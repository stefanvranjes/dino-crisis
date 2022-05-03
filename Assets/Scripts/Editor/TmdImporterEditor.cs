using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

[CustomEditor(typeof(IMP_TMD))]
public class TmdImporterEditor : ScriptedImporterEditor
{
    public override void OnInspectorGUI()
    {
        var gridReference = new GUIContent("GRID");
        var prop1 = serializedObject.FindProperty("grid");
        EditorGUILayout.PropertyField(prop1, gridReference);
        var texReference = new GUIContent("TIM");
        var prop2 = serializedObject.FindProperty("mainT");
        EditorGUILayout.PropertyField(prop2, texReference);
        base.ApplyRevertGUI();
    }
}
