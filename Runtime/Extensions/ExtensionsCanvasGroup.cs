// Ignore Spelling: Fisip

using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.Extensions
{
    /// <summary>
    /// CanvasGroup component extensions.
    /// </summary>
    public static class ExtensionsCanvasGroup
    {
        /// <summary>
        /// Set canvas group visibility.
        /// </summary>
        /// <param name="group"></param>
        /// <param name="visible"></param>
        public static void SetVisibility(this CanvasGroup group, bool visible)
        {
            if(group == null)
            {
                NullCanvasGroupWarningMessage();

                return;
            }

            group.alpha = visible ? 1f : 0f;
            group.interactable = visible;
            group.blocksRaycasts = visible;
        }

        private static void NullCanvasGroupWarningMessage()
        {
            Debug.LogWarning("FisipGroup.CustomPackage.Tools.Extensions.ExtensionsCanvasGroup: " +
                "CanvasGroup is null, returning...");
        }
    }
}