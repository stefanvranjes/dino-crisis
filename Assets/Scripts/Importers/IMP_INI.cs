using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "ini")]
public class IMP_INI : ScriptedImporter
{
    public uint ramAddress;
    public uint size;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            IniScriptableObject ini = ScriptableObject.CreateInstance("IniScriptableObject") as IniScriptableObject;

            List<SoundData> list = new List<SoundData>();
            ini.ADDR = ramAddress;
            ini.SIZE = size;
            ini.DATA = new SoundData[ini.SIZE / 4];

            for (int i = 0; i < ini.DATA.Length; i++)
            {
                SoundData snd = new SoundData();
                snd.DAT_00 = reader.ReadByte();
                snd.DAT_01 = reader.ReadByte();
                snd.DAT_02 = reader.ReadByte();
                snd.DAT_03 = reader.ReadByte();
                ini.DATA[i] = snd;
            }

            ctx.AddObjectToAsset("ini", ini);
            ctx.SetMainObject(ini);
        }
    }
}
