using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriTracker : MonoBehaviour
{
    public byte[] BUFFER;
    public int currentOffset; //0x00
    public int startOffset; //0x04
    public int DAT_08; //0x08
    public int DAT_0C; //0x0C
    public uint DAT_10; //0x10
    public uint DAT_14; //0x14
    public uint DAT_18; //0x18
    public byte DAT_1C; //0x1C
    public byte DAT_1D; //0x1D
    public byte DAT_1E; //0x1E
    public byte DAT_1F; //0x1F
    public byte DAT_20; //0x20
    public sbyte DAT_24; //0x24
    public byte DAT_25; //0x25
    public byte DAT_26; //0x26
    public byte DAT_27; //0x27

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
        BUFFER = null;
        currentOffset = 0;
        startOffset = 0;
        DAT_08 = 0;
        DAT_0C = 0;
        DAT_10 = 0;
        DAT_14 = 0;
        DAT_18 = 0;
        DAT_1C = 0;
        DAT_1D = 0;
        DAT_1E = 0;
        DAT_1F = 0;
        DAT_20 = 0;
        DAT_24 = 0;
        DAT_25 = 0;
        DAT_26 = 0;
        DAT_27 = 0;
    }
}
