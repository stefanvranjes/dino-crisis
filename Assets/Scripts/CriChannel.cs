using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriChannel : MonoBehaviour
{
    public int DAT_00; //0x00
    public short DAT_04; //0x04
    public short DAT_06; //0x06
    public short DAT_0A; //0x0A
    public sbyte DAT_0D; //0x0D
    public sbyte DAT_13; //0x13
    public ushort DAT_14; //0x14
    public ushort DAT_18; //0x18
    public bool DAT_1A; //0x1A
    public sbyte DAT_1B; //0x1B
    public byte DAT_1C; //0x1C
    public byte DAT_1D; //0x1D
    public byte DAT_1E; //0x1E
    public bool DAT_20; //0x20
    public bool DAT_21; //0x21
    public sbyte DAT_22; //0x22
    public sbyte DAT_23; //0x23

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetValues()
    {
        DAT_00 = 0;
        DAT_04 = 0;
        DAT_06 = 0;
        DAT_0A = 0;
        DAT_0D = 0;
        DAT_13 = 0;
        DAT_14 = 0;
        DAT_18 = 0;
        DAT_1A = false;
        DAT_1B = 0;
        DAT_1C = 0;
        DAT_1D = 0;
        DAT_1E = 0;
        DAT_20 = false;
        DAT_21 = false;
        DAT_22 = 0;
        DAT_23 = 0;
    }
}
