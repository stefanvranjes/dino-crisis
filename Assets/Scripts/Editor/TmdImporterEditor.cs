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
        var clutReference = new GUIContent("CLUT");
        var prop3 = serializedObject.FindProperty("clut");
        EditorGUILayout.PropertyField(prop3, clutReference);
        base.ApplyRevertGUI();
    }
}
