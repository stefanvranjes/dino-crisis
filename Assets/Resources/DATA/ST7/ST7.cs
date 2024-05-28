using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST7 : LevelManager
{
    public static new ST7 instance;

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

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
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
        SceneManager.instance.DAT_AC = DAT_11874;
        SceneManager.instance.DAT_B0 = DAT_11528;
        GameManager.instance.DAT_46 = 7;

        for (int i = 0; i < DAT_11784.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
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

    //FUN_27C (ST7)
    public static void FUN_27C(CriParticle param1)
    {

    }

    //FUN_BC8 (ST7)
    public static void FUN_BC8(CriParticle param1)
    {

    }

    //FUN_13BC (ST7)
    public static void FUN_13BC(CriParticle param1)
    {

    }

    //FUN_1C58 (ST7)
    public static void FUN_1C58(CriParticle param1)
    {

    }

    //FUN_1D60 (ST7)
    public static void FUN_1D60(CriParticle param1)
    {

    }

    //FUN_21E0 (ST7)
    public static void FUN_21E0(CriParticle param1)
    {

    }

    //FUN_1F14 (ST7)
    public static void FUN_1F14(CriParticle param1)
    {

    }

    //FUN_2048 (ST7)
    public static void FUN_2048(CriParticle param1)
    {

    }

    //FUN_2650 (ST7)
    public static void FUN_2650(CriInteract param1)
    {

    }

    //FUN_2AC8 (ST7)
    public static void FUN_2AC8(CriInteract param1)
    {

    }

    //FUN_3300 (ST7)
    public static void FUN_3300(CriInteract param1)
    {

    }

    //FUN_39E8 (ST7)
    public static void FUN_39E8(CriInteract param1)
    {

    }

    //FUN_3A24 (ST7)
    public static void FUN_3A24(CriInteract param1)
    {

    }

    //FUN_3D54 (ST7)
    public static void FUN_3D54(CriInteract param1)
    {

    }

    //FUN_623C (ST7)
    public static void FUN_623C(CriPlayer param1)
    {

    }

    //FUN_672C (ST7)
    public static void FUN_672C(CriInteract param1)
    {

    }

    //FUN_94FC (ST7)
    public static void FUN_94FC(CriInteract param1)
    {

    }

    //FUN_BED4 (ST7)
    public static void FUN_BED4(CriInteract param1)
    {

    }

    //FUN_E5B4 (ST7)
    public static void FUN_E5B4(CriInteract param1)
    {

    }

    //FUN_E830 (ST7)
    public static void FUN_E830(CriInteract param1)
    {

    }

    //FUN_E86C (ST7)
    public static void FUN_E86C(CriInteract param1)
    {

    }

    //FUN_10844 (ST7)
    public static void FUN_10844(CriInteract param1)
    {

    }
}
