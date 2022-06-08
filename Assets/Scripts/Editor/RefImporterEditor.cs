using UnityEditor;
using UnityEditor.AssetImporters;
using UnityEngine;

[CustomEditor(typeof(IMP_REF))]
public class RefImporterEditor : ScriptedImporterEditor
{
    public override void OnInspectorGUI()
    {
        var ram = new GUIContent("RAM");
        var prop = serializedObject.FindProperty("ram");
        EditorGUILayout.PropertyField(prop, ram);
        base.ApplyRevertGUI();
    }
}
