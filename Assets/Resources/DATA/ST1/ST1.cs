using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//0x800E8000
public class ST1 : LevelManager
{
    public static new ST1 instance;
    public uint[] DAT_04 = new uint[4] { 0x80132b5c, 0x80132bfc, 0x80132ca4, 0x80132d6c };
    public FUN_B58BC[] DAT_7624 = new FUN_B58BC[] { FUN_44EA8, FUN_45224, FUN_45350 };
    public FUN_B58C0[] DAT_7680 = new FUN_B58C0[3] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0 }; //0x7680 (ST1)
    public FUN_C2570[] DAT_76A8 = new FUN_C2570[5] { FUN_4A26C, FUN_7F6F8, FUN_7F750, FUN_6C74, FUN_7F7E4 }; //0x76A8 (ST1)
    public FUN_C1CF8[] DAT_76C8 = new FUN_C1CF8[15] { FUN_20A98, FUN_20AA0, FUN_20AA8, FUN_20B0C, FUN_21758,
                                                      FUN_21ECC, FUN_22178, FUN_2DD8, FUN_51A8, FUN_66C4, 
                                                      FUN_222AC, FUN_22464, FUN_2268C, FUN_71F4, FUN_6B74 };
    public byte[][] DAT_7594 = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 11, 27, 15, 13, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 0, 0, 0, 35, 6, 0, 0, 22, 26, 21, 21, 23, 31, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 }
    }; //0x7594 (ST1)
    public TrgScriptableObject DAT_74A4; //0x74A4 (ST1)
    public uint[] DAT_7230 = new uint[157] { 0x0, 0x20, 0x2d, 0x39, 0x3f, 0x80000042, 0x0, 0x16, 0x1c, 0x21, 0x33, 0x80000050, 0x0, 0x15, 0x22, 0x38, 0x8000004a, 0x0, 0x8, 0x1e, 0x30, 0x8000004b, 0x0, 0x16, 0x28, 0x3c, 0x8000005a, 0x0, 0xc, 0x16, 0x24, 0x34, 0x3c, 0x40, 0x80000052, 0x0, 0x5, 0x14, 0x34, 0x39, 0x8000004a, 0x0, 0x17, 0x1f, 0x39, 0x80000057, 0x0, 0x1b, 0x2e, 0x3c, 0x8000004b, 0x0, 0x10, 0x28, 0x3f, 0x80000064, 0x0, 0x14, 0x21, 0x3c, 0x8000005b, 0x0, 0xd, 0x16, 0x23, 0x28, 0x80000042, 0x0, 0x1a, 0x22, 0x38, 0x80000057, 0x0, 0xf, 0x1c, 0x2b, 0x38, 0x80000045, 0x0, 0x5, 0x1d, 0x31, 0x80000042, 0x0, 0x6, 0x18, 0x22, 0x3d, 0x80000048, 0x0, 0x1d, 0x21, 0x32, 0x80000046, 0x0, 0x3, 0x9, 0x14, 0x22, 0x2a, 0x37, 0x3d, 0x80000053, 0x0, 0x13, 0x1e, 0x2e, 0x32, 0x80000047, 0x0, 0x18, 0x28, 0x3b, 0x8000004a, 0x0, 0x10, 0x1b, 0x27, 0x31, 0x80000043, 0x0, 0xa, 0x15, 0x2b, 0x80000042, 0x0, 0x22, 0x33, 0x41, 0x8000005c, 0x0, 0x12, 0x18, 0x28, 0x34, 0x3f, 0x8000004b, 0x0, 0x6, 0xb, 0x16, 0x1e, 0x3b, 0x8000004d, 0x0, 0x14, 0x26, 0x3b, 0x80000051, 0x0, 0x1e, 0x2b, 0x40, 0x8000004d, 0x0, 0xc, 0x80000018 };
    public byte[] DAT_7AA0 = new byte[108] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1d, 0x0, 0x5f, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x16, 0xf0, 0x59, 0x1b, 0x0, 0x0, 0x0, 0xe8, 0x3, 0x0, 0x0, 0x1, 0x1b, 0xf7, 0x33, 0xf, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3d, 0xff, 0x2, 0x9, 0x0, 0x7, 0xf9, 0x0, 0x0, 0x0, 0x78, 0x0, 0xfa, 0x0, 0x2, 0x7, 0xff, 0x5, 0x4, 0x0, 0x0, 0x0, 0x27, 0x1, 0xc3, 0x0, 0x3, 0x13, 0x0, 0x3f, 0xe, 0x0, 0x0, 0x0, 0xda, 0x2, 0xed, 0xfe, 0x3, 0x1b, 0x0, 0x30, 0xf4, 0x0, 0x0, 0x0, 0x36, 0x6, 0x42, 0xff, 0x4, 0x1d, 0xf8, 0x29, 0xea, 0x0, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x1b, 0x0, 0x5c, 0xe9, 0x0 };
    public sbyte[] DAT_7B44 = new sbyte[4];
    public byte DAT_7B49;
    public byte DAT_7B4A;
    public byte DAT_7B4B;
    public byte DAT_7B4C;
    public byte DAT_7B4D;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //FUN_F4 (ST1)
    public override void Initialize()
    {
        bool bVar2;
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        DAT_74A4 = Resources.Load<TrgScriptableObject>("DATA/ST1/ST1_01");
        //...
        PTR_FUN_B58BC = DAT_7624;
        PTR_FUN_B58C0 = DAT_7680;
        PTR_FUN_C2570 = DAT_76A8;
        PTR_FUN_C1CF8 = DAT_76C8;
        //...
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        SceneManager.instance.DAT_AC = DAT_7594[uVar3];
        GameManager.instance.DAT_46 = true;
        SceneManager.instance.DAT_B0 = DAT_7230;

        for (int i = 0; i < DAT_74A4.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
            puVar5 = DAT_74A4.TRIGGERS[i];
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

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 1);
        bVar2 = InventoryManager.FUN_4A87C(0, 0x22);

        if (!bVar2)
        {
            bVar2 = InventoryManager.FUN_4A87C(0, 0x23);

            if (!bVar2)
                SceneManager.instance.DAT_9EEC[2].DAT_03 |= 2;
        }

        bVar2 = InventoryManager.FUN_4A87C(0, 0x1e);

        if (!bVar2)
            SceneManager.instance.DAT_9EEC[1].DAT_03 |= 2;
    }

    //FUN_6A9C (ST1)
    public void FUN_6A9C()
    {
        CriPlayer oVar1;
        CriPlayer puVar2;
        uint uVar4;

        uVar4 = 0;

        do
        {
            puVar2 = (CriPlayer)SceneManager.instance.DAT_27C[uVar4];

            if ((puVar2.flags & 1) != 0 && puVar2.DAT_3C != 3 && puVar2.DAT_3C != 5)
            {
                oVar1 = (CriPlayer)SceneManager.instance.FUN_65B30(puVar2);

                if (oVar1 == null)
                    puVar2.DAT_1C5 = 1;
                else
                {
                    if (oVar1.DAT_1C5 != 1)
                        puVar2.DAT_1C5 = 1;
                }

                puVar2.DAT_208 &= 0xfff3ffff;
            }

            uVar4++;
        } while (uVar4 < 10);
    }

    //FUN_2DD8 (ST1)
    public static void FUN_2DD8(CriInteract param1)
    {
        param1.FUN_2DD8();
    }

    //FUN_51A8 (ST1)
    public static void FUN_51A8(CriInteract param1)
    {
        param1.FUN_51A8();
    }

    //FUN_66C4 (ST1)
    public static void FUN_66C4(CriInteract param1)
    {
        param1.FUN_66C4();
    }

    //FUN_6B74 (ST1)
    public static void FUN_6B74(CriInteract param1)
    {
        param1.FUN_6B74();
    }

    //FUN_71F4 (ST1)
    public static void FUN_71F4(CriInteract param1)
    {
        param1.FUN_71F4();
    }

    //FUN_6C74 (ST1)
    public static void FUN_6C74(CriStatic param1)
    {
        param1.FUN_6C74();
    }
}
