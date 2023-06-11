using System.IO;
#if UNITY_EDITOR
using UnityEditor.AssetImporters;
#endif
using UnityEngine;

#if UNITY_EDITOR
[ScriptedImporter(1, "cln")]
public class IMP_CLN : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            SceneColliderScriptableObject cln = ScriptableObject.CreateInstance("SceneColliderScriptableObject") as SceneColliderScriptableObject;

            int length = 17;
            cln.WALL_SEGMENTS = new WallSegment[length];

            for (int i = 0; i < length; i++)
            {
                reader.Seek(i * 0x10, SeekOrigin.Begin);
                WallSegment seg = new WallSegment();
                seg.WALL_COUNT = reader.ReadByte(1);
                seg.WALL_OFFSET = reader.ReadUInt32(8);
                seg.WALL_COLLIDERS = new WallCollider[seg.WALL_COUNT];
                reader.Seek(0x110 + seg.WALL_OFFSET, SeekOrigin.Begin);

                for (int j = 0; j < seg.WALL_COUNT; j++)
                {
                    WallCollider col = new WallCollider();
                    col.DAT_00 = reader.ReadByte();
                    col.DAT_01 = reader.ReadByte();
                    col.DAT_02 = reader.ReadByte();
                    col.DAT_03 = reader.ReadByte();
                    col.DAT_04 = reader.ReadSVector2();
                    col.DAT_08 = reader.ReadSVector2();
                    col.flags = reader.ReadUInt16();
                    seg.WALL_COLLIDERS[j] = col;
                    reader.Seek(2, SeekOrigin.Current);
                }

                cln.WALL_SEGMENTS[i] = seg;
            }

            cln.FLOOR_SEGMENT = new FloorSegment[length];

            for (int i = 0; i < length; i++)
            {
                reader.Seek(i * 0x10, SeekOrigin.Begin);
                FloorSegment seg = new FloorSegment();
                seg.FLOOR_COUNT = reader.ReadByte(0);
                seg.FLOOR_OFFSET = reader.ReadUInt32(4);
                seg.FLOOR_COLLIDERS = new FloorCollider[seg.FLOOR_COUNT];
                reader.Seek(0x110 + seg.FLOOR_OFFSET, SeekOrigin.Begin);

                for (int j = 0; j < seg.FLOOR_COUNT; j++)
                {
                    FloorCollider col = new FloorCollider();
                    col.DAT_00 = reader.ReadByte(0);
                    col.DAT_01 = reader.ReadByte(1);
                    col.DAT_04 = new Vector2Int[4];
                    col.DAT_04[0] = reader.ReadSVector2(4);
                    col.DAT_04[1] = reader.ReadSVector2(8);
                    col.DAT_04[2] = reader.ReadSVector2(12);
                    col.DAT_04[3] = reader.ReadSVector2(16);
                    seg.FLOOR_COLLIDERS[j] = col;
                    reader.Seek(0x14, SeekOrigin.Current);
                }

                cln.FLOOR_SEGMENT[i] = seg;
            }

            ctx.AddObjectToAsset("cln", cln);
            ctx.SetMainObject(cln);
        }
    }
}
#endif