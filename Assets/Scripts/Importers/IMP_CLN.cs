using System.IO;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1, "cln")]
public class IMP_CLN : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            SceneColliderScriptableObject cln = ScriptableObject.CreateInstance("SceneColliderScriptableObject") as SceneColliderScriptableObject;

            int wallLength = 0;

            while(reader.ReadByte(1) != 0)
            {
                wallLength++;
                reader.Seek(0x10, SeekOrigin.Current);
            }

            reader.Seek(0, SeekOrigin.Begin);
            cln.WALL_SEGMENTS = new WallSegment[wallLength];

            for (int i = 0; i < wallLength; i++)
            {
                reader.Seek(i * 0x10, SeekOrigin.Begin);
                WallSegment seg = new WallSegment();
                seg.WALL_COUNT = reader.ReadByte(1);
                seg.WALL_OFFSET = reader.ReadUInt32(8);
                seg.WALL_COLLIDERS = new WallCollider[seg.WALL_COUNT];
                long pos = reader.Position;
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

            reader.Seek(wallLength * 0x10, SeekOrigin.Begin);
            cln.FLOOR_SEGMENT = new FloorSegment();
            cln.FLOOR_SEGMENT.FLOOR_COUNT = reader.ReadByte(0);
            cln.FLOOR_SEGMENT.FLOOR_OFFSET = reader.ReadUInt32(4);
            cln.FLOOR_SEGMENT.FLOOR_COLLIDERS = new FloorCollider[cln.FLOOR_SEGMENT.FLOOR_COUNT];
            reader.Seek(cln.FLOOR_SEGMENT.FLOOR_OFFSET + 0x110, SeekOrigin.Begin);

            for (int i = 0; i < cln.FLOOR_SEGMENT.FLOOR_COUNT; i++)
            {
                FloorCollider col = new FloorCollider();
                col.DAT_00 = reader.ReadByte(0);
                col.DAT_01 = reader.ReadByte(1);
                col.DAT_04 = new Vector2Int[4];
                col.DAT_04[0] = reader.ReadSVector2(4);
                col.DAT_04[1] = reader.ReadSVector2(8);
                col.DAT_04[2] = reader.ReadSVector2(12);
                col.DAT_04[3] = reader.ReadSVector2(16);
                cln.FLOOR_SEGMENT.FLOOR_COLLIDERS[i] = col;
                reader.Seek(0x14, SeekOrigin.Current);
            }

            ctx.AddObjectToAsset("cln", cln);
            ctx.SetMainObject(cln);
        }
    }
}
