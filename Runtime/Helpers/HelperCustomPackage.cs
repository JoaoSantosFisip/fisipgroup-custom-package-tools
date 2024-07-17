using UnityEditor;
using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.Helpers
{
    /// <summary>
    /// Helper for custom package related issues.
    /// </summary>
    public static class HelperCustomPackage
    {
        /// <summary>
        /// Creates custom packages 
        /// </summary>
        /// <param name="packageName"></param>
        public static void CreateResourcesFolders(string packageName)
        {
#if UNITY_EDITOR
            // Create Resources folder.
            if (!AssetDatabase.IsValidFolder("Assets/Resources"))
            {
                AssetDatabase.CreateFolder("Assets", "Resources");

                Debug.LogWarning("Created Resources folder");
            }

            // Create CustomPackage folder.
            if (!AssetDatabase.IsValidFolder("Assets/Resources/CustomPackage"))
            {
                AssetDatabase.CreateFolder("Assets/Resources", "CustomPackage");

                Debug.LogWarning("Created CustomPackage folder");
            }

            // Create Addressables folder.
            if (!AssetDatabase.IsValidFolder("Assets/Resources/CustomPackage/" + packageName))
            {
                AssetDatabase.CreateFolder("Assets/Resources/CustomPackage", packageName);

                Debug.LogWarning("Created Addressables folder");
            }
#endif
        }
        /// <summary>
        /// Returns info file, use: variable = GetInfoFile<ScriptableObjectType>(packageName) as ScriptableObjectType;.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="packageName"></param>
        /// <returns></returns>
        public static ScriptableObject GetInfoFile<T>(string packageName)
        {
            var info = Resources.Load<ScriptableObject>($"CustomPackage/{packageName}/Info");

            if (info != null)
            {
                return info;
            }

            info = ScriptableObject.CreateInstance(typeof(T));
#if UNITY_EDITOR
            AssetDatabase.CreateAsset(info, GetInfoFilePath(packageName));
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
#endif
            return info;
        }
        /// <summary>
        /// Saves info file, use: variable = SaveFileChanges(infoSO, packageName) as ScriptableObjectType;.
        /// </summary>
        /// <param name="packageName"></param>
        public static ScriptableObject SaveFileChanges(ScriptableObject info, string packageName)
        {
            // AssetDatabse.SaveAssets and AssetDatabase.Refresh weren't staging changes on git
            // So we are creating a new file and deleting the old one as a fix
            var path = GetInfoFilePath(packageName);

#if UNITY_EDITOR
            AssetDatabase.DeleteAsset(path);
            AssetDatabase.CreateAsset(info, path);
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
#endif

            return info;
        }
        /// <summary>
        /// Returns the path for the info file.
        /// </summary>
        /// <param name="packageName"></param>
        /// <returns></returns>
        private static string GetInfoFilePath(string packageName)
        {
            return $"Assets/Resources/CustomPackage/{packageName}/Info.asset";
        }
    }
}