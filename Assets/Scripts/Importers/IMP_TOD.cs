using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1, "tod")]
public class IMP_TOD : ScriptedImporter
{
    public uint ramAddress;
    public Tmd2ScriptableObject tmd;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            if (tmd != null)
            {
                TodScriptableObject tod = ScriptableObject.CreateInstance("TodScriptableObject") as TodScriptableObject;

                tod.PACKET_OFFSET = reader.ReadUInt32() - ramAddress;
                tod.FRAME_COUNT = reader.ReadInt32();
                tod.FRAMES = new Frame[tod.FRAME_COUNT + 1];
                tod.PACKETS = new Packet[tod.FRAME_COUNT + 1];

                for (int i = 0; i < tod.FRAME_COUNT + 1; i++)
                {
                    Frame f = new Frame();
                    f.DAT_00 = reader.ReadByte();
                    f.DAT_01 = reader.ReadByte();
                    f.DAT_02 = reader.ReadByte();
                    f.DAT_03 = reader.ReadByte();
                    tod.FRAMES[i] = f;
                }

                for (int i = 0; i < tod.FRAME_COUNT + 1; i++)
                {
                    Packet p = new Packet();
                    p.DAT_00 = reader.ReadSVector();
                    p.DAT_06 = reader.ReadSVector();
                    p.COMP = new uint[(uint)tmd.BONE_COUNT * 0x24 + 0x1f >> 5];

                    for (int j = 0; j < p.COMP.Length; j++)
                        p.COMP[j] = reader.ReadUInt32();

                    tod.PACKETS[i] = p;
                }

                ctx.AddObjectToAsset("tod", tod);
                ctx.SetMainObject(tod);
            }
        }
    }
}
