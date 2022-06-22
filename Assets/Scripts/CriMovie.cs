using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriMovie : MonoBehaviour
{
    public ushort DAT_00; //0x00
    public byte DAT_05; //0x05
    public byte DAT_06; //0x06
    public sbyte DAT_07; //0x07
    public sbyte DAT_08; //0x08
    public sbyte DAT_09; //0x09
    public byte DAT_0A; //0x0A
    public byte DAT_0B; //0x0B
    public short DAT_0C; //0x0C
    public short DAT_0E; //0x0E
    public short DAT_10; //0x10
    public short DAT_12; //0x12
    public short DAT_18; //0x18
    public short DAT_1A; //0x1A
    public short DAT_1C; //0x1C
    public short DAT_1E; //0x1E
    public ushort[] DAT_24; //0x24
    public int[] DAT_30; //0x30
    public int[] DAT_44; //0x44
    public int[] DAT_58; //0x58
    public MovScriptableObject[] PTR_58; //0x58
    public int DAT_AC; //0xAC

    private void Awake()
    {
        DAT_24 = new ushort[5];
        DAT_30 = new int[5];
        DAT_44 = new int[5];
        DAT_58 = new int[21];
        PTR_58 = new MovScriptableObject[21];
    }

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
        DAT_05 = 0;
        DAT_06 = 0;
        DAT_07 = 0;
        DAT_08 = 0;
        DAT_09 = 0;
        DAT_0A = 0;
        DAT_0B = 0;
        DAT_0C = 0;
        DAT_0E = 0;
        DAT_10 = 0;
        DAT_12 = 0;
        DAT_18 = 0;
        DAT_1A = 0;
        DAT_1C = 0;
        DAT_1E = 0;
        DAT_24 = new ushort[5];
        DAT_30 = new int[5];
        DAT_44 = new int[5];
        DAT_58 = new int[21];
        PTR_58 = new MovScriptableObject[21];
    }

    private int FUN_55DC8(uint param1, int param2)
    {
        CriPlayer oVar1;

        switch (param1 >> 0x10)
        {
            case 0:
                switch (param2)
                {
                    case 0:
                        return GameManager.instance.DAT_78;
                    case 1:
                        return GameManager.instance.DAT_922C;
                    case 2:
                        return GameManager.instance.DAT_28;
                    case 3:
                        return GameManager.instance.DAT_2A;
                    case 4:
                        return GameManager.instance.DAT_2C;
                    case 5:
                        return GameManager.instance.DAT_2E;
                    case 6:
                        return (ushort)GameManager.instance.DAT_28 | (ushort)GameManager.instance.DAT_2A << 0x10;
                    case 7:
                        return GameManager.instance.DAT_9ADC | GameManager.instance.DAT_9ADD << 8;
                    case 8:
                        return GameManager.instance.DAT_20;
                    case 9:
                        return SceneManager.instance.DAT_270;
                    case 10:
                        return GameManager.instance.DAT_3B;
                }

                break;
            case 1:
                switch (param2)
                {
                    case 0:
                        return SceneManager.instance.DAT_C51D0;
                    case 1:
                        return SceneManager.instance.DAT_C51D4;
                    case 2:
                        return SceneManager.instance.DAT_C51B8;
                    case 3:
                        return SceneManager.instance.DAT_C51BC;
                    case 4:
                        return SceneManager.instance.DAT_C51C0;
                    case 5:
                        return SceneManager.instance.DAT_C51C4;
                    case 6:
                        return SceneManager.instance.DAT_C51C8;
                    case 7:
                        return SceneManager.instance.DAT_C51CC;
                    case 8:
                        return DAT_0C;
                    case 9:
                        return DAT_0E;
                    case 10:
                        return DAT_10;
                    case 11:
                    case 12:
                    case 13:
                        return DAT_12;
                    case 14:
                        return DAT_18;
                    case 15:
                        return DAT_1A;
                    case 16:
                        return DAT_1C;
                    case 17:
                    case 18:
                    case 19:
                        return DAT_1E;
                }

                break;
        }

        return 0;
    }

    private bool FUN_56698()
    {
        DAT_58[0]++;
        return false;
    }

    private bool FUN_566EC()
    {
        ushort uVar1;
        bool bVar2;
        int iVar2;
        MovContainer2 mVar4;

        bVar2 = InventoryManager.FUN_4A87C(10, 9);

        if (!bVar2)
        {
            mVar4 = (MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];
            uVar1 = mVar4.DAT_02;
            iVar2 = mVar4.DAT_01;

            if (iVar2 == -1)
                iVar2 = (int)SceneManager.instance.FUN_566B0();

            SceneManager.instance.DAT_D7C0[iVar2].DAT_05 = 1;
            SceneManager.instance.DAT_D7C0[iVar2].PTR_58[0] = (MovScriptableObject)SceneManager.instance.scn.OBJECTS[uVar1];
            SceneManager.instance.DAT_D7C0[iVar2].DAT_58[0] = 0;
            SceneManager.instance.DAT_D7C0[iVar2].DAT_AC = 1 + mVar4.DAT_01 / 4;
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_567E4()
    {
        ushort uVar1;

        DAT_05 = 2;
        uVar1 = ((MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02;
        DAT_58[0]++;
        DAT_00 = uVar1;
        return true;
    }

    private bool FUN_5680C()
    {
        DAT_58[0]++;
        return true;
    }

    private bool FUN_56824()
    {
        bool bVar1;
        int iVar2;

        bVar1 = DAT_07 == 0;

        if (bVar1)
            ResetValues();
        else
        {
            iVar2 = DAT_AC;
            DAT_07--;
            DAT_AC = iVar2 - 1;
            DAT_58[0] = DAT_58[iVar2 - 1];
            PTR_58[0] = PTR_58[iVar2 - 1];
        }

        return bVar1;
    }

    private bool FUN_5687C()
    {
        bool bVar1;

        bVar1 = InventoryManager.FUN_4A87C(10, 9);

        if (!bVar1)
        {
            DAT_AC = 1;
            PTR_58[0] = (MovScriptableObject)SceneManager.instance.scn.OBJECTS
                [((MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02];
            DAT_58[0] = 0;
        }
        else
            DAT_58[0]++;

        return false;
    }

    private bool FUN_568F8()
    {
        SceneManager.instance.DAT_D7C0
            [((MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01].ResetValues();
        DAT_58[0]++;
        return false;
    }

    private bool FUN_56960()
    {
        int iVar1;

        iVar1 = ((MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01;

        if (SceneManager.instance.DAT_D7C0[iVar1].DAT_05 != 0)
            SceneManager.instance.DAT_D7C0[iVar1].DAT_05 = 0x80;

        DAT_58[0]++;
        return false;
    }

    private bool FUN_569C0()
    {
        int iVar1;

        iVar1 = ((MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01;

        if (SceneManager.instance.DAT_D7C0[iVar1].DAT_05 == 0x80)
            SceneManager.instance.DAT_D7C0[iVar1].DAT_05 = 1;

        DAT_58[0]++;
        return false;
    }

    private bool FUN_56A1C()
    {
        MovContainer3 mVar1;

        mVar1 = (MovContainer3)PTR_58[0].CONTAINERS[DAT_58[0]];
        DAT_24[DAT_08] = mVar1.DAT_04;
        DAT_30[DAT_08] = PTR_58[0].GetContainer(DAT_58[0], mVar1.DAT_02);
        DAT_58[0]++;
        DAT_08++;
        return false;
    }

    private bool FUN_56A70()
    {
        sbyte sVar1;
        int iVar2;
        ushort uVar3;
        MovContainer2 mVar4;

        iVar2 = DAT_08 - 1;
        mVar4 = (MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];
        uVar3 = (ushort)(DAT_24[iVar2] - 1);
        DAT_24[iVar2] = uVar3;

        if (uVar3 == 0)
        {
            sVar1 = (sbyte)(DAT_08 - 1);
            DAT_08 = sVar1;
            iVar2 = DAT_30[sVar1];
        }
        else
            iVar2 = DAT_58[0] - PTR_58[0].GetContainer(DAT_58[0], mVar4.DAT_02);

        DAT_58[0] = iVar2;
        return false;
    }

    private bool FUN_56AE0()
    {
        DAT_44[DAT_09] = DAT_58[0] + PTR_58[0].GetContainer
            (DAT_58[0], ((MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
        DAT_58[0]++;
        DAT_09++;
        return false;
    }

    private bool FUN_56B1C()
    {
        DAT_58[0]+= PTR_58[0].GetContainer
            (DAT_58[0], ((MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
        return false;
    }

    private bool FUN_56B3C()
    {
        DAT_58[0]++;
        return false;
    }

    private bool FUN_56B54()
    {
        int iVar1;
        MovContainer2 mVar1;

        mVar1 = (MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];

        if ((DAT_06 >> (mVar1.DAT_01 & 0x1f) & 1) == 0 &&
            mVar1.DAT_01 != 0)
            iVar1 = DAT_58[0] + 1;
        else
            iVar1 = DAT_58[0] + PTR_58[0].GetContainer(DAT_58[0], mVar1.DAT_02);

        DAT_58[0] = iVar1;
        return false;
    }

    private bool FUN_56B98()
    {
        int piVar1;

        piVar1 = DAT_AC;
        DAT_07++;
        DAT_58[piVar1] = DAT_58[0] + 1;
        PTR_58[piVar1] = PTR_58[0];
        DAT_AC = piVar1 + 1;
        PTR_58[0] = (MovScriptableObject)SceneManager.instance.scn.OBJECTS
            [((MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02];
        DAT_58[0] = 0;
        return false;
    }

    private bool FUN_56BF4()
    {
        int iVar1;

        iVar1 = DAT_AC;
        DAT_07--;
        DAT_AC = iVar1 - 1;
        DAT_58[0] = DAT_58[iVar1 - 1];
        PTR_58[0] = PTR_58[iVar1 - 1];
        return false;
    }

    private bool FUN_56C20()
    {
        return false;
    }

    private bool FUN_56C28()
    {
        bool bVar1;
        bool bVar2;

        bVar1 = InventoryManager.FUN_4A87C(2, 0);
        bVar2 = true;

        if (!bVar1)
        {
            bVar1 = InventoryManager.FUN_4A87C(2, 1);
            bVar2 = true;

            if (!bVar1)
            {
                bVar2 = false;
                DAT_58[0]++;
            }
        }

        return bVar2;
    }

    private bool FUN_56E9C()
    {
        DAT_58[0]++;
        return false;
    }

    private bool FUN_56C80()
    {
        byte bVar1;
        bool bVar2;

        bVar2 = InventoryManager.FUN_4A87C(((MovContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01,
                                           ((MovContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
        bVar1 = 2;

        if (!bVar2)
            bVar1 = 0x40;

        DAT_06 = bVar1;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_56CDC()
    {
        byte bVar1;
        int iVar2;
        int iVar3;
        MovContainer5 mVar3;

        mVar3 = (MovContainer5)PTR_58[0].CONTAINERS[DAT_58[0]];
        iVar2 = (int)FUN_55DC8((uint)DAT_0A << 0x10 | DAT_0B, mVar3.DAT_02);
        iVar3 = mVar3.DAT_04;

        if (iVar2 == iVar3)
            bVar1 = 42;
        else
        {
            bVar1 = 112;

            if (iVar3 <= iVar2)
                bVar1 = 76;
        }

        DAT_06 = bVar1;
        DAT_58[0]++;
        return false;
    }
}
