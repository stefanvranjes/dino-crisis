using System;
using System.IO;
using UnityEngine;

public static class Utilities
{
    public static short[] DAT_AC7E8;

    //FUN_8F8C0
    public static Matrix3x3 RotMatrix(ref Vector3Int r, ref Matrix3x3 m)
    {
        short sVar1;
        Matrix3x3 pMVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        int iVar7;
        short sVar8;
        int iVar9;

        if (r.x < 0)
        {
            pMVar2 = FGO_01_OBJ_64(ref r, ref m);
            return pMVar2;
        }

        iVar6 = DAT_AC7E8[(r.x & 0xfff) * 2];
        iVar3 = DAT_AC7E8[(r.x & 0xfff) * 2 + 1];
        
        if (-1 < r.y)
        {
            sVar8 = DAT_AC7E8[(r.y & 0xfff) * 2];
            iVar9 = -sVar8;
            iVar4 = DAT_AC7E8[(r.y & 0xfff) * 2 + 1];
            sVar1 = (short)r.z;
            m.V02 = sVar8;
            m.V12 = (short)(-(iVar4 * iVar6) >> 12);
            sVar8 = (short)(iVar4 * iVar3 >> 12);

            if (-1 < sVar1)
            {
                m.V22 = sVar8;
                iVar7 = DAT_AC7E8[(sVar1 & 0xfff) * 2];
                iVar5 = DAT_AC7E8[(sVar1 & 0xfff) * 2 + 1];
                m.V00 = (short)(iVar5 * iVar4 >> 12);
                m.V01 = (short)(-(iVar7 * iVar4) >> 12);
                iVar4 = iVar5 * iVar9 >> 12;
                m.V10 = (short)((iVar7 * iVar3 >> 12) - (iVar4 * iVar6 >> 12));
                m.V20 = (short)((iVar7 * iVar6 >> 12) + (iVar4 * iVar3 >> 12));
                iVar9 = iVar7 * iVar9 >> 12;
                m.V11 = (short)((iVar5 * iVar3 >> 12) + (iVar9 * iVar6 >> 12));
                m.V21 = (short)((iVar5 * iVar6 >> 12) - (iVar9 * iVar3 >> 12));
                return m;
            }

            m.V22 = sVar8;
            pMVar2 = FGO_01_OBJ_160(ref r, ref m);
            return pMVar2;
        }

        pMVar2 = FGO_01_OBJ_CC(ref r, ref m);
        return pMVar2;
    }

    private static Matrix3x3 FGO_01_OBJ_64(ref Vector3Int r, ref Matrix3x3 m)
    {
        if (r.y < 0)
        {

        }
    }

    private static Matrix3x3 FGO_01_OBJ_CC(ref Vector3Int r, ref Matrix3x3 m)
    {
        short sVar1;

        sVar1 = (short)r.z;
    }

    private static Matrix3x3 FGO_01_OBJ_160(ref Vector3Int r, ref Matrix3x3 m)
    {

    }

    public static int LeadingZeros(int x)
    {
        if ((x & 0x80000000) != 0)
            x ^= -1;

        if (x == 0) return 32;

        const int numIntBits = sizeof(int) * 8; //compile time constant
                                                //do the smearing
        x |= x >> 1;
        x |= x >> 2;
        x |= x >> 4;
        x |= x >> 8;
        x |= x >> 16;
        //count the ones
        x -= x >> 1 & 0x55555555;
        x = (x >> 2 & 0x33333333) + (x & 0x33333333);
        x = (x >> 4) + x & 0x0f0f0f0f;
        x += x >> 8;
        x += x >> 16;
        return numIntBits - (x & 0x0000003f); //subtract # of 1s from 32
    }

    public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
    {
        if (val.CompareTo(min) < 0) return min;
        else if (val.CompareTo(max) > 0) return max;
        else return val;
    }
}

public class BufferedBinaryReader : IDisposable
{
    public long Position { get { return bufferOffset; } }
    public long Length { get { return bufferSize; } }

    private readonly Stream stream;
    private byte[] buffer;
    private int bufferSize;
    private int bufferOffset;
    private int numBufferedBytes;

    public BufferedBinaryReader(Stream stream, int bufferSize)
    {
        this.stream = stream;
        this.bufferSize = bufferSize;
        buffer = new byte[bufferSize];
        bufferOffset = bufferSize;
    }

    public BufferedBinaryReader(byte[] buffer)
    {
        if (buffer != null)
        {
            bufferSize = buffer.Length;
            this.buffer = buffer;
        }
        else
        {
            bufferSize = 0;
            this.buffer = null;
        }
    }

    public int NumBytesAvailable { get { return Math.Max(0, numBufferedBytes - bufferOffset); } }

