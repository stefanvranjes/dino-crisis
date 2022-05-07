using System.IO;
using UnityEngine;
using UnityEditor;

public class MenuItems
{
    private static string defaultOpenPath = "";
    private static string defaultSavePath = "";

    [MenuItem("Tools/Export DAT")]
    private static void ExportDAT()
    {
        string file = EditorUtility.OpenFilePanel("Open .DAT file to extract asset", defaultOpenPath, "DAT");
        string save = EditorUtility.SaveFolderPanel("Save location", defaultSavePath, "");
        defaultOpenPath = Path.GetDirectoryName(file);
        defaultSavePath = Path.GetDirectoryName(save);

        EXP_DAT.ExtractDAT(file, save);
    }
}
