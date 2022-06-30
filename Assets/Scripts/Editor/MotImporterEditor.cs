using UnityEditor.AssetImporters;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(IMP_MOT))]
public class MotImporterEditor : AssetImporterEditor
{
    public override void OnInspectorGUI()
    {
        var scn = new GUIContent("SCN");
        var prop = serializedObject.FindProperty("scn");
        EditorGUILayout.PropertyField(prop, scn);
        base.ApplyRevertGUI();
    }
}