    public bool FillBuffer()
    {
        var numBytesUnread = bufferSize - bufferOffset;
        var numBytesToRead = bufferSize - numBytesUnread;
        bufferOffset = 0;
        numBufferedBytes = numBytesUnread;
        if (numBytesUnread > 0)
        {
            Buffer.BlockCopy(buffer, numBytesToRead, buffer, 0, numBytesUnread);
        }
        while (numBytesToRead > 0)
        {
            var numBytesRead = stream.Read(buffer, numBytesUnread, numBytesToRead);
            if (numBytesRead == 0)
            {
                return false;
            }
            numBufferedBytes += numBytesRead;
            numBytesToRead -= numBytesRead;
            numBytesUnread += numBytesRead;
        }
        return true;
    }

    public void ChangeBuffer(byte[] buffer)
    {
        bufferSize = buffer.Length;
        this.buffer = buffer;
        bufferOffset = 0;
    }

    public void ChangeBuffer(BufferedBinaryReader reader)
    {
        bufferSize = reader.bufferSize;
        buffer = reader.buffer;
        bufferOffset = reader.bufferOffset;
    }

    public byte[] GetBuffer()
    {
        return buffer;
    }

    public byte ReadByte()
    {
        byte val = (byte)(int)buffer[bufferOffset];
        bufferOffset++;
        return val;
    }

    public byte ReadByte(int offset)
    {
        byte val = (byte)(int)buffer[bufferOffset + offset];
        return val;
    }

    public short ReadInt16()
    {
        var val = (short)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8);
        bufferOffset += 2;
        return val;
    }

    public short ReadInt16(int offset)
    {
        var val = (short)((int)buffer[bufferOffset + offset] | (int)buffer[bufferOffset + offset + 1] << 8);
        return val;
    }

    public ushort ReadUInt16()
    {
        var val = (ushort)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8);
        bufferOffset += 2;
        return val;
    }

    public ushort ReadUInt16(int offset)
    {
        var val = (ushort)((int)buffer[bufferOffset + offset] | (int)buffer[bufferOffset + offset + 1] << 8);
        return val;
    }

    public int ReadInt32()
    {
        var val = (int)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8 |
                        (int)buffer[bufferOffset + 2] << 16 | (int)buffer[bufferOffset + 3] << 24);
        bufferOffset += 4;
        return val;
    }

    public int ReadInt32(int offset)
    {
        var val = (int)((int)buffer[bufferOffset + offset] | (int)buffer[bufferOffset + offset + 1] << 8 |
                        (int)buffer[bufferOffset + offset + 2] << 16 | (int)buffer[bufferOffset + offset + 3] << 24);
        return val;
    }

    public uint ReadUInt32()
    {
        var val = (uint)((int)buffer[bufferOffset] | (int)buffer[bufferOffset + 1] << 8 |
                        (int)buffer[bufferOffset + 2] << 16 | (int)buffer[bufferOffset + 3] << 24);
        bufferOffset += 4;
        return val;
    }

    public uint ReadUInt32(int offset)
    {
        var val = (uint)((int)buffer[bufferOffset + offset] | (int)buffer[bufferOffset + offset + 1] << 8 |
                        (int)buffer[bufferOffset + offset + 2] << 16 | (int)buffer[bufferOffset + offset + 3] << 24);
        return val;
    }

    public Vector3Int ReadSVector()
    {
        var val = new Vector3Int(ReadInt16(), ReadInt16(), ReadInt16());
        return val;
    }

    public Vector3Int ReadSVector(int offset)
    {
        var val = new Vector3Int(ReadInt16(offset), ReadInt16(offset + 2), ReadInt16(offset + 4));
        return val;
    }

    public void Write(byte value)
    {
        buffer[bufferOffset] = value;
        bufferOffset++;
    }

    public void Write(int offset, byte value)
    {
        buffer[bufferOffset + offset] = value;
    }

    public void Write(ushort value)
    {
        buffer[bufferOffset] = (byte)value;
        buffer[bufferOffset + 1] = (byte)(value >> 8);
        bufferOffset += 2;
    }

    public void Write(int offset, ushort value)
    {
        buffer[bufferOffset + offset] = (byte)value;
        buffer[bufferOffset + offset + 1] = (byte)(value >> 8);
    }

    public void Dispose()
    {
        if (stream != null)
            stream.Close();
    }

    public void Seek(long offset, SeekOrigin origin)
    {
        switch (origin)
        {
            case SeekOrigin.Begin:
                bufferOffset = (int)offset;
                break;
            case SeekOrigin.Current:
                bufferOffset += (int)offset;
                break;
            case SeekOrigin.End:
                bufferOffset = bufferSize - (int)offset;
                break;
        }
    }
}
