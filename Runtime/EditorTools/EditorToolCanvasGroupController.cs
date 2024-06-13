using FisipGroup.CustomPackage.Tools.Extensions;
using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.EditorTool
{
    /// <summary>
    /// Script to easily control the canvas group visibility via editor.
    /// </summary>
    [RequireComponent(typeof(CanvasGroup))]
    public class EditorToolCanvasGroupController : MonoBehaviour
    {
        private CanvasGroup _group;

        private void Awake()
        {
            _group = GetComponent<CanvasGroup>();
        }

        public void SetVisibility(bool visible)
        {
#if UNITY_EDITOR
            GetComponent<CanvasGroup>().SetVisibility(visible);

            return;
#endif

            _group.SetVisibility(visible);
        }
    }
}