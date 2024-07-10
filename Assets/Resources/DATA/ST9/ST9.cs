using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST9 : LevelManager
{
    public static new ST9 instance;

    public uint[] DAT_159A0 = new uint[] { 0, 0xd, 0x1b, 0x23, 0x2b, 0x39, 0x43, 0x80000057, 0x0, 0x6, 0x11, 0x16, 0x20, 0x23, 0x33, 0x42, 0x80000057, 0x0, 0x12, 0x21, 0x2e, 0x3e, 0x44, 0x80000053, 0x0, 0x1e, 0x2d, 0x42, 0x4b, 0x80000075, 0x0, 0x15, 0x28, 0x3c, 0x4a, 0x80000055, 0x0, 0x8, 0x18, 0x2a, 0x37, 0x80000052, 0x0, 0x5, 0x10, 0x1f, 0x32, 0x39, 0x47, 0x8000005b, 0x0, 0xd, 0xf, 0x1f, 0x26, 0x29, 0x2d, 0x33, 0x47, 0x8000005c, 0x0, 0x3, 0xb, 0xe, 0x1e, 0x21, 0x29, 0x3a, 0x80000065, 0x0, 0xc, 0x13, 0x29, 0x2e, 0x3c, 0x40, 0x44, 0x4c, 0x8000005a, 0x0, 0xf, 0x1e, 0x26, 0x2c, 0x3e, 0x4a, 0x80000059, 0x0, 0xe, 0x1a, 0x1d, 0x22, 0x2c, 0x31, 0x3f, 0x43, 0x48, 0x4c, 0x80000059, 0x0, 0x14, 0x20, 0x28, 0x3c, 0x50, 0x80000066, 0x0, 0x17, 0x1f, 0x24, 0x26, 0x33, 0x36, 0x45, 0x4b, 0x80000056, 0x0, 0xf, 0x14, 0x1d, 0x29, 0x2e, 0x33, 0x38, 0x44, 0x4f, 0x80000052, 0x0, 0xb, 0x14, 0x22, 0x2a, 0x37, 0x3d, 0x4f, 0x80000059, 0x0, 0x10, 0x15, 0x25, 0x37, 0x3d, 0x45, 0x4c, 0x80000056, 0x0, 0x4, 0x7, 0xd, 0x11, 0x1c, 0x2f, 0x38, 0x44, 0x80000051, 0x0, 0xe, 0x1f, 0x33, 0x42, 0x4c, 0x80000059, 0x0, 0x5, 0x13, 0x1c, 0x28, 0x33, 0x47, 0x50, 0x8000005d, 0x0, 0x5, 0xf, 0x17, 0x21, 0x2d, 0x36, 0x46, 0x80000051, 0x0, 0x6, 0xe, 0x1d, 0x22, 0x2d, 0x3d, 0x43, 0x80000055, 0x0, 0x5, 0xd, 0x15, 0x24, 0x2b, 0x35, 0x45, 0x80000052, 0x0, 0x7, 0x27, 0x3a, 0x80000056, 0x0, 0x13, 0x31, 0x42, 0x8000005e, 0x0, 0x11, 0x2b, 0x3c, 0x4f, 0x80000060, 0x0, 0xe, 0x20, 0x3d, 0x4e, 0x80000063, 0x0, 0x11, 0x21, 0x29, 0x35, 0x3e, 0x80000054, 0x0, 0x8, 0x27, 0x37, 0x80000046 };
    public TrgScriptableObject DAT_15D40; //0x15D40 (ST9)
    public byte[] DAT_15E30 = new byte[] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 };
    public FUN_B58BC[] DAT_15E60 = new FUN_B58BC[] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08, 
                                                     null, FUN_46A1C, null, null, null, FUN_45D38, FUN_45E70, null, null, 
                                                     FUN_CC84, FUN_D478, FUN_DD14, FUN_DE1C, FUN_C864, FUN_CA8C, FUN_DFD0, 
                                                     FUN_E1D8, FUN_E338, FUN_E4C4, FUN_E664, FUN_E80C, FUN_EA84 };
    public FUN_B58C0[] DAT_15ED0 = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, FUN_1AF8, null, null, null, null, FUN_3ABC };
    public FUN_C2570[] DAT_15EF4 = new FUN_C2570[] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null, FUN_15590,
                                                     FUN_7F808, null, null, null, FUN_15508 };
    public FUN_C1CF8[] DAT_15F24 = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, FUN_21ECC, 
                                                     FUN_22178, null, null, null, FUN_222AC, FUN_22464, FUN_2268C, 
                                                     null, null, null, FUN_EAC0, FUN_11F34, FUN_11F70, FUN_142A8, 
                                                     FUN_F0D0, FUN_143D0, FUN_12C54, FUN_14B2C, FUN_14DD0, 
                                                     FUN_152D8, FUN_15314 };

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

    //FUN_134 (ST9)
    public override void Initialize()
    {
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_15E60;
        PTR_FUN_B58C0 = DAT_15ED0;
        PTR_FUN_C2570 = DAT_15EF4;
        PTR_FUN_C1CF8 = DAT_15F24;
        SceneManager.instance.DAT_AC = DAT_15E30;
        SceneManager.instance.DAT_B0 = DAT_159A0;
        GameManager.instance.DAT_46 = 9;

        for (int i = 0; i < DAT_15D40.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
            puVar5 = DAT_15D40.TRIGGERS[i];
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

    //FUN_1AF8 (ST9)
    public static void FUN_1AF8(CriPlayer param1)
    {

    }

    //FUN_3ABC (ST9)
    public static void FUN_3ABC(CriPlayer param1)
    {

    }

    //FUN_CC84 (ST9)
    public static void FUN_CC84(CriParticle param1)
    {

    }

    //FUN_D478 (ST9)
    public static void FUN_D478(CriParticle param1)
    {

    }

    //FUN_DD14 (ST9)
    public static void FUN_DD14(CriParticle param1)
    {

    }

    //FUN_DE1C (ST9)
    public static void FUN_DE1C(CriParticle param1)
    {

    }

    //FUN_C864 (ST9)
    public static void FUN_C864(CriParticle param1)
    {

    }

    //FUN_CA8C (ST9)
    public static void FUN_CA8C(CriParticle param1)
    {

    }

    //FUN_DFD0 (ST9)
    public static void FUN_DFD0(CriParticle param1)
    {

    }

    //FUN_E1D8 (ST9)
    public static void FUN_E1D8(CriParticle param1)
    {

    }

    //FUN_E338 (ST9)
    public static void FUN_E338(CriParticle param1)
    {

    }

    //FUN_E4C4 (ST9)
    public static void FUN_E4C4(CriParticle param1)
    {

    }

    //FUN_E664 (ST9)
    public static void FUN_E664(CriParticle param1)
    {

    }

    //FUN_E80C (ST9)
    public static void FUN_E80C(CriParticle param1)
    {

    }

    //FUN_EA84 (ST9)
    public static void FUN_EA84(CriParticle param1)
    {

    }

    //FUN_EAC0 (ST9)
    public static void FUN_EAC0(CriInteract param1)
    {

    }

    //FUN_F0D0 (ST9)
    public static void FUN_F0D0(CriInteract param1)
    {

    }

    //FUN_11F34 (ST9)
    public static void FUN_11F34(CriInteract param1)
    {

    }

    //FUN_11F70 (ST9)
    public static void FUN_11F70(CriInteract param1)
    {

    }

    //FUN_12C54 (ST9)
    public static void FUN_12C54(CriInteract param1)
    {

    }

    //FUN_142A8 (ST9)
    public static void FUN_142A8(CriInteract param1)
    {

    }

    //FUN_143D0 (ST9)
    public static void FUN_143D0(CriInteract param1)
    {

    }

    //FUN_14B2C (ST9)
    public static void FUN_14B2C(CriInteract param1)
    {

    }

    //FUN_14DD0 (ST9)
    public static void FUN_14DD0(CriInteract param1)
    {

    }

    //FUN_152D8 (ST9)
    public static void FUN_152D8(CriInteract param1)
    {

    }

    //FUN_15314 (ST9)
    public static void FUN_15314(CriInteract param1)
    {

    }

    //FUN_15508 (ST9)
    public static void FUN_15508(CriStatic param1)
    {

    }

    //FUN_15590 (ST9)
    public static void FUN_15590(CriStatic param1)
    {

    }
}
