using System.IO;
using UnityEngine;
using UnityEditor;

public class MenuItems
{
    private static string defaultOpenPath = "";
    private static string defaultSavePath = "";
    private static string defaultOpenPath2 = "";
    private static string defaultSavePath2 = "";

    [MenuItem("Tools/Export DAT")]
    private static void ExportDAT()
    {
        string file = EditorUtility.OpenFilePanel("Open .DAT file to extract asset", defaultOpenPath, "DAT");
        string ram = EditorUtility.OpenFilePanel("Open .RAM file", defaultSavePath, "");
        defaultOpenPath = Path.GetDirectoryName(file);
        defaultSavePath = Path.GetDirectoryName(ram);
        string save = EditorUtility.SaveFolderPanel("Save location", defaultSavePath, "");
        defaultSavePath = Path.GetDirectoryName(save);

        if (ram.StartsWith(Application.dataPath))
            ram = "Assets" + ram.Substring(Application.dataPath.Length);

        EXP_DAT.RAM = AssetDatabase.LoadAssetAtPath(ram, typeof(RamScriptableObject)) as RamScriptableObject;

        EXP_DAT.ExtractDAT(file, save);
    }

    [MenuItem("Tools/Export SCN")]
    private static void ExportSCN()
    {
        string file = EditorUtility.OpenFilePanel("Open file to extract asset", defaultOpenPath2, "");
        string ram = EditorUtility.OpenFilePanel("Open .RAM file", defaultSavePath2, "");
        defaultOpenPath2 = Path.GetDirectoryName(file);
        defaultSavePath2 = Path.GetDirectoryName(ram);
        string save = EditorUtility.SaveFolderPanel("Save location", defaultSavePath2, "");
        defaultSavePath2 = Path.GetDirectoryName(save);

        if (ram.StartsWith(Application.dataPath))
            ram = "Assets" + ram.Substring(Application.dataPath.Length);

        EXP_DAT.RAM = AssetDatabase.LoadAssetAtPath(ram, typeof(RamScriptableObject)) as RamScriptableObject;

        EXP_SCN.ExtractSCN(file, save);
    }
}
