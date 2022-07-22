using System.IO;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor.AssetImporters;
#endif
using UnityEngine;

#if UNITY_EDITOR
[ScriptedImporter(1, "mot")]
public class IMP_MOT : ScriptedImporter
{
    public ScnScriptableObject scn;

    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            if (scn != null)
            {
                SceneCameraScriptableObject mot = ScriptableObject.CreateInstance("SceneCameraScriptableObject") as SceneCameraScriptableObject;

                int length = reader.ReadInt32();
                mot.MOTIONS = new CameraMotion[length];

                for (int i = 0; i < length; i++)
                {
                    CameraMotion m = new CameraMotion();
                    m.DAT_00 = reader.ReadByte();
                    m.DAT_01 = reader.ReadByte();
                    m.DAT_02 = reader.ReadByte();
                    m.DAT_03 = reader.ReadByte();
                    m.DAT_04 = new Vector2Int[4];
                    m.DAT_04[0] = reader.ReadSVector2();
                    m.DAT_04[1] = reader.ReadSVector2();
                    m.DAT_04[2] = reader.ReadSVector2();
                    m.DAT_04[3] = reader.ReadSVector2();
                    reader.Seek(0x10, SeekOrigin.Current);
                    m.DAT_24 = reader.ReadByte();
                    m.DAT_25 = reader.ReadByte();
                    m.DAT_26 = reader.ReadByte();
                    m.DAT_27 = reader.ReadByte();
                    reader.Seek(4, SeekOrigin.Current);
                    m.DAT_2C = reader.ReadSVector();
                    m.DAT_32 = reader.ReadInt16();
                    m.DAT_34 = reader.ReadSVector();
                    reader.Seek(2, SeekOrigin.Current);
                    m.DAT_3C = reader.ReadSVector();
                    reader.Seek(2, SeekOrigin.Current);
                    //FeedPostprocessor(m.DAT_02);
                    mot.MOTIONS[i] = m;
                }

                ctx.AddObjectToAsset("mot", mot);
                ctx.SetMainObject(mot);
            }
        }
    }
}
#endif