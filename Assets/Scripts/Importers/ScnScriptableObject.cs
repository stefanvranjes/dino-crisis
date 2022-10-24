using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DataContainer
{
    public byte DAT_00;
}

[System.Serializable]
public class DataContainer2 : DataContainer
{
    public sbyte DAT_01;
    public ushort DAT_02;
}

[System.Serializable]
public class DataContainer3 : DataContainer2
{
    public ushort DAT_04;
    public ushort DAT_06;
}

[System.Serializable]
public class DataContainer4 : DataContainer
{
    public byte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
}

[System.Serializable]
public class DataContainer5 : DataContainer4
{
    public int DAT_04;
}

[System.Serializable]
public class DataContainer6 : DataContainer4
{
    public byte DAT_04;
    public byte DAT_05;
    public short DAT_06;
    public Vector3Int DAT_08;
    public short DAT_0E;
    public Tmd2ScriptableObject DAT_10;
    public RefScriptableObject DAT_14;
}

[System.Serializable]
public class DataContainer7 : DataContainer2
{
    public int DAT_04;
}

[System.Serializable]
public class DataContainer8 : DataContainer4
{
    public ushort DAT_04;
    public TmdScriptableObject DAT_08;
    public Vector3Int DAT_0C;
    public Vector3Int DAT_12;
    public BoxCollider DAT_18;
}

[System.Serializable]
public class DataContainer9 : DataContainer4
{
    public TodScriptableObject PTR_04;
    public int DAT_04;
    public bool hasPointer;
}

[System.Serializable]
public class DataContainer10 : DataContainer4
{
    [SerializeReference]
    public Trigger DAT_04;
}

[System.Serializable]
public class DataContainer11 : DataContainer
{
    public Vector3Int DAT_02;
    public Vector3Int DAT_08;
    public short DAT_10;
    public short DAT_12;
}

[System.Serializable]
public class DataContainer12 : DataContainer4
{
    public short DAT_04;
}

[System.Serializable]
public class DataContainer13 : DataContainer
{
    public byte DAT_01;
    public short DAT_02;
    public short DAT_04;
    public short DAT_06;
}

[System.Serializable]
public class DataContainer14 : DataContainer4
{
    public Vector3Int[] DAT_04;
}

[System.Serializable]
public class DataContainer15 : DataContainer4
{
    public ushort DAT_04;
}

[System.Serializable]
public class DataContainer16 : DataContainer4
{
    public Vector3Int DAT_04;
    public byte DAT_0A;
    public byte DAT_0B;
}

[System.Serializable]
public class DataContainer17 : DataContainer4
{
    public byte DAT_04;
    public byte DAT_05;
    public short DAT_06;
    public short DAT_08;
    public short DAT_0A;
}

[System.Serializable]
public class DataContainer18 : DataContainer
{
    public byte DAT_01;
    public short DAT_02;
    public short DAT_04;
    public short DAT_06;
}

[System.Serializable]
public class DataContainer19 : DataContainer4
{
    public short DAT_04;
    public short DAT_06;
    public short DAT_08;
    public ushort DAT_0A;
}

[System.Serializable]
public class DataContainer20 : DataContainer
{
    public Vector3Int DAT_02;
    public short DAT_08;
    public short DAT_0A;
    public short DAT_0C;
    public short DAT_0E;
    public Vector3Int DAT_12;
    public short DAT_18;
    public short DAT_1A;
    public short DAT_1C;
    public short DAT_1E;
}

[System.Serializable]
public class DataContainer21 : DataContainer4
{
    public byte DAT_04;
    public byte DAT_05;
    public byte DAT_06;
    public byte DAT_07;
}

[System.Serializable]
public class DataContainer22 : DataContainer
{
    public byte DAT_01;
    public byte DAT_15;
    public byte DAT_19;
    public byte DAT_1A;
    public short DAT_22;
}

[System.Serializable]
public class DataContainer23 : DataContainer16
{
    public short DAT_0C;
    public uint DAT_10;
}

[System.Serializable]
public class DataContainer24 : DataContainer4
{
    public Vector3Int DAT_04;
    public short DAT_0A;
    public byte DAT_0C;
    public byte DAT_0D;
    public ushort DAT_0E;
    public ushort DAT_10;
    public ushort DAT_12;
    //unknown 0x14
    public uint DAT_18;
}

