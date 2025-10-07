using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct UNK_12A20
{
    public byte DAT_00;
    public sbyte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public Vector3Int DAT_04;
    public ushort DAT_0A;
    public int DAT_0C;
}

public struct UNK_12A50
{
    public byte DAT_00;
    public sbyte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public Vector3Int DAT_04;
    public ushort DAT_0A;
    public Vector3Int DAT_0C;
    public short DAT_12;
}

public struct UNK_12FF0
{
    public uint DAT_00;
    public ushort DAT_04;
}

public class ST4 : LevelManager
{
    public static new ST4 instance;

    public FUN_B58BC[] DAT_1279C = new FUN_B58BC[20] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, 
                                                       FUN_45B08, null, FUN_46A1C, FUN_346C, null, null, 
                                                       FUN_45D38, FUN_45E70, null, null, null, FUN_3648, 
                                                       FUN_46814, FUN_3760, FUN_3828 };
    public FUN_B58C0[] DAT_127EC = new FUN_B58C0[8] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, FUN_252C, null, 
                                                      FUN_10E38, null, FUN_3AB8 };
    public FUN_C2570[] DAT_1280C = new FUN_C2570[8] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, 
                                                      null, null, FUN_7F808 };
    public FUN_C1CF8[] DAT_1282C = new FUN_C1CF8[25] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, 
                                                       FUN_21ECC, FUN_22178, null, null, null, FUN_222AC, 
                                                       FUN_22464, FUN_2268C, null, null, null, null, null, null, 
                                                       FUN_123F8, FUN_11328, FUN_1167C, FUN_11854, FUN_12140, FUN_123BC };
    public byte[][] DAT_1270C = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 12, 27, 15, 13, 13, 32, 25, 20, 20, 33, 30, 27, 24, 34, 31, 0, 27, 35, 0, 0, 0, 22, 0, 28, 28, 23, 0, 29, 29, 16, 0, 30, 30, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 10, 27, 0, 0, 0, 32, 25, 20, 20, 33, 30, 26, 24, 34, 31, 27, 27, 35, 0, 0, 0, 22, 0, 28, 28, 23, 0, 29, 29, 16, 0, 30, 30, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 10, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 6, 0, 0, 35, 0, 0, 0, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 16, 11, 11, 24, 31, 31, 31, 25, 0, 0, 0 }
    };
    public TrgScriptableObject DAT_1261C; //0x1261C (ST4)
    public uint[] DAT_12520 = new uint[63] { 0x0, 0x9, 0x80000016, 0x0, 0xc, 0x80000017, 0x0, 0x80000014, 0x0, 0x7, 0xd, 0x80000015, 0x0, 0xb, 0x80000016, 0x0, 0x9, 0x80000011, 0x0, 0x9, 0x80000013, 0x0, 0x4, 0x80000017, 0x0, 0xc, 0x80000014, 0x0, 0x80000023, 0x0, 0x80000010, 0x0, 0x80000013, 0x0, 0xc, 0x80000018, 0x0, 0x9, 0x80000015, 0x0, 0x80000015, 0x0, 0xe, 0x8000001d, 0x0, 0x5, 0xe, 0x8000001d, 0x0, 0xa, 0x80000013, 0x0, 0x80000013, 0x0, 0x80000010, 0x0, 0x7, 0x80000013, 0x0, 0x7, 0x80000014, 0x0, 0x8000000f };
    public CapsuleCollider[] DAT_12890 = new CapsuleCollider[] { }; //0x12890 (ST4)
    public short[] DAT_1295C = new short[] { }; //0x1295C (ST4)
    private short[] DAT_12964 = new short[] { }; //0x12964 (ST4)
    private UNK_12A20[] PTR_DAT_12A20; //0x12A20 (ST4)
    private UNK_12A50[] PTR_DAT_12A50; //0x12A50 (ST4)
    private UNK_12A20[] PTR_DAT_12B2C; //0x12B2C (ST4)
    private delegate void FUN_12DE0(CriPlayer p); //0x12DE0 (ST4)
    private FUN_12DE0[] PTR_FUN_12DE0; //0x12DE0 (ST4)
    private short[] DAT_12DEC = new short[] { }; //0x12E08 (ST4)
    private delegate void FUN_12E28(CriPlayer p); //0x12E28 (ST4)
    private delegate void FUN_12E60(CriPlayer p); //0x12E60 (ST4)
    private delegate void FUN_12E88(CriPlayer p); //0x12E88 (ST4)
    private delegate void FUN_12E90(CriPlayer p); //0x12E90 (ST4)
    private delegate void FUN_12EE0(CriPlayer p); //0x12EE0 (ST4)
    private delegate void FUN_12F0C(CriPlayer p); //0x12F0C (ST4)
    public delegate void FUN_12F38(CriPlayer p); //0x12F38 (ST4)
    private delegate void FUN_12F7C(CriPlayer p1, CriPlayer p2); //0x12F7C (ST4)
    private delegate void FUN_12FB8(CriPlayer p1, CriPlayer p2); //0x12FB8 (ST4)
    private delegate void FUN_12FCC(CriPlayer p); //0x12FCC (ST4)
    private delegate void FUN_12FDC(CriPlayer p); //0x12FDC (ST4)
    private delegate void FUN_12FE8(CriPlayer p); //0x12FE8 (ST4)
    public delegate void FUN_136B0(CriPlayer p); //0x136B0 (ST4)
    private delegate void FUN_136CC(CriPlayer p); //0x136CC (ST4)
    private delegate void FUN_136F0(CriPlayer p); //0x136F0 (ST4)
    private delegate void FUN_13714(CriPlayer p); //0x13714 (ST4)
    private delegate void FUN_1371C(CriPlayer p); //0x1371C (ST4)
    private delegate void FUN_13724(CriPlayer p); //0x13724 (ST4)
    private delegate void FUN_13734(CriPlayer p); //0x13734 (ST4)
    private delegate void FUN_13748(CriPlayer p); //0x13784 (ST4)
    private delegate void FUN_137A8(CriPlayer p); //0x137A8 (ST4)
    private delegate void FUN_137C4(CriPlayer p); //0x137C4 (ST4)
    private delegate void FUN_137D4(CriPlayer p); //0x137D4 (ST4)
    private delegate void FUN_13824(CriPlayer p); //0x13824 (ST4)
    private delegate void FUN_13828(CriPlayer p); //0x13828 (ST4)
    private delegate void FUN_13834(CriPlayer p); //0x13834 (ST4)
    private delegate void FUN_13860(CriPlayer p); //0x13860 (ST4)
    private delegate void FUN_1388C(CriPlayer p); //0x1388C (ST4)
    private delegate void FUN_13898(CriPlayer p); //0x13898 (ST4)
    private delegate void FUN_138A8(CriPlayer p); //0x138A8 (ST4)
    private delegate void FUN_138B8(CriPlayer p); //0x138B8 (ST4)
    private delegate bool FUN_13B7C(CriPlayer p); //0x13B7C (ST4)
    private delegate void FUN_13B94(CriPlayer p); //0x13B94 (ST4)
    private delegate void FUN_140B8(CriPlayer p); //0x140B8 (ST4)
    private delegate void FUN_140C4(CriPlayer p); //0x140C4 (ST4)
    private delegate void FUN_140D4(CriPlayer p); //0x140D4 (ST4)
    private delegate void FUN_140E4(CriPlayer p); //0x140E4 (ST4)
    private delegate void FUN_140FC(CriPlayer p, CriPlayer p2); //0x140FC (ST4)
    private delegate void FUN_1410C(CriPlayer p); //0x1410C (ST4)
    private delegate void FUN_14118(CriPlayer p); //0x14118 (ST4)
    private delegate void FUN_14120(CriPlayer p); //0x14120 (ST4)
    private delegate void FUN_14144(CriPlayer p); //0x14144 (ST4)
    public delegate void FUN_14194(CriPlayer p); //0x14194 (ST4)
    private byte[] DAT_12E24 = new byte[2] { 48, 49 }; //0x12E24 (ST4)
    private FUN_12E28[] PTR_FUN_12E28; //0x12E28 (ST4)
    private int[] DAT_12E38 = new int[10] { 10, 13, 11, 14, 12, 15, 16, 17, 6, 5 }; //0x12E38 (ST4)
    private FUN_12E60[] PTR_FUN_12E60; //0x12E60 (ST4)
    private int[] DAT_12E74 = new int[3] { 7, 8, 9 }; //0x12E74 (ST4)
    private short[] DAT_12E80 = new short[2] { -0x400, 0x400 }; //0x12E80 (ST4)
    private FUN_12E88[] PTR_FUN_12E88; //0x12E88 (ST4)
    private FUN_12E90[] PTR_FUN_12E90; //0x12E90 (ST4)
    private FUN_12EE0[] PTR_FUN_12EE0; //0x12EE0 (ST4)
    private FUN_12F0C[] PTR_FUN_12F0C; //0x12F0C (ST4)
    public FUN_12F38[] PTR_FUN_12F38; //0x12F38 (ST4)
    private int[] DAT_12F4C = new int[7] { 25, 28, 26, 29, 27, 30, 23 }; //0x12F4C (ST4)
    private FUN_12F7C[] PTR_FUN_12F7C; //0x12F7C (ST4)
    private int[] DAT_12F98 = new int[6] { 33, 35, 34, 36, 24, 37 }; //0x12F98 (ST4)
    private FUN_12FB8[] PTR_FUN_12FB8; //0x12FB8 (ST4)
    private FUN_12FCC[] PTR_FUN_12FCC; //0x12FCC (ST4)
    private int[] DAT_12FD4 = new int[2] { 38, 39 }; //0x12FD4 (ST4)
    private FUN_12FDC[] PTR_FUN_12FDC; //0x12FDC (ST4)
    private FUN_12FE8[] PTR_FUN_12FE8; //0x12FE8 (ST4)
    public UNK_12FF0[] PTR_DAT_12FF0; //0x12FF0 (ST4)
    public uint[] DAT_13034 = new uint[5] { 0x8010abbc, 0x8010abc4, 0x8010abcc, 0x8010abd4, 0x8010abdc };
    public uint[] DAT_13060 = new uint[3] { 0x8010eb80, 0x8010eb98, 0x8010ebb0 };
    public sbyte[] DAT_1306C = new sbyte[4] { -4, -2, 2, 4 };
    public CapsuleCollider[] DAT_1307C; //0x1307C (ST4)
    public FUN_136B0[] PTR_FUN_136B0; //0x136B0 (ST4)
    private FUN_136CC[] PTR_FUN_136CC; //0x136CC (ST4)
    private FUN_136F0[] PTR_FUN_136F0; //0x136F0 (ST4)
    private FUN_13714[] PTR_FUN_13714; //0x13714 (ST4)
    private FUN_1371C[] PTR_FUN_1371C; //0x1371C (ST4)
    private FUN_13724[] PTR_FUN_13724; //0x13724 (ST4)
    private FUN_13734[] PTR_FUN_13734; //0x13734 (ST4)
    private short[] DAT_1373C = new short[6] { 54, 110, 167, 225, 286, 346 }; //0x1373C (ST4)
    private FUN_13748[] PTR_FUN_13748; //0x13748 (ST4)
    private FUN_137A8[] PTR_FUN_137A8; //0x137A8 (ST4)
    private FUN_137C4[] PTR_FUN_137C4; //0x137C4 (ST4)
    private FUN_137D4[] PTR_FUN_137D4; //0x137D4 (ST4)
    private FUN_13824[] PTR_FUN_13824; //0x13824 (ST4)
    private FUN_13828[] PTR_FUN_13828; //0x13828 (ST4)
    private FUN_13834[] PTR_FUN_13834; //0x13834 (ST4)
    private FUN_13860[] PTR_FUN_13860; //0x13860 (ST4)
    private FUN_1388C[] PTR_FUN_1388C; //0x1388C (ST4)
    private FUN_13898[] PTR_FUN_13898; //0x13898 (ST4)
    private FUN_138A8[] PTR_FUN_138A8; //0x138A8 (ST4)
    private FUN_138B8[] PTR_FUN_138B8; //0x138B8 (ST4)
    private FUN_13B7C[] PTR_FUN_13B7C; //0x13B7C (ST4)
    private FUN_13B94[] PTR_FUN_13B94; //0x13B94 (ST4)
    private UNK_9B314[] PTR_DAT_13B9C; //0x13B9C (ST4)
    public CapsuleCollider[] DAT_13E24; //0x13E30 (ST4)
    private byte[] DAT_13E48 = new byte[2] { 48, 49 }; //0x13E48 (ST4)
    private byte[] DAT_13E4C = new byte[2] { 50, 51 }; //0x13E4C (ST4)
    private FUN_140B8[] PTR_FUN_140B8; //0x140B8 (ST4)
    private byte[] DAT_140C0 = new byte[2] { 56, 57 }; //0x140C0 (ST4)
    private FUN_140C4[] PTR_FUN_140C4; //0x140C4 (ST4)
    private FUN_140D4[] PTR_FUN_140D4; //0x140D4 (ST4)
    private int[] DAT_140DC = new int[2] { 5, 5 }; //0x140DC (ST4)
    private FUN_140E4[] PTR_FUN_140E4; //0x140E4 (ST4)
    private byte[] DAT_140EC = new byte[2] { 54, 55 }; //0x140EC (ST4)
    private int[] DAT_140F0 = new int[3] { 13, 3, 8 }; //0x140F0 (ST4)
    private FUN_140FC[] PTR_FUN_140FC; //0x140FC (ST4)
    private FUN_1410C[] PTR_FUN_1410C; //0x1410C (ST4)
    private FUN_14118[] PTR_FUN_14118; //0x14118 (ST4)
    private FUN_14120[] PTR_FUN_14120; //0x14120 (ST4)
    private FUN_14144[] PTR_FUN_14144; //0x14144 (ST4)
    public FUN_14194[] PTR_FUN_14194; //0x14194 (ST4)
    private uint[] PTR_DAT_141B0 = new uint[] { 0x8017D000, 0x8017E000, 0x8017F000 }; //0x141B0 (ST4)
    private byte[] PTR_DAT_145E0 = new byte[] { 4, 7, 45, 4, 8, 46, 4, 8, 47 }; //0x145E0 (ST4)
    private ushort DAT_1464C = 0; //0x1464C (ST4)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_12DE0 = new FUN_12DE0[3]
            {
                FUN_6CC,
                FUN_764,
                FUN_794
            };
            PTR_FUN_12E28 = new FUN_12E28[4]
            {
                FUN_F40,
                FUN_F78,
                FUN_1060,
                FUN_10BC
            };
            PTR_FUN_12E60 = new FUN_12E60[5]
            {
                FUN_1288,
                FUN_1304,
                FUN_147C,
                FUN_15CC,
                FUN_165C
            };
            PTR_FUN_12E88 = new FUN_12E88[2]
            {
                FUN_16F4,
                FUN_1790
            };
            PTR_FUN_12E90 = new FUN_12E90[4]
            {
                FUN_19D8,
                FUN_1A28,
                FUN_1AC4,
                FUN_1B00
            };
            PTR_FUN_12EE0 = new FUN_12EE0[6]
            {
                FUN_CF0,
                FUN_1B0,
                FUN_1B0,
                FUN_1B0,
                FUN_1B0,
                FUN_1B0
            };
            PTR_FUN_12F0C = new FUN_12F0C[4]
            {
                FUN_1180,
                FUN_199C,
                FUN_16B8, 
                FUN_1A88
            };
            PTR_FUN_12F38 = new FUN_12F38[2]
            {
                FUN_9AC, 
                FUN_2498
            };
            PTR_FUN_12F7C = new FUN_12F7C[7]
            {
                FUN_2A44,
                FUN_2ABC,
                FUN_2B7C,
                FUN_2C14,
                FUN_2C14,
                FUN_2C14,
                FUN_2CB8
            };
            PTR_FUN_12FB8 = new FUN_12FB8[5]
            {
                FUN_2D3C,
                FUN_2DDC,
                FUN_2EA4,
                FUN_2FDC,
                FUN_307C
            };
            PTR_FUN_12FCC = new FUN_12FCC[]
            {
                FUN_2CFC,
                FUN_30C0
            };
            PTR_FUN_12FDC = new FUN_12FDC[2]
            {
                FUN_3144,
                FUN_31A4
            };
            PTR_FUN_12FE8 = new FUN_12FE8[2]
            {
                FUN_313C,
                FUN_3238
            };
            PTR_FUN_136B0 = new FUN_136B0[]
            {
                FUN_3D4C,
                FUN_3FE0, 
                FUN_6B54, 
                FUN_7A14, 
                FUN_7C0C
            };
            PTR_FUN_136CC = new FUN_136CC[]
            {
                //...
            };
            PTR_FUN_136F0 = new FUN_136F0[]
            {
                FUN_4098, 
                FUN_43C8, 
                FUN_4C84, 
                FUN_51A0, 
                FUN_56F4, 
                FUN_5814
            };
            PTR_FUN_13714 = new FUN_13714[2]
            {
                FUN_4030,
                FUN_4078
            };
            PTR_FUN_1371C = new FUN_1371C[2]
            {
                FUN_40D4,
                FUN_4250
            };
            PTR_FUN_13724 = new FUN_13724[4]
            {
                FUN_4984, 
                FUN_4B90, 
                FUN_4BEC, 
                FUN_4C30
            };
            PTR_FUN_13734 = new FUN_13734[2]
            {
                FUN_4F04,
                FUN_5170
            };
            PTR_FUN_13748 = new FUN_13748[6]
            {
                FUN_5208,
                FUN_5294,
                FUN_53BC,
                FUN_5410,
                FUN_5594,
                FUN_55F4
            };
            PTR_FUN_137A8 = new FUN_137A8[]
            {
                FUN_6CF0, 
                FUN_70A0
            };
            PTR_FUN_137C4 = new FUN_137C4[4]
            {
                FUN_6B90,
                FUN_6BE8,
                FUN_6C44,
                FUN_6C9C
            };
            PTR_FUN_137D4 = new FUN_137D4[]
            {
                FUN_6D2C, 
                FUN_6E14
            };
            PTR_FUN_13824 = new FUN_13824[4]
            {
                FUN_7B94, 
                FUN_7A50, 
                FUN_7AC4, 
                FUN_4028
            };
            PTR_FUN_13828 = new FUN_13828[1]
            {
                FUN_7A50
            };
            PTR_FUN_13834 = new FUN_13834[]
            {
                //...
            };
            PTR_FUN_13860 = new FUN_13860[]
            {
                FUN_7C68, 
                FUN_7E18, 
                FUN_80F8
            };
            PTR_FUN_1388C = new FUN_1388C[2]
            {
                FUN_7C88, 
                FUN_7E04
            };
            PTR_FUN_13898 = new FUN_13898[4]
            {
                FUN_7E54,
                FUN_8004,
                FUN_8060,
                FUN_80A4
            };
            PTR_FUN_138A8 = new FUN_138A8[]
            {
                //...
            };
            PTR_FUN_138B8 = new FUN_138B8[]
            {

            };
            PTR_FUN_13B7C = new FUN_13B7C[6]
            {
                FUN_DC9C,
                FUN_DD04,
                FUN_DD70,
                FUN_DE04,
                FUN_DEB8,
                FUN_DF24
            };
            PTR_FUN_13B94 = new FUN_13B94[2]
            {
                FUN_E088,
                FUN_E118
            };
            PTR_FUN_140B8 = new FUN_140B8[2]
            {
                FUN_EE9C,
                FUN_EEE4
            };
            PTR_FUN_140C4 = new FUN_140C4[4]
            {
                FUN_F098,
                FUN_F138,
                FUN_F1A8,
                FUN_F20C
            };
            PTR_FUN_140D4 = new FUN_140D4[2]
            {
                FUN_F320,
                FUN_F38C
            };
            PTR_FUN_140E4 = new FUN_140E4[2]
            {
                FUN_F4C8,
                FUN_F5E0
            };
            PTR_FUN_140FC = new FUN_140FC[4]
            {
                FUN_FDD4,
                FUN_FECC, 
                FUN_FFA8, 
                FUN_1014C
            };
            PTR_FUN_1410C = new FUN_1410C[2]
            {
                FUN_10374,
                FUN_10400
            };
            PTR_FUN_14118 = new FUN_14118[2]
            {
                FUN_1054C,
                FUN_10584
            };
            PTR_FUN_14120 = new FUN_14120[9]
            {
                FUN_F7B4,
                FUN_FD30,
                FUN_EE08,
                FUN_F064,
                FUN_EBA4,
                FUN_EBA4, 
                FUN_F97C, 
                FUN_EBA4, 
                FUN_EBA4
            };
            PTR_FUN_14144 = new FUN_14144[9]
            {
                FUN_F880, 
                FUN_10284, 
                FUN_F028, 
                FUN_F2E4, 
                FUN_F734, 
                FUN_F48C, 
                FUN_FB94, 
                FUN_10510, 
                FUN_10628
            };
            PTR_FUN_14194 = new FUN_14194[2]
            {
                FUN_EBD8, 
                FUN_10664
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

    //FUN_1C (ST4)
    public override void Initialize()
    {
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_1279C;
        PTR_FUN_B58C0 = DAT_127EC;
        PTR_FUN_C2570 = DAT_1280C;
        PTR_FUN_C1CF8 = DAT_1282C;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        GameManager.instance.DAT_AC = DAT_1270C[uVar3];
        GameManager.instance.DAT_B0 = DAT_12520;
        GameManager.instance.DAT_46 = 4;

        for (int i = 0; i < DAT_1261C.TRIGGERS.Length; i++)
        {
            puVar4 = LevelManager.instance.DAT_9EEC[i];
            puVar5 = DAT_1261C.TRIGGERS[i];
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

        GameManager.instance.FUN_7669C(LevelManager.instance.DAT_9EEC, 4);
    }

    //FUN_1B0 (ST4)
    private void FUN_1B0(CriPlayer param1)
    {
        return;
    }

    //FUN_1B8 (ST4)
    private void FUN_1B8(CriPlayer param1)
    {
        byte bVar1;
        ushort uVar2;
        CriParticle oVar3;

        if (param1.DAT_60 == PTR_DAT_12B2C[param1.DAT_1D9].DAT_00)
        {
            do
            {
                oVar3 = SceneManager.instance.FUN_5FFA0();

                if (oVar3 != null)
                {
                    oVar3.tags = PTR_DAT_12B2C[param1.DAT_1D9].DAT_01;
                    oVar3.DAT_2F = PTR_DAT_12B2C[param1.DAT_1D9].DAT_02;
                    oVar3.DAT_4C = param1.PTR_1CC;
                    oVar3.screen = PTR_DAT_12B2C[param1.DAT_1D9].DAT_04;
                    uVar2 = PTR_DAT_12B2C[param1.DAT_1D9].DAT_0A;
                    oVar3.DAT_62 = uVar2;
                    oVar3.DAT_60 = uVar2;
                    oVar3.IDAT_6C = PTR_DAT_12B2C[param1.DAT_1D9].DAT_0C;
                }

                bVar1 = param1.DAT_1D9;
                param1.DAT_1D9 = (byte)(bVar1 + 1);
            } while (PTR_DAT_12B2C[param1.DAT_1D9].DAT_00 == param1.DAT_60);

            if (39 < bVar1 + 1)
                param1.DAT_1C0 &= 0xdfffffff;
        }
    }

    //FUN_2D8 (ST4)
    private void FUN_2D8(CriPlayer param1)
    {
        byte bVar1;
        ushort uVar2;
        CriParticle oVar3;
        CriObject oVar4;

        while (PTR_DAT_12A50[param1.DAT_1D9].DAT_00 < param1.DAT_60)
            param1.DAT_1D9++;

        if (param1.DAT_60 == PTR_DAT_12A50[param1.DAT_1D9].DAT_00)
        {
            do
            {
                oVar3 = SceneManager.instance.FUN_5FFA0();

                if (oVar3 != null)
                {
                    oVar3.tags = PTR_DAT_12A50[param1.DAT_1D9].DAT_01;
                    oVar3.DAT_2F = PTR_DAT_12A50[param1.DAT_1D9].DAT_02;
                    oVar4 = Utilities.FUN_601C8(param1.skeleton, PTR_DAT_12A50[param1.DAT_1D9].DAT_03);
                    oVar3.DAT_4C = oVar4;
                    oVar3.screen = PTR_DAT_12A50[param1.DAT_1D9].DAT_04;
                    uVar2 = PTR_DAT_12A50[param1.DAT_1D9].DAT_0A;
                    oVar3.DAT_62 = uVar2;
                    oVar3.DAT_60 = uVar2;
                    oVar3.DAT_40 = PTR_DAT_12A50[param1.DAT_1D9].DAT_0C;
                    oVar3.DAT_70.y = PTR_DAT_12A50[param1.DAT_1D9].DAT_12;
                }

                bVar1 = param1.DAT_1D9;
                param1.DAT_1D9 = (byte)(bVar1 + 1);
            } while (PTR_DAT_12A50[param1.DAT_1D9].DAT_00 == param1.DAT_60);

            if (10 < bVar1 + 1)
            {
                param1.DAT_1D9 = 0;
                param1.DAT_1C0 &= 0xfffffffd;
            }
        }
    }

    //FUN_460 (ST4)
    public void FUN_460(CriPlayer param1)
    {
        ushort uVar1;
        byte bVar2;
        CriParticle oVar3;
        CriObject oVar4;

        if (param1.DAT_1DA == PTR_DAT_12A20[param1.DAT_1D9].DAT_00)
        {
            oVar3 = SceneManager.instance.FUN_5FFA0();

            if (oVar3 != null)
            {
                oVar3.tags = PTR_DAT_12A20[param1.DAT_1D9].DAT_01;
                oVar3.DAT_2F = PTR_DAT_12A20[param1.DAT_1D9].DAT_02;
                oVar4 = Utilities.FUN_601C8(param1.skeleton, 3);
                oVar3.DAT_4C = oVar4;
                oVar3.screen = PTR_DAT_12A20[param1.DAT_1D9].DAT_04;
                uVar1 = PTR_DAT_12A20[param1.DAT_1D9].DAT_0A;
                oVar3.DAT_62 = uVar1;
                oVar3.DAT_60 = uVar1;
                oVar3.IDAT_6C = PTR_DAT_12A20[param1.DAT_1D9].DAT_0C;
            }

            bVar2 = (byte)(param1.DAT_1D9 + 1);
            param1.DAT_1D9 = bVar2;

            if (2 < bVar2)
            {
                param1.DAT_1C0 &= 0xbfffffff;
                param1.DAT_1D9 = 0;
            }
        }

        param1.DAT_1DA++;
    }

    //FUN_584 (ST4)
    private void FUN_584(CriPlayer param1)
    {
        short sVar1;
        CriObject oVar2;
        ushort uVar3;

        uVar3 = (ushort)(param1.SDAT_1FA + 0x400 & 0xfff);

        if (uVar3 < 0xc01)
        {
            if (uVar3 < 0x801)
                uVar3 = (ushort)Utilities.FUN_51D40(param1.SDAT_1FA, (short)param1.DAT_19E, param1.DAT_167);
            else
                uVar3 = param1.DAT_167;
        }
        else
            uVar3 = (ushort)-param1.DAT_167;

        sVar1 = Utilities.FUN_51D40(param1.SDAT_1F8, (short)param1.DAT_19C, param1.DAT_166);
        uVar3 = (ushort)(param1.DAT_19E + uVar3 & 0xfff);
        param1.DAT_19E = uVar3;
        param1.DAT_19C = (ushort)(param1.DAT_19C + sVar1 & 0xfff);

        if (uVar3 < 0x801)
        {
            if (0x200 < uVar3)
                param1.DAT_19E = 0x200;
        }
        else
        {
            if (uVar3 < 0xe00)
                param1.DAT_19E = 0xe00;
        }

        uVar3 = param1.DAT_19C;

        if (uVar3 < 0x801)
        {
            if (0x100 < uVar3)
                param1.DAT_19C = 0x100;
        }
        else
        {
            if (uVar3 < 0xf00)
                param1.DAT_19C = 0xf00;
        }

        oVar2 = Utilities.FUN_601C8(param1.skeleton, 2);
        oVar2.vr.x = param1.DAT_19C & 0xfff;
        oVar2.vr.y = param1.DAT_19E & 0xfff;
    }

    //FUN_6CC (ST4)
    private void FUN_6CC(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriObject oVar3;
        CriSkinned oVar4;

        oVar4 = param1.DAT_154;
        oVar3 = Utilities.FUN_601C8(param1.skeleton, 2);
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar4.screen);
        param1.SDAT_1FA = sVar1;
        sVar2 = (short)Utilities.FUN_61654(oVar3.screen, oVar4.screen, sVar1);
        param1.SDAT_1F8 = sVar2;
        param1.SDAT_1FA = (short)(param1.SDAT_1FA - param1.vr.y & 0xfff);
        FUN_584(param1);
    }

    //FUN_764 (ST4)
    private void FUN_764(CriPlayer param1)
    {
        if (param1.DAT_19C != 0)
            param1.DAT_19C = 0;

        if (param1.DAT_19E != 0)
            param1.DAT_19E = 0;
    }

    //FUN_794 (ST4)
    private void FUN_794(CriPlayer param1)
    {
        CriObject oVar1;

        oVar1 = Utilities.FUN_601C8(param1.skeleton, 2);
        param1.SDAT_1F8 = (short)oVar1.vr.x;
        param1.SDAT_1FA = (short)oVar1.vr.y;
        FUN_584(param1);
    }

    //FUN_7E8 (ST4)
    public void FUN_7E8(CriPlayer param1)
    {
        PTR_FUN_12DE0[param1.DAT_164](param1);
    }

    //FUN_824 (ST4)
    public void FUN_824(CriPlayer param1)
    {
        CriCamera cVar1;
        ushort uVar2;

        cVar1 = SceneManager.instance.cCamera;
        uVar2 = (ushort)(param1.UDAT_1D2 >> 8 & 0x7f);
        cVar1.DAT_38 += (short)(DAT_12DEC[(param1.UDAT_1D2 & 0xff) + 14] * uVar2);
        cVar1.DAT_3A += (short)(DAT_12DEC[param1.UDAT_1D2] * uVar2);
        uVar2 = (ushort)(param1.UDAT_1D2 + 1);
        param1.UDAT_1D2 = uVar2;

        if (13 < (uVar2 & 0xff))
            param1.UDAT_1D2 = 0;
    }

    //FUN_8C4 (ST4)
    private void FUN_8C4(CriPlayer param1)
    {
        byte bVar1;

        bVar1 = param1.frame.DAT_02;

        if (bVar1 != 0)
        {
            GameManager.FUN_64650();
            param1.UDAT_1D2 = 0x8100;
            GameManager.instance.FUN_5C94C(param1, DAT_12E24[bVar1 >> 1]);
        }
    }

    //FUN_930 (ST4)
    private void FUN_930(CriPlayer param1)
    {
        param1.DAT_3D = 8;
        param1.DAT_3E = 0;
        param1.DAT_40.z = 0;
        param1.DAT_164 = 1;
    }

    //FUN_9AC (ST4)
    private void FUN_9AC(CriPlayer param1)
    {
        ushort uVar2;
        CriObject oVar3;

        param1.health = 1000;
        param1.maxHealth = 1000;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_175 = 2;
        param1.DAT_3C++;
        param1.FUN_609C8(0, 1, 0);
        param1.DAT_3D = 4;
        param1.PTR_120 = DAT_12890;
        param1.DAT_120 = 0;
        param1.PTR_130 = DAT_12890;
        param1.DAT_130 = 16;
        param1.FUN_77784(1, DAT_12890[16].radius);
        param1.DAT_164 = 0;
        param1.DAT_19E = 0;
        param1.DAT_19C = 0;
        param1.DAT_166 = 10;
        param1.DAT_167 = 10;
        param1.FUN_66404(0, 0x4000, 0x7fff);
        param1.DAT_140 |= 1;
        uVar2 = 0xb22;

        if (GameManager.instance.DAT_A2D2 == 0)
            uVar2 = 0x41a;

        param1.DAT_1D0 = uVar2;
        param1.DAT_1C0 = 0;
        param1.DAT_1DF = 0;
        oVar3 = Utilities.FUN_601C8(param1.skeleton, 4);
        param1.PTR_1CC = oVar3;
        param1.DAT_1E7 = 1;
        param1.BDAT_1E8 = 0;
        param1.DAT_1DB = 0;
        param1.IDAT_1C4 = 0;
        GameManager.instance.PTR_FUN_148 = FUN_3100;
        GameManager.instance.PTR_FUN_14C = FUN_3274;
        param1.DAT_12E = 2;
        param1.PTR_124 = DAT_12890;
        param1.DAT_124 = 12;
        param1.DAT_154 = SceneManager.instance.DAT_27C[10];
        param1.DAT_12F = 4;
    }

    //FUN_B1C (ST4)
    private void FUN_B1C(CriPlayer param1)
    {
        short sVar1;
        ushort uVar2;
        ushort uVar3;

        if ((param1.DAT_11E & 0x80) == 0)
            return;

        param1.DAT_11E &= 0x7f;
        uVar3 = (ushort)(param1.DAT_1A1 & 0xf);
        uVar2 = (ushort)(param1.DAT_1A0 >> 4 & 0xf);

        if (uVar2 == 2)
        {
            if (uVar3 == 7)
                sVar1 = (short)(param1.health - 67);
            else
                sVar1 = (short)(param1.health - 50);
        }
        else
        {
            if (uVar2 < 3)
            {
                if (uVar2 != 1) goto LAB_BDC;

                if (uVar3 < 6 && 1 < uVar3)
                    return;

                sVar1 = (short)(param1.health - 100);
            }
            else
            {
                if (uVar2 != 3) goto LAB_BDC;

                sVar1 = (short)(param1.health - 350);
            }
        }

        param1.health = sVar1;

        LAB_BDC:
        if (param1.health < 1)
        {
            param1.health = 1;
            param1.DAT_1C0 |= 1;
        }

        if ((param1.DAT_1C0 & 0x40000000) == 0)
        {
            param1.DAT_1C0 |= 0x40000000;
            param1.DAT_1D9 = 0;
            param1.DAT_1DA = 0;
        }

        if (param1.DAT_3D != 3 && param1.DAT_3D == 2)
        {
            param1.DAT_3D = 3;
            param1.DAT_11C = 0;
            param1.DAT_3E = 0;
        }
    }

    //FUN_CF0 (ST4)
    private void FUN_CF0(CriPlayer param1)
    {
        sbyte sVar1;
        bool bVar2;
        sbyte sVar3;
        byte bVar4;
        bool bVar5;
        int iVar5;

        if (55 < param1.DAT_148)
            param1.DAT_1C0 |= 0x10;

        if ((param1.DAT_1C0 & 0x10) != 0)
        {
            sVar1 = (sbyte)param1.frame.DAT_01;

            if (sVar1 == 59)
            {
                param1.DAT_3D = 5;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_3A = 1;
                return;
            }

            if (sVar1 == 11)
            {
                param1.DAT_3D = 5;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_3A = 0;
                return;
            }
        }

        bVar2 = false;

        if (param1.DAT_148 < 5)
            bVar2 = 60 < param1.DAT_1F2;

        if (!bVar2 && 8 < param1.DAT_148 - 6)
            return;

        if (param1.IDAT_1C4 != 0)
            return;

        if (param1.DAT_154.DAT_3C == 5)
            return;

        bVar5 = Utilities.FUN_64C0C(param1.screen, param1.DAT_154.screen, (short)param1.vr.y, 0x180);

        if (!bVar5)
            return;

        param1.DAT_1DB = 0;

        if (34 < param1.frame.DAT_01) goto LAB_E94;

        bVar5 = Utilities.FUN_64C0C(param1.PTR_1CC.screen, param1.DAT_154.screen, (short)param1.vr.y, 0x200);
        sVar3 = 2;

        if (!bVar5)
        {
            bVar5 = Utilities.FUN_64C0C(param1.PTR_1CC.screen, param1.DAT_154.screen, (short)(param1.vr.y + 0x500 & 0xfff), 0x300);

            if (bVar5)
            {
                param1.DAT_1DB = 0;
                goto LAB_E94;
            }

            bVar5 = Utilities.FUN_64C0C(param1.PTR_1CC.screen, param1.DAT_154.screen, (short)(param1.vr.y - 0x500 & 0xfff), 0x300);
            sVar3 = 1;

            if (!bVar5) goto LAB_E94;
        }

        param1.DAT_1DB = sVar3;

        LAB_E94:
        if (param1.DAT_1DB != -1)
        {
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_164 = 2;

            if (2 < param1.DAT_1DF)
            {
                iVar5 = (int)GameManager.FUN_64650();

                if ((0xd1 >> (iVar5 % 7 & 0x1f) & 1) != 0)
                {
                    param1.DAT_1DF = 0;
                    param1.DAT_3D = 2;
                    bVar4 = (byte)GameManager.FUN_64650();
                    param1.DAT_1DB = (sbyte)(bVar4 & 1);
                }
            }
        }
    }

    //FUN_F40 (ST4)
    private void FUN_F40(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(0, 1, 0);
    }

    //FUN_F78 (ST4)
    private void FUN_F78(CriPlayer param1)
    {
        sbyte sVar1;

        FUN_8C4(param1);

        if (param1.frame.DAT_01 == 13)
            param1.DAT_164 = 0;

        param1.FUN_60AB4();
        param1.DAT_40.z = DAT_12964[param1.frame.DAT_01];

        if (param1.frame.DAT_01 == 20)
        {
            sVar1 = (sbyte)(param1.DAT_1E7 - 1);
            param1.DAT_1E7 = sVar1;

            if (sVar1 == -1 && 10000 < param1.IDAT_1C8)
            {
                param1.DAT_40.z = 0;
                param1.DAT_3E++;
                param1.FUN_609C8(3, 0, 0);
                param1.DAT_1E7 = 4;
            }
        }
    }

    //FUN_1060 (ST4)
    private void FUN_1060(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3E++;
            param1.FUN_6103C(0, 1, 19, 0);
        }
    }

    //FUN_10BC (ST4)
    private void FUN_10BC(CriPlayer param1)
    {
        bool bVar1;
        int iVar1;

        FUN_8C4(param1);
        param1.DAT_40.z = DAT_12964[param1.frame.DAT_01];
        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            if (param1.IDAT_1C8 < 0xfa1)
                param1.DAT_3E = 1;
            else
            {
                iVar1 = (int)GameManager.FUN_64650();

                if ((0x6c >> (iVar1 % 7 & 0x1f) & 1) != 0)
                {
                    param1.DAT_3D = 4;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_164 = 0;
                }
            }
        }
    }

    //FUN_1180 (ST4)
    private void FUN_1180(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriObject oVar3;
        int iVar3;
        int iVar4;
        uint uVar5;
        CriSkinned oVar6;

        oVar6 = param1.DAT_154;
        oVar3 = Utilities.FUN_601C8(param1.skeleton, 3);
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);

        if (param1.DAT_10C.x == oVar6.screen.x)
        {
            iVar4 = 10;

            if (param1.DAT_10C.z != oVar6.screen.z) goto LAB_1228;

            iVar3 = Utilities.FUN_615EC(oVar3.screen, oVar6.screen);

            if ((iVar3 - param1.vr.y & 0xfff) - 0x201 < 0xbff)
            {
                uVar5 = GameManager.FUN_64650();
                iVar4 = (int)(uVar5 & 15) + 35;
                goto LAB_1228;
            }
        }

        iVar4 = 10;
        LAB_1228:
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, (uint)iVar4, sVar1);
        param1.vr.y += sVar2;
        PTR_FUN_12E28[param1.DAT_3E](param1);
    }

    //FUN_1288 (ST4)
    private void FUN_1288(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_12E38[param1.DAT_1DB], 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1C0 &= 0x7fffffff;
        GameManager.instance.FUN_5C94C(param1, 50);
    }

    //FUN_1304 (ST4)
    private void FUN_1304(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;

        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        GameManager.FUN_64650();
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 10, sVar1);
        param1.vr.y += sVar2;
        bVar3 = param1.FUN_60AB4();

        if (!bVar3)
        {
            if (param1.frame.DAT_02 != 0)
            {
                param1.PTR_120 = DAT_12890;
                param1.DAT_120 = 7;
                bVar3 = SceneManager.instance.FUN_802B8(param1, false, 1);

                if (bVar3)
                    param1.DAT_1C0 |= 0x80000000;
            }
        }
        else
        {
            param1.DAT_3E++;

            if (param1.DAT_1C0 < 0)
            {
                param1.FUN_609C8(DAT_12E38[param1.DAT_1DB + 2], 0, 0);
                param1.DAT_1C0 |= 0x20000000;
                param1.DAT_1D9 = 0;
                param1.DAT_1DA = 0;
                FUN_27AC((CriPlayer)param1.DAT_154, param1, 100);
            }
            else
                param1.FUN_609C8(DAT_12E38[param1.DAT_1DB + 4], 0, 0);
        }
    }

    //FUN_147C (ST4)
    private void FUN_147C(CriPlayer param1)
    {
        bool bVar1;
        int iVar2;
        byte bVar3;
        byte bVar4;

        if (param1.DAT_1C0 < 0)
        {
            param1.FUN_65714();

            if (param1.frame.DAT_01 == 15)
                GameManager.instance.FUN_5C94C(param1, 51);
        }

        if ((param1.DAT_1C0 & 0x20000000) != 0)
            FUN_1B8(param1);

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            if ((int)param1.DAT_1C0 < 0)
            {
                bVar3 = 0;

                if (param1.IDAT_1C8 < 4001)
                {
                    param1.DAT_3E += 2;
                    param1.FUN_609C8(DAT_12E38[param1.DAT_1DB + 6], 0, 0);
                    return;
                }

                param1.DAT_3E++;
                iVar2 = DAT_12E38[param1.DAT_1DB + 8];
                bVar4 = 10;
            }
            else
            {
                iVar2 = 0;
                bVar3 = 1;
                bVar4 = 19;
                param1.DAT_3D = 0;
                param1.DAT_3E = 3;
            }

            param1.FUN_6103C(iVar2, bVar3, bVar4, 0);
        }
    }

    //FUN_15CC (ST4)
    private void FUN_15CC(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;

        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 5, sVar1);
        param1.vr.y += sVar2;
        FUN_8C4(param1);
        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_164 = 0;
        }

        param1.DAT_40.z = DAT_12964[param1.frame.DAT_01];
    }

    //FUN_165C (ST4)
    private void FUN_165C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3D = 0;
            param1.DAT_3E = 3;
            param1.FUN_6103C(0, 1, 19, 0);
        }
    }

    //FUN_16B8 (ST4)
    private void FUN_16B8(CriPlayer param1)
    {
        PTR_FUN_12E60[param1.DAT_3E](param1);
    }

    //FUN_16F4 (ST4)
    private void FUN_16F4(CriPlayer param1)
    {
        param1.DAT_1C0 &= 0x7fffffff;
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_12E74[param1.DAT_1DB], 0, 10);
        param1.DAT_1D9 = 0;
        param1.DAT_1C0 &= 0xfffffffd;
        GameManager.instance.FUN_5C94C(param1, 52);
        param1.DAT_164 = 2;
    }

    //FUN_1790 (ST4)
    private void FUN_1790(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        uint uVar3;
        bool bVar4;

        FUN_8C4(param1);

        if ((param1.DAT_1C0 & 2) != 0)
            FUN_2D8(param1);

        if (45 < param1.frame.DAT_01)
        {
            sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
            uVar3 = GameManager.FUN_64650();
            sVar2 = (short)Utilities.FUN_64838(param1.vr.y, (uVar3 & 0xf) + 10, sVar1);
            param1.vr.y += sVar2;
        }

        if (-1 < (int)param1.DAT_1C0 && param1.frame.DAT_03 != 0)
        {
            param1.PTR_120 = DAT_12890;
            param1.DAT_120 = 9;
            bVar4 = SceneManager.instance.FUN_802B8(param1, true, 1);

            if (bVar4)
            {
                param1.BDAT_1E8++;
                param1.DAT_3F++;
                param1.DAT_1C0 |= 0x80000000;
                param1.UDAT_1E0 = (ushort)(param1.vr.y + DAT_12E80[param1.DAT_1DB] & 0xfff);
                FUN_27AC((CriPlayer)param1.DAT_154, param1, (byte)param1.DAT_1DB + 9U);

                if (param1.DAT_1DB == 2)
                    param1.DAT_1C0 |= 2;
            }
        }

        param1.DAT_40.z = DAT_12964[param1.frame.DAT_01];
        bVar4 = param1.FUN_60AB4();

        if (bVar4)
        {
            if (param1.BDAT_1E8 == 3)
            {
                param1.DAT_3D = 4;
                param1.DAT_3E = 0;
                param1.BDAT_1E8 = 0;
            }
            else
            {
                param1.DAT_3D = 0;
                param1.DAT_3E = 1;
                param1.FUN_609C8(0, 1, 0);
                param1.DAT_164 = 0;
            }

            param1.DAT_1DF++;
        }
    }

    //FUN_199C (ST4)
    private void FUN_199C(CriPlayer param1)
    {
        PTR_FUN_12E88[param1.DAT_3E](param1);
    }

    //FUN_19D8 (ST4)
    private void FUN_19D8(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(2, 0, 0);
        param1.DAT_40.z = 0;
        GameManager.instance.FUN_5C94C(param1, 54);
    }

    //FUN_1A28 (ST4)
    private void FUN_1A28(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3D = 0;
            param1.DAT_3E = 3;
            param1.FUN_6103C(0, 1, 19, 0);
            param1.DAT_164 = 0;
        }
    }

    //FUN_1A88 (ST4)
    private void FUN_1A88(CriPlayer param1)
    {
        PTR_FUN_12E90[param1.DAT_3E](param1);
    }

    //FUN_1AC4 (ST4)
    private void FUN_1AC4(CriPlayer param1)
    {
        param1.DAT_40.z = 0;
        param1.DAT_3E++;
        param1.FUN_609C8(4, 0, 0);
    }

    //FUN_1B00 (ST4)
    private void FUN_1B00(CriPlayer param1)
    {
        bool bVar1;

        if (param1.frame.DAT_01 == 60)
            GameManager.instance.FUN_5C94C(param1, 53);

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3D = 0;
            param1.DAT_3E = 3;
            param1.FUN_6103C(0, 1, 19, 0);
            param1.DAT_164 = 0;
        }
    }

    //FUN_2498 (ST4)
    private void FUN_2498(CriPlayer param1)
    {
        int iVar1;
        CriSkinned oVar2;

        oVar2 = param1.DAT_154;
        FUN_B1C(param1);
        iVar1 = (int)Utilities.FUN_631AC(param1.PTR_1CC.screen, oVar2.screen);
        param1.IDAT_1C8 = iVar1;
        PTR_FUN_12EE0[param1.DAT_3D](param1);
        PTR_FUN_12F0C[param1.DAT_3D](param1);
    }

    //FUN_2768 (ST4)
    private void FUN_2768(CriPlayer param1, CriPlayer param2)
    {
        param1.DAT_3C = 1;
        param1.DAT_3D = 0;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_152 = 0;
        param1.DAT_11E &= 0x7f;
        param1.DAT_12C &= 0xffbf;
        param1.DAT_140 &= 0xfffd;
        param1.DAT_98 = param1.DAT_1E0;
    }

    //FUN_27AC (ST4)
    public void FUN_27AC(CriPlayer param1, CriPlayer param2, uint param3)
    {
        bool bVar1;
        short sVar2;
        short sVar3;
        uint uVar4;
        int iVar5;
        CriObject oVar5;
        Vector3Int local_40;
        Matrix3x3 auStack56;

        uVar4 = param3 & 0xff;
        param1.DAT_3C = 5;
        param1.DAT_3D = 1;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        iVar5 = 0;

        if (uVar4 < 8)
        {
            if (uVar4 < 5)
            {
                if (uVar4 != 0)
                {
                    if (uVar4 < 3 || uVar4 == 4)
                    {
                        iVar5 = (int)((param3 & 0xfe) + ((param3 & 0xff) >> 7));
                        auStack56 = new Matrix3x3();
                        Utilities.RotMatrix_gte(ref param2.vr, ref auStack56);
                        local_40 = Utilities.ApplyMatrixSV(ref auStack56, ref DAT_12890[iVar5].pos);
                        oVar5 = Utilities.FUN_601C8(param2.skeleton, DAT_12890[iVar5].bone);
                        local_40.x += oVar5.screen.x;
                        local_40.y += oVar5.screen.y;
                        local_40.z += oVar5.screen.z;
                        sVar2 = param1.FUN_64804(local_40);
                        iVar5 = 3;
                        param2.DAT_1DD = (byte)((sVar2 + 0x400 & 0xfff) < 0x800 ? 1 : 0);
                    }

                    goto LAB_2980;
                }
            }
            else
            {
                sVar2 = param1.FUN_64804(param2.screen);
                bVar1 = (sVar2 + 0x400 & 0xfff) < 0x800;
                param2.DAT_1DD = (byte)(bVar1 ? 1 : 0);

                if (bVar1)
                    sVar3 = (short)(param2.UDAT_1E0 + 0x800 & 0xfff);
                else
                    sVar3 = (short)param2.UDAT_1E0;

                param1.vr.y = sVar3;
            }

            iVar5 = 0;
        }
        else
        {
            if (uVar4 == 8)
            {
                sVar2 = param1.FUN_64804(param2.screen);
                param2.DAT_1DD = (byte)((sVar2 + 0x400 & 0xfff) < 0x800 ? 1 : 0);
                iVar5 = 1;
            }
            else
            {
                if (uVar4 == 100)
                {
                    param1.DAT_3C = 5;
                    param1.DAT_3D = 0;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_152 = 1;
                    param1.vr.y = param2.vr.y;
                    param2.FUN_656EC();
                    iVar5 = 2;
                }
                else
                    iVar5 = 0;
            }
        }

        LAB_2980:
        param1.DAT_154 = param2;
        param1.DAT_11E |= 0x80;
        param1.DAT_1E0 = param1.DAT_98;
        param1.DAT_98 = param2.DAT_98;
        param1.health -= DAT_1295C[iVar5];
        param1.FUN_4FE30();

        if (param1.health < 1)
            param1.health = 0;

        //FUN_1D988
    }

    //FUN_2A44 (ST4)
    private void FUN_2A44(CriPlayer param1, CriPlayer param2)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_12F4C[param2.DAT_1DB], 0, 0);
        param1.DAT_12C |= 0x40;
        param1.FUN_65714();
        param1.DAT_1C0 &= 0xfffffffe;
    }

    //FUN_2ABC (ST4)
    private void FUN_2ABC(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        bool bVar2;

        param1.FUN_65714();
        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(DAT_12F4C[param2.DAT_1DB], 0, 0);
            param1.DAT_40 = new Vector3Int(0, 0, 400);
            sVar1 = 0x400;

            if (param2.DAT_1DB == 0)
                sVar1 = -0x400;

            param1.vr.y += sVar1;
            param1.DAT_152 = 0;
            param1.screen.y += 0x1f7;
            param1.DAT_140 &= 0x7fff;
        }
    }

    //FUN_2B7C (ST4)
    private void FUN_2B7C(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        bool bVar2;

        sVar1 = (short)(param1.DAT_40.z - 15);
        param1.DAT_40.z = sVar1;

        if ((sVar1 << 0x10) < 0)
            param1.DAT_40.z = 0;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(DAT_12F4C[param2.DAT_1DB], 0, 0);
        }
    }

    //FUN_2C14 (ST4)
    private void FUN_2C14(CriPlayer param1, CriPlayer param2)
    {
        byte bVar1;
        bool bVar2;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_40.z = 0;

            if (param1.health == 0)
                FUN_930(param2);
            else
            {
                bVar1 = param1.DAT_3E;
                param1.DAT_3E = (byte)(bVar1 + 1);
                param1.FUN_609C8(DAT_12F4C[bVar1 * 2], (byte)DAT_12F4C[(bVar1 << 3 | 4) / 4], 0);
            }
        }
    }

    //FUN_2CB8 (ST4)
    private void FUN_2CB8(CriPlayer param1, CriPlayer param2)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            FUN_2768(param1, param2);
    }

    //FUN_2CFC (ST4)
    private void FUN_2CFC(CriPlayer param1)
    {
        PTR_FUN_12F7C[param1.DAT_3E](param1, (CriPlayer)param1.DAT_154);
    }

    //FUN_2D3C (ST4)
    private void FUN_2D3C(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;

        param1.DAT_12C |= 0x40;
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_12F98[param2.DAT_1DD], 0, 0);
        sVar1 = 250;

        if (param2.DAT_1DD != 0)
            sVar1 = -250;

        param1.DAT_40.z = sVar1;
        GameManager.instance.FUN_5C94C(param1, 3);
        param1.DAT_1C0 &= 0xfffffffe;
    }

    //FUN_2DDC (ST4)
    private void FUN_2DDC(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        bool bVar2;

        if (param2.DAT_1DD == 0)
        {
            sVar1 = (short)(param1.DAT_40.z - 10);

            if (param1.DAT_40.z != 0)
            {
                param1.DAT_40.z = sVar1;
                goto LAB_2E38;
            }
        }
        else
        {
            sVar1 = (short)(param1.DAT_40.z + 10);

            if (param1.DAT_40.z != 0)
            {
                param1.DAT_40.z = sVar1;
                goto LAB_2E38;
            }
        }

        sVar1 = 0;
        LAB_2E38:
        param1.DAT_40.z = sVar1;
        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(DAT_12F98[param2.DAT_1DD + 2], 0, 0);
            param1.DAT_112 = 30;
        }
    }

    //FUN_2EA4 (ST4)
    private void FUN_2EA4(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;

        if (param1.frame.DAT_01 == 3)
            GameManager.instance.FUN_5C94C(param1, 5);

        if (param2.DAT_1DD == 0)
        {
            sVar1 = (short)(param1.DAT_40.z - 4);

            if (param1.DAT_40.z != 0)
            {
                param1.DAT_40.z = sVar1;
                goto LAB_2F20;
            }
        }
        else
        {
            sVar1 = (short)(param1.DAT_40.z + 4);

            if (param1.DAT_40.z != 0)
            {
                param1.DAT_40.z = sVar1;
                goto LAB_2F20;
            }
        }

        sVar1 = 0;
        LAB_2F20:
        param1.DAT_40.z = sVar1;
        param1.FUN_60AB4();
        sVar1 = param1.DAT_112;
        param1.DAT_112 = (short)(sVar1 - 1);

        if (sVar1 == 1)
        {
            param1.DAT_40.z = 0;

            if (param1.health == 0)
                FUN_930(param2);
            else
            {
                param1.DAT_3E++;
                param1.FUN_609C8(DAT_12F98[param2.DAT_1DD + 4], 0, 0);

                if (param2.DAT_1DD != 0)
                    param1.DAT_5C |= 8;
            }
        }
    }

    //FUN_2FDC (ST4)
    private void FUN_2FDC(CriPlayer param1, CriPlayer param2)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            if (param2.DAT_1DD == 0)
            {
                param1.DAT_3E++;
                param1.FUN_609C8(DAT_12F98[param2.DAT_1DD + 6], 6, 0);
            }
            else
                FUN_2768(param1, param2);
        }
    }

    //FUN_307C (ST4)
    private void FUN_307C(CriPlayer param1, CriPlayer param2)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            FUN_2768(param1, param2);
    }

    //FUN_30C0 (ST4)
    private void FUN_30C0(CriPlayer param1)
    {
        PTR_FUN_12FB8[param1.DAT_3E](param1, (CriPlayer)param1.DAT_154);
    }

    //FUN_3100 (ST4)
    private void FUN_3100(CriPlayer param1)
    {
        PTR_FUN_12FCC[param1.DAT_3D](param1);
    }

    //FUN_313C (ST4)
    private void FUN_313C(CriPlayer param1)
    {
        return;
    }

    //FUN_3144 (ST4)
    private void FUN_3144(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(DAT_12FD4[((CriPlayer)param1.DAT_154).BDAT_1EC], 0, 0);
        param1.FUN_65714();
    }

    //FUN_31A4 (ST4)
    private void FUN_31A4(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.FUN_65714();
    }

    //FUN_3238 (ST4)
    private void FUN_3238(CriPlayer param1)
    {
        PTR_FUN_12FDC[param1.DAT_3E](param1);
    }

    //FUN_3274 (ST4)
    private void FUN_3274(CriPlayer param1)
    {
        PTR_FUN_12FE8[param1.DAT_3D](param1);
    }

    //FUN_3608 (ST4)
    public byte FUN_3608(CriParticle param1)
    {
        byte bVar1;
        byte bVar2;

        bVar1 = param1.DAT_2F;
        bVar2 = (byte)(bVar1 >> 4 & 7);
        param1.DAT_2F = bVar2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (bVar2 < 5)
        {
            param1.DAT_40.y = 10;
            param1.DAT_68 = 9;
        }

        return (byte)(bVar1 & 0xf);
    }

    //FUN_3D4C (ST4)
    private void FUN_3D4C(CriPlayer param1)
    {
        bool bVar1;
        int iVar2;
        uint uVar3;

        param1.skinSize = new Vector3Int(0x1000, 0x1000, 0x1000);
        param1.PTR_124 = DAT_1307C;
        param1.DAT_124 = 0;
        param1.PTR_120 = DAT_1307C;
        param1.DAT_120 = 0;
        param1.PTR_130 = DAT_1307C;
        param1.DAT_130 = 4;
        param1.DAT_12F = 2;
        param1.DAT_12E = 2;
        param1.DAT_1A2 = true;
        param1.DAT_18D = true;
        param1.DAT_175 = 1;
        param1.DAT_3D = 0;
        param1.BDAT_1C0 = 0;
        param1.DAT_3C++;

        if (param1.maxHealth == 0)
            FUN_CA78(param1);

        param1.health = param1.maxHealth;

        if (param1.DAT_196 < 1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 3;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.screen.y = -5000;
            param1.UDAT_1DA = 150;
            param1.SDAT_1D4 = 150;
            param1.SDAT_1D8 = 0;
            param1.DAT_1D6 = 0;
            param1.DAT_196 = 0;
        }
        else
        {
            param1.DAT_3C = 5;
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.screen.y = 0;
        }

        param1.DAT_199 = 0;
        param1.DAT_194 = 0;
        //...
        param1.DAT_1C7 = 0;
        param1.DAT_1D2 = 0;
        param1.DAT_1CD = 0;
        param1.DAT_140 |= 1;
        iVar2 = (int)GameManager.FUN_64650();
        uVar3 = 0;
        param1.V2_1F4.y = iVar2 + (iVar2 / 80) * -80 + 80;
        param1.FUN_65CF8(0, 10, 10);
        param1.FUN_66404(0, 0x4000, 0x2000);
        param1.FUN_66460(true);

        do
        {
            if ((param1.DAT_19A >> (int)(uVar3 & 31) & 1) != 0)
            {
                bVar1 = FUN_E4E8(param1, (byte)(uVar3 >> 2), (byte)(uVar3 & 3));

                if (bVar1)
                    param1.DAT_199++;
            }

            uVar3++;
        } while ((uVar3 & 0xff) < 0x10);

        param1.FUN_609C8(1, 1, 0);
    }

    //FUN_3F24 (ST4)
    private void FUN_3F24(CriPlayer param1)
    {
        short sVar1;

        sVar1 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

        if (sVar1 != 0x201 && sVar1 != 0x501 && sVar1 != 0x701)
            FUN_3FA4(param1);
    }

    //FUN_3F64 (ST4)
    public void FUN_3F64(CriPlayer param1)
    {
        short sVar1;

        sVar1 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

        if (sVar1 == 0x201 || sVar1 == 0x501 || sVar1 == 0x701)
            FUN_3FA4(param1);
    }

    //FUN_3FA4 (ST4)
    private void FUN_3FA4(CriPlayer param1)
    {
        PTR_FUN_136CC[param1.DAT_3D](param1);
    }

    //FUN_3FE0 (ST4)
    private void FUN_3FE0(CriPlayer param1)
    {
        FUN_3F24(param1);
        PTR_FUN_136F0[param1.DAT_3D](param1);
    }

    //FUN_4028 (ST4)
    private void FUN_4028(CriPlayer param1)
    {
        return;
    }

    //FUN_4030 (ST4)
    private void FUN_4030(CriPlayer param1)
    {
        param1.FUN_609C8(0, 1, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_4078 (ST4)
    private void FUN_4078(CriPlayer param1)
    {
        param1.FUN_60AB4();
    }

    //FUN_4098 (ST4)
    private void FUN_4098(CriPlayer param1)
    {
        PTR_FUN_13714[param1.DAT_3E](param1);
    }

    //FUN_40D4 (ST4)
    private void FUN_40D4(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        param1.FUN_609C8(14, 1, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1EA = 200;
        local_38 = new Vector3Int(0, param1.vr.y, 0);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref auStack48);
        local_38 = new Vector3Int(0, 0, param1.DAT_1EA);
        local_38 = Utilities.ApplyMatrixSV(ref auStack48, ref local_38);
        param1.screen.x += local_38.x;
        param1.screen.y += local_38.y;
        param1.screen.z += local_38.z;
        iVar2 = (int)GameManager.FUN_64650();
        sVar1 = (short)Utilities.FUN_64838(param1.vr.x, (uint)((iVar2 % 0xf + 10) * 0x10000 >> 0x10), 0);
        param1.vr.x = param1.vr.x + sVar1 & 0xfff;
        iVar2 = (int)GameManager.FUN_64650();
        sVar1 = (short)Utilities.FUN_64838(param1.vr.z, (uint)((iVar2 % 0xf + 10) * 0x10000 >> 0x10), 0);
        param1.vr.z = param1.vr.z + sVar1 & 0xfff;
        param1.DAT_3E++;
    }

    //FUN_4250 (ST4)
    private void FUN_4250(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        bool bVar2;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        local_38 = new Vector3Int(0, param1.vr.y, 0);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref auStack48);
        local_38 = new Vector3Int(0, 0, param1.DAT_1EA);
        param1.screen.x += local_38.x;
        param1.screen.y += local_38.y;
        param1.screen.z += local_38.z;
        iVar2 = (int)GameManager.FUN_64650();
        sVar1 = (short)Utilities.FUN_64838(param1.vr.x, (uint)((iVar2 % 0xf + 0x14) * 0x10000 >> 0x10), 0);
        param1.vr.x = param1.vr.x + sVar1 & 0xfff;
        iVar2 = (int)GameManager.FUN_64650();
        sVar1 = (short)Utilities.FUN_64838(param1.vr.z, (uint)((iVar2 % 0xf + 0x14) * 0x10000 >> 0x10), 0);
        param1.vr.z = param1.vr.z + sVar1 & 0xfff;

        if (param1.DAT_60 == 3)
            GameManager.instance.FUN_5C94C(param1, 48);
    }

    //FUN_43C8 (ST4)
    private void FUN_43C8(CriPlayer param1)
    {
        PTR_FUN_1371C[param1.DAT_3E](param1);
    }

    //FUN_46B4 (ST4)
    private bool FUN_46B4(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        short sVar3;
        bool bVar3;
        int iVar4;
        CriSkinned oVar4;
        int iVar5;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        oVar4 = SceneManager.instance.DAT_27C[10];
        FUN_CF30(param1);
        iVar5 = param1.DAT_1E8 + param1.DAT_1E6;
        param1.DAT_1E8 = (ushort)iVar5;

        if (param1.screen.y < param1.SDAT_1DC && iVar5 * 0x10000 < 0)
        {
            if (param1.DAT_1C2 == 2)
            {
                if (param1.DAT_3C == 4 && param1.DAT_3D == 2)
                {
                    param1.DAT_3C = 4;
                    param1.DAT_3D = 3;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                {
                    if (param1.DAT_3C == 1 && param1.DAT_3C == 2)
                        param1.DAT_1C3 = 1;
                    else
                        param1.DAT_1C3 = 0;

                    param1.DAT_3C = 1;
                    param1.DAT_3D = 6;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
            }
            else
            {
                param1.DAT_3C = 1;
                param1.DAT_3D = 3;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.UDAT_1DA = 150;
                param1.SDAT_1D4 = 150;
                param1.SDAT_1D8 = 0;
                param1.SDAT_1D6 = 0;
                GameManager.instance.FUN_65CB0(param1);
            }

            bVar3 = true;
            param1.DAT_18D = true;
            oVar4.DAT_18D = true;
            param1.BDAT_1C0 = 0;
            param1.DAT_1C7 = 0;
            param1.DAT_12E = 2;
        }
        else
        {
            if ((short)param1.DAT_1E2 <= (short)param1.UDAT_1E0 && param1.DAT_1E8 == param1.DAT_1C5 * 165)
            {
                param1.DAT_1E8 = 0;
                param1.DAT_1E6 <<= 1;
                param1.FUN_65CF8(0, 10, 10);
            }

            local_38 = new Vector3Int(0, param1.vr.y, 0);
            auStack48 = new Matrix3x3();
            Utilities.RotMatrix(ref local_38, ref auStack48);
            local_38 = new Vector3Int(0, (short)param1.DAT_1E8, param1.DAT_1EA);
            local_38 = Utilities.ApplyMatrixSV(ref auStack48, ref local_38);
            param1.screen.x += local_38.x;
            param1.screen.y += local_38.y;
            param1.screen.z += local_38.z;
            sVar1 = (short)Utilities.FUN_61654(param1.DAT_34, param1.screen, (short)param1.vr.y);
            iVar4 = (int)GameManager.FUN_64650();
            sVar2 = (short)Utilities.FUN_64838(param1.vr.x, (uint)((iVar4 % 0xf + 30) * 0x10000 >> 0x10), sVar1);
            param1.vr.x = param1.vr.x + sVar2 & 0xfff;

            if (param1.DAT_1C4 == 3)
            {
                sVar3 = 0x200;

                if (param1.DAT_1C6 == 0)
                    sVar3 = 0xe00;

                iVar4 = (int)GameManager.FUN_64650();
                iVar5 = (int)((ulong)((long)iVar4 * -0x77777777) >> 0x20);
            }
            else
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar5 = (int)((ulong)((long)iVar4 * -0x77777777) >> 0x20);
                sVar3 = 0;
            }

            sVar2 = (short)Utilities.FUN_64838(param1.vr.z, (uint)((iVar4 + ((iVar5 + iVar4 >> 3) - (iVar4 >> 31)) * -15 + 20) * 0x10000 >> 0x10), sVar3);
            param1.vr.z = param1.vr.z + sVar2 & 0xfff;
            bVar3 = false;
        }

        return bVar3;
    }

    //FUN_4984 (ST4)
    private void FUN_4984(CriPlayer param1)
    {
        byte bVar1;
        CriSkinned oVar2;
        bool bVar3;
        uint uVar4;

        oVar2 = SceneManager.instance.DAT_27C[10];
        param1.FUN_609C8(2, 9, 20);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65CF8(1, 10, 10);
        param1.DAT_12E = 4;
        param1.DAT_1C7 = 1;
        param1.BDAT_1C0 = 1;
        param1.DAT_1C2 = 0;
        param1.DAT_1C4 = 1;
        bVar3 = FUN_CAC4(param1);

        if (!bVar3)
            param1.DAT_1C5 = 1;
        else
            param1.DAT_1C5 = 2;

        param1.SDAT_1DC = -5000;
        param1.DAT_1C5++;
        uVar4 = Utilities.FUN_631AC(param1.screen, oVar2.screen);

        if (uVar4 < 7000)
        {
            bVar1 = param1.DAT_1C5;
            param1.DAT_1E8 = (ushort)(bVar1 * 280);
            param1.DAT_1E6 = (ushort)(bVar1 * -20);

            if (bVar1 == 3)
                uVar4 -= 3000;

            param1.UDAT_1E0 = 50;
            param1.DAT_1E2 = (ushort)(uVar4 / 30);
            param1.DAT_1EA = (short)((int)(uVar4 / 30 << 0x10) >> 15);

            if (param1.DAT_1E2 < 51)
            {
                param1.DAT_1E8 = (ushort)(param1.DAT_1C5 * 0xff);
                param1.DAT_1E6 >>= 1;
                param1.DAT_1E2 = param1.UDAT_1E0;
            }
        }
        else
        {
            bVar1 = param1.DAT_1C5;
            param1.DAT_1E8 = (ushort)(bVar1 * 200);
            param1.DAT_1E6 = (ushort)(bVar1 * -10);

            if (bVar1 == 3)
                uVar4 -= 3000;

            param1.DAT_1E2 = (ushort)(uVar4 / 80);
            param1.DAT_1EA = (short)((int)(uVar4 / 80 << 0x10) >> 14);
        }

        GameManager.instance.FUN_5C94C(param1, 52);
        param1.DAT_3E++;
    }

    //FUN_4B90 (ST4)
    private void FUN_4B90(CriPlayer param1)
    {
        bool bVar1;

        param1.FUN_60AB4();
        bVar1 = FUN_46B4(param1);

        if (!bVar1 && param1.DAT_1E8 == 0)
            param1.DAT_3E++;
    }

    //FUN_4BEC (ST4)
    private void FUN_4BEC(CriPlayer param1)
    {
        param1.FUN_609C8(15, 1, 0);
        param1.DAT_3E++;
    }

    //FUN_4C30 (ST4)
    private void FUN_4C30(CriPlayer param1)
    {
        bool bVar1;

        param1.FUN_60AB4();
        bVar1 = FUN_46B4(param1);

        if (!bVar1 && param1.DAT_60 == 2)
            GameManager.instance.FUN_5C94C(param1, 48);
    }

    //FUN_4C84 (ST4)
    private void FUN_4C84(CriPlayer param1)
    {
        PTR_FUN_13724[param1.DAT_3E](param1);
    }

    //FUN_4F04 (ST4)
    private void FUN_4F04(CriPlayer param1)
    {
        uint uVar1;
        int iVar2;
        short sVar3;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        param1.FUN_609C8(1, 9, 20);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        uVar1 = (uint)-(param1.DAT_1E8 / 5);
        param1.DAT_1EC = (short)uVar1;

        if ((uVar1 & 0xffff) == 0)
        {
            if (param1.screen.y == -5000)
                param1.DAT_1E8 = 0;
            else
            {
                uVar1 = (uint)((-5000 - param1.screen.y) / 40);
                param1.DAT_1E8 = (ushort)uVar1;

                if ((uVar1 & 0xffff) == 0)
                {
                    if (-5000 - param1.screen.y < 0)
                        param1.DAT_1E8 = 0xffff;
                    else
                        param1.DAT_1E8 = 1;
                }
            }
        }
        else
        {
            iVar2 = (int)(param1.DAT_1E8 + uVar1);
            param1.DAT_1E8 = (ushort)iVar2;

            if (param1.DAT_1EC < 0)
            {
                if (iVar2 * 0x10000 < 1)
                {
                    param1.DAT_1E8 = 0;
                    param1.DAT_1EC = 0;
                }
            }
            else
            {
                if (-1 < iVar2 * 0x10000)
                {
                    param1.DAT_1E8 = 0;
                    param1.DAT_1EC = 0;
                }
            }
        }

        param1.DAT_1EE = (short)((param1.DAT_1EA - 300) / 10);

        if (param1.DAT_1EA != 300)
        {
            sVar3 = 1;

            if (param1.DAT_1EA - 300 < 0)
                sVar3 = -1;

            param1.DAT_1EE = sVar3;
        }

        if (param1.DAT_1EE != 0)
        {
            iVar2 = param1.DAT_1EA - param1.DAT_1EE;
            param1.DAT_1EA = (short)iVar2;

            if (param1.DAT_1EE < 0)
            {
                if (300 < iVar2 * 0x10000 >> 0x10) goto LAB_50B8;

                param1.DAT_1EA = 300;
            }
            else
            {
                if (iVar2 * 0x10000 >> 0x10 < 300) goto LAB_50B8;

                param1.DAT_1EA = 300;
            }

            param1.DAT_1EE = 0;
        }

        LAB_50B8:
        local_38 = new Vector3Int(0, param1.vr.y, 0);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref auStack48);
        local_38 = new Vector3Int(0, (short)param1.DAT_1E8, param1.DAT_1EA);
        local_38 = Utilities.ApplyMatrixSV(ref auStack48, ref local_38);
        param1.screen.x += local_38.x;
        param1.screen.y += local_38.y;
        param1.BDAT_1C0 = 1;
        param1.UDAT_1E4 = 40;
        param1.screen.z += local_38.z;
        param1.FUN_65CF8(1, 10, 10);
        param1.DAT_3E++;
    }

    //FUN_5170 (ST4)
    private void FUN_5170(CriPlayer param1)
    {
        param1.FUN_60AB4();
        FUN_D434(param1);
    }

    //FUN_51A0 (ST4)
    private void FUN_51A0(CriPlayer param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_1CF - 1);

        if (param1.DAT_1CF == 0)
            PTR_FUN_13734[param1.DAT_3E](param1);
        else
        {
            param1.DAT_1CF = bVar1;

            if (0 < bVar1 << 0x18)
                PTR_FUN_13734[param1.DAT_3E](param1);
            else
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
        }
    }

    //FUN_5208 (ST4)
    private void FUN_5208(CriPlayer param1)
    {
        CriSkinned oVar1;

        param1.FUN_609C8(19, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_656EC();
        oVar1 = SceneManager.instance.DAT_27C[10];
        oVar1.DAT_152 = 1;
        param1.DAT_152 = 1;
        oVar1.DAT_154 = param1;
        param1.DAT_154 = oVar1;
        oVar1.DAT_11E |= 8;
        param1.DAT_18D = false;
        oVar1.DAT_18D = false;
        param1.BDAT_1C0 = 1;
        param1.DAT_3E++;
    }

    //FUN_5294 (ST4)
    private void FUN_5294(CriPlayer param1)
    {
        bool bVar1;
        ushort uVar2;
        CriPlayer oVar3;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.FUN_65714();
        uVar2 = param1.DAT_60;

        if (uVar2 == 19)
        {
            oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
            GameManager.instance.PTR_FUN_148 = FUN_9D30;
            oVar3.DAT_3C = 5;
            oVar3.DAT_3D = 3;
            oVar3.DAT_3E = 0;
            oVar3.DAT_3F = 0;
            param1.FUN_65C4C(oVar3);
            GameManager.instance.FUN_5C94C(param1, 53);
            //FUN_1D988
            oVar3.DAT_11E &= 0xdf;
            oVar3.vr.y = param1.vr.y;
            uVar2 = param1.DAT_60;
        }

        if (uVar2 == 22 || uVar2 == 54)
            GameManager.instance.FUN_5C94C(param1, 48);

        uVar2 = param1.DAT_60;

        if (uVar2 == 42)
        {
            GameManager.instance.FUN_5C94C(param1, 49);
            //FUN_1D988
            uVar2 = param1.DAT_60;
        }

        //if (uVar2 == 54)
        //    ; //FUN_1D988
    }

    //FUN_53BC (ST4)
    private void FUN_53BC(CriPlayer param1)
    {
        param1.FUN_609C8(20, 1, 0);
        param1.FUN_65714();
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1CB = 0;
        param1.DAT_3E++;
    }

    //FUN_5410 (ST4)
    private void FUN_5410(CriPlayer param1)
    {
        CriPlayer oVar1;
        byte bVar2;
        bool bVar3;
        ushort uVar4;
        int iVar5;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar3 = param1.FUN_60AB4();

        if (bVar3 && (sbyte)param1.DAT_1CB < 2)
        {
            if (oVar1.DAT_1E5 != 0)
            {
                param1.FUN_65714();
                param1.DAT_3E++;
                return;
            }

            bVar2 = (byte)(param1.DAT_1CB + 1);

            if (param1.DAT_60 == 0)
                param1.DAT_14C.y = param1.screen.y + 0xa4b;
            else
            {
                param1.DAT_1CB = bVar2;

                if (1 < bVar2)
                    param1.DAT_3E++;
            }
        }

        param1.FUN_65714();
        bVar2 = param1.DAT_1CB;

        if (bVar2 == 0)
        {
            uVar4 = param1.DAT_60;

            if (uVar4 != 1) goto LAB_5538;

            iVar5 = 56;
            GameManager.instance.FUN_5C94C(param1, iVar5);
        }
        else
        {
            if ((bVar2 == 1 || bVar2 == 2) && param1.DAT_60 == 1)
            {
                iVar5 = 57;
                GameManager.instance.FUN_5C94C(param1, iVar5);
            }
        }

        uVar4 = param1.DAT_60;

        LAB_5538:
        if (uVar4 == 2)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            //FUN_1D988
        }

        if (param1.DAT_60 == 22)
        {
            GameManager.instance.FUN_5C94C(param1, 49);
            //FUN_1D988
        }
    }

    //FUN_5594 (ST4)
    private void FUN_5594(CriPlayer param1)
    {
        param1.FUN_609C8(21, 0, 0);
        param1.FUN_65714();
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_5C94C(param1, 56);
        param1.DAT_3E++;
    }

    //FUN_55F4 (ST4)
    private void FUN_55F4(CriPlayer param1)
    {
        CriSkinned oVar1;
        bool bVar2;
        ushort uVar3;

        oVar1 = SceneManager.instance.DAT_27C[10];
        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 3;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.UDAT_1DA = 150;
            param1.SDAT_1D4 = 150;
            param1.SDAT_1D8 = 0;
            param1.SDAT_1D6 = 0;
            param1.DAT_18D = true;
            oVar1.DAT_18D = true;
            param1.BDAT_1C0 = 0;
            param1.DAT_1EA = 346;
            GameManager.instance.FUN_65CB0(param1);
        }

        param1.FUN_65714();

        if (45 < param1.DAT_60)
            param1.DAT_40.z = DAT_1373C[param1.DAT_60 - 46];

        uVar3 = param1.DAT_60;

        if (uVar3 == 2)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            uVar3 = param1.DAT_60;
        }

        if (uVar3 == 22)
        {
            param1.DAT_152 = 0;
            oVar1.DAT_152 = 0;
            oVar1.DAT_11E &= 0xf7;
            GameManager.instance.FUN_5C94C(param1, 49);
        }
    }

    //FUN_56F4 (ST4)
    private void FUN_56F4(CriPlayer param1)
    {
        PTR_FUN_13748[param1.DAT_3E](param1);
    }

    //FUN_5814 (ST4)
    private void FUN_5814(CriPlayer param1)
    {
        ushort uVar1;
        int iVar2;
        CriSkinned oVar2;

        oVar2 = SceneManager.instance.DAT_27C[10];

        if (param1.DAT_3E == 0)
        {
            param1.DAT_18D = false;
            oVar2.DAT_18D = false;
        }

        if ((oVar2.DAT_3C == 5 && oVar2.DAT_3D == 0) || (oVar2.DAT_3C == 5 && oVar2.DAT_3D == 1))
            FUN_4C84(param1);
        else
        {
            param1.DAT_3C = 2;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            iVar2 = (int)GameManager.FUN_64650();
            param1.DAT_1C6 = (byte)(iVar2 % 2);

            if ((iVar2 % 2 & 0xff) == 0)
                uVar1 = (ushort)(param1.vr.y - 0x400);
            else
                uVar1 = (ushort)(param1.vr.y + 0x400);

            param1.SDAT_1DE = (short)(uVar1 & 0xfff);
            param1.DAT_18D = true;
            oVar2.DAT_18D = true;
        }
    }

    //FUN_5A78 (ST4)
    private void FUN_5A78(CriPlayer param1)
    {
        uint uVar1;

        if (param1.DAT_1C3 == 0)
        {
            param1.FUN_609C8(14, 0, 20);
            param1.DAT_1CB = 0;
        }
        else
        {
            param1.DAT_1CB = 0xff;
            param1.FUN_60AB4();
        }

        param1.DAT_40 = new Vector3Int(0, 0, 0);
        uVar1 = (uint)-(param1.DAT_1E8 / 5);
        param1.DAT_1EC = (short)uVar1;

        if ((uVar1 & 0xffff) == 0)
        {
            if (param1.screen.y == -5000)
                param1.DAT_1E8 = 0;
            else
            {
                uVar1 = (uint)(-5000 - param1.screen.y) / 40;
                param1.DAT_1E8 = (ushort)uVar1;

                if ((uVar1 & 0xffff) == 0)
                {
                    if (-5000 - param1.screen.y < 0)
                    {

                    }

                }
            }
        }
    }

    //FUN_6B54 (ST4)
    private void FUN_6B54(CriPlayer param1)
    {
        PTR_FUN_137A8[param1.DAT_3D](param1);
    }

    //FUN_6B90 (ST4)
    private void FUN_6B90(CriPlayer param1)
    {
        GameManager.instance.FUN_65CB0(param1);
        param1.FUN_65CF8(0, 10, 10);
        param1.DAT_12E = 2;
        FUN_CC4C(param1);
        param1.DAT_3E = (byte)param1.DAT_1C1;
        FUN_6BE8(param1);
    }

    //FUN_6BE8 (ST4)
    private void FUN_6BE8(CriPlayer param1)
    {
        bool bVar1;

        param1.FUN_60AB4();
        bVar1 = FUN_CCBC(param1);

        if (!bVar1 && param1.DAT_1E8 == 0)
            param1.DAT_3E++;
    }

    //FUN_6C44 (ST4)
    private void FUN_6C44(CriPlayer param1)
    {
        bool bVar1;

        param1.FUN_609C8(15, 1, 0);
        bVar1 = FUN_CCBC(param1);

        if (!bVar1)
            param1.DAT_3E++;
    }

    //FUN_6C9C (ST4)
    private void FUN_6C9C(CriPlayer param1)
    {
        bool bVar1;

        param1.FUN_60AB4();
        bVar1 = FUN_CCBC(param1);

        if (!bVar1 && param1.DAT_60 == 2)
            GameManager.instance.FUN_5C94C(param1, 48);
    }

    //FUN_6CF0 (ST4)
    private void FUN_6CF0(CriPlayer param1)
    {
        PTR_FUN_137C4[param1.DAT_3E](param1);
    }

    //FUN_6D2C (ST4)
    private void FUN_6D2C(CriPlayer param1)
    {
        uint uVar1;

        param1.V2_1F0 = new Vector2Int(param1.screen.x, param1.screen.z);
        GameManager.instance.FUN_65CB0(param1);

        if (param1.screen.y == -5000)
            param1.DAT_1E8 = 0;
        else
        {
            uVar1 = (uint)(-5000 - param1.screen.y) / 40;
            param1.DAT_1E8 = (ushort)uVar1;

            if ((uVar1 & 0xffff) == 0)
            {
                if (-5000 - param1.screen.y < 0)
                    param1.DAT_1E8 = 0xffff;
                else
                    param1.DAT_1E8 = 1;
            }
        }

        param1.DAT_1EE = (short)((param1.DAT_1EA - 400) / 10);
        param1.FUN_65CF8(0, 10, 10);
        param1.DAT_3E++;
    }

    //FUN_6E14 (ST4)
    private void FUN_6E14(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        uint uVar3;
        uint uVar4;
        int iVar5;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        local_38 = new Vector3Int(param1.V2_1F0.x, param1.screen.y, param1.V2_1F0.y);
        uVar3 = Utilities.FUN_631AC(local_38, param1.screen);
        uVar4 = Utilities.FUN_631AC(param1.screen, SceneManager.instance.DAT_27C[10].screen);

        if (6000 < uVar3 && 6000 < uVar4)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 3;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.UDAT_1DA = 150;
            param1.SDAT_1D4 = 150;
            param1.SDAT_1D8 = 0;
            param1.SDAT_1D6 = 0;
            return;
        }

        param1.FUN_60AB4();
        local_38 = new Vector3Int(0, param1.vr.y, 0);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref auStack48);

        if (param1.DAT_1EE != 0)
        {
            iVar5 = param1.DAT_1EA - param1.DAT_1EE;
            param1.DAT_1EA = (short)iVar5;

            if (param1.DAT_1EE < 0)
            {
                if (iVar5 * 0x10000 >> 0x10 < 401)
                {
                    param1.DAT_1EA = 400;
                    param1.DAT_1EE = 0;
                }
            }
            else
            {
                if (399 < iVar5 * 0x10000 >> 0x10)
                {
                    param1.DAT_1EA = 400;
                    param1.DAT_1EE = 0;
                }
            }
        }

        local_38 = new Vector3Int(0, (short)param1.DAT_1E8, param1.DAT_1EA);
        local_38 = Utilities.ApplyMatrixSV(ref auStack48, ref local_38);
        param1.screen.x += local_38.x;
        param1.screen.y += local_38.y;
        param1.screen.z += local_38.z;

        if ((short)param1.DAT_1E8 < 0)
        {
            if (-5001 < param1.screen.y) goto LAB_6FC8;

            param1.screen.y = -5000;
        }
        else
        {
            if ((short)param1.DAT_1E8 < 1 || param1.screen.y < -4999) goto LAB_6FC8;

            param1.screen.y = -5000;
        }

        param1.DAT_1E8 = 0;
        LAB_6FC8:
        sVar1 = (short)Utilities.FUN_61654(param1.DAT_34, param1.screen, (short)param1.vr.y);
        iVar5 = (int)GameManager.FUN_64650();
        sVar2 = (short)Utilities.FUN_64838(param1.vr.x, (uint)((iVar5 % 0xf + 10) * 0x10000 >> 0x10), sVar1);
        param1.vr.x = param1.vr.x + sVar2 & 0xfff;
        iVar5 = (int)GameManager.FUN_64650();
        sVar2 = (short)Utilities.FUN_64838(param1.vr.z, (uint)((iVar5 % 0xf + 10) * 0x10000 >> 0x10), 0);
        param1.vr.z = param1.vr.z + sVar2 & 0xfff;
    }

    //FUN_70A0 (ST4)
    private void FUN_70A0(CriPlayer param1)
    {
        PTR_FUN_137D4[param1.DAT_3E](param1);
    }

    //FUN_7A14 (ST4)
    private void FUN_7A14(CriPlayer param1)
    {
        PTR_FUN_13824[param1.DAT_3E](param1);
    }

    //FUN_7A50 (ST4)
    private void FUN_7A50(CriPlayer param1)
    {
        param1.FUN_609C8(6, 0, 0);
        InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);
        InventoryManager.FUN_4A7E8(5, param1.DAT_163, false);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_11E |= 0x40;
        param1.DAT_3E++;
    }

    //FUN_7AC4 (ST4)
    private void FUN_7AC4(CriPlayer param1)
    {
        bool bVar1;
        short sVar2;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_12C = 0xffff;
            param1.PTR_120 = null;
            param1.DAT_120 = 0;
            param1.DAT_11E |= 0x40;
            param1.DAT_140 |= 1;
            FUN_E6F4(param1);
            param1.DAT_3E++;
        }

        sVar2 = (short)param1.DAT_60;

        if (sVar2 == 25)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            sVar2 = (short)param1.DAT_60;
        }

        if (sVar2 == 40)
            GameManager.instance.FUN_5C94C(param1, 49);

        sVar2 = (short)param1.DAT_60;

        if (sVar2 == 80)
        {
            GameManager.instance.FUN_5C94C(param1, 58);
            sVar2 = (short)param1.DAT_60;
        }

        if (sVar2 == 110)
            GameManager.instance.FUN_5C94C(param1, 60);
    }

    //FUN_7B94 (ST4)
    private void FUN_7B94(CriPlayer param1)
    {
        PTR_FUN_13828[param1.DAT_3E](param1);
    }

    //FUN_7BD0 (ST4)
    public void FUN_7BD0(CriPlayer param1)
    {
        PTR_FUN_13834[param1.DAT_3D](param1);
    }

    //FUN_7C0C (ST4)
    private void FUN_7C0C(CriPlayer param1)
    {
        if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
            FUN_81CC(param1);

        PTR_FUN_13860[param1.DAT_3D](param1);
    }

    //FUN_7C68 (ST4)
    private void FUN_7C68(CriPlayer param1)
    {
        param1.FUN_60AB4();
    }

    //FUN_7C88 (ST4)
    private void FUN_7C88(CriPlayer param1)
    {
        short sVar1;
        uint uVar3;

        param1.FUN_609C8(1, 9, 10);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.UDAT_1E4 = (ushort)param1.PTR_190[param1.DAT_190].x;
        sVar1 = (short)param1.PTR_190[param1.DAT_190].y;
        param1.DAT_190++;
        param1.V2_1F0 = new Vector2Int(param1.screen.x, param1.screen.y);
        param1.DAT_18F--;
        param1.DAT_1EA = sVar1;
        uVar3 = Utilities.FUN_631AC(param1.screen, param1.PTR_190[param1.DAT_190]);
        param1.UDAT_1FC = uVar3;
        FUN_D8E0(param1);
        param1.DAT_3E++;
    }

    //FUN_7E04 (ST4)
    private void FUN_7E04(CriPlayer param1)
    {
        sbyte sVar1;
        uint uVar2;
        uint uVar4;
        Vector3Int local_18;

        local_18 = new Vector3Int(param1.V2_1F0.x, 0, param1.V2_1F0.y);
        uVar2 = Utilities.FUN_631AC(local_18, param1.screen);

        if (param1.UDAT_1FC < uVar2)
        {
            sVar1 = (sbyte)(param1.DAT_18F - 1);
            param1.DAT_18F = (byte)sVar1;

            if (sVar1 == 0)
            {
                param1.DAT_40 = new Vector3Int(0, 0, 0);
                InventoryManager.FUN_4A7E8(3, param1.DAT_176, true);
                param1.DAT_3E++;
                return;
            }

            param1.DAT_190++;
            param1.V2_1F0 = new Vector2Int(param1.screen.x, param1.screen.z);
            uVar4 = Utilities.FUN_631AC(param1.screen, param1.PTR_190[param1.DAT_190]);
            param1.UDAT_1FC = uVar4;
        }

        param1.FUN_60AB4();
        FUN_D8E0(param1);
    }

    //FUN_7E18 (ST4)
    private void FUN_7E18(CriPlayer param1)
    {
        PTR_FUN_1388C[param1.DAT_3E](param1);
    }

    //FUN_7E54 (ST4)
    private void FUN_7E54(CriPlayer param1)
    {
        byte bVar1;
        CriSkinned oVar2;
        uint uVar3;

        oVar2 = SceneManager.instance.DAT_27C[10];
        param1.FUN_609C8(2, 9, 20);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65CF8(1, 10, 10);
        param1.DAT_12E = 4;
        param1.DAT_1C7 = 1;
        param1.BDAT_1C0 = 1;
        param1.DAT_1C4 = 1;
        param1.DAT_1C5 = 2;
        param1.DAT_1C2 = 0;
        param1.SDAT_1DC = -5000;
        uVar3 = Utilities.FUN_631AC(param1.screen, oVar2.screen);

        if (uVar3 < 7000)
        {
            bVar1 = param1.DAT_1C5;
            param1.UDAT_1E0 = 50;
            param1.DAT_1E8 = (ushort)(bVar1 * 280);
            param1.DAT_1E6 = (ushort)(bVar1 * -20);
            param1.DAT_1E2 = (ushort)(uVar3 / 30);
            param1.DAT_1EA = (short)((int)(uVar3 / 30 << 0x10) >> 15);

            if ((short)param1.DAT_1E2 < 51)
            {
                param1.DAT_1E8 = (ushort)(bVar1 * 0xff);
                param1.DAT_1E6 >>= 1;
                param1.DAT_1E2 = param1.UDAT_1E0;
            }
        }
        else
        {
            param1.DAT_1E8 = (ushort)(param1.DAT_1C5 * 200);
            param1.DAT_1E6 = (ushort)(param1.DAT_1C5 * -10);
            param1.DAT_1E2 = (ushort)(uVar3 / 80);
            param1.DAT_1EA = (short)((int)(uVar3 / 80 << 0x10) >> 14);
        }

        GameManager.instance.FUN_5C94C(param1, 52);
        param1.DAT_3E++;
    }

    //FUN_8004 (ST4)
    private void FUN_8004(CriPlayer param1)
    {
        bool bVar1;

        param1.FUN_60AB4();
        bVar1 = FUN_46B4(param1);

        if (!bVar1 && param1.DAT_1E8 == 0)
            param1.DAT_3E++;
    }

    //FUN_8060 (ST4)
    private void FUN_8060(CriPlayer param1)
    {
        param1.FUN_609C8(15, 1, 0);
        param1.DAT_3E++;
    }

    //FUN_80A4 (ST4)
    private void FUN_80A4(CriPlayer param1)
    {
        bool bVar1;

        param1.FUN_60AB4();
        bVar1 = FUN_46B4(param1);

        if (!bVar1 && param1.DAT_60 == 2)
            GameManager.instance.FUN_5C94C(param1, 48);
    }

    //FUN_80F8 (ST4)
    private void FUN_80F8(CriPlayer param1)
    {
        PTR_FUN_13898[param1.DAT_3E](param1);
    }

    //FUN_81CC (ST4)
    private void FUN_81CC(CriPlayer param1)
    {
        PTR_FUN_138A8[param1.DAT_3E](param1);
    }

    //FUN_8208 (ST4)
    private void FUN_8208(CriPlayer param1)
    {
        PTR_FUN_138B8[param1.DAT_3E](param1);
    }

    //FUN_AEF4 (ST4)
    public void FUN_AEF4(CriPlayer param1)
    {
        uint uVar1;

        if ((param1.DAT_11E & 0x80) != 0)
        {
            if ((param1.DAT_18E & 4) != 0)
                param1.DAT_18E &= 0xfb;

            param1.DAT_11E &= 0x7b;
            uVar1 = (uint)param1.DAT_1A0 >> 4 & 0xf;
            DAT_1464C = (ushort)uVar1;
            //...
        }
    }

    //FUN_CA78 (ST4)
    private void FUN_CA78(CriSkinned param1)
    {
        short sVar1;
        uint uVar2;

        uVar2 = GameManager.FUN_64650();
        sVar1 = 850;

        if ((uVar2 & 2) == 0)
        {
            uVar2 = GameManager.FUN_64650();
            sVar1 = 1000;

            if ((uVar2 & 2) == 0)
                sVar1 = 750;
        }

        param1.maxHealth = sVar1;
    }

    //FUN_CAC4 (ST4)
    private bool FUN_CAC4(CriPlayer param1)
    {
        return true;
    }

    //FUN_CC4C (ST4)
    private void FUN_CC4C(CriPlayer param1)
    {
        ushort uVar1;
        int iVar2;

        param1.DAT_1C4 = 3;
        iVar2 = (int)GameManager.FUN_64650();
        param1.DAT_1C6 = (byte)(iVar2 % 2);

        if ((iVar2 % 2 & 0xff) == 0)
            uVar1 = (ushort)(param1.vr.y - 0x400);
        else
            uVar1 = (ushort)(param1.vr.y + 0x400);

        param1.SDAT_1DE = (short)(uVar1 & 0xfff);
    }

    //FUN_CCBC (ST4)
    private bool FUN_CCBC(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        short sVar3;
        bool bVar3;
        int iVar4;
        CriSkinned oVar4;
        ushort uVar5;
        int iVar6;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        oVar4 = SceneManager.instance.DAT_27C[10];
        FUN_CF30(param1);
        uVar5 = (ushort)(param1.DAT_1E8 + param1.DAT_1E6);
        param1.DAT_1E8 = uVar5;

        if (param1.screen.y < param1.SDAT_1DC && uVar5 << 0x10 < 1)
        {
            bVar3 = true;

            if (param1.health < 1)
                param1.DAT_1CF = 10;

            param1.DAT_3C = 1;
            param1.DAT_3D = 3;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_1DA = 150;
            param1.SDAT_1D4 = 150;
            param1.SDAT_1D8 = 0;
            param1.SDAT_1D6 = 0;
            param1.DAT_18D = true;
            oVar4.DAT_18D = true;
            param1.BDAT_1C0 = 0;
            param1.DAT_1C7 = 0;
        }
        else
        {
            if ((short)param1.DAT_1E2 <= (short)param1.UDAT_1E0 && param1.DAT_1E8 == param1.DAT_1C5 * 165)
            {
                param1.DAT_1E8 = 0;
                param1.DAT_1E6 <<= 1;
            }

            local_38 = new Vector3Int(0, param1.vr.y, 0);
            auStack48 = new Matrix3x3();
            Utilities.RotMatrix(ref local_38, ref auStack48);
            local_38 = new Vector3Int(0, (short)param1.DAT_1E8, param1.DAT_1EA);
            local_38 = Utilities.ApplyMatrixSV(ref auStack48, ref local_38);
            param1.screen.x += local_38.x;
            param1.screen.y += local_38.y;
            param1.screen.z += local_38.z;
            sVar1 = (short)Utilities.FUN_61654(param1.DAT_34, param1.screen, (short)param1.vr.y);
            iVar4 = (int)GameManager.FUN_64650();
            sVar2 = (short)Utilities.FUN_64838(param1.vr.x, (uint)((iVar4 % 0xf + 30) * 0x10000 >> 0x10), sVar1);
            param1.vr.x = param1.vr.x + sVar2 & 0xfff;

            if (param1.DAT_1C4 == 3)
            {
                sVar3 = 0x200;

                if (param1.DAT_1C6 == 0)
                    sVar3 = 0xe00;

                iVar4 = (int)GameManager.FUN_64650();
                iVar6 = (int)((ulong)((long)iVar4 * -0x77777777) >> 0x20);
            }
            else
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar6 = (int)((ulong)((long)iVar4 * -0x77777777) >> 0x20);
                sVar3 = 0;
            }

            sVar2 = (short)Utilities.FUN_64838(param1.vr.z, (uint)((iVar4 + ((iVar6 + iVar4 >> 3) - (iVar4 >> 31)) * -15 + 20) * 0x10000 >> 0x10), sVar3);
            bVar3 = false;
        }

        return bVar3;
    }

    //FUN_CF30 (ST4)
    private void FUN_CF30(CriPlayer param1)
    {
        return;
    }

    //FUN_D434 (ST4)
    private void FUN_D434(CriPlayer param1)
    {
        uint uVar1;
        byte bVar2;
        ushort uVar3;
        short sVar4;
        short sVar5;
        short sVar6;
        short sVar7;
        int iVar8;
        CriSkinned oVar8;
        int iVar9;
        int iVar10;
        Vector3Int local_40;
        Matrix3x3 auStack56;

        oVar8 = SceneManager.instance.DAT_27C[10];
        sVar7 = 0;
        bVar2 = (byte)FUN_E2B4(param1);

        if (bVar2 == 1)
            sVar7 = -40;
        else
        {
            if (bVar2 < 2)
            {
                if (bVar2 == 0)
                {
                    if (param1.DAT_1CC != 0)
                    {
                        param1.UDAT_1E4 = 0;
                        param1.SDAT_1D6 = 40;
                        param1.FUN_65CF8(0, 10, 10);
                    }

                    sVar4 = (short)Utilities.FUN_615EC(param1.screen, oVar8.screen);
                    sVar7 = (short)Utilities.FUN_64838(param1.vr.y, (uint)(int)(short)param1.UDAT_1E4, sVar4);
                }
            }
            else
            {
                if (bVar2 == 2)
                    sVar7 = 40;
            }
        }

        param1.DAT_1CC = bVar2;
        param1.vr.y = param1.vr.y + sVar7 & 0xfff;
        local_40 = new Vector3Int(0, param1.vr.y, 0);
        auStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref local_40, ref auStack56);

        if (param1.DAT_1EC != 0)
        {
            uVar3 = (ushort)(param1.DAT_1E8 + (ushort)param1.DAT_1EC);
            param1.DAT_1E8 = uVar3;

            if (param1.DAT_1EC < 0)
            {
                if (uVar3 << 0x10 < 1)
                {
                    param1.DAT_1E8 = 0;
                    param1.DAT_1EC = 0;

                    if (param1.screen.y == -5000)
                        param1.DAT_1E8 = 0;
                    else
                    {
                        uVar1 = (uint)((-5000 - param1.screen.y) / 40);
                        param1.DAT_1E8 = (ushort)uVar1;

                        if ((uVar1 & 0xffff) == 0)
                        {
                            if (-5000 - param1.screen.y < 0)
                                param1.DAT_1E8 = 0xffff;
                            else
                                param1.DAT_1E8 = 1;
                        }
                    }
                }
            }
            else
            {
                if (-1 < uVar3 << 0x10)
                {
                    param1.DAT_1E8 = 0;
                    param1.DAT_1EC = 0;

                    if (param1.screen.y == -5000)
                        param1.DAT_1E8 = 0;
                    else
                    {
                        uVar1 = (uint)((-5000 - param1.screen.y) / 40);
                        param1.DAT_1E8 = (ushort)uVar1;

                        if ((uVar1 & 0xffff) == 0)
                        {
                            if (-5000 - param1.screen.y < 0)
                                param1.DAT_1E8 = 0xffff;
                            else
                                param1.DAT_1E8 = 1;
                        }
                    }
                }
            }
        }

        if (param1.DAT_1EE != 0)
        {
            iVar8 = (ushort)param1.DAT_1EA - (ushort)param1.DAT_1EE;
            param1.DAT_1EA = (short)iVar8;

            if (param1.DAT_1EE < 0)
            {
                if (iVar8 * 0x10000 >> 0x10 < 0x191)
                {
                    param1.DAT_1EA = 400;
                    param1.DAT_1EE = 0;
                }
            }
            else
            {
                if (399 < iVar8 * 0x10000 >> 0x10)
                {
                    param1.DAT_1EA = 400;
                    param1.DAT_1EE = 0;
                }
            }
        }

        local_40 = new Vector3Int(0, (short)param1.DAT_1E8, param1.DAT_1EA);
        local_40 = Utilities.ApplyMatrixSV(ref auStack56, ref local_40);
        param1.screen.x += local_40.x;
        param1.screen.y += local_40.y;
        param1.screen.z += local_40.z;

        if (param1.DAT_1EC == 0)
        {
            if ((short)param1.DAT_1E8 < 0)
            {
                if (-5001 < param1.screen.y) goto LAB_D744;

                param1.screen.y = -5000;
            }
            else
            {
                if ((short)param1.DAT_1E8 < 1 || param1.screen.y < -4999) goto LAB_D744;

                param1.screen.y = -5000;
            }

            param1.DAT_1E8 = 0;
        }

        LAB_D744:
        sVar4 = (short)Utilities.FUN_61654(param1.DAT_34, param1.screen, (short)param1.vr.y);

        if (param1.DAT_1EC == 0)
        {
            iVar8 = (int)GameManager.FUN_64650();
            sVar6 = (short)param1.vr.x;
            sVar5 = (short)(iVar8 + (iVar8 / 15) * -15 + 10);
        }
        else
        {
            iVar8 = (int)GameManager.FUN_64650();
            sVar6 = (short)param1.vr.x;
            sVar5 = (short)(iVar8 + (iVar8 / 15) * -15 + 80);
        }

        sVar6 = (short)Utilities.FUN_64838(sVar6, (uint)(int)sVar5, sVar4);
        param1.vr.x += sVar6;
        param1.vr.x &= 0xfff;
        iVar8 = sVar7;
        iVar9 = 0x200;

        if (iVar8 < 0)
            iVar9 = 0xe00;

        if (iVar8 < 0)
            iVar8 = -iVar8;

        if (iVar8 < (short)param1.UDAT_1E4 || param1.UDAT_1E4 == 0)
        {
            iVar8 = (int)GameManager.FUN_64650();
            iVar10 = (int)((ulong)((long)iVar8 * -0x77777777) >> 0x20);
            iVar9 = 0;
        }
        else
        {
            iVar8 = (int)GameManager.FUN_64650();
            iVar10 = (int)((ulong)((long)iVar8 * -0x77777777) >> 0x20);
        }

        sVar7 = (short)Utilities.FUN_64838(param1.vr.z, (uint)((iVar8 + ((iVar10 + iVar8 >> 3) - (iVar8 >> 31)) * -15 + 10) * 0x10000 >> 0x10), iVar9);
        param1.vr.z = param1.vr.z + sVar7 & 0xfff;
    }

    //FUN_D8E0 (ST4)
    private void FUN_D8E0(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.PTR_190[param1.DAT_190]);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, (uint)(int)(short)param1.UDAT_1E4, sVar1);
        param1.vr.y = param1.vr.y + sVar2 & 0xfff;
        local_38 = new Vector3Int(0, param1.vr.y, 0);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref auStack48);
        local_38 = new Vector3Int(0, 0, param1.DAT_1EA);
        local_38 = Utilities.ApplyMatrixSV(ref auStack48, ref local_38);
        param1.screen.x += local_38.x;
        param1.screen.y += local_38.y;
        param1.screen.z += local_38.z;
        iVar3 = sVar2;
        iVar4 = 0x200;

        if (iVar3 < 0)
            iVar4 = 0xe00;

        if (iVar3 < 0)
            iVar3 = -iVar3;

        if (iVar3 < (short)param1.UDAT_1E4 || param1.UDAT_1E4 == 0)
        {
            iVar3 = (int)GameManager.FUN_64650();
            iVar5 = (int)((ulong)((long)iVar3 * -0x77777777) >> 0x20);
            iVar4 = 0;
        }
        else
        {
            iVar3 = (int)GameManager.FUN_64650();
            iVar5 = (int)((ulong)((long)iVar3 * -0x77777777) >> 0x20);
        }

        sVar2 = (short)Utilities.FUN_64838(param1.vr.z, (uint)((iVar3 + ((iVar5 + iVar3 >> 3) - (iVar3 >> 31)) * -15 + 10) * 0x10000 >> 0x10), iVar4);
        param1.vr.z = param1.vr.z + sVar2 & 0xfff;
    }

    //FUN_DC10 (ST4)
    public void FUN_DC10(CriPlayer param1)
    {
        bool bVar1;
        bool bVar2;

        bVar1 = PTR_FUN_13B7C[param1.BDAT_1CA](param1);

        if (!bVar1)
        {
            if ((param1.DAT_174 & 0x80) != 0)
                return;

            bVar2 = true;
        }
        else
        {
            if ((param1.DAT_174 & 0x80) == 0)
                return;

            bVar2 = false;
        }

        param1.FUN_6642C(bVar2);
    }

    //FUN_DC9C (ST4)
    private bool FUN_DC9C(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;

        sVar1 = (short)param1.screen.x;

        if (-0x3b81 < sVar1 && sVar1 < 0x37a1)
        {
            sVar2 = (short)param1.screen.z;

            if (sVar2 < 0x176e && -0xc51 < sVar2)
            {
                bVar3 = false;

                if (0x1ef0 < sVar1)
                {
                    if (0xff0 < sVar2)
                        return true;

                    bVar3 = true;

                    if (0x6f < sVar2)
                        bVar3 = false;
                }

                return bVar3;
            }
        }

        return true;
    }

    //FUN_DD04 (ST4)
    private bool FUN_DD04(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;

        sVar1 = (short)param1.screen.x;

        if (sVar1 < 0x1fe1 && -0x2001 < sVar1)
        {
            sVar2 = (short)param1.screen.z;

            if (sVar2 < 0x2bc1 && -0x2781 < sVar2)
            {
                bVar3 = false;

                if (0xa00 < sVar1 && -0x1860 < sVar2)
                {
                    bVar3 = true;

                    if (0xbbf < sVar2)
                        bVar3 = false;
                }

                return bVar3;
            }
        }

        return true;
    }

    //FUN_DD70 (ST4)
    private bool FUN_DD70(CriPlayer param1)
    {
        short sVar1;
        bool bVar2;

        if (-0x1c01 < param1.screen.x)
        {
            sVar1 = (short)param1.screen.z;

            if (sVar1 < 0x2b21)
            {
                if (-0xbc1 < param1.screen.x)
                    bVar2 = false;
                else
                {
                    if (-0x1c60 < sVar1)
                    {
                        bVar2 = true;

                        if (7999 < sVar1)
                            bVar2 = false;
                    }
                    else bVar2 = false;
                }

                return bVar2;
            }
        }

        return true;
    }

    //FUN_DE04 (ST4)
    private bool FUN_DE04(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;

        sVar1 = (short)param1.screen.x;

        if (-0x40d1 < sVar1 && sVar1 < 0x3cf1)
        {
            sVar2 = (short)param1.screen.z;

            if (sVar2 < 0x1cb1 && -0x11a1 < sVar2 && (-0x3901 < sVar1 || 0xca1 < sVar2) && 
                param1.screen.x < 0x2441 || (param1.screen.z < 0x1541 && -0x4e1 < param1.screen.z))
            {
                bVar3 = false;

                if (0x18b0 < param1.screen.x)
                {
                    bVar3 = true;

                    if (-0xd91 < param1.screen.z)
                        bVar3 = false;
                }

                return bVar3;
            }
        }

        return true;
    }

    //FUN_DEB8 (ST4)
    private bool FUN_DEB8(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;

        sVar1 = (short)param1.screen.x;

        if (sVar1 < 0x2531 && -0x2551 < sVar1)
        {
            sVar2 = (short)param1.screen.z;

            if (sVar2 < 0x3111 && -0x2cd1 < sVar2)
            {
                bVar3 = false;

                if (0xf50 < sVar1 && -0x1310 < sVar2)
                {
                    bVar3 = true;

                    if (0x66f < sVar2)
                        bVar3 = false;
                }

                return bVar3;
            }
        }

        return true;
    }

    //FUN_DF24 (ST4)
    private bool FUN_DF24(CriPlayer param1)
    {
        short sVar1;
        bool bVar2;

        if (-0x2001 < param1.screen.x)
        {
            sVar1 = (short)param1.screen.z;

            if (sVar1 < 0x3074)
            {
                if (-0x1101 < param1.screen.x)
                    bVar2 = false;
                else
                {
                    if (-0x199d < sVar1)
                    {
                        bVar2 = true;

                        if (0x19a2 < sVar1)
                            bVar2 = false;
                    }
                    else bVar2 = false;
                }

                return bVar2;
            }
        }

        return true;
    }

    //FUN_E088 (ST4)
    private void FUN_E088(CriPlayer param1)
    {
        CriObject oVar1;

        Utilities.FUN_64930(param1.vr.y, param1, param1.DAT_167, 0xf00, 0x100);
        Utilities.FUN_64A54(param1.vr.x, param1, param1.DAT_166, 0xf00, 0x100);

        if (param1.DAT_19E != 0)
        {
            oVar1 = Utilities.FUN_601C8(param1.skeleton, 1);
            oVar1.vr.y = (short)param1.DAT_19E;
            oVar1.vr.x = (short)param1.DAT_19C;
        }
    }

    //FUN_E118 (ST4)
    private void FUN_E118(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriBone oVar3;
        CriSkinned oVar4;
        Vector3Int local_40;
        Matrix3x3 auStack56;

        oVar4 = SceneManager.instance.DAT_27C[10];
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar4.screen);
        Utilities.FUN_64930(sVar1, param1, param1.DAT_167, 0xf00, 0x100);
        local_40 = new Vector3Int(0, param1.vr.y, 0);
        auStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref local_40, ref auStack56);
        oVar3 = (CriBone)Utilities.FUN_601C8(oVar4.skeleton, 0);
        local_40 = new Vector3Int(oVar4.screen.x, oVar3.DAT_44.y, oVar4.screen.z);
        sVar2 = (short)Utilities.FUN_61654(param1.screen, local_40, (short)param1.vr.y);
        Utilities.FUN_64A54(sVar2, param1, param1.DAT_166, 0xf00, 0x100);

        if (param1.DAT_19E != 0)
        {
            oVar3 = (CriBone)Utilities.FUN_601C8(param1.skeleton, 1);
            oVar3.vr.y = (short)param1.DAT_19E;
            oVar3.vr.x = (short)param1.DAT_19C;
        }
    }

    //FUN_E23C (ST4)
    public void FUN_E23C(CriPlayer param1)
    {
        PTR_FUN_13B94[param1.DAT_164](param1);
    }

    //FUN_E278 (ST4)
    private uint FUN_E278(CriSkinned param1)
    {
        uint uVar1;
        uint uVar2;

        uVar2 = 0;
        uVar1 = param1.DAT_128;

        do
        {
            if ((uVar1 & 1) != 0)
                return uVar2 & 0xff;

            uVar2++;
            uVar1 = (uint)(param1.DAT_128 >> (int)(uVar2 & 31));
        } while (uVar2 < 9);

        return 0xff;
    }

    //FUN_E2B4 (ST4)
    private int FUN_E2B4(CriSkinned param1)
    {
        ushort uVar1;
        CriSkinned oVar2;
        uint uVar3;
        int iVar4;

        oVar2 = SceneManager.instance.FUN_65B30(param1);

        if (oVar2 == null)
            iVar4 = 0;
        else
        {
            uVar3 = Utilities.FUN_631AC(param1.screen, oVar2.screen);
            uVar1 = (ushort)param1.FUN_64804(oVar2.screen);

            if (3999 < uVar3 || uVar1 - 0x201 < 0xc00)
            {
                uVar3 = FUN_E278(param1);

                if ((uVar3 & 0xff) == 0xff)
                    return 0;

                if (oVar2 != SceneManager.instance.DAT_27C[uVar3 & 0xff])
                    return 0;
            }

            iVar4 = 1;

            if (0x7ff < uVar1)
                iVar4 = 2;
        }

        return iVar4;
    }

    //FUN_E4E8 (ST4)
    private bool FUN_E4E8(CriSkinned param1, byte param2, byte param3)
    {
        return param1.FUN_65D78(ref PTR_DAT_13B9C[param2 * 4 + param3], param2, param3);
    }

    //FUN_E528 (ST4)
    public void FUN_E528(CriPlayer param1)
    {
        byte bVar1;
        short sVar2;

        sVar2 = param1.DAT_194;
        bVar1 = param1.DAT_3C;

        if (0 < sVar2 && bVar1 != 3 && bVar1 != 4 && param1.DAT_194-- == 1)
        {
            sVar2 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (bVar1 == 2 || sVar2 == 0x201 || sVar2 == 0x501 || sVar2 == 4)
                param1.DAT_194 = 1;
            else
            {
                param1.DAT_194 = 0;
                param1.DAT_3C = 2;
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.FUN_65CF8(0, 10, 10);
            }
        }
    }

    //FUN_E6F4 (ST4)
    private void FUN_E6F4(CriPlayer param1)
    {
        CriParticle oVar2;

        oVar2 = SceneManager.instance.FUN_5FFA0();

        if (oVar2 != null)
        {
            oVar2.tags = 0;
            oVar2.DAT_3C = 3;
            oVar2.DAT_2F = 0;
            oVar2.screen = param1.screen;
            oVar2.DAT_68 = 120;
            oVar2.DAT_62 = 0;
            oVar2.DAT_60 = 0;
            oVar2.DAT_69 = 76;
        }
    }

    //FUN_EBA4 (ST4)
    private void FUN_EBA4(CriPlayer param1)
    {
        return;
    }

    //FUN_EBD8 (ST4)
    private void FUN_EBD8(CriPlayer param1)
    {
        param1.PTR_120 = DAT_13E24;
        param1.DAT_120 = 0;
        param1.PTR_130 = DAT_13E24;
        param1.DAT_130 = 0;
        param1.PTR_124 = DAT_13E24;
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
        param1.DAT_3A = param1.DAT_2F;
        param1.DAT_154 = SceneManager.instance.DAT_27C[10];
        //...
    }

    //FUN_EE08 (ST4)
    private void FUN_EE08(CriPlayer param1)
    {
        if (param1.screen.y == 0)
        {
            if ((param1.DAT_1C0 & 1) == 0)
            {
                if (param1.DAT_2F == 1 && (param1.PDAT_1C8.DAT_02 & 2) != 0)
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

    //FUN_EE9C (ST4)
    private void FUN_EE9C(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(13, 1, 0);
        param1.FUN_65890();
    }

    //FUN_EEE4 (ST4)
    private void FUN_EEE4(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        int iVar5;
        CriSkinned oVar6;

        oVar6 = param1.DAT_154;
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 80, sVar1);
        param1.vr.y += sVar2;
        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.screen.y = 0;
            uVar4 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_13E48[uVar4 & 1]);
            bVar3 = Utilities.FUN_64C0C(param1.screen, oVar6.screen, (short)param1.vr.y, 0x200);

            if (bVar3 && param1.DAT_148 < 5)
            {
                param1.DAT_3D = 3;
                param1.DAT_3E = 0;
                return;
            }

            uVar4 = GameManager.FUN_64650();

            if ((uVar4 & 1) == 0)
                iVar5 = 3;
            else
                iVar5 = 13;

            param1.FUN_609C8(iVar5, 0, 0);
            uVar4 = GameManager.FUN_64650();

            if ((0x40 >> (int)(uVar4 & 7) & 1) != 0)
            {
                uVar4 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_13E4C[uVar4 & 1]);
            }
        }

        param1.FUN_65890();
    }

    //FUN_F028 (ST4)
    private void FUN_F028(CriPlayer param1)
    {
        PTR_FUN_140B8[param1.DAT_3E](param1);
    }

    //FUN_F064 (ST4)
    private void FUN_F064(CriPlayer param1)
    {
        if (param1.screen.y == 0 && (param1.DAT_1C0 & 1) != 0)
        {
            param1.DAT_3D = 6;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_F098 (ST4)
    private void FUN_F098(CriPlayer param1)
    {
        uint uVar1;

        param1.DAT_40.y = -100;
        param1.SDAT_1CC = 8;
        param1.DAT_40.z = 160;
        param1.DAT_3E++;
        param1.FUN_609C8(4, 0, 0);
        uVar1 = GameManager.FUN_64650();
        GameManager.instance.FUN_5C94C(param1, DAT_140C0[uVar1 & 1]);

        if (param1.DAT_2F == 0)
            param1.DAT_1C0 |= 0x20;
    }

    //FUN_F138 (ST4)
    private void FUN_F138(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.DAT_40.y += param1.SDAT_1CC;

        if (param1.frame.DAT_01 == 12)
        {
            param1.DAT_1C0 |= 0x40;
            param1.DAT_3E++;
        }
    }

    //FUN_F1A8 (ST4)
    private void FUN_F1A8(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.DAT_40.y += param1.SDAT_1CC;

        if (param1.frame.DAT_01 == 16)
        {
            param1.DAT_1C0 &= 0xffffffbf;
            param1.DAT_3E++;
        }
    }

    //FUN_F20C (ST4)
    private void FUN_F20C(CriPlayer param1)
    {
        int iVar1;

        param1.FUN_60AB4();
        param1.DAT_40.y += param1.SDAT_1CC;

        if (param1.screen.y == 0)
        {
            param1.DAT_1C0 &= 0xffffffdf;

            if (param1.DAT_2F == 0)
            {
                param1.DAT_3D = 1;
                param1.DAT_3E = 1;
                param1.DAT_3F = 0;
                param1.FUN_609C8(13, 1, 0);
                iVar1 = (int)GameManager.FUN_64650();
                param1.DAT_112 = (short)(iVar1 + (iVar1 / 30) * -30 + 60);
            }
            else
            {
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
        }
    }

    //FUN_F2E4 (ST4)
    private void FUN_F2E4(CriPlayer param1)
    {
        PTR_FUN_140C4[param1.DAT_3E](param1);
    }

    //FUN_F320 (ST4)
    private void FUN_F320(CriPlayer param1)
    {
        CriInteract oVar1;

        oVar1 = param1.PDAT_1C8;
        param1.DAT_3E++;
        param1.FUN_609C8(6, 0, 0);

        if (param1.DAT_2F == 1)
            oVar1.BDAT_08 |= 2;
    }

    //FUN_F38C (ST4)
    private void FUN_F38C(CriPlayer param1)
    {
        ushort uVar1;
        int iVar2;
        bool bVar2;
        CriInteract oVar3;

        oVar3 = param1.PDAT_1C8;
        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            if (param1.DAT_2F == 0)
            {
                param1.DAT_3D = 1;
                param1.DAT_3E = 1;
                param1.DAT_3F = 0;
                param1.FUN_609C8(13, 1, 0);
                iVar2 = (int)GameManager.FUN_64650();
                param1.DAT_112 = (short)(iVar2 + (iVar2 / 30) * -30 + 60);
            }
            else
            {
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_40.z = 0;
                param1.DAT_40.y = 0;
                param1.PTR_120 = DAT_13E24;
                param1.DAT_120 = 0;
                uVar1 = (ushort)GameManager.FUN_64650();
                param1.DAT_112 = (short)(uVar1 & 0xf);
                oVar3.DAT_08 &= 0xfd;
            }
        }

        param1.FUN_65890();
    }

    //FUN_F48C (ST4)
    private void FUN_F48C(CriPlayer param1)
    {
        PTR_FUN_140D4[param1.DAT_3E](param1);
    }

    //FUN_F4C8 (ST4)
    private void FUN_F4C8(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriPlayer oVar4;

        param1.DAT_3E++;
        param1.DAT_12C |= 0x10;
        oVar4 = (CriPlayer)param1.DAT_154;
        param1.FUN_609C8(DAT_140DC[param1.DAT_2E], 1, 0);
        GameManager.instance.PTR_FUN_148 = FUN_112EC;
        oVar4.DAT_154 = param1;
        oVar4.DAT_1E0 = oVar4.DAT_98;
        oVar4.DAT_3C = 5;
        oVar4.DAT_3D = 0;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        oVar4.DAT_98 = param1.DAT_98;
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar4.screen);
        param1.vr.y = sVar1;
        param1.DAT_112 = 90;

        if (param1.DAT_2E == 0)
            param1.vr.y = oVar4.vr.y + 0x800 & 0xfff;
        else
            param1.vr.y = oVar4.vr.y;

        sVar2 = (short)(oVar4.health - 5);
        oVar4.health = sVar2;

        if (sVar2 < 10)
            oVar4.health = 10;

        param1.IDAT_1C4 = 20;
    }

    //FUN_F5E0 (ST4)
    private void FUN_F5E0(CriPlayer param1)
    {
        short sVar1;
        byte bVar2;
        short sVar3;
        bool bVar4;
        int iVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)param1.DAT_154;
        param1.FUN_60AB4();
        sVar3 = param1.DAT_112;

        if (sVar3 < 1)
        {
            if (oVar5.frame.DAT_01 == 24)
            {
                param1.DAT_3D = 5;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_12C &= 0xffef;
                param1.SetSkeletonPrevious(param1);
                GameManager.instance.DAT_922C &= (byte)~(1 << param1.DAT_2E & 31);
                bVar2 = (byte)(GameManager.instance.DAT_922D - 1);
                GameManager.instance.DAT_922D = bVar2;

                if (bVar2 == 0)
                    oVar5.DAT_3D++;

                oVar5.FUN_4FE30();
            }
        }
        else
        {
            bVar4 = GameManager.FUN_64C68();
            sVar1 = -5;

            if (!bVar4)
                sVar1 = -1;

            param1.DAT_112 = (short)(sVar3 + sVar1);
        }

        iVar4 = param1.IDAT_1C4 - 1;
        
        if (param1.IDAT_1C4 == 0)
        {
            sVar3 = (short)(oVar5.health - 5);
            oVar5.health = sVar3;

            if (sVar3 < 10)
                oVar5.health = 10;

            iVar4 = 20;
        }

        param1.IDAT_1C4 = iVar4;
    }

    //FUN_F734 (ST4)
    private void FUN_F734(CriPlayer param1)
    {
        CriSkinned oVar1;
        CriObject oVar2;

        oVar1 = param1.DAT_154;
        PTR_FUN_140E4[param1.DAT_3E](param1);
        oVar2 = Utilities.FUN_601C8(oVar1.skeleton, 8);
        param1.DAT_14C = oVar2.screen;
        param1.FUN_65714();
    }

    //FUN_F7B4 (ST4)
    private void FUN_F7B4(CriPlayer param1)
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
            GameManager.instance.FUN_5C94C(param1, DAT_140EC[uVar1 & 1]);
        }
    }

    //FUN_F880 (ST4)
    private void FUN_F880(CriPlayer param1)
    {
        byte bVar1;
        byte bVar2;
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
            bVar2 = (byte)(param1.DAT_3E + 1);
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
            bVar2 = (byte)(param1.DAT_3E - 1);
        }

        param1.DAT_3E = bVar2;
        param1.FUN_609C8(iVar5, 1, 10);
    }

    //FUN_F97C (ST4)
    private void FUN_F97C(CriPlayer param1)
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
            uVar4 = param1.UDAT_1DA;

            if (uVar4 == 0)
                return; //trap(0x1c00)

            if (uVar4 == 0xffffffff && iVar7 == -0x80000000)
                return; //trap(0x1800)

            puVar6 = param1.PDAT_1D4[iVar7 % (int)uVar4];
            param1.DAT_158.x = puVar6.x;
            param1.DAT_158.z = puVar6.y;
            param1.SDAT_1D8 = (short)puVar6.z;
            param1.BDAT_1DC = (byte)(iVar7 % (int)uVar4);
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

    //FUN_FB94 (ST4)
    private void FUN_FB94(CriPlayer param1)
    {
        byte bVar1;
        byte bVar2;
        bool bVar3;
        uint uVar4;

        bVar1 = param1.DAT_3E;

        if (bVar1 == 1)
        {
            bVar3 = param1.FUN_60AB4();

            if (bVar3)
            {
                param1.screen.y = 0;
                uVar4 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_13E48[uVar4 & 1]);

                if ((param1.DAT_1C0 & 2) != 0)
                {
                    GameManager.instance.FUN_774CC(param1, param1.DAT_158);

                    if (param1.DAT_148 < 4)
                    {
                        param1.DAT_3E++;
                        param1.FUN_609C8(8, 1, 10);
                        param1.DAT_40.y = 0;
                        param1.DAT_40.z = 70;
                        return;
                    }

                    uVar4 = GameManager.FUN_64650();
                    param1.FUN_609C8(DAT_140F0[uVar4 & 1], 0, 0);
                }
            }

            param1.FUN_65890();
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    param1.DAT_3E = 1;
                    param1.FUN_609C8(13, 0, 0);
                }
            }
            else
            {
                if (bVar1 == 2)
                {
                    param1.FUN_60AB4();
                    bVar2 = param1.frame.DAT_01;

                    if (bVar2 == 3 || bVar2 == 11)
                    {
                        uVar4 = GameManager.FUN_64650();
                        GameManager.instance.FUN_5C94C(param1, DAT_13E48[uVar4 & 1]);
                    }
                }
            }
        }
    }

    //FUN_FD30 (ST4)
    private void FUN_FD30(CriPlayer param1)
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

                if (param1.PDAT_1C8.DAT_0B <= param1.DAT_1DD)
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
            param1.DAT_3F = 0;
        }
    }

    //FUN_FDD4 (ST4)
    private void FUN_FDD4(CriPlayer param1, CriPlayer param2)
    {
        bool bVar2;
        int iVar2;

        if (param1.DAT_3F == 0)
        {
            param1.FUN_609C8(2, 0, 10);
            param1.DAT_3F++;
        }
        else
        {
            if (param1.DAT_3F == 1)
            {
                bVar2 = param1.FUN_60AB4();

                if (bVar2)
                {
                    param1.DAT_3F = 0;
                    param1.DAT_3E++;
                    param1.FUN_609C8(13, 1, 0);
                    param1.UDAT_1D2 = (ushort)param2.vr.x;
                    param1.screen.y = 0;
                }

                iVar2 = (int)GameManager.FUN_64650();
                param1.DAT_112 = (short)(iVar2 + (iVar2 / 30) * -30 + 60);
            }
        }
    }

    //FUN_FECC (ST4)
    private void FUN_FECC(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        int iVar5;

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.screen.y = 0;
            uVar4 = GameManager.FUN_64650();

            if ((uVar4 & 1) == 0)
                iVar5 = 3;
            else
                iVar5 = 13;

            param1.FUN_609C8(iVar5, 0, 0);
            uVar4 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_13E48[uVar4 & 1]);
        }

        param1.FUN_65890();
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 80, sVar1);
        param1.vr.y += sVar2;

        if (param1.DAT_148 < 6)
            param1.DAT_3E++;
    }

    //FUN_FFA8 (ST4)
    private void FUN_FFA8(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        ushort uVar2;
        int iVar3;
        bool bVar3;
        uint uVar4;
        int iVar5;

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.screen.y = 0;
            uVar4 = GameManager.FUN_64650();
            iVar5 = 13;

            if ((uVar4 & 1) == 0)
                iVar5 = 3;

            param1.FUN_609C8(iVar5, 0, 0);
            uVar4 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_13E48[uVar4 & 1]);
        }

        param1.FUN_65890();

        if (param1.DAT_3F == 0)
        {
            iVar3 = param1.FUN_64804(param2.screen);

            if ((iVar3 + 0x300 & 0xfff) < 0x600)
                param1.UDAT_1D2 = (ushort)param1.vr.y;
        }

        sVar1 = (short)Utilities.FUN_64838(param1.vr.y, 80, param1.UDAT_1D2);
        param1.vr.y += sVar1;

        if (param1.DAT_142 == 0 && param1.DAT_12A == 0)
            param1.DAT_1D0 &= 0xfffe;
        else
        {
            if ((param1.DAT_1D0 & 1) == 0)
            {
                param1.DAT_1D0 |= 1;
                param1.DAT_3F = 0;
                param1.UDAT_1D2 = (ushort)(param1.vr.y + 0x800 & 0xfff);

                if (param1.DAT_12A != 0)
                    param1.DAT_3F = 1;
            }
        }

        if (6 < param1.DAT_148)
        {
            param1.DAT_3E++;
            uVar2 = (ushort)Utilities.FUN_615EC(param1.screen, param2.screen);
            param1.UDAT_1D2 = uVar2;
        }

        if (11 < param1.DAT_148)
        {
            param1.DAT_3E = 1;
            param1.DAT_3F = 0;
        }
    }

    //FUN_1014C (ST4)
    private void FUN_1014C(CriPlayer param1, CriPlayer param2)
    {
        short sVar1;
        bool bVar2;
        uint uVar3;
        short sVar4;
        int iVar5;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.screen.y = 0;
            uVar3 = GameManager.FUN_64650();
            iVar5 = 13;

            if ((uVar3 & 1) == 0)
                iVar5 = 4;

            param1.FUN_609C8(iVar5, 0, 0);
            uVar3 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_13E48[uVar3 & 1]);
        }

        param1.FUN_65890();
        param1.DAT_40.z = 0;
        sVar1 = (short)Utilities.FUN_64838(param1.vr.y, 80, param1.UDAT_1D2);
        param1.vr.y += sVar1;

        if (param1.DAT_40.x == 0)
        {
            uVar3 = GameManager.FUN_64650();
            sVar4 = 5;

            if ((uVar3 & 1) != 0)
                sVar4 = -5;

            param1.DAT_40.x = sVar4;
        }
        else
            param1.DAT_40.x = -param1.DAT_40.x;

        if (2 < param1.DAT_148 - 6)
        {
            param1.DAT_3F = 1;
            param1.DAT_3E--;
            param1.UDAT_1D2 = (ushort)(param1.vr.y + 0x800 & 0xfff);
        }

        if (11 < param1.DAT_148)
        {
            param1.DAT_3E = 1;
            param1.DAT_3F = 0;
        }
    }

    //FUN_10284 (ST4)
    private void FUN_10284(CriPlayer param1)
    {
        int iVar1;
        uint uVar2;
        int iVar3;
        CriPlayer oVar3;

        oVar3 = (CriPlayer)param1.DAT_154;

        if (param1.DAT_3E != 0)
            param1.DAT_40.y += param1.SDAT_1CC;

        iVar1 = (int)Utilities.FUN_63160(param1.screen, oVar3.screen);
        PTR_FUN_140FC[param1.DAT_3E](param1, oVar3);

        if (param1.frame.DAT_01 == 5)
        {
            iVar3 = (int)GameManager.FUN_64650();

            if (iVar3 == (iVar3 / 30) * 30)
            {
                uVar2 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_13E4C[uVar2 & 1]);
            }
        }
    }

    //FUN_10374 (ST4)
    private void FUN_10374(CriPlayer param1)
    {
        param1.DAT_40.y = -60;
        param1.SDAT_1CC = 6;
        param1.PTR_120 = null;
        param1.DAT_120 = 0;
        param1.PTR_130 = null;
        param1.DAT_130 = 0;
        param1.DAT_40.z = 80;
        param1.DAT_3E++;
        param1.FUN_609C8(3, 1, 0);
        param1.vr.y = param1.SDAT_1D8;
        param1.DAT_11E |= 0x40;
        param1.DAT_144 &= 0x7fff;
    }

    //FUN_10400 (ST4)
    private void FUN_10400(CriPlayer param1)
    {
        bool bVar1;
        CriInteract oVar2;

        bVar1 = param1.FUN_60AB4();

        if (!bVar1)
            param1.FUN_65890();
        else
        {
            oVar2 = param1.PDAT_1C8;

            if (oVar2 != null)
            {
                oVar2.DAT_14++;
                //...
            }

            //...
        }
    }

    //FUN_10510 (ST4)
    private void FUN_10510(CriPlayer param1)
    {
        PTR_FUN_1410C[param1.DAT_3E](param1);
    }

    //FUN_1054C (ST4)
    private void FUN_1054C(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(13, 0, 0);
    }

    //FUN_10584 (ST4)
    private void FUN_10584(CriPlayer param1)
    {
        bool bVar1;
        CriInteract oVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            oVar1 = param1.PDAT_1C8;

            if (oVar1 != null)
                oVar1.BDAT_08 |= 1;

            param1.PTR_120 = DAT_13E24;
            param1.DAT_120 = 0;
            param1.PTR_130 = DAT_13E24;
            param1.DAT_130 = 0;
            param1.DAT_144 |= 0x8000;
            param1.DAT_11E &= 0xbf;
            param1.DAT_13C = new Vector2Int(param1.screen.x, param1.screen.z);
        }

        param1.FUN_65890();
    }

    //FUN_10628 (ST4)
    private void FUN_10628(CriPlayer param1)
    {
        PTR_FUN_14118[param1.DAT_3E](param1);
    }

    //FUN_10664 (ST4)
    private void FUN_10664(CriPlayer param1)
    {
        PTR_FUN_14120[param1.DAT_3D](param1);
        PTR_FUN_14144[param1.DAT_3D](param1);
    }

    //FUN_10D80 (ST4)
    public void FUN_10D80(CriPlayer param1)
    {
        ushort uVar1;

        uVar1 = (ushort)(param1.DAT_1A0 >> 4 & 0xf);
        param1.DAT_11E &= 0x7f;
        //...
        param1.DAT_3C = 3;
        param1.DAT_3D = 0;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_11E |= 0x40;
    }

    //FUN_11020 (ST4)
    public void FUN_11020(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        bool bVar2;
        int iVar3;
        uint uVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)param1.DAT_154;
        param1.PTR_120 = DAT_13E24;
        param1.DAT_120 = 1;
        bVar2 = SceneManager.instance.FUN_802B8(param1, false, 1);

        if (!bVar2) goto LAB_11230;

        if ((param1.DAT_1C0 & 0x40) == 0)
            iVar2 = (GameManager.instance.DAT_922D == 0 ? 1 : 0) << 1;
        else
        {
            iVar2 = 1;

            if (GameManager.instance.DAT_922D == 0)
            {
                iVar2 = 2;
                uVar4 = GameManager.FUN_64650();

                if ((0x24U >> (int)(uVar4 & 7) & 1) != 0)
                    iVar2 = 1;
            }
        }

        param1.DAT_1C0 &= 0xffffff9f;
        iVar3 = Utilities.FUN_615EC(oVar5.screen, param1.screen);
        uVar4 = (uint)(((iVar3 - oVar5.vr.y & 0xfff) + 0x200 & 0xfff) >> 10);

        if (iVar2 == 1)
        {
            param1.DAT_2E = (byte)uVar4;

            if ((uVar4 & 1) == 0)
            {
                param1.DAT_2E = (byte)(uVar4 >> 1);

                if ((GameManager.instance.DAT_922C >> (param1.DAT_2E & 0x1f) & 1) == 0)
                {
                    GameManager.instance.DAT_922C |= (byte)(1 << (param1.DAT_2E & 0x1f));
                    param1.DAT_3D = 4;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_40 = new Vector3Int(0, 0, 0);
                    param1.PTR_120 = null;
                    param1.DAT_120 = 0;
                    GameManager.instance.DAT_922D++;
                    //FUN_1D988
                    goto LAB_11230;
                }
            }

            param1.DAT_3E++;
        }
        else
        {
            if (iVar2 != 2) goto LAB_11230;

            oVar5.FUN_539F8(0, 200, (int)uVar4);
            param1.DAT_3E++;
            sVar1 = (short)(oVar5.health - 10);
            oVar5.health = sVar1;

            if (sVar1 < 10)
                oVar5.health = 10;

            //FUN_1D988
        }

        LAB_11230:
        param1.PTR_120 = DAT_13E24;
        param1.DAT_120 = 0;
    }

    //FUN_11250 (ST4)
    public void FUN_11250(CriPlayer param1)
    {
        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E = 1;
            param1.DAT_40 = new Vector3Int(0, 0, 0);
            param1.FUN_609C8(12, 1, 10);
            GameManager.instance.FUN_5C94C(param1, 3);
            //...
        }

        param1.FUN_60AB4();
        param1.DAT_1C0 &= 0xfffffffe;
    }

    //FUN_11364 (ST4)
    public void FUN_11364(CriInteract param1)
    {
        byte bVar1;
        CriStatic oVar2;
        int iVar3;
        int iVar4;
        uint uVar5;
        CriPlayer oVar6;

        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        
        if ((oVar6.DAT_240 & 0xf0) == 0)
        {
            param1.FUN_5FF98();
            InventoryManager.FUN_4A7E8(2, 9, false);
            return;
        }

        InventoryManager.FUN_4A7E8(2, 9, true);
        bVar1 = oVar6.DAT_240;
        param1.DAT_02 = bVar1;
        uVar5 = (uint)(bVar1 >> 4);
        iVar3 = (int)(uVar5 + 31);
        param1.DAT_04 = (byte)iVar3;
        oVar2 = SceneManager.instance.DAT_7CDC[iVar3];
        iVar4 = InventoryManager.instance.FUN_68C18(oVar6.DAT_240);
        InventoryManager.FUN_4A7E8(11, (uint)iVar4, false);
        oVar2.flags = 1;
        oVar2.DAT_40 = null;
        oVar6.DAT_240 = 0;
        oVar6.FUN_4FE90(0);
        oVar2.screen = oVar6.screen;
        oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(PTR_DAT_141B0[uVar5 - 1]);
        oVar2.cCollider = null;
        oVar2.vr = new Vector3Int(0, 0, 0);
        oVar2.flags |= 2;
        param1.DAT_08 = 0;
        param1.DAT_0A = 0;
        param1.DAT_0C = 0;
        param1.DAT_0E = 0;
        param1.DAT_03++;
    }

    //FUN_114D4 (ST4)
    private void FUN_114D4(CriInteract param1)
    {
        CriStatic oVar1;

        oVar1 = SceneManager.instance.DAT_7CDC[param1.DAT_04];
        oVar1.vr.x += 0x200;
        param1.DAT_0A += 0x20;
        oVar1.screen.x += param1.DAT_08;
        oVar1.screen.y += param1.DAT_0A;
        oVar1.screen.z += param1.DAT_0C;

        if (0 < oVar1.screen.y)
        {
            oVar1.screen.y = 0;
            GameManager.instance.FUN_5C94C(oVar1, 19);
            param1.DAT_0A = 0x280;
            oVar1.vr.x = 0;
            oVar1.vr.z = 0x400;
            param1.DAT_03++;
        }
    }

    //FUN_115B0 (ST4)
    private void FUN_115B0(CriInteract param1)
    {
        short sVar1;
        CriStatic oVar2;

        oVar2 = SceneManager.instance.DAT_7CDC[param1.DAT_04];
        oVar2.vr.y += param1.DAT_0A;
        sVar1 = param1.DAT_0A;
        param1.DAT_0A = (short)(sVar1 - 0x20);

        if (sVar1 == 0x20)
        {
            //FUN_1A6B8
            oVar2.cCollider = null;
            param1.DAT_03++;
        }

        oVar2.screen.x += param1.DAT_08;
        oVar2.screen.z += param1.DAT_0C;
    }

    //FUN_120C4 (ST4)
    private void FUN_120C4(CriInteract param1)
    {
        if (!param1.DAT_09 && param1.DAT_0B == param1.DAT_16)
        {
            InventoryManager.FUN_4A7E8(4, PTR_DAT_145E0[param1.DAT_02 * 3], true);
            param1.DAT_03++;
        }
    }

    //FUN_252C (ST4)
    public static void FUN_252C(CriPlayer param1)
    {
        param1.FUN_252C();
    }

    //FUN_346C (ST4)
    public static void FUN_346C(CriParticle param1)
    {
        param1.FUN_346C();
    }

    //FUN_3648 (ST4)
    public static void FUN_3648(CriParticle param1)
    {
        param1.FUN_3648();
    }

    //FUN_3760 (ST4)
    public static void FUN_3760(CriParticle param1)
    {
        param1.FUN_3760();
    }

    //FUN_3828 (ST4)
    public static void FUN_3828(CriParticle param1)
    {
        param1.FUN_3828();
    }

    //FUN_3AB8 (ST4)
    public static void FUN_3AB8(CriPlayer param1)
    {
        param1.FUN_3AB8();
    }

    //FUN_9D30 (ST4)
    public static void FUN_9D30(CriPlayer param1)
    {
        return;
    }

    //FUN_10E38 (ST4)
    public static void FUN_10E38(CriPlayer param1)
    {
        param1.FUN_10E38();
    }

    //FUN_112EC (ST4)
    public static void FUN_112EC(CriPlayer param1)
    {
        return;
    }

    //FUN_11328 (ST4)
    public static void FUN_11328(CriInteract param1)
    {
        return;
    }

    //FUN_1167C (ST4)
    public static void FUN_1167C(CriInteract param1)
    {
        return;
    }

    //FUN_11854 (ST4)
    public static void FUN_11854(CriInteract param1)
    {
        return;
    }

    //FUN_12140 (ST4)
    public static void FUN_12140(CriInteract param1)
    {
        return;
    }

    //FUN_123BC (ST4)
    public static void FUN_123BC(CriInteract param1)
    {
        return;
    }

    //FUN_123F8 (ST4)
    public static void FUN_123F8(CriInteract param1)
    {
        return;
    }
}
