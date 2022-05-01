using UnityEditor;

using UnityEngine;
using System.IO;
using System.Collections;
using System.Collections.Generic;

public static class MeshSaverEditor
{
    private static string previousPath = "";

    [MenuItem("CONTEXT/MeshFilter/Import LZSS")]
    public static void ImportTMD(MenuCommand menuCommand)
    {
        MeshFilter mf = menuCommand.context as MeshFilter;
        string path = EditorUtility.OpenFilePanel("Open .lzss file to import mesh data", previousPath, "lzss");
        previousPath = Path.GetDirectoryName(path);
        Material mat = mf.GetComponent<MeshRenderer>().sharedMaterial;
        Texpage p = mf.GetComponent<Texpage>();
        Mesh m = IMP_LZSS.LoadAsset2(path, mat, p);
        m.name = "newGeo";
        mf.sharedMesh = m;
    }

    [MenuItem("CONTEXT/MeshFilter/Save Mesh...")]
    public static void SaveMeshInPlace(MenuCommand menuCommand)
    {
        MeshFilter mf = menuCommand.context as MeshFilter;
        Mesh m = mf.sharedMesh;
        SaveMesh(m, m.name, false, true);
    }

    [MenuItem("CONTEXT/MeshFilter/Save Mesh As New Instance...")]
    public static void SaveMeshNewInstanceItem(MenuCommand menuCommand)
    {
        MeshFilter mf = menuCommand.context as MeshFilter;
        Mesh m = mf.sharedMesh;
        SaveMesh(m, m.name, true, true);
    }

    public static void SaveMesh(Mesh mesh, string name, bool makeNewInstance, bool optimizeMesh)
    {
        string path = EditorUtility.SaveFilePanel("Save Separate Mesh Asset", "Assets/", name, "asset");
        if (string.IsNullOrEmpty(path)) return;

        path = FileUtil.GetProjectRelativePath(path);

        Mesh meshToSave = (makeNewInstance) ? Object.Instantiate(mesh) as Mesh : mesh;

        if (optimizeMesh)
            MeshUtility.Optimize(meshToSave);

        AssetDatabase.CreateAsset(meshToSave, path);
        AssetDatabase.SaveAssets();
    }

}
