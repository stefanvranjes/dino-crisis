using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST6 : LevelManager
{
    public static new ST6 instance;

    private uint[] DAT_1C = new uint[] { 4, 5, 6, 7 };
    private byte[] DAT_2C = new byte[] { 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4, 2 };
    private byte[] DAT_40 = new byte[] { 0, 1, 2, 3, 4, 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4, 2, 49, 51, 52 };
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
    private delegate void FUN_16754(CriPlayer p); //0x16754 (ST6)
    private delegate void FUN_1675C(CriPlayer p); //0x1675C (ST6)
    private delegate void FUN_16764(CriPlayer p); //0x16764 (ST6)
    private delegate void FUN_1676C(CriPlayer p); //0x1676C (ST6)
    private delegate void FUN_1679C(CriPlayer p); //0x1679C (ST6)
    private delegate void FUN_167F4(CriPlayer p); //0x167F4 (ST6)
    private delegate void FUN_16818(CriPlayer p); //0x16818 (ST6)
    private delegate void FUN_16820(CriPlayer p); //0x16820 (ST6)
    private delegate void FUN_1683C(CriPlayer p); //0x1683C (ST6)
    private delegate void FUN_1687C(CriPlayer p); //0x1687C (ST6)
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
    private delegate void FUN_16B40(CriPlayer p); //0x16B40 (ST6)
    private delegate void FUN_16B50(CriPlayer p); //0x16B50 (ST6)
    private delegate void FUN_16B58(CriPlayer p); //0x16B58 (ST6)
    private delegate void FUN_16B74(CriPlayer p); //0x16B74 (ST6)
    private delegate void FUN_16B7C(CriPlayer p); //0x16B7C (ST6)
    private delegate void FUN_16BB0(CriPlayer p); //0x16BB0 (ST6)
    private delegate void FUN_16BC4(CriPlayer p); //0x16BC4 (ST6)
    private delegate void FUN_16BCC(CriPlayer p); //0x16BCC (ST6)
    private delegate void FUN_16BE4(CriPlayer p); //0x16BE4 (ST6)
    private delegate void FUN_16F18(CriParticle p); //0x16F18 (ST6)
    private delegate void FUN_16F2C(CriParticle p); //0x16F2C (ST6)
    private delegate void FUN_16F38(CriParticle p); //0x16F38 (ST6)
    private delegate void FUN_16F74(CriParticle p); //0x16F74 (ST6)
    private delegate void FUN_16F84(CriParticle p); //0x16F84 (ST6)
    private delegate void FUN_16FA8(CriParticle p); //0x16FA8 (ST6)
    private delegate void FUN_16FB4(CriParticle p); //0x16FB4 (ST6)
    private delegate void FUN_16FD4(CriParticle p); //0x16FD4 (ST6)
    private delegate void FUN_16FFC(CriParticle p); //0x16FFC (ST6)
    private delegate void FUN_1701C(CriParticle p); //0x1701C (ST6)
    private delegate void FUN_1706C(CriParticle p); //0x1706C (ST6)
    private delegate void FUN_170AC(CriParticle p); //0x170AC (ST6)
    private delegate void FUN_170B8(CriParticle p); //0x170B8 (ST6)
    private delegate void FUN_170C4(CriInteract i); //0x170C4 (ST6)
    private delegate void FUN_170F0(CriInteract i); //0x170F0 (ST6)
    private delegate void FUN_17150(CriInteract i); //0x17150 (ST6)
    private delegate void FUN_171A8(CriInteract i); //0x171A8 (ST6)
    private delegate void FUN_171B4(CriInteract i); //0x171B4 (ST6)
    private delegate void FUN_171D8(CriInteract i); //0x171D8 (ST6)
    private delegate void FUN_171F0(CriInteract i); //0x171F0 (ST6)
    private delegate void FUN_171FC(CriInteract i); //0x171FC (ST6)
    private delegate void FUN_17310(CriInteract i); //0x17310 (ST6)
    private delegate void FUN_173D4(CriInteract i); //0x173D4 (ST6)
    private delegate void FUN_173E0(CriStatic s); //0x173E0 (ST6)
    private delegate void FUN_173E8(CriStatic s); //0x173E8 (ST6)
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
    private FUN_16754[] PTR_FUN_16754; //0x16754 (ST6)
    private FUN_1675C[] PTR_FUN_1675C; //0x1675C (ST6)
    private FUN_16764[] PTR_FUN_16764; //0x16764 (ST6)
    private FUN_1676C[] PTR_FUN_1676C; //0x1676C (ST6)
    private FUN_1679C[] PTR_FUN_1679C; //0x1679C (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_167A4; //0x167A4 (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_167B8; //0x167B8 (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_167CC; //0x167CC (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_167E0; //0x167E0 (ST6)
    private FUN_167F4[] PTR_FUN_167F4; //0x167F4 (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_16804; //0x16804 (ST6)
    private FUN_16818[] PTR_FUN_16818; //0x16818 (ST6)
    private FUN_16820[] PTR_FUN_16820; //0x16820 (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_16828; //0x16828 (ST6)
    private FUN_1683C[] PTR_FUN_1683C; //0x1683C (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_16868; //0x16868 (ST6)
    private FUN_1687C[] PTR_FUN_1687C; //0x1687C (ST6)
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
    private FUN_16B40[] PTR_FUN_16B40; //0x16B40 (ST6)
    private FUN_16B50[] PTR_FUN_16B50; //0x16B50 (ST6)
    private FUN_16B58[] PTR_FUN_16B58; //0x16B58 (ST6)
    private CriInteract.FUN_0C[] PTR_FUN_16B60; //0x16B60 (ST6)
    private FUN_16B74[] PTR_FUN_16B74; //0x16B74 (ST6)
    private FUN_16B7C[] PTR_FUN_16B7C; //0x16B7C (ST6)
    private FUN_16BB0[] PTR_FUN_16BB0; //0x16BB0 (ST6)
    private FUN_16BC4[] PTR_FUN_16BC4; //0x16BC4 (ST6)
    private FUN_16BCC[] PTR_FUN_16BCC; //0x16BCC (ST6)
    private FUN_16BE4[] PTR_FUN_16BE4; //0x16BE4 (ST6)
    private UNK_9B314[] PTR_DAT_16D20; //0x16D20 (ST6)
    private short[] DAT_16EAC = new short[] { -3500, 0, -1500, -1500 };
    private Vector3Int[] DAT_16EB4; //0x16EB4 (ST6)
    private short[] DAT_16ED4 = new short[] { -1500, 0, -1500, -1500, 120, 60 };
    private Vector3Int[] DAT_16EE0; //0x16EE0 (ST6)
    private uint[] DAT_16F00 = new uint[] { 0x8011d1ec, 0x8011d204, 0x8011d21c, 0x8011d2ec, 0x8011d37c, 0x8011d49c };
    private FUN_16F18[] PTR_FUN_16F18; //0x16F18 (ST6)
    private uint[] DAT_16F24 = new uint[] { 0x8012cf94 };
    private ushort[] DAT_16F28 = new ushort[] { 0x7f3c };
    private FUN_16F2C[] PTR_FUN_16F2C; //0x16F2C (ST6)
    private FUN_16F38[] PTR_FUN_16F38; //0x16F38 (ST6)
    private short[] DAT_16F48 = new short[] { -2320, -1230, -3900, -2610, -1230, -3900, -2900, -1230, -3900, -3190, -1230, -3900, -3480, -1230, -3900, -4390, -1075, 2600, -2290, -2580, -2870, -3160 };
    private FUN_16F74[] PTR_FUN_16F74; //0x16F74 (ST6)
    private FUN_16F84[] PTR_FUN_16F84; //0x16F84 (ST6)
    private uint[] DAT_16F90 = new uint[] { 0x8010f728, 0, 0x8010f730 }; //0x16F90 (ST6)
    private uint[] DAT_16F94 = new uint[] { 1, 1, 1 }; //0x16F94 (ST6)
    private FUN_16FA8[] PTR_FUN_16FA8; //0x16FA8 (ST6)
    private FUN_16FB4[] PTR_FUN_16FB4; //0x16FB4 (ST6)
    private uint[] DAT_16FC4 = new uint[] { 0x80120020, 0x80120060, 0x80120068, 0x80120070 }; //0x16FC4 (ST6)
    private FUN_16FD4[] PTR_FUN_16FD4; //0x16FD4 (ST6)
    private uint[] DAT_16FE0 = new uint[] { 0x8012cc24, 0x8012cc2c, 0x8012cc34, 0x8012cc4c, 0x8012cc54, 0x8012cc5c, 0x8012cc64 }; //0x16FE0 (ST6)
    private FUN_16FFC[] PTR_FUN_16FFC; //0x16FFC (ST6)
    private uint[] DAT_17008 = new uint[] { 0x8011a394, 0x8011a3d4, 0x8011a414, 0x8011a47c, 0x8011a54c }; //0x17008 (ST6)
    private FUN_1701C[] PTR_FUN_1701C; //0x1701C (ST6)
    private uint[] DAT_17028 = new uint[] { 0x801402e8, 0x80140488, 0x80140500, 0x80140540, 0x80140568, 0x80140570, 0x80140578, 0x80140580, 0x80140588, 0x80140590, 0x80140598, 0x801405a8, 0x801405b0 }; //0x17028 (ST6)
    private byte[] DAT_1705C = new byte[] { 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0 }; //0x1705C (ST6)
    private FUN_1706C[] PTR_FUN_1706C; //0x1706C (ST6)
    private uint[] DAT_17078 = new uint[] { 0x801454b8, 0x801454d0, 0x801454e8 }; //0x17078 (ST6)
    private FUN_170AC[] PTR_FUN_170AC; //0x170AC (ST6)
    private FUN_170B8[] PTR_FUN_170B8; //0x170B8 (ST6)
    private FUN_170C4[] PTR_FUN_170C4; //0x170C4 (ST6)
    private byte[] DAT_170E0 = new byte[] { 1, 2, 5, 6, 3, 7, 0, 0, 1, 2, 8, 4, 3, 7, 0, 0 }; //0x170E0 (ST6)
    private FUN_170F0[] PTR_FUN_170F0; //0x170F0 (ST6)
    private byte[] DAT_17118 = new byte[] { 12, 0, 12, 0, 12, 0, 244, 0, 244, 0, 244, 0, 244, 0, 244, 0, 12, 0, 12, 0, 0, 0, 0, 0, 0, 0, 78, 0, 0, 0, 208, 0, 0, 0, 110, 0, 0, 1, 0, 0, 32, 0, 78, 0, 0, 1, 208, 0, 32, 0, 110, 0 }; //0x17118 (ST6)
    private short DAT_1714C; //0x1714C (ST6)
    private FUN_17150[] PTR_FUN_17150; //0x17150 (ST6)
    private FUN_171A8[] PTR_FUN_171A8; //0x171A8 (ST6)
    private FUN_171B4[] PTR_FUN_171B4; //0x171B4 (ST6)
    private byte[] DAT_171D4 = new byte[] { 1, 0, 0, 148 };
    private FUN_171D8[] PTR_FUN_171D8; //0x171D8 (ST6)
    private byte[] DAT_171E0 = new byte[] { 0, 28, 29, 30, 31, 0, 0, 0, 1, 255, 0, 0, 62, 63, 0, 0 }; //0x171E0 (ST6)
    private FUN_171F0[] PTR_FUN_171F0; //0x171F0 (ST6)
    private FUN_171FC[] PTR_FUN_171FC; //0x171FC (ST6)
    public short[] DAT_17208 = new short[] { 768, -3646, -19660, 7184, 11458, 6708, -32, -3840 };
    public short[] DAT_1721C = new short[] { -20224, 0, -1639, -5528, -27728, -3079, -8344, -27984, -1776, -4788, -27553, 0 };
    public short[] DAT_17230 = new short[] { 50, 32, 25, 25, 50, 32, 25, 25, 0, 16384, 16, 25, 2850, 500, -3500, 5120, 5, 2850, 600, -2800 };
    private FUN_17310[] PTR_FUN_17310; //0x17310 (ST6)
    private FUN_173D4[] PTR_FUN_173D4; //0x173D4 (ST6)
    private FUN_173E0[] PTR_FUN_173E0; //0x173E0 (ST6)
    private FUN_173E8[] PTR_FUN_173E8; //0x173E8 (ST6)
    private ushort DAT_173F0; //0x173F0 (ST6)
    private sbyte[] DAT_173F4 = new sbyte[20]; //0x173F4 (ST6)
    private byte[] DAT_17414 = new byte[16]; //0x17414 (ST6)
    //private ushort DAT_17470; //0x17470 (ST6)
    //private ushort DAT_17472; //0x17472 (ST6)
    //private ushort DAT_17474; //0x17474 (ST6)
    //private ushort DAT_17476; //0x17476 (ST6)
    //private byte DAT_17478; //0x17478 (ST6)
    public short DAT_174E4; //0x174E4 (ST6)

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
            PTR_FUN_166F4 = new FUN_166F4[22]
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
                FUN_41D4, 
                FUN_4B74, 
                FUN_4930, 
                FUN_4DAC, 
                FUN_4F64, 
                FUN_5F94, 
                FUN_5408, 
                FUN_5AF0, 
                FUN_5DAC, 
                FUN_64A4, 
                FUN_69AC
            };
            PTR_FUN_1674C = new FUN_1674C[2]
            {
                FUN_4130,
                FUN_7828
            };
            PTR_FUN_16754 = new FUN_16754[2]
            {
                FUN_484C,
                FUN_48D8
            };
            PTR_FUN_1675C = new FUN_1675C[2]
            {
                FUN_4AC0,
                FUN_4B08
            };
            PTR_FUN_16764 = new FUN_16764[2]
            {
                FUN_484C,
                FUN_4D54
            };
            PTR_FUN_1676C = new FUN_1676C[2]
            {
                FUN_4DE8,
                FUN_4E30
            };
            PTR_FUN_1679C = new FUN_1679C[2]
            {
                FUN_51C8,
                FUN_52AC
            };
            PTR_FUN_167A4 = new CriInteract.FUN_0C[]
            {

            };
            PTR_FUN_167B8 = new CriInteract.FUN_0C[]
            {

            };
            PTR_FUN_167F4 = new FUN_167F4[2]
            {
                FUN_51C8,
                FUN_5770
            };
            PTR_FUN_16804 = new CriInteract.FUN_0C[]
            {

            };
            PTR_FUN_16818 = new FUN_16818[2]
            {
                FUN_5B2C,
                FUN_5BF8
            };
            PTR_FUN_16820 = new FUN_16820[2]
            {
                FUN_5DE8,
                FUN_5F10
            };
            PTR_FUN_16828 = new CriInteract.FUN_0C[]
            {

            };
            PTR_FUN_1683C = new FUN_1683C[6]
            {
                FUN_5B2C,
                FUN_5FD0,
                FUN_6164,
                FUN_61D8,
                FUN_63BC,
                FUN_642C
            };
            PTR_FUN_16868 = new CriInteract.FUN_0C[]
            {

            };
            PTR_FUN_1687C = new FUN_1687C[6]
            {
                FUN_64E0,
                FUN_65B0,
                FUN_6634,
                FUN_66EC,
                FUN_68C4,
                FUN_6934
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
            PTR_FUN_16ADC = new FUN_16ADC[17]
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
                FUN_8AFC, 
                FUN_8CAC, 
                FUN_8D68, 
                FUN_8E5C, 
                FUN_8F7C, 
                FUN_9258, 
                FUN_9258
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
            PTR_FUN_16B30 = new FUN_16B30[5]
            {
                FUN_89B8,
                FUN_8A14,
                FUN_8A54,
                FUN_8AA4,
                FUN_8B38
            };
            PTR_FUN_16B40 = new FUN_16B40[4]
            {
                FUN_8B38,
                FUN_8BB4,
                FUN_8C04,
                FUN_8C54
            };
            PTR_FUN_16B50 = new FUN_16B50[2]
            {
                FUN_8CE8,
                FUN_88D8
            };
            PTR_FUN_16B58 = new FUN_16B58[2]
            {
                FUN_8DA4,
                FUN_8E00
            };
            PTR_FUN_16B74 = new FUN_16B74[2]
            {
                FUN_8E98,
                FUN_8F4C
            };
            PTR_FUN_16B7C = new FUN_16B7C[4]
            {
                FUN_8FB8,
                FUN_903C,
                FUN_9084,
                FUN_90EC
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
            PTR_FUN_16F18 = new FUN_16F18[3]
            {
                FUN_C940,
                FUN_CA60,
                FUN_60068
            };
            PTR_FUN_16F2C = new FUN_16F2C[3]
            {
                FUN_CB8C,
                FUN_CC34,
                FUN_60068
            };
            PTR_FUN_16F38 = new FUN_16F38[4]
            {
                FUN_CD98, 
                FUN_D170, 
                FUN_D380, 
                FUN_60068
            };
            PTR_FUN_16F74 = new FUN_16F74[4]
            {
                FUN_D58C,
                FUN_D864,
                FUN_DA04,
                FUN_60068
            };
            PTR_FUN_16F84 = new FUN_16F84[3]
            {
                FUN_DE28,
                FUN_DEB4,
                FUN_60068
            };
            PTR_FUN_16FA8 = new FUN_16FA8[3]
            {
                FUN_DF30,
                FUN_DFB8,
                FUN_60068
            };
            PTR_FUN_16FB4 = new FUN_16FB4[4]
            {
                FUN_E0E4,
                FUN_E178,
                FUN_E224,
                FUN_60068
            };
            PTR_FUN_16FD4 = new FUN_16FD4[3]
            {
                FUN_E2EC,
                FUN_E368,
                FUN_60068
            };
            PTR_FUN_16FFC = new FUN_16FFC[3]
            {
                FUN_E44C,
                FUN_E4C4,
                FUN_60068
            };
            PTR_FUN_1701C = new FUN_1701C[3]
            {
                FUN_E60C,
                FUN_E6C4,
                FUN_60068
            };
            PTR_FUN_1706C = new FUN_1706C[3]
            {
                FUN_E79C,
                FUN_E86C,
                FUN_60068
            };
            PTR_FUN_170AC = new FUN_170AC[3]
            {
                FUN_E950,
                FUN_E9F4,
                FUN_60068
            };
            PTR_FUN_170B8 = new FUN_170B8[3]
            {
                FUN_EABC,
                FUN_EB3C,
                FUN_60068
            };
            PTR_FUN_170C4 = new FUN_170C4[5]
            {
                FUN_EBEC,
                FUN_EE88,
                FUN_F018,
                FUN_EDD0,
                FUN_5FF98
            };
            PTR_FUN_170F0 = new FUN_170F0[5]
            {
                FUN_F288,
                FUN_F4C8,
                FUN_F994,
                FUN_F9D8,
                FUN_5FF98
            };
            PTR_FUN_17150 = new FUN_17150[5]
            {
                FUN_11B74,
                FUN_11E3C,
                FUN_11F34,
                FUN_11FD8,
                FUN_5FF98
            };
            PTR_FUN_171B4 = new FUN_171B4[7]
            {
                FUN_12D68,
                FUN_12EC8,
                FUN_12FE4, 
                FUN_131B4, 
                FUN_132E0, 
                FUN_1346C, 
                FUN_13698
            };
            PTR_FUN_171D8 = new FUN_171D8[2]
            {
                FUN_144E4,
                FUN_14560
            };
            PTR_FUN_171F0 = new FUN_171F0[]
            {

            };
            PTR_FUN_171FC = new FUN_171FC[3]
            {
                FUN_14758, 
                FUN_14B8C, 
                FUN_5FF98
            };
            PTR_FUN_17310 = new FUN_17310[4]
            {
                FUN_15238,
                FUN_15258,
                FUN_153A8,
                FUN_5FF98
            };
            PTR_FUN_173D4 = new FUN_173D4[3]
            {
                FUN_15428,
                FUN_15440,
                FUN_5FF98
            };
            PTR_FUN_173E0 = new FUN_173E0[2]
            {
                FUN_1561C,
                FUN_15634
            };
            PTR_FUN_173E8 = new FUN_173E8[2]
            {
                FUN_156A4,
                FUN_156E8
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

        GameManager.instance.DAT_AC = DAT_15FF8[uVar3];
        GameManager.instance.DAT_B0 = DAT_15A78;
        GameManager.instance.DAT_46 = 6;
        bVar1 = InventoryManager.FUN_4A87C(0, 0xe2);

        if (!bVar1)
        {
            for (int i = 0; i < DAT_15E18.TRIGGERS.Length; i++)
            {
                puVar4 = LevelManager.instance.DAT_9EEC[i];
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
                puVar4 = LevelManager.instance.DAT_9EEC[i];
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

        GameManager.instance.FUN_7669C(LevelManager.instance.DAT_9EEC, 6);
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
        CriBone oVar2;
        uint uVar3;
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
        if ((param1.DAT_3C != 1 || param1.DAT_3D != 6) && (param1.DAT_3C != 1 || param1.DAT_3D != 7))
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
        if (SceneManager.instance.skinnedObjects[10].DAT_3C != 5)
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
        oVar6 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
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
                    param1.BDAT_1C0 &= 0x7f;

                    if (sVar5 < 0x200)
                        bVar3 = (byte)(param1.BDAT_1C0 | 8);
                    else
                        bVar3 = (byte)(param1.BDAT_1C0 & 0xf7);

                    param1.BDAT_1C0 = bVar3;
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

                        param1.BDAT_1C0 = bVar3;
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
                            param1.BDAT_1C0 &= 0xdf;
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
                        param1.BDAT_1C0 &= 0xdf;
                        GameManager.instance.FUN_65CB0(param1);
                        FUN_B2E0(param1);
                        return;
                    }
                }
                else
                {
                    param1.BDAT_1C0 &= 0xdf;
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

    //FUN_4930 (ST6)
    private void FUN_4930(CriPlayer param1)
    {
        PTR_FUN_16754[param1.DAT_3E](param1);
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
                    param1.DAT_1D0 = (param1.DAT_1D0 & 0xffff0000) | uVar2;
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

        oVar3 = (CriPlayer)SceneManager.instance.skinnedObjects[10];

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

    //FUN_4B74 (ST6)
    private void FUN_4B74(CriPlayer param1)
    {
        PTR_FUN_1675C[param1.DAT_3E](param1);
    }

    //FUN_4BB0 (ST6)
    private void FUN_4BB0(CriPlayer param1)
    {
        bool bVar1;
        byte bVar2;
        short sVar3;
        int iVar4;

        FUN_B1FC(param1);
        sVar3 = param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen);
        bVar1 = SceneManager.instance.FUN_80D48(param1.screen, SceneManager.instance.skinnedObjects[10].screen, 4);

        if ((GameManager.instance.DAT_922C & 2) == 0 && 
            (SceneManager.instance.skinnedObjects[10].DAT_11E & 0x80) == 0 && param1.DAT_1C8 != 0)
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

                    param1.BDAT_1C0 = bVar2;
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

    //FUN_4DAC (ST6)
    private void FUN_4DAC(CriPlayer param1)
    {
        PTR_FUN_16764[param1.DAT_3E](param1);
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
            if ((param1.BDAT_1C0 & 0x40) == 0 || 0x7ff < param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen) - 0x400)
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

            param1.BDAT_1C0 &= 0xbf;
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

    //FUN_4F64 (ST6)
    private void FUN_4F64(CriPlayer param1)
    {
        PTR_FUN_1676C[param1.DAT_3E](param1);
    }
    
    //FUN_4FA0 (ST6)
    private void FUN_4FA0(CriPlayer param1)
    {
        CriPlayer oVar1;
        bool bVar2;
        int iVar2;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];

        if ((oVar1.DAT_11E & 0x80) == 0)
        {
            bVar2 = SceneManager.instance.FUN_81014(param1.screen, SceneManager.instance.skinnedObjects[10].screen, (byte)(param1.DAT_48 << 4 | 0xf), false);

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

    //FUN_51C8 (ST6)
    private void FUN_51C8(CriPlayer param1)
    {
        int iVar1;

        if (param1.DAT_3D == 6)
        {
            param1.FUN_609C8(14, 0, 10);
            iVar1 = 1;
            param1.PTR_120 = DAT_16488;
            param1.DAT_120 = 6;
            param1.DAT_12E = 1;
        }
        else
        {
            if ((param1.BDAT_1C0 & 8) == 0)
            {
                param1.FUN_609C8(15, 0, 0);
                iVar1 = 6;
            }
            else
            {
                param1.FUN_609C8(19, 0, 0);
                iVar1 = 3;
            }

            param1.PTR_120 = DAT_16488;
            param1.DAT_120 = iVar1;
            iVar1 = 0;
        }

        param1.FUN_65D0C((byte)iVar1, 30);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1C1 = 0;
        param1.DAT_3E++;
    }

    //FUN_52AC (ST6)
    private void FUN_52AC(CriPlayer param1)
    {
        int iVar1;
        ushort uVar2;
        bool bVar3;
        int iVar3;
        Vector3Int local_18;

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            if ((param1.BDAT_1C0 & 0x20) == 0)
            {
                param1.DAT_3C = 1;
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                GameManager.instance.FUN_65CB0(param1);
                FUN_B2E0(param1);
            }
            else
            {
                param1.DAT_3C = 1;
                param1.DAT_3D = 4;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 |= 0x40;
            }

            param1.DAT_1C1 = 0;
        }

        param1.FUN_65890();
        uVar2 = param1.DAT_60;

        if (uVar2 == 28)
        {
            param1.DAT_12E = 5;
            GameManager.instance.FUN_5C94C(param1, 51);
            uVar2 = param1.DAT_60;
        }

        if (uVar2 == 34)
            FUN_B4AC(param1);

        if (param1.DAT_60 < 34)
        {
            local_18 = new Vector3Int(param1.DAT_10C.x, param1.screen.y, param1.DAT_10C.z);
            iVar1 = Utilities.FUN_615EC(param1.screen, local_18);
            iVar3 = (int)GameManager.FUN_64650();
            uVar2 = (ushort)Utilities.FUN_64838(param1.vr.y, (uint)(iVar3 % 15 + 10) * 0x10000 >> 0x10, iVar1);
            param1.vr.y = param1.vr.y + uVar2 & 0xfff;
        }
    }

    //FUN_5408 (ST6)
    private void FUN_5408(CriPlayer param1)
    {
        PTR_FUN_1679C[param1.DAT_3E](param1);
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

        oVar8 = (CriPlayer)SceneManager.instance.skinnedObjects[10];

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

    //FUN_5770 (ST6)
    private void FUN_5770(CriPlayer param1)
    {
        ushort uVar1;
        int iVar2;
        bool bVar3;
        int iVar3;
        Vector3Int local_18;

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_1C1 = 0;
            GameManager.instance.FUN_65CB0(param1);
            FUN_B2E0(param1);
        }

        param1.FUN_65890();

        if ((param1.DAT_1C0 & 0xff08) == 0x200)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 10;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
        else
        {
            uVar1 = param1.DAT_60;

            if (uVar1 == 10)
            {
                GameManager.instance.FUN_5C94C(param1, 51);
                uVar1 = param1.DAT_60;
            }

            if (uVar1 == 19)
            {
                param1.DAT_12E = 3;
                GameManager.instance.FUN_5C94C(param1, 61);
            }

            uVar1 = param1.DAT_60;

            if (uVar1 == 33)
            {
                FUN_B4AC(param1);
                uVar1 = param1.DAT_60;
            }

            if (uVar1 == 36 && param1.DAT_1C3 != 0)
            {
                uVar1 = (ushort)param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen);

                if (0xc00 < (ushort)(uVar1 - 0x200) && param1.UDAT_1DC < 3500)
                {
                    param1.DAT_1C3 = 0;
                    param1.DAT_3E++;
                }
            }

            local_18 = new Vector3Int(param1.DAT_10C.x, param1.screen.y, param1.DAT_10C.z);
            iVar2 = Utilities.FUN_615EC(param1.screen, local_18);
            iVar3 = (int)GameManager.FUN_64650();
            uVar1 = (ushort)Utilities.FUN_64838(param1.vr.y, (uint)(iVar3 % 15 + 10) * 0x10000 >> 0x10, iVar2);
            param1.vr.y = param1.vr.y + uVar1 & 0xfff;
        }
    }

    //FUN_592C (ST6)
    private void FUN_592C(CriPlayer param1)
    {
        int iVar1;

        if ((param1.BDAT_1C0 & 8) == 0)
            iVar1 = 26;
        else
            iVar1 = 27;

        param1.FUN_609C8(iVar1, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_5AF0 (ST6)
    private void FUN_5AF0(CriPlayer param1)
    {
        PTR_FUN_167F4[param1.DAT_3E](param1);
    }

    //FUN_5B2C  (ST6)
    private void FUN_5B2C(CriPlayer param1)
    {
        CriSkinned oVar2; 

        if (param1.DAT_3D == 8)
            param1.FUN_609C8(16, 0, 0);
        else
        {
            param1.FUN_609C8(29, 0, 0);
            SceneManager.instance.FUN_65D1C(param1,  PTR_FUN_16804[param1.DAT_1CB], 17);
        }

        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_656EC();
        param1.DAT_18D = false;
        oVar2 = SceneManager.instance.skinnedObjects[10];
        oVar2.DAT_18D = false;
        oVar2.DAT_11E |= 0x28;
        param1.FUN_65D0C(0, 30);
        param1.DAT_3E++;
    }

    //FUN_5BF8 (ST6)
    private void FUN_5BF8(CriPlayer param1)
    {
        short sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        CriCamera cVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        bVar4 = param1.FUN_60AB4();

        if (bVar4)
        {
            GameManager.instance.FUN_5DC54();
            oVar5.DAT_11E |= 1;
        }

        if (param1.DAT_60 < 27)
        {
            sVar2 = (short)Utilities.FUN_615EC(param1.screen, oVar5.screen);
            iVar4 = (int)GameManager.FUN_64650();
            sVar3 = (short)Utilities.FUN_64838(param1.vr.y, (uint)(iVar4 % 15 + 20) * 0x10000 >> 0x10, sVar2);
            param1.vr.y = param1.vr.y + sVar3 & 0xfff;
        }

        param1.FUN_65714();
        sVar3 = (short)param1.DAT_60;

        if (sVar3 == 27)
        {
            GameManager.instance.PTR_FUN_148 = FUN_86FC;
            oVar5.DAT_3C = 5;
            oVar5.DAT_3D = 6;
            oVar5.DAT_3E = 0;
            oVar5.DAT_3F = 0;
            param1.FUN_65C4C(oVar5);
            //FUN_1D988
            oVar5.DAT_152 = 1;
            param1.DAT_152 = 1;
            oVar5.DAT_154 = param1;
            param1.DAT_154 = oVar5;
            oVar5.vr.y = param1.vr.y;
            cVar4 = SceneManager.instance.cCamera;
            cVar4.DAT_72 |= 2;
            cVar4.DAT_70 = 1;
            cVar4.PTR_FUN_8C = cVar4.FUN_BF40;
            cVar4.DAT_64 = param1;
            GameManager.instance.FUN_5C94C(param1, 60);
            sVar3 = (short)param1.DAT_60;
        }

        if (sVar3 == 61)
            FUN_C06C(param1);

        if (param1.DAT_60 == 70)
            GameManager.instance.FUN_5C94C(param1, 59);
    }

    //FUN_5DAC (ST6)
    private void FUN_5DAC(CriPlayer param1)
    {
        PTR_FUN_16818[param1.DAT_3E](param1);
    }

    //FUN_5DE8 (ST6)
    private void FUN_5DE8(CriPlayer param1)
    {
        short sVar1;
        uint uVar2;
        Vector3Int local_18;

        local_18 = new Vector3Int(param1.DAT_10C.x, param1.vr.y, param1.DAT_10C.z);
        uVar2 = (uint)(int)param1.FUN_64804(local_18);
        param1.UDAT_1DA = (ushort)uVar2;

        if ((uVar2 & 0x800) == 0)
        {
            param1.FUN_609C8(12, 0, 0);
            param1.BDAT_1C0 |= 8;
            sVar1 = (short)(((short)uVar2 - 0x400) / 0x19);
        }
        else
        {
            param1.FUN_609C8(13, 0, 0);
            param1.BDAT_1C0 &= 0xf7;
            sVar1 = (short)-((int)((0x1000 - uVar2 & 0xfff) - 0x400) / 0x19);
        }

        param1.SDAT_1D8 = sVar1;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.vr.y = param1.vr.y + param1.SDAT_1D8 & 0xfff;
        param1.DAT_3E++;
    }

    //FUN_5F10 (ST6)
    private void FUN_5F10(CriPlayer param1)
    {
        ushort uVar1;
        bool bVar2;

        bVar2 = param1.FUN_60AB4();

        if (!bVar2)
        {
            param1.vr.y = param1.vr.y + param1.SDAT_1D8 & 0xfff;
            param1.FUN_65890();
        }
        else
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;

            if ((param1.DAT_1C0 & 8) == 0)
                uVar1 = (ushort)(param1.vr.y - 0x400);
            else
                uVar1 = (ushort)(param1.vr.y + 0x400);

            param1.vr.y = uVar1 & 0xfff;
        }
    }

    //FUN_5F94 (ST6)
    private void FUN_5F94(CriPlayer param1)
    {
        PTR_FUN_16820[param1.DAT_3E](param1);
    }

    //FUN_5FD0 (ST6)
    private void FUN_5FD0(CriPlayer param1)
    {
        short sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        CriPlayer oVar5;
        CriCamera cVar6;

        oVar5 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        bVar4 = param1.FUN_60AB4();

        if (bVar4)
            param1.DAT_3E++;

        if (param1.DAT_60 < 23)
        {
            sVar2 = (short)Utilities.FUN_615EC(param1.screen, oVar5.screen);
            iVar4 = (int)GameManager.FUN_64650();
            sVar3 = (short)Utilities.FUN_64838(param1.vr.y, (uint)(iVar4 % 15 + 20) * 0x10000 >> 0x10, sVar2);
            param1.vr.y = param1.vr.y + sVar3 & 0xfff;
        }

        param1.FUN_65714();

        if (param1.DAT_60 == 23)
        {
            oVar5.vr.y = param1.vr.y;
            GameManager.instance.PTR_FUN_148 = FUN_86FC;
            oVar5.DAT_3C = 5;
            oVar5.DAT_3D = 7;
            oVar5.DAT_3E = 0;
            oVar5.DAT_3F = 0;
            param1.FUN_65C4C(oVar5);
            oVar5.DAT_152 = 1;
            param1.DAT_152 = 1;
            oVar5.DAT_154 = param1;
            param1.DAT_154 = oVar5;
            oVar5.DAT_11E &= 0xdf;
            SceneManager.instance.FUN_26E1C();
            cVar6 = SceneManager.instance.cCamera;
            cVar6.DAT_72 |= 4;
            cVar6.DAT_70 = 1;
            cVar6.PTR_FUN_8C = cVar6.FUN_BE1C;
            cVar6.DAT_64 = param1;
            GameManager.instance.FUN_5C94C(param1, 53);
            //FUN_1D988
        }
    }

    //FUN_6164 (ST6)
    private void FUN_6164(CriPlayer param1)
    {
        CriPlayer oVar1;

        param1.FUN_609C8(30, 1, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        //...
        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar1.DAT_1E6 = 160;
        oVar1.DAT_1E5 = 0;
        param1.DAT_3E++;
    }

    //FUN_61D8 (ST6)
    private void FUN_61D8(CriPlayer param1)
    {
        int iVar3;
        bool bVar3;
        short sVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        bVar3 = param1.FUN_60AB4();

        if (bVar3 && oVar5.DAT_1E5 != 0)
            param1.DAT_3E++;

        param1.FUN_65714();
        sVar4 = (short)param1.DAT_60;

        if (sVar4 == 2 || sVar4 == 20)
        {
            GameManager.instance.FUN_5C94C(param1, 54);
            //FUN_1D988
            sVar4 = (short)param1.DAT_60;
        }

        if (sVar4 == 19)
            SceneManager.instance.FUN_65D1C(param1, PTR_FUN_16828[param1.DAT_1CB], 7);

        if ((oVar5.DAT_11E & 0x20) == 0 && 0 < oVar5.health && oVar5.DAT_1E5 == 0)
        {
            iVar3 = GameManager.instance.FUN_64C80();
            //...

            if ((oVar5.DAT_11E & 1) == 0 && param1.DAT_60 == 15)
            {
                iVar3 = (int)GameManager.FUN_64650();
                oVar5.health = (short)((oVar5.health - 50) - (iVar3 + (iVar3 / 50) * -50));
                oVar5.FUN_4FE30();

                if (oVar5.health < 1)
                    FUN_C06C(param1);
            }
        }
    }

    //FUN_63BC (ST6)
    private void FUN_63BC(CriPlayer param1)
    {
        param1.FUN_609C8(31, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        param1.DAT_3E++;
        SceneManager.instance.skinnedObjects[10].DAT_3E++;
    }

    //FUN_642C (ST6)
    private void FUN_642C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_18D = true;
            SceneManager.instance.skinnedObjects[10].DAT_18D = true;
            GameManager.instance.FUN_65CB0(param1);
            FUN_B2E0(param1);
        }

        param1.FUN_65714();

        if (param1.DAT_60 == 26)
            GameManager.instance.FUN_5C94C(param1, 59);
    }

    //FUN_64A4 (ST6)
    private void FUN_64A4(CriPlayer param1)
    {
        PTR_FUN_1683C[param1.DAT_3E](param1);
    }

    //FUN_64E0 (ST6)
    private void FUN_64E0(CriPlayer param1)
    {
        CriPlayer oVar4;

        param1.FUN_609C8(34, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_656EC();
        param1.DAT_18D = false;
        oVar4 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar4.DAT_18D = false;
        oVar4.DAT_11E |= 8;
        param1.FUN_65D0C(0, 30);
        GameManager.instance.PTR_FUN_148 = FUN_86FC;
        oVar4.DAT_3C = 5;
        oVar4.DAT_3D = 8;
        oVar4.DAT_3E = 0;
        oVar4.DAT_3F = 0;
        param1.FUN_65C4C(oVar4);
        oVar4.DAT_152 = 1;
        oVar4.vr.y = param1.vr.y;
        param1.DAT_152 = 1;
        oVar4.DAT_154 = param1;
        param1.DAT_154 = oVar4;
        param1.DAT_3E++;
    }

    //FUN_65B0 (ST6)
    private void FUN_65B0(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.FUN_65714();

        if (param1.DAT_60 == 32)
            GameManager.instance.FUN_5C94C(param1, 53);

        //FUN_C7FC
    }

    //FUN_6634 (ST6)
    private void FUN_6634(CriPlayer param1)
    {
        CriPlayer oVar1;
        CriCamera cVar2;

        param1.FUN_609C8(32, 1, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        //...
        oVar1.DAT_1E6 = 160;
        oVar1.DAT_1E5 = 0;
        SceneManager.instance.FUN_26E1C();
        cVar2 = SceneManager.instance.cCamera;
        cVar2.DAT_72 |= 4;
        cVar2.DAT_70 = 1;
        cVar2.PTR_FUN_8C = cVar2.FUN_C064;
        cVar2.DAT_64 = param1;
        param1.DAT_3E++;
    }

    //FUN_66EC (ST6)
    private void FUN_66EC(CriPlayer param1)
    {
        int iVar3;
        bool bVar3;
        short sVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        bVar3 = param1.FUN_60AB4();

        if (bVar3 && oVar5.DAT_1E5 != 0)
            param1.DAT_3E++;

        param1.FUN_65714();
        sVar4 = (short)param1.DAT_60;

        if (sVar4 == 2 || sVar4 == 20)
        {
            GameManager.instance.FUN_5C94C(param1, 54);
            sVar4 = (short)param1.DAT_60;
        }

        if (sVar4 == 19)
            SceneManager.instance.FUN_65D1C(param1, PTR_FUN_16868[param1.DAT_1CB], 11);

        if ((oVar5.DAT_11E & 0x20) == 0 && 0 < oVar5.health && oVar5.DAT_1E5 == 0)
        {
            iVar3 = GameManager.instance.FUN_64C80();
            //...

            if ((oVar5.DAT_11E & 1) == 0 && param1.DAT_60 == 15)
            {
                iVar3 = (int)GameManager.FUN_64650();
                oVar5.health = (short)((oVar5.health - 50) - (iVar3 + (iVar3 / 50) * -50));
                oVar5.FUN_4FE30();

                if (oVar5.health < 1)
                    FUN_C06C(param1);
            }
        }
    }

    //FUN_68C4 (ST6)
    private void FUN_68C4(CriPlayer param1)
    {
        param1.FUN_609C8(33, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        param1.DAT_3E++;
        SceneManager.instance.skinnedObjects[10].DAT_3E++;
    }

    //FUN_6934 (ST6)
    private void FUN_6934(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_18D = true;
            SceneManager.instance.skinnedObjects[10].DAT_18D = true;
            GameManager.instance.FUN_65CB0(param1);
            FUN_B2E0(param1);
        }

        param1.FUN_65714();

        if (param1.DAT_60 == 16)
            GameManager.instance.FUN_5C94C(param1, 59);
    }

    //FUN_69AC (ST6)
    private void FUN_69AC(CriPlayer param1)
    {
        PTR_FUN_1687C[param1.DAT_3E](param1);
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
        sVar2 = param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen);

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

        param1.BDAT_1C0 = bVar1;
        param1.DAT_60 = (ushort)(uVar4 & 0xff);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        FUN_B4AC(param1);
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        GameManager.instance.FUN_5C94C(param1, 56);

        if ((param1.BDAT_1C0 & 4) == 0)
            FUN_BC9C(param1);

        param1.BDAT_1C0 &= 0xdf;
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
        sVar2 = (short)Utilities.FUN_615EC(param1.screen, SceneManager.instance.skinnedObjects[10].screen);
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
        sVar2 = param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen);

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

        param1.BDAT_1C0 = bVar1;
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

        param1.BDAT_1C0 &= 0xdf;
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
        sVar2 = (short)Utilities.FUN_615EC(param1.screen, SceneManager.instance.skinnedObjects[10].screen);
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
            param1.BDAT_1C0 &= 0xef;
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
        param1.BDAT_1C0 &= 0xdf;
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
        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
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
        PTR_FUN_16B30[param1.DAT_3E](param1);
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

    //FUN_8CAC (ST6)
    private void FUN_8CAC(CriPlayer param1)
    {
        PTR_FUN_16B40[param1.DAT_3E](param1);
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

    //FUN_8D68 (ST6)
    private void FUN_8D68(CriPlayer param1)
    {
        PTR_FUN_16B50[param1.DAT_3E](param1);
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

    //FUN_8E5C (ST6)
    private void FUN_8E5C(CriPlayer param1)
    {
        PTR_FUN_16B58[param1.DAT_3E](param1);
    }

    //FUN_8E98 (ST6)
    private void FUN_8E98(CriPlayer param1)
    {
        CriPlayer oVar1;

        param1.FUN_609C8(42, 0, 0);
        oVar1 = param1.DAT_1DC;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_11E = (byte)(param1.DAT_11E & 0xdf | 0x80);
        param1.FUN_65714();
        param1.FUN_5348C(0x70, 0x70);
        param1.DAT_1C0 &= 0xfffffffe;
        SceneManager.instance.FUN_65D1C(param1, PTR_FUN_16B60[oVar1.DAT_1CB], 14);
        param1.DAT_3E++;
    }

    //FUN_8F4C (ST6)
    private void FUN_8F4C(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.FUN_65714();
    }

    //FUN_8F7C (ST6)
    private void FUN_8F7C(CriPlayer param1)
    {
        PTR_FUN_16B74[param1.DAT_3E](param1);
    }

    //FUN_8FB8 (ST6)
    private void FUN_8FB8(CriPlayer param1)
    {
        int iVar1;

        if (param1.DAT_3D == 7)
            iVar1 = 43;
        else
            iVar1 = 48;

        param1.FUN_609C8(iVar1, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        param1.DAT_1C0 &= 0xfffffffe;
        param1.FUN_66460(true);
        param1.DAT_3E++;
    }

    //FUN_903C (ST6)
    private void FUN_903C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.FUN_65714();
    }

    //FUN_9084 (ST6)
    private void FUN_9084(CriPlayer param1)
    {
        int iVar1;

        if (param1.DAT_3D == 7)
            iVar1 = 44;
        else
            iVar1 = 46;

        param1.FUN_609C8(iVar1, 1, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        param1.DAT_3E++;
    }

    //FUN_90EC (ST6)
    private void FUN_90EC(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.FUN_65714();
    }

    //FUN_9258 (ST6)
    private void FUN_9258(CriPlayer param1)
    {
        PTR_FUN_16B7C[param1.DAT_3E](param1);
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
        param1.BDAT_1C0 &= 0xfb;

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
                param1.BDAT_1C0 &= 0xfd;
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
        param1.BDAT_1C0 &= 0xfb;

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
                param1.BDAT_1C0 &= 0xfd;
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
            param1.BDAT_1C0 &= 0xfb;
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
            param1.BDAT_1C0 &= 0xfb;

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

            oVar3 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
            uVar2 = Utilities.FUN_631AC(oVar3.screen, SceneManager.instance.skinnedObjects[10].screen);

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

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
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

        sVar3 = param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen);

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

        sVar1 = param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen);

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

        sVar1 = param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen);
        //iVar4 = 9;

        if ((ushort)(sVar1 - 0xa00) < 0x400)
        {
            uVar2 = param1.DAT_1CB;
        }
        else
        {
            //iVar4 = 7;

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
                    //iVar4 = 7;
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
        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
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
        Utilities.RotMatrix(ref SceneManager.instance.skinnedObjects[10].vr, ref auStack56);
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
        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
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

    //FUN_C940 (ST6)
    private void FUN_C940(CriParticle param1)
    {
        ushort uVar1;
        byte bVar2;

        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (param1.DAT_2F < 6)
        {
            switch (param1.DAT_2F)
            {
                case 0:
                case 1:
                    uVar1 = (ushort)param1.vr.y;
                    param1.DAT_56 = 0x28;
                    param1.DAT_54 = 0x7f36;
                    param1.vr.y = 0;
                    param1.DAT_50.r = (byte)((uVar1 >> 4) & 0xf0);
                    bVar2 = (byte)uVar1;
                    param1.DAT_50.g = (byte)(bVar2 & 0xf0);
                    param1.DAT_50.b = (byte)(bVar2 << 4);
                    param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16F00[param1.DAT_2F]));
                    param1.flags |= 2;
                    param1.DAT_3C++;
                    return;
                case 2:
                    uVar1 = (ushort)param1.vr.y;
                    param1.DAT_56 = 0x28;
                    param1.DAT_54 = 0x7f36;
                    param1.vr.y = 0;
                    param1.DAT_50.r = (byte)((uVar1 >> 4) & 0xf0);
                    param1.DAT_50.a |= 2;
                    bVar2 = (byte)uVar1;
                    param1.DAT_50.g = (byte)(bVar2 & 0xf0);
                    param1.DAT_50.b = (byte)(bVar2 << 4);
                    param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16F00[param1.DAT_2F]));
                    param1.flags |= 2;
                    param1.DAT_3C++;
                    return;
                case 3:
                case 4:
                case 5:
                    param1.DAT_56 = 0x68;
                    param1.DAT_54 = 0x7f37;
                    param1.DAT_50.a |= 2;
                    param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16F00[param1.DAT_2F]));
                    param1.flags |= 2;
                    param1.DAT_3C++;
                    return;
            }
        }

        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16F00[param1.DAT_2F]));
        param1.flags |= 2;
        param1.DAT_3C++;
    }
    

    //FUN_CA60 (ST6)
    private void FUN_CA60(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen.x += param1.DAT_40.x;
        param1.DAT_40.y += param1.DAT_69;
        param1.screen.z += param1.DAT_40.z;
        param1.screen.y += param1.DAT_40.y;
        param1.vr.z = param1.vr.z + param1.DAT_6B & 0xfff;
        sVar1 = (sbyte)(param1.DAT_6A - 1);
        param1.DAT_6A = (byte)sVar1;

        if (sVar1 == 0)
            param1.DAT_3C++;

        iVar2 = param1.FUN_606D8();

        if (iVar2 == 1)
            param1.DAT_3C++;
    }

    //FUN_CB8C (ST6)
    private void FUN_CB8C(CriParticle param1)
    {
        ushort uVar1;

        if ((param1.DAT_2F & 0x80) != 0)
            FUN_CD18(param1);

        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16F24[param1.DAT_2F]));
        uVar1 = DAT_16F28[param1.DAT_2F];
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.DAT_76 = 30;
        param1.DAT_54 = uVar1;
        param1.DAT_3C++;
    }

    //FUN_CC34 (ST6)
    private void FUN_CC34(CriParticle param1)
    {
        short sVar1;

        param1.DAT_40.x += param1.DAT_70.x;
        param1.DAT_40.y += param1.DAT_70.y;
        param1.DAT_40.z += param1.DAT_70.z;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.y += param1.DAT_40.y;
        param1.screen.z += param1.DAT_40.z;

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

    //FUN_CD18 (ST6)
    private void FUN_CD18(CriParticle param1)
    {
        byte bVar1;
        byte bVar2;
        byte bVar3;
        byte bVar4;
        ushort uVar5;

        bVar1 = param1.DAT_2F;
        bVar2 = param1.DAT_68;
        bVar3 = param1.DAT_69;
        bVar4 = param1.DAT_6A;
        param1.DAT_2F = 0;
        param1.DAT_68 = 0;
        param1.DAT_69 = 0;
        param1.DAT_6A = 0;
        param1.DAT_70.y = 0;
        uVar5 = (ushort)(bVar1 & 0x7f);
        param1.DAT_62 = uVar5;
        param1.DAT_60 = uVar5;
        param1.DAT_50.r = bVar2;
        param1.DAT_50.g = bVar3;
        param1.DAT_50.b = bVar4;
    }

    //FUN_CD98 (ST6)
    private void FUN_CD98(CriParticle param1)
    {
        byte bVar1;
        int piVar2;
        int piVar3;
        bool bVar4;
        int iVar4;
        bool bVar5;
        int iVar5;
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
        System.Array.Copy(DAT_1C, local_48, 4);
        System.Array.Copy(DAT_2C, local_38, 20);

        do
        {
            local_78[iVar4] = SceneManager.instance.staticObjects[piVar2];
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

                    if  (iVar4 != 3)
                    {
                        param1.PTR_68[0] = oVar7;
                        goto LAB_D070;
                    }
                }

                local_60[0].DAT_78 = bVar1;
                local_60[3].DAT_78 = (byte)iVar4;
                local_60[1] = local_60[3];
                goto LAB_D06C;
            }
            
            if (iVar4 != 0)
            {
                param1.PTR_68[0] = oVar7;
                goto LAB_D070;
            }

            local_60[0].DAT_78 = 1;
            local_60[1].DAT_78 = 0;
        }

        LAB_D06C:
        param1.PTR_68[0] = local_60[0];
        oVar7 = local_60[0];
        oVar8 = local_60[1];
        LAB_D070:
        param1.PTR_68[1] = oVar8;
        param1.DAT_70.x = (oVar7.screen.x + oVar8.screen.x) / 2;
        param1.DAT_70.y = (oVar7.screen.z + oVar8.screen.z) / 2;
        oVar7.VDAT_74.x = oVar7.screen.x - param1.DAT_70.x;
        oVar7.VDAT_74.y = oVar7.screen.z - param1.DAT_70.y;
        oVar7.VDAT_74.x = oVar7.screen.x - param1.DAT_70.x;
        oVar7.VDAT_74.y = oVar7.screen.z - param1.DAT_70.y;
        oVar7.DAT_4A = 970;
        oVar8.DAT_4A = 969;
        param1.DAT_74 = 0;
        param1.DAT_75 = 0;
        param1.DAT_3C++;
        InventoryManager.FUN_4A7E8(3, 0x3e, false);
        InventoryManager.FUN_4A7E8(3, 0x2c, true);
        //FUN_1D988
    }

    //FUN_D170 (ST6)
    private void FUN_D170(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;
        CriStatic oVar4;
        CriStatic oVar5;
        Vector3Int local_28;
        Vector3Int local_30;
        Vector3Int local_38;
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
        oVar5.screen.x = local_30.x + param1.DAT_70.x;
        oVar5.screen.z = local_30.z + param1.DAT_70.y;
        sVar2 = (sbyte)(param1.DAT_74 + 1);
        param1.DAT_74 = (byte)sVar2;

        if (sVar2 == 28)
            GameManager.instance.FUN_5C94C(oVar4, 152);

        if (32 < param1.DAT_74)
        {
            param1.DAT_3C++;
            oVar4.screen.x = oVar5.VDAT_74.x + param1.DAT_70.x;
            oVar4.screen.z = oVar5.VDAT_74.y + param1.DAT_70.y;
            oVar5.screen.x = oVar4.VDAT_74.x + param1.DAT_70.x;
            oVar5.screen.z = oVar4.VDAT_74.y + param1.DAT_70.y;
        }
    }

    //FUN_D380 (ST6)
    private void FUN_D380(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        CriStatic oVar3;
        CriStatic oVar4;
        int iVar5;
        uint uVar5;
        bool bVar5;
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
                goto LAB_D518;
            else
            {
                piVar6++;

                if (4 < iVar5)
                    goto LAB_D518;
            }
        }

        InventoryManager.FUN_4A7E8(3, 0x2e, true);
        LAB_D518:
        InventoryManager.FUN_4A7E8(3, 0x3e, true);
        param1.DAT_3C++;
    }

    //FUN_D58C (ST6)
    private void FUN_D58C(CriParticle param1)
    {
        byte bVar1;
        bool bVar2;
        int iVar2;
        int piVar3;
        int iVar4;
        CriStatic oVar4;
        byte bVar5;
        int iVar6;
        int piVar7;
        CriStatic[] local_48;
        byte[] local_30;

        iVar6 = 0;
        iVar4 = 0;
        piVar3 = 0;
        piVar7 = 0;
        local_48 = new CriStatic[5];
        local_30 = new byte[28];
        System.Array.Copy(DAT_40, local_30, 28);
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.screen.y = -1350;
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
                oVar4 = local_48[piVar3];
                bVar1 = local_30[iVar2 + iVar6 * 5];
                oVar4.DAT_79 = (byte)iVar2;
                iVar2++;
                oVar4.DAT_78 = bVar1;
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
                bVar5 = (byte)(iVar6 + 1);

                if (iVar6 == 4)
                    bVar5 = 1;
                else
                {
                    if (2 < iVar6 + 1)
                        bVar5 = 2;
                }

                param1.DAT_3C += bVar5;
                param1.DAT_7A = 0;
                param1.DAT_7B = 0;
                return;
            }
        } while (true);
    }

    //FUN_D864 (ST6)
    private void FUN_D864(CriParticle param1)
    {
        short sVar1;
        byte bVar2;
        CriStatic oVar3;
        CriStatic oVar4;

        bVar2 = (byte)(param1.DAT_7A + 1);
        oVar4 = (CriStatic)param1.PTR_68[param1.DAT_78];
        oVar3 = SceneManager.instance.staticObjects[param1.DAT_78 + 5];
        param1.DAT_7A = bVar2;

        if (bVar2 == 11)
        {
            GameManager.instance.FUN_5C94C(oVar4, 145);

            //if (oVar4.DAT_79 != 4)
            //    ; //FUN_1D988
        }

        oVar3.vr.y = oVar3.vr.y + 0x40 & 0xfff;
        sVar1 = (short)(oVar4.screen.y + 4);

        if (-0x433 < sVar1)
        {
            oVar3 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
            oVar3.flags |= 2;
            oVar4.screen.y = -1075;
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

    //FUN_DA04 (ST6)
    private void FUN_DA04(CriParticle param1)
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
                    oVar5.screen.x = DAT_16F48[param1.DAT_78 * 3];
                    oVar5.screen.y = DAT_16F48[param1.DAT_78 * 3 + 1];
                    oVar5.screen.z = DAT_16F48[param1.DAT_78 * 3 + 2];
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
                FUN_DCDC(param1);
        }

        sVar3 = (short)(oVar6.screen.y + 4);
        oVar6.screen.y = sVar3;

        if (-1075 < sVar3)
        {
            oVar4 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
            oVar6.flags |= 2;
            oVar6.screen.y = -1075;
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

    //FUN_DCDC (ST6)
    private void FUN_DCDC(CriParticle param1)
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

                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8010f740));
                param1.flags |= 2;
                param1.screen.x = DAT_16F48[18] - 85;
                InventoryManager.FUN_4A7E8(3, 0x2d, false);
                param1.DAT_7B = 0;
                return;
            }

            if (sVar1 != 0)
                return;

            param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8010f738));
            param1.flags |= 2;
            param1.screen.x = DAT_16F48[18];
        }

        param1.DAT_7B++;
    }

    //FUN_DE28 (ST6)
    private void FUN_DE28(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3f;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.vr.y = 0x400;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8010f748));
        param1.DAT_65 = 3;
        param1.DAT_4C = SceneManager.instance.cCamera;
        param1.DAT_3C++;
    }

    //FUN_DEB4 (ST6)
    private void FUN_DEB4(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_DF30 (ST6)
    private void FUN_DF30(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16F90[0]));
        param1.DAT_69 = 1;
        param1.DAT_68 = (byte)DAT_16F94[0];
        param1.DAT_3C++;
    }

    //FUN_DFB8 (ST6)
    private void FUN_DFB8(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;

        sVar2 = (sbyte)(param1.DAT_68 - 1);
        param1.DAT_68 = (byte)sVar2;

        if (sVar2 == -1)
        {
            if (DAT_16F90[param1.DAT_69] == 0)
                param1.flags &= 0xfffffffd;
            else
            {
                param1.flags |= 2;
                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16F90[param1.DAT_69]));
            }

            bVar1 = (byte)DAT_16F94[param1.DAT_69];
            bVar3 = (byte)(param1.DAT_69 + 1);
            param1.DAT_69 = bVar3;
            param1.DAT_68 = bVar1;

            if (2 < bVar3)
                param1.DAT_3C++;
        }
    }

    //FUN_E0E4 (ST6)
    private void FUN_E0E4(CriParticle param1)
    {
        param1.flags |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8011c0c0));
        param1.DAT_56 = 0x37;
        param1.DAT_54 = 0x7f36;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.DAT_40 = new Vector3Int(-param1.DAT_69, -param1.DAT_6A, 0);
        param1.IDAT_6C = 20;
        param1.DAT_3C = 1;
    }

    //FUN_E178 (ST6)
    private void FUN_E178(CriParticle param1)
    {
        int iVar1;

        param1.screen.y += param1.DAT_40.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.vr.x = param1.vr.x + 0x180 & 0xfff;
        param1.DAT_40.y += param1.DAT_6B;
        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == 0)
        {
            param1.vr.x = 0;
            param1.DAT_6B = 0;
            param1.IDAT_6C = 0x80;
            param1.DAT_3C++;
        }

        param1.FUN_606D8();
    }

    //FUN_E224 (ST6)
    private void FUN_E224(CriParticle param1)
    {
        byte bVar1;
        int iVar2;

        bVar1 = (byte)(param1.DAT_6B + 1);
        param1.DAT_6B = bVar1;

        if ((bVar1 & 0xf) == 0)
            param1.DAT_60++;

        param1.vr.y += 0x20;
        param1.vr.x += 8;
        iVar2 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar2;

        if (iVar2 == 0)
            param1.DAT_3C++;

        param1.FUN_606D8();
    }

    //FUN_E2EC (ST6)
    private void FUN_E2EC(CriParticle param1)
    {
        param1.flags |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16FC4[param1.DAT_2F]));
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7eff;
        param1.DAT_3C = 1;
        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
    }

    private void FUN_E368(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.screen.y += param1.DAT_40.y;
        sVar1 = (sbyte)param1.DAT_69;

        if (sVar1 != 0)
        {
            param1.DAT_69 = (byte)(sVar1 - 1);

            if (sVar1 == 1)
                param1.DAT_3C++;
        }

        iVar2 = param1.FUN_606D8();

        if (iVar2 == 1)
            param1.DAT_3C++;
    }

    //FUN_E44C (ST6)
    private void FUN_E44C(CriParticle param1)
    {
        param1.DAT_56 = 0x37;
        param1.DAT_54 = 0x7f34;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.flags |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16FE0[param1.DAT_2F]));
        param1.DAT_3C++;
    }

    //FUN_E4C4 (ST6)
    private void FUN_E4C4(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen.x += param1.DAT_40.x;
        param1.screen.y += param1.DAT_40.y;
        param1.screen.z += param1.DAT_40.z;

        if (0 < param1.screen.y)
        {
            param1.DAT_6A = 0;
            param1.DAT_40 = new Vector3Int(0, 0, 0);
            param1.screen.y = 0;
        }

        param1.DAT_40.y += param1.DAT_6A;
        param1.vr.z = param1.vr.z + param1.DAT_6B * 0x10;
        iVar2 = param1.FUN_606D8();

        if (iVar2 == 1)
            param1.DAT_3C = 2;

        sVar1 = (sbyte)param1.DAT_69;

        if (sVar1 != 0)
        {
            param1.DAT_69 = (byte)(sVar1 - 1);

            if (sVar1 == 1)
                param1.DAT_3C = 2;
        }
    }

    //FUN_E60C (ST6)
    private void FUN_E60C(CriParticle param1)
    {
        ushort uVar1;
        int iVar2;

        param1.flags |= 2;
        uVar1 = 0x17;

        if (param1.DAT_2F < 2)
            param1.DAT_56 = uVar1;
        else
        {
            uVar1 = 0x77;

            if (param1.DAT_2F < 5)
                param1.DAT_56 = uVar1;
        }

        param1.DAT_54 = 0x7f30;
        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.IDAT_6C = param1.DAT_6A;
        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_17008[param1.DAT_2F]));

        if (iVar2 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_E6C4 (ST6)
    private void FUN_E6C4(CriParticle param1)
    {
        int iVar1;

        param1.screen.y += param1.DAT_40.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.DAT_40.y += param1.DAT_69;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_E79C (ST6)
    private void FUN_E79C(CriParticle param1)
    {
        int iVar1;
        ushort uVar2;

        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.vr.z = param1.DAT_6A << 4;
        uVar2 = 0x7f3c;
        param1.IDAT_6C = param1.DAT_6B;
        param1.DAT_56 = (ushort)(DAT_1705C[param1.DAT_2F] << 5 | 8);

        if (3 < param1.DAT_2F)
            uVar2 = 0x7f3d;

        param1.DAT_3C = 1;
        param1.DAT_54 = uVar2;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_17028[param1.DAT_2F]));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_E86C (ST6)
    private void FUN_E86C(CriParticle param1)
    {
        int iVar1;

        param1.screen.y += param1.DAT_40.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.DAT_40.y += param1.DAT_69;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_E950 (ST6)
    private void FUN_E950(CriParticle param1)
    {
        int iVar1;

        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (param1.DAT_2F == 2)
        {
            param1.DAT_56 = 0x38;
            param1.DAT_50.a |= 2;
        }
        else
            param1.DAT_56 = 0x38;

        param1.DAT_54 = 0x7f37;
        param1.DAT_3C = 1;
        param1.flags |= 2;
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_17078[param1.DAT_2F]));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_E9F4 (ST6)
    private void FUN_E9F4(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen.x += param1.DAT_40.x;
        param1.screen.y += param1.DAT_40.y;
        param1.screen.z += param1.DAT_40.z;
        param1.DAT_40.y += param1.DAT_6A;
        param1.vr.z = param1.vr.z + param1.DAT_6B * 0x10;
        iVar2 = param1.FUN_606D8();

        if (iVar2 == 1)
            param1.DAT_3C = 2;

        if (param1.DAT_2F != 2)
        {
            sVar1 = (sbyte)(param1.DAT_69 - 1);
            param1.DAT_69 = (byte)sVar1;

            if (sVar1 == -1)
                param1.DAT_3C = 2;
        }
    }

    //FUN_EABC (ST6)
    private void FUN_EABC(CriParticle param1)
    {
        param1.DAT_54 = 0x7f3d;
        param1.DAT_56 = 0x38;
        param1.DAT_50.r = 0x80;
        param1.DAT_50.g = 0x80;
        param1.DAT_50.b = 0x80;
        param1.screen = new Vector3Int(130, 180, 1);
        param1.DAT_3C++;
        param1.DAT_65 |= 0x80;
        param1.flags |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8012d064));
    }

    //FUN_EB3C (ST6)
    private void FUN_EB3C(CriParticle param1)
    {
        param1.FUN_606D8();
    }

    //FUN_EBEC (ST6)
    private void FUN_EBEC(CriInteract param1)
    {
        sbyte sVar1;
        CriPlayer oVar2;
        byte bVar3;
        uint uVar4;
        short sVar5;
        uint uVar6;

        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        sVar1 = (sbyte)oVar2.DAT_1D7;
        param1.BDAT_08 = (byte)sVar1;

        if ((oVar2.DAT_1A0 & 8) != 0)
        {
            bVar3 = (byte)(sVar1 - 1);
            param1.BDAT_08 = bVar3;

            if ((uint)bVar3 << 0x18 < 0)
                param1.BDAT_08 = 0;
        }

        if (oVar2.DAT_3D == 5)
        {
            if (param1.BDAT_08 == 0)
                uVar4 = (uint)(oVar2.frameNum * 22);
            else
                uVar4 = (uint)(oVar2.frameNum << 5);
        }
        else
        {
            if (oVar2.DAT_3D != 1)
            {
                param1.BDAT_16 = 0;
                goto LAB_ECDC;
            }

            if (param1.BDAT_08 == 0)
                uVar4 = (uint)(oVar2.frameNum * 22);
            else
                uVar4 = (uint)(oVar2.frameNum << 5);
        }

        uVar6 = oVar2.frameCount + 1U & 0xff;

        if (uVar6 == 0)
            return; //0x1c00

        param1.BDAT_16 = (byte)(uVar4 / uVar6);
        LAB_ECDC:
        oVar2.DAT_3C = 4;
        oVar2.DAT_3D = 0;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        oVar2.DAT_152 = 2;
        oVar2.DAT_40.z = 0;
        oVar2.DAT_140 |= 0x8000;
        oVar2.DAT_12C |= 0x10;
        oVar2.DAT_174 &= 0x7f;
        InventoryManager.FUN_4A7E8(1, 2, true);
        InventoryManager.FUN_4A7E8(2, 0x12, true);
        param1.DAT_0A = param1.DAT_07;
        param1.DAT_07 = 0x80;
        param1.DAT_03 = (sbyte)(param1.DAT_02 + 1);

        if (param1.DAT_02 == 0)
            sVar5 = (short)(oVar2.screen.y + param1.DAT_0A * -0x1a9);
        else
            sVar5 = (short)(oVar2.screen.y + param1.DAT_0A * 0x1a9);

        param1.DAT_0C = sVar5;
    }

    //FUN_EDD0 (ST6)
    private void FUN_EDD0(CriInteract param1)
    {
        short sVar1;
        CriPlayer oVar2;

        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar2.DAT_3C = 1;
        oVar2.DAT_3D = 0;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        sVar1 = param1.DAT_0C;
        oVar2.DAT_140 &= 0x7fff;
        oVar2.DAT_152 = 0;
        oVar2.screen.y = sVar1;
        oVar2.DAT_12C &= 0xffef;
        oVar2.DAT_174 |= 0x80;
        InventoryManager.FUN_4A7E8(1, 2, false);
        InventoryManager.FUN_4A7E8(2, 0x12, false);
        oVar2.FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(oVar2.DAT_220), 1, 10, oVar2.DAT_220);
        param1.DAT_03++;
    }

    //FUN_EE88 (ST6)
    private void FUN_EE88(CriInteract param1)
    {
        short sVar1;
        CriPlayer oVar2;
        short sVar3;
        Vector3Int local_18;
        Matrix3x3 auStack56;

        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        auStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.DAT_08 == 0)
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

    //FUN_F018 (ST6)
    private void FUN_F018(CriInteract param1)
    {
        short sVar1;
        CriPlayer oVar2;
        short sVar3;
        Vector3Int local_18;
        Matrix3x3 auStack56;

        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        auStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack56);

        if (param1.DAT_08 == 0)
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

    //FUN_F288 (ST6)
    private void FUN_F288(CriInteract param1)
    {
        short sVar1;
        int iVar2;
        bool bVar2;
        CriStatic oVar2;
        int puVar5;
        int iVar3;
        CriStatic oVar3;
        bool bVar4;
        int iVar4;
        CriStatic oVar4;
        int iVar6;
        CriCamera cVar6;

        SceneManager.instance.FUN_26EBC(2, 0);
        SceneManager.instance.FUN_264C4(0, 0, -38, -750);
        SceneManager.instance.FUN_26504(0, 0, -0x3f01, 9580);
        cVar6 = SceneManager.instance.cCamera;
        iVar3 = 1;
        oVar4 = SceneManager.instance.staticObjects[0];
        oVar4.DAT_48 = 0;
        cVar6.DAT_36 = 200;
        oVar4.screen.z = 2980;
        oVar4.screen.x = 0;
        DAT_17414[0] = 9;

        do
        {
            oVar2 = SceneManager.instance.staticObjects[iVar3++];
            oVar2.DAT_48 = 0;
        } while (iVar3 < 8);

        iVar4 = 0;
        iVar6 = 0;
        puVar5 = 0;

        do
        {
            bVar2 = InventoryManager.FUN_4A87C(3, (uint)iVar4 + 0x2c);

            if (!bVar2)
                DAT_173F4[puVar5] = -1;
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
                DAT_173F4[puVar5] = (sbyte)iVar6;
                iVar6++;
            }

            iVar4++;
            puVar5++;
        } while (iVar4 < 20);

        if (param1.DAT_02 == 0)
        {
            DAT_173F4[3] = -16;
            DAT_173F4[7] = -16;
            DAT_173F4[11] = -16;
            DAT_173F4[12] = -16;
            DAT_173F4[16] = -16;
        }

        param1.BDAT_0A = 6;
        param1.DAT_18 = 8;
        param1.DAT_0B = 0;
        param1.DAT_08 = 0;
        param1.BDAT_09 = 0;
        param1.PDAT_0C = null;
        param1.PDAT_10 = null;
        param1.PDAT_14 = null;
        param1.DAT_19 = 0;
        param1.DAT_1A = 0xff;
        param1.DAT_1B = 0;
        bVar4 = InventoryManager.FUN_4A87C(3, 0x2b);

        if (bVar4)
        {
            oVar4 = SceneManager.instance.staticObjects[iVar6 + 1];
            oVar4.screen.y = 0xe782;
            oVar4.screen.z = 3000;
            oVar4.screen.x = 0;
            param1.DAT_19 = 1;
            param1.DAT_1A = (byte)(iVar6 + 1);
        }

        param1.DAT_03++;
    }

    //FUN_F4C8 (ST6)
    private void FUN_F4C8(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        int puVar3;
        uint uVar4;
        int iVar5;
        uint uVar6;
        CriStatic oVar7;
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

                goto LAB_F97C;
            }
        }
        else
        {
            if (bVar1 < 2)
            {
                if  (bVar1 == 0)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0x10) != 0)
                        param1.BDAT_16 ^= 1;

                    if (param1.BDAT_16 != 0)
                        return;

                    if ((InputManager.controllers[0].DAT_B58B8 & 0x2000) != 0)
                    {
                        uVar6 = (byte)param1.BDAT_0A;

                        if ((byte)param1.DAT_0B < (int)(uVar6 - 1))
                        {
                            uVar4 = (byte)param1.DAT_0B + 1U;

                            if (uVar4 < uVar6)
                            {
                                do
                                {
                                    if (((ushort)param1.SDAT_10 >> (int)(uVar4 & 0x1f) & 1U) == 0)
                                    {
                                        iVar8 = 147;
                                        param1.DAT_0B = (sbyte)uVar4;
                                        param1.DAT_12 = 0;
                                        param1.DAT_13 = 0;
                                        param1.DAT_03++;
                                        goto LAB_F97C;
                                    }

                                    uVar4++;
                                } while ((int)uVar4 < (int)uVar6);
                            }
                        }
                    }

                    if ((InputManager.controllers[0].DAT_B58B8 & 0x8000) != 0 && param1.DAT_0B != 0)
                    {
                        uVar6 = (uint)(param1.DAT_0B - 1);

                        if (-1 < (int)uVar6)
                        {
                            do
                            {
                                if (((ushort)param1.SDAT_10 >> (int)(uVar6 & 0x1f) & 1) == 0)
                                {
                                    iVar8 = 147;
                                    param1.DAT_0B = (sbyte)uVar6;
                                    param1.DAT_12 = 0;
                                    param1.DAT_13 = 0;
                                    param1.DAT_03++;
                                    goto LAB_F97C;
                                }

                                uVar6--;
                            } while (-1 < (int)uVar6);
                        }
                    }

                    if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0 && param1.BDAT_09 < (byte)param1.BDAT_0A)
                    {
                        if (param1.DAT_02 == 0)
                            puVar3 = 0;
                        else
                            puVar3 = 8;

                        DAT_17414[param1.BDAT_09 * 4] = DAT_170E0[puVar3 + param1.DAT_0B];
                        DAT_17414[param1.BDAT_09 * 4 + 1] = (byte)param1.DAT_0B;
                        param1.DAT_15 = 0;
                        param1.DAT_14 = 0;
                        param1.BDAT_09++;
                        param1.VDAT_10.x |= (ushort)(1 << (param1.DAT_0B & 0xf));
                        DAT_17414[param1.BDAT_09 * 4] = 9;

                        if (param1.BDAT_0A <= param1.BDAT_09)
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
                                uVar4 = (uint)((ushort)param1.SDAT_10 >> (int)(uVar6 & 0x1f));
                            } while ((int)uVar6 < param1.BDAT_0A);
                        }
                    }

                    if ((InputManager.controllers[0].DAT_B58B8 & 0x40) != 0)
                    {
                        bVar1 = (byte)(param1.BDAT_09 - 1);

                        if (param1.BDAT_09 != 0)
                        {
                            param1.BDAT_09 = bVar1;
                            iVar8 = 148;
                            param1.SDAT_10 &= (short)~(1 << (DAT_17414[bVar1 * 4 + 1] & 0xf));
                            DAT_17414[param1.BDAT_09 * 4] = 9;
                            goto LAB_F97C;
                        }

                        param1.DAT_03 = 4;
                        SceneManager.instance.skinnedObjects[10].flags |= 2;
                        InventoryManager.FUN_4A7E8(2, 0xb, true);
                        iVar5 = 1;

                        do
                        {
                            oVar7 = SceneManager.instance.staticObjects[iVar5++];
                            oVar7.DAT_48 = 1;
                        } while (iVar5 < 8);

                        SceneManager.instance.FUN_26EBC(0, 0);
                        GameManager.instance.FUN_5C94C(null, 148);
                    }
                }
            }
            else
            {
                if (bVar1 == 2)
                {
                    if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
                    {
                        param1.DAT_03 = 4;
                        SceneManager.instance.skinnedObjects[10].flags |= 2;
                        InventoryManager.FUN_4A7E8(2, 0xb, true);
                        iVar5 = 1;

                        do
                        {
                            oVar7 = SceneManager.instance.staticObjects[iVar5++];
                            oVar7.DAT_48 = 1;
                        } while (iVar5 < 8);

                        SceneManager.instance.FUN_26EBC(0, 0);
                        GameManager.instance.FUN_5C94C(null, 148);
                    }
                }
                else
                {
                    if (bVar1 == 3 && (InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
                    {
                        param1.DAT_0B = 0;
                        param1.DAT_08 = 0;
                        param1.BDAT_09 = 0;
                        param1.PDAT_0C = null;
                        param1.PDAT_10 = null;
                        param1.PDAT_14 = null;
                        DAT_17414[0] = 9;
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
        LAB_F97C:
        GameManager.instance.FUN_5C94C(null, iVar8);
    }

    //FUN_F994 (ST6)
    private void FUN_F994(CriInteract param1)
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

    //FUN_F9D8 (ST6)
    private void FUN_F9D8(CriInteract param1)
    {
        int iVar1;
        byte bVar1;
        byte bVar2;
        sbyte sVar2;
        CriStatic oVar2;
        sbyte sVar3;
        CriStatic oVar4;
        int iVar4;
        sbyte sVar5;
        int iVar6;

        if (DAT_17414[param1.DAT_17 * 4] < 12)
        {
            switch (DAT_17414[param1.DAT_17 * 4])
            {
                case 0:
                    iVar6 = param1.DAT_18;
                    iVar4 = iVar6;

                    if (iVar6 < 0)
                        iVar4 = iVar6 + 3;

                    if ((iVar6 + (iVar4 >> 2) * -4) * 0x1000000 >> 0x18 == 1)
                    {
                        DAT_17414[param1.DAT_17 * 4] = 2;

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
                                goto LAB_10FA4;
                            }

                            if (param1.DAT_19 == 0) goto LAB_10F6C;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            oVar4 = SceneManager.instance.staticObjects[bVar1];
                            oVar4.vr.x += DAT_17118[bVar2];
                            LAB_10F6C:
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
                                goto LAB_10FA4;
                            }

                            if (param1.DAT_19 == 0) goto LAB_10F6C;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            oVar4 = SceneManager.instance.staticObjects[bVar1];
                            oVar4.vr.x += DAT_17118[bVar2];
                            LAB_10F6C:
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

                    LAB_10FA4:
                    oVar4 = SceneManager.instance.staticObjects[0];
                    iVar6 = oVar4.screen.y;

                    if (oVar4.screen.z == 0xba4 && -0x16a8 < iVar6)
                        iVar6 = -0x16a8;

                    SceneManager.instance.FUN_264C4(50, (short)oVar4.screen.x, (short)iVar6, (short)oVar4.screen.z);
                    return;
                case 1:
                    if (param1.DAT_18 < 13)
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
                                    oVar4.vr.z += DAT_17118[param1.DAT_1B];
                                }

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
                            goto LAB_10FA4;
                        }
                    }
                    else
                    {
                        DAT_17414[param1.DAT_17 * 4] = 11;

                        if (15 < param1.DAT_18)
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
                                {
                                    oVar4 = SceneManager.instance.staticObjects[param1.DAT_1A];
                                    oVar4.vr.z += DAT_17414[param1.DAT_1B];
                                }

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
                            goto LAB_10FA4;
                        }
                    }

                    param1.DAT_0D = (byte)(bVar1 + 1);
                    oVar4 = SceneManager.instance.staticObjects[0];
                    oVar4.screen.x -= 60;

                    if (param1.DAT_19 != 0)
                    {
                        oVar4.screen.x -= 60;
                    }

                    oVar4 = SceneManager.instance.staticObjects[0];
                    iVar6 = oVar4.screen.y;

                    if (oVar4.screen.z == 0xba4 && -0x16a8 < iVar6)
                        iVar6 = -0x16a8;

                    SceneManager.instance.FUN_264C4(50, (short)oVar4.screen.x, (short)iVar6, (short)oVar4.screen.z);
                    return;
                case 2:
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
                            goto LAB_10FA4;
                        }

                        if (param1.DAT_19 == 0) goto LAB_10F6C;

                        bVar1 = param1.DAT_1A;
                        bVar2 = param1.DAT_1B;
                        oVar4 = SceneManager.instance.staticObjects[bVar1];
                        oVar4.vr.x += DAT_17118[bVar2];
                        LAB_10F6C:
                        param1.DAT_1B++;
                        return;
                    }

                    oVar4 = SceneManager.instance.staticObjects[0];
                    iVar6 = oVar4.screen.y;

                    if (oVar4.screen.z == 0xba4 && -0x16a8 < iVar6)
                        iVar6 = -0x16a8;

                    SceneManager.instance.FUN_264C4(50, (short)oVar4.screen.x, (short)iVar6, (short)oVar4.screen.z);
                    return;
            }
            return;
        }

        oVar2 = SceneManager.instance.staticObjects[0];
        iVar1 = oVar2.screen.y;

        if (oVar2.screen.z == 0xba4 && -0x16a8 < iVar1)
            iVar1 = -0x16a8;

        SceneManager.instance.FUN_264C4(50, (short)oVar2.screen.x, (short)iVar1, (short)oVar2.screen.z);
    }

    //FUN_11B74 (ST6)
    private void FUN_11B74(CriInteract param1)
    {
        CriStatic oVar1;
        CriBone oVar2;
        CriObject oVar3;

        param1.PDAT_0C = SceneManager.instance.skinnedObjects[param1.DAT_04];
        oVar1 = SceneManager.instance.FUN_5FE78();

        if (oVar1 != null)
        {
            param1.PDAT_08 = oVar1;

            if (param1.DAT_02 < 5)
            {
                switch (param1.DAT_02)
                {
                    case 0:
                        oVar2 = (CriBone)Utilities.FUN_601C8(((CriSkinned)param1.PDAT_0C).skeleton, 6);
                        param1.PDAT_10 = oVar2;
                        oVar1.screen = new Vector3Int(60, 40, 120);
                        oVar1.vr.y = 0x400;
                        oVar1.vr.z = 0x800;
                        oVar1.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010cbb4);
                        oVar1.vr.x = 0;
                        oVar1.DAT_48 = 0;
                        param1.SDAT_14 = -146;
                        param1.DAT_16 = -300;
                        param1.SDAT_18 = -120;
                        param1.SDAT_1A = 30;
                        oVar3 = param1.PDAT_10;
                        oVar1.cCollider = null;
                        oVar1.DAT_40 = oVar3;
                        oVar1.flags |= 2;
                        param1.DAT_03 = 1;
                        return;
                    case 1:
                        oVar2 = (CriBone)Utilities.FUN_601C8(((CriSkinned)param1.PDAT_0C).skeleton, 6);
                        param1.PDAT_10 = oVar2;
                        oVar1.screen = new Vector3Int(-110, 360, -90);
                        oVar1.vr.z = 0x800;
                        oVar1.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010c0b0);
                        oVar1.vr.x = 0;
                        oVar1.vr.y = 0;
                        oVar1.DAT_48 = 0;
                        param1.SDAT_14 = -146;
                        param1.DAT_16 = -100;
                        param1.SDAT_18 = -120;
                        param1.SDAT_1A = 30;
                        oVar3 = param1.PDAT_10;
                        oVar1.cCollider = null;
                        oVar1.DAT_40 = oVar3;
                        oVar1.flags |= 2;
                        param1.DAT_03 = 1;
                        return;
                    case 2:
                        oVar2 = (CriBone)Utilities.FUN_601C8(((CriSkinned)param1.PDAT_0C).skeleton, 3);
                        param1.PDAT_10 = oVar2;
                        oVar1.screen = new Vector3Int(-50, 200, 80);
                        oVar1.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8017e000);
                        oVar1.vr = new Vector3Int(0, 0, 0);
                        oVar1.DAT_48 = 1;
                        oVar3 = param1.PDAT_10;
                        oVar1.cCollider = null;
                        oVar1.DAT_40 = oVar3;
                        oVar1.flags |= 2;
                        param1.DAT_03 = 1;
                        return;
                    case 3:
                        oVar2 = (CriBone)Utilities.FUN_601C8(((CriSkinned)param1.PDAT_0C).skeleton, 6);
                        param1.PDAT_10 = oVar2;
                        oVar1.screen = new Vector3Int(60, 40, 120);
                        oVar1.vr.y = 0x400;
                        oVar1.vr.z = 0x800;
                        oVar1.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010cbb4);
                        oVar1.vr.x = 0;
                        oVar1.DAT_48 = 0;
                        param1.SDAT_14 = 219;
                        param1.DAT_16 = -300;
                        param1.SDAT_18 = 180;
                        param1.SDAT_1A = 30;
                        oVar3 = param1.PDAT_10;
                        oVar1.cCollider = null;
                        oVar1.DAT_40 = oVar3;
                        oVar1.flags |= 2;
                        param1.DAT_03 = 1;
                        return;
                    case 4:
                        oVar2 = (CriBone)Utilities.FUN_601C8(((CriSkinned)param1.PDAT_0C).skeleton, 6);
                        param1.PDAT_10 = oVar2;
                        oVar1.screen = new Vector3Int(60, 40, 120);
                        oVar1.vr.y = 0x400;
                        oVar1.cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x8010cbb4);
                        oVar1.vr.x = 0;
                        oVar1.vr.z = 0x800;
                        oVar1.DAT_48 = 0;
                        param1.SDAT_14 = 0;
                        param1.DAT_16 = 0;
                        param1.SDAT_18 = 0;
                        param1.SDAT_1A = 0;
                        oVar3 = param1.PDAT_10;
                        oVar1.cCollider = null;
                        oVar1.DAT_40 = oVar3;
                        oVar1.flags |= 2;
                        param1.DAT_03 = 1;
                        return;
                }
            }

            oVar1.cCollider = null;
            oVar1.DAT_40 = param1.PDAT_10;
            oVar1.flags |= 2;
        }

        param1.DAT_03 = 1;
    }

    //FUN_11E3C (ST6)
    private void FUN_11E3C(CriInteract param1)
    {
        bool bVar1;
        CriStatic oVar1;
        Vector3Int local_20;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x3c);

        if (bVar1)
        {
            oVar1 = (CriStatic)param1.PDAT_08;
            oVar1.DAT_40 = null;
            local_20 = Utilities.ApplyMatrixSV(ref param1.PDAT_10.cTransform.rotation, ref oVar1.screen);
            oVar1.screen.x = param1.PDAT_10.screen.x + local_20.x;
            oVar1.screen.y = param1.PDAT_10.screen.y + local_20.y;
            oVar1.screen.z = param1.PDAT_10.screen.z + local_20.z;
            oVar1.vr = param1.PDAT_10.vr;
            param1.DAT_03 = 2;
        }
    }

    //FUN_11F34 (ST6)
    private void FUN_11F34(CriInteract param1)
    {
        short sVar1;
        ushort uVar2;
        CriObject oVar3;
        byte bVar4;

        oVar3 = param1.PDAT_08;
        oVar3.screen.x += param1.SDAT_14;
        uVar2 = (ushort)DAT_1714C;
        bVar4 = (byte)(DAT_1714C + 1);
        DAT_1714C++;
        oVar3.screen.y = oVar3.screen.y + (ushort)param1.DAT_16 + param1.SDAT_1A * uVar2;
        sVar1 = param1.SDAT_18;
        oVar3.vr.x += 80;
        oVar3.vr.y += 80;
        oVar3.vr.z += 80;
        oVar3.screen.z += sVar1;

        if (19 < bVar4)
        {
            DAT_1714C = 0;
            param1.DAT_03 = 3;
        }
    }

    //FUN_11FD8 (ST6)
    private void FUN_11FD8(CriInteract param1)
    {
        param1.PDAT_08.FUN_5FF00();
        param1.DAT_03 = 4;
    }

    //FUN_12084 (ST6)
    private void FUN_12084(CriInteract param1)
    {
        byte bVar1;
        ushort uVar3;

        param1.DAT_07 = 0x20;
        param1.DAT_03++;
        //...
        //DAT_17470 = 30;
        //DAT_17472 = 30;
        //DAT_17474 = 230;
        //DAT_17476 = 230;
        //DAT_17478 = 4;

        if ((param1.DAT_02 & 1) == 0)
            bVar1 = param1.DAT_05;
        else
            bVar1 = param1.DAT_04;

        uVar3 = bVar1;
        //uVar4 = 0;
        //...
    }

    //FUN_12D68 (ST6)
    private void FUN_12D68(CriInteract param1)
    {
        sbyte sVar1;
        sbyte sVar2;
        CriStatic oVar3;

        oVar3 = SceneManager.instance.staticObjects[3];
        param1.PDAT_08 = SceneManager.instance.staticObjects[0];
        param1.PDAT_10 = oVar3;

        if (param1.DAT_04 == 0)
            param1.DAT_04 = 1;

        param1.DAT_02 = 0;
        param1.BDAT_16 = 0;
        sVar1 = (sbyte)(param1.DAT_05 - param1.DAT_04);
        param1.SDAT_14 = param1.DAT_05;

        while (sVar1 != 0)
        {
            param1.SDAT_14 += sVar1;
            sVar1 -= (sbyte)param1.DAT_04;
        }

        sVar2 = 1;

        if (param1.DAT_06 - param1.DAT_07 < 0)
            sVar2 = -1;

        param1.DAT_17 = sVar2;

        if ((param1.DAT_06 & 1) != 0)
        {
            param1.BDAT_16 = param1.DAT_05;

            if ((param1.DAT_07 & 2) != 0)
            {
                param1.DAT_03 = 1;
                return;
            }

            param1.DAT_03 = 2;
            return;
        }

        if ((param1.DAT_06 & 2) == 0)
        {
            param1.PDAT_10 = SceneManager.instance.staticObjects[4];

            if ((param1.DAT_07 & 1) != 0)
            {
                param1.DAT_03 = 5;
                return;
            }

            param1.DAT_03 = 6;
            return;
        }

        if ((param1.DAT_07 & 1) != 0)
        {
            param1.DAT_03 = 3;
            return;
        }

        param1.DAT_03 = 4;
    }

    //FUN_12EC8 (ST6)
    private void FUN_12EC8(CriInteract param1)
    {
        byte bVar1;
        short sVar2;
        bool bVar3;

        bVar1 = param1.DAT_02;

        if (bVar1 == 1)
        {
            sVar2 = (short)FUN_13CE8(param1);

            if (param1.PDAT_08.screen.y == sVar2)
            {
                param1.PDAT_10.screen.y = sVar2;
                param1.PDAT_10.flags |= 2;
                ((CriStatic)param1.PDAT_10).DAT_4A = 950;
                param1.DAT_02++;
                param1.DAT_18 = 0;
            }
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    param1.BDAT_16 = param1.DAT_05;
                    FUN_13CE8(param1);
                    bVar3 = InventoryManager.FUN_4A87C(3, 0x20);

                    if (bVar3)
                    {
                        InventoryManager.FUN_4A7E8(3, 0x20, false);
                        param1.DAT_02++;
                    }
                }
            }
            else
            {
                if (bVar1 == 2)
                    FUN_13E98(param1);
            }
        }
    }


    private void FUN_12FE4(CriInteract param1)
    {
        bool bVar1;
        short sVar2;
        CriStatic oVar4;

        if (param1.DAT_02 < 6)
        {
            switch (param1.DAT_02)
            {
                case 0:
                    param1.BDAT_16 = param1.DAT_0D;
                    FUN_13CE8(param1);
                    bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

                    if (bVar1)
                    {
                        InventoryManager.FUN_4A7E8(3, 0x20, false);
                        param1.DAT_02++;
                    }

                    break;
                case 1:
                    sVar2 = (short)FUN_13CE8(param1);

                    if (param1.PDAT_08.screen.y == sVar2)
                    {
                        param1.PDAT_10.screen.y = sVar2;
                        param1.PDAT_10.flags |= 2;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 950;
                        param1.DAT_02++;
                    }

                    break;
                case 2:
                    sVar2 = (short)FUN_13CE8(param1);
                    oVar4 = SceneManager.instance.staticObjects[4];

                    if (param1.PDAT_08.screen.y == sVar2)
                    {
                        param1.PDAT_10 = oVar4;
                        oVar4.flags &= 0xfffffffd;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 1000;
                        param1.PDAT_10.screen.y = sVar2;
                        param1.PDAT_08.screen.y = sVar2;
                        param1.DAT_02++;
                    }

                    break;
                case 3:
                    FUN_13CE8(param1);
                    bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

                    if (bVar1)
                    {
                        InventoryManager.FUN_4A7E8(3, 0x20, false);
                        param1.DAT_02++;
                    }

                    break;
                case 4:
                    sVar2 = (short)FUN_13CE8(param1);

                    if (param1.PDAT_08.screen.y == sVar2)
                    {
                        param1.PDAT_10.screen.y = sVar2 + 5000;
                        param1.PDAT_10.flags |= 2;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 950;
                        param1.DAT_02++;
                    }

                    break;
                case 5:
                    FUN_13E98(param1);
                    break;
            }
        }
    }

    //FUN_131B4 (ST6)
    private void FUN_131B4(CriInteract param1)
    {
        byte bVar1;
        short sVar2;

        bVar1 = param1.DAT_02;

        if (bVar1 == 1)
            FUN_1386C(param1);
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    GameManager.instance.FUN_5C94C(null, 145);
                    GameManager.instance.FUN_5C94C(null, 146);
                    param1.DAT_02++;
                }
            }
            else
            {
                if (bVar1 == 2)
                {
                    sVar2 = (short)FUN_13B04(param1);

                    if (param1.PDAT_08.screen.y == sVar2)
                    {
                        param1.PDAT_10.screen.y = sVar2;
                        param1.PDAT_10.flags &= 0xfffffffd;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 1000;
                        param1.DAT_02++;
                        param1.DAT_18 = 0;
                    }
                }
                else
                {
                    if (bVar1 == 3)
                    {
                        FUN_13B04(param1);
                        InventoryManager.FUN_4A7E8(3, 0x21, true);
                    }
                }
            }
        }
    }

    //FUN_132E0 (ST6)
    private void FUN_132E0(CriInteract param1)
    {
        bool bVar1;
        short sVar2;

        if (param1.DAT_02 < 6)
        {
            switch (param1.DAT_02)
            {
                case 0:
                    GameManager.instance.FUN_5C94C(null, 145);
                    GameManager.instance.FUN_5C94C(null, 146);
                    param1.DAT_02++;
                    break;
                case 1:
                    FUN_1386C(param1);
                    break;
                case 2:
                    sVar2 = (short)FUN_13CE8(param1);

                    if (param1.PDAT_08.screen.y == sVar2)
                    {
                        param1.PDAT_10 = SceneManager.instance.staticObjects[4];
                        param1.PDAT_10.screen.y = sVar2;
                        param1.PDAT_10.flags &= 0xfffffffd;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 1000;
                        param1.DAT_02++;
                    }

                    break;
                case 3:
                    FUN_13CE8(param1);
                    bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

                    if (bVar1)
                    {
                        InventoryManager.FUN_4A7E8(3, 0x20, false);
                        param1.DAT_02++;
                    }

                    break;
                case 4:
                    sVar2 = (short)FUN_13CE8(param1);

                    if (param1.PDAT_08.screen.y == sVar2)
                    {
                        param1.PDAT_10.screen.y = sVar2 + 5000;
                        param1.PDAT_10.flags |= 2;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 950;
                        param1.DAT_02++;
                    }

                    break;
                case 5:
                    FUN_13E98(param1);
                    break;
            }
        }
    }

    //FUN_1346C (ST6)
    private void FUN_1346C(CriInteract param1)
    {
        CriStatic oVar1;
        short sVar2;
        bool bVar3;

        if (param1.DAT_02 < 7)
        {
            switch (param1.DAT_02)
            {
                case 0:
                    GameManager.instance.FUN_5C94C(null, 145);
                    GameManager.instance.FUN_5C94C(null, 146);
                    param1.DAT_02++;
                    break;
                case 1:
                    FUN_1386C(param1);

                    if (param1.DAT_02 == 2)
                    {
                        param1.DAT_04 = 0;
                        param1.PDAT_10.flags |= 2;
                    }

                    break;
                case 2:
                    sVar2 = (short)FUN_13B04(param1);

                    if (param1.PDAT_10.screen.y == sVar2)
                    {
                        oVar1 = SceneManager.instance.staticObjects[3];
                        param1.PDAT_10 = oVar1;
                        oVar1.screen.y = sVar2;
                        param1.PDAT_10.flags &= 0xfffffffd;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 1000;
                        param1.BDAT_16 = 0;
                        param1.DAT_04 = 1;
                        param1.DAT_02++;
                    }

                    break;
                case 3:
                    FUN_13B04(param1);
                    bVar3 = InventoryManager.FUN_4A87C(3, 0x20);

                    if (bVar3)
                    {
                        InventoryManager.FUN_4A7E8(3, 0x20, false);
                        param1.DAT_02++;
                    }

                    break;
                case 4:
                    sVar2 = (short)FUN_13B04(param1);

                    if (param1.PDAT_08.screen.y == sVar2)
                    {
                        param1.PDAT_10.screen.y = sVar2;
                        param1.PDAT_10.flags |= 2;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 950;
                        param1.DAT_02++;
                    }

                    break;
                case 5:
                    sVar2 = (short)FUN_13B04(param1);

                    if (param1.PDAT_08.screen.y == sVar2)
                    {
                        param1.PDAT_10.screen.y = sVar2;
                        param1.PDAT_10.flags &= 0xfffffffd;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 1000;
                        param1.DAT_02++;
                    }

                    break;
                case 6:
                    FUN_13B04(param1);
                    InventoryManager.FUN_4A7E8(3, 0x21, true);
                    break;
            }
        }
    }

    //FUN_13698 (ST6)
    private void FUN_13698(CriInteract param1)
    {
        CriStatic oVar1;
        short sVar2;
        bool bVar3;

        if (param1.DAT_02 < 6)
        {
            switch (param1.DAT_02)
            {
                case 0:
                    GameManager.instance.FUN_5C94C(null, 145);
                    GameManager.instance.FUN_5C94C(null, 146);
                    param1.DAT_02++;
                    break;
                case 1:
                    FUN_1386C(param1);

                    if (param1.DAT_02 == 2)
                    {
                        param1.DAT_04 = 0;
                        param1.PDAT_10.flags |= 2;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 950;
                    }

                    break;
                case 2:
                    sVar2 = (short)FUN_13B04(param1);
                    oVar1 = SceneManager.instance.staticObjects[3];

                    if (param1.PDAT_10.screen.y == sVar2)
                    {
                        param1.PDAT_10 = oVar1;
                        oVar1.screen.y = sVar2;
                        oVar1.flags &= 0xfffffffd;
                        oVar1.DAT_4A = 1000;
                        param1.BDAT_16 = 0;
                        param1.DAT_04 = 1;
                        param1.DAT_02++;
                    }

                    break;
                case 3:
                    FUN_13B04(param1);
                    bVar3 = InventoryManager.FUN_4A87C(3, 0x20);

                    if (bVar3)
                    {
                        InventoryManager.FUN_4A7E8(3, 0x20, false);
                        param1.DAT_02++;
                    }

                    break;
                case 4:
                    sVar2 = (short)FUN_13B04(param1);

                    if (param1.PDAT_08.screen.y == sVar2)
                    {
                        param1.PDAT_10.screen.y = sVar2;
                        param1.PDAT_10.flags |= 2;
                        ((CriStatic)param1.PDAT_10).DAT_4A = 950;
                        param1.DAT_02++;
                    }

                    break;
                case 5:
                    FUN_13E98(param1);
                    break;
            }
        }
    }

    //FUN_1386C (ST6)
    private void FUN_1386C(CriInteract param1)
    {
        sbyte sVar1;
        CriObject oVar2;
        CriObject oVar3;
        LightSource lVar4;
        short sVar5;
        int iVar6;
        uint uVar7;
        int iVar8;
        CriObject oVar8;
        int iVar9;

        iVar8 = (sbyte)param1.BDAT_16 * param1.DAT_17;
        sVar5 = (short)iVar8;
        param1.PDAT_08.screen.y += sVar5;
        param1.PDAT_10.screen.y += sVar5;
        iVar9 = System.Array.IndexOf(SceneManager.instance.staticObjects, param1.PDAT_08);
        oVar2 = SceneManager.instance.staticObjects[iVar9 + 1];
        oVar3 = SceneManager.instance.staticObjects[iVar9 + 2];
        uVar7 = 0;
        oVar2.screen.y += sVar5;
        oVar3.screen.y += sVar5;

        do
        {
            lVar4 = SceneManager.instance.FUN_55790((int)uVar7);
            iVar6 = lVar4.DAT_04.y + iVar8;
            sVar5 = (short)iVar6;
            iVar6 *= 0x10000;

            if ((param1.DAT_06 & 4) == 0)
            {
                if (0 < iVar6)
                    lVar4.DAT_04.y = sVar5 - 5000;
            }
            else
            {
                if (iVar6 >> 0x10 < -5000)
                    lVar4.DAT_04.y = sVar5 + 5000;
            }

            uVar7++;
        } while (uVar7 < 4);

        if (param1.DAT_17 < 0)
        {
            oVar8 = param1.PDAT_08;

            if (oVar8.screen.y < -10000)
                oVar8.screen.y += 15000;

            if (oVar2.screen.y < -10000)
                oVar2.screen.y += 15000;

            if (oVar3.screen.y < -10000)
                oVar3.screen.y += 15000;

            if (-5000 <= param1.PDAT_10.screen.y) goto LAB_13AA0;

            param1.PDAT_10.screen.y = -5000;
        }
        else
        {
            oVar8 = param1.PDAT_08;

            if (5000 < oVar8.screen.y)
                oVar8.screen.y -= 15000;

            if (5000 < oVar2.screen.y)
                oVar2.screen.y -= 15000;

            if (5000 < oVar3.screen.y)
                oVar3.screen.y -= 15000;

            if (param1.PDAT_10.screen.y <= 5000) goto LAB_13AA0;

            ((CriStatic)param1.PDAT_10).DAT_4A = 1000;
        }

        LAB_13AA0:
        sVar1 = (sbyte)(param1.BDAT_16 + param1.DAT_04);
        param1.BDAT_16 = (byte)sVar1;

        if (param1.DAT_05 < sVar1)
        {
            param1.BDAT_16 = param1.DAT_05;
            param1.DAT_02++;
        }

        FUN_14164(param1);
    }

    //FUN_13B04 (ST6)
    private int FUN_13B04(CriInteract param1)
    {
        short sVar1;
        LightSource lVar2;
        CriObject oVar2;
        int iVar3;
        CriObject oVar3;
        short sVar4;
        CriObject oVar5;
        uint uVar6;
        int iVar7;

        param1.PDAT_08.screen.y += (sbyte)param1.BDAT_16;
        oVar5 = param1.PDAT_08;
        iVar7 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar5);
        oVar2 = SceneManager.instance.staticObjects[iVar7 + 1];
        oVar3 = SceneManager.instance.staticObjects[iVar7 + 2];
        sVar1 = 20000;

        if (5000 < oVar5.screen.y)
        {
            sVar1 = (short)(oVar5.screen.y - 15000);
            oVar5.screen.y = sVar1;
        }

        oVar2.screen.y += (sbyte)param1.BDAT_16;

        if (5000 < oVar2.screen.y)
            oVar2.screen.y -= 15000;

        oVar3.screen.y += (sbyte)param1.BDAT_16;

        if (5000 < oVar3.screen.y)
            oVar3.screen.y -= 15000;

        param1.PDAT_10.screen.y += (sbyte)param1.BDAT_16;

        if (param1.DAT_04 == 0)
        {
            oVar2 = param1.PDAT_10;
            uVar6 = 0;

            if (oVar2.screen.y <= 10000) goto LAB_13C78;

            sVar1 = (short)(oVar2.screen.y - 20000);
        }
        else
        {
            oVar2 = param1.PDAT_10;
            uVar6 = 0;

            if (oVar2.screen.y <= 5000) goto LAB_13C78;

            sVar1 = (short)(oVar2.screen.y - 15000);
        }

        oVar2.screen.y = sVar1;
        uVar6 = 0;

        LAB_13C78:
        do
        {
            lVar2 = SceneManager.instance.FUN_55790((int)uVar6);
            iVar3 = lVar2.DAT_04.y + (sbyte)param1.BDAT_16;
            sVar4 = (short)iVar3;
            lVar2.DAT_04.y = sVar4;

            if (0 < iVar3 * 0x10000)
                lVar2.DAT_04.y = sVar4 - 5000;

            uVar6++;
        } while (uVar6 < 4);

        FUN_14164(param1);
        return sVar1;
    }

    //FUN_13CE8 (ST6)
    private int FUN_13CE8(CriInteract param1)
    {
        short sVar1;
        LightSource lVar2;
        CriObject oVar2;
        int iVar3;
        CriObject oVar3;
        short sVar4;
        CriObject oVar5;
        int iVar6;

        param1.PDAT_08.screen.y -= (sbyte)param1.BDAT_16;
        oVar5 = param1.PDAT_08;
        iVar6 = System.Array.IndexOf(SceneManager.instance.staticObjects, oVar5);
        oVar2 = SceneManager.instance.staticObjects[iVar6 + 1];
        oVar3 = SceneManager.instance.staticObjects[iVar6 + 2];
        sVar1 = 20000;

        if (oVar5.screen.y < -10000)
        {
            sVar1 = (short)(oVar5.screen.y + 15000);
            oVar5.screen.y = sVar1;
        }

        oVar2.screen.y -= (sbyte)param1.BDAT_16;

        if (oVar2.screen.y < -10000)
            oVar2.screen.y += 15000;

        oVar3.screen.y -= (sbyte)param1.BDAT_16;

        if (oVar3.screen.y < -10000)
            oVar3.screen.y += 15000;

        param1.PDAT_10.screen.y -= (sbyte)param1.BDAT_16;
        oVar2 = param1.PDAT_10;

        if (oVar2.screen.y < -10000)
            oVar2.screen.y += 15000;

        iVar6 = 0;

        do
        {
            lVar2 = SceneManager.instance.FUN_55790(iVar6);
            iVar3 = lVar2.DAT_04.y - (sbyte)param1.BDAT_16;
            sVar4 = (short)iVar3;
            lVar2.DAT_04.y = sVar4;

            if (iVar3 * 0x10000 >> 0x10 < -5000)
                lVar2.DAT_04.y = sVar4 + 5000;

            iVar6++;
        } while (iVar6 < 4);

        FUN_14164(param1);
        return sVar1;
    }

    //FUN_13E98 (ST6)
    private void FUN_13E98(CriInteract param1)
    {
        LightSource lVar1;
        CriObject oVar1;
        CriObject oVar2;
        int iVar2;
        short sVar3;
        int iVar4;
        uint uVar5;
        int iVar6;
        int iVar7;

        iVar6 = (sbyte)param1.BDAT_16 * param1.DAT_17;
        sVar3 = (short)iVar6;
        param1.PDAT_08.screen.y += sVar3;
        param1.PDAT_10.screen.y += sVar3;
        iVar7 = System.Array.IndexOf(SceneManager.instance.staticObjects, param1.PDAT_08);
        oVar1 = SceneManager.instance.staticObjects[iVar7 + 1];
        uVar5 = 0;
        oVar2 = SceneManager.instance.staticObjects[iVar7 + 2];
        oVar1.screen.y += sVar3;
        uVar5 = 0;
        oVar2.screen.y += sVar3;

        do
        {
            lVar1 = SceneManager.instance.FUN_55790((int)uVar5);
            iVar2 = lVar1.DAT_04.y + iVar6;
            sVar3 = (short)iVar2;
            lVar1.DAT_04.y = sVar3;
            iVar2 *= 0x10000;

            if ((param1.DAT_06 & 4) == 0)
            {
                if (0 < iVar2)
                    lVar1.DAT_04.y = sVar3 - 5000;
            }
            else
            {
                if (iVar2 >> 0x10 < -5000)
                    lVar1.DAT_04.y = sVar3 + 5000;
            }

            uVar5++;
        } while (uVar5 < 4);

        if (param1.DAT_17 < 0)
        {
            if (param1.PDAT_10.screen.y < param1.SDAT_14)
            {
                param1.BDAT_16 -= param1.DAT_04;

                if (DAT_171D4[0] != 0)
                {
                    iVar4 = 146;

                    if (param1.DAT_03 < 3)
                        iVar4 = 240;

                    GameManager.instance.FUN_5C860(iVar4);
                    GameManager.instance.FUN_5C94C(null, 147);
                    DAT_171D4[0] = 0;
                }
            }

            if (-1 < param1.PDAT_10.screen.y) goto LAB_14108;

            param1.PDAT_10.screen.y = 0;
            InventoryManager.FUN_4A7E8(3, 0x21, true);
            DAT_171D4[0] = 1;
        }
        else
        {
            if (param1.SDAT_14 < param1.PDAT_10.screen.y)
            {
                param1.BDAT_16 -= param1.DAT_04;

                if (DAT_171D4[0] != 0)
                {
                    GameManager.instance.FUN_5C860(146);
                    GameManager.instance.FUN_5C94C(null, 147);
                    DAT_171D4[0] = 0;
                }
            }

            if (param1.PDAT_10.screen.y < 1) goto LAB_14108;

            param1.PDAT_10.screen.y = 0;
            DAT_171D4[0] = 1;
            InventoryManager.FUN_4A7E8(3, 0x21, true);
        }

        param1.FUN_5FF98();
        
        LAB_14108:
        if ((sbyte)param1.BDAT_16 < 1)
        {
            param1.PDAT_10.screen.y = 0;
            InventoryManager.FUN_4A7E8(3, 0x21, true);
            DAT_171D4[0] = 1;
            param1.FUN_5FF98();
        }

        FUN_14164(param1);
    }

    //FUN_14164 (ST6)
    private void FUN_14164(CriInteract param1)
    {
        short sVar1;
        CriInteract puVar2;
        int pbVar3;
        CriParticle oVar4;
        CriStatic oVar5;
        int iVar6;
        int iVar7;

        iVar7 = (sbyte)param1.BDAT_16 * param1.DAT_17;
        pbVar3 = 0;

        if (pbVar3 < 10)
        {
            do
            {
                puVar2 = SceneManager.instance.DAT_8FFC[pbVar3];

                if ((puVar2.DAT_00 & 1) != 0 && puVar2.DAT_01 == 11)
                {
                    sVar1 = (short)puVar2.VDAT_10.y;
                    puVar2.VDAT_10.y = sVar1 + iVar7;
                    puVar2.FUN_5FF98();
                }

                pbVar3++;
            } while (pbVar3 < 10);
        }

        iVar6 = 59;
        pbVar3 = 0;

        do
        {
            oVar4 = SceneManager.instance.particleObjects[pbVar3];

            if ((oVar4.flags & 1) != 0 && oVar4.tags == 3 && oVar4.DAT_2F == 0)
            {
                sVar1 = (short)oVar4.screen.y;
                oVar4.screen.y = sVar1 + iVar7;
                oVar4.FUN_60068();
            }

            pbVar3++;
            iVar6--;
        } while (iVar6 != -1);

        pbVar3 = 0;

        if (pbVar3 < 36)
        {
            do
            {
                oVar5 = SceneManager.instance.staticObjects[pbVar3];

                if ((oVar5.flags & 1) != 0 && oVar5.DAT_2F == 7 && 1 < oVar5.tags)
                {
                    sVar1 = (short)oVar5.screen.y;
                    oVar5.screen.y = sVar1 + iVar7;

                    if (0 < (sVar1 + iVar7) * 0x10000)
                        oVar5.FUN_5FF00();
                }

                pbVar3++;
            } while (pbVar3 < 36);
        }
    }

    //FUN_144E4 (ST6)
    private void FUN_144E4(CriInteract param1)
    {
        short sVar1;

        if (GameManager.instance.DAT_9AA0 == 0x60c)
            sVar1 = 500;
        else
        {
            sVar1 = -400;

            if (GameManager.instance.DAT_9AA0 != 0x611)
            {
                param1.FUN_5FF98();
                return;
            }
        }

        param1.DAT_08 = 0;
        param1.DAT_0A = 0;
        param1.DAT_0C = sVar1;
        param1.DAT_03++;
    }

    //FUN_14560 (ST6)
    private void FUN_14560(CriInteract param1)
    {
        CriParticle psVar2;
        CriInteract psVar3;
        int iVar4;
        int pbVar5;
        int iVar6;
        CriStatic oVar7;

        pbVar5 = 0;

        if (pbVar5 < 10)
        {
            do
            {
                psVar3 = SceneManager.instance.DAT_8FFC[pbVar5];

                if ((psVar3.DAT_14 & 1) != 0 && psVar3.DAT_01 == 11)
                {
                    psVar3.VDAT_10.x += param1.DAT_08;
                    psVar3.VDAT_10.y += param1.DAT_0A;
                    psVar3.VDAT_10.z += param1.DAT_0C;
                }

                pbVar5++;
            } while (pbVar5 < 10);
        }

        iVar6 = 59;
        pbVar5 = 0;

        do
        {
            psVar2 = SceneManager.instance.particleObjects[pbVar5];

            if ((psVar2.flags & 1) != 0 && psVar2.tags == 3 && psVar2.DAT_2F == 0 && psVar2.DAT_69 != 0)
            {
                psVar2.screen.x += param1.DAT_08;
                psVar2.screen.y += param1.DAT_0A;
                psVar2.screen.z += param1.DAT_0C;
            }

            iVar6--;
            pbVar5++;
        } while (iVar6 != -1);

        iVar4 = 0;

        if (iVar4 < 36)
        {
            oVar7 = SceneManager.instance.staticObjects[iVar4];

            do
            {
                if ((oVar7.flags & 1) != 0 && oVar7.DAT_2E == 7 && 1 < oVar7.tags)
                {
                    oVar7.screen.x += param1.DAT_08;
                    oVar7.screen.y += param1.DAT_0A;
                    oVar7.screen.z += param1.DAT_0C;
                }

                iVar4++;
            } while (iVar4 < 36);
        }
    }

    //FUN_14758 (ST6)
    private void FUN_14758(CriInteract param1)
    {
        param1.DAT_04 = 0;
        param1.PDAT_08 = null;
        param1.DAT_03++;
        InventoryManager.FUN_4A7E8(3, 0x3d, true);
        DAT_174E4 = 0;
    }

    //FUN_14B8C (ST6)
    private void FUN_14B8C(CriInteract param1)
    {
        bool bVar1;

        param1.DAT_04 = 2;
        bVar1 = InventoryManager.FUN_4A87C(3, 0x3e);

        if (bVar1)
            param1.DAT_04 = 0;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x3f);

        if (bVar1)
            param1.DAT_04 = 1;

        PTR_FUN_171F0[param1.DAT_04](param1);
    }

    //FUN_15238 (ST6)
    private void FUN_15238(CriInteract param1)
    {
        param1.DAT_0A = 0;
        param1.DAT_08 = 0;
        param1.DAT_0E = 0;
        param1.DAT_0C = 0;
        param1.DAT_03 = 1;
    }

    //FUN_15258 (ST6)
    private void FUN_15258(CriInteract param1)
    {
        short sVar2;

        sVar2 = param1.DAT_08;

        while (sVar2 < 20)
        {
            //...
            sVar2 = (short)(param1.DAT_08 + 1);
            param1.DAT_08 = sVar2;
        }

        sVar2 = (short)(param1.DAT_0A + 1);
        param1.DAT_0A = sVar2;

        if (5 < sVar2)
        {
            param1.DAT_08 = 0;
            param1.DAT_0A = 0;
        }
    }

    //FUN_153A8 (ST6)
    private void FUN_153A8(CriInteract param1)
    {
        return;
    }

    //FUN_15428 (ST6)
    private void FUN_15428(CriInteract param1)
    {
        param1.BDAT_08 = 0;
        param1.DAT_09 = false;
        param1.DAT_03++;
    }

    //FUN_15440 (ST6)
    private void FUN_15440(CriInteract param1)
    {
        sbyte sVar1;
        CriSkinned oVar2;
        CriInteract oVar3;
        CriBone oVar4;

        oVar2 = SceneManager.instance.skinnedObjects[10];

        if (oVar2.screen.y == 0)
            return;

        if (oVar2.DAT_3C == 1 && oVar2.DAT_3D == 0 && oVar2.frameNum == 0)
        {
            if (param1.BDAT_08 == 0)
            {
                oVar3 = SceneManager.instance.FUN_5FF08();

                if (oVar3 != null)
                {
                    oVar3.DAT_01 = 11;
                    oVar3.BDAT_0A = 2;
                    //...
                    oVar4 = (CriBone)Utilities.FUN_601C8(oVar2.skeleton, 0);
                    oVar3.PTR_18 = oVar4;
                }

                param1.BDAT_08 = 15;

                if (param1.BDAT_08 != 0)
                    param1.BDAT_08--;
            }
            else
                param1.BDAT_08--;
        }
        else
        {
            if (param1.BDAT_08 != 0)
                param1.BDAT_08--;
        }

        if (oVar2.DAT_3C == 1)
        {
            sVar1 = (sbyte)oVar2.DAT_3D;

            if ((sVar1 == 1 || sVar1 == 4 || sVar1 == 2 || sVar1 == 5) && oVar2.frameNum == 0)
            {
                if (param1.DAT_09) goto LAB_155B8;

                oVar3 = SceneManager.instance.FUN_5FF08();

                if (oVar3 != null)
                {
                    oVar3.DAT_01 = 11;
                    oVar3.BDAT_0A = 8;
                    //...
                    oVar4 = (CriBone)Utilities.FUN_601C8(oVar2.skeleton, 0);
                    oVar3.PTR_18 = oVar4;
                }

                param1.BDAT_09 = 20;
            }

            if (param1.BDAT_09 == 0)
                return;
        }

        LAB_155B8:
        param1.BDAT_09--;
    }

    //FUN_1561C (ST6)
    private void FUN_1561C(CriStatic param1)
    {
        param1.VDAT_74.x = -80;
        param1.tags++;
    }

    //FUN_15634 (ST6)
    private void FUN_15634(CriStatic param1)
    {
        short sVar1;

        sVar1 = (short)(param1.VDAT_74.x + 4);
        param1.screen.x -= 200;
        param1.VDAT_74.x = sVar1;
        param1.vr.z -= 634;
        param1.screen.y += sVar1;
    }

    //FUN_156A4 (ST6)
    private void FUN_156A4(CriStatic param1)
    {
        param1.tags++;
        param1.DAT_4C = new Vector3Int(0, 0, 0);
        //FUN_15708
    }

    //FUN_156E8 (ST6)
    private void FUN_156E8(CriStatic param1)
    {
        //FUN_158C8
    }

    //FUN_CD5C (ST6)
    public static void FUN_CD5C(CriParticle param1)
    {
        instance.PTR_FUN_16F38[param1.DAT_3C](param1);
    }

    //FUN_D550 (ST6)
    public static void FUN_D550(CriParticle param1)
    {
        instance.PTR_FUN_16F74[param1.DAT_3C](param1);
    }

    //FUN_DDEC (ST6)
    public static void FUN_DDEC(CriParticle param1)
    {
        instance.PTR_FUN_16F84[param1.DAT_3C](param1);
    }

    //FUN_DEF4 (ST6)
    public static void FUN_DEF4(CriParticle param1)
    {
        instance.PTR_FUN_16FA8[param1.DAT_3C](param1);
    }

    //FUN_C904 (ST6)
    public static void FUN_C904(CriParticle param1)
    {
        instance.PTR_FUN_16F18[param1.DAT_3C](param1);
    }

    //FUN_CB2C (ST6)
    public static void FUN_CB2C(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_16F2C[param1.DAT_3C](param1);
    }

    //FUN_E0A8 (ST6)
    public static void FUN_E0A8(CriParticle param1)
    {
        instance.PTR_FUN_16FB4[param1.DAT_3C](param1);
    }

    //FUN_E2B0 (ST6)
    public static void FUN_E2B0(CriParticle param1)
    {
        instance.PTR_FUN_16FD4[param1.DAT_3C](param1);
    }

    //FUN_E410 (ST6)
    public static void FUN_E410(CriParticle param1)
    {
        instance.PTR_FUN_16FFC[param1.DAT_3C](param1);
    }

    //FUN_E59C (ST6)
    public static void FUN_E59C(CriParticle param1)
    {
        int iVar1;

        instance.PTR_FUN_1701C[param1.DAT_3C](param1);
        iVar1 = param1.IDAT_6C - 1;

        if (param1.IDAT_6C != 0xff)
        {
            param1.IDAT_6C = iVar1;

            if (iVar1 == -1)
                param1.FUN_451A4();
        }
    }

    //FUN_E73C (ST6)
    public static void FUN_E73C(CriParticle param1)
    {
        int iVar1;

        instance.PTR_FUN_1706C[param1.DAT_3C](param1);
        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();
    }

    //FUN_E8E4 (ST6)
    public static void FUN_E8E4(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_170AC[param1.DAT_3C](param1);
    }

    //FUN_EB5C (ST6)
    public static void FUN_EB5C(CriParticle param1)
    {
        instance.PTR_FUN_170B8[param1.DAT_3C](param1);
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

        oVar5 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
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
        instance.PTR_FUN_173E8[param1.tags](param1);
    }

    //FUN_155E0 (ST6)
    public static void FUN_155E0(CriStatic param1)
    {
        instance.PTR_FUN_173E0[param1.tags](param1);
    }

    //FUN_EB98 (ST6)
    public static void FUN_EB98(CriInteract param1)
    {
        ((CriPlayer)SceneManager.instance.skinnedObjects[10]).DAT_1C0 &= 0xfffffffe;
        instance.PTR_FUN_170C4[param1.DAT_03](param1);
    }

    //FUN_1200C (ST6)
    public static void FUN_1200C(CriInteract param1)
    {
        instance.PTR_FUN_17150[param1.DAT_03](param1);
    }

    //FUN_12048 (ST6)
    public static void FUN_12048(CriInteract param1)
    {
        instance.PTR_FUN_171A8[param1.DAT_03](param1);
    }

    //FUN_14380 (ST6)
    public static void FUN_14380(CriInteract param1)
    {
        Trigger6 puVar1;
        uint uVar3;

        uVar3 = 0;

        do
        {
            puVar1 = SceneManager.instance.DAT_9FE0[uVar3];

            if (puVar1.DAT_13)
            {
                if (puVar1.DAT_28 == 0x405 && GameManager.instance.DAT_9ADC == 0x405)
                {
                    puVar1.DAT_28 = 0x60f;
                    puVar1.DAT_00[3].x = -0x100;
                    puVar1.DAT_00[0].x = -0x100;
                    puVar1.DAT_00[2].y = 0x2e8;
                    puVar1.DAT_00[1].x = 0x2e8;
                    puVar1.DAT_00[1].y = -0x1279;
                    puVar1.DAT_00[0].y = -0x1279;
                    puVar1.DAT_00[3].y = -0x1661;
                    puVar1.DAT_00[2].x = -0x1661;
                }
                else
                {
                    if (puVar1.DAT_28 == 0x60f && GameManager.instance.DAT_9ADC == 0x60f)
                    {
                        puVar1.DAT_28 = 0x405;
                        puVar1.DAT_00[3].x = -0xc84;
                        puVar1.DAT_00[0].x = -0xc84;
                        puVar1.DAT_00[2].y = -0x89c;
                        puVar1.DAT_00[1].x = -0x89c;
                        puVar1.DAT_00[1].y = -0x162c;
                        puVar1.DAT_00[0].y = -0x162c;
                        puVar1.DAT_00[3].y = 0x1a14;
                        puVar1.DAT_00[2].x = 0x1a14;
                    }
                }
            }

            uVar3++;
        } while (uVar3 < 4);

        param1.FUN_5FF98();
    }

    //FUN_F1A8 (ST6)
    public static void FUN_F1A8(CriInteract param1)
    {
        instance.PTR_FUN_170F0[param1.DAT_03](param1);

        if (param1.DAT_03 != 4)
        {
            //...
        }
    }

    //FUN_144A8 (ST6)
    public static void FUN_144A8(CriInteract param1)
    {
        instance.PTR_FUN_171D8[param1.DAT_03](param1);
    }

    //FUN_12D2C (ST6)
    public static void FUN_12D2C(CriInteract param1)
    {
        instance.PTR_FUN_171B4[param1.DAT_03](param1);
    }

    //FUN_14C04 (ST6)
    public static void FUN_14C04(CriInteract param1)
    {
        bool bVar1;
        CriCamera cVar2;

        instance.PTR_FUN_171FC[param1.DAT_03](param1);
        bVar1 = InventoryManager.FUN_4A87C(3, 0x3c);

        if (bVar1)
        {
            InventoryManager.FUN_4A7E8(3, 0x3c, false);
            InventoryManager.FUN_4A7E8(3, 0x3a, true);
            cVar2 = SceneManager.instance.cCamera;
            cVar2.DAT_70 = 1;
            cVar2.PTR_FUN_8C = cVar2.FUN_14C90;
        }
    }

    //FUN_14EA8 (ST6)
    public static void FUN_14EA8(CriInteract param1)
    {
        sbyte sVar1;
        byte bVar2;
        short sVar3;
        bool bVar4;
        CriStatic oVar6;
        CriStatic oVar7;
        Vector3Int local_38;
        Vector3Int local_30;
        Vector3Int local_28;
        Matrix3x3 auStack88;

        oVar7 = SceneManager.instance.staticObjects[2];
        sVar1 = param1.DAT_03;
        oVar6 = SceneManager.instance.staticObjects[1];

        if (sVar1 == 1)
        {
            bVar4 = InventoryManager.FUN_4A87C(3, 0x2c);

            if (bVar4)
            {
                bVar2 = (byte)param1.DAT_15;
                param1.DAT_15 = (sbyte)(bVar2 + 1);

                if (5 < bVar2)
                {
                    GameManager.instance.FUN_5C94C(oVar6, 145);
                    InventoryManager.FUN_4A7E8(3, 0x2c, false);
                    param1.DAT_15 = 0;
                }
            }

            local_28 = new Vector3Int(0, (byte)param1.DAT_14 << 6, 0);
            auStack88 = new Matrix3x3();
            Utilities.RotMatrix(ref local_28, ref auStack88);
            local_38 = new Vector3Int(param1.DAT_0C, oVar6.screen.y, param1.DAT_0E);
            local_30 = Utilities.ApplyMatrixSV(ref auStack88, ref local_38);
            oVar6.screen.x = local_30.x + param1.DAT_08;
            oVar6.screen.z = local_30.z + param1.DAT_0A;
            local_38 = new Vector3Int(param1.VDAT_10.x, oVar7.screen.y, param1.VDAT_10.y);
            local_30 = Utilities.ApplyMatrixSV(ref auStack88, ref local_38);
            oVar7.screen.x = local_30.x + param1.DAT_08;
            oVar7.screen.z = local_30.z + param1.DAT_0A;
            bVar2 = (byte)(param1.DAT_14 + 1);
            param1.DAT_14 = (sbyte)bVar2;

            if (bVar2 < 33)
                return;

            oVar6.screen.x = param1.VDAT_10.x + param1.DAT_08;
            oVar6.screen.z = param1.VDAT_10.y + param1.DAT_0A;
            oVar7.screen.x = param1.DAT_0C + param1.DAT_08;
            oVar7.screen.z = param1.DAT_0E + param1.DAT_0A;
            InventoryManager.FUN_4A7E8(3, 0x3e, true);
            param1.DAT_03++;
        }
        else
        {
            if (sVar1 < 2)
            {
                if (sVar1 != 0)
                    return;

                param1.DAT_08 = (short)((oVar6.screen.x + oVar7.screen.x) / 2);
                param1.DAT_0A = (short)((oVar6.screen.z + oVar7.screen.z) / 2);
                param1.DAT_0C = (short)(oVar6.screen.x - param1.DAT_08);
                param1.DAT_0E = (short)(oVar6.screen.z - param1.DAT_0A);
                param1.VDAT_10.x = (short)(oVar7.screen.x - param1.DAT_08);
                param1.VDAT_10.y = (short)(oVar7.screen.z - param1.DAT_0A);
                oVar6.DAT_4A = 969;
                oVar7.DAT_4A = 970;
                param1.DAT_14 = 0;
                param1.DAT_15 = 0;
                param1.BDAT_16 = 0;
                param1.DAT_03++;
                InventoryManager.FUN_4A7E8(3, 0x2c, true);
                //FUN_1D988
                return;
            }

            if (sVar1 != 2)
                return;

            oVar7 = SceneManager.instance.staticObjects[param1.BDAT_16];
            sVar3 = (short)(oVar7.screen.y + 4);
            oVar7.screen.y = sVar3;

            if (sVar3 < 1074)
                return;

            oVar7.screen.y = -1075;
            GameManager.instance.FUN_5C860(145);
            bVar2 = (byte)(param1.BDAT_16 + 1);
            param1.BDAT_16 = bVar2;

            if (bVar2 < 4)
                return;

            InventoryManager.FUN_4A7E8(3, 0x3e, true);
        }

        param1.FUN_5FF98();
    }

    //FUN_153B0 (ST6)
    public static void FUN_153B0(CriInteract param1)
    {
        instance.PTR_FUN_17310[param1.DAT_03](param1);
    }

    //FUN_153EC (ST6)
    public static void FUN_153EC(CriInteract param1)
    {
        instance.PTR_FUN_173D4[param1.DAT_03](param1);
    }
}
