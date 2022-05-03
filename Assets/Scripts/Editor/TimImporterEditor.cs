using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

[CustomEditor(typeof(IMP_TIM))]
public class TimImporterEditor : ScriptedImporterEditor
{
    public override void OnInspectorGUI()
    {
        var clutReference = new GUIContent("CLUT");
        var prop = serializedObject.FindProperty("clut");
        EditorGUILayout.PropertyField(prop, clutReference);
        base.ApplyRevertGUI();
    }
}
