using System.IO;
#if UNITY_EDITOR
using UnityEditor.AssetImporters;
#endif
using UnityEngine;

#if UNITY_EDITOR
[ScriptedImporter(1, "tod")]
public class IMP_TOD : ScriptedImporter
{
    public uint ramAddress;
    public int boneCount;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            TodScriptableObject tod = ScriptableObject.CreateInstance("TodScriptableObject") as TodScriptableObject;

            if (boneCount != 0)
            {
                tod.PACKET_OFFSET = reader.ReadUInt32() - ramAddress;
                tod.FRAME_COUNT = reader.ReadInt32();
                tod.FRAMES = new Frame[tod.FRAME_COUNT + 1];
                int packetCount = 0;

                for (int i = 0; i < tod.FRAME_COUNT + 1; i++)
                {
                    Frame f = new Frame();
                    f.DAT_00 = reader.ReadByte();
                    f.DAT_01 = reader.ReadByte();
                    f.DAT_02 = reader.ReadByte();
                    f.DAT_03 = reader.ReadByte();
                    tod.FRAMES[i] = f;

                    if (f.DAT_01 >= packetCount)
                        packetCount = f.DAT_01 + 1;
                }

                tod.PACKETS = new Packet[packetCount];

                for (int i = 0; i < packetCount; i++)
                {
                    Packet p = new Packet();
                    p.DAT_00 = reader.ReadSVector();
                    p.DAT_06 = reader.ReadSVector();
                    p.COMP = new uint[(uint)boneCount * 0x24 + 0x1f >> 5];

                    for (int j = 0; j < p.COMP.Length; j++)
                        p.COMP[j] = reader.ReadUInt32();

                    tod.PACKETS[i] = p;
                }
            }

            ctx.AddObjectToAsset("tod", tod);
            ctx.SetMainObject(tod);
        }
    }
}
#endif