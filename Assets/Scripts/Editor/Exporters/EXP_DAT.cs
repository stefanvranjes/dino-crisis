using System;
using System.IO;
using System.Collections.Generic;
using UnityEditor;

public static class EXP_DAT
{
    private delegate void FUN_9ACD0(BufferedBinaryReader reader, string outFile);
    private static long[] PTR_DAT_9AC6C = new long[16]
    {
        0x0000, 0x0800, 0x1000, 0x1800, 0x2000, 0x2800,
        0x3000, 0x3800, 0x4000, 0x4800, 0x5000, 0x5800,
        0x6000, 0x6800, 0x7000, 0x7800
    };
    private static FUN_9ACD0[] PTR_FUN_9ACD0 = new FUN_9ACD0[10]
            {
                new FUN_9ACD0(FUN_2ABC8), new FUN_9ACD0(FUN_2AC7C),
                new FUN_9ACD0(FUN_2AD58), new FUN_9ACD0(FUN_2AE20),
                new FUN_9ACD0(FUN_2AF7C), new FUN_9ACD0(FUN_2B024),
                new FUN_9ACD0(FUN_2ABC8), new FUN_9ACD0(FUN_2B13C),
                new FUN_9ACD0(FUN_2B270), new FUN_9ACD0(FUN_2B3DC)
            };
    private static ushort DAT_C3329; //originally a byte
    private static short DAT_C3330;
    public static RamScriptableObject RAM;

    //FUN_2A990
    public static void ExtractDAT(string inFile, string outDir)
    {
        using (BinaryReader reader = new BinaryReader(File.Open(inFile, FileMode.Open)))
        {
            DAT_C3329 = 1; //not in the original code
            string outFile = outDir + Path.DirectorySeparatorChar;
            outFile += Path.GetFileNameWithoutExtension(inFile);
            BufferedBinaryReader bufferReader = new BufferedBinaryReader(reader.BaseStream, (int)reader.BaseStream.Length);
            bufferReader.FillBuffer();
            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            while (true)
            {
                int segmentId = reader.ReadInt32();
                int size = reader.ReadInt32() - 1;

                if (9 < segmentId) break;

                PTR_FUN_9ACD0[segmentId](bufferReader, outFile);
                reader.BaseStream.Seek(8, SeekOrigin.Current);
                bufferReader.Seek(reader.BaseStream.Position, SeekOrigin.Begin);
                DAT_C3329 += (ushort)(size / 0x800 + 1);

                /*if (15 < DAT_C3329)
                    DAT_C3329 = 1;*/
            }

            AssetDatabase.Refresh();
        }
    }

    private static void FUN_2ABC8(BufferedBinaryReader reader, string outFile)
    {
        int puVar1;
        int puVar3;
        byte[] aVar3;

        puVar1 = DAT_C3329 * 0x800 - (int)reader.Position;
        aVar3 = new byte[reader.ReadInt32(4)];

        for (puVar3 = 0; puVar3 < aVar3.Length; puVar3++)
        {
            aVar3[puVar3] = reader.ReadByte(puVar1);
            puVar1++;
        }

        IniPostprocessor.script = true;
        IniPostprocessor.address = reader.ReadUInt32(8);
        outFile += "_" + DAT_C3329.ToString("D2") + ".ini";
        File.WriteAllBytes(outFile, aVar3);
        AssetDatabase.Refresh();
        IniPostprocessor.script = false;
    }

    private static void FUN_2AC7C(BufferedBinaryReader reader, string outFile)
    {
        outFile += "_" + DAT_C3329.ToString("D2") + ".tim";

        using (BinaryWriter writer = new BinaryWriter(File.Open(outFile, FileMode.Create)))
        {
            writer.Write(reader.ReadInt16(8));
            writer.Write(reader.ReadInt16(10));
            writer.Write(reader.ReadInt16(12));
            writer.Write(reader.ReadInt16(14));
            writer.Write((long)0);
            int size = reader.ReadInt32(4);
            //int pos = (int)PTR_DAT_9AC6C[DAT_C3329] - (int)reader.Position;
            int pos = DAT_C3329 * 0x800 - (int)reader.Position;
            int pageX = 0;
            int pageY = 0;

            for (int i = 0; i < size; i++)
            {
                if ((i % 0x80) / 0x40 % 2 == 0)
                {
                    writer.Write(reader.ReadByte(pos + ((pageX / 0x800) * 0x1000 + (pageX % 0x800))));
                    pageX++;
                }
                else
                {
                    writer.Write(reader.ReadByte(pos + ((pageY / 0x800) * 0x1000 + (pageY % 0x800) + 0x800)));
                    pageY++;
                }
            }
        }
    }

