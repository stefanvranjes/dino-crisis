using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct UNK_78C8
{
    public uint DAT_00; //0x00
    public byte DAT_04; //0x04
}

struct UNK_7908
{
    public uint DAT_00; //0x00
    public Vector3Int DAT_04; //0x00
    public Vector3Int DAT_0A; //0x0A
}

//0x800E8000
public class ST1 : LevelManager
{
    public static new ST1 instance;
    public FUN_B58BC[] DAT_7624 = new FUN_B58BC[23] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, 
                                                      FUN_45B08, FUN_270, FUN_46A1C, FUN_35C, FUN_468, null,
                                                      FUN_45D38, FUN_45E70, FUN_464F8, FUN_7CC, FUN_1324,
                                                      FUN_1B18, FUN_27EC, FUN_28F4, FUN_23B4, FUN_1118,
                                                      FUN_2AA8, FUN_2C40 };
    public FUN_B58C0[] DAT_7680 = new FUN_B58C0[3] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0 }; //0x7680 (ST1)
    public FUN_C2570[] DAT_76A8 = new FUN_C2570[8] { FUN_4A26C, FUN_7F6F8, FUN_7F750, FUN_6C74, FUN_7F7E4,
                                                     null, null, FUN_7F808 }; //0x76A8 (ST1)
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
    private delegate void FUN_54(CriInteract i); //0x54 (ST1)
    private delegate void FUN_7984(CriInteract i); //0x7984 (ST1)
    private delegate void FUN_7A8C(CriInteract i); //0x7A8C (ST1)
    private delegate void FUN_7B14(CriInteract i); //0x7B14 (ST1)
    private delegate void FUN_7B28(CriInteract i); //0x7B28 (ST1)
    private delegate void FUN_7704(CriParticle p); //0x7704 (ST1)
    private delegate void FUN_7710(CriParticle p); //0x7710 (ST1)
    private delegate void FUN_780C(CriParticle p); //0x780C (ST1)
    private delegate void FUN_7840(CriParticle p); //0x7840 (ST1)
    private delegate void FUN_7858(CriParticle p); //0x7858 (ST1)
    private delegate void FUN_7864(CriParticle p); //0x7864 (ST1)
    private delegate void FUN_78A0(CriParticle p); //0x78A0 (ST1)
    private delegate void FUN_78B0(CriParticle p); //0x78B0 (ST1)
    private delegate void FUN_78BC(CriParticle p); //0x78BC (ST1)
    private delegate void FUN_78E0(CriParticle p); //0x78E0 (ST1)
    private delegate void FUN_78FC(CriParticle p); //0x78FC (ST1)
    private delegate void FUN_7978(CriParticle p); //0x7978 (ST1)
    private delegate void FUN_7B20(CriStatic s); //FUN_7B20 (ST1)
    private FUN_54[] PTR_FUN_54; //0x54 (ST1)
    public uint[] DAT_7230 = new uint[157] { 0x0, 0x20, 0x2d, 0x39, 0x3f, 0x80000042, 0x0, 0x16, 0x1c, 0x21, 0x33, 0x80000050, 0x0, 0x15, 0x22, 0x38, 0x8000004a, 0x0, 0x8, 0x1e, 0x30, 0x8000004b, 0x0, 0x16, 0x28, 0x3c, 0x8000005a, 0x0, 0xc, 0x16, 0x24, 0x34, 0x3c, 0x40, 0x80000052, 0x0, 0x5, 0x14, 0x34, 0x39, 0x8000004a, 0x0, 0x17, 0x1f, 0x39, 0x80000057, 0x0, 0x1b, 0x2e, 0x3c, 0x8000004b, 0x0, 0x10, 0x28, 0x3f, 0x80000064, 0x0, 0x14, 0x21, 0x3c, 0x8000005b, 0x0, 0xd, 0x16, 0x23, 0x28, 0x80000042, 0x0, 0x1a, 0x22, 0x38, 0x80000057, 0x0, 0xf, 0x1c, 0x2b, 0x38, 0x80000045, 0x0, 0x5, 0x1d, 0x31, 0x80000042, 0x0, 0x6, 0x18, 0x22, 0x3d, 0x80000048, 0x0, 0x1d, 0x21, 0x32, 0x80000046, 0x0, 0x3, 0x9, 0x14, 0x22, 0x2a, 0x37, 0x3d, 0x80000053, 0x0, 0x13, 0x1e, 0x2e, 0x32, 0x80000047, 0x0, 0x18, 0x28, 0x3b, 0x8000004a, 0x0, 0x10, 0x1b, 0x27, 0x31, 0x80000043, 0x0, 0xa, 0x15, 0x2b, 0x80000042, 0x0, 0x22, 0x33, 0x41, 0x8000005c, 0x0, 0x12, 0x18, 0x28, 0x34, 0x3f, 0x8000004b, 0x0, 0x6, 0xb, 0x16, 0x1e, 0x3b, 0x8000004d, 0x0, 0x14, 0x26, 0x3b, 0x80000051, 0x0, 0x1e, 0x2b, 0x40, 0x8000004d, 0x0, 0xc, 0x80000018 };
    private FUN_7704[] PTR_FUN_7704; //0x7704 (ST1)
    private FUN_7710[] PTR_FUN_7710; //0x7710 (ST1)
    private UNK_771C[] PTR_DAT_771C; //0x771C (ST1)
    private FUN_7984[] PTR_FUN_7984; //0x7984 (ST1)
    private FUN_7A8C[] PTR_FUN_7A8C; //0x7A8C (ST1)
    private byte[] DAT_7AA0 = new byte[108] { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1d, 0x0, 0x5f, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x16, 0xf0, 0x59, 0x1b, 0x0, 0x0, 0x0, 0xe8, 0x3, 0x0, 0x0, 0x1, 0x1b, 0xf7, 0x33, 0xf, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3d, 0xff, 0x2, 0x9, 0x0, 0x7, 0xf9, 0x0, 0x0, 0x0, 0x78, 0x0, 0xfa, 0x0, 0x2, 0x7, 0xff, 0x5, 0x4, 0x0, 0x0, 0x0, 0x27, 0x1, 0xc3, 0x0, 0x3, 0x13, 0x0, 0x3f, 0xe, 0x0, 0x0, 0x0, 0xda, 0x2, 0xed, 0xfe, 0x3, 0x1b, 0x0, 0x30, 0xf4, 0x0, 0x0, 0x0, 0x36, 0x6, 0x42, 0xff, 0x4, 0x1d, 0xf8, 0x29, 0xea, 0x0, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x1b, 0x0, 0x5c, 0xe9, 0x0 };
    private FUN_7B14[] PTR_FUN_7B14; //0x7B14 (ST1)
    private FUN_7B28[] PTR_FUN_7B28; //0x7B28 (ST1)
    private sbyte[] DAT_7B44 = new sbyte[5];
    private byte DAT_7B49;
    private byte DAT_7B4A;
    private byte DAT_7B4B;
    private byte DAT_7B4C;
    private byte DAT_7B4D;
    private uint[] DAT_77F8 = new uint[4] { 0x8011d314, 0x8011d324, 0x8011d33c, 0x8011d344 }; //0x77F8 (ST1)
    private byte[] DAT_7808 = new byte[4] { 3, 1, 0, 0 }; //0x7808 (ST1)
    private FUN_780C[] PTR_FUN_780C; //0x780C (ST1)
    private byte[] DAT_7828 = new byte[] { 1, 5, 3, 7, 9, 2, 6, 10, 8, 3, 5, 9, 1, 4, 7, 8, 1, 3, 1, 5, 2, 3, 9, 2 }; //0x7828 (ST1)
    private FUN_7840[] PTR_FUN_7840; //0x7840 (ST1)
    private uint[] DAT_7850 = new uint[] { 0x80112508 }; //0x7850 (ST1)
    private ushort[] DAT_7854 = new ushort[] { 0x7ef9 }; //0x7854 (ST1)
    private FUN_7858[] PTR_FUN_7858; //0x7858 (ST1)
    private FUN_7864[] PTR_FUN_7864; //0x7864 (ST1)
    private short[] DAT_7874 = new short[] { -2320, -1230, -3900, -2610, -1230, -3900, -2900, -1230, -3900, -3190, -1230, -3900, -3480, -1230, -3900, -4390, -1075, 2600, -2290, -2580, -2870, -3160 };
    private FUN_78A0[] PTR_FUN_78A0; //0x78A0 (ST1)
    private FUN_78B0[] PTR_FUN_78B0; //0x78B0 (ST1)
    private FUN_78BC[] PTR_FUN_78BC; //0x78BC (ST1)
    private UNK_78C8[] DAT_78C8 = new UNK_78C8[] //0x78C8 (ST1)
    {
        new UNK_78C8
        {
            DAT_00=0x80115438, 
            DAT_04=1
        }, 
        new UNK_78C8
        {
            DAT_00=0,
            DAT_04=1
        }, 
        new UNK_78C8
        {
            DAT_00=0x80115440, 
            DAT_04=1
        }
    }; 
    private FUN_78E0[] PTR_FUN_78E0; //0x78E0 (ST1)
    private uint[] DAT_78EC = new uint[] { 0x8010f8cc, 0x8010f8f4, 0x8010f914 };
    private ushort[] DAT_78F8 = new ushort[] { 0x101, 3 };
    private FUN_78FC[] PTR_FUN_78FC; //0x78FC (ST1)
    private UNK_7908[] PTR_DAT_7908 = new UNK_7908[]
    {
        new UNK_7908
        {
            DAT_00=0x8010D084,
            DAT_04=new Vector3Int(-160, -180, 130),
            DAT_0A=new Vector3Int(-5, 10, -5)
        },
        new UNK_7908
        {
            DAT_00=0x8010D0CC,
            DAT_04=new Vector3Int(120, -170, 180),
            DAT_0A=new Vector3Int(-5, 10, -5)
        },
        new UNK_7908
        {
            DAT_00=0x8010D0E4,
            DAT_04=new Vector3Int(-170, -130, 110),
            DAT_0A=new Vector3Int(-5, 10, -5)
        },
        new UNK_7908
        {
            DAT_00=0x8010D0FC,
            DAT_04=new Vector3Int(130, -170, -190),
            DAT_0A=new Vector3Int(-5, 10, -5)
        },
        new UNK_7908
        {
            DAT_00=0x8010D114,
            DAT_04=new Vector3Int(-160, -150, -120),
            DAT_0A=new Vector3Int(-5, 10, -5)
        },
        new UNK_7908
        {
            DAT_00=0x8010D14C,
            DAT_04=new Vector3Int(110, -180, -160),
            DAT_0A=new Vector3Int(-5, 10, -5)
        },
        new UNK_7908
        {
            DAT_00=0x8010D184,
            DAT_04=new Vector3Int(-180, -130, -130),
            DAT_0A=new Vector3Int(-5, 10, -5)
        }
    };
    private FUN_7978[] PTR_FUN_7978; //0x7978 (ST1)
    private FUN_7B20[] PTR_FUN_7B20; //0x7B20 (ST1)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_54 = new FUN_54[6]
            {
                FUN_3018,
                FUN_30A8,
                FUN_3138,
                FUN_31C8,
                FUN_2F84,
                FUN_3270
            };
            
            PTR_FUN_7704 = new FUN_7704[3]
            {
                FUN_2BC,
                FUN_31C,
                FUN_60068
            };
            PTR_FUN_7710 = new FUN_7710[3]
            {
                FUN_398,
                FUN_448,
                FUN_60068
            };
            PTR_DAT_771C = new UNK_771C[]
            {

            };
            PTR_FUN_780C = new FUN_780C[4]
            {
                FUN_4B4,
                FUN_5F8,
                FUN_71C,
                FUN_60068
            };
            PTR_FUN_7840 = new FUN_7840[4]
            {
                FUN_818,
                FUN_88C,
                FUN_AA0,
                FUN_60068
            };
            PTR_FUN_7858 = new FUN_7858[3]
            {
                FUN_1178,
                FUN_1220,
                FUN_60068
            };
            PTR_FUN_7864 = new FUN_7864[4]
            {
                FUN_1360,
                FUN_1738,
                FUN_1948,
                FUN_60068
            };
            PTR_FUN_78A0 = new FUN_78A0[4]
            {
                FUN_1B54,
                FUN_1E2C,
                FUN_1FCC,
                FUN_60068
            };
            PTR_FUN_78B0 = new FUN_78B0[3]
            {
                FUN_23F0,
                FUN_24A8,
                FUN_60068
            };
            PTR_FUN_78BC = new FUN_78BC[3]
            {
                FUN_2828,
                FUN_28B4,
                FUN_60068
            };
            PTR_FUN_78E0 = new FUN_78E0[3]
            {
                FUN_2930,
                FUN_29B8,
                FUN_60068
            };
            PTR_FUN_78FC = new FUN_78FC[3]
            {
                FUN_2B08,
                FUN_2BA8,
                FUN_60068
            };
            PTR_FUN_7978 = new FUN_7978[3]
            {
                FUN_2C8C,
                FUN_2D48,
                FUN_60068
            };
            PTR_FUN_7984 = new FUN_7984[7]
            {
                FUN_2E74,
                FUN_2F24,
                FUN_3378,
                FUN_33DC,
                FUN_34D0,
                FUN_3500,
                FUN_5FF98
            };
            PTR_FUN_7A8C = new FUN_7A8C[7]
            {
                FUN_51E4,
                FUN_52C8,
                FUN_54D8,
                FUN_55CC,
                FUN_56B4,
                FUN_570C,
                FUN_5FF98
            };
            PTR_FUN_7B14 = new FUN_7B14[3]
            {
                FUN_6700,
                FUN_6718,
                FUN_5FF98
            };
            PTR_FUN_7B20 = new FUN_7B20[2]
            {
                FUN_6CB0,
                FUN_6CF4,
            };
            PTR_FUN_7B28 = new FUN_7B28[5]
            {
                FUN_7084,
                FUN_7090,
                FUN_70E0,
                FUN_71EC,
                FUN_5FF98
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

    //FUN_F4 (ST1)
    public override void Initialize()
    {
        bool bVar2;
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();
        DAT_74A4 = Resources.Load<TrgScriptableObject>("DATA/ST1/ST1_01");
        PTR_FUN_B58BC = DAT_7624;
        PTR_FUN_B58C0 = DAT_7680;
        PTR_FUN_C2570 = DAT_76A8;
        PTR_FUN_C1CF8 = DAT_76C8;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        GameManager.instance.DAT_AC = DAT_7594[uVar3];
        GameManager.instance.DAT_46 = 1;
        GameManager.instance.DAT_B0 = DAT_7230;

        for (int i = 0; i < DAT_74A4.TRIGGERS.Length; i++)
        {
            puVar4 = LevelManager.instance.DAT_9EEC[i];
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

        GameManager.instance.FUN_7669C(LevelManager.instance.DAT_9EEC, 1);
        bVar2 = InventoryManager.FUN_4A87C(0, 0x22);

        if (!bVar2)
        {
            bVar2 = InventoryManager.FUN_4A87C(0, 0x23);

            if (!bVar2)
                LevelManager.instance.DAT_9EEC[2].DAT_03 |= 2;
        }

        bVar2 = InventoryManager.FUN_4A87C(0, 0x1e);

        if (!bVar2)
            LevelManager.instance.DAT_9EEC[1].DAT_03 |= 2;
    }

    //FUN_2BC (ST1)
    private void FUN_2BC(CriParticle param1)
    {
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8010ee50));
        param1.DAT_56 = 103;
        param1.DAT_54 = 0x7ef0;
        param1.DAT_50.a |= 2;
        param1.DAT_3C++;
        param1.flags |= 2;
    }

    //FUN_31C (ST1)
    private void FUN_31C(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_398 (ST1)
    private void FUN_398(CriParticle param1)
    {
        byte bVar1;
        ushort uVar2;
        uint[] local_20 = new uint[4] { 0x80132b5c, 0x80132bfc, 0x80132ca4, 0x80132d6c };
        
        bVar1 = param1.DAT_2F;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(local_20[bVar1]));
        param1.DAT_56 = 37;
        param1.DAT_54 = 0x7f3c;

        if (bVar1 == 0)
            uVar2 = 12;
        else
            uVar2 = 8;

        param1.DAT_60 = uVar2;
        param1.DAT_62 = uVar2;
        param1.flags |= 2;
        param1.DAT_3C++;
    }

    //FUN_448 (ST1)
    private void FUN_448(CriParticle param1)
    {
        param1.FUN_606D8();
    }

    //FUN_4B4 (ST1)
    private void FUN_4B4(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;
        int iVar4;
        Vector3Int local_38;
        Vector3Int local_40;
        Matrix3x3 auStack48;

        iVar4 = param1.DAT_2F;
        bVar1 = DAT_7808[PTR_DAT_771C[iVar4].DAT_03];
        param1.DAT_54 = 0x7efa;
        param1.DAT_56 = (ushort)(bVar1 << 5 | 5);
        sVar2 = (sbyte)PTR_DAT_771C[iVar4].DAT_02;
        param1.DAT_50.a |= 2;
        param1.DAT_62 = (ushort)(short)sVar2;
        param1.DAT_60 = (ushort)(short)sVar2;
        bVar3 = PTR_DAT_771C[iVar4].DAT_01;
        param1.DAT_50.r = bVar3;
        param1.DAT_50.g = bVar3;
        param1.DAT_50.b = bVar3;
        local_38 = new Vector3Int(0, param1.vr.y, 0);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref auStack48);
        local_40 = new Vector3Int(0, 0, PTR_DAT_771C[iVar4].DAT_04);
        local_40 = Utilities.ApplyMatrixSV(ref auStack48, ref local_40);
        param1.DAT_40.x = local_40.x;
        param1.DAT_40.y = PTR_DAT_771C[iVar4].DAT_06;
        param1.DAT_70.y = 0x10;
        param1.DAT_40.z = local_40.z;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_77F8[PTR_DAT_771C[iVar4].DAT_00]));
        param1.vr = new Vector3Int(0, 0, 0);
        param1.DAT_3C++;
    }

    //FUN_5F8 (ST1)
    private void FUN_5F8(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        int iVar3;

        if (0 < param1.screen.y)
        {
            param1.DAT_3C++;
            param1.DAT_60 >>= 1;
            iVar3 = param1.DAT_40.x << 0x10;
            param1.DAT_62 >>= 1;
            param1.DAT_40.x = (iVar3 >> 0x10) - (iVar3 >> 0x1f) >> 1;
            param1.screen.y = 0;
            iVar3 = param1.DAT_40.z << 0x10;
            sVar1 = PTR_DAT_771C[param1.DAT_2F].DAT_06;
            param1.DAT_40.z = (iVar3 >> 0x10) - (iVar3 >> 0x1f) >> 1;
            param1.DAT_40.y = sVar1;
        }

        sVar2 = PTR_DAT_771C[param1.DAT_2F].DAT_08;
        param1.DAT_40.y += param1.DAT_70.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.vr.z = param1.vr.z - sVar2 & 0xfff;
        param1.screen.y += param1.DAT_40.y;
        param1.FUN_606D8();
    }

    //FUN_71C (ST1)
    private void FUN_71C(CriParticle param1)
    {
        short sVar1;

        if (0 < param1.screen.y)
            param1.DAT_3C++;

        sVar1 = PTR_DAT_771C[param1.DAT_2F].DAT_08;
        param1.DAT_40.y += param1.DAT_70.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.vr.z = param1.vr.z - sVar1 & 0xfff;
        param1.screen.y += param1.DAT_40.y;
        param1.FUN_606D8();
    }

    //FUN_818 (ST1)
    private void FUN_818(CriParticle param1)
    {
        uint uVar2;

        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        uVar2 = 0;

        do
        {
            param1.DAT_6C[uVar2] = 0;
            uVar2++;
        } while (uVar2 < 8);

        param1.DAT_68 = 0;
        param1.DAT_69 = 0;
        param1.DAT_6A = 0;
        param1.DAT_3C++;
    }

    //FUN_88C (ST1)
    private void FUN_88C(CriParticle param1)
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

                if (param1.DAT_6A != 3) goto LAB_9B0;
                else goto LAB_9A4;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (sbyte)param1.DAT_69 < 2)
                {
                    if (param1.DAT_6A == 3) goto LAB_9A4;

                    GameManager.instance.FUN_5C94C(null, 145);
                    sVar1 = (sbyte)(param1.DAT_69 + 1);
                    param1.DAT_69 = (byte)sVar1;
                }

                if (param1.DAT_6A != 3) goto LAB_9B0;
                else goto LAB_9A4;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_9B0;
                else goto LAB_9A4;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                sVar1 = (sbyte)(param1.DAT_69 - 1);
                param1.DAT_69 = (byte)sVar1;

                if (param1.DAT_6A != 3) goto LAB_9B0;
                else goto LAB_9A4;
            }
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                param1.DAT_6A--;
            }

            if (param1.DAT_6A != 3) goto LAB_9B0;
        }

        LAB_9A4:
        param1.DAT_69 = 1;

        LAB_9B0:
        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 147);

            if ((sbyte)param1.DAT_68 < 1)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_3C = 3;
            }
            else
                param1.DAT_68--;

            param1.DAT_6C[param1.DAT_68] = 0;
        }
    }

    //FUN_AA0 (ST1)
    private void FUN_AA0(CriParticle param1)
    {
        uint uVar1;
        byte bVar2;

        bVar2 = 0;
        param1.DAT_3C++;
        uVar1 = 0;

        do
        {
            if (param1.DAT_6C[uVar1] != DAT_7828[param1.DAT_2F * 4 + uVar1])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                GameManager.instance.FUN_5C94C(null, 149);
                return;
            }

            bVar2++;
            uVar1 = (uint)bVar2;
        } while (bVar2 < 4);

        GameManager.instance.FUN_5C94C(null, 148);
        InventoryManager.FUN_4A7E8(2, 9, true);
    }

    //FUN_1178 (ST1)
    private void FUN_1178(CriParticle param1)
    {
        ushort uVar1;

        if ((param1.DAT_2F & 0x80) != 0)
            FUN_1304(param1);

        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_7850[param1.DAT_2F]));
        uVar1 = DAT_7854[param1.DAT_2F];
        param1.DAT_56 = 55;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.DAT_76 = 30;
        param1.DAT_54 = uVar1;
        param1.DAT_3C++;
    }

    //FUN_1220 (ST1)
    private void FUN_1220(CriParticle param1)
    {
        short sVar1;

        param1.DAT_40 += param1.DAT_70;
        param1.screen += param1.DAT_40;

        if (param1.DAT_2F < 2)
        {
            param1.FUN_606D8();

            if ((param1.DAT_58.FRAMES[param1.DAT_5C].DAT_04 & 0xe0) == 0)
                return;
        }
        else
        {
            sVar1 = param1.DAT_76;
            param1.DAT_76 = (short)(sVar1 - 1);

            if (sVar1 != 1)
                return;
        }

        param1.DAT_3C++;
    }

    //FUN_1304 (ST1)
    private void FUN_1304(CriParticle param1)
    {
        byte bVar1;
        ushort uVar2;

        bVar1 = param1.DAT_2F;
        param1.DAT_2F = 0;
        param1.DAT_70.y = 0;
        uVar2 = (ushort)(bVar1 & 0x7f);
        param1.DAT_62 = uVar2;
        param1.DAT_60 = uVar2;
    }

    //FUN_1360 (ST1)
    private void FUN_1360(CriParticle param1)
    {
        byte bVar3;
        int piVar4;
        int piVar5;
        bool bVar6;
        int iVar6;
        bool bVar7;
        int iVar7;
        int puVar8;
        CriStatic oVar9;
        CriStatic oVar10;
        byte[] local_38 = new byte[20] { 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4, 2 };
        uint[] local_48 = new uint[4] { 4, 5, 6, 7 };
        CriStatic[] local_60 = new CriStatic[5];
        CriStatic[] local_78 = new CriStatic[5];

        iVar7 = 0;
        oVar10 = null;
        System.Array.Copy(SceneManager.instance.staticObjects, local_78, 5);
        oVar9 = SceneManager.instance.staticObjects[5];
        bVar6 = InventoryManager.FUN_4A87C(3, 0x20);

        if (!bVar6)
        {
            bVar6 = InventoryManager.FUN_4A87C(3, 0x21);

            if (!bVar6)
            {
                bVar6 = InventoryManager.FUN_4A87C(3, 0x22);

                if (bVar6)
                    iVar7 = 3;
            }
            else
            {
                bVar6 = InventoryManager.FUN_4A87C(0, 0x76);

                if (!bVar6)
                {
                    bVar6 = InventoryManager.FUN_4A87C(3, 0x21);

                    if (bVar6)
                        iVar7 = 1;
                }
                else
                    iVar7 = 2;
            }
        }
        else
            iVar7 = 0;

        bVar6 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (!bVar6)
        {
            InventoryManager.FUN_4A7E8(3, 0x3f, true);
            piVar4 = 0;

            do
            {
                local_78[piVar4].DAT_78 = local_38[piVar4 + iVar7 * 5];
                local_78[piVar4].DAT_79 = (byte)piVar4;
                piVar4++;
            } while (piVar4 < 5);
        }

        piVar4 = 0;

        do
        {
            piVar5 = 0;

            do
            {
                if (local_78[piVar5].DAT_78 == piVar4)
                {
                    local_60[piVar4] = local_78[piVar5];
                    break;
                }

                piVar5++;
            } while (piVar5 < 5);

            piVar4++;
        } while (piVar4 < 5);

        iVar6 = 0;
        puVar8 = 0;

        do
        {
            bVar7 = InventoryManager.FUN_4A87C(3, 0x3d);

            if (bVar7)
            {
                iVar6 = 3;
                break;
            }

            bVar7 = InventoryManager.FUN_4A87C(2, local_48[puVar8]);

            if (bVar7) break;

            iVar6++;
            puVar8++;
        } while (iVar6 < 4);

        if (iVar6 == 1)
        {
            bVar3 = 2;
            local_60[0] = local_60[1];
            local_60[3] = local_60[2];
            local_60[0].DAT_78 = bVar3;
            local_60[3].DAT_78 = (byte)iVar6;
            local_60[1] = local_60[3];
        }
        else
        {
            if (1 < iVar6)
            {
                if (iVar6 == 2)
                {
                    bVar3 = 3;
                    local_60[0] = local_60[2];
                }
                else
                {
                    bVar3 = 4;
                    local_60[0] = local_60[3];
                    local_60[3] = local_60[4];

                    if (iVar6 != 3)
                    {
                        param1.PTR_68[0] = oVar9;
                        goto LAB_1638;
                    }
                }

                local_60[0].DAT_78 = bVar3;
                local_60[3].DAT_78 = (byte)iVar6;
                local_60[1] = local_60[3];
                goto LAB_1634;
            }

            if (iVar6 != 0)
            {
                param1.PTR_68[0] = oVar9;
                goto LAB_1638;
            }

            local_60[0].DAT_78 = 1;
            local_60[1].DAT_78 = 0;
        }

        LAB_1634:
        param1.PTR_68[0] = local_60[0];
        oVar9 = local_60[0];
        oVar10 = local_60[1];
        LAB_1638:
        param1.PTR_68[1] = oVar10;

        if (oVar10 != null)
        {
            param1.DAT_70.x = (oVar9.screen.x + oVar10.screen.x) / 2;
            param1.DAT_70.y = (oVar9.screen.z + oVar10.screen.z) / 2;
            oVar9.VDAT_74.x = oVar9.screen.x - param1.DAT_70.x;
            oVar9.VDAT_74.y = oVar9.screen.z - param1.DAT_70.y;
            oVar10.VDAT_74.x = oVar10.screen.x - param1.DAT_70.x;
            oVar10.VDAT_74.y = oVar10.screen.z - param1.DAT_70.y;
            oVar9.DAT_4A = 970;
            oVar10.DAT_4A = 969;
            param1.DAT_74 = 0;
            param1.DAT_75 = 0;
            param1.DAT_3C++;
            InventoryManager.FUN_4A7E8(3, 0x3e, false);
            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            //FUN_1D988
        }
        else
        {
            param1.DAT_70.x = oVar9.screen.x / 2;
            param1.DAT_70.y = oVar9.screen.z / 2;
            oVar9.VDAT_74.x = oVar9.screen.x - param1.DAT_70.x;
            oVar9.VDAT_74.y = oVar9.screen.z - param1.DAT_70.y;
            oVar10.VDAT_74.x = -param1.DAT_70.x;
            oVar10.VDAT_74.y = -param1.DAT_70.y;
            oVar9.DAT_4A = 970;
            oVar10.DAT_4A = 969;
            param1.DAT_74 = 0;
            param1.DAT_75 = 0;
            param1.DAT_3C++;
            InventoryManager.FUN_4A7E8(3, 0x3e, false);
            InventoryManager.FUN_4A7E8(3, 0x2c, true);
            //FUN_1D988
        }
    }

    //FUN_1738 (ST1)
    private void FUN_1738(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;
        CriStatic oVar4;
        CriStatic oVar5;
        Vector3Int local_28;
        Vector3Int local_30;
        Vector3Int local_38;
        Matrix3x3 auStack_58;

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
        auStack_58 = new Matrix3x3();
        Utilities.RotMatrix(ref local_28, ref auStack_58);
        local_38 = new Vector3Int(oVar4.VDAT_74.x, oVar4.screen.y, oVar4.VDAT_74.y);
        local_30 = Utilities.ApplyMatrixSV(ref auStack_58, ref local_38);
        oVar4.screen.x = local_30.x + param1.DAT_70.x;
        oVar4.screen.z = local_30.z + param1.DAT_70.y;
        local_38 = new Vector3Int(oVar5.VDAT_74.x, oVar5.screen.y, oVar5.VDAT_74.y);
        local_30 = Utilities.ApplyMatrixSV(ref auStack_58, ref local_38);
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

    //FUN_1948 (ST1)
    private void FUN_1948(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        CriStatic oVar3;
        CriStatic oVar4;
        int iVar5;
        uint uVar5;
        bool bVar5;
        int piVar6;
        CriStatic[] local_30 = new CriStatic[5];

        InventoryManager.FUN_4A7E8(3, 0x2e, false);
        piVar6 = 0;

        do
        {
            local_30[piVar6] = SceneManager.instance.staticObjects[piVar6];
            piVar6++;
        } while (piVar6 < 5);

        oVar3 = local_30[3];
        oVar4 = local_30[4];
        uVar5 = 0;

        do
        {
            InventoryManager.FUN_4A7E8(3, uVar5 + 0x24, false);
            uVar5++;
        } while (uVar5 < 4);

        if (oVar4.DAT_78 != 3)
            InventoryManager.FUN_4A7E8(3, oVar4.DAT_78 + 0x24U, true);

        if (GameManager.instance.DAT_9AA0 == 0x601 && oVar4.DAT_78 == 4)
        {
            bVar5 = InventoryManager.FUN_4A87C(0, 0xb5);

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
                goto LAB_1AE0;
            else
            {
                piVar6++;

                if (4 < iVar5)
                    goto LAB_1AE0;
            }
        }

        InventoryManager.FUN_4A7E8(3, 0x2e, true);
        LAB_1AE0:
        InventoryManager.FUN_4A7E8(3, 0x3e, true);
        param1.DAT_3C++;
    }

    //FUN_1B54 (ST1)
    private void FUN_1B54(CriParticle param1)
    {
        byte bVar2;
        bool bVar4;
        int iVar4;
        int piVar5;
        int iVar6;
        CriStatic oVar6;
        sbyte sVar7;
        int iVar8;
        int piVar9;
        CriStatic[] local_48 = new CriStatic[5];
        byte[] local_30 = new byte[24] { 0, 1, 2, 3, 4, 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4 };

        iVar8 = 0;
        piVar9 = 0;
        System.Array.Copy(SceneManager.instance.staticObjects, local_48, 5);
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.screen.y = -1350;
        param1.screen.z = -3800;
        param1.DAT_50.a |= 2;
        param1.flags &= 0xfffffffd;
        bVar4 = InventoryManager.FUN_4A87C(3, 0x3e);

        if (!bVar4)
        {
            bVar4 = InventoryManager.FUN_4A87C(3, 0x20);

            if (!bVar4)
            {
                bVar4 = InventoryManager.FUN_4A87C(3, 0x21);

                if (!bVar4)
                {
                    bVar4 = InventoryManager.FUN_4A87C(3, 0x22);

                    if (bVar4)
                        iVar8 = 4;
                }
                else
                {
                    bVar4 = InventoryManager.FUN_4A87C(0, 0x76);

                    if (!bVar4)
                    {
                        bVar4 = InventoryManager.FUN_4A87C(3, 0x21);

                        if (bVar4)
                            iVar8 = 2;
                    }
                    else
                        iVar8 = 3;

                    param1.DAT_78 = 0;
                }
            }
            else
                iVar8 = 1;
        }
        else
        {
            iVar8 = 0;
            param1.DAT_78 = 3;
        }

        bVar4 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (!bVar4)
        {
            InventoryManager.FUN_4A7E8(3, 0x3f, true);
            piVar5 = 0;

            do
            {
                oVar6 = local_48[piVar5];
                bVar2 = local_30[piVar5 + iVar8 * 5];
                oVar6.DAT_79 = (byte)piVar5;
                oVar6.DAT_78 = bVar2;
                piVar5++;
            } while (piVar5 < 5);
        }

        iVar4 = 0;

        do
        {
            iVar6 = 0;
            piVar5 = 0;

            do
            {
                iVar6++;

                if (local_48[piVar5].DAT_78 == iVar4)
                {
                    param1.PTR_68[piVar9] = local_48[piVar5];
                    break;
                }

                piVar5++;
            } while (iVar6 < 5);

            iVar4++;
            piVar9++;

            if (3 < iVar4)
            {
                InventoryManager.FUN_4A7E8(3, 0x3e, false);
                InventoryManager.FUN_4A7E8(3, 0x2c, true);
                InventoryManager.FUN_4A7E8(3, 0x2d, true);
                sVar7 = (sbyte)(iVar8 + 1);

                if (iVar8 == 4)
                    sVar7 = 1;
                else if (2 < iVar8 + 1)
                    sVar7 = 2;

                param1.DAT_3C += (byte)sVar7;
                param1.DAT_7A = 0;
                param1.DAT_7B = 0;
                return;
            }
        } while (true);
    }

    //FUN_1E2C (ST1)
    private void FUN_1E2C(CriParticle param1)
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
              //  ; //FUN_1D988
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

    //FUN_1FCC (ST1)
    private void FUN_1FCC(CriParticle param1)
    {
        sbyte sVar2;
        short sVar3;
        bool bVar4;
        int iVar4;
        CriStatic oVar4;
        CriParticle oVar5;
        CriStatic oVar6;
        CriStatic oVar7;

        oVar6 = (CriStatic)param1.PTR_68[param1.DAT_78];
        oVar7 = SceneManager.instance.staticObjects[param1.DAT_78];
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
                    oVar5.tags = 0x12;
                    oVar5.flags |= 2;
                    oVar5.screen.x = DAT_7874[param1.DAT_78 * 3];
                    oVar5.screen.y = DAT_7874[param1.DAT_78 * 3 + 1];
                    oVar5.screen.z = DAT_7874[param1.DAT_78 * 3 + 2];
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
                //  ; //FUN_1D988
        }

        sVar3 = (short)(oVar7.vr.z + 0x23);
        oVar7.vr.z = sVar3;

        if (0x400 < sVar3)
            oVar7.vr.z = 0x400;

        if ((oVar6.flags & 2) != 0)
        {
            bVar4 = InventoryManager.FUN_4A87C(3, 0x2d);

            if (!bVar4)
                param1.flags &= 0xfffffffd;
            else
                FUN_22A4(param1);
        }

        sVar3 = (short)(oVar6.screen.y + 4);
        oVar6.screen.y = sVar3;

        if (-0x433 < sVar3)
        {
            oVar4 = SceneManager.instance.staticObjects[param1.DAT_78];
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

    //FUN_22A4 (ST1)
    private void FUN_22A4(CriParticle param1)
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

                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80115450));
                param1.flags |= 2;
                param1.screen.x = DAT_7874[param1.DAT_78] - 85;
                InventoryManager.FUN_4A7E8(3, 0x2d, false);
                param1.DAT_7B = 0;
                return;
            }

            if (sVar1 != 0)
                return;

            param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80115448));
            param1.flags |= 2;
            param1.screen.x = DAT_7874[param1.DAT_78];
        }

        param1.DAT_7B++;
    }

    //FUN_23F0 (ST1)
    private void FUN_23F0(CriParticle param1)
    {
        CriSkinned oVar2;
        Matrix3x3 auStack_38;
        Vector3Int local_18;

        oVar2 = SceneManager.instance.skinnedObjects[10];
        param1.PTR_68[0] = oVar2;
        auStack_38 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack_38);
        local_18 = new Vector3Int(0, 0, 150);
        param1.VDAT_6C = Utilities.ApplyMatrixSV(ref auStack_38, ref local_18);
        param1.VDAT_6C.x += oVar2.screen.x;
        param1.VDAT_6C.y = oVar2.screen.y - 1000;
        param1.VDAT_6C.z += oVar2.screen.z;
        param1.DAT_3C++;
    }

    //FUN_24A8 (ST1)
    private void FUN_24A8(CriParticle param1)
    {
        bool bVar1;
        Vector3Int local_18;

        local_18 = new Vector3Int();
        local_18.x = param1.VDAT_6C.x;
        local_18.y = param1.PTR_68[0].screen.y - 1000;
        local_18.z = param1.VDAT_6C.z;
        param1.VDAT_6C.y = -2800;
        bVar1 = InventoryManager.FUN_4A87C(2, 0xd);

        if (!bVar1)
            param1.DAT_3C++;

        FUN_2528(param1.VDAT_6C, local_18);
    }

    //FUN_2528 (ST1)
    private void FUN_2528(Vector3Int param1, Vector3Int param2)
    {
        CriCamera cVar1;
        Vector3Int local_60;
        CriTransform local_58;

        local_58 = new CriTransform();
        local_58.rotation.V22 = 0x1000;
        local_58.rotation.V11 = 0x1000;
        local_58.rotation.V00 = 0x1000;
        local_58.rotation.V21 = 0;
        local_58.rotation.V20 = 0;
        local_58.rotation.V12 = 0;
        local_58.rotation.V10 = 0;
        local_58.rotation.V02 = 0;
        local_58.rotation.V01 = 0;
        GameManager.instance.DAT_30 = 0x4016282e;
        cVar1 = SceneManager.instance.cCamera;
        local_60 = new Vector3Int();
        local_60.x = param1.x - cVar1.DAT_30.x;
        local_60.y = param1.y - cVar1.DAT_30.y;
        local_60.z = param1.z - cVar1.DAT_30.z;
        local_58.position = Utilities.ApplyMatrixSV(ref cVar1.cTransform.rotation, ref local_60);
        local_58.position.x += cVar1.DAT_38;
        local_58.position.y += cVar1.DAT_3A;
        local_58.position.z += cVar1.DAT_3C;
        Utilities.SetRotMatrix(ref cVar1.cTransform.rotation);
        Utilities.SetTransMatrix(ref local_58);
        //RotTransPers
        local_60.x = param2.x - cVar1.DAT_30.x;
        local_60.y = param2.y - cVar1.DAT_30.y;
        local_60.z = param2.z - cVar1.DAT_30.z;
        local_58.position = Utilities.ApplyMatrixSV(ref cVar1.cTransform.rotation, ref local_60);
        local_58.position.x += cVar1.DAT_38;
        local_58.position.y += cVar1.DAT_3A;
        local_58.position.z += cVar1.DAT_3C;
        Utilities.SetRotMatrix(ref cVar1.cTransform.rotation);
        Utilities.SetTransMatrix(ref local_58);
        //RotTransPers
        //...
    }

    //FUN_2828 (ST1)
    private void FUN_2828(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3f;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.vr.y = 0x400;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80115458));
        param1.DAT_65 = 3;
        param1.DAT_4C = SceneManager.instance.cCamera;
        param1.DAT_3C++;
    }

    //FUN_28B4 (ST1)
    private void FUN_28B4(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_2930 (ST1)
    private void FUN_2930(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_78C8[0].DAT_00));
        param1.DAT_69 = 1;
        param1.DAT_68 = DAT_78C8[0].DAT_04;
        param1.DAT_3C++;
    }

    //FUN_29B8 (ST1)
    private void FUN_29B8(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;

        sVar2 = (sbyte)(param1.DAT_68 - 1);
        param1.DAT_68 = (byte)sVar2;

        if (sVar2 == -1)
        {
            if (DAT_78C8[param1.DAT_69].DAT_00 == 0)
                param1.flags &= 0xfffffffd;
            else
            {
                param1.flags |= 2;
                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_78C8[param1.DAT_69].DAT_00), param1.DAT_69);
            }

            bVar1 = DAT_78C8[param1.DAT_69].DAT_04;
            bVar3 = (byte)(param1.DAT_69 + 1);
            param1.DAT_69 = bVar3;
            param1.DAT_68 = bVar1;

            if (2 < bVar3)
                param1.DAT_3C++;
        }
    }

    //FUN_2B08 (ST1)
    private void FUN_2B08(CriParticle param1)
    {
        ushort uVar1;

        param1.DAT_56 = (ushort)(DAT_78F8[param1.DAT_2F] << 5 | 0x15);
        uVar1 = 0x7efe;

        if (param1.DAT_2F != 2)
            uVar1 = 0x7eff;

        param1.DAT_54 = uVar1;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_78EC[param1.DAT_2F]));
        param1.DAT_50.a |= 2;
        param1.DAT_3C++;
        param1.flags |= 2;
    }

    //FUN_2BA8 (ST1)
    private void FUN_2BA8(CriParticle param1)
    {
        int iVar1;

        param1.DAT_34 = param1.screen;
        param1.DAT_40.y += param1.DAT_68;
        param1.screen += param1.DAT_40;
        iVar1 = param1.FUN_606D8();

        if (iVar1 != 0)
            param1.DAT_3C++;
    }

    //FUN_2C8C (ST1)
    private void FUN_2C8C(CriParticle param1)
    {
        int iVar2;

        param1.DAT_56 = 0x35;
        param1.DAT_54 = 0x7e72;
        param1.DAT_62 = 10;
        param1.DAT_60 = 10;
        iVar2 = param1.DAT_2F * 0x10;
        param1.DAT_40 = PTR_DAT_7908[iVar2].DAT_04;
        param1.DAT_70 = PTR_DAT_7908[iVar2].DAT_0A;
        param1.DAT_76 = 20;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(PTR_DAT_7908[iVar2].DAT_00));
        param1.DAT_3C++;
    }

    //FUN_2D48 (ST1)
    private void FUN_2D48(CriParticle param1)
    {
        short sVar1;

        sVar1 = param1.DAT_76;
        param1.DAT_76 = (short)(sVar1 - 1);

        if (sVar1 == 1)
            param1.DAT_3C++;

        param1.screen += param1.DAT_40;
        param1.DAT_40.y += param1.DAT_70.y;
        param1.FUN_606D8();
    }

    //FUN_2E74 (ST1)
    private void FUN_2E74(CriInteract param1)
    {
        SceneManager.instance.FUN_26EBC(2, 0);
        SceneManager.instance.FUN_26504(0, -0x1140, -0x778, 0x200);
        param1.DAT_08 = 10000;
        param1.BDAT_0A = -20;
        param1.DAT_0B = 40;
        param1.BDAT_0C = 4;
        param1.BDAT_0E = 100;
        param1.DAT_0D = 0;
        param1.DAT_0F = 0;
        param1.DAT_10 = 0;
        param1.DAT_11 = 12;
        param1.DAT_12 = 0;
        param1.DAT_13 = 0;
        param1.DAT_14 = 0;
        InventoryManager.FUN_4A7E8(2, 0xb, false);
        param1.DAT_18 = 0;
        param1.DAT_17 = 0;
        param1.DAT_0D = 0;
        param1.DAT_03++;
    }

    //FUN_2F24 (ST1)
    private void FUN_2F24(CriInteract param1)
    {
        ushort uVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0xf000) != 0)
            GameManager.instance.FUN_5C94C(null, 145);

        if (5U < param1.BDAT_0C)
        {
            if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
            {
                uVar1 = (ushort)(param1.DAT_08 - 100);
                param1.DAT_08 = (short)uVar1;

                if (uVar1 < 7000U)
                    param1.DAT_08 = 7000;
            }

            if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
            {
                uVar1 = (ushort)(param1.DAT_08 + 100);
                param1.DAT_08 = (short)uVar1;

                if (10000 < uVar1)
                    param1.DAT_08 = 10000;
            }

            return;
        }

        PTR_FUN_54[param1.BDAT_0C](param1);
    }

    //FUN_2F84 (ST1)
    private void FUN_2F84(CriInteract param1)
    {
        ushort uVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            param1.BDAT_0C = 0;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            param1.BDAT_0C = 1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            param1.BDAT_0C = 2;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            param1.BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            param1.DAT_03 = 2;
            GameManager.instance.FUN_5C94C(null, 146);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            param1.BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar1 = (ushort)(param1.DAT_08 - 100);
            param1.DAT_08 = (short)uVar1;

            if (uVar1 < 7000U)
                param1.DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar1 = (ushort)(param1.DAT_08 + 100);
            param1.DAT_08 = (short)uVar1;

            if (10000U < uVar1)
                param1.DAT_08 = 10000;
        }
    }

    //FUN_3018 (ST1)
    private void FUN_3018(CriInteract param1)
    {
        sbyte sVar1;
        ushort uVar2;

        if ((InputManager.controllers[0].DAT_B5898 & 0x10a0) != 0)
        {
            sVar1 = (sbyte)(param1.BDAT_0A + 1);
            param1.BDAT_0A = sVar1;

            if (40 < sVar1)
                param1.BDAT_0A = 40;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            param1.BDAT_0C = 1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            param1.BDAT_0C = 2;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            param1.BDAT_0C = 4;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            param1.BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar2 = (ushort)(param1.DAT_08 - 100);
            param1.DAT_08 = (short)uVar2;

            if (uVar2 < 7000U)
                param1.DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar2 = (ushort)(param1.DAT_08 + 100);
            param1.DAT_08 = (short)uVar2;

            if (10000U < uVar2)
                param1.DAT_08 = 10000;
        }
    }

    //FUN_30A8 (ST1)
    private void FUN_30A8(CriInteract param1)
    {
        sbyte sVar1;
        ushort uVar2;

        if ((InputManager.controllers[0].DAT_B5898 & 0x80a0) != 0)
        {
            sVar1 = (sbyte)(param1.DAT_0B - 1);
            param1.DAT_0B = sVar1;

            if (sVar1 < -40)
                param1.DAT_0B = -40;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            param1.BDAT_0C = 0;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            param1.BDAT_0C = 4;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            param1.BDAT_0C = 3;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            param1.BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar2 = (ushort)(param1.DAT_08 - 100);
            param1.DAT_08 = (short)uVar2;

            if (uVar2 < 7000U)
                param1.DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar2 = (ushort)(param1.DAT_08 + 100);
            param1.DAT_08 = (short)uVar2;

            if (10000U < uVar2)
                param1.DAT_08 = 10000;
        }
    }

    //FUN_3138 (ST1)
    private void FUN_3138(CriInteract param1)
    {
        sbyte sVar1;
        ushort uVar2;

        if ((InputManager.controllers[0].DAT_B5898 & 0x20a0) != 0)
        {
            sVar1 = (sbyte)(param1.DAT_0B + 1);
            param1.DAT_0B = sVar1;

            if (40 < sVar1)
                param1.DAT_0B = 40;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            param1.BDAT_0C = 0;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            param1.BDAT_0C = 4;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            param1.BDAT_0C = 3;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            param1.BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar2 = (ushort)(param1.DAT_08 - 100);
            param1.DAT_08 = (short)uVar2;

            if (uVar2 < 7000U)
                param1.DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar2 = (ushort)(param1.DAT_08 + 100);
            param1.DAT_08 = (short)uVar2;

            if (10000U < uVar2)
                param1.DAT_08 = 10000;
        }
    }

    //FUN_31C8 (ST1)
    private void FUN_31C8(CriInteract param1)
    {
        sbyte sVar1;
        ushort uVar2;

        if ((InputManager.controllers[0].DAT_B5898 & 0x20a0) != 0)
        {
            sVar1 = (sbyte)(param1.BDAT_0A + 1);
            param1.BDAT_0A = sVar1;

            if (sVar1 < -40)
                param1.BDAT_0A = -40;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            param1.BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            param1.BDAT_0C = 1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            param1.BDAT_0C = 2;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
            param1.BDAT_0C = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar2 = (ushort)(param1.DAT_08 - 100);
            param1.DAT_08 = (short)uVar2;

            if (uVar2 < 7000U)
                param1.DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar2 = (ushort)(param1.DAT_08 + 100);
            param1.DAT_08 = (short)uVar2;

            if (10000U < uVar2)
                param1.DAT_08 = 10000;
        }
    }

    //FUN_3270 (ST1)
    private void FUN_3270(CriInteract param1)
    {
        ushort uVar1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
            param1.BDAT_0C = 4;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
            param1.BDAT_0C = 1;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
            param1.BDAT_0C = 2;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            param1.BDAT_0C = 3;

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
            param1.DAT_03 = 5;

        if ((InputManager.controllers[0].DAT_B5898 & 4) != 0)
        {
            uVar1 = (ushort)(param1.DAT_08 - 100);
            param1.DAT_08 = (short)uVar1;

            if (uVar1 < 7000U)
                param1.DAT_08 = 7000;
        }

        if ((InputManager.controllers[0].DAT_B5898 & 8) != 0)
        {
            uVar1 = (ushort)(param1.DAT_08 + 100);
            param1.DAT_08 = (short)uVar1;

            if (10000U < uVar1)
                param1.DAT_08 = 10000;
        }
    }

    //FUN_3378 (ST1)
    private void FUN_3378(CriInteract param1)
    {
        param1.DAT_10 += 4;
        param1.DAT_11--;

        if (99U < param1.DAT_10)
        {
            param1.DAT_10 = 100;
            param1.DAT_03 = 3;
            param1.DAT_11 = 12;
            GameManager.instance.FUN_5C94C(null, 147);
        }
    }

    //FUN_33DC (ST1)
    private void FUN_33DC(CriInteract param1)
    {
        CriCamera oVar2;
        byte bVar3;
        CriParticle oVar4;

        oVar2 = SceneManager.instance.cCamera;
        bVar3 = (byte)(param1.DAT_0D + 1);
        param1.DAT_0D = bVar3;

        if (18U < bVar3)
        {
            param1.DAT_0D = 0;
            param1.DAT_03 = 4;

            if ((byte)param1.BDAT_0A - 13U < 4 && (byte)param1.DAT_0B - 3U < 4)
                InventoryManager.FUN_4A7E8(2, 9, true);

            oVar4 = SceneManager.instance.FUN_5FFA0();

            if (oVar4 != null)
            {
                GameManager.instance.FUN_5C94C(null, 148);
                oVar4.tags = 21;
                oVar4.DAT_2F = 2;
                oVar4.DAT_4C = null;
                oVar4.screen = oVar2.DAT_30;
                oVar4.DAT_62 = 10;
                oVar4.DAT_60 = 10;
                oVar4.DAT_68 = 0xff;
                oVar4.DAT_69 = 10;
                oVar4.DAT_6A = 10;
                oVar4.DAT_6B = 0;
            }
        }
    }

    //FUN_34D0 (ST1)
    private void FUN_34D0(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_10 - 10);
        param1.DAT_10 = bVar1;

        if (bVar1 < 11U)
        {
            param1.DAT_10 = 0;
            param1.DAT_03 = 1;
        }
    }

    //FUN_3500 (ST1)
    private void FUN_3500(CriInteract param1)
    {
        InventoryManager.FUN_4A7E8(2, 0xb, true);
        param1.DAT_03++;
    }

    //FUN_51E4 (ST1)
    private void FUN_51E4(CriInteract param1)
    {
        sbyte sVar1;
        sbyte[] puVar2;
        bool bVar3;
        uint uVar4;
        uint uVar5;

        InventoryManager.FUN_4A7E8(2, 0xa, false);
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 0x12, false);
        InventoryManager.FUN_4A7E8(2, 0xb, false);
        param1.DAT_08 = 0;
        param1.DAT_0A = 0;
        param1.DAT_0C = 0;
        puVar2 = DAT_7B44;
        uVar4 = 0;

        do
        {
            puVar2[uVar4] = -1;
            uVar5 = uVar4 + 1;
            uVar4 = uVar5;
        } while (uVar5 < 5);

        //DAT_7B4B = 0;
        DAT_7B4A = 0;
        DAT_7B49 = 0;
        //DAT_7B4D = 0;
        //DAT_7B4C = 0;
        bVar3 = InventoryManager.FUN_4A87C(3, 0x20);
        sVar1 = 3;

        if (!bVar3)
            sVar1 = 1;

        param1.DAT_03 = sVar1;
    }

    //FUN_52C8 (ST1)
    private void FUN_52C8(CriInteract param1)
    {
        short sVar1;

        //...

        if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
        {
            if (param1.DAT_08 == 4)
                param1.DAT_08 = 0;
            else
                param1.DAT_08++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
        {
            sVar1 = (short)(param1.DAT_08 - 1);

            if (param1.DAT_08 == 0)
                sVar1 = 4;

            param1.DAT_08 = sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0)
        {
            sVar1 = (short)(param1.DAT_0A - 1);

            if (param1.DAT_0A == 0)
                sVar1 = 1;

            param1.DAT_0A = sVar1;
            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
        {
            if (param1.DAT_0A == 1)
                param1.DAT_0A = 0;
            else
                param1.DAT_0A++;

            GameManager.instance.FUN_5C94C(null, 145);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            DAT_7B44[DAT_7B49] = (sbyte)((byte)param1.DAT_08 + param1.DAT_0A * 5);

            if (DAT_7B49 == 4)
                param1.DAT_03 = 2;

            DAT_7B49++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            if (DAT_7B49 == 0)
            {
                InventoryManager.FUN_4A7E8(2, 0xb, true);
                param1.DAT_03 = 5;
            }
            else
            {
                DAT_7B44[DAT_7B49] = -1;
                DAT_7B49--;
            }

            GameManager.instance.FUN_5C94C(null, 147);
        }
    }

    //FUN_54D8 (ST1)
    private void FUN_54D8(CriInteract param1)
    {
        bool bVar1;

        if (DAT_7B4A < 31)
        {
            if (DAT_7B4A == 0)
            {
                InventoryManager.FUN_4A7E8(3, 0x22, false);
                InventoryManager.FUN_4A7E8(3, 0x23, false);
                InventoryManager.FUN_4A7E8(3, 0x24, false);

                if (param1.DAT_02 == 0)
                {
                    FUN_5DC8();
                    FUN_5EE8();
                }
                else if (param1.DAT_02 == 1)
                {
                    FUN_5F98();
                    FUN_6044();
                }
            }

            //FUN_5718
            DAT_7B4A++;
        }
        
        bVar1 = InventoryManager.FUN_4A87C(3, 0x21);

        if (bVar1)
        {
            param1.DAT_03 = 3;
            DAT_7B4A = 0;
        }
    }

    //FUN_55CC (ST1)
    private void FUN_55CC(CriInteract param1)
    {
        sbyte sVar1;
        short sVar2;
        bool bVar3;
        int iVar4;

        if (param1.DAT_0C == 0)
        {
            bVar3 = InventoryManager.FUN_4A87C(3, 0x24);

            if (bVar3)
                InventoryManager.FUN_4A7E8(2, 0xa, true);
            else
            {
                bVar3 = InventoryManager.FUN_4A87C(3, 0x23);

                if (bVar3)
                    InventoryManager.FUN_4A7E8(2, 0xa, true);
            }
        }

        //FUN_5AC8
        sVar2 = (short)(param1.DAT_0C + 1);
        param1.DAT_0C = sVar2;

        if (sVar2 == 150)
        {
            bVar3 = InventoryManager.FUN_4A87C(2, 0xa);
            sVar1 = 5;

            if (!bVar3)
                sVar1 = 4;

            param1.DAT_03 = sVar1;

            if (param1.DAT_0C == 150)
            {
                bVar3 = InventoryManager.FUN_4A87C(2, 0xa);

                if (!bVar3)
                    iVar4 = 148;
                else
                    iVar4 = 149;

                GameManager.instance.FUN_5C94C(null, iVar4);
            }
        }
    }

    //FUN_56B4 (ST1)
    private void FUN_56B4(CriInteract param1)
    {
        //FUN_5AC8

        if (29 < DAT_7B4A)
        {
            param1.DAT_03 = 5;
            DAT_7B4A = 0;
        }

        DAT_7B4A++;
    }

    //FUN_570C (ST1)
    private void FUN_570C(CriInteract param1)
    {
        param1.DAT_03 = 5;
    }

    //FUN_5DC8 (ST1)
    private void FUN_5DC8()
    {
        uint uVar3;
        uint uVar4;
        uint uVar5;
        bool bVar6;
        byte[] local_18 = new byte[5] { 5, 7, 0, 3, 6 };
        byte[] local_10 = new byte[5] { 5, 8, 1, 0, 4 };

        bVar6 = false;
        uVar5 = 0;

        do
        {
            uVar3 = uVar5 + 1;

            if (DAT_7B44[uVar5] != local_18[uVar5])
            {
                bVar6 = true;
                break;
            }

            uVar5 = uVar3;
        } while (uVar3 < 5);

        if (bVar6)
        {
            uVar5 = 0;

            do
            {
                if (DAT_7B44[uVar5] != local_10[uVar5])
                {
                    InventoryManager.FUN_4A7E8(2, 10, true);
                    uVar4 = 0x95;
                    goto LAB_5ED0;
                }

                uVar3 = uVar5 + 1;
                uVar5 = uVar3;
            } while (uVar3 < 5);

            uVar4 = 0x12;
        }
        else
            uVar4 = 9;

        InventoryManager.FUN_4A7E8(2, uVar4, true);
        uVar4 = 0x94;
        LAB_5ED0:
        GameManager.instance.FUN_5C94C(null, (int)uVar4);
    }

    //FUN_5EE8 (ST1)
    private void FUN_5EE8()
    {
        byte bVar1;
        bool bVar2;
        uint uVar3;

        bVar1 = GameManager.instance.DAT_9ADF;

        if (bVar1 == 1)
        {
            bVar2 = InventoryManager.FUN_4A87C(2, 9);

            if (bVar2)
            {
                uVar3 = 0x22;
                goto LAB_5F80;
            }
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                    uVar3 = 0x24;
                else
                    uVar3 = 0x23;

                goto LAB_5F80;
            }

            if (bVar1 != 2)
            {
                uVar3 = 0x23;
                goto LAB_5F80;
            }

            bVar2 = InventoryManager.FUN_4A87C(2, 0x12);

            if (bVar2)
            {
                uVar3 = 0x22;
                goto LAB_5F80;
            }
        }

        uVar3 = 0x23;
        LAB_5F80:
        InventoryManager.FUN_4A7E8(3, uVar3, true);
    }

    //FUN_5F98 (ST1)
    private void FUN_5F98()
    {
        uint uVar3;
        uint uVar4;
        uint uVar5;
        byte[] local_10 = new byte[5] { 3, 1, 4, 1, 5 };

        uVar3 = 0;

        do
        {
            if (DAT_7B44[uVar3] != local_10[uVar3])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                uVar4 = 0x95;
                goto LAB_602C;
            }

            uVar5 = uVar3 + 1;
            uVar3 = uVar5;
        } while (uVar5 < 5);

        InventoryManager.FUN_4A7E8(2, 9, true);
        uVar4 = 0x94;
        LAB_602C:
        GameManager.instance.FUN_5C94C(null, (int)uVar4);
    }

    //FUN_6044 (ST1)
    private void FUN_6044()
    {
        bool bVar1;
        uint uVar2;

        if (GameManager.instance.DAT_9ADF == 0)
            uVar2 = 0x24;
        else if (GameManager.instance.DAT_9ADF == 3)
        {
            bVar1 = InventoryManager.FUN_4A87C(2, 9);

            if (bVar1)
                uVar2 = 0x22;
            else
                uVar2 = 0x23;
        }
        else
            uVar2 = 0x23;

        InventoryManager.FUN_4A7E8(3, uVar2, true);
    }

    //FUN_6700 (ST1)
    private void FUN_6700(CriInteract param1)
    {
        param1.DAT_0A = 0;
        param1.DAT_08 = 0;
        param1.DAT_03++;
    }

    //FUN_6718 (ST1)
    private void FUN_6718(CriInteract param1)
    {
        ushort uVar2;
        sbyte sVar3;
        int iVar4;
        CriParticle oVar5;
        uint uVar6;

        uVar6 = (ushort)param1.DAT_0A;

        if (param1.DAT_0A < 9)
        {
            do
            {
                iVar4 = (int)uVar6 * 12;

                if (DAT_7AA0[iVar4 + 6] != param1.DAT_08) break;

                oVar5 = SceneManager.instance.FUN_5FFA0();

                if (oVar5 != null)
                {
                    oVar5.tags = 20;
                    oVar5.DAT_2F = (byte)(DAT_7AA0[iVar4 + 7] | 0x80);
                    oVar5.DAT_4C = SceneManager.instance.staticObjects[param1.DAT_04];
                    oVar5.DAT_40.x = DAT_7AA0[iVar4 + 8] << 0x18 >> 0x17;
                    oVar5.DAT_40.y = DAT_7AA0[iVar4 + 9] << 0x18 >> 0x17;
                    oVar5.DAT_40.z = DAT_7AA0[iVar4 + 10] << 0x18 >> 0x17;
                    oVar5.DAT_6C[0] = 0x80;
                }

                uVar6 = (ushort)param1.DAT_0A + 1U;
                param1.DAT_0A = (short)uVar6;
            } while ((short)uVar6 < 9);
        }

        //...
        uVar2 = (ushort)param1.DAT_08;
        param1.DAT_08 = (short)(uVar2 + 1);

        if (5 < param1.DAT_08)
        {
            param1.DAT_0A = 0;
            param1.DAT_08 = 0;
        }

        sVar3 = (sbyte)(param1.DAT_05 - 1);
        param1.DAT_05 = (byte)sVar3;

        if (sVar3 == 0)
        {
            param1.DAT_03++;
            FUN_6A9C();
        }
    }

    //FUN_7084 (ST1)
    private void FUN_7084(CriInteract param1)
    {
        param1.DAT_03 = 1;
    }

    //FUN_7090 (ST1)
    private void FUN_7090(CriInteract param1)
    {
        CriSkinned oVar1;
        uint uVar2;

        uVar2 = 0;

        do
        {
            oVar1 = SceneManager.instance.skinnedObjects[uVar2];

            if (oVar1.tags == 2)
            {
                param1.PDAT_08 = oVar1;
                param1.DAT_03 = 2;
                return;
            }
        } while (uVar2 < 10);
    }

    //FUN_70E0 (ST1)
    private void FUN_70E0(CriInteract param1)
    {
        //...
    }

    //FUN_71EC (ST1)
    private void FUN_71EC(CriInteract param1)
    {
        return;
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
            puVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[uVar4];

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

    //FUN_6CB0 (ST1)
    private void FUN_6CB0(CriStatic param1)
    {
        param1.tags++;
        param1.DAT_4C = new Vector3Int(0, 0, 0);
        //FUN_6D14
    }

    private void FUN_6CF4(CriStatic param1)
    {
        FUN_6ED4(param1);
    }

    //FUN_6D14 (ST1)
    private void FUN_6D14(CriStatic param1)
    {
        return;
    }

    //FUN_6DE8 (ST1)
    private void FUN_6DE8(CriStatic param1)
    {
        param1.DAT_54 = param1.DAT_4C;
        param1.DAT_4C = param1.PTR_60[param1.DAT_5C].DAT_00;
        param1.screen.x -= param1.DAT_54.x - param1.DAT_4C.x;
        param1.screen.y -= param1.DAT_54.y - param1.DAT_4C.y;
        param1.screen.z -= param1.DAT_54.z - param1.DAT_4C.z;
        Utilities.FUN_60C94(param1.PTR_60[param1.DAT_5C].COMP, GameManager.instance.todUncomp, 1);
        param1.vr = GameManager.instance.todUncomp[0];
        param1.DAT_6F--;
    }

    //FUN_6ED4 (ST1)
    private bool FUN_6ED4(CriStatic param1)
    {
        byte bVar1;
        sbyte sVar2;
        uint uVar3;
        byte[] aVar4;
        byte bVar5;
        bool bVar6;

        bVar1 = param1.DAT_6E;
        bVar6 = false;

        if ((bVar1 & 0x20) == 0)
        {
            if (param1.DAT_6F != 0) goto LAB_7068;

            sVar2 = (sbyte)param1.DAT_6D;
            bVar5 = (byte)(sVar2 + 1);
            param1.DAT_6D = bVar5;

            if ((bVar1 & 4) != 0)
            {
                bVar6 = param1.DAT_6C <= bVar5;

                if (param1.DAT_6C < bVar5)
                {
                    if ((bVar1 & 1) == 0)
                        param1.DAT_6D = (byte)sVar2;
                    else
                        param1.DAT_6D = 0;
                }

                if ((uint)param1.DAT_68[param1.DAT_6D * 4] >> 1 == 0)
                    param1.DAT_6D++;
            }

            bVar5 = param1.DAT_6D;

            if (param1.DAT_6C <= bVar5)
                bVar6 = true;

            if (param1.DAT_6C < bVar5)
            {
                if ((bVar1 & 1) == 0)
                    param1.DAT_6D = (byte)(bVar5 - 1);
                else
                    param1.DAT_6D = 0;
            }

            if ((bVar1 & 2) == 0)
            {
                uVar3 = param1.DAT_6D;
                aVar4 = param1.DAT_68;
            }
            else
            {
                uVar3 = (uint)param1.DAT_6C - param1.DAT_6D;
                aVar4 = param1.DAT_68;
            }

            param1.DAT_5C = aVar4[uVar3 * 4 + 1];
            bVar5 = param1.DAT_68[uVar3 * 4];
            param1.DAT_6F = bVar5;

            if ((bVar1 & 4) != 0 && 1 < bVar5)
                param1.DAT_6F = (byte)((uint)bVar5 >> 1);

            if ((bVar1 & 8) == 0) goto LAB_7068;

            sVar2 = (sbyte)(param1.DAT_6F << 1);
        }
        else
            sVar2 = (sbyte)(param1.DAT_6F + 1);

        param1.DAT_6F = (byte)sVar2;
        LAB_7068:
        FUN_6DE8(param1);
        return bVar6;
    }

    //FUN_2DD8 (ST1)
    public static void FUN_2DD8(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_14 + 3);
        param1.DAT_14 = (sbyte)bVar1;

        if (99U < bVar1)
        {
            param1.DAT_14 = 0;
            param1.DAT_13 = (sbyte)bVar1;

            if (59U < bVar1)
            {
                param1.DAT_13 = 0;
                param1.DAT_12++;
            }
        }

        instance.PTR_FUN_7984[param1.DAT_03](param1);
        //FUN_3540
    }

    //FUN_51A8 (ST1)
    public static void FUN_51A8(CriInteract param1)
    {
        instance.PTR_FUN_7A8C[param1.DAT_03](param1);
    }

    //FUN_66C4 (ST1)
    public static void FUN_66C4(CriInteract param1)
    {
        instance.PTR_FUN_7B14[param1.DAT_03](param1);
    }

    //FUN_6B74 (ST1)
    public static void FUN_6B74(CriInteract param1)
    {
        CriTrigger tVar1;

        tVar1 = LevelManager.instance.DAT_9EEC[param1.DAT_04];
        tVar1.DAT_01 = param1.DAT_05;
        tVar1.DAT_0E = 0;
        tVar1.DAT_10 = 0;
        tVar1.DAT_12 = 0;
        tVar1.DAT_14 = false;
        InventoryManager.FUN_4A7E8(5, tVar1.DAT_02, false);
        param1.FUN_5FF98();
    }

    //FUN_71F4 (ST1)
    public static void FUN_71F4(CriInteract param1)
    {
        instance.PTR_FUN_7B28[param1.DAT_03](param1);
    }

    //FUN_270 (ST1)
    public static void FUN_270(CriParticle param1)
    {
        instance.PTR_FUN_7704[param1.DAT_3C](param1);
        param1.FUN_630EC();
    }

    //FUN_35C (ST1)
    public static void FUN_35C(CriParticle param1)
    {
        instance.PTR_FUN_7710[param1.DAT_3C](param1);
    }

    //FUN_468 (ST1)
    public static void FUN_468(CriParticle param1)
    {
        instance.PTR_FUN_780C[param1.DAT_3C](param1);
        param1.FUN_630EC();
    }

    //FUN_7CC (ST1)
    public static void FUN_7CC(CriParticle param1)
    {
        instance.PTR_FUN_7840[param1.DAT_3C](param1);
        //FUN_B50
    }

    //FUN_1324 (ST1)
    public static void FUN_1324(CriParticle param1)
    {
        instance.PTR_FUN_7864[param1.DAT_3C](param1);
    }

    //FUN_1118 (ST1)
    public static void FUN_1118(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_7858[param1.DAT_3C](param1);
    }

    //FUN_1B18 (ST1)
    public static void FUN_1B18(CriParticle param1)
    {
        instance.PTR_FUN_78A0[param1.DAT_3C](param1);
    }

    //FUN_23B4 (ST1)
    public static void FUN_23B4(CriParticle param1)
    {
        instance.PTR_FUN_78B0[param1.DAT_3C](param1);
    }

    //FUN_27EC (ST1)
    public static void FUN_27EC(CriParticle param1)
    {
        instance.PTR_FUN_78BC[param1.DAT_3C](param1);
    }

    //FUN_28F4 (ST1)
    public static void FUN_28F4(CriParticle param1)
    {
        instance.PTR_FUN_78E0[param1.DAT_3C](param1);
    }

    //FUN_2AA8 (ST1)
    public static void FUN_2AA8(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_78FC[param1.DAT_3C](param1);
    }

    //FUN_2C40 (ST1)
    public static void FUN_2C40(CriParticle param1)
    {
        instance.PTR_FUN_7978[param1.DAT_3C](param1);
        param1.FUN_630EC();
    }

    //FUN_6C74 (ST1)
    public static void FUN_6C74(CriStatic param1)
    {
        instance.PTR_FUN_7B20[param1.tags](param1);
    }
}
