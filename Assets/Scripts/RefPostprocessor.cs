using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class RefPostprocessor : AssetPostprocessor
{
    public static bool script;
    public static RamScriptableObject[] ram;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_REF refImporter = assetImporter as IMP_REF;

            if (refImporter != null && script)
            {
                refImporter.ram = ram;
            }
        }
    }
}
