using System.IO;
using System.Collections.Generic;
using UnityEditor.AssetImporters;
using UnityEngine;

[ScriptedImporter(1, "way")]
public class IMP_WAY : ScriptedImporter
{
    public override void OnImportAsset(AssetImportContext ctx)
    {
        byte[] buffer = File.ReadAllBytes(ctx.assetPath);

        using (BufferedBinaryReader reader = new BufferedBinaryReader(buffer))
        {
            WaypointScriptableObject way = ScriptableObject.CreateInstance("WaypointScriptableObject") as WaypointScriptableObject;

            int length = 16;
            int[] offsets = new int[length * 3];
            List<WaypointContainer> list = new List<WaypointContainer>();

            for (int i = 0; i < length; i++)
            {
                if (reader.ReadUInt16(0) != 0)
                {
                    WaypointContainer point = new WaypointContainer();
                    point.DAT_00 = reader.ReadByte();
                    point.DAT_01 = reader.ReadByte();
                    int offset_1 = reader.ReadUInt16();
                    int offset_2 = reader.ReadUInt16();
                    int offset_3 = reader.ReadUInt16();

                    if (offset_2 != 0)
                        point.OFF_02 = new ushort[(offset_2 - offset_1) / 2];
                    else
                        point.OFF_02 = new ushort[(reader.Length - offset_1) / 2];

                    if (offset_2 != 0)
                    {
                        if (offset_3 != 0)
                            point.OFF_04 = new ushort[(offset_3 - offset_2) / 2];
                        else
                            point.OFF_04 = new ushort[(reader.Length - offset_2) / 2];

                        if (offset_3 != 0)
                        {
                            if (reader.ReadUInt16(8) != 0)
                                point.OFF_06 = new byte[reader.ReadUInt16(2) - offset_3];
                            else
                                point.OFF_06 = new byte[reader.Length - offset_3];
                        }
                        else
                        {
                            point.OFF_06 = new byte[0];
                        }
                    }
                    else
                    {
                        point.OFF_04 = new ushort[0];
                        point.OFF_06 = new byte[0];
                    }

                    long position = reader.Position;
                    reader.Seek(offset_1, SeekOrigin.Begin);

                    for (int j = 0; j < point.OFF_02.Length; j++)
                        point.OFF_02[j] = reader.ReadUInt16();

                    reader.Seek(offset_2, SeekOrigin.Begin);

                    for (int j = 0; j < point.OFF_04.Length; j++)
                        point.OFF_04[j] = reader.ReadUInt16();

                    reader.Seek(offset_3, SeekOrigin.Begin);

                    for (int j = 0; j < point.OFF_06.Length; j++)
                        point.OFF_06[j] = reader.ReadByte();

                    list.Add(point);
                    reader.Seek(position, SeekOrigin.Begin);
                }
                else
                    reader.Seek(8, SeekOrigin.Current);
            }

            way.WAYPOINTS = list.ToArray();
            ctx.AddObjectToAsset("way", way);
            ctx.SetMainObject(way);
        }
    }
}
