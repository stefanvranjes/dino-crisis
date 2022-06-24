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
    public short DAT_14; //0x14
    public short DAT_16; //0x16
    public short DAT_18; //0x18
    public short DAT_1A; //0x1A
    public short DAT_1C; //0x1C
    public short DAT_1E; //0x1E
    public short DAT_20; //0x20
    public short DAT_22; //0x22
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

    private void FUN_557B4(uint param1, int param2, int param3)
    {
        byte bVar1;
        short sVar2;
        ushort uVar3;
        CriPlayer oVar4;
        CriStatic oVar5;
        CriCamera oVar6;

        if (8 < param1 >> 0x10)
            return;

        bVar1 = (byte)param3;
        sVar2 = (short)param3;
        uVar3 = (ushort)param3;

        switch (param1 >> 0x10)
        {
            case 0:
                switch (param2)
                {
                    case 0:
                        GameManager.instance.DAT_78 = param3;
                        return;
                    case 1:
                        GameManager.instance.DAT_922C = bVar1;
                        return;
                    case 2:
                        GameManager.instance.DAT_28 = sVar2;
                        return;
                    case 3:
                        GameManager.instance.DAT_2A = sVar2;
                        return;
                    case 4:
                        GameManager.instance.DAT_2C = sVar2;
                        return;
                    case 5:
                        GameManager.instance.DAT_2E = sVar2;
                        return;
                    case 6:
                        GameManager.instance.DAT_28 = (short)param3;
                        GameManager.instance.DAT_2A = (short)(param3 >> 0x10);
                        return;
                    case 7:
                        GameManager.instance.DAT_9ADC = uVar3;
                        return;
                    case 8:
                        GameManager.instance.DAT_20 = bVar1;
                        return;
                    case 9:
                        SceneManager.instance.DAT_270 = bVar1;
                        return;
                    case 10:
                        GameManager.instance.DAT_3B = bVar1;
                        return;
                    default:
                        return;
                }
            case 1:
                switch (param2)
                {
                    case 0:
                        SceneManager.instance.DAT_C51D0 = param3;
                        return;
                    case 1:
                        SceneManager.instance.DAT_C51D4 = param3;
                        return;
                    case 2:
                        SceneManager.instance.DAT_C51B8 = param3;
                        return;
                    case 3:
                        SceneManager.instance.DAT_C51BC = param3;
                        return;
                    case 4:
                        SceneManager.instance.DAT_C51C0 = param3;
                        return;
                    case 5:
                        SceneManager.instance.DAT_C51C4 = param3;
                        return;
                    case 6:
                        SceneManager.instance.DAT_C51C8 = param3;
                        return;
                    case 7:
                        SceneManager.instance.DAT_C51CC = param3;
                        return;
                    case 8:
                        DAT_0C = sVar2;
                        return;
                    case 9:
                        DAT_0E = sVar2;
                        return;
                    case 10:
                        DAT_10 = sVar2;
                        return;
                    case 11:
                        DAT_12 = sVar2;
                        return;
                    case 12:
                        DAT_14 = sVar2;
                        return;
                    case 13:
                        DAT_16 = sVar2;
                        return;
                    case 14:
                        DAT_18 = sVar2;
                        return;
                    case 15:
                        DAT_1A = sVar2;
                        return;
                    case 16:
                        DAT_1C = sVar2;
                        return;
                    case 17:
                        DAT_1E = sVar2;
                        return;
                    case 18:
                        DAT_20 = sVar2;
                        return;
                    case 19:
                        DAT_22 = sVar2;
                        return;
                    default:
                        return;
                }
            case 2:
                oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[param1 & 0xffff];

                switch (param2)
                {
                    case 0:
                        oVar4.flags = (uint)param3;
                        return;
                    case 1:
                        oVar4.tags = (sbyte)bVar1;
                        return;
                    case 2:
                        oVar4.DAT_2F = bVar1;
                        return;
                    case 3:
                        oVar4.screen.x = sVar2;
                        return;
                    case 4:
                        oVar4.screen.y = sVar2;
                        return;
                    case 5:
                        oVar4.screen.z = sVar2;
                        return;
                    case 6:
                        oVar4.vr.x = sVar2;
                        return;
                    case 7:
                        oVar4.vr.y = sVar2;
                        return;
                    case 8:
                        oVar4.vr.z = sVar2;
                        return;
                    default:
                        return;
                    case 10:
                        oVar4.DAT_3C = bVar1;
                        return;
                    case 11:
                        oVar4.DAT_3D = bVar1;
                        return;
                    case 12:
                        oVar4.DAT_3E = bVar1;
                        return;
                    case 13:
                        oVar4.DAT_3F = bVar1;
                        return;
                    case 16:
                        oVar4.DAT_140 = uVar3;
                        break;
                    case 17:
                        oVar4.DAT_12C = uVar3;
                        break;
                    case 18:
                        oVar4.DAT_11E = bVar1;
                        return;
                    case 19:
                        oVar4.DAT_3C = (byte)param3;
                        oVar4.DAT_3D = (byte)(param3 >> 8);
                        oVar4.DAT_3E = (byte)(param3 >> 0x10);
                        oVar4.DAT_3F = (byte)(param3 >> 0x18);
                        return;
                    case 21:
                        oVar4.health = sVar2;
                        return;
                    case 23:
                        oVar4.DAT_40.x = sVar2;
                        return;
                    case 24:
                        oVar4.DAT_40.y = sVar2;
                        return;
                    case 25:
                        oVar4.DAT_40.z = sVar2;
                        return;
                    case 26:
                        oVar4.DAT_174 = bVar1;
                        return;
                    case 27:
                        oVar4.DAT_1C0 = oVar4.DAT_1C0 & 0xffffff00 | bVar1;
                        return;
                    case 28:
                        oVar4.DAT_1C0 = oVar4.DAT_1C0 & 0xffff00ff | (uint)bVar1 << 8;
                        return;
                    case 29:
                        oVar4.DAT_1C0 = oVar4.DAT_1C0 & 0xff00ffff | (uint)bVar1 << 0x10;
                        return;
                    case 30:
                        oVar4.DAT_1C0 = oVar4.DAT_1C0 & 0x00ffffff | (uint)bVar1 << 0x18;
                        return;
                    case 31:
                        oVar4.DAT_1C4 = (sbyte)bVar1;
                        return;
                    case 32:
                        oVar4.DAT_18E = bVar1;
                        return;
                    case 33:
                        oVar4.DAT_152 = sVar2;
                        return;
                    case 34:
                        oVar4.DAT_1A3 = bVar1;
                        return;
                    case 35:
                        oVar4.DAT_34.x = sVar2;
                        return;
                    case 36:
                        oVar4.DAT_34.y = sVar2;
                        return;
                    case 37:
                        oVar4.DAT_34.z = sVar2;
                        return;
                    case 38:
                        oVar4.DAT_164 = bVar1;
                        return;
                    case 39:
                        oVar4.DAT_165 = bVar1;
                        return;
                    case 40:
                        oVar4.DAT_166 = bVar1;
                        return;
                    case 41:
                        oVar4.DAT_167 = bVar1;
                        return;
                    case 42:
                        oVar4.DAT_1A7 = bVar1;
                        return;
                }

                break;
            case 3:
                oVar5 = SceneManager.instance.DAT_7CDC[param1 & 0xffff];

                switch (param2)
                {
                    case 0:
                        oVar5.flags = (uint)param3;
                        return;
                    case 1:
                        oVar5.DAT_2E = bVar1;
                        return;
                    case 2:
                        oVar5.DAT_2F = bVar1;
                        return;
                    case 3:
                        oVar5.screen.x = sVar2;
                        return;
                    case 4:
                        oVar5.screen.y = sVar2;
                        return;
                    case 5:
                        oVar5.screen.z = sVar2;
                        return;
                    case 6:
                        oVar5.vr.x = sVar2;
                        return;
                    case 7:
                        oVar5.vr.y = sVar2;
                        return;
                    case 8:
                        oVar5.vr.z = sVar2;
                        return;
                    default:
                        return;
                    case 10:
                        oVar5.tags = (sbyte)bVar1;
                        return;
                    case 14:
                        oVar5.DAT_48 = bVar1;
                        return;
                    case 15:
                        oVar5.DAT_4A = uVar3;
                        return;
                    case 27:
                        oVar5.DAT_74 = oVar5.DAT_74 & 0xffffff00 | bVar1;
                        return;
                    case 28:
                        oVar5.DAT_74 = oVar5.DAT_74 & 0xffff00ff | (uint)bVar1 >> 8;
                        return;
                    case 29:
                        oVar5.DAT_74 = oVar5.DAT_74 & 0xff00ffff | (uint)bVar1 >> 0x10;
                        return;
                    case 30:
                        oVar5.DAT_74 = oVar5.DAT_74 & 0x00ffffff | (uint)bVar1 >> 0x18;
                        return;
                    case 31:
                        oVar5.DAT_78 = bVar1;
                        return;
                }
            case 4:
                //...
                break;
            case 5:
                oVar6 = SceneManager.instance.cCamera;

                switch (param2)
                {
                    case 0:
                        oVar6.screen.x = sVar2;
                        return;
                    case 1:
                        oVar6.screen.y = sVar2;
                        return;
                    case 2:
                        oVar6.screen.z = sVar2;
                        return;
                    case 3:
                        oVar6.vr.x = sVar2;
                        return;
                    case 4:
                        oVar6.vr.y = sVar2;
                        return;
                    case 5:
                        oVar6.vr.z = sVar2;
                        return;
                    case 6:
                        oVar6.DAT_58 = (sbyte)bVar1;
                        return;
                    case 7:
                        oVar6.DAT_59 = (sbyte)bVar1;
                        return;
                    case 8:
                        oVar6.DAT_5A = (sbyte)bVar1;
                        return;
                    case 9:
                        oVar6.DAT_5B = (sbyte)bVar1;
                        return;
                    case 10:
                        oVar6.DAT_83 = bVar1;
                        return;
                    case 11:
                        oVar6.DAT_68 = bVar1;
                        return;
                    case 12:
                        oVar6.DAT_38 = sVar2;
                        return;
                    case 13:
                        oVar6.DAT_3A = sVar2;
                        return;
                    case 14:
                        oVar6.DAT_3A = sVar2;
                        return;
                    case 15:
                        oVar6.DAT_30.x = sVar2;
                        return;
                    case 16:
                        oVar6.DAT_30.y = sVar2;
                        return;
                    case 17:
                        oVar6.DAT_30.z = sVar2;
                        return;
                    default:
                        return;
                }
            case 6:
                //...
                break;
            case 7:
                //...
                break;
            case 8:
                //...
                break;
        }
    }

    private int FUN_55DC8(uint param1, int param2)
    {
        CriPlayer oVar1;
        CriStatic oVar2;
        CriCamera oVar3;

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
                        return GameManager.instance.DAT_9ADC;
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
            case 2:
                oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[param1 & 0xffff];

                switch (param2)
                {
                    case 0:
                        return (int)(oVar1.flags & 1);
                    case 1:
                        return oVar1.tags;
                    case 2:
                        return oVar1.DAT_2F;
                    case 3:
                        return oVar1.screen.x;
                    case 4:
                        return oVar1.screen.y;
                    case 5:
                        return oVar1.screen.z;
                    case 6:
                        return oVar1.vr.x;
                    case 7:
                        return oVar1.vr.y;
                    case 8:
                        return oVar1.vr.z;
                    case 10:
                    case 19:
                        return oVar1.DAT_3C;
                    case 11:
                        return oVar1.DAT_3D;
                    case 12:
                        return oVar1.DAT_3E;
                    case 13:
                        return oVar1.DAT_3F;
                    case 16:
                        return oVar1.DAT_140;
                    case 17:
                        return oVar1.DAT_12C;
                    case 18:
                        return oVar1.DAT_11E;
                    case 21:
                        return oVar1.health;
                    case 23:
                        return oVar1.DAT_40.x;
                    case 24:
                        return oVar1.DAT_40.y;
                    case 25:
                        return oVar1.DAT_40.z;
                    case 26:
                        return oVar1.DAT_174;
                    case 27:
                        return (byte)oVar1.DAT_1C0;
                    case 28:
                        return (byte)(oVar1.DAT_1C0 >> 8);
                    case 29:
                        return (byte)(oVar1.DAT_1C0 >> 0x10);
                    case 30:
                        return (byte)(oVar1.DAT_1C0 >> 0x18);
                    case 31:
                        return (byte)oVar1.DAT_1C4;
                    case 32:
                        return oVar1.DAT_18E;
                    case 33:
                        return oVar1.DAT_152;
                    case 34:
                        return oVar1.DAT_1A3;
                    case 38:
                        return oVar1.DAT_164;
                    case 39:
                        return oVar1.DAT_165;
                    case 40:
                        return oVar1.DAT_166;
                    case 41:
                        return oVar1.DAT_167;
                    case 42:
                        return oVar1.DAT_1A7;
                }

                break;
            case 3:
                oVar2 = SceneManager.instance.DAT_7CDC[param1 & 0xffff];

                switch (param2)
                {
                    case 0:
                        return (int)(oVar2.flags & 1);
                    case 1:
                        return oVar2.DAT_2E;
                    case 2:
                        return oVar2.DAT_2F;
                    case 3:
                        return oVar2.screen.x;
                    case 4:
                        return oVar2.screen.y;
                    case 5:
                        return oVar2.screen.z;
                    case 6:
                        return oVar2.vr.x;
                    case 7:
                        return oVar2.vr.y;
                    case 8:
                        return oVar2.vr.z;
                    case 10:
                        return oVar2.tags;
                    case 14:
                        return oVar2.DAT_48;
                    case 15:
                        return oVar2.DAT_4A;
                    case 27:
                        return (byte)oVar2.DAT_74;
                    case 28:
                        return (byte)(oVar2.DAT_74 >> 8);
                    case 29:
                        return (byte)(oVar2.DAT_74 >> 0x10);
                    case 30:
                        return (byte)(oVar2.DAT_74 >> 0x18);
                    case 31:
                        return oVar2.DAT_78;
                }

                break;
            case 4:
                //...
                break;
            case 5:
                oVar3 = SceneManager.instance.cCamera;

                switch (param2)
                {
                    case 0:
                        return oVar3.screen.x;
                    case 1:
                        return oVar3.screen.y;
                    case 2:
                        return oVar3.screen.z;
                    case 3:
                        return oVar3.vr.x;
                    case 4:
                        return oVar3.vr.y;
                    case 5:
                        return oVar3.vr.z;
                    case 6:
                        return oVar3.DAT_58;
                    case 7:
                        return oVar3.DAT_59;
                    case 8:
                        return oVar3.DAT_5A;
                    case 9:
                        return oVar3.DAT_5B;
                    case 10:
                        return oVar3.DAT_83;
                    case 11:
                        return oVar3.DAT_68;
                    case 12:
                        return oVar3.DAT_38;
                    case 13:
                        return oVar3.DAT_3A;
                    case 14:
                        return oVar3.DAT_3C;
                    case 15:
                        return oVar3.DAT_30.x;
                    case 16:
                        return oVar3.DAT_30.y;
                    case 17:
                        return oVar3.DAT_30.z;
                }

                break;
            case 6:
                //...
                break;
            case 7:
                //...
                break;
            case 8:
                //...
                break;
        }

        return 0;
    }

    private int FUN_56584(int param1, int param2, int param3)
    {
        switch (param3)
        {
            case 0:
                return param1 + param2;
            case 1:
                return param1 - param2;
            case 2:
                return param1 * param2;
            case 3:
                break;
            case 4:
                if (param2 == 0)
                    return 0; //trap(0x1c00)

                if (param2 == -1 && param2 == -0x80000000)
                    return 0; //trap(0x1800)

                return param1 % param2;
            case 5:
                return param1 | param2;
            case 6:
                return param1 & param2;
            case 7:
                return param1 ^ param2;
            case 8:
                return ~param1;
            case 9:
                return param1 << (param2 & 0x1f);
            case 10:
            case 11:
                return param1 >> (param2 & 0x1f);
            default:
                return param1;
        }

        if (param2 == 0)
            return 0; //trap(0x1c00)

        if (param2 == -1 && param1 == -0x80000000)
            return 0; //trap(0x1800)

        return param1 / param2;
    }

    private void FUN_5666C(int param1, int param2)
    {
        byte bVar1;

        bVar1 = 0x2a;

        if (param1 != param2)
        {
            if (param1 < param2)
                bVar1 = 0x70;
            else
                bVar1 = 0x4c;
        }

        DAT_06 = bVar1;
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
            bVar1 = 0x2a;
        else
        {
            bVar1 = 0x70;

            if (iVar3 <= iVar2)
                bVar1 = 0x4c;
        }

        DAT_06 = bVar1;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_56D5C()
    {
        ushort uVar1;

        DAT_05 = 2;
        uVar1 = (ushort)FUN_55DC8((uint)DAT_05 << 0x10 | DAT_0B, 
            ((MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01);
        DAT_00 = uVar1;
        DAT_58[0]++;
        return true;
    }

    private bool FUN_56DB4()
    {
        ushort uVar1;
        MovContainer2 mVar2;

        mVar2 = (MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];
        uVar1 = (ushort)FUN_55DC8((uint)DAT_0A << 0x10 | DAT_0B, mVar2.DAT_01);
        DAT_24[DAT_08] = uVar1;
        DAT_30[DAT_08] = DAT_58[0] + mVar2.DAT_02;
        DAT_58[0]++;
        DAT_08++;
        return false;
    }

    private bool FUN_56E44()
    {
        bool bVar1;

        bVar1 = InventoryManager.FUN_4A87C(((MovContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01,
                                           ((MovContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);

        if (bVar1)
            DAT_58[0]++;

        return !bVar1;
    }

    private bool FUN_56EB4()
    {
        MovContainer6 mVar4;
        CriSkinned oVar3;

        mVar4 = (MovContainer6)PTR_58[0].CONTAINERS[DAT_58[0]];

        if (mVar4.DAT_04 == 0 || !InventoryManager.FUN_4A87C(4, mVar4.DAT_04))
        {
            oVar3 = SceneManager.instance.DAT_27C[mVar4.DAT_01];
            oVar3.flags = 3;
            oVar3.tags = (sbyte)mVar4.DAT_02;
            oVar3.DAT_2F = mVar4.DAT_03;
            oVar3.DAT_163 = mVar4.DAT_04;
            oVar3.screen = mVar4.DAT_08;
            oVar3.DAT_34 = mVar4.DAT_08;
            oVar3.DAT_13C.x = mVar4.DAT_08.x;
            oVar3.DAT_13C.y = mVar4.DAT_08.z;
            oVar3.vr.y = mVar4.DAT_0E;

            if (mVar4.DAT_10 != null)
            {
                oVar3.cSkin = mVar4.DAT_10;
                oVar3.FUN_604A4(mVar4.DAT_10);
            }

            if (mVar4.DAT_14 != null)
                oVar3.DAT_98 = mVar4.DAT_14;

            oVar3.maxHealth = mVar4.DAT_06;
            oVar3.DAT_18E = mVar4.DAT_05;
            //...
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57018()
    {
        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57070()
    {
        MovContainer4 mVar2;

        mVar2 = (MovContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        DAT_0A = mVar2.DAT_01;
        DAT_0B = mVar2.DAT_02;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_570A0()
    {
        CriStatic oVar1;
        MovContainer8 mVar2;

        mVar2 = (MovContainer8)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar1 = SceneManager.instance.DAT_7CDC[mVar2.DAT_01];
        oVar1.flags = 3;
        oVar1.DAT_2E = mVar2.DAT_02;
        oVar1.DAT_48 = mVar2.DAT_03;
        oVar1.DAT_4A = mVar2.DAT_04;
        oVar1.cMesh = mVar2.DAT_08;
        oVar1.screen = mVar2.DAT_0C;
        oVar1.vr = mVar2.DAT_12;

        if (mVar2.DAT_18 == null)
            oVar1.cCollider = null;
        else
            oVar1.cCollider = mVar2.DAT_18;

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57188()
    {
        MovContainer9 mVar1;
        CriSkinned oVar2;

        oVar2 = SceneManager.instance.DAT_27C[DAT_0B];
        mVar1 = (MovContainer9)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar2.DAT_40 = new Vector3Int(0, 0, 0);
        oVar2.DAT_3C = 4;
        oVar2.DAT_3D = 0;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        oVar2.FUN_6103C(mVar1.DAT_04, mVar1.DAT_01, mVar1.DAT_02, mVar1.DAT_03);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57218()
    {
        MovContainer4 mVar1;

        mVar1 = (MovContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        InventoryManager.FUN_4A7E8(mVar1.DAT_01, mVar1.DAT_02, mVar1.DAT_03 != 0);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57268()
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

    private bool FUN_572C4()
    {
        int iVar1;
        MovContainer2 mVar2;

        mVar2 = (MovContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];
        iVar1 = Utilities.Rand();

        switch (mVar2.DAT_01)
        {
            case 0:
                SceneManager.instance.DAT_C51D0 = iVar1;
                break;
            case 1:
                SceneManager.instance.DAT_C51D4 = iVar1;
                break;
            case 2:
                SceneManager.instance.DAT_C51B8 = iVar1;
                break;
            case 3:
                SceneManager.instance.DAT_C51BC = iVar1;
                break;
            case 4:
                SceneManager.instance.DAT_C51C0 = iVar1;
                break;
            case 5:
                SceneManager.instance.DAT_C51C4 = iVar1;
                break;
            case 6:
                SceneManager.instance.DAT_C51C8 = iVar1;
                break;
            case 7:
                SceneManager.instance.DAT_C51CC = iVar1;
                break;
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57398()
    {
        MovContainer10 mVar1;
        int iVar2;

        mVar1 = (MovContainer10)PTR_58[0].CONTAINERS[DAT_58[0]];
        iVar2 = mVar1.DAT_01 + 4;
        SceneManager.instance.triggers[iVar2] = mVar1.DAT_04;
        mVar1.DAT_04.DAT_13 = true;

        switch (mVar1.DAT_02)
        {
            case 0:
            case 1:
            case 2:
            case 5:
            case 6:
            case 8:
            case 9:
            case 10:
            case 11:
            case 3:
            case 7:
                break;
            default:
                return false;
            case 4:
                SceneManager.instance.triggers[iVar2].FUN_57488(iVar2);
                break;
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57604()
    {
        int iVar1;
        MovContainer5 mVar2;

        mVar2 = (MovContainer5)PTR_58[0].CONTAINERS[DAT_58[0]];
        iVar1 = FUN_55DC8((uint)DAT_0A << 0x10 | DAT_0B, mVar2.DAT_02);
        FUN_5666C(iVar1, mVar2.DAT_04);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5766C()
    {
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B,
                  ((MovContainer5)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02,
                  ((MovContainer5)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_04);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_576C0()
    {
        int iVar1;
        MovContainer5 mVar2;

        mVar2 = (MovContainer5)PTR_58[0].CONTAINERS[DAT_58[0]];
        iVar1 = FUN_55DC8((uint)DAT_0A << 0x10 | DAT_0B, mVar2.DAT_02);
        iVar1 = FUN_56584(iVar1, mVar2.DAT_04, mVar2.DAT_01);
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B, mVar2.DAT_02, iVar1);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5774C()
    {
        byte bVar1;
        CriObject oVar2;
        MovContainer4 mVar3;

        mVar3 = (MovContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];

        if (mVar3.DAT_02 == 1)
        {
            bVar1 = DAT_0A;

            if (bVar1 == 3)
                oVar2 = SceneManager.instance.DAT_7CDC[DAT_0B];
            else
            {
                if (bVar1 < 4)
                {
                    oVar2 = null;

                    if (bVar1 == 2)
                        oVar2 = SceneManager.instance.DAT_27C[DAT_0B];
                }
                else
                {
                    oVar2 = null;

                    if (bVar1 == 4)
                        oVar2 = SceneManager.instance.DAT_5FCC[DAT_0B];
                }
            }

            //sound
        }
        else
            ; //FUN_5C860

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57870()
    {
        SceneManager.instance.triggers[((MovContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01].DAT_13 =
            ((MovContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_03 != 0;
        DAT_58[0]++;
        return false;
    }
}
