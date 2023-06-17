using System.IO;
using UnityEngine;
using UnityEditor.AssetImporters;

[ScriptedImporter(1, "tod3")]
public class IMP_TOD3 : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            Tod3ScriptableObject tod3 = ScriptableObject.CreateInstance("Tod3ScriptableObject") as Tod3ScriptableObject;

            int length = buffer.Length / 0x20;
            tod3.FRAMES = new Frame3[length];

            for (int i = 0; i < length; i++)
            {
                Frame3 f = new Frame3();
                f.DAT_00 = reader.ReadByte();
                reader.Seek(3, SeekOrigin.Current);
                f.FRAME_NUM = reader.ReadUInt32();
                reader.Seek(4, SeekOrigin.Current);
                f.DAT_0C = reader.ReadUInt16();
                f.POSITION = reader.ReadSVector();
                reader.Seek(2, SeekOrigin.Current); //padding
                f.VELOCITY = reader.ReadSVector();
                reader.Seek(4, SeekOrigin.Current); //padding
                tod3.FRAMES[i] = f;
            }

            ctx.AddObjectToAsset("tod3", tod3);
            ctx.SetMainObject(tod3);
        }
    }
}
