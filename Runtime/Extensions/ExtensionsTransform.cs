using System.Collections.Generic;
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
        /// <param name="transform"></param>
        /// <returns></returns>
        public static Transform DestroyChildren(this Transform transform)
        {
            if(transform == null)
            {
                NullTransformWarningMessage();

                return null;
            }

            for (int i = transform.childCount - 1; i >= 0; i--)
            {
                Object.DestroyImmediate(transform.GetChild(i).gameObject);
            }

            return transform;
        }

        /// <summary>
        /// Get's components in children excluding self.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T[] GetComponentsInChildrenExclusive<T>(this Transform transform)
        {
            if (transform == null)
            {
                NullTransformWarningMessage();

                return null;
            }

            var components = new List<T>();

            for(int i = 0; i < transform.childCount; i++)
            {
                if(transform.GetChild(i).TryGetComponent(out T childrenComponent))
                {
                    components.Add(childrenComponent);
                }
            }

            return components.ToArray();
        }
        

        private static void NullTransformWarningMessage()
        {
            Debug.LogWarning("FisipGroup.CustomPackage.Tools.Extensions.ExtensionsTransform: " +
                "Transform is null, returning...");
        }
    }
}