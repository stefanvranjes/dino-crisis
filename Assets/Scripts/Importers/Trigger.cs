using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//writable class (needs instantiating upon start)
[System.Serializable]
public class Trigger
{
    public string prefabName;

    public Vector2Int[] DAT_00; //0x00
    public byte DAT_10; //0x10
    public byte DAT_11; //0x11
    public byte DAT_12; //0x12
    public bool DAT_13; //0x13 - writable
}

[System.Serializable]
public class Trigger2 : Trigger
{
    public ushort DAT_18;
    public Vector3Int DAT_1A;
    public short DAT_20;
    public byte DAT_22;
    public byte DAT_23;
    public byte DAT_24;
    public bool DAT_25;
}

[System.Serializable]
public class Trigger3 : Trigger
{
    public int DAT_18;
    public int DAT_1C;
}

[System.Serializable]
public class Trigger4 : Trigger
{
    public byte DAT_18;
    public byte DAT_19;
    public bool DAT_1A;
}

[System.Serializable]
public class Trigger5 : Trigger
{
    public byte DAT_18;
    public ushort DAT_1A;
}

[System.Serializable]
public class Trigger6 : Trigger
{
    public ushort DAT_18;
    public ushort DAT_1A;
    public ushort DAT_1C;
    public byte DAT_1E;
    public byte DAT_1F;
    public uint DAT_20;
    public int DAT_24;
    public ushort DAT_28;

    public void FUN_1A638(CriStatic param1, Vector3Int param2)
    {
        param1.flags = 3;
        param1.DAT_2E = 2;
        param1.DAT_48 = 1;
        param1.DAT_4A = 0;
        param1.DAT_2F = 0;
        param1.tags = 0;
        param1.cMesh = (TmdScriptableObject)Utilities.GetRamObject(DAT_20);
        param1.SetMaterials();
        param1.screen = param2;
        param1.vr.x = 0;
        param1.vr.y = 0;

        if (DAT_18 < 11U)
            param1.vr.z = 0xc00;
        else
            param1.vr.z = 0;

        param1.cCollider = null;
    }
}

[System.Serializable]
public class Trigger7 : Trigger
{
    public byte DAT_18;
    public byte DAT_19;
}

[System.Serializable]
public class Trigger8 : Trigger
{

}

[System.Serializable]
public class Trigger9 : Trigger
{
    public short DAT_18;
    public short DAT_1A;
    public short DAT_1C;
    public short DAT_1E;
    public int DAT_24;
    public byte DAT_28;
    public byte DAT_29;
    public ushort DAT_2A;
}

[System.Serializable]
public class Trigger10 : Trigger
{
    public byte DAT_18;
    public bool DAT_19;
}

[System.Serializable]
public class Trigger11 : Trigger
{

}

[System.Serializable]
public class Trigger12 : Trigger
{
    public byte DAT_18;
}

[System.Serializable]
public class Trigger13 : Trigger
{
    public byte DAT_18;
    public byte DAT_19;
    public byte DAT_1A;
    public byte DAT_1B;
}