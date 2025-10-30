using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct UNK_12B68
{
    public short DAT_00;
    public short DAT_02;
    public short DAT_04;
    public byte DAT_06;
    public byte DAT_07;
    public bool DAT_08;
    public bool DAT_09;
    public bool DAT_0A;
}

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
    private delegate void FUN_11F90(CriParticle p); //0x11F90 (ST8)
    private delegate void FUN_12020(CriParticle p); //0x12020 (ST8)
    private delegate void FUN_12048(CriParticle p); //0x12048 (ST8)
    private delegate void FUN_12054(CriParticle p); //0x12054 (ST8)
    private delegate void FUN_12080(CriParticle p); //0x12080 (ST8)
    private delegate void FUN_1208C(CriInteract i); //0x1208C (ST8)
    private delegate void FUN_120AC(CriInteract i); //0x120AC (ST8)
    private delegate void FUN_12140(CriInteract i); //0x12140 (ST8)
    private delegate void FUN_12164(CriInteract i); //0x12164 (ST8)
    private delegate void FUN_121E4(CriInteract i); //0x121E4 (ST8)
    private delegate void FUN_121F4(CriInteract i); //0x121F4 (ST8)
    private delegate void FUN_122B0(CriInteract i); //0x122B0 (ST8)
    private delegate void FUN_123D4(CriInteract i); //0x123D4 (ST8)
    private delegate void FUN_12454(CriStatic s); //0x12454 (ST8)
    private delegate void FUN_1248C(CriInteract i); //0x1248C (ST8)
    private delegate void FUN_124A8(CriInteract i); //0x124A8 (ST8)
    private delegate void FUN_12508(CriParticle p); //0x12508 (ST8)
    private delegate void FUN_12518(CriInteract i); //0x12518 (ST8)
    private delegate void FUN_1255C(CriInteract i); //0x1255C (ST8)
    private delegate void FUN_12614(CriInteract i); //0x12614 (ST8)
    private delegate void FUN_1268C(CriInteract i); //0x1268C (ST8)
    private uint[] DAT_11F08 = new uint[] { 0x80138424, 0x80138434, 0x80138474, 0x80138504, 0x80138514, 0x8013851c, 0x80138524, 0x8013852c, 0x80138534, 0x8013853c, 0x80138544, 0x8013854c, 0x8013854c, 0x80138554, 0x801385c4, 0x8013865c, 0x8013866c, 0x80133fcc, 0x80133fdc, 0x8013401c, 0x801340ac, 0x801340bc, 0x801340c4, 0x801340cc, 0x801340d4, 0x801340dc, 0x801340e4, 0x801340ec, 0x801340f4, 0x801340f4, 0x801340fc, 0x8013416c, 0x80134204, 0x80134214 };
    private FUN_11F90[] PTR_FUN_11F90; //0x11F90 (ST8)
    private uint[] DAT_11F9C = new uint[] { 0x80144e70, 0x80145b88, 0x80145bd8, 0x80146178, 0x80146718, 0x80146750, 0x80146828, 0x80146908, 0x80146af8, 0x80146ba8, 0x80146bb0, 0x80146bb8, 0x80146bc0, 0x80146bc8, 0x80146bd0, 0x80146bd8, 0x80146be0, 0x80146be8, 0x80146bf0, 0x80146bf8, 0x80146c00, 0x80146c10, 0x80146c18, 0x80146c20, 0x80146c28, 0x80146c30, 0x80146c38, 0x80146c40, 0x80146c48, 0x80146c50, 0x80146c58, 0x80146c60, 0x80146c68 };
    private FUN_12020[] PTR_FUN_12020; //0x12020 (ST8)
    private uint[] DAT_12030 = new uint[] { 0x801278b4, 0x80127984, 0x8012799c };
    private ushort[] DAT_12034 = new ushort[] { 0x7efb, 0x7efb, 0x7efb };
    private FUN_12048[] PTR_FUN_12048; //0x12048 (ST8)
    private FUN_12054[] PTR_FUN_12054; //0x12054 (ST8)
    private uint[] DAT_12060 = new uint[] { 0x80139200, 0x80139240, 0x80139270, 0x80139298, 0x801392b8, 0x801392e0, 0x80139308, 0x80139358 };
    private FUN_12080[] PTR_FUN_12080; //0x12080 (ST8)
    private FUN_1208C[] PTR_FUN_1208C; //0x1208C (ST8)
    private byte[] DAT_120A8 = new byte[] { 0, 3, 9, 2 };
    private FUN_120AC[] PTR_FUN_120AC; //0x120AC (ST8)
    private FUN_12140[] PTR_FUN_12140; //0x12140 (ST8)
    private FUN_12164[] PTR_FUN_12164; //0x12164 (ST8)
    private uint[][] DAT_121D8 = new uint[3][] { new uint[] { 0x8011746c, 0x80117c58, 0x80118744, 0x801191f0, 0x8011c2ac, 0x8011ca58, 0x8011d2a4, 0x8011dd50 },
                                                 new uint[] { 0x80119d1c, 0x8011a428, 0x80119d1c, 0x8011a428, 0x8011e85c, 0x8011f008, 0x8011e85c, 0x8011f008 },
                                                 new uint[] { 0x8011acd4, 0x8011b7e0, 0x8011acd4, 0x8011b7e0, 0x8011f954, 0x80120b40, 0x8011f954, 0x80120b40 } };
    private FUN_121E4[] PTR_FUN_121E4; //0x121E4 (ST8)
    private FUN_121F4[] PTR_FUN_121F4; //0x121F4 (ST8)
    private byte[] DAT_12270 = new byte[] { 0, 0xff, 0, 0 };
    private byte[] DAT_12274 = new byte[] { 0, 0xf, 0, 0 };
    private byte[] DAT_12278 = new byte[] { 0x4d, 0, 0, 0 };
    private byte[] DAT_1227C = new byte[] { 0, 0, 0, 0 };
    private FUN_122B0[] PTR_FUN_122B0; //0x122B0 (ST8)
    private sbyte[] DAT_12384 = new sbyte[] { 0, 0, 0, 0, 0, -1, -1, -1, -1, -1, 1, 1, 1, 1, 1, 1, 1, -1, -1, -1, 2, 2, 2, 2, 2, 2, 2, 2, -1, -1, 3, 3, 3, 3, 3, -1, -1, -1, -1, -1, 0, 3, 3, 3, 0, 0, 3, 3, -1, -1, 0, 1, 0, 3, 0, 1, 3, 1, -1, -1, 0, 1, 2, 3, 0, 1, 2, 3, 1, -1, 0, 1, 2, 3, 0, 1, 2, 3, 2, 1 };
    private FUN_123D4[] PTR_FUN_123D4; //0x123D4 (ST8)
    private uint[] DAT_123F0 = new uint[] { 0x801003d0, 0x80100784, 0x80100b38, 0x80100eec, 0x801012a0, 0x80101654, 0x8010001c };
    private sbyte[] DAT_1240C = new sbyte[] { 3, 4, 5, 0, 1, 2, 5, 1, 2, 3, 0, 4, 3, 4, 0, 1, 5, 2, 2, 1, 3, 5, 0, 4, 4, 0, 2, 5, 1, 3, 2, 5, 1, 0, 4, 3 };
    private FUN_12454[] PTR_FUN_12454; //0x12454 (ST8)
    private byte[] DAT_1245C = new byte[] { 3, 1, 30, 90, 2, 2, 1, 50, 100, 3, 4, 3, 90, 120, 2, 2, 2, 88, 88, 3, 2, 3, 150, 100, 3, 1, 2, 120, 60, 3, 1, 3, 120, 40, 3, 1, 6, 120, 20, 2, 0, 3, 120, 0, 3, 0, 0, 0 };
    private FUN_1248C[] PTR_FUN_1248C; //0x1248C (ST8)
    private FUN_124A8[] PTR_FUN_124A8; //0x124A8 (ST8)
    private byte[] DAT_124E4 = new byte[] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 0 };
    private byte[] DAT_124F0 = new byte[] { 1, 5, 3, 7, 9, 2, 6, 10, 8, 3, 5, 9, 1, 4, 7, 8, 1, 3, 1, 5, 2, 3, 9, 2 };
    private FUN_12508[] PTR_FUN_12508; //0x12508 (ST8)
    private FUN_12518[] PTR_FUN_12518; //0x12518 (ST8)
    private FUN_1255C[] PTR_FUN_1255C; //0x1255C (ST8)
    private byte[] DAT_125C4 = new byte[] { 180, 84, 148, 116, 180, 148, 212, 116, 180, 44, 252, 44, 252, 116, 180, 188, 108, 188, 108, 116, 180, 116 };
    private byte[] DAT_125DC = new byte[] { 147, 146, 146, 147, 148, 146, 146, 146, 148, 146 };
    private byte[] DAT_125E8 = new byte[] { 4, 2, 1, 3, 0, 2, 9, 3, 0, 7, 1, 3, 0, 2, 1, 6, 128, 0, 9, 5, 128, 6, 4, 128, 5, 7, 3, 128, 2, 128, 8, 6, 9, 128, 128, 7, 4, 8, 128, 1, 0, 2, 1, 3 };
    private FUN_12614[] PTR_FUN_12614; //0x12614 (ST8)
    private FUN_1268C[] PTR_FUN_1268C; //0x1268C (ST8)
    private byte[] DAT_1262C = new byte[] { 3, 6, 7, 2, 0, 4 };
    private sbyte[] DAT_126A4 = new sbyte[10];
    private short[] DAT_128B0 = new short[0x100];
    private Tmd3ScriptableObject DAT_12AB0; //0x12AB0 (ST8)
    //private int DAT_12AB4; //0x12AB4 (ST8)
    private int DAT_12AB8; //0x12AB8 (ST8)
    //private int DAT_12ABC; //0x12ABC (ST8)
    private int DAT_12AC0; //0x12AC0 (ST8)
    private byte DAT_12AC4; //0x12AC4 (ST8)
    private byte DAT_12AC5; //0x12AC5 (ST8)
    private byte DAT_12AC6; //0x12AC6 (ST8)
    private byte DAT_12AC7; //0x12AC7 (ST8)
    //private int DAT_12AC8; //0x12AC8 (ST8)
    private int DAT_12ACC; //0x12ACC (ST8)
    //private int DAT_12AD0; //0x12AD0 (ST8)
    private int DAT_12AD4; //0x12AD4 (ST8)
    private UNK_12B68[] PTR_DAT_12B68 = new UNK_12B68[3]; //0x12B68 (ST8)
    private sbyte[] DAT_12B8C = new sbyte[16];
    private sbyte[] DAT_12B9C = new sbyte[16];
    private sbyte[] DAT_12BAC = new sbyte[16];
    //private int DAT_12BB8; //0x12BB8 (ST8)
    private int DAT_12BBC; //0x12BBC (ST8)
    //private int DAT_12BC0; //0x12BC0 (ST8)
    private int DAT_12BC4; //0x12BC4 (ST8) 
    private CriStatic DAT_12BC8; //0x12BC8 (ST8)
    private CriStatic DAT_12BCC; //0x12BCC (ST8)
    private CriStatic DAT_12BD0; //0x12BD0 (ST8)
    private CriStatic DAT_12BD4; //0x12BD4 (ST8)
    private CriStatic DAT_12BD8; //0x12BD8 (ST8)
    private CriStatic DAT_12BDC; //0x12BDC (ST8)
    private Vector3Int DAT_12BF0; //0x12BF0 (ST8)
    //private byte DAT_12BF8; //0x12BF8 (ST8)
    private sbyte[] DAT_12C00 = new sbyte[12];
    private byte[] DAT_12C1C = new byte[20]; // unknown size?
    private byte[] DAT_12CAC = new byte[20]; // unknown size?
    private byte[] DAT_12D3C = new byte[20];
    private int[] DAT_12D50 = new int[3];
    private int[] DAT_12D60 = new int[3];
    private sbyte[] DAT_12D70 = new sbyte[11];
    private sbyte[] DAT_12D80 = new sbyte[11];

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_11F90 = new FUN_11F90[3]
            {
                FUN_220,
                FUN_364,
                FUN_60068
            };
            PTR_FUN_12020 = new FUN_12020[4]
            {
                FUN_44C,
                FUN_5CC,
                FUN_630,
                FUN_60068
            };
            PTR_FUN_12048 = new FUN_12048[3]
            {
                FUN_6C0,
                FUN_780,
                FUN_60068
            };
            PTR_FUN_12054 = new FUN_12054[3]
            {
                FUN_860,
                FUN_8D4,
                FUN_60068
            };
            PTR_FUN_12080 = new FUN_12080[3]
            {
                FUN_974,
                FUN_A00,
                FUN_60068
            };
            PTR_FUN_1208C = new FUN_1208C[5]
            {
                FUN_ABC,
                FUN_D58,
                FUN_EE8,
                FUN_CA0,
                FUN_5FF98
            };
            PTR_FUN_120AC = new FUN_120AC[5]
            {
                FUN_1078,
                FUN_1108,
                FUN_1300,
                FUN_13B8,
                FUN_5FF98
            };
            PTR_FUN_12140 = new FUN_12140[7]
            {
                FUN_179C,
                FUN_1880,
                FUN_1A90,
                FUN_1B84,
                FUN_1C6C,
                FUN_1CC4,
                FUN_5FF98
            };
            PTR_FUN_12164 = new FUN_12164[5]
            {
                FUN_2CB8, 
                FUN_2D84, 
                FUN_2E9C, 
                FUN_2F38, 
                FUN_5FF98
            };
            PTR_FUN_121E4 = new FUN_121E4[4]
            {
                FUN_2FD0, 
                FUN_305C, 
                FUN_320C, 
                FUN_5FF98
            };
            PTR_FUN_121F4 = new FUN_121F4[17]
            {
                FUN_3574, 
                FUN_35F4, 
                FUN_3650,
                FUN_4004, 
                FUN_4294, 
                FUN_431C, 
                FUN_4364, 
                FUN_440C, 
                FUN_4494, 
                FUN_44DC, 
                FUN_4584, 
                FUN_492C, 
                FUN_4994, 
                FUN_4A00, 
                FUN_4A80, 
                FUN_4B00, 
                FUN_5FF98
            };
            PTR_FUN_122B0 = new FUN_122B0[6]
            {
                FUN_62C8,
                FUN_6350,
                FUN_6574,
                FUN_6914,
                FUN_6E70,
                FUN_5FF98
            };
            PTR_FUN_123D4 = new FUN_123D4[7]
            {
                FUN_88BC,
                FUN_8A0C, 
                FUN_9220, 
                FUN_93DC, 
                FUN_977C, 
                FUN_9990, 
                FUN_5FF98
            };
            PTR_FUN_12454 = new FUN_12454[2]
            {
                FUN_A7F8,
                FUN_A83C
            };
            PTR_FUN_1248C = new FUN_1248C[7]
            {
                FUN_AC10, 
                FUN_AEE8, 
                FUN_AFCC, 
                FUN_B024, 
                FUN_B064, 
                FUN_B22C, 
                FUN_5FF98
            };
            PTR_FUN_124A8 = new FUN_124A8[7]
            {
                FUN_B2F8, 
                FUN_B750, 
                FUN_B7BC, 
                FUN_BA3C, 
                FUN_BD28, 
                FUN_BE14, 
                FUN_C034
            };
            PTR_FUN_12508 = new FUN_12508[4]
            {
                FUN_D19C,
                FUN_D210,
                FUN_D424,
                FUN_60068
            };
            PTR_FUN_12518 = new FUN_12518[6]
            {
                FUN_DA9C, 
                FUN_DAFC, 
                FUN_DC00, 
                FUN_DD10, 
                FUN_DD9C, 
                FUN_5FF98
            };
            PTR_FUN_1255C = new FUN_1255C[6]
            {
                FUN_E42C, 
                FUN_E4B4, 
                FUN_E52C, 
                FUN_E5D8, 
                FUN_E684, 
                FUN_5FF98
            };
            PTR_FUN_12614 = new FUN_12614[6]
            {
                FUN_10240,
                FUN_102B8,
                FUN_105D4,
                FUN_10934,
                FUN_10A88,
                FUN_5FF98
            };
            PTR_FUN_1268C = new FUN_1268C[4]
            {
                FUN_11758,
                FUN_117C4,
                FUN_11884,
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
        GameManager.instance.DAT_AC = DAT_11DC8;
        GameManager.instance.DAT_B0 = DAT_119A4;
        GameManager.instance.DAT_46 = 8;

        for (int i = 0; i < DAT_11CD8.TRIGGERS.Length; i++)
        {
            puVar4 = LevelManager.instance.DAT_9EEC[i];
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

    //FUN_220 (ST8)
    private void FUN_220(CriParticle param1)
    {
        byte bVar1;
        uint uVar2;
        int iVar3;

        bVar1 = param1.DAT_2F;
        param1.flags |= 2;

        if (bVar1 < 3)
        {
            param1.DAT_56 = 0x38;
            param1.DAT_54 = 0x7f35;
        }
        else
        {
            if (bVar1 < 17 && 12 < bVar1)
            {
                param1.DAT_56 = 0x78;
                param1.DAT_54 = 0x7f37;
                param1.DAT_50.r = param1.DAT_69;
                param1.DAT_50.g = param1.DAT_6A;
                param1.DAT_50.b = param1.DAT_6B;
            }
            else
            {
                param1.DAT_56 = 0x38;
                param1.DAT_54 = 0x7f36;
                param1.vr.z = (short)(param1.DAT_69 << 4);
            }
        }

        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (GameManager.instance.DAT_9AA0 == 10)
            uVar2 = param1.DAT_2F + 17U;
        else
            uVar2 = param1.DAT_2F;

        iVar3 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11F08[uVar2 & 0xff]));

        if (iVar3 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_364 (ST8)
    private void FUN_364(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen.x += param1.DAT_40.x;
        param1.screen.y += param1.DAT_40.y;
        param1.screen.z += param1.DAT_40.z;
        iVar2 = param1.FUN_606D8();

        if (param1.DAT_2F < 2)
        {
            sVar1 = (sbyte)(param1.DAT_69 - 1);
            param1.DAT_69 = (byte)sVar1;

            if (sVar1 == 0)
                param1.DAT_3C = 2;
        }
        else
        {
            if (iVar2 == 1)
                param1.DAT_3C = 2;
        }
    }

    //FUN_44C (ST8)
    private void FUN_44C(CriParticle param1)
    {
        byte bVar1;
        ushort uVar2;
        int iVar3;

        bVar1 = param1.DAT_2F;
        param1.flags |= 2;

        if (bVar1 == 7)
        {
            uVar2 = 0x67;
            param1.DAT_56 = uVar2;
        }
        else
        {
            if (bVar1 < 8)
            {
                uVar2 = 0x27;

                if (bVar1 < 2)
                {
                    uVar2 = 0x67;
                    param1.DAT_56 = uVar2;
                }
                else
                    param1.DAT_56 = uVar2;
            }
            else if (bVar1 == 9)
            {
                uVar2 = 0x47;
                param1.DAT_56 = uVar2;
            }
            else
                param1.DAT_56 = 0x27;
        }

        bVar1 = param1.DAT_2F;

        if (bVar1 == 7)
            uVar2 = 0x7eff;
        else
        {
            if (bVar1 < 8)
            {
                if (bVar1 != 0)
                {
                    param1.DAT_54 = 0x7efe;
                    goto LAB_4F0;
                }

                uVar2 = 0x7eff;
            }
            else
            {
                uVar2 = 0x7efe;

                if (bVar1 == 9)
                    uVar2 = 0x7eff;
            }
        }

        param1.DAT_54 = uVar2;
        LAB_4F0:
        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (param1.DAT_2F == 9)
            param1.DAT_62 = param1.DAT_6B;

        if (param1.DAT_6A != 0)
        {
            param1.DAT_65 |= 3;
            param1.vr.x = 0;
            param1.DAT_4C = SceneManager.instance.cCamera;
            param1.vr.y = (short)(param1.DAT_6A << 4);
        }

        iVar3 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_11F9C[param1.DAT_2F]));

        if (iVar3 == 1)
            param1.DAT_3C = 3;
        else
            param1.DAT_3C = 1;

        if (param1.DAT_2F - 2 < 3)
            param1.DAT_3C = 2;
    }

    //FUN_5CC (ST8)
    private void FUN_5CC(CriParticle param1)
    {
        int iVar1;
        bool bVar2;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 3;

        if (param1.DAT_69 != 0)
        {
            bVar2 = InventoryManager.FUN_4A87C(3, param1.DAT_69);

            if (bVar2)
                param1.DAT_3C = 3;
        }
    }

    //FUN_630 (ST8)
    private void FUN_630(CriParticle param1)
    {
        bool bVar1;

        param1.FUN_606D8();

        if (param1.DAT_69 != 0)
        {
            bVar1 = InventoryManager.FUN_4A87C(3, param1.DAT_69);

            if (bVar1)
                param1.DAT_3C = 3;
        }
    }

    //FUN_6C0 (ST8)
    private void FUN_6C0(CriParticle param1)
    {
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_12030[param1.DAT_2F & 15]));
        param1.DAT_56 = 0x25;
        param1.DAT_54 = DAT_12034[param1.DAT_2F & 15];

        if ((param1.DAT_2F & 15) == 0)
            param1.DAT_50.a |= 2;

        param1.DAT_40.y = 10;
        param1.DAT_68 = 9;
        param1.flags |= 2;
        param1.DAT_62 = param1.DAT_69;
        param1.DAT_60 = param1.DAT_69;
        param1.DAT_3C++;
    }

    //FUN_780 (ST8)
    private void FUN_780(CriParticle param1)
    {
        short sVar1;
        int iVar2;

        iVar2 = param1.FUN_606D8();

        if (iVar2 == 1)
            param1.DAT_3C++;

        sVar1 = (short)(param1.DAT_40.y + param1.DAT_68);
        param1.DAT_40.y = sVar1;

        if ((param1.DAT_2F & 15) == 0)
            sVar1 = (short)(param1.screen.y - sVar1);
        else
            sVar1 = (short)(param1.screen.y + sVar1);

        param1.screen.y = sVar1;

        if (10000 < param1.screen.y)
            param1.DAT_3C++;
    }

    //FUN_860 (ST8)
    private void FUN_860(CriParticle param1)
    {
        int iVar1;

        param1.DAT_56 = 0xfa;
        param1.DAT_54 = 0x7f70;
        param1.DAT_62 = param1.DAT_69;
        param1.flags |= 2;
        param1.DAT_60 = param1.DAT_68;
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8012fd04));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_8D4 (ST8)
    private void FUN_8D4(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_974 (ST8)
    private void FUN_974(CriParticle param1)
    {
        int iVar1;

        param1.DAT_56 = 0x25;
        param1.DAT_54 = 0x7efd;
        param1.flags |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.DAT_50.a |= 2;
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_12060[param1.DAT_2F]));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_A00 (ST8)
    private void FUN_A00(CriParticle param1)
    {
        int iVar1;

        param1.screen.x += param1.DAT_40.x;
        param1.screen.y += param1.DAT_40.y;
        param1.screen.z += param1.DAT_40.z;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_ABC (ST8)
    private void FUN_ABC(CriInteract param1)
    {
        sbyte sVar1;
        ushort uVar2;
        ushort uVar3;
        CriPlayer oVar4;
        byte bVar5;
        uint uVar6;
        short sVar7;
        uint uVar8;

        oVar4 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        sVar1 = (sbyte)oVar4.DAT_1D7;
        param1.BDAT_08 = (byte)sVar1;

        if ((oVar4.DAT_1C0 & 8) != 0)
        {
            bVar5 = (byte)(sVar1 - 1);
            param1.BDAT_08 = bVar5;

            if ((bVar5 << 0x18) < 0)
                param1.BDAT_08 = 0;
        }

        if (oVar4.DAT_3D == 5)
        {
            if (param1.BDAT_08 == 0)
                uVar6 = oVar4.frameNum * 0x16U;
            else
                uVar6 = (uint)oVar4.frameNum << 5;
        }
        else
        {
            if (oVar4.DAT_3D != 1)
            {
                param1.BDAT_16 = 0;
                goto LAB_BAC;
            }

            if (param1.BDAT_08 == 0)
                uVar6 = oVar4.frameNum * 0x16U;

            uVar6 = (uint)oVar4.frameNum << 5;
        }

        uVar8 = oVar4.frameCount + 1U & 0xff;

        if (uVar8 == 0)
            return; //0x1c00

        param1.BDAT_16 = (byte)(uVar6 / uVar8);
        LAB_BAC:
        uVar2 = oVar4.DAT_140;
        oVar4.DAT_3C = 4;
        oVar4.DAT_3D = 0;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        oVar4.DAT_152 = 2;
        uVar3 = oVar4.DAT_12C;
        oVar4.DAT_40.z = 0;
        oVar4.DAT_140 = (ushort)(uVar2 | 0x8000);
        bVar5 = oVar4.DAT_174;
        oVar4.DAT_12C = (ushort)(uVar3 | 0x10);
        oVar4.DAT_174 = (byte)(bVar5 & 0x7f);
        InventoryManager.FUN_4A7E8(1, 2, true);
        InventoryManager.FUN_4A7E8(2, 0x12, true);
        param1.DAT_0A = param1.DAT_07;
        param1.DAT_07 = 0x80;
        param1.DAT_03 = (sbyte)(param1.DAT_02 + 1);

        if (param1.DAT_02 == 0)
            sVar7 = (short)(oVar4.screen.y + param1.DAT_0A * -0x1a9);
        else
            sVar7 = (short)(oVar4.screen.y + param1.DAT_0A * 0x1a9);

        param1.DAT_0C = sVar7;
    }

    //FUN_D58 (ST8)
    private void FUN_D58(CriInteract param1)
    {
        short sVar1;
        CriSkinned oVar2;
        short sVar3;
        Matrix3x3 auStack56;
        Vector3Int local_18;

        oVar2 = SceneManager.instance.skinnedObjects[10];
        auStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018da38), 1, param1.BDAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -19;
        }
        else
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018e8b8), 1, param1.BDAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -13;
        }

        param1.SDAT_10 = sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_EE8 (ST8)
    private void FUN_EE8(CriInteract param1)
    {
        short sVar1;
        CriSkinned oVar2;
        short sVar3;
        Matrix3x3 auStack56;
        Vector3Int local_18;

        oVar2 = SceneManager.instance.skinnedObjects[10];
        auStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018e178), 1, param1.BDAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 19;
        }
        else
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018f340), 1, param1.BDAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack56, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 13;
        }

        param1.SDAT_10 = sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_CA0 (ST8)
    private void FUN_CA0(CriInteract param1)
    {
        byte bVar1;
        short sVar2;
        ushort uVar3;
        CriPlayer oVar4;

        oVar4 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar4.DAT_3C = 1;
        oVar4.DAT_3D = 0;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        sVar2 = param1.DAT_0C;
        oVar4.DAT_140 &= 0x7fff;
        uVar3 = oVar4.DAT_12C;
        oVar4.DAT_152 = 0;
        oVar4.screen.y = sVar2;
        bVar1 = oVar4.DAT_174;
        oVar4.DAT_12C = (ushort)(uVar3 & 0xffef);
        oVar4.DAT_174 = (byte)(bVar1 | 0x80);
        InventoryManager.FUN_4A7E8(1, 2, false);
        InventoryManager.FUN_4A7E8(2, 0x12, false);
        oVar4.FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(oVar4.DAT_220), 1, 10, oVar4.DAT_220);
        param1.DAT_03++;
    }

    //FUN_1078 (ST8)
    private void FUN_1078(CriInteract param1)
    {
        int puVar1;
        uint uVar2;
        int puVar3;

        puVar3 = 0;
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
        uVar2 = 0;
        puVar1 = puVar3;

        do
        {
            param1.SET_OFFSET_08(puVar1 + 4, 0xff);
            uVar2++;
            puVar1 = puVar3 + (int)uVar2;
        } while (uVar2 < 4);

        param1.BDAT_0A = 0;
        param1.BDAT_09 = 0;
        param1.SET_OFFSET_08(puVar3, 0);
        param1.DAT_03 = 1;
    }

    //FUN_1108 (ST8)
    private void FUN_1108(CriInteract param1)
    {
        sbyte sVar1;

        //FUN_13F8

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
            sVar1 = (sbyte)(param1.GET_OFFSET_08(0) - 1);

            if (param1.GET_OFFSET_08(0) == 0)
                sVar1 = 4;

            param1.SET_OFFSET_08(0, (byte)sVar1);
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

    //FUN_1300 (ST8)
    private void FUN_1300(CriInteract param1)
    {
        bool bVar1;
        int iVar2;
        int pcVar3;
        uint uVar4;
        int iVar5;
        int iVar6;

        iVar6 = 0;
        //FUN_13F8
        bVar1 = false;
        uVar4 = 0;
        iVar2 = iVar6;

        do
        {
            pcVar3 = (int)uVar4;
            uVar4++;

            if (param1.GET_OFFSET_08(iVar2 + 4) != DAT_120A8[pcVar3])
            {
                bVar1 = true;
                break;
            }

            iVar2 = iVar6 + (int)uVar4;
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

    //FUN_13B8 (ST8)
    private void FUN_13B8(CriInteract param1)
    {
        bool bVar1;

        //FUN_13F8
        bVar1 = InventoryManager.FUN_4A87C(3, 0x30);

        if (bVar1)
            param1.DAT_03 = 4;
    }

    //FUN_179C (ST8)
    private void FUN_179C(CriInteract param1)
    {
        sbyte sVar1;
        bool bVar3;
        uint uVar4;
        uint uVar5;

        InventoryManager.FUN_4A7E8(2, 10, false);
        InventoryManager.FUN_4A7E8(2, 9, false);
        InventoryManager.FUN_4A7E8(2, 0x12, false);
        InventoryManager.FUN_4A7E8(2, 11, false);
        param1.DAT_08 = 0;
        param1.DAT_0A = 0;
        param1.DAT_0C = 0;
        uVar4 = 0;

        do
        {
            DAT_126A4[uVar4] = -1;
            uVar5 = uVar4 + 1;
            uVar4 = uVar5;
        } while (uVar5 < 5);

        DAT_126A4[7] = 0;
        DAT_126A4[6] = 0;
        DAT_126A4[5] = 0;
        DAT_126A4[9] = 0;
        DAT_126A4[8] = 0;
        bVar3 = InventoryManager.FUN_4A87C(3, 0x20);
        sVar1 = 3;

        if (!bVar3)
            sVar1 = 1;

        param1.DAT_03 = sVar1;
    }

    //FUN_1880 (ST8)
    private void FUN_1880(CriInteract param1)
    {
        short sVar1;

        //FUN_1CD0

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
            DAT_126A4[DAT_126A4[5]] = (sbyte)(param1.DAT_08 + param1.DAT_0A * 5);

            if (DAT_126A4[5] == 4)
                param1.DAT_03 = 2;

            DAT_126A4[5]++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            if (DAT_126A4[5] == 0)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_03 = 5;
            }
            else
            {
                DAT_126A4[DAT_126A4[5]] = -1;
                DAT_126A4[5]--;
            }

            GameManager.instance.FUN_5C94C(null, 147);
        }
    }

    //FUN_1A90 (ST8)
    private void FUN_1A90(CriInteract param1)
    {
        bool bVar1;

        if (DAT_126A4[6] < 31)
        {
            if (DAT_126A4[6] == 0)
            {
                InventoryManager.FUN_4A7E8(3, 0x22, false);
                InventoryManager.FUN_4A7E8(3, 0x23, false);
                InventoryManager.FUN_4A7E8(3, 0x24, false);

                if (param1.DAT_02 == 0)
                {
                    FUN_2380();
                    FUN_24A0();
                }
                else
                {
                    if (param1.DAT_02 == 1)
                    {
                        FUN_2550();
                        FUN_25FC();
                    }
                }
            }

            //FUN_1CD0
            DAT_126A4[6]++;
        }

        bVar1 = InventoryManager.FUN_4A87C(3, 0x21);

        if (bVar1)
        {
            param1.DAT_03 = 3;
            DAT_126A4[6] = 0;
        }
    }

    //FUN_1B84 (ST8)
    private void FUN_1B84(CriInteract param1)
    {
        sbyte sVar1;
        short sVar2;
        bool bVar3;
        int iVar4;

        if (param1.DAT_0C == 0)
            if (InventoryManager.FUN_4A87C(3, 0x24) || InventoryManager.FUN_4A87C(3, 0x23))
                InventoryManager.FUN_4A7E8(2, 10, true);

        //FUN_2080
        sVar2 = (short)(param1.DAT_0C + 1);
        param1.DAT_0C = sVar2;

        if (sVar2 == 150)
        {
            bVar3 = InventoryManager.FUN_4A87C(2, 10);
            sVar1 = 5;

            if (!bVar3)
                sVar1 = 4;

            param1.DAT_03 = sVar1;

            if (param1.DAT_0C == 150)
            {
                bVar3 = InventoryManager.FUN_4A87C(2, 10);

                if (!bVar3)
                    iVar4 = 148;
                else
                    iVar4 = 149;

                GameManager.instance.FUN_5C94C(null, iVar4);
            }
        }
    }

    //FUN_1C6C (ST8)
    private void FUN_1C6C(CriInteract param1)
    {
        //FUN_2080

        if (29 < DAT_126A4[6])
        {
            param1.DAT_03 = 5;
            DAT_126A4[6] = 0;
        }

        DAT_126A4[6]++;
    }

    //FUN_1CC4 (ST8)
    private void FUN_1CC4(CriInteract param1)
    {
        param1.DAT_03 = 5;
    }

    //FUN_2380 (ST8)
    private void FUN_2380()
    {
        int pcVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;
        bool bVar5;
        byte[] local_18;
        
        bVar5 = false;
        local_18 = new byte[] { 5, 7, 0, 3, 6, 0, 0, 0, 5, 8, 1, 0, 4, 0, 0, 0 };
        pcVar1 = 0;
        uVar4 = 0;

        do
        {
            uVar2 = uVar4 + 1;

            if (DAT_126A4[pcVar1] != local_18[uVar4])
            {
                bVar5 = true;
                break;
            }

            pcVar1 = (int)uVar4 + 1;
            uVar4 = uVar2;
        } while (uVar2 < 5);

        if (bVar5)
        {
            pcVar1 = 0;
            uVar4 = 0;

            do
            {
                if (DAT_126A4[pcVar1] != local_18[(int)uVar4 + 8])
                {
                    InventoryManager.FUN_4A7E8(2, 10, true);
                    iVar3 = 149;
                    goto LAB_2488;
                }

                uVar2 = uVar4 + 1;
                pcVar1 = (int)uVar4 + 1;
                uVar4 = uVar2;
            } while (uVar2 < 5);

            iVar3 = 0x12;
        }
        else
            iVar3 = 9;

        InventoryManager.FUN_4A7E8(2, (uint)iVar3, true);
        iVar3 = 148;
        LAB_2488:
        GameManager.instance.FUN_5C94C(null, iVar3);
    }

    //FUN_24A0 (ST8)
    private void FUN_24A0()
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
                goto LAB_2538;
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

                goto LAB_2538;
            }

            if (bVar1 != 2)
            {
                uVar3 = 0x23;
                goto LAB_2538;
            }

            bVar2 = InventoryManager.FUN_4A87C(2, 0x12);

            if (bVar2)
            {
                uVar3 = 0x22;
                goto LAB_2538;
            }
        }

        uVar3 = 0x23;
        LAB_2538:
        InventoryManager.FUN_4A7E8(3, uVar3, true);
    }

    //FUN_2550 (ST8)
    private void FUN_2550()
    {
        int pcVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;
        byte[] local_10;

        local_10 = new byte[] { 3, 1, 4, 1, 5, 148, 0 };
        pcVar1 = 0;
        uVar2 = 0;

        do
        {
            if (DAT_126A4[pcVar1] != local_10[uVar2])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                iVar3 = 149;
                goto LAB_25E4;
            }

            uVar4 = uVar2 + 1;
            pcVar1 = (int)uVar4;
            uVar2 = uVar4;
        } while (uVar4 < 5);

        InventoryManager.FUN_4A7E8(2, 9, true);
        iVar3 = 148;
        LAB_25E4:
        GameManager.instance.FUN_5C94C(null, iVar3);
    }

    //FUN_25FC (ST8)
    private void FUN_25FC()
    {
        bool bVar1;
        uint uVar2;

        if (GameManager.instance.DAT_9ADF == 0)
            uVar2 = 0x24;
        else
        {
            if (GameManager.instance.DAT_9ADF == 3)
            {
                bVar1 = InventoryManager.FUN_4A87C(2, 9);

                if (bVar1)
                    uVar2 = 0x22;
                else
                    uVar2 = 0x23;
            }
            else
                uVar2 = 0x23;
        }

        InventoryManager.FUN_4A7E8(3, uVar2, true);
    }

    //FUN_2CB8 (ST8)
    private void FUN_2CB8(CriInteract param1)
    {
        CriBone oVar1;
        CriStatic oVar2;

        oVar1 = Utilities.FUN_601C8(SceneManager.instance.skinnedObjects[param1.DAT_04].skeleton, 3) as CriBone;
        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            param1.PDAT_08 = oVar2;
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8017e000);
            oVar2.DAT_48 = 1;
            oVar2.screen = new Vector3Int(-50, 200, 80);
            oVar2.DAT_40 = oVar1;
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.cCollider = null;
            oVar2.flags |= 2;
        }

        param1.DAT_03++;
    }

    //FUN_2D84 (ST8)
    private void FUN_2D84(CriInteract param1)
    {
        bool bVar1;
        CriStatic oVar2;
        CriBone oVar3;
        Vector3Int local_18;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

        if (bVar1)
        {
            oVar2 = (CriStatic)param1.PDAT_08;
            oVar3 = Utilities.FUN_601C8(SceneManager.instance.skinnedObjects[param1.DAT_04].skeleton, 3) as CriBone;
            oVar2.DAT_40 = null;
            local_18 = Utilities.ApplyMatrixSV(ref oVar3.cTransform.rotation, ref oVar2.screen);
            oVar2.screen.x += local_18.x;
            oVar2.screen.y += local_18.y;
            oVar2.screen.z += local_18.z;
            oVar2.vr.x = oVar3.vr.x;
            oVar2.vr.y = oVar3.vr.y;
            oVar2.vr.z = oVar3.vr.z + 0x400;
            param1.VDAT_0C = new Vector3Int(0, -40, 80);
            param1.DAT_03++;
        }
    }

    //FUN_2E9C (ST8)
    private void FUN_2E9C(CriInteract param1)
    {
        CriStatic oVar2;

        oVar2 = (CriStatic)param1.PDAT_08;
        param1.VDAT_0C.x += 3;
        param1.VDAT_0C.y += 20;
        oVar2.screen.x += param1.VDAT_0C.x;
        oVar2.screen.y += param1.VDAT_0C.y;
        oVar2.screen.z += param1.VDAT_0C.z;
        oVar2.vr.x -= 1000;

        if (0 < oVar2.screen.y)
        {
            oVar2.screen.y = 0;
            param1.VDAT_0C.y = 400;
            oVar2.vr.x = 0;
            oVar2.vr.z = 0xc00;
            param1.DAT_03++;
        }
    }

    //FUN_2F38 (ST8)
    private void FUN_2F38(CriInteract param1)
    {
        param1.VDAT_0C.y -= 10;
        param1.PDAT_08.vr.y += param1.VDAT_0C.y;

        if (param1.VDAT_0C.y == 0)
            param1.DAT_03++;
    }

    //FUN_2FD0 (ST8)
    private void FUN_2FD0(CriInteract param1)
    {
        int puVar1;
        uint uVar2;

        //...
        uVar2 = 0;
        puVar1 = 0;

        do
        {
            DAT_128B0[puVar1] = 0x421;
            uVar2++;
            puVar1++;
        } while (uVar2 < 0x100);

        param1.DAT_03++;
    }

    //FUN_305C (ST8)
    private void FUN_305C(CriInteract param1)
    {
        bool bVar1;
        CriSkinned oVar2;
        CriInteract puVar3;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x38);
        oVar2 = SceneManager.instance.skinnedObjects[10];

        if (bVar1)
        {
            //...
            oVar2.DAT_174 &= 0x7f;
            FUN_3324(param1);

            if (!InventoryManager.FUN_4A87C(0, 0xda) && 
               (InventoryManager.FUN_4A87C(11, 1) || InventoryManager.FUN_4A87C(11, 2) || 
                InventoryManager.FUN_4A87C(11, 3) || InventoryManager.FUN_4A87C(11, 4) || 
                InventoryManager.FUN_4A87C(11, 5) || InventoryManager.FUN_4A87C(11, 6) || 
                InventoryManager.FUN_4A87C(11, 7) || InventoryManager.FUN_4A87C(11, 8) || 
                InventoryManager.FUN_4A87C(11, 9) || InventoryManager.FUN_4A87C(11, 10)))
            {
                puVar3 = SceneManager.instance.DAT_8FFC[4];
                puVar3.DAT_01 = 28;
                puVar3.DAT_00 = 1;
                puVar3.DAT_02 = 1;
                puVar3.DAT_04 = 8;
                InventoryManager.FUN_4A7E8(3, 0x39, true);
            }

            param1.DAT_03++;
        }
    }

    //FUN_320C (ST8)
    private void FUN_320C(CriInteract param1)
    {
        CriBone oVar1;
        CriPlayer oVar2;
        bool bVar3;

        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar1 = (CriBone)Utilities.FUN_601C8(oVar2.skeleton, 3);

        if (param1.BDAT_08 != oVar2.DAT_240 || oVar1.cMesh == DAT_12AB0)
            FUN_3324(param1);

        bVar3 = InventoryManager.FUN_4A87C(3, 0x38);

        if (!bVar3)
        {
            //...
            oVar2.DAT_174 |= 0x80;

            if (oVar2.DAT_240 >> 4 != 0)
            {
                oVar1 = (CriBone)Utilities.FUN_601C8(oVar2.skeleton, 3);
                oVar1.cMesh = DAT_12AB0;
            }

            param1.DAT_03--;
        }
    }

    //FUN_3324 (ST8)
    private void FUN_3324(CriInteract param1)
    {
        CriPlayer oVar1;
        CriBone oVar2;
        uint uVar3;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar2 = Utilities.FUN_601C8(oVar1.skeleton, 3) as CriBone;

        if (oVar1.DAT_240 >> 4 == 0)
            DAT_12AB0 = oVar2.cMesh;
        else
        {
            param1.BDAT_08 = oVar1.DAT_240;
            uVar3 = oVar1.DAT_240 & 0xfU;

            if (GameManager.instance.DAT_A2D3 == 3)
                uVar3 += 4;

            DAT_12AB0 = oVar2.cMesh;
            oVar2.cMesh = (Tmd3ScriptableObject)Utilities.GetRamObject(DAT_121D8[(oVar1.DAT_240 >> 4) - 1][uVar3]);
        }
    }

    //FUN_3574 (ST8)
    private void FUN_3574(CriInteract param1)
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
        param1.DAT_10 = 0;
        param1.DAT_11 = 0;
        param1.DAT_12 = 0;
        param1.DAT_13 = 0;
        param1.DAT_14 = 0;
        param1.DAT_15 = 0;
        param1.BDAT_16 = 0;
        param1.DAT_17 = 0;
        param1.UDAT_18 = 0x102;
        param1.DAT_04 = 0;
        param1.DAT_05 = 0;
        param1.DAT_06 = 0;
        param1.DAT_07 = 0;
        param1.DAT_03++;
    }

    //FUN_35F4 (ST8)
    private void FUN_35F4(CriInteract param1)
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

    //FUN_3650 (ST8)
    private void FUN_3650(CriInteract param1)
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
                bVar3 = (byte)(param1.BDAT_08 << (6 - param1.DAT_13 & 31) & 0xc0);
                bVar1 = (byte)(param1.BDAT_0A << (6 - (int)uVar4 & 31) & 0xc0);
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
                            param1.BDAT_0C = 0xf8;
                            param1.DAT_1A &= 0x3e;
                            param1.DAT_04 &= 0x3e;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 1);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 1);
                            return;
                        case 2:
                            param1.DAT_0D = 0xf3;
                            param1.BDAT_0C = 0xf0;
                            param1.DAT_1A &= 0x3c;
                            param1.DAT_04 &= 0x3c;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 3);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 3);
                            return;
                        case 3:
                            param1.DAT_0D = 0xe7;
                            param1.BDAT_0C = 0xf0;
                            param1.DAT_1A &= 0x38;
                            param1.DAT_04 &= 0x38;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 7);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 7);
                            return;
                        case 4:
                            param1.DAT_0D = 0xcf;
                            param1.BDAT_0C = 0xe0;
                            param1.DAT_1A &= 0x30;
                            param1.DAT_04 &= 0x30;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 15);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 15);
                            return;
                        case 5:
                            param1.DAT_0D = 0x9f;
                            param1.BDAT_0C = 0xc0;
                            param1.DAT_1A &= 0x20;
                            param1.DAT_04 &= 0x20;
                            param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 31);
                            param1.DAT_06 = (byte)param1.DAT_13;
                            param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 31);
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

                if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 4 < param1.DAT_13)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                        return;

                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_03 = 7;
                    uVar4 = (byte)param1.DAT_13;
                    param1.DAT_05 = (byte)(param1.DAT_0B >> 2);
                    param1.DAT_1B = (byte)(param1.BDAT_09 >> 2);
                    bVar3 = (byte)(param1.BDAT_09 << (6 - param1.DAT_13 & 31) & 0xc0);
                    bVar1 = (byte)(param1.DAT_0B << (6 - (int)uVar4 & 31) & 0xc0);

                    if (5 < uVar4)
                    {
                        param1.DAT_1B |= bVar3;
                        param1.DAT_05 |= bVar1;
                        return;
                    }

                    switch (uVar4)
                    {
                        case 0:
                            param1.DAT_0F = 0xfc;
                            param1.BDAT_0E = 0xfc;
                            param1.DAT_1B |= (byte)(param1.BDAT_09 << 6);
                            param1.DAT_05 |= (byte)(param1.DAT_0B << 6);
                            return;
                        case 1:
                            param1.DAT_0F = 0xf9;
                            param1.BDAT_0E = 0xf8;
                            param1.DAT_1B &= 0x3e;
                            param1.DAT_05 &= 0x3e;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 1);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 1);
                            return;
                        case 2:
                            param1.DAT_0F = 0xf3;
                            param1.BDAT_0E = 0xf0;
                            param1.DAT_1B &= 0x3c;
                            param1.DAT_05 &= 0x3c;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 3);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 3);
                            return;
                        case 3:
                            param1.DAT_0F = 0xe7;
                            param1.BDAT_0E = 0xf0;
                            param1.DAT_1B &= 0x38;
                            param1.DAT_05 &= 0x38;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 7);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 7);
                            return;
                        case 4:
                            param1.DAT_0F = 0xcf;
                            param1.BDAT_0E = 0xe0;
                            param1.DAT_1B &= 0x30;
                            param1.DAT_05 &= 0x30;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 15);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 15);
                            return;
                        case 5:
                            param1.DAT_0F = 0x9f;
                            param1.BDAT_0E = 0xc0;
                            param1.DAT_1B &= 0x20;
                            param1.DAT_05 &= 0x20;
                            param1.DAT_1B |= (byte)(bVar3 | param1.BDAT_09 & 31);
                            param1.DAT_05 |= (byte)(bVar1 | param1.DAT_0B & 31);
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

                if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0 && param1.DAT_13 != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_13--;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0 || 5 < param1.DAT_13)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0x20a0) == 0)
                        return;

                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.DAT_03 = 10;
                    uVar4 = (byte)param1.DAT_13;
                    bVar3 = (byte)(param1.BDAT_08 << (6 - param1.DAT_13 & 31) & 0xc0);
                    bVar1 = (byte)(param1.BDAT_0A << (6 - (int)uVar4 & 31) & 0xc0);
                    param1.DAT_04 = (byte)(param1.BDAT_0A >> 2);
                    param1.DAT_1A = (byte)(param1.BDAT_08 >> 2);

                    if (uVar4 < 7)
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
                                param1.DAT_0C = 0xf8;
                                param1.DAT_1A &= 0x3e;
                                param1.DAT_04 &= 0x3e;
                                param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 1);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 1);
                                return;
                            case 2:
                                param1.DAT_0D = 0xf3;
                                param1.DAT_0C = 0xf0;
                                param1.DAT_1A &= 0x3c;
                                param1.DAT_04 &= 0x3c;
                                param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 3);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 3);
                                return;
                            case 3:
                                param1.DAT_0D = 0xe7;
                                param1.DAT_0C = 0xf0;
                                param1.DAT_1A &= 0x38;
                                param1.DAT_04 &= 0x38;
                                param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 7);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 7);
                                return;
                            case 4:
                                param1.DAT_0D = 0xcf;
                                param1.DAT_0C = 0xe0;
                                param1.DAT_1A &= 0x30;
                                param1.DAT_04 &= 0x30;
                                param1.DAT_1A |= (byte)(bVar3 | param1.BDAT_08 & 15);
                                param1.DAT_06 = (byte)param1.DAT_13;
                                param1.DAT_04 |= (byte)(bVar1 | param1.BDAT_0A & 15);
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

                if (bVar1 == 3) goto LAB_376C;
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

        LAB_376C:
        param1.DAT_19 = bVar1;
    }

    //FUN_4004 (ST8)
    private void FUN_4004(CriInteract param1)
    {
        byte bVar1;

        if (param1.BDAT_16 < 7)
        {
            switch (param1.BDAT_16)
            {
                case 0:
                    GameManager.instance.FUN_5C94C(null, 152);
                    //DAT_12AB4 = 60;
                    DAT_12AB8 = 100;
                    //DAT_12ABC = 200;
                    DAT_12AC0 = 1;
                    param1.DAT_17 = 0;
                    param1.BDAT_16 = 1;
                    goto LAB_4250;
                case 1:
                    DAT_12AB8 -= 8;
                    DAT_12AC0 += 0x10;
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (3 < bVar1)
                    {
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    //...
                    goto LAB_4250;
                case 2:
                    //FUN_5DA4
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (31 < bVar1)
                    {
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    goto LAB_4250;
                case 3:
                    //FUN_5DA4
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (20 < bVar1)
                    {
                        GameManager.instance.FUN_5C94C(null, 153);
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    goto LAB_4250;
                case 4:
                    //...
                    bVar1 = (byte)(param1.DAT_17 + 2);
                    param1.DAT_17 = (sbyte)bVar1;

                    if (130 < bVar1)
                    {
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    goto LAB_4250;
                case 5:
                    //FUN_5DA4
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (50 < bVar1)
                    {
                        param1.DAT_17 = 0;
                        param1.BDAT_16++;
                    }

                    goto LAB_4250;
                case 6:
                    //FUN_5DA4
                    bVar1 = (byte)param1.DAT_17;
                    param1.DAT_17 = (sbyte)(bVar1 + 1);

                    if (20 < bVar1)
                    {
                        param1.BDAT_16 = 0;
                        param1.DAT_17 = 0;
                        param1.DAT_03 = 16;
                        InventoryManager.FUN_4A7E8(2, 9, true);
                    }

                    goto LAB_4250;
            }
        }

        LAB_4250:;
        //FUN_EE100
    }

    //FUN_4294 (ST8)
    private void FUN_4294(CriInteract param1)
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

        if (7 < param1.DAT_16)
        {
            GameManager.instance.FUN_5C94C(null, 151);
            param1.DAT_17 = 0;
            param1.BDAT_16 = (byte)param1.DAT_13;
            param1.DAT_03++;
        }
    }

    //FUN_431C (ST8)
    private void FUN_431C(CriInteract param1)
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

    //FUN_4364 (ST8)
    private void FUN_4364(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
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
            bVar3 = FUN_4BDC(param1);
            sVar2 = 3;

            if (!bVar3)
                sVar2 = 2;

            param1.DAT_03 = sVar2;
        }
    }

    //FUN_440C (ST8)
    private void FUN_440C(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;
        param1.DAT_10 -= 2;

        if (2 < bVar1)
        {
            param1.DAT_17 = 0;
            param1.DAT_16++;
        }

        if (7 < param1.BDAT_16)
        {
            GameManager.instance.FUN_5C94C(null, 151);
            param1.DAT_17 = 0;
            param1.BDAT_16 = (byte)param1.DAT_13;
            param1.DAT_03++;
        }
    }

    //FUN_4494 (ST8)
    private void FUN_4494(CriInteract param1)
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

    //FUN_44DC (ST8)
    private void FUN_44DC(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
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
            bVar3 = FUN_4BDC(param1);
            sVar2 = 3;

            if (!bVar3)
                sVar2 = 2;

            param1.DAT_03 = sVar2;
        }
    }

    //FUN_4584 (ST8)
    private void FUN_4584(CriInteract param1)
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
                        param1.DAT_03 = 11;
                        uVar7 = (byte)param1.DAT_13;
                        bVar5 = (byte)(param1.BDAT_09 << (6 - param1.DAT_13 & 31) & 0xc0);
                        bVar6 = (byte)(param1.DAT_0B << (6 - (int)uVar7 & 31) & 0xc0);
                        param1.DAT_05 = (byte)(param1.DAT_0B >> 2);
                        param1.DAT_1B = (byte)(param1.BDAT_09 >> 2);

                        if (uVar7 < 7)
                        {
                            switch (uVar7)
                            {
                                case 0:
                                    param1.DAT_0F = 0xfc;
                                    param1.BDAT_0E = 0xfc;
                                    param1.DAT_1B |= (byte)(param1.BDAT_09 << 6);
                                    param1.DAT_05 |= (byte)(param1.DAT_0B << 6);
                                    bVar1 = param1.DAT_1B;
                                    bVar2 = param1.DAT_05;
                                    bVar3 = param1.DAT_1A;
                                    bVar4 = param1.DAT_04;
                                    param1.DAT_1B = bVar1;
                                    param1.DAT_05 = bVar2;
                                    param1.DAT_04 &= 0x3f;
                                    param1.DAT_1A &= 0x3f;
                                    param1.DAT_1B &= 0x3f;
                                    param1.DAT_04 |= (byte)(bVar2 & 0xc0);
                                    param1.DAT_1A |= (byte)(bVar1 & 0xc0);
                                    param1.DAT_05 &= 0x3f;
                                    param1.DAT_1B |= (byte)(bVar3 & 0xc0);
                                    param1.DAT_05 |= (byte)(bVar4 & 0xc0);
                                    return;
                                case 1:
                                    param1.DAT_0F = 0xf9;
                                    param1.BDAT_0E = 0xf8;
                                    param1.DAT_1B &= 0x3e;
                                    param1.DAT_05 &= 0x3e;
                                    bVar4 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 1);
                                    bVar3 = (byte)(param1.DAT_05 | bVar6 | param1.DAT_0B & 1);
                                    LAB_01:
                                    bVar1 = param1.DAT_1A;
                                    bVar2 = param1.DAT_04;
                                    param1.DAT_1B = bVar4;
                                    param1.DAT_05 = bVar3;
                                    param1.DAT_04 &= 0x3f;
                                    param1.DAT_1A = (byte)(bVar1 & 0x3f);
                                    param1.DAT_1B = (byte)(bVar4 & 0x3f);
                                    param1.DAT_04 |= (byte)(bVar3 & 0xc0);
                                    param1.DAT_1A |= (byte)(bVar4 & 0xc0);
                                    param1.DAT_05 &= 0x3f;
                                    param1.DAT_1B |= (byte)(bVar1 & 0xc0);
                                    param1.DAT_05 |= (byte)(bVar2 & 0xc0);
                                    return;
                                case 2:
                                    param1.DAT_0F = 0xf3;
                                    param1.BDAT_0E = 0xf0;
                                    param1.DAT_1B &= 0x3c;
                                    param1.DAT_05 &= 0x3c;
                                    bVar4 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 3);
                                    bVar3 = (byte)(param1.DAT_05 | bVar6 | param1.DAT_0B & 3);
                                    goto LAB_01;
                                case 3:
                                    param1.DAT_0F = 0xe7;
                                    param1.BDAT_0E = 0xf0;
                                    param1.DAT_1B &= 0x38;
                                    param1.DAT_05 &= 0x38;
                                    bVar4 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 7);
                                    bVar3 = (byte)(param1.DAT_05 | bVar6 | param1.DAT_0B & 7);
                                    goto LAB_01;
                                case 4:
                                    param1.DAT_0F = 0xcf;
                                    param1.BDAT_0E = 0xe0;
                                    param1.DAT_1B &= 0x30;
                                    param1.DAT_05 &= 0x30;
                                    bVar4 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 15);
                                    bVar3 = (byte)(param1.DAT_05 | bVar6 | param1.DAT_0B & 15);
                                    goto LAB_01;
                                case 5:
                                    param1.DAT_0F = 0x9f;
                                    param1.BDAT_0E = 0xc0;
                                    param1.DAT_1B &= 0x20;
                                    param1.DAT_05 &= 0x20;
                                    bVar4 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 31);
                                    bVar3 = (byte)(param1.DAT_05 | bVar6 | param1.DAT_0B & 31);
                                    goto LAB_01;
                                case 6:
                                    param1.DAT_0F = 0x3f;
                                    param1.DAT_1B = 0;
                                    param1.DAT_05 = 0;
                                    param1.BDAT_0E = 0;
                                    bVar4 = (byte)(param1.DAT_1B | bVar5 | param1.BDAT_09 & 63);
                                    bVar3 = (byte)(param1.DAT_05 | bVar6 | param1.DAT_0B & 63);
                                    goto LAB_01;
                            }
                        }

                        bVar1 = param1.DAT_1B;
                        bVar2 = param1.DAT_05;
                        bVar3 = param1.DAT_1A;
                        bVar4 = param1.DAT_04;
                        param1.DAT_1B = (byte)(bVar1 | bVar5);
                        param1.DAT_05 = (byte)(bVar2 | bVar6);
                        param1.DAT_04 &= 0x3f;
                        param1.DAT_1A = (byte)(bVar3 & 0x3f);
                        param1.DAT_1B = (byte)(bVar1 & 0x3f);
                        param1.DAT_04 |= (byte)(bVar2 & 0xc0 | bVar6);
                        param1.DAT_1A |= (byte)(bVar1 & 0xc0 | bVar5);
                        param1.DAT_05 &= 0x3f;
                        param1.DAT_1B |= (byte)(bVar3 & 0xc0);
                        param1.DAT_05 |= (byte)(bVar4 & 0xc0);
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

    //FUN_492C (ST8)
    private void FUN_492C(CriInteract param1)
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

    //FUN_4994 (ST8)
    private void FUN_4994(CriInteract param1)
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
            DAT_12AC7 = 0;
            DAT_12AC5 = 0;
            DAT_12AC6 = 0;
            DAT_12AC4 = 0;
            param1.DAT_03++;
        }
    }

    //FUN_4A00 (ST8)
    private void FUN_4A00(CriInteract param1)
    {
        byte bVar1;

        DAT_12AC4 -= 4;
        DAT_12AC6 -= 2;
        DAT_12AC5 += 4;
        DAT_12AC7 += 2;
        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;

        if (4 < bVar1)
        {
            param1.DAT_17 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_03++;
        }
    }

    //FUN_4A80 (ST8)
    private void FUN_4A80(CriInteract param1)
    {
        byte bVar1;

        DAT_12AC4 -= 4;
        DAT_12AC6 += 2;
        DAT_12AC5 += 4;
        DAT_12AC7 -= 2;
        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;

        if (4 < bVar1)
        {
            param1.DAT_17 = 0;
            param1.BDAT_16 = 0;
            param1.DAT_03++;
        }
    }

    //FUN_4B00 (ST8)
    private void FUN_4B00(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;

        DAT_12AC4 -= 4;
        DAT_12AC5 += 4;
        bVar1 = (byte)(param1.DAT_17 + 1);
        param1.DAT_17 = (sbyte)bVar1;

        if (9 < bVar1)
        {
            DAT_12AC4++;
            DAT_12AC5--;
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
            param1.DAT_10 = param1.DAT_04;
            param1.BDAT_08 = param1.DAT_1A;
            param1.BDAT_09 = param1.DAT_1B;
            param1.DAT_0B = (sbyte)param1.DAT_05;
            bVar3 = FUN_4BDC(param1);
            sVar2 = 3;

            if (!bVar3)
                sVar2 = 2;

            param1.DAT_03 = sVar2;
        }
    }

    //FUN_4BDC (ST8)
    private bool FUN_4BDC(CriInteract param1)
    {
        bool bVar1;
        uint uVar2;

        uVar2 = param1.DAT_02;
        bVar1 = false;

        if (param1.BDAT_08 == DAT_12278[uVar2] && (byte)param1.BDAT_0A == DAT_1227C[uVar2] && 
            param1.BDAT_09 == DAT_12270[uVar2])
        {
            bVar1 = true;

            if ((byte)param1.DAT_0B == DAT_12274[uVar2])
                bVar1 = false;
        }

        return bVar1;
    }

    //FUN_62C8 (ST8)
    private void FUN_62C8(CriInteract param1)
    {
        int puVar1;

        puVar1 = 0;

        do
        {
            PTR_DAT_12B68[puVar1].DAT_00 = 0xa0;
            PTR_DAT_12B68[puVar1].DAT_02 = 0x80;

            if (param1.DAT_02 == 1)
                PTR_DAT_12B68[puVar1].DAT_04 = 0x800;
            else
                PTR_DAT_12B68[puVar1].DAT_04 = 0;

            PTR_DAT_12B68[puVar1].DAT_06 = 0;
            PTR_DAT_12B68[puVar1].DAT_07 = 70;
            PTR_DAT_12B68[puVar1].DAT_08 = true;
            PTR_DAT_12B68[puVar1].DAT_09 = true;
            PTR_DAT_12B68[puVar1].DAT_0A = false;
            puVar1++;
        } while (puVar1 < 3);

        param1.BDAT_08 = 0;
        param1.BDAT_09 = 0;
        param1.BDAT_0A = 0;
        param1.DAT_0B = 0;
        param1.BDAT_0C = 0;
        param1.DAT_0D = 0;
        param1.BDAT_0E = 0;
        param1.DAT_0F = 0;
        param1.DAT_10 = 0;
        param1.DAT_11 = 0;
        param1.DAT_12 = 1;
        param1.DAT_13 = 2;
        param1.DAT_14 = 0;
        param1.DAT_15 = 0;
        param1.BDAT_16 = 0;
        param1.DAT_17 = 0;
        param1.DAT_03++;
    }

    //FUN_6350 (ST8)
    private void FUN_6350(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;

        bVar1 = param1.BDAT_08;

        if (bVar1 == 1)
        {
            bVar1 = param1.BDAT_09;
            param1.BDAT_09 = (byte)(bVar1 + 1);

            if (bVar1 < 16)
            {
                PTR_DAT_12B68[1].DAT_00 += 5;
                PTR_DAT_12B68[1].DAT_02 -= 5;
                PTR_DAT_12B68[1].DAT_04 += 0x40;
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

                PTR_DAT_12B68[0].DAT_07--;
                PTR_DAT_12B68[1].DAT_07--;
                PTR_DAT_12B68[2].DAT_07--;
                PTR_DAT_12B68[0].DAT_02++;
                PTR_DAT_12B68[1].DAT_02++;
                PTR_DAT_12B68[2].DAT_02++;
                bVar1 = param1.BDAT_09;
                param1.BDAT_09 = (byte)(bVar1 + 1);

                if (bVar1 < 36)
                    return;

                sVar2 = (sbyte)param1.BDAT_08;
                param1.BDAT_09 = 0;
                param1.BDAT_0A = 0;
                param1.DAT_0B = 0;
                goto LAB_64E4;
            }

            if (bVar1 != 2)
            {
                if (bVar1 != 3)
                    return;

                bVar1 = param1.BDAT_09;
                param1.BDAT_09 = (byte)(bVar1 + 1);

                if (bVar1 < 16)
                {
                    PTR_DAT_12B68[0].DAT_00 -= 5;
                    PTR_DAT_12B68[0].DAT_02 -= 5;
                    PTR_DAT_12B68[0].DAT_04 += 0x40;
                    return;
                }

                GameManager.instance.FUN_5C94C(null, 149);
                param1.BDAT_08 = 0;
                param1.BDAT_09 = 0;
                param1.BDAT_0A = 0;
                param1.DAT_0B = 0;
                param1.DAT_0F = 1;
                param1.DAT_03++;
                return;
            }

            bVar1 = param1.BDAT_09;
            param1.BDAT_09 = (byte)(bVar1 + 1);

            if (bVar1 < 16)
            {
                PTR_DAT_12B68[1].DAT_02 -= 5;
                PTR_DAT_12B68[1].DAT_04 += 0x40;
                return;
            }
        }

        GameManager.instance.FUN_5C94C(null, 149);
        sVar2 = (sbyte)param1.BDAT_08;
        param1.BDAT_09 = 0;
        LAB_64E4:
        param1.BDAT_08 = (byte)(sVar2 + 1);
    }

    //FUN_6574 (ST8)
    private void FUN_6574(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        int puVar3;
        uint uVar4;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0 && param1.BDAT_0E != 0)
        {
            if (PTR_DAT_12B68[0].DAT_0A && PTR_DAT_12B68[1].DAT_0A && PTR_DAT_12B68[2].DAT_0A)
            {
                param1.BDAT_0E = 1;
                return;
            }

            param1.BDAT_0E--;
            GameManager.instance.FUN_5C94C(null, 144);
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
                PTR_DAT_12B68[bVar1].DAT_0A = false;
                param1.BDAT_08 = 6;
                param1.DAT_03++;
                GameManager.instance.FUN_5C94C(null, 149);
                return;
            }

            if (1 < bVar1)
            {
                if (bVar1 != 2)
                    return;

                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                    return;

                InventoryManager.FUN_4A7E8(2, 11, true);
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

                    GameManager.instance.FUN_5C94C(null, 145);
                    param1.DAT_0F = 0;
                    sVar2 = (sbyte)(param1.DAT_03 + 1);
                    param1.DAT_03 = sVar2;
                    return;
                }

                uVar4 = param1.BDAT_0C - 1U;

                if ((int)uVar4 < 0)
                    return;

                puVar3 = (int)uVar4;

                while (PTR_DAT_12B68[puVar3].DAT_0A)
                {
                    uVar4--;
                    puVar3++;

                    if ((int)uVar4 < 0)
                        return;
                }
            }
            else
            {
                uVar4 = param1.BDAT_0C + 1U;

                if (2 < uVar4)
                    return;

                puVar3 = (int)uVar4;

                while (PTR_DAT_12B68[puVar3].DAT_0A)
                {
                    uVar4++;
                    puVar3++;

                    if (2 < (int)uVar4)
                        return;
                }
            }

            param1.BDAT_0C = (byte)uVar4;
        }
        else
            param1.BDAT_0E++;

        GameManager.instance.FUN_5C94C(null, 144);
    }

    //FUN_6858 (ST8)
    private bool FUN_6858(CriInteract param1)
    {
        if (param1.DAT_02 == 0)
        {
            if (PTR_DAT_12B68[0].DAT_06 == 0 && PTR_DAT_12B68[1].DAT_06 == 3 && PTR_DAT_12B68[2].DAT_06 == 3)
            {
                if (param1.DAT_11 != 2 && param1.DAT_12 != 0 && param1.DAT_13 != 1)
                    return false;

                return true;
            }
        }
        else
        {
            if (PTR_DAT_12B68[0].DAT_06 == 1 && PTR_DAT_12B68[1].DAT_06 == 1 && PTR_DAT_12B68[2].DAT_06 == 0 &&
                param1.DAT_11 == 1 && param1.DAT_12 == 2 && param1.DAT_13 == 0)
                return true;
        }

        return false;
    }

    //FUN_6914 (ST8)
    private void FUN_6914(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        int iVar2;
        uint uVar2;
        int iVar3;
        bool bVar3;
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
                        PTR_DAT_12B68[iVar2].DAT_07++;
                    }
                    else
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    return;
                case 1:
                    //FUN_71B4

                    if ((InputManager.controllers[0].DAT_B58B8 & 0x40) == 0)
                    {
                        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) == 0)
                        {
                            if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) == 0)
                            {
                                if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0)
                                {
                                    GameManager.instance.FUN_5C94C(null, 147);
                                    param1.BDAT_08++;
                                }
                            }
                            else
                            {
                                GameManager.instance.FUN_5C94C(null, 147);
                                param1.BDAT_08 += 2;
                            }
                        }
                        else
                            param1.BDAT_08 = 5;
                    }
                    else
                    {
                        GameManager.instance.FUN_5C94C(null, 146);
                        param1.BDAT_08 = 4;
                    }

                    return;
                case 2:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (bVar1 < 32)
                    {
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12B68[iVar2].DAT_04 += 0x20;
                    }
                    else
                    {
                        param1.BDAT_08 = 1;
                        param1.BDAT_09 = 0;
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12B68[iVar2].DAT_06++;
                        PTR_DAT_12B68[iVar2].DAT_06 &= 3;
                    }

                    return;
                case 3:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (bVar1 < 32)
                    {
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12B68[iVar2].DAT_04 -= 0x20;
                    }
                    else
                    {
                        param1.BDAT_08 = 1;
                        param1.BDAT_09 = 0;
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12B68[iVar2].DAT_06--;
                        PTR_DAT_12B68[iVar2].DAT_06 &= 3;
                    }

                    return;
                case 4:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (bVar1 < 10)
                    {
                        iVar2 = param1.BDAT_0C;
                        PTR_DAT_12B68[iVar2].DAT_07--;
                    }
                    else
                    {
                        param1.DAT_03 = 2;
                        param1.BDAT_08 = 0;
                        param1.BDAT_09 = 0;
                        param1.BDAT_0A = 0;
                        param1.DAT_0B = 0;
                        param1.DAT_0F = 1;
                    }

                    return;
                case 5:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (9 < bVar1)
                    {
                        iVar3 = 0;
                        PTR_DAT_12B68[param1.BDAT_0C].DAT_0A = true;
                        sVar2 = (sbyte)param1.DAT_10;
                        param1.DAT_10 = (byte)(sVar2 + 1);
                        param1.SET_OFFSET_08(sVar2 + 9, param1.BDAT_0C);
                        param1.BDAT_08 = 0;
                        param1.BDAT_09 = 0;
                        param1.BDAT_0A = 0;
                        param1.DAT_0B = 0;
                        param1.DAT_0F = 1;
                        param1.DAT_03 = 2;

                        do
                        {
                            if (!PTR_DAT_12B68[iVar3].DAT_0A)
                            {
                                param1.BDAT_0C = (byte)iVar3;
                                GameManager.instance.FUN_5C94C(null, 148);
                                return;
                            }

                            iVar3++;
                        } while (iVar3 < 3);

                        bVar3 = FUN_6858(param1);

                        if (bVar3)
                        {
                            GameManager.instance.FUN_5C94C(null, 150);
                            param1.DAT_03 = 4;
                            param1.BDAT_0E = 1;
                            param1.DAT_0F = 0;
                            return;
                        }

                        GameManager.instance.FUN_5C94C(null, 148);
                        param1.BDAT_0E = 1;
                        return;
                    }

                    uVar4 = param1.BDAT_0C;

                    if (uVar4 != 1)
                    {
                        if (uVar4 < 2)
                        {
                            if (uVar4 != 0) goto LAB_6C58;

                            PTR_DAT_12B68[0].DAT_00 += 8;
                        }
                        else
                        {
                            if (uVar4 == 2)
                                PTR_DAT_12B68[2].DAT_00 -= 8;
                        }
                    }

                    uVar4 = param1.BDAT_0C;
                    LAB_6C58:
                    PTR_DAT_12B68[uVar4].DAT_02 += 8;
                    iVar3 = param1.BDAT_0C;
                    PTR_DAT_12B68[iVar3].DAT_07--;
                    return;
                case 6:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (9 < bVar1)
                    {
                        param1.DAT_0F = 1;
                        param1.BDAT_08 = 0;
                        param1.BDAT_09 = 0;
                        param1.BDAT_0A = 0;
                        param1.DAT_0B = 0;
                        param1.DAT_03 = 2;
                        return;
                    }

                    uVar2 = param1.BDAT_0C;

                    if (uVar2 != 1)
                    {
                        if (uVar2 < 2)
                        {
                            if (uVar2 != 0) goto LAB_6DF4;

                            PTR_DAT_12B68[0].DAT_00 -= 8;
                        }
                        else
                        {
                            if (uVar2 == 2)
                                PTR_DAT_12B68[2].DAT_00 += 8;
                        }
                    }

                    uVar2 = param1.BDAT_0C;
                    LAB_6DF4:
                    PTR_DAT_12B68[uVar2].DAT_02 -= 8;
                    PTR_DAT_12B68[param1.BDAT_0C].DAT_07 = 33;
                    return;
            }
        }
    }

    //FUN_6E70 (ST8)
    private void FUN_6E70(CriInteract param1)
    {
        byte bVar1;

        if (param1.BDAT_08 < 7)
        {
            switch (param1.BDAT_08)
            {
                case 0:
                    param1.DAT_15 += 3;
                    DAT_12AD4 = 0;
                    //DAT_12AD0 = 0;
                    DAT_12ACC = 0;
                    //DAT_12AC8 = 0;
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (40 < bVar1)
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    goto LAB_7070;
                case 1:
                    //DAT_12AC8 = 60;
                    DAT_12ACC = 100;
                    //DAT_12AD0 = 200;
                    DAT_12AD4 = 1;
                    param1.BDAT_08++;
                    goto LAB_7070;
                case 2:
                    DAT_12ACC -= 8;
                    DAT_12AD4 += 0x10;
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (3 < bVar1)
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    goto LAB_7070;
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
                    DAT_12ACC += 8;
                    DAT_12AD4 -= 0x10;
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (3 < bVar1)
                    {
                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                    }

                    goto LAB_7070;
                case 6:
                    bVar1 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar1 + 1);

                    if (20 < bVar1)
                    {
                        param1.DAT_03 = 5;
                        InventoryManager.FUN_4A7E8(2, 9, true);
                    }

                    //...
                    return;
            }
        }

        LAB_7070:;
        //...
    }

    //FUN_88BC (ST8)
    private void FUN_88BC(CriInteract param1)
    {
        CriStatic oVar1;
        int iVar3;
        int iVar4;

        param1.BDAT_08 = 0;
        param1.BDAT_09 = 0;
        param1.BDAT_0A = 0;
        param1.DAT_0B = 0;
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
        iVar3 = 0;

        do
        {
            DAT_12B8C[iVar3] = -1;
            DAT_12B9C[iVar3] = -1;
            DAT_12BAC[iVar3] = DAT_12384[iVar3 + param1.DAT_02 * 10];

            if (DAT_12384[iVar3 + param1.DAT_02 * 10] != -1)
                param1.BDAT_0E++;

            iVar4 = iVar3 + 1;
            iVar3 = iVar4;
        } while (iVar4 < 10);

        iVar4 = 0;
        param1.DAT_0D = 0x80;

        do
        {
            oVar1 = SceneManager.instance.staticObjects[iVar4];
            iVar4++;
            oVar1.screen.x = 0;
            oVar1.vr.y = 0;
            oVar1.flags |= 2;
        } while (iVar4 < 6);

        oVar1 = SceneManager.instance.staticObjects[0];
        oVar1.screen.y = -340;
        oVar1.screen.x = 640;
        oVar1 = SceneManager.instance.staticObjects[1];
        oVar1.screen.y = -340;
        oVar1.screen.x = 0;
        oVar1 = SceneManager.instance.staticObjects[2];
        oVar1.screen.y = -340;
        oVar1.screen.x = -640;
        oVar1 = SceneManager.instance.staticObjects[3];
        oVar1.screen.y = 410;
        oVar1.screen.x = 640;
        oVar1 = SceneManager.instance.staticObjects[4];
        oVar1.screen.y = 410;
        oVar1.screen.x = 0;
        oVar1 = SceneManager.instance.staticObjects[5];
        oVar1.screen.y = 410;
        oVar1.screen.x = -640;
        param1.DAT_03 = 1;
    }

    //FUN_8A0C (ST8)
    private void FUN_8A0C(CriInteract param1)
    {
        int iVar1;
        byte bVar1;
        CriStatic oVar1;
        int iVar2;
        sbyte sVar2;
        uint uVar2;
        CriStatic oVar2;
        int iVar3;
        uint uVar3;
        CriStatic oVar3;
        int iVar4;
        CriStatic oVar4;
        byte bVar5;
        byte bVar6;
        uint uVar7;

        //FUN_9BF0
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
                        if (param1.DAT_0F == param1.BDAT_0E)
                        {
                            param1.BDAT_08 = 0;
                            param1.DAT_03++;
                            return;
                        }

                        param1.BDAT_09 = 0;
                        param1.BDAT_08++;
                        bVar6 = (byte)DAT_12BAC[param1.DAT_0F];

                        if (bVar6 == 1)
                        {
                            iVar1 = Utilities.Rand();
                            uVar7 = (uint)(iVar1 % 6);
                            iVar1 = Utilities.Rand();
                            bVar5 = (byte)(1 << (int)(uVar7 & 0x1f));
                            param1.DAT_10 = bVar5;
                            param1.DAT_11 = bVar5;
                            param1.BDAT_0C = (byte)uVar7;
                            DAT_12B8C[param1.DAT_0F] = (sbyte)(iVar1 % 6);
                            SceneManager.instance.staticObjects[uVar7].cMesh = (TmdScriptableObject)Utilities.GetRamObject(DAT_123F0[iVar1 % 6]);

                            do
                            {
                                iVar1 = Utilities.Rand();
                                uVar7 = (uint)(iVar1 % 6);
                            } while (uVar7 == param1.BDAT_0C);

                            bVar6 = (byte)(param1.DAT_10 | (1 << (int)(uVar7 & 0x1f)));
                            param1.DAT_10 = bVar6;
                            param1.DAT_11 = bVar6;
                            SceneManager.instance.staticObjects[uVar7].cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010001c);
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
                                    bVar5 = (byte)(1 << (int)(uVar7 & 0x1f));
                                    param1.DAT_10 = bVar5;
                                    param1.DAT_11 = bVar5;
                                    param1.BDAT_0C = (byte)uVar7;
                                    DAT_12B8C[param1.DAT_0F] = (sbyte)(iVar1 % 6);
                                    SceneManager.instance.staticObjects[uVar7].cMesh = (TmdScriptableObject)Utilities.GetRamObject(DAT_123F0[iVar1 % 6]);
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
                                        oVar1 = SceneManager.instance.staticObjects[uVar7];
                                        iVar4 = (int)uVar7 + (iVar2 % 6) * 6;
                                        uVar7++;
                                        oVar1.cMesh = (TmdScriptableObject)Utilities.GetRamObject(DAT_123F0[DAT_1240C[iVar4]]);
                                    } while (uVar7 < 6);

                                    DAT_12B8C[param1.DAT_0F] = DAT_1240C[iVar3 % 6 + (iVar2 % 6) * 6];
                                    param1.DAT_11 = (byte)(0x3f - (1 << (iVar3 % 6 & 0x1f)));
                                    bVar5 = 4;
                                    param1.DAT_10 = 0x3f;
                                }
                                else
                                {
                                    if (bVar6 != 3) goto LAB_8EA8;

                                    iVar1 = Utilities.Rand();
                                    uVar7 = (uint)(iVar1 % 6);
                                    iVar1 = Utilities.Rand();
                                    bVar5 = (byte)(1 << (int)(uVar7 & 0x1f));
                                    param1.DAT_10 = bVar5;
                                    param1.DAT_11 = bVar5;
                                    param1.BDAT_0C = (byte)uVar7;
                                    DAT_12B8C[param1.DAT_0F] = (sbyte)(iVar1 % 6);
                                    SceneManager.instance.staticObjects[uVar7].cMesh = (TmdScriptableObject)Utilities.GetRamObject(DAT_123F0[iVar1 % 6]);

                                    do
                                    {
                                        iVar1 = Utilities.Rand();
                                        bVar5 = 7;
                                    } while (iVar1 % 6 == param1.BDAT_0C);

                                    param1.DAT_12 = (sbyte)(iVar1 % 6);
                                }
                            }
                        }

                        LAB_8EA8:
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
                                oVar3 = SceneManager.instance.staticObjects[uVar2];

                                if ((param1.DAT_10 >> (int)(uVar2 & 0x1f) & 1) != 0)
                                    oVar3.vr.y += param1.DAT_0D;

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
                    case 5:
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
                                oVar4 = SceneManager.instance.staticObjects[uVar3];

                                if ((param1.DAT_11 >> (int)(uVar3 & 0x1f) & 1) != 0)
                                    oVar4.vr.y -= param1.DAT_0D;

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
                                param1.BDAT_0A = 35;
                            }
                        }

                        return;
                    case 4:
                        bVar1 = param1.BDAT_09;
                        param1.BDAT_09 = (byte)(bVar1 + 1);

                        if (bVar1 < 0x10)
                        {
                            uVar2 = 0;

                            do
                            {
                                oVar3 = SceneManager.instance.staticObjects[uVar2];

                                if ((param1.DAT_10 >> (int)(uVar2 & 0x1f) & 1) != 0)
                                    oVar3.vr.y += param1.DAT_0D;

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
                    case 6:
                        bVar1 = param1.BDAT_09;
                        param1.BDAT_09 = (byte)(bVar1 + 1);

                        if (bVar1 < 0x10)
                        {
                            uVar2 = 0;

                            do
                            {
                                oVar3 = SceneManager.instance.staticObjects[uVar2];

                                if ((param1.DAT_11 >> (int)(uVar2 & 0x1f) & 1) != 0)
                                    oVar3.vr.y -= param1.DAT_0D;

                                uVar2++;
                            } while (uVar2 < 6);
                        }
                        else
                        {
                            param1.BDAT_08 = 3;
                            param1.BDAT_09 = 0;
                            param1.DAT_11 ^= 0x3f;
                            GameManager.instance.FUN_5C94C(null, 147);
                        }

                        return;
                    case 7:
                        bVar1 = param1.BDAT_09;
                        param1.BDAT_09 = (byte)(bVar1 + 1);

                        if (bVar1 < 7)
                        {
                            oVar2 = SceneManager.instance.staticObjects[param1.DAT_12];
                            oVar2.vr.y += param1.DAT_0D;
                        }
                        else
                        {
                            param1.BDAT_09 = 0;
                            param1.BDAT_08++;
                            GameManager.instance.FUN_5C94C(null, 147);
                        }

                        return;
                }
            }
        }
    }

    //FUN_9220 (ST8)
    private void FUN_9220(CriInteract param1)
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
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x801003d0);
                oVar2.screen = new Vector3Int(430, -40, -1240);
                oVar2.vr.y = 0x800;
                oVar2 = SceneManager.instance.staticObjects[1];
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80100784);
                oVar2.screen = new Vector3Int(-360, -40, -1240);
                oVar2.vr.y = 0x800;
                oVar2 = SceneManager.instance.staticObjects[2];
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80100b38);
                oVar2.screen = new Vector3Int(-1160, -40, -1240);
                oVar2.vr.y = 0x800;
                oVar2 = SceneManager.instance.staticObjects[3];
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80100eec);
                oVar2.screen = new Vector3Int(430, 728, -1240);
                oVar2.vr.y = 0x800;
                oVar2 = SceneManager.instance.staticObjects[4];
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x801012a0);
                oVar2.screen = new Vector3Int(-360, 728, -1240);
                oVar2.vr.y = 0x800;
                oVar2 = SceneManager.instance.staticObjects[5];
                oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80101654);
                oVar2.screen = new Vector3Int(-1160, 728, -1240);
                oVar2.vr.y = 0x800;
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
                    //FUN_9CFC
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

    //FUN_93DC (ST8)
    private void FUN_93DC(CriInteract param1)
    {
        byte bVar2;
        sbyte sVar3;
        sbyte sVar4;
        CriStatic oVar5;

        //FUN_9CFC

        bVar2 = param1.BDAT_08;
        
        if (bVar2 == 1)
        {
            bVar2 = param1.BDAT_09;
            param1.BDAT_09 = (byte)(bVar2 + 1);

            if (bVar2 < 16)
            {
                oVar5 = SceneManager.instance.staticObjects[param1.DAT_13];
                oVar5.vr.y += 0x100;
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

                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && (byte)param1.DAT_13 < 5)
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

                if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0 && (byte)param1.DAT_13 < 3)
                {
                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.DAT_13 += 3;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) != 0 && 2 < (byte)param1.DAT_13)
                {
                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.DAT_13 -= 3;
                    return;
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0 && (byte)param1.DAT_14 < 10)
                {
                    GameManager.instance.FUN_5C94C(null, 146);
                    DAT_12B9C[param1.DAT_14] = param1.DAT_13;
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
                    sVar4 = (sbyte)FUN_9BA4();
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
            DAT_12B9C[param1.DAT_14] = -1;
        }
    }

    //FUN_977C (ST8)
    private void FUN_977C(CriInteract param1)
    {
        sbyte sVar1;
        byte bVar2;

        bVar2 = param1.BDAT_08;

        if (bVar2 == 1)
        {
            DAT_12BBC -= 8;
            DAT_12BC4 += 0x10;
            bVar2 = param1.BDAT_09;
            param1.BDAT_09 = (byte)(bVar2 + 1);

            if (bVar2 < 4) goto LAB_9954;
        }
        else
        {
            if (bVar2 < 2)
            {
                if (bVar2 == 0)
                {
                    //DAT_12BB8 = 60;
                    DAT_12BBC = 100;
                    //DAT_12BC0 = 200;
                    DAT_12BC4 = 1;
                    param1.BDAT_08 = 1;
                    param1.BDAT_09 = 0;
                    GameManager.instance.FUN_5C94C(null, 149);
                }

                goto LAB_9954;
            }

            if (bVar2 != 2)
            {
                if (bVar2 == 3)
                {
                    //...
                    bVar2 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar2 + 1);

                    if (60 < bVar2)
                    {
                        InventoryManager.FUN_4A7E8(2, 10, true);
                        param1.DAT_03 = 6;
                        param1.BDAT_08 = 0;
                    }
                }

                goto LAB_9954;
            }

            sVar1 = param1.BDAT_0A;
            param1.BDAT_0A = (sbyte)(sVar1 + 1);
            //...
            bVar2 = (byte)(param1.BDAT_09 + 2);
            param1.BDAT_09 = bVar2;

            if (bVar2 < 131) goto LAB_9954;

            GameManager.instance.FUN_5C94C(null, 151);
        }

        param1.BDAT_09 = 0;
        param1.BDAT_08++;
        LAB_9954:;
        //...
    }

    //FUN_9990 (ST8)
    private void FUN_9990(CriInteract param1)
    {
        sbyte sVar1;
        byte bVar2;

        bVar2 = param1.BDAT_08;

        if (bVar2 == 1)
        {
            DAT_12BBC -= 8;
            DAT_12BC4 += 0x10;
            bVar2 = param1.BDAT_09;
            param1.BDAT_09 = (byte)(bVar2 + 1);

            if (bVar2 < 4) goto LAB_9B68;
        }
        else
        {
            if (bVar2 < 2)
            {
                if (bVar2 == 0)
                {
                    //DAT_12BB8 = 60;
                    DAT_12BBC = 100;
                    //DAT_12BC0 = 200;
                    DAT_12BC4 = 1;
                    param1.BDAT_08 = 1;
                    param1.BDAT_09 = 0;
                    GameManager.instance.FUN_5C94C(null, 149);
                }

                goto LAB_9B68;
            }

            if (bVar2 != 2)
            {
                if (bVar2 == 3)
                {
                    //...
                    bVar2 = param1.BDAT_09;
                    param1.BDAT_09 = (byte)(bVar2 + 1);

                    if (60 < bVar2)
                    {
                        InventoryManager.FUN_4A7E8(2, 9, true);
                        param1.DAT_03 = 6;
                        param1.BDAT_08 = 0;
                    }
                }

                goto LAB_9B68;
            }

            sVar1 = param1.BDAT_0A;
            param1.BDAT_0A = (sbyte)(sVar1 + 1);
            //...
            bVar2 = (byte)(param1.BDAT_09 + 2);
            param1.BDAT_09 = bVar2;

            if (bVar2 < 131) goto LAB_9B68;

            GameManager.instance.FUN_5C94C(null, 150);
        }

        param1.BDAT_09 = 0;
        param1.BDAT_08++;
        LAB_9B68:;
        //...
    }

    //FUN_9BA4 (ST8)
    private int FUN_9BA4()
    {
        int iVar2;
        int iVar3;

        iVar2 = 0;

        do
        {
            iVar3 = iVar2 + 1;

            if (DAT_12B8C[iVar2] != DAT_12B9C[iVar2])
                return 4;

            iVar2 = iVar3;
        } while (iVar3 < 10);

        return 5;
    }

    //FUN_A7F8 (ST8)
    private void FUN_A7F8(CriStatic param1)
    {
        param1.tags++;
        param1.DAT_4C = new Vector3Int(0, 0, 0);
        //FUN_A85C
    }

    //FUN_A83C (ST8)
    private void FUN_A83C(CriStatic param1)
    {
        //FUN_AA1C
    }

    //FUN_AC10 (ST8)
    private void FUN_AC10(CriInteract param1)
    {
        CriStatic oVar2;
        uint uVar3;
        uint uVar4;

        param1.BDAT_09 = 0;
        param1.DAT_03 = 1;
        GameManager.instance.FUN_5C94C(null, 149);
        InventoryManager.FUN_4A7E8(3, 0x28, false);
        InventoryManager.FUN_4A7E8(3, 0x29, false);
        InventoryManager.FUN_4A7E8(3, 0x2a, false);
        InventoryManager.FUN_4A7E8(3, 0x2b, false);
        InventoryManager.FUN_4A7E8(3, 0x2c, false);
        //DAT_12BF8 = 0;
        DAT_12C00[8] = 0;
        DAT_12C00[9] = 0;
        DAT_12C00[10] = 0;
        DAT_12C00[11] = 0;
        DAT_12C00[5] = 0;
        param1.DAT_0B = 0x40;
        uVar3 = 0;

        do
        {
            DAT_12C00[uVar3] = 0;
            uVar4 = uVar3 + 1;
            uVar3 = uVar4;
        } while (uVar4 < 5);

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80117b88);
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_48 = 1;
            oVar2.cCollider = null;
            oVar2.flags |= 2;
            DAT_12BC8 = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80117B88);
            oVar2.DAT_48 = 2;
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_4A = 0x3ff;
            oVar2.cCollider = null;
            oVar2.flags |= 2;
            DAT_12BD4 = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80113a60);
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_48 = 1;
            oVar2.cCollider = null;
            DAT_12BCC = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80113a60);
            oVar2.DAT_48 = 2;
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_4A = 0x3ff;
            oVar2.cCollider = null;
            DAT_12BD8 = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80119678);
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_48 = 1;
            oVar2.cCollider = null;
            DAT_12BD0 = oVar2;
        }

        oVar2 = SceneManager.instance.FUN_5FE78();

        if (oVar2 != null)
        {
            oVar2.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80119678);
            oVar2.DAT_48 = 2;
            oVar2.screen = new Vector3Int(0, 0, 0);
            oVar2.vr = new Vector3Int(0, 0, 0);
            oVar2.DAT_4A = 0x3ff;
            oVar2.cCollider = null;
            DAT_12BDC = oVar2;
        }

        DAT_12BC8.DAT_40 = DAT_12BD4;
        DAT_12BCC.DAT_40 = DAT_12BD8;
        DAT_12BD0.DAT_40 = DAT_12BDC;
    }

    //FUN_AEE8 (ST8)
    private void FUN_AEE8(CriInteract param1)
    {
        if (param1.BDAT_09 < 110)
        {
            //...

            if (param1.BDAT_09 == 90)
                InventoryManager.FUN_4A7E8(3, 0x29, true);
        }
        else
        {
            param1.DAT_03 = 2;
            //...
        }

        param1.BDAT_09++;
    }

    //FUN_AFCC (ST8)
    private void FUN_AFCC(CriInteract param1)
    {
        PTR_FUN_124A8[param1.BDAT_08](param1);
        //...
    }

    //FUN_B024 (ST8)
    private void FUN_B024(CriInteract param1)
    {
        param1.DAT_03 = 5;
        InventoryManager.FUN_4A7E8(2, 9, true);
        InventoryManager.FUN_4A7E8(3, 0x28, true);
    }

    //FUN_B064 (ST8)
    private void FUN_B064(CriInteract param1)
    {
        byte bVar1;
        int iVar2;
        sbyte sVar3;

        DAT_12BD8.screen.x += param1.SDAT_14;
        DAT_12BD8.screen.y += param1.DAT_16;
        DAT_12BDC.screen.x += param1.SDAT_18;
        DAT_12BDC.screen.y += param1.SDAT_1A;
        bVar1 = param1.BDAT_09;

        if (bVar1 < 0x82)
        {
            if (bVar1 + 0xba < 0x3d)
            {
                if (bVar1 == 0x50)
                    GameManager.instance.FUN_5C94C(null, 153);
            }
            else
            {
                //FUN_C280
                FUN_CB7C();
            }
        }
        else
        {
            param1.DAT_03 = 5;
            InventoryManager.FUN_4A7E8(2, 0xb, true);
        }

        sVar3 = (sbyte)param1.BDAT_09;

        if (sVar3 == 71)
        {
            FUN_D0CC(5, 0x2c00fa, 160, 120, 1);
            InventoryManager.FUN_4A7E8(3, 0x28, true);
            sVar3 = (sbyte)param1.BDAT_09;
        }

        if (sVar3 == -126)
            InventoryManager.FUN_4A7E8(3, 0x2c, true);

        param1.BDAT_09++;
        iVar2 = (int)Utilities.SquareRoot0(DAT_12BDC.screen.x * DAT_12BDC.screen.x +
                                           DAT_12BDC.screen.y * DAT_12BDC.screen.y);

        if (iVar2 < 200)
        {
            param1.SDAT_18 = (short)-param1.SDAT_18;
            param1.SDAT_1A = (short)-param1.SDAT_1A;
        }
    }

    //FUN_B22C (ST8)
    private void FUN_B22C(CriInteract param1)
    {
        InventoryManager.FUN_4A7E8(3, 0x28, false);
        InventoryManager.FUN_4A7E8(3, 0x29, false);
        InventoryManager.FUN_4A7E8(3, 0x2a, false);
        InventoryManager.FUN_4A7E8(3, 0x2b, false);
        InventoryManager.FUN_4A7E8(3, 0x2c, false);
        DAT_12BC8.FUN_5FF00();
        DAT_12BD4.FUN_5FF00();
        DAT_12BCC.FUN_5FF00();
        DAT_12BD8.FUN_5FF00();
        DAT_12BD0.FUN_5FF00();
        DAT_12BDC.FUN_5FF00();
        param1.DAT_03 = 6;
    }

    //FUN_B2F8 (ST8)
    private void FUN_B2F8(CriInteract param1)
    {
        short sVar1;
        CriStatic oVar2;
        int iVar2;
        uint uVar3;
        uint uVar4;
        uint uVar5;

        param1.SET_OFFSET_08(1, 0);
        param1.SET_OFFSET_08(5, 0);
        param1.SET_OFFSET_08(4, 0);
        param1.SET_OFFSET_08(6, 0);
        param1.SET_OFFSET_08(0, 0);
        param1.SET_OFFSET_08(2, 0);
        param1.SET_OFFSET_08(7, 0);
        //FUN_1802C
        DAT_12BC8.flags |= 2;
        DAT_12BD4.flags |= 2;
        DAT_12BCC.flags |= 2;
        DAT_12BD8.flags |= 2;
        DAT_12BD0.flags |= 2;
        DAT_12BDC.flags |= 2;
        DAT_12BD8.DAT_40 = null;
        DAT_12BDC.DAT_40 = null;
        oVar2 = DAT_12BD4;
        oVar2.vr.z = 0;
        oVar2.screen.y = 0;
        oVar2.screen.x = 0;
        DAT_12BF0 = new Vector3Int(0, 0, 0);
        InventoryManager.FUN_4A7E8(3, 0x2b, false);
        InventoryManager.FUN_4A7E8(3, 0x2c, false);
        uVar3 = (uint)Utilities.Rand();
        iVar2 = (int)(uVar3 % 9) * 5;
        param1.SDAT_14 = (short)(DAT_1245C[iVar2 + 1] * DAT_1245C[iVar2 + 4]);
        param1.DAT_16 = (short)(DAT_1245C[iVar2] * DAT_1245C[iVar2 + 4]);
        param1.SDAT_10 = (short)(DAT_1245C[iVar2 + 2] * 10);
        param1.SDAT_12 = (short)(DAT_1245C[iVar2 + 3] * 10);

        if ((uVar3 >> 8 & 1) == 0)
        {
            if ((uVar3 & 1) == 0)
            {
                param1.SDAT_14 = (short)-param1.SDAT_14;
                param1.DAT_16 = (short)-param1.DAT_16;
            }
            else
            {
                param1.SDAT_10 = (short)-param1.SDAT_10;
                param1.SDAT_12 = (short)-param1.SDAT_12;
            }
        }
        else
        {
            if ((uVar3 & 1) == 0)
            {
                param1.SDAT_14 = (short)-param1.SDAT_14;
                param1.SDAT_12 = (short)-param1.SDAT_12;
            }
            else
            {
                param1.SDAT_10 = (short)-param1.SDAT_10;
                param1.DAT_16 = (short)-param1.DAT_16;
            }
        }

        DAT_12BD8.screen.x = param1.SDAT_10;
        DAT_12BD8.screen.y = param1.SDAT_12;
        sVar1 = (short)Utilities.Ratan2(-param1.SDAT_10, -param1.SDAT_12);
        DAT_12BD8.vr.z = 0x1000 - sVar1 & 0xfff;

        do
        {
            uVar4 = (uint)Utilities.Rand();
            uVar5 = uVar4 % 9;
        } while (uVar5 == uVar3 % 9);

        iVar2 = (int)uVar5 * 5;

        if (DAT_1245C[iVar2 + 4] == 1)
        {
            param1.SDAT_10 = DAT_1245C[iVar2 + 1];
            param1.SDAT_12 = DAT_1245C[iVar2];
        }
        else
        {
            param1.SDAT_10 = (short)(DAT_1245C[iVar2 + 1] * (DAT_1245C[iVar2 + 4] - 1));
            param1.SDAT_12 = (short)(DAT_1245C[iVar2] * DAT_1245C[iVar2 + 4] - 1);
        }

        param1.SDAT_10 = (short)(DAT_1245C[uVar5 * 5 + 2] * 10);
        param1.SDAT_12 = (short)(DAT_1245C[uVar5 * 5 + 3] * 10);

        if ((uVar4 >> 8 & 1) == 0)
        {
            if ((uVar4 & 1) != 0)
            {
                param1.SDAT_10 = (short)-param1.SDAT_10;
                param1.SDAT_12 = (short)-param1.SDAT_12;
            }
            else
            {
                param1.SDAT_10 = (short)-param1.SDAT_10;
                param1.SDAT_12 = (short)-param1.SDAT_12;
            }
        }
        else
        {
            if ((uVar4 & 1) == 0)
            {
                param1.SDAT_10 = (short)-param1.SDAT_10;
                param1.SDAT_12 = (short)-param1.SDAT_12;
            }
            else
            {
                param1.SDAT_10 = (short)-param1.SDAT_10;
                param1.SDAT_12 = (short)-param1.SDAT_12;
            }
        }

        DAT_12BDC.screen.x = param1.SDAT_10;
        DAT_12BDC.screen.y = param1.SDAT_12;
        sVar1 = (short)Utilities.Ratan2(-param1.SDAT_10, -param1.SDAT_12);
        DAT_12BDC.vr.z = 0x1800 - sVar1 & 0xfff;
    }

    //FUN_B750 (ST8)
    private void FUN_B750(CriInteract param1)
    {
        FUN_C154(param1);
        //FUN_C280
        FUN_CB7C();

        if (param1.GET_OFFSET_08(1) < 20)
            param1.SET_OFFSET_08(1, (byte)(param1.GET_OFFSET_08(1) + 1));
        else
        {
            param1.SET_OFFSET_08(1, 0);
            param1.SET_OFFSET_08(0, 2);
        }
    }

    //FUN_B7BC (ST8)
    private void FUN_B7BC(CriInteract param1)
    {
        bool bVar1;
        ushort uVar2;
        int iVar3;
        int iVar4;
        uint uVar5;
        byte bVar6;

        FUN_C154(param1);
        //FUN_C280
        FUN_CB7C();
        bVar6 = 100;
        DAT_12BD8.screen.x += param1.SDAT_14;
        bVar1 = DAT_12C00[5] != 0;
        DAT_12BD8.screen.y += param1.DAT_16;

        if (bVar1)
            bVar6 = 0x50;

        if (param1.GET_OFFSET_08(1) < bVar6)
            param1.SET_OFFSET_08(1, (byte)(param1.GET_OFFSET_08(1) + 1));
        else
        {
            DAT_12BDC.screen.x += param1.SDAT_18;
            DAT_12BDC.screen.y += param1.SDAT_1A;
        }

        iVar3 = DAT_12BD8.screen.x;
        iVar4 = DAT_12BD8.screen.y;
        iVar3 = (int)Utilities.SquareRoot0(iVar3 * iVar3 + iVar4 * iVar4);

        if (iVar3 < 100)
        {
            uVar2 = (ushort)DAT_12BD4.vr.z;
            uVar5 = (uint)(uVar2 + 0x800 & 0xfff);
            iVar3 = DAT_12BD8.vr.z;

            if (iVar3 < ((short)uVar2 - 0x80 & 0xfff) || 
               ((short)uVar2 + 0x80 & 0xfff) < iVar3)
            {
                iVar3 = DAT_12BD8.vr.z;

                if (iVar3 < (int)(uVar5 - 0x80 & 0xfff) || 
                   (int)(uVar5 + 0x80 & 0xfff) < iVar3)
                {
                    param1.SET_OFFSET_08(0, 0);
                    param1.SET_OFFSET_08(1, 0);
                    param1.SDAT_14 = (short)-param1.SDAT_14;
                    param1.DAT_16 = (short)-param1.DAT_16;
                    param1.DAT_03 = 4;
                    GameManager.instance.FUN_5C94C(null, 151);
                    return;
                }

                param1.SET_OFFSET_08(0, 3);
                DAT_12BD8.DAT_40 = DAT_12BD4;
                DAT_12BD8.screen = new Vector3Int(0, 100, 0);
                DAT_12BD8.vr.z = 0x800;
                param1.SET_OFFSET_08(2, 1);
            }
            else
            {
                param1.SET_OFFSET_08(0, 3);
                DAT_12BD8.DAT_40 = DAT_12BD4;
                DAT_12BD8.screen = new Vector3Int(0, -100, 0);
                DAT_12BD8.vr.z = 0;
                param1.SET_OFFSET_08(2, 0);
            }

            GameManager.instance.FUN_5C94C(null, 150);
            param1.SET_OFFSET_08(3, (byte)(param1.GET_OFFSET_08(3) >> 1));
        }
    }

    //FUN_BA3C (ST8)
    private void FUN_BA3C(CriInteract param1)
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        Vector3Int local_30;
        Vector3Int local_38;
        Vector3Int local_40;
        Vector3Int local_48;
        Vector3Int local_50;
        Matrix3x3 auStack112;

        FUN_C154(param1);
        //FUN_C280
        FUN_CB7C();
        DAT_12BDC.screen.x += param1.SDAT_18;
        DAT_12BDC.screen.y += param1.SDAT_1A;
        iVar1 = DAT_12BDC.screen.x;
        iVar2 = DAT_12BDC.screen.y;
        iVar1 = (int)Utilities.SquareRoot0(iVar1 * iVar1 + iVar2 * iVar2);

        if (iVar1 < 401)
        {
            auStack112 = new Matrix3x3();
            local_38 = new Vector3Int(0, 0, DAT_12BD4.vr.z);
            Utilities.RotMatrix(ref local_38, ref auStack112);
            local_50 = new Vector3Int(0, iVar1, 0);
            local_30 = Utilities.ApplyMatrixSV(ref auStack112, ref local_50);
            local_48 = new Vector3Int(0, 0, 0);
            local_40 = new Vector3Int(0, 0, 0);
            local_40.x = local_30.x;
            local_40.z = local_30.z;

            if (iVar1 - 201 < 200)
            {
                if (param1.GET_OFFSET_08(2) == 0)
                {
                    iVar2 = Utilities.FUN_615EC(local_48, local_40);
                    iVar1 = 0x1800;
                }
                else
                {
                    iVar2 = Utilities.FUN_615EC(local_48, local_40);
                    iVar1 = 0;
                }

                uVar3 = (uint)(iVar1 - iVar2 & 0xfff);
                iVar1 = DAT_12BDC.vr.z;

                if (iVar1 < (int)(uVar3 - 0x1a0 & 0xfff))
                    return;

                if ((int)(uVar3 + 0x1a0 & 0xfff) < iVar1)
                    return;
            }
            else
            {
                if (param1.GET_OFFSET_08(2) == 0)
                {
                    iVar2 = Utilities.FUN_615EC(local_48, local_40);
                    iVar1 = 0;
                }
                else
                {
                    iVar2 = Utilities.FUN_615EC(local_48, local_40);
                    iVar1 = 0x1800;
                }

                uVar3 = (uint)(iVar1 - iVar2 & 0xfff);
                iVar1 = DAT_12BDC.vr.z;

                if ((int)(uVar3 - 0x80 & 0xfff) <= iVar1 && iVar1 <= (int)(uVar3 + 0x80 & 0xfff))
                {
                    DAT_12BDC.DAT_40 = DAT_12BD4;
                    DAT_12BDC.screen.x = 0;
                    DAT_12BDC.screen.z = 0;

                    if (param1.GET_OFFSET_08(2) == 0)
                    {
                        DAT_12BDC.screen.y = 200;
                        DAT_12BDC.vr.z = 0;
                    }
                    else
                    {
                        DAT_12BDC.screen.y = -200;
                        DAT_12BDC.vr.z = 0x800;
                    }

                    param1.SET_OFFSET_08(0, 4);
                    param1.SET_OFFSET_08(1, 0);
                    GameManager.instance.FUN_5C94C(null, 150);
                    param1.SET_OFFSET_08(3, (byte)(param1.GET_OFFSET_08(3) >> 1));
                    return;
                }
            }

            param1.DAT_16 = 0;
            param1.SDAT_14 = 0;
            param1.SET_OFFSET_08(0, 0);
            param1.SET_OFFSET_08(1, 0);
            param1.SDAT_18 = (short)-param1.SDAT_18;
            param1.SDAT_1A = (short)-param1.SDAT_1A;
            param1.DAT_03 = 4;
            GameManager.instance.FUN_5C94C(null, 151);
        }
    }

    //FUN_BD28 (ST8)
    private void FUN_BD28(CriInteract param1)
    {
        ushort uVar1;
        byte bVar2;
        CriStatic oVar3;

        if (9 < param1.GET_OFFSET_08(1))
        {
            oVar3 = DAT_12BD4;

            if (oVar3.screen.x < 651)
            {
                oVar3.screen.x += 10;
                DAT_12BD4.vr.z = DAT_12BD4.vr.z + 0x30 & 0xfff;
            }
            else
            {
                if (DAT_12BD0 == null)
                {
                    uVar1 = (ushort)oVar3.vr.z;

                    if (0xfce < uVar1 - 0x19) goto LAB_BDCC;
                }
                else
                {
                    uVar1 = (ushort)oVar3.vr.z;

                    if (uVar1 - 0x7e8 < 0x31) goto LAB_BDCC;
                }

                oVar3.vr.z = (short)(uVar1 + 0x30 & 0xfff);
            }
        }

        LAB_BDCC:
        if (param1.GET_OFFSET_08(1) < 100)
        {
            param1.SET_OFFSET_08(1, (byte)(param1.GET_OFFSET_08(1) + 1));
            return;
        }

        bVar2 = 5;

        if (DAT_12BC8.cMesh == (TmdScriptableObject)Utilities.GetRamObject(0x801182e4))
            bVar2 = 6;

        param1.SET_OFFSET_08(0, bVar2);
        param1.SET_OFFSET_08(1, 0);
    }

    //FUN_BE14 (ST8)
    private void FUN_BE14(CriInteract param1)
    {
        ushort uVar1;
        sbyte sVar3;
        bool bVar4;
        CriStatic oVar4;

        if (param1.GET_OFFSET_08(2) == 0)
        {
            oVar4 = DAT_12BD4;
            uVar1 = (ushort)oVar4.vr.z;

            if (0xfce < uVar1 - 0x19) goto LAB_BE88;
        }
        else
        {
            oVar4 = DAT_12BD4;
            uVar1 = (ushort)oVar4.vr.z;

            if (uVar1 - 0x7e8 < 0x31) goto LAB_BE88;
        }

        oVar4.vr.z = (short)(uVar1 + 0x30 & 0xfff);
        LAB_BE88:
        bVar4 = InventoryManager.FUN_4A87C(3, 0x2b);
        //...

        if (param1.GET_OFFSET_08(1) == 10)
            GameManager.instance.FUN_5C94C(null, 152);

        //...

        sVar3 = (sbyte)param1.GET_OFFSET_08(1);

        if (sVar3 == 60)
        {
            InventoryManager.FUN_4A7E8(3, 0x2b, true);
            sVar3 = (sbyte)param1.GET_OFFSET_08(1);
        }

        //...

        if (param1.GET_OFFSET_08(1) == 120)
        {
            DAT_12C00[5] = 1;
            InventoryManager.FUN_4A7E8(3, 0x2a, true);
            DAT_12BD4.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x801182e4);
            DAT_12BC8.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x801182e4);
            DAT_12BD8.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80115af4);
            DAT_12BCC.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80115af4);
            DAT_12BDC.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8011a38c);
            DAT_12BD0.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8011a38c);
            DAT_12BD8.DAT_40 = null;
            DAT_12BDC.DAT_40 = null;
            oVar4 = DAT_12BD4;
            oVar4.vr.y = 0;
            oVar4.screen.y = 0;
            oVar4.screen.x = 0;
            oVar4 = DAT_12BD8;
            oVar4.screen.y = 1500;
            oVar4.screen.x = 1500;
            oVar4 = DAT_12BDC;
            oVar4.screen.y = 1500;
            oVar4.screen.x = 1500;
            param1.SET_OFFSET_08(0, 0);
        }

        param1.SET_OFFSET_08(1, (byte)(param1.GET_OFFSET_08(1) + 1));
    }

    //FUN_C034 (ST8)
    private void FUN_C034(CriInteract param1)
    {
        ushort uVar1;
        CriStatic oVar2;

        if (param1.GET_OFFSET_08(2) == 0)
        {
            oVar2 = DAT_12BD4;
            uVar1 = (ushort)oVar2.vr.z;

            if (0xfce < uVar1 - 0x19) goto LAB_C0AC;
        }
        else
        {
            oVar2 = DAT_12BD4;
            uVar1 = (ushort)oVar2.vr.z;

            if (uVar1 - 0x7e8 < 0x31) goto LAB_C0AC;
        }

        oVar2.vr.z = (short)(uVar1 + 0x30 & 0xfff);

        LAB_C0AC:
        //...

        if (param1.GET_OFFSET_08(1) == 10)
            GameManager.instance.FUN_5C94C(null, 152);

        //...

        if (param1.GET_OFFSET_08(1) == 60)
        {
            InventoryManager.FUN_4A7E8(3, 0x2b, true);
            param1.SET_OFFSET_08(0, 0);
            param1.DAT_03 = 3;
        }

        param1.SET_OFFSET_08(1, (byte)(param1.GET_OFFSET_08(1) + 1));
    }

    //FUN_C154 (ST8)
    private void FUN_C154(CriInteract param1)
    {
        bool bVar1;
        sbyte sVar2;
        int iVar3;

        iVar3 = 30;

        if (DAT_12C00[5] != 0)
            iVar3 = 60;

        bVar1 = false;

        if ((InputManager.controllers[0].DAT_B5898 & 0x2000) != 0)
        {
            sVar2 = (sbyte)(param1.GET_OFFSET_08(4) - 2);
            param1.SET_OFFSET_08(4, (byte)sVar2);

            if ((uint)(int)sVar2 <= (uint)-(iVar3 + 2))
            {
                param1.SET_OFFSET_08(4, (byte)-iVar3);
                bVar1 = true;
            }
        }

        if ((InputManager.controllers[0].DAT_B5898 & 0x8000) != 0)
        {
            sVar2 = (sbyte)(param1.GET_OFFSET_08(4) + 2);
            param1.SET_OFFSET_08(4, (byte)sVar2);

            if (iVar3 + 2 <= (uint)(int)sVar2)
            {
                param1.SET_OFFSET_08(4, (byte)iVar3);
                bVar1 = true;
            }
        }

        param1.SET_OFFSET_08(5, (byte)(param1.DAT_06 << 1));
        iVar3 = ((sbyte)param1.GET_OFFSET_08(6) << 0x19) >> 0x18;

        if (iVar3 < (sbyte)param1.DAT_04)
            param1.SET_OFFSET_08(6, (byte)(param1.GET_OFFSET_08(6) + 1));
        else
        {
            if (param1.DAT_04 < iVar3)
                param1.SET_OFFSET_08(6, (byte)(param1.GET_OFFSET_08(6) - 1));
            else
            {
                if (!bVar1)
                    param1.SET_OFFSET_08(4, 0);
            }
        }

        DAT_12BD4.vr.z = DAT_12BD4.vr.z + param1.GET_OFFSET_08(5) & 0xfff;
    }

    //FUN_CB7C (ST8)
    private void FUN_CB7C()
    {
        DAT_12BC8.vr.y += 10;
        DAT_12BCC.vr.y += 10;
        DAT_12BD0.vr.y += 10;
    }

    //FUN_D0CC (ST8)
    private void FUN_D0CC(byte param1, uint param2, short param3, short param4, short param5)
    {
        CriParticle oVar1;

        oVar1 = SceneManager.instance.FUN_5FFA0();

        if (oVar1 != null)
        {
            oVar1.tags = 17;
            oVar1.DAT_69 = (byte)(param2 >> 0x10);
            oVar1.DAT_2F = param1;
            oVar1.DAT_68 = (byte)param2;
            oVar1.screen.x = param3;
            oVar1.screen.y = param4;
            oVar1.screen.z = param5;
            oVar1.DAT_65 |= 0x80;
        }
    }

    //FUN_D19C (ST8)
    private void FUN_D19C(CriParticle param1)
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

    //FUN_D210 (ST8)
    private void FUN_D210(CriParticle param1)
    {
        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) != 0)
            {
                if ((sbyte)param1.DAT_6A < 3)
                {
                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.DAT_6A++;
                }

                if (param1.DAT_6A != 3) goto LAB_D334;

                goto LAB_D328;
            }

            if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0 && param1.DAT_69 < 2)
                {
                    if (param1.DAT_6A == 3) goto LAB_D328;

                    GameManager.instance.FUN_5C94C(null, 144);
                    param1.DAT_69++;
                }

                if (param1.DAT_6A != 3) goto LAB_D334;

                goto LAB_D328;
            }

            if ((sbyte)param1.DAT_69 < 1)
            {
                if (param1.DAT_6A != 3) goto LAB_D334;

                goto LAB_D328;
            }

            if (param1.DAT_6A != 3)
            {
                GameManager.instance.FUN_5C94C(null, 144);
                param1.DAT_69--;
            }
        }
        else
        {
            if (0 < (sbyte)param1.DAT_6A)
            {
                GameManager.instance.FUN_5C94C(null, 144);
                param1.DAT_6A--;
            }

            if (param1.DAT_6A != 3) goto LAB_D334;

            goto LAB_D328;
        }

        LAB_D328:
        param1.DAT_69 = 1;
        
        LAB_D334:
        if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 145);
            param1.DAT_6C[param1.DAT_68] = DAT_124E4[param1.DAT_6A * 3 + param1.DAT_69];
            param1.DAT_68++;

            if (3 < (sbyte)param1.DAT_68)
                param1.DAT_3C++;
        }

        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 146);

            if (param1.DAT_68 < 1)
            {
                InventoryManager.FUN_4A7E8(2, 11, true);
                param1.DAT_3C = 3;
            }
            else
                param1.DAT_68--;

            param1.DAT_6C[param1.DAT_68] = 0;
        }
    }

    //FUN_D424 (ST8)
    private void FUN_D424(CriParticle param1)
    {
        uint uVar1;
        byte bVar2;

        bVar2 = 0;
        param1.DAT_3C++;
        uVar1 = 0;

        do
        {
            if (param1.DAT_6C[uVar1] != DAT_124F0[param1.DAT_2F * 4 + uVar1])
            {
                InventoryManager.FUN_4A7E8(2, 10, true);
                GameManager.instance.FUN_5C94C(null, 148);
                return;
            }

            bVar2++;
            uVar1 = bVar2;
        } while (bVar2 < 4);

        GameManager.instance.FUN_5C94C(null, 147);
        InventoryManager.FUN_4A7E8(2, 9, true);
    }

    //FUN_DA9C (ST8)
    private void FUN_DA9C(CriInteract param1)
    {
        uint uVar2;

        param1.DAT_15 = -1;
        param1.BDAT_16 = 0;
        param1.DAT_14 = 0;
        param1.UDAT_0C = 0;
        param1.DAT_08 = 320;
        param1.DAT_0A = 240;
        param1.DAT_18 = 80;
        uVar2 = 0;

        do
        {
            DAT_12D3C[uVar2] = 0;
            uVar2++;
        } while (uVar2 < 20);

        param1.DAT_03 = (sbyte)uVar2;
    }

    //FUN_DAFC (ST8)
    private void FUN_DAFC(CriInteract param1)
    {
        bool bVar1;

        if ((byte)param1.DAT_15 < 0x90)
            DAT_12C00[12] = 6;

        if (0xf0 < (byte)param1.DAT_15)
            DAT_12C00[12] = -6;

        param1.DAT_15 += DAT_12C00[12];
        bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

        if (!bVar1)
        {
            //FUN_E2D8

            if ((param1.BDAT_0C & 0x10) != 0)
                GameManager.instance.FUN_5C94C(null, 153);

            param1.BDAT_0C++;
        }
        else
        {
            param1.DAT_03 = 2;
            param1.UDAT_0C = 0;
            GameManager.instance.FUN_5C860(153);
            GameManager.instance.FUN_5C94C(null, 151);
        }
    }

    //FUN_DC00 (ST8)
    private void FUN_DC00(CriInteract param1)
    {
        uint uVar1;

        FUN_DDA8(param1);

        if (param1.BDAT_16 == 0)
        {
            param1.ADAT_10 = DAT_12D3C;
            param1.IDAT_10 = param1.DAT_14;
            DAT_12D3C[param1.DAT_14] = param1.BDAT_0C;

            if (31 < param1.ADAT_10[param1.IDAT_10])
            {
                if (param1.IDAT_10 != 19)
                {
                    param1.BDAT_0C = 0;
                    param1.DAT_0D = 0;
                    param1.BDAT_0E = 0;
                    param1.DAT_0F = 0;
                    param1.DAT_14++;
                    return;
                }

                param1.BDAT_16 = 1;
                param1.UDAT_0C = 0;
                GameManager.instance.FUN_5C94C(null, 152);
            }

            uVar1 = param1.UDAT_0C + 4;
        }
        else
        {
            uVar1 = param1.UDAT_0C + 1;

            if (9 < param1.UDAT_0C)
            {
                if (0xef < param1.DAT_18)
                {
                    param1.DAT_18 = 0xf0;
                    param1.UDAT_0C = 0;
                    param1.DAT_03 = 3;
                    GameManager.instance.FUN_5C860(151);
                    return;
                }

                param1.DAT_18 += 4;
                return;
            }
        }

        param1.UDAT_0C = uVar1;
    }

    //FUN_DD10 (ST8)
    private void FUN_DD10(CriInteract param1)
    {
        FUN_DDA8(param1);

        if (param1.UDAT_0C < 20)
            param1.UDAT_0C++;
        else
        {
            if (param1.DAT_18 < 11U)
                param1.DAT_03 = 4;
            else
            {
                InventoryManager.FUN_4A7E8(3, 0x20, true);
                param1.DAT_18 -= 10;
            }
        }
    }

    //FUN_DD9C (ST8)
    private void FUN_DD9C(CriInteract param1)
    {
        param1.DAT_03 = 5;
    }

    //FUN_DDA8 (ST8)
    private void FUN_DDA8(CriInteract param1)
    {
        int iVar3;
        uint uVar5;
        short sVar6;
        CriCamera cVar8;
        Vector3Int local_a0;
        Vector3Int local_98;
        Vector3Int local_90;
        int local_40;
        int local_30;
        Matrix3x3 auStack104;

        auStack104 = new Matrix3x3();
        local_40 = 0;
        local_30 = 0;
        cVar8 = SceneManager.instance.cCamera;
        Utilities.SetRotMatrix(ref cVar8.cTransform.rotation);
        Utilities.SetTransMatrix(ref cVar8.cTransform);
        param1.ADAT_10 = DAT_12D3C;

        do
        {
            iVar3 = local_30;
            local_98 = new Vector3Int(0, 0, 0);
            uVar5 = 0;

            if (param1.ADAT_10[param1.IDAT_10] != 0xff)
            {
                sVar6 = 0;

                do
                {
                    Utilities.RotMatrix(ref local_98, ref auStack104);
                    local_90 = new Vector3Int(-600, 0, 0);
                    local_a0 = new Vector3Int(-400, 0, 0);
                    local_90 = Utilities.ApplyMatrixSV(ref auStack104, ref local_90);
                    local_a0 = Utilities.ApplyMatrixSV(ref auStack104, ref local_a0);
                    local_90.x -= cVar8.DAT_30.x + 6000;
                    local_90.z -= cVar8.DAT_30.z + 5998;
                    local_a0.x -= cVar8.DAT_30.x + 6000;
                    local_a0.z -= cVar8.DAT_30.z + 5998;

                    if (local_40 == 19)
                    {
                        local_90.y = (local_90.y - cVar8.DAT_30.y) - 0x720;
                        local_a0.y = (local_a0.y - cVar8.DAT_30.y) - 0x720;
                    }
                    else
                    {
                        local_90.y = (local_90.y - cVar8.DAT_30.y) + sVar6 + iVar3;
                        local_a0.y = (local_a0.y - cVar8.DAT_30.y) + sVar6 + iVar3;
                    }

                    Utilities.SetRotMatrix(ref cVar8.cTransform.rotation);
                    Utilities.SetTransMatrix(ref cVar8.cTransform);
                    //...
                    local_98.y += 0x80;
                    uVar5++;
                    sVar6 -= 3;
                } while (uVar5 < param1.ADAT_10[param1.IDAT_10] + 1);
            }

            uVar5 = 0;

            if (param1.ADAT_10[param1.IDAT_10] != 0)
            {
                //...
            }

            local_30 -= 0x60;
            local_40++;
            param1.IDAT_10++;
        } while (local_40 < 20);
    }

    //FUN_E42C (ST8)
    private void FUN_E42C(CriInteract param1)
    {
        uint uVar3;

        uVar3 = 0;
        param1.DAT_1B = 0;
        param1.DAT_19 = 0;
        param1.DAT_18 = 0;
        param1.DAT_17 = 0;
        param1.BDAT_16 = 0;
        param1.DAT_1A = 0x20;
        GameManager.instance.DAT_38 = 0x73;

        do
        {
            DAT_12D50[uVar3] = 0;
            DAT_12D60[uVar3] = 0;
            uVar3++;
        } while (uVar3 < 3);

        param1.DAT_03 = 9;
        GameManager.instance.FUN_2984C(0x8011);
    }

    //FUN_E4B4 (ST8)
    private void FUN_E4B4(CriInteract param1)
    {
        bool bVar1;

        if (param1.BDAT_16 < 30)
            param1.BDAT_16++;
        else
        {
            //...
            bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

            if (bVar1)
                param1.DAT_03 = 4;
        }

        //FUN_FBA8
    }

    //FUN_E52C (ST8)
    private void FUN_E52C(CriInteract param1)
    {
        if (param1.BDAT_16 < 50)
        {
            param1.BDAT_16++;
            //FUN_F4B4
        }
        else
        {
            //FUN_ECF4

            if (param1.DAT_17 == -1)
            {
                param1.BDAT_16 = 0;
                param1.DAT_17 = 0;
                param1.DAT_03 = 6;
            }

            param1.DAT_17++;
        }

        if (param1.BDAT_16 == 35)
            GameManager.instance.FUN_2984C(0x8012);

        //...
    }

    //FUN_E5D8 (ST8)
    private void FUN_E5D8(CriInteract param1)
    {
        if (param1.BDAT_16 < 50)
        {
            param1.BDAT_16++;
            //FUN_F4B4
        }
        else
        {
            //FUN_ECF4

            if (param1.DAT_17 == -1)
            {
                param1.BDAT_16 = 0;
                param1.DAT_17 = 0;
                param1.DAT_03 = 7;
            }

            param1.DAT_17++;
        }

        if (param1.BDAT_16 == 35)
            GameManager.instance.FUN_2984C(0x8012);

        //...
    }

    //FUN_E684 (ST8)
    private void FUN_E684(CriInteract param1)
    {
        param1.DAT_03 = 5;
        GameManager.instance.DAT_38 = 0;
    }

    //FUN_10240 (ST8)
    private void FUN_10240(CriInteract param1)
    {
        int iVar3;

        iVar3 = 0;
        param1.BDAT_08 = 0;
        param1.BDAT_09 = 0;
        param1.BDAT_0A = 0;
        param1.DAT_0B = 0;
        param1.BDAT_0C = 0;
        param1.DAT_0D = 0;
        param1.BDAT_0E = 0;
        param1.DAT_0F = 0;
        param1.DAT_14 = 0;
        param1.DAT_15 = 0;
        param1.BDAT_16 = 0;
        param1.DAT_17 = 0;
        param1.DAT_18 = 0;
        param1.DAT_19 = 0;
        param1.DAT_1A = 0;
        param1.DAT_1B = 0;

        do
        {
            DAT_12D60[iVar3] = -1;
            DAT_12D70[iVar3] = -1;
            iVar3++;
        } while (iVar3 < 11);

        param1.BDAT_0C = 10;
        param1.DAT_0D = 10;
        param1.SDAT_10 = 0xb0;
        param1.SDAT_12 = 0x70;
        param1.BDAT_16 = 0x20;
        param1.DAT_03++;
    }

    //FUN_102B8 (ST8)
    private void FUN_102B8(CriInteract param1)
    {
        sbyte sVar1;
        byte bVar2;
        uint uVar3;

        if ((InputManager.controllers[0].DAT_B58B8 & 0x1000) == 0)
        {
            if ((InputManager.controllers[0].DAT_B58B8 & 0x4000) == 0)
            {
                if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) == 0)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) == 0)
                    {
                        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) == 0)
                            return;

                        GameManager.instance.FUN_5C94C(null, 145);
                        bVar2 = (byte)(param1.DAT_0F - 1);

                        if (param1.DAT_0F == 0)
                        {
                            InventoryManager.FUN_4A7E8(2, 0xb, true);
                            param1.FUN_5FF98();
                            return;
                        }

                        param1.DAT_0F = bVar2;
                        DAT_12D70[bVar2] = -1;

                        if (param1.DAT_0F == 0)
                            param1.BDAT_0C = 10;
                        else
                            param1.BDAT_0C = (byte)DAT_12D70[param1.DAT_0F - 1];

                        if (param1.DAT_0F < 2)
                            param1.DAT_0D = 10;
                        else
                            param1.DAT_0D = (byte)DAT_12D70[param1.DAT_0F - 2];

                        DAT_12D80[param1.BDAT_0C] = -1;
                        param1.DAT_18 = 1;
                        sVar1 = (sbyte)(param1.DAT_03 + 1);
                    }
                    else
                    {
                        uVar3 = DAT_125E8[param1.BDAT_0C * 4 + 3];

                        if (uVar3 == 0x80)
                            return;

                        if (DAT_12D80[uVar3] != -1)
                            return;

                        param1.DAT_0D = param1.BDAT_0C;
                        param1.DAT_0F++;
                        param1.BDAT_0C = DAT_125E8[param1.BDAT_0C * 4 + 3];
                        DAT_12D80[param1.DAT_0D] = 0;
                        sVar1 = (sbyte)(param1.DAT_03 + 1);
                    }
                }
                else
                {
                    uVar3 = DAT_125E8[param1.BDAT_0C * 4 + 2];

                    if (uVar3 == 0x80)
                        return;

                    if (DAT_12D80[uVar3] != -1)
                        return;

                    param1.DAT_0D = param1.BDAT_0C;
                    param1.DAT_0F++;
                    param1.BDAT_0C = DAT_125E8[param1.BDAT_0C * 4 + 2];
                    DAT_12D80[param1.DAT_0D] = 0;
                    sVar1 = (sbyte)(param1.DAT_03 + 1);
                }
            }
            else
            {
                uVar3 = DAT_125E8[param1.BDAT_0C * 4 + 1];

                if (uVar3 == 0x80)
                    return;

                if (DAT_12D80[uVar3] != -1)
                    return;

                param1.DAT_0D = param1.BDAT_0C;
                param1.DAT_0F++;
                param1.BDAT_0C = DAT_125E8[param1.BDAT_0C * 4 + 1];
                DAT_12D80[param1.DAT_0D] = 0;
                sVar1 = (sbyte)(param1.DAT_03 + 1);
            }
        }
        else
        {
            uVar3 = DAT_125E8[param1.BDAT_0C * 4];

            if (uVar3 == 0x80)
                return;

            if (DAT_12D80[uVar3] != -1)
                return;

            param1.DAT_0D = param1.BDAT_0C;
            param1.DAT_0F++;
            param1.BDAT_0C = DAT_125E8[param1.BDAT_0C * 4];
            DAT_12D80[param1.DAT_0D] = 0;
            sVar1 = (sbyte)(param1.DAT_03 + 1);
        }

        param1.DAT_03 = sVar1;
    }

    //FUN_105D4 (ST8)
    private void FUN_105D4(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;
        int iVar3;
        byte bVar4;
        short sVar5;
        int iVar6;
        int pbVar7;
        int iVar8;

        param1.BDAT_16 = 0x80;

        if (param1.BDAT_08 != 0)
        {
            iVar8 = 2;

            if (param1.BDAT_08 != 1)
                return;

            bVar1 = (byte)(param1.DAT_15 & 3);
            param1.DAT_14 += 2;

            if (bVar1 == 1)
            {
                iVar3 = param1.SDAT_10 - (byte)param1.DAT_14;
                param1.SDAT_10 = (short)iVar3;
                pbVar7 = param1.BDAT_0C * 2;

                if (iVar3 * 0x10000 >> 0x10 < DAT_125C4[pbVar7] - 4)
                {
                    iVar8 = 1;
                    param1.SDAT_10 = (short)(DAT_125C4[pbVar7] - 4);
                }
            }
            else
            {
                if (bVar1 < 2)
                {
                    if ((param1.DAT_15 & 3) == 0)
                        iVar8 = 1;
                }
                else
                {
                    if (bVar1 == 2)
                    {
                        sVar5 = (short)(param1.SDAT_10 + (byte)param1.DAT_14);
                        param1.SDAT_10 = sVar5;
                        pbVar7 = param1.BDAT_0C * 2;

                        if (DAT_125C4[pbVar7] - 4 < sVar5)
                        {
                            iVar8 = 1;
                            param1.SDAT_10 = (short)(DAT_125C4[pbVar7] - 4);
                        }
                    }
                }
            }

            bVar1 = (byte)(param1.DAT_15 >> 4);
            bVar4 = (byte)(bVar1 & 3);

            if (bVar4 == 1)
            {
                iVar6 = param1.SDAT_12 - (byte)param1.DAT_14;
                param1.SDAT_12 = (short)iVar6;
                iVar3 = param1.BDAT_0C * 2;

                if (DAT_125C4[iVar3 + 1] - 4 <= iVar6 * 0x10000 >> 0x10) goto LAB_10894;
            }
            else
            {
                if (bVar4 < 2)
                {
                    if ((bVar1 & 3) == 0)
                        iVar8--;

                    goto LAB_10894;
                }

                if (bVar4 != 2) goto LAB_10894;

                sVar5 = (short)(param1.SDAT_12 + (byte)param1.DAT_14);
                param1.SDAT_12 = sVar5;
                iVar3 = param1.BDAT_0C * 2;

                if (sVar5 <= DAT_125C4[iVar3 + 1] - 4) goto LAB_10894;
            }

            iVar8--;
            param1.SDAT_12 = (short)(DAT_125C4[iVar3 + 1] - 4);

            LAB_10894:
            if (iVar8 != 0)
                return;

            DAT_12D70[param1.DAT_0F - 1] = (sbyte)param1.BDAT_0C;

            if (param1.BDAT_0C < 10 && param1.DAT_18 == 0)
            {
                GameManager.instance.FUN_5C94C(null, DAT_125DC[param1.BDAT_0C]);
                param1.DAT_19 = 1;
            }

            param1.DAT_03 = 1;
            param1.DAT_18 = 0;
            param1.BDAT_08 = 0;

            if (param1.DAT_0F != 6)
                return;

            iVar8 = FUN_10BDC(param1) ? 1 : 0;
            bVar2 = 4;

            if (iVar8 == 0)
                bVar2 = 3;

            param1.DAT_03 = (sbyte)bVar2;
            return;
        }

        param1.DAT_14 = 2;
        param1.DAT_15 = 0;

        if (DAT_125C4[param1.BDAT_0C * 2] - 4 < param1.SDAT_10)
        {
            bVar1 = (byte)(param1.DAT_15 | 1);
            param1.DAT_15 = (sbyte)bVar1;
        }
        else
        {
            if (param1.SDAT_10 < DAT_125C4[param1.BDAT_0C * 2] - 4)
            {
                bVar1 = (byte)(param1.DAT_15 | 2);
                param1.DAT_15 = (sbyte)bVar1;
            }
        }

        if (DAT_125C4[param1.BDAT_0C * 2 + 1] - 4 < param1.SDAT_12)
            bVar1 = (byte)(param1.DAT_15 | 0x10);
        else
        {
            if (DAT_125C4[param1.BDAT_0C * 2 + 1] - 4 <= param1.SDAT_12)
                goto LAB_106B4;

            bVar1 = (byte)(param1.DAT_15 | 0x20);
        }

        param1.DAT_15 = (sbyte)bVar1;
        LAB_106B4:
        param1.BDAT_08++;
    }

    //FUN_10934 (ST8)
    private void FUN_10934(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)param1.DAT_0B;
        param1.DAT_0B = (sbyte)(bVar1 + 1);

        if (19 < bVar1)
        {
            if (param1.BDAT_08 == 0)
            {
                GameManager.instance.FUN_5C94C(null, 150);
                param1.BDAT_08++;
            }
            else
            {
                bVar1 = param1.BDAT_09;
                param1.BDAT_09 = (byte)(bVar1 + 1);

                if (60 < bVar1)
                {
                    InventoryManager.FUN_4A7E8(2, 10, true);
                    param1.FUN_5FF98();
                }
            }

            //...
        }
    }

    //FUN_10A88 (ST8)
    private void FUN_10A88(CriInteract param1)
    {
        byte bVar1;

        bVar1 = (byte)param1.DAT_0B;
        param1.DAT_0B = (sbyte)(bVar1 + 1);

        if (19 < bVar1)
        {
            if (param1.BDAT_08 == 0)
            {
                GameManager.instance.FUN_5C94C(null, 149);
                param1.BDAT_08++;
            }
            else
            {
                bVar1 = param1.BDAT_09;
                param1.BDAT_09 = (byte)(bVar1 + 1);

                if (60 < bVar1)
                {
                    InventoryManager.FUN_4A7E8(2, 9, true);
                    param1.FUN_5FF98();
                }
            }

            //...
        }
    }

    //FUN_10BDC (ST8)
    private bool FUN_10BDC(CriInteract param1)
    {
        int iVar2;
        int iVar3;

        iVar2 = 0;

        do
        {
            iVar3 = iVar2 + 1;

            if (DAT_12D70[iVar2] != DAT_1262C[iVar2])
                return false;

            iVar2 = iVar3;
        } while (iVar3 < 6);

        return true;
    }

    //FUN_11758 (ST8)
    private void FUN_11758(CriInteract param1)
    {
        param1.DAT_08 = 0x140;
        param1.DAT_0A = 0xf0;
        param1.DAT_10 = 0x71;
        param1.DAT_12 = 0x10;
        //...
        param1.DAT_03 = 1;
    }

    //FUN_117C4 (ST8)
    private void FUN_117C4(CriInteract param1)
    {
        sbyte sVar1;
        bool bVar2;

        if (param1.DAT_02 == 0)
        {
            bVar2 = InventoryManager.FUN_4A87C(3, 0x20);
            sVar1 = 0x10;

            if (!bVar2)
                sVar1 = 2;
        }
        else
        {
            if (param1.DAT_02 != 1) goto LAB_1181C;

            sVar1 = (sbyte)param1.DAT_04;
        }

        param1.DAT_12 = sVar1;

        LAB_1181C:
        if (param1.DAT_10 < 0x10)
            param1.DAT_11 = (byte)param1.DAT_12;

        if (0x70 < param1.DAT_10)
            param1.DAT_11 = (byte)-param1.DAT_12;

        param1.DAT_10 += param1.DAT_11;
    }

    //FUN_11884 (ST8)
    private void FUN_11884(CriInteract param1)
    {
        LevelManager.instance.FUN_60100(param1.PTR_0C);
        param1.DAT_03 = 3;
    }

    //FUN_1E4 (ST8)
    public static void FUN_1E4(CriParticle param1)
    {
        instance.PTR_FUN_11F90[param1.DAT_3C](param1);
    }

    //FUN_410 (ST8)
    public static void FUN_410(CriParticle param1)
    {
        instance.PTR_FUN_12020[param1.DAT_3C](param1);
    }

    //FUN_684 (ST8)
    public static void FUN_684(CriParticle param1)
    {
        instance.PTR_FUN_12048[param1.DAT_3C](param1);
    }

    //FUN_824 (ST8)
    public static void FUN_824(CriParticle param1)
    {
        instance.PTR_FUN_12054[param1.DAT_3C](param1);
    }

    //FUN_908 (ST8)
    public static void FUN_908(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_12080[param1.DAT_3C](param1);
    }

    //FUN_A68 (ST8)
    public static void FUN_A68(CriInteract param1)
    {
        ((CriPlayer)SceneManager.instance.skinnedObjects[10]).DAT_1C0 &= 0xfffffffe;
        instance.PTR_FUN_1208C[param1.DAT_03](param1);
    }

    //FUN_1724 (ST8)
    public static void FUN_1724(CriInteract param1)
    {
        instance.PTR_FUN_120AC[param1.DAT_03](param1);
    }

    //FUN_1760 (ST8)
    public static void FUN_1760(CriInteract param1)
    {
        instance.PTR_FUN_12140[param1.DAT_03](param1);
    }

    //FUN_2C7C (ST8)
    public static void FUN_2C7C(CriInteract param1)
    {
        instance.PTR_FUN_12164[param1.DAT_03](param1);
    }

    //FUN_2F84 (ST8)
    public static void FUN_2F84(CriInteract param1)
    {
        instance.PTR_FUN_121E4[param1.DAT_03](param1);
        InventoryManager.FUN_4A7E8(3, 0x38, false);
    }

    //FUN_3410 (ST8)
    public static void FUN_3410(CriInteract param1)
    {
        instance.PTR_FUN_121F4[param1.DAT_03](param1);
        //...
    }

    //FUN_61E0 (ST8)
    public static void FUN_61E0(CriInteract param1)
    {
        instance.PTR_FUN_122B0[param1.DAT_03](param1);
        //...
    }

    //FUN_87E4 (ST8)
    public static void FUN_87E4(CriInteract param1)
    {
        byte bVar1;

        //FUN_A400

        if (param1.DAT_19 == 0)
        {
            bVar1 = (byte)(param1.DAT_18 + 6);
            param1.DAT_18 = bVar1;

            if (bVar1 < 0x81) goto LAB_886C;

            bVar1 = param1.DAT_19;
            param1.DAT_18 = 0x80;
        }
        else
        {
            bVar1 = (byte)(param1.DAT_18 - 6);
            param1.DAT_18 = bVar1;

            if (0x1f < bVar1) goto LAB_886C;

            bVar1 = param1.DAT_19;
            param1.DAT_18 = 0x20;
        }

        param1.DAT_19 = (byte)(bVar1 ^ 1);
        LAB_886C:
        //...
        instance.PTR_FUN_123D4[param1.DAT_03](param1);
    }

    //FUN_A7BC (ST8)
    public static void FUN_A7BC(CriStatic param1)
    {
        instance.PTR_FUN_12454[param1.tags](param1);
    }

    //FUN_ABCC (ST8)
    public static void FUN_ABCC(CriInteract param1)
    {
        instance.PTR_FUN_1248C[param1.DAT_03](param1);
        //...
    }

    //FUN_D150 (ST8)
    public static void FUN_D150(CriParticle param1)
    {
        instance.PTR_FUN_12508[param1.DAT_3C](param1);
        //...
    }

    //FUN_E3F0 (ST8)
    public static void FUN_E3F0(CriInteract param1)
    {
        instance.PTR_FUN_12518[param1.DAT_03](param1);
    }

    //FUN_F738 (ST8)
    public static void FUN_F738(CriInteract param1)
    {
        instance.PTR_FUN_1255C[param1.DAT_03](param1);
        //...
    }

    //FUN_10118 (ST8)
    public static void FUN_10118(CriInteract param1)
    {
        byte bVar1;

        if (param1.DAT_03 < 2)
        {
            if (param1.DAT_17 == 0)
            {
                bVar1 = (byte)(param1.BDAT_16 + 6);
                param1.BDAT_16 = bVar1;

                if (bVar1 < 0x81) goto LAB_101C8;

                param1.BDAT_16 = 0x80;
            }
            else
            {
                bVar1 = (byte)(param1.BDAT_16 - 6);
                param1.BDAT_16 = bVar1;

                if (31 < bVar1) goto LAB_101C8;

                param1.BDAT_16 = 0x20;
            }

            param1.DAT_17 ^= 1;
            param1.BDAT_0E ^= 1;
        }
        else
        {
            param1.BDAT_16 = 0x80;
            param1.BDAT_0E = 1;
        }

        LAB_101C8:
        instance.PTR_FUN_12614[param1.DAT_03](param1);
        //...
    }

    //FUN_118B8 (ST8)
    public static void FUN_118B8(CriInteract param1)
    {
        instance.PTR_FUN_1268C[param1.DAT_03](param1);
    }
}
