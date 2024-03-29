using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

#if UNITY_EDITOR
public class TmdPostprocessor : AssetPostprocessor
{
    public static bool script;
    public static uint address;

    private void OnPreprocessAsset()
    {
        if (assetImporter.importSettingsMissing)
        {
            IMP_TMD tmdImporter = assetImporter as IMP_TMD;

            if (tmdImporter != null && script)
            {
                tmdImporter.ramAddress = address;
            }
        }
    }
}
#endif
