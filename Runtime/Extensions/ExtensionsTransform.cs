using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.Extensions
{
    /// <summary>
    /// Transform component extensions.
    /// </summary>
    public static class ExtensionsTransform
    {
        /// <summary>
        /// Destroy all the transform's children.
        /// </summary>
        /// <param name="current"></param>
        /// <returns></returns>
        public static Transform DestroyChildren(this Transform current)
        {
            if(current == null)
            {
                NullTransformWarningMessage();

                return null;
            }

            for (int i = current.childCount - 1; i >= 0; i--)
            {
                Object.DestroyImmediate(current.GetChild(i).gameObject);
            }

            return current;
        }

        private static void NullTransformWarningMessage()
        {
            Debug.LogWarning("FisipGroup.CustomPackage.Tools.Extensions.ExtensionsTransform: " +
                "Transform is null, returning...");
        }
    }
}