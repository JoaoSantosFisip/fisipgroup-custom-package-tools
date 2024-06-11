using UnityEngine;
using UnityEngine.Events;

namespace FisipGroup.CustomPackage.Tools.EditorTool
{
    public class EditorToolOnStartEvent : MonoBehaviour
    {
        [SerializeField] private UnityEvent OnStart;

        private void Start()
        {
            OnStart?.Invoke();
        }
    }
}