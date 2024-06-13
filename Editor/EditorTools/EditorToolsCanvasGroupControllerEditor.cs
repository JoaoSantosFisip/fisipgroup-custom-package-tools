using UnityEditor;
using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.EditorTool
{
    /// <summary>
    /// Custom editor for EditorToolsCanvasGroup.cs script
    /// Adds 2 buttons to help turn on/off the canvas controller visibility.
    /// </summary>
    [CustomEditor(typeof(EditorToolCanvasGroupController))]
    public class EditorToolsCanvasGroupControllerEditor : Editor
    {
        /// <summary>
        /// Creates 2 buttons to control CanvasGroup visibility
        /// </summary>
        public override void OnInspectorGUI()
        {
            // Get the target object
            var controller = (EditorToolCanvasGroupController)target;

            // Custom Inspector UI
            EditorGUILayout.LabelField("CanvasGroup Visibility:", EditorStyles.boldLabel);

            EditorGUILayout.BeginHorizontal();

            if (GUILayout.Button("Show"))
            {
                controller.SetVisibility(true);
            }
            if (GUILayout.Button("Hide"))
            {
                controller.SetVisibility(false);
            }

            EditorGUILayout.EndHorizontal();
        }
    }
}