    private static void FUN_2AD58(BufferedBinaryReader reader, string outFile)
    {
        outFile += "_" + DAT_C3329.ToString("D2") + ".clut";

        using (BinaryWriter writer = new BinaryWriter(File.Open(outFile, FileMode.Create)))
        {
            writer.Write(reader.ReadInt16(8));
            writer.Write(reader.ReadInt16(10));
            writer.Write(reader.ReadInt16(12));
            writer.Write(reader.ReadInt16(14));
            writer.Write((long)0);
            int size = reader.ReadInt32(4);
            //int pos = (int)PTR_DAT_9AC6C[DAT_C3329] - (int)reader.Position;
            int pos = DAT_C3329 * 0x800 - (int)reader.Position;

            for (int i = 0; i < size; i++)
                writer.Write(reader.ReadByte(pos + i));
        }
    }

    private static void FUN_2AE20(BufferedBinaryReader reader, string outFile)
    {
        int puVar2;
        int puVar3;
        byte[] aVar3;

        if (DAT_C3330 == 0)
        {
            DAT_C3330++;
        }

        puVar2 = DAT_C3329 * 0x800 - (int)reader.Position;
        aVar3 = new byte[reader.ReadInt32(4)];

        for (puVar3 = 0; puVar3 < aVar3.Length; puVar3++)
        {
            aVar3[puVar3] = reader.ReadByte(puVar2);
            puVar2++;
        }

        GianPostprocessor.script = true;
        GianPostprocessor.index = reader.ReadUInt16(14);
        outFile += "_" + DAT_C3329.ToString("D2") + ".gian";
        File.WriteAllBytes(outFile, aVar3);
        AssetDatabase.Refresh();
        GianPostprocessor.script = false;
    }

    private static void FUN_2AF7C(BufferedBinaryReader reader, string outFile)
    {
        long addr;
        int size;

        if (DAT_C3330 == 0)
        {
            DAT_C3330++;
        }

        size = reader.ReadInt32(4);

        /*if (size < 0x801)
            addr = PTR_DAT_9AC6C[DAT_C3329];
        else
        {
            addr = PTR_DAT_9AC6C[DAT_C3329];
            size = 0x800;
        }*/

        if (size < 0x801)
            addr = DAT_C3329 * 0x800;
        else
        {
            addr = DAT_C3329 * 0x800;
            //size = 0x800;
        }

        uint addr2 = reader.ReadUInt32(8);
        reader.Seek(addr, SeekOrigin.Begin);
        outFile += "_" + DAT_C3329.ToString("D2");
        EXP_SND.ExtractSND(reader, RAM, outFile, addr2, size);
    }

    private static void FUN_2B024(BufferedBinaryReader reader, string outFile)
    {
        int puVar2;
        int puVar3;
        byte[] aVar3;

        puVar2 = DAT_C3329 * 0x800 - (int)reader.Position;
        aVar3 = new byte[reader.ReadInt32(4)];

        for (puVar3 = 0; puVar3 < aVar3.Length; puVar3++)
        {
            aVar3[puVar3] = reader.ReadByte(puVar2);
            puVar2++;
        }

        outFile += "_" + DAT_C3329.ToString("D2") + ".gnt";
        File.WriteAllBytes(outFile, aVar3);
    }

