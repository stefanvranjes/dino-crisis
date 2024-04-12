using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST6 : LevelManager
{
    public static new ST6 instance;

    public uint[] DAT_15A78 = new uint[232] { 0, 0xd, 0x1b, 0x23, 0x2b, 0x39, 0x43, 0x80000057, 0x0, 0x6, 0x11, 0x16, 0x20, 0x23, 0x33, 0x42, 0x80000057, 0x0, 0x12, 0x21, 0x2e, 0x3e, 0x44, 0x80000053, 0x0, 0x1e, 0x2d, 0x42, 0x4b, 0x80000075, 0x0, 0x15, 0x28, 0x3c, 0x4a, 0x80000055, 0x0, 0x8, 0x18, 0x2a, 0x37, 0x80000052, 0x0, 0x5, 0x10, 0x1f, 0x32, 0x39, 0x47, 0x8000005b, 0x0, 0xd, 0xf, 0x1f, 0x26, 0x29, 0x2d, 0x33, 0x47, 0x8000005c, 0x0, 0x3, 0xb, 0xe, 0x1e, 0x21, 0x29, 0x3a, 0x80000065, 0x0, 0xc, 0x13, 0x29, 0x2e, 0x3c, 0x40, 0x44, 0x4c, 0x8000005a, 0x0, 0xf, 0x1e, 0x26, 0x2c, 0x3e, 0x4a, 0x80000059, 0x0, 0xe, 0x1a, 0x1d, 0x22, 0x2c, 0x31, 0x3f, 0x43, 0x48, 0x4c, 0x80000059, 0x0, 0x14, 0x20, 0x28, 0x3c, 0x50, 0x80000066, 0x0, 0x17, 0x1f, 0x24, 0x26, 0x33, 0x36, 0x45, 0x4b, 0x80000056, 0x0, 0xf, 0x14, 0x1d, 0x29, 0x2e, 0x33, 0x38, 0x44, 0x4f, 0x80000052, 0x0, 0xb, 0x14, 0x22, 0x2a, 0x37, 0x3d, 0x4f, 0x80000059, 0x0, 0x10, 0x15, 0x25, 0x37, 0x3d, 0x45, 0x4c, 0x80000056, 0x0, 0x4, 0x7, 0xd, 0x11, 0x1c, 0x2f, 0x38, 0x44, 0x80000051, 0x0, 0xe, 0x1f, 0x33, 0x42, 0x4c, 0x80000059, 0x0, 0x5, 0x13, 0x1c, 0x28, 0x33, 0x47, 0x50, 0x8000005d, 0x0, 0x5, 0xf, 0x17, 0x21, 0x2d, 0x36, 0x46, 0x80000051, 0x0, 0x6, 0xe, 0x1d, 0x22, 0x2d, 0x3d, 0x43, 0x80000055, 0x0, 0x5, 0xd, 0x15, 0x24, 0x2b, 0x35, 0x45, 0x80000052, 0x0, 0x7, 0x27, 0x3a, 0x80000056, 0x0, 0x13, 0x31, 0x42, 0x8000005e, 0x0, 0x11, 0x2b, 0x3c, 0x4f, 0x80000060, 0x0, 0xe, 0x20, 0x3d, 0x4e, 0x80000063, 0x0, 0x11, 0x21, 0x29, 0x35, 0x3e, 0x80000054, 0x0, 0x8, 0x27, 0x37, 0x80000046 };
    public TrgScriptableObject DAT_15E18; //0x15E18 (ST6)
    public TrgScriptableObject DAT_15F08; //0x15F08 (ST6)
    public byte[][] DAT_15FF8 = new byte[3][]
    {
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 },
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 },
        new byte[48] { 29, 0, 0, 0, 27, 0, 0, 0, 32, 10, 6, 5, 33, 0, 0, 0, 34, 0, 0, 0, 35, 20, 11, 6, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 30, 26, 21, 24, 0, 0, 0, 25, 31, 31, 31 }
    };
    public FUN_B58BC[] DAT_16088 = new FUN_B58BC[] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758,
                                                     FUN_45B08, null, FUN_45480, null, null, null, FUN_45D38,
                                                     FUN_45E70, null, null, FUN_CD5C, FUN_D550, FUN_DDEC,
                                                     FUN_DEF4, FUN_C904, FUN_CB2C, FUN_E0A8, FUN_E2B0,
                                                     FUN_E410, FUN_E59C, FUN_E73C, FUN_E8E4, FUN_EB5C };
    public FUN_B58C0[] DAT_160F8 = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, FUN_1B98, null, null,
                                                     null, null, FUN_3B5C };
    public FUN_C2570[] DAT_1611C = new FUN_C2570[] { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null,
                                                     FUN_15668, FUN_7F808, null, null, null, FUN_155E0 };
    public FUN_C1CF8[] DAT_1614C = new FUN_C1CF8[] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, FUN_21ECC,
                                                     FUN_22178, null, null, null, FUN_222AC, FUN_22464, FUN_2268C,
                                                     null, null, null, FUN_EB98, FUN_1200C, FUN_12048, FUN_14380,
                                                     FUN_F1A8, FUN_144A8, FUN_12D2C, FUN_14C04, FUN_14EA8,
                                                     FUN_153B0, FUN_153EC };
    private CapsuleCollider[] DAT_161E8; //0x161E8 (ST6)
    private short[] DAT_161F8 = new short[2] { 0, 0x800 };
    private short[] DAT_16228 = new short[14] { 4, -4, 20, -20, 20, -20, 10, -10, 8, -8, 2, -2, 1, -1 };
    private short[] DAT_16244 = new short[16] { 4, -4, 10, -10, 10, -10, 8, -8, 4, -4, 1, -1, 1, -1, 4, -400 };
    private delegate void FUN_162DC(CriPlayer p); //0x162DC (ST6)
    private delegate void FUN_166D8(CriPlayer p); //0x166D8 (ST6)
    private delegate void FUN_166F4(CriPlayer p); //0x16FF4 (ST6)
    private delegate void FUN_1674C(CriPlayer p); //0x1674C (ST6)
    private delegate void FUN_16894(CriPlayer p); //0x16894 (ST6)
    private delegate void FUN_1689C(CriPlayer p); //0x1689C (ST6)
    private delegate void FUN_168AC(CriPlayer p); //0x168AC (ST6)
    private delegate void FUN_16914(CriPlayer p); //0x16914 (ST6)
    private delegate void FUN_1691C(CriPlayer p); //0x1691C (ST6)
    private delegate void FUN_1692C(CriPlayer p); //0x1692C (ST6)
    private delegate void FUN_16970(CriPlayer p); //0x16970 (ST6)
    private delegate void FUN_1697C(CriPlayer p); //0x1697C (ST6)
    private delegate void FUN_16A08(CriPlayer p); //0x16A08 (ST6)
    private delegate void FUN_16A60(CriPlayer p); //0x16A60 (ST6)
    private delegate void FUN_16A68(CriPlayer p); //0x16A68 (ST6)
    private delegate void FUN_16A7C(CriPlayer p); //0x16A7C (ST6)
    private delegate void FUN_16A9C(CriPlayer p); //0x16A9C (ST6)
    private delegate void FUN_16AAC(CriPlayer p); //0x16AAC (ST6)
    private delegate void FUN_16AB4(CriPlayer p); //0x16AB4 (ST6)
    private delegate void FUN_16ABC(CriPlayer p); //0x16ABC (ST6)
    private delegate void FUN_16AC4(CriPlayer p); //0x16AC4 (ST6)
    private delegate void FUN_16ADC(CriPlayer p); //0x16ADC (ST6)
    private delegate void FUN_16B20(CriPlayer p); //0x16B20 (ST6)
    private delegate void FUN_16B28(CriPlayer p); //0x16B28 (ST6)
    private delegate void FUN_16B30(CriPlayer p); //0x16B30 (ST6)
    private delegate void FUN_16BB0(CriPlayer p); //0x16BB0 (ST6)
    private delegate void FUN_16BC4(CriPlayer p); //0x16BC4 (ST6)
    private delegate void FUN_16BCC(CriPlayer p); //0x16BCC (ST6)
    private delegate void FUN_16BE4(CriPlayer p); //0x16BE4 (ST6)
    private FUN_162DC[] PTR_FUN_162DC; //0x162DC (ST6)
    private Vector3Int DAT_16314 = new Vector3Int(-0x3000, -0x19A0, -0x2900); //0x16314
    private CapsuleCollider[] DAT_16488; //0x16488 (ST6)
    private CapsuleCollider[] DAT_16554; //0x16554 (ST6)
    private short[] DAT_16560 = new short[] { 0, 1, 0, 1, 0, 1, 0, 1, 175, 50, 200, 50, 225, 75, 225, 75 };
    private short[] DAT_16580 = new short[] { 125, 25, 150, 25, 150, 25, 250, 50 };
    private short[] DAT_16590 = new short[] { 800, 200, 800, 200, 800, 200, 800, 200 };
    private short[] DAT_165A0 = new short[] { 150, 25, 175, 25, 175, 25, 250, 50, 227, 50, 260, 50, 292, 75, 292, 75 };
    private short[] DAT_165C0 = new short[] { 0, 1, 0, 1, 0, 1, 0, 1, 100, 25, 125, 25, 150, 50, 150, 50 };
    private short[] DAT_165E0 = new short[] { 60, 20, 80, 20, 80, 20, 150, 50 };
    private short[] DAT_165F0 = new short[] { 400, 100, 400, 100, 400, 200, 400, 200 };
    private short[] DAT_16600 = new short[] { 80, 20, 100, 20, 100, 20, 150, 50, 130, 25, 162, 25, 195, 50, 195, 50 };
    private short[] DAT_16638 = new short[] { 0, -206, -101, -101, -101, -100, -99, -97, -94, -91, -87, -84, -78, -73, -67, -60, -53, -53, -58, -64, -68, -71, -74, -76, -78, -77, -78, -76, -75, -72, -68, -65, -59, -54, -47, -24, 8, 26, 34, 30 };
    private short[] DAT_16688 = new short[] { 0, 200, 115, 113, 111, 108, 105, 104, 101, 98, 97, 94, 93, 90, 88, 86, 86, 88, 88, 89, 89, 87, 87, 85, 82, 80, 77, 72, 68, 64, 57, 52, 46, 38, 31, 8, -22, -39, -44, -35 };
    private short[] DAT_168B4 = new short[] { 0, -100, -91, -79, -64, -47, -29, -8, 11, 25, 36, 43, 49, 51, 51, 47, 42, 32, 21, 7, -18, -41, -49, -40 };
    private short[] DAT_168E4 = new short[] { 0, 120, 117, 104, 85, 57, 23, -5, -15, -24, -31, -35, -36, -37, -33, -28, -21, -11, 6, 24, 35, 40, 36, 27 };
    private short[] DAT_16988 = new short[] { 0, -71, -74, -76, -78, -77, -78, -76, -75, -72, -68, -52, -27, -5, 14, 31, 45, 58, 67, 75, 79, 81, 78, 71, 64, 59, 55, 51, 50, 49, 50, 0 };
    private short[] DAT_169C8 = new short[] { 0, 61, 64, 65, 66, 68, 68, 66, 64, 60, 56, 50, 47, 49, 52, 53, 56, 58, 60, 62, 65, 67, 69, 71, 71, 72, 71, 71, 70, 67, 66, 0 };
    private short[] DAT_1693C = new short[] { 0, 34, 10, 4, 5, 5, 4, 5, 6, 5, 5, 3, 3, 2, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, -1, 0 };
    private short[] DAT_16A10 = new short[] { 0, 11, 10, 9, 10, 13, 16, 21, 27, 36, 45, 53, 55, 59, 59, 61, 61, 60, 59, 56 };
    private short[] DAT_16A38 = new short[] { 0, 28, 46, 60, 69, 73, 70, 64, 62, 62, 66, 70, 73, 74, 75, 74, 73, 70, 66, 61 };
    private FUN_166D8[] PTR_FUN_166D8; //0x166D8 (ST6)
    private FUN_166F4[] PTR_FUN_166F4; //0x166F4 (ST6)
    private FUN_1674C[] PTR_FUN_1674C; //0x1674C (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_167A4; //0x167A4 (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_167B8; //0x167B8 (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_167CC; //0x167CC (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_167E0; //0x167E0 (ST6)
    private FUN_16894[] PTR_FUN_16894; //0x16894 (ST6)
    private FUN_1689C[] PTR_FUN_1689C; //0x1689C (ST6)
    private FUN_168AC[] PTR_FUN_168AC; //0x168AC (ST6)
    private FUN_16914[] PTR_FUN_16914; //0x16914 (ST6)
    private FUN_1691C[] PTR_FUN_1691C; //0x1691C (ST6)
    private FUN_1692C[] PTR_FUN_1692C; //0x1692C (ST6)
    private FUN_16970[] PTR_FUN_16970; //0x16970 (ST6)
    private FUN_1697C[] PTR_FUN_1697C; //0x1697C (ST6)
    private FUN_16A08[] PTR_FUN_16A08; //0x16A08 (ST6)
    private FUN_16A60[] PTR_FUN_16A60; //0x16A60 (ST6)
    private FUN_16A68[] PTR_FUN_16A68; //0x16A68 (ST6)
    private FUN_16A7C[] PTR_FUN_16A7C; //0x16A7C (ST6)
    private FUN_16A9C[] PTR_FUN_16A9C; //0x16A9C (ST6)
    private FUN_16AAC[] PTR_FUN_16AAC; //0x16AAC (ST6)
    private FUN_16AB4[] PTR_FUN_16AB4; //0x16AB4 (ST6)
    private FUN_16ABC[] PTR_FUN_16ABC; //0x16ABC (ST6)
    private FUN_16AC4[] PTR_FUN_16AC4; //0x16AC4 (ST6)
    private FUN_16ADC[] PTR_FUN_16ADC; //0x16ADC (ST6)
    private FUN_16B20[] PTR_FUN_16B20; //0x16B20 (ST6)
    private FUN_16B28[] PTR_FUN_16B28; //0x16B28 (ST6)
    private FUN_16B30[] PTR_FUN_16B30; //0x16B30 (ST6)
    private FUN_16BB0[] PTR_FUN_16BB0; //0x16BB0 (ST6)
    private FUN_16BC4[] PTR_FUN_16BC4; //0x16BC4 (ST6)
    private FUN_16BCC[] PTR_FUN_16BCC; //0x16BCC (ST6)
    private FUN_16BE4[] PTR_FUN_16BE4; //0x16BE4 (ST6)
    private UNK_9B314[] PTR_DAT_16D20; //0x16D20 (ST6)
    private short[] DAT_16EAC = new short[] { -3500, 0, -1500, -1500 };
    private Vector3Int[] DAT_16EB4; //0x16EB4 (ST6)
    private short[] DAT_16ED4 = new short[] { -1500, 0, -1500, -1500, 120, 60 };
    private Vector3Int[] DAT_16EE0; //0x16EE0 (ST6)
    private ushort DAT_173F0; //0x173F0 (ST6)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_162DC = new FUN_162DC[6]
            {
                FUN_3190,
                FUN_18B4,
                FUN_18B4,
                FUN_1C04,
                FUN_1C84,
                FUN_1CFC
            };
            PTR_FUN_166D8 = new FUN_166D8[7]
            {
                FUN_AFE0,
                FUN_4094, 
                FUN_6A78, 
                FUN_7228, 
                FUN_77C4,
                FUN_7D80, 
                FUN_86C0
            };
            PTR_FUN_166F4 = new FUN_166F4[]
            {
                FUN_4108,
                FUN_496C,
                FUN_4210,
                FUN_4BB0,
                FUN_4100,
                FUN_4100,
                FUN_4FA0, 
                FUN_5444,
                FUN_4100,
                FUN_4100, 
                FUN_4100, 

            };
            PTR_FUN_1674C = new FUN_1674C[10]
            {
                FUN_4130,
                FUN_7828,
                FUN_484C,
                FUN_48D8,
                FUN_4AC0,
                FUN_4B08,
                FUN_484C,
                FUN_4D54,
                FUN_4DE8,
                FUN_4E30
            };
            PTR_FUN_167A4 = new CriInteract.FUN_0C[]
            {

            };
            PTR_FUN_167B8 = new CriInteract.FUN_0C[]
            {

            };
            PTR_FUN_16894 = new FUN_16894[2]
            {
                FUN_4DE8,
                FUN_69E8
            };
            PTR_FUN_1689C = new FUN_1689C[3]
            {
                FUN_6D08,
                FUN_6FE8,
                FUN_7128
            };
            PTR_FUN_168AC = new FUN_168AC[2]
            {
                FUN_6AB4,
                FUN_6BE4
            };
            PTR_FUN_16914 = new FUN_16914[2]
            {
                FUN_6D44,
                FUN_6E8C
            };
            PTR_FUN_1691C = new FUN_1691C[4]
            {
                FUN_7024,
                FUN_70E4,
                FUN_7164,
                FUN_71AC,
            };
            PTR_FUN_1692C = new FUN_1692C[4]
            {
                FUN_73B0,
                FUN_7528,
                FUN_7658,
                FUN_7788
            };
            PTR_FUN_16970 = new FUN_16970[6]
            {
                FUN_7264,
                FUN_72C8,
                FUN_4100,
                FUN_73EC,
                FUN_745C,
                FUN_4100
            };
            PTR_FUN_1697C = new FUN_1697C[3]
            {
                FUN_73EC,
                FUN_745C,
                FUN_4100
            };
            PTR_FUN_16A08 = new FUN_16A08[2]
            {
                FUN_7564,
                FUN_75E4
            };
            PTR_FUN_16A60 = new FUN_16A60[2]
            {
                FUN_7694,
                FUN_7714
            };
            PTR_FUN_16A68 = new FUN_16A68[1]
            {
                FUN_7828
            };
            PTR_FUN_16A7C = new FUN_16A7C[8]
            {
                FUN_7848,
                FUN_79D4,
                FUN_4100, 
                FUN_7848, 
                FUN_7A68, 
                FUN_4100, 
                FUN_7AFC, 
                FUN_7BDC
            };
            PTR_FUN_16A9C = new FUN_16A9C[4]
            {
                FUN_7F7C, 
                FUN_803C, 
                FUN_816C, 
                FUN_822C
            };
            PTR_FUN_16AAC = new FUN_16AAC[2]
            {
                FUN_7DBC, 
                FUN_7F04
            };
            PTR_FUN_16AB4 = new FUN_16AB4[2]
            {
                FUN_7FB8,
                FUN_801C
            };
            PTR_FUN_16ABC = new FUN_16ABC[2]
            {
                FUN_80C0,
                FUN_810C
            };
            PTR_FUN_16AC4 = new FUN_16AC4[2]
            {
                FUN_81A8,
                FUN_81F0
            };
            PTR_FUN_16ADC = new FUN_16ADC[]
            {
                FUN_8268,
                FUN_83F8,
                FUN_8464,
                FUN_84B8,
                FUN_8554,
                FUN_85EC,
                FUN_8660, 
                FUN_4100, 
                FUN_881C, 
                FUN_897C,
            };
            PTR_FUN_16B20 = new FUN_16B20[2]
            {
                FUN_8738,
                FUN_87B0
            };
            PTR_FUN_16B28 = new FUN_16B28[2]
            {
                FUN_8858,
                FUN_88D8
            };
            PTR_FUN_16B30 = new FUN_16B30[12]
            {
                FUN_89B8,
                FUN_8A14,
                FUN_8A54,
                FUN_8AA4,
                FUN_8B38,
                FUN_8BB4,
                FUN_8C04,
                FUN_8C54,
                FUN_8CE8,
                FUN_88D8,
                FUN_8DA4,
                FUN_8E00
            };
            PTR_FUN_16BB0 = new FUN_16BB0[5]
            {
                FUN_4100, 
                FUN_9E00, 
                FUN_9570, 
                FUN_AA84, 
                FUN_4100
            };
            PTR_FUN_16BC4 = new FUN_16BC4[2]
            {
                FUN_95D8,
                FUN_99EC
            };
            PTR_FUN_16BCC = new FUN_16BCC[6]
            {
                FUN_9E40,
                FUN_A2D0,
                FUN_A7E4,
                FUN_A838,
                FUN_A870,
                FUN_A8A8
            };
            PTR_FUN_16BE4 = new FUN_16BE4[2]
            {
                FUN_AAF0,
                FUN_AF68
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

    //FUN_10C (ST6)
    public override void Initialize()
    {
        bool bVar1;
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();

        PTR_FUN_B58BC = DAT_16088;
        PTR_FUN_B58C0 = DAT_160F8;
        PTR_FUN_C2570 = DAT_1611C;
        PTR_FUN_C1CF8 = DAT_1614C;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        SceneManager.instance.DAT_AC = DAT_15FF8[uVar3];
        SceneManager.instance.DAT_B0 = DAT_15A78;
        GameManager.instance.DAT_46 = 6;
        bVar1 = InventoryManager.FUN_4A87C(0, 0xe2);

        if (!bVar1)
        {
            for (int i = 0; i < DAT_15E18.TRIGGERS.Length; i++)
            {
                puVar4 = SceneManager.instance.DAT_9EEC[i];
                puVar5 = DAT_15E18.TRIGGERS[i];
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
        }
        else
        {
            for (int i = 0; i < DAT_15F08.TRIGGERS.Length; i++)
            {
                puVar4 = SceneManager.instance.DAT_9EEC[i];
                puVar5 = DAT_15F08.TRIGGERS[i];
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
        }

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 6);
    }

    //FUN_2AC (ST6)
    private void FUN_2AC(CriPlayer param1)
    {
        CriCamera cVar1;
        ushort uVar2;

        cVar1 = SceneManager.instance.cCamera;
        uVar2 = (ushort)(param1.UDAT_1D2 >> 8 & 0x7f);
        cVar1.DAT_38 = (short)(DAT_16244[param1.UDAT_1D2 & 0xff] * uVar2);
        cVar1.DAT_3A = (short)(DAT_16228[param1.UDAT_1D2 & 0xff] * uVar2);
        uVar2 = (ushort)(param1.UDAT_1D2 + 1);
        param1.UDAT_1D2 = uVar2;

        if (13 < (uVar2 & 0xffU))
            param1.UDAT_1D2 = 0;
    }

    //FUN_658 (ST6)
    private void FUN_658(CriPlayer param1)
    {
        if (param1.DAT_2F != 4 || (!InventoryManager.FUN_4A87C(3, 0x3f) && !InventoryManager.FUN_4A87C(3, 0x3e)))
            InventoryManager.FUN_4A7E8(3, 0x22, true);
    }

    //FUN_7DC (ST6)
    private void FUN_7DC(CriPlayer param1)
    {
        byte bVar1;
        bool bVar2;
        CriSkinned oVar5;

        oVar5 = param1.DAT_154;

        if ((param1.DAT_11E & 0x80) == 0)
            return;

        param1.DAT_11E &= 0x7f;

        if (param1.DAT_3C == 4)
            return;

        bVar2 = InventoryManager.FUN_4A87C(3, 0x20);

        if (bVar2)
            return;

        bVar1 = (byte)(param1.DAT_1A0 >> 4);

        if (bVar1 == 3)
            param1.DAT_1ED++;

        if (param1.DAT_3D == 2)
            return;

        //...
    }

    //FUN_18B4 (ST6)
    private void FUN_18B4(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        bool bVar2;
        uint uVar3;
        CriPlayer oVar4;
        Vector3Int local_18;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) == 0)
        {
            if (param1.DAT_3C == 0 || (param1.DAT_18E & 0x80) == 0)
            {
                param1.cTransform.position = param1.screen;
                FUN_7DC(param1);
                //...
                param1.vr.y &= 0xfff;

                if (param1.DAT_3C != 4)
                {
                    local_18 = new Vector3Int(0, DAT_161F8[param1.DAT_2F - 3], 0);
                    Utilities.RotMatrix_gte(ref local_18, ref param1.cTransform.rotation);
                }

                param1.FUN_62F3C(ref param1.DAT_40);
                //...

                if (param1.DAT_3D == 0)
                {
                    if ((param1.DAT_1C0 & 2) != 0 && 0x20 < param1.frame.DAT_01)
                    {
                        param1.PTR_120 = DAT_161E8;
                        param1.DAT_120 = 0;
                        bVar2 = SceneManager.instance.FUN_802B8(param1, false, 1);

                        if (bVar2)
                        {
                            oVar4 = (CriPlayer)param1.DAT_154;
                            iVar2 = Utilities.FUN_615EC(oVar4.screen, param1.screen);
                            oVar4.FUN_539F8(1, 300, ((iVar2 - oVar4.vr.y & 0xfff) + 0x200 & 0xfff) >> 10);
                            sVar1 = (short)(oVar4.health - 250);
                            oVar4.health = sVar1;

                            if (sVar1 < 100)
                                oVar4.health = 100;

                            //FUN_1D988
                            oVar4.DAT_177 = 30;
                        }

                        param1.PTR_120 = null;
                        param1.DAT_120 = 0;
                    }
                }
                else
                    param1.FUN_66208();
            }

            if (param1.DAT_3C == 4)
                uVar3 = param1.flags & 0xfffffffb;
            else
                uVar3 = param1.flags | 4;

            param1.flags = uVar3;
        }
    }

    //FUN_1C04 (ST6)
    private void FUN_1C04(CriPlayer param1)
    {
        param1.DAT_3D++;
        param1.FUN_609C8(9, 0, 0);
        param1.FUN_65714();
        param1.PTR_120 = null;
        param1.DAT_120 = 0;
        param1.PTR_130 = null;
        param1.DAT_130 = 0;
        param1.DAT_1C0 &= 0xfffffffe;
        param1.DAT_140 |= 0x8000;
        param1.DAT_12C |= 8;
        param1.FUN_66418();
    }

    //FUN_1C84 (ST6)
    private void FUN_1C84(CriPlayer param1)
    {
        CriSkinned oVar1;

        oVar1 = param1.DAT_154;
        param1.FUN_60AB4();
        param1.FUN_65714();

        if (oVar1.frame.DAT_03 == 100)
        {
            SceneManager.instance.DAT_272 = false;
            SceneManager.instance.DAT_270 = 3;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_1CFC (ST6)
    private void FUN_1CFC(CriPlayer param1)
    {
        short sVar1;

        param1.FUN_65714();
        sVar1 = param1.DAT_112;
        param1.DAT_112 = (short)(sVar1 - 1);

        if (sVar1 == 1)
        {
            SceneManager.instance.DAT_272 = false;
            SceneManager.instance.DAT_270 = 3;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_3190 (ST6)
    private void FUN_3190(CriPlayer param1)
    {
        sbyte sVar1;
        bool bVar2;
        CriBone oVar2;
        uint uVar3;
        byte bVar4;
        SceneColliderScriptableObject oVar5;
        Vector3Int local_18;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) != 0 || param1.DAT_3C != 0 &&
            (param1.DAT_18E & 0x80) != 0) goto LAB_348C;

        param1.DAT_34 = param1.screen;

        if (param1.DAT_3C != 0)
        {
            local_18 = new Vector3Int(param1.PTR_130[param1.DAT_130].pos.x, 0, param1.PTR_130[param1.DAT_130].pos.y);
            local_18 = Utilities.ApplyMatrixSV(ref param1.cTransform.rotation, ref local_18);
            sVar1 = param1.PTR_130[param1.DAT_130].bone;

            if (sVar1 == -1)
            {
                local_18.x += param1.screen.x;
                local_18.z += param1.screen.z;
            }
            else
            {
                oVar2 = (CriBone)Utilities.FUN_601C8(param1.skeleton, sVar1);
                local_18.x += oVar2.screen.x;
                local_18.z += oVar2.screen.z;
            }

            uVar3 = (uint)(int)GameManager.instance.FUN_7732C((ushort)local_18.x, (ushort)local_18.z, 0);

            if ((uVar3 & 0xff) == param1.DAT_1EB)
            {
                uVar3 = param1.DAT_1EB + 1U & 7;
                param1.DAT_1EB = (byte)uVar3;
                param1.DAT_158.x = DAT_16314.x;
                param1.DAT_158.z = DAT_16314.z;
            }

            GameManager.instance.FUN_774CC(param1, param1.DAT_158);
        }

        //...

        param1.vr.y &= 0xfff;
        SceneManager.instance.FUN_802B8(param1, true, 1);
        param1.FUN_62F3C(ref param1.DAT_40);

        if (param1.IDAT_1C4 != 0)
            param1.IDAT_1C4--;

        SceneManager.instance.FUN_80A14(param1);
        //FUN_61C

        LAB_348C:
        if (param1.DAT_3C == 4 || (param1.DAT_1C0 & 2) != 0)
            uVar3 = param1.flags & 0xfffffffb;
        else
            uVar3 = param1.flags | 4;

        param1.flags = uVar3;
    }

    //FUN_3E5C (ST6)
    private void FUN_3E5C(CriPlayer param1)
    {
        bool bVar1;
        CriPlayer oVar2;
        int iVar3;

        param1.screen.y = 0;
        param1.DAT_3C++;
        param1.FUN_6449C(param1.DAT_140);
        param1.FUN_77784(1, 0x250);
        param1.DAT_175 = 1;
        param1.DAT_3D = 1;
        FUN_AFE0(param1);

        if (param1.maxHealth == 0)
            FUN_B058(param1);

        param1.health = param1.maxHealth;

        if (0 < param1.DAT_196)
        {
            param1.DAT_3C = 5;
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        oVar2 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

        if (oVar2 == null)
            param1.DAT_1C8 = 1;
        else
        {
            if (oVar2.DAT_1C5 != 1)
                param1.DAT_1C8 = 1;
        }

        FUN_B4AC(param1);
        FUN_B4C4(param1);
        param1.PTR_130 = DAT_16488;
        param1.DAT_130 = 11;
        param1.DAT_18D = true;
        param1.FUN_65D0C(0, 30);
        param1.FUN_66404(0, 0x2000, 0x2000);
        param1.FUN_65984(18, 14);
        iVar3 = 0;

        do
        {
            if ((param1.DAT_19A >> (iVar3 & 31) & 1) != 0)
            {
                bVar1 = FUN_B708(param1, (uint)(byte)iVar3 >> 2, (uint)iVar3 & 3);

                if (bVar1)
                    param1.DAT_199++;
            }

            iVar3++;
        } while ((byte)iVar3 < 16);

        param1.FUN_609C8(1, 1, 0);
    }

    //FUN_3FE0 (ST6)
    private void FUN_3FE0(CriPlayer param1)
    {
        if (param1.DAT_3C != 1 && param1.DAT_3D != 6 && param1.DAT_3D != 7)
            FUN_4050(param1);
    }

    //FUN_4050 (ST6)
    private void FUN_4050(CriPlayer param1)
    {
        if (param1.DAT_3D != 37)
            PTR_FUN_166F4[param1.DAT_3D](param1);
    }

    //FUN_40F0 (ST6)
    private void FUN_4094(CriPlayer param1)
    {
        if (param1.DAT_3D == 37)
            FUN_6A3C(param1);
        else
        {
            
        }
    }

    //FUN_4100 (ST6)
    private void FUN_4100(CriPlayer param1)
    {
        return;
    }

    //FUN_4108 (ST6)
    private void FUN_4108(CriPlayer param1)
    {
        if (SceneManager.instance.DAT_27C[10].DAT_3C != 5)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_4130 (ST6)
    private void FUN_4130(CriPlayer param1)
    {
        int iVar1;
        uint uVar2;

        iVar1 = (int)GameManager.FUN_64650();
        uVar2 = (uint)(iVar1 % 5 & 0xff);
        param1.FUN_6103C(18, 9, (byte)uVar2, 0);
        param1.DAT_60 = (ushort)(uVar2 << 1);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65D0C(0, 30);
        param1.DAT_3E++;
    }

    //FUN_41D4 (ST6)
    private void FUN_41D4(CriPlayer param1)
    {
        PTR_FUN_1674C[param1.DAT_3E](param1);
    }

    //FUN_4210 (ST6)
    private void FUN_4210(CriPlayer param1)
    {
        short sVar1;
        bool bVar2;
        byte bVar3;
        bool bVar4;
        short sVar5;
        int iVar6;
        CriPlayer oVar6;
        uint uVar7;
        uint uVar8;
        Vector3Int local_20;

        FUN_B1FC(param1);
        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        sVar5 = param1.FUN_64804(oVar6.screen);
        uVar8 = (uint)(oVar6.vr.y - param1.vr.y & 0xfff);
        bVar2 = SceneManager.instance.FUN_80D48(param1.screen, oVar6.screen, 4);

        if ((GameManager.instance.DAT_922C & 2) == 0 && (oVar6.DAT_11E & 0x80) == 0)
        {
            if (param1.DAT_1C8 == 0)
            {
                if (0xd00 < (ushort)(sVar5 - 0x180) && param1.UDAT_1DC < 0xdac && !bVar2)
                {
                    param1.DAT_1C3 = 0;
                    param1.DAT_3C = 1;
                    param1.DAT_3D = 7;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0x7f);

                    if (sVar5 < 0x200)
                        bVar3 = (byte)(param1.BDAT_1C0 | 8);
                    else
                        bVar3 = (byte)(param1.BDAT_1C0 & 0xf7);

                    param1.BDAT_1C0 = (sbyte)bVar3;
                    GameManager.instance.FUN_65C7C(param1);
                    return;
                }
            }
            else
            {
                if (0xd00 < (ushort)(sVar5 - 0x180) && param1.UDAT_1DC < 0xdac && !bVar2)
                {
                    iVar6 = (int)GameManager.FUN_64650();
                    uVar7 = 0x601;

                    if (iVar6 != (iVar6 / 3) * 3)
                    {
                        iVar6 = (int)GameManager.FUN_64650();

                        if (iVar6 == (iVar6 / 5) * 5)
                            param1.DAT_1C3 = 1;

                        param1.DAT_3C = 1;
                        param1.DAT_3D = 7;
                        param1.DAT_3E = 0;
                        param1.DAT_3F = 0;

                        if (sVar5 < 0x200)
                            bVar3 = (byte)(param1.BDAT_1C0 | 0x88);
                        else
                            bVar3 = (byte)(param1.BDAT_1C0 & 0x77);

                        param1.BDAT_1C0 = (sbyte)bVar3;
                        goto LAB_459C;
                    }

                    param1.DAT_3C = (byte)uVar7;
                    param1.DAT_3D = (byte)(uVar7 >> 8);
                    param1.DAT_3E = (byte)(uVar7 >> 0x10);
                    param1.DAT_3F = (byte)(uVar7 >> 0x18);
                    LAB_459C:
                    GameManager.instance.FUN_65C7C(param1);
                    return;
                }
            }
        }
        else
        {
            if ((param1.BDAT_1C0 & 0x20) == 0)
            {
                if ((GameManager.instance.DAT_922C & 2) == 0)
                {
                    if (oVar6.DAT_3C == 5 && oVar6.DAT_3D == 1 &&
                        0xc00 < (ushort)(sVar5 - 0x200) && param1.UDAT_1DC < 0xe74)
                    {
                        bVar4 = SceneManager.instance.FUN_65BA8(param1);

                        if (!bVar2 && !bVar4 && 0xc00 < uVar8 - 0x200)
                        {
                            uVar7 = 0x901;
                            param1.DAT_3C = (byte)uVar7;
                            param1.DAT_3D = (byte)(uVar7 >> 8);
                            param1.DAT_3E = (byte)(uVar7 >> 0x10);
                            param1.DAT_3F = (byte)(uVar7 >> 0x18);
                            GameManager.instance.FUN_65C7C(param1);
                        }
                        else
                        {
                            param1.DAT_3C = 1;
                            param1.DAT_3D = 0;
                            param1.DAT_3E = 0;
                            param1.DAT_3F = 0;
                        }
                    }
                }
                else
                {
                    sVar1 = (short)(oVar6.DAT_3D << 8 | oVar6.DAT_3C);

                    if ((sVar1 == 0x705 || sVar1 == 0x805 || sVar1 == 0x405 || sVar1 == 0x605) &&
                        param1.UDAT_1DC < 0xe74 && 0xc00 < (ushort)(sVar5 - 0x200))
                    {
                        param1.DAT_3C = 1;
                        param1.DAT_3D = 0;
                        param1.DAT_3E = 0;
                        param1.DAT_3F = 0;
                    }
                }
            }
            else
            {
                if (oVar6.DAT_3C == 5 && oVar6.DAT_3D == 4)
                {
                    if (uVar8 - 0x601 < 0x400 && 0xc00 < (ushort)(sVar5 - 0x200) &&
                        param1.UDAT_1DC - 0x708 < 700)
                    {
                        if (bVar2 || SceneManager.instance.FUN_65BA8(param1) || GameManager.instance.DAT_55)
                        {
                            param1.DAT_3C = 1;
                            param1.DAT_3D = 0;
                            param1.DAT_3E = 0;
                            param1.DAT_3F = 0;
                            param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xdf);
                            GameManager.instance.FUN_65CB0(param1);
                            FUN_B2E0(param1);
                            return;
                        }

                        uVar7 = 0x801;
                        goto LAB_466C;
                    }

                    if (param1.UDAT_1DC < 0x708 && 0xc00 < (ushort)(sVar5 - 0x200))
                    {
                        param1.DAT_3C = 1;
                        param1.DAT_3D = 0;
                        param1.DAT_3E = 0;
                        param1.DAT_3F = 0;
                        param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xdf);
                        GameManager.instance.FUN_65CB0(param1);
                        FUN_B2E0(param1);
                        return;
                    }
                }
                else
                {
                    param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xdf);
                    GameManager.instance.FUN_65CB0(param1);
                    FUN_B2E0(param1);
                }
            }
        }

        local_20 = new Vector3Int(param1.DAT_10C.x, param1.screen.y, param1.DAT_10C.z);
        sVar5 = param1.FUN_64804(local_20);
        uVar7 = 0x501;

        if (0x7ff < (ushort)(sVar5 - 0x400))
        {
            if (param1.DAT_1C8 == 0)
                return;

            if (param1.UDAT_1DC < 0x1389)
                return;

            uVar7 = 0x301;

            if (oVar6.DAT_3C == 5)
                return;
        }

        LAB_466C:
        param1.DAT_3C = (byte)uVar7;
        param1.DAT_3D = (byte)(uVar7 >> 8);
        param1.DAT_3E = (byte)(uVar7 >> 0x10);
        param1.DAT_3F = (byte)(uVar7 >> 0x18);
    }

    //FUN_4690 (ST6)
    private void FUN_4690(CriPlayer param1)
    {
        byte bVar1;
        ushort uVar2;
        short sVar3;
        int iVar4;
        ushort uVar5;
        Vector3Int local_18;

        param1.FUN_60AB4();
        param1.FUN_65890();

        if (param1.DAT_1CE == 0)
        {
            if ((param1.DAT_162 & 2) != 0)
            {
                bVar1 = (byte)(param1.DAT_1CC + 1);
                param1.DAT_1CC = bVar1;
                
                if (20 < bVar1)
                {
                    param1.DAT_1CE = 1;
                    uVar2 = (ushort)param1.FUN_6615C();
                    param1.DAT_1D0 = uVar2;
                    param1.DAT_1CF = 52;
                    param1.DAT_1CC = 0;
                }
            }

            if (param1.DAT_1CE == 0)
            {
                local_18 = new Vector3Int(param1.DAT_10C.x, param1.screen.y, param1.DAT_10C.z);
                uVar2 = (ushort)Utilities.FUN_615EC(param1.screen, local_18);
                iVar4 = (int)GameManager.FUN_64650();
                sVar3 = (short)param1.vr.y;
                iVar4 = (iVar4 % 15 + 20) * 0x10000 >> 0x10;
                goto LAB_481C;
            }
        }

        if ((param1.DAT_162 & 2) == 0)
            param1.DAT_1CD++;

        bVar1 = (byte)(param1.DAT_1CF - 1);
        param1.DAT_1CF = bVar1;
        uVar5 = (ushort)(param1.vr.y - (short)param1.DAT_1D0 & 0xfff);

        if ((bVar1 << 0x18) < 1 || 3 < param1.DAT_1CD || uVar5 < 0x100 || 0xf00 < uVar5)
        {
            param1.DAT_1CE = 0;
            param1.DAT_1CC = 0;
        }

        sVar3 = (short)param1.vr.y;
        uVar2 = (ushort)param1.DAT_1D0;
        iVar4 = 20;
        LAB_481C:
        sVar3 = (short)Utilities.FUN_64838(sVar3, (uint)iVar4, uVar2);
        param1.vr.y = param1.vr.y + sVar3 & 0xfff;
    }

    //FUN_484C (ST6)
    private void FUN_484C(CriPlayer param1)
    {
        int iVar1;

        if (param1.DAT_3D == 3)
            iVar1 = 2;
        else
            iVar1 = 1;

        param1.FUN_609C8(iVar1, 1, 10);
        param1.DAT_40 = new Vector3Int(0, 0, 0);

        if (param1.DAT_3D == 1)
            iVar1 = 2;
        else
            iVar1 = 1;

        param1.FUN_65D0C((byte)iVar1, 30);
        param1.DAT_1CE = 0;
        param1.DAT_1CC = 0;
        param1.DAT_3E++;
    }

    //FUN_48D8 (ST6)
    private void FUN_48D8(CriPlayer param1)
    {
        short sVar1;

        FUN_4690(param1);
        sVar1 = (short)param1.DAT_60;

        if (sVar1 == 1)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            sVar1 = (short)param1.DAT_60;
        }

        if (sVar1 == 24)
            GameManager.instance.FUN_5C94C(param1, 49);
    }

    //FUN_496C (ST6)
    private void FUN_496C(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriPlayer oVar3;
        bool bVar4;
        bool bVar5;
        CriBone oVar5;

        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((param1.DAT_18E & 4) == 0)
        {
            oVar5 = (CriBone)Utilities.FUN_601C8(param1.skeleton, 2);
            sVar1 = (short)param1.vr.y;
            sVar2 = (short)oVar5.vr.y;
            bVar4 = SceneManager.instance.FUN_80D48(param1.screen, oVar3.screen, 4);

            if (!bVar4)
            {
                bVar5 = Utilities.FUN_64C0C(param1.screen, oVar3.screen, (short)(sVar1 + sVar2 & 0xfff), 0x200);

                if (bVar5 || param1.UDAT_1DC < 4000 && (oVar3.DAT_3C == 1 && oVar3.DAT_3D == 1) || 
                   (oVar3.DAT_3C == 1 && oVar3.DAT_3D == 5) || (oVar3.DAT_227 & 0x80) != 0 || 
                    param1.BDAT_1EC != 0 || (param1.UDAT_1DC < 8000 && (oVar3.DAT_227 & 0x40) != 0))
                {
                    param1.BDAT_1EC = 0;
                    param1.DAT_3C = 1;
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.FUN_65D0C(0, 30);
                    FUN_B0C0(param1);
                }
            }
        }
    }

    //FUN_4AC0 (ST6)
    private void FUN_4AC0(CriPlayer param1)
    {
        FUN_484C(param1);
        GameManager.instance.FUN_77238((byte)param1.DAT_48, ref param1.VDAT_1E4);
        GameManager.instance.FUN_774CC(param1, (Vector3Int)param1.VDAT_1E4);
    }

    //FUN_4B08 (ST6)
    private void FUN_4B08(CriPlayer param1)
    {
        uint uVar1;
        Vector3Int vVar2;
        
        FUN_48D8(param1);

        if (param1.DAT_1C2 == 0)
        {
            vVar2 = (Vector3Int)param1.VDAT_1E4;
            uVar1 = Utilities.FUN_631AC(param1.screen, vVar2);

            if (uVar1 < 600)
            {
                GameManager.instance.FUN_77238((byte)param1.DAT_48, ref param1.VDAT_1E4);
                GameManager.instance.FUN_774CC(param1, (Vector3Int)param1.VDAT_1E4);
            }
        }
    }

    //FUN_4BB0 (ST6)
    private void FUN_4BB0(CriPlayer param1)
    {
        bool bVar1;
        byte bVar2;
        short sVar3;
        int iVar4;

        FUN_B1FC(param1);
        sVar3 = param1.FUN_64804(SceneManager.instance.DAT_27C[10].screen);
        bVar1 = SceneManager.instance.FUN_80D48(param1.screen, SceneManager.instance.DAT_27C[10].screen, 4);

        if ((GameManager.instance.DAT_922C & 2) == 0 && 
            (SceneManager.instance.DAT_27C[10].DAT_11E & 0x80) == 0 && param1.DAT_1C8 != 0)
        {
            if (!bVar1 && 0xd00 < (ushort)(sVar3 - 0x180) && param1.UDAT_1DC < 0xdac)
            {
                iVar4 = (int)GameManager.FUN_64650();

                if (iVar4 == (iVar4 / 3) * 3)
                {
                    param1.DAT_3C = 1;
                    param1.DAT_3D = 6;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                {
                    iVar4 = (int)GameManager.FUN_64650();

                    if (iVar4 == (iVar4 / 5) * 5)
                        param1.DAT_1C3 = 1;

                    param1.DAT_3C = 1;
                    param1.DAT_3D = 7;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;

                    if (sVar3 < 0x200)
                        bVar2 = (byte)(param1.BDAT_1C0 | 0x88);
                    else
                        bVar2 = (byte)(param1.BDAT_1C0 & 0x77);

                    param1.BDAT_1C0 = (sbyte)bVar2;
                }

                GameManager.instance.FUN_65C7C(param1);
            }
        }
        else
        {
            if (param1.UDAT_1DC < 0x1194)
            {
                param1.DAT_3C = 1;
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
        }
    }

    //FUN_4D54 (ST6)
    private void FUN_4D54(CriPlayer param1)
    {
        short sVar1;

        FUN_4690(param1);
        sVar1 = (short)param1.DAT_60;

        if (sVar1 == 1)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            sVar1 = (short)param1.DAT_60;
        }

        if (sVar1 == 15)
            GameManager.instance.FUN_5C94C(param1, 49);
    }

    //FUN_4DE8 (ST6)
    private void FUN_4DE8(CriPlayer param1)
    {
        param1.FUN_609C8(3, 8, 10);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_4E30 (ST6)
    private void FUN_4E30(CriPlayer param1)
    {
        short sVar1;
        bool bVar2;
        CriPlayer oVar3;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            if ((param1.BDAT_1C0 & 0x40) == 0 || 0x7ff < param1.FUN_64804(SceneManager.instance.DAT_27C[10].screen) - 0x400)
            {
                param1.DAT_3C = 1;
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
            else
            {
                param1.DAT_3C = 1;
                param1.DAT_3D = 5;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                GameManager.instance.FUN_65CB0(param1);
                FUN_B2E0(param1);
            }

            param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xbf);
        }

        sVar1 = (short)param1.DAT_60;

        if (sVar1 == 12)
        {
            GameManager.instance.FUN_5C94C(param1, 58);
            sVar1 = (short)param1.DAT_60;
        }

        if (sVar1 == 5)
        {
            oVar3 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

            if (oVar3 != null && (oVar3.BDAT_1C0 & 1) != 0 && oVar3.DAT_3C == 1 && oVar3.DAT_3D != 4)
            {
                if (oVar3.DAT_3C == 1 && oVar3.DAT_3D == 5)
                    FUN_B46C(param1);

                oVar3.DAT_3C = 1;
                oVar3.DAT_3D = 4;
                oVar3.DAT_3E = 0;
                oVar3.DAT_3F = 0;
            }
        }
    }

    private void FUN_4FA0(CriPlayer param1)
    {
        CriPlayer oVar1;
        bool bVar2;
        int iVar2;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar1.DAT_11E & 0x80) == 0)
        {
            bVar2 = SceneManager.instance.FUN_81014(param1.screen, SceneManager.instance.DAT_27C[10].screen, (byte)(param1.DAT_48 << 4 | 0xf), false);

            if (!bVar2 && (param1.DAT_162 & 1) != 0 && param1.DAT_1C1 == 0 && param1.DAT_60 - 28 < 6 && (param1.DAT_12B & 0x1e) != 0)
            {
                param1.DAT_1C1 = 1;

                if ((oVar1.vr.y - param1.vr.y & 0xfff) - 0x400 < 0x801)
                {
                    oVar1.DAT_3C = 5;
                    oVar1.DAT_3D = 3;
                    oVar1.DAT_3E = 0;
                    oVar1.DAT_3F = 0;
                    oVar1.vr.y = param1.vr.y - 0x800 & 0xfff;
                    param1.BDAT_1C0 |= 0x20;
                    //...
                }
                else
                {
                    oVar1.DAT_3C = 5;
                    oVar1.DAT_3D = 0;
                    oVar1.DAT_3E = 0;
                    oVar1.DAT_3F = 0;
                    oVar1.vr.y = param1.vr.y;
                    //...
                }

                //FUN_65D1C
                GameManager.instance.PTR_FUN_148 = FUN_86FC;
                oVar1.DAT_1F0 = param1;
                param1.FUN_65C4C(oVar1);
                GameManager.instance.FUN_5C94C(param1, 63);
                //FUN_1F988

                if ((oVar1.DAT_11E & 1) == 0 && 0 < oVar1.health)
                {
                    iVar2 = (int)GameManager.FUN_64650();
                    oVar1.health = (short)((oVar1.health - 400) - (iVar2 + (iVar2 / 150) * -150));
                    oVar1.FUN_4FE30();

                    if (oVar1.health < 1)
                        FUN_C06C(param1);
                }
            }
        }
    }

    //FUN_5444 (ST6)
    private void FUN_5444(CriPlayer param1)
    {
        int iVar2;
        bool bVar2;
        CriInteract.FUN_0C[] aVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;
        CriInteract.FUN_0C dVar6;
        uint uVar7;
        CriPlayer oVar8;

        oVar8 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar8.DAT_11E & 0x80) != 0)
            return;

        bVar2 = SceneManager.instance.FUN_81014(param1.screen, oVar8.screen, (byte)(param1.DAT_48 << 4 | 0xf), false);

        if (bVar2)
            return;

        if ((param1.DAT_162 & 1) == 0)
            return;

        if (param1.DAT_1C1 != 0)
            return;

        if (13 < param1.DAT_60 - 19U)
            return;

        if ((param1.DAT_12B & 6) == 0)
            return;

        uVar5 = (uint)(oVar8.vr.y - param1.vr.y & 0xfff);

        if ((param1.BDAT_1C0 & 8) == 0)
        {
            if ((param1.BDAT_1C0 & 0x80) == 0)
            {
                uVar3 = GameManager.FUN_64650();

                if ((uVar3 & 1) == 0 && param1.DAT_60 < 27 && uVar5 - 0x600 < 0x400)
                {
                    param1.DAT_1C1 = 2;
                    return;
                }
            }

            uVar4 = 2;

            if (uVar5 - 0x200 < 0x400)
            {
                uVar7 = 20;
                uVar3 = param1.DAT_1CB;
                aVar2 = PTR_FUN_167A4;
                goto LAB_5650;
            }

            uVar4 = 0;

            if (uVar5 - 0xa00 < 0x400)
            {
                uVar7 = 20;
                uVar3 = param1.DAT_1CB;
                aVar2 = PTR_FUN_167B8;
                goto LAB_5650;
            }

            uVar7 = 20;

            if (0xbff < uVar5 - 0x201)
            {
                uVar4 = 3;
                uVar3 = param1.DAT_1CB;
                aVar2 = PTR_FUN_167E0;
                goto LAB_5650;
            }
        }
        else
        {
            uVar3 = uVar5 - 0x201 & 0xffff;
            uVar4 = 0;

            if (uVar3 < 0x400)
            {
                uVar7 = 20;
                uVar3 = param1.DAT_1CB;
                aVar2 = PTR_FUN_167B8;
                goto LAB_5650;
            }

            uVar4 = 2;

            if (uVar3 < 0xc00)
            {
                uVar7 = 20;
                uVar3 = param1.DAT_1CB;
                aVar2 = PTR_FUN_167A4;
                goto LAB_5650;
            }

            uVar7 = 20;

            if (uVar3 < 0xc00)
            {
                uVar4 = 3;
                uVar3 = param1.DAT_1CB;
                aVar2 = PTR_FUN_167E0;
                goto LAB_5650;
            }
        }

        uVar4 = 1;
        uVar7 = 18;
        uVar3 = param1.DAT_1CB;
        aVar2 = PTR_FUN_167CC;
        LAB_5650:
        dVar6 = aVar2[uVar3];
        param1.DAT_1C1 = 1;
        oVar8.FUN_53A2C(1, uVar4);
        SceneManager.instance.FUN_65D1C(oVar8, dVar6, (sbyte)uVar7);
        GameManager.instance.FUN_5C94C(param1, 63);
        //FUN_1D988
        FUN_B4AC(param1);

        if ((oVar8.DAT_11E & 1) == 0 && 0 < oVar8.health)
        {
            iVar2 = (int)GameManager.FUN_64650();
            oVar8.health = (short)((oVar8.health - 150) - (iVar2 + (iVar2 / 50) * -50));
            oVar8.FUN_4FE30();

            if (oVar8.health < 1)
            {
                oVar8.DAT_3C = 3;
                oVar8.DAT_3D = 0;
                oVar8.DAT_3E = 0;
                oVar8.DAT_3F = 0;

                if (uVar5 < 0x800)
                    oVar8.DAT_3F = 0;
                else
                    oVar8.DAT_3F = 1;

                FUN_C06C(param1);
            }
        }
    }

    //FUN_69E8 (ST6)
    private void FUN_69E8(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_1A4 = 1;
        }

        if (param1.DAT_60 == 12)
            GameManager.instance.FUN_5C94C(param1, 58);
    }

    //FUN_6A3C (ST6)
    private void FUN_6A3C(CriPlayer param1)
    {
        PTR_FUN_16894[param1.DAT_3E](param1);
    }

    //FUN_6A78 (ST6)
    private void FUN_6A78(CriPlayer param1)
    {
        PTR_FUN_1689C[param1.DAT_3D](param1);
    }

    //FUN_6AB4 (ST6)
    private void FUN_6AB4(CriPlayer param1)
    {
        byte bVar1;
        short sVar2;
        int iVar3;
        uint uVar4;

        iVar3 = (int)GameManager.FUN_64650();
        uVar4 = (uint)(iVar3 % 5);
        sVar2 = param1.FUN_64804(SceneManager.instance.DAT_27C[10].screen);

        if ((ushort)(sVar2 - 0x400) < 0x800)
        {
            param1.FUN_6103C(22, 0, (byte)uVar4, 0);
            bVar1 = (byte)(param1.BDAT_1C0 | 0x10);
        }
        else
        {
            param1.FUN_6103C(4, 0, (byte)uVar4, 0);
            bVar1 = (byte)(param1.BDAT_1C0 & 0xef);
        }

        param1.BDAT_1C0 = (sbyte)bVar1;
        param1.DAT_60 = (ushort)(uVar4 & 0xff);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        FUN_B4AC(param1);
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        GameManager.instance.FUN_5C94C(param1, 56);

        if ((param1.BDAT_1C0 & 4) == 0)
            FUN_BC9C(param1);

        param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xdf);
        param1.DAT_3E++;
    }
    
    //FUN_6BE4 (ST6)
    private void FUN_6BE4(CriPlayer param1)
    {
        ushort uVar1;
        short sVar2;
        short sVar3;
        bool bVar4;
        int iVar4;
        short[] aVar4;

        bVar4 = param1.FUN_60AB4();

        if (bVar4)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_140 &= 0xfffe;
            param1.DAT_12C &= 0xfff7;
        }

        if ((param1.BDAT_1C0 & 0x10) == 0)
        {
            uVar1 = param1.DAT_60;
            aVar4 = DAT_16688;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar4 = DAT_16638;
        }

        param1.DAT_40.z = aVar4[uVar1];
        sVar2 = (short)Utilities.FUN_615EC(param1.screen, SceneManager.instance.DAT_27C[10].screen);
        iVar4 = (int)GameManager.FUN_64650();
        sVar3 = (short)Utilities.FUN_64838(param1.vr.y, (uint)((iVar4 % 15 + 10) * 0x10000 >> 0x10), sVar2);
        param1.vr.y = param1.vr.y + sVar3 & 0xfff;

        if (param1.health < 1 && param1.DAT_60 == 19)
        {
            param1.DAT_3C = 3;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_6D08 (ST6)
    private void FUN_6D08(CriPlayer param1)
    {
        PTR_FUN_168AC[param1.DAT_3E](param1);
    }

    //FUN_6D44 (ST6)
    private void FUN_6D44(CriPlayer param1)
    {
        byte bVar1;
        short sVar2;
        int iVar3;
        uint uVar4;

        iVar3 = (int)GameManager.FUN_64650();
        uVar4 = (uint)(iVar3 % 5);
        sVar2 = param1.FUN_64804(SceneManager.instance.DAT_27C[10].screen);

        if ((ushort)(sVar2 - 0x400) < 0x800)
        {
            param1.FUN_6103C(0x17, 0, (byte)uVar4, 0);
            bVar1 = (byte)(param1.DAT_1C0 | 0x10);
        }
        else
        {
            param1.FUN_6103C(5, 0, (byte)uVar4, 0);
            bVar1 = (byte)(param1.DAT_1C0 & 0xef);
        }

        param1.BDAT_1C0 = (sbyte)bVar1;
        param1.DAT_60 = (ushort)(uVar4 & 0xff);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        FUN_B4AC(param1);
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        GameManager.instance.FUN_5C94C(param1, 55);

        if ((param1.BDAT_1C0 & 4) == 0)
        {
            if ((param1.BDAT_1C0 & 2) == 0)
                FUN_BB4C(param1);
            else
                FUN_BC9C(param1);
        }

        param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xdf);
        param1.DAT_3E++;
    }

    //FUN_6E8C (ST6)
    private void FUN_6E8C(CriPlayer param1)
    {
        ushort uVar1;
        short sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        short[] aVar4;
        uint uVar5;

        bVar4 = param1.FUN_60AB4();

        if (bVar4)
        {
            param1.DAT_140 &= 0xfffe;
            param1.DAT_12C &= 0xfff7;

            if (param1.health < 1)
            {
                uVar5 = 0x201;

                if (param1.DAT_1C6 == 3)
                    uVar5 = 0x302;
            }
            else
                uVar5 = 0x201;

            param1.DAT_3C = (byte)uVar5;
            param1.DAT_3D = (byte)(uVar5 >> 8);
            param1.DAT_3E = (byte)(uVar5 >> 0x10);
            param1.DAT_3F = (byte)(uVar5 >> 0x18);
        }

        if ((param1.BDAT_1C0 & 0x10) == 0)
        {
            uVar1 = param1.DAT_60;
            aVar4 = DAT_168E4;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar4 = DAT_168B4;
        }

        param1.DAT_40.z = aVar4[uVar1];
        sVar2 = (short)Utilities.FUN_615EC(param1.screen, SceneManager.instance.DAT_27C[10].screen);
        iVar4 = (int)GameManager.FUN_64650();
        sVar3 = (short)Utilities.FUN_64838(param1.vr.y, (uint)((iVar4 % 15 + 10) * 0x10000 >> 0x10), sVar2);
        param1.vr.y = param1.vr.y + sVar3 & 0xfff;

        if (param1.health < 1 && param1.DAT_60 == 18 && param1.DAT_1C6 != 3)
        {
            param1.DAT_3C = 3;
            param1.DAT_3D = 3;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_6FE8 (ST6)
    private void FUN_6FE8(CriPlayer param1)
    {
        PTR_FUN_16914[param1.DAT_3E](param1);
    }

    //FUN_7024 (ST6)
    private void FUN_7024(CriPlayer param1)
    {
        int iVar1;
        uint uVar2;

        iVar1 = (int)GameManager.FUN_64650();
        uVar2 = (uint)(iVar1 % 5 & 0xff);
        param1.FUN_6103C(8, 8, (byte)uVar2, 10);
        param1.DAT_60 = (ushort)(uVar2 << 1);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_5C94C(param1, 55);

        if ((param1.BDAT_1C0 & 4) == 0)
            FUN_BC9C(param1);

        param1.DAT_3E++;
    }

    //FUN_70E4 (ST6)
    private void FUN_70E4(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 5;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            InventoryManager.FUN_4A7E8(5, param1.DAT_163, false);
        }
    }

    //FUN_7128 (ST6)
    private void FUN_7128(CriPlayer param1)
    {
        PTR_FUN_1691C[param1.DAT_3E](param1);
    }

    //FUN_7164 (ST6)
    private void FUN_7164(CriPlayer param1)
    {
        param1.FUN_609C8(28, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_71AC (ST6)
    private void FUN_71AC(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 3;
            param1.DAT_3D = 3;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xef);
        }
    }

    //FUN_7228 (ST6)
    private void FUN_7228(CriPlayer param1)
    {
        PTR_FUN_1692C[param1.DAT_3D](param1);
    }

    //FUN_7264 (ST6)
    private void FUN_7264(CriPlayer param1)
    {
        param1.FUN_609C8(10, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        param1.DAT_3E++;
    }

    //FUN_72C8 (ST6)
    private void FUN_72C8(CriPlayer param1)
    {
        bool bVar1;
        CriPlayer oVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_12C = 0xffff;
            param1.PTR_124 = null;
            param1.DAT_124 = 0;
            param1.PTR_120 = null;
            param1.DAT_120 = 0;
            param1.DAT_12F = 0;
            param1.DAT_12E = 0;
            param1.DAT_11E |= 0x40;
            param1.DAT_140 |= 1;
            oVar1 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

            if (oVar1 != null && (oVar1.BDAT_1C0 & 1) != 0)
                oVar1.DAT_1C8 = 1;

            param1.DAT_144 &= 0x7fff;

            if (param1.DAT_1A3 == 0)
                FUN_BD54(param1);

            param1.DAT_3E++;
        }

        param1.DAT_40.z = DAT_1693C[param1.DAT_60];

        if (param1.DAT_60 == 12)
            GameManager.instance.FUN_5C94C(param1, 50);
    }

    //FUN_73B0 (ST6)
    private void FUN_73B0(CriPlayer param1)
    {
        PTR_FUN_16970[param1.DAT_3E](param1);
    }

    //FUN_73EC (ST6)
    private void FUN_73EC(CriPlayer param1)
    {
        param1.FUN_609C8(11, 8, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_65CB0(param1);
        GameManager.instance.FUN_5C94C(param1, 57);
        InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);
        param1.DAT_3E++;
    }

    //FUN_745C (ST6)
    private void FUN_745C(CriPlayer param1)
    {
        bool bVar1;
        CriPlayer oVar2;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_12C = 0xffff;
            param1.PTR_124 = null;
            param1.DAT_124 = 0;
            param1.PTR_120 = null;
            param1.DAT_120 = 0;
            param1.DAT_12F = 0;
            param1.DAT_12E = 0;
            param1.DAT_11E |= 0x40;
            param1.DAT_140 |= 1;
            oVar2 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

            if (oVar2 != null && (oVar2.BDAT_1C0 & 1) != 0)
                oVar2.DAT_1C8 = 1;

            param1.DAT_144 &= 0x7fff;

            if (param1.DAT_1A3 == 0)
                FUN_BD54(param1);

            param1.DAT_3E++;
        }

        if (param1.DAT_60 == 46)
            GameManager.instance.FUN_5C94C(param1, 50);
    }

    //FUN_7528 (ST6)
    private void FUN_7528(CriPlayer param1)
    {
        PTR_FUN_1697C[param1.DAT_3E](param1);
    }

    //FUN_7564 (ST6)
    private void FUN_7564(CriPlayer param1)
    {
        int iVar1;

        if ((param1.BDAT_1C0 & 0x10) == 0)
            iVar1 = 20;
        else
            iVar1 = 24;

        param1.FUN_609C8(iVar1, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_5C94C(param1, 57);
        InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);
        param1.DAT_3E++;
    }

    //FUN_75E4 (ST6)
    private void FUN_75E4(CriPlayer param1)
    {
        ushort uVar1;
        bool bVar2;
        short[] aVar3;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3C = 3;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        if ((param1.BDAT_1C0 & 0x10) == 0)
        {
            uVar1 = param1.DAT_60;
            aVar3 = DAT_16988;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar3 = DAT_169C8;
        }

        param1.DAT_40.z = aVar3[uVar1];
    }

    //FUN_7658 (ST6)
    private void FUN_7658(CriPlayer param1)
    {
        PTR_FUN_16A08[param1.DAT_3E](param1);
    }

    //FUN_7714 (ST6)
    private void FUN_7694(CriPlayer param1)
    {
        int iVar1;

        if ((param1.BDAT_1C0 & 0x10) == 0)
            iVar1 = 21;
        else
            iVar1 = 25;

        param1.FUN_609C8(iVar1, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_5C94C(param1, 57);
        InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);
        param1.DAT_3E++;
    }

    //FUN_7714 (ST6)
    private void FUN_7714(CriPlayer param1)
    {
        ushort uVar1;
        bool bVar2;
        short[] aVar3;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3C = 3;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        if ((param1.BDAT_1C0 & 0x10) == 0)
        {
            uVar1 = param1.DAT_60;
            aVar3 = DAT_16A10;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar3 = DAT_16A38;
        }

        param1.DAT_40.z = aVar3[uVar1];
    }

    //FUN_7788 (ST6)
    private void FUN_7788(CriPlayer param1)
    {
        PTR_FUN_16A60[param1.DAT_3E](param1);
    }

    //FUN_77C4 (ST6)
    private void FUN_77C4(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

        if (bVar1)
            param1.FUN_65D0C(0, 30);

        PTR_FUN_16A68[param1.DAT_3D](param1);
    }

    //FUN_7828 (ST6)
    private void FUN_7828(CriPlayer param1)
    {
        param1.FUN_60AB4();
    }

    //FUN_7848 (ST6)
    private void FUN_7848(CriPlayer param1)
    {
        int iVar1;

        if (param1.DAT_3D == 1)
            iVar1 = 1;
        else
            iVar1 = 2;

        param1.FUN_609C8(iVar1, 1, 10);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.SDAT_1D4 = (short)param1.screen.x;
        param1.SDAT_1D6 = (short)param1.screen.z;
        param1.UDAT_1E0 = (ushort)Utilities.FUN_631AC(param1.screen, param1.PTR_190[param1.DAT_190]);
        param1.DAT_3E++;
    }

    //FUN_78C4 (ST6)
    private void FUN_78C4(CriPlayer param1)
    {
        sbyte sVar1;
        ushort uVar2;
        short sVar3;
        uint uVar4;
        int iVar5;
        uint uVar6;
        Vector3Int local_18;

        local_18 = new Vector3Int(param1.SDAT_1D4, 0, param1.SDAT_1D6);
        uVar4 = Utilities.FUN_631AC(local_18, param1.screen);

        if (param1.UDAT_1E0 < uVar4)
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

            iVar5 = param1.DAT_190 + 2;
            param1.DAT_190 = iVar5;
            param1.SDAT_1D6 = (short)param1.screen.z;
            param1.SDAT_1D4 = (short)param1.screen.x;
            uVar6 = Utilities.FUN_631AC(param1.screen, param1.PTR_190[param1.DAT_190]);
            param1.UDAT_1E0 = (ushort)uVar6;
        }

        param1.FUN_60AB4();
        uVar2 = (ushort)Utilities.FUN_615EC(param1.screen, param1.PTR_190[param1.DAT_190]);
        sVar3 = (short)Utilities.FUN_64838(param1.vr.y, 60, uVar2);
        param1.vr.y = param1.vr.y + sVar3 & 0xfff;
        param1.FUN_65890();
    }

    //FUN_79D4 (ST6)
    private void FUN_79D4(CriPlayer param1)
    {
        short sVar1;

        FUN_78C4(param1);
        sVar1 = (short)param1.DAT_60;

        if (sVar1 == 1)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            sVar1 = (short)param1.DAT_60;
        }

        if (sVar1 == 24)
            GameManager.instance.FUN_5C94C(param1, 49);
    }

    //FUN_7A2C (ST6)
    private void FUN_7A2C(CriPlayer param1)
    {
        PTR_FUN_16A7C[param1.DAT_3E](param1);
    }

    //FUN_7A68 (ST6)
    private void FUN_7A68(CriPlayer param1)
    {
        short sVar1;

        FUN_78C4(param1);
        sVar1 = (short)param1.DAT_60;

        if (sVar1 == 1)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            sVar1 = (short)param1.DAT_60;
        }

        if (sVar1 == 15)
            GameManager.instance.FUN_5C94C(param1, 49);
    }

    //FUN_7AFC (ST6)
    private void FUN_7AFC(CriPlayer param1)
    {
        int iVar1;

        if ((param1.BDAT_1C0 & 0x10) == 0)
            iVar1 = 4;
        else
            iVar1 = 22;

        param1.FUN_609C8(iVar1, 0, 10);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        FUN_B4AC(param1);
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        GameManager.instance.FUN_5C94C(param1, 56);

        if ((param1.BDAT_1C0 & 4) == 0)
            FUN_BC9C(param1);

        param1.DAT_18D = true;
        param1.DAT_196 = 0;
        param1.DAT_12C |= 8;
        param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xdf);
        FUN_B4DC(param1);
        param1.DAT_3E++;
    }

    //FUN_7BDC (ST6)
    private void FUN_7BDC(CriPlayer param1)
    {
        bool bVar1;
        ushort uVar1;
        short[] aVar2;
        Vector3Int local_10;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_12C &= 0xfff7;
            param1.DAT_140 &= 0xfffe;
            bVar1 = InventoryManager.FUN_4A87C(5, param1.DAT_163);

            if (bVar1)
                InventoryManager.FUN_4A7E8(5, param1.DAT_163, false);

            FUN_B418(param1);
        }

        if ((param1.BDAT_1C0 & 0x10) == 0)
        {
            uVar1 = param1.DAT_60;
            aVar2 = DAT_16638;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar2 = DAT_16688;
        }

        param1.DAT_40.z = aVar2[uVar1];
        local_10 = new Vector3Int(0, param1.UDAT_1DA, 0);
        Utilities.RotMatrix(ref local_10, ref param1.cTransform.rotation);

        if (param1.health < 1)
        {
            param1.DAT_3C = 3;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_12C &= 0xfff7;
            param1.DAT_140 &= 0xfffe;
            bVar1 = InventoryManager.FUN_4A87C(5, param1.DAT_163);

            if (bVar1)
                InventoryManager.FUN_4A7E8(5, param1.DAT_163, false);

            FUN_B418(param1);
        }
    }

    //FUN_7D80 (ST6)
    private void FUN_7D80(CriPlayer param1)
    {
        PTR_FUN_16A9C[param1.DAT_3D](param1);
    }

    //FUN_7DBC (ST6)
    private void FUN_7DBC(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        CriPlayer oVar2;

        param1.FUN_609C8(6, 8, 10);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        oVar2 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

        if (oVar2 != null && (oVar2.BDAT_1C0 & 1) != 0)
            oVar2.DAT_1C8 = 1;

        if (param1.DAT_1C6 == 2)
        {
            iVar2 = (int)GameManager.FUN_64650();
            sVar1 = (short)(iVar2 + (iVar2 / 10) * -10 + 20);
        }
        else
        {
            if (param1.DAT_1C6 != 1)
            {
                param1.DAT_196 = 150;
                goto LAB_7EB8;
            }

            iVar2 = (int)GameManager.FUN_64650();
            sVar1 = (short)(iVar2 + (iVar2 / 5) * -5 + 10);
        }

        param1.DAT_196 = (short)(sVar1 * 30);
        LAB_7EB8:
        param1.DAT_1C7 = 0;
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        InventoryManager.FUN_4A7E8(5, param1.DAT_163, true);
        param1.DAT_3E++;
    }

    //FUN_7F04 (ST6)
    private void FUN_7F04(CriPlayer param1)
    {
        bool bVar1;
        short sVar2;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 5;
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        if (param1.DAT_196 == 0)
        {
            sVar2 = (short)param1.DAT_60;

            if (sVar2 == 55)
            {
                param1.DAT_3C = 5;
                param1.DAT_3D = 3;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                return;
            }
        }
        else
            sVar2 = (short)param1.DAT_60;

        if (sVar2 == 70)
            GameManager.instance.FUN_5C94C(param1, 50);
    }

    //FUN_7FB8 (ST6)
    private void FUN_7FB8(CriPlayer param1)
    {
        param1.FUN_609C8(7, 9, 0);
        param1.DAT_12C = 0xffff;
        param1.PTR_124 = DAT_16554;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_12F = 1;
        param1.DAT_3E++;
    }

    //FUN_7F7C (ST6)
    private void FUN_7F7C(CriPlayer param1)
    {
        PTR_FUN_16AAC[param1.DAT_3E](param1);
    }

    //FUN_801C (ST6)
    private void FUN_801C(CriPlayer param1)
    {
        param1.FUN_60AB4();
    }

    //FUN_803C (ST6)
    private void FUN_803C(CriPlayer param1)
    {
        ushort uVar1;

        uVar1 = (ushort)(param1.DAT_196 - 1);

        if (param1.DAT_196 < 0)
        {
            param1.DAT_196 = (short)uVar1;

            if (uVar1 << 0x10 < 1)
            {
                PTR_FUN_16AB4[param1.DAT_3E](param1);
            }
        }
        else
        {
            param1.DAT_196 = (short)uVar1;

            if (0 < uVar1 << 0x10)
            {
                PTR_FUN_16AB4[param1.DAT_3E](param1);
            }
            else
            {
                param1.DAT_3C = 5;
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                InventoryManager.FUN_4A7E8(5, param1.DAT_163, false);
            }
        }
    }

    //FUN_80C0 (ST6)
    private void FUN_80C0(CriPlayer param1)
    {
        param1.FUN_609C8(9, 8, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_12C = 0;
        param1.DAT_3E++;
    }

    //FUN_810C (ST6)
    private void FUN_810C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        param1.FUN_65890();

        if (param1.DAT_60 == 32)
        {
            FUN_B4C4(param1);
            GameManager.instance.FUN_5C94C(param1, 64);
        }
    }

    //FUN_816C (ST6)
    private void FUN_816C(CriPlayer param1)
    {
        PTR_FUN_16ABC[param1.DAT_3E](param1);
    }

    //FUN_81A8 (ST6)
    private void FUN_81A8(CriPlayer param1)
    {
        param1.FUN_609C8(17, 8, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_81F0 (ST6)
    private void FUN_81F0(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        param1.FUN_65890();
    }

    //FUN_822C (ST6)
    private void FUN_822C(CriPlayer param1)
    {
        PTR_FUN_16AC4[param1.DAT_3E](param1);
    }

    //FUN_8268 (ST6)
    private void FUN_8268(CriPlayer param1)
    {
        ushort uVar1;
        CriPlayer oVar2;
        int iVar3;
        CriCamera cVar4;

        GameManager.instance.FUN_46C0C(0, 20, 1);
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        DialogManager.instance.DAT_B1440 = 2;
        uVar1 = oVar2.DAT_140;
        oVar2.screen = new Vector3Int(0, 0, 0);
        oVar2.vr = new Vector3Int(0, 0, 0);
        oVar2.PTR_124 = null;
        oVar2.DAT_124 = 0;
        oVar2.PTR_120 = null;
        oVar2.DAT_120 = 0;
        oVar2.DAT_12F = 0;
        oVar2.DAT_12E = 0;
        oVar2.DAT_140 = (ushort)(uVar1 | 0x8000);
        oVar2.FUN_535E4(0x70, 0x70);
        GameManager.instance.PTR_FUN_14C = FUN_9294;
        param1.FUN_65C4C(oVar2);
        oVar2.DAT_152 = 1;
        param1.DAT_152 = 1;
        oVar2.DAT_154 = param1;
        param1.DAT_154 = oVar2;
        oVar2.DAT_3C = 6;
        oVar2.DAT_3D = 0;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        oVar2.DAT_1C0 &= 0xfffffffe;
        param1.screen = new Vector3Int(0, 0, 0);
        param1.vr = new Vector3Int(0, 0, 0);
        param1.PTR_124 = null;
        param1.DAT_124 = 0;
        param1.PTR_120 = null;
        param1.DAT_120 = 0;
        param1.DAT_12F = 0;
        param1.DAT_12E = 0;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_140 |= 0x8000;
        param1.flags |= 2;
        iVar3 = (int)GameManager.FUN_64650();
        param1.BDAT_1CA = (byte)(iVar3 + (iVar3 / 2) * -2);
        FUN_C184(param1);
        cVar4 = SceneManager.instance.cCamera;
        cVar4.DAT_70 = 1;
        cVar4.PTR_FUN_8C = cVar4.FUN_C064;
        cVar4.DAT_64 = param1;
        param1.FUN_609C8(30, 1, 0);
        param1.FUN_656EC();
        param1.DAT_3E++;
    }

    //FUN_83F8 (ST6)
    private void FUN_83F8(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.FUN_65714();

        if (param1.DAT_60 == 2 || param1.DAT_60 == 20)
            GameManager.instance.FUN_5C94C(param1, 54);
    }

    //FUN_8464 (ST6)
    private void FUN_8464(CriPlayer param1)
    {
        param1.FUN_609C8(31, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        param1.DAT_3E++;
    }

    //FUN_84B8 (ST6)
    private void FUN_84B8(CriPlayer param1)
    {
        bool bVar1;
        CriCamera cVar2;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.FUN_65714();

        if (param1.DAT_60 == 16)
        {
            cVar2 = SceneManager.instance.cCamera;
            cVar2.DAT_70 = 1;
            cVar2.DAT_64 = param1;
            cVar2.PTR_FUN_8C = cVar2.PTR_FUN_16ACC[param1.BDAT_1CA];
            FUN_C320(param1);
            GameManager.instance.FUN_5C94C(param1, 59);
        }
    }

    //FUN_8554 (ST6)
    private void FUN_8554(CriPlayer param1)
    {
        CriCamera cVar1;

        param1.FUN_6103C(16, 0, 40, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
        cVar1 = SceneManager.instance.cCamera;
        cVar1.DAT_70 = 1;
        cVar1.PTR_FUN_8C = cVar1.PTR_FUN_16AD4[param1.BDAT_1CA];
        cVar1.DAT_64 = param1;

        if (param1.BDAT_1CA != 0)
            FUN_C4D8(param1);
    }

    //FUN_85EC (ST6)
    private void FUN_85EC(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.FUN_609C8(0x10, 0, 0x3c);
            param1.DAT_3E++;
        }

        if (param1.DAT_60 == 20)
            GameManager.instance.FUN_5C94C(param1, 58);
    }

    //FUN_8660 (ST6)
    private void FUN_8660(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        if (param1.DAT_60 == 10)
            SceneManager.instance.DAT_272 = true;
    }

    //FUN_86C0 (ST6)
    private void FUN_86C0(CriPlayer param1)
    {
        PTR_FUN_16ADC[param1.DAT_3E](param1);
    }

    //FUN_86FC (ST6)
    private void FUN_86FC(CriPlayer param1)
    {

    }

    //FUN_8738 (ST6)
    private void FUN_8738(CriPlayer param1)
    {
        param1.FUN_609C8(35, 0, 5);
        param1.DAT_11E |= 0x88;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1C8 = 0;
        param1.DAT_1C0 &= 0xfffffffe;
        GameManager.instance.FUN_5C94C(param1, 3);
        param1.DAT_3E++;
    }

    //FUN_87B0 (ST6)
    private void FUN_87B0(CriPlayer param1)
    {
        short sVar1;
        bool bVar2;

        sVar1 = (short)param1.DAT_64.z;
        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3C = 5;
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        param1.DAT_40.z = -((param1.DAT_64.z - sVar1) - 76);

        if (param1.DAT_60 == 10)
            GameManager.instance.FUN_5C94C(param1, 5);
    }

    //FUN_881C (ST6)
    private void FUN_881C(CriPlayer param1) 
    {
        PTR_FUN_16B20[param1.DAT_3E](param1);
    }

    //FUN_8858 (ST6)
    private void FUN_8858(CriPlayer param1)
    {
        param1.FUN_609C8(36, 1, 0);
        param1.DAT_1CA = 10;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1E6 = 100;
        param1.DAT_5C |= 8;
        param1.FUN_538CC();
        param1.DAT_3E++;
    }

    //FUN_88D8 (ST6)
    private void FUN_88D8(CriPlayer param1)
    {
        int iVar2;
        uint uVar3;

        param1.FUN_60AB4();

        if ((param1.DAT_11E & 0x20) == 0)
        {
            iVar2 = GameManager.instance.FUN_64C80();

            if (iVar2 != 0)
                param1.DAT_1CA -= (short)iVar2;

            if (param1.DAT_1CA < 1 || --param1.DAT_1E6 << 0x10 < 1)
            {
                uVar3 = 0x505;

                if (param1.DAT_3D == 1)
                    uVar3 = 0x205;

                param1.DAT_3C = (byte)uVar3;
                param1.DAT_3D = (byte)(uVar3 >> 8);
                param1.DAT_3E = (byte)(uVar3 >> 0x10);
                param1.DAT_3F = (byte)(uVar3 >> 0x18);
            }
        }
    }

    //FUN_897C (ST6)
    private void FUN_897C(CriPlayer param1)
    {
        PTR_FUN_16B28[param1.DAT_3E](param1);
    }

    //FUM_89B8 (ST6)
    private void FUN_89B8(CriPlayer param1)
    {
        param1.FUN_609C8(37, 4, 5);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_5348C(0x70, 0x70);
        param1.DAT_3E++;
    }

    //FUN_8A14 (ST6)
    private void FUN_8A14(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;
    }

    //FUN_8A54 (ST6)
    private void FUN_8A54(CriPlayer param1)
    {
        param1.DAT_98 = param1.DAT_1E0;
        param1.FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x801860cc), 6, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_8AA4 (ST6)
    private void FUN_8AA4(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_11E &= 0x7f;
            param1.DAT_12C &= 0xfff7;
            param1.DAT_11E &= 0xf7;
        }
    }

    //FUN_8AFC (ST6)
    private void FUN_8AFC(CriPlayer param1)
    {

    }

    //FUN_8B38 (ST6)
    private void FUN_8B38(CriPlayer param1)
    {
        param1.FUN_609C8(38, 4, 5);
        param1.DAT_40 = new Vector3Int(0, 0, -100);
        param1.DAT_1C8 = 0;
        param1.DAT_11E |= 0x88;
        param1.DAT_1C0 &= 0xfffffffe;
        GameManager.instance.FUN_5C94C(param1, 3);
        param1.DAT_3E++;
    }

    //FUN_8BB4 (ST6)
    private void FUN_8BB4(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.DAT_40.z += 5;
    }

    //FUN_8C04 (ST6)
    private void FUN_8C04(CriPlayer param1)
    {
        param1.FUN_609C8(39, 0, 0);
        param1.DAT_40.x = 0;
        param1.DAT_40.y = 0;
        param1.DAT_40.z += 2;
        param1.DAT_3E++;
    }

    //FUN_8C54 (ST6)
    private void FUN_8C54(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 5;
            param1.DAT_3D = 4;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        param1.DAT_40.z += 2;

        if (param1.DAT_60 == 7)
            GameManager.instance.FUN_5C94C(param1, 5);
    }

    //FUN_8CE8 (ST6)
    private void FUN_8CE8(CriPlayer param1)
    {
        param1.FUN_609C8(41, 1, 0);
        param1.DAT_1CA = 40;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1E6 = 150;
        param1.DAT_5C |= 8;
        param1.FUN_538CC();
        param1.DAT_3E++;
    }

    //FUN_8DA4 (ST6)
    private void FUN_8DA4(CriPlayer param1)
    {
        param1.FUN_609C8(40, 1, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_5348C(0x70, 0x70);
        param1.DAT_3E++;
    }

    //FUN_8E00 (ST6)
    private void FUN_8E00(CriPlayer param1)
    {
        byte bVar1;
        bool bVar2;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            bVar1 = param1.DAT_11E;
            param1.DAT_3C = 1;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_11E = (byte)(bVar1 & 0x7f);
            param1.DAT_98 = param1.DAT_1E0;
            param1.DAT_12C &= 0xfff7;
            param1.DAT_11E = (byte)(bVar1 & 0x77);
        }
    }

    //FUN_9294 (ST6)
    private void FUN_9294(CriPlayer param1)
    {

    }

    //FUN_94E4 (ST6)
    private void FUN_94E4(CriPlayer param1)
    {
        if ((param1.DAT_11E & 0x80) == 0)
            param1.BDAT_1EC = 0;
        else
        {
            if ((param1.DAT_18E & 4) != 0)
                param1.DAT_18E &= 0xfb;

            param1.BDAT_1EC = 1;
            param1.DAT_11E &= 0x7b;

        }
    }

    //FUN_9570 (ST6)
    private void FUN_9570(CriPlayer param1)
    {
        PTR_FUN_16BC4[(param1.DAT_1A1 & 0xf) != 6 ? 1 : 0](param1);

        if (param1.DAT_1C5 == 0)
            FUN_BB4C(param1);
    }

    //FUN_95D8 (ST6)
    private void FUN_95D8(CriPlayer param1)
    {
        short sVar2;
        short sVar3;
        int iVar4;
        int iVar5;
        ushort uVar6;
        int iVar7;
        short[] aVar8;
        int iVar9;
        short sVar10;

        if ((param1.DAT_11E & 1) != 0)
            return;

        iVar4 = (int)GameManager.FUN_64650();
        param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xfb);

        if (param1.health < 1)
            return;

        if (!GameManager.instance.DAT_A2D0)
        {
            aVar8 = DAT_16580;
            iVar9 = 5;
        }
        else
        {
            aVar8 = DAT_165E0;
            iVar9 = 60;
        }

        uVar6 = (ushort)(param1.DAT_1A0 & 0xf);
        iVar7 = 1;

        if (uVar6 == 1 || uVar6 == 3)
        {
            iVar5 = (int)GameManager.FUN_64650();
            iVar7 = iVar5 % iVar9;

            if (iVar9 == 0)
                return; //trap(0x1c00)

            if (iVar9 == -1 && iVar5 == -0x80000000)
                return; //trap(0x1800)
        }

        sVar10 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

        if (sVar10 == 5 || sVar10 == 0x105 || sVar10 == 0x205 || 
           (sVar10 == 0x601 && param1.DAT_60 - 26 < 12) || 
           (sVar10 == 0x701 && param1.DAT_60 < 36) || sVar10 == 0x304 || 
           param1.DAT_3C == 2 || param1.DAT_3C == 3)
        {
            iVar4 = (int)GameManager.FUN_64650();
            iVar7 = aVar8[3];
            sVar10 = (short)(iVar4 % iVar7);

            if (iVar7 == 0)
                return; //trap(0x1c00)

            if (iVar7 == -1 && iVar4 == -0x80000000)
                return; //trap(0x1800)

            sVar3 = aVar8[2];
            sVar2 = param1.health;
            param1.DAT_1C5 = 0;
        }
        else
        {
            if (param1.DAT_3C == 4)
            {
                param1.DAT_1C5 = 0;
                goto LAB_98D4;
            }

            if ((iVar7 & 0xff) != 0)
            {
                if (param1.UDAT_1DC < ((iVar4 % 10) * 100 & 0xffff) + 4000)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    iVar7 = aVar8[3];
                    sVar10 = (short)(iVar4 & iVar7);

                    if (iVar7 == 0)
                        return; //trap(0x1c00)

                    if (iVar7 == -1 && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar3 = aVar8[2];
                }
                else
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    iVar7 = aVar8[1];
                    sVar10 = (short)(iVar4 % iVar7);

                    if (iVar7 == 0)
                        return; //trap(0x1c00)

                    if (iVar7 == -1 && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar3 = aVar8[0];
                }

                sVar2 = param1.health;
                param1.DAT_1C5 = 0;
            }
            else
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar7 = aVar8[7];
                sVar10 = (short)(iVar4 % iVar7);

                if (iVar7 == 0)
                    return; //trap(0x1c00)

                if (iVar7 == -1 && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                sVar3 = aVar8[6];
                sVar2 = param1.health;
                param1.DAT_1C5 = 2;
            }
        }

        param1.DAT_11C = (short)(sVar3 + sVar10);
        param1.health = (short)(sVar2 - (sVar3 + sVar10));

        LAB_98D4:
        if (param1.health < 1)
        {
            InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);

            if (param1.DAT_1C5 == 0)
            {
                if (param1.DAT_3C == 3)
                    return;

                if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
                    return;
            }

            sVar10 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (sVar10 == 0x105 || sVar10 == 0x202 || (sVar10 == 5 && 0x3d < param1.DAT_60) ||
               (sVar10 == 0x205 && param1.DAT_60 < 0x17))
            {
                param1.DAT_3C = 3;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
            else
                param1.DAT_1C5 = 2;
        }

        if (param1.DAT_1C5 != 0)
        {
            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B46C(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xfd);
            }

            FUN_B4DC(param1);
        }
    }

    //FUN_99EC (ST6)
    private void FUN_99EC(CriPlayer param1)
    {
        short sVar2;
        short sVar3;
        int iVar4;
        int iVar5;
        ushort uVar6;
        int iVar7;
        short[] aVar8;
        int iVar9;
        short sVar10;

        if ((param1.DAT_11E & 1) != 0)
            return;

        iVar4 = (int)GameManager.FUN_64650();
        param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xfb);

        if (param1.health < 1)
            return;

        if (!GameManager.instance.DAT_A2D0)
        {
            aVar8 = DAT_165A0;
            iVar9 = 5;
        }
        else
        {
            aVar8 = DAT_16600;
            iVar9 = 60;
        }

        uVar6 = (ushort)(param1.DAT_1A0 & 0xf);
        iVar7 = 1;

        if (uVar6 == 1 || uVar6 == 3)
        {
            iVar5 = (int)GameManager.FUN_64650();
            iVar7 = iVar5 % iVar9;

            if (iVar9 == 0)
                return; //trap(0x1c00)

            if (iVar9 == -1 && iVar5 == -0x80000000)
                return; //trap(0x1800)
        }

        sVar10 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

        if (sVar10 == 5 || sVar10 == 0x105 || sVar10 == 0x205 || 
           (sVar10 == 0x601 && param1.DAT_60 - 26 < 12) || 
           (sVar10 == 0x701 && param1.DAT_60 < 36) || sVar10 == 0x304 || 
            param1.DAT_3C == 2 || param1.DAT_3C == 3)
        {
            iVar4 = (int)GameManager.FUN_64650();
            iVar7 = aVar8[3];
            sVar10 = (short)(iVar4 % iVar7);

            if (iVar7 == 0)
                return; //trap(0x1c00)

            if (iVar7 == -1 && iVar4 == -0x80000000)
                return; //trap(0x1800)

            sVar3 = aVar8[2];
            sVar2 = param1.health;
            param1.DAT_1C5 = 0;
        }
        else
        {
            if (param1.DAT_3C == 4)
            {
                param1.DAT_1C5 = 0;
                goto LAB_9CE8;
            }

            if ((iVar7 & 0xff) != 0)
            {
                if (param1.UDAT_1DC < (((uint)iVar4 % 10) * 100 & 0xffff) + 5500)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    iVar7 = aVar8[3];
                    sVar10 = (short)(iVar4 % iVar7);

                    if (iVar7 == 0)
                        return; //trap(0x1c00)

                    if (iVar7 == -1 && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar3 = aVar8[2];
                }
                else
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    iVar7 = aVar8[1];
                    sVar10 = (short)(iVar4 % iVar7);

                    if (iVar7 == 0)
                        return; //trap(0x1c00)

                    if (iVar7 == -1 && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar3 = aVar8[0];
                }

                sVar2 = param1.health;
                param1.DAT_1C5 = 0;
            }
            else
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar7 = aVar8[7];
                sVar10 = (short)(iVar4 % iVar7);

                if (iVar7 == 0)
                    return; //trap(0x1c00)

                if (iVar7 == -1 && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                sVar3 = aVar8[6];
                sVar2 = param1.health;
                param1.DAT_1C5 = 2;
            }
        }

        param1.DAT_11C = (short)(sVar3 + sVar10);
        param1.health = (short)(sVar2 - (sVar3 + sVar10));
        
        LAB_9CE8:
        if (param1.health < 1)
        {
            InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);

            if (param1.DAT_1C5 == 0)
            {
                if (param1.DAT_3C == 3)
                    return;

                if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
                    return;
            }

            sVar10 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (sVar10 == 0x105 || sVar10 == 0x202 || (sVar10 == 5 && 0x3d < param1.DAT_60) ||
               (sVar10 == 0x205 && param1.DAT_60 < 0x17))
            {
                param1.DAT_3C = 3;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
            else
                param1.DAT_1C5 = 2;
        }

        if (param1.DAT_1C5 != 0)
        {
            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B46C(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xfd);
            }

            FUN_B4DC(param1);
        }
    }

    //FUN_9E00 (ST6)
    private void FUN_9E00(CriPlayer param1)
    {
        PTR_FUN_16BCC[param1.DAT_1A1 & 15](param1);
    }

    //FUN_9E40 (ST6)
    private void FUN_9E40(CriPlayer param1)
    {
        short sVar2;
        int iVar3;
        int iVar4;
        short[] aVar5;
        ushort uVar6;
        short sVar7;
        int iVar8;
        int iVar9;
        int psVar10;
        short sVar11;

        if ((param1.DAT_11E & 1) == 0)
        {
            iVar3 = (int)GameManager.FUN_64650();
            iVar4 = (int)GameManager.FUN_64650();
            param1.DAT_1C0 &= 0xfb;
            uVar6 = (ushort)(param1.DAT_1A0 & 0xf);

            if (uVar6 == 1)
                iVar9 = 5;
            else
            {
                iVar9 = 1;

                if (uVar6 == 3)
                    iVar9 = 5;
            }

            if (!GameManager.instance.DAT_A2D0)
                aVar5 = DAT_16560;
            else
                aVar5 = DAT_165C0;

            psVar10 = iVar9 << 3;

            if (param1.health < 1)
                return;

            sVar11 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (sVar11 == 5 || sVar11 == 0x205 || (sVar11 == 0x601 && param1.DAT_60 - 26 < 12) || 
                sVar11 == 0x304 || sVar11 == 2 || param1.DAT_3C == 3)
            {
                iVar3 = (int)GameManager.FUN_64650();
                iVar8 = (ushort)aVar5[psVar10 + 5];
                sVar11 = (short)(iVar3 % iVar9);

                if (iVar8 == 0)
                    return; //trap(0x1c00)

                if (iVar8 == -1 && iVar3 == -0x80000000)
                    return; //trap(0x1800)

                sVar2 = aVar5[psVar10 + 4];
                sVar7 = param1.health;
                param1.DAT_1C5 = 0;
                param1.DAT_11C = (short)(sVar2 + sVar11);
                param1.health = (short)(sVar7 - (sVar2 + sVar11));
            }
            else
            {
                if (sVar11 == 0x105)
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    iVar8 = aVar5[psVar10 + 5];

                    if (iVar8 == 0)
                        return; //trap(0x1c00)

                    if (iVar8 == -1 && iVar3 == -0x80000000)
                        return; //trap(0x1800)

                    sVar11 = aVar5[psVar10 + 4];
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_1C5 = 4;
                    param1.DAT_196 = 0;
                    sVar11 += (short)(iVar3 % iVar9);
                    param1.DAT_11C = sVar11;
                    param1.health -= sVar11;
                }
                else
                {
                    if (param1.DAT_3C != 4)
                    {
                        if (param1.UDAT_1DC < ((iVar3 % 10) * 100 & 0xffff) + 0x1194)
                        {
                            iVar3 = (int)GameManager.FUN_64650();
                            iVar8 = aVar5[psVar10 + 5];
                            sVar11 = (short)(iVar3 % iVar8);

                            if (iVar8 == 0)
                                return; //trap(0x1c00)

                            if (iVar8 == -1 && iVar3 == -0x80000000)
                                return; //trap(0x1800)

                            sVar2 = aVar5[psVar10 + 4];
                            sVar7 = param1.health;
                            param1.DAT_1C5 = 2;
                        }
                        else
                        {
                            if ((((uint)iVar4 % 0x14) * 100 & 0xffff) + 0x1194 <= param1.UDAT_1DC)
                            {
                                iVar3 = (int)GameManager.FUN_64650();
                                iVar8 = aVar5[psVar10 + 1];
                                sVar11 = (short)(iVar3 % iVar8);

                                if (iVar8 == 0)
                                    return; //trap(0x1c00)

                                if (iVar8 == -1 && iVar3 == -0x80000000)
                                    return; //trap(0x1800)

                                sVar2 = aVar5[psVar10];
                                sVar7 = param1.health;
                                param1.DAT_1C5 = 0;
                                param1.DAT_11C = (short)(sVar2 + sVar11);
                                param1.health = (short)(sVar7 - (sVar2 + sVar11));
                                goto LAB_A1A0;
                            }
                            else
                            {
                                iVar3 = (int)GameManager.FUN_64650();
                                iVar8 = aVar5[psVar10 + 3];
                                sVar11 = (short)(iVar3 % iVar8);

                                if (iVar8 == 0)
                                    return; //trap(0x1c00)

                                if (iVar8 == -1 && iVar3 == -0x80000000)
                                    return; //trap(0x1800)

                                sVar2 = aVar5[psVar10 + 2];
                                sVar7 = param1.health;
                                param1.DAT_1C5 = 2;
                            }

                            param1.DAT_11C = (short)(sVar2 + sVar11);
                            param1.health = (short)(sVar7 - (sVar2 + sVar11));
                            goto LAB_A1A0;
                        }

                        param1.DAT_1C5 = 0;
                    }
                }

                LAB_A1A0:
                if (param1.health < 1)
                {
                    InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);

                    if (param1.DAT_1C5 == 0)
                    {
                        if (param1.DAT_3C == 3)
                            return;

                        if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
                            return;
                    }
                }

                sVar11 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

                if (param1.DAT_1C5 == 4 || sVar11 == 0x202 || (sVar11 == 5 && 0x3d < param1.DAT_60) || 
                    sVar11 == 0x205 && param1.DAT_60 < 0x17)
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.DAT_1C5 == 0) goto LAB_A2AC;

            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B46C(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 |= 2;
            }

            FUN_B4DC(param1);
        }

        if (param1.DAT_1C5 != 0)
            return;

        LAB_A2AC:
        FUN_BC9C(param1);
    }

    //FUN_A2D0 (ST6)
    private void FUN_A2D0(CriPlayer param1)
    {
        short sVar2;
        int iVar3;
        int iVar4;
        short[] aVar5;
        ushort uVar6;
        short sVar7;
        int iVar8;
        int iVar9;
        int psVar10;
        short sVar11;

        if ((param1.DAT_11E & 1) == 0)
        {
            iVar3 = (int)GameManager.FUN_64650();
            iVar4 = (int)GameManager.FUN_64650();
            param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xfb);
            uVar6 = (ushort)(param1.DAT_1A0 & 0xf);

            if (uVar6 == 1)
                iVar9 = 5;
            else
            {
                iVar9 = 1;

                if (uVar6 == 3)
                    iVar9 = 5;
            }

            if (GameManager.instance.DAT_A2D2 == 0)
                aVar5 = DAT_16560;
            else
                aVar5 = DAT_165C0;

            psVar10 = iVar9 << 3;

            if (param1.health < 1)
                return;

            sVar11 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (sVar11 == 5 || sVar11 == 0x205 || (sVar11 == 0x601 && param1.DAT_60 - 0x1a < 12) || 
                sVar11 == 0x304 || param1.DAT_3C == 2 || param1.DAT_3C == 3)
            {
                iVar3 = (int)GameManager.FUN_64650();
                iVar8 = aVar5[psVar10 + 5];
                sVar11 = (short)(iVar3 % iVar8);

                if (iVar8 == 0)
                    return; //trap(0x1c00)

                if (iVar8 == -1 && iVar3 == -0x80000000)
                    return; //trap(0x1800)

                sVar7 = aVar5[psVar10 + 4];
                sVar2 = param1.health;
                param1.DAT_1C5 = 0;
                sVar7 = (short)(sVar7 + sVar11 + 100);
                param1.DAT_11C = sVar7;
                param1.health = (short)(sVar2 - sVar7);
            }
            else
            {
                if (sVar11 == 0x105)
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    iVar8 = aVar5[psVar10 + 5];
                    sVar11 = (short)(iVar3 % iVar8);

                    if (iVar8 == 0)
                        return; //trap(0x1c00)

                    if (iVar8 == -1 && iVar3 == -0x80000000)
                        return; //trap(0x1800)

                    sVar7 = aVar5[psVar10 + 4];
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_1C5 = 4;
                    sVar2 = param1.health;
                    param1.DAT_196 = 0;
                    sVar7 = (short)(sVar7 + sVar11 + 100);
                    param1.DAT_11C = sVar7;
                    param1.health = (short)(sVar2 - sVar7);
                    goto LAB_A624;
                }

                if (param1.DAT_3C != 4)
                {
                    if (param1.UDAT_1DC < (((uint)iVar3 % 10) * 100 & 0xffff) + 0x157c)
                    {
                        iVar3 = (int)GameManager.FUN_64650();
                        iVar8 = aVar5[psVar10 + 5];
                        sVar11 = (short)(iVar3 % iVar8);

                        if (iVar8 == 0)
                            return; //trap(0x1c00)

                        if (iVar8 == -1 && iVar3 == -0x80000000)
                            return; //trap(0x1800)

                        sVar7 = aVar5[psVar10 + 4];
                        sVar2 = param1.health;
                        param1.DAT_1C5 = 2;
                    }
                    else
                    {
                        if ((((uint)iVar4 % 0x14) * 100 & 0xffff) + 6000 <= param1.UDAT_1DC)
                        {
                            iVar3 = (int)GameManager.FUN_64650();
                            iVar8 = aVar5[psVar10 + 1];
                            sVar11 = (short)(iVar3 % iVar8);

                            if (iVar8 == 0)
                                return; //trap(0x1c00)

                            if (iVar8 == -1 && iVar3 == -0x80000000)
                                return; //trap(0x1800)

                            sVar7 = aVar5[psVar10];
                            sVar2 = param1.health;
                            param1.DAT_1C5 = 0;
                            sVar7 = (short)(sVar7 + sVar11 + 100);
                            param1.DAT_11C = sVar7;
                            param1.health = (short)(sVar2 - sVar7);
                            goto LAB_A624;
                        }

                        iVar3 = (int)GameManager.FUN_64650();
                        iVar8 = aVar5[psVar10 + 3];
                        sVar11 = (short)(iVar3 % iVar8);

                        if (iVar8 == 0)
                            return; //trap(0x1c00)

                        if (iVar8 == -1 && iVar3 == -0x80000000)
                            return; //trap(0x1800)

                        sVar7 = aVar5[psVar10 + 2];
                        sVar2 = param1.health;
                        param1.DAT_1C5 = 2;
                    }

                    sVar7 = (short)(sVar7 + sVar11 + 100);
                    param1.DAT_11C = sVar7;
                    param1.health = (short)(sVar2 - sVar7);
                    goto LAB_A624;
                }

                param1.DAT_1C5 = 0;
            }

            LAB_A624:
            if (param1.health < 1)
            {
                InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);

                if (param1.DAT_1C5 == 0)
                {
                    if (param1.DAT_3C == 3)
                        return;

                    if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
                        return;
                }

                sVar11 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

                if (param1.DAT_1C5 == 4 || sVar11 == 0x202 || sVar11 == 5 &&
                    0x3d < param1.DAT_60 || (sVar11 == 0x205 && param1.DAT_60 < 0x17))
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.DAT_1C5 == 0) goto LAB_A730;

            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B46C(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 |= 2;
            }

            FUN_B4DC(param1);
        }

        if (param1.DAT_1C5 != 0)
            return;

        LAB_A730:
        FUN_BC9C(param1);
    }

    //FUN_A754 (ST6)
    private void FUN_A754(CriPlayer param1)
    {
        if (param1.DAT_3C - 2 < 3)
            param1.DAT_1C5 = 0;
        else
        {
            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B46C(param1);

            param1.DAT_3C = 2;
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_1C5 = 2;
            param1.DAT_1C0 |= 2;
            FUN_B4DC(param1);
        }

        param1.BDAT_1C0 |= 4;
        FUN_B598(param1);
    }

    //FUN_A7E4 (ST6)
    private void FUN_A7E4(CriPlayer param1)
    {
        byte bVar1;

        if (param1.DAT_3C != 5)
        {
            param1.DAT_1C6 = 0;
            bVar1 = (byte)(param1.DAT_1C7 + 1);
            param1.DAT_1C7 = (sbyte)bVar1;

            if (1 < bVar1)
                param1.DAT_194 = 1;

            FUN_A754(param1);
        }
    }

    //FUN_A838 (ST6)
    private void FUN_A838(CriPlayer param1)
    {
        if (param1.DAT_3C != 5)
        {
            param1.DAT_1C6 = 1;
            param1.DAT_194 = 1;
            FUN_A754(param1);
        }
    }

    //FUN_A870 (ST6)
    private void FUN_A870(CriPlayer param1)
    {
        if (param1.DAT_3C != 5)
        {
            param1.DAT_1C6 = 2;
            param1.DAT_194 = 1;
            FUN_A754(param1);
        }
    }

    //FUN_A8A8 (ST6)
    private void FUN_A8A8(CriPlayer param1)
    {
        short sVar2;

        if ((param1.DAT_11E & 1) == 0 && 0 < param1.health)
        {
            if (param1.DAT_3C != 4 || (param1.DAT_3C == 4 && param1.DAT_3D == 3))
                param1.health = -1;

            sVar2 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);
            param1.DAT_1C6 = 3;
            param1.DAT_1C0 |= 4;

            if (sVar2 == 5 || param1.DAT_3C == 4 || sVar2 == 0x205 || param1.DAT_3C == 2 || param1.DAT_3C == 3)
                param1.DAT_1C5 = 0;
            else
            {
                if (sVar2 == 0x105)
                {
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 2;
                    param1.DAT_196 = 0;
                    param1.DAT_1C5 = 4;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.health < 1)
            {
                InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);

                if (param1.DAT_1C5 == 0)
                {
                    if (param1.DAT_3C == 0)
                        return;

                    if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
                        return;
                }

                sVar2 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

                if (param1.DAT_1C5 == 4 || sVar2 == 0x202 || (sVar2 == 5 && 0x3d < param1.DAT_60) ||
                    sVar2 == 0x205 && param1.DAT_60 < 0x17)
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.DAT_1C5 != 0)
            {
                if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                    FUN_B46C(param1);

                if (param1.DAT_1C5 == 2)
                {
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_1C0 |= 2;
                }

                FUN_B4DC(param1);
            }
        }

        FUN_B598(param1);
    }

    //FUN_AA84 (ST6)
    private void FUN_AA84(CriPlayer param1)
    {
        DAT_173F0 = (ushort)((param1.DAT_1A0 & 0xf) == 9 ? 1 : 0);
        PTR_FUN_16BE4[DAT_173F0](param1);
    }

    //FUN_AAF0 (ST6)
    private void FUN_AAF0(CriPlayer param1)
    {
        short sVar2;
        short sVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        short[] aVar7;
        short sVar8;

        if ((param1.DAT_11E & 1) == 0)
        {
            iVar4 = (int)GameManager.FUN_64650();
            iVar5 = (int)GameManager.FUN_64650();
            param1.BDAT_1C0 = (sbyte)(param1.BDAT_1C0 & 0xfb);

            if (param1.health < 1)
                return;

            if (!GameManager.instance.DAT_A2D0)
                aVar7 = DAT_16590;
            else
                aVar7 = DAT_165F0;

            sVar8 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (sVar8 == 5 || sVar8 == 0x205 || sVar8 == 0x304 || 
                param1.DAT_3C == 2 || param1.DAT_3C == 3)
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar6 = aVar7[7];
                sVar8 = (short)(iVar4 % iVar6);

                if (iVar6 == 0)
                    return; //trap(0x1c00)

                if (iVar6 == -1 && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                sVar2 = aVar7[6];
                sVar3 = param1.health;
                param1.DAT_1C5 = 0;
                param1.DAT_11C = (short)(sVar2 + sVar8);
                param1.health = (short)(sVar3 - (sVar2 + sVar8));
            }
            else
            {
                if (sVar8 == 0x105)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    iVar6 = aVar7[7];
                    sVar8 = (short)(iVar4 % iVar6);

                    if (iVar6 == 0)
                        return; //trap(0x1c00)

                    if (iVar6 == -1 && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar2 = aVar7[6];
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_1C5 = 4;
                    sVar3 = param1.health;
                    param1.DAT_196 = 0;
                }
                else
                {
                    if (param1.DAT_3C == 4)
                    {
                        param1.DAT_1C5 = 0;
                        goto LAB_AE18;
                    }

                    if ((((uint)iVar4 % 10) * 100 & 0xffff) + 3000 <= param1.UDAT_1DC)
                    {
                        if (param1.UDAT_1DC < (((uint)iVar5 % 30) * 100 & 0xffff) + 4000)
                        {
                            iVar4 = (int)GameManager.FUN_64650();
                            iVar6 = aVar7[5];
                            sVar8 = (short)(iVar4 % iVar6);

                            if (iVar6 == 0)
                                return; //trap(0x1c00)

                            if (iVar6 == -1 && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            sVar2 = aVar7[4];
                        }
                        else
                        {
                            iVar4 = (int)GameManager.FUN_64650();
                            iVar6 = aVar7[3];
                            sVar8 = (short)(iVar4 % iVar6);

                            if (iVar6 == 0)
                                return; //trap(0x1c00)

                            if (iVar6 == -1 && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            sVar2 = aVar7[2];
                        }

                        sVar3 = param1.health;
                        param1.DAT_1C5 = 2;
                        param1.DAT_11C = (short)(sVar2 + sVar8);
                        param1.health = (short)(sVar3 - (sVar2 + sVar8));
                        goto LAB_AE18;
                    }

                    iVar4 = (int)GameManager.FUN_64650();
                    iVar6 = aVar7[7];
                    sVar8 = (short)(iVar4 % iVar6);

                    if (iVar6 == 0)
                        return; //trap(0x1c00)

                    if (iVar6 == -1 && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar2 = aVar7[6];
                    param1.DAT_1C5 = 1;
                    sVar3 = param1.health;
                }

                param1.DAT_11C = (short)(sVar2 + sVar8);
                param1.health = (short)(sVar3 - (sVar2 + sVar8));
            }

            LAB_AE18:
            if (param1.health < 1)
            {
                InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);

                if (param1.DAT_1C5 == 0)
                {
                    if (param1.DAT_3C == 3)
                        return;

                    if (param1.DAT_3C == 4 && param1.DAT_3D == 3)
                        return;
                }

                sVar8 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

                if (param1.DAT_1C5 == 4 || sVar8 == 0x202 || (sVar8 == 5 && 0x3d < param1.DAT_60) || 
                   (sVar8 == 0x205 && param1.DAT_60 < 0x17))
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                {
                    if (param1.DAT_1C5 != 2)
                        param1.DAT_1C5 = 1;
                }
            }

            if (param1.DAT_1C5 == 0) goto LAB_AF44;

            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B46C(param1);

            if (param1.DAT_1C5 == 1)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 0;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
            else
            {
                if (param1.DAT_1C5 == 2)
                {
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.BDAT_1C0 |= 2;
                }
            }

            FUN_B4DC(param1);
        }

        if (param1.DAT_1C5 != 0)
            return;

        LAB_AF44:
        FUN_BC9C(param1);
    }

    //FUN_AF68 (ST6)
    private void FUN_AF68(CriPlayer param1)
    {
        CriInteract oVar1;
        CriBone oVar2;

        if (param1.UDAT_1D2 == 0)
        {
            oVar1 = SceneManager.instance.FUN_5FF08();

            if (oVar1 != null)
            {
                oVar1.DAT_01 = 11;
                oVar2 = param1.skeleton;
                oVar1.BDAT_0A = 17;
                //...
                oVar1.PTR_18 = oVar2;
                param1.UDAT_1D2 = 45;
            }

            FUN_AAF0(param1);
        }
    }

    //FUN_AFE0 (ST6)
    private void FUN_AFE0(CriPlayer param1)
    {
        sbyte sVar1;

        if (GameManager.instance.DAT_9AA0 >> 8 == 6 || GameManager.instance.DAT_9AA0 >> 8 == 9)
        {
            sVar1 = (sbyte)GameManager.instance.DAT_9AA0;

            if ((sVar1 - 3) < 6)
            {
                if (sVar1 == 8)
                {
                    param1.DAT_1CB = 4;
                    return;
                }

                if (sVar1 != 7)
                {
                    param1.DAT_1CB = (byte)(sVar1 - 3);
                    return;
                }
            }
        }

        param1.DAT_1CB = 5;
    }

    //FUN_B058 (ST6)
    private void FUN_B058(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        uint uVar3;

        iVar2 = (int)GameManager.FUN_64650();
        sVar1 = 1000;

        if (iVar2 == (iVar2 / 3) * 3)
        {
            uVar3 = GameManager.FUN_64650();
            sVar1 = 1200;

            if ((uVar3 & 2) == 0)
                sVar1 = 850;
        }

        param1.maxHealth = sVar1;
    }

    //FUN_B0C0 (ST6)
    private void FUN_B0C0(CriPlayer param1)
    {
        CriPlayer oVar1;
        uint uVar2;
        int iVar3;

        oVar1 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

        if (oVar1 != null)
        {
            if ((oVar1.BDAT_1C0 & 1) != 0)
            {
                if (param1.UDAT_1DC < 5000)
                    uVar2 = oVar1.UDAT_1DC;
                else
                    uVar2 = oVar1.UDAT_1DC;

                if (uVar2 < 5000)
                {
                    iVar3 = (int)GameManager.FUN_64650();

                    if (iVar3 == (iVar3 / 3) * 3)
                    {
                        if (oVar1.UDAT_1DC <= param1.UDAT_1DC)
                        {
                            oVar1.DAT_1C8 = 0;
                            goto LAB_B1E4;
                        }
                    }
                    else
                    {
                        if (param1.UDAT_1DC <= oVar1.UDAT_1DC)
                        {
                            oVar1.DAT_1C8 = 0;
                            goto LAB_B1E4;
                        }
                    }

                    oVar1.DAT_1C8 = 1;
                }
                else
                {
                    if (oVar1.DAT_1C8 != 0)
                        return;

                    oVar1.DAT_1C8 = 1;
                }

                param1.DAT_1C8 = 0;
                return;
            }

            if (oVar1.DAT_1C8 != 0)
                oVar1.DAT_1C8 = 0;
        }

        LAB_B1E4:
        param1.DAT_1C8 = 1;
    }

    //FUN_B1FC (ST6)
    private void FUN_B1FC(CriPlayer param1)
    {
        uint uVar1;
        uint uVar2;
        CriPlayer oVar3;
        
        if ((GameManager.instance.DAT_922C & 2) == 0 && (param1.DAT_128 & 0x3ff) != 0)
        {
            uVar2 = 0;
            uVar1 = param1.DAT_128;

            do
            {
                if ((uVar1 & 1) != 0) break;

                uVar2++;
                uVar1 = (uint)param1.DAT_128 >> (int)(uVar2 & 31);
            } while ((byte)uVar2 < 10);

            oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
            uVar2 = Utilities.FUN_631AC(oVar3.screen, SceneManager.instance.DAT_27C[10].screen);

            if (uVar2 < param1.UDAT_1DC)
            {
                param1.DAT_1C8 = 0;
                oVar3.DAT_1C8 = 1;
            }
            else
            {
                param1.DAT_1C8 = 1;
                oVar3.DAT_1C8 = 0;
            }
        }
    }

    //FUN_B2E0 (ST6)
    private void FUN_B2E0(CriPlayer param1)
    {
        CriPlayer oVar1;
        uint uVar2;
        int iVar3;

        if (param1.DAT_1C8 == 0)
            return;

        oVar1 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

        if (oVar1 == null)
            return;

        if ((oVar1.BDAT_1C0 & 1) == 0)
            return;

        if (param1.UDAT_1DC < 5000)
            uVar2 = oVar1.UDAT_1DC;
        else
            uVar2 = oVar1.UDAT_1DC;

        if (uVar2 < 5000)
        {
            iVar3 = (int)GameManager.FUN_64650();

            if (iVar3 == (iVar3 / 3) * 3)
            {
                if (oVar1.UDAT_1DC <= param1.UDAT_1DC)
                {
                    oVar1.DAT_1C8 = 0;
                    param1.DAT_1C8 = 1;
                    return;
                }
            }
            else
            {
                if (param1.UDAT_1DC <= oVar1.UDAT_1DC)
                {
                    oVar1.DAT_1C8 = 0;
                    param1.DAT_1C8 = 1;
                    return;
                }
            }

            oVar1.DAT_1C8 = 1;
        }
        else
        {
            if (oVar1.DAT_1C8 != 0)
                return;

            oVar1.DAT_1C8 = 1;
        }

        param1.DAT_1C8 = 0;
    }

    //FUN_B418 (ST6)
    private void FUN_B418(CriPlayer param1)
    {
        CriPlayer oVar1;

        oVar1 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

        if (oVar1 == null || (oVar1.BDAT_1C0 & 1) == 0)
            param1.DAT_1C8 = 1;
        else
        {
            oVar1.DAT_1C8 = 1;
            param1.DAT_1C8 = 0;
        }
    }

    //FUN_B46C (ST6)
    private void FUN_B46C(CriPlayer param1)
    {
        short sVar1;

        sVar1 = 0x28;

        if ((param1.DAT_1C0 & 8) == 0)
            sVar1 = -0x28;

        param1.vr.y = param1.vr.y + sVar1 * (short)param1.DAT_60 & 0xfff;
    }
    
    //FUN_B4AC (ST6)
    private void FUN_B4AC(CriPlayer param1)
    {
        param1.PTR_120 = DAT_16488;
        param1.DAT_120 = 0;
        param1.DAT_12E = 3;
    }

    //FUN_B4C4 (ST6)
    private void FUN_B4C4(CriPlayer param1)
    {
        param1.PTR_124 = DAT_16488;
        param1.DAT_124 = 12;
        param1.DAT_12F = 5;
    }

    //FUN_B4DC (ST6)
    private void FUN_B4DC(CriPlayer param1)
    {
        CriPlayer oVar1;
        CriPlayer oVar2;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar2 = oVar1.DAT_1DC;
        
        if (oVar1.DAT_3C == 5 && oVar1.DAT_3D == 8 && oVar2 == param1)
        {
            if (2 < oVar1.DAT_3E)
                SceneManager.instance.FUN_26E6C();

            oVar1.DAT_3E = 5;
            oVar1.FUN_6103C(47, 0, 16, 0);
            oVar1.DAT_60 = 0x10;
            oVar1.DAT_18D = true;
            oVar2.DAT_18D = true;
            oVar1.DAT_152 = 0;
            oVar2.DAT_152 = 0;
            oVar1.DAT_11E &= 0xf7;
        }
    }

    //FUN_B598 (ST6)
    private void FUN_B598(CriPlayer param1)
    {
        bool bVar1;
        sbyte sVar1;
        byte bVar2;
        short sVar3;
        int iVar4;
        uint uVar5;
        int iVar6;
        uint uVar7;
        int iVar8;

        sVar3 = param1.FUN_64804(SceneManager.instance.DAT_27C[10].screen);

        if ((ushort)(sVar3 - 0x200) < 0xc00)
        {
            iVar8 = 1;

            if (0x3ff < (short)(sVar3 - 0x200))
            {
                iVar8 = 3;

                if ((ushort)(sVar3 - 0x600) < 0x400)
                    iVar8 = 2;
            }
        }
        else
            iVar8 = 0;

        iVar4 = (int)GameManager.FUN_64650();
        iVar6 = iVar4;

        if (iVar4 < 0)
            iVar6 = iVar4 + 3;

        uVar7 = (uint)(iVar4 + (iVar6 >> 2) * -4);
        sVar1 = (sbyte)Utilities.FUN_22EF4(param1, uVar7 + (uint)iVar8 * 4 & 0xff);
        uVar5 = uVar7;

        if (sVar1 != 0)
        {
            uVar5 = Utilities.FUN_22F08(param1, (uint)iVar8);

            if ((uVar5 & 0xff) == 0xff)
            {
                SceneManager.instance.FUN_23068((byte)iVar8, (byte)uVar7);
                uVar5 = uVar7;
            }
        }

        bVar1 = FUN_B708(param1, (uint)iVar8, uVar5 & 0xff);

        if (bVar1)
        {
            bVar2 = (byte)(param1.DAT_199 + 1);
            param1.DAT_199 = bVar2;
            param1.DAT_19A |= (ushort)(1 << (int)(uVar5 + (uint)iVar8 * 4 & 0x1f));

            if (4 < bVar2)
            {
                param1.DAT_199 = 4;
                SceneManager.instance.FUN_22F9C();
            }
        }
    }

    //FUN_B708 (ST6)
    private bool FUN_B708(CriPlayer param1, uint param2, uint param3)
    {
        return param1.FUN_65D78(ref PTR_DAT_16D20[(param2 & 0xff) * 4 + (param3 & 0xff)], (byte)(param2 & 0xff), (byte)(param3 & 0xff));
    }

    //FUN_B748 (ST6)
    private void FUN_B748(CriPlayer param1)
    {
        sbyte sVar1;
        short sVar2;

        sVar2 = param1.DAT_194;

        if (0 < param1.DAT_194)
        {
            sVar1 = (sbyte)param1.DAT_3C;

            if (sVar1 != 3 && sVar1 != 4)
            {
                param1.DAT_194 = (short)(sVar2 - 1);

                if (sVar2 == 1)
                {
                    if (sVar1 == 2)
                        param1.DAT_194 = 1;
                    else
                    {
                        param1.DAT_194 = 0;
                        param1.DAT_3C = 5;
                        param1.DAT_3D = 0;
                        param1.DAT_3E = 0;
                        param1.DAT_3F = 0;
                        param1.FUN_65D0C(0, 30);
                    }
                }
            }
        }
    }

    //FUN_BB4C (ST6)
    private void FUN_BB4C(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        int iVar3;
        uint uVar4;

        sVar1 = param1.FUN_64804(SceneManager.instance.DAT_27C[10].screen);

        if ((ushort)(sVar1 - 0xa00) < 0x400)
        {
            iVar2 = (int)GameManager.FUN_64650();
            iVar3 = iVar2;

            if (iVar2 < 0)
                iVar3 = iVar2 + 3;

            uVar4 = (uint)((iVar2 + (iVar3 >> 2) * -4) * 2);
        }
        else
        {
            if ((ushort)(sVar1 - 0x200) < 0x400)
            {
                iVar2 = (int)GameManager.FUN_64650();
                iVar3 = iVar2;

                if (iVar2 < 0)
                    iVar3 = iVar2 + 3;

                uVar4 = (uint)((iVar2 + (iVar3 >> 2) * -4) * 2 + 8);
            }
            else
            {
                if ((ushort)(sVar1 - 0x200) < 0xc00)
                {
                    iVar2 = (int)GameManager.FUN_64650();
                    iVar3 = iVar2;

                    if (iVar2 < 0)
                        iVar3 = iVar2 + 3;

                    uVar4 = (uint)((iVar2 + (iVar3 >> 2) * -4) * 2 + 0x18);
                }
                else
                {
                    iVar2 = (int)GameManager.FUN_64650();
                    iVar3 = iVar2;

                    if (iVar2 < 0)
                        iVar3 = iVar2 + 3;

                    uVar4 = (uint)((iVar2 + (iVar3 >> 2) * -4) * 2 + 0x10);
                }
            }
        }

        //FUN_65D1C
    }

    //FUN_BC9C (ST6)
    private void FUN_BC9C(CriPlayer param1)
    {
        short sVar1;
        uint uVar2;
        int iVar3;
        int iVar4;

        sVar1 = param1.FUN_64804(SceneManager.instance.DAT_27C[10].screen);
        iVar4 = 9;

        if ((ushort)(sVar1 - 0xa00) < 0x400)
        {
            uVar2 = param1.DAT_1CB;
        }
        else
        {
            iVar4 = 7;

            if ((ushort)(sVar1 - 0x200) < 0x400)
            {
                uVar2 = param1.DAT_1CB;
            }
            else
            {
                if ((ushort)(sVar1 - 0x200) < 0xc00)
                {
                    uVar2 = param1.DAT_1CB;
                }
                else
                {
                    iVar4 = 7;
                    uVar2 = param1.DAT_1CB;
                }
            }
        }

        //FUN_65D1C
    }

    //FUN_BD54 (ST6)
    private void FUN_BD54(CriPlayer param1)
    {
        CriBone oVar2;
        CriParticle oVar3;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        auStack48 = new Matrix3x3();
        oVar2 = (CriBone)Utilities.FUN_601C8(param1.skeleton, 0);
        Utilities.RotMatrix(ref param1.vr, ref auStack48);
        local_38 = Utilities.ApplyMatrixSV(ref auStack48, ref oVar2.DAT_44);
        oVar3 = SceneManager.instance.FUN_5FFA0();

        if (oVar3 != null)
        {
            oVar3.tags = 0;
            oVar3.DAT_3C = 3;
            oVar3.DAT_2F = 0;
            oVar3.screen.x = param1.screen.x + local_38.x;
            oVar3.screen.y = param1.screen.y;
            oVar3.screen.z = param1.screen.z + local_38.z;
            oVar3.DAT_68 = 120;
            oVar3.DAT_62 = 0;
            oVar3.DAT_60 = 0;
            oVar3.DAT_69 = 76;
        }
    }

    //FUN_C06C (ST6)
    private void FUN_C06C(CriPlayer param1)
    {
        CriPlayer oVar1;

        GameManager.instance.FUN_5DC54();
        GameManager.instance.FUN_46C0C(1, 30, 1);
        DialogManager.instance.DAT_B1440 = 4;
        InventoryManager.DAT_B7A60[0] |= 4;
        param1.DAT_1C9 = 1;
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar1.DAT_11E |= 1;
        param1.DAT_11E |= 8;
        oVar1.DAT_12C |= 8;
        SceneManager.instance.DAT_272 = false;
        SceneManager.instance.DAT_270 = (byte)param1.tags;
        SceneManager.instance.DAT_271 = true;
        SceneManager.instance.DAT_274 = param1.cSkin;
        SceneManager.instance.DAT_278 = param1.DAT_98;
    }

    //FUN_C140 (ST6)
    private void FUN_C140(CriPlayer param1)
    {
        if ((param1.DAT_1C9 & 1) != 0 && !GameManager.instance.DAT_6D)
        {
            param1.DAT_1C9 &= 0xfe;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_C184 (ST6)
    private void FUN_C184(CriPlayer param1)
    {
        byte bVar1;
        CriCamera cVar2;
        Vector3Int local_50;
        Vector3Int local_48;
        Vector3Int local_40;
        Matrix3x3 auStack56;

        bVar1 = param1.BDAT_1CA;
        auStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref param1.vr, ref auStack56);
        local_50 = Utilities.ApplyMatrixSV(ref auStack56, ref DAT_16EB4[bVar1]);
        local_40 = new Vector3Int(param1.screen.x + local_50.x, param1.screen.y + DAT_16EAC[bVar1], param1.screen.z + local_50.z);
        Utilities.RotMatrix(ref SceneManager.instance.DAT_27C[10].vr, ref auStack56);
        local_50 = Utilities.ApplyMatrixSV(ref auStack56, ref DAT_16EB4[bVar1 + 2]);
        local_48 = new Vector3Int(param1.screen.x + local_50.x, param1.screen.y + DAT_16EAC[bVar1 + 2], param1.screen.z + local_50.z);
        SceneManager.instance.FUN_264C4(0, (short)local_48.x, (short)local_48.y, (short)local_48.z);
        SceneManager.instance.FUN_26504(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_269C8(local_48, local_40);
        cVar2 = SceneManager.instance.cCamera;
        cVar2.DAT_8B = 0;
        cVar2.DAT_8A = 0;
        cVar2.DAT_92 = 0;
        cVar2.DAT_52 = 0;
        cVar2.DAT_50 = 0;
        cVar2.DAT_3E = 0;
        cVar2.DAT_36 = 0;
        cVar2.DAT_90 = 0;
        cVar2.DAT_56 = 0;
        cVar2.DAT_54 = 0;
        cVar2.DAT_2E = 0;
        cVar2.DAT_2F = 0;
        cVar2.DAT_26 = 0;
        cVar2.tags = 0;
    }

    //FUN_C320 (ST6)
    private void FUN_C320(CriPlayer param1)
    {
        uint uVar1;
        CriPlayer oVar2;
        CriCamera cVar3;
        Vector3Int local_50;
        Vector3Int local_48;
        Vector3Int local_40;
        Matrix3x3 auStack56;

        uVar1 = param1.BDAT_1CA;
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        cVar3 = SceneManager.instance.cCamera;
        auStack56 = new Matrix3x3();
        local_48 = new Vector3Int();

        if (uVar1 != 0)
        {
            Utilities.RotMatrix(ref oVar2.vr, ref auStack56);
            local_50 = Utilities.ApplyMatrixSV(ref auStack56, ref DAT_16EE0[uVar1 + 2]);
            local_48 = new Vector3Int(param1.screen.x + local_50.x, param1.screen.y + DAT_16ED4[uVar1 + 2], param1.screen.z + local_50.z);
            cVar3.DAT_8B = 2;
            cVar3.DAT_36 = DAT_16ED4[uVar1 + 4];
            SceneManager.instance.FUN_264C4(1, (short)local_48.x, (short)local_48.y, (short)local_48.z);
        }

        Utilities.RotMatrix(ref param1.vr, ref auStack56);
        local_50 = Utilities.ApplyMatrixSV(ref auStack56, ref DAT_16EE0[uVar1]);
        local_40 = new Vector3Int(param1.screen.x + local_50.x, param1.screen.y + DAT_16ED4[uVar1], param1.screen.z + local_50.z);
        cVar3.DAT_8A = 2;
        cVar3.DAT_26 = DAT_16ED4[uVar1 + 4];
        SceneManager.instance.FUN_26504(1, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_269C8(local_48, local_40);
    }

    //FUN_C4D8 (ST6)
    private void FUN_C4D8(CriPlayer param1)
    {
        CriCamera cVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        local_40 = new Vector3Int(0, 0, 1000);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref param1.vr, ref auStack48);
        local_40 = Utilities.ApplyMatrixSV(ref auStack48, ref local_40);
        local_38 = new Vector3Int(param1.screen.x + local_40.x, param1.screen.y - 2000, param1.screen.z + local_40.z);
        SceneManager.instance.FUN_264C4(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        cVar1 = SceneManager.instance.cCamera;
        cVar1.DAT_7C = new Vector3Int(0x180, 0xc00, 0x9c4);
    }

    //FUN_CD5C (ST6)
    public static void FUN_CD5C(CriParticle param1)
    {
        return;
    }

    //FUN_D550 (ST6)
    public static void FUN_D550(CriParticle param1)
    {
        return;
    }

    //FUN_DDEC (ST6)
    public static void FUN_DDEC(CriParticle param1)
    {
        return;
    }

    //FUN_DEF4 (ST6)
    public static void FUN_DEF4(CriParticle param1)
    {
        return;
    }

    //FUN_C904 (ST6)
    public static void FUN_C904(CriParticle param1)
    {
        return;
    }

    //FUN_CB2C (ST6)
    public static void FUN_CB2C(CriParticle param1)
    {
        return;
    }

    //FUN_E0A8 (ST6)
    public static void FUN_E0A8(CriParticle param1)
    {
        return;
    }

    //FUN_E2B0 (ST6)
    public static void FUN_E2B0(CriParticle param1)
    {
        return;
    }

    //FUN_E410 (ST6)
    public static void FUN_E410(CriParticle param1)
    {
        return;
    }

    //FUN_E59C (ST6)
    public static void FUN_E59C(CriParticle param1)
    {
        return;
    }

    //FUN_E73C (ST6)
    public static void FUN_E73C(CriParticle param1)
    {
        return;
    }

    //FUN_E8E4 (ST6)
    public static void FUN_E8E4(CriParticle param1)
    {
        return;
    }

    //FUN_EB5C (ST6)
    public static void FUN_EB5C(CriParticle param1)
    {
        return;
    }

    //FUN_1B98 (ST6)
    public static void FUN_1B98(CriPlayer param1)
    {
        instance.PTR_FUN_162DC[param1.DAT_2F - 2](param1);

        if ((param1.UDAT_1D2 & 0x8000) != 0)
            instance.FUN_2AC(param1);
    }

    //FUN_3B5C (ST6)
    public static void FUN_3B5C(CriPlayer param1)
    {
        sbyte sVar1;
        ushort uVar3;
        uint uVar4;
        CriPlayer oVar5;
        Vector3Int vVar6;

        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if (param1.DAT_3C != 0)
        {
            if ((InventoryManager.DAT_B7A60[0] & 2) != 0)
            {
                param1.FUN_66208();
                return;
            }

            if ((param1.DAT_18E & 0x80) != 0)
            {
                param1.FUN_66208();
                goto LAB_3D84;
            }
        }

        if (param1.DAT_3C == 1 && param1.DAT_3D == 1)
            vVar6 = (Vector3Int)param1.VDAT_1E4;
        else
            vVar6 = param1.screen;

        sVar1 = GameManager.instance.FUN_774CC(param1, vVar6);
        param1.DAT_1C2 = (byte)sVar1;

        if ((sbyte)param1.DAT_1C2 == -1)
        {
            GameManager.instance.FUN_77238((byte)param1.DAT_48, ref param1.VDAT_1E4);
            sVar1 = GameManager.instance.FUN_774CC(param1, (Vector3Int)param1.VDAT_1E4);
        }

        param1.cTransform.position = param1.screen;
        uVar4 = Utilities.FUN_631AC(param1.screen, oVar5.screen);
        param1.UDAT_1DC = uVar4;

        if (param1.DAT_177 != 0)
            param1.DAT_177--;

        instance.FUN_C140(param1);
        instance.FUN_B748(param1);
        uVar3 = (ushort)(param1.UDAT_1D2 - 1);

        if (0 < param1.UDAT_1D2)
        {
            param1.UDAT_1D2 = uVar3;

            if (uVar3 << 0x10 < 0)
                param1.UDAT_1D2 = 0;
        }

        LAB_3D84:
        param1.FUN_6449C(param1.DAT_140);
        param1.DAT_48 = (sbyte)-(param1.screen.y / 0x1a9);
    }

    //FUN_15668 (ST6)
    public static void FUN_15668(CriStatic param1)
    {
        return;
    }

    //FUN_155E0 (ST6)
    public static void FUN_155E0(CriStatic param1)
    {
        return;
    }

    //FUN_EB98 (ST6)
    public static void FUN_EB98(CriInteract param1)
    {
        return;
    }

    //FUN_1200C (ST6)
    public static void FUN_1200C(CriInteract param1)
    {
        return;
    }

    //FUN_12048 (ST6)
    public static void FUN_12048(CriInteract param1)
    {
        return;
    }

    //FUN_14380 (ST6)
    public static void FUN_14380(CriInteract param1)
    {
        return;
    }

    //FUN_F1A8 (ST6)
    public static void FUN_F1A8(CriInteract param1)
    {
        return;
    }

    //FUN_144A8 (ST6)
    public static void FUN_144A8(CriInteract param1)
    {
        return;
    }

    //FUN_12D2C (ST6)
    public static void FUN_12D2C(CriInteract param1)
    {
        return;
    }

    //FUN_14C04 (ST6)
    public static void FUN_14C04(CriInteract param1)
    {
        return;
    }

    //FUN_14EA8 (ST6)
    public static void FUN_14EA8(CriInteract param1)
    {
        return;
    }

    //FUN_153B0 (ST6)
    public static void FUN_153B0(CriInteract param1)
    {
        return;
    }

    //FUN_153EC (ST6)
    public static void FUN_153EC(CriInteract param1)
    {
        return;
    }
}
