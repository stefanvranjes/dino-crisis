using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "gian")]
public class IMP_GIAN : ScriptedImporter
{
    public int index;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            string identifier = new string(System.Text.Encoding.UTF8.GetChars(reader.ReadBytes(4)));

            if (identifier == "Gian")
            {
                GianScriptableObject gian = ScriptableObject.CreateInstance("GianScriptableObject") as GianScriptableObject;
            
                List<SpuVoiceAttr> list = new List<SpuVoiceAttr>();
                gian.INDEX = index;
                reader.Seek(0x90, SeekOrigin.Begin);
                
                while(reader.Position < reader.Length)
                {
                    SpuVoiceAttr attr = new SpuVoiceAttr();
                    reader.Seek(1, SeekOrigin.Current);
                    attr.FLAGS = reader.ReadByte();
                    attr.DAT_02 = reader.ReadByte();
                    attr.DAT_03 = reader.ReadByte();
                    attr.SAMPLE_NOTE = reader.ReadByte();
                    attr.NOTE = reader.ReadByte();
                    reader.Seek(10, SeekOrigin.Current);
                    attr.ADSR1 = reader.ReadUInt16();
                    attr.ADSR2 = reader.ReadUInt16();
                    reader.Seek(2, SeekOrigin.Current);
                    attr.ADDR = reader.ReadUInt16();
                    list.Add(attr);
                }

                gian.ATTRS = list.ToArray();
                ctx.AddObjectToAsset("gian", gian);
                ctx.SetMainObject(gian);
            }
        }
    }
}
