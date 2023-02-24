using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class IniPostprocessor : AssetPostprocessor
{
    public static bool script;
    public static uint address;
    public static uint size;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_INI iniImporter = assetImporter as IMP_INI;

            if (iniImporter != null && script)
            {
                iniImporter.ramAddress = address;
                iniImporter.size = size;
            }
        }
    }
}
