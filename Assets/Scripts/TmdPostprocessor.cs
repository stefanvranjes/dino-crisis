using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TmdPostprocessor : AssetPostprocessor
{
    public static bool script;
    public static uint address;
    public static GridScriptableObject grid;
    public static Texture2D tim;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_TMD tmdImporter = assetImporter as IMP_TMD;

            if (tmdImporter != null && script)
            {
                tmdImporter.ramAddress = address;
                tmdImporter.grid = grid;
                tmdImporter.mainT = tim;
            }
        }
    }
}
