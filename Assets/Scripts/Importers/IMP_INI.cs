using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "ini")]
public class IMP_INI : ScriptedImporter
{
    public uint ramAddress;
    public int size;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            IniScriptableObject ini = ScriptableObject.CreateInstance("IniScriptableObject") as IniScriptableObject;

            List<SoundData> list = new List<SoundData>();
            ini.ADDR = ramAddress;
            ini.SIZE = size;

            while (reader.Position < size)
            {
                SoundData snd = new SoundData();
                snd.DAT_00 = reader.ReadByte();
                snd.DAT_01 = reader.ReadByte();
                snd.DAT_02 = reader.ReadByte();
                snd.DAT_03 = reader.ReadByte();
                list.Add(snd);
            }

            ini.DATA = list.ToArray();
            ctx.AddObjectToAsset("ini", ini);
            ctx.SetMainObject(ini);
        }
    }
}
