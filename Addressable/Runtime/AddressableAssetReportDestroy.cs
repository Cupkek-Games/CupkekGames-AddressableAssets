#if UNITY_ADDRESSABLES
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace CupkekGames.AddressableAssets
{
  public class AddressableAssetReportDestroy : MonoBehaviour
  {
    private AssetReference _assetReference;

    // Who made this instance (AddressableAssetManager.ReleaseInstances); null: no one in particular.
    internal object Owner { get; set; }

    private void OnDestroy()
    {
      if (_assetReference != null)
      {
        AddressableAssetManager.ReportDestroy(_assetReference, gameObject);
      } else {
        Debug.LogError("AddressableAssetReportDestroy is not set");
      }
    }

    public void SetAssetReference(AssetReference assetReference)
    {
      _assetReference = assetReference;
    }
    
    /// <summary>
    /// Checks if the asset reference is already set.
    /// </summary>
    /// <returns>True if the asset reference is set, false otherwise.</returns>
    public bool HasAssetReference()
    {
      return _assetReference != null;
    }
  }
}
#endif
