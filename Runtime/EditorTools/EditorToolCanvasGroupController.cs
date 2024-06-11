using FisipGroup.CustomPackage.Tools.Extensions;
using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.EditorTool
{
    public class EditorToolCanvasGroupController : MonoBehaviour
    {
        private CanvasGroup _group;

        private void Awake()
        {
            _group = GetComponent<CanvasGroup>();
        }

        public void SetVisibility(bool visible)
        {
            _group.SetVisibility(visible);
        }

        [ContextMenu("Set Visible")]
        private void SetVisibile()
        {
            _group.SetVisibility(true);
        }
        [ContextMenu("Set Hidden")]
        private void SetHidden()
        {
            _group.SetVisibility(false);
        }
    }
}