    private static void FUN_2B13C(BufferedBinaryReader reader, string outFile)
    {
        uint uVar1;
        int pbVar2;
        uint uVar3;
        int pbVar4;
        int iVar5;
        List<byte> lVar6;
        int pbVar6;
        uint uVar7;
        uint uVar8;
        byte bVar9;
        uint uVar10;
        bool bVar11;
        bool bVar12;

        iVar5 = 0x800;

        if (reader.ReadInt32(4) < 0x801)
            iVar5 = reader.ReadInt32(4);

        iVar5 = reader.ReadInt32(4); //not in the original code
        pbVar6 = 0;
        lVar6 = new List<byte>();
        uVar8 = reader.ReadByte(12);
        uVar7 = reader.ReadByte(13);
        uVar10 = reader.ReadByte(15);
        //pbVar4 = (int)PTR_DAT_9AC6C[DAT_C3329] - (int)reader.Position;
        pbVar4 = DAT_C3329 * 0x800 - (int)reader.Position;
        bVar11 = false;
        bVar12 = false;

        if (reader.ReadByte(14) == 1) bVar11 = true;
        if (reader.ReadByte(14) == 2) bVar12 = true;

        do
        {
            if (bVar11)
            {
                bVar11 = false;
                goto LAB_2B1C4;
            }

            if (bVar12)
            {
                bVar12 = false;
                LAB_2B204:
                uVar3 = 0;
                uVar1 = (uint)reader.ReadByte(pbVar4) >> 4;
                pbVar2 = pbVar6 + -(int)((reader.ReadByte(pbVar4) & 0xfU) << 8 | uVar10);

                if (uVar1 != 0xfffffffe)
                {
                    do
                    {
                        bVar9 = lVar6[pbVar2];
                        pbVar2++;
                        uVar3++;
                        lVar6.Add(bVar9);
                        pbVar6++;
                    } while (uVar3 < uVar1 + 2);
                }

                bVar9 = (byte)uVar10;
                uVar7 >>= 1;
                iVar5--;
                pbVar4++;
                continue;
            }

            bVar9 = (byte)uVar10;

            if (uVar8 == 0)
            {
                uVar7 = reader.ReadByte(pbVar4);
                pbVar4++;
                iVar5--;
                uVar8 = 8;

                if (iVar5 == 0)
                {
                    reader.Write(14, 1);
                    goto LAB_2B25C;
                }
            }

            LAB_2B1C4:
            uVar8--;

            if ((uVar7 & 1) == 0)
            {
                bVar9 = reader.ReadByte(pbVar4);
                uVar10 = bVar9;
                iVar5--;
                pbVar4++;

                if (iVar5 == 0)
                {
                    reader.Write(14, 2);
                    goto LAB_2B25C;
                }

                LAB_2B204:
                uVar3 = 0;
                uVar1 = (uint)reader.ReadByte(pbVar4) >> 4;
                pbVar2 = pbVar6 + -(int)((reader.ReadByte(pbVar4) & 0xfU) << 8 | uVar10);

                if (uVar1 != 0xfffffffe)
                {
                    do
                    {
                        bVar9 = lVar6[pbVar2];
                        pbVar2++;
                        uVar3++;
                        lVar6.Add(bVar9);
                        pbVar6++;
                    } while (uVar3 < uVar1 + 2);
                }
            }
            else
            {
                lVar6.Add(reader.ReadByte(pbVar4));
                pbVar6++;
            }

            bVar9 = (byte)uVar10;
            uVar7 >>= 1;
            iVar5--;
            pbVar4++;
        } while (iVar5 != 0);

        reader.Write(14, 0);
        LAB_2B25C:
        //write ram address
        reader.Write(12, (byte)uVar8);
        reader.Write(13, (byte)uVar7);
        reader.Write(15, bVar9);
        outFile += "_" + DAT_C3329.ToString("D2");
        File.WriteAllBytes(outFile, lVar6.ToArray());
    }

