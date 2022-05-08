using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

[CustomEditor(typeof(IMP_TMD))]
public class TmdImporterEditor : ScriptedImporterEditor
{
    public override void OnInspectorGUI()
    {
        var ramAddress = new GUIContent("RAM");
        var prop1 = serializedObject.FindProperty("ramAddress");
        EditorGUILayout.PropertyField(prop1, ramAddress);
        var gridReference = new GUIContent("GRID");
        var prop2 = serializedObject.FindProperty("grid");
        EditorGUILayout.PropertyField(prop2, gridReference);
        var texReference = new GUIContent("TIM");
        var prop3 = serializedObject.FindProperty("mainT");
        EditorGUILayout.PropertyField(prop3, texReference);
        base.ApplyRevertGUI();
    }
}
