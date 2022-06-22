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
}

public class MovContainer5 : MovContainer4
{
    public int DAT_04;
}

public class MovScriptableObject : ScriptableObject
{
    public MovContainer[] CONTAINERS;

    public int GetContainer(int container, int offset)
    {
        return 0; //tmp
    }
}
