using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriScene : MonoBehaviour
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
    public _SCENE_OBJ_DATA[] PTR_58; //0x58
    public int DAT_AC; //0xAC
    public delegate bool FUN_9E540();
    public FUN_9E540[] PTR_FUN_9E540;

    private void Awake()
    {
        DAT_24 = new ushort[5];
        DAT_30 = new int[5];
        DAT_44 = new int[5];
        DAT_58 = new int[21];
        PTR_58 = new _SCENE_OBJ_DATA[21];
        PTR_FUN_9E540 = new FUN_9E540[114]
        {
            FUN_56698,
            FUN_566EC,
            FUN_567E4,
            FUN_5680C,
            FUN_56824,
            FUN_5687C,
            FUN_568F8,
            FUN_56960,
            FUN_569C0,
            FUN_56A1C,
            FUN_56A70, //10
            FUN_56AE0,
            FUN_56B1C,
            FUN_56B3C,
            FUN_56B54,
            FUN_56B98,
            FUN_56BF4,
            FUN_56C20,
            FUN_56C28,
            FUN_56E9C,
            FUN_56C80, //20
            FUN_56CDC,
            FUN_56D5C,
            FUN_56DB4,
            FUN_56E44,
            FUN_56698,
            FUN_56698,
            FUN_56698,
            FUN_56698,
            FUN_56698,
            FUN_56698, //30
            FUN_56698,
            FUN_56EB4,
            FUN_57018,
            FUN_57070,
            FUN_570A0,
            FUN_57188,
            FUN_57218,
            FUN_57268,
            FUN_572C4,
            FUN_57398, //40
            FUN_57604,
            FUN_5766C,
            FUN_576C0,
            FUN_5774C,
            FUN_57870,
            FUN_578B8,
            FUN_57E84,
            FUN_57970,
            FUN_579BC,
            FUN_57B28, //50
            FUN_57B6C,
            FUN_57C6C,
            FUN_57CB0,
            FUN_57D00,
            FUN_57DE8,
            FUN_57FE8,
            FUN_58048,
            FUN_580A8,
            FUN_5811C,
            FUN_581C0, //60
            FUN_58214,
            FUN_58384,
            FUN_583CC,
            FUN_5841C,
            FUN_58494,
            FUN_584E8,
            FUN_58688,
            FUN_586C4,
            FUN_58700,
            FUN_5873C, //70
            FUN_58778,
            FUN_587DC,
            FUN_588FC,
            FUN_58974,
            FUN_58A3C,
            FUN_58ACC,
            FUN_58BC8,
            FUN_58C6C,
            FUN_58D10,
            FUN_58D98, //80
            FUN_58E14,
            FUN_58EC8,
            FUN_58F20,
            FUN_58F38,
            FUN_590EC,
            FUN_591B8,
            FUN_59420,
            FUN_595FC,
            FUN_59994,
            FUN_59BFC, //90
            FUN_59D28,
            FUN_5A5B4,
            FUN_5A60C,
            FUN_5A66C,
            FUN_5A6A8,
            FUN_5A764,
            FUN_5A794,
            FUN_5A814,
            FUN_5A85C,
            FUN_5A9B0, //100
            FUN_5AAD4,
            FUN_5AB68,
            FUN_5AA08,
            FUN_5ABD8,
            FUN_5AC6C,
            FUN_5ACDC,
            FUN_5AD28,
            FUN_5AD90,
            FUN_5ADE0,
            FUN_5AE44, //110
            FUN_5AE78,
            FUN_56698,
            FUN_56698
        };
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
        PTR_58 = new _SCENE_OBJ_DATA[21];
    }

    private void FUN_557B4(uint param1, int param2, int param3)
    {
        byte bVar1;
        short sVar2;
        ushort uVar3;
        CriPlayer oVar4;
        CriStatic oVar5;
        CriCamera oVar6;
        CriParticle oVar7;
        CriTrigger oVar8;
        LightSource lVar9;

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
                oVar7 = SceneManager.instance.DAT_5FCC[param1 & 0xffff];

                switch (param2)
                {
                    case 0:
                        oVar7.flags = (uint)param3;
                        return;
                    case 1:
                        oVar7.tags = (sbyte)bVar1;
                        return;
                    case 2:
                        oVar7.DAT_2F = bVar1;
                        return;
                    case 3:
                        oVar7.screen.x = sVar2;
                        return;
                    case 4:
                        oVar7.screen.y = sVar2;
                        return;
                    case 5:
                        oVar7.screen.z = sVar2;
                        return;
                    case 6:
                        oVar7.vr.x = sVar2;
                        return;
                    case 7:
                        oVar7.vr.y = sVar2;
                        return;
                    case 8:
                        oVar7.vr.z = sVar2;
                        return;
                    default:
                        return;
                    case 10:
                        oVar7.DAT_3C = bVar1;
                        return;
                    case 11:
                        oVar7.DAT_3D = bVar1;
                        return;
                    case 12:
                        oVar7.DAT_3E = bVar1;
                        return;
                    case 13:
                        oVar7.DAT_3F = bVar1;
                        return;
                    case 23:
                        oVar7.DAT_40.x = sVar2;
                        return;
                    case 24:
                        oVar7.DAT_40.y = sVar2;
                        return;
                    case 25:
                        oVar7.DAT_40.z = sVar2;
                        return;
                    case 27:
                        oVar7.DAT_68 = bVar1;
                        return;
                    case 28:
                        oVar7.DAT_69 = bVar1;
                        return;
                    case 29:
                        oVar7.DAT_6A = bVar1;
                        return;
                    case 30:
                        oVar7.DAT_6B = bVar1;
                        return;
                    case 31:
                        oVar7.DAT_6C = bVar1;
                        return;
                }
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
                oVar8 = SceneManager.instance.DAT_9EEC[param1 & 0xffff];

                switch (param2)
                {
                    case 0:
                        oVar8.DAT_03 = bVar1;
                        return;
                    case 1:
                        oVar8.DAT_01 = bVar1;
                        return;
                    case 2:
                        oVar8.DAT_02 = bVar1;
                        return;
                    case 3:
                        oVar8.DAT_04.x = sVar2;
                        return;
                    case 4:
                        oVar8.DAT_04.y = sVar2;
                        return;
                    case 5:
                        oVar8.DAT_04.z = sVar2;
                        return;
                    case 6:
                        oVar8.DAT_0C = sVar2;
                        return;
                    case 7:
                        oVar8.DAT_0A = sVar2;
                        return;
                }
                break;
            case 7:
                lVar9 = SceneManager.instance.FUN_55790((int)param1 & 0xffff);

                switch (param2)
                {
                    case 0:
                        lVar9.DAT_04.x = sVar2;
                        return;
                    case 1:
                        lVar9.DAT_04.y = sVar2;
                        return;
                    case 2:
                        lVar9.DAT_04.z = sVar2;
                        return;
                    case 3:
                        lVar9.DAT_00 = bVar1;
                        return;
                    case 4:
                        lVar9.DAT_01 = bVar1;
                        return;
                    case 5:
                        lVar9.DAT_02 = bVar1;
                        return;
                    default:
                        return;
                }
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
        CriParticle oVar4;
        CriTrigger oVar5;
        LightSource lVar6;

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
                oVar4 = SceneManager.instance.DAT_5FCC[param1 & 0xffff];

                switch (param2)
                {
                    case 0:
                        return (int)(oVar4.flags & 1);
                    case 1:
                        return (byte)oVar4.tags;
                    case 2:
                        return oVar4.DAT_2F;
                    case 3:
                        return oVar4.screen.x;
                    case 4:
                        return oVar4.screen.y;
                    case 5:
                        return oVar4.screen.z;
                    case 6:
                        return oVar4.vr.x;
                    case 7:
                        return oVar4.vr.y;
                    case 8:
                        return oVar4.vr.z;
                    case 10:
                        return oVar4.DAT_3C;
                    case 11:
                        return oVar4.DAT_3D;
                    case 12:
                        return oVar4.DAT_3E;
                    case 13:
                        return oVar4.DAT_3F;
                    case 23:
                        return oVar4.DAT_40.x;
                    case 24:
                        return oVar4.DAT_40.y;
                    case 25:
                        return oVar4.DAT_40.z;
                    case 27:
                        return oVar4.DAT_68;
                    case 28:
                        return oVar4.DAT_69;
                    case 29:
                        return oVar4.DAT_6A;
                    case 30:
                        return oVar4.DAT_6B;
                    case 31:
                        return oVar4.DAT_6C;
                }
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
                oVar5 = SceneManager.instance.DAT_9EEC[(int)param1 & 0xffff];

                switch (param2)
                {
                    case 0:
                        return oVar5.DAT_03;
                    case 1:
                        return oVar5.DAT_01;
                    case 2:
                        return oVar5.DAT_02;
                    case 3:
                        return oVar5.DAT_04.x;
                    case 4:
                        return oVar5.DAT_04.y;
                    case 5:
                        return oVar5.DAT_04.z;
                    case 6:
                        return oVar5.DAT_0C;
                    case 7:
                        return oVar5.DAT_0A;
                }
                break;
            case 7:
                lVar6 = SceneManager.instance.FUN_55790((int)param1 & 0xffff);

                switch (param2)
                {
                    case 0:
                        return lVar6.DAT_04.x;
                    case 1:
                        return lVar6.DAT_04.y;
                    case 2:
                        return lVar6.DAT_04.z;
                    case 3:
                        return lVar6.DAT_00;
                    case 4:
                        return lVar6.DAT_01;
                    case 5:
                        return lVar6.DAT_02;
                }
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
        DataContainer2 mVar4;

        bVar2 = InventoryManager.FUN_4A87C(10, 9);

        if (!bVar2)
        {
            mVar4 = (DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];
            uVar1 = mVar4.DAT_02;
            iVar2 = mVar4.DAT_01;

            if (iVar2 == -1)
                iVar2 = (int)SceneManager.instance.FUN_566B0();

            SceneManager.instance.DAT_D7C0[iVar2].DAT_05 = 1;
            SceneManager.instance.DAT_D7C0[iVar2].PTR_58[0] = SceneManager.instance.scn.GetData(uVar1);
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
        uVar1 = ((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02;
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
            PTR_58[0] = SceneManager.instance.scn.GetData
                (((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
            DAT_58[0] = 0;
        }
        else
            DAT_58[0]++;

        return false;
    }

    private bool FUN_568F8()
    {
        SceneManager.instance.DAT_D7C0
            [((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01].ResetValues();
        DAT_58[0]++;
        return false;
    }

    private bool FUN_56960()
    {
        int iVar1;

        iVar1 = ((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01;

        if (SceneManager.instance.DAT_D7C0[iVar1].DAT_05 != 0)
            SceneManager.instance.DAT_D7C0[iVar1].DAT_05 = 0x80;

        DAT_58[0]++;
        return false;
    }

    private bool FUN_569C0()
    {
        int iVar1;

        iVar1 = ((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01;

        if (SceneManager.instance.DAT_D7C0[iVar1].DAT_05 == 0x80)
            SceneManager.instance.DAT_D7C0[iVar1].DAT_05 = 1;

        DAT_58[0]++;
        return false;
    }

    private bool FUN_56A1C()
    {
        DataContainer3 mVar1;

        mVar1 = (DataContainer3)PTR_58[0].CONTAINERS[DAT_58[0]];
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
        DataContainer2 mVar4;

        iVar2 = DAT_08 - 1;
        mVar4 = (DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];
        uVar3 = (ushort)(DAT_24[iVar2] - 1);
        DAT_24[iVar2] = uVar3;

        if (uVar3 == 0)
        {
            sVar1 = (sbyte)(DAT_08 - 1);
            DAT_08 = sVar1;
            iVar2 = DAT_30[sVar1];
        }
        else
            iVar2 = PTR_58[0].GetContainer(DAT_58[0], mVar4.DAT_02, true);

        DAT_58[0] = iVar2;
        return false;
    }

    private bool FUN_56AE0()
    {
        DAT_44[DAT_09] = PTR_58[0].GetContainer
            (DAT_58[0], ((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
        DAT_58[0]++;
        DAT_09++;
        return false;
    }

    private bool FUN_56B1C()
    {
        DAT_58[0] = PTR_58[0].GetContainer
            (DAT_58[0], ((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
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
        DataContainer2 mVar1;

        mVar1 = (DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];

        if ((DAT_06 >> (mVar1.DAT_01 & 0x1f) & 1) == 0 &&
            mVar1.DAT_01 != 0)
            iVar1 = DAT_58[0] + 1;
        else
            iVar1 = PTR_58[0].GetContainer(DAT_58[0], mVar1.DAT_02);

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
        PTR_58[0] = SceneManager.instance.scn.GetData
            (((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
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

        bVar2 = InventoryManager.FUN_4A87C(((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01,
                                           ((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
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
        DataContainer5 mVar3;

        mVar3 = (DataContainer5)PTR_58[0].CONTAINERS[DAT_58[0]];
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
            ((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01);
        DAT_00 = uVar1;
        DAT_58[0]++;
        return true;
    }

    private bool FUN_56DB4()
    {
        ushort uVar1;
        DataContainer2 mVar2;

        mVar2 = (DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];
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

        bVar1 = InventoryManager.FUN_4A87C(((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01,
                                           ((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);

        if (bVar1)
            DAT_58[0]++;

        return !bVar1;
    }

    private bool FUN_56EB4()
    {
        DataContainer6 mVar4;
        CriSkinned oVar3;

        mVar4 = (DataContainer6)PTR_58[0].CONTAINERS[DAT_58[0]];

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

            if (mVar4.DAT_10 != 0)
            {
                oVar3.cSkin = (Tmd2ScriptableObject)Utilities.GetRamObject(mVar4.DAT_10);
                oVar3.FUN_604A4(oVar3.cSkin);
                oVar3.materials = new Material[16];
                Tmd2ScriptableObject tmd = oVar3.cSkin;
                Material mat1 = new Material(GameManager.instance.materials[0]);
                Material mat2 = new Material(GameManager.instance.materials[3]);
                mat1.mainTexture = tmd.TEX_2D;
                mat1.SetTexture("_Tex8", tmd.TEX8_2D);
                mat1.SetTexture("_CLUT", tmd.CLUT_2D);
                oVar3.materials[0] = mat1;
                Tmd2ScriptableObject tmd2 = (Tmd2ScriptableObject)Utilities.GetRamObject(0x8018066c);
                mat2.mainTexture = tmd2.TEX_2D;
                mat2.SetTexture("_Tex8", tmd2.TEX8_2D);
                mat2.SetTexture("_CLUT", tmd2.CLUT_2D);
                oVar3.materials[3] = mat2;
                GameObject sdw = new GameObject("Shadow");
                oVar3.shadow = sdw.transform;
            }

            if (mVar4.DAT_14 != 0)
            {
                int length = ((RefScriptableObject)Utilities.GetRamObject(mVar4.DAT_14)).ASSET_REFS.Length;
                oVar3.DAT_98 = new TodScriptableObject[length];

                for (int i = 0; i < length; i++)
                    oVar3.DAT_98[i] = ((RefScriptableObject)Utilities.GetRamObject(mVar4.DAT_14)).ASSET_REFS[i] as TodScriptableObject;
            }

            oVar3.maxHealth = mVar4.DAT_06;
            oVar3.DAT_18E = mVar4.DAT_05;
            LevelManager.instance.PTR_FUN_B58C0[oVar3.tags]((CriPlayer)oVar3);
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57018()
    {
        DataContainer7 mVar1;

        mVar1 = (DataContainer7)PTR_58[0].CONTAINERS[DAT_58[0]];
        DialogManager.instance.FUN_1E2D8(SceneManager.instance.scn.endBuffer,
            (mVar1.DAT_04 - SceneManager.instance.scn.bufferOffset) / 2, 0, mVar1.DAT_02);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57070()
    {
        DataContainer4 mVar2;

        mVar2 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        DAT_0A = mVar2.DAT_01;
        DAT_0B = mVar2.DAT_02;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_570A0()
    {
        CriStatic oVar1;
        DataContainer8 mVar2;

        mVar2 = (DataContainer8)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar1 = SceneManager.instance.DAT_7CDC[mVar2.DAT_01];
        oVar1.flags = 3;
        oVar1.DAT_2E = mVar2.DAT_02;
        oVar1.DAT_48 = mVar2.DAT_03;
        oVar1.DAT_4A = mVar2.DAT_04;
        oVar1.cMesh = (TmdScriptableObject)Utilities.GetRamObject(mVar2.DAT_08);
        oVar1.SetMaterials();
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
        DataContainer9 mVar1;
        CriSkinned oVar2;

        oVar2 = SceneManager.instance.DAT_27C[DAT_0B];
        mVar1 = (DataContainer9)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar2.DAT_40 = new Vector3Int(0, 0, 0);
        oVar2.DAT_3C = 4;
        oVar2.DAT_3D = 0;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;

        if (mVar1.hasPointer)
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(mVar1.ramAddress), mVar1.DAT_01, mVar1.DAT_02, mVar1.DAT_03);
        else
            oVar2.FUN_6103C((int)mVar1.ramValue, mVar1.DAT_01, mVar1.DAT_02, mVar1.DAT_03);

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57218()
    {
        DataContainer4 mVar1;

        mVar1 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        InventoryManager.FUN_4A7E8(mVar1.DAT_01, mVar1.DAT_02, mVar1.DAT_03 != 0);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57268()
    {
        byte bVar1;
        bool bVar2;

        bVar2 = InventoryManager.FUN_4A87C(((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01,
                                           ((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
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
        DataContainer2 mVar2;

        mVar2 = (DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]];
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
        DataContainer10 mVar1;
        int iVar2;

        mVar1 = (DataContainer10)PTR_58[0].CONTAINERS[DAT_58[0]];
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
                SceneManager.instance.FUN_57488
                    ((Trigger6)SceneManager.instance.triggers[iVar2], iVar2);
                break;
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57604()
    {
        int iVar1;
        DataContainer5 mVar2;

        mVar2 = (DataContainer5)PTR_58[0].CONTAINERS[DAT_58[0]];
        iVar1 = FUN_55DC8((uint)DAT_0A << 0x10 | DAT_0B, mVar2.DAT_02);
        FUN_5666C(iVar1, mVar2.DAT_04);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5766C()
    {
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B,
                  ((DataContainer5)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02,
                  ((DataContainer5)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_04);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_576C0()
    {
        int iVar1;
        DataContainer5 mVar2;

        mVar2 = (DataContainer5)PTR_58[0].CONTAINERS[DAT_58[0]];
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
        DataContainer4 mVar3;

        mVar3 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];

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

            GameManager.instance.FUN_5C94C(oVar2, mVar3.DAT_01);
        }
        else
            GameManager.instance.FUN_5C860(mVar3.DAT_01);

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57870()
    {
        SceneManager.instance.triggers[((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01 + 4].DAT_13 =
            ((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_03 != 0;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_578B8()
    {
        CriCamera oVar1;
        DataContainer11 mVar2;

        oVar1 = SceneManager.instance.cCamera;
        mVar2 = (DataContainer11)PTR_58[0].CONTAINERS[DAT_58[0]];
        SceneManager.instance.FUN_26EBC(2, 0);
        oVar1.DAT_36 = mVar2.DAT_10;
        oVar1.DAT_26 = mVar2.DAT_12;
        SceneManager.instance.FUN_264C4(oVar1.DAT_36,
            (short)mVar2.DAT_02.x, (short)mVar2.DAT_02.y, (short)mVar2.DAT_02.z);
        SceneManager.instance.FUN_26504(oVar1.DAT_26, 
            (short)mVar2.DAT_08.x, (short)mVar2.DAT_08.y, (short)mVar2.DAT_08.z);
        oVar1.DAT_73 = 1;
        oVar1.DAT_72 |= 1;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57E84()
    {
        byte bVar1;
        CriObject oVar2;
        DataContainer4 mVar3;

        mVar3 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        bVar1 = mVar3.DAT_01;

        if (bVar1 == 3)
            oVar2 = SceneManager.instance.DAT_7CDC[mVar3.DAT_02];
        else
        {
            if (bVar1 < 4)
            {
                if (bVar1 != 2) goto LAB_57FBC;

                ((CriPlayer)SceneManager.instance.DAT_27C[mVar3.DAT_02]).FUN_6016C();
                oVar2 = SceneManager.instance.DAT_27C[mVar3.DAT_02];
            }
            else
            {
                if (bVar1 == 4)
                    oVar2 = SceneManager.instance.DAT_5FCC[mVar3.DAT_02];
                else
                {
                    if (bVar1 != 8) goto LAB_57FBC;

                    //...
                    oVar2 = null; //tmp
                }
            }
        }

        oVar2.ResetValues();
        LAB_57FBC:
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57970()
    {
        SceneManager.instance.FUN_26EBC(((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01,
                                        ((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_579BC()
    {
        byte bVar1;
        CriObject oVar2;
        LightSource lVar3;

        bVar1 = DAT_0A;

        if (bVar1 == 3)
            oVar2 = SceneManager.instance.DAT_7CDC[DAT_0B];
        else
        {
            if (bVar1 < 4)
            {
                if (bVar1 != 2) goto LAB_57B04;

                oVar2 = SceneManager.instance.DAT_27C[DAT_0B];
            }
            else
            {
                if (bVar1 != 4)
                {
                    if (bVar1 == 7)
                    {
                        lVar3 = SceneManager.instance.FUN_55790(DAT_0B);
                        lVar3.DAT_04.x += DAT_0C;
                        lVar3.DAT_04.y += DAT_0E;
                        lVar3.DAT_04.z += DAT_10;
                    }

                    goto LAB_57B04;
                }

                oVar2 = SceneManager.instance.DAT_5FCC[DAT_0B];
            }
        }

        oVar2.screen.x += DAT_0C;
        oVar2.screen.y += DAT_0E;
        oVar2.screen.z += DAT_10;
        LAB_57B04:
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57B28()
    {
        DAT_0C += DAT_12;
        DAT_0E += DAT_14;
        DAT_10 += DAT_16;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57B6C()
    {
        byte bVar1;
        CriObject oVar2;

        bVar1 = DAT_0A;

        if (bVar1 == 3)
            oVar2 = SceneManager.instance.DAT_7CDC[DAT_0B];
        else
        {
            if (bVar1 < 4)
            {
                if (bVar1 != 2) goto LAB_57C54;

                oVar2 = SceneManager.instance.DAT_27C[DAT_0B];
            }
            else
            {
                if (bVar1 != 4) goto LAB_57C54;

                oVar2 = SceneManager.instance.DAT_5FCC[DAT_0B];
            }
        }

        oVar2.vr.x += DAT_18;
        oVar2.vr.y += DAT_1A;
        oVar2.vr.z += DAT_1C;
        LAB_57C54:
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57C6C()
    {
        DAT_18 += DAT_1E;
        DAT_1A += DAT_20;
        DAT_1C += DAT_22;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57CB0()
    {
        DataContainer12 mVar1;

        mVar1 = (DataContainer12)PTR_58[0].CONTAINERS[DAT_58[0]];
        GameManager.instance.FUN_46C0C(mVar1.DAT_01, (uint)(int)mVar1.DAT_04, mVar1.DAT_02);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57D00()
    {
        CriSkinned oVar1;
        DataContainer13 mVar2;

        mVar2 = (DataContainer13)PTR_58[0].CONTAINERS[DAT_58[0]];
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B, 3, mVar2.DAT_02);
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B, 4, mVar2.DAT_04);
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B, 5, mVar2.DAT_06);

        if (DAT_0A == 2)
        {
            oVar1 = SceneManager.instance.DAT_27C[DAT_0B];
            oVar1.DAT_13C.x = mVar2.DAT_02;
            oVar1.DAT_13C.y = mVar2.DAT_06;
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_57DE8()
    {
        DataContainer13 mVar1;

        mVar1 = (DataContainer13)PTR_58[0].CONTAINERS[DAT_58[0]];
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B, 6, mVar1.DAT_02);
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B, 7, mVar1.DAT_04);
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B, 8, mVar1.DAT_06);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_57FE8()
    {
        //...
        DAT_AC++;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58048()
    {
        //...
        DAT_AC--;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_580A8()
    {
        CriSkinned oVar1;
        DataContainer14 mVar2;
        uint uVar3;

        mVar2 = (DataContainer14)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar1 = SceneManager.instance.DAT_27C[DAT_0B];
        oVar1.PTR_190 = mVar2.DAT_04;
        oVar1.DAT_190 = 0;
        oVar1.DAT_18F = 1;
        oVar1.DAT_176 = mVar2.DAT_03;
        uVar3 = (uint)mVar2.DAT_02 << 8 | 4;
        oVar1.DAT_3C = (byte)uVar3;
        oVar1.DAT_3D = (byte)(uVar3 >> 8);
        oVar1.DAT_3E = (byte)(uVar3 >> 0x10);
        oVar1.DAT_3F = (byte)(uVar3 >> 0x18);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5811C()
    {
        CriPlayer oVar1;
        uint uVar2;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[DAT_0B];
        uVar2 = (uint)((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01 << 8 | 1;
        oVar1.DAT_3C = (byte)uVar2;
        oVar1.DAT_3D = (byte)(uVar2 >> 8);
        oVar1.DAT_3E = (byte)(uVar2 >> 0x10);
        oVar1.DAT_3F = (byte)(uVar2 >> 0x18);

        if (DAT_0B == 10)
        {
            oVar1.FUN_5348C(0x70, 0x70);
            oVar1.flags |= 2;
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_581C0()
    {
        CriStatic oVar1;
        DataContainer15 mVar2;

        mVar2 = (DataContainer15)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar1 = SceneManager.instance.DAT_7CDC[mVar2.DAT_01];
        oVar1.DAT_48 = mVar2.DAT_02;
        oVar1.DAT_4A = mVar2.DAT_04;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58214()
    {
        CriPlayer oVar1;
        DataContainer16 mVar2;

        mVar2 = (DataContainer16)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[DAT_0B];

        switch (mVar2.DAT_01)
        {
            case 0:
                oVar1.FUN_53674((sbyte)mVar2.DAT_0A, (sbyte)mVar2.DAT_0B);
                break;
            case 1:
                oVar1.FUN_5348C((sbyte)mVar2.DAT_0A, (sbyte)mVar2.DAT_0B);
                break;
            case 2:
                oVar1.FUN_536DC((uint)(int)mVar2.DAT_04.x, mVar2.DAT_0A, mVar2.DAT_02);
                break;
            case 3:
                oVar1.FUN_53748((uint)(int)mVar2.DAT_04.y, mVar2.DAT_0B, mVar2.DAT_02);
                break;
            case 4:
                oVar1.FUN_53854((short)mVar2.DAT_04.x, (short)mVar2.DAT_04.y, (sbyte)mVar2.DAT_0A, (sbyte)mVar2.DAT_0B);
                break;
            case 5:
                oVar1.FUN_53520((byte)mVar2.DAT_04.z, (sbyte)mVar2.DAT_0A, (sbyte)mVar2.DAT_0B);
                break;
            case 6:
                oVar1.FUN_537B4(mVar2.DAT_04, (sbyte)mVar2.DAT_0A, (sbyte)mVar2.DAT_0B);
                break;
            case 7:
                oVar1.FUN_535E4((sbyte)mVar2.DAT_0A, (sbyte)mVar2.DAT_0B);
                break;
            case 8:
                oVar1.FUN_538DC((sbyte)mVar2.DAT_0A, (sbyte)mVar2.DAT_0B);
                break;
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_58384()
    {
        GameManager.instance.FUN_2984C(((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_583CC()
    {
        DataContainer15 mVar1;

        mVar1 = (DataContainer15)PTR_58[0].CONTAINERS[DAT_58[0]];
        SceneManager.instance.FUN_8133C(mVar1.DAT_01, mVar1.DAT_04, mVar1.DAT_03);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5841C()
    {
        DataContainer17 mVar1;

        mVar1 = (DataContainer17)PTR_58[0].CONTAINERS[DAT_58[0]];
        SceneManager.instance.FUN_4A784(mVar1.DAT_01, mVar1.DAT_02, mVar1.DAT_06,
                                        mVar1.DAT_08, mVar1.DAT_0A, mVar1.DAT_03,
                                        mVar1.DAT_04, mVar1.DAT_05);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58494()
    {
        FloorCollider fVar1;

        fVar1 = SceneManager.instance.FUN_645C8(((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01,
                                               ((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02);
        fVar1.DAT_04[1].x = 0;
        fVar1.DAT_04[1].y = 0;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_584E8()
    {
        short sVar1;
        CriParticle oVar2;
        CriBone oVar3;
        DataContainer23 mVar4;

        mVar4 = (DataContainer23)PTR_58[0].CONTAINERS[DAT_58[0]];

        if ((sbyte)mVar4.DAT_01 == -1)
        {
            oVar2 = SceneManager.instance.FUN_5FFA0();

            if (oVar2 == null) goto LAB_58660;
        }
        else
            oVar2 = SceneManager.instance.DAT_5FCC[mVar4.DAT_01];

        oVar2.ResetValues();
        oVar2.flags = 1;
        oVar2.tags = (sbyte)mVar4.DAT_02;
        oVar2.DAT_2F = mVar4.DAT_03;
        oVar2.screen = mVar4.DAT_04;

        if (mVar4.DAT_0A == 2)
        {
            oVar3 = (CriBone)Utilities.FUN_601C8
                (SceneManager.instance.DAT_27C[mVar4.DAT_0B & 0xf].skeleton, (int)((uint)mVar4.DAT_0B >> 4));
            oVar2.DAT_4C = oVar3;
        }
        else
        {
            if (mVar4.DAT_0A == 3)
                oVar2.DAT_4C = SceneManager.instance.DAT_7CDC[mVar4.DAT_0B & 0xf];
            else
                oVar2.DAT_4C = null;
        }

        oVar2.DAT_68 = (byte)mVar4.DAT_10;
        oVar2.DAT_69 = (byte)(mVar4.DAT_10 >> 8);
        oVar2.DAT_6A = (byte)(mVar4.DAT_10 >> 0x10);
        oVar2.DAT_6B = (byte)(mVar4.DAT_10 >> 0x18);
        sVar1 = mVar4.DAT_0C;
        oVar2.DAT_50 = new Color32(0x80, 0x80, 0x80, 0x2c);
        oVar2.vr.y = sVar1;
        LAB_58660:
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58688()
    {
        DataContainer18 mVar2;

        mVar2 = (DataContainer18)PTR_58[0].CONTAINERS[DAT_58[0]];
        DAT_0C = mVar2.DAT_02;
        DAT_0E = mVar2.DAT_04;
        DAT_10 = mVar2.DAT_06;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_586C4()
    {
        DataContainer18 mVar2;

        mVar2 = (DataContainer18)PTR_58[0].CONTAINERS[DAT_58[0]];
        DAT_12 = mVar2.DAT_02;
        DAT_14 = mVar2.DAT_04;
        DAT_16 = mVar2.DAT_06;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58700()
    {
        DataContainer18 mVar2;

        mVar2 = (DataContainer18)PTR_58[0].CONTAINERS[DAT_58[0]];
        DAT_18 = mVar2.DAT_02;
        DAT_1A = mVar2.DAT_04;
        DAT_1C = mVar2.DAT_06;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5873C()
    {
        DataContainer18 mVar2;

        mVar2 = (DataContainer18)PTR_58[0].CONTAINERS[DAT_58[0]];
        DAT_1E = mVar2.DAT_02;
        DAT_20 = mVar2.DAT_04;
        DAT_22 = mVar2.DAT_06;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58778()
    {
        if (((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01 == 1)
            GameManager.instance.FUN_767A8();
        else
            GameManager.instance.FUN_7683C();

        DAT_58[0]++;
        return false;
    }

    private bool FUN_587DC()
    {
        bool bVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;
        DataContainer4 mVar5;
        CriSkinned oVar5;
        CriBone oVar6;

        mVar5 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        uVar2 = (uint)FUN_55DC8((uint)mVar5.DAT_01 << 0x10 | mVar5.DAT_02, 0);

        if (uVar2 != 0)
        {
            bVar1 = mVar5.DAT_03 != 1;

            if (bVar1)
                uVar2 &= 0xfffffffd;
            else
                uVar2 |= 2;

            FUN_557B4((uint)mVar5.DAT_01 << 0x10 | mVar5.DAT_02, 0, (int)uVar2);

            if (mVar5.DAT_01 == 2)
            {
                oVar5 = SceneManager.instance.DAT_27C[mVar5.DAT_02];
                iVar3 = oVar5.boneCount;
                oVar6 = oVar5.skeleton;
                uVar4 = 1;

                if (!bVar1)
                    uVar4 = 3;

                if (iVar3 != 0)
                {
                    iVar3 -= 2;

                    do
                    {
                        oVar6.flags = uVar4;
                        oVar6 = (CriBone)oVar6.next;
                        bVar1 = iVar3 != -1;
                        iVar3--;
                    } while (bVar1);
                }
            }
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_588FC()
    {
        byte bVar1;
        uint uVar2;
        DataContainer4 mVar3;

        mVar3 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        uVar2 = (uint)FUN_55DC8((uint)DAT_0A << 0x10 | DAT_0B, mVar3.DAT_01);
        bVar1 = 2;

        if ((uVar2 & 1 << (mVar3.DAT_02 & 0x1f)) == 0)
            bVar1 = 0x40;

        DAT_06 = bVar1;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58974()
    {
        byte bVar1;
        DataContainer4 mVar2;
        CriObject oVar3;

        mVar2 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        bVar1 = mVar2.DAT_01;

        if (bVar1 == 3)
            oVar3 = SceneManager.instance.DAT_7CDC[mVar2.DAT_02];
        else
        {
            if (bVar1 < 4)
            {
                if (bVar1 != 2) goto LAB_58A24;

                oVar3 = SceneManager.instance.DAT_27C[mVar2.DAT_02];
            }
            else
            {
                if (bVar1 != 4) goto LAB_58A24;

                oVar3 = SceneManager.instance.DAT_5FCC[mVar2.DAT_02];
            }
        }

        SceneManager.instance.cCamera.DAT_64 = oVar3;
        LAB_58A24:
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58A3C()
    {
        CriCamera oVar1;
        DataContainer19 mVar2;

        oVar1 = SceneManager.instance.cCamera;
        mVar2 = (DataContainer19)PTR_58[0].CONTAINERS[DAT_58[0]];
        SceneManager.instance.FUN_26EBC(4, 0);
        oVar1.DAT_46 = mVar2.DAT_04;
        oVar1.DAT_74 = mVar2.DAT_06;
        oVar1.DAT_76 = mVar2.DAT_08;
        oVar1.DAT_78 = mVar2.DAT_0A;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58ACC()
    {
        CriCamera oVar1;
        DataContainer20 mVar2;

        oVar1 = SceneManager.instance.cCamera;
        mVar2 = (DataContainer20)PTR_58[0].CONTAINERS[DAT_58[0]];
        SceneManager.instance.FUN_26EBC(2, 0);
        oVar1.DAT_36 = mVar2.DAT_08;
        oVar1.DAT_3E = mVar2.DAT_0A;
        oVar1.DAT_50 = mVar2.DAT_0C;
        oVar1.DAT_52 = mVar2.DAT_0E;
        SceneManager.instance.FUN_264C4(oVar1.DAT_36, 
            (short)mVar2.DAT_02.x, (short)mVar2.DAT_02.y, (short)mVar2.DAT_02.z);
        oVar1.DAT_26 = mVar2.DAT_18;
        oVar1.SDAT_2E = mVar2.DAT_1A;
        oVar1.DAT_54 = mVar2.DAT_1C;
        oVar1.DAT_56 = mVar2.DAT_1E;
        SceneManager.instance.FUN_26504(oVar1.DAT_26, 
            (short)mVar2.DAT_12.x, (short)mVar2.DAT_12.y, (short)mVar2.DAT_12.z);
        oVar1.DAT_73 = 1;
        oVar1.DAT_72 |= 1;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58BC8()
    {
        CriCamera oVar1;
        DataContainer13 mVar2;

        oVar1 = SceneManager.instance.cCamera;
        mVar2 = (DataContainer13)PTR_58[0].CONTAINERS[DAT_58[0]];

        if ((mVar2.DAT_01 & 1) != 0)
            oVar1.DAT_36 = mVar2.DAT_02;

        if ((mVar2.DAT_01 & 2) != 0)
            oVar1.DAT_3E = mVar2.DAT_04;

        if ((mVar2.DAT_01 & 4) != 0)
            oVar1.DAT_26 = mVar2.DAT_02;

        if ((mVar2.DAT_01 & 8) != 0)
            oVar1.SDAT_2E = mVar2.DAT_04;

        DAT_58[0]++;
        return false;
    }

    private bool FUN_58C6C()
    {
        CriCamera oVar1;
        DataContainer13 mVar2;

        oVar1 = SceneManager.instance.cCamera;
        mVar2 = (DataContainer13)PTR_58[0].CONTAINERS[DAT_58[0]];

        if ((mVar2.DAT_01 & 1) != 0)
            oVar1.DAT_50 = mVar2.DAT_02;

        if ((mVar2.DAT_01 & 2) != 0)
            oVar1.DAT_52 = mVar2.DAT_04;

        if ((mVar2.DAT_01 & 4) != 0)
            oVar1.DAT_54 = mVar2.DAT_02;

        if ((mVar2.DAT_01 & 8) != 0)
            oVar1.DAT_56 = mVar2.DAT_04;

        DAT_58[0]++;
        return false;
    }

    private bool FUN_58D10()
    {
        int iVar1;
        int iVar2;
        DataContainer21 mVar3;

        mVar3 = (DataContainer21)PTR_58[0].CONTAINERS[DAT_58[0]];
        iVar1 = FUN_55DC8((uint)DAT_0A << 0x10 | DAT_0B, mVar3.DAT_02);
        iVar2 = FUN_55DC8((uint)DAT_0A << 0x10 | DAT_0B, mVar3.DAT_05);
        FUN_5666C(iVar1, iVar2);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58D98()
    {
        int iVar1;
        DataContainer21 mVar2;

        mVar2 = (DataContainer21)PTR_58[0].CONTAINERS[DAT_58[0]];
        iVar1 = FUN_55DC8((uint)mVar2.DAT_03 << 0x10 | mVar2.DAT_04, mVar2.DAT_05);
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B, mVar2.DAT_02, iVar1);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58E14()
    {
        int iVar1;
        int iVar2;
        DataContainer21 mVar3;

        mVar3 = (DataContainer21)PTR_58[0].CONTAINERS[DAT_58[0]];
        iVar1 = FUN_55DC8((uint)DAT_0A << 0x10 | DAT_0B, mVar3.DAT_02);
        iVar2 = FUN_55DC8((uint)mVar3.DAT_03 << 0x10 | mVar3.DAT_04, mVar3.DAT_05);
        iVar1 = FUN_56584(iVar1, iVar2, mVar3.DAT_01);
        FUN_557B4((uint)DAT_0A << 0x10 | DAT_0B, mVar3.DAT_02, iVar1);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58EC8()
    {
        byte bVar1;
        bool bVar2;

        bVar2 = InventoryManager.FUN_4A87C(11, 
            ((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01);
        bVar1 = 2;

        if (!bVar2)
            bVar1 = 0x40;

        DAT_06 = bVar1;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58F20()
    {
        DAT_58[0]++;
        return false;
    }

    private bool FUN_58F38()
    {
        byte bVar1;
        DataContainer4 mVar2;
        CriObject oVar3;

        mVar2 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];

        if (DAT_0A != 3)
        {
            if (DAT_0A != 4) goto LAB_590D4;

            bVar1 = mVar2.DAT_01;

            if (bVar1 == 3)
                oVar3 = SceneManager.instance.DAT_7CDC[mVar2.DAT_02];
            else
            {
                if (bVar1 < 4)
                {
                    if (bVar1 != 2) goto LAB_590D4;

                    oVar3 = SceneManager.instance.DAT_27C[mVar2.DAT_02];
                }
                else
                {
                    if (bVar1 != 4) goto LAB_590D4;

                    oVar3 = SceneManager.instance.DAT_5FCC[mVar2.DAT_02];
                }
            }

            SceneManager.instance.DAT_5FCC[DAT_0B].DAT_4C = oVar3;
            goto LAB_590D4;
        }

        bVar1 = mVar2.DAT_01;

        if (bVar1 == 3)
            oVar3 = SceneManager.instance.DAT_7CDC[mVar2.DAT_02];
        else
        {
            if (bVar1 < 4)
            {
                if (bVar1 != 2) goto LAB_590D4;

                oVar3 = SceneManager.instance.DAT_27C[mVar2.DAT_02];
            }
            else
            {
                if (bVar1 != 4) goto LAB_590D4;

                oVar3 = SceneManager.instance.DAT_5FCC[mVar2.DAT_02];
            }
        }

        SceneManager.instance.DAT_7CDC[DAT_0B].DAT_40 = oVar3;
        LAB_590D4:
        DAT_58[0]++;
        return false;
    }

    private bool FUN_590EC()
    {
        byte bVar1;
        DataContainer19 mVar3;
        Vector3Int local_248;

        mVar3 = (DataContainer19)PTR_58[0].CONTAINERS[DAT_58[0]];
        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_591B8()
    {
        ushort uVar1;
        short sVar2;
        CriParticle oVar3;
        CriObject oVar4;
        DataContainer24 mVar5;

        mVar5 = (DataContainer24)PTR_58[0].CONTAINERS[DAT_58[0]];

        if ((sbyte)mVar5.DAT_01 == -1)
        {
            oVar3 = SceneManager.instance.FUN_5FFA0();

            if (oVar3 == null) goto LAB_593F8;
        }
        else
            oVar3 = SceneManager.instance.DAT_5FCC[mVar5.DAT_01];

        oVar3.ResetValues();
        oVar3.flags = 1;
        oVar3.tags = (sbyte)mVar5.DAT_02;
        oVar3.DAT_2F = mVar5.DAT_03;

        if (mVar5.DAT_0C == 2)
        {
            oVar4 = Utilities.FUN_601C8(SceneManager.instance.DAT_27C[mVar5.DAT_0D & 0xf].skeleton, mVar5.DAT_0D & 0xf);
            oVar3.screen.x = oVar4.screen.x + mVar5.DAT_04.x;
            oVar3.screen.y = oVar4.screen.y + mVar5.DAT_04.y;
            sVar2 = (short)(oVar4.screen.z + mVar5.DAT_04.z);
        }
        else
        {
            if (mVar5.DAT_0C == 3)
            {
                oVar3.screen.x = SceneManager.instance.DAT_7CDC[mVar5.DAT_0D].screen.x + mVar5.DAT_04.x;
                oVar3.screen.y = SceneManager.instance.DAT_7CDC[mVar5.DAT_0D].screen.y + mVar5.DAT_04.y;
                sVar2 = (short)(SceneManager.instance.DAT_7CDC[mVar5.DAT_0D].screen.z + mVar5.DAT_04.z);
            }
            else
            {
                oVar3.screen.x = mVar5.DAT_04.x;
                oVar3.screen.y = mVar5.DAT_04.y;
                sVar2 = (short)mVar5.DAT_04.z;
            }
        }

        oVar3.screen.z = sVar2;
        oVar3.DAT_68 = (byte)mVar5.DAT_18;
        oVar3.DAT_69 = (byte)(mVar5.DAT_18 >> 8);
        oVar3.DAT_6A = (byte)(mVar5.DAT_18 >> 0x10);
        oVar3.DAT_6B = (byte)(mVar5.DAT_18 >> 0x18);
        oVar3.vr.y = mVar5.DAT_0A;
        oVar3.DAT_56 = (ushort)(mVar5.DAT_0E | 0x60);
        oVar3.DAT_54 = mVar5.DAT_10;
        uVar1 = mVar5.DAT_12;
        oVar3.DAT_62 = uVar1;
        oVar3.DAT_60 = uVar1;
        //FUN_606A8
        oVar3.DAT_50 = new Color32(0x80, 0x80, 0x80, 0x2c);
        oVar3.DAT_4C = null;
        LAB_593F8:
        DAT_58[0]++;
        return false;
    }

    private bool FUN_59420()
    {
        byte bVar1;
        CriPlayer oVar2;
        DataContainer4 mVar3;
        uint uVar4;
        uint uVar5;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        mVar3 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        bVar1 = mVar3.DAT_01;

        if (bVar1 == 1)
        {
            if (mVar3.DAT_02 == 1)
                oVar2.DAT_1C0 |= 4;
            else
                oVar2.DAT_1C0 &= 0xfffffffb;
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    if (mVar3.DAT_02 == 0)
                    {
                        SceneManager.instance.DAT_C51D8 = oVar2.DAT_240;
                        oVar2.DAT_240 = 0;
                        uVar4 = 0;
                    }
                    else
                    {
                        oVar2.DAT_240 = SceneManager.instance.DAT_C51D8;
                        uVar4 = SceneManager.instance.DAT_C51D8;
                    }

                    oVar2.FUN_4FE90(uVar4);
                }
            }
            else
            {
                if (bVar1 == 2)
                {
                    InventoryManager.FUN_4A7E8(2, 9, false);
                    InventoryManager.FUN_4A7E8(2, 10, false);
                    InventoryManager.FUN_4A7E8(2, 11, false);
                    bVar1 = oVar2.DAT_1D7;

                    if (bVar1 == 1)
                    {
                        if ((oVar2.DAT_1C0 & 8) == 0)
                            uVar5 = 10;
                        else
                            uVar5 = 11;
                    }
                    else
                    {
                        if (bVar1 < 2)
                        {
                            if (bVar1 != 0) goto LAB_595CC;

                            uVar5 = 9;
                        }
                        else
                        {
                            if (bVar1 != 2) goto LAB_595CC;

                            if ((oVar2.DAT_1C0 & 8) == 0)
                                uVar5 = 10;
                            else
                                uVar5 = 11;
                        }
                    }

                    InventoryManager.FUN_4A7E8(2, uVar5, true);
                }
            }
        }

        LAB_595CC:
        DAT_58[0]++;
        return false;
    }

    private bool FUN_595FC()
    {
        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_59994()
    {
        bool bVar1;
        CriTrigger puVar2;
        int iVar3;
        uint uVar4;
        DataContainer25 mVar6;
        bool bVar6;
        int iVar6;
        CriSkinned oVar7;
        Vector2Int[] puVar8;
        uint uVar9;
        uint uVar10;

        mVar6 = (DataContainer25)PTR_58[0].CONTAINERS[DAT_58[0]];
        puVar2 = SceneManager.instance.FUN_596E8(mVar6.DAT_10);

        if (puVar2 != null)
        {
            puVar2.DAT_03 |= 1;
            oVar7 = SceneManager.instance.DAT_27C[mVar6.DAT_01];
            ((CriPlayer)oVar7).ResetValues();
            oVar7.flags = 1;
            oVar7.tags = (sbyte)mVar6.DAT_02;
            oVar7.DAT_2F = mVar6.DAT_03;
            oVar7.cSkin = (Tmd2ScriptableObject)Utilities.GetRamObject(mVar6.DAT_04);
            oVar7.FUN_604A4(oVar7.cSkin);
            int length = ((RefScriptableObject)Utilities.GetRamObject(mVar6.DAT_08)).ASSET_REFS.Length;
            oVar7.DAT_98 = new TodScriptableObject[length];

            for (int i = 0; i < length; i++)
                oVar7.DAT_98[i] = ((RefScriptableObject)Utilities.GetRamObject(mVar6.DAT_08)).ASSET_REFS[i] as TodScriptableObject;

            oVar7.screen = puVar2.DAT_04;
            oVar7.vr.y = puVar2.DAT_0C;
            oVar7.DAT_163 = puVar2.DAT_02;
            oVar7.DAT_198 = puVar2.DAT_00;
            oVar7.maxHealth = puVar2.DAT_0A;
            oVar7.DAT_194 = puVar2.DAT_0E;
            oVar7.DAT_196 = puVar2.DAT_10;
            oVar7.DAT_19A = puVar2.DAT_12;
            bVar1 = puVar2.DAT_14;
            oVar7.DAT_18E = 0;
            oVar7.DAT_1A6 = bVar1;

            if (oVar7.DAT_196 == 0)
            {
                uVar9 = 0;
                SV2ScriptableObject sv2 = (SV2ScriptableObject)Utilities.GetRamObject(mVar6.DAT_0C);
                uVar10 = (uint)sv2.SVECTORS.Length;

                if (uVar10 != 0)
                {
                    do
                    {
                        puVar8 = sv2.SVECTORS[uVar9].sv2;
                        bVar6 = GameManager.instance.FUN_768C8(puVar2.DAT_04, puVar8);

                        if (bVar6)
                        {
                            iVar6 = (int)GameManager.FUN_64650();
                            iVar3 = (int)GameManager.FUN_64650();
                            //...
                        }

                        uVar9++;
                    } while (uVar9 < uVar10);
                }
            }

            oVar7.DAT_34.z = oVar7.screen.z;
            oVar7.DAT_34.x = oVar7.screen.x;
            oVar7.DAT_13C.x = oVar7.screen.x;
            oVar7.DAT_13C.y = oVar7.screen.z;
            //...(requires level script - ST1-9)
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_59BFC()
    {
        uint uVar1;
        CriSkinned oVar2;
        DataContainer14 mVar3;

        mVar3 = (DataContainer14)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar2 = SceneManager.instance.DAT_27C[10];
        uVar1 = (uint)mVar3.DAT_01 << 8 | 4;
        oVar2.DAT_3C = (byte)uVar1;
        oVar2.DAT_3D = (byte)(uVar1 >> 8);
        oVar2.DAT_3E = (byte)(uVar1 >> 0x10);
        oVar2.DAT_3F = (byte)(uVar1 >> 0x18);
        oVar2.PTR_190 = mVar3.DAT_04;
        oVar2.DAT_190 = 0;
        oVar2.DAT_176 = mVar3.DAT_02;
        oVar2.DAT_18F = mVar3.DAT_03;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_59D28()
    {
        byte bVar1;
        bool bVar5;
        int iVar5;
        CriPlayer oVar5;
        CriSkinned pcVar7;
        uint uVar8;
        DataContainer22 mVar10;
        uint uVar11;

        /*oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        mVar10 = (MovContainer22)PTR_58[0].CONTAINERS[DAT_58[0]];
        
        if ((oVar5.DAT_11E & 0x80) != 0)
        {
            DAT_58[0]++;
            return false;
        }

        if (mVar10.DAT_22 == 0 && (mVar10.DAT_19 & 2) == 0)
        {
            bVar5 = InventoryManager.FUN_4A87C(2, 0x15);

            if (!bVar5 || mVar10.DAT_1A != SceneManager.instance.cCamera.DAT_68)
            {
                DAT_58[0]++;
                return false;
            }

            InventoryManager.FUN_4A7E8(2, 0x15, false);
        }

        switch (mVar10.DAT_22)
        {
            case 0:
                uVar8 = 0;

                if ((SceneManager.instance.DAT_27C[mVar10.DAT_01].flags & 1) != 0)
                {
                    DAT_58[0]++;
                    return false;
                }

                uVar11 = 0;

                if (uVar8 < 10)
                {
                    do
                    {
                        pcVar7 = SceneManager.instance.DAT_27C[uVar8];

                        if ((pcVar7.flags & 1) != 0 && -1 < pcVar7.DAT_198)
                            uVar11++;

                        uVar8++;
                    } while (uVar8 < 10);
                }

                bVar1 = mVar10.DAT_15;
                iVar5 = (int)GameManager.FUN_64650();

        }*/

        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5A5B4()
    {
        byte bVar1;
        int iVar2;

        iVar2 = SceneManager.instance.FUN_59C74
            (((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01);
        bVar1 = 2;

        if (iVar2 == 0)
            bVar1 = 0x40;

        DAT_06 = bVar1;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5A60C()
    {
        DataContainer4 mVar2;

        mVar2 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        GameManager.instance.DAT_2E = mVar2.DAT_02;
        GameManager.instance.DAT_39 = mVar2.DAT_01;
        InventoryManager.FUN_4A7E8(2, 0xf, true);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5A66C()
    {
        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5A6A8()
    {
        LightSource puVar1;
        DataContainer16 mVar2;

        mVar2 = (DataContainer16)PTR_58[0].CONTAINERS[DAT_58[0]];
        puVar1 = SceneManager.instance.FUN_55790(mVar2.DAT_01);

        if (puVar1.DAT_02 == 0)
            puVar1.DAT_04 = mVar2.DAT_04;
        else
        {
            if (mVar2.DAT_02 == 1)
            {
                puVar1.DAT_00 = (byte)mVar2.DAT_04.x;
                puVar1.DAT_01 = (byte)mVar2.DAT_04.y;
                puVar1.DAT_02 = (byte)mVar2.DAT_04.z;
            }
        }

        DAT_58[0]++;
        return false;
    }

    private bool FUN_5A764()
    {
        GameManager.instance.DAT_21 = ((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5A794()
    {
        DataContainer4 mVar1;
        CriSkinned oVar2;

        mVar1 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar2 = SceneManager.instance.DAT_27C[DAT_0B];

        if (mVar1.DAT_01 == 1)
            oVar2.DAT_5C |= mVar1.DAT_02;
        else
            oVar2.DAT_5C &= (byte)~mVar1.DAT_02;

        DAT_58[0]++;
        return false;
    }

    private bool FUN_5A814()
    {
        //FUN_1D988
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5A85C()
    {
        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5A9B0()
    {
        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5AAD4()
    {
        Trigger tVar1;

        tVar1 = SceneManager.instance.triggers
            [((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01 + 4];

        if (tVar1 != null && tVar1.DAT_13)
            DialogManager.instance.PTR_FUN_99028[tVar1.DAT_10](tVar1);

        DAT_58[0]++;
        return false;
    }

    private bool FUN_5AB68()
    {
        byte bVar1;
        CriSkinned oVar2;
        DataContainer4 mVar3;

        mVar3 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        bVar1 = mVar3.DAT_01;
        oVar2 = SceneManager.instance.DAT_27C[DAT_0B];
        oVar2.DAT_18C = bVar1;

        if ((mVar3.DAT_01 & 0xe0) != 0)
            oVar2.DAT_18C = (byte)(bVar1 | mVar3.DAT_02);

        DAT_58[0]++;
        return false;
    }

    private bool FUN_5AA08()
    {
        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5ABD8()
    {
        DataContainer4 mVar1;
        CriPlayer oVar2;

        mVar1 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (mVar1.DAT_02 == 0)
            oVar2.DAT_98 = oVar2.DAT_1E0;
        else
            SceneManager.instance.DAT_27C[mVar1.DAT_01].FUN_65C4C(oVar2);

        DAT_58[0]++;
        return false;
    }

    private bool FUN_5AC6C()
    {
        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5ACDC()
    {
        //...
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5AD28()
    {
        GameManager.instance.DAT_A0E2 = ((DataContainer2)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_02;
        GameManager.instance.DAT_39 = 2;
        InventoryManager.FUN_4A7E8(2, 0xf, true);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5AD90()
    {
        DataContainer4 mVar1;

        mVar1 = (DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]];
        SceneManager.instance.FUN_81390(mVar1.DAT_01, mVar1.DAT_02, mVar1.DAT_03);
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5ADE0()
    {
        if (((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01 == 1)
            SceneManager.instance.FUN_26E1C();
        else
            SceneManager.instance.FUN_26E6C();

        DAT_58[0]++;
        return false;
    }

    private bool FUN_5AE44()
    {
        GameManager.instance.DAT_9234 = ((DataContainer4)PTR_58[0].CONTAINERS[DAT_58[0]]).DAT_01;
        DAT_58[0]++;
        return false;
    }

    private bool FUN_5AE78()
    {
        //...
        DAT_58[0]++;
        return false;
    }
}
