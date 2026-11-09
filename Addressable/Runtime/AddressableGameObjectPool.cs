#if UNITY_ADDRESSABLES
using UnityEngine;
using UnityEngine.AddressableAssets;
using CupkekGames.Pool;

namespace CupkekGames.AddressableAssets
{
    public class AddressableGameObjectPool : GameObjectPoolBase
    {
        private AssetReference _assetReference;

        public AddressableGameObjectPool(AssetReference assetReference, int defaultCapacity, int maxSize, bool prewarm = true, bool collectionCheck = true) 
            : base(defaultCapacity, maxSize, collectionCheck)
        {
            _assetReference = assetReference;

            if (prewarm)
            {
                Prewarm();
                // Debug.Log($"Created Addressable GameObject pool for {assetReference} with {Pool.CountAll} objects");
            }
        }

        public override GameObject CreateObject()
        {
            return AddressableAssetManager.InstantiateSync(_assetReference, owner: this);
        }

        public void Dispose()
        {   
            Pool.Dispose();
            
            // This pool's instances only; other holders of the asset keep theirs.
            if (_assetReference != null)
            {
                AddressableAssetManager.ReleaseInstances(_assetReference, this);
            }
        }
    }
}
#endif 