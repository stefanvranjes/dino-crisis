using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class _STATIC_OBJ_DATA
{
    public byte DAT_00; //0x00
    public byte DAT_01; //0x01
    public byte DAT_02; //0x02
    public byte DAT_03; //0x03
    public ushort DAT_04; //0x04
    public TmdScriptableObject DAT_08; //0x08;
    public Vector3Int DAT_0C; //0x0C
    public Vector3Int DAT_12; //0x12
}

[System.Serializable]
public class MovContainer
{
    public byte DAT_00;
}

[System.Serializable]
public class MovContainer2 : MovContainer
{
    public sbyte DAT_01;
    public ushort DAT_02;
}

[System.Serializable]
public class MovContainer3 : MovContainer2
{
    public ushort DAT_04;
}

[System.Serializable]
public class MovContainer4 : MovContainer
{
    public byte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
}

[System.Serializable]
public class MovContainer5 : MovContainer4
{
    public int DAT_04;
}

[System.Serializable]
public class MovContainer6 : MovContainer4
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
public class MovContainer7 : MovContainer2
{
    public int DAT_04;
}

[System.Serializable]
public class MovContainer8 : MovContainer4
{
    public ushort DAT_04;
    public TmdScriptableObject DAT_08;
    public Vector3Int DAT_0C;
    public Vector3Int DAT_12;
    public BoxColliderScriptableObject DAT_18;
}

[System.Serializable]
public class MovContainer9 : MovContainer4
{
    public TodScriptableObject DAT_04;
}

[System.Serializable]
public class MovContainer10 : MovContainer4
{
    public TriggerScriptableObject DAT_04;
}

[System.Serializable]
public class MovContainer11 : MovContainer
{
    public Vector3Int DAT_02;
    public Vector3Int DAT_08;
    public short DAT_10;
    public short DAT_12;
}

[System.Serializable]
public class MovContainer12 : MovContainer4
{
    public short DAT_04;
}

[System.Serializable]
public class MovContainer13 : MovContainer
{
    public byte DAT_01;
    public short DAT_02;
    public short DAT_04;
    public short DAT_06;
}

[System.Serializable]
public class MovContainer14 : MovContainer4
{
    public Vector3Int[] DAT_04;
}

[System.Serializable]
public class MovContainer15 : MovContainer4
{
    public ushort DAT_04;
}

[System.Serializable]
public class MovContainer16 : MovContainer4
{
    public Vector3Int DAT_04;
    public byte DAT_0A;
    public byte DAT_0B;
}

[System.Serializable]
public class MovContainer17 : MovContainer4
{
    public byte DAT_04;
    public byte DAT_05;
    public short DAT_06;
    public short DAT_08;
    public short DAT_0A;
}

[System.Serializable]
public class MovContainer18 : MovContainer
{
    public byte DAT_01;
    public short DAT_02;
    public short DAT_04;
    public short DAT_06;
}

[System.Serializable]
public class MovContainer19 : MovContainer4
{
    public short DAT_04;
    public short DAT_06;
    public short DAT_08;
    public ushort DAT_0A;
}

[System.Serializable]
public class MovContainer20 : MovContainer
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
public class MovContainer21 : MovContainer4
{
    public byte DAT_04;
    public byte DAT_05;
}

[System.Serializable]
public class MovContainer22 : MovContainer
{
    public byte DAT_01;
    public byte DAT_15;
    public byte DAT_19;
    public byte DAT_1A;
    public short DAT_22;
}

[System.Serializable]
public class _MOVIE_DATA
{
    public int index;
    public MovContainer[] CONTAINERS;

    public int GetContainer(int container, int offset)
    {
        return 0; //tmp
    }
}

public class ScnScriptableObject : ScriptableObject
{
    public string prefabName;

    public List<_STATIC_OBJ_DATA> staticObjs;
    public List<_MOVIE_DATA> movies;

    public _MOVIE_DATA GetMovie(int index)
    {
        for (int i = 0; i < movies.Count; i++)
        {
            if (movies[i].index == index)
                return movies[i];
        }

        return null;
    }
}
