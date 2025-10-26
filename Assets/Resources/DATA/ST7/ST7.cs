using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct UNK_12130
{
    public Vector3Int[] DAT_00;
    public byte DAT_04;
}

//size=0xc
public struct UNK_12974
{
    public short DAT_00;
    public short DAT_02;
    public short DAT_04;
    public sbyte DAT_06;
    public sbyte DAT_07;
    public sbyte DAT_0A;
}

public class ST7 : LevelManager
{
    public static new ST7 instance;

    private uint[] DAT_04 = new uint[] { 4, 5, 6, 7 };
    private byte[] DAT_14 = new byte[] { 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4, 2 };
    private byte[] DAT_28 = new byte[] { 0, 1, 2, 3, 4, 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4, 2 };
    public uint[] DAT_11528 = new uint[151] { 0, 0xa, 0x11, 0x22, 0x31, 0x36, 0x80000046, 0x0, 0x16, 0x3a, 0x80000060, 0x0, 0x8, 0x17, 0x36, 0x8000005b, 0x0, 0xa, 0x18, 0x26, 0x2e, 0x36, 0x80000044, 0x0, 0x16, 0x80000046, 0x0, 0xc, 0x10, 0x1d, 0x21, 0x32, 0x3b, 0x80000044, 0x0, 0x6, 0x9, 0x22, 0x2e, 0x33, 0x80000047, 0x0, 0x1f, 0x24, 0x39, 0x8000004e, 0x0, 0x15, 0x1b, 0x20, 0x29, 0x36, 0x80000060, 0x0, 0x8, 0x16, 0x36, 0x80000047, 0x0, 0xe, 0x2f, 0x33, 0x80000040, 0x0, 0xd, 0x24, 0x32, 0x38, 0x80000045, 0x0, 0x7, 0xc, 0x12, 0x21, 0x27, 0x30, 0x39, 0x80000041, 0x0, 0x7, 0xf, 0x30, 0x80000042, 0x0, 0x12, 0x1a, 0x25, 0x39, 0x80000052, 0x0, 0x8, 0xb, 0x12, 0x18, 0x24, 0x30, 0x80000048, 0x0, 0x6, 0x17, 0x2b, 0x80000040, 0x0, 0x6, 0x2a, 0x31, 0x80000040, 0x0, 0xf, 0x24, 0x36, 0x8000003e, 0x0, 0x13, 0x2b, 0x8000004c, 0x0, 0x26, 0x37, 0x80000046, 0x0, 0x12, 0x26, 0x35, 0x8000004e, 0x0, 0x20, 0x27, 0x3b, 0x8000004a, 0x0, 0x10, 0x30, 0x3c, 0x80000050, 0x0, 0x8, 0x18, 0x29, 0x35, 0x3b, 0x80000047, 0x0, 0x12, 0x34, 0x80000044, 0x0, 0x1b, 0x25, 0x34, 0x80000043 };
    public TrgScriptableObject DAT_11784; //0x11784 (ST6)
    public byte[] DAT_11874 = new byte[48] { 29, 7, 10, 10, 27, 15, 13, 0, 32, 25, 20, 18, 33, 30, 27, 24, 34, 31, 0, 25, 35, 0, 0, 0, 22, 0, 28, 26, 23, 0, 29, 27, 16, 0, 30, 29, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 };
    public FUN_B58BC[] DAT_118A4 = new FUN_B58BC[] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08,
                                                     null, FUN_46A1C, null, null, null, FUN_45D38, FUN_45E70, FUN_464F8,
                                                     FUN_27C, FUN_BC8, FUN_13BC, FUN_1C58, FUN_1D60, FUN_21E0, FUN_1F14,
                                                     FUN_2048 };
    public FUN_B58C0[] DAT_118FC = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, null, null, FUN_623C, null, null,
                                                     null, null };
    public FUN_C2570[] DAT_11924 = new FUN_C2570[] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null, null,
                                                     FUN_7F808 };
    public FUN_C1CF8[] DAT_11944 = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, FUN_21ECC,
                                                     FUN_22178, null, null, null, FUN_222AC, FUN_22464, FUN_2268C,
                                                     FUN_2650, FUN_2AC8, FUN_3300, FUN_39E8, FUN_3A24, null,
                                                     FUN_3D54, FUN_672C, FUN_94FC, FUN_BED4, FUN_E5B4, FUN_E830,
                                                     FUN_E86C, FUN_10844 };
    private delegate void FUN_119D4(CriParticle p); //0x119D4 (ST7)
    private delegate void FUN_119E4(CriParticle p); //0x119E4 (ST7)
    private delegate void FUN_11A20(CriParticle p); //0x11A20 (ST7)
    private delegate void FUN_11A30(CriParticle p); //0x11A30 (ST7)
    private delegate void FUN_11A54(CriParticle p); //0x11A54 (ST7)
    private delegate void FUN_11A60(CriParticle p); //0x11A60 (ST7)
    private delegate void FUN_11A98(CriParticle p); //0x11A98 (ST7)
    private delegate void FUN_11AC8(CriParticle p); //0x11AC8 (ST7)
    private delegate void FUN_11AFC(CriInteract i); //0x11AFC (ST7)
    private delegate void FUN_11B78(CriInteract i); //0x11B78 (ST7)
    private delegate void FUN_11BAC(CriInteract i); //0x11BAC (ST7)
    private delegate void FUN_11BC0(CriInteract i); //0x11BC0 (ST7)
    private delegate void FUN_11BD4(CriInteract i); //0x11BD4 (ST7)
    private delegate void FUN_120F4(CriInteract i); //0x120F4 (ST7)
    private delegate void FUN_12444(CriPlayer p); //0x12444 (ST7)
    private delegate void FUN_12468(CriPlayer p); //0x12468 (ST7)
    private delegate void FUN_124B8(CriPlayer p); //0x124B8 (ST7)
    private delegate void FUN_124D4(CriInteract i); //0x124D4 (ST7)
    private delegate void FUN_125A0(CriInteract i); //0x125A0 (ST7)
    private delegate void FUN_125FC(CriInteract i); //0x125FC (ST7)
    private delegate void FUN_1269C(CriInteract i); //0x1269C (ST7)
    private delegate void FUN_126F4(CriInteract i); //0x126F4 (ST7)
    private delegate void FUN_1278C(CriInteract i); //0x1278C (ST7)
    private delegate void FUN_12850(CriInteract i); //0x12850 (ST7)
    private FUN_119D4[] PTR_FUN_119D4; //0x119D4 (ST7)
    private FUN_119E4[] PTR_FUN_119E4; //0x119E4 (ST7)
    private short[] DAT_119F4 = new short[] { -2320, -1230, -3900, -2610, -1230, -3900, -2900, -1230, -3900, -3190, -1230, -3900, -3480, -1230, -3900, -4390, -1075, 2600 };
    private short[] DAT_11A18 = new short[] { -2290, -2580, -2870, -3160 };
    private FUN_11A20[] PTR_FUN_11A20; //0x11A20 (ST7)
    private FUN_11A30[] PTR_FUN_11A30; //0x11A30 (ST7)
    private uint[] DAT_11A3C = new uint[] { 0x80118a38, 0, 0x80118a40 }; //0x11A3C (ST7)
    private byte[] DAT_11A40 = new byte[] { 1, 1, 1 }; //0x11A40 (ST7)
    private FUN_11A54[] PTR_FUN_11A54; //0x11A54 (ST7)
    private FUN_11A60[] PTR_FUN_11A60; //0x11A60 (ST7)
    private uint[] DAT_11A6C = new uint[] { 0x8011d168, 0x8011d178, 0x8011d180, 0x8011d188, 0x8011d190, 0x8011d1a0, 0x8011d1a8, 0x8011d1b0, 0x8011d1b8, 0x8011d1c0, 0x8011d1f0 }; //0x11A6C (ST7)
    private FUN_11A98[] PTR_FUN_11A98; //0x11A98 (ST7)
    private uint[] DAT_11AA8 = new uint[] { 0x8010eef0, 0x8010f028, 0x8010f040, 0x8010f058, 0x8010f068, 0x8010f078, 0x8010ef38, 0x8010efb0 };
    private FUN_11AC8[] PTR_FUN_11AC8; //0x11AC8 (ST7)
    private byte[] DAT_11AF8 = new byte[] { 0, 0x80, 0xfe, 0xfe }; //0x11AF8 (ST7)
    private FUN_11AFC[] PTR_FUN_11AFC; //0x11AFC (ST7)
    private byte[] DAT_11B0C; //0x11B0C (ST7)
    private FUN_11B78[] PTR_FUN_11B78; //0x11B78 (ST7)
    private int[] DAT_11B84 = new int[] { -0xa1ac00, -0xd8afae, -0xc1ea9f, -0xe2afae, -0xcbffaf, -0xd5d4d2, -0xb6ce9c, -0xc4c7e7, -0xcfd4, -0x1018000 };
    private FUN_11BAC[] PTR_FUN_11BAC; //0x11BAC (ST7)
    private byte[] DAT_11BBC = new byte[] { 3, 6, 9, 5 };
    private FUN_11BC0[] PTR_FUN_11BC0; //0x11BC0 (ST7)
    private FUN_11BD4[] PTR_FUN_11BD4; //0x11BD4 (ST7)
    private CriObject DAT_11BE0; //0x11BE0 (ST7)
    private CriObject DAT_12018; //0x12018 (ST7)
    private FUN_120F4[] PTR_FUN_120F4; //0x120F4 (ST7)
    private UNK_12130[] PTR_DAT_12130; //0x12130 (ST7)
    private CapsuleCollider[] DAT_12148; //0x12148 (ST7)
    private byte[] DAT_12410 = new byte[] { 54, 55 };
    private FUN_12444[] PTR_FUN_12444; //0x12444 (ST7)
    private FUN_12468[] PTR_FUN_12468; //0x12468 (ST7)
    private FUN_124B8[] PTR_FUN_124B8; //0x124B8 (ST7)
    private FUN_124D4[] PTR_FUN_124D4; //0x124D4 (ST7)
    private byte[] DAT_12590 = new byte[] { 1, 2, 5, 6, 3, 7 };
    private byte[] DAT_12598 = new byte[] { 1, 2, 8, 4, 3, 7 };
    private FUN_125A0[] PTR_FUN_125A0; //0x125A0 (ST7)
    private sbyte[] DAT_125B4 = new sbyte[] { -12, 0, -12, 0, -12, 0, 12, 0, 12, 0, 12, 0, 12, 0, 12, 0, -12, 0, -12 };
    private sbyte[] DAT_125C8 = new sbyte[] { 12, 0, 12, 0, 12, 0, -12, 0, -12, 0, -12, 0, -12, 0, 12, 0, 12, };
    private FUN_125FC[] PTR_FUN_125FC; //0x125FC (ST7)
    private byte[] DAT_12690 = new byte[12]; //0x12690 (ST7)
    private FUN_1269C[] PTR_FUN_1269C; //0x1269C (ST7)
    private Vector4Int[][] PTR_DAT_126D8 = new Vector4Int[3][];
    private uint[] DAT_126DC = new uint[] { 1, 3, 2 };
    private byte[] DAT_126F0 = new byte[] { 45, 46, 47 };
    private FUN_126F4[] PTR_FUN_126F4; //0x126F4 (ST7)
    private sbyte[] DAT_1273C = new sbyte[] { 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, 2, 2, 2, 2, 2, 2, 2, 2, -1, -1, 3, 3, 3, 3, 3, -1, -1, -1, -1, -1, 0, 3, 3, 3, 0, 0, 3, 3, -1, -1, 0, 1, 0, 3, 0, 1, 3, 1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, 1, -1, 0, 1, 2, 3, 0, 1, 2, 3, 2, 1 } ; //0x1273C (ST7)
    private FUN_1278C[] PTR_FUN_1278C; //0x1278C (ST7)
    private uint[] DAT_127A8 = new uint[] { 0x8010999c, 0x80109d50, 0x8010a104, 0x8010a4b8, 0x8010a86c, 0x8010a86c, 0x8010ac20, 0x801095e8 };
    private byte[] DAT_127C4 = new byte[] { 3, 4, 5, 0, 1, 2, 5, 1, 2, 3, 0, 4, 3, 4, 0, 1, 5, 2, 2, 1, 3, 5, 0, 4, 4, 0, 2, 5, 1, 3, 2, 5, 1, 0, 4, 3 };
    private FUN_12850[] PTR_FUN_12850; //0x12850 (ST7)
    private sbyte[] DAT_12870 = new sbyte[20]; //0x12870 (ST7)
    private byte[] DAT_12890 = new byte[20]; //0x12890 (ST7)
    private byte[] DAT_128C0 = new byte[20]; //0x128C0 (ST7)
    private uint[] DAT_128D4 = new uint[4]; //0x128D4 (ST7)
    private UNK_12974[] PTR_DAT_12974 = new UNK_12974[3]; //0x12974 (ST7)
    private sbyte[] DAT_12998 = new sbyte[10]; //0x12988 (ST7)
    private sbyte[] DAT_129A8 = new sbyte[10]; //0x129A8 (ST7)
    private sbyte[] DAT_129B8 = new sbyte[10]; //0x129B8 (ST7)
    private short DAT_129EC; //0x129EC (ST7)
    private short DAT_129EE; //0x129EE (ST7)
    private short DAT_129F0; //0x129F0 (ST7)
    private short DAT_129F2; //0x129F2 (ST7)
    private byte DAT_129F4; //0x129F4 (ST7)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_119D4 = new FUN_119D4[4]
            {
                FUN_2C8,
                FUN_33C,
                FUN_550,
                FUN_60068
            };
            PTR_FUN_119E4 = new FUN_119E4[4]
            {
                FUN_C04,
                FUN_FDC,
                FUN_11EC,
                FUN_60068
            };
            PTR_FUN_11A20 = new FUN_11A20[4]
            {
                FUN_13F8,
                FUN_16D0,
                FUN_1870,
                FUN_60068
            };
            PTR_FUN_11A30 = new FUN_11A30[3]
            {
                FUN_1C94,
                FUN_1D20,
                FUN_60068
            };
            PTR_FUN_11A54 = new FUN_11A54[3]
            {
                FUN_1D9C,
                FUN_1E24,
                FUN_60068
            };
            PTR_FUN_11A60 = new FUN_11A60[3]
            {
                FUN_1F74,
                FUN_1FD0,
                FUN_60068
            };
            PTR_FUN_11A98 = new FUN_11A98[3]
            {
                FUN_20A8,
                FUN_2150,
                FUN_60068
            };
            PTR_FUN_11AC8 = new FUN_11AC8[3]
            {
                FUN_221C,
                FUN_2314,
                FUN_60068
            };
            PTR_FUN_11AFC = new FUN_11AFC[4]
            {
                FUN_2348,
                FUN_244C,
                FUN_2644,
                FUN_5FF98
            };
            PTR_FUN_11B78 = new FUN_11B78[3]
            {
                FUN_2B04,
                FUN_2B1C,
                FUN_5FF98
            };
            PTR_FUN_11BAC = new FUN_11BAC[4]
            {
                FUN_2D18,
                FUN_2D80,
                FUN_2E94,
                FUN_5FF98
            };
            PTR_FUN_11BC0 = new FUN_11BC0[5]
            {
                FUN_333C,
                FUN_33CC,
                FUN_35C4,
                FUN_367C,
                FUN_5FF98
            };
            PTR_FUN_11BD4 = new FUN_11BD4[3]
            {
                FUN_3A60,
                FUN_3AAC,
                FUN_3BD8
            };
            PTR_FUN_120F4 = new FUN_120F4[3]
            {
                FUN_3D90,
                FUN_3E2C,
                FUN_5FF98
            };
            PTR_FUN_12444 = new FUN_12444[7]
            {
                FUN_4BB8,
                FUN_5134,
                FUN_420C,
                FUN_4468,
                FUN_3FA8,
                FUN_3FA8,
                FUN_4D80
            };
            PTR_FUN_12468 = new FUN_12468[1]
            {
                FUN_4C84
            };
            PTR_FUN_124B8 = new FUN_124B8[2]
            {
                FUN_3FDC,
                FUN_5A68
            };
            PTR_FUN_124D4 = new FUN_124D4[3]
            {
                FUN_6890,
                FUN_6910,
                FUN_696C
            };
            PTR_FUN_125A0 = new FUN_125A0[5]
            {
                FUN_95DC,
                FUN_981C,
                FUN_9CE8,
                FUN_9D2C,
                FUN_5FF98
            };
            PTR_FUN_125FC = new FUN_125FC[6]
            {
                FUN_BFBC,
                FUN_C044,
                FUN_C268, 
                FUN_C608, 
                FUN_CB64, 
                FUN_5FF98
            };
            PTR_FUN_1269C = new FUN_1269C[3]
            {
                FUN_E4D8,
                FUN_E538,
                FUN_5FF98
            };
            PTR_FUN_126F4 = new FUN_126F4[2]
            {
                FUN_E5F0, 
                FUN_E700
            };
            PTR_FUN_1278C = new FUN_1278C[7]
            {
                FUN_E944,
                FUN_EA94, 
                FUN_F2A8, 
                FUN_F464, 
                FUN_F804, 
                FUN_FA18, 
                FUN_5FF98
            };
            PTR_FUN_12850 = new FUN_12850[]
            {

            };
        }
    }

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();
    }

    //FUN_134 (ST7)
    public override void Initialize()
    {
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_118A4;
        PTR_FUN_B58C0 = DAT_118FC;
        PTR_FUN_C2570 = DAT_11924;
        PTR_FUN_C1CF8 = DAT_11944;
        GameManager.instance.DAT_AC = DAT_11874;
        GameManager.instance.DAT_B0 = DAT_11528;
        GameManager.instance.DAT_46 = 7;

        for (int i = 0; i < DAT_11784.TRIGGERS.Length; i++)
        {
            puVar4 = LevelManager.instance.DAT_9EEC[i];
            puVar5 = DAT_11784.TRIGGERS[i];
            puVar4.DAT_00 = puVar5.DAT_00;
            puVar4.DAT_01 = puVar5.DAT_01;
            puVar4.DAT_02 = puVar5.DAT_02;
            puVar4.DAT_03 = puVar5.DAT_03;
            puVar4.DAT_04 = puVar5.DAT_04;
            puVar4.DAT_0A = puVar5.DAT_0A;
            puVar4.DAT_0C = puVar5.DAT_0C;
            puVar4.DAT_0E = puVar5.DAT_0E;
            puVar4.DAT_10 = puVar5.DAT_10;
            puVar4.DAT_12 = puVar5.DAT_12;
            puVar4.DAT_14 = puVar5.DAT_14;
            puVar4.DAT_16 = puVar5.DAT_16;
        }

        GameManager.instance.FUN_5E130(0, 4, 0);
    }

    //FUN_2C8 (ST7)
    private void FUN_2C8(CriParticle param1)
    {
        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        //...
        param1.DAT_68 = 0;
        param1.DAT_69 = 0;
        param1.DAT_6A = 0;
        param1.DAT_3C++;
    }

    //FUN_33C (ST7)
    private void FUN_33C(CriParticle param1)
    {
        sbyte sVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            {
                if ((sbyte)param1.DAT_6A < 3)
                {
                    GameManager.instance.FUN_5C94C(null, 145);
                    param1.DAT_6A++;
                }

                if (param1.DAT_6A != 3) goto LAB_460;

                goto LAB_454;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (sbyte)param1.DAT_69 < 2)
                {
                    if ((sbyte)param1.DAT_6A == 3) goto LAB_454;

                    GameManager.instance.FUN_5C94C(null, 145);
                    sVar1 = (sbyte)(param1.DAT_69 + 1);
                    param1.DAT_69 = (byte)sVar1;
                }

                if (param1.DAT_6A != 3) goto LAB_460;

                goto LAB_454;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_460;

                goto LAB_454;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                sVar1 = (sbyte)(param1.DAT_69 - 1);
                param1.DAT_69 = (byte)sVar1;

                if (param1.DAT_6A != 3) goto LAB_460;
            }
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                param1.DAT_6A--;
            }

            if (param1.DAT_6A != 3) goto LAB_460;
        }

        LAB_454:
        param1.DAT_69 = 1;
        
        LAB_460:
        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            //...
            sVar1 = (sbyte)(param1.DAT_68 + 1);
            param1.DAT_68 = (byte)sVar1;

            if (3 < sVar1)
                param1.DAT_3C++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 147);

            if ((sbyte)param1.DAT_68 < 1)
            {
                InventoryManager.FUN_4A7E8(2, 0xb, true);
                param1.DAT_3C = 3;
            }
            else
                param1.DAT_68--;

            //...
        }
    }

    //FUN_550 (ST7)
    private void FUN_550(CriParticle param1)
    {
        param1.DAT_3C++;
        //...
        GameManager.instance.FUN_5C94C(null, 148);
        InventoryManager.FUN_4A7E8(2, 9, true);
    }

    //FUN_C04 (ST7)
    private void FUN_C04(CriParticle param1)
    {
        byte bVar1;
        int piVar2;
        int piVar3;
        int iVar4;
        bool bVar4;
        int iVar5;
        bool bVar5;
        int puVar6;
        CriStatic oVar7;
        CriStatic oVar8;
        CriStatic[] local_78;
        CriStatic[] local_60;
        uint[] local_48;
        byte[] local_38;

        iVar5 = 0;
        oVar8 = null;
        iVar4 = 0;
        piVar2 = 0;
        local_78 = new CriStatic[5];
        local_60 = new CriStatic[5];
        local_48 = new uint[4];
        local_38 = new byte[20];
        System.Array.Copy(DAT_04, local_48, 4);
        System.Array.Copy(DAT_14, local_38, 20);

        do
        {
            local_78[piVar2] = SceneManager.instance.staticObjects[iVar4];
            piVar2++;
            iVar4++;
        } while (iVar4 < 5);

        oVar7 = SceneManager.instance.staticObjects[5];
        bVar4 = InventoryManager.FUN_4A87C(3, 0x20);

        if (!bVar4)
        {
            bVar4 = InventoryManager.FUN_4A87C(3, 0x21);

            if (!bVar4)
            {
                bVar4 = InventoryManager.FUN_4A87C(3, 0x22);

                if (bVar4)
                    iVar5 = 3;
            }
            else
            {
                bVar4 = InventoryManager.FUN_4A87C(0, 0x76);

                if (!bVar4)
                {
                    bVar4 = InventoryManager.FUN_4A87C(3, 0x21);

                    if (bVar4)
                        iVar5 = 1;
                }
                else
                    iVar5 = 2;
            }
        }
        else
            iVar5 = 0;

        bVar4 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (!bVar4)
        {
            InventoryManager.FUN_4A7E8(3, 0x3f, true);
            iVar4 = 0;
            piVar2 = 0;

            do
            {
                local_78[piVar2].DAT_78 = local_38[iVar4 + iVar5 * 5];
                local_78[piVar2].DAT_79 = (byte)iVar4;
                iVar4++;
                piVar2++;
            } while (iVar4 < 5);
        }

        iVar4 = 0;
        piVar2 = 0;

        do
        {
            iVar5 = 0;
            piVar3 = 0;

            do
            {
                iVar5++;

                if (local_78[piVar3].DAT_78 == iVar4)
                {
                    local_60[piVar2] = local_78[piVar3];
                    break;
                }

                piVar3++;
            } while (iVar5 < 5);

            iVar4++;
            piVar2++;
        } while (iVar4 < 5);

        iVar4 = 0;
        puVar6 = 0;

        do
        {
            bVar5 = InventoryManager.FUN_4A87C(3, 0x3d);

            if (bVar5)
            {
                iVar4 = 3;
                break;
            }

            bVar5 = InventoryManager.FUN_4A87C(2, local_48[puVar6]);

            if (bVar5) break;

            iVar4++;
            puVar6++;
        } while (iVar4 < 4);

        if (iVar4 == 1)
        {
            bVar1 = 2;
            local_60[0] = local_60[1];
            local_60[3] = local_60[2];
            local_60[0].DAT_78 = bVar1;
            local_60[3].DAT_78 = (byte)iVar4;
            local_60[1] = local_60[3];
        }
        else
        {
            if (1 < iVar4)
            {
                if (iVar4 == 2)
                {
                    bVar1 = 3;
                    local_60[0] = local_60[2];
                }
                else
                {
                    bVar1 = 4;
                    local_60[0] = local_60[3];
                    local_60[3] = local_60[4];

                    if (bVar1 != 3)
                    {
                        param1.PTR_68[0] = oVar7;
                        goto LAB_EDC;
                    }
                }

                local_60[0].DAT_78 = bVar1;
                local_60[3].DAT_78 = (byte)iVar4;
                local_60[1] = local_60[3];
                goto LAB_ED8;
            }

            if (iVar4 != 0)
            {
                param1.PTR_68[0] = oVar7;
                goto LAB_EDC;
            }

            local_60[0].DAT_78 = 1;
            local_60[1].DAT_78 = 0;
        }

        LAB_ED8:
        param1.PTR_68[0] = local_60[0];
        oVar7 = local_60[0];
        oVar8 = local_60[1];
        LAB_EDC:
        param1.PTR_68[1] = oVar8;
        param1.DAT_70.x = (oVar7.screen.x + oVar8.screen.x) / 2;
        param1.DAT_70.y = (oVar7.screen.z + oVar8.screen.z) / 2;
        oVar7.VDAT_74.x = oVar7.screen.x - param1.DAT_70.x;
        oVar7.VDAT_74.y = oVar7.screen.z - param1.DAT_70.y;
        oVar8.VDAT_74.x = oVar8.screen.x - param1.DAT_70.x;
        oVar8.VDAT_74.y = oVar8.screen.z - param1.DAT_70.y;
        oVar7.DAT_4A = 970;
        oVar8.DAT_4A = 969;
        param1.DAT_74 = 0;
        param1.DAT_75 = 0;
        param1.DAT_3C++;
        InventoryManager.FUN_4A7E8(3, 0x3e, false);
        InventoryManager.FUN_4A7E8(3, 0x2c, true);
        //FUN_1D988
    }

    //FUN_FDC (ST7)
    private void FUN_FDC(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;
        CriStatic oVar4;
        CriStatic oVar5;
        Vector3Int local_38;
        Vector3Int local_30;
        Vector3Int local_28;
        Matrix3x3 auStack88;

        oVar4 = (CriStatic)param1.PTR_68[0];
        oVar5 = (CriStatic)param1.PTR_68[1];
        bVar3 = InventoryManager.FUN_4A87C(3, 0x2c);

        if (bVar3)
        {
            bVar1 = param1.DAT_75;
            param1.DAT_75 = (byte)(bVar1 + 1);

            if (5 < bVar1)
            {
                GameManager.instance.FUN_5C94C(oVar4, 145);
                InventoryManager.FUN_4A7E8(3, 0x2c, false);
                param1.DAT_75 = 0;
            }
        }

        local_28 = new Vector3Int(0, (sbyte)param1.DAT_74 << 6, 0);
        auStack88 = new Matrix3x3();
        Utilities.RotMatrix(ref local_28, ref auStack88);
        local_38 = new Vector3Int(oVar4.VDAT_74.x, oVar4.screen.y, oVar4.VDAT_74.y);
        local_30 = Utilities.ApplyMatrixSV(ref auStack88, ref local_38);
        oVar4.screen.x = local_30.x + param1.DAT_70.x;
        oVar4.screen.z = local_30.z + param1.DAT_70.y;
        local_38 = new Vector3Int(oVar5.VDAT_74.x, oVar5.screen.y, oVar5.VDAT_74.y);
        local_30 = Utilities.ApplyMatrixSV(ref auStack88, ref local_38);
        oVar5.screen.x = local_30.x + param1.DAT_70.x;
        oVar5.screen.z = local_30.z + param1.DAT_70.y;
        sVar2 = (sbyte)(param1.DAT_74 + 1);
        param1.DAT_74 = (byte)sVar2;

        if (sVar2 == 28)
            GameManager.instance.FUN_5C94C(oVar4, 152);

        if (32 < (sbyte)param1.DAT_74)
        {
            param1.DAT_3C++;
            oVar4.screen.x = oVar5.VDAT_74.x + param1.DAT_70.x;
            oVar4.screen.z = oVar5.VDAT_74.y + param1.DAT_70.y;
            oVar5.screen.x = oVar4.VDAT_74.x + param1.DAT_70.x;
            oVar5.screen.z = oVar4.VDAT_74.y + param1.DAT_70.y;
        }
    }

    //FUN_11EC (ST7)
    private void FUN_11EC(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        CriStatic oVar3;
        CriStatic oVar4;
        bool bVar5;
        int iVar5;
        int piVar6;
        int iVar7;
        CriStatic[] local_30;

        InventoryManager.FUN_4A7E8(3, 0x2e, false);
        iVar7 = 0;
        piVar6 = 0;
        local_30 = new CriStatic[5];

        do
        {
            local_30[piVar6] = SceneManager.instance.staticObjects[iVar7];
            piVar6++;
            iVar7++;
        } while (iVar7 < 5);

        oVar4 = local_30[4];
        oVar3 = local_30[3];
        iVar5 = 0;

        do
        {
            InventoryManager.FUN_4A7E8(3, (uint)iVar5 + 0x24, false);
            iVar5++;
        } while (iVar5 < 4);

        if (oVar4.DAT_78 != 3)
            InventoryManager.FUN_4A7E8(3, (uint)(int)(sbyte)oVar4.DAT_78 + 0x24, true);

        if (GameManager.instance.DAT_9AA0 == 0x601 && oVar4.DAT_78 == 4)
        {
            bVar5 = InventoryManager.FUN_4A87C(0, 181);

            if (bVar5)
            {
                oVar4.DAT_78 = oVar3.DAT_78;
                oVar3.DAT_78 = 4;
                sVar1 = (short)local_30[3].screen.x;
                sVar2 = (short)local_30[3].screen.z;
                local_30[3].screen.x = local_30[4].screen.x;
                local_30[3].screen.z = local_30[4].screen.z;
                local_30[4].screen.x = sVar1;
                local_30[4].screen.z = sVar2;
            }
        }

        iVar5 = 0;
        piVar6 = 0;

        while (iVar5 != 4)
        {
            iVar5++;

            if (local_30[piVar6].DAT_79 != local_30[piVar6].DAT_78)
                goto LAB_1384;
            else
            {
                piVar6++;

                if (4 < iVar5)
                    goto LAB_1384;
            }
        }

        InventoryManager.FUN_4A7E8(3, 0x2e, true);
        LAB_1384:
        InventoryManager.FUN_4A7E8(3, 0x3e, true);
        param1.DAT_3C++;
    }

    //FUN_13F8 (ST7)
    private void FUN_13F8(CriParticle param1)
    {
        int iVar2;
        bool bVar2;
        int piVar3;
        int iVar4;
        sbyte sVar5;
        int iVar6;
        int piVar7;
        CriStatic[] local_48;
        byte[] local_30;

        iVar6 = 0;
        piVar7 = 0;
        iVar4 = 0;
        piVar3 = 0;
        local_48 = new CriStatic[5];
        local_30 = new byte[25];
        System.Array.Copy(DAT_28, local_30, 25);
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.screen.x = -1350;
        param1.screen.z = -3800;
        param1.DAT_50.a |= 2;
        param1.flags &= 0xfffffffd;

        do
        {
            local_48[piVar3] = SceneManager.instance.staticObjects[iVar4];
            piVar3++;
            iVar4++;
        } while (iVar4 < 5);

        bVar2 = InventoryManager.FUN_4A87C(3, 0x3e);

        if (!bVar2)
        {
            bVar2 = InventoryManager.FUN_4A87C(3, 0x20);

            if (!bVar2)
            {
                bVar2 = InventoryManager.FUN_4A87C(3, 0x21);

                if (!bVar2)
                {
                    bVar2 = InventoryManager.FUN_4A87C(3, 0x22);

                    if (bVar2)
                        iVar6 = 4;
                }
                else
                {
                    bVar2 = InventoryManager.FUN_4A87C(0, 0x76);

                    if (!bVar2)
                    {
                        bVar2 = InventoryManager.FUN_4A87C(3, 0x21);

                        if (bVar2)
                            iVar6 = 2;
                    }
                    else
                        iVar6 = 3;

                    param1.DAT_78 = 0;
                }
            }
            else
                iVar6 = 1;
        }
        else
        {
            iVar6 = 0;
            param1.DAT_78 = 3;
        }

        bVar2 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (!bVar2)
        {
            InventoryManager.FUN_4A7E8(3, 0x3f, true);
            iVar2 = 0;
            piVar3 = 0;

            do
            {
                local_48[piVar3].DAT_79 = (byte)iVar2;
                local_48[piVar3].DAT_78 = local_30[iVar2 + iVar6 * 5];
                iVar2++;
                piVar3++;
            } while (iVar2 < 5);
        }

        iVar2 = 0;

        do
        {
            iVar4 = 0;
            piVar3 = 0;

            do
            {
                iVar4++;

                if (local_48[piVar3].DAT_78 == iVar2)
                {
                    param1.PTR_68[piVar7] = local_48[piVar3];
                    break;
                }

                piVar3++;
            } while (iVar4 < 5);

            iVar2++;
            piVar7++;

            if (3 < iVar2)
            {
                InventoryManager.FUN_4A7E8(3, 0x3e, false);
                InventoryManager.FUN_4A7E8(3, 0x2c, true);
                InventoryManager.FUN_4A7E8(3, 0x2d, true);
                sVar5 = (sbyte)(iVar6 + 1);

                if (iVar6 == 4)
                    sVar5 = 1;
                else
                {
                    if (2 < iVar6 + 1)
                        sVar5 = 2;
                }

                param1.DAT_3C += (byte)sVar5;
                param1.DAT_7A = 0;
                param1.DAT_7B = 0;
                return;
            }
        } while (true);
    }

    //FUN_16D0 (ST7)
    private void FUN_16D0(CriParticle param1)
    {
        short sVar1;
        sbyte sVar2;
        CriStatic oVar3;
        CriStatic oVar4;

        sVar2 = (sbyte)(param1.DAT_7A + 1);
        oVar4 = (CriStatic)param1.PTR_68[param1.DAT_78];
        oVar3 = SceneManager.instance.staticObjects[param1.DAT_78 + 5];
        param1.DAT_7A = (byte)sVar2;

        if (sVar2 == 11)
        {
            GameManager.instance.FUN_5C94C(oVar4, 145);

            //if (oVar4.DAT_79 != 4)
            //    ; //FUN_1D988
        }

        oVar3.vr.y = oVar3.vr.y + 0x40 & 0xfff;
        sVar1 = (short)(oVar4.screen.y + 4);
        oVar4.screen.y = sVar1;

        if (-0x433 < sVar1)
        {
            oVar3 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
            oVar3.flags |= 2;
            oVar4.screen.y = -0x433;
            GameManager.instance.FUN_5C860(145);

            if (oVar4.DAT_79 != 4)
                GameManager.instance.FUN_5C94C(oVar3, 146);

            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            InventoryManager.FUN_4A7E8(3, 0x2d, true);
            param1.DAT_78++;
            param1.DAT_7A = 0;

            if (3 < param1.DAT_78)
            {
                param1.DAT_3C += 2;
                InventoryManager.FUN_4A7E8(3, 0x3e, true);
            }
        }
    }

    //FUN_1870 (ST7)
    private void FUN_1870(CriParticle param1)
    {
        sbyte sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        CriStatic oVar4;
        CriParticle oVar5;
        CriStatic oVar6;
        CriStatic oVar7;

        oVar6 = (CriStatic)param1.PTR_68[param1.DAT_78];
        oVar7 = SceneManager.instance.staticObjects[param1.DAT_78 + 5];
        bVar4 = InventoryManager.FUN_4A87C(3, 0x2c);

        if (bVar4)
        {
            InventoryManager.FUN_4A7E8(3, 0x2c, false);

            if ((oVar6.flags & 2) != 0)
            {
                iVar4 = 0;

                do
                {
                    iVar4++;
                    oVar5 = SceneManager.instance.FUN_5FFA0();
                    oVar5.tags = 18;
                    oVar5.flags |= 2;
                    oVar5.screen.x = DAT_119F4[param1.DAT_78 * 3];
                    oVar5.screen.y = DAT_119F4[param1.DAT_78 * 3 + 1];
                    oVar5.screen.z = DAT_119F4[param1.DAT_78 * 3 + 2];
                    oVar5.DAT_4C = null;
                } while (iVar4 < 2);
            }
        }

        sVar2 = (sbyte)(param1.DAT_7A + 1);
        param1.DAT_7A = (byte)sVar2;

        if (sVar2 == 11)
        {
            GameManager.instance.FUN_5C94C(oVar6, 145);

            //if (oVar6.DAT_79 != 4)
            //    ; //FUN_1D988
        }

        sVar3 = (short)(oVar7.vr.z + 35);
        oVar7.vr.z = sVar3;

        if (0x400 < sVar3)
            oVar7.vr.z = 0x400;

        if ((oVar6.flags & 2) != 0)
        {
            bVar4 = InventoryManager.FUN_4A87C(3, 0x2d);

            if (!bVar4)
                param1.flags &= 0xfffffffd;
            else
                FUN_1B48(param1);
        }

        sVar3 = (short)(oVar6.screen.y + 4);
        oVar6.screen.y = sVar3;

        if (-0x433 < sVar3)
        {
            oVar4 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
            oVar4.flags |= 2;
            oVar6.screen.y = -0x433;
            GameManager.instance.FUN_5C860(145);

            if (oVar6.DAT_79 != 4)
                GameManager.instance.FUN_5C94C(oVar4, 146);

            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            InventoryManager.FUN_4A7E8(3, 0x2d, true);
            param1.DAT_78++;
            param1.DAT_7A = 0;

            if (3 < param1.DAT_78)
            {
                param1.DAT_3C++;
                InventoryManager.FUN_4A7E8(3, 0x3e, true);
            }
        }
    }

    //FUN_1B48 (ST7)
    private void FUN_1B48(CriParticle param1)
    {
        sbyte sVar1;

        sVar1 = (sbyte)param1.DAT_7B;

        if (sVar1 == 1)
            param1.flags &= 0xfffffffd;
        else
        {
            if (1 < sVar1)
            {
                if (sVar1 != 2)
                    return;

                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80118a50));
                param1.flags |= 2;
                param1.screen.x = DAT_11A18[param1.DAT_78] - 85;
                InventoryManager.FUN_4A7E8(3, 0x2d, false);
                param1.DAT_7B = 0;
                return;
            }

            if (sVar1 != 0)
                return;

            param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80118a48));
            param1.flags |= 2;
            param1.screen.x = DAT_11A18[param1.DAT_78];
        }

        param1.DAT_7B++;
    }

    //FUN_1C94 (ST7)
    private void FUN_1C94(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3f;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.vr.y = 0x400;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80118a58));
        param1.DAT_65 = 3;
        param1.DAT_4C = SceneManager.instance.cCamera;
        param1.DAT_3C++;
    }

    //FUN_1D20 (ST7)
    private void FUN_1D20(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_1D9C (ST7)
    private void FUN_1D9C(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11A3C[0]));
        param1.DAT_69 = 1;
        param1.DAT_68 = DAT_11A40[0];
        param1.DAT_3C++;
    }

    //FUN_1E24 (ST7)
    private void FUN_1E24(CriParticle param1)
    {
        sbyte sVar2;
        byte bVar3;

        sVar2 = (sbyte)(param1.DAT_68 - 1);
        param1.DAT_68 = (byte)sVar2;

        if (sVar2 == -1)
        {
            if (DAT_11A3C[param1.DAT_69] == 0)
                param1.flags &= 0xfffffffd;
            else
            {
                param1.flags |= 2;
                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11A3C[param1.DAT_69]));
            }

            param1.DAT_68 = DAT_11A40[param1.DAT_69];
            bVar3 = (byte)(param1.DAT_69 + 1);
            param1.DAT_69 = bVar3;

            if (2 < bVar3)
                param1.DAT_3C++;
        }
    }

    //FUN_1F74 (ST7)
    private void FUN_1F74(CriParticle param1)
    {
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x801223cc));
        param1.DAT_56 = 0x37;
        param1.DAT_54 = 0x7f33;
        param1.DAT_3C = 1;
        param1.DAT_50.a |= 2;
        param1.flags |= 2;
    }

    //FUN_1FD0 (ST7)
    private void FUN_1FD0(CriParticle param1)
    {
        int iVar1;

        param1.screen.y += param1.DAT_40.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.DAT_40.y += param1.DAT_68;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_20A8 (ST7)
    private void FUN_20A8(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11A6C[param1.DAT_2F]));
        param1.DAT_56 = 0x25;
        param1.DAT_54 = 0x7f36;
        param1.DAT_50.a |= 2;
        param1.vr.x = param1.DAT_68 << 4;
        param1.flags |= 2;
        param1.vr.z = param1.DAT_6A << 4;
        param1.vr.y = param1.DAT_69 << 4;
        sVar1 = 3;

        if (iVar2 != 1)
            sVar1 = (sbyte)(param1.DAT_3C + 1);

        param1.DAT_3C = (byte)sVar1;
    }

    //FUN_2150 (ST7)
    private void FUN_2150(CriParticle param1)
    {
        int iVar1;

        param1.screen.y += param1.DAT_40.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.DAT_40.y += param1.DAT_6B;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_221C (ST7)
    private void FUN_221C(CriParticle param1)
    {
        byte bVar1;
        int iVar2;

        bVar1 = param1.DAT_2F;
        param1.flags |= 2;

        if (bVar1 == 0 || (bVar1 < 8 && 5 < bVar1))
        {
            param1.DAT_56 = 0x67;
            param1.DAT_54 = 0x7f37;
            param1.DAT_50.r = param1.DAT_69;
            param1.DAT_50.g = param1.DAT_6A;
            param1.DAT_50.b = param1.DAT_6B;
        }
        else
        {
            param1.DAT_56 = 0x27;
            param1.DAT_54 = 0x7f38;
            param1.vr.z = param1.DAT_69 << 4;
        }

        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11AA8[param1.DAT_2F]));

        if (iVar2 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_2314 (ST7)
    private void FUN_2314(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_2348 (ST7)
    private void FUN_2348(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;

        bVar1 = (byte)(InventoryManager.FUN_4A87C(0, 0x50) ? 1 : 0);
        param1.BDAT_08 = bVar1;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x51) ? 1 : 0);
        param1.BDAT_08 = DAT_11AF8[param1.BDAT_08 | (bVar2 & 0x7f) << 1];
        bVar1 = (byte)(InventoryManager.FUN_4A87C(0, 0x52) ? 1 : 0);
        param1.BDAT_09 = bVar1;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x53) ? 1 : 0);
        param1.BDAT_09 = DAT_11AF8[param1.BDAT_09 | (bVar2 & 0x7f) << 1];
        bVar1 = (byte)(InventoryManager.FUN_4A87C(0, 0x54) ? 1 : 0);
        param1.BDAT_0A = (sbyte)bVar1;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x55) ? 1 : 0);
        param1.BDAT_0A = (sbyte)DAT_11AF8[(byte)param1.BDAT_0A | (bVar2 & 0x7f) << 1];
        //...
    }

    //FUN_244C (ST7)
    private void FUN_244C(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;
        sbyte sVar3;
        int iVar4;

        param1.DAT_0B = (sbyte)param1.BDAT_08;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x50) ? 1 : 0);
        param1.BDAT_08 = bVar2;
        iVar4 = InventoryManager.FUN_4A87C(0, 0x51) ? 1 : 0;
        param1.DAT_11 = (byte)(param1.BDAT_08 | (iVar4 << 1));
        param1.BDAT_08 = DAT_11AF8[param1.BDAT_08 | iVar4 << 1 & 0xff];

        if (param1.DAT_11 == 3)
            param1.DAT_11 = 2;

        bVar1 = (byte)param1.DAT_0B;

        if (param1.BDAT_08 != bVar1)
        {
            sVar3 = (sbyte)(bVar1 - 2);

            if (bVar1 <= param1.BDAT_08)
                sVar3 = (sbyte)(bVar1 + 2);

            param1.BDAT_08 = (byte)sVar3;
        }

        param1.DAT_0B = (sbyte)param1.BDAT_09;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x52) ? 1 : 0);
        param1.BDAT_09 = bVar2;
        iVar4 = InventoryManager.FUN_4A87C(0, 0x53) ? 1 : 0;
        param1.DAT_12 = (sbyte)(param1.BDAT_09 | (iVar4 << 1));
        param1.BDAT_09 = DAT_11AF8[param1.BDAT_09 | iVar4 << 1 & 0xff];

        if (param1.DAT_12 == 3)
            param1.DAT_12 = 2;

        bVar1 = (byte)param1.DAT_0B;

        if (param1.BDAT_09 != bVar1)
        {
            sVar3 = (sbyte)(bVar1 - 2);

            if (bVar1 <= param1.BDAT_09)
                sVar3 = (sbyte)(bVar1 + 2);

            param1.BDAT_09 = (byte)sVar3;
        }

        param1.DAT_0B = param1.BDAT_0A;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x54) ? 1 : 0);
        param1.BDAT_0A = (sbyte)bVar2;
        iVar4 = InventoryManager.FUN_4A87C(0, 0x55) ? 1 : 0;
        param1.DAT_13 = (sbyte)((byte)param1.BDAT_0A | (iVar4 << 1));
        param1.BDAT_0A = (sbyte)DAT_11AF8[(byte)param1.BDAT_0A | iVar4 << 1 & 0xff];

        if (param1.DAT_13 == 3)
            param1.DAT_13 = 2;

        bVar1 = (byte)param1.DAT_0B;

        if ((byte)param1.BDAT_0A != bVar1)
        {
            sVar3 = (sbyte)(bVar1 - 2);

            if (bVar1 <= (byte)param1.BDAT_0A)
                sVar3 = (sbyte)(bVar1 + 2);

            param1.BDAT_0A = sVar3;
        }

        if (param1.BDAT_08 == 0xfe || param1.BDAT_09 == 0xfe || (byte)param1.BDAT_0A == 0xfe)
            InventoryManager.FUN_4A7E8(0, 0x56, true);
    }

    //FUN_2644 (ST7)
    private void FUN_2644(CriInteract param1)
    {
        param1.DAT_03 = 3;
    }

    //FUN_2B04 (ST7)
    private void FUN_2B04(CriInteract param1)
    {
        param1.DAT_0A = 0;
        param1.DAT_08 = 0;
        param1.DAT_03++;
    }

    //FUN_2B1C (ST7)
    private void FUN_2B1C(CriInteract param1)
    {
        byte bVar1;
        short sVar2;
        short sVar3;
        sbyte sVar4;
        short sVar5;
        int iVar6;
        CriParticle oVar7;

        sVar5 = param1.DAT_0A;
        sVar3 = param1.DAT_0A;

        while (sVar3 < 9 && DAT_11B0C[(iVar6 = sVar5 * 12) + 6] == param1.DAT_08)
        {
            oVar7 = SceneManager.instance.FUN_5FFA0();

            if (oVar7 != null)
            {
                oVar7.tags = 20;
                bVar1 = DAT_11B0C[iVar6 + 7];
                oVar7.DAT_62 = bVar1;
                oVar7.DAT_60 = bVar1;
                oVar7.DAT_4C = SceneManager.instance.staticObjects[param1.DAT_04];
                oVar7.DAT_40.x = DAT_11B0C[iVar6 + 8] << 0x18 >> 0x17;
                oVar7.DAT_40.y = DAT_11B0C[iVar6 + 9] << 0x18 >> 0x17;
                bVar1 = DAT_11B0C[iVar6 + 10];
                oVar7.IDAT_6C = 0x80;
                oVar7.DAT_40.z = bVar1 << 0x18 >> 0x17;
                bVar1 = param1.DAT_06;

                if (bVar1 == 1)
                {
                    oVar7.DAT_50.r = 0;
                    oVar7.DAT_50.g = 0x80;
                    oVar7.DAT_50.b = 0;
                }
                else
                {
                    if (bVar1 < 2)
                    {
                        if (bVar1 == 0)
                        {
                            oVar7.DAT_50.r = 0x80;
                            oVar7.DAT_50.g = 0;
                            oVar7.DAT_50.b = 0;
                        }
                    }
                    else
                    {
                        if (bVar1 == 2)
                        {
                            oVar7.DAT_50.r = 0;
                            oVar7.DAT_50.g = 0;
                            oVar7.DAT_50.b = 0x80;
                        }
                    }
                }
            }

            sVar5 = (short)(param1.DAT_0A + 1);
            param1.DAT_0A = sVar5;
            sVar3 = sVar5;
        }

        sVar2 = param1.DAT_08;
        param1.DAT_08 = (short)(sVar2 + 1);

        if (5 < (short)(sVar2 + 1))
        {
            param1.DAT_0A = 0;
            param1.DAT_08 = 0;
        }

        sVar4 = (sbyte)(param1.DAT_05 - 1);
        param1.DAT_05 = (byte)sVar4;

        if (sVar4 == 0)
            param1.DAT_03++;
    }

    //FUN_2D18 (ST7)
    private void FUN_2D18(CriInteract param1)
    {
        byte bVar1;
        uint uVar2;
        CriInteract oVar3;

        oVar3 = SceneManager.instance.DAT_8FFC[0];
        bVar1 = (byte)oVar3.DAT_13;
        uVar2 = (uint)DAT_11B84[(byte)oVar3.DAT_12 + oVar3.DAT_11 * 12];
        param1.DAT_03 = 1;
        param1.DAT_08 = (short)((int)((uVar2 >> ((bVar1 & 3) << 3) & 0xff) * 3) >> 1);
    }

    //FUN_2D80 (ST7)
    private void FUN_2D80(CriInteract param1)
    {
        short sVar1;
        int iVar2;
        CriInteract oVar3;
        bool bVar4;

        oVar3 = SceneManager.instance.DAT_8FFC[0];
        param1.DAT_0A = param1.DAT_08;
        iVar2 = ((DAT_11B84[(byte)oVar3.DAT_12 + oVar3.DAT_11 * 12] >> (((byte)oVar3.DAT_13 & 3) << 3) & 0xff) * 3) >> 1;
        param1.DAT_08 = (short)iVar2;

        if (iVar2 != param1.DAT_0A)
        {
            sVar1 = (short)(param1.DAT_0A - 1);

            if (param1.DAT_0A <= iVar2)
                sVar1 = (short)(param1.DAT_0A + 1);

            param1.DAT_08 = sVar1;
        }

        sVar1 = param1.DAT_08;

        if (45 < sVar1 && 75 < sVar1 && sVar1 < 129)
            InventoryManager.FUN_4A7E8(3, 0x17, true);

        param1.BDAT_0C = 0xc0;
        param1.DAT_0D = 0;
        param1.BDAT_0E = 0xc0;
        bVar4 = InventoryManager.FUN_4A87C(3, 0x20);

        if (!bVar4)
            param1.DAT_03 = 2;

        //FUN_2EA0
    }

    //FUN_2E94 (ST7)
    private void FUN_2E94(CriInteract param1)
    {
        param1.DAT_03 = 3;
    }

    //FUN_333C (ST7)
    private void FUN_333C(CriInteract param1)
    {
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
        param1.BDAT_0C = 0xff;
        param1.DAT_0D = 0xff;
        param1.BDAT_0E = 0xff;
        param1.DAT_0F = 0xff;
        param1.BDAT_0A = 0;
        param1.BDAT_09 = 0;
        param1.BDAT_08 = 0;
        param1.DAT_03 = 1;
    }

    //FUN_33CC (ST7)
    private void FUN_33CC(CriInteract param1)
    {
        sbyte sVar1;

        //FUN_36BC

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
        {
            if (param1.BDAT_08 == 4)
                param1.BDAT_08 = 0;
            else
                param1.BDAT_08++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
        {
            sVar1 = (sbyte)(param1.BDAT_08 - 1);

            if (param1.BDAT_08 == 0)
                sVar1 = 4;

            param1.BDAT_08 = (byte)sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
        {
            sVar1 = (sbyte)(param1.BDAT_09 - 1);

            if (param1.BDAT_09 == 0)
                sVar1 = 1;

            param1.BDAT_09 = (byte)sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
        {
            if (param1.BDAT_09 == 1)
                param1.BDAT_09 = 0;
            else
                param1.BDAT_09++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            param1.SET_OFFSET_08(param1.BDAT_0A + 4, (byte)(param1.BDAT_08 + param1.BDAT_09 * 5));

            if (param1.BDAT_0A == 3)
                param1.DAT_03 = 2;

            param1.BDAT_0A++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            if (param1.BDAT_0A == 0)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_03 = 4;
            }
            else
            {
                param1.SET_OFFSET_08(param1.BDAT_0A + 3, 0xff);
                param1.BDAT_0A--;
            }

            GameManager.instance.FUN_5C94C(null, 147);
        }
    }

    //FUN_35C4 (ST7)
    private void FUN_35C4(CriInteract param1)
    {
        bool bVar1;
        int iVar4;
        int iVar5;

        //FUN_36BC
        bVar1 = false;
        iVar4 = 0;

        do
        {
            if (param1.GET_OFFSET_08(iVar4 + 4) != DAT_11BBC[iVar4])
            {
                bVar1 = true;
                break;
            }

            iVar4++;
        } while (iVar4 < 4);

        if (bVar1)
        {
            InventoryManager.FUN_4A7E8(2, 10, true);
            iVar5 = 149;
        }
        else
        {
            InventoryManager.FUN_4A7E8(2, 9, true);
            iVar5 = 148;
        }

        GameManager.instance.FUN_5C94C(null, iVar5);
        param1.DAT_03 = 3;
    }

    //FUN_367C (ST7)
    private void FUN_367C(CriInteract param1)
    {
        bool bVar1;

        //FUN_36BC
        bVar1 = InventoryManager.FUN_4A87C(3, 0x30);

        if (bVar1)
            param1.DAT_03 = 4;
    }

    //FUN_3A60 (ST7)
    private void FUN_3A60(CriInteract param1)
    {
        //...
        param1.DAT_03++;
    }

    //FUN_3AAC (ST7)
    private void FUN_3AAC(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;
        
        bVar1 = (byte)(param1.GET_OFFSET_08(10) + 1);
        param1.SET_OFFSET_08(10, bVar1);

        if ((bVar1 & 1) != 0)
        {
            bVar1 = param1.GET_OFFSET_08(9);

            if (bVar1 == 1)
            {
                sVar2 = (sbyte)(param1.GET_OFFSET_08(8) - 1);
                param1.SET_OFFSET_08(8, (byte)sVar2);

                if (sVar2 == 0)
                    param1.SET_OFFSET_08(9, (byte)(param1.GET_OFFSET_08(9) - 1));
            }
            else
            {
                if (bVar1 < 2)
                {
                    if (bVar1 == 0)
                    {
                        bVar1 = (byte)(param1.GET_OFFSET_08(8) + 1);
                        param1.SET_OFFSET_08(9, bVar1);

                        if (7 < bVar1)
                            param1.SET_OFFSET_08(9, (byte)(param1.GET_OFFSET_08(9) + 1));
                    }
                }
                else
                {
                    if (bVar1 == 2)
                    {
                        if (param1.GET_OFFSET_08(8) == 0)
                            param1.DAT_03++;
                        else
                            param1.SET_OFFSET_08(8, (byte)(param1.GET_OFFSET_08(8) - 1));
                    }
                }
            }
        }

        bVar3 = InventoryManager.FUN_4A87C(2, 0x1a);

        if (bVar3)
        {
            InventoryManager.FUN_4A7E8(2, 0x1a, false);
            param1.SET_OFFSET_08(9, 2);
        }
    }

    //FUN_3BD8 (ST7)
    private void FUN_3BD8(CriInteract param1)
    {
        FUN_60100(param1);
        param1.FUN_5FF98();
    }

    //FUN_3D90 (ST7)
    private void FUN_3D90(CriInteract param1)
    {
        if (param1.DAT_02 == 0)
        {
            param1.PTR_10 = DAT_11BE0;
            param1.BDAT_0E = 49;
            param1.PDAT_14 = SceneManager.instance.skinnedObjects[param1.DAT_04];
        }
        else
        {
            param1.PTR_10 = DAT_12018;
            param1.BDAT_0E = 10;
        }

        param1.DAT_0C = 0;
        param1.DAT_03++;
        //FUN_3E2C
    }

    //FUN_3E2C (ST7)
    private void FUN_3E2C(CriInteract param1)
    {
        //...
    }

    //FUN_3FA8 (ST7)
    private void FUN_3FA8(CriPlayer param1)
    {
        return;
    }

    //FUN_3FDC (ST7)
    private void FUN_3FDC(CriPlayer param1)
    {
        CriSkinned oVar1;

        param1.PTR_120 = DAT_12148;
        param1.DAT_120 = 0;
        param1.PTR_130 = DAT_12148;
        param1.DAT_130 = 0;
        param1.PTR_124 = DAT_12148;
        param1.DAT_124 = 2;
        param1.DAT_12E = 1;
        param1.DAT_12F = 1;
        param1.DAT_3C++;
        param1.FUN_77784(1, param1.PTR_130[param1.DAT_130].radius);
        param1.health = 1000;
        param1.maxHealth = 1000;
        param1.FUN_609C8(0, 0, 0);
        param1.FUN_66404(0, 0x800, 0xc00);
        param1.FUN_66460(true);
        oVar1 = SceneManager.instance.skinnedObjects[10];
        param1.DAT_3A = param1.DAT_2F;
        param1.DAT_154 = oVar1;
        param1.PDAT_1D4 = PTR_DAT_12130[param1.DAT_3A].DAT_00;
        param1.DAT_1DA = PTR_DAT_12130[param1.DAT_3A].DAT_04;
        param1.DAT_1A5 = 7;
        param1.DAT_140 |= 1;
        //...
    }

    //FUN_420C (ST7)
    private void FUN_420C(CriPlayer param1)
    {
        if (param1.screen.y == 0)
        {
            if ((param1.DAT_1C0 & 1) == 0)
            {
                if (param1.DAT_2F == 1 && (param1.PDAT_1C8.BDAT_08 & 2) != 0)
                {
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 1;
                    param1.DAT_3F = 0;
                    param1.FUN_609C8(13, 1, 0);
                    param1.IDAT_1C4 = 30;
                }
            }
            else
            {
                param1.DAT_3D = 6;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
        }
    }

    //FUN_4468 (ST7)
    private void FUN_4468(CriPlayer param1)
    {
        if (param1.screen.y == 0 && (param1.DAT_1C0 & 1) != 0)
        {
            param1.DAT_3D = 6;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_4BB8 (ST7)
    private void FUN_4BB8(CriPlayer param1)
    {
        uint uVar1;
        CriInteract oVar2;

        Utilities.FUN_63160(param1.screen, param1.DAT_154.screen);
        oVar2 = param1.PDAT_1C8;

        if (param1.DAT_148 < 0x10)
        {
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            oVar2.BDAT_08 |= 8;
        }
        else
        {
            if ((oVar2.BDAT_08 & 8) != 0)
            {
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
            }
        }

        if (param1.DAT_3A != 1 && param1.frame.DAT_01 == 24)
        {
            uVar1 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_12410[uVar1 & 1]);
        }
    }

    //FUN_4C84 (ST7)
    private void FUN_4C84(CriPlayer param1)
    {
        byte bVar1;
        sbyte sVar2;
        uint uVar3;
        bool bVar4;
        int iVar5;

        bVar1 = param1.DAT_3E;

        if (bVar1 == 1)
        {
            bVar4 = param1.FUN_60AB4();

            if (!bVar4)
                return;

            uVar3 = GameManager.FUN_64650();

            if ((uVar3 & 0x40) == 0)
                return;

            iVar5 = 9;
            sVar2 = (sbyte)(param1.DAT_3E + 1);
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 != 0)
                    return;

                param1.DAT_3E = 1;
                uVar3 = GameManager.FUN_64650();
                param1.FUN_6103C(1, 1, (byte)(uVar3 & 0xf), 10);
                return;
            }

            if (bVar1 != 2)
                return;

            bVar4 = param1.FUN_60AB4();

            if (!bVar4)
                return;

            iVar5 = 1;
            sVar2 = (sbyte)(param1.DAT_3E - 1);
        }

        param1.DAT_3E = (byte)sVar2;
        param1.FUN_609C8(iVar5, 1, 10);
    }

    //FUN_4D80 (ST7)
    private void FUN_4D80(CriPlayer param1)
    {
        ushort uVar1;
        short sVar2;
        short sVar3;
        uint uVar4;
        int iVar5;
        Vector3Int puVar6;
        int iVar7;
        CriSkinned oVar7;
        Vector3Int local_20;

        local_20 = new Vector3Int(param1.screen.x, 0, param1.screen.z);
        oVar7 = param1.DAT_154;

        if ((param1.DAT_1C0 & 2) == 0)
        {
            iVar7 = (int)GameManager.FUN_64650();
            uVar4 = param1.DAT_1DA;

            if (uVar4 == 0)
                return; //0x1c00

            if (uVar4 == 0xffffffff && iVar7 == -0x80000000)
                return; //0x1800

            puVar6 = param1.PDAT_1D4[iVar7 % (int)uVar4];
            param1.DAT_158.x = puVar6.x;
            param1.DAT_158.z = puVar6.y;
            sVar2 = (short)puVar6.z;
            param1.BDAT_1DC = (byte)(iVar7 % (int)uVar4);
            param1.SDAT_1D8 = sVar2;
            uVar4 = param1.DAT_1C0 | 2;
        }
        else
        {
            sVar2 = (short)Utilities.FUN_615EC(local_20, param1.DAT_10C);
            sVar3 = (short)Utilities.FUN_64838(param1.vr.y, 30, sVar2);
            param1.vr.y += sVar3;

            if (param1.DAT_148 != 0)
            {
                GameManager.instance.FUN_774CC(param1, oVar7.screen);
                uVar1 = param1.DAT_148;
                iVar5 = (int)GameManager.FUN_64650();
                iVar7 = iVar5;

                if (iVar5 < 0)
                    iVar7 = iVar5 + 7;

                if (uVar1 <= iVar5 + (iVar7 >> 3) * -8 + 0x10)
                    return;

                if (param1.screen.y != 0)
                    return;

                if (param1.DAT_2F == 0)
                {
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 1;
                    param1.DAT_3F = 0;
                }
                else
                {
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }

                param1.DAT_1DD = (byte)param1.PDAT_1C8.DAT_0B;
                param1.DAT_1C0 &= 0xfffffffc;
                param1.FUN_609C8(13, 1, 0);
                iVar7 = (int)GameManager.FUN_64650();
                param1.DAT_112 = (short)(iVar7 + (iVar7 / 30) * -30 + 60);
                return;
            }

            param1.DAT_3D = 7;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_40.z = 0;
            uVar4 = param1.DAT_1C0 & 0xfffffffd;
        }

        param1.DAT_1C0 = uVar4;
    }

    //FUN_5134 (ST7)
    private void FUN_5134(CriPlayer param1)
    {
        byte bVar1;

        if (param1.DAT_3E != 0 && param1.screen.y == 0)
        {
            if (param1.DAT_2F == 1)
            {
                if (param1.IDAT_1C4 != 0)
                {
                    param1.IDAT_1C4--;
                    return;
                }

                bVar1 = 2;
            }
            else
            {
                bVar1 = 6;

                if ((byte)param1.PDAT_1C8.DAT_0B <= param1.DAT_1DD)
                {
                    if (param1.DAT_3E < 2)
                        return;

                    bVar1 = 2;

                    if (param1.DAT_112 != 0)
                    {
                        param1.DAT_112--;
                        return;
                    }
                }
            }

            param1.DAT_3D = bVar1;
            param1.DAT_3E = 0;
        }
    }

    //FUN_5A68 (ST7)
    private void FUN_5A68(CriPlayer param1)
    {
        PTR_FUN_12444[param1.DAT_3D](param1);
        PTR_FUN_12468[param1.DAT_3D](param1);
    }

    //FUN_6184 (ST7)
    private void FUN_6184(CriPlayer param1)
    {
        ushort uVar1;

        uVar1 = (ushort)(param1.DAT_1A0 >> 4 & 0xf);
        param1.DAT_11E &= 0x7f;
        //...
        param1.DAT_3C = 3;
        param1.DAT_11E |= 0x40;
    }

    //FUN_6424 (ST7)
    private void FUN_6424(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        bool bVar2;
        int iVar3;
        uint uVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)param1.DAT_154;
        param1.PTR_120 = DAT_12148;
        param1.DAT_120 = 1;
        bVar2 = SceneManager.instance.FUN_802B8(param1, false, 1);

        if (!bVar2) goto LAB_6634;

        if ((param1.DAT_1C0 & 0x40) == 0)
            iVar2 = (GameManager.instance.DAT_922D == 0 ? 1 : 0) << 1;
        else
        {
            iVar2 = 1;

            if (GameManager.instance.DAT_922D == 0)
            {
                iVar2 = 2;
                uVar4 = GameManager.FUN_64650();

                if ((0x24 >> (int)(uVar4 & 7) & 1U) != 0)
                    iVar2 = 1;
            }
        }

        param1.DAT_1C0 &= 0xffffff9f;
        iVar3 = Utilities.FUN_615EC(oVar5.screen, param1.screen);
        uVar4 = (uint)((iVar3 - (oVar5.vr.y & 0xfff) + 0x200 & 0xfff) >> 10);

        if (iVar2 == 1)
        {
            param1.DAT_2E = (byte)uVar4;

            if ((uVar4 & 1) == 0)
            {
                param1.DAT_2E = (byte)(uVar4 >> 1);

                if ((GameManager.instance.DAT_922C >> param1.DAT_2E & 0x1f & 1) == 0)
                {
                    GameManager.instance.DAT_922C |= (byte)(1 << param1.DAT_2E & 0x1f);
                    param1.DAT_3D = 4;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_40 = new Vector3Int(0, 0, 0);
                    param1.PTR_120 = null;
                    param1.DAT_120 = 0;
                    GameManager.instance.DAT_922D++;
                    //FUN_1D988
                    goto LAB_6634;
                }
            }

            param1.DAT_3E++;
        }
        else
        {
            if (iVar2 != 2) goto LAB_6634;

            oVar5.FUN_539F8(0, 200, (int)uVar4);
            param1.DAT_3E++;
            sVar1 = (short)(oVar5.health - 10);
            oVar5.health = sVar1;

            if (sVar1 < 10)
                oVar5.health = 10;

            //FUN_1D988
        }

        LAB_6634:
        param1.PTR_120 = DAT_12148;
        param1.DAT_120 = 0;
    }

    //FUN_6890 (ST7)
    private void FUN_6890(CriInteract param1)
    {
        if (param1.DAT_02 == 0)
        {
            param1.BDAT_08 = 15;
            param1.BDAT_09 = 0;
            param1.BDAT_0A = 0;
            param1.DAT_0B = 0;
        }
        else
        {
            param1.BDAT_08 = 165;
            param1.BDAT_09 = 90;
            param1.BDAT_0A = 0;
            param1.DAT_0B = 90;
        }

        param1.DAT_0D = 0xff;
        param1.DAT_0F = 0xff;
        param1.BDAT_0C = 0;
        param1.BDAT_0E = 0;
        param1.PTR_10 = null;
        param1.PDAT_14 = null;
        param1.SDAT_18 = 0x102;
        param1.DAT_04 = 0;
        param1.DAT_05 = 0;
        param1.DAT_06 = 0;
        param1.DAT_07 = 0;
        param1.DAT_03++;
    }

    //FUN_6910 (ST7)
    private void FUN_6910(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_15 + 1);
        param1.DAT_15 = (sbyte)bVar1;
        
        if (1 < bVar1)
        {
            param1.DAT_15 = 0;
            param1.DAT_14++;
        }

        if (7 < (byte)param1.DAT_14)
            param1.DAT_03++;
    }

    //FUN_696C (ST7)
    private void FUN_696C(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;
        uint uVar4;

        bVar1 = param1.DAT_19;

        if (bVar1 == 1)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && param1.DAT_02 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_19 = 2;
                return;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8040) != 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_19 = 0;
                return;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0 && param1.DAT_13 != 0) 
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_13--;
                return;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 4 < param1.DAT_13)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                    return;

                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_03 = 4;
                uVar4 = (byte)param1.DAT_13;
                bVar3 = (byte)((param1.BDAT_08 << (6 - (byte)param1.DAT_13 & 0x1f)) & 0xc0);
                bVar1 = (byte)((param1.BDAT_0A << (6 - (int)uVar4 & 0x1f)) & 0xc0);
                param1.DAT_04 = (byte)(param1.BDAT_0A >> 2);
                param1.DAT_1A = (byte)(param1.BDAT_08 >> 2);

                if (uVar4 < 6)
                {
                    switch (uVar4)
                    {
                        case 0:
                            param1.DAT_0D = 0xfc;
                            param1.BDAT_0C = 0xfc;
                            param1.DAT_1A |= (byte)(param1.BDAT_08 << 6);
                            param1.DAT_04 |= (byte)(param1.BDAT_0A << 6);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            return;
                        case 1:
                            param1.DAT_0D = 0xf9;
                            param1.BDAT_0C = 0xf9;
                            param1.DAT_1A &= 0x3e;
                            param1.DAT_04 &= 0x3e;
                            param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 1);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 1);
                            return;
                        case 2:
                            param1.DAT_0D = 0xf3;
                            param1.BDAT_0C = 0xf0;
                            param1.DAT_1A &= 0x3c;
                            param1.DAT_04 &= 0x3c;
                            param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 3);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 3);
                            return;
                        case 3:
                            param1.DAT_0D = 0xe7;
                            param1.BDAT_0C = 0xf0;
                            param1.DAT_1A &= 0x38;
                            param1.DAT_04 &= 0x38;
                            param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 7);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 7);
                            return;
                        case 4:
                            param1.DAT_0D = 0xcf;
                            param1.BDAT_0C = 0xe0;
                            param1.DAT_1A &= 0x30;
                            param1.DAT_04 &= 0x30;
                            param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 15);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 15);
                            return;
                        case 5:
                            param1.DAT_0D = 0x9f;
                            param1.BDAT_0C = 0xc0;
                            param1.DAT_1A &= 0x20;
                            param1.DAT_04 &= 0x20;
                            param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 31);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 31);
                            return;
                    }
                }

                param1.DAT_1A |= bVar3;
                param1.DAT_06 = (byte)param1.DAT_13;
                param1.DAT_04 |= bVar1;
                return;
            }

            GameManager.instance.FUN_5C94C(null, 150);
            param1.DAT_13++;
            return;
        }

        if (1 < bVar1)
        {
            if (bVar1 == 2)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x8040) != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_19 = 1;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0 && param1.DAT_13 != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_13--;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 4 < (byte)param1.DAT_13)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                        return;

                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_03 = 7;
                    uVar4 = (byte)param1.DAT_13;
                    param1.DAT_05 = (byte)(param1.DAT_0B >> 2);
                    param1.DAT_1B = (byte)(param1.BDAT_09 >> 2);
                    bVar3 = (byte)(param1.BDAT_09 << (6 - (byte)param1.DAT_13 & 0x1f) & 0xc0);
                    bVar1 = (byte)((byte)param1.DAT_0B << (6 - (int)uVar4 & 0x1f) & 0xc0);

                    if (5 < uVar4)
                    {
                        param1.DAT_1B = (byte)(param1.DAT_1B | bVar3);
                        param1.DAT_05 = (byte)(param1.DAT_05 | bVar1);
                        return;
                    }

                    switch (uVar4)
                    {
                        case 0:
                            param1.DAT_0F = 0xfc;
                            param1.BDAT_0E = 0xfc;
                            param1.DAT_1B = (byte)(param1.DAT_1B | param1.BDAT_09 << 6);
                            param1.DAT_05 = (byte)(param1.DAT_05 | (byte)param1.DAT_0B << 6);
                            return;
                        case 1:
                            param1.DAT_0F = 0xf9;
                            param1.BDAT_0E = 0xf8;
                            param1.DAT_1B &= 0x3e;
                            param1.DAT_05 &= 0x3e;
                            param1.DAT_1B = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 1);
                            param1.DAT_05 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 1);
                            return;
                        case 2:
                            param1.DAT_0F = 0xf3;
                            param1.BDAT_0E = 0xf0;
                            param1.DAT_1B &= 0x3c;
                            param1.DAT_05 &= 0x3c;
                            param1.DAT_1B = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 3);
                            param1.DAT_05 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 3);
                            return;
                        case 3:
                            param1.DAT_0F = 0xe7;
                            param1.BDAT_0E = 0xf0;
                            param1.DAT_1B &= 0x38;
                            param1.DAT_05 &= 0x38;
                            param1.DAT_1B = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 7);
                            param1.DAT_05 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 7);
                            return;
                        case 4:
                            param1.DAT_0F = 0xcf;
                            param1.BDAT_0E = 0xe0;
                            param1.DAT_1B &= 0x30;
                            param1.DAT_05 &= 0x30;
                            param1.DAT_1B = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 15);
                            param1.DAT_05 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 15);
                            return;
                        case 5:
                            param1.DAT_0F = 0x9f;
                            param1.BDAT_0E = 0xc0;
                            param1.DAT_1B &= 0x20;
                            param1.DAT_05 &= 0x20;
                            param1.DAT_1B = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 31);
                            param1.DAT_05 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 31);
                            return;
                    }
                }
            }
            else
            {
                if (bVar1 != 3)
                    return;

                if ((InputManager.controllers[0].DAT_B58B8 & 0x8040) != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_19 = 0;

                    if (param1.DAT_13 != 6)
                        return;

                    param1.DAT_13 = 5;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 5 < (byte)param1.DAT_13)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0x20a0) == 0)
                        return;

                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_03 = 10;
                    uVar4 = (byte)param1.DAT_13;
                    bVar3 = (byte)((param1.BDAT_08 << (6 - (byte)param1.DAT_13 & 31)) & 0xc0);
                    bVar1 = (byte)((param1.BDAT_0A << (6 - (int)uVar4 & 31)) & 0xc0);
                    param1.DAT_04 = (byte)(param1.BDAT_0A >> 2);
                    param1.DAT_1A = (byte)(param1.BDAT_08 >> 2);

                    if (uVar4 < 7)
                    {
                        switch (uVar4)
                        {
                            case 0:
                                param1.DAT_0D = 0xfc;
                                param1.BDAT_0C = 0xfc;
                                param1.DAT_1A = (byte)(param1.DAT_1A | param1.BDAT_08 << 6);
                                param1.DAT_04 = (byte)(param1.DAT_04 | (byte)param1.BDAT_0A << 6);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                return;
                            case 1:
                                param1.DAT_0D = 0xf9;
                                param1.BDAT_0C = 0xf8;
                                param1.DAT_1A &= 0x3e;
                                param1.DAT_04 &= 0x3e;
                                param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 1);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 1);
                                return;
                            case 2:
                                param1.DAT_0D = 0xf3;
                                param1.BDAT_0C = 0xf0;
                                param1.DAT_1A &= 0x3c;
                                param1.DAT_04 &= 0x3c;
                                param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 3);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 3);
                                return;
                            case 3:
                                param1.DAT_0D = 0xe7;
                                param1.BDAT_0C = 0xf0;
                                param1.DAT_1A &= 0x38;
                                param1.DAT_04 &= 0x38;
                                param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 7);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 7);
                                return;
                            case 4:
                                param1.DAT_0D = 0xcf;
                                param1.BDAT_0C = 0xe0;
                                param1.DAT_1A &= 0x30;
                                param1.DAT_04 &= 0x30;
                                param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 15);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 15);
                                return;
                            case 5:
                                param1.DAT_0D = 0x9f;
                                param1.BDAT_0C = 0xc0;
                                param1.DAT_1A &= 0x20;
                                param1.DAT_04 &= 0x20;
                                param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 31);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 31);
                                return;
                            case 6:
                                param1.DAT_0D = 0x3f;
                                param1.DAT_1A = 0;
                                param1.DAT_04 = 0;
                                param1.BDAT_0C = 0;
                                param1.DAT_1A = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 63);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 = (byte)(param1.DAT_04 | bVar1 | param1.BDAT_0A & 63);
                                return;
                        }
                    }

                    param1.DAT_1A |= bVar3;
                    param1.DAT_06 = (byte)param1.DAT_13;
                    param1.DAT_04 |= bVar1;
                    return;
                }
            }

            GameManager.instance.FUN_5C94C(null, 150);
            param1.DAT_13++;
            return;
        }

        if (bVar1 != 0)
            return;

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 150);
            bVar1 = param1.DAT_18;

            if (bVar1 == 1)
            {
                param1.DAT_03 = 0;
                return;
            }

            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    InventoryManager.FUN_4A7E8(2, 0xb, true);
                    param1.DAT_03 = 16;
                    return;
                }
            }
            else
            {
                if (bVar1 == 2)
                {
                    param1.DAT_19 = 1;
                    return;
                }

                if (bVar1 == 3) goto LAB_6A88;
            }
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_18++;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_18--;
            }

            if (param1.DAT_02 != 0)
            {
                if (param1.DAT_18 == 0xff)
                    param1.DAT_18 = 3;

                param1.DAT_18 &= 3;
                return;
            }

            sVar2 = (sbyte)param1.DAT_18;

            if (sVar2 == -1)
            {
                param1.DAT_18 = 2;
                sVar2 = (sbyte)param1.DAT_18;
            }

            if (sVar2 != 3)
                return;

            param1.DAT_18 = 0;
            return;
        }

        GameManager.instance.FUN_5C94C(null, 150);
        bVar1 = param1.DAT_18;

        if (bVar1 == 2)
        {
            param1.DAT_19 = 1;
            return;
        }

        if (bVar1 != 3)
            return;

        LAB_6A88:
        param1.DAT_19 = bVar1;
    }

    //FUN_95DC (ST7)
    private void FUN_95DC(CriInteract param1)
    {
        short sVar1;
        bool bVar2;
        int iVar2;
        CriStatic oVar2;
        CriStatic oVar3;
        int iVar4;
        bool bVar4;
        CriStatic oVar4;
        int puVar5;
        int iVar6;
        CriCamera oVar6;

        SceneManager.instance.FUN_26EBC(2, 0);
        SceneManager.instance.FUN_264C4(0, 0, -38, -750);
        oVar6 = SceneManager.instance.cCamera;
        iVar4 = 1;
        oVar2 = SceneManager.instance.staticObjects[0];
        oVar2.DAT_48 = 0;
        oVar6.DAT_36 = 200;
        oVar2.screen.z = 0xba4;
        oVar2.screen.x = 0;

        do
        {
            SceneManager.instance.staticObjects[iVar4].DAT_48 = 0;
            iVar4++;
        } while (iVar4 < 8);

        iVar4 = 0;
        iVar6 = 0;
        puVar5 = 0;

        do
        {
            bVar2 = InventoryManager.FUN_4A87C(3, (uint)iVar4 + 0x2c);
            iVar2 = iVar4;

            if (iVar2 == 0)
                DAT_12870[puVar5] = -1;
            else
            {
                oVar3 = SceneManager.instance.staticObjects[iVar6 + 1];
                iVar2 = iVar4;

                if (iVar4 < 0)
                    iVar2 = iVar4 + 3;

                sVar1 = (short)(iVar2 >> 2);
                oVar3.screen.x = sVar1 * -0x960 + 0x12c0;
                oVar3.screen.y = -2200;
                oVar3.screen.z = (iVar4 + sVar1 * -4) * -4000 + 3000;
                DAT_12870[puVar5] = (sbyte)iVar6;
                iVar6++;
            }

            iVar4++;
            puVar5++;
        } while (iVar4 < 20);

        if (param1.DAT_02 == 0)
        {
            DAT_12870[3] = -0x10;
            DAT_12870[7] = -0x10;
            DAT_12870[11] = -0x10;
            DAT_12870[15] = -0x10;
            DAT_12870[19] = -0x10;
        }

        param1.BDAT_0A = 6;
        param1.DAT_18 = 8;
        param1.DAT_0B = 0;
        param1.BDAT_08 = 0;
        param1.BDAT_09 = 0;
        param1.PDAT_0C = null;
        param1.PTR_10 = null;
        param1.PDAT_14 = null;
        param1.DAT_19 = 0;
        param1.DAT_1A = 0xff;
        param1.DAT_1B = 0;
        bVar4 = InventoryManager.FUN_4A87C(3, 0x2b);

        if (bVar4)
        {
            oVar4 = SceneManager.instance.staticObjects[iVar6 + 1];
            oVar4.screen.y = -6270;
            oVar4.screen.z = 3000;
            oVar4.screen.x = 0;
            param1.DAT_19 = 1;
            param1.DAT_1A = (byte)(iVar6 + 1);
        }

        param1.DAT_03++;
    }

    //FUN_981C (ST7)
    private void FUN_981C(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte[] puVar3;
        uint uVar4;
        int iVar5;
        uint uVar6;
        int iVar8;

        bVar1 = param1.BDAT_08;

        if (bVar1 == 1)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
            {
                if (param1.BDAT_09 == 0)
                    iVar8 = 148;
                else
                {
                    iVar8 = 149;
                    param1.DAT_17 = 0;
                    param1.BDAT_16 = 1;
                    param1.BDAT_0C = 0;
                    param1.DAT_0D = 0;
                    param1.DAT_03 = 3;
                }

                goto LAB_9CD0;
            }
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0x10) != 0)
                        param1.BDAT_16 ^= 1;

                    if (param1.BDAT_16 != 0)
                        return;

                    if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
                    {
                        uVar6 = (byte)param1.BDAT_0A;

                        if ((byte)param1.DAT_0B < (int)(uVar6 - 1) && (int)(uVar4 = (byte)param1.DAT_0B + 1U) < (int)uVar6)
                        {
                            do
                            {
                                if (((ushort)param1.SDAT_10 >> (int)(uVar4 & 31) & 1) == 0)
                                {
                                    iVar8 = 147;
                                    param1.DAT_0B = (sbyte)uVar4;
                                    param1.DAT_12 = 0;
                                    param1.DAT_13 = 0;
                                    param1.DAT_03++;
                                    goto LAB_9CD0;
                                }

                                uVar4++;
                            } while ((int)uVar4 < (int)uVar6);
                        }
                    }

                    if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0 && param1.DAT_0B != 0 && 
                        -1 < (int)(uVar6 = (uint)(param1.DAT_0B - 1)))
                    {
                        do
                        {
                            if (((ushort)param1.SDAT_10 >> (int)(uVar6 & 31) & 1) == 0)
                            {
                                iVar8 = 147;
                                param1.DAT_0B = (sbyte)uVar6;
                                param1.DAT_12 = 0;
                                param1.DAT_13 = 0;
                                param1.DAT_03++;
                                goto LAB_9CD0;
                            }

                            uVar6--;
                        } while (-1 < (int)uVar6);
                    }

                    if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0 && param1.BDAT_09 < (byte)param1.BDAT_0A)
                    {
                        if (param1.DAT_02 == 0)
                            puVar3 = DAT_12590;
                        else
                            puVar3 = DAT_12598;

                        DAT_12890[param1.BDAT_09 * 4] = puVar3[param1.DAT_0B];
                        DAT_12890[param1.BDAT_09 * 4 + 1] = (byte)param1.DAT_0B;
                        param1.DAT_15 = 0;
                        param1.DAT_14 = 0;
                        param1.BDAT_09++;
                        param1.SDAT_10 |= (short)(1 << (param1.DAT_0B & 15));
                        DAT_12890[param1.BDAT_09 * 4] = 9;

                        if ((byte)param1.BDAT_0A < param1.BDAT_09)
                            param1.BDAT_08 = 1;

                        GameManager.instance.FUN_5C94C(null, 150);
                        uVar6 = 0;

                        if (param1.BDAT_0A != 0)
                        {
                            uVar4 = (ushort)param1.SDAT_10;

                            do
                            {
                                if ((uVar4 & 1) == 0)
                                {
                                    param1.DAT_0B = (sbyte)uVar6;
                                    return;
                                }

                                uVar6++;
                                uVar4 = (uint)(ushort)param1.SDAT_10 >> (int)(uVar6 & 31);
                            } while ((int)uVar6 < (byte)param1.BDAT_0A);
                        }
                    }

                    if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
                    {
                        bVar1 = (byte)(param1.BDAT_09 - 1);

                        if (param1.BDAT_09 != 0)
                        {
                            param1.BDAT_09 = bVar1;
                            iVar8 = 148;
                            param1.SDAT_10 &= (short)~(1 << (DAT_12890[bVar1 * 4 + 1] & 15));
                            DAT_12890[param1.BDAT_09 * 4] = 9;
                            goto LAB_9CD0;
                        }

                        FUN_9B7C();
                    }
                }
            }
            else
            {
                if (bVar1 == 2)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
                        FUN_9B7C();
                }
                else
                {
                    if (bVar1 == 3 && (InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
                    {
                        param1.DAT_0B = 0;
                        param1.BDAT_08 = 0;
                        param1.BDAT_09 = 0;
                        param1.PDAT_0C = null;
                        param1.PTR_10 = null;
                        param1.PDAT_14 = null;
                        DAT_12890[0] = 9;
                        GameManager.instance.FUN_5C94C(null, 148);
                    }
                }
            }
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x5000) == 0)
            return;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) == 0)
            sVar2 = (sbyte)(param1.BDAT_08 - 1);
        else
            sVar2 = (sbyte)(param1.BDAT_08 + 1);

        param1.BDAT_08 = (byte)sVar2;
        iVar8 = 147;
        param1.BDAT_08 &= 3;
        LAB_9CD0:
        GameManager.instance.FUN_5C94C(null, iVar8);

        void FUN_9B7C()
        {
            param1.DAT_03 = 4;
            SceneManager.instance.skinnedObjects[10].flags |= 2;
            InventoryManager.FUN_4A7E8(2, 0xb, true);
            iVar5 = 1;

            do
            {
                SceneManager.instance.staticObjects[iVar5].DAT_48 = 1;
                iVar5++;
            } while (iVar5 < 8);

            SceneManager.instance.FUN_26EBC(0, 0);
            GameManager.instance.FUN_5C94C(null, 148);
        }
    }

    //FUN_9CE8 (ST7)
    private void FUN_9CE8(CriInteract param1)
    {
        sbyte sVar1;

        param1.DAT_12 += 5;
        sVar1 = (sbyte)(param1.DAT_0D + 1);
        param1.DAT_0D = (byte)sVar1;
        param1.DAT_13 += 5;

        if (sVar1 != 1)
        {
            param1.DAT_03 = 1;
            param1.DAT_0D = 0;
        }
    }

    //FUN_9D2C (ST7)
    private void FUN_9D2C(CriInteract param1)
    {
        byte bVar1;
        int iVar1;
        CriStatic oVar1;
        sbyte sVar2;
        int iVar2;
        byte bVar2;
        CriStatic oVar2;
        int iVar3;
        sbyte sVar3;
        uint uVar3;
        CriStatic oVar3;
        sbyte sVar4;
        int iVar4;
        bool bVar4;
        CriStatic oVar4;
        CriCamera cVar4;
        sbyte sVar5;
        int iVar5;
        CriStatic oVar5;
        uint uVar5;
        int iVar6;
        short sVar7;

        if (DAT_12890[param1.DAT_17 * 4] < 12)
        {
            switch (DAT_12890[param1.DAT_17 * 4])
            {
                case 0:
                    iVar6 = param1.DAT_18;
                    iVar4 = iVar6;

                    if (iVar6 < 0)
                        iVar4 = iVar6 + 3;

                    if ((sbyte)(iVar6 + (iVar4 >> 2) * -4) == 1)
                    {
                        DAT_12890[param1.DAT_17 * 4] = 2;

                        if ((param1.DAT_18 & 3) == 0)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            break;
                        }

                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (39 < bVar1)
                        {
                            if (bVar1 == 40)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (19 < param1.DAT_1B)
                            {
                                sVar5 = param1.DAT_17;
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_1B = 0;
                                sVar3 = (sbyte)(param1.DAT_18 - 1);
                                param1.DAT_18 = (byte)sVar3;
                                param1.DAT_17 = (sbyte)(sVar5 + 1);
                                goto LAB_B2F8;
                            }

                            if (param1.DAT_19 == 0) goto LAB_B2C0;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            oVar4 = SceneManager.instance.staticObjects[bVar1];
                            oVar4.vr.x += DAT_125C8[bVar2];
                            LAB_B2C0:
                            param1.DAT_1B++;
                            break;
                        }
                    }
                    else
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (79 < bVar1)
                        {
                            if (bVar1 == 80)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (19 < param1.DAT_1B)
                            {
                                sVar5 = param1.DAT_17;
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_1B = 0;
                                sVar3 = (sbyte)(param1.DAT_18 - 2);
                                param1.DAT_18 = (byte)sVar3;
                                param1.DAT_17 = (sbyte)(sVar5 + 1);
                                goto LAB_B2F8;
                            }

                            if (param1.DAT_19 == 0)
                            {
                                param1.DAT_1B++;
                                break;
                            }

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            oVar4 = SceneManager.instance.staticObjects[bVar1];
                            oVar4.vr.x += DAT_125C8[bVar2];
                            param1.DAT_1B++;
                            break;
                        }
                    }

                    param1.DAT_0D = (byte)(bVar1 + 1);
                    oVar4 = SceneManager.instance.staticObjects[0];
                    oVar4.screen.z += 100;

                    if (param1.DAT_19 != 0)
                    {
                        oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                        oVar4.screen.z += 100;
                    }

                    LAB_B2F8:
                    oVar4 = SceneManager.instance.staticObjects[0];
                    iVar4 = oVar4.screen.y;

                    if (oVar4.screen.z == 0xba4 && -0x16a8 < iVar4)
                        iVar4 = -0x16a8;

                    SceneManager.instance.FUN_264C4(50, (short)oVar4.screen.x, (short)iVar4, (short)oVar4.screen.z);
                    break;
                case 1:
                    if ((sbyte)param1.DAT_18 < 13)
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (79 < bVar1)
                        {
                            if (bVar1 == 80)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (param1.DAT_1B < 20)
                            {
                                if (param1.DAT_19 != 0)
                                {
                                    oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                    oVar4.vr.z += DAT_125C8[param1.DAT_1B];
                                }

                                param1.DAT_1B++;
                                break;
                            }

                            sVar3 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar2 = (sbyte)(param1.DAT_18 + 8);
                            param1.DAT_18 = (byte)sVar2;
                            param1.DAT_17 = (sbyte)(sVar3 + 1);
                            goto LAB_B2F8;
                        }
                    }
                    else
                    {
                        DAT_12890[param1.DAT_17 * 4] = 11;

                        if (15 < param1.DAT_18)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            break;
                        }

                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (39 < bVar1)
                        {
                            if (bVar1 == 40)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (param1.DAT_1B < 20)
                            {
                                if (param1.DAT_19 != 0)
                                {
                                    oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                    oVar4.vr.z += DAT_125C8[param1.DAT_1B];
                                }

                                param1.DAT_1B++;
                                break;
                            }

                            sVar3 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar2 = (sbyte)(param1.DAT_18 - 4);
                            param1.DAT_18 = (byte)sVar2;
                            param1.DAT_17 = (sbyte)(sVar3 + 1);
                            goto LAB_B2F8;
                        }
                    }

                    LAB_B1CC:
                    param1.DAT_0D = (byte)(bVar1 + 1);
                    oVar4 = SceneManager.instance.staticObjects[0];
                    oVar4.screen.x -= 60;

                    if (param1.DAT_19 != 0)
                    {
                        iVar4 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar4);
                        oVar4 = SceneManager.instance.staticObjects[iVar4 + param1.DAT_1A];
                        oVar4.screen.x -= 60;
                    }

                    goto LAB_B2F8;
                case 2:
                    if ((param1.DAT_18 & 3) == 0)
                    {
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_17++;
                        break;
                    }

                    if (param1.BDAT_0C == 0)
                    {
                        param1.BDAT_0C++;
                        GameManager.instance.FUN_5C94C(null, 151);
                    }

                    bVar1 = param1.DAT_0D;

                    if (39 < bVar1)
                    {
                        if (bVar1 == 40)
                        {
                            GameManager.instance.FUN_5C860(151);
                            GameManager.instance.FUN_5C94C(null, 152);
                            param1.DAT_0D++;
                        }

                        if (19 < param1.DAT_1B)
                        {
                            sVar5 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar3 = (sbyte)(param1.DAT_18 - 1);
                            param1.DAT_18 = (byte)sVar3;
                            param1.DAT_17 = (sbyte)(sVar5 + 1);
                            goto LAB_B2F8;
                        }

                        if (param1.DAT_19 == 0) goto LAB_B2C0;

                        bVar1 = param1.DAT_1A;
                        bVar2 = param1.DAT_1B;
                        oVar4 = SceneManager.instance.staticObjects[bVar1];
                        oVar4.vr.x += DAT_125C8[bVar2];
                        LAB_B2C0:
                        param1.DAT_1B++;
                        break;
                    }

                    param1.DAT_0D = (byte)(bVar1 + 1);
                    oVar4 = SceneManager.instance.staticObjects[0];
                    oVar4.screen.z += 100;

                    if (param1.DAT_19 != 0)
                    {
                        oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                        oVar4.screen.z += 100;
                    }

                    goto LAB_B2F8;
                case 3:
                    if (param1.BDAT_0C < 5)
                    {
                        switch (param1.BDAT_0C)
                        {
                            case 0:
                                if (param1.DAT_19 == 0 && DAT_12870[param1.DAT_18] != -1)
                                {
                                    if (param1.DAT_0D == 0)
                                        GameManager.instance.FUN_5C94C(null, 153);

                                    bVar1 = param1.DAT_0D;
                                    param1.DAT_0D = (byte)(bVar1 + 1);
                                    oVar1 = SceneManager.instance.staticObjects[0];

                                    if (bVar1 < 30)
                                        oVar1.screen.y += 110;
                                    else
                                    {
                                        sVar2 = DAT_12870[param1.DAT_18];
                                        param1.DAT_0D = 0;
                                        param1.BDAT_0C++;
                                        param1.DAT_1A = (byte)(sVar2 + 1);
                                        GameManager.instance.FUN_5C860(153);
                                        GameManager.instance.FUN_5C94C(null, 154);
                                    }

                                    iVar3 = oVar1.screen.y;

                                    if (oVar1.screen.z == 0xba4 && -0x16a8 < iVar3)
                                        iVar3 = -0x16a8;

                                    SceneManager.instance.FUN_264C4(50, (short)oVar1.screen.x, (short)iVar3, (short)oVar1.screen.z);
                                }
                                else
                                {
                                    param1.DAT_0C = 0;
                                    param1.DAT_0D = 0;
                                    param1.DAT_17++;
                                }

                                break;
                            case 1:
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);
                                oVar1 = SceneManager.instance.staticObjects[0];

                                if (bVar1 < 10)
                                    oVar1.screen.x -= 45;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                }

                                LAB_B2F8_2:
                                oVar1 = SceneManager.instance.staticObjects[0];
                                iVar2 = oVar1.screen.y;

                                if (oVar1.screen.z == 0xba4 && -0x16a8 < iVar2)
                                    iVar2 = -0x16a8;

                                SceneManager.instance.FUN_264C4(50, (short)oVar1.screen.x, (short)iVar2, (short)oVar1.screen.z);
                                break;
                            case 2:
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);
                                oVar1 = SceneManager.instance.staticObjects[0];

                                if (bVar1 < 7)
                                    oVar1.screen.y += 110;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                }

                                goto LAB_B2F8_2;
                            case 3:
                                oVar1 = SceneManager.instance.staticObjects[0];

                                if (param1.DAT_0D < 10)
                                {
                                    param1.DAT_0D++;
                                    oVar1.screen.x += 45;
                                }
                                else
                                {
                                    bVar1 = param1.DAT_1B;
                                    param1.DAT_1B = (byte)(bVar1 + 1);

                                    if (bVar1 < 20)
                                        break;

                                    param1.DAT_1B = 0;
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                    GameManager.instance.FUN_5C94C(null, 153);
                                }

                                goto LAB_B2F8_2;
                            case 4:
                                if (param1.DAT_0D < 37)
                                {
                                    param1.DAT_0D++;
                                    oVar1 = SceneManager.instance.staticObjects[0];
                                    oVar1.screen.y -= 110;
                                    iVar1 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar1);
                                    oVar1 = SceneManager.instance.staticObjects[iVar1 + param1.DAT_1A];
                                    oVar1.screen.y -= 110;
                                }
                                else
                                {
                                    if (param1.DAT_0F == 0)
                                    {
                                        param1.DAT_0F++;
                                        GameManager.instance.FUN_5C860(153);
                                        GameManager.instance.FUN_5C94C(null, 152);
                                    }

                                    if (param1.DAT_1B < 20)
                                    {
                                        oVar1 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                        oVar1.vr.z += DAT_125B4[param1.DAT_1B] << 0x18 >> 0x19;
                                        param1.DAT_1B++;
                                        break;
                                    }

                                    param1.DAT_1B = 0;
                                    param1.BDAT_0C = 0;
                                    param1.DAT_17++;
                                    InventoryManager.FUN_4A7E8(3, 0x2b, true);
                                    param1.DAT_19 = 1;
                                    DAT_12870[param1.DAT_18] = -1;
                                    InventoryManager.FUN_4A7E8(3, (uint)(int)(sbyte)param1.DAT_18 + 0x2c, false);
                                }

                                goto LAB_B2F8_2;
                        }
                    }

                    break;
                case 4:
                    if (param1.DAT_18 < 8)
                    {
                        DAT_12890[param1.DAT_17 * 4] = 5;

                        if (param1.DAT_18 < 4)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            break;
                        }

                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (39 < bVar1)
                        {
                            if (bVar1 == 40)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (19 < param1.DAT_1B)
                            {
                                sVar4 = param1.DAT_17;
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_1B = 0;
                                sVar3 = (sbyte)(param1.DAT_18 - 4);
                                param1.DAT_18 = (byte)sVar3;
                                param1.DAT_17 = (sbyte)(sVar4 + 1);
                                goto LAB_B2F8;
                            }

                            if (param1.DAT_19 == 0) goto LAB_B2C0;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            oVar5 = SceneManager.instance.staticObjects[bVar1];
                            oVar5.vr.z += DAT_125B4[bVar2];
                            LAB_B2C0:
                            param1.DAT_1B++;
                            break;
                        }
                    }
                    else
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (79 < bVar1)
                        {
                            if (bVar1 == 80)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (19 < param1.DAT_1B)
                            {
                                sVar4 = param1.DAT_17;
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_1B = 0;
                                sVar3 = (sbyte)(param1.DAT_18 - 8);
                                param1.DAT_18 = (byte)sVar3;
                                param1.DAT_17 = (sbyte)(sVar4 + 1);
                                goto LAB_B2F8;
                            }

                            if (param1.DAT_19 == 0) goto LAB_B2C0;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            oVar5 = SceneManager.instance.staticObjects[bVar1];
                            oVar5.vr.z += DAT_125B4[bVar2];
                            LAB_B2C0:
                            param1.DAT_1B++;
                            break;
                        }
                    }

                    param1.DAT_0D = (byte)(bVar1 + 1);
                    oVar5 = SceneManager.instance.staticObjects[0];
                    oVar5.screen.x += 60;

                    if (param1.DAT_19 != 0)
                    {
                        iVar5 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar5);
                        oVar5 = SceneManager.instance.staticObjects[iVar5 + param1.DAT_1A];
                        oVar5.screen.x += 60;
                    }

                    goto LAB_B2F8;
                case 5:
                    if (param1.DAT_18 < 4)
                    {
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_17++;
                        break;
                    }

                    if (param1.BDAT_0C == 0)
                    {
                        param1.BDAT_0C++;
                        GameManager.instance.FUN_5C94C(null, 151);
                    }

                    bVar1 = param1.DAT_0D;

                    if (39 < bVar1)
                    {
                        if (bVar1 == 40)
                        {
                            GameManager.instance.FUN_5C860(151);
                            GameManager.instance.FUN_5C94C(null, 152);
                            param1.DAT_0D++;
                        }

                        if (19 < param1.DAT_1B)
                        {
                            sVar4 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar3 = (sbyte)(param1.DAT_18 - 4);
                            param1.DAT_18 = (byte)sVar3;
                            param1.DAT_17 = (sbyte)(sVar4 + 1);
                            goto LAB_B2F8;
                        }

                        if (param1.DAT_19 == 0) goto LAB_B2C0;

                        bVar1 = param1.DAT_1A;
                        bVar2 = param1.DAT_1B;
                        oVar5 = SceneManager.instance.staticObjects[bVar1];
                        oVar5.vr.z += DAT_125B4[bVar2];
                        LAB_B2C0:
                        param1.DAT_1B++;
                        break;
                    }

                    param1.DAT_0D = (byte)(bVar1 + 1);
                    oVar5 = SceneManager.instance.staticObjects[0];
                    oVar5.screen.x += 60;

                    if (param1.DAT_19 != 0)
                    {
                        iVar5 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar5);
                        oVar5 = SceneManager.instance.staticObjects[iVar5 + param1.DAT_1A];
                        oVar5.screen.x += 60;
                    }

                    goto LAB_B2F8;
                case 6:
                    iVar5 = (sbyte)param1.DAT_18;
                    iVar3 = iVar5;

                    if (iVar5 < 0)
                        iVar3 = iVar5 + 3;

                    if ((sbyte)(iVar5 + (iVar3 >> 2) * -4) == 2)
                    {
                        if (param1.DAT_02 == 0)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            FUN_A604();
                            break;
                        }

                        DAT_12890[param1.DAT_17 * 4] = 10;

                        if (param1.DAT_02 == 0)
                        {
                            iVar5 = param1.DAT_18;
                            iVar3 = iVar5;

                            if (iVar5 < 0)
                                iVar3 = iVar5 + 3;

                            if ((sbyte)(iVar5 + (iVar3 >> 2) * -4) == 2)
                            {
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_17++;
                                break;
                            }
                        }

                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (39 < bVar1)
                        {
                            if (bVar1 == 40)
                            {
                                GameManager.instance.FUN_5C94C(null, 152);
                                GameManager.instance.FUN_5C860(151);
                                param1.DAT_0D++;
                            }

                            if (param1.DAT_1B < 20)
                            {
                                if (param1.DAT_19 != 0)
                                {
                                    oVar3 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                    oVar3.vr.x += DAT_125B4[param1.DAT_1B];
                                }

                                param1.DAT_1B++;
                                return;
                            }

                            sVar4 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar2 = (sbyte)(param1.DAT_18 + 1);
                            param1.DAT_18 = (byte)sVar2;
                            param1.DAT_17 = (sbyte)(sVar4 + 1);
                            goto LAB_B2F8;
                        }
                    }
                    else
                    {
                        FUN_A604();
                        break;
                    }

                    param1.DAT_0D = (byte)(bVar1 + 1);
                    oVar3 = SceneManager.instance.staticObjects[0];
                    oVar3.screen.z -= 100;

                    if (param1.DAT_19 != 0)
                    {
                        iVar3 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar3);
                        oVar3 = SceneManager.instance.staticObjects[iVar3 + param1.DAT_1A];
                        oVar3.screen.z -= 100;
                    }

                    goto LAB_B2F8;

                    void FUN_A604()
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (79 < bVar1)
                        {
                            if (bVar1 == 80)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (param1.DAT_1B < 20)
                            {
                                if (param1.DAT_19 != 0)
                                {
                                    oVar3 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                    oVar3.vr.x += DAT_125B4[param1.DAT_1B];
                                }

                                param1.DAT_1B++;
                                return;
                            }

                            sVar4 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar2 = (sbyte)(param1.DAT_18 + 2);
                            param1.DAT_18 = (byte)sVar2;
                            param1.DAT_17 = (sbyte)(sVar4 + 1);
                            goto LAB_B2F8_3;
                        }

                        param1.DAT_0D = (byte)(bVar1 + 1);
                        oVar3 = SceneManager.instance.staticObjects[0];
                        oVar3.screen.z -= 100;

                        if (param1.DAT_19 != 0)
                        {
                            iVar3 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar3);
                            oVar3 = SceneManager.instance.staticObjects[iVar3 + param1.DAT_1A];
                            oVar3.screen.z -= 100;
                        }

                        LAB_B2F8_3:
                        oVar3 = SceneManager.instance.staticObjects[0];
                        iVar3 = oVar3.screen.y;

                        if (oVar3.screen.z == 0xba4 && -0x16a8 < iVar3)
                            iVar3 = -0x16a8;

                        SceneManager.instance.FUN_264C4(50, (short)oVar3.screen.x, (short)iVar3, (short)oVar3.screen.z);
                        return;
                    }
                case 7:
                    if (param1.BDAT_0C < 5)
                    {
                        switch (param1.BDAT_0C)
                        {
                            case 0:
                                if (param1.DAT_19 == 0 || DAT_12870[param1.DAT_18] != -1)
                                {
                                    param1.BDAT_0C = 0;
                                    param1.DAT_0D = 0;
                                    param1.DAT_17++;
                                }
                                else
                                {
                                    if (param1.DAT_0D == 0)
                                        GameManager.instance.FUN_5C94C(null, 153);

                                    if (param1.DAT_0D < 37)
                                    {
                                        param1.DAT_0D++;
                                        oVar2 = SceneManager.instance.staticObjects[0];
                                        oVar2.screen.y += 110;
                                        iVar2 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar2);
                                        oVar2 = SceneManager.instance.staticObjects[iVar2 + param1.DAT_1A];
                                        oVar2.screen.y += 110;
                                    }
                                    else
                                    {
                                        if (param1.DAT_1B == 0)
                                        {
                                            GameManager.instance.FUN_5C860(153);
                                            GameManager.instance.FUN_5C94C(null, 155);
                                        }

                                        bVar1 = param1.DAT_1B;
                                        param1.DAT_1B = (byte)(bVar1 + 1);

                                        if (bVar1 < 20)
                                            break;

                                        GameManager.instance.FUN_5C94C(null, 154);
                                        param1.DAT_1B = 0;
                                        param1.DAT_0D = 0;
                                        param1.BDAT_0C++;
                                    }

                                    oVar2 = SceneManager.instance.staticObjects[0];
                                    iVar2 = oVar2.screen.y;

                                    if (oVar2.screen.z == 0xba4 && -0x16a8 < iVar2)
                                        iVar2 = -0x16a8;

                                    SceneManager.instance.FUN_264C4(50, (short)oVar2.screen.x, (short)iVar2, (short)oVar2.screen.z);
                                }

                                break;
                            case 1:
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);
                                oVar2 = SceneManager.instance.staticObjects[0];

                                if (bVar1 < 10)
                                    oVar2.screen.x -= 45;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                }

                                LAB_B2F8_3:
                                oVar2 = SceneManager.instance.staticObjects[0];
                                iVar2 = oVar2.screen.y;

                                if (oVar2.screen.z == 0xba4 && -0x16a8 < iVar2)
                                    iVar2 = -0x16a8;

                                SceneManager.instance.FUN_264C4(50, (short)oVar2.screen.x, (short)iVar2, (short)oVar2.screen.z);
                                break;
                            case 2:
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);
                                oVar2 = SceneManager.instance.staticObjects[0];

                                if (bVar1 < 7)
                                    oVar2.screen.y -= 110;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                }

                                goto LAB_B2F8_3;
                            case 3:
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);
                                oVar2 = SceneManager.instance.staticObjects[0];

                                if (bVar1 < 10)
                                    oVar2.screen.x += 45;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                    GameManager.instance.FUN_5C94C(null, 153);
                                }

                                goto LAB_B2F8_3;
                            case 4:
                                if (param1.DAT_0D < 30)
                                {
                                    param1.DAT_0D++;
                                    SceneManager.instance.staticObjects[0].screen.y -= 110;
                                }
                                else
                                {
                                    if (param1.DAT_0F == 0)
                                    {
                                        param1.DAT_0F++;
                                        GameManager.instance.FUN_5C860(153);
                                        GameManager.instance.FUN_5C94C(null, 152);
                                    }

                                    bVar1 = param1.DAT_1B;
                                    param1.DAT_1B = (byte)(bVar1 + 1);

                                    if (bVar1 < 20)
                                        break;

                                    param1.DAT_1B = 0;
                                    param1.BDAT_0C = 0;
                                    param1.DAT_17++;
                                    InventoryManager.FUN_4A7E8(3, 0x2b, false);
                                    param1.DAT_19 = 0;
                                    DAT_12870[param1.DAT_18] = (sbyte)(param1.DAT_1A - 1);
                                    InventoryManager.FUN_4A7E8(3, param1.DAT_18 + 0x2cU, true);
                                    param1.DAT_1A = 0xff;
                                }

                                goto LAB_B2F8_3;
                        }
                    }

                    oVar1 = SceneManager.instance.staticObjects[0];
                    iVar1 = oVar1.screen.y;

                    if (oVar1.screen.z == 0xba4 && -0x16a8 < iVar1)
                        iVar1 = -0x16a8;

                    SceneManager.instance.FUN_264C4(50, (short)oVar1.screen.x, (short)iVar1, (short)oVar1.screen.z);
                    break;
                case 8:
                    if ((param1.DAT_18 & 3) == 0)
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;
                        sVar2 = (sbyte)(bVar1 + 1);

                        if (119 < bVar1)
                        {
                            if (bVar1 == 120)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (param1.DAT_1B < 20)
                            {
                                if (param1.DAT_19 != 0)
                                {
                                    oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                    oVar4.vr.x += DAT_125B4[param1.DAT_1B];
                                }

                                param1.DAT_1B++;
                                break;
                            }

                            sVar2 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar3 = (sbyte)(param1.DAT_18 + 3);
                            param1.DAT_18 = (byte)sVar3;
                            param1.DAT_17 = (sbyte)(sVar2 + 1);
                            goto LAB_B2F8;
                        }
                    }
                    else
                    {
                        DAT_12890[param1.DAT_17 * 4] = 6;
                        iVar5 = (sbyte)param1.DAT_18;
                        iVar4 = iVar5;

                        if (iVar5 < 0)
                            iVar4 = iVar5 + 3;

                        if ((sbyte)(iVar5 + (iVar4 >> 2) * -4) == 2)
                        {
                            if (param1.DAT_02 != 0)
                            {
                                DAT_12890[param1.DAT_17 * 4] = 10;

                                if (param1.DAT_02 == 0)
                                {
                                    iVar5 = (sbyte)param1.DAT_18;
                                    iVar4 = iVar5;

                                    if (iVar5 < 0)
                                        iVar4 = iVar5 + 3;

                                    if ((sbyte)(iVar5 + (iVar4 >> 2) * -4) == 2)
                                    {
                                        param1.BDAT_0C = 0;
                                        param1.DAT_0D = 0;
                                        param1.DAT_17++;
                                        break;
                                    }
                                }
                                else
                                {
                                    iVar5 = (sbyte)param1.DAT_18;
                                    iVar4 = iVar5;

                                    if (iVar5 < 0)
                                        iVar4 = iVar5 + 3;

                                    if ((sbyte)(iVar5 + (iVar4 >> 2) * -4) == 3)
                                    {
                                        param1.BDAT_0C = 0;
                                        param1.DAT_0D = 0;
                                        param1.DAT_17++;
                                        break;
                                    }
                                }

                                if (param1.BDAT_0C == 0)
                                {
                                    param1.BDAT_0C++;
                                    GameManager.instance.FUN_5C94C(null, 151);
                                }

                                bVar1 = param1.DAT_0D;
                                sVar2 = (sbyte)(bVar1 + 1);

                                if (39 < bVar1)
                                {
                                    if (bVar1 == 40)
                                    {
                                        GameManager.instance.FUN_5C94C(null, 152);
                                        GameManager.instance.FUN_5C860(151);
                                        param1.DAT_0D++;
                                    }

                                    if (param1.DAT_1B < 20)
                                    {
                                        if (param1.DAT_19 != 0)
                                        {
                                            oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                            oVar4.vr.x += DAT_125B4[param1.DAT_1B];
                                        }

                                        param1.DAT_1B++;
                                        break;
                                    }

                                    sVar2 = param1.DAT_17;
                                    param1.BDAT_0C = 0;
                                    param1.DAT_0D = 0;
                                    param1.DAT_1B = 0;
                                    sVar3 = (sbyte)(param1.DAT_18 + 1);
                                    param1.DAT_18 = (byte)sVar3;
                                    param1.DAT_17 = (sbyte)(sVar2 + 1);
                                    goto LAB_B2F8;
                                }

                                goto LAB_B054;
                            }

                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                        }

                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;
                        sVar2 = (sbyte)(bVar1 + 1);

                        if (79 < bVar1)
                        {
                            if (bVar1 == 80)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (param1.DAT_1B < 20)
                            {
                                if (param1.DAT_19 != 0)
                                {
                                    oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                    oVar4.vr.x += DAT_125B4[param1.DAT_1B];
                                }

                                param1.DAT_1B++;
                                break;
                            }

                            sVar2 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar3 = (sbyte)(param1.DAT_18 + 1);
                            param1.DAT_18 = (byte)sVar3;
                            param1.DAT_17 = (sbyte)(sVar2 + 1);
                            goto LAB_B2F8;
                        }
                    }

                    LAB_B054:
                    param1.DAT_0D = (byte)sVar2;
                    oVar4 = SceneManager.instance.staticObjects[0];
                    oVar4.screen.z -= 100;

                    if (param1.DAT_19 != 0)
                    {
                        iVar4 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar4);
                        oVar4 = SceneManager.instance.staticObjects[iVar4 + param1.DAT_1A];
                        oVar4.screen.z -= 100;
                    }

                    goto LAB_B2F8;
                case 9:
                    if (param1.DAT_18 == 8)
                        FUN_AE5C();
                    else
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C = 0x80;
                            GameManager.instance.FUN_5C94C(null, 151);
                            oVar4 = SceneManager.instance.staticObjects[0];

                            if (oVar4.screen.x < 0)
                                bVar1 = (byte)(param1.BDAT_0C | 2);
                            else
                                bVar1 = (byte)(param1.BDAT_0C | 1);

                            param1.BDAT_0C = bVar1;

                            if (oVar4.screen.x == 0)
                                param1.BDAT_0C = 0x80;

                            if (oVar4.screen.z < 0xba4)
                                bVar1 = (byte)(param1.BDAT_0C | 4);
                            else
                                bVar1 = (byte)(param1.BDAT_0C | 8);

                            param1.BDAT_0C = bVar1;

                            if (oVar4.screen.z == 0xba4)
                                param1.BDAT_0C &= 0x83;
                        }
                        else
                        {
                            oVar4 = SceneManager.instance.staticObjects[0];

                            if ((param1.BDAT_0C & 1) != 0)
                            {
                                if (oVar4.screen.x < 1)
                                    oVar4.screen.x = 0;
                                else
                                    oVar4.screen.x -= 60;

                                if (param1.DAT_19 != 0)
                                {
                                    oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                    oVar4.screen.x -= 60;
                                }
                            }

                            oVar4 = SceneManager.instance.staticObjects[0];

                            if ((param1.BDAT_0C & 2) != 0)
                            {
                                if (oVar4.screen.x < 0)
                                    oVar4.screen.x += 60;
                                else
                                    oVar4.screen.x = 0;
                            }

                            if (param1.DAT_19 != 0)
                                SceneManager.instance.staticObjects[param1.DAT_1A].screen.x = oVar4.screen.x;

                            if ((param1.BDAT_0C & 4) != 0)
                            {
                                sVar7 = (short)(oVar4.screen.z + 100);

                                if (0xba3 < oVar4.screen.z)
                                    sVar7 = 0xba4;

                                oVar4.screen.z = sVar7;
                            }

                            if ((param1.BDAT_0C & 8) != 0)
                            {
                                sVar7 = 0xba4;

                                if (0xba4 < oVar4.screen.z)
                                    sVar7 = (short)(oVar4.screen.z - 100);

                                oVar4.screen.z = sVar7;
                            }

                            if (param1.DAT_19 != 0)
                                SceneManager.instance.staticObjects[param1.DAT_1A].screen.z = oVar4.screen.z + 20;

                            if (oVar4.screen.x == 0 && oVar4.screen.z == 0xba4)
                            {
                                if (param1.DAT_0F == 0)
                                {
                                    param1.DAT_0F++;
                                    GameManager.instance.FUN_5C860(151);
                                    GameManager.instance.FUN_5C94C(null, 152);
                                }

                                if (param1.DAT_1B < 20)
                                {
                                    if (param1.DAT_19 != 0)
                                    {
                                        if ((param1.BDAT_0C & 1) != 0)
                                        {
                                            oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                            oVar4.vr.z += DAT_125C8[param1.DAT_1B];
                                        }

                                        if ((param1.BDAT_0C & 2) != 0)
                                        {
                                            oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                            oVar4.vr.z += DAT_125B4[param1.DAT_1B];
                                        }

                                        if ((param1.BDAT_0C & 4) != 0)
                                        {
                                            oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                            oVar4.vr.x += DAT_125C8[param1.DAT_1B];
                                        }

                                        if ((param1.BDAT_0C & 8) != 0)
                                        {
                                            oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                            oVar4.vr.x += DAT_125B4[param1.DAT_1B];
                                        }
                                    }

                                    param1.DAT_1B++;
                                    break;
                                }

                                FUN_AE5C();
                            }
                        }

                        goto LAB_B2F8;
                    }

                    break;

                    void FUN_AE5C()
                    {
                        param1.DAT_0B = 0;
                        param1.BDAT_08 = 0;
                        param1.BDAT_09 = 0;
                        param1.DAT_1B = 0;
                        param1.PDAT_0C = null;
                        param1.PTR_10 = null;
                        param1.PDAT_14 = null;
                        DAT_12890[0] = 9;
                        param1.DAT_18 = 8;
                        param1.DAT_03 = 1;
                        cVar4 = SceneManager.instance.cCamera;
                        cVar4.DAT_36 = 200;
                        cVar4.DAT_3E = 0;
                        cVar4.DAT_50 = 0;
                        cVar4.DAT_52 = 0;
                        SceneManager.instance.FUN_264C4(400, 0, -38, -750);
                        cVar4.DAT_72 |= 1;
                        cVar4.DAT_73 = 1;
                        uVar5 = 0;

                        do
                        {
                            uVar3 = 0;

                            do
                            {
                                DAT_128C0[uVar3] = 0;
                                uVar3++;
                            } while (uVar3 < 20);

                            bVar4 = FUN_B348(param1.DAT_02, uVar5);

                            if (bVar4)
                                FUN_B374(param1.DAT_02, (int)uVar5, 10);

                            if (DAT_128C0[16] != 0 || DAT_128C0[17] != 0 || DAT_128C0[18] != 0 || DAT_128C0[19] != 0)
                            {
                                InventoryManager.FUN_4A7E8(2, 9, true);
                                break;
                            }

                            InventoryManager.FUN_4A7E8(2, 9, false);
                            uVar5++;
                        } while (uVar5 < 4);
                    }
                case 10:
                    if (param1.DAT_02 == 0)
                    {
                        iVar5 = (sbyte)param1.DAT_18;
                        iVar4 = iVar5;

                        if (iVar5 < 0)
                            iVar4 = iVar5 + 3;

                        if ((sbyte)(iVar5 + (iVar4 >> 2) * -4) == 2)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            break;
                        }
                    }
                    else
                    {
                        iVar5 = (sbyte)param1.DAT_18;
                        iVar4 = iVar5;

                        if (iVar5 < 0)
                            iVar4 = iVar5 + 3;

                        if ((sbyte)(iVar5 + (iVar4 >> 2) * -4) == 3)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            break;
                        }
                    }

                    if (param1.BDAT_0C == 0)
                    {
                        param1.BDAT_0C++;
                        GameManager.instance.FUN_5C94C(null, 151);
                    }

                    bVar1 = param1.DAT_0D;
                    sVar2 = (sbyte)(bVar1 + 1);

                    if (39 < bVar1)
                    {
                        if (bVar1 == 40)
                        {
                            GameManager.instance.FUN_5C94C(null, 152);
                            GameManager.instance.FUN_5C860(151);
                            param1.DAT_0D++;
                        }

                        if (param1.DAT_1B < 20)
                        {
                            if (param1.DAT_19 != 0)
                            {
                                oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                oVar4.vr.x += DAT_125B4[param1.DAT_1B];
                            }

                            param1.DAT_1B++;
                            break;
                        }

                        sVar2 = param1.DAT_17;
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_1B = 0;
                        sVar3 = (sbyte)(param1.DAT_18 + 1);
                        param1.DAT_18 = (byte)sVar3;
                        param1.DAT_17 = (sbyte)(sVar2 + 1);
                        goto LAB_B2F8;
                    }

                    goto LAB_B054;
                case 11:
                    if (15 < param1.DAT_18)
                    {
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_17++;
                        break;
                    }

                    if (param1.BDAT_0C == 0)
                    {
                        param1.BDAT_0C++;
                        GameManager.instance.FUN_5C94C(null, 151);
                    }

                    bVar1 = param1.DAT_0D;

                    if (39 < bVar1)
                    {
                        if (bVar1 == 40)
                        {
                            GameManager.instance.FUN_5C860(151);
                            GameManager.instance.FUN_5C94C(null, 152);
                            param1.DAT_0D++;
                        }

                        if (param1.DAT_1B < 20)
                        {
                            if (param1.DAT_19 != 0)
                            {
                                oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                oVar4.vr.z += DAT_125C8[param1.DAT_1B];
                            }

                            param1.DAT_1B++;
                            break;
                        }

                        sVar3 = param1.DAT_17;
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_1B = 0;
                        sVar2 = (sbyte)(param1.DAT_18 - 4);
                        param1.DAT_18 = (byte)sVar2;
                        param1.DAT_17 = (sbyte)(sVar3 + 1);
                        goto LAB_B2F8;
                    }

                    goto LAB_B1CC;
            }
            return;
        }

        oVar1 = SceneManager.instance.staticObjects[0];
        iVar1 = oVar1.screen.y;

        if (oVar1.screen.z == 0xba4 && -0x16a8 < iVar1)
            iVar1 = -0x16a8;

        SceneManager.instance.FUN_264C4(50, (short)oVar1.screen.x, (short)iVar1, (short)oVar1.screen.z);
    }

    //FUN_B348 (ST7)
    private bool FUN_B348(int param1, uint param2)
    {
        if (DAT_12870[param2] == -1)
            return false;

        return param2 < 20;
    }

    //FUN_B374 (ST7)
    private void FUN_B374(int param1, int param2, int param3)
    {
        bool bVar1;

        if (DAT_128C0[param2] <= param3)
        {
            DAT_128C0[param2] = (byte)param3;
            param3--;
            bVar1 = FUN_B348(param1, (uint)param2 - 1);

            if (bVar1)
                FUN_B374(0, param2 - 1, param3);

            bVar1 = FUN_B348(param1, (uint)param2 + 4);

            if (bVar1)
                FUN_B374(0, param2 + 4, param3);

            bVar1 = FUN_B348(param1, (uint)param2 + 1);

            if (bVar1)
                FUN_B374(0, param2 + 1, param3);

            bVar1 = FUN_B348(param1, (uint)param2 - 4);

            if (bVar1)
                FUN_B374(0, param2 - 4, param3);
        }
    }

    //FUN_BFBC (ST7)
    private void FUN_BFBC(CriInteract param1)
    {
        //...
        param1.DAT_03++;
    }

    //FUN_C044 (ST7)
    private void FUN_C044(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;

        bVar1 = param1.BDAT_08;

        if (bVar1 == 1)
        {
            bVar1 = param1.BDAT_09;
            param1.BDAT_09 = (byte)(bVar1 + 1);

            if (bVar1 < 0x10)
            {
                PTR_DAT_12974[2].DAT_00 += 5;
                PTR_DAT_12974[2].DAT_02 -= 5;
                PTR_DAT_12974[2].DAT_04 += 0x40;
                return;
            }
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 != 0)
                    return;

                if ((byte)param1.DAT_0B < 10)
                {
                    param1.DAT_0B++;
                    return;
                }

                PTR_DAT_12974[0].DAT_07--;
                PTR_DAT_12974[1].DAT_07--;
                PTR_DAT_12974[2].DAT_07--;
                PTR_DAT_12974[0].DAT_02++;
                PTR_DAT_12974[1].DAT_02++;
                PTR_DAT_12974[2].DAT_02++;
                bVar1 = param1.BDAT_09;
                param1.BDAT_09 = (byte)(bVar1 + 1);

                if (bVar1 < 0x24)
                    return;

                sVar2 = (sbyte)param1.BDAT_08;
                param1.BDAT_09 = 0;
                param1.BDAT_0A = 0;
                param1.DAT_0B = 0;
                goto LAB_C1D8;
            }

            if (bVar1 != 2)
            {
                if (bVar1 != 3)
                    return;

                bVar1 = param1.BDAT_09;
                param1.BDAT_09 = (byte)(bVar1 + 1);

                if (bVar1 < 0x10)
                {
                    PTR_DAT_12974[0].DAT_00 -= 5;
                    PTR_DAT_12974[0].DAT_02 -= 5;
                    PTR_DAT_12974[0].DAT_04 += 0x40;
                    return;
                }

                GameManager.instance.FUN_5C94C(null, 158);
                param1.PDAT_08 = null;
                param1.DAT_0F = 1;
                param1.DAT_03++;
                return;
            }

            bVar1 = param1.BDAT_09;
            param1.BDAT_09 = (byte)(bVar1 + 1);

            if (bVar1 < 0x10)
            {
                PTR_DAT_12974[1].DAT_02 -= 5;
                PTR_DAT_12974[1].DAT_04 += 0x40;
                return;
            }
        }

        GameManager.instance.FUN_5C94C(null, 158);
        sVar2 = (sbyte)param1.BDAT_08;
        param1.BDAT_09 = 0;
        LAB_C1D8:
        param1.BDAT_08 = (byte)(sVar2 + 1);
    }

    //FUN_C268 (ST7)
    private void FUN_C268(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        uint uVar4;

        if (InputManager.controllers[0].DAT_B58B8 != 0 && param1.BDAT_0E != 0)
        {
            if (PTR_DAT_12974[0].DAT_0A != 0 && PTR_DAT_12974[1].DAT_0A != 0 && PTR_DAT_12974[2].DAT_0A != 0)
            {
                param1.BDAT_0E = 1;
                return;
            }

            param1.BDAT_0E--;
            GameManager.instance.FUN_5C94C(null, 153);
            return;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) == 0 || 1 < param1.BDAT_0E)
        {
            bVar1 = param1.BDAT_0E;

            if (bVar1 == 1)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                    return;

                if (param1.DAT_10 == 0)
                    return;

                sVar2 = (sbyte)(param1.DAT_10 - 1);
                param1.DAT_10 = (byte)sVar2;
                bVar1 = param1.GET_OFFSET_08(sVar2 + 9);
                param1.BDAT_0C = bVar1;
                PTR_DAT_12974[bVar1].DAT_0A = 0;
                param1.BDAT_08 = 6;
                param1.DAT_03++;
                GameManager.instance.FUN_5C94C(null, 158);
                return;
            }

            if (1 < bVar1)
            {
                if (bVar1 != 2)
                    return;

                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                    return;

                InventoryManager.FUN_4A7E8(2, 0xb, true);
                sVar2 = 5;
                param1.DAT_03 = sVar2;
                return;
            }

            if (bVar1 != 0)
                return;

            if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) == 0 || 1 < param1.BDAT_0C)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0 || param1.BDAT_0C == 0)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                        return;

                    GameManager.instance.FUN_5C94C(null, 154);
                    param1.DAT_0F = 0;
                    sVar2 = (sbyte)(param1.DAT_03 + 1);
                    param1.DAT_03 = sVar2;
                    return;
                }

                uVar4 = (uint)(param1.BDAT_0C - 1);

                if ((int)uVar4 < 0)
                    return;

                while (PTR_DAT_12974[uVar4].DAT_0A != 0)
                {
                    uVar4--;

                    if ((int)uVar4 < 0)
                        return;
                }
            }
            else
            {
                uVar4 = (uint)(param1.BDAT_0C + 1);

                if (2 < (int)uVar4)
                    return;

                while (PTR_DAT_12974[uVar4].DAT_0A != 0)
                {
                    uVar4++;

                    if (2 < (int)uVar4)
                        return;
                }
            }

            param1.BDAT_0C = (byte)uVar4;
        }
        else
            param1.BDAT_0E++;

        GameManager.instance.FUN_5C94C(null, 153);
    }

    //FUN_C54C (ST7)
    private bool FUN_C54C(CriInteract param1)
    {
        if (param1.DAT_02 == 0)
        {
            if (PTR_DAT_12974[0].DAT_06 == 0 && PTR_DAT_12974[1].DAT_06 == 3 && PTR_DAT_12974[2].DAT_06 == 3)
            {
                if (param1.DAT_11 != 2 && param1.DAT_12 != 0 && param1.DAT_13 != 1)
                    return false;

                return true;
            }
        }
        else
        {
            if (PTR_DAT_12974[0].DAT_06 == 1 && PTR_DAT_12974[1].DAT_06 == 1 && PTR_DAT_12974[2].DAT_06 == 0 &&
                param1.DAT_11 == 1 && param1.DAT_12 == 2 && param1.DAT_13 == 0)
                return true;
        }

        return false;
    }

    //FUN_C608 (ST7)
    private void FUN_C608(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        int iVar2;
        uint uVar2;
        bool bVar3;
        int iVar3;
        uint uVar4;

        if (param1.BDAT_08 < 7)
        {
            switch (param1.BDAT_08)
            {
                case 0:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (bVar1 < 10)
                    {
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12974[iVar2].DAT_07++;
                    }
                    else
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    break;
                case 1:
                    //FUN_CEA8

                    if ((InputManager.controllers[0].DAT_B58B8 & 0x40) == 0)
                    {
                        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                        {
                            if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) == 0)
                            {
                                if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
                                {
                                    GameManager.instance.FUN_5C94C(null, 156);
                                    param1.BDAT_08++;
                                }
                            }
                            else
                            {
                                GameManager.instance.FUN_5C94C(null, 156);
                                param1.BDAT_08++;
                            }
                        }
                        else
                            param1.BDAT_08 = 5;
                    }
                    else
                    {
                        GameManager.instance.FUN_5C94C(null, 155);
                        param1.BDAT_08 = 4;
                    }

                    break;
                case 2:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (bVar1 < 0x20)
                    {
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12974[iVar2].DAT_04 += 0x20;
                    }
                    else
                    {
                        param1.BDAT_08 = 1;
                        param1.BDAT_09 = 0;
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12974[iVar2].DAT_07++;
                        PTR_DAT_12974[iVar2].DAT_07 &= 3;
                    }

                    break;
                case 3:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (bVar1 < 0x20)
                    {
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12974[iVar2].DAT_04 -= 0x20;
                    }
                    else
                    {
                        param1.BDAT_08 = 1;
                        param1.BDAT_09 = 0;
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12974[iVar2].DAT_07--;
                        PTR_DAT_12974[iVar2].DAT_07 &= 3;
                    }

                    break;
                case 4:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (bVar1 < 10)
                    {
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12974[iVar2].DAT_07--;
                    }
                    else
                    {
                        param1.DAT_03 = 2;
                        param1.PDAT_08 = null;
                        param1.DAT_0F = 1;
                    }

                    break;
                case 5:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (9 < bVar1)
                    {
                        iVar3 = 0;
                        PTR_DAT_12974[param1.BDAT_0C].DAT_0A = 1;
                        sVar2 = (sbyte)param1.DAT_10;
                        param1.DAT_10 = (byte)(sVar2 + 1);
                        param1.SET_OFFSET_08(sVar2 + 9, param1.BDAT_0C);
                        param1.PDAT_08 = null;
                        param1.DAT_0F = 1;
                        param1.DAT_03 = 2;

                        do
                        {
                            if (PTR_DAT_12974[iVar3].DAT_0A == 0)
                            {
                                param1.BDAT_0C = (byte)iVar3;
                                GameManager.instance.FUN_5C94C(null, 157);
                                break;
                            }

                            iVar3++;
                        } while (iVar3 < 3);

                        bVar3 = FUN_C54C(param1);

                        if (bVar3)
                        {
                            GameManager.instance.FUN_5C94C(null, 159);
                            param1.DAT_03 = 4;
                            param1.BDAT_0E = 1;
                            param1.DAT_0F = 0;
                            break;
                        }

                        GameManager.instance.FUN_5C94C(null, 157);
                        param1.BDAT_0E = 1;
                        break;
                    }

                    uVar4 = param1.BDAT_0C;

                    if (uVar4 != 1)
                    {
                        if (uVar4 < 2)
                        {
                            if (uVar4 != 0) goto LAB_C94C;

                            PTR_DAT_12974[0].DAT_00 += 8;
                        }
                        else
                        {
                            if (uVar4 == 2)
                                PTR_DAT_12974[2].DAT_00 -= 8;
                        }
                    }

                    uVar4 = param1.BDAT_0C;
                    LAB_C94C:
                    PTR_DAT_12974[uVar4].DAT_02 += 8;
                    iVar3 = param1.BDAT_0C;
                    PTR_DAT_12974[iVar3].DAT_07--;
                    break;
                case 6:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (9 < bVar1)
                    {
                        param1.DAT_0F = 1;
                        param1.PDAT_08 = null;
                        param1.DAT_03 = 2;
                        break;
                    }

                    uVar2 = param1.BDAT_0C;

                    if (uVar2 != 1)
                    {
                        if (uVar2 < 2)
                        {
                            if (uVar2 != 0) goto LAB_CAE8;

                            PTR_DAT_12974[0].DAT_00 -= 8;
                        }
                        else
                        {
                            if (uVar2 == 2)
                                PTR_DAT_12974[2].DAT_00 += 8;
                        }
                    }

                    uVar2 = param1.BDAT_0C;
                    LAB_CAE8:
                    PTR_DAT_12974[uVar2].DAT_02 -= 8;
                    PTR_DAT_12974[uVar2].DAT_07 = 33;
                    break;
            }
        }
    }

    //FUN_CB64 (ST7)
    private void FUN_CB64(CriInteract param1)
    {
        byte bVar1;

        if (param1.BDAT_08 < 7)
        {
            switch (param1.BDAT_08)
            {
                case 0:
                    param1.DAT_15 += 3;
                    DAT_128D4[3] = 0;
                    DAT_128D4[2] = 0;
                    DAT_128D4[1] = 0;
                    DAT_128D4[0] = 0;
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (40 < bVar1)
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    goto LAB_CD64;
                case 1:
                    DAT_128D4[0] = 60;
                    DAT_128D4[1] = 100;
                    DAT_128D4[2] = 200;
                    DAT_128D4[3] = 1;
                    param1.BDAT_08++;
                    goto LAB_CD64;
                case 2:
                    DAT_128D4[1] -= 8;
                    DAT_128D4[3] += 0x10;
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (3 < bVar1)
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    goto LAB_CD64;
                case 3:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (10 < bVar1)
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    //...
                    return;
                case 4:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (30 < bVar1)
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    //...
                    return;
                case 5:
                    DAT_128D4[1] += 8;
                    DAT_128D4[3] -= 0x10;
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (3 < bVar1)
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    goto LAB_CD64;
                case 6:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (20 < bVar1)
                    {
                        param1.DAT_03 = 5;
                        InventoryManager.FUN_4A7E8(2, 9, true);
                    }

                    //FUN_CDB0
                    return;
            }
        }

        LAB_CD64:;
        //...
    }

    //FUN_E4D8 (ST7)
    private void FUN_E4D8(CriInteract param1)
    {
        param1.DAT_04 = 0;
        param1.BDAT_08 |= 1;
        param1.DAT_03++;
        param1.DAT_15 = (sbyte)DAT_12690[param1.DAT_02 * 3];
        param1.BDAT_16 = DAT_12690[param1.DAT_02 * 3 + 1];
    }

    //FUN_E538 (ST7)
    private void FUN_E538(CriInteract param1)
    {
        if (param1.BDAT_09 == 0 && param1.DAT_0B == param1.BDAT_16)
        {
            InventoryManager.FUN_4A7E8(4, DAT_12690[param1.DAT_02 + 2], true);
            param1.DAT_03++;
        }
    }

    //FUN_E5F0 (ST7)
    private void FUN_E5F0(CriInteract param1)
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        Vector4Int[] aVar2;

        param1.DAT_03++;
        iVar1 = param1.DAT_04;
        aVar2 = PTR_DAT_126D8[iVar1];
        param1.VDAT_14 = aVar2;

        if (param1.DAT_02 == 0)
        {
            param1.VDAT_14 = PTR_DAT_126D8[iVar1 + param1.DAT_05];
            iVar1 = (int)GameManager.FUN_64650();
            param1.DAT_18 = (byte)(iVar1 + (iVar1 / 46) * -46 + 45);
        }
        else
        {
            iVar2 = (int)GameManager.FUN_64650();
            uVar3 = DAT_126DC[iVar1];

            if (uVar3 == 0)
                return; //0x1c00

            if (uVar3 == 0xffffffff && iVar2 == -0x80000000)
                return; //0x1800

            param1.DAT_18 = 0;
            param1.VDAT_14 = PTR_DAT_126D8[iVar1 + (iVar2 % (int)uVar3)];
        }
    }

    //FUN_E700 (ST7)
    private void FUN_E700(CriInteract param1)
    {
        CriPlayer oVar1;

        if (param1.DAT_18 == 0)
        {
            oVar1 = LevelManager.instance.FUN_60108();

            if (oVar1 != null)
            {
                oVar1.tags = 5;
                oVar1.DAT_2F = param1.DAT_04;
                oVar1.DAT_163 = DAT_126F0[param1.DAT_05];
                oVar1.screen.x = param1.VDAT_14[0].x;
                oVar1.screen.y = param1.VDAT_14[0].y;
                oVar1.screen.z = param1.VDAT_14[0].z;
                oVar1.vr.y = param1.VDAT_14[0].w;
                oVar1.cSkin = param1.TDAT_0C;
                oVar1.FUN_604A4(oVar1.cSkin);
                oVar1.DAT_98 = param1.TDAT_10;
                oVar1.DAT_18E = 100;
                oVar1.DAT_1DD = param1.DAT_19;
                PTR_FUN_B58C0[oVar1.tags](oVar1);
                param1.FUN_5FF98();
            }
        }
        else
            param1.DAT_18--;
    }

    //FUN_E944 (ST7)
    private void FUN_E944(CriInteract param1)
    {
        CriStatic puVar2;
        int iVar3;
        int iVar4;
        CriStatic puVar5;
        CriStatic puVar6;
        CriStatic puVar7;
        CriStatic puVar8;
        CriStatic puVar9;

        param1.PDAT_08 = null;
        param1.PDAT_0C = null;
        param1.PTR_10 = null;
        param1.PDAT_14 = null;
        iVar3 = 0;

        do
        {
            DAT_12998[iVar3] = -1;
            DAT_129A8[iVar3] = -1;
            DAT_129B8[iVar3] = DAT_1273C[iVar3 + param1.DAT_02 * 10];

            if (DAT_1273C[iVar3 + param1.DAT_02 * 10] != -1)
                param1.BDAT_0E++;

            iVar4 = iVar3 + 1;
            iVar3 = iVar4;
        } while (iVar4 < 10);

        iVar4 = 0;
        param1.DAT_0D = 0x80;

        do
        {
            puVar2 = SceneManager.instance.staticObjects[iVar4];
            iVar4++;
            puVar2.screen.z = 0;
            puVar2.vr.y = 0;
            puVar2.flags |= 2;
        } while (iVar4 < 6);

        puVar2 = SceneManager.instance.staticObjects[0];
        puVar5 = SceneManager.instance.staticObjects[1];
        puVar6 = SceneManager.instance.staticObjects[2];
        puVar7 = SceneManager.instance.staticObjects[3];
        puVar8 = SceneManager.instance.staticObjects[4];
        puVar9 = SceneManager.instance.staticObjects[5];
        puVar2.screen.y = -340;
        puVar5.screen.y = -340;
        puVar2.screen.x = 640;
        puVar5.screen.x = 0;
        puVar6.screen.x = -640;
        puVar7.screen.x = 640;
        puVar7.screen.y = 410;
        puVar8.screen.x = 0;
        puVar8.screen.y = 410;
        puVar9.screen.x = -640;
        puVar9.screen.y = 410;
        param1.DAT_03 = 1;
    }

    //FUN_EA94 (ST7)
    private void FUN_EA94(CriInteract param1)
    {
        int iVar1;
        byte bVar1;
        sbyte sVar2;
        int iVar2;
        uint uVar2;
        int iVar3;
        uint uVar3;
        int iVar4;
        byte bVar5;
        byte bVar6;
        uint uVar7;

        //FUN_FC78
        bVar1 = (byte)param1.BDAT_0A;
        param1.BDAT_0A = (sbyte)(bVar1 + 1);

        if (30 < bVar1)
        {
            param1.BDAT_0A = 35;

            if (param1.BDAT_08 < 9)
            {
                switch (param1.BDAT_08)
                {
                    case 0:
                        if (param1.DAT_0F == param1.DAT_0E)
                        {
                            param1.BDAT_08 = 0;
                            param1.BDAT_09 = 0;
                            param1.BDAT_0A = 0;
                            param1.DAT_0B = 0;
                            param1.DAT_03++;
                            return;
                        }

                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                        bVar6 = (byte)DAT_129B8[param1.DAT_0F];

                        if (bVar6 == 1)
                        {
                            iVar1 = Utilities.Rand();
                            uVar7 = (uint)(iVar1 % 6);
                            iVar1 = Utilities.Rand();
                            bVar5 = (byte)(1 << (int)(uVar7 & 31));
                            param1.DAT_10 = bVar5;
                            param1.DAT_11 = bVar5;
                            param1.BDAT_0C = (byte)uVar7;
                            DAT_12998[param1.DAT_0F] = (sbyte)(iVar1 % 6);
                            SceneManager.instance.staticObjects[uVar7].cMesh = (TmdScriptableObject)Utilities.GetRamObject(DAT_127A8[iVar1 & 6]);

                            do
                            {
                                iVar1 = Utilities.Rand();
                                uVar7 = (uint)(iVar1 % 6);
                            } while (uVar7 == param1.BDAT_0C);

                            bVar6 = (byte)(param1.DAT_10 | (1 << (int)(uVar7 & 31)));
                            param1.DAT_10 = bVar6;
                            param1.DAT_11 = bVar6;
                            SceneManager.instance.staticObjects[uVar7].cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x801095e8);
                        }
                        else
                        {
                            if (bVar6 < 2)
                            {
                                if (bVar6 == 0)
                                {
                                    iVar1 = Utilities.Rand();
                                    uVar7 = (uint)(iVar1 % 6);
                                    iVar1 = Utilities.Rand();
                                    bVar5 = (byte)(1 << (int)(uVar7 & 31));
                                    param1.DAT_10 = bVar5;
                                    param1.DAT_11 = bVar5;
                                    param1.BDAT_0C = (byte)uVar7;
                                    DAT_12998[param1.DAT_0F] = (sbyte)(iVar1 % 6);
                                    SceneManager.instance.staticObjects[uVar7].cMesh = (TmdScriptableObject)Utilities.GetRamObject(DAT_127A8[iVar1 % 6]);
                                }
                            }
                            else
                            {
                                if (bVar6 == 2)
                                {
                                    iVar2 = Utilities.Rand();
                                    iVar3 = Utilities.Rand();
                                    uVar7 = 0;

                                    do
                                    {
                                        iVar4 = (int)(uVar7 + (iVar2 % 6) * 6);
                                        SceneManager.instance.staticObjects[uVar7++].cMesh = (TmdScriptableObject)Utilities.GetRamObject(DAT_127A8[DAT_127C4[iVar4]]);
                                    } while (uVar7 < 6);

                                    DAT_12998[param1.DAT_0F] = (sbyte)DAT_127C4[iVar3 % 6 + (iVar2 % 6) * 6];
                                    param1.DAT_11 = (byte)(63 - (1 << (iVar3 % 6 & 31)));
                                    bVar5 = 4;
                                    param1.DAT_10 = 63;
                                }
                                else
                                {
                                    if (bVar6 != 3) goto LAB_EF30;

                                    iVar1 = Utilities.Rand();
                                    uVar7 = (uint)(iVar1 % 6);
                                    iVar1 = Utilities.Rand();
                                    bVar5 = (byte)(1 << (int)(uVar7 & 31));
                                    param1.DAT_10 = bVar5;
                                    param1.DAT_11 = bVar5;
                                    param1.BDAT_0C = (byte)uVar7;
                                    DAT_12998[param1.DAT_0F] = (sbyte)(iVar1 % 6);
                                    SceneManager.instance.staticObjects[uVar7].cMesh = (TmdScriptableObject)Utilities.GetRamObject(DAT_127A8[iVar1 % 6]);

                                    do
                                    {
                                        iVar1 = Utilities.Rand();
                                        bVar5 = 7;
                                    } while (iVar1 % 6 == param1.BDAT_0C);

                                    param1.DAT_12 = (sbyte)(iVar1 % 6);
                                }

                                param1.BDAT_08 = bVar5;
                            }
                        }
    
                        LAB_EF30:
                        param1.DAT_0F++;
                        return;
                    case 1:
                        bVar1 = param1.BDAT_09;
                        param1.BDAT_09 = (byte)(bVar1 + 1);

                        if (bVar1 < 0x10)
                        {
                            uVar2 = 0;

                            do
                            {
                                if ((param1.DAT_10 >> (int)(uVar2 & 31) & 1) != 0)
                                    SceneManager.instance.staticObjects[uVar2].vr.y += param1.DAT_0D;

                                uVar2++;
                            } while (uVar2 < 6);
                        }
                        else
                        {
                            param1.BDAT_09 = 0;
                            param1.BDAT_08++;
                            GameManager.instance.FUN_5C94C(null, 147);
                        }

                        return;
                    case 2:
                        bVar1 = param1.BDAT_09;
                        param1.BDAT_09 = (byte)(bVar1 + 1);

                        if (5 < bVar1)
                        {
                            param1.BDAT_09 = 0;
                            param1.BDAT_08++;
                        }

                        return;
                    case 3:
                        bVar1 = param1.BDAT_09;
                        sVar2 = (sbyte)(bVar1 + 1);
                        param1.BDAT_09 = (byte)sVar2;

                        if (bVar1 < 0x10)
                        {
                            uVar3 = 0;

                            do
                            {
                                if ((param1.DAT_11 >> (int)(uVar3 & 31) & 1) != 0)
                                    SceneManager.instance.staticObjects[uVar3].vr.y -= param1.DAT_0D;

                                uVar3++;
                            } while (uVar3 < 6);
                        }
                        else
                        {
                            if (sVar2 == 17)
                                GameManager.instance.FUN_5C94C(null, 147);

                            bVar1 = (byte)param1.DAT_0B;
                            param1.BDAT_09 = 35;
                            param1.DAT_0B = (sbyte)(bVar1 + 1);

                            if (29 < bVar1)
                            {
                                param1.BDAT_08 = 0;
                                param1.BDAT_09 = 0;
                                param1.BDAT_0A = 35;
                                param1.DAT_0B = 0;
                            }
                        }

                        return;
                    case 4:
                        goto case 1;
                    case 5:
                        goto case 2;
                    case 6:
                        goto case 3;
                    case 7:
                        bVar1 = param1.BDAT_09;
                        param1.BDAT_09 = (byte)(bVar1 + 1);

                        if (bVar1 < 7)
                            SceneManager.instance.staticObjects[param1.DAT_12].vr.y += param1.DAT_0D;
                        else
                        {
                            param1.BDAT_09 = 0;
                            param1.BDAT_08++;
                            GameManager.instance.FUN_5C94C(null, 147);
                        }

                        return;
                    case 8:
                        bVar1 = param1.BDAT_09;
                        param1.BDAT_09 = (byte)(bVar1 + 1);

                        if (bVar1 < 7)
                            SceneManager.instance.staticObjects[param1.DAT_0D].vr.y -= param1.DAT_0D;
                        else
                        {
                            param1.BDAT_08 = 1;
                            param1.BDAT_09 = 0;
                            GameManager.instance.FUN_5C94C(null, 147);
                        }

                        return;
                }
            }
        }
    }

    //FUN_F464 (ST7)
    private void FUN_F2A8(CriInteract param1)
    {
        byte bVar1;
        CriStatic oVar2;

        bVar1 = param1.BDAT_08;

        if (bVar1 == 1)
        {
            bVar1 = param1.BDAT_09;
            param1.BDAT_09 = (byte)(bVar1 + 1);

            if (29 < bVar1)
            {
                GameManager.instance.FUN_46C0C(0, 20, 1);
                oVar2 = SceneManager.instance.staticObjects[0];
                oVar2.screen.x = 430;
                oVar2.screen.y = -40;
                oVar2.screen.z = -1240;
                oVar2.vr.y = 0x800;
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010999c);
                oVar2 = SceneManager.instance.staticObjects[1];
                oVar2.screen.x = -360;
                oVar2.screen.y = -40;
                oVar2.screen.z = -1240;
                oVar2.vr.y = 0x800;
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80109d50);
                oVar2 = SceneManager.instance.staticObjects[2];
                oVar2.screen.x = -1160;
                oVar2.screen.y = -40;
                oVar2.screen.z = -1240;
                oVar2.vr.y = 0x800;
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010a104);
                oVar2 = SceneManager.instance.staticObjects[3];
                oVar2.screen.x = 430;
                oVar2.screen.y = 728;
                oVar2.screen.z = -1240;
                oVar2.vr.y = 0x800;
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010a4b8);
                oVar2 = SceneManager.instance.staticObjects[4];
                oVar2.screen.x = -360;
                oVar2.screen.y = 728;
                oVar2.screen.z = -1240;
                oVar2.vr.y = 0x800;
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010a86c);
                oVar2 = SceneManager.instance.staticObjects[5];
                oVar2.screen.x = -1160;
                oVar2.screen.y = 728;
                oVar2.screen.z = -1240;
                oVar2.vr.y = 0x800;
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010ac20);
                param1.BDAT_08 = 2;
                param1.BDAT_09 = 0;
            }
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    GameManager.instance.FUN_46C0C(1, 20, 1);
                    param1.BDAT_08++;
                }
            }
            else
            {
                if (bVar1 == 2)
                {
                    //FUN_FD84
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (29 < bVar1)
                    {
                        param1.BDAT_08 = 0;
                        param1.BDAT_09 = 0;
                        param1.DAT_03++;
                    }
                }
            }
        }
    }

    //FUN_F464 (ST7)
    private void FUN_F464(CriInteract param1)
    {
        byte bVar2;
        sbyte sVar3;
        byte bVar4;

        //FUN_FD84
        bVar2 = param1.BDAT_08;

        if (bVar2 == 1)
        {
            bVar2 = param1.BDAT_09;
            param1.BDAT_09 = (byte)(bVar2 + 1);

            if (bVar2 < 0x10)
            {
                SceneManager.instance.staticObjects[param1.DAT_13].vr.y += 0x100;
                return;
            }

            param1.BDAT_08 = 0;
            param1.BDAT_09 = 0;
        }
        else
        {
            if (bVar2 < 2)
            {
                if (bVar2 != 0)
                    return;

                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && param1.DAT_13 < 5)
                {
                    if (param1.DAT_13 == 2)
                        return;

                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.DAT_13++;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
                {
                    if (param1.DAT_13 != 0 && param1.DAT_13 != 3)
                    {
                        GameManager.instance.FUN_5C94C(null, 144);
                        param1.DAT_13--;
                        return;
                    }

                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.BDAT_16 = 1;
                    param1.DAT_15 = 0;
                    param1.BDAT_08 = 2;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0 && param1.DAT_13 < 3)
                {
                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.DAT_13 += 3;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0 && 2 < param1.DAT_13)
                {
                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.DAT_13 -= 3;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0 && (byte)param1.DAT_14 < 10)
                {
                    GameManager.instance.FUN_5C94C(null, 146);
                    DAT_129A8[param1.DAT_14] = param1.DAT_13;
                    param1.DAT_14++;
                    param1.BDAT_08++;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x40) == 0)
                    return;

                if (param1.DAT_14 == 0)
                    return;

                GameManager.instance.FUN_5C94C(null, 145);
                sVar3 = param1.DAT_14;
            }
            else
            {
                if (bVar2 != 2)
                    return;

                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.BDAT_16 = 0;
                    param1.BDAT_08 = 0;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x5000) != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.DAT_15 ^= 1;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                    return;

                if (param1.DAT_15 == 0)
                {
                    GameManager.instance.FUN_5C94C(null, 146);
                    bVar4 = (byte)FUN_FC2C();
                    param1.DAT_03 = (sbyte)bVar4;
                    SceneManager.instance.staticObjects[0].flags &= 0xfffffffd;
                    SceneManager.instance.staticObjects[1].flags &= 0xfffffffd;
                    SceneManager.instance.staticObjects[2].flags &= 0xfffffffd;
                    SceneManager.instance.staticObjects[3].flags &= 0xfffffffd;
                    SceneManager.instance.staticObjects[4].flags &= 0xfffffffd;
                    SceneManager.instance.staticObjects[5].flags &= 0xfffffffd;
                    param1.BDAT_08 = 0;
                    param1.BDAT_09 = 0;
                    return;
                }

                GameManager.instance.FUN_5C94C(null, 145);
                sVar3 = param1.DAT_14;

                if (sVar3 == 0)
                    return;
            }

            param1.DAT_14 = (sbyte)(sVar3 - 1);
            DAT_129A8[param1.DAT_14] = -1;
        }
    }

    //FUN_F804 (ST7)
    private void FUN_F804(CriInteract param1)
    {
        //...
    }

    //FUN_FA18 (ST7)
    private void FUN_FA18(CriInteract param1)
    {
        //...
    }

    //FUN_FC2C (ST7)
    private int FUN_FC2C()
    {
        int iVar2;
        int iVar3;

        iVar2 = 0;

        do
        {
            iVar3 = iVar2 + 1;

            if (DAT_12998[iVar2] != DAT_129A8[iVar2])
                return 4;

            iVar2 = iVar3;
        } while (iVar3 < 10);

        return 5;
    }

    //FUN_27C (ST7)
    public static void FUN_27C(CriParticle param1)
    {
        instance.PTR_FUN_119D4[param1.DAT_3C](param1);
        //FUN_600
    }

    //FUN_BC8 (ST7)
    public static void FUN_BC8(CriParticle param1)
    {
        instance.PTR_FUN_119E4[param1.DAT_3C](param1);
    }

    //FUN_13BC (ST7)
    public static void FUN_13BC(CriParticle param1)
    {
        instance.PTR_FUN_11A20[param1.DAT_3C](param1);
    }

    //FUN_1C58 (ST7)
    public static void FUN_1C58(CriParticle param1)
    {
        instance.PTR_FUN_11A30[param1.DAT_3C](param1);
    }

    //FUN_1D60 (ST7)
    public static void FUN_1D60(CriParticle param1)
    {
        instance.PTR_FUN_11A54[param1.DAT_3C](param1);
    }

    //FUN_21E0 (ST7)
    public static void FUN_21E0(CriParticle param1)
    {
        instance.PTR_FUN_11AC8[param1.DAT_3C](param1);
    }

    //FUN_1F14 (ST7)
    public static void FUN_1F14(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_11A60[param1.DAT_3C](param1);
    }

    //FUN_2048 (ST7)
    public static void FUN_2048(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_11A98[param1.DAT_3C](param1);
    }

    //FUN_2650 (ST7)
    public static void FUN_2650(CriInteract param1)
    {
        instance.PTR_FUN_11AFC[param1.DAT_03](param1);
    }

    //FUN_2AC8 (ST7)
    public static void FUN_2AC8(CriInteract param1)
    {
        instance.PTR_FUN_11B78[param1.DAT_03](param1);
    }

    //FUN_3300 (ST7)
    public static void FUN_3300(CriInteract param1)
    {
        instance.PTR_FUN_11BAC[param1.DAT_03](param1);
    }

    //FUN_39E8 (ST7)
    public static void FUN_39E8(CriInteract param1)
    {
        instance.PTR_FUN_11BC0[param1.DAT_03](param1);
    }

    //FUN_3A24 (ST7)
    public static void FUN_3A24(CriInteract param1)
    {
        instance.PTR_FUN_11BD4[param1.DAT_03](param1);
    }

    //FUN_3D54 (ST7)
    public static void FUN_3D54(CriInteract param1)
    {
        instance.PTR_FUN_120F4[param1.DAT_03](param1);
    }

    //FUN_623C (ST7)
    public static void FUN_623C(CriPlayer param1)
    {
        CriSkinned oVar1;
        sbyte sVar2;
        uint uVar3;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);
        oVar1 = SceneManager.instance.skinnedObjects[10];

        if ((InventoryManager.DAT_B7A60[0] & 2) == 0)
        {
            if (param1.DAT_3C == 0 || (param1.DAT_18E & 0x80) == 0)
            {
                param1.DAT_34 = param1.screen;

                if ((param1.DAT_1C0 & 2) == 0)
                {
                    param1.DAT_158.x = oVar1.screen.x;
                    param1.DAT_158.z = oVar1.screen.z;
                }

                sVar2 = GameManager.instance.FUN_774CC(param1, param1.DAT_158);
                param1.DAT_1DB = sVar2;

                if ((param1.DAT_11E & 0x80) != 0)
                    instance.FUN_6184(param1);

                instance.PTR_FUN_124B8[param1.DAT_3C](param1);

                if ((param1.flags & 1) == 0)
                    return;

                param1.FUN_62F3C(ref param1.DAT_40);

                if ((param1.DAT_1C0 & 0x60) != 0)
                    instance.FUN_6424(param1);

                param1.FUN_6449C(0);
                SceneManager.instance.FUN_80030(param1, true, 1);
                SceneManager.instance.FUN_80A14(param1);

                if (param1.DAT_2F == 1 && param1.DAT_1DD < param1.PDAT_1C8.DAT_0B && param1.PDAT_1C8.BDAT_09 < 3)
                    param1.DAT_1C0 |= 1;
            }

            if (param1.DAT_3C == 4)
                uVar3 = param1.flags & 0xfffffffb;
            else
                uVar3 = param1.flags | 4;

            param1.flags = uVar3;
        }
    }

    //FUN_672C (ST7)
    public static void FUN_672C(CriInteract param1)
    {
        instance.PTR_FUN_124D4[param1.DAT_03](param1);
        //...
    }

    //FUN_94FC (ST7)
    public static void FUN_94FC(CriInteract param1)
    {
        instance.PTR_FUN_125A0[param1.DAT_03](param1);
        //...
    }

    //FUN_BED4 (ST7)
    public static void FUN_BED4(CriInteract param1)
    {
        instance.PTR_FUN_125FC[param1.DAT_03](param1);
        //...
    }

    //FUN_E5B4 (ST7)
    public static void FUN_E5B4(CriInteract param1)
    {
        instance.PTR_FUN_1269C[param1.DAT_03](param1);
    }

    //FUN_E830 (ST7)
    public static void FUN_E830(CriInteract param1)
    {
        instance.PTR_FUN_126F4[param1.DAT_03](param1);
    }

    //FUN_E86C (ST7)
    public static void FUN_E86C(CriInteract param1)
    {
        byte bVar1;

        //FUN_10488

        if (param1.DAT_19 == 0)
        {
            bVar1 = (byte)(param1.DAT_18 + 6);
            param1.DAT_18 = bVar1;

            if (bVar1 < 129) goto LAB_E8F4;

            bVar1 = param1.DAT_19;
            param1.DAT_18 = 0x80;
        }
        else
        {
            bVar1 = (byte)(param1.DAT_18 - 6);
            param1.DAT_18 = bVar1;

            if (31 < bVar1) goto LAB_E8F4;

            bVar1 = param1.DAT_19;
            param1.DAT_18 = 0x20;
        }

        param1.DAT_19 = (byte)(bVar1 ^ 1);
        LAB_E8F4:
        //FUN_1071C
        instance.PTR_FUN_1278C[param1.DAT_03](param1);
    }

    //FUN_10844 (ST7)
    public static void FUN_10844(CriInteract param1)
    {
        //...
    }
}
