
#if UNITY_ADDRESSABLES && UNITY_EDITOR
using CupkekGames.Luna;
using CupkekGames.AddressableAssets.Editor;
using CupkekGames.Services.Editor;
using UnityEditor;

namespace CupkekGames.AddressableAssets.UI.Editor
{
    [CustomEditor(typeof(UIPrefabLoaderAddressableString), true)]
    public class UIPrefabLoaderAddressableStringEditor : PrefabLoaderAddressableEditor<string, UIViewComponent>
    {
        public override string GetKeyFromFileName(string name)
        {
            return name;
        }
    }
}
#endif