    private static void FUN_2B270(BufferedBinaryReader reader, string outFile)
    {
        uint uVar1;
        int pbVar2;
        uint uVar3;
        int pbVar4;
        int iVar5;
        List<byte> lVar6;
        int pbVar6;
        uint uVar7;
        uint uVar8;
        byte bVar9;
        uint uVar10;
        bool bVar11;
        bool bVar12;

        iVar5 = 0x800;

        if (reader.ReadInt32(4) < 0x801)
            iVar5 = reader.ReadInt32(4);

        iVar5 = reader.ReadInt32(4); //not in the original code
        pbVar6 = 0;
        lVar6 = new List<byte>();
        uVar8 = 0;
        uVar7 = 0;
        uVar10 = 0;
        //pbVar4 = (int)PTR_DAT_9AC6C[DAT_C3329] - (int)reader.Position;
        pbVar4 = DAT_C3329 * 0x800 - (int)reader.Position;
        bVar11 = false;
        bVar12 = false;

        //if (reader.ReadByte(14) == 1) bVar11 = true;
        //if (reader.ReadByte(14) == 2) bVar12 = true;

        do
        {
            if (bVar11)
            {
                bVar11 = false;
                goto LAB_2B1C4;
            }

            if (bVar12)
            {
                bVar12 = false;
                LAB_2B204:
                uVar3 = 0;
                uVar1 = (uint)reader.ReadByte(pbVar4) >> 4;
                pbVar2 = pbVar6 + -(int)((reader.ReadByte(pbVar4) & 0xfU) << 8 | uVar10);

                if (uVar1 != 0xfffffffe)
                {
                    do
                    {
                        bVar9 = lVar6[pbVar2];
                        pbVar2++;
                        uVar3++;
                        lVar6.Add(bVar9);
                        pbVar6++;
                    } while (uVar3 < uVar1 + 2);
                }

                bVar9 = (byte)uVar10;
                uVar7 >>= 1;
                iVar5--;
                pbVar4++;
                continue;
            }

            bVar9 = (byte)uVar10;

            if (uVar8 == 0)
            {
                uVar7 = reader.ReadByte(pbVar4);
                pbVar4++;
                iVar5--;
                uVar8 = 8;

                if (iVar5 == 0)
                {
                    reader.Write(14, 1);
                    goto LAB_2B25C;
                }
            }

            LAB_2B1C4:
            uVar8--;

            if ((uVar7 & 1) == 0)
            {
                bVar9 = reader.ReadByte(pbVar4);
                uVar10 = bVar9;
                iVar5--;
                pbVar4++;

                if (iVar5 == 0)
                {
                    reader.Write(14, 2);
                    goto LAB_2B25C;
                }

                LAB_2B204:
                uVar3 = 0;
                uVar1 = (uint)reader.ReadByte(pbVar4) >> 4;
                pbVar2 = pbVar6 + -(int)((reader.ReadByte(pbVar4) & 0xfU) << 8 | uVar10);

                if (uVar1 != 0xfffffffe)
                {
                    do
                    {
                        bVar9 = lVar6[pbVar2];
                        pbVar2++;
                        uVar3++;
                        lVar6.Add(bVar9);
                        pbVar6++;
                    } while (uVar3 < uVar1 + 2);
                }
            }
            else
            {
                lVar6.Add(reader.ReadByte(pbVar4));
                pbVar6++;
            }

            bVar9 = (byte)uVar10;
            uVar7 >>= 1;
            iVar5--;
            pbVar4++;
        } while (iVar5 != 0);

        //reader.Write(14, 0);
        LAB_2B25C:
        //write ram address
        //reader.Write(12, (byte)uVar8);
        //reader.Write(13, (byte)uVar7);
        //reader.Write(15, bVar9);
        outFile += "_" + DAT_C3329.ToString("D2") + ".tim";

        using (BinaryWriter writer = new BinaryWriter(File.Open(outFile, FileMode.Create)))
        {
            short width = reader.ReadInt16(12);
            short height = reader.ReadInt16(14);
            writer.Write(reader.ReadInt16(8));
            writer.Write(reader.ReadInt16(10));
            writer.Write(width);
            writer.Write(height);
            writer.Write((long)0);
            //writer.Write(lVar6.ToArray());
            int[] pages = new int[width * 2 / 0x40];
            int[] slices = new int[width * 2 / 0x40];

            for (int i = 0; i < lVar6.Count; i++)
            {
                int pageIndex = i % (width * 2) / 0x40;
                writer.Write(lVar6[(pages[pageIndex] / 0x800) * pages.Length * 0x800 + (pages[pageIndex] % 0x800) + 0x800 * pageIndex]);
                pages[pageIndex]++;
            }
        }
    }

    private static void FUN_2B3DC(BufferedBinaryReader reader, string outFile)
    {
        return;
    }
}
