using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct UNK_11CD8
{
    public uint DAT_00; //0x00
    public byte DAT_04; //0x04
}

struct UNK_11DA8
{
    public byte DAT_06; //0x06
    public byte DAT_07; //0x07
    public byte DAT_08; //0x08
    public byte DAT_09; //0x09
    public byte DAT_0A; //0x0A
}

struct UNK_123CC
{
    public Vector3Int[] DAT_00; //0x00
    public byte DAT_04; //0x04
}

public class ST3 : LevelManager
{
    public static new ST3 instance;

    private byte[] DAT_28 = new byte[] { 0, 1, 2, 3, 4, 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4 };
    public FUN_B58BC[] DAT_11B40 = new FUN_B58BC[22] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08,
                                                       null, FUN_46A1C, null, null, null, FUN_45D38, FUN_45E70, FUN_464F8,
                                                       FUN_3A4, FUN_CF0, FUN_14E4, FUN_1D80, FUN_1E88, FUN_2308, FUN_203C,
                                                       FUN_2170 };
    public FUN_B58C0[] DAT_11B98 = new FUN_B58C0[10] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0, null, null, FUN_6364, null, null,
                                                       null, null };
    public FUN_C2570[] DAT_11BC0 = new FUN_C2570[8]  { FUN_4A26C, FUN_7F6F8, FUN_7F750, null, FUN_7F7E4, null, null,
                                                       FUN_7F808 };
    public FUN_C1CF8[] DAT_11BE0 = new FUN_C1CF8[23] { FUN_20A98, null, FUN_20AA8, FUN_20B0C, FUN_21758, FUN_21ECC,
                                                       FUN_22178, null, null, null, FUN_222AC, FUN_22464, FUN_2268C,
                                                       FUN_2778, FUN_2BF0, FUN_3428, FUN_3B10, FUN_3B4C, null,
                                                       FUN_3E7C, FUN_6854, FUN_9624, FUN_1096C };
    public byte[][] DAT_11AB0 = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 10, 27, 15, 13, 0, 32, 25, 20, 18, 33, 30, 27, 24, 34, 31, 0, 25, 35, 0, 0, 0, 22, 0, 28, 26, 23, 0, 29, 27, 16, 0, 30, 29, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 8, 27, 0, 0, 0, 32, 25, 20, 20, 33, 30, 27, 24, 34, 31, 0, 25, 35, 0, 0, 0, 22, 0, 28, 26, 23, 0, 29, 27, 16, 0, 30, 29, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 8, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 6, 0, 0, 35, 0, 0, 0, 22, 0, 0, 0, 23, 0, 0, 0, 16, 26, 20, 19, 17, 31, 30, 29, 24, 0, 31, 31, 25, 0, 0, 0 }
    };
    public TrgScriptableObject DAT_118D0; //0x118D0 (ST3)
    public TrgScriptableObject DAT_119C0; //0x119C0 (ST3)
    public uint[] DAT_11674 = new uint[151] { 0x0, 0xa, 0x11, 0x22, 0x31, 0x36, 0x80000046, 0x0, 0x16, 0x3a, 0x80000060, 0x0, 0x8, 0x17, 0x36, 0x8000005b, 0x0, 0xa, 0x18, 0x26, 0x2e, 0x36, 0x80000044, 0x0, 0x16, 0x80000046, 0x0, 0xc, 0x10, 0x1d, 0x21, 0x32, 0x3b, 0x80000044, 0x0, 0x6, 0x9, 0x22, 0x2e, 0x33, 0x80000047, 0x0, 0x1f, 0x24, 0x39, 0x8000004e, 0x0, 0x15, 0x1b, 0x20, 0x29, 0x36, 0x80000060, 0x0, 0x8, 0x16, 0x36, 0x80000047, 0x0, 0xe, 0x2f, 0x33, 0x80000040, 0x0, 0xd, 0x24, 0x32, 0x38, 0x80000045, 0x0, 0x7, 0xc, 0x12, 0x21, 0x27, 0x30, 0x39, 0x80000041, 0x0, 0x7, 0xf, 0x30, 0x80000042, 0x0, 0x12, 0x1a, 0x25, 0x39, 0x80000052, 0x0, 0x8, 0xb, 0x12, 0x18, 0x24, 0x30, 0x80000048, 0x0, 0x6, 0x17, 0x2b, 0x80000040, 0x0, 0x6, 0x2a, 0x31, 0x80000040, 0x0, 0xf, 0x24, 0x36, 0x8000003e, 0x0, 0x13, 0x2b, 0x8000004c, 0x0, 0x26, 0x37, 0x80000046, 0x0, 0x12, 0x26, 0x35, 0x8000004e, 0x0, 0x20, 0x27, 0x3b, 0x8000004a, 0x0, 0x10, 0x30, 0x3c, 0x80000050, 0x0, 0x8, 0x18, 0x29, 0x35, 0x3b, 0x80000047, 0x0, 0x12, 0x34, 0x80000044, 0x0, 0x1b, 0x25, 0x34, 0x80000043 };
    private delegate void FUN_11C70(CriParticle p); //0x11C70 (ST3)
    private delegate void FUN_11C80(CriParticle p); //0x11C80 (ST3)
    private delegate void FUN_11CBC(CriParticle p); //0x11CBC (ST3)
    private delegate void FUN_11CCC(CriParticle p); //0x11CCC (ST3)
    private delegate void FUN_11CF0(CriParticle p); //0x11CF0 (ST3)
    private delegate void FUN_11CFC(CriParticle p); //0x11CFC (ST3)
    private delegate void FUN_11D34(CriParticle p); //0x11D34 (ST3)
    private delegate void FUN_11D64(CriParticle p); //0x11D64 (ST3)
    private delegate void FUN_11D98(CriInteract i); //0x11D98 (ST3)
    private delegate void FUN_11E14(CriInteract i); //0x11E14 (ST3)
    private delegate void FUN_11E48(CriInteract i); //0x11E48 (ST3)
    private delegate void FUN_11E5C(CriInteract i); //0x11E5C (ST3)
    private delegate void FUN_11E70(CriInteract i); //0x11E70 (ST3)
    private delegate void FUN_12390(CriInteract i); //0x12390 (ST3)
    private delegate void FUN_12678(CriPlayer p); //0x12678 (ST3)
    private delegate void FUN_12684(CriPlayer p); //0x12684 (ST3)
    private delegate void FUN_12694(CriPlayer p); //0x12694 (ST3)
    private delegate void FUN_126A4(CriPlayer p); //0x126A4 (ST3)
    private delegate void FUN_126BC(CriPlayer p1, CriPlayer p2); //0x126BC (ST3)
    private delegate void FUN_126CC(CriPlayer p); //0x126CC (ST3)
    private delegate void FUN_126D8(CriPlayer p); //0x126D8 (ST3)
    private delegate void FUN_126E0(CriPlayer p); //0x126E0 (ST3)
    private delegate void FUN_12704(CriPlayer p); //0x12704 (ST3)
    private delegate void FUN_12730(CriPlayer p); //0x12730 (ST3)
    private delegate void FUN_12748(CriPlayer p); //0x12748 (ST3)
    private delegate void FUN_12754(CriPlayer p); //0x12754 (ST3)
    private delegate void FUN_12768(CriPlayer p); //0x12768 (ST3)
    private delegate void FUN_12770(CriInteract i); //0x12770 (ST3)
    private delegate void FUN_1283C(CriInteract i); //0x1283C (ST3)
    private delegate void FUN_12AEC(CriInteract i); //0x12AEC (ST3)
    private byte[] DAT_11C4C = new byte[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 0 }; //0x11C4C (ST3)
    private byte[] DAT_11C58 = new byte[] { 1, 5, 3, 7, 9, 2, 6, 10, 8, 3, 5, 9, 1, 4, 7, 8, 1, 3, 1, 5, 2, 3, 9, 2 }; //0x11C58 (ST3)
    private FUN_11C70[] PTR_FUN_11C70; //0x11C70 (ST3)
    private FUN_11C80[] PTR_FUN_11C80; //0x11C80 (ST3)
    private Vector3Int[] DAT_11C90 = new Vector3Int[] //0x11C90 (ST3)
    {
        new Vector3Int(-2320, -1230, -3900), new Vector3Int(-2610, -1230, -3900),
        new Vector3Int(-2900, -1230, -3900), new Vector3Int(-3190, -1230, -3900),
        new Vector3Int(-3480, -1230, -3900), new Vector3Int(-4390, -1075, 2600)
    };
    private short[] DAT_11CB4 = new short[] { -2290, -2580, -2870, -3160 };
    private FUN_11CBC[] PTR_FUN_11CBC; //0x11CBC (ST3)
    private FUN_11CCC[] PTR_FUN_11CCC; //0x11CCC (ST3)
    private UNK_11CD8[] DAT_11CD8 = new UNK_11CD8[] //0x11CD8 (ST3)
    {
        new UNK_11CD8
        {
            DAT_00=0x80118A38, 
            DAT_04=1
        }, 
        new UNK_11CD8
        {
            DAT_00=0, 
            DAT_04=1
        }, 
        new UNK_11CD8
        {
            DAT_00=0x80118A40, 
            DAT_04=1
        }
    }; 
    private FUN_11CF0[] PTR_FUN_11CF0; //0x11CF0 (ST3)
    private FUN_11CFC[] PTR_FUN_11CFC; //0x11CFC (ST3)
    private uint[] DAT_11D08 = new uint[] //0x11D08 (ST3)
    {
        0x8011d168, 0x8011d178, 0x8011d180, 0x8011d188,
        0x8011d190, 0x8011d1a0, 0x8011d1a8, 0x8011d1b0,
        0x8011d1b8, 0x8011d1c0, 0x8011d1f0
    };
    private FUN_11D34[] PTR_FUN_11D34; //0x11D34 (ST3)
    private uint[] DAT_11D44 = new uint[] //0x11D44 (ST3)
    {
        0x8010eef0, 0x8010f028, 0x8010f040, 0x8010f058,
        0x8010f068, 0x8010f078, 0x8010ef38, 0x8010efb0
    };
    private FUN_11D64[] PTR_FUN_11D64; //0x11D64 (ST3)
    private byte[] DAT_11D94 = new byte[] { 0, 0x80, 0xfe, 0xfe }; //0x11D94 (ST3)
    private FUN_11D98[] PTR_FUN_11D98; //0x11D98 (ST3)
    private UNK_11DA8[] DAT_11DA8; //0x11DA8 (ST3)
    private FUN_11E14[] PTR_FUN_11E14; //0x11E14 (ST3)
    private uint[] DAT_11E20 = new uint[] //0x11E20 (ST3)
    {
        0xff5e5400, 0xff275052, 0xff3e1561, 0xff1d5052, 0xff340051,
        0xff2a2b2e, 0xff493164, 0xff3b3819, 0xffff302c, 0xfefe8000
    };
    private FUN_11E48[] PTR_FUN_11E48; //0x11E48 (ST3)
    private byte[] DAT_11E58 = new byte[] { 3, 6, 9, 5 }; //0x11E58 (ST3)
    private FUN_11E5C[] PTR_FUN_11E5C; //0x11E5C (ST3)
    private FUN_11E70[] PTR_FUN_11E70; //0x11E70 (ST3)
    private UNK_PARTICLE_10[] DAT_11E7C; //0x11E7C (ST3)
    private UNK_PARTICLE_10[] DAT_122B4; //0x122B4 (ST3)
    private FUN_12390[] PTR_FUN_12390; //0x12390 (ST3)
    private UNK_123CC[] DAT_123CC; //0x123CC (ST3)
    private CapsuleCollider[] DAT_123E4; //0x123E4 (ST3)
    private byte[] DAT_12408 = new byte[] { 48, 49 }; //0x12408 (ST3)
    private byte[] DAT_1240C = new byte[] { 50, 51 }; //0x1240C (ST3)
    private CriInteract.FUN_0C FUN_12418; //0x12418 (ST3)
    private CriInteract.FUN_0C FUN_124CC; //0x124CC (ST3)
    private FUN_12678[] PTR_FUN_12678; //0x12678 (ST3)
    private byte[] DAT_12680 = new byte[] { 56, 57 }; //0x12680 (ST3)
    private FUN_12684[] PTR_FUN_12684; //0x12684 (ST3)
    private FUN_12694[] PTR_FUN_12694; //0x12694 (ST3)
    private int[] DAT_1269C = new int[] { 5, 5 }; //0x1269C (ST3)
    private FUN_126A4[] PTR_FUN_126A4; //0x126A4 (ST3)
    private byte[] DAT_126AC = new byte[] { 54, 55 }; //0x126AC (ST3)
    private int[] DAT_126B0 = new int[] { 13, 3, 8 }; //0x126B0 (ST3)
    private FUN_126BC[] PTR_FUN_126BC; //0x126BC (ST3)
    private FUN_126CC[] PTR_FUN_126CC; //0x126CC (ST3)
    private FUN_126D8[] PTR_FUN_126D8; //0x126D8 (ST3)
    private FUN_126E0[] PTR_FUN_126E0; //0x126E0 (ST3)
    private FUN_12704[] PTR_FUN_12704; //0x12704 (ST3)
    private byte[] DAT_12728 = new byte[] { 52, 53 }; //0x12728 (ST3)
    private byte[] DAT_1272C = new byte[] { 58, 59 }; //0x1272C (ST3)
    private FUN_12730[] PTR_FUN_12730; //0x12730 (ST3)
    private short[] DAT_12740 = new short[] { 0x500, 0xb00, 0xb00, 0x500 };
    private FUN_12748[] PTR_FUN_12748; //0x12748 (ST3)
    private FUN_12754[] PTR_FUN_12754; //0x12754 (ST3)
    private FUN_12768[] PTR_FUN_12768; //0x12768 (ST3)
    private FUN_12770[] PTR_FUN_12770; //0x12770 (ST3)
    private byte[] DAT_127EC = new byte[] { 0, 0xff, 0, 0 }; //0x127EC (ST3)
    private byte[] DAT_127F0 = new byte[] { 0, 0x0f, 0, 0 }; //0x127F0 (ST3)
    private byte[] DAT_127F4 = new byte[] { 0, 0x4d, 0, 0 }; //0x127F4 (ST3)
    private byte[] DAT_127F8 = new byte[] { 0, 0, 0, 0 }; //0x127F8 (ST3)
    private byte[] DAT_1282C = new byte[] { 1, 2, 5, 6, 3, 7 }; //0x1282C (ST3)
    private byte[] DAT_12834 = new byte[] { 1, 2, 8, 4, 3, 7 }; //0x12834 (ST3)
    private FUN_1283C[] PTR_FUN_1283C; //0x1283C (ST3)
    private sbyte[] DAT_12850 = new sbyte[] { -12, 0, -12, 0, -12, 0, 12, 0, 12, 0, 12, 0, 12, 0, 12, 0, -12, 0, -12, 0 }; //0x12850 (ST3)
    private sbyte[] DAT_12864 = new sbyte[] { 12, 0, 12, 0, 12, 0, -12, 0, -12, 0, -12, 0, -12, 0, -12, 0, 12, 0, 12, 0 }; //0x12864 (ST3)
    private FUN_12AEC[] PTR_FUN_12AEC; //0x12AEC (ST3)
    private int DAT_12AF8; //0x12AF8 (ST3)
    private int DAT_12AFC; //0x12AFC (ST3)
    private int DAT_12B00; //0x12B00 (ST3)
    private int DAT_12B04; //0x12B04 (ST3)
    private byte DAT_12B08; //0x12B08 (ST3)
    private byte DAT_12B09; //0x12B09 (ST3)
    private byte DAT_12B0A; //0x12B0A (ST3)
    private byte DAT_12B0B; //0x12B0B (ST3)
    private sbyte[] DAT_12B0C = new sbyte[20]; //0x12B0C (ST3)
    private byte[] DAT_12B2C = new byte[20]; //0x12B2C (ST3) //tmp 20
    private byte[] DAT_12B5C = new byte[20]; //0x12B5C (ST3)
    private short[] DAT_12C88 = new short[4]; //0x12C88 (ST3)
    private byte DAT_12C90; //0x12C90 (ST3)
    private short[] DAT_12CA0 = new short[9]; //0x12CA0 (ST3)
    private short[] DAT_12CC0 = new short[9]; //0x12CC0 (ST3)
    private sbyte[] DAT_12CE0 = new sbyte[9]; //0x12CE0 (ST3)
    private sbyte[] DAT_12CF0 = new sbyte[9]; //0x12CF0 (ST3)


    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_11C70 = new FUN_11C70[4]
            {
                FUN_3F0,
                FUN_464,
                FUN_678,
                FUN_60068
            };
            PTR_FUN_11C80 = new FUN_11C80[4]
            {
                FUN_14E4_2, 
                FUN_1104, 
                FUN_1314, 
                FUN_60068
            };
            PTR_FUN_11CBC = new FUN_11CBC[4]
            {
                FUN_1520,
                FUN_17F8,
                FUN_1998,
                FUN_60068
            };
            PTR_FUN_11CCC = new FUN_11CCC[3]
            {
                FUN_1DBC,
                FUN_1E48,
                FUN_60068
            };
            PTR_FUN_11CF0 = new FUN_11CF0[3]
            {
                FUN_1EC4,
                FUN_1F4C,
                FUN_60068
            };
            PTR_FUN_11CFC = new FUN_11CFC[3]
            {
                FUN_209C,
                FUN_20F8,
                FUN_60068
            };
            PTR_FUN_11D34 = new FUN_11D34[3]
            {
                FUN_21D0,
                FUN_2278,
                FUN_60068
            };
            PTR_FUN_11D64 = new FUN_11D64[3]
            {
                FUN_2344,
                FUN_243C,
                FUN_60068
            };
            PTR_FUN_11D98 = new FUN_11D98[4]
            {
                FUN_2470,
                FUN_2574,
                FUN_276C,
                FUN_5FF98
            };
            PTR_FUN_11E14 = new FUN_11E14[3]
            {
                FUN_2C2C,
                FUN_2C44,
                FUN_5FF98
            };
            PTR_FUN_11E48 = new FUN_11E48[4]
            {
                FUN_2E40,
                FUN_2EA8,
                FUN_2FBC,
                FUN_5FF98
            };
            PTR_FUN_11E5C = new FUN_11E5C[5]
            {
                FUN_3464,
                FUN_34F4, 
                FUN_36EC, 
                FUN_37A4, 
                FUN_5FF98
            };
            PTR_FUN_11E70 = new FUN_11E70[3]
            {
                FUN_3B88,
                FUN_3BD4,
                FUN_3D00
            };
            PTR_FUN_12390 = new FUN_12390[3]
            {
                FUN_3EB8, 
                FUN_3F54, 
                FUN_5FF98
            };
            PTR_FUN_12678 = new FUN_12678[2]
            {
                FUN_43C8,
                FUN_4410
            };
            PTR_FUN_12684 = new FUN_12684[4]
            {
                FUN_45C4,
                FUN_4664,
                FUN_46D4,
                FUN_4738
            };
            PTR_FUN_12694 = new FUN_12694[2]
            {
                FUN_484C,
                FUN_48B8
            };
            PTR_FUN_126A4 = new FUN_126A4[2]
            {
                FUN_49F4,
                FUN_4B0C
            };
            PTR_FUN_126BC = new FUN_126BC[4]
            {
                FUN_5300,
                FUN_53F8,
                FUN_54D4,
                FUN_5678
            };
            PTR_FUN_126CC = new FUN_126CC[3]
            {
                FUN_58A0,
                FUN_592C,
                FUN_5A2C
            };
            PTR_FUN_126D8 = new FUN_126D8[2]
            {
                FUN_5A78,
                FUN_5AB0
            };
            PTR_FUN_126E0 = new FUN_126E0[9]
            {
                FUN_4CE0,
                FUN_525C,
                FUN_4334,
                FUN_4590,
                FUN_40D0,
                FUN_40D0,
                FUN_4EA8,
                FUN_40D0, 
                FUN_40D0
            };
            PTR_FUN_12704 = new FUN_12704[9]
            {
                FUN_4DAC,
                FUN_57B0,
                FUN_4554,
                FUN_4810,
                FUN_4C60,
                FUN_49B8,
                FUN_50C0,
                FUN_5A3C,
                FUN_5B54
            };
            PTR_FUN_12730 = new FUN_12730[4]
            {
                FUN_5CCC,
                FUN_5DCC,
                FUN_5E18,
                FUN_5E80
            };
            PTR_FUN_12748 = new FUN_12748[3]
            {
                FUN_6050,
                FUN_6110,
                FUN_6110
            };
            PTR_FUN_12754 = new FUN_12754[5]
            {
                FUN_4104,
                FUN_5B90, 
                FUN_5BF8, 
                FUN_5FC0, 
                FUN_6260
            };
            PTR_FUN_12768 = new FUN_12768[2]
            {
                FUN_677C,
                FUN_67F8
            };
            PTR_FUN_12770 = new FUN_12770[17]
            {
                FUN_69B8,
                FUN_6A38,
                FUN_6A94, 
                FUN_7448, 
                FUN_76D8, 
                FUN_7760, 
                FUN_77A8, 
                FUN_7850, 
                FUN_78D8, 
                FUN_7920, 
                FUN_79C8, 
                FUN_7D70, 
                FUN_7DD8, 
                FUN_7E44, 
                FUN_7EC4, 
                FUN_7F44, 
                FUN_5FF98
            };
            PTR_FUN_1283C = new FUN_1283C[5]
            {
                FUN_9704,
                FUN_9944,
                FUN_9E10,
                FUN_9E54, 
                FUN_5FF98
            };
            PTR_FUN_12AEC = new FUN_12AEC[3]
            {
                FUN_109A8,
                FUN_10AFC,
                FUN_10EA4
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

    //FUN_1A4 (ST3)
    public override void Initialize()
    {
        bool bVar1;
        TriggerData puVar2;
        uint uVar3;
        CriTrigger puVar4;

        base.Initialize();
        PTR_FUN_B58BC = DAT_11B40;
        PTR_FUN_B58C0 = DAT_11B98;
        PTR_FUN_C2570 = DAT_11BC0;
        PTR_FUN_C1CF8 = DAT_11BE0;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        GameManager.instance.DAT_AC = DAT_11AB0[uVar3];
        GameManager.instance.DAT_B0 = DAT_11674;
        GameManager.instance.DAT_46 = 3;
        bVar1 = InventoryManager.FUN_4A87C(0, 0x5d);

        if (!bVar1)
        {
            for (int i = 0; i < DAT_118D0.TRIGGERS.Length; i++)
            {
                puVar4 = LevelManager.instance.DAT_9EEC[i];
                puVar2 = DAT_118D0.TRIGGERS[i];
                puVar4.DAT_00 = puVar2.DAT_00;
                puVar4.DAT_01 = puVar2.DAT_01;
                puVar4.DAT_02 = puVar2.DAT_02;
                puVar4.DAT_03 = puVar2.DAT_03;
                puVar4.DAT_04 = puVar2.DAT_04;
                puVar4.DAT_0A = puVar2.DAT_0A;
                puVar4.DAT_0C = puVar2.DAT_0C;
                puVar4.DAT_0E = puVar2.DAT_0E;
                puVar4.DAT_10 = puVar2.DAT_10;
                puVar4.DAT_12 = puVar2.DAT_12;
                puVar4.DAT_14 = puVar2.DAT_14;
                puVar4.DAT_16 = puVar2.DAT_16;
            }
        }
        else
        {
            for (int i = 0; i < DAT_119C0.TRIGGERS.Length; i++)
            {
                puVar4 = LevelManager.instance.DAT_9EEC[i];
                puVar2 = DAT_119C0.TRIGGERS[i];
                puVar4.DAT_00 = puVar2.DAT_00;
                puVar4.DAT_01 = puVar2.DAT_01;
                puVar4.DAT_02 = puVar2.DAT_02;
                puVar4.DAT_03 = puVar2.DAT_03;
                puVar4.DAT_04 = puVar2.DAT_04;
                puVar4.DAT_0A = puVar2.DAT_0A;
                puVar4.DAT_0C = puVar2.DAT_0C;
                puVar4.DAT_0E = puVar2.DAT_0E;
                puVar4.DAT_10 = puVar2.DAT_10;
                puVar4.DAT_12 = puVar2.DAT_12;
                puVar4.DAT_14 = puVar2.DAT_14;
                puVar4.DAT_16 = puVar2.DAT_16;
            }
        }

        GameManager.instance.FUN_7669C(LevelManager.instance.DAT_9EEC, 3);
        //...
    }

    //FUN_3F0 (ST3)
    private void FUN_3F0(CriParticle param1)
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

    //FUN_464 (ST3)
    private void FUN_464(CriParticle param1)
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

                if (param1.DAT_6A != 3) goto LAB_588;

                goto LAB_57C;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (sbyte)param1.DAT_69 < 2)
                {
                    if (param1.DAT_6A == 3) goto LAB_57C;

                    GameManager.instance.FUN_5C94C(null, 145);
                    sVar1 = (sbyte)(param1.DAT_69 + 1);
                    param1.DAT_69 = (byte)sVar1;
                }

                if (param1.DAT_6A != 3) goto LAB_588;

                goto LAB_57C;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_588;

                goto LAB_57C;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                sVar1 = (sbyte)(param1.DAT_69 - 1);
                param1.DAT_69 = (byte)sVar1;

                if (param1.DAT_6A != 3) goto LAB_588;

                goto LAB_57C;
            }
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 145);
                param1.DAT_6A--;
            }

            if (param1.DAT_6A != 3) goto LAB_588;
        }

        LAB_57C:
        param1.DAT_69 = 1;

        LAB_588:
        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);
            param1.DAT_6C[param1.DAT_68] = DAT_11C4C[(sbyte)param1.DAT_6A * 3 + (sbyte)param1.DAT_69];
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
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_3C = 3;
            }
            else
                param1.DAT_68--;

            param1.DAT_6C[param1.DAT_68] = 0;
        }
    }

    //FUN_678 (ST3)
    private void FUN_678(CriParticle param1)
    {
        uint uVar1;
        byte bVar2;

        bVar2 = 0;
        param1.DAT_3C++;
        uVar1 = 0;

        do
        {
            if (param1.DAT_6C[uVar1] != DAT_11C58[param1.DAT_2F * 4 + uVar1])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                GameManager.instance.FUN_5C94C(null, 149);
                return;
            }

            bVar2++;
            uVar1 = bVar2;
        } while (bVar2 < 4);

        GameManager.instance.FUN_5C94C(null, 148);
        InventoryManager.FUN_4A7E8(2, 9, true);
    }

    //FUN_1104 (ST3)
    private void FUN_1104(CriParticle param1)
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

    //FUN_1314 (ST3)
    private void FUN_1314(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        CriStatic oVar3;
        CriStatic oVar4;
        bool bVar5;
        int iVar5;
        int piVar6;
        CriStatic[] local_30 = new CriStatic[5];

        InventoryManager.FUN_4A7E8(3, 0x2e, false);
        piVar6 = 0;

        do
        {
            local_30[piVar6] = SceneManager.instance.staticObjects[piVar6];
            piVar6++;
        } while (piVar6 < 5);

        oVar4 = local_30[4];
        oVar3 = local_30[3];
        iVar5 = 0;

        do
        {
            InventoryManager.FUN_4A7E8(3, (uint)iVar5 + 0x24, false);
            iVar5++;
        } while (iVar5 < 4);

        if ((sbyte)oVar4.DAT_78 != 3)
            InventoryManager.FUN_4A7E8(3, (uint)(sbyte)oVar4.DAT_78 + 0x24, true);

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
                goto LAB_14AC;
            else
            {
                piVar6++;

                if (4 < iVar5)
                    goto LAB_14AC;
            }
        }

        InventoryManager.FUN_4A7E8(3, 0x2e, true);
        LAB_14AC:
        InventoryManager.FUN_4A7E8(3, 0x3e, true);
        param1.DAT_3C++;
    }

    //FUN_14E4 (ST3)
    private void FUN_14E4_2(CriParticle param1)
    {
        PTR_FUN_11CBC[param1.DAT_3C](param1);
    }

    //FUN_1520 (ST3)
    private void FUN_1520(CriParticle param1)
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
        byte[] local_34 = new byte[24];

        iVar8 = 0;
        piVar9 = 0;
        System.Array.Copy(DAT_28, local_34, 24);
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
                bVar2 = local_34[piVar5 + iVar8 * 5];
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

    //FUN_17F8 (ST3)
    private void FUN_17F8(CriParticle param1)
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
                //; //FUN_1D988
        }

        oVar3.vr.y = oVar3.vr.y + 0x40 & 0xfff;
        sVar1 = (short)(oVar4.screen.y + 4);
        oVar4.screen.y = sVar1;

        if (-1075 < sVar1)
        {
            oVar3 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
            oVar3.flags |= 2;
            oVar3.screen.y = -1075;
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

    //FUN_1998 (ST3)
    private void FUN_1998(CriParticle param1)
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
                    oVar5.screen = DAT_11C90[param1.DAT_78];
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
            //; //FUN_1D988
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
                FUN_1C70(param1);
        }

        sVar3 = (short)(oVar6.screen.y + 4);
        oVar6.screen.y = sVar3;

        if (-1075 < sVar3)
        {
            oVar4 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
            oVar4.flags |= 2;
            oVar6.screen.y = -1075;
            GameManager.instance.FUN_5C860(145);

            if (oVar4.DAT_79 != 4)
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

    //FUN_1C70 (ST3)
    private void FUN_1C70(CriParticle param1)
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
                param1.screen.x = DAT_11CB4[param1.DAT_78] - 85;
                InventoryManager.FUN_4A7E8(3, 0x2d, false);
                param1.DAT_7B = 0;
                return;
            }

            if (sVar1 != 0)
                return;

            param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80118a48));
            param1.flags |= 2;
            param1.screen.x = DAT_11CB4[param1.DAT_78];
        }

        param1.DAT_7B++;
    }

    //FUN_1DBC (ST3)
    private void FUN_1DBC(CriParticle param1)
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

    //FUN_1E48 (ST3)
    private void FUN_1E48(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_1EC4 (ST3)
    private void FUN_1EC4(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11CD8[0].DAT_00));
        param1.DAT_69 = 1;
        param1.DAT_68 = DAT_11CD8[0].DAT_04;
        param1.DAT_3C++;
    }

    //FUN_1F4C (ST3)
    private void FUN_1F4C(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;

        sVar2 = (sbyte)(param1.DAT_68 - 1);
        param1.DAT_68 = (byte)sVar2;

        if (sVar2 == -1)
        {
            if (DAT_11CD8[param1.DAT_69].DAT_00 == 0)
                param1.flags &= 0xfffffffd;
            else
            {
                param1.flags |= 2;
                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11CD8[param1.DAT_69].DAT_00));
            }

            bVar1 = DAT_11CD8[param1.DAT_69].DAT_04;
            bVar3 = (byte)(param1.DAT_69 + 1);
            param1.DAT_69 = bVar3;
            param1.DAT_68 = bVar1;

            if (2 < bVar3)
                param1.DAT_3C++;
        }
    }

    //FUN_209C (ST3)
    private void FUN_209C(CriParticle param1)
    {
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x801223cc));
        param1.DAT_56 = 0x37;
        param1.DAT_54 = 0x7f33;
        param1.DAT_3C = 1;
        param1.DAT_50.a |= 2;
        param1.flags |= 2;
    }

    //FUN_20F8 (ST3)
    private void FUN_20F8(CriParticle param1)
    {
        int iVar1;

        param1.screen += param1.DAT_40;
        param1.DAT_40.y += param1.DAT_68;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_21D0 (ST3)
    private void FUN_21D0(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11D08[param1.DAT_2F]));
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

    //FUN_2278 (ST3)
    private void FUN_2278(CriParticle param1)
    {
        int iVar1;

        param1.screen += param1.DAT_40;
        param1.DAT_40.y += param1.DAT_6B;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_2344 (ST3)
    private void FUN_2344(CriParticle param1)
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
        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11D44[param1.DAT_2F]));

        if (iVar2 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_243C (ST3)
    private void FUN_243C(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_2470 (ST3)
    private void FUN_2470(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;

        bVar1 = (byte)(InventoryManager.FUN_4A87C(0, 0x50) ? 1 : 0);
        param1.BDAT_08 = bVar1;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x51) ? 1 : 0);
        param1.BDAT_08 = DAT_11D94[param1.BDAT_08 | (bVar2 & 0x7f) << 1];
        bVar1 = (byte)(InventoryManager.FUN_4A87C(0, 0x52) ? 1 : 0);
        param1.BDAT_09 = bVar1;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x53) ? 1 : 0);
        param1.BDAT_09 = DAT_11D94[param1.BDAT_09 | (bVar2 & 0x7f) << 1];
        bVar1 = (byte)(InventoryManager.FUN_4A87C(0, 0x54) ? 1 : 0);
        param1.DAT_10 = bVar1;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x55) ? 1 : 0);
        param1.DAT_10 = DAT_11D94[param1.DAT_10 | (bVar2 & 0x7f) << 1];
        //...
        param1.DAT_03 = 1;
    }

    //FUN_2574 (ST3)
    private void FUN_2574(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;
        sbyte sVar3;
        int iVar4;
        uint uVar5;

        param1.DAT_0B = (sbyte)param1.BDAT_08;
        bVar2 = (byte)(InventoryManager.FUN_4A87C(0, 0x50) ? 1 : 0);
        param1.BDAT_08 = bVar2;
        iVar4 = InventoryManager.FUN_4A87C(0, 0x51) ? 1 : 0;
        param1.DAT_11 = (byte)(param1.BDAT_08 | (byte)(iVar4 << 1));
        param1.BDAT_08 = DAT_11D94[param1.BDAT_08 | iVar4 << 1 & 0xff];

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
        param1.DAT_12 = (sbyte)(param1.BDAT_09 | (byte)(iVar4 << 1));
        param1.BDAT_09 = DAT_11D94[param1.BDAT_09 | iVar4 << 1 & 0xff];

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
        param1.BDAT_0A = (sbyte)DAT_11D94[(byte)param1.BDAT_0A | iVar4 << 1 & 0xff];

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

        uVar5 = (uint)((byte)param1.BDAT_0A << 0x10 | param1.BDAT_09 << 8 | param1.BDAT_08);

        if (uVar5 == 0xfe || uVar5 == 0xfe00 || uVar5 == 0xfe0000)
            InventoryManager.FUN_4A7E8(0, 0x56, true);
    }

    //FUN_276C (ST3)
    private void FUN_276C(CriInteract param1)
    {
        param1.DAT_03 = 3;
    }

    //FUN_2C2C (ST3)
    private void FUN_2C2C(CriInteract param1)
    {
        param1.DAT_0A = 0;
        param1.DAT_08 = 0;
        param1.DAT_03++;
    }

    //FUN_2C44 (ST3)
    private void FUN_2C44(CriInteract param1)
    {
        byte bVar1;
        ushort uVar2;
        short sVar3;
        sbyte sVar4;
        short sVar5;
        CriParticle oVar7;

        sVar5 = param1.DAT_0A;
        sVar3 = param1.DAT_0A;

        while (sVar3 < 9 && DAT_11DA8[sVar5].DAT_06 == param1.DAT_08)
        {
            oVar7 = SceneManager.instance.FUN_5FFA0();

            if (oVar7 != null)
            {
                oVar7.tags = 20;
                bVar1 = DAT_11DA8[sVar5].DAT_07;
                oVar7.DAT_62 = bVar1;
                oVar7.DAT_60 = bVar1;
                oVar7.DAT_4C = SceneManager.instance.staticObjects[param1.DAT_04];
                oVar7.DAT_40.x = (DAT_11DA8[sVar5].DAT_08 << 0x18) >> 0x17;
                oVar7.DAT_40.y = (DAT_11DA8[sVar5].DAT_09 << 0x18) >> 0x17;
                oVar7.DAT_40.z = (DAT_11DA8[sVar5].DAT_0A << 0x18) >> 0x17;
                oVar7.IDAT_6C = 0x80;
                bVar1 = param1.DAT_06;

                if (bVar1 == 1)
                {
                    oVar7.DAT_50.r = 0;
                    oVar7.DAT_50.g = 0x80;
                    oVar7.DAT_50.b = 0;
                }
                else if (bVar1 < 2)
                {
                    if (bVar1 == 0)
                    {
                        oVar7.DAT_50.r = 0x80;
                        oVar7.DAT_50.g = 0;
                        oVar7.DAT_50.b = 0;
                    }
                }
                else if (bVar1 == 2)
                {
                    oVar7.DAT_50.r = 0;
                    oVar7.DAT_50.g = 0;
                    oVar7.DAT_50.b = 0x80;
                }
            }

            sVar5 = (short)(param1.DAT_0A + 1);
            param1.DAT_0A = sVar5;
            sVar3 = sVar5;
        }

        uVar2 = (ushort)param1.DAT_08;
        param1.DAT_08 = (short)(uVar2 + 1);

        if (5 < (short)(uVar2 + 1))
        {
            param1.DAT_0A = 0;
            param1.DAT_08 = 0;
        }

        sVar4 = (sbyte)(param1.DAT_05 - 1);
        param1.DAT_05 = (byte)sVar4;

        if (sVar4 == 0)
            param1.DAT_03++;
    }

    //FUN_2E40 (ST3)
    private void FUN_2E40(CriInteract param1)
    {
        byte bVar1;
        uint uVar2;
        CriInteract oVar3;

        oVar3 = SceneManager.instance.DAT_8FFC[0];
        bVar1 = (byte)oVar3.DAT_13;
        uVar2 = DAT_11E20[((byte)oVar3.DAT_12 * 4 + oVar3.DAT_11 * 0xc) / 4];
        param1.DAT_03 = 1;
        param1.DAT_08 = (short)((int)((uVar2 >> ((bVar1 & 3) << 3) & 0xff) * 3) >> 1);
    }

    //FUN_2EA8 (ST3)
    private void FUN_2EA8(CriInteract param1)
    {
        CriInteract oVar1;
        short sVar1;
        int iVar2;

        oVar1 = SceneManager.instance.DAT_8FFC[0];
        param1.DAT_0A = param1.DAT_08;
        iVar2 = (int)((DAT_11E20[(byte)oVar1.DAT_12 * 4 + oVar1.DAT_11 * 0xc] >> 
                     (((byte)oVar1.DAT_14 & 3) << 3) & 0xff) * 3) >> 1;
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
        iVar2 = InventoryManager.FUN_4A87C(3, 0x20) ? 1 : 0;

        if (iVar2 == 0)
            param1.DAT_03 = 2;

        //FUN_2FC8
    }

    //FUN_2FBC (ST3)
    private void FUN_2FBC(CriInteract param1)
    {
        param1.DAT_03 = 3;
    }

    //FUN_3464 (ST3)
    private void FUN_3464(CriInteract param1)
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

    //FUN_34F4 (ST3)
    private void FUN_34F4(CriInteract param1)
    {
        sbyte sVar1;

        //FUN_37E4

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
            param1.SET_OFFSET_08(param1.BDAT_0A + 4, (byte)(param1.GET_OFFSET_08(0) + param1.BDAT_09 * 5));

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

    //FUN_36EC (ST3)
    private void FUN_36EC(CriInteract param1)
    {
        bool bVar1;
        uint uVar4;
        int iVar5;

        //FUN_37E4
        bVar1 = false;
        uVar4 = 0;

        do
        {
            if (param1.GET_OFFSET_08((int)uVar4 + 4) != DAT_11E58[uVar4])
            {
                bVar1 = true;
                break;
            }

            uVar4++;
        } while (uVar4 < 4);

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

    //FUN_37A4 (ST3)
    private void FUN_37A4(CriInteract param1)
    {
        bool bVar1;

        //FUN_37E4
        bVar1 = InventoryManager.FUN_4A87C(3, 0x30);

        if (bVar1)
            param1.DAT_03 = 4;
    }

    //FUN_3B88 (ST3)
    private void FUN_3B88(CriInteract param1)
    {
        //...
        param1.DAT_03++;
    }

    //FUN_3BD4 (ST3)
    private void FUN_3BD4(CriInteract param1)
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
            else if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    bVar1 = (byte)(param1.GET_OFFSET_08(8) + 1);
                    param1.SET_OFFSET_08(8, bVar1);

                    if (7 < bVar1)
                        param1.SET_OFFSET_08(9, (byte)(param1.GET_OFFSET_08(9) + 1));
                }
            }
            else if (bVar1 == 2)
            {
                if (param1.GET_OFFSET_08(8) == 0)
                    param1.DAT_03++;
                else
                    param1.SET_OFFSET_08(8, (byte)(param1.GET_OFFSET_08(8) - 1));
            }
        }

        bVar3 = InventoryManager.FUN_4A87C(2, 0x1a);

        if (bVar3)
        {
            InventoryManager.FUN_4A7E8(2, 0x1a, false);
            param1.SET_OFFSET_08(9, 2);
        }
    }

    //FUN_3D00 (ST3)
    private void FUN_3D00(CriInteract param1)
    {
        LevelManager.instance.FUN_60100(param1.PTR_08);
        param1.FUN_5FF98();
    }

    //FUN_3EB8 (ST3)
    private void FUN_3EB8(CriInteract param1)
    {
        if (param1.DAT_02 == 0)
        {
            param1.DAT_10_2 = DAT_11E7C;
            param1.IDAT_10 = 0;
            param1.BDAT_0E = 49;
            param1.PDAT_14 = SceneManager.instance.skinnedObjects[param1.DAT_04];
        }
        else
        {
            param1.DAT_10_2 = DAT_122B4;
            param1.IDAT_10 = 0;
            param1.BDAT_0E = 10;
        }

        param1.DAT_0C = 0;
        param1.DAT_03++;
        FUN_3F54(param1);
    }

    //FUN_3F54 (ST3)
    private void FUN_3F54(CriInteract param1)
    {
        byte bVar1;
        CriParticle pVar2;
        CriObject oVar3;
        sbyte sVar4;

        do
        {
            if (param1.DAT_10_2[param1.IDAT_10].DAT_06 != param1.DAT_0C)
            {
                param1.DAT_0C++;
                return;
            }

            pVar2 = SceneManager.instance.FUN_5FFA0();

            if (pVar2 != null)
            {
                pVar2.tags = 21;
                pVar2.DAT_2F = param1.DAT_10_2[param1.IDAT_10].DAT_12;
                pVar2.screen = param1.DAT_10_2[param1.IDAT_10].DAT_00;
                bVar1 = param1.DAT_10_2[param1.IDAT_10].DAT_07;
                pVar2.DAT_62 = bVar1;
                pVar2.DAT_60 = bVar1;
                pVar2.DAT_40 = param1.DAT_10_2[param1.IDAT_10].DAT_08;

                if (param1.DAT_10_2[param1.IDAT_10].DAT_0E != -1)
                {
                    oVar3 = Utilities.FUN_601C8(((CriSkinned)param1.PDAT_14).skeleton,
                                                param1.DAT_10_2[param1.IDAT_10].DAT_0E);
                    pVar2.DAT_4C = oVar3;
                }

                pVar2.IDAT_6C = param1.DAT_10_2[param1.IDAT_10].DAT_0F;
                pVar2.vr.z = param1.DAT_10_2[param1.IDAT_10].DAT_10;
                pVar2.DAT_50.r = param1.DAT_10_2[param1.IDAT_10].DAT_13;
                pVar2.DAT_50.g = param1.DAT_10_2[param1.IDAT_10].DAT_14;
                pVar2.DAT_50.b = param1.DAT_10_2[param1.IDAT_10].DAT_15;
            }

            sVar4 = (sbyte)(param1.BDAT_0E - 1);
            param1.BDAT_0E = (byte)sVar4;
            param1.IDAT_10++;
        } while (sVar4 != 0);

        param1.DAT_03++;
    }

    //FUN_40D0 (ST3)
    private void FUN_40D0(CriPlayer param1)
    {
        return;
    }

    //FUN_40D8 (ST3)
    private void FUN_40D8(CriPlayer param1)
    {
        if (param1.DAT_154.health < 0xfb)
        {
            param1.DAT_2F = 1;
            return;
        }

        param1.DAT_2F = 0;
    }

    //FUN_4104 (ST3)
    private void FUN_4104(CriPlayer param1)
    {
        CriSkinned oVar1;
        CriInteract pbVar2;
        CriInteract oVar3;
        int iVar4;

        param1.DAT_120 = 0;
        param1.PTR_120 = DAT_123E4;
        param1.DAT_130 = 0;
        param1.PTR_130 = DAT_123E4;
        param1.DAT_124 = 2;
        param1.PTR_124 = DAT_123E4;
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
        param1.PDAT_1D4 = DAT_123CC[param1.DAT_3A].DAT_00;
        param1.DAT_1DA = DAT_123CC[param1.DAT_3A].DAT_04;
        param1.DAT_1A5 = 7;
        param1.DAT_140 |= 1;
        param1.PDAT_1C8 = null;
        iVar4 = 0;

        do
        {
            if (iVar4 < 10)
            {
                pbVar2 = SceneManager.instance.DAT_8FFC[iVar4];

                if ((pbVar2.DAT_00 & 1) != 0 && pbVar2.DAT_01 == 23)
                {
                    param1.PDAT_1C8 = pbVar2;
                    goto LAB_4264;
                }
                else
                {
                    iVar4++;
                    continue;
                }
            }

            LAB_4264:
            oVar3 = param1.PDAT_1C8;

            if (oVar3 != null)
            {
                oVar3.BDAT_09++;
                oVar3.BDAT_0A++;

                if ((oVar3.BDAT_08 & 4) == 0)
                {
                    oVar3.TDAT_0C = param1.cSkin;
                    oVar3.TDAT_10 = param1.DAT_98;
                    oVar3.BDAT_08 |= 4;
                }
            }

            if (param1.DAT_18E == 100)
            {
                param1.DAT_3D = 8;
                param1.DAT_120 = 0;
                param1.PTR_120 = null;
                param1.DAT_130 = 0;
                param1.PTR_130 = null;
                param1.DAT_11E |= 0x40;
                param1.DAT_144 &= 0x7fff;

                if (oVar3 != null)
                    oVar3.BDAT_0A--;
            }

            FUN_40D8(param1);
            param1.IDAT_1C4 = 0;
            return;
        } while (true);
    }

    //FUN_4334 (ST3)
    private void FUN_4334(CriPlayer param1)
    {
        if (param1.screen.y == 0)
        {
            if ((param1.DAT_1C0 & 1) == 0)
            {
                if (param1.DAT_2F == 1 && (param1.PDAT_1C8.DAT_08 & 2) != 0)
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

    //FUN_43C8 (ST3)
    private void FUN_43C8(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(13, 1, 0);
        param1.FUN_65890();
    }

    //FUN_4410 (ST3)
    private void FUN_4410(CriPlayer param1)
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
            GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);
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
                GameManager.instance.FUN_5C94C(param1, DAT_1240C[uVar4 & 1]);
            }
        }

        param1.FUN_65890();
    }

    //FUN_4554 (ST3)
    private void FUN_4554(CriPlayer param1)
    {
        PTR_FUN_12678[param1.DAT_3E](param1);
    }

    //FUN_4590 (ST3)
    private void FUN_4590(CriPlayer param1)
    {
        if (param1.screen.y == 0 && (param1.DAT_1C0 & 1) != 0)
        {
            param1.DAT_3D = 6;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_45C4 (ST3)
    private void FUN_45C4(CriPlayer param1)
    {
        uint uVar1;

        param1.DAT_40.y = -100;
        param1.SDAT_1CC = 8;
        param1.DAT_40.z = 160;
        param1.DAT_3E++;
        param1.FUN_609C8(4, 0, 0);
        uVar1 = GameManager.FUN_64650();
        GameManager.instance.FUN_5C94C(param1, DAT_12680[uVar1 & 1]);

        if (param1.DAT_2F == 0)
            param1.DAT_1C0 |= 0x20;
    }

    //FUN_4664 (ST3)
    private void FUN_4664(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.DAT_40.y += param1.SDAT_1CC;

        if (param1.frame.DAT_01 == 12)
        {
            param1.DAT_1C0 |= 0x40;
            param1.DAT_3E++;
        }
    }

    //FUN_46D4 (ST3)
    private void FUN_46D4(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.DAT_40.y += param1.SDAT_1CC;

        if (param1.frame.DAT_01 == 12)
        {
            param1.DAT_1C0 &= 0xffffffbf;
            param1.DAT_3E++;
        }
    }

    //FUN_4738 (ST3)
    private void FUN_4738(CriPlayer param1)
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

    //FUN_4810 (ST3)
    private void FUN_4810(CriPlayer param1)
    {
        PTR_FUN_12684[param1.DAT_3E](param1);
    }

    //FUN_484C (ST3)
    private void FUN_484C(CriPlayer param1)
    {
        CriInteract oVar1;

        oVar1 = param1.PDAT_1C8;
        param1.DAT_3E++;
        param1.FUN_609C8(6, 0, 0);

        if (param1.DAT_2F == 1)
            oVar1.BDAT_08 |= 2;
    }

    //FUN_48B8 (ST3)
    private void FUN_48B8(CriPlayer param1)
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
                param1.DAT_120 = 0;
                param1.PTR_120 = DAT_123E4;
                uVar1 = (ushort)GameManager.FUN_64650();
                param1.DAT_112 = (short)(uVar1 & 0xf);
                oVar3.BDAT_08 &= 0xfd;
            }
        }

        param1.FUN_65890();
    }

    //FUN_49B8 (ST3)
    private void FUN_49B8(CriPlayer param1)
    {
        PTR_FUN_12694[param1.DAT_3E](param1);
    }

    //FUN_49F4 (ST3)
    private void FUN_49F4(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriPlayer oVar4;

        param1.DAT_3E++;
        param1.DAT_12C |= 0x10;
        oVar4 = (CriPlayer)param1.DAT_154;
        param1.FUN_609C8(DAT_126AC[param1.DAT_2E], 1, 0);
        GameManager.instance.PTR_FUN_148 = FUN_6818;
        oVar4.DAT_154 = param1;
        oVar4.DAT_1E0 = param1.DAT_98;
        oVar4.DAT_3C = 5;
        oVar4.DAT_3D = 0;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        oVar4.DAT_98 = param1.DAT_98;
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar4.screen);
        param1.vr.y = sVar1;
        param1.DAT_112 = 90;

        if (param1.DAT_2E == 0)
            param1.vr.y = param1.vr.y + 0x800 & 0xfff;
        else
            param1.vr.y = oVar4.vr.y;

        sVar2 = (short)(oVar4.health - 5);
        oVar4.health = sVar2;

        if (sVar2 < 10)
            oVar4.health = 10;

        param1.IDAT_1C4 = 20;
    }

    //FUN_4B0C (ST3)
    private void FUN_4B0C(CriPlayer param1)
    {
        short sVar1;
        sbyte sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)param1.DAT_154;
        param1.FUN_60AB4();
        sVar3 = param1.DAT_112;

        if (sVar3 < 1)
        {
            if (oVar5.frame.DAT_01 == 0x18)
            {
                param1.DAT_3D = 5;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_12C &= 0xffef;
                param1.SetSkeletonPrevious(param1);
                GameManager.instance.DAT_922C &= (byte)~(1 << (param1.DAT_2E & 31));
                sVar2 = (sbyte)(GameManager.instance.DAT_922D - 1);
                GameManager.instance.DAT_922D = (byte)sVar2;

                if (sVar2 == 0)
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

    //FUN_4C60 (ST3)
    private void FUN_4C60(CriPlayer param1)
    {
        CriSkinned oVar1;
        CriObject oVar2;

        oVar1 = param1.DAT_154;
        PTR_FUN_126A4[param1.DAT_3E](param1);
        oVar2 = Utilities.FUN_601C8(oVar1.skeleton, 8);
        param1.DAT_14C = oVar2.screen;
    }

    //FUN_4CE0 (ST3)
    private void FUN_4CE0(CriPlayer param1)
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
        else if ((oVar2.BDAT_08 & 8) != 0)
        {
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
        }

        if (param1.DAT_3A != 1 && param1.frame.DAT_01 == 0x18)
        {
            uVar1 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_126AC[uVar1 & 1]);
        }
    }

    //FUN_4DAC (ST3)
    private void FUN_4DAC(CriPlayer param1)
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

    //FUN_4EA8 (ST3)
    private void FUN_4EA8(CriPlayer param1)
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

    //FUN_50C0 (ST3)
    private void FUN_50C0(CriPlayer param1)
    {
        byte bVar1;
        sbyte sVar2;
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
                GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);

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
                    param1.FUN_609C8(DAT_126B0[uVar4 & 1], 0, 0);
                }
            }

            param1.FUN_65890();
        }
        else if (bVar1 < 2)
        {
            if (bVar1 == 0)
            {
                param1.DAT_3E = 1;
                param1.FUN_609C8(13, 0, 0);
            }
        }
        else if (bVar1 == 2)
        {
            param1.FUN_60AB4();
            sVar2 = (sbyte)param1.frame.DAT_01;

            if (sVar2 == 3 || sVar2 == 11)
            {
                uVar4 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);
            }
        }
    }

    //FUN_525C (ST3)
    private void FUN_525C(CriPlayer param1)
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

                if ((uint)(byte)param1.PDAT_1C8.DAT_0B <= param1.DAT_1DD)
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

    //FUN_5300 (ST3)
    private void FUN_5300(CriPlayer param1, CriPlayer param2)
    {
        int iVar2;
        bool bVar2;

        if (param1.DAT_3F == 0)
        {
            param1.FUN_609C8(2, 0, 10);
            param1.DAT_3F++;
        }
        else if (param1.DAT_3F == 1)
        {
            bVar2 = param1.FUN_60AB4();

            if (bVar2)
            {
                param1.DAT_3F = 0;
                param1.DAT_3E++;
                param1.FUN_609C8(13, 1, 0);
                param1.screen.y = 0;
                param1.UDAT_1D2 = (ushort)param2.vr.x;
            }

            iVar2 = (int)GameManager.FUN_64650();
            param2.DAT_112 = (short)(iVar2 + (iVar2 / 30) * -30 + 60);
        }
    }

    //FUN_53F8 (ST3)
    private void FUN_53F8(CriPlayer param1, CriPlayer param2)
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
            GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);
        }

        param1.FUN_65890();
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 80, sVar1);
        param1.vr.y += sVar2;

        if (param1.DAT_148 < 6)
            param1.DAT_3E++;
    }

    //FUN_54D4 (ST3)
    private void FUN_54D4(CriPlayer param1, CriPlayer param2)
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
            GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar4 & 1]);
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
            param1.DAT_1D0 &= 0xfffffffe;
        else if ((param1.DAT_1D0 & 1) == 0)
        {
            param1.DAT_1D0 |= 1;
            param1.DAT_3F = 0;
            param1.UDAT_1D2 = (ushort)(param1.vr.y + 0x800 & 0xfff);

            if (param1.DAT_12A != 0)
                param1.DAT_3F = 1;
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

    //FUN_5678 (ST3)
    private void FUN_5678(CriPlayer param1, CriPlayer param2)
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
            GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar3 & 1]);
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

        if (2 < param1.DAT_148 - 6U)
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

    //FUN_57B0 (ST3)
    private void FUN_57B0(CriPlayer param1)
    {
        uint uVar1;
        uint uVar2;
        int iVar3;
        CriPlayer oVar3;

        oVar3 = (CriPlayer)param1.DAT_154;

        if (param1.DAT_3E != 0)
            param1.DAT_40.y += param1.SDAT_1CC;

        uVar1 = Utilities.FUN_63160(param1.screen, oVar3.screen);
        PTR_FUN_126BC[param1.DAT_3E](param1, oVar3);

        if (param1.frame.DAT_01 == 5)
        {
            iVar3 = (int)GameManager.FUN_64650();

            if (iVar3 == (iVar3 / 30) * 30)
            {
                uVar2 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_1240C[uVar2 & 1]);
            }
        }
    }

    //FUN_58A0 (ST3)
    private void FUN_58A0(CriPlayer param1)
    {
        param1.DAT_40.y = -60;
        param1.SDAT_1CC = 6;
        param1.DAT_120 = 0;
        param1.PTR_120 = null;
        param1.DAT_130 = 0;
        param1.PTR_130 = null;
        param1.DAT_40.z = 80;
        param1.DAT_3E++;
        param1.FUN_609C8(3, 1, 0);
        param1.vr.y = param1.SDAT_1D8;
        param1.DAT_11E |= 0x40;
        param1.DAT_144 &= 0x7fff;
    }

    private void FUN_592C(CriPlayer param1)
    {
        bool bVar1;
        CriInteract oVar1;
        CriInteract oVar2;
        
        bVar1 = param1.FUN_60AB4();

        if (!bVar1)
            param1.FUN_65890();
        else
        {
            oVar2 = param1.PDAT_1C8;
            oVar1 = null;

            if (oVar2 != null)
            {
                oVar2.DAT_14++;
                oVar2.BDAT_09--;
                oVar1 = oVar2;
            }

            oVar2 = SceneManager.instance.FUN_5FF08();

            if (oVar2 != null)
            {
                oVar2.DAT_01 = 24;
                oVar2.DAT_02 = 0;
                oVar2.DAT_04 = param1.DAT_3A;
                oVar2.DAT_05 = param1.BDAT_1DC;
                oVar2.TDAT_0C = param1.cSkin;
                oVar2.TDAT_10 = param1.DAT_98;

                if (oVar1 != null)
                {
                    oVar2.DAT_19 = (byte)oVar1.DAT_0B;
                    oVar1.DAT_14--;
                }
                else
                    oVar2.DAT_19 = 0;
            }

            param1.FUN_6016C();
        }
    }

    //FUN_5A2C (ST3)
    private void FUN_5A2C(CriPlayer param1)
    {
        param1.DAT_40 = Vector3Int.zero;
    }

    //FUN_5A3C (ST3)
    private void FUN_5A3C(CriPlayer param1)
    {
        PTR_FUN_126CC[param1.DAT_3E](param1);
    }

    //FUN_5A78 (ST3)
    private void FUN_5A78(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(13, 0, 0);
    }

    //FUN_5AB0 (ST3)
    private void FUN_5AB0(CriPlayer param1)
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

            param1.DAT_120 = 0;
            param1.PTR_120 = DAT_123E4;
            param1.DAT_130 = 0;
            param1.PTR_130 = DAT_123E4;
            param1.DAT_144 |= 0x8000;
            param1.DAT_11E &= 0xbf;
            param1.DAT_13C = new Vector2Int(param1.screen.x, param1.screen.z);
        }

        param1.FUN_65890();
    }

    //FUN_5B54 (ST3)
    private void FUN_5B54(CriPlayer param1)
    {
        PTR_FUN_126D8[param1.DAT_3E](param1);
    }

    //FUN_5B90 (ST3)
    private void FUN_5B90(CriPlayer param1)
    {
        PTR_FUN_126E0[param1.DAT_3D](param1);
        PTR_FUN_12704[param1.DAT_3D](param1);
    }

    //FUN_5BF8 (ST3)
    private void FUN_5BF8(CriPlayer param1)
    {
        byte bVar1;
        short sVar2;

        bVar1 = param1.DAT_3D;

        if (bVar1 == 1)
        {
            param1.DAT_40.y += param1.SDAT_1CC;

            if (param1.screen.y == 0)
            {
                param1.DAT_112 = 45;
                param1.DAT_40.y = 0;
                param1.DAT_40.z = 0;
                param1.DAT_3D++;
                return;
            }
        }
        else
        {
            if (1 < bVar1)
            {
                if (bVar1 != 2)
                    return;

                sVar2 = (short)(param1.DAT_112 - 1);
                param1.DAT_112 = sVar2;

                if (sVar2 == -1)
                {
                    param1.DAT_3C = 1;
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    param1.DAT_11E &= 0xbf;
                }

                return;
            }

            if (bVar1 == 0)
            {
                param1.DAT_40.y = -50;
                param1.SDAT_1CC = 8;
                param1.DAT_3D = 1;
                param1.DAT_40.z = -80;
                return;
            }
        }
    }

    //FUN_5CCC (ST3)
    private void FUN_5CCC(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        CriInteract oVar2;

        param1.DAT_112 = 15;
        param1.DAT_3D++;
        sVar1 = (short)Utilities.FUN_615EC(param1.DAT_154.screen, param1.screen);
        param1.UDAT_1D2 = (ushort)sVar1;
        param1.DAT_40.z = 200;
        param1.SDAT_1CE = -8;
        param1.DAT_40.y = -50;
        param1.SDAT_1CC = 8;
        param1.DAT_120 = 0;
        param1.PTR_120 = null;
        param1.health = 0;
        param1.FUN_609C8(7, 0, 0);
        iVar2 = (int)GameManager.FUN_64650();
        GameManager.instance.FUN_5C94C(param1, DAT_12728[iVar2 & 1]);
        param1.DAT_144 &= 0x7fff;
        oVar2 = param1.PDAT_1C8;

        if (oVar2 != null)
        {
            oVar2.DAT_0B++;
            oVar2.BDAT_09--;
        }

        param1.DAT_1C0 &= 0xffffff9f;
    }

    //FUN_5DCC (ST3)
    private void FUN_5DCC(CriPlayer param1)
    {
        short sVar1;

        sVar1 = param1.DAT_112;
        param1.DAT_112 = (short)(sVar1 - 1);

        if (sVar1 == 1)
            param1.DAT_3D++;

        param1.FUN_60AB4();
    }

    //FUN_5E18 (ST3)
    private void FUN_5E18(CriPlayer param1)
    {
        uint uVar1;

        if (param1.screen.y == 0)
        {
            param1.DAT_40.y = -30;
            param1.DAT_3D++;
            uVar1 = GameManager.FUN_64650();
            GameManager.instance.FUN_5C94C(param1, DAT_1272C[uVar1 & 1]);
        }
    }

    //FUN_5E80 (ST3)
    private void FUN_5E80(CriPlayer param1)
    {
        CriParticle oVar2;
        CriInteract oVar3;
        CriInteract oVar4;

        param1.FUN_60AB4();

        if (param1.DAT_3E == 0 && param1.screen.y == 0)
        {
            param1.DAT_40 = Vector3Int.zero;
            param1.SDAT_1CC = 0;
            param1.SDAT_1CE = 0;
            param1.DAT_130 = 0;
            param1.PTR_130 = null;
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
                oVar2.DAT_69 = 30;
                param1.DAT_3E++;
            }

            oVar4 = param1.PDAT_1C8;

            if (oVar4.BDAT_0A != oVar4.BDAT_16)
            {
                oVar3 = SceneManager.instance.FUN_5FF08();

                if (oVar3 != null)
                {
                    oVar3.DAT_01 = 24;
                    oVar3.DAT_02 = 1;
                    oVar3.DAT_04 = param1.DAT_3A;
                    oVar3.TDAT_0C = param1.cSkin;
                    oVar3.TDAT_10 = param1.DAT_98;
                    oVar3.DAT_19 = (byte)oVar4.DAT_0B;
                    oVar4.BDAT_0A++;
                }
            }
        }
    }

    //FUN_5FC0 (ST3)
    private void FUN_5FC0(CriPlayer param1)
    {
        Vector3Int local_18;

        PTR_FUN_12730[param1.DAT_3D](param1);
        param1.DAT_40.y += param1.SDAT_1CC;
        param1.DAT_40.z += param1.SDAT_1CE;
        local_18 = new Vector3Int(0, (short)param1.UDAT_1D2, 0);
        Utilities.RotMatrix_gte(ref local_18, ref param1.cTransform.rotation);
    }

    //FUN_6050 (ST3)
    private void FUN_6050(CriPlayer param1)
    {
        bool bVar1;
        uint uVar2;

        if (param1.DAT_3D == 0)
        {
            param1.DAT_3D = 1;
            param1.FUN_609C8(10, 1, 0);
        }
        else if (param1.DAT_3D == 1)
        {
            bVar1 = param1.FUN_60AB4();

            if (bVar1)
            {
                uVar2 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar2 & 1]);
            }

            param1.FUN_65890();

            if (param1.screen.y == 0)
            {
                param1.DAT_40 = Vector3Int.zero;
                param1.DAT_3D++;
            }
        }
    }

    //FUN_6110 (ST3)
    private void FUN_6110(CriPlayer param1)
    {
        bool bVar1;
        uint uVar2;

        if (param1.DAT_3D == 0)
        {
            param1.DAT_3D = 1;
            param1.FUN_609C8(11, 1, 0);
            param1.vr.y = DAT_12740[(param1.DAT_18E - 1) * 2];
        }
        else if (param1.DAT_3D == 1)
        {
            bVar1 = param1.FUN_60AB4();

            if (bVar1)
            {
                param1.vr.y = DAT_12740[(param1.DAT_18E - 1) * 2];
                uVar2 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar2 & 1]);
            }

            if (param1.frame.DAT_01 == 0x11)
            {
                param1.vr.y = DAT_12740[(param1.DAT_18E - 1) * 2 + 1];
                uVar2 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(param1, DAT_12408[uVar2 & 1]);
            }

            param1.FUN_65890();

            if (param1.screen.y == 0)
            {
                param1.DAT_40 = Vector3Int.zero;
                param1.DAT_3D++;
            }
        }
    }

    //FUN_6260 (ST3)
    private void FUN_6260(CriPlayer param1)
    {
        param1.FUN_6642C(false);
        PTR_FUN_12748[param1.DAT_18E](param1);
    }

    //FUN_62AC (ST3)
    private void FUN_62AC(CriPlayer param1)
    {
        ushort uVar1;
        CriInteract.FUN_0C dVar2;
        int iVar3;

        uVar1 = (ushort)((param1.DAT_1A1 << 8 | param1.DAT_1A0) >> 4 & 0xf);
        param1.DAT_11E &= 0x7f;

        if (uVar1 == 2)
        {
            dVar2 = FUN_12418;
            iVar3 = 9;
        }
        else
        {
            if (uVar1 < 3)
            {
                if (uVar1 != 1) goto LAB_6340;
            }
            else if (uVar1 != 3) goto LAB_6340;

            if ((param1.DAT_1A1 & 0xfU) - 2 < 4)
                return;

            dVar2 = FUN_124CC;
            iVar3 = 21;
        }

        SceneManager.instance.FUN_65D1C(param1, dVar2, (sbyte)iVar3);
        LAB_6340:
        param1.DAT_3C = 3;
        param1.DAT_3D = 0;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_11E |= 0x40;
    }

    //FUN_654C (ST3)
    private void FUN_654C(CriPlayer param1)
    {
        short sVar1;
        int iVar2;
        bool bVar2;
        int iVar3;
        uint uVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)param1.DAT_154;
        param1.DAT_120 = 1;
        param1.PTR_120 = DAT_123E4;
        bVar2 = SceneManager.instance.FUN_802B8(param1, false, 1);

        if (!bVar2) goto LAB_675C;

        if ((param1.DAT_1C0 & 0x40) == 0)
            iVar2 = (GameManager.instance.DAT_922D == 0 ? 1 : 0) << 1;
        else
        {
            iVar2 = 1;

            if (GameManager.instance.DAT_922D == 0)
            {
                iVar2 = 2;
                uVar4 = GameManager.FUN_64650();

                if ((0x24 >> (int)(uVar4 & 7) & 1) != 0)
                    iVar2 = 1;
            }
        }

        param1.DAT_1C0 &= 0xffffff9f;
        iVar3 = Utilities.FUN_615EC(oVar5.screen, param1.screen);
        uVar4 = (uint)(((iVar3 - oVar5.vr.y & 0xfff) + 0x200 & 0xfff) >> 0x10);

        if (iVar2 == 1)
        {
            param1.DAT_2E = (byte)uVar4;

            if ((uVar4 & 1) == 0)
            {
                param1.DAT_2E = (byte)(uVar4 >> 1);

                if ((GameManager.instance.DAT_922C >> (param1.DAT_2E & 0x1f) & 1) == 0)
                {
                    GameManager.instance.DAT_922C |= (byte)(1 << (param1.DAT_2E & 31));
                    param1.DAT_3D = 4;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_40 = Vector3Int.zero;
                    param1.DAT_120 = 0;
                    param1.PTR_120 = null;
                    GameManager.instance.DAT_922D++;
                    //FUN_1D988
                    goto LAB_675C;
                }
            }

            param1.DAT_3E++;
        }
        else
        {
            if (iVar2 != 2) goto LAB_675C;

            oVar5.FUN_539F8(0, 200, (int)uVar4);
            param1.DAT_3E++;
            sVar1 = (short)(oVar5.health - 10);
            oVar5.health = sVar1;

            if (sVar1 < 10)
                oVar5.health = 10;

            //FUN_1D988
        }

        LAB_675C:
        param1.DAT_120 = 0;
        param1.PTR_120 = DAT_123E4;
    }

    //FUN_677C (ST3)
    private void FUN_677C(CriPlayer param1)
    {
        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E = 1;
            param1.DAT_40.x = 0;
            param1.DAT_40.z = 0;
            param1.FUN_609C8(12, 1, 10);
            GameManager.instance.FUN_5C94C(param1, 3);
        }
        else
            param1.FUN_60AB4();

        param1.DAT_1C0 &= 0xfffffffe;
    }

    //FUN_67F8 (ST3)
    private void FUN_67F8(CriPlayer param1)
    {
        param1.DAT_11E = 0;
        param1.DAT_3C = 1;
        param1.DAT_3D = 0;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_152 = 0;
        param1.DAT_12C &= 0xffbf;
    }

    //FUN_69B8 (ST3)
    private void FUN_69B8(CriInteract param1)
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
        param1.VDAT_10 = new Vector3Int(0, 0, 0x102);
        param1.DAT_04 = 0;
        param1.DAT_05 = 0;
        param1.DAT_06 = 0;
        param1.DAT_07 = 0;
        param1.DAT_03++;
    }

    //FUN_6A38 (ST3)
    private void FUN_6A38(CriInteract param1)
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

    //FUN_6A94 (ST3)
    private void FUN_6A94(CriInteract param1)
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

            if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 4 < (byte)param1.DAT_13)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                    return;

                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_03 = 4;
                uVar4 = (byte)param1.DAT_13;
                bVar3 = (byte)(param1.BDAT_08 << (6 - (byte)param1.DAT_13 & 31));
                bVar1 = (byte)((byte)param1.BDAT_0A << (6 - (int)uVar4 & 31));
                bVar3 &= 0xc0;
                bVar1 &= 0xc0;
                param1.DAT_04 = (byte)((uint)(byte)param1.BDAT_0A >> 2);
                param1.DAT_1A = (byte)((uint)param1.BDAT_08 >> 2);

                if (uVar4 < 6)
                {
                    switch (uVar4) //0x5C (ST3)
                    {
                        case 0: //FUN_72B8 (ST3)
                            param1.DAT_0D = 0xfc;
                            param1.BDAT_0C = 0xfc;
                            bVar3 = (byte)(param1.DAT_1A | param1.BDAT_08 << 6);
                            bVar1 = (byte)(param1.DAT_04 | (byte)param1.BDAT_0A << 6);
                            break;
                        case 1: //FUN_6DB0 (ST3)
                            param1.DAT_0D = 0xf9;
                            param1.BDAT_0C = 0xf8;
                            param1.DAT_1A &= 0x3e;
                            param1.DAT_04 &= 0x3e;
                            bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 1);
                            bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 1);
                            break;
                        case 2: //FUN_6DEC (ST3)
                            param1.DAT_0D = 0xf3;
                            param1.BDAT_0C = 0xf0;
                            param1.DAT_1A &= 0x3c;
                            param1.DAT_04 &= 0x3c;
                            bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 3);
                            bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 3);
                            break;
                        case 3: //FUN_6E28 (ST3)
                            param1.DAT_0D = 0xe7;
                            param1.BDAT_0C = 0xf0;
                            param1.DAT_1A &= 0x38;
                            param1.DAT_04 &= 0x38;
                            bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 7);
                            bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 7);
                            break;
                        case 4: //FUN_6E64 (ST3)
                            param1.DAT_0D = 0xcf;
                            param1.BDAT_0C = 0xe0;
                            param1.DAT_1A &= 0x30;
                            param1.DAT_04 &= 0x30;
                            bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 15);
                            bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 15);
                            break;
                        case 5: //FUN_6EA0 (ST3)
                            param1.DAT_0D = 0x9f;
                            param1.BDAT_0C = 0xc0;
                            param1.DAT_1A &= 0x20;
                            param1.DAT_04 &= 0x20;
                            bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 31);
                            bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 31);
                            break;
                    }
                }

                param1.DAT_1A = bVar3;
                param1.DAT_06 = (byte)param1.DAT_13;
                param1.DAT_04 = bVar1;
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
                    param1.DAT_05 = (byte)((uint)(byte)param1.DAT_0B >> 2);
                    param1.DAT_1B = (byte)((uint)param1.BDAT_09 >> 2);
                    bVar3 = (byte)(param1.DAT_1B | param1.BDAT_09 << (6 - (byte)param1.DAT_13 & 31) & 0xc0);
                    bVar1 = (byte)(param1.DAT_05 | (byte)param1.DAT_0B << (6 - (int)uVar4 & 31) & 0xc0);

                    if (uVar4 < 6)
                    {
                        switch (uVar4) //0x74 (ST3)
                        {
                            case 0: //FUN_6FE4 (ST3)
                                param1.DAT_0F = 0xfc;
                                param1.BDAT_0E = 0xfc;
                                bVar3 = (byte)(param1.DAT_1B | param1.BDAT_09 << 6);
                                bVar1 = (byte)(param1.DAT_05 | (byte)param1.DAT_0B << 6);
                                break;
                            case 1: //FUN_7020 (ST3)
                                param1.DAT_0F = 0xf9;
                                param1.BDAT_0E = 0xf8;
                                param1.DAT_1B &= 0x3e;
                                param1.DAT_05 &= 0x3e;
                                bVar3 = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 1);
                                bVar1 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 1);
                                break;
                            case 2: //FUN_705C (ST3)
                                param1.DAT_0F = 0xf3;
                                param1.BDAT_0E = 0xf0;
                                param1.DAT_1B &= 0x3c;
                                param1.DAT_05 &= 0x3c;
                                bVar3 = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 3);
                                bVar1 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 3);
                                break;
                            case 3: //FUN_7098 (ST3)
                                param1.DAT_0F = 0xe7;
                                param1.BDAT_0E = 0xf0;
                                param1.DAT_1B &= 0x38;
                                param1.DAT_05 &= 0x38;
                                bVar3 = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 7);
                                bVar1 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 7);
                                break;
                            case 4: //FUN_70D4 (ST3)
                                param1.DAT_0F = 0xcf;
                                param1.BDAT_0E = 0xe0;
                                param1.DAT_1B &= 0x30;
                                param1.DAT_05 &= 0x30;
                                bVar3 = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 15);
                                bVar1 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 15);
                                break;
                            case 5: //FUN_7110 (ST3)
                                param1.DAT_0F = 0x9f;
                                param1.BDAT_0E = 0xc0;
                                param1.DAT_1B &= 0x20;
                                param1.DAT_05 &= 0x20;
                                bVar3 = (byte)(param1.DAT_1B | bVar3 | param1.BDAT_09 & 31);
                                bVar1 = (byte)(param1.DAT_05 | bVar1 | (byte)param1.DAT_0B & 31);
                                break;
                        }
                    }

                    param1.DAT_1B = bVar3;
                    param1.DAT_05 = bVar1;
                    return;
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

                if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0 && param1.DAT_13 != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_13--;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 5 < (byte)param1.DAT_13)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0x20a0) == 0)
                        return;

                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_03 = 10;
                    uVar4 = (byte)param1.DAT_13;
                    bVar3 = (byte)(param1.BDAT_08 << (6 - (byte)param1.DAT_13 & 31));
                    bVar1 = (byte)((byte)param1.BDAT_0A << (6 - (int)uVar4 & 31));
                    bVar3 &= 0xc0;
                    bVar1 &= 0xc0;
                    param1.DAT_04 = (byte)((uint)(byte)param1.BDAT_0A >> 2);
                    param1.DAT_1A = (byte)((uint)param1.BDAT_08 >> 2);

                    if (uVar4 < 7)
                    {
                        switch (uVar4) //0x8C (ST3)
                        {
                            case 0: //FUN_72B8 (ST3)
                                param1.DAT_0D = 0xfc;
                                param1.BDAT_0C = 0xfc;
                                param1.DAT_1A = (byte)(param1.DAT_1A | param1.BDAT_08 << 6);
                                param1.DAT_04 = (byte)(param1.DAT_04 | (byte)param1.BDAT_0A << 6);
                                break;
                            case 1: //FUN_72F8 (ST3)
                                param1.DAT_0D = 0xf9;
                                param1.BDAT_0C = 0xf8;
                                param1.DAT_1A &= 0x3e;
                                param1.DAT_04 &= 0x3e;
                                bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 1);
                                bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 1);
                                break;
                            case 2: //FUN_7334 (ST3)
                                param1.DAT_0D = 0xf3;
                                param1.BDAT_0C = 0xf0;
                                param1.DAT_1A &= 0x3c;
                                param1.DAT_04 &= 0x3c;
                                bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 3);
                                bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 3);
                                break;
                            case 3: //FUN_7370 (ST3)
                                param1.DAT_0D = 0xe7;
                                param1.BDAT_0C = 0xf0;
                                param1.DAT_1A &= 0x38;
                                param1.DAT_04 &= 0x38;
                                bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 7);
                                bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 7);
                                break;
                            case 4: //FUN_73AC (ST3)
                                param1.DAT_0D = 0xcf;
                                param1.BDAT_0C = 0xe0;
                                param1.DAT_1A &= 0x30;
                                param1.DAT_04 &= 0x30;
                                bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 15);
                                bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 15);
                                break;
                            case 5: //FUN_6EA0 (ST3)
                                param1.DAT_0D = 0x9f;
                                param1.BDAT_0C = 0xc0;
                                param1.DAT_1A &= 0x20;
                                param1.DAT_04 &= 0x20;
                                bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 31);
                                bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 31);
                                break;
                            case 6: //FUN_73E4 (ST3)
                                param1.DAT_0D = 0x3f;
                                param1.BDAT_0C = 0;
                                param1.DAT_1A = 0;
                                param1.DAT_04 = 0;
                                bVar3 = (byte)(param1.DAT_1A | bVar3 | param1.BDAT_08 & 63);
                                bVar1 = (byte)(param1.DAT_04 | bVar1 | (byte)param1.BDAT_0A & 63);
                                break;
                        }
                    }

                    param1.DAT_1A = bVar3;
                    param1.DAT_06 = (byte)param1.DAT_13;
                    param1.DAT_04 = bVar1;
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
                    InventoryManager.FUN_4A7E8(2, 11, true);
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

                if (bVar1 == 3) goto LAB_6BB0;
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

        LAB_6BB0:
        param1.DAT_19 = bVar1;
    }

    //FUN_7448 (ST3)
    private void FUN_7448(CriInteract param1)
    {
        byte bVar1;

        if (param1.BDAT_16 < 7)
        {
            switch (param1.BDAT_16) //0xAC (ST3)
            {
                case 0: //FUN_7488 (ST3)
                    GameManager.instance.FUN_5C94C(null, 152);
                    DAT_12AF8 = 60;
                    DAT_12AFC = 100;
                    DAT_12B00 = 200;
                    DAT_12B04 = 1;
                    param1.DAT_17 = 0;
                    param1.BDAT_16 = 1;
                    break;
                case 1: //FUN_74D0 (ST3)
                    DAT_12AFC -= 8;
                    DAT_12B04 += 0x10;
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (3 < bVar1)
                    {
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    break;
                case 2: //FUN_7508 (ST3)
                    //FUN_91E8
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (31 < bVar1)
                    {
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    break;
                case 3: //FUN_7538 (ST3)
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (20 < bVar1)
                    {
                        GameManager.instance.FUN_5C94C(null, 153);
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    break;
                case 4: //FUN_7580 (ST3)
                    //FUN_91E8
                    FUN_9544(100, 115, (byte)param1.DAT_17, 10, 0x80202080);
                    FUN_9544(100, 115, 130, 10, 0x802020);
                    bVar1 = (byte)(param1.DAT_17 + 2);
                    param1.DAT_17 = (sbyte)bVar1;

                    if (130 < bVar1)
                    {
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    break;
                case 5: //FUN_75F4 (ST3)
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (50 < bVar1)
                    {
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    break;
                case 6: //FUN_7640 (ST3)
                    //FUN_91E8
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (20 < bVar1)
                    {
                        param1.BDAT_16 = 0;
                        param1.DAT_17 = 0;
                        param1.DAT_03 = 16;
                        InventoryManager.FUN_4A7E8(2, 9, true);
                    }

                    break;
            }
        }

        FUN_9544((short)DAT_12AF8, (short)DAT_12AFC, (short)DAT_12B00, (short)DAT_12B04, 0x202020);
    }

    //FUN_76D8 (ST3)
    private void FUN_76D8(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;
        param1.DAT_10 += 2;

        if (2 < bVar1)
        {
            param1.DAT_17 = 0;
            param1.BDAT_16++;
        }

        if (7 < param1.BDAT_16)
        {
            GameManager.instance.FUN_5C94C(null, 151);
            param1.DAT_17 = 0;
            param1.BDAT_16 = (byte)param1.DAT_13;
            param1.DAT_03++;
        }
    }

    //FUN_7760 (ST3)
    private void FUN_7760(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_12 + 2);
        param1.DAT_12 = (sbyte)bVar1;
        param1.DAT_11 -= 6;

        if (20 < bVar1)
        {
            param1.DAT_12 = 20;
            param1.DAT_17 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_03++;
        }
    }

    //FUN_77A8 (ST3)
    private void FUN_77A8(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;
        bool bVar3;

        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;
        param1.DAT_10 -= 2;

        if (2 < bVar1)
        {
            param1.DAT_17 = 0;
            param1.BDAT_16++;
        }

        if (7 < param1.BDAT_16)
        {
            param1.DAT_10 = 0;
            param1.DAT_11 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_12 = 0;
            param1.DAT_0D = 0xff;
            param1.BDAT_0C = 0;
            param1.BDAT_0A = (sbyte)param1.DAT_04;
            param1.BDAT_08 = param1.DAT_1A;
            bVar3 = FUN_8020(param1);
            bVar2 = 3;

            if (!bVar3)
                bVar2 = 2;

            param1.DAT_03 = (sbyte)bVar2;
        }
    }

    //FUN_7850 (ST3)
    private void FUN_7850(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;
        param1.DAT_10 -= 2;

        if (2 < bVar1)
        {
            param1.DAT_17 = 0;
            param1.BDAT_16++;
        }

        if (7 < param1.BDAT_16)
        {
            GameManager.instance.FUN_5C94C(null, 151);
            param1.DAT_17 = 0;
            param1.BDAT_16 = (byte)param1.DAT_13;
            param1.DAT_03++;
        }
    }

    //FUN_78D8 (ST3)
    private void FUN_78D8(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_12 + 2);
        param1.DAT_12 = (sbyte)bVar1;
        param1.DAT_11 -= 6;

        if (20 < bVar1)
        {
            param1.DAT_12 = 20;
            param1.DAT_17 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_03++;
        }
    }

    //FUN_7920 (ST3)
    private void FUN_7920(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;
        bool bVar3;

        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;
        param1.DAT_10 += 2;

        if (2 < bVar1)
        {
            param1.DAT_17 = 0;
            param1.BDAT_16++;
        }
        
        if (7 < param1.BDAT_16)
        {
            param1.DAT_10 = 0;
            param1.DAT_11 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_12 = 0;
            param1.DAT_0F = 0xff;
            param1.BDAT_0E = 0;
            param1.DAT_0B = (sbyte)param1.DAT_05;
            param1.BDAT_09 = param1.DAT_1B;
            bVar3 = FUN_8020(param1);
            bVar2 = 3;

            if (!bVar3)
                bVar2 = 2;

            param1.DAT_03 = (sbyte)bVar2;
        }
    }

    //FUN_79C8 (ST3)
    private void FUN_79C8(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;
        byte bVar3;
        byte bVar4;
        byte bVar5;
        byte bVar6;
        uint uVar7;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) == 0 || param1.DAT_13 == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 5 < param1.DAT_13)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x8040) == 0)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
                    {
                        GameManager.instance.FUN_5C94C(null, 150);
                        uVar7 = (byte)param1.DAT_13;
                        bVar5 = (byte)(param1.BDAT_09 << (6 - param1.DAT_13 & 0x1f) & 0xc0);
                        bVar6 = (byte)((byte)param1.DAT_0B << (6 - (int)uVar7 & 0x1f) & 0xc0);
                        param1.DAT_05 = (byte)((byte)param1.DAT_0B >> 2);
                        param1.DAT_1B = (byte)(param1.BDAT_09 >> 2);

                        if (uVar7 < 7)
                        {
                            switch (uVar7) //0xCC (ST3)
                            {
                                case 0: //FUN_7B30 (ST3)
                                    param1.DAT_0F = 0xfc;
                                    param1.BDAT_0E = 0xfc;
                                    param1.DAT_1B = (byte)(param1.DAT_1B | param1.BDAT_09 << 6);
                                    param1.DAT_05 = (byte)(param1.DAT_05 | (byte)param1.DAT_0B << 6);
                                    break;
                                case 1: //FUN_7B70 (ST3)
                                    param1.DAT_0F = 0xf9;
                                    param1.BDAT_0E = 0xf8;
                                    param1.DAT_1B &= 0x3e;
                                    param1.DAT_05 &= 0x3e;
                                    bVar1 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 1);
                                    bVar2 = (byte)(param1.DAT_05 | bVar6 | (byte)param1.DAT_0B & 1);
                                    break;
                                case 2: //FUN_7BAC (ST3)
                                    param1.DAT_0F = 0xf3;
                                    param1.BDAT_0E = 0xf0;
                                    param1.DAT_1B &= 0x3c;
                                    param1.DAT_05 &= 0x3c;
                                    bVar1 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 3);
                                    bVar2 = (byte)(param1.DAT_05 | bVar6 | (byte)param1.DAT_0B & 3);
                                    break;
                                case 3: //FUN_7BE8 (ST3)
                                    param1.DAT_0F = 0xe7;
                                    param1.BDAT_0E = 0xf0;
                                    param1.DAT_1B &= 0x38;
                                    param1.DAT_05 &= 0x38;
                                    bVar1 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 7);
                                    bVar2 = (byte)(param1.DAT_05 | bVar6 | (byte)param1.DAT_0B & 7);
                                    break;
                                case 4: //FUN_7C24 (ST3)
                                    param1.DAT_0F = 0xcf;
                                    param1.BDAT_0E = 0xe0;
                                    param1.DAT_1B &= 0x30;
                                    param1.DAT_05 &= 0x30;
                                    bVar1 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 15);
                                    bVar2 = (byte)(param1.DAT_05 | bVar6 | (byte)param1.DAT_0B & 15);
                                    break;
                                case 5: //FUN_7C60 (ST3)
                                    param1.DAT_0F = 0x9f;
                                    param1.BDAT_0E = 0xc0;
                                    param1.DAT_1B &= 0x20;
                                    param1.DAT_05 &= 0x20;
                                    bVar1 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 31);
                                    bVar2 = (byte)(param1.DAT_05 | bVar6 | (byte)param1.DAT_0B & 31);
                                    break;
                                case 6: //FUN_7CA4 (ST3)
                                    param1.DAT_0F = 0x3f;
                                    param1.BDAT_0E = 0;
                                    param1.DAT_1B = 0;
                                    param1.DAT_05 = 0;
                                    bVar1 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 63);
                                    bVar2 = (byte)(param1.DAT_05 | bVar6 | (byte)param1.DAT_0B & 63);
                                    break;
                            }
                        }

                        bVar1 = param1.DAT_1B;
                        bVar2 = param1.DAT_05;
                        bVar3 = param1.DAT_1A;
                        bVar4 = param1.DAT_04;
                        param1.DAT_1B = bVar1;
                        param1.DAT_05 = bVar2;
                        param1.DAT_04 &= 0x3f;
                        param1.DAT_1A = (byte)(bVar3 & 0x3f);
                        param1.DAT_1B = (byte)(bVar1 & 0x3f);
                        param1.DAT_04 = (byte)(param1.DAT_04 | bVar2 & 0xc0);
                        param1.DAT_1A = (byte)(param1.DAT_1A | bVar1 & 0xc0);
                        param1.DAT_05 &= 0x3f;
                        param1.DAT_1B = (byte)(param1.DAT_1B | bVar3 & 0xc0);
                        param1.DAT_05 = (byte)(param1.DAT_05 | bVar4 & 0xc0);
                    }
                }
                else
                {
                    GameManager.instance.FUN_5C94C(null, 147);
                    param1.DAT_0D = 0xff;
                    param1.DAT_0F = 0xff;
                    param1.DAT_19 = 3;
                    param1.DAT_12 = 0;
                    param1.BDAT_0C = 0;
                    param1.BDAT_0E = 0;
                    param1.DAT_03 = 2;
                }
            }
            else
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.DAT_13++;
            }
        }
        else
        {
            GameManager.instance.FUN_5C94C(null, 150);
            param1.DAT_13--;
        }
    }

    //FUN_7D70 (ST3)
    private void FUN_7D70(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;
        param1.DAT_10 -= 2;

        if (13 < bVar1)
        {
            GameManager.instance.FUN_5C94C(null, 151);
            param1.DAT_17 = 0;
            param1.BDAT_16 = (byte)param1.DAT_13;
            param1.DAT_03++;
        }
    }

    //FUN_7DD8 (ST3)
    private void FUN_7DD8(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_12 + 2);
        param1.DAT_12 = (sbyte)bVar1;
        param1.DAT_11 -= 6;

        if (20 < bVar1)
        {
            param1.DAT_12 = 20;
            param1.DAT_17 = 0;
            param1.BDAT_16 = 0;
            DAT_12B0B = 0;
            DAT_12B09 = 0;
            DAT_12B0A = 0;
            DAT_12B08 = 0;
            param1.DAT_03++;
        }
    }

    //FUN_7E44 (ST3)
    private void FUN_7E44(CriInteract param1)
    {
        byte bVar1;

        DAT_12B08 -= 4;
        DAT_12B0A -= 2;
        DAT_12B09 += 4;
        DAT_12B0B += 2;
        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;

        if (4 < bVar1)
        {
            param1.DAT_17 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_03++;
        }
    }

    //FUN_7EC4 (ST3)
    private void FUN_7EC4(CriInteract param1)
    {
        byte bVar1;

        DAT_12B08 -= 4;
        DAT_12B0A += 2;
        DAT_12B09 += 4;
        DAT_12B0B -= 2;
        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;

        if (4 < bVar1)
        {
            param1.DAT_17 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_03++;
        }
    }

    //FUN_7F44 (ST3)
    private void FUN_7F44(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;
        bool bVar3;

        DAT_12B08 -= 4;
        DAT_12B09 += 4;
        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;

        if (4 < bVar1)
        {
            DAT_12B08++;
            DAT_12B09--;
            param1.DAT_17 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_10 = 0;
            param1.DAT_11 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_12 = 0;
            param1.DAT_0D = 0xff;
            param1.BDAT_0C = 0;
            param1.DAT_0F = 0xff;
            param1.BDAT_0E = 0;
            param1.BDAT_0A = (sbyte)param1.DAT_04;
            param1.BDAT_08 = param1.DAT_1A;
            param1.BDAT_09 = param1.DAT_1B;
            param1.DAT_0B = (sbyte)param1.DAT_05;
            bVar3 = FUN_8020(param1);
            bVar2 = 3;

            if (!bVar3)
                bVar2 = 2;

            param1.DAT_03 = (sbyte)bVar2;
        }
    }

    //FUN_8020 (ST3)
    private bool FUN_8020(CriInteract param1)
    {
        int iVar1;
        bool bVar2;

        iVar1 = param1.DAT_02;
        bVar2 = false;

        if (param1.BDAT_08 == DAT_127F4[iVar1] && (byte)param1.BDAT_0A == DAT_127F8[iVar1] &&
            param1.BDAT_09 == DAT_127EC[iVar1])
        {
            bVar2 = true;

            if ((byte)param1.DAT_0B != DAT_127F0[iVar1])
                bVar2 = false;
        }

        return bVar2;
    }

    //FUN_9544 (ST3)
    private void FUN_9544(short param1, short param2, short param3, short param4, uint param5)
    {
        return;
    }

    //FUN_9704 (ST3)
    private void FUN_9704(CriInteract param1)
    {
        short sVar1;
        CriStatic oVar2;
        int iVar2;
        int iVar3;
        int iVar4;
        bool bVar4;
        int puVar5;
        int iVar6;
        bool bVar6;

        SceneManager.instance.FUN_26EBC(2, 0);
        SceneManager.instance.FUN_264C4(0, 0, -38, -750);
        SceneManager.instance.FUN_26504(0, 0, -0x3f01, 0x256c);
        iVar3 = 1;
        oVar2 = SceneManager.instance.staticObjects[0];
        oVar2.DAT_48 = 0;
        oVar2.screen.z = 2980;
        oVar2.screen.x = 0;
        SceneManager.instance.cCamera.DAT_36 = 200;
        DAT_12B2C[0] = 9;

        do
        {
            SceneManager.instance.staticObjects[iVar3].DAT_48 = 0;
            iVar3++;
        } while (iVar3 < 8);

        iVar4 = 0;
        iVar6 = 0;
        puVar5 = 0;

        do
        {
            bVar6 = InventoryManager.FUN_4A87C(3, (uint)iVar4 + 0x2c);

            if (!bVar6)
                DAT_12B0C[puVar5] = -1;
            else
            {
                iVar3 = iVar6 + 1;
                iVar2 = iVar4;

                if (iVar4 < 0)
                    iVar2 = iVar4 + 3;

                sVar1 = (short)(iVar2 >> 2);
                oVar2 = SceneManager.instance.staticObjects[iVar3];
                oVar2.screen.x = sVar1 * -0x960 + 0x12c0;
                oVar2.screen.y = -2200;
                oVar2.screen.z = ((short)iVar4 + sVar1 * -4) * -4000 + 3000;
                DAT_12B0C[puVar5] = (sbyte)iVar6;
                iVar6++;
            }

            iVar4++;
            puVar5++;
        } while (iVar4 < 20);

        if (param1.DAT_02 == 0)
        {
            DAT_12B0C[3] = -0x10;
            DAT_12B0C[7] = -0x10;
            DAT_12B0C[11] = -0x10;
            DAT_12B0C[15] = -0x10;
            DAT_12B0C[19] = -0x10;
        }

        param1.BDAT_0A = 6;
        param1.DAT_18 = 8;
        param1.DAT_0B = 0;
        param1.BDAT_08 = 0;
        param1.BDAT_09 = 0;
        param1.BDAT_0C = 0;
        param1.DAT_0D = 0;
        param1.BDAT_0E = 0;
        param1.DAT_0F = 0;
        param1.SDAT_10 = 0;
        param1.DAT_12 = 0;
        param1.DAT_13 = 0;
        param1.DAT_14 = 0;
        param1.DAT_15 = 0;
        param1.BDAT_16 = 0;
        param1.DAT_17 = 0;
        param1.DAT_19 = 0;
        param1.DAT_1A = 0xff;
        param1.DAT_1B = 0;
        bVar4 = InventoryManager.FUN_4A87C(3, 0x2b);

        if (bVar4)
        {
            oVar2 = SceneManager.instance.staticObjects[iVar6 + 1];
            oVar2.screen = new Vector3Int(0, -6270, 3000);
            param1.DAT_19 = 1;
            param1.DAT_1A = (byte)(iVar6 + 1);
        }

        param1.DAT_03++;
    }

    //FUN_9944 (ST3)
    private void FUN_9944(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        int iVar3;
        byte[] aVar3;
        uint uVar4;
        uint uVar5;
        int iVar7;

        bVar1 = param1.BDAT_08;

        if (bVar1 == 1)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
            {
                if (param1.BDAT_09 == 0)
                    iVar7 = 148;
                else
                {
                    iVar7 = 149;
                    param1.DAT_17 = 0;
                    param1.BDAT_16 = 1;
                    param1.BDAT_0C = 0;
                    param1.DAT_0D = 0;
                    param1.DAT_03 = 3;
                }

                goto LAB_9DF8;
            }
        }
        else if (bVar1 < 2)
        {
            if (bVar1 == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x10) != 0)
                    param1.BDAT_16 ^= 1;

                if (param1.BDAT_16 != 0)
                    return;

                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
                {
                    uVar5 = (byte)param1.BDAT_0A;

                    if ((byte)param1.DAT_0B < (int)(uVar5 - 1))
                    {
                        uVar4 = (byte)(param1.DAT_0B + 1);

                        if ((int)uVar4 < (int)uVar5)
                        {
                            do
                            {
                                if (((ushort)param1.SDAT_10 >> (int)(uVar4 & 0x1f) & 1) == 0)
                                {
                                    iVar7 = 147;
                                    param1.DAT_0B = (sbyte)iVar7;
                                    param1.DAT_12 = 0;
                                    param1.DAT_13 = 0;
                                    param1.DAT_03++;
                                    goto LAB_9DF8;
                                }

                                uVar4++;
                            } while ((int)uVar4 < (int)uVar5);
                        }
                    }
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0 && param1.DAT_0B != 0)
                {
                    uVar5 = (byte)param1.DAT_0B - 1U;

                    if (-1 < (int)uVar5)
                    {
                        do
                        {
                            if (((short)param1.SDAT_10 >> (int)(uVar5 & 0x1f) & 1) == 0)
                            {
                                iVar7 = 147;
                                param1.DAT_0B = (sbyte)uVar5;
                                param1.DAT_12 = 0;
                                param1.DAT_13 = 0;
                                param1.DAT_03++;
                                goto LAB_9DF8;
                            }

                            uVar5--;
                        } while (-1 < (int)uVar5);
                    }
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0 && param1.BDAT_09 < (byte)param1.BDAT_0A)
                {
                    if (param1.DAT_02 == 0)
                        aVar3 = DAT_1282C;
                    else
                        aVar3 = DAT_12834;

                    DAT_12B2C[param1.BDAT_09 * 4] = aVar3[(byte)param1.DAT_0B];
                    DAT_12B2C[param1.BDAT_09 * 4 + 1] = (byte)param1.DAT_0B;
                    param1.DAT_15 = 0;
                    param1.DAT_14 = 0;
                    param1.BDAT_09++;
                    param1.SDAT_10 |= (short)(1 << ((byte)param1.DAT_0B & 15));
                    DAT_12B2C[param1.BDAT_09 * 4] = 9;

                    if ((byte)param1.BDAT_0A <= param1.BDAT_09)
                        param1.BDAT_08 = 1;

                    GameManager.instance.FUN_5C94C(null, 150);
                    uVar5 = 0;

                    if (param1.BDAT_0A != 0)
                    {
                        uVar4 = (ushort)param1.SDAT_10;

                        do
                        {
                            if ((uVar4 & 1) == 0)
                            {
                                param1.DAT_0B = (sbyte)uVar5;
                                return;
                            }

                            uVar5++;
                            uVar4 = (uint)((ushort)param1.SDAT_10 >> (int)(uVar5 & 0x1f));
                        } while ((int)uVar5 < (byte)param1.BDAT_0A);
                    }
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
                {
                    bVar1 = (byte)(param1.BDAT_09 - 1);

                    if (param1.BDAT_09 != 0)
                    {
                        param1.BDAT_09 = bVar1;
                        iVar7 = 148;
                        param1.SDAT_10 &= (short)~(1 << (DAT_12B2C[bVar1 * 4 + 1] & 15));
                        DAT_12B2C[param1.BDAT_09 * 4] = 9;
                        goto LAB_9DF8;
                    }

                    param1.DAT_03 = 4;
                    SceneManager.instance.skinnedObjects[10].flags |= 2;
                    InventoryManager.FUN_4A7E8(2, 0xb, true);
                    iVar3 = 1;

                    do
                    {
                        SceneManager.instance.staticObjects[iVar3].DAT_48 = 1;
                        iVar3++;
                    } while (iVar3 < 8);

                    SceneManager.instance.FUN_26EBC(0, 0);
                    GameManager.instance.FUN_5C94C(null, 148);
                }
            }
        }
        else if (bVar1 == 2)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
            {
                param1.DAT_03 = 4;
                SceneManager.instance.skinnedObjects[10].flags |= 2;
                InventoryManager.FUN_4A7E8(2, 0xb, true);
                iVar3 = 1;

                do
                {
                    SceneManager.instance.staticObjects[iVar3].DAT_48 = 1;
                    iVar3++;
                } while (iVar3 < 8);

                SceneManager.instance.FUN_26EBC(0, 0);
                GameManager.instance.FUN_5C94C(null, 148);
            }
        }
        else if (bVar1 == 3 && (InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            param1.DAT_0B = 0;
            param1.BDAT_08 = 0;
            param1.BDAT_09 = 0;
            param1.BDAT_0C = 0;
            param1.DAT_0D = 0;
            param1.BDAT_0E = 0;
            param1.DAT_0F = 0;
            param1.SDAT_10 = 0;
            param1.DAT_12 = 0;
            param1.DAT_13 = 0;
            param1.DAT_14 = 0;
            param1.DAT_15 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_17 = 0;
            DAT_12B2C[0] = 9;
            GameManager.instance.FUN_5C94C(null, 148);
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x5000) == 0)
            return;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) == 0)
            sVar2 = (sbyte)(param1.BDAT_08 - 1);
        else
            sVar2 = (sbyte)(param1.BDAT_08 + 1);

        param1.BDAT_08 = (byte)sVar2;
        iVar7 = 147;
        LAB_9DF8:
        GameManager.instance.FUN_5C94C(null, iVar7);
    }

    //FUN_9E10 (ST3)
    private void FUN_9E10(CriInteract param1)
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

    //FUN_9E54 (ST3)
    private void FUN_9E54(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;
        sbyte sVar2;
        sbyte sVar3;
        int iVar2;
        int iVar3;
        int iVar4;
        bool bVar4;
        CriStatic oVar4;
        CriCamera cVar4;
        sbyte sVar5;
        int iVar5;
        int iVar6;
        short sVar7;

        if (DAT_12B2C[(byte)param1.DAT_17 * 4] < 12)
        {
            switch (DAT_12B2C[(byte)param1.DAT_17 * 4]) //0xE8 (ST3)
            {
                case 0: //FUN_9EB4 (ST3)
                    iVar6 = (sbyte)param1.DAT_18;
                    iVar4 = iVar6;

                    if (iVar6 < 0)
                        iVar4 = iVar6 + 3;

                    if ((iVar6 + (iVar4 >> 2) * -4) * 0x1000000 >> 0x18 == 1)
                    {
                        DAT_12B2C[param1.DAT_17 * 4] = 2;

                        if ((param1.DAT_18 & 3) == 0)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            return;
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
                                break;
                            }

                            if (param1.DAT_19 == 0) goto LAB_B3E8;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            SceneManager.instance.staticObjects[bVar1].vr.x += DAT_12864[bVar2];
                            LAB_B3E8:
                            param1.DAT_1B++;
                            return;
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
                                goto LAB_B3E8;
                            }

                            if (param1.DAT_19 == 0) goto LAB_B3E8;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            SceneManager.instance.staticObjects[bVar1].vr.x += DAT_12864[bVar2];
                            LAB_B3E8:
                            param1.DAT_1B++;
                            return;
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

                    break;
                case 1: //FUN_9FD4 (ST3)
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_12864[param1.DAT_1B];

                                param1.DAT_1B++;
                                return;
                            }

                            sVar3 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar2 = (sbyte)(param1.DAT_18 + 8);
                            param1.DAT_18 = (byte)sVar2;
                            param1.DAT_17 = (sbyte)(sVar3 + 1);
                            break;
                        }
                    }
                    else
                    {
                        DAT_12B2C[param1.DAT_17 * 4] = 11;

                        if (15 < (sbyte)param1.DAT_18)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            return;
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_12864[param1.DAT_1B];

                                param1.DAT_1B++;
                                return;
                            }

                            sVar3 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar2 = (sbyte)(param1.DAT_18 - 4);
                            param1.DAT_18 = (byte)sVar2;
                            param1.DAT_17 = (sbyte)(sVar3 + 1);
                            break;
                        }
                    }

                    param1.DAT_0D = (byte)(bVar1 + 1);
                    oVar4 = SceneManager.instance.staticObjects[0];
                    oVar4.screen.x -= 60;

                    if (param1.DAT_19 != 0)
                    {
                        oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                        oVar4.screen.x -= 60;
                    }

                    break;
                case 2: //FUN_A098 (ST3)
                    if ((param1.DAT_18 & 3) == 0)
                    {
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_17++;
                    }
                    else
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (bVar1 < 40)
                        {
                            param1.DAT_0D = (byte)(bVar1 + 1);
                            SceneManager.instance.staticObjects[0].screen.z += 100;

                            if (param1.DAT_19 != 0)
                                SceneManager.instance.staticObjects[param1.DAT_1A].screen.z += 100;
                        }
                        else
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_12864[param1.DAT_1B];

                                param1.DAT_1B++;
                                return;
                            }

                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            param1.DAT_18--;
                            param1.DAT_17++;
                        }

                        break;
                    }

                    return;
                case 3: //FUN_A1DC (ST3)
                    if (param1.BDAT_0C < 5)
                    {
                        switch (param1.BDAT_0C) //0x118 (ST3)
                        {
                            case 0: //FUN_A20C (ST3)
                                if (param1.DAT_19 == 0 && DAT_12B0C[param1.DAT_18] != -1)
                                {
                                    if (param1.DAT_0D == 0)
                                        GameManager.instance.FUN_5C94C(null, 153);

                                    bVar1 = param1.DAT_0D;
                                    param1.DAT_0D = (byte)(bVar1 + 1);

                                    if (bVar1 < 30)
                                        SceneManager.instance.staticObjects[0].screen.y += 110;
                                    else
                                    {
                                        sVar2 = DAT_12B0C[param1.DAT_18];
                                        param1.DAT_0D = 0;
                                        param1.BDAT_0C++;
                                        param1.DAT_1A = (byte)(sVar2 + 1);
                                        GameManager.instance.FUN_5C860(153);
                                        GameManager.instance.FUN_5C94C(null, 154);
                                    }

                                    break;
                                }
                                else
                                {
                                    param1.BDAT_0C = 0;
                                    param1.DAT_0D = 0;
                                    param1.DAT_17++;
                                }

                                return;
                            case 1: //FUN_A2B0 (ST3)
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);

                                if (bVar1 < 10)
                                    SceneManager.instance.staticObjects[0].screen.x -= 45;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                }

                                break;
                            case 2: //FUN_A2D4 (ST3)
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);

                                if (bVar1 < 7)
                                    SceneManager.instance.staticObjects[0].screen.y += 110;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                }

                                break;
                            case 3: //FUN_A310 (ST3)
                                if (param1.DAT_0D < 10)
                                {
                                    param1.DAT_0D++;
                                    SceneManager.instance.staticObjects[0].screen.x += 45;
                                }
                                else
                                {
                                    bVar1 = param1.DAT_1B;
                                    param1.DAT_1B = (byte)(bVar1 + 1);

                                    if (bVar1 < 20)
                                        return;

                                    param1.DAT_1B = 0;
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                    GameManager.instance.FUN_5C94C(null, 153);
                                }

                                break;
                            case 4: //FUN_A35C (ST3)
                                if (param1.DAT_0D < 37)
                                {
                                    param1.DAT_0D++;
                                    SceneManager.instance.staticObjects[0].screen.y -= 110;
                                    SceneManager.instance.staticObjects[param1.DAT_1A].screen.y -= 110;
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
                                        SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_12850[param1.DAT_1B] >> 1;
                                        param1.DAT_1B++;
                                        return;
                                    }

                                    param1.DAT_1B = 0;
                                    param1.BDAT_0C = 0;
                                    param1.DAT_17++;
                                    InventoryManager.FUN_4A7E8(3, 0x2b, true);
                                    param1.DAT_19 = 1;
                                    DAT_12B0C[param1.DAT_18] = -1;
                                    InventoryManager.FUN_4A7E8(3, param1.DAT_18 + 0x2cU, false);
                                }

                                break;
                        }
                    }

                    break;
                case 4: //FUN_A494 (ST3)
                    if (param1.DAT_18 < 8)
                    {
                        DAT_12B2C[(byte)param1.DAT_17 * 4] = 5;

                        if ((sbyte)param1.DAT_18 < 4)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            return;
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
                                sVar2 = param1.DAT_17;
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_1B = 0;
                                sVar3 = (sbyte)(param1.DAT_18 - 4);
                                param1.DAT_18 = (byte)sVar3;
                                param1.DAT_17 = (sbyte)(sVar2 + 1);
                                break;
                            }

                            if (param1.DAT_19 == 0) goto LAB_B3E8;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            SceneManager.instance.staticObjects[bVar1].vr.z += DAT_12850[bVar2];
                            LAB_B3E8:
                            param1.DAT_1B++;
                            return;
                        }
                    }
                    else
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.BDAT_0C;

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
                                sVar2 = param1.DAT_17;
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_1B = 0;
                                sVar3 = (sbyte)(param1.DAT_18 - 8);
                                param1.DAT_18 = (byte)sVar3;
                                param1.DAT_17 = (sbyte)(sVar2 + 1);
                                break;
                            }

                            if (param1.DAT_19 == 0) goto LAB_B3E8;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            SceneManager.instance.staticObjects[bVar1].vr.z += DAT_12850[bVar2];
                            LAB_B3E8:
                            param1.DAT_1B++;
                            return;
                        }
                    }

                    LAB_A5E0:
                    param1.DAT_0D = (byte)(bVar1 + 1);
                    SceneManager.instance.staticObjects[0].screen.x += 60;

                    if (param1.DAT_19 != 0)
                        SceneManager.instance.staticObjects[param1.DAT_1A].screen.x += 60;

                    break;
                case 5: //FUN_A594 (ST3)
                    if ((sbyte)param1.DAT_18 < 4)
                    {
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_17++;
                        return;
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
                            sVar2 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar3 = (sbyte)(param1.DAT_18 - 4);
                            param1.DAT_18 = (byte)sVar3;
                            param1.DAT_17 = (sbyte)(sVar2 + 1);
                            break;
                        }

                        if (param1.DAT_19 == 0) goto LAB_B3E8;

                        bVar1 = param1.DAT_1A;
                        bVar2 = param1.DAT_1B;
                        SceneManager.instance.staticObjects[bVar1].vr.z += DAT_12850[bVar2];
                        LAB_B3E8:
                        param1.DAT_1B++;
                        return;
                    }

                    goto LAB_A5E0;
                case 6: //FUN_A6B8 (ST3)
                    iVar5 = param1.DAT_18;
                    iVar3 = iVar5;

                    if (iVar5 < 0)
                        iVar3 = iVar5 + 3;

                    if ((iVar5 + (iVar3 >> 2) * -4) * 0x1000000 >> 0x18 == 2)
                    {
                        if (param1.DAT_02 == 0)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            goto LAB_A72C;
                        }

                        DAT_12B2C[param1.DAT_17 * 4] = 10;

                        if (param1.DAT_02 == 0)
                        {
                            iVar5 = param1.DAT_18;
                            iVar3 = iVar5;

                            if (iVar5 < 0)
                                iVar3 = iVar5 + 3;

                            if ((iVar5 + (iVar3 >> 2) * -4) * 0x1000000 >> 0x18 == 2)
                            {
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_17++;
                                return;
                            }
                        }
                        else
                        {
                            iVar5 = param1.DAT_18;
                            iVar3 = iVar5;

                            if (iVar5 < 0)
                                iVar3 = iVar5 + 3;

                            if ((iVar5 + (iVar3 >> 2) * -4) * 0x1000000 >> 0x18 == 3)
                            {
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_17++;
                                return;
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_12850[param1.DAT_1B];

                                param1.DAT_1B++;
                                return;
                            }

                            sVar3 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar2 = (sbyte)(param1.DAT_18 + 1);
                            param1.DAT_18 = (byte)sVar2;
                            param1.DAT_17 = (sbyte)(sVar3 + 1);
                            break;
                        }

                        goto LAB_B17C;
                    }

                    LAB_A72C:
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
                                SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_12850[param1.DAT_1B];

                            param1.DAT_1B++;
                            return;
                        }

                        sVar3 = param1.DAT_17;
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_1B = 0;
                        sVar2 = (sbyte)(param1.DAT_18 + 2);
                        param1.DAT_18 = (byte)sVar2;
                        param1.DAT_17 = (sbyte)(sVar3 + 1);
                        break;
                    }

                    LAB_B17C:
                    param1.DAT_0D = (byte)(bVar1 + 1);
                    SceneManager.instance.staticObjects[0].screen.z -= 100;

                    if (param1.DAT_19 != 0)
                        SceneManager.instance.staticObjects[param1.DAT_1A].screen.z -= 100;

                    break;
                case 7: //FUN_A7C4 (ST3)
                    if (param1.BDAT_0C < 5)
                    {
                        switch (param1.BDAT_0C) //0x130 (ST3)
                        {
                            case 0: //FUN_A7F4 (ST3)
                                if (param1.DAT_19 == 0 || DAT_12B0C[param1.DAT_18] != -1)
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
                                        SceneManager.instance.staticObjects[0].screen.y += 110;
                                        SceneManager.instance.staticObjects[param1.DAT_1A].screen.y += 110;
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
                                            return;

                                        GameManager.instance.FUN_5C94C(null, 154);
                                        param1.DAT_1B = 0;
                                        param1.DAT_0D = 0;
                                        param1.BDAT_0C++;
                                    }

                                    break;
                                }

                                return;
                            case 1: //FUN_A8F0 (ST3)
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);

                                if (bVar1 < 10)
                                    SceneManager.instance.staticObjects[0].screen.x -= 45;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                }

                                break;
                            case 2: //FUN_A92C (ST3)
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);

                                if (bVar1 < 7)
                                    SceneManager.instance.staticObjects[0].screen.y -= 110;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                }

                                break;
                            case 3: //FUN_A95C (ST3)
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);

                                if (bVar1 < 10)
                                    SceneManager.instance.staticObjects[0].screen.x += 45;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                    GameManager.instance.FUN_5C94C(null, 153);
                                }

                                break;
                            case 4: //FUN_A9BC (ST3)
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
                                        return;

                                    param1.DAT_1B = 0;
                                    param1.BDAT_0C = 0;
                                    param1.DAT_17++;
                                    InventoryManager.FUN_4A7E8(3, 0x2b, false);
                                    param1.DAT_19 = 0;
                                    DAT_12B0C[param1.DAT_18] = (sbyte)(param1.DAT_1A - 1);
                                    InventoryManager.FUN_4A7E8(3, param1.DAT_18 + 0x2cU, true);
                                    param1.DAT_1A = 0xff;
                                }

                                break;
                        }
                    }

                    break;
                case 8: //FUN_AA9C (ST3)
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_12850[param1.DAT_1B];

                                param1.DAT_1B++;
                                return;
                            }

                            sVar2 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar3 = (sbyte)(param1.DAT_18 + 3);
                            param1.DAT_18 = (byte)sVar3;
                            param1.DAT_17 = (sbyte)(sVar2 + 1);
                            break;
                        }
                    }
                    else
                    {
                        DAT_12B2C[param1.DAT_17 * 4] = 6;
                        iVar5 = param1.DAT_18;
                        iVar4 = iVar5;

                        if (iVar5 < 0)
                            iVar4 = iVar5 + 3;

                        if ((iVar5 + (iVar4 >> 2) * -4) * 0x1000000 >> 0x18 == 2)
                        {
                            if (param1.DAT_02 != 0)
                            {
                                DAT_12B2C[param1.DAT_17 * 4] = 10;

                                if (param1.DAT_02 == 0)
                                {
                                    iVar5 = param1.DAT_18;
                                    iVar4 = iVar5;

                                    if (iVar5 < 0)
                                        iVar4 = iVar5 + 3;

                                    if ((iVar5 + (iVar4 >> 2) * -4) * 0x1000000 >> 0x18 == 2)
                                    {
                                        param1.BDAT_0C = 0;
                                        param1.DAT_0D = 0;
                                        param1.DAT_17++;
                                        return;
                                    }
                                }
                                else
                                {
                                    iVar5 = param1.DAT_18;
                                    iVar4 = iVar5;

                                    if (iVar5 < 0)
                                        iVar4 = iVar5 + 3;

                                    if ((iVar5 + (iVar4 >> 2) * -4) * 0x1000000 >> 0x18 == 3)
                                    {
                                        param1.BDAT_0C = 0;
                                        param1.DAT_0D = 0;
                                        param1.DAT_17++;
                                        return;
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
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_12850[param1.DAT_1B];

                                        param1.DAT_1B++;
                                        return;
                                    }

                                    sVar2 = param1.DAT_17;
                                    param1.BDAT_0C = 0;
                                    param1.DAT_0D = 0;
                                    param1.DAT_1B = 0;
                                    sVar3 = (sbyte)(param1.DAT_18 + 1);
                                    param1.DAT_18 = (byte)sVar3;
                                    param1.DAT_17 = (sbyte)(sVar2 + 1);
                                    break;
                                }

                                goto LAB_B17C;
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_12850[param1.DAT_1B];

                                param1.DAT_1B++;
                                return;
                            }

                            sVar2 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar3 = (sbyte)(param1.DAT_18 + 2);
                            param1.DAT_18 = (byte)sVar3;
                            param1.DAT_17 = (sbyte)(sVar2 + 1);
                            break;
                        }
                    }

                    goto LAB_B17C;
                case 9: //FUN_AB64 (ST6)
                    oVar4 = SceneManager.instance.staticObjects[0];

                    if (param1.DAT_18 != 8)
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C = 0x80;
                            GameManager.instance.FUN_5C94C(null, 151);

                            if (oVar4.screen.x < 0)
                                bVar1 = (byte)(param1.BDAT_0C | 2);
                            else
                                bVar1 = (byte)(param1.BDAT_0C | 1);

                            param1.BDAT_0C = bVar1;

                            if (oVar4.screen.x == 0)
                                param1.BDAT_0C = 0x80;

                            if (oVar4.screen.z < 2980)
                                bVar1 = (byte)(param1.BDAT_0C | 4);
                            else
                                bVar1 = (byte)(param1.BDAT_0C | 8);

                            param1.BDAT_0C = bVar1;

                            if (oVar4.screen.z == 2980)
                                param1.BDAT_0C &= 0x83;
                        }
                        else
                        {
                            if ((param1.BDAT_0C & 1) != 0)
                            {
                                if (oVar4.screen.x < 1)
                                    oVar4.screen.x = 0;
                                else
                                    oVar4.screen.x -= 60;

                                if (param1.DAT_19 != 0)
                                    SceneManager.instance.staticObjects[param1.DAT_1A].screen.x -= 60;
                            }

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

                                if (2979 < oVar4.screen.z)
                                    sVar7 = 2980;

                                oVar4.screen.z = sVar7;
                            }

                            if ((param1.BDAT_0C & 8) != 0)
                            {
                                sVar7 = 2980;

                                if (2980 < oVar4.screen.z)
                                    sVar7 = (short)(oVar4.screen.z - 100);

                                oVar4.screen.z = sVar7;
                            }

                            if (param1.DAT_19 != 0)
                                SceneManager.instance.staticObjects[param1.DAT_1A].screen.z = oVar4.screen.z + 20;

                            if (oVar4.screen.x == 0 && oVar4.screen.z == 2980)
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
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_12864[param1.DAT_1B];

                                        if ((param1.BDAT_0C & 2) != 0)
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_12850[param1.DAT_1B];

                                        if ((param1.BDAT_0C & 4) != 0)
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_12864[param1.DAT_1B];

                                        if ((param1.BDAT_0C & 8) != 0)
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_12850[param1.DAT_1B];
                                    }

                                    param1.DAT_1B++;
                                    return;
                                }

                                goto LAB_AF84;
                            }
                        }

                        break;
                    }

                    LAB_AF84:
                    param1.DAT_0B = 0;
                    param1.BDAT_08 = 0;
                    param1.BDAT_09 = 0;
                    param1.DAT_1B = 0;
                    param1.BDAT_0C = 0;
                    param1.DAT_0D = 0;
                    param1.BDAT_0E = 0;
                    param1.DAT_0F = 0;
                    param1.DAT_10 = 0;
                    param1.DAT_11 = 0;
                    param1.DAT_12 = 0;
                    param1.DAT_13 = 0;
                    param1.DAT_14 = 0;
                    param1.DAT_15 = 0;
                    param1.BDAT_16 = 0;
                    param1.DAT_17 = 0;
                    DAT_12B2C[0] = 9;
                    param1.DAT_18 = 8;
                    param1.DAT_03 = 1;
                    cVar4 = SceneManager.instance.cCamera;
                    cVar4.DAT_36 = 200;
                    cVar4.DAT_3E = 0;
                    cVar4.DAT_50 = 0;
                    cVar4.DAT_52 = 0;
                    SceneManager.instance.FUN_264C4(400, 0, -38, -750);
                    iVar5 = 0;
                    cVar4.DAT_72 |= 1;
                    cVar4.DAT_73 = 1;

                    do
                    {
                        iVar3 = 0;

                        do
                        {
                            DAT_12B5C[iVar3] = 0;
                            iVar3++;
                        } while (iVar3 < 20);

                        bVar4 = FUN_B470(iVar5);

                        if (bVar4)
                            FUN_B49C(param1.DAT_02, iVar5, 0);

                        if (DAT_12B5C[16] != 0 || DAT_12B5C[17] != 0 || DAT_12B5C[18] != 0 || DAT_12B5C[19] != 0)
                        {
                            InventoryManager.FUN_4A7E8(2, 9, true);
                            return;
                        }

                        InventoryManager.FUN_4A7E8(2, 9, false);
                        iVar5++;
                    } while (iVar5 < 4);

                    return;
                case 10: //FUN_B0C4 (ST3)
                    if (param1.DAT_02 == 0)
                    {
                        iVar3 = param1.DAT_18;
                        iVar2 = iVar3;

                        if (iVar3 < 0)
                            iVar2 = iVar3 + 3;

                        if ((iVar3 + (iVar2 >> 2) * -4) * 0x1000000 >> 0x18 == 2)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            return;
                        }
                    }
                    else
                    {
                        iVar3 = param1.DAT_18;
                        iVar2 = iVar3;

                        if (iVar3 < 0)
                            iVar2 = iVar3 + 3;

                        if ((iVar3 + (iVar2 >> 2) * -4) * 0x1000000 >> 0x18 == 3)
                        {
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_17++;
                            return;
                        }
                    }

                    if (param1.BDAT_0C == 0)
                    {
                        param1.BDAT_0C++;
                        GameManager.instance.FUN_5C94C(null, 151);
                    }

                    bVar1 = param1.DAT_0D;

                    if (bVar1 < 40)
                    {
                        param1.DAT_0D = (byte)(bVar1 + 1);
                        SceneManager.instance.staticObjects[0].screen.z -= 100;

                        if (param1.DAT_19 != 0)
                            SceneManager.instance.staticObjects[param1.DAT_1A].screen.z -= 100;
                    }
                    else
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
                                SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_12850[param1.DAT_1B];

                            param1.DAT_1B++;
                            return;
                        }

                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_1B = 0;
                        param1.DAT_18++;
                        param1.DAT_17++;
                    }

                    break;
                case 11: //FUN_B290 (ST3)
                    if (param1.DAT_18 < 16)
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (bVar1 < 40)
                        {
                            param1.DAT_0D = (byte)(bVar1 + 1);
                            SceneManager.instance.staticObjects[0].screen.x -= 60;

                            if (param1.DAT_19 != 0)
                                SceneManager.instance.staticObjects[param1.DAT_1A].screen.x -= 60;
                        }
                        else
                        {
                            if (bVar1 == 40)
                            {
                                GameManager.instance.FUN_5C860(151);
                                GameManager.instance.FUN_5C94C(null, 152);
                                param1.DAT_0D++;
                            }

                            if (param1.DAT_1B < 40)
                            {
                                if (param1.DAT_19 != 0)
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_12864[param1.DAT_1B];

                                param1.DAT_1B++;
                                return;
                            }

                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            param1.DAT_18 -= 4;
                            param1.DAT_17++;
                        }

                        break;
                    }
                    else
                    {
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_17++;
                    }

                    return;
            }
        }
        
        oVar4 = SceneManager.instance.staticObjects[0];
        iVar4 = oVar4.screen.y;

        if (oVar4.screen.z == 2980 && -5800 < oVar4.screen.y)
            iVar4 = -5800;

        SceneManager.instance.FUN_264C4(50, (short)oVar4.screen.x, (short)iVar4, (short)oVar4.screen.z);
    }

    //FUN_B470 (ST3)
    private bool FUN_B470(int param1)
    {
        if (DAT_12B0C[param1] != -1)
            return false;

        return param1 < 20;
    }

    //FUN_B49C (ST3)
    private void FUN_B49C(int param1, int param2, int param3)
    {
        bool bVar1;

        if (DAT_12B5C[param2] <= param3)
        {
            DAT_12B5C[param2] = (byte)param3;
            param3--;
            bVar1 = FUN_B470(param2 - 1);

            if (bVar1)
                FUN_B49C(0, param2 - 1, param3);

            bVar1 = FUN_B470(param2 + 4);

            if (bVar1)
                FUN_B49C(0, param2 + 4, param3);

            bVar1 = FUN_B470(param2 + 1);

            if (bVar1)
                FUN_B49C(0, param2 + 1, param3);

            bVar1 = FUN_B470(param2 - 4);

            if (bVar1)
                FUN_B49C(0, param2 - 4, param3);
        }
    }

    //FUN_109A8 (ST3)
    private void FUN_109A8(CriInteract param1)
    {
        byte bVar1;
        ushort uVar3;
        uint uVar4;
        int piVar5;

        param1.DAT_07 = 0x20;
        param1.DAT_03++;
        //...
        DAT_12C88[0] = 60;
        DAT_12C88[1] = 60;
        DAT_12C88[2] = 190;
        DAT_12C88[3] = 80;
        DAT_12C90 = 2;

        if ((param1.DAT_02 & 1) == 0)
            bVar1 = param1.DAT_05;
        else
            bVar1 = param1.DAT_04;

        uVar3 = bVar1;
        uVar4 = 0;
        piVar5 = 0;

        do
        {
            param1.SET_OFFSET_08(piVar5 + 1, (byte)uVar3);

            if ((uVar4 & 1) == 0)
                param1.SET_OFFSET_08((int)(uVar4 + 3), 0xff);
            else
                param1.SET_OFFSET_08((int)(uVar4 + 3), 1);

            uVar3 += 40;
            bVar1 = (byte)GameManager.FUN_64650();
            param1.SET_OFFSET_08(piVar5 + 4, (byte)(bVar1 & 0x7f));
            piVar5 += 2;
            uVar4++;
        } while (uVar4 < DAT_12C90);
    }

    //FUN_10AFC (ST3)
    private void FUN_10AFC(CriInteract param1)
    {
        sbyte sVar1;
        byte bVar2;
        short sVar3;
        int iVar4;
        int iVar6;
        uint uVar8;
        uint uVar9;
        int iVar10;

        uVar9 = 0;
        iVar10 = 0;

        do
        {
            uVar8 = 0;

            do
            {
                iVar4 = (int)(uVar8 + iVar10);
                iVar6 = (int)(uVar8 << 5);
                uVar8++;
                DAT_12CE0[iVar4] = (sbyte)iVar6;
                DAT_12CF0[iVar4] = (sbyte)(uVar9 << 5);
            } while (uVar8 < 3);

            uVar9++;
            iVar10 += 3;
        } while (uVar9 < 3);

        uVar9 = 0;
        iVar10 = 0;

        do
        {
            uVar8 = 0;
            iVar4 = iVar10;

            do
            {
                iVar6 = (int)(uVar8 << 5);
                DAT_12CA0[iVar4] = (short)iVar6;
                DAT_12CC0[iVar4] = (short)(uVar9 << 5);
                iVar4++;
                uVar8++;
            } while (uVar8 < 3);

            uVar9++;
            iVar10 += 3;
        } while (uVar9 < 3);

        uVar9 = 0;
        iVar10 = 0;
        iVar4 = 0;

        if (DAT_12C90 != 0)
        {
            do
            {
                if ((param1.DAT_02 & 1) == 0)
                {
                    sVar3 = (short)(param1.GET_OFFSET_08_2(iVar10 + 2) + param1.GET_OFFSET_08(iVar4 + 12));
                    param1.SET_OFFSET_08_2(iVar10 + 2, sVar3);
                    iVar6 = DAT_12C88[1];

                    if (sVar3 < iVar6)
                    {
                        sVar1 = (sbyte)param1.GET_OFFSET_08(iVar4 + 12);
                        param1.SET_OFFSET_08(iVar4 + 12, (byte)-sVar1);
                        param1.SET_OFFSET_08_2(iVar10 + 2, (short)(param1.GET_OFFSET_08_2(iVar10 + 2) - sVar1));
                        iVar6 = DAT_12C88[1];
                    }

                    if (iVar6 + DAT_12C88[3] <= param1.GET_OFFSET_08_2(iVar10 + 2))
                    {
                        sVar1 = (sbyte)-param1.GET_OFFSET_08(iVar4 + 12);
                        param1.SET_OFFSET_08(iVar4 + 12, (byte)sVar1);
                        sVar3 = param1.GET_OFFSET_08_2(iVar10 + 2);
                        param1.SET_OFFSET_08_2(iVar10 + 2, (short)(sVar3 + sVar1));
                    }
                }
                else
                {
                    param1.SET_OFFSET_08_2(iVar10 + 2, (short)(param1.GET_OFFSET_08_2(iVar10 + 2) + param1.GET_OFFSET_08(iVar4 + 12)));
                    iVar6 = (int)FUN_10ED4(param1, uVar9);

                    if (iVar6 != 0)
                    {
                        param1.SET_OFFSET_08_2(iVar10 + 2, (short)(param1.GET_OFFSET_08_2(iVar10 + 2) - param1.GET_OFFSET_08(iVar4 + 12)));
                        param1.SET_OFFSET_08(iVar4 + 12, (byte)-param1.GET_OFFSET_08(iVar4 + 12));
                    }

                    if (param1.GET_OFFSET_08_2(iVar10 + 2) < DAT_12C88[0])
                    {
                        if ((sbyte)param1.GET_OFFSET_08(iVar4 + 12) < 0)
                            param1.SET_OFFSET_08(iVar4 + 12, (byte)-param1.GET_OFFSET_08(iVar4 + 12));

                        param1.SET_OFFSET_08_2(iVar10 + 2, (short)(param1.GET_OFFSET_08_2(iVar10 + 2) + param1.GET_OFFSET_08(iVar4 + 12)));
                    }

                    if (DAT_12C88[0] + DAT_12C88[2] - 0x40 <= param1.GET_OFFSET_08_2(iVar10 + 2))
                    {
                        if (-1 < (sbyte)param1.GET_OFFSET_08(iVar4 + 12))
                            param1.SET_OFFSET_08(iVar4 + 12, (byte)-param1.GET_OFFSET_08(iVar4 + 12));

                        sVar1 = (sbyte)param1.GET_OFFSET_08(iVar4 + 12);
                        sVar3 = param1.GET_OFFSET_08_2(iVar10 + 2);
                        param1.SET_OFFSET_08_2(iVar10 + 2, (short)(sVar3 + sVar1));
                    }
                }

                uVar9++;
                iVar10++;
                iVar4++;
            } while (uVar9 < DAT_12C90);
        }

        bVar2 = param1.DAT_02;

        if ((bVar2 & 2) == 0)
            return;

        uVar9 = ((uint)bVar2 >> 4) + 1;

        if (2 < uVar9)
        {
            if ((bVar2 & 4) == 0)
            {
                bVar2 = (byte)(param1.DAT_07 + 1);
                param1.DAT_07 = bVar2;
                uVar9 = 0;

                if (bVar2 < 0x20) goto LAB_10E68;
            }
            else
            {
                sVar1 = (sbyte)(param1.DAT_07 - 1);
                param1.DAT_07 = (byte)sVar1;
                uVar9 = 0;

                if (sVar1 != 0) goto LAB_10E68;
            }

            param1.DAT_03++;
            uVar9 = 0;
        }

        LAB_10E68:
        param1.DAT_02 = (byte)(param1.DAT_02 & 0xf | (byte)(uVar9 << 4));
    }

    //FUN_10EA4 (ST3)
    private void FUN_10EA4(CriInteract param1)
    {
        param1.FUN_5FF98();
        LevelManager.instance.FUN_60100(param1.PTR_08);
    }

    //FUN_10ED4 (ST3)
    private uint FUN_10ED4(CriInteract param1, uint param2)
    {
        uint uVar1;
        uint uVar2;
        int iVar3;
        int iVar4;
        int iVar5;

        iVar5 = 0;
        iVar4 = 0;

        if ((param1.DAT_02 & 1) == 0)
            iVar5 = param1.GET_OFFSET_08_2((int)param2 + 2) + 0x20;
        else
            iVar4 = param1.GET_OFFSET_08_2((int)param2 + 2) + 0x20;

        uVar1 = 0;
        iVar3 = 0;

        if (DAT_12C90 != 0)
        {
            do
            {
                if (uVar1 != param2)
                {
                    if ((param1.DAT_02 & 1) == 0)
                        uVar2 = (uint)(iVar5 - (param1.GET_OFFSET_08_2(iVar3 + 2) + 0x20));
                    else
                        uVar2 = (uint)(iVar4 - (param1.GET_OFFSET_08_2(iVar3 + 2) + 0x20));

                    if (uVar2 < 0x21)
                    {
                        param1.SET_OFFSET_08((int)(uVar1 + 12), (byte)-param1.GET_OFFSET_08((int)(uVar1 + 12)));
                        return uVar2;
                    }
                }

                uVar1++;
                iVar3 += 2;
            } while (uVar1 < DAT_12C90);
        }

        return 0;
    }

    //FUN_3A4 (ST3)
    public static void FUN_3A4(CriParticle param1)
    {
        instance.PTR_FUN_11C70[param1.DAT_3C](param1);
        //FUN_728
    }

    //FUN_CF0 (ST3)
    public static void FUN_CF0(CriParticle param1)
    {
        instance.PTR_FUN_11C80[param1.DAT_3C](param1);
    }

    //FUN_14E4 (ST3)
    public static void FUN_14E4(CriParticle param1)
    {
        instance.PTR_FUN_11CBC[param1.DAT_3C](param1);
    }

    //FUN_1D80 (ST3)
    public static void FUN_1D80(CriParticle param1)
    {
        instance.PTR_FUN_11CCC[param1.DAT_3C](param1);
    }

    //FUN_1E88 (ST3)
    public static void FUN_1E88(CriParticle param1)
    {
        instance.PTR_FUN_11CF0[param1.DAT_3C](param1);
    }

    //FUN_203C (ST3)
    public static void FUN_203C(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_11CFC[param1.DAT_3C](param1);
    }

    //FUN_2170 (ST3)
    public static void FUN_2170(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_11D34[param1.DAT_3C](param1);
    }

    //FUN_2308 (ST3)
    public static void FUN_2308(CriParticle param1)
    {
        instance.PTR_FUN_11D64[param1.DAT_3C](param1);
    }

    //FUN_2778 (ST3)
    public static void FUN_2778(CriInteract param1)
    {
        instance.PTR_FUN_11D98[param1.DAT_03](param1);
    }

    //FUN_2BF0 (ST3)
    public static void FUN_2BF0(CriInteract param1)
    {
        instance.PTR_FUN_11E14[param1.DAT_03](param1);
    }

    //FUN_3428 (ST3)
    public static void FUN_3428(CriInteract param1)
    {
        instance.PTR_FUN_11E48[param1.DAT_03](param1);
    }

    //FUN_3B10 (ST3)
    public static void FUN_3B10(CriInteract param1)
    {
        instance.PTR_FUN_11E5C[param1.DAT_03](param1);
    }

    //FUN_3B4C (ST3)
    public static void FUN_3B4C(CriInteract param1)
    {
        instance.PTR_FUN_11E70[param1.DAT_03](param1);
    }

    //FUN_3E7C (ST3)
    public static void FUN_3E7C(CriInteract param1)
    {
        instance.PTR_FUN_12390[param1.DAT_03](param1);
    }

    //FUN_6364 (ST3)
    public static void FUN_6364(CriPlayer param1)
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
                    instance.FUN_62AC(param1);

                instance.PTR_FUN_12754[param1.DAT_3C](param1);

                if ((param1.flags & 1) == 0)
                    return;

                param1.FUN_62F3C(ref param1.DAT_40);

                if ((param1.DAT_1C0 & 0x60) != 0)
                    instance.FUN_654C(param1);

                param1.FUN_6449C(0);
                SceneManager.instance.FUN_80030(param1, true, 1);
                SceneManager.instance.FUN_80A14(param1);

                if (param1.DAT_2F == 1 && param1.DAT_1DD < (uint)(byte)param1.PDAT_1C8.DAT_0B && param1.PDAT_1C8.BDAT_09 < 3U)
                    param1.DAT_1C0 |= 1;
            }

            if (param1.DAT_3C == 4)
                uVar3 = param1.flags & 0xfffffffb;
            else
                uVar3 = param1.flags | 4;

            param1.flags = uVar3;
        }
    }

    //FUN_6818 (ST3)
    public static void FUN_6818(CriPlayer param1)
    {
        instance.PTR_FUN_12768[param1.DAT_3D](param1);
    }

    //FUN_6854 (ST3)
    public static void FUN_6854(CriInteract param1)
    {
        instance.PTR_FUN_12770[param1.DAT_03](param1);
        //...
    }

    //FUN_9624 (ST3)
    public static void FUN_9624(CriInteract param1)
    {
        instance.PTR_FUN_1283C[param1.DAT_03](param1);
        //...
    }

    //FUN_1096C (ST3)
    public static void FUN_1096C(CriInteract param1)
    {
        instance.PTR_FUN_12AEC[param1.DAT_03](param1);
    }
}
