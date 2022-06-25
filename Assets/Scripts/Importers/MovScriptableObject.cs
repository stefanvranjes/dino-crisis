using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class MovContainer
{
    public byte DAT_00;
}

public class MovContainer2 : MovContainer
{
    public sbyte DAT_01;
    public ushort DAT_02;
}

public class MovContainer3 : MovContainer2
{
    public ushort DAT_04;
}

public class MovContainer4 : MovContainer
{
    public byte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
}

public class MovContainer5 : MovContainer4
{
    public int DAT_04;
}

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

public class MovContainer7 : MovContainer2
{
    public int DAT_04;
}

public class MovContainer8 : MovContainer4
{
    public ushort DAT_04;
    public TmdScriptableObject DAT_08;
    public Vector3Int DAT_0C;
    public Vector3Int DAT_12;
    public BoxColliderScriptableObject DAT_18;
}

public class MovContainer9 : MovContainer4
{
    public TodScriptableObject DAT_04;
}

public class MovContainer10 : MovContainer4
{
    public TriggerScriptableObject DAT_04;
}

public class MovContainer11 : MovContainer
{
    public Vector3Int DAT_02;
    public Vector3Int DAT_08;
    public short DAT_10;
    public short DAT_12;
}

public class MovContainer12 : MovContainer4
{
    public short DAT_04;
}

public class MovContainer13 : MovContainer
{
    public short DAT_02;
    public short DAT_04;
    public short DAT_06;
}

public class MovContainer14 : MovContainer4
{
    public Vector3Int[] DAT_04;
}

public class MovContainer15 : MovContainer4
{
    public ushort DAT_04;
}

public class MovScriptableObject : ScriptableObject
{
    public MovContainer[] CONTAINERS;

    public int GetContainer(int container, int offset)
    {
        return 0; //tmp
    }
}
