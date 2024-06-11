using UnityEngine;
using UnityEngine.Events;

namespace FisipGroup.CustomPackage.Tools.EditorTool
{
    public class EditorToolOnAwakeEvent : MonoBehaviour
    {
        [SerializeField] private UnityEvent OnAwake;

        private void Awake()
        {
            OnAwake?.Invoke();
        }
    }
}