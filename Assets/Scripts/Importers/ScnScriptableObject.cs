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
    public TodScriptableObject[] DAT_14;
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
    public TodScriptableObject DAT_04;
}

[System.Serializable]
public class DataContainer10 : DataContainer4
{
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

public class DataContainer23 : DataContainer16
{
    public short DAT_0C;
    public uint DAT_10;
}

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
public class _SCENE_OBJ_DATA
{
    public int index;
    public DataContainer[] CONTAINERS;

    public int GetContainer(int container, int offset)
    {
        return 0; //tmp
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
