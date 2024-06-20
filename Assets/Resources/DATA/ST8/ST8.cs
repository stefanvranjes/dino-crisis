using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST8 : LevelManager
{
    public static new ST8 instance;

    public uint[] DAT_119A4 = new uint[205] { 0, 0x6, 0x11, 0x16, 0x20, 0x23, 0x33, 0x42, 0x80000057, 0x0, 0x12, 0x21, 0x2e, 0x3e, 0x44, 0x80000053, 0x0, 0x1e, 0x2d, 0x42, 0x4b, 0x80000075, 0x0, 0x15, 0x28, 0x3c, 0x4a, 0x80000055, 0x0, 0x8, 0x18, 0x2a, 0x37, 0x80000052, 0x0, 0x5, 0x10, 0x1f, 0x32, 0x39, 0x47, 0x8000005b, 0x0, 0xd, 0xf, 0x1f, 0x26, 0x29, 0x2d, 0x33, 0x47, 0x8000005c, 0x0, 0x3, 0xb, 0xe, 0x11, 0x1a, 0x25, 0x29, 0x34, 0x49, 0x8000005c, 0x0, 0xf, 0x25, 0x30, 0x80000052, 0x0, 0x14, 0x1f, 0x28, 0x36, 0x47, 0x80000056, 0x0, 0x11, 0x1c, 0x2e, 0x41, 0x80000057, 0x0, 0xc, 0x1c, 0x2e, 0x41, 0x80000054, 0x0, 0x12, 0x29, 0x3a, 0x80000053, 0x0, 0xa, 0x10, 0x23, 0x2a, 0x3d, 0x80000055, 0x0, 0x10, 0x19, 0x20, 0x31, 0x3d, 0x80000057, 0x0, 0x23, 0x2c, 0x3f, 0x4f, 0x8000006e, 0x0, 0x4, 0x1b, 0x26, 0x49, 0x8000005a, 0x0, 0x14, 0x32, 0x4c, 0x80000060, 0x0, 0x8, 0x14, 0x23, 0x26, 0x2f, 0x3b, 0x46, 0x80000063, 0x0, 0x24, 0x31, 0x8000005a, 0x0, 0x11, 0x17, 0x22, 0x38, 0x3c, 0x41, 0x80000053, 0x0, 0x8, 0x1b, 0x1f, 0x36, 0x3e, 0x4e, 0x8000005f, 0x0, 0x3, 0x13, 0x23, 0x2a, 0x39, 0x44, 0x80000053, 0x0, 0xc, 0x1f, 0x29, 0x3a, 0x46, 0x80000055, 0x0, 0x7, 0x15, 0x20, 0x28, 0x39, 0x40, 0x46, 0x80000057, 0x0, 0x8, 0xb, 0xf, 0x12, 0x1f, 0x32, 0x36, 0x44, 0x48, 0x80000051, 0x0, 0xa, 0xf, 0x1a, 0x2b, 0x36, 0x3f, 0x80000056, 0x0, 0xa, 0x18, 0x29, 0x30, 0x3b, 0x8000005f, 0x0, 0xe, 0x80000023 };
    public TrgScriptableObject DAT_11CD8; //0x11CD8 (ST8)
    public byte[] DAT_11DC8 = new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 };
    public FUN_B58BC[] DAT_11DF8 = new FUN_B58BC[] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, 
                                                     FUN_45B08, null, FUN_46A1C, null, null, null, FUN_45D38, 
                                                     FUN_45E70, null, null, null, FUN_1E4, FUN_410, FUN_D150, 
                                                     FUN_684, FUN_824, FUN_908 };
    public FUN_B58C0[] DAT_11E50 = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, null, null, null, null, 
                                                     null, null };
    public FUN_C2570[] DAT_11E74 = new FUN_C2570[] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null, 
                                                     FUN_A7BC, FUN_7F808 };
    public FUN_C1CF8[] DAT_11E94 = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, 
                                                     FUN_21ECC, FUN_22178, null, FUN_1760, null, FUN_222AC, 
                                                     FUN_22464, FUN_2268C, null, null, null, FUN_2C7C, 
                                                     FUN_1724, FUN_3410, FUN_2F84, null, FUN_87E4, FUN_61E0, 
                                                     FUN_ABCC, FUN_E3F0, FUN_F738, FUN_118B8 };

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

    //FUN_10C (ST8)
    public override void Initialize()
    {
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_11DF8;
        PTR_FUN_B58C0 = DAT_11E50;
        PTR_FUN_C2570 = DAT_11E74;
        PTR_FUN_C1CF8 = DAT_11E94;
        SceneManager.instance.DAT_AC = DAT_11DC8;
        SceneManager.instance.DAT_B0 = DAT_119A4;
        GameManager.instance.DAT_46 = 8;

        for (int i = 0; i < DAT_11CD8.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
            puVar5 = DAT_11CD8.TRIGGERS[i];
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

    //FUN_1E4 (ST8)
    public static void FUN_1E4(CriParticle param1)
    {

    }

    //FUN_410 (ST8)
    public static void FUN_410(CriParticle param1)
    {

    }

    //FUN_684 (ST8)
    public static void FUN_684(CriParticle param1)
    {

    }

    //FUN_824 (ST8)
    public static void FUN_824(CriParticle param1)
    {

    }

    //FUN_908 (ST8)
    public static void FUN_908(CriParticle param1)
    {

    }

    //FUN_A68 (ST8)
    public static void FUN_A68(CriInteract param1)
    {

    }

    //FUN_1724 (ST8)
    public static void FUN_1724(CriInteract param1)
    {

    }

    //FUN_1760 (ST8)
    public static void FUN_1760(CriInteract param1)
    {

    }

    //FUN_2C7C (ST8)
    public static void FUN_2C7C(CriInteract param1)
    {

    }

    //FUN_2F84 (ST8)
    public static void FUN_2F84(CriInteract param1)
    {

    }

    //FUN_3410 (ST8)
    public static void FUN_3410(CriInteract param1)
    {

    }

    //FUN_61E0 (ST8)
    public static void FUN_61E0(CriInteract param1)
    {

    }

    //FUN_87E4 (ST8)
    public static void FUN_87E4(CriInteract param1)
    {

    }

    //FUN_A7BC (ST8)
    public static void FUN_A7BC(CriStatic param1)
    {

    }

    //FUN_ABCC (ST8)
    public static void FUN_ABCC(CriInteract param1)
    {

    }

    //FUN_D150 (ST8)
    public static void FUN_D150(CriParticle param1)
    {

    }

    //FUN_E3F0 (ST8)
    public static void FUN_E3F0(CriInteract param1)
    {

    }

    //FUN_F738 (ST8)
    public static void FUN_F738(CriInteract param1)
    {

    }

    //FUN_10118 (ST8)
    public static void FUN_10118(CriInteract param1)
    {

    }

    //FUN_118B8 (ST8)
    public static void FUN_118B8(CriInteract param1)
    {

    }
}
