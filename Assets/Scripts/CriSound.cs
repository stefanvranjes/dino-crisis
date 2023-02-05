using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriSound : MonoBehaviour
{
    public sbyte[] DAT_08; //0x08
    public short DAT_20; //0x20
    public byte DAT_22; //0x22
    public byte DAT_23; //0x23
    public byte DAT_24; //0x24
    public sbyte DAT_25; //0x25
    public uint DAT_28; //0x28
    public uint DAT_2C; //0x2C
    public uint DAT_30; //0x30
    public uint DAT_34; //0x34
    public uint DAT_38; //0x38
    public uint DAT_48; //0x48
    public ushort DAT_4C; //0x4C
    public ushort DAT_4E; //0x4E

    // Start is called before the first frame update
    void Start()
    {
        DAT_08 = new sbyte[24];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetValues()
    {
        DAT_08 = new sbyte[24];
        DAT_20 = 0;
        DAT_22 = 0;
        DAT_23 = 0;
        DAT_24 = 0;
        DAT_25 = 0;
        DAT_28 = 0;
        DAT_2C = 0;
        DAT_30 = 0;
        DAT_34 = 0;
        DAT_38 = 0;
        DAT_48 = 0;
        DAT_4C = 0;
        DAT_4E = 0;
    }
}
