using UnityEditor;
using UnityEngine;

namespace FisipGroup.CustomPackage.Tools.EditorTool
{
    /// <summary>
    /// Preset styles to keep editor windows appearence consistent.
    /// </summary>
    public class EditorWindowStyles : Editor
    {
        public static GUIStyle TitleStyle = new(GUI.skin.box)
        {
            fontSize = 20,
            fontStyle = FontStyle.Bold
        };
        public static GUIStyle SectionStyle = new(GUI.skin.box)
        {
            fontSize = 15,
            fontStyle = FontStyle.Bold
        };
        public static GUIStyle InputTextStyle = new(GUI.skin.textArea)
        {
            fontSize = 15,
            wordWrap = false
        };
        public static GUIStyle SmallTextStyle = new(GUI.skin.box)
        {
            fontSize = 12,
            fontStyle = FontStyle.Bold
        };
    }
}