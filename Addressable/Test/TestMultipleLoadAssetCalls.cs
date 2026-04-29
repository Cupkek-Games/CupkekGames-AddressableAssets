#if UNITY_ADDRESSABLES
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace CupkekGames.AddressableAssets.Test
{
    public class TestMultipleLoadAssetCalls : MonoBehaviour
    {
        [SerializeField] private AssetReference _assetReference;
        [SerializeField] private int _callAmount;

        private void Awake()
        {
            AddressableAssetManager.Test = true;

            for (int i = 0; i < _callAmount; i++) {
                AddressableAssetManager.LoadAsset<GameObject>(_assetReference);
            }
        }
    }
}
#endif 