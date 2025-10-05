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

    [MenuItem("Tools/Export ITEM")]
    private static void ExportITEM()
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
        EXP_DAT.ExtractITEM(file, save);
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

    [MenuItem("Tools/Export COMMON")]
    private static void ExportCOMMON()
    {
        string file1 = EditorUtility.OpenFilePanel("Open file to read from", defaultOpenPath, "");
        defaultOpenPath = Path.GetDirectoryName(file1);
        string file2 = EditorUtility.OpenFilePanel("Open file to write from", defaultOpenPath, "");
        string ram = EditorUtility.OpenFilePanel("Open .RAM file", defaultSavePath, "");
        defaultSavePath = Path.GetDirectoryName(ram);
        string save = EditorUtility.SaveFolderPanel("Save location", defaultSavePath, "");
        defaultSavePath = Path.GetDirectoryName(save);

        if (ram.StartsWith(Application.dataPath))
            ram = "Assets" + ram.Substring(Application.dataPath.Length);

        EXP_CMN.RAM = AssetDatabase.LoadAssetAtPath(ram, typeof(RamScriptableObject)) as RamScriptableObject;
        EXP_CMN.ExtractCOMMON(file1, file2, save);
    }

    [MenuItem("Tools/Export DOOR")]
    private static void ExportDOOR()
    {
        string file = EditorUtility.OpenFilePanel("Open file to read from", defaultOpenPath2, "");
        defaultOpenPath2 = Path.GetDirectoryName(file);
        string ram = EditorUtility.OpenFilePanel("Open .RAM file", defaultOpenPath2, "");
        defaultSavePath = Path.GetDirectoryName(ram);
        string save = EditorUtility.SaveFolderPanel("Save location", defaultSavePath, "");
        defaultSavePath = Path.GetDirectoryName(save);

        EXP_DOOR.ExtractDOOR(file, ram, save);
    }
}
