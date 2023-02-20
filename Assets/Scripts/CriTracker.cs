using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct TrackerData
{
    public ushort DAT_00; //0x00
    public sbyte DAT_02; //0x02
    public byte DAT_03; //0x03
    public byte DAT_04; //0x04
    public byte DAT_05; //0x05
    public byte DAT_06; //0x06
    public byte DAT_07; //0x07
    public byte DAT_08; //0x08
    public byte DAT_09; //0x09
    public byte DAT_0A; //0x0A
    public byte DAT_0B; //0x0B
}

public class CriTracker : MonoBehaviour
{
    public byte[] BUFFER;
    public int currentOffset; //0x00
    public int startOffset; //0x04
    public int DAT_08; //0x08
    public int DAT_0C; //0x0C
    public int DAT_10; //0x10
    public int DAT_14; //0x14
    public int DAT_18; //0x18
    public bool DAT_1C; //0x1C
    public sbyte DAT_1D; //0x1D
    public sbyte DAT_1E; //0x1E
    public byte DAT_1F; //0x1F
    public byte DAT_20; //0x20
    public byte DAT_21; //0x21
    public byte DAT_22; //0x22
    public byte DAT_23; //0x23
    public byte DAT_24; //0x24
    public byte DAT_25; //0x25
    public byte DAT_26; //0x26
    public bool DAT_27; //0x27
    public sbyte DAT_28; //0x28
    public TrackerData[] DAT_2C; //0x2C

    // Start is called before the first frame update
    void Start()
    {
        DAT_2C = new TrackerData[16];
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
        DAT_1C = false;
        DAT_1D = 0;
        DAT_1E = 0;
        DAT_1F = 0;
        DAT_20 = 0;
        DAT_21 = 0;
        DAT_22 = 0;
        DAT_23 = 0;
        DAT_24 = 0;
        DAT_25 = 0;
        DAT_26 = 0;
        DAT_27 = false;
        DAT_28 = 0;
        DAT_2C = new TrackerData[16];
    }

    public void FUN_5DAA0()
    {
        byte bVar1;
        CriPlayer oVar2;
        int iVar3;
        int iVar4;
        int iVar5;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        iVar4 = DAT_14;
        iVar3 = DAT_18 * 1000;

        if (iVar4 == 0)
            return; //trap(0x1c00)

        if (iVar4 == -1 && iVar3 == -0x80000000)
            return; //trap(0x1800)

        iVar5 = iVar3 / iVar4;
        DAT_10 = iVar5;
        bVar1 = oVar2.DAT_1D7;

        if (bVar1 != 0)
        {
            iVar3 = iVar5 >> 1;
            iVar4 = iVar5 >> 2;

            if (bVar1 == 1)
            {
                iVar3 += iVar4;
                iVar4 = iVar5 >> 3;
            }

            DAT_10 = iVar3 + iVar4;
        }

        GameManager.instance.cSound.DAT_52 = oVar2.DAT_1D7;
        GameManager.instance.cSound.DAT_53 = true;
    }
}