[System.Serializable]
public class SVECTOR_SERIALIZED_ARRAY
{
    public Vector2Int[] sv2;
}

[System.Serializable]
public class DataContainer25 : DataContainer4
{
    public Tmd2ScriptableObject DAT_04;
    public TodScriptableObject[] DAT_08;
    public SVECTOR_SERIALIZED_ARRAY[] DAT_0C; //0x00 - lenght, 0x04 - svectors
    public byte DAT_10;
}

[System.Serializable]
public class _SCENE_OBJ_DATA
{
    public int index;
    [SerializeReference]
    public List<DataContainer> CONTAINERS;

    public int GetContainer(int container, int offset, bool prev = false)
    {
        offset = (short)offset;

        if (offset < 0)
        {
            offset = -offset;
            prev = true;
        }

        while (offset != 0)
        {
            if (prev) container--;

            switch (CONTAINERS[container].DAT_00)
            {
                case 0:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                case 112:
                case 113:
                    offset -= 1;
                    break;
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 18:
                case 19:
                case 22:
                case 23:
                case 39:
                case 49:
                case 50:
                case 51:
                case 52:
                case 62: //tmp
                case 107:
                    offset -= 4;
                    break;
                case 9:
                case 99: //tmp
                case 106: //tmp
                    offset -= 8;
                    break;
                case 20:
                case 24:
                case 34:
                case 37:
                case 38:
                case 44:
                case 45:
                case 47:
                case 48:
                case 59:
                case 65:
                case 71:
                case 72:
                case 73:
                case 74:
                case 82:
                case 84:
                case 87:
                case 92:
                case 93:
                case 96:
                case 97:
                case 101:
                case 102:
                case 104:
                case 108:
                case 109:
                case 110:
                case 111: //tmp
                    offset -= 4;
                    break;
                case 21:
                case 41:
                case 42:
                case 43:
                    offset -= 8;
                    break;
                case 32:
                    offset -= 0x18;
                    break;
                case 33:
                    offset -= 8;
                    break;
                case 35:
                    offset -= 0x20;
                    break;
                case 36:
                    offset -= 8;
                    break;
                case 40:
                    switch (((DataContainer10)CONTAINERS[container]).DAT_02)
                    {
                        case 0:
                            offset -= 0x30;
                            break;
                        case 1:
                            offset -= 0x28;
                            break;
                        case 2:
                        case 5:
                        case 6:
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                            offset -= 0x20;
                            break;
                        case 3:
                            offset -= 0x24;
                            break;
                        case 4:
                            offset -= 0x2c;
                            break;
                        case 7:
                            offset -= 0x34;
                            break;
                    }

                    break;
                case 46:
                    offset -= 0x14;
                    break;
                case 53:
                    offset -= 8;
                    break;
                case 54:
                case 55:
                case 77:
                case 78:
                    offset -= 8;
                    break;
                case 58:
                case 90:
                    offset -= 0xc;
                    break;
                case 60:
                case 63:
                    offset -= 8;
                    break;
                case 61:
                case 83:
                case 95:
                    offset -= 0xc;
                    break;
                case 64:
                    offset -= 0xc;
                    break;
                case 67:
                case 68:
                case 69:
                case 70:
                    offset -= 8;
                    break;
                case 75:
                case 85:
                    offset -= 0xc;
                    break;
                case 76:
                    offset -= 0x20;
                    break;
                case 79:
                case 80:
                case 81:
                case 88:
                    offset -= 8;
                    break;
                case 66:
                    offset -= 0x14;
                    break;
                default:
                    Debug.Log("Unknown case: " + CONTAINERS[container].DAT_00);
                    break;
            }

            if (!prev) container++;
        }

        return container;
    }
}

public class ScnScriptableObject : ScriptableObject
{
    public string prefabName;

    public List<_SCENE_OBJ_DATA> data;
    public int bufferOffset;
    public ushort[] endBuffer;

    public _SCENE_OBJ_DATA GetData(int index)
    {
        for (int i = 0; i < data.Count; i++)
        {
            if (data[i].index == index)
                return data[i];
        }

        return null;
    }
}
