using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

[CustomEditor(typeof(IMP_TOD))]
public class TodImporterEditor : ScriptedImporterEditor
{
    public override void OnInspectorGUI()
    {
        var ramAddress = new GUIContent("RAM");
        var prop1 = serializedObject.FindProperty("ramAddress");
        EditorGUILayout.PropertyField(prop1, ramAddress);
        var boneCount = new GUIContent("BONES");
        var prop2 = serializedObject.FindProperty("boneCount");
        EditorGUILayout.PropertyField(prop2, boneCount);
        base.ApplyRevertGUI();
    }
}
