using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class TodPostprocessor : AssetPostprocessor
{
    public static bool script;
    public static uint address;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_TOD todImporter = assetImporter as IMP_TOD;

            if (todImporter != null && script)
            {
                todImporter.ramAddress = address;
            }
        }
    }
}
