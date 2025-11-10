using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct UNK_16CFC
{
    public uint DAT_00; //0x00
    public ushort DAT_04; //0x04
}

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
    private delegate void FUN_16044(CriPlayer p); //0x16044 (ST9)
    private delegate void FUN_16050(CriPlayer p); //0x16050 (ST9)
    private delegate void FUN_16060(CriPlayer p); //0x16060 (ST9)
    private delegate void FUN_16068(CriPlayer p); //0x16068 (ST9)
    private delegate void FUN_16080(CriPlayer p); //0x16080 (ST9)
    private delegate void FUN_16088(CriPlayer p); //0x16088 (ST9)
    private delegate void FUN_16098(CriPlayer p); //0x16098 (ST9)
    private delegate void FUN_160A0(CriPlayer p); //0x160A0 (ST9)
    private delegate void FUN_160B4(CriPlayer p); //0x160B4 (ST9)
    private delegate void FUN_161B8(CriPlayer p); //0x161B8 (ST9)
    private delegate void FUN_161D0(CriPlayer p); //0x161D0 (ST9)
    private delegate void FUN_161D8(CriPlayer p); //0x161D8 (ST9)
    private delegate void FUN_161E0(CriPlayer p); //0x161E0 (ST9)
    private delegate void FUN_161E8(CriPlayer p); //0x161E8 (ST9)
    private delegate void FUN_161F0(CriPlayer p); //0x161F0 (ST9)
    private delegate void FUN_16204(CriPlayer p); //0x16204 (ST9)
    private delegate void FUN_16218(CriPlayer p); //0x16218 (ST9)
    private delegate void FUN_1622C(CriPlayer p); //0x1622C (ST9)
    private delegate void FUN_16238(CriPlayer p); //0x16238 (ST9)
    private delegate void FUN_16244(CriPlayer p); //0x16244 (ST9)
    private delegate void FUN_16250(CriPlayer p); //0x16250 (ST9)
    private delegate void FUN_164B0(CriPlayer p); //0x164B0 (ST9)
    private delegate void FUN_164CC(CriPlayer p); //0x164CC (ST9)
    private delegate void FUN_164F8(CriPlayer p); //0x164F8 (ST9)
    private delegate void FUN_16524(CriPlayer p); //0x16524 (ST9)
    private delegate void FUN_1652C(CriPlayer p); //0x1652C (ST9)
    private delegate void FUN_16534(CriPlayer p); //0x16534 (ST9)
    private delegate void FUN_1653C(CriPlayer p); //0x1653C (ST9)
    private delegate void FUN_16544(CriPlayer p); //0x16544 (ST9)
    private delegate void FUN_16574(CriPlayer p); //0x16574 (ST9)
    private delegate void FUN_165CC(CriPlayer p); //0x165CC (ST9)
    private delegate void FUN_165F0(CriPlayer p); //0x165F0 (ST9)
    private delegate void FUN_165F8(CriPlayer p); //0x165F8 (ST9)
    private delegate void FUN_16614(CriPlayer p); //0x16614 (ST9)
    private delegate void FUN_16654(CriPlayer p); //0x16654 (ST9)
    private delegate void FUN_1666C(CriPlayer p); //0x1666C (ST9)
    private delegate void FUN_16674(CriPlayer p); //0x16674 (ST9)
    private delegate void FUN_16684(CriPlayer p); //0x16684 (ST9)
    private delegate void FUN_166EC(CriPlayer p); //0x166EC (ST9)
    private delegate void FUN_166F4(CriPlayer p); //0x166F4 (ST9)
    private delegate void FUN_166FC(CriPlayer p); //0x166FC (ST9)
    private delegate void FUN_16704(CriPlayer p); //0x16704 (ST9)
    private delegate void FUN_16748(CriPlayer p); //0x16748 (ST9)
    private delegate void FUN_16754(CriPlayer p); //0x16754 (ST9)
    private delegate void FUN_167E0(CriPlayer p); //0x167E0 (ST9)
    private delegate void FUN_16838(CriPlayer p); //0x16838 (ST9)
    private delegate void FUN_16840(CriPlayer p); //0x16840 (ST9)
    private delegate void FUN_16854(CriPlayer p); //0x16854 (ST9)
    private delegate void FUN_16860(CriPlayer p); //0x16860 (ST9)
    private delegate void FUN_1686C(CriPlayer p); //0x1686C (ST9)
    private delegate void FUN_16874(CriPlayer p); //0x16874 (ST9)
    private delegate void FUN_16884(CriPlayer p); //0x16884 (ST9)
    private delegate void FUN_1688C(CriPlayer p); //0x1688C (ST9)
    private delegate void FUN_16894(CriPlayer p); //0x16894 (ST9)
    private delegate void FUN_1689C(CriPlayer p); //0x1689C (ST9)
    private delegate void FUN_168B4(CriPlayer p); //0x168B4 (ST9)
    private delegate void FUN_168D4(CriPlayer p); //0x168D4 (ST9)
    private delegate void FUN_168F8(CriPlayer p); //0x168F8 (ST9)
    private delegate void FUN_16900(CriPlayer p); //0x16900 (ST9)
    private delegate void FUN_16908(CriPlayer p); //0x16908 (ST9)
    private delegate void FUN_16918(CriPlayer p); //0x16918 (ST9)
    private delegate void FUN_16928(CriPlayer p); //0x16928 (ST9)
    private delegate void FUN_16930(CriPlayer p); //0x16930 (ST9)
    private delegate void FUN_1694C(CriPlayer p); //0x1694C (ST9)
    private delegate void FUN_16954(CriPlayer p); //0x16954 (ST9)
    private delegate void FUN_1696C(CriPlayer p); //0x1696C (ST9)
    private delegate void FUN_16974(CriPlayer p); //0x16974 (ST9)
    private delegate void FUN_1697C(CriPlayer p); //0x1697C (ST9)
    private delegate void FUN_16988(CriPlayer p); //0x16988 (ST9)
    private delegate void FUN_1699C(CriPlayer p); //0x1699C (ST9)
    private delegate void FUN_169A4(CriPlayer p); //0x169A4 (ST9)
    private delegate void FUN_169BC(CriPlayer p); //0x169BC (ST9)
    private delegate void FUN_16CF0(CriParticle p); //0x16CF0 (ST9)
    private delegate void FUN_16D04(CriParticle p); //0x16D04 (ST9)
    private delegate void FUN_16D10(CriParticle p); //0x16D10 (ST9)
    private delegate void FUN_16D4C(CriParticle p); //0x16D4C (ST9)
    private delegate void FUN_16D5C(CriParticle p); //0x16D5C (ST9)
    private delegate void FUN_16D80(CriParticle p); //0x16D80 (ST9)
    private delegate void FUN_16D8C(CriParticle p); //0x16D8C (ST9)
    private delegate void FUN_16D9C(CriParticle p); //0x16D9C (ST9)
    private delegate void FUN_16DAC(CriParticle p); //0x16DAC (ST9)
    private delegate void FUN_16DD4(CriParticle p); //0x16DD4 (ST9)
    private delegate void FUN_16DF4(CriParticle p); //0x16DF4 (ST9)
    private delegate void FUN_16E44(CriParticle p); //0x16E44 (ST9)
    private delegate void FUN_16E84(CriParticle p); //0x16E84 (ST9)
    private delegate void FUN_16E90(CriParticle p); //0x16E90 (ST9)
    private delegate void FUN_16E9C(CriInteract i); //0x16E9C (ST9)
    private delegate void FUN_16EC8(CriInteract i); //0x16EC8 (ST9)
    private delegate void FUN_16F28(CriInteract i); //0x16F28 (ST9)
    private CapsuleCollider[] DAT_15F90; //0x15F90 (ST9)
    private short[] DAT_15FCC = new short[] { -0x1500, 0x1500 };
    private short[] DAT_15FD0 = new short[] { 0, 0x800 };
    private byte[] DAT_15FD4 = new byte[] { 5, 6, 6, 6, 3, 4, 4, 4, 2, 4, 4, 4 };
    private byte[] DAT_15FE0 = new byte[] { 57, 58, 50, 51, 54, 59, 148, 149 }; //0x15FE0 (ST9)
    private short[] DAT_16000 = new short[] { 4, -4, 0x20, -0x20, 0x20, -0x20, 0x10, -0x10, 8, -8, 2, -2, 1, -1 };
    private short[] DAT_1601C = new short[] { 4, -4, 0x10, -0x10, 0x10, -0x10, 8, -8, 4, -4, 1, -1, 1, -1, 4, -0x400 };
    private FUN_16044[] PTR_FUN_16044; //0x16044 (ST9)
    private FUN_16050[] PTR_FUN_16050; //0x16050 (ST9)
    private FUN_16060[] PTR_FUN_16060; //0x16060 (ST9)
    private FUN_16068[] PTR_FUN_16068; //0x16068 (ST9)
    private int[] DAT_16078 = new int[] { 4, 7 }; //0x16078 (ST9)
    private FUN_16080[] PTR_FUN_16080; //0x16080 (ST9)
    private FUN_16088[] PTR_FUN_16088; //0x16088 (ST9)
    private FUN_16098[] PTR_FUN_16098; //0x16098 (ST9)
    private FUN_160A0[] PTR_FUN_160A0; //0x160A0 (ST9)
    private FUN_160B4[] PTR_FUN_160B4; //0x160B4 (ST9)
    public short[] DAT_160CC = new short[] { -0x100 -0x510 -0x4b0 -0x3a0 -0x4b0 -0x3a0 }; //0x160CC (ST9)
    public Vector3Int[] DAT_160D8; //0x160D8 (ST9)
    private short[] DAT_160EC = new short[] { -0x3000, -0x19a0, -0x2900, -0x2c80, 0x980, -0x3980, 0x2780, -0x2c80, 0x2d80, 0xf00, 0x2500, 0x2c00, -0x1400, 0x3680, -0x2c00, 0x2800 };
    private Vector2Int[][] DAT_1610C; //0x1610C (ST9)
    private short[] DAT_1618C = new short[] { 0x200, 0x0, 0xe00, 0xc00, 0xa00, 0x800, 0x600, 0x400 }; //0x1618C (ST9)
    private uint[] DAT_161A8 = new uint[] { 0x801243d8, 0x80125088, 0x80127ef8 }; //0x161A8 (ST9)
    private byte[] DAT_161B4 = new byte[] { 48, 51, 49 }; //0x161B4 (ST9)
    private FUN_161B8[] PTR_FUN_161B8; //0x161B8 (ST9)
    private FUN_161D0[] PTR_FUN_161D0; //0x161D0 (ST9)
    private FUN_161D8[] PTR_FUN_161D8; //0x161D8 (ST9)
    private FUN_161E0[] PTR_FUN_161E0; //0x161E0 (ST9)
    private FUN_161E8[] PTR_FUN_161E8; //0x161E8 (ST9)
    private FUN_161F0[] PTR_FUN_161F0; //0x161F0 (ST9)
    private FUN_16204[] PTR_FUN_16204; //0x16204 (ST9)
    private FUN_16218[] PTR_FUN_16218; //0x16218 (ST9)
    private FUN_1622C[] PTR_FUN_1622C; //0x1622C (ST9)
    private FUN_16238[] PTR_FUN_16238; //0x16238 (ST9)
    private FUN_16244[] PTR_FUN_16244; //0x16244 (ST9)
    private FUN_16250[] PTR_FUN_16250; //0x16250 (ST9)
    private CapsuleCollider[] DAT_16260; //0x16260 (ST9)
    private ushort[] DAT_16338 = new ushort[] { 0, 1, 0, 1, 0, 1, 0, 1, 175, 50, 200, 50, 225, 75, 225, 75, 125, 25, 150, 25, 150, 25, 250, 50, 800, 200, 800, 200, 800, 200, 800, 200, 150, 25, 175, 25, 175, 25, 250, 50, 227, 50, 260, 50, 292, 75, 292, 75 };
    private ushort[] DAT_16398 = new ushort[] { 0, 1, 0, 1, 0, 1, 0, 1, 100, 25, 125, 25, 150, 50, 150, 50, 60, 20, 80, 20, 80, 20, 150, 50, 400, 100, 400, 100, 400, 200, 400, 200, 80, 20, 100, 20, 100, 20, 150, 50, 130, 25, 162, 25, 195, 50, 195, 50 };
    private short[] DAT_16410 = new short[] { 0, -206, -101, -101, -101, -100, -99, -97, -94, -91, -87, -84, -78, -73, -67, -60, -53, -53, -58, -64, -68, -71, -74, -76, -78, -77, -78, -76, -75, -72, -68, -65, -59, -54, -47, -24, 8, 26, 34, 30 };
    private short[] DAT_16460 = new short[] { 0, 200, 115, 113, 111, 108, 105, 104, 101, 98, 97, 94, 93, 90, 88, 86, 86, 88, 88, 89, 89, 87, 87, 85, 82, 80, 77, 72, 68, 64, 57, 52, 46, 38, 31, 8, -22, -39, -44, -35 };
    private FUN_164B0[] PTR_FUN_164B0; //0x164B0 (ST9)
    private FUN_164CC[] PTR_FUN_164CC; //0x164CC (ST9)
    private FUN_164F8[] PTR_FUN_164F8; //0x164F8 (ST9)
    private FUN_16524[] PTR_FUN_16524; //0x16524 (ST9)
    private FUN_1652C[] PTR_FUN_1652C; //0x1652C (ST9)
    private FUN_16534[] PTR_FUN_16534; //0x16534 (ST9)
    private FUN_1653C[] PTR_FUN_1653C; //0x1653C (ST9)
    private FUN_16544[] PTR_FUN_16544; //0x16544 (ST9)
    private FUN_16574[] PTR_FUN_16574; //0x16574 (ST9)
    private FUN_165CC[] PTR_FUN_165CC; //0x165CC (ST9)
    private FUN_165F8[] PTR_FUN_165F8; //0x165F8 (ST9)
    private FUN_168D4[] PTR_FUN_168D4; //0x168D4 (ST9)
    private FUN_165F0[] PTR_FUN_165F0; //0x165F0 (ST9)
    private FUN_16614[] PTR_FUN_16614; //0x16614 (ST9)
    private FUN_16654[] PTR_FUN_16654; //0x16654 (ST9)
    private FUN_1666C[] PTR_FUN_1666C; //0x1666C (ST9)
    private FUN_16674[] PTR_FUN_16674; //0x16674 (ST9)
    private FUN_16684[] PTR_FUN_16684; //0x16684 (ST9)
    private short[] DAT_1668C = new short[] { 0, -100, -91, -79, -64, -47, -29, -8, 11, 25, 36, 43, 49, 51, 51, 47, 42, 32, 21, 7, -18, -41, -49, -40 };
    private short[] DAT_166BC = new short[] { 0, 120, 117, 104, 85, 57, 23, -5, -15, -24, -31, -35, -36, -37, -33, -28, -21, -11, 6, 24, 35, 40, 36, 27 };
    private FUN_166EC[] PTR_FUN_166EC; //0x166EC (ST9)
    private FUN_166F4[] PTR_FUN_166F4; //0x166F4 (ST9)
    private FUN_166FC[] PTR_FUN_166FC; //0x166FC (ST9)
    private FUN_16704[] PTR_FUN_16704; //0x16704 (ST9)
    private short[] DAT_16714 = new short[] { 0, 34, 10, 4, 5, 5, 4, 5, 6, 5, 5, 3, 3, 2, 1, 0, 1, 0, 0, 1, 1, 0, 0, 0, -1, 0 };
    private FUN_16748[] PTR_FUN_16748; //0x16748 (ST9)
    private FUN_16754[] PTR_FUN_16754; //0x16754 (ST9)
    private short[] DAT_16760 = new short[] { 0, -71, -74, -76, -78, -77, -78, -76, -75, -72, -68, -52, -27, -5, 14, 31, 45, 58, 67, 75, 79, 81, 78, 71, 64, 59, 55, 51, 50, 49, 50, 0 };
    private short[] DAT_167A0 = new short[] { 0, 61, 64, 65, 66, 68, 68, 66, 64, 60, 56, 50, 47, 49, 52, 53, 56, 58, 60, 62, 65, 67, 69, 71, 71, 72, 71, 71, 70, 67, 66, 0 };
    private FUN_167E0[] PTR_FUN_167E0; //0x167E0 (ST9)
    private short[] DAT_167E8 = new short[] { 0, 11, 10, 9, 10, 13, 16, 21, 27, 36, 45, 53, 55, 59, 59, 61, 61, 60, 59, 56 };
    private short[] DAT_16810 = new short[] { 0, 28, 46, 60, 69, 73, 70, 64, 62, 62, 66, 70, 73, 74, 75, 74, 73, 70, 66, 61 };
    private FUN_16838[] PTR_FUN_16838; //0x16838 (ST9)
    private FUN_16840[] PTR_FUN_16840; //0x16840 (ST9)
    private FUN_16854[] PTR_FUN_16854; //0x16854 (ST9)
    private FUN_16860[] PTR_FUN_16860; //0x16860 (ST9)
    private FUN_1686C[] PTR_FUN_1686C; //0x1686C (ST9)
    private FUN_16874[] PTR_FUN_16874; //0x16874 (ST9)
    private FUN_16884[] PTR_FUN_16884; //0x16884 (ST9)
    private FUN_1688C[] PTR_FUN_1688C; //0x1688C (ST9)
    private FUN_16894[] PTR_FUN_16894; //0x16894 (ST9)
    private FUN_1689C[] PTR_FUN_1689C; //0x1689C (ST9)
    private FUN_168B4[] PTR_FUN_168B4; //0x168B4 (ST9)
    private FUN_168F8[] PTR_FUN_168F8; //0x168F8 (ST9)
    private FUN_16900[] PTR_FUN_16900; //0x16900 (ST9)
    private FUN_16908[] PTR_FUN_16908; //0x16908 (ST9)
    private FUN_16918[] PTR_FUN_16918; //0x16918 (ST9)
    private FUN_16928[] PTR_FUN_16928; //0x16928 (ST9)
    private FUN_16930[] PTR_FUN_16930; //0x16930 (ST9)
    private FUN_1694C[] PTR_FUN_1694C; //0x1694C (ST9)
    private FUN_16954[] PTR_FUN_16954; //0x16954 (ST9)
    private FUN_1696C[] PTR_FUN_1696C; //0x1696C (ST9)
    private FUN_16974[] PTR_FUN_16974; //0x16974 (ST9)
    private FUN_1697C[] PTR_FUN_1697C; //0x1697C (ST9)
    private FUN_16988[] PTR_FUN_16988; //0x16988 (ST9)
    private FUN_1699C[] PTR_FUN_1699C; //0x1699C (ST9)
    private FUN_169A4[] PTR_FUN_169A4; //0x169A4 (ST9)
    private FUN_169BC[] PTR_FUN_169BC; //0x169BC (ST9)
    private UNK_9B314[] PTR_DAT_16AF8; //0x16AF8 (ST9)
    private short[] DAT_16C84 = new short[] { -3500, 0, -1500, -1500 };
    private Vector3Int[] DAT_16C8C; //0x16C8C (ST9)
    private short[] DAT_16CAC = new short[] { -1500, 0, -1500, -1500, 120, 60 };
    private Vector3Int[] DAT_16CB8; //0x16CC8 (ST9)
    private uint[] DAT_16CD8 = new uint[] { 0x8011d1ec, 0x8011d204, 0x8011d21c, 0x8011d2ec, 0x8011d37c, 0x8011d49c };
    private FUN_16CF0[] PTR_FUN_16CF0; //0x16CF0 (ST9)
    private UNK_16CFC[] PTR_DAT_16CFC = new UNK_16CFC[1]; //0x16CFC (ST9)
    private FUN_16D04[] PTR_FUN_16D04; //0x16D04 (ST9)
    private FUN_16D10[] PTR_FUN_16D10; //0x16D10 (ST9)
    private short[] DAT_16D20 = new short[] { -2320, -1230, -3900, -2610, -1230, -3900, -2900, -1230, -3900, -3190, -1230, -3900, -3480, -1230, -3900, -4390, -1075, 2600, -2290, -2580, -2870, -3160 };
    private FUN_16D4C[] PTR_FUN_16D4C; //0x16D4C (ST9)
    private FUN_16D5C[] PTR_FUN_16D5C; //0x16D5C (ST9)
    private uint DAT_16D68 = 0x8010f728; //0x16D68 (ST9)
    private int[] DAT_16D6C = new int[] { 1, 0, 1 };
    private FUN_16D80[] PTR_FUN_16D80; //0x16D80 (ST9)
    private FUN_16D8C[] PTR_FUN_16D8C; //0x16D8C (ST9)
    private uint[] PTR_FUN_16D9C = new uint[4] {0x80120020, 0x80120060, 0x80120068, 0x80120070}; //0x16D9C (ST9)
    private FUN_16DAC[] PTR_FUN_16DAC; //0x16DAC (ST9)
    private uint[] DAT_16DB8 = new uint[] { 0x8012cc24, 0x8012cc2c, 0x8012cc34, 0x8012cc4c, 0x8012cc54, 0x8012cc5c, 0x8012cc64 };
    private FUN_16DD4[] PTR_FUN_16DD4; //0x16DD4 (ST9)
    private uint[] DAT_16DE0 = new uint[] { 0x8011a394, 0x8011a3d4, 0x8011a414, 0x8011a47c, 0x8011a54c };
    private FUN_16DF4[] PTR_FUN_16DF4; //0x16DF4 (ST9)
    private uint[] DAT_16E00 = new uint[] //0x16E00 (ST9)
    {
        0x801402e8, 0x80140488, 0x80140500, 0x80140540,
        0x80140568, 0x80140570, 0x80140578, 0x80140580,
        0x80140588, 0x80140590, 0x80140598, 0x801405a8,
        0x801405b0
    };
    private byte[] DAT_16E34 = new byte[] { 1, 3, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }; //0x16E34 (ST9)
    private FUN_16E44[] PTR_FUN_16E44; //0x16E44 (ST9)
    private uint[] DAT_16E50 = new uint[] { 0x801454b8, 0x801454d0, 0x801454e8 }; //0x16E50 (ST9)
    private FUN_16E84[] PTR_FUN_16E84; //0x16E84 (ST9)
    private FUN_16E90[] PTR_FUN_16E90; //0x16E90 (ST9)
    private FUN_16E9C[] PTR_FUN_16E9C; //0x16E9C (ST9)
    private sbyte[] DAT_16EB8 = new sbyte[] { 1, 2, 5, 6, 3, 7 }; //0x16EB8 (ST9)
    private sbyte[] DAT_16EC0 = new sbyte[] { 1, 2, 8, 4, 3, 7 }; //0x16EC0 (ST9)
    private FUN_16EC8[] PTR_FUN_16EC8; //0x16EC8 (ST9)
    private sbyte[] DAT_16EDC = new sbyte[] { -12, 0, -12, 0, -12, 0, 12, 0, 12, 0, 12, 0, 12, 0, 12, 0, -12, 0, -12, 0 };
    private sbyte[] DAT_16EF0 = new sbyte[] { 12, 0, 12, 0, 12, 0, -12, 0, -12, 0, -12, 0, -12, 0, -12, 0, 12, 0, 12, 0 };
    private FUN_16F28[] PTR_FUN_16F28; //0x16F28 (ST9)
    private ushort DAT_171C8; //0x171C8 (ST9)
    private sbyte[] DAT_171CC = new sbyte[20]; //0x171CC (ST9)
    private sbyte[] DAT_171EC = new sbyte[6]; //0x171EC (ST9)
    private byte[] DAT_1721C = new byte[20]; //0x1721C (ST9)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_16044 = new FUN_16044[3]
            {
                FUN_460,
                FUN_4F8,
                FUN_528
            };
            PTR_FUN_16050 = new FUN_16050[4]
            {
                FUN_A28,
                FUN_AE4,
                FUN_BA8,
                FUN_C18
            };
            PTR_FUN_16060 = new FUN_16060[2]
            {
                FUN_DDC,
                FUN_E7C
            };
            PTR_FUN_16068 = new FUN_16068[4]
            {
                FUN_1040,
                FUN_108C,
                FUN_1284,
                FUN_138C
            };
            PTR_FUN_16080 = new FUN_16080[2]
            {
                FUN_14B4,
                FUN_1578
            };
            PTR_FUN_16088 = new FUN_16088[4]
            {
                FUN_DA0,
                FUN_1478,
                FUN_1714,
                FUN_F5C
            };
            PTR_FUN_16098 = new FUN_16098[2]
            {
                FUN_36E8, 
                FUN_3A80
            };
            PTR_FUN_160A0 = new FUN_160A0[5]
            {
                FUN_60C,
                FUN_1750, 
                FUN_72C, 
                FUN_734, 
                FUN_17D4
            };
            PTR_FUN_160B4 = new FUN_160B4[6]
            {
                FUN_30F0, 
                FUN_1814, 
                FUN_1814, 
                FUN_1B64, 
                FUN_1BE4, 
                FUN_1C5C
            };
            PTR_FUN_161B8 = new FUN_161B8[6]
            {
                FUN_2244,
                FUN_2288,
                FUN_2288,
                FUN_2288,
                FUN_2340,
                FUN_23A4
            };
            PTR_FUN_161D0 = new FUN_161D0[2]
            {
                FUN_2450, 
                FUN_249C
            };
            PTR_FUN_161D8 = new FUN_161D8[2]
            {
                FUN_2500, 
                FUN_254C
            };
            PTR_FUN_161E0 = new FUN_161E0[2]
            {
                FUN_27D8, 
                FUN_2814
            };
            PTR_FUN_161E8 = new FUN_161E8[2]
            {
                FUN_2B68,
                FUN_2C70
            };
            PTR_FUN_161F0 = new FUN_161F0[5]
            {
                FUN_2748,
                FUN_1F3C,
                FUN_1F3C,
                FUN_1F3C,
                FUN_2A6C
            };
            PTR_FUN_16204 = new FUN_16204[5]
            {
                FUN_2870, 
                FUN_2D90, 
                FUN_2E40, 
                FUN_F5C, 
                FUN_2D54
            };
            PTR_FUN_16218 = new FUN_16218[5]
            {
                FUN_60C, 
                FUN_3084, 
                FUN_72C, 
                FUN_734, 
                FUN_25A4
            };
            PTR_FUN_1622C = new FUN_1622C[3]
            {
                FUN_35C4,
                FUN_3600,
                FUN_3658
            };
            PTR_FUN_16238 = new FUN_16238[3]
            {
                FUN_3574,
                FUN_368C,
                FUN_36C8
            };
            PTR_FUN_16244 = new FUN_16244[3]
            {
                FUN_375C,
                FUN_37AC,
                FUN_3824
            };
            PTR_FUN_16250 = new FUN_16250[4]
            {
                FUN_38C0,
                FUN_398C,
                FUN_3A08,
                FUN_3A60
            };
            PTR_FUN_164B0 = new FUN_164B0[7]
            {
                FUN_3DBC, 
                FUN_3FF4, 
                FUN_69D8, 
                FUN_7188, 
                FUN_7724, 
                FUN_7CE0, 
                FUN_8620
            };
            PTR_FUN_164CC = new FUN_164CC[11]
            {
                FUN_4068, 
                FUN_48CC, 
                FUN_4170, 
                FUN_4B10, 
                FUN_4060, 
                FUN_4060, 
                FUN_4F00, 
                FUN_53A4, 
                FUN_4060, 
                FUN_4060, 
                FUN_4060
            };
            PTR_FUN_164F8 = new FUN_164F8[11]
            {
                FUN_4134,
                FUN_4AD4,
                FUN_4890,
                FUN_4D0C,
                FUN_4EC4,
                FUN_5EF4,
                FUN_5368,
                FUN_5A50,
                FUN_5D0C,
                FUN_6404,
                FUN_690C
            };
            PTR_FUN_16524 = new FUN_16524[2]
            {
                FUN_4090,
                FUN_7788
            };
            PTR_FUN_1652C = new FUN_1652C[2]
            {
                FUN_47AC,
                FUN_4838
            };
            PTR_FUN_16534 = new FUN_16534[2]
            {
                FUN_4A20,
                FUN_4A68
            };
            PTR_FUN_1653C = new FUN_1653C[2]
            {
                FUN_47AC,
                FUN_4CB4
            };
            PTR_FUN_16544 = new FUN_16544[2]
            {
                FUN_4D48,
                FUN_4D90
            };
            PTR_FUN_16574 = new FUN_16574[2]
            {
                FUN_5128,
                FUN_520C
            };
            PTR_FUN_165CC = new FUN_165CC[2]
            {
                FUN_5128,
                FUN_56D0
            };
            PTR_FUN_165F0 = new FUN_165F0[2]
            {
                FUN_5A8C,
                FUN_5B58
            };
            PTR_FUN_165F8 = new FUN_165F8[2]
            {
                FUN_5D48,
                FUN_5E70
            };
            PTR_FUN_16614 = new FUN_16614[2]
            {
                FUN_5A8C,
                FUN_5F30
            };
            PTR_FUN_16654 = new FUN_16654[6]
            {
                FUN_6440,
                FUN_6510,
                FUN_6594,
                FUN_664C,
                FUN_6824,
                FUN_6894
            };
            PTR_FUN_1666C = new FUN_1666C[2]
            {
                FUN_4D48,
                FUN_6948
            };
            PTR_FUN_16674 = new FUN_16674[4]
            {
                FUN_6C68, 
                FUN_6F48, 
                FUN_7088, 
                FUN_714C
            };
            PTR_FUN_16684 = new FUN_16684[2]
            {
                FUN_6A14,
                FUN_6B44
            };
            PTR_FUN_166EC = new FUN_166EC[2]
            {
                FUN_6CA4, 
                FUN_6DEC
            };
            PTR_FUN_166F4 = new FUN_166F4[2]
            {
                FUN_6F84,
                FUN_7044
            };
            PTR_FUN_166FC = new FUN_166FC[2]
            {
                FUN_70C4,
                FUN_710C
            };
            PTR_FUN_16704 = new FUN_16704[4]
            {
                FUN_7310, 
                FUN_7488, 
                FUN_75B8, 
                FUN_76E8
            };
            PTR_FUN_16748 = new FUN_16748[3]
            {
                FUN_71C4,
                FUN_7228,
                FUN_4060
            };
            PTR_FUN_16754 = new FUN_16754[3]
            {
                FUN_734C,
                FUN_73BC,
                FUN_4060
            };
            PTR_FUN_167E0 = new FUN_167E0[2]
            {
                FUN_74C4,
                FUN_7544
            };
            PTR_FUN_16838 = new FUN_16838[2]
            {
                FUN_75F4,
                FUN_7674
            };
            PTR_FUN_16840 = new FUN_16840[5]
            {
                FUN_7788, 
                FUN_798C, 
                FUN_7A20, 
                FUN_7C60, 
                FUN_7C9C
            };
            PTR_FUN_16854 = new FUN_16854[3]
            {
                FUN_77A8,
                FUN_7934,
                FUN_4060
            };
            PTR_FUN_16860 = new FUN_16860[3]
            {
                FUN_77A8,
                FUN_79C8,
                FUN_4060
            };
            PTR_FUN_1686C = new FUN_1686C[2]
            {
                FUN_7A5C,
                FUN_7B3C
            };
            PTR_FUN_16874 = new FUN_16874[4]
            {
                FUN_7EDC, 
                FUN_7F9C, 
                FUN_80CC, 
                FUN_818C
            };
            PTR_FUN_16884 = new FUN_16884[2]
            {
                FUN_7D1C,
                FUN_7E64
            };
            PTR_FUN_1688C = new FUN_1688C[2]
            {
                FUN_7F18,
                FUN_7F7C
            };
            PTR_FUN_16894 = new FUN_16894[2]
            {
                FUN_8020,
                FUN_806C
            };
            PTR_FUN_1689C = new FUN_1689C[2]
            {
                FUN_8108,
                FUN_8150
            };
            PTR_FUN_168B4 = new FUN_168B4[7]
            {
                FUN_81C8,
                FUN_8358,
                FUN_83C4,
                FUN_8418,
                FUN_84B4,
                FUN_854C,
                FUN_85C0
            };
            PTR_FUN_168D4 = new FUN_168D4[9]
            {
                FUN_877C, 
                FUN_88DC, 
                FUN_8A5C, 
                FUN_8C0C, 
                FUN_8CC8, 
                FUN_8DBC, 
                FUN_8EDC, 
                FUN_91B8, 
                FUN_91B8
            };
            PTR_FUN_168F8 = new FUN_168F8[2]
            {
                FUN_8698,
                FUN_8710
            };
            PTR_FUN_16900 = new FUN_16900[2]
            {
                FUN_87B8,
                FUN_8838
            };
            PTR_FUN_16908 = new FUN_16908[4]
            {
                FUN_8918,
                FUN_8974,
                FUN_89B4,
                FUN_8A04
            };
            PTR_FUN_16918 = new FUN_16918[4]
            {
                FUN_8A98,
                FUN_8B14,
                FUN_8B64,
                FUN_8BB4
            };
            PTR_FUN_16928 = new FUN_16928[2]
            {
                FUN_8C48,
                FUN_8838
            };
            PTR_FUN_16930 = new FUN_16930[2]
            {
                FUN_8D04,
                FUN_8D60
            };
            PTR_FUN_1694C = new FUN_1694C[2]
            {
                FUN_8DF8,
                FUN_8EAC
            };
            PTR_FUN_16954 = new FUN_16954[4]
            {
                FUN_8F18,
                FUN_8F9C,
                FUN_8FE4,
                FUN_904C
            };
            PTR_FUN_1696C = new FUN_1696C[2]
            {
                FUN_92CC, 
                FUN_9408
            };
            PTR_FUN_16974 = new FUN_16974[2]
            {
                FUN_9230,
                FUN_9290
            };
            PTR_FUN_1697C = new FUN_1697C[3]
            {
                FUN_9308,
                FUN_935C,
                FUN_4060
            };
            PTR_FUN_16988 = new FUN_16988[5]
            {
                FUN_4060, 
                FUN_9D60, 
                FUN_94D0, 
                FUN_A9E4, 
                FUN_4060
            };
            PTR_FUN_1699C = new FUN_1699C[2]
            {
                FUN_9538, 
                FUN_994C
            };
            PTR_FUN_169A4 = new FUN_169A4[6]
            {
                FUN_9DA0,
                FUN_A230, 
                FUN_A744, 
                FUN_A798, 
                FUN_A7D0, 
                FUN_A808
            };
            PTR_FUN_169BC = new FUN_169BC[2]
            {
                FUN_AA50,
                FUN_AEC8
            };
            PTR_FUN_16CF0 = new FUN_16CF0[3]
            {
                FUN_C8A0,
                FUN_C9C0,
                FUN_60068
            };
            PTR_FUN_16D04 = new FUN_16D04[3]
            {
                FUN_CAEC,
                FUN_CB80,
                FUN_60068
            };
            PTR_FUN_16D10 = new FUN_16D10[4]
            {
                FUN_CCC0,
                FUN_D098,
                FUN_D2A8,
                FUN_60068
            };
            PTR_FUN_16D4C = new FUN_16D4C[4]
            {
                FUN_D4B4,
                FUN_D78C,
                FUN_D92C,
                FUN_60068
            };
            PTR_FUN_16D5C = new FUN_16D5C[3]
            {
                FUN_DD50,
                FUN_DDDC,
                FUN_60068
            };
            PTR_FUN_16D80 = new FUN_16D80[3]
            {
                FUN_DE58,
                FUN_DEE0,
                FUN_60068
            };
            PTR_FUN_16D8C = new FUN_16D8C[4]
            {
                FUN_E00C,
                FUN_E0A0,
                FUN_E14C,
                FUN_60068
            };
            PTR_FUN_16DAC = new FUN_16DAC[3]
            {
                FUN_E214,
                FUN_E290,
                FUN_60068
            };
            PTR_FUN_16DD4 = new FUN_16DD4[3]
            {
                FUN_E374,
                FUN_E3EC,
                FUN_60068
            };
            PTR_FUN_16DF4 = new FUN_16DF4[3]
            {
                FUN_E534,
                FUN_E5EC,
                FUN_60068
            };
            PTR_FUN_16E44 = new FUN_16E44[3]
            {
                FUN_E6C4,
                FUN_E794,
                FUN_60068
            };
            PTR_FUN_16E84 = new FUN_16E84[3]
            {
                FUN_E878,
                FUN_E91C,
                FUN_60068
            };
            PTR_FUN_16E90 = new FUN_16E90[3]
            {
                FUN_E9E4,
                FUN_EA64,
                FUN_60068
            };
            PTR_FUN_16E9C = new FUN_16E9C[5]
            {
                FUN_EB14,
                FUN_EDB0,
                FUN_EF40,
                FUN_ECF8,
                FUN_5FF98
            };
            PTR_FUN_16EC8 = new FUN_16EC8[5]
            {
                FUN_F1B0,
                FUN_F3F0,
                FUN_F8BC,
                FUN_F900, 
                FUN_5FF98
            };
            PTR_FUN_16F28 = new FUN_16F28[]
            {

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
        GameManager.instance.DAT_AC = DAT_15E30;
        GameManager.instance.DAT_B0 = DAT_159A0;
        GameManager.instance.DAT_46 = 9;

        for (int i = 0; i < DAT_15D40.TRIGGERS.Length; i++)
        {
            puVar4 = LevelManager.instance.DAT_9EEC[i];
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

    //FUN_20C (ST9)
    private void FUN_20C(CriPlayer param1)
    {
        CriCamera cVar1;
        short sVar2;

        cVar1 = SceneManager.instance.cCamera;
        sVar2 = (short)(param1.UDAT_1D2 >> 8 & 0x7f);
        cVar1.DAT_38 += (short)(DAT_1601C[param1.UDAT_1D2 & 0xff] * sVar2);
        cVar1.DAT_3A += (short)(DAT_16000[param1.UDAT_1D2] * sVar2);
        sVar2 = (short)(param1.UDAT_1D2 + 1);
        param1.UDAT_1D2 = (ushort)sVar2;

        if (13 < (sVar2 & 0xff))
            param1.UDAT_1D2 = 0;
    }

    //FUN_2AC (ST9)
    private void FUN_2AC(CriPlayer param1)
    {
        byte bVar1;

        bVar1 = param1.frame.DAT_02;

        if (bVar1 != 0)
        {
            GameManager.FUN_64650();
            param1.UDAT_1D2 = 0x8100;
            GameManager.instance.FUN_5C94C(param1, DAT_15FE0[bVar1 >> 1]);
        }
    }

    //FUN_318 (ST9)
    private void FUN_318(CriPlayer param1)
    {
        short sVar1;
        CriBone oVar2;
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
        else if (uVar3 < 0xe00)
            param1.DAT_19E = 0xe00;

        uVar3 = param1.DAT_19C;

        if (uVar3 < 0x801)
        {
            if (0x100 < uVar3)
                param1.DAT_19C = 0x100;
        }
        else if (uVar3 < 0xf00)
            param1.DAT_19C = 0xf00;

        oVar2 = Utilities.FUN_601C8(param1.skeleton, 2) as CriBone;
        oVar2.vr.x = param1.DAT_19C & 0xfff;
        oVar2.vr.y = param1.DAT_19E & 0xfff;
    }

    //FUN_460 (ST9)
    private void FUN_460(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriBone oVar3;

        oVar3 = Utilities.FUN_601C8(param1.skeleton, 2) as CriBone;
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_154.screen);
        param1.SDAT_1FA = sVar1;
        sVar2 = (short)Utilities.FUN_61654(oVar3.screen, param1.DAT_154.screen, sVar1);
        param1.SDAT_1F8 = sVar2;
        param1.SDAT_1FA = (short)(param1.SDAT_1FA - param1.vr.y & 0xfff);
        FUN_318(param1);
    }

    //FUN_4F8 (ST9)
    private void FUN_4F8(CriPlayer param1)
    {
        if (param1.DAT_19C != 0)
            param1.DAT_19C = 0;

        if (param1.DAT_19E != 0)
            param1.DAT_19E = 0;
    }

    //FUN_528 (ST9)
    private void FUN_528(CriPlayer param1)
    {
        CriBone oVar1;

        oVar1 = Utilities.FUN_601C8(param1.skeleton, 2) as CriBone;
        param1.SDAT_1F8 = (short)oVar1.vr.x;
        param1.SDAT_1FA = (short)oVar1.vr.y;
        FUN_318(param1);
    }

    //FUN_57C (ST9)
    private void FUN_57C(CriPlayer param1)
    {
        PTR_FUN_16044[param1.DAT_164](param1);
    }

    //FUN_5B8 (ST9)
    private void FUN_5B8(CriPlayer param1)
    {
        if (param1.DAT_2F != 4 || (!InventoryManager.FUN_4A87C(3, 0x3f) && !InventoryManager.FUN_4A87C(3, 0x3e)))
            InventoryManager.FUN_4A7E8(3, 0x22, true);
    }

    //FUN_60C (ST9)
    private void FUN_60C(CriPlayer param1)
    {
        CriSkinned oVar1;

        param1.health = 1000;
        param1.maxHealth = 1000;
        param1.DAT_175 = 2;
        param1.PTR_120 = DAT_15F90;
        param1.DAT_120 = 0;
        param1.DAT_167 = 5;
        param1.DAT_166 = 10;
        param1.DAT_164 = 0;
        param1.DAT_3C++;

        if (param1.DAT_2F == 2)
        {
            param1.PTR_130 = DAT_15F90;
            param1.DAT_130 = 3;
            param1.FUN_77784(1, DAT_15F90[3].radius);
            param1.DAT_12E = 3;
            param1.DAT_164 = 1;
        }
        else
        {
            param1.PTR_130 = null;
            param1.DAT_130 = 0;
            param1.DAT_164 = 0;
            param1.DAT_12E = 1;
        }

        if (param1.DAT_2F != 4)
            param1.FUN_66404(0, 0x4000, 0x7fff);

        param1.FUN_609C8(0, 1, 0);
        oVar1 = SceneManager.instance.skinnedObjects[10];
        param1.IDAT_1C4 = 0;
        param1.DAT_11C = 0;
        param1.DAT_154 = oVar1;
        oVar1.DAT_14C = new Vector3Int(0x18, 0x27bd, 0x8010); //0x1CC0
        param1.PTR_124 = DAT_15F90;
        param1.DAT_124 = 0;
        param1.DAT_12F = 3;
    }

    //FUN_72C (ST9)
    private void FUN_72C(CriPlayer param1)
    {
        return;
    }

    //FUN_734 (ST9)
    private void FUN_734(CriPlayer param1)
    {
        return;
    }

    //FUN_73C (ST9)
    private void FUN_73C(CriPlayer param1)
    {
        byte bVar1;
        bool bVar2;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)param1.DAT_154;

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

        if (bVar1 == 2)
        {
            //...
            goto LAB_944;
        }

        if (bVar1 < 3)
        {
            if (bVar1 == 1)
            {
                //...
            }

            goto LAB_944;
        }

        if (bVar1 != 3) goto LAB_944;

        oVar5.DAT_1C0 &= 0xffffffbf;

        if (param1.DAT_2F == 4)
        {
            if (GameManager.instance.DAT_922C == 2)
            {
                param1.DAT_3A = 1;
                param1.DAT_11E++;
            }
            else
                param1.DAT_3A = 0;
        }
        else
        {
            if (param1.DAT_3D != 1 || param1.frame.DAT_01 < 10 || param1.DAT_3E == 2)
                param1.DAT_3A = 0;
            else
            {
                param1.DAT_3A = 1;
                param1.DAT_1EE++;
            }
        }

        //...
        param1.DAT_3D = 2;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;

        LAB_944:;
        //...
    }

    //FUN_974 (ST9)
    private void FUN_974(CriPlayer param1)
    {
        bool bVar1;
        int iVar1;
        uint uVar2;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            if ((param1.DAT_1C0 & 2) == 0)
            {
                iVar1 = (int)GameManager.FUN_64650();

                if ((iVar1 >> 4 & 1) == 0)
                    return;

                param1.FUN_609C8(3, 1, param1.DAT_1F1);
                uVar2 = param1.DAT_1C0 | 2;
            }
            else
            {
                param1.FUN_609C8(0, 1, param1.DAT_1F1);
                uVar2 = param1.DAT_1C0 & 0xfffffffd;
            }

            param1.DAT_1C0 = uVar2;
        }
    }

    //FUN_A28 (ST9)
    private void FUN_A28(CriPlayer param1)
    {
        int iVar1;
        CriCamera cVar1;

        cVar1 = SceneManager.instance.cCamera;

        if (param1.DAT_2F == 4)
            param1.DAT_1F1 = 10;
        else
        {
            param1.DAT_1F1 = 0;
            cVar1.DAT_83 = 2;
        }

        param1.DAT_3E++;
        iVar1 = (int)GameManager.FUN_64650();

        if ((iVar1 >> 4 & 1) == 0)
            param1.FUN_609C8(0, 1, param1.DAT_1F1);
        else
        {
            param1.FUN_609C8(3, 1, param1.DAT_1F1);
            param1.DAT_1C0 |= 2;
        }

        param1.DAT_40.z = 0x78;
    }

    //FUN_AE4 (ST9)
    private void FUN_AE4(CriPlayer param1)
    {
        uint uVar1;

        FUN_974(param1);

        if (param1.DAT_2F == 4)
        {
            if (param1.screen.z < -0x1521)
                param1.DAT_3E++;
        }
        else if (-0x1c00 < param1.screen.z)
        {
            param1.DAT_3E += 2;
            SceneManager.instance.cCamera.DAT_83 = 3;
            uVar1 = GameManager.FUN_64650();

            if ((0x84 >> (int)(uVar1 & 7) & 1) != 0)
                param1.DAT_1C0 |= 4;

            param1.DAT_112 = 30;
        }
    }

    //FUN_BA8 (ST9)
    private void FUN_BA8(CriPlayer param1)
    {
        CriSkinned oVar2;

        oVar2 = param1.DAT_154;
        FUN_974(param1);

        if (param1.screen.z - oVar2.screen.z < 0x1500)
        {
            param1.DAT_3E++;
            param1.DAT_112 = 30;
            param1.screen.z += 0x1500;
        }
    }

    //FUN_C18 (ST9)
    private void FUN_C18(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        int iVar4;
        CriSkinned oVar6;

        oVar6 = param1.DAT_154;
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar6.screen);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 5, sVar1);
        param1.vr.y += sVar2;
        bVar3 = param1.FUN_60AB4();

        if (bVar3 && (param1.DAT_1C0 & 2) != 0)
        {
            param1.FUN_609C8(0, 1, param1.DAT_1F1);
            param1.DAT_1C0 &= 0xfffffffd;
        }

        iVar4 = oVar6.screen.z - param1.screen.z;

        if (iVar4 < 0)
            iVar4 = param1.screen.z - oVar6.screen.z;

        if (iVar4 < 0x1500)
        {
            param1.DAT_1C0 |= 8;
            param1.screen.z = oVar6.screen.z + DAT_15FCC[param1.DAT_2F - 3];

            if ((param1.DAT_1C0 & 4) != 0)
            {
                param1.DAT_1C0 &= 0xfffffffb;
                param1.DAT_112 = 0;
            }
        }

        if (param1.DAT_112 == 0)
        {
            if (bVar3)
            {
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_40.z = 0;
                param1.DAT_1C0 &= 0xfffffffd;
            }
        }
        else
            param1.DAT_112--;
    }

    //FUN_DA0 (ST9)
    private void FUN_DA0(CriPlayer param1)
    {
        PTR_FUN_16050[param1.DAT_3E](param1);
    }

    //FUN_DDC (ST9)
    private void FUN_DDC(CriPlayer param1)
    {
        CriSkinned oVar2;

        oVar2 = param1.DAT_154;

        if (param1.DAT_2F == 4)
            param1.screen.y = -0xd7c;

        param1.DAT_164 = 1;
        param1.DAT_3E++;
        param1.FUN_609C8(8, 0, 0);
        param1.FUN_656EC();
        oVar2.DAT_3C = 6;
        oVar2.DAT_3D = 0;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        oVar2.DAT_98 = param1.DAT_98;
        oVar2.DAT_152 = 1;
        oVar2.vr.y = param1.vr.y;
        param1.DAT_152 = 1;
        param1.PTR_120 = null;
        param1.DAT_120 = 0;
        GameManager.instance.FUN_5DC54();
    }

    //FUN_E7C (ST9)
    private void FUN_E7C(CriPlayer param1)
    {
        byte bVar1;
        int iVar2;

        param1.FUN_60AB4();
        param1.FUN_65714();
        bVar1 = param1.frame.DAT_03;

        if (bVar1 == 0)
            return;

        if (bVar1 == 2)
        {
            GameManager.instance.FUN_5C94C(param1, 50);
            iVar2 = 56;
        }
        else
        {
            if (2 < bVar1)
            {
                if (bVar1 == 3)
                    iVar2 = 57;
                else
                {
                    if (bVar1 != 4)
                        return;

                    iVar2 = 58;
                }

                GameManager.instance.FUN_5C94C(param1, iVar2);
                return;
            }

            if (bVar1 != 1)
                return;

            GameManager.instance.FUN_5C94C(param1, 49);
            iVar2 = 55;
        }

        GameManager.instance.FUN_5C94C(param1, iVar2);
        //FUN_1D988
    }

    //FUN_F5C (ST9)
    private void FUN_F5C(CriPlayer param1)
    {
        PTR_FUN_16060[param1.DAT_3E](param1);
    }

    //FUN_F98 (ST9)
    private void FUN_F98(CriPlayer param1)
    {
        CriCamera cVar1;

        cVar1 = SceneManager.instance.cCamera;
        InventoryManager.FUN_4A7E8(3, 0x20, true);
        param1.DAT_3D = 3;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_40.z = 0;
        param1.DAT_154.DAT_154 = param1;
        param1.DAT_164 = 1;
        cVar1.DAT_70 = 1;
        cVar1.PTR_FUN_8C = cVar1.FUN_1E08;

        if (param1.DAT_2F == 3)
            SceneManager.instance.staticObjects[8].flags &= 0xfffffffd;

        //FUN_1D988
    }

    //FUN_1040 (ST9)
    private void FUN_1040(CriPlayer param1)
    {
        param1.DAT_3E++;
        param1.FUN_609C8(6, 0, 0);
        GameManager.instance.FUN_5C94C(param1, 48);
    }

    //FUN_108C (ST9)
    private void FUN_108C(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        bool bVar5;
        CriSkinned oVar5;

        oVar5 = param1.DAT_154;
        param1.screen.z = oVar5.screen.z + DAT_15FCC[param1.DAT_2F - 3];

        if (param1.frame.DAT_01 < 25)
        {
            sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar5.screen);
            sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 10, sVar1);
            param1.vr.y += sVar2;
        }

        if (param1.frame.DAT_01 < 30)
        {
            if (param1.DAT_2F == 4)
                param1.screen.y -= 0x20;
        }
        else
        {
            param1.PTR_120 = DAT_15F90;
            param1.DAT_120 = 4;
            bVar3 = SceneManager.instance.FUN_802B8(param1, false, 1);

            if (bVar3)
            {
                FUN_F98(param1);
                return;
            }

            param1.PTR_120 = null;
            param1.DAT_120 = 0;
        }

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(5, 0, 0);
            param1.DAT_40.z = -40;
            param1.PTR_120 = null;
            param1.DAT_120 = 0;
            param1.DAT_1DF++;
        }

        if (param1.DAT_2F == 4 && param1.frame.DAT_01 == 20 && oVar5.DAT_3C == 1 && oVar5.DAT_3D == 5)
        {
            bVar5 = InventoryManager.FUN_4A87C(3, 0);

            if (!bVar5)
            {
                bVar5 = InventoryManager.FUN_4A87C(3, 1);

                if (!bVar5) goto LAB_1248;

                uVar4 = 0x3e;
            }
            else
                uVar4 = 0x3f;

            InventoryManager.FUN_4A7E8(3, uVar4, true);
        }

        LAB_1248:
        if (param1.frame.DAT_01 == 33)
            GameManager.instance.FUN_5C94C(param1, 48);
    }

    //FUN_1284 (ST9)
    private void FUN_1284(CriPlayer param1)
    {
        short sVar1;
        bool bVar2;
        uint uVar3;

        sVar1 = (short)Utilities.FUN_64838(param1.vr.y, 10, DAT_15FD0[param1.DAT_2F - 3]);
        param1.vr.y += sVar1;

        if (param1.DAT_2F == 4 && param1.frame.DAT_01 < 30)
            param1.screen.y += 0x20;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            if (param1.DAT_2F == 3)
            {
                uVar3 = GameManager.FUN_64650();

                if ((0x43 >> (int)(uVar3 & 7) & 1) != 0)
                {
                    param1.DAT_3E = 0;
                    param1.DAT_40.z = 0;
                }
                else
                {
                    param1.DAT_3F = 0;
                    param1.DAT_3E++;
                    param1.FUN_609C8(0, 0, 0);
                    param1.DAT_40.z = 0x78;
                }
            }
        }
    }

    //FUN_138C (ST9)
    private void FUN_138C(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        int iVar3;
        bool bVar3;
        CriSkinned oVar4;

        oVar4 = param1.DAT_154;

        if (param1.DAT_2F == 3 && param1.DAT_40.z == 0)
        {
            sVar1 = (short)Utilities.FUN_615EC(param1.screen, oVar4.screen);
            sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 10, sVar1);
            param1.vr.y += sVar2;
        }

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            param1.DAT_3E = 0;
            param1.DAT_40.z = 0;
        }

        iVar3 = param1.screen.z - oVar4.screen.z;

        if (iVar3 < 0)
            iVar3 = oVar4.screen.z - param1.screen.z;

        if (iVar3 < 0x1500)
            param1.screen.z = oVar4.screen.z + DAT_15FCC[param1.DAT_2F - 3];
    }

    //FUN_1478 (ST9)
    private void FUN_1478(CriPlayer param1)
    {
        PTR_FUN_16068[param1.DAT_3E](param1);
    }

    //FUN_14B4 (ST9)
    private void FUN_14B4(CriPlayer param1)
    {
        short sVar1;

        param1.DAT_3E++;
        param1.DAT_40.z = 0;
        param1.FUN_609C8(DAT_16078[param1.DAT_3A], 0, 0);
        sVar1 = -60;

        if (param1.DAT_3A == 0)
        {
            if (param1.DAT_2F != 4) goto LAB_1528;

            sVar1 = 60;
        }

        param1.DAT_40.z = sVar1;
        LAB_1528:
        param1.vr.y = DAT_15FD0[param1.DAT_2F - 3];
        GameManager.instance.FUN_5C94C(param1, DAT_15FE0[param1.DAT_3A]);
        param1.DAT_164 = 2;
    }

    //FUN_1578 (ST9)
    private void FUN_1578(CriPlayer param1)
    {
        bool bVar2;
        CriCamera cVar2;
        uint uVar3;
        CriSkinned oVar4;

        cVar2 = SceneManager.instance.cCamera;
        oVar4 = param1.DAT_154;

        if (param1.DAT_2F == 3)
        {
            if (0x1600 < oVar4.screen.z - param1.screen.z)
                param1.DAT_1C0 &= 0xfffffff7;

            if (param1.screen.z < -0x1c00)
            {
                cVar2.DAT_83 = 2;

                if (cVar2.DAT_68 == 8 && cVar2.DAT_6A == 8)
                {
                    cVar2.DAT_48 = new Vector3Int(0x247, -0xac6, 0x1b80);
                    cVar2.DAT_40 = new Vector3Int(-0x2f7, -0xf66, oVar4.screen.z);
                }

                cVar2.DAT_26 = 20;
                cVar2.DAT_36 = 20;
            }
        }

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3D = 0;

            if (param1.DAT_2F == 3 && param1.DAT_3A == 0)
            {
                uVar3 = GameManager.FUN_64650();

                if ((0x36 >> (int)(uVar3 & 7) & 1) != 0 && (param1.DAT_1C0 & 8) != 0)
                    param1.DAT_3D = 1;
            }

            param1.DAT_3E = 0;
            param1.DAT_1C0 &= 0xfffffffd;
        }

        if (param1.DAT_2F == 4)
        {
            param1.screen.y += 0x20;

            if (-0xd7c < param1.screen.y)
                param1.screen.y = -0xd7c;
        }
    }

    //FUN_1714 (ST9)
    private void FUN_1714(CriPlayer param1)
    {
        PTR_FUN_16080[param1.DAT_3E](param1);
    }

    //FUN_1750 (ST9)
    private void FUN_1750(CriPlayer param1)
    {
        PTR_FUN_16088[param1.DAT_3D](param1);

        if (param1.DAT_3D != 1 && param1.frame.DAT_02 != 0)
            GameManager.instance.FUN_5C94C(param1, DAT_15FE0[param1.frame.DAT_02]);
    }

    //FUN_17D4 (ST9)
    private void FUN_17D4(CriPlayer param1)
    {
        PTR_FUN_16098[param1.DAT_2F - 3](param1);
    }

    //FUN_1814 (ST9)
    private void FUN_1814(CriPlayer param1)
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
                param1.DAT_34 = param1.screen;
                FUN_73C(param1);
                PTR_FUN_160A0[param1.DAT_3C](param1);
                param1.DAT_21A &= 0xfff;

                if (param1.DAT_3C != 4)
                {
                    local_18 = new Vector3Int(0, DAT_15FD0[param1.DAT_2F - 3], 0);
                    Utilities.RotMatrix_gte(ref local_18, ref param1.cTransform.rotation);
                }

                param1.FUN_62F3C(ref param1.DAT_40);

                if (param1.DAT_2F == 4)
                {
                    bVar2 = InventoryManager.FUN_4A87C(3, 0x3a);

                    if (bVar2)
                        FUN_3874(param1);
                }

                if (param1.IDAT_1C4 != 0)
                    param1.IDAT_1C4--;

                FUN_57C(param1);
                uVar3 = GameManager.instance.DAT_A2D2;

                if (DAT_15FD4[uVar3] <= param1.DAT_1ED ||
                    DAT_15FD4[uVar3 + 4] <= (byte)param1.DAT_1EE ||
                    DAT_15FD4[uVar3 + 8] <= param1.DAT_1DF)
                    FUN_5B8(param1);

                if (param1.DAT_3D == 0)
                {
                    if ((param1.DAT_1C0 & 2) != 0 && 0x20 < param1.frame.DAT_01)
                    {
                        param1.PTR_120 = DAT_15F90;
                        param1.DAT_120 = 4;
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

    //FUN_1B64 (ST9)
    private void FUN_1B64(CriPlayer param1)
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

    //FUN_1BE4 (ST9)
    private void FUN_1BE4(CriPlayer param1)
    {

        param1.FUN_60AB4();
        param1.FUN_65714();

        if (param1.frame.DAT_03 == 100)
        {
            SceneManager.instance.DAT_272 = false;
            SceneManager.instance.DAT_270 = 3;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_1C5C (ST9)
    private void FUN_1C5C(CriPlayer param1)
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

    //FUN_1F3C (ST9)
    private void FUN_1F3C(CriPlayer param1)
    {
        return;
    }

    //FUN_1F44 (ST9)
    private void FUN_1F44()
    {
        CriParticle puVar1;
        uint uVar2;

        uVar2 = 0;

        do
        {
            puVar1 = SceneManager.instance.particleObjects[uVar2];

            if (puVar1.tags == 12 || puVar1.tags == 3)
            {
                puVar1.flags &= 0xfffffffd;
                puVar1.FUN_60068();
            }

            uVar2++;
        } while (uVar2 < SceneManager.instance.particleObjects.Length);
    }

    //FUN_1FF0 (ST9)
    private void FUN_1FF0(CriPlayer param1)
    {
        CriPlayer puVar1;
        CriCamera cVar2;

        cVar2 = SceneManager.instance.cCamera;
        param1.DAT_3D = 3;
        param1.DAT_3E = 0;
        param1.DAT_3F = 0;
        param1.DAT_40.z = 0;
        param1.DAT_1C0 &= 0xfffffffd;
        param1.DAT_154.DAT_154 = param1;
        cVar2.PTR_FUN_8C = cVar2.FUN_1E08;
        cVar2.DAT_8A = 0;
        SceneManager.instance.staticObjects[4].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[5].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[6].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[7].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[8].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[9].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[10].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[11].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[12].flags &= 0xfffffffd;
        SceneManager.instance.staticObjects[13].flags &= 0xfffffffd;
        //FUN_1D988
        puVar1 = (CriPlayer)param1.PDAT_1F4;

        if (puVar1 != null)
        {
            param1.PDAT_1F4 = null;
            puVar1.DAT_3C++;
        }

        FUN_1F44();
    }

    //FUN_2110 (ST9)
    private void FUN_2110(CriPlayer param1)
    {
        sbyte sVar1;
        CriBone oVar2;
        uint uVar3;
        Vector3Int local_18;

        Utilities.RotMatrix_gte(ref param1.vr, ref param1.cTransform.rotation);
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
            oVar2 = Utilities.FUN_601C8(param1.skeleton, sVar1) as CriBone;
            local_18.x += oVar2.screen.x;
            local_18.z += oVar2.screen.z;
        }

        sVar1 = GameManager.instance.FUN_7732C((ushort)local_18.x, (ushort)local_18.z, 0);
        uVar3 = (uint)(sVar1 + 1 & 7);
        param1.DAT_1EB = (byte)uVar3;
        param1.DAT_158.x = DAT_160EC[uVar3 * 2];
        param1.DAT_158.z = DAT_160EC[uVar3 * 2 + 1];
    }

    //FUN_2244 (ST9)
    private void FUN_2244(CriPlayer param1)
    {
        param1.DAT_164 = 1;
        param1.DAT_3F++;
        param1.FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x80121a0c), 0, 0, 0);
    }

    //FUN_2288 (ST9)
    private void FUN_2288(CriPlayer param1)
    {
        bool bVar1;
        uint uVar2;

        uVar2 = param1.frame.DAT_03;

        if (uVar2 != 0)
        {
            if (uVar2 == 0x32)
                GameManager.instance.FUN_2984C(0x801a);
            else
                GameManager.instance.FUN_5C94C(param1, DAT_161B4[uVar2 - 1]);
        }

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.FUN_609C8((TodScriptableObject)Utilities.GetRamObject(DAT_161A8[param1.DAT_3F - 1]), 0, 0, 0);
            param1.DAT_3F++;
        }
    }

    //FUN_2340 (ST9)
    private void FUN_2340(CriPlayer param1)
    {
        bool bVar1;

        param1.FUN_60AB4();
        bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

        if (bVar1)
        {
            param1.DAT_3F++;
            param1.FUN_609C8(1, 0, 0);
        }
    }

    //FUN_23A4 (ST9)
    private void FUN_23A4(CriPlayer param1)
    {
        bool bVar1;

        if (param1.frame.DAT_01 == 9)
            GameManager.instance.FUN_5C94C(param1, 57);

        if (param1.frame.DAT_01 == 60)
            GameManager.instance.FUN_5C94C(param1, 51);

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            FUN_2110(param1);
            param1.DAT_3C = 1;
            param1.DAT_3D = 0;
            param1.DAT_3E = 1;
            param1.DAT_3F = 0;
            param1.DAT_164 = 0;
            param1.FUN_609C8(0, 1, 10);
        }
    }

    //FUN_2450 (ST9)
    private void FUN_2450(CriPlayer param1)
    {
        PTR_FUN_161B8[param1.DAT_3F](param1);
        FUN_2AC(param1);
    }

    //FUN_249C (ST9)
    private void FUN_249C(CriPlayer param1)
    {
        bool bVar1;

        if (param1.DAT_3F == 0)
        {
            param1.DAT_3F++;
            FUN_2110(param1);
            param1.DAT_164 = 1;
            param1.flags |= 2;
        }

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_164 = 0;
        }
    }

    //FUN_2500 (ST9)
    private void FUN_2500(CriPlayer param1)
    {
        PTR_FUN_161D0[param1.DAT_3E](param1);
        param1.FUN_65890();
    }

    //FUN_254C (ST9)
    private void FUN_254C(CriPlayer param1)
    {
        bool bVar1;

        param1.DAT_175 = 0xff;
        param1.DAT_140 |= 0x8000;
        param1.FUN_60AB4();
        bVar1 = InventoryManager.FUN_4A87C(3, 0x30);

        if (bVar1)
            param1.FUN_65890();
    }

    //FUN_25A4 (ST9)
    private void FUN_25A4(CriPlayer param1)
    {
        param1.DAT_164 = 1;
        param1.DAT_140 &= 0x7fff;
        PTR_FUN_161D8[param1.DAT_18E](param1);
    }

    //FUN_25F4 (ST9)
    private void FUN_25F4(CriPlayer param1)
    {
        uint uVar1;
        ushort uVar2;
        ushort uVar3;

        if ((param1.DAT_11E & 0x80) != 0)
        {
            param1.DAT_11E &= 0x7f;

            if (param1.DAT_3C != 4)
            {
                uVar3 = (ushort)(param1.DAT_1A0 >> 4 & 0xf);
                uVar2 = (ushort)(param1.DAT_1A1 & 0xf);

                if (uVar3 == 2)
                {
                    uVar1 = GameManager.FUN_64650();
                    //...
                    //iVar5 = 1;
                }
                else if (uVar3 < 3)
                {
                    if (uVar3 == 1)
                    {
                        if (uVar2 < 6 && 1 < uVar2)
                            return;

                        uVar1 = GameManager.FUN_64650();
                        //...
                        //iVar5 = 4;
                    }
                }
                else if (uVar3 == 3 && param1.DAT_3D == 1)
                {
                    //...
                    param1.DAT_3D = 2;
                    param1.DAT_3E = 0;
                    ((CriPlayer)param1.DAT_154).DAT_1C0 &= 0xffffffbf;
                    //iVar5 = 8;
                    param1.DAT_11C++;
                }

                //FUN_65D1C
            }
        }
    }

    //FUN_2748 (ST9)
    private void FUN_2748(CriPlayer param1)
    {
        bool bVar1;
        CriSkinned oVar2;

        oVar2 = param1.DAT_154;
        bVar1 = InventoryManager.FUN_4A87C(2, 2);

        if (!bVar1)
        {
            bVar1 = InventoryManager.FUN_4A87C(3, 0x22);

            if (!bVar1)
            {
                GameManager.instance.FUN_774CC(param1, oVar2.screen);

                if (param1.DAT_148 < 23 && param1.IDAT_1C4 == 0)
                {
                    param1.DAT_3D = 4;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
            }
        }
    }
     
    //FUN_27D8 (ST9)
    private void FUN_27D8(CriPlayer param1)
    {
        param1.DAT_164 = 0;
        param1.DAT_3E++;
        param1.FUN_609C8(0, 1, 0);
    }

    //FUN_2814 (ST9)
    private void FUN_2814(CriPlayer param1)
    {
        short sVar1;
        short sVar2;

        FUN_2AC(param1);
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_10C);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 20, sVar1);
        param1.vr.y += sVar2;
        param1.FUN_60AB4();
        param1.FUN_65890();
    }

    //FUN_2870 (ST9)
    private void FUN_2870(CriPlayer param1)
    {
        PTR_FUN_161E0[param1.DAT_3E](param1);
    }

    //FUN_28AC (ST9)
    private void FUN_28AC(CriPlayer param1, sbyte param2)
    {
        CriCamera cVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        uint uVar6;
        CriSkinned oVar7;
        uint uVar8;
        Vector3Int local_50;
        Matrix3x3 auStack_48;

        cVar1 = SceneManager.instance.cCamera;
        uVar4 = 0;
        oVar7 = param1.DAT_154;
        uVar8 = param1.DAT_1D4 & 0xfU;

        do
        {
            bVar3 = GameManager.instance.FUN_768C8(oVar7.screen, DAT_1610C[(uVar4 & 0xff) * 8]);
            uVar6 = uVar4;

            if (bVar3) break;

            uVar4++;
            uVar6 = 0;
        } while ((uVar4 & 0xff) < 8);

        if (param2 == 0)
            cVar1.DAT_8A = 0;
        else
        {
            if (uVar8 != (uVar6 & 0xff))
                param1.DAT_1C0 |= 0x20;

            if ((param1.DAT_1C0 & 0x20) != 0 && cVar1.DAT_8A == 0)
            {
                cVar1.DAT_8A = 3;
                param1.DAT_1C0 &= 0xffffffdf;
            }
        }

        param1.SDAT_1D4 = (short)(uVar6 & 0xff | (ushort)(uVar8 << 8));
        local_50 = new Vector3Int(0, DAT_1618C[uVar6 & 0xff], 0);
        auStack_48 = new Matrix3x3();
        Utilities.RotMatrix_gte(ref local_50, ref auStack_48);
        local_50.y = 0;
        local_50.x = 0x157c;
        local_50 = Utilities.ApplyMatrixSV(ref auStack_48, ref local_50);
        param1.screen.x = oVar7.screen.x + local_50.x;
        param1.screen.z = oVar7.screen.z + local_50.z;
        sVar2 = (short)Utilities.FUN_615EC(param1.screen, oVar7.screen);
        param1.vr.y = sVar2;
    }

    //FUN_2A6C (ST9)
    private void FUN_2A6C(CriPlayer param1)
    {
        CriCamera cVar1;
        short sVar2;
        CriPlayer oVar3;

        cVar1 = SceneManager.instance.cCamera;
        oVar3 = (CriPlayer)param1.DAT_154;

        if ((param1.DAT_1C0 & 1) == 0)
        {
            if (param1.frame.DAT_01 == 0x4b)
                FUN_1FF0(param1);
        }
        else if (param1.DAT_3F == 0)
        {
            param1.DAT_3F = 1;
            cVar1.DAT_4E = 6;
        }
        else
        {
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            cVar1.PTR_FUN_8C = cVar1.FUN_1CFC;
            cVar1.DAT_8A = 0;
            param1.FUN_609C8(6, 0, 0);
            param1.DAT_40.z = 0;
            sVar2 = (short)Utilities.FUN_615EC(oVar3.screen, param1.screen);
            oVar3.vr.y = sVar2;
            param1.PTR_120 = DAT_15F90;
            param1.DAT_120 = 0;
            oVar3.DAT_1C0 |= 0x40;
            param1.DAT_140 &= 0x7fff;
        }
    }

    //FUN_2B68 (ST9)
    private void FUN_2B68(CriPlayer param1)
    {
        CriCamera cVar1;
        CriParticle pVar2;

        cVar1 = SceneManager.instance.cCamera;

        if (param1.DAT_3F == 0)
        {
            param1.DAT_3F = 1;
            param1.DAT_164 = 1;
            param1.DAT_40 = new Vector3Int(0, 0, 0);
            param1.DAT_140 |= 0x8000;
            cVar1.DAT_70 = 1;
            cVar1.PTR_FUN_8C = cVar1.FUN_3440;
            param1.FUN_609C8(2, 0, 0);
            param1.PTR_120 = null;
            param1.DAT_120 = 0;
            param1.DAT_1C0 = param1.DAT_1C0 & 0xfffffffe | 10;
            param1.flags &= 0xfffffffd;
            param1.DAT_1DA = 8;
            FUN_28AC(param1, 0);
        }
        else
        {
            param1.DAT_3F = 0;
            param1.DAT_3E++;
            cVar1.DAT_4E = 6;
            pVar2 = SceneManager.instance.FUN_5FFA0();

            if (pVar2 != null)
            {
                pVar2.tags = 27;
                param1.PDAT_1F4 = pVar2;
            }
        }
    }

    //FUN_2C70 (ST9)
    private void FUN_2C70(CriPlayer param1)
    {
        CriPlayer oVar1;

        if (param1.DAT_3F == 0)
        {
            param1.DAT_3F++;
            GameManager.instance.FUN_5C94C(param1, 60);
        }

        oVar1 = (CriPlayer)param1.DAT_154;
        FUN_28AC(param1, 1);
        param1.FUN_60AB4();
        FUN_2AC(param1);

        if (param1.frame.DAT_01 == 51)
            GameManager.instance.FUN_5C94C(param1, 48);

        if (param1.frame.DAT_01 == 71)
            GameManager.instance.FUN_5C94C(param1, 50);

        if (oVar1.DAT_3C == 1 && oVar1.DAT_3D == 6 && oVar1.DAT_3E == 1 && oVar1.DAT_241 == 0)
            param1.DAT_1C0 |= 1;
    }

    //FUN_2D54 (ST9)
    private void FUN_2D54(CriPlayer param1)
    {
        PTR_FUN_161E8[param1.DAT_3E](param1);
    }

    //FUN_2D90 (ST9)
    private void FUN_2D90(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        bool bVar3;

        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E = 1;
            param1.DAT_164 = 2;
            param1.DAT_1C0 &= 0xfffffffd;
        }
        else if (param1.DAT_3E != 1) goto LAB_2E04;

        bVar3 = param1.FUN_60AB4();

        if (bVar3)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            FUN_1FF0(param1);
        }

        LAB_2E04:
        sVar1 = (short)Utilities.FUN_615EC(param1.screen, param1.DAT_154.screen);
        sVar2 = (short)Utilities.FUN_64838(param1.vr.y, 20, sVar1);
        param1.vr.y += sVar2;
    }

    //FUN_2E40 (ST9)
    private void FUN_2E40(CriPlayer param1)
    {
        sbyte sVar1;
        short sVar3;
        uint uVar4;
        uint uVar5;
        bool bVar6;
        CriPlayer oVar6;
        CriBone oVar7;
        Vector3Int local_20;

        oVar6 = (CriPlayer)param1.PDAT_1F4;

        if (oVar6 != null)
        {
            oVar6.DAT_3C++;
            param1.PDAT_1F4 = null;
        }

        local_20 = new Vector3Int(param1.PTR_130[param1.DAT_130].pos.x, 0, param1.PTR_130[param1.DAT_130].pos.z);
        local_20 = Utilities.ApplyMatrixSV(ref param1.cTransform.rotation, ref local_20);
        sVar1 = param1.PTR_130[param1.DAT_130].bone;

        if (sVar1 == -1)
        {
            local_20.x += param1.screen.x;
            local_20.z += param1.screen.z;
        }
        else
        {
            oVar7 = Utilities.FUN_601C8(param1.skeleton, sVar1) as CriBone;
            local_20.x += oVar7.screen.x;
            local_20.z += oVar7.screen.z;
        }

        uVar4 = (uint)GameManager.instance.FUN_7732C((ushort)local_20.x, (ushort)local_20.z, 0);

        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E = 1;
            param1.FUN_609C8(7, 0, 0);
            SceneManager.instance.FUN_26EBC(0, 0);
            param1.DAT_164 = 0;
        }
        else if (param1.DAT_3E == 1)
        {
            bVar6 = param1.FUN_60AB4();

            if (bVar6)
            {
                uVar5 = uVar4 + 1 & 7;
                param1.DAT_1EB = (byte)uVar5;
                param1.DAT_158.x = DAT_160EC[uVar5 * 2];
                param1.DAT_158.z = DAT_160EC[uVar5 * 2 + 1];
                param1.DAT_3D = 0;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_1C0 &= 0xfffffff7;
            }
        }

        param1.FUN_65890();
        FUN_2AC(param1);

        if (param1.frame.DAT_03 != 0)
            GameManager.instance.FUN_5C94C(param1, 54);

        sVar3 = (short)Utilities.FUN_64838(param1.vr.y, 20, DAT_1618C[uVar4 & 0xff] + 0x800 & 0xfff);
        param1.vr.y += sVar3;
    }

    //FUN_3084 (ST9)
    private void FUN_3084(CriPlayer param1)
    {
        FUN_25F4(param1);
        PTR_FUN_161F0[param1.DAT_3D](param1);
        PTR_FUN_16204[param1.DAT_3D](param1);
    }

    //FUN_30F0 (ST9)
    private void FUN_30F0(CriPlayer param1)
    {
        sbyte sVar1;
        bool bVar2;
        CriBone oVar2;
        uint uVar3;
        Vector3Int local_18;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) != 0 || param1.DAT_3C != 0 && (param1.DAT_18E & 0x80) != 0)
            goto LAB_33EC;

        param1.DAT_34 = param1.screen;

        if (param1.DAT_3C != 0)
        {
            local_18 = new Vector3Int(param1.PTR_130[param1.DAT_130].pos.x, 0, param1.PTR_130[param1.DAT_130].pos.z);
            local_18 = Utilities.ApplyMatrixSV(ref param1.cTransform.rotation, ref local_18);
            sVar1 = param1.PTR_130[param1.DAT_130].bone;

            if (sVar1 == -1)
            {
                local_18.x += param1.screen.x;
                local_18.z += param1.screen.z;
            }
            else
            {
                oVar2 = Utilities.FUN_601C8(param1.skeleton, sVar1) as CriBone;
                local_18.x += oVar2.screen.x;
                local_18.z += oVar2.screen.z;
            }

            uVar3 = (uint)(int)GameManager.instance.FUN_7732C((ushort)local_18.x, (ushort)local_18.z, 0);

            if ((uVar3 & 0xff) == param1.DAT_1EB)
            {
                uVar3 = param1.DAT_1EB + 1U & 7;
                param1.DAT_1EB = (byte)uVar3;
                param1.DAT_158.x = DAT_160EC[uVar3];
                param1.DAT_158.z = DAT_160EC[uVar3 + 1];
            }

            GameManager.instance.FUN_774CC(param1, param1.DAT_158);
        }

        PTR_FUN_16218[param1.DAT_3C](param1);

        if ((param1.DAT_1C0 & 4) == 0)
        {
            //FUN_81544
            bVar2 = false; //tmp

            if (bVar2)
            {
                InventoryManager.FUN_4A7E8(3, 0x21, true);
                param1.DAT_1C0 |= 4;

                if (param1.PDAT_1F4 != null)
                {
                    ((CriSkinned)param1.PDAT_1F4).DAT_3C++;
                    param1.PDAT_1F4 = null;
                }
            }
        }

        if (param1.DAT_3D != 4 && param1.DAT_3D != 1)
        {
            if (GameManager.instance.DAT_A2D2 == 0)
            {
                if (2 < (ushort)param1.DAT_11C)
                {
                    //FUN_81544
                    bVar2 = false; //tmp

                    if (bVar2)
                        InventoryManager.FUN_4A7E8(3, 0x22, true);
                }
            }
            else if (4 < (ushort)param1.DAT_11C)
            {
                //FUN_81544
                bVar2 = false; //tmp

                if (bVar2)
                    InventoryManager.FUN_4A7E8(3, 0x22, true);
            }
        }

        //FUN_81544
        bVar2 = false; //tmp

        if (bVar2)
            InventoryManager.FUN_4A7E8(3, 0x23, true);

        param1.vr.y &= 0xfff;
        SceneManager.instance.FUN_802B8(param1, true, 1);
        param1.FUN_62F3C(ref param1.DAT_40);

        if (param1.IDAT_1C4 != 0)
            param1.IDAT_1C4--;

        SceneManager.instance.FUN_80A14(param1);
        FUN_57C(param1);

        LAB_33EC:
        if (param1.DAT_3C == 4 || (param1.DAT_1C0 & 2) != 0)
            uVar3 = param1.flags & 0xfffffffb;
        else
            uVar3 = param1.flags | 4;

        param1.flags = uVar3;
    }

    //FUN_3574 (ST9)
    private void FUN_3574(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x21);

        if (!bVar1)
            param1.DAT_164 = 1;
        else
            param1.DAT_164 = 0;

        param1.FUN_60AB4();
        param1.FUN_65890();
    }

    //FUN_35C4 (ST9)
    private void FUN_35C4(CriPlayer param1)
    {
        param1.DAT_40.z = 0;
        param1.DAT_3E++;
        param1.FUN_609C8(0, 1, 0);
    }

    //FUN_3600 (ST9)
    private void FUN_3600(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3E++;
            param1.FUN_609C8(3, 1, 0);
        }
    }

    //FUN_3658 (ST9)
    private void FUN_3658(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            InventoryManager.FUN_4A7E8(3, 0x23, true);
    }

    //FUN_368C (ST9)
    private void FUN_368C(CriPlayer param1)
    {
        PTR_FUN_1622C[param1.DAT_3E](param1);
    }

    //FUN_36C8 (ST9)
    private void FUN_36C8(CriPlayer param1)
    {
        param1.FUN_60AB4();
    }

    //FUN_36E8 (ST9)
    private void FUN_36E8(CriPlayer param1)
    {
        PTR_FUN_16238[param1.DAT_3D](param1);

        if (param1.frame.DAT_02 != 0)
            GameManager.instance.FUN_5C94C(param1, DAT_15FE0[param1.frame.DAT_02]);
    }

    //FUN_375C (ST9)
    private void FUN_375C(CriPlayer param1)
    {
        if (param1.screen.z < -0x1521)
        {
            GameManager.instance.DAT_922C = 1;
            InventoryManager.FUN_4A7E8(3, 0x3b, true);
        }
    }

    //FUN_37AC (ST9)
    private void FUN_37AC(CriPlayer param1)
    {
        if (param1.screen.z < -0x37bd)
        {
            GameManager.instance.DAT_922C = 2;
            InventoryManager.FUN_4A7E8(3, 0x3b, true);
        }
        else if (-0x1521 < param1.screen.y)
            GameManager.instance.DAT_922C = 0;
    }

    //FUN_3824 (ST9)
    private void FUN_3824(CriPlayer param1)
    {
        if (-0x37bd < param1.screen.z)
        {
            GameManager.instance.DAT_922C = 1;
            InventoryManager.FUN_4A7E8(3, 0x3b, true);
        }
    }

    //FUN_3874 (ST9)
    private void FUN_3874(CriPlayer param1)
    {
        PTR_FUN_16244[GameManager.instance.DAT_922C](param1);
    }

    //FUN_38C0 (ST9)
    private void FUN_38C0(CriPlayer param1)
    {
        bool bVar1;

        if (param1.DAT_3E == 0)
        {
            param1.DAT_3E = 1;
            param1.FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x80110f48), 1, 0, 0);
            param1.DAT_40.z = 45;
            param1.DAT_164 = 1;
        }
        else
        {
            bVar1 = param1.FUN_60AB4();

            if (bVar1 && InventoryManager.FUN_4A87C(3, 0x20))
            {
                InventoryManager.FUN_4A7E8(3, 0x20, false);
                param1.DAT_3E = 0;
                param1.DAT_3D++;
                param1.FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x80110fbc), 0, 0, 0);
                GameManager.instance.FUN_5C94C(param1, 146);
            }
        }
    }

    //FUN_398C (ST9)
    private void FUN_398C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3D++;
            param1.FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x80114264), 1, 10, 0);
        }

        if (param1.frame.DAT_01 == 18)
            GameManager.instance.FUN_5C94C(param1, 48);
    }

    //FUN_3A08 (ST9)
    private void FUN_3A08(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_40.z = 0;
            param1.DAT_3C = 1;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        if (param1.frame.DAT_01 == 19)
            GameManager.instance.FUN_5C94C(param1, 51);
    }

    //FUN_3A60 (ST9)
    private void FUN_3A60(CriPlayer param1)
    {
        param1.FUN_60AB4();
    }

    //FUN_3A80 (ST9)
    private void FUN_3A80(CriPlayer param1)
    {
        PTR_FUN_16250[param1.DAT_3D](param1);
    }

    //FUN_3DBC (ST9)
    private void FUN_3DBC(CriPlayer param1)
    {
        bool bVar1;
        CriPlayer oVar2;
        uint uVar3;

        param1.screen.y = 0;
        param1.DAT_3C++;
        param1.FUN_6449C(param1.DAT_140);
        param1.FUN_77784(1, 0x250);
        param1.DAT_175 = 1;
        param1.DAT_3D = 1;
        FUN_AF40(param1);

        if (param1.maxHealth == 0)
            FUN_AFB8(param1);

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
        else if (oVar2.DAT_1C5 != 1)
            param1.DAT_1C8 = 1;

        FUN_B40C(param1);
        FUN_B424(param1);
        param1.PTR_130 = DAT_16260;
        param1.DAT_130 = 11;
        param1.DAT_18D = true;
        param1.FUN_65D0C(0, 30);
        param1.FUN_66404(0, 0x2000, 0x2000);
        param1.FUN_65984(18, 14);
        uVar3 = 0;

        do
        {
            if ((param1.DAT_19A >> (int)(uVar3 & 31) & 1) != 0)
            {
                bVar1 = FUN_B668(param1, (uVar3 & 0xff) >> 2, uVar3 & 3);

                if (bVar1)
                    param1.DAT_199++;
            }

            uVar3++;
        } while ((uVar3 & 0xff) < 0x10);

        param1.FUN_609C8(1, 1, 0);
    }

    //FUN_3F40 (ST9)
    private void FUN_3F40(CriPlayer param1)
    {
        if ((param1.DAT_3C != 1 || param1.DAT_3D != 6) && (param1.DAT_3C != 1 || param1.DAT_3D != 7))
            FUN_3FB0(param1);
    }

    //FUN_3F78 (ST9)
    private void FUN_3F78(CriPlayer param1)
    {
        if ((param1.DAT_3C == 1 && param1.DAT_3D == 6) || (param1.DAT_3C == 1 && param1.DAT_3D == 7))
            FUN_3FB0(param1);
    }

    //FUN_3FB0 (ST9)
    private void FUN_3FB0(CriPlayer param1)
    {
        if (param1.DAT_3D != 37)
            PTR_FUN_164CC[param1.DAT_3D](param1);
    }

    //FUN_3FF4 (ST9)
    private void FUN_3FF4(CriPlayer param1)
    {
        if (param1.DAT_3D == 37)
            FUN_699C(param1);
        else
        {
            FUN_3F40(param1);
            PTR_FUN_164F8[param1.DAT_3D](param1);
        }
    }

    //FUN_4060 (ST9)
    private void FUN_4060(CriPlayer param1)
    {
        return;
    }

    //FUN_4068 (ST9)
    private void FUN_4068(CriPlayer param1)
    {
        if (SceneManager.instance.skinnedObjects[10].DAT_3C != 5)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_4090 (ST9)
    private void FUN_4090(CriPlayer param1)
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

    //FUN_4134 (ST9)
    private void FUN_4134(CriPlayer param1)
    {
        PTR_FUN_16524[param1.DAT_3E](param1);
    }

    //FUN_4170 (ST9)
    private void FUN_4170(CriPlayer param1)
    {
        ushort uVar1;
        bool bVar2;
        byte bVar3;
        bool bVar4;
        short sVar5;
        int iVar6;
        CriSkinned oVar6;
        uint uVar7;
        uint uVar8;
        Vector3Int local_20;

        FUN_B15C(param1);
        oVar6 = SceneManager.instance.skinnedObjects[10];
        sVar5 = param1.FUN_64804(oVar6.screen);
        uVar8 = (uint)(oVar6.vr.y - param1.vr.y & 0xfff);
        bVar2 = SceneManager.instance.FUN_80D48(param1.screen, oVar6.screen, 4);

        if ((GameManager.instance.DAT_922C & 2) == 0 && (oVar6.DAT_11E & 0x80) == 0)
        {
            if (0xd00 < (ushort)(sVar5 - 0x180) && param1.UDAT_1DC < 0xdac && !bVar2)
            {
                param1.DAT_1C3 = 0;
                param1.DAT_3C = 1;
                param1.DAT_3D = 7;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_1C0 &= 0x7f;

                if (sVar5 < 0x200)
                    bVar3 = (byte)(param1.BDAT_1C0 | 8);
                else
                    bVar3 = (byte)(param1.BDAT_1C0 & 0xf7);

                param1.DAT_1C0 = bVar3;
                GameManager.instance.FUN_65C7C(param1);
                return;
            }
        }
        else if (0xd00 < (ushort)(sVar5 - 0x180) && param1.UDAT_1DC < 0xdac && !bVar2)
        {
            iVar6 = (int)GameManager.FUN_64650();

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
                goto LAB_44FC;
            }
            
            param1.DAT_3C = 1;
            param1.DAT_3D = 6;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            LAB_44FC:
            GameManager.instance.FUN_65C7C(param1);
            return;
        }
        else if ((param1.BDAT_1C0 & 0x20) == 0)
        {
            if ((GameManager.instance.DAT_922C & 2) == 0)
            {
                if (oVar6.DAT_3C == 5 && oVar6.DAT_3D == 1 && 0xc00 < (ushort)(sVar5 - 0x200) && param1.UDAT_1DC < 0xe74)
                {
                    bVar4 = SceneManager.instance.FUN_65BA8(param1);

                    if (!bVar2 && !bVar4 && 0xc00 < (uVar8 - 0x200))
                    {
                        param1.DAT_3C = 1;
                        param1.DAT_3D = 9;
                        param1.DAT_3E = 0;
                        param1.DAT_3F = 0;
                        GameManager.instance.FUN_65C7C(param1);
                        return;
                    }

                    param1.DAT_3C = 1;
                    param1.DAT_3D = 0;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
            }
            else
            {
                uVar1 = (ushort)(oVar6.DAT_3D << 8 | param1.DAT_3C);

                if ((uVar1 == 0x705 || uVar1 == 0x805 || uVar1 == 0x405 || uVar1 == 0x605) && 
                    param1.UDAT_1DC < 0xe74 && 0xc00 < (ushort)(sVar5 - 0x200))
                {
                    param1.DAT_3C = 1;
                    param1.DAT_3D = 0;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
            }
        }
        else if (oVar6.DAT_3C == 5 && oVar6.DAT_3D == 4)
        {
            if (uVar8 - 0x601 < 0x400 && 0xc00 < (ushort)(sVar5 - 0x200) && param1.UDAT_1DC - 0x708 < 700)
            {
                if (bVar2 || SceneManager.instance.FUN_65BA8(param1) || GameManager.instance.DAT_55)
                {
                    param1.DAT_3C = 1;
                    param1.DAT_3D = 0;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.DAT_1C0 &= 0xdf;
                    GameManager.instance.FUN_65CB0(param1);
                    FUN_B240(param1);
                    return;
                }

                uVar7 = 0x801;
                goto LAB_45CC;
            }

            if (param1.UDAT_1DC < 0x708 && 0xc00 < (ushort)(sVar5 - 0x200))
            {
                param1.DAT_3C = 1;
                param1.DAT_3D = 0;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_1C0 &= 0xdf;
                GameManager.instance.FUN_65CB0(param1);
                FUN_B240(param1);
                return;
            }
        }
        else
        {
            param1.BDAT_1C0 &= 0xdf;
            GameManager.instance.FUN_65CB0(param1);
            FUN_B240(param1);
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

        LAB_45CC:
        param1.DAT_3C = (byte)uVar7;
        param1.DAT_3D = (byte)(uVar7 >> 8);
        param1.DAT_3E = (byte)(uVar7 >> 0x10);
        param1.DAT_3F = (byte)(uVar7 >> 0x18);
    }

    //FUN_45F0 (ST9)
    private void FUN_45F0(CriPlayer param1)
    {
        byte bVar1;
        short sVar2;
        short sVar3;
        ushort uVar4;
        int iVar5;
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
                    sVar2 = (short)param1.FUN_6615C();
                    param1.DAT_1D0 = (param1.DAT_1D0 & 0xffff0000) | (ushort)sVar2;
                    param1.DAT_1CF = 52;
                    param1.DAT_1CC = 0;
                }
            }

            if (param1.DAT_1CE == 0)
            {
                local_18 = new Vector3Int(param1.DAT_10C.x, param1.screen.y, param1.DAT_10C.z);
                sVar2 = (short)Utilities.FUN_615EC(param1.screen, local_18);
                iVar5 = (int)GameManager.FUN_64650();
                sVar3 = (short)param1.vr.y;
                iVar5 = (iVar5 % 15 + 20) * 0x10000 >> 0x10;
                goto LAB_477C;
            }
        }

        if ((param1.DAT_162 & 2) == 0)
            param1.DAT_1CD++;

        bVar1 = (byte)(param1.DAT_1CF - 1);
        param1.DAT_1CF = bVar1;
        uVar4 = (ushort)(param1.vr.y - (short)param1.DAT_1D0 & 0xfff);

        if (bVar1 << 0x18 < 1 || 3 < param1.DAT_1CD || uVar4 < 0x100 || 0xf00 < uVar4)
        {
            param1.DAT_1CE = 0;
            param1.DAT_1CC = 0;
        }

        sVar3 = (short)param1.vr.y;
        sVar2 = (short)param1.DAT_1D0;
        iVar5 = 20;
        LAB_477C:
        sVar3 = (short)Utilities.FUN_64838(sVar3, (uint)iVar5, sVar2);
        param1.vr.y = param1.vr.y + sVar3 & 0xfff;
    }

    //FUN_47AC (ST9)
    private void FUN_47AC(CriPlayer param1)
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

    //FUN_4838 (ST9)
    private void FUN_4838(CriPlayer param1)
    {
        ushort uVar1;

        FUN_45F0(param1);
        uVar1 = param1.DAT_60;
        
        if (uVar1 == 1)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            uVar1 = param1.DAT_60;
        }

        if (uVar1 == 24)
            GameManager.instance.FUN_5C94C(param1, 49);
    }

    //FUN_4890 (ST9)
    private void FUN_4890(CriPlayer param1)
    {
        PTR_FUN_1652C[param1.DAT_3E](param1);
    }

    //FUN_48CC (ST9)
    private void FUN_48CC(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        CriPlayer oVar3;
        bool bVar4;
        CriBone oVar5;

        oVar3 = (CriPlayer)SceneManager.instance.skinnedObjects[10];

        if ((param1.DAT_18E & 4) == 0)
        {
            oVar5 = Utilities.FUN_601C8(param1.skeleton, 2) as CriBone;
            sVar1 = (short)param1.vr.y;
            sVar2 = (short)oVar5.vr.y;
            bVar4 = SceneManager.instance.FUN_80D48(param1.screen, oVar3.screen, 4);

            if ((!bVar4 && (Utilities.FUN_64C0C(param1.screen, oVar3.screen, (short)(sVar1 + sVar2 & 0xfff), 0x200) || 
                 param1.UDAT_1DC < 4000 && ((oVar3.DAT_3C == 1 && oVar3.DAT_3D == 1) || (oVar3.DAT_3C == 1 && oVar3.DAT_3D == 5) || 
                 (oVar3.DAT_227 & 0x80) != 0))) || param1.BDAT_1EC != 0 || (param1.UDAT_1DC < 8000 && (oVar3.DAT_227 & 0x40) != 0))
            {
                param1.BDAT_1EC = 0;
                param1.DAT_3C = 1;
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.FUN_65D0C(0, 30);
                FUN_B020(param1);
            }
        }
    }

    //FUN_4A20 (ST9)
    private void FUN_4A20(CriPlayer param1)
    {
        FUN_47AC(param1);
        GameManager.instance.FUN_77238((byte)param1.DAT_48, ref param1.VDAT_1E4);
        GameManager.instance.FUN_774CC(param1, (Vector3Int)param1.VDAT_1E4);
    }

    //FUN_4A68 (ST9)
    private void FUN_4A68(CriPlayer param1)
    {
        uint uVar1;
        Vector3Int vVar2;

        FUN_4838(param1);

        if (param1.DAT_1C2 == 0)
        {
            vVar2 = (Vector3Int)param1.VDAT_1E4;
            uVar1 = Utilities.FUN_631AC(param1.screen, vVar2);

            if (uVar1 < 600)
            {
                GameManager.instance.FUN_77238((byte)param1.DAT_48, ref param1.VDAT_1E4);
                GameManager.instance.FUN_774CC(param1, vVar2);
            }
        }
    }

    //FUN_4AD4 (ST9)
    private void FUN_4AD4(CriPlayer param1)
    {
        PTR_FUN_16534[param1.DAT_3E](param1);
    }

    //FUN_4B10 (ST9)
    private void FUN_4B10(CriPlayer param1)
    {
        bool bVar1;
        byte bVar2;
        short sVar3;
        int iVar4;
        CriSkinned oVar5;

        oVar5 = SceneManager.instance.skinnedObjects[10];
        FUN_B15C(param1);
        sVar3 = param1.FUN_64804(oVar5.screen);
        bVar1 = SceneManager.instance.FUN_80D48(param1.screen, oVar5.screen, 4);

        if ((GameManager.instance.DAT_922C & 2) == 0 && (oVar5.DAT_11E & 0x80) == 0 && param1.DAT_1C8 != 0)
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
        else if (param1.UDAT_1DC < 4500)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_4CB4 (ST9)
    private void FUN_4CB4(CriPlayer param1)
    {
        ushort uVar1;

        FUN_45F0(param1);
        uVar1 = param1.DAT_60;

        if (uVar1 == 1)
        {
            GameManager.instance.FUN_5C94C(param1, 48);
            uVar1 = param1.DAT_60;
        }

        if (uVar1 == 15)
            GameManager.instance.FUN_5C94C(param1, 49);
    }

    //FUN_4D0C (ST9)
    private void FUN_4D0C(CriPlayer param1)
    {
        PTR_FUN_1653C[param1.DAT_3E](param1);
    }

    //FUN_4D48 (ST9)
    private void FUN_4D48(CriPlayer param1)
    {
        param1.FUN_609C8(3, 8, 10);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_4D90 (ST9)
    private void FUN_4D90(CriPlayer param1)
    {
        ushort uVar1;
        bool bVar2;
        CriPlayer oVar3;

        bVar2 = param1.FUN_60AB4();
        oVar3 = (CriPlayer)SceneManager.instance.skinnedObjects[10];

        if (bVar2)
        {
            if ((param1.BDAT_1C0 & 0x40) == 0 || 0x7ff < (ushort)(param1.FUN_64804(oVar3.screen) - 0x400))
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
                FUN_B240(param1);
            }

            param1.BDAT_1C0 &= 0xbf;
        }

        uVar1 = param1.DAT_60;

        if (uVar1 == 12)
        {
            GameManager.instance.FUN_5C94C(param1, 58);
            uVar1 = param1.DAT_60;
        }

        if (uVar1 == 5)
        {
            oVar3 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

            if (oVar3 != null && (oVar3.BDAT_1C0 & 1) != 0 && oVar3.DAT_3C == 1 && (oVar3.DAT_3C != 1 || oVar3.DAT_3D != 4))
            {
                if (oVar3.DAT_3C == 1 && param1.DAT_3D == 5)
                    FUN_B3CC(param1);

                param1.DAT_3C = 1;
                param1.DAT_3D = 4;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
        }
    }

    //FUN_4EC4 (ST9)
    private void FUN_4EC4(CriPlayer param1)
    {
        PTR_FUN_16544[param1.DAT_3E](param1);
    }

    //FUN_4F00 (ST9)
    private void FUN_4F00(CriPlayer param1)
    {
        bool bVar2;
        int iVar2;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)SceneManager.instance.skinnedObjects[10];

        if ((oVar5.DAT_11E & 0x80) == 0)
        {
            bVar2 = SceneManager.instance.FUN_81014(param1.screen, oVar5.screen, (byte)(param1.DAT_48 << 4 | 0xf), false);

            if (!bVar2 && (param1.DAT_162 & 1) != 0 && param1.DAT_1C1 == 0 && param1.DAT_60 - 28 < 6 && (param1.DAT_12B & 0x1e) != 0)
            {
                param1.DAT_1C1 = 1;

                if ((oVar5.vr.y - param1.vr.y & 0xfff) - 0x400 < 0x801)
                {
                    oVar5.DAT_3C = 5;
                    oVar5.DAT_3D = 3;
                    oVar5.DAT_3E = 0;
                    oVar5.DAT_3F = 0;
                    oVar5.vr.y = param1.vr.y - 0x800 & 0xfff;
                    param1.BDAT_1C0 |= 0x20;
                    //...
                }
                else
                {
                    oVar5.DAT_3C = 5;
                    oVar5.DAT_3D = 0;
                    oVar5.DAT_3E = 0;
                    oVar5.DAT_3F = 0;
                    oVar5.vr.y = param1.vr.y;
                    //...
                }

                //FUN_65D1C
                GameManager.instance.PTR_FUN_148 = FUN_865C;
                oVar5.DAT_1F0 = param1;
                param1.FUN_65C4C(oVar5);
                GameManager.instance.FUN_5C94C(param1, 63);
                //FUN_1D988

                if ((oVar5.DAT_11E & 1) == 0 && 0 < oVar5.health)
                {
                    iVar2 = (int)GameManager.FUN_64650();
                    oVar5.health = (short)((oVar5.health - 400) - (iVar2 + (iVar2 / 150) * -150));
                    oVar5.FUN_4FE30();

                    if (oVar5.health < 1)
                    {
                        FUN_BFCC(param1);
                    }
                }
            }
        }
    }

    //FUN_5128 (ST9)
    private void FUN_5128(CriPlayer param1)
    {
        int iVar1;

        if (param1.DAT_3D == 6)
        {
            param1.FUN_609C8(14, 0, 10);
            param1.PTR_120 = DAT_16260;
            param1.DAT_120 = 6;
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

            param1.PTR_120 = DAT_16260;
            param1.DAT_120 = iVar1;
        }

        //FUN_65D0C
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1C1 = 0;
        param1.DAT_3E++;
    }

    //FUN_520C (ST9)
    private void FUN_520C(CriPlayer param1)
    {
        short sVar1;
        ushort uVar2;
        int iVar3;
        bool bVar3;
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
                FUN_B240(param1);
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
            FUN_B40C(param1);

        if (param1.DAT_60 < 34)
        {
            local_18 = new Vector3Int(param1.DAT_10C.x, param1.vr.y, param1.DAT_10C.z);
            sVar1 = (short)Utilities.FUN_615EC(param1.screen, local_18);
            iVar3 = (int)GameManager.FUN_64650();
            uVar2 = (ushort)Utilities.FUN_64838(param1.vr.y, (uint)(iVar3 % 15 + 10) * 0x10000 >> 0x10, sVar1);
            param1.vr.y = param1.vr.y + uVar2 & 0xfff;
        }
    }

    //FUN_5368 (ST9)
    private void FUN_5368(CriPlayer param1)
    {
        PTR_FUN_16574[param1.DAT_3E](param1);
    }

    //FUN_53A4 (ST9)
    private void FUN_53A4(CriPlayer param1)
    {
        bool bVar2;
        int iVar2;
        uint uVar3;
        uint uVar5;
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

        if (13 < param1.DAT_60 - 19)
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
                    goto LAB_55E4;
                }
            }

            //...
        }

        //...
        LAB_55E4:
        GameManager.instance.FUN_5C94C(param1, 63);
        //FUN_1D988
        FUN_B40C(param1);

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

                FUN_BFCC(param1);
            }
        }
    }

    //FUN_56D0 (ST9)
    private void FUN_56D0(CriPlayer param1)
    {
        ushort uVar1;
        short sVar1;
        short sVar2;
        int iVar3;
        bool bVar3;
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
            FUN_B240(param1);
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
                FUN_B40C(param1);
                uVar1 = param1.DAT_60;
            }

            if (uVar1 == 36 && param1.DAT_1C3 != 0 && 0xc00 < (ushort)(param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen) - 0x200) && param1.UDAT_1DC < 3500)
            {
                param1.DAT_1C3 = 0;
                param1.DAT_3E++;
            }

            local_18 = new Vector3Int(param1.DAT_10C.x, param1.screen.y, param1.DAT_10C.z);
            sVar2 = (short)Utilities.FUN_615EC(param1.screen, local_18);
            iVar3 = (int)GameManager.FUN_64650();
            sVar1 = (short)Utilities.FUN_64838(param1.vr.y, (uint)(iVar3 % 15 + 10) * 0x10000 >> 0x10, sVar2);
            param1.vr.y = param1.vr.y + sVar1 & 0xfff;
        }
    }

    //FUN_5A50 (ST9)
    private void FUN_5A50(CriPlayer param1)
    {
        PTR_FUN_165CC[param1.DAT_3E](param1);
    }

    //FUN_5D0C (ST9)
    private void FUN_5A8C(CriPlayer param1)
    {
        CriPlayer pbVar1;

        if (param1.DAT_3D == 8)
            param1.FUN_609C8(16, 0, 0);
        else
        {
            param1.FUN_609C8(29, 0, 0);
            //FUN_65D1C
        }

        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_656EC();
        pbVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        pbVar1.DAT_18D = false;
        pbVar1.DAT_11E |= 0x28;
        param1.FUN_65D0C(0, 30);
        param1.DAT_3E++;
    }

    //FUN_5B58 (ST9)
    private void FUN_5B58(CriPlayer param1)
    {
        CriCamera cVar1;
        short sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
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
            GameManager.instance.PTR_FUN_148 = FUN_865C;
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
            cVar1 = SceneManager.instance.cCamera;
            cVar1.DAT_72 |= 4;
            cVar1.PTR_FUN_8C = cVar1.FUN_BEA0;
            cVar1.DAT_64 = param1;
            GameManager.instance.FUN_5C94C(param1, 60);
            sVar3 = (short)param1.DAT_60;
        }

        if (sVar3 == 61)
            FUN_BFCC(param1);

        if (param1.DAT_60 == 70)
            GameManager.instance.FUN_5C94C(param1, 59);
    }

    //FUN_5D0C (ST9)
    private void FUN_5D0C(CriPlayer param1)
    {
        PTR_FUN_165F0[param1.DAT_3E](param1);
    }

    //FUN_5D48 (ST9)
    private void FUN_5D48(CriPlayer param1)
    {
        short sVar1;
        short sVar2;
        Vector3Int local_18;

        local_18 = new Vector3Int(param1.DAT_10C.x, param1.screen.y, param1.DAT_10C.z);
        sVar2 = param1.FUN_64804(local_18);
        param1.UDAT_1DA = (ushort)sVar2;

        if ((sVar2 & 0x800) == 0)
        {
            param1.FUN_609C8(12, 0, 0);
            param1.BDAT_1C0 |= 8;
            sVar1 = (short)((sVar2 - 0x400) / 0x19);
        }
        else
        {
            param1.FUN_609C8(13, 0, 0);
            param1.BDAT_1C0 &= 0xf7;
            sVar1 = (short)-(((0x1000 - sVar2 & 0xfff) - 0x400) / 0x19);
        }

        param1.SDAT_1D8 = sVar1;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.vr.y = param1.vr.y + param1.SDAT_1D8 & 0xfff;
        param1.DAT_3E++;
    }

    //FUN_5E70 (ST9)
    private void FUN_5E70(CriPlayer param1)
    {
        short sVar1;
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

            if ((param1.BDAT_1D0 & 8) == 0)
                sVar1 = (short)(param1.vr.y - 0x400);
            else
                sVar1 = (short)(param1.vr.y + 0x400);

            param1.vr.y = sVar1 & 0xfff;
        }
    }

    //FUN_5EF4 (ST9)
    private void FUN_5EF4(CriPlayer param1)
    {
        PTR_FUN_165F8[param1.DAT_3E](param1);
    }

    //FUN_5F30 (ST9)
    private void FUN_5F30(CriPlayer param1)
    {
        CriCamera cVar1;
        short sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        CriPlayer oVar5;

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
            GameManager.instance.PTR_FUN_148 = FUN_865C;
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
            cVar1 = SceneManager.instance.cCamera;
            cVar1.DAT_72 |= 4;
            cVar1.DAT_70 = 1;
            cVar1.PTR_FUN_8C = cVar1.FUN_BD7C;
            cVar1.DAT_64 = param1;
            GameManager.instance.FUN_5C94C(param1, 53);
            //FUN_1D988
        }
    }

    //FUN_6404 (ST9)
    private void FUN_6404(CriPlayer param1)
    {
        PTR_FUN_16614[param1.DAT_3E](param1);
    }

    //FUN_6440 (ST9)
    private void FUN_6440(CriPlayer param1)
    {
        CriCamera cVar3;
        CriPlayer oVar4;

        param1.FUN_609C8(34, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_656EC();
        param1.DAT_18D = false;
        cVar3 = SceneManager.instance.cCamera;
        oVar4 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar4.DAT_18D = false;
        oVar4.DAT_11E |= 8;
        param1.FUN_65D0C(0, 30);
        GameManager.instance.PTR_FUN_148 = FUN_865C;
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

    //FUN_6510 (ST9)
    private void FUN_6510(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.FUN_65714();

        if (param1.DAT_60 == 32)
            GameManager.instance.FUN_5C94C(param1, 53);

        //FUN_C75C
    }

    //FUN_6594 (ST9)
    private void FUN_6594(CriPlayer param1)
    {
        CriPlayer oVar1;
        CriCamera cVar2;

        param1.FUN_609C8(32, 1, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar1.DAT_1CA = 35;
        oVar1.DAT_1E6 = 160;
        oVar1.DAT_1E5 = 0;
        SceneManager.instance.FUN_26E1C();
        cVar2 = SceneManager.instance.cCamera;
        cVar2.DAT_72 |= 4;
        cVar2.DAT_70 = 1;
        cVar2.PTR_FUN_8C = cVar2.FUN_BFC4;
        cVar2.DAT_64 = param1;
        param1.DAT_3E++;
    }

    //FUN_664C (ST9)
    private void FUN_664C(CriPlayer param1)
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

        //...

        if ((oVar5.DAT_11E & 0x20) == 0 && 0 < oVar5.health && oVar5.DAT_1E5 == 0)
        {
            iVar3 = GameManager.instance.FUN_64C80();

            if (iVar3 != 0)
                oVar5.DAT_1CA -= (short)iVar3;

            if (oVar5.DAT_1CA < 1 || --oVar5.DAT_1E6 << 0x10 < 1)
                oVar5.DAT_1E5 = 1;

            if ((oVar5.DAT_11E & 1) == 0 && param1.DAT_60 == 15)
            {
                iVar3 = (int)GameManager.FUN_64650();
                oVar5.health = (short)((oVar5.health - 50) - (iVar3 + (iVar3 / 50) * -50));
                oVar5.FUN_4FE30();

                if (oVar5.health < 1)
                    FUN_BFCC(param1);
            }
        }
    }

    //FUN_6824 (ST9)
    private void FUN_6824(CriPlayer param1)
    {
        param1.FUN_609C8(33, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        param1.DAT_3E++;
        SceneManager.instance.skinnedObjects[10].DAT_3E++;
    }

    //FUN_6894 (ST9)
    private void FUN_6894(CriPlayer param1)
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
            FUN_B240(param1);
        }

        param1.FUN_65714();

        if (param1.DAT_60 == 16)
            GameManager.instance.FUN_5C94C(param1, 59);
    }

    //FUN_690C (ST9)
    private void FUN_690C(CriPlayer param1)
    {
        PTR_FUN_16654[param1.DAT_3E](param1);
    }

    //FUN_6948 (ST9)
    private void FUN_6948(CriPlayer param1)
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

    //FUN_699C (ST9)
    private void FUN_699C(CriPlayer param1)
    {
        PTR_FUN_1666C[param1.DAT_3E](param1);
    }

    //FUN_69D8 (ST9)
    private void FUN_69D8(CriPlayer param1)
    {
        PTR_FUN_16674[param1.DAT_3D](param1);
    }

    //FUN_6A14 (ST9)
    private void FUN_6A14(CriPlayer param1)
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
        param1.DAT_60 = (byte)uVar4;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        FUN_B40C(param1);
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        GameManager.instance.FUN_5C94C(param1, 0x38);

        //if ((param1.BDAT_1C0 & 4) == 0)
        //    ; //FUN_BBFC

        param1.BDAT_1C0 &= 0xdf;
        param1.DAT_3E++;
    }

    //FUN_6B44 (ST9)
    private void FUN_6B44(CriPlayer param1)
    {
        ushort uVar1;
        short sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        short[] aVar5;

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
            aVar5 = DAT_16410;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar5 = DAT_16460;
        }

        param1.DAT_40.z = aVar5[uVar1];
        sVar2 = (short)Utilities.FUN_615EC(param1.screen, SceneManager.instance.skinnedObjects[10].screen);
        iVar4 = (int)GameManager.FUN_64650();
        sVar3 = (short)Utilities.FUN_64838(param1.vr.y, (uint)(iVar4 % 15 + 10) * 0x10000 >> 0x10, sVar2);
        param1.vr.y = param1.vr.y + sVar3 & 0xfff;

        if (param1.health < 1 && param1.DAT_60 == 19)
        {
            param1.DAT_3C = 3;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_6C68 (ST9)
    private void FUN_6C68(CriPlayer param1)
    {
        PTR_FUN_16684[param1.DAT_3E](param1);
    }

    //FUN_6CA4 (ST9)
    private void FUN_6CA4(CriPlayer param1)
    {
        byte bVar1;
        short sVar2;
        int iVar3;
        uint uVar4;

        iVar3 = (int)GameManager.FUN_64650();
        uVar4 = (uint)iVar3 % 5;
        sVar2 = (short)param1.FUN_64804(SceneManager.instance.skinnedObjects[10].screen);

        if ((short)(sVar2 - 0x400) < 0x800)
        {
            param1.FUN_6103C(23, 0, (byte)uVar4, 0);
            bVar1 = (byte)(param1.BDAT_1C0 | 0x10);
        }
        else
        {
            param1.FUN_6103C(5, 0, (byte)uVar4, 0);
            bVar1 = (byte)(param1.BDAT_1C0 & 0xef);
        }

        param1.BDAT_1C0 = bVar1;
        param1.DAT_60 = (ushort)(uVar4 & 0xff);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        FUN_B40C(param1);
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        GameManager.instance.FUN_5C94C(param1, 55);

        if ((param1.BDAT_1C0 & 4) == 0)
        {
            //...
        }

        param1.BDAT_1C0 &= 0xdf;
        param1.DAT_3E++;
    }

    //FUN_6DEC (ST9)
    private void FUN_6DEC(CriPlayer param1)
    {
        ushort uVar1;
        short sVar2;
        short sVar3;
        int iVar4;
        bool bVar4;
        uint uVar5;
        short[] aVar6;

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
            aVar6 = DAT_1668C;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar6 = DAT_166BC;
        }

        param1.DAT_40.z = aVar6[uVar1];
        sVar2 = (short)Utilities.FUN_615EC(param1.screen, SceneManager.instance.skinnedObjects[10].screen);
        iVar4 = (int)GameManager.FUN_64650();
        sVar3 = (short)Utilities.FUN_64838(param1.vr.y, (uint)(iVar4 % 15 + 10) * 0x10000 >> 0x10, sVar2);
        param1.vr.y = param1.vr.y + sVar3 & 0xfff;

        if (param1.health < 1 && param1.DAT_60 == 18 && param1.DAT_1C6 != 3)
        {
            param1.DAT_3C = 3;
            param1.DAT_3D = 3;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }
    }

    //FUN_6F48 (ST9)
    private void FUN_6F48(CriPlayer param1)
    {
        PTR_FUN_166EC[param1.DAT_3E](param1);
    }

    //FUN_6F84 (ST9)
    private void FUN_6F84(CriPlayer param1)
    {
        int iVar1;
        uint uVar2;

        iVar1 = (int)GameManager.FUN_64650();
        uVar2 = (uint)iVar1 % 5 & 0xff;
        param1.FUN_6103C(8, 8, (byte)uVar2, 10);
        param1.DAT_60 = (ushort)(uVar2 << 1);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_5C94C(param1, 55);
        //...
        param1.DAT_3E++;
    }

    //FUN_7044 (ST9)
    private void FUN_7044(CriPlayer param1)
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

    //FUN_7088 (ST9)
    private void FUN_7088(CriPlayer param1)
    {
        PTR_FUN_166F4[param1.DAT_3E](param1);
    }

    //FUN_70C4 (ST9)
    private void FUN_70C4(CriPlayer param1)
    {
        param1.FUN_609C8(28, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_710C (ST9)
    private void FUN_710C(CriPlayer param1)
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

    //FUN_714C (ST9)
    private void FUN_714C(CriPlayer param1)
    {
        PTR_FUN_166FC[param1.DAT_3E](param1);
    }

    //FUN_7188 (ST9)
    private void FUN_7188(CriPlayer param1)
    {
        PTR_FUN_16704[param1.DAT_3D](param1);
    }

    //FUN_71C4 (ST9)
    private void FUN_71C4(CriPlayer param1)
    {
        param1.FUN_609C8(10, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        param1.DAT_3E++;
    }

    //FUN_7228 (ST9)
    private void FUN_7228(CriPlayer param1)
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
                FUN_BCB4(param1);

            param1.DAT_3E++;
        }

        param1.DAT_40.z = DAT_16714[param1.DAT_60];

        if (param1.DAT_60 == 12)
            GameManager.instance.FUN_5C94C(param1, 50);
    }

    //FUN_7310 (ST9)
    private void FUN_7310(CriPlayer param1)
    {
        PTR_FUN_16748[param1.DAT_3E](param1);
    }

    //FUN_734C (ST9)
    private void FUN_734C(CriPlayer param1)
    {
        param1.FUN_609C8(11, 8, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_65CB0(param1);
        GameManager.instance.FUN_5C94C(param1, 57);
        InventoryManager.FUN_4A7E8(4, param1.DAT_163, true);
        param1.DAT_3E++;
    }

    //FUN_73BC (ST9)
    private void FUN_73BC(CriPlayer param1)
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
                FUN_BCB4(param1);

            param1.DAT_3E++;
        }

        if (param1.DAT_60 == 46)
            GameManager.instance.FUN_5C94C(param1, 50);
    }

    //FUN_7488 (ST9)
    private void FUN_7488(CriPlayer param1)
    {
        PTR_FUN_16754[param1.DAT_3E](param1);
    }

    //FUN_74C4 (ST9)
    private void FUN_74C4(CriPlayer param1)
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

    //FUN_7544 (ST9)
    private void FUN_7544(CriPlayer param1)
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
            aVar3 = DAT_16760;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar3 = DAT_167A0;
        }

        param1.DAT_40.z = aVar3[uVar1];
    }

    //FUN_75B8 (ST9)
    private void FUN_75B8(CriPlayer param1)
    {
        PTR_FUN_167E0[param1.DAT_3E](param1);
    }

    //FUN_75F4 (ST9)
    private void FUN_75F4(CriPlayer param1)
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

    //FUN_7674 (ST9)
    private void FUN_7674(CriPlayer param1)
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
            aVar3 = DAT_167E8;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar3 = DAT_16810;
        }

        param1.DAT_40.z = aVar3[uVar1];
    }

    //FUN_76E8 (ST9)
    private void FUN_76E8(CriPlayer param1)
    {
        PTR_FUN_16838[param1.DAT_3E](param1);
    }

    //FUN_7724 (ST9)
    private void FUN_7724(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = InventoryManager.FUN_4A87C(3, 0x20);

        if (bVar1)
            param1.FUN_65D0C(0, 30);

        PTR_FUN_16840[param1.DAT_3D](param1);
    }

    //FUN_7788 (ST9)
    private void FUN_7788(CriPlayer param1)
    {
        param1.FUN_60AB4();
    }

    //FUN_77A8 (ST9)
    private void FUN_77A8(CriPlayer param1)
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
        iVar1 = (int)Utilities.FUN_631AC(param1.screen, param1.GET_OFFSET_190());
        param1.UDAT_1E0 = (ushort)iVar1;
        param1.DAT_3E++;
    }

    //FUN_7824 (ST9)
    private void FUN_7824(CriPlayer param1)
    {
        sbyte sVar1;
        short sVar2;
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

            iVar5 = param1.DAT_190 + 1;
            param1.DAT_190 = iVar5;
            param1.SDAT_1D6 = (short)param1.screen.z;
            param1.SDAT_1D4 = (short)param1.screen.x;
            uVar6 = Utilities.FUN_631AC(param1.screen, param1.PTR_190[iVar5]);
            param1.UDAT_1E0 = (ushort)uVar6;
        }

        param1.FUN_60AB4();
        sVar2 = (short)Utilities.FUN_615EC(param1.screen, param1.GET_OFFSET_190());
        sVar3 = (short)Utilities.FUN_64838(param1.vr.y, 60, sVar2);
        param1.vr.y = param1.vr.y + sVar3 & 0xfff;
        param1.FUN_65890();
    }

    //FUN_798C (ST9)
    private void FUN_798C(CriPlayer param1)
    {
        PTR_FUN_16854[param1.DAT_3E](param1);
    }

    //FUN_7934 (ST9)
    private void FUN_7934(CriPlayer param1)
    {
        FUN_7824(param1);

        if (param1.DAT_60 == 1)
            GameManager.instance.FUN_5C94C(param1, 48);

        if (param1.DAT_60 == 24)
            GameManager.instance.FUN_5C94C(param1, 49);
    }

    //FUN_79C8 (ST9)
    private void FUN_79C8(CriPlayer param1)
    {
        FUN_7824(param1);

        if (param1.DAT_60 == 1)
            GameManager.instance.FUN_5C94C(param1, 48);

        if (param1.DAT_60 == 15)
            GameManager.instance.FUN_5C94C(param1, 49);
    }

    //FUN_7A20 (ST9)
    private void FUN_7A20(CriPlayer param1)
    {
        PTR_FUN_16860[param1.DAT_3E](param1);
    }

    //FUN_7A5C (ST9)
    private void FUN_7A5C(CriPlayer param1)
    {
        int iVar1;

        if ((param1.BDAT_1C0 & 0x10) == 0)
            iVar1 = 4;
        else
            iVar1 = 22;

        param1.FUN_609C8(iVar1, 0, 10);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        FUN_B40C(param1);
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        GameManager.instance.FUN_5C94C(param1, 56);
        //...
        param1.DAT_18D = true;
        param1.DAT_196 = 0;
        param1.DAT_12C |= 8;
        param1.BDAT_1C0 &= 0xdf;
        FUN_B43C(param1);
        param1.DAT_3E++;
    }

    //FUN_7B3C (ST9)
    private void FUN_7B3C(CriPlayer param1)
    {
        ushort uVar1;
        bool bVar2;
        short[] aVar3;
        Vector3Int local_10;

        bVar2 = param1.FUN_60AB4();

        if (bVar2)
        {
            param1.DAT_3C = 1;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_12C &= 0xfff7;
            param1.DAT_140 &= 0xfffe;
            bVar2 = InventoryManager.FUN_4A87C(5, param1.DAT_163);

            if (bVar2)
                InventoryManager.FUN_4A7E8(5, param1.DAT_163, false);

            FUN_B378(param1);
        }

        if ((param1.BDAT_1C0 & 0x10) == 0)
        {
            uVar1 = param1.DAT_60;
            aVar3 = DAT_16410;
        }
        else
        {
            uVar1 = param1.DAT_60;
            aVar3 = DAT_16460;
        }

        param1.DAT_40.z = aVar3[uVar1];
        local_10 = new Vector3Int(0, (short)param1.UDAT_1DA, 0);
        Utilities.RotMatrix(ref local_10, ref param1.cTransform.rotation);

        if (param1.health < 1)
        {
            param1.DAT_3C = 3;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_12C &= 0xfff7;
            param1.DAT_140 &= 0xfffe;
            bVar2 = InventoryManager.FUN_4A87C(5, param1.DAT_163);

            if (bVar2)
                InventoryManager.FUN_4A7E8(5, param1.DAT_163, false);

            FUN_B378(param1);
        }
    }

    //FUN_7C60 (ST9)
    private void FUN_7C60(CriPlayer param1)
    {
        PTR_FUN_1686C[param1.DAT_3E](param1);
    }

    //FUN_7C9C (ST9)
    private void FUN_7C9C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            InventoryManager.FUN_4A7E8(3, param1.DAT_176, true);

        param1.FUN_65890();
    }

    //FUN_7CE0 (ST9)
    private void FUN_7CE0(CriPlayer param1)
    {
        PTR_FUN_16874[param1.DAT_3D](param1);
    }

    //FUN_7D1C (ST9)
    private void FUN_7D1C(CriPlayer param1)
    {
        short sVar1;
        CriPlayer oVar2;
        int iVar3;

        param1.FUN_609C8(6, 8, 10);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        oVar2 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

        if (oVar2 != null && (oVar2.BDAT_1C0 & 1) != 0)
            oVar2.DAT_1C8 = 1;

        if (param1.DAT_1C6 == 2)
        {
            iVar3 = (int)GameManager.FUN_64650();
            sVar1 = (short)(iVar3 + (iVar3 / 10) * -10 + 20);
        }
        else
        {
            if (param1.DAT_1C6 != 1)
            {
                param1.DAT_196 = 150;
                goto LAB_7E18;
            }

            iVar3 = (int)GameManager.FUN_64650();
            sVar1 = (short)(iVar3 + (iVar3 / 5) * -5 + 10);
        }

        param1.DAT_196 = (short)(sVar1 * 30);
        LAB_7E18:
        param1.DAT_1C7 = 0;
        param1.FUN_65D0C(0, 30);
        GameManager.instance.FUN_65CB0(param1);
        InventoryManager.FUN_4A7E8(5, param1.DAT_163, true);
        param1.DAT_3E++;
    }

    //FUN_7E64 (ST9)
    private void FUN_7E64(CriPlayer param1)
    {
        bool bVar1;

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
            if (param1.DAT_60 == 55)
            {
                param1.DAT_3C = 5;
                param1.DAT_3D = 3;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                return;
            }
        }

        if (param1.DAT_60 == 70)
            GameManager.instance.FUN_5C94C(param1, 50);
    }

    //FUN_7EDC (ST9)
    private void FUN_7EDC(CriPlayer param1)
    {
        PTR_FUN_16884[param1.DAT_3E](param1);
    }

    //FUN_7F18 (ST9)
    private void FUN_7F18(CriPlayer param1)
    {
        param1.FUN_609C8(7, 9, 0);
        param1.DAT_12C = 0xffff;
        param1.PTR_124 = DAT_16260;
        param1.DAT_124 = 17;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_12F = 1;
        param1.DAT_3E++;
    }

    //FUN_7F7C (ST9)
    private void FUN_7F7C(CriPlayer param1)
    {
        param1.FUN_60AB4();
    }

    //FUN_7F9C (ST9)
    private void FUN_7F9C(CriPlayer param1)
    {
        short sVar1;

        sVar1 = param1.DAT_196;

        if (sVar1 < 0 || 0 < --param1.DAT_196 << 0x10)
            PTR_FUN_1688C[param1.DAT_3E](param1);
        else
        {
            param1.DAT_3C = 5;
            param1.DAT_3D = 2;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_12C = 0;
            InventoryManager.FUN_4A7E8(5, param1.DAT_163, false);
        }
    }

    //FUN_8020 (ST9)
    private void FUN_8020(CriPlayer param1)
    {
        param1.FUN_609C8(9, 8, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_12C = 0;
        param1.DAT_3E++;
    }

    //FUN_806C (ST9)
    private void FUN_806C(CriPlayer param1)
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
            FUN_B424(param1);
            GameManager.instance.FUN_5C94C(param1, 64);
        }
    }

    //FUN_80CC (ST9)
    private void FUN_80CC(CriPlayer param1)
    {
        PTR_FUN_16894[param1.DAT_3E](param1);
    }

    //FUN_8108 (ST9)
    private void FUN_8108(CriPlayer param1)
    {
        param1.FUN_609C8(17, 8, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_8150 (ST9)
    private void FUN_8150(CriPlayer param1)
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

    //FUN_818C (ST9)
    private void FUN_818C(CriPlayer param1)
    {
        PTR_FUN_1689C[param1.DAT_3E](param1);
    }

    //FUN_81C8 (ST9)
    private void FUN_81C8(CriPlayer param1)
    {
        int iVar2;
        CriCamera cVar2;
        CriPlayer oVar3;

        GameManager.instance.FUN_46C0C(0, 20, 1);
        oVar3 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar3.screen = new Vector3Int(0, 0, 0);
        oVar3.vr = new Vector3Int(0, 0, 0);
        oVar3.PTR_124 = null;
        oVar3.DAT_124 = 0;
        oVar3.PTR_120 = null;
        oVar3.DAT_120 = 0;
        oVar3.DAT_12F = 0;
        oVar3.DAT_12E = 0;
        oVar3.DAT_140 |= 0x8000;
        oVar3.FUN_535E4(0x70, 0x70);
        GameManager.instance.PTR_FUN_14C = FUN_91F4;
        param1.FUN_65C4C(oVar3);
        oVar3.DAT_152 = 1;
        param1.DAT_152 = 1;
        oVar3.DAT_154 = param1;
        param1.DAT_154 = oVar3;
        oVar3.DAT_3C = 6;
        oVar3.DAT_3D = 0;
        oVar3.DAT_3E = 0;
        oVar3.DAT_3F = 0;
        oVar3.DAT_1C0 &= 0xfffffffe;
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
        iVar2 = (int)GameManager.FUN_64650();
        param1.BDAT_1CA = (byte)(iVar2 + (iVar2 / 2) * -2);
        FUN_C0E4(param1);
        cVar2 = SceneManager.instance.cCamera;
        cVar2.DAT_70 = 1;
        cVar2.PTR_FUN_8C = cVar2.FUN_BFC4;
        cVar2.DAT_64 = param1;
        param1.FUN_609C8(30, 1, 0);
        param1.FUN_656EC();
        param1.DAT_3E++;
    }

    //FUN_8358 (ST9)
    private void FUN_8358(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.FUN_65714();

        if (param1.DAT_60 == 2 || param1.DAT_60 == 20)
            GameManager.instance.FUN_5C94C(param1, 54);
    }

    //FUN_83C4 (ST9)
    private void FUN_83C4(CriPlayer param1)
    {
        param1.FUN_609C8(31, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        param1.DAT_3E++;
    }

    //FUN_8418 (ST9)
    private void FUN_8418(CriPlayer param1)
    {
        bool bVar1;
        CriCamera cVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.FUN_65714();

        if (param1.DAT_60 == 16)
        {
            cVar1 = SceneManager.instance.cCamera;
            cVar1.DAT_70 = 1;
            cVar1.DAT_64 = param1;
            cVar1.PTR_FUN_8C = cVar1.PTR_FUN_168A4[param1.BDAT_1CA];
            FUN_C280(param1);
            GameManager.instance.FUN_5C94C(param1, 59);
        }
    }

    //FUN_84B4 (ST9)
    private void FUN_84B4(CriPlayer param1)
    {
        CriCamera cVar1;

        param1.FUN_6103C(16, 0, 40, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_3E++;
        cVar1 = SceneManager.instance.cCamera;
        cVar1.DAT_70 = 1;
        cVar1.DAT_64 = param1;
        cVar1.PTR_FUN_8C = cVar1.PTR_FUN_168A4[param1.BDAT_1CA + 2];

        if (param1.BDAT_1CA != 0)
            FUN_C438(param1);
    }

    //FUN_854C (ST9)
    private void FUN_854C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.FUN_609C8(16, 0, 60);
            param1.DAT_3E++;
        }

        if (param1.DAT_60 == 20)
            GameManager.instance.FUN_5C94C(param1, 58);
    }

    //FUN_85C0 (ST9)
    private void FUN_85C0(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        if (param1.DAT_60 == 10)
            SceneManager.instance.DAT_272 = true;
    }

    //FUN_8620 (ST9)
    private void FUN_8620(CriPlayer param1)
    {
        PTR_FUN_168B4[param1.DAT_3E](param1);
    }

    //FUN_865C (ST9)
    private void FUN_865C(CriPlayer param1)
    {
        PTR_FUN_168D4[param1.DAT_3D](param1);
    }

    //FUN_8698 (ST9)
    private void FUN_8698(CriPlayer param1)
    {
        param1.FUN_609C8(35, 0, 5);
        param1.DAT_11E |= 0x88;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1C8 = 0;
        param1.DAT_1C0 &= 0xfffffffe;
        GameManager.instance.FUN_5C94C(param1, 3);
        param1.DAT_3E++;
    }

    //FUN_8710 (ST9)
    private void FUN_8710(CriPlayer param1)
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

        param1.DAT_40.z = -((param1.DAT_64.z - sVar1) - 0x4c);

        if (param1.DAT_60 == 10)
            GameManager.instance.FUN_5C94C(param1, 5);
    }

    //FUN_877C (ST9)
    private void FUN_877C(CriPlayer param1)
    {
        PTR_FUN_168F8[param1.DAT_3E](param1);
    }

    //FUN_87B8 (ST9)
    private void FUN_87B8(CriPlayer param1)
    {
        param1.FUN_609C8(36, 1, 0);
        param1.DAT_1CA = 10;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1E6 = 100;
        param1.DAT_5C |= 8;
        param1.FUN_538CC();
        param1.DAT_3E++;
    }

    //FUN_8838 (ST9)
    private void FUN_8838(CriPlayer param1)
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

    //FUN_88DC (ST9)
    private void FUN_88DC(CriPlayer param1)
    {
        PTR_FUN_16900[param1.DAT_3E](param1);
    }

    //FUN_8918 (ST9)
    private void FUN_8918(CriPlayer param1)
    {
        param1.FUN_609C8(37, 4, 5);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_5348C(0x70, 0x70);
        param1.DAT_3E++;
    }

    //FUN_8974 (ST9)
    private void FUN_8974(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;
    }

    //FUN_89B4 (ST9)
    private void FUN_89B4(CriPlayer param1)
    {
        param1.DAT_98 = param1.DAT_1E0;
        param1.FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x801860cc), 6, 0, 0);
        param1.DAT_3E++;
    }

    //FUN_8A04 (ST9)
    private void FUN_8A04(CriPlayer param1)
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

    //FUN_8A5C (ST9)
    private void FUN_8A5C(CriPlayer param1)
    {
        PTR_FUN_16908[param1.DAT_3E](param1);
    }

    //FUN_8A98 (ST9)
    private void FUN_8A98(CriPlayer param1)
    {
        param1.FUN_609C8(38, 4, 5);
        param1.DAT_40 = new Vector3Int(0, 0, -100);
        param1.DAT_1C8 = 0;
        param1.DAT_11E |= 0x88;
        param1.DAT_1C0 &= 0xfffffffe;
        GameManager.instance.FUN_5C94C(param1, 3);
        param1.DAT_3E++;
    }

    //FUN_8B14 (ST9)
    private void FUN_8B14(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.DAT_40.z += 5;
    }

    //FUN_8B64 (ST9)
    private void FUN_8B64(CriPlayer param1)
    {
        param1.FUN_609C8(39, 0, 0);
        param1.DAT_40.x = 0;
        param1.DAT_40.y = 0;
        param1.DAT_40.z += 2;
        param1.DAT_3E++;
    }

    //FUN_8BB4 (ST9)
    private void FUN_8BB4(CriPlayer param1)
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

    //FUN_8C0C (ST9)
    private void FUN_8C0C(CriPlayer param1)
    {
        PTR_FUN_16918[param1.DAT_3E](param1);
    }

    //FUN_8C48 (ST9)
    private void FUN_8C48(CriPlayer param1)
    {
        param1.FUN_609C8(41, 1, 0);
        param1.DAT_1CA = 40;
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_1E6 = 150;
        param1.DAT_5C |= 8;
        param1.FUN_538CC();
        param1.DAT_3E++;
    }

    //FUN_8CC8 (ST9)
    private void FUN_8CC8(CriPlayer param1)
    {
        PTR_FUN_16928[param1.DAT_3E](param1);
    }

    //FUN_8D04 (ST9)
    private void FUN_8D04(CriPlayer param1)
    {
        param1.FUN_609C8(40, 1, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_5348C(0x70, 0x70);
        param1.DAT_3E++;
    }

    //FUN_8D60 (ST9)
    private void FUN_8D60(CriPlayer param1)
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

    //FUN_8DBC (ST9)
    private void FUN_8DBC(CriPlayer param1)
    {
        PTR_FUN_16930[param1.DAT_3E](param1);
    }

    //FUN_8DF8 (ST9)
    private void FUN_8DF8(CriPlayer param1)
    {
        param1.FUN_609C8(42, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.DAT_11E = (byte)(param1.DAT_11E & 0xdf | 0x80);
        param1.FUN_65714();
        param1.FUN_5348C(0x70, 0x70);
        param1.DAT_1C0 &= 0xfffffffe;
        //FUN_65D1C
        param1.DAT_3E++;
    }

    //FUN_8EAC (ST9)
    private void FUN_8EAC(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.FUN_65714();
    }

    //FUN_8EDC (ST9)
    private void FUN_8EDC(CriPlayer param1)
    {
        PTR_FUN_1694C[param1.DAT_3E](param1);
    }

    //FUN_8F18 (ST9)
    private void FUN_8F18(CriPlayer param1)
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

    //FUN_8F9C (ST9)
    private void FUN_8F9C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
            param1.DAT_3E++;

        param1.FUN_65714();
    }

    //FUN_8FE4 (ST9)
    private void FUN_8FE4(CriPlayer param1)
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

    //FUN_904C (ST9)
    private void FUN_904C(CriPlayer param1)
    {
        param1.FUN_60AB4();
        param1.FUN_65714();
    }

    //FUN_91B8 (ST9)
    private void FUN_91B8(CriPlayer param1)
    {
        PTR_FUN_16954[param1.DAT_3E](param1);
    }

    //FUN_91F4 (ST9)
    private void FUN_91F4(CriPlayer param1)
    {
        PTR_FUN_1696C[param1.DAT_3D](param1);
    }

    //FUN_9230 (ST9)
    private void FUN_9230(CriPlayer param1)
    {
        param1.FUN_609C8(44, 1, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        param1.FUN_66460(true);
        param1.DAT_3E++;
    }

    //FUN_9290 (ST9)
    private void FUN_9290(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (bVar1)
        {
            param1.DAT_3C = 6;
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
        }

        param1.FUN_65714();
    }

    //FUN_92CC (ST9)
    private void FUN_92CC(CriPlayer param1)
    {
        PTR_FUN_16974[param1.DAT_3E](param1);
    }

    //FUN_9308 (ST9)
    private void FUN_9308(CriPlayer param1)
    {
        param1.FUN_609C8(45, 0, 0);
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_65714();
        param1.DAT_3E++;
    }

    //FUN_935C (ST9)
    private void FUN_935C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_60AB4();

        if (!bVar1)
        {
            param1.FUN_65714();

            if (param1.DAT_60 == 16)
            {
                param1.DAT_154.DAT_152 = 0;
                param1.DAT_152 = 0;
                GameManager.instance.FUN_5C94C(param1, 4);
            }

            if (param1.DAT_60 == 35)
                GameManager.instance.FUN_5C94C(param1, 5);
        }
        else
        {
            param1.FUN_65714();
            param1.FUN_66460(false);
            param1.vr.y = param1.vr.y + 0x800 & 0xfff;
            param1.DAT_3E++;
        }
    }

    //FUN_9408 (ST9)
    private void FUN_9408(CriPlayer param1)
    {
        PTR_FUN_1697C[param1.DAT_3E](param1);
    }

    //FUN_9444 (ST9)
    private void FUN_9444(CriPlayer param1)
    {
        if ((param1.DAT_11E & 0x80) == 0)
            param1.BDAT_1EC = 0;
        else
        {
            if ((param1.DAT_18E & 4) != 0)
                param1.DAT_18E &= 0xfb;

            param1.BDAT_1EC = 1;
            param1.DAT_11E &= 0x7b;
            PTR_FUN_16988[param1.DAT_1A0 >> 4](param1);
        }
    }

    //FUN_94D0 (ST9)
    private void FUN_94D0(CriPlayer param1)
    {
        PTR_FUN_1699C[(param1.DAT_1A1 & 0xf) != 6 ? 1 : 0](param1);

        //if (param1.DAT_1C5 == 0) ;
            //FUN_BAAC
    }

    //FUN_9538 (ST9)
    private void FUN_9538(CriPlayer param1)
    {
        short sVar2;
        short sVar3;
        int iVar4;
        int iVar5;
        ushort uVar6;
        uint uVar7;
        int psVar8;
        int iVar9;
        short sVar10;
        ushort[] aVar11;

        if ((param1.DAT_11E & 1) != 0)
            return;

        iVar4 = (int)GameManager.FUN_64650();
        param1.BDAT_1C0 &= 0xfb;

        if (param1.health < 1)
            return;

        if (GameManager.instance.DAT_A2D2 == 0)
        {
            aVar11 = DAT_16338;
            psVar8 = 16;
            iVar9 = 5;
        }
        else
        {
            aVar11 = DAT_16398;
            psVar8 = 16;
            iVar9 = 60;
        }

        uVar6 = (ushort)((param1.DAT_1A1 << 8 | param1.DAT_1A0) & 0xf);
        uVar7 = 1;

        if (uVar6 == 1 || uVar6 == 3)
        {
            iVar5 = (int)GameManager.FUN_64650();
            uVar7 = (uint)(iVar5 % iVar9);

            if (iVar9 == 0)
                return; //trap(0x1c00)

            if (iVar9 == -1 && iVar5 == -0x80000000)
                return; //trap(0x1800)
        }

        sVar10 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

        if (sVar10 == 5 || sVar10 == 0x105 || sVar10 == 0x205 || 
           (sVar10 == 0x601 && param1.DAT_60 - 26 < 12) || 
           (sVar10 == 0x701 && param1.DAT_60 < 36) || 
            sVar10 == 0x304 || param1.DAT_3C == 2 || param1.DAT_3C == 3)
        {
            iVar4 = (int)GameManager.FUN_64650();
            uVar7 = aVar11[psVar8 + 3];
            sVar10 = (short)(iVar4 % (int)uVar7);

            if (uVar7 == 0)
                return; //trap(0x1c00)

            if (uVar7 == 0xffffffff && iVar4 == -0x80000000)
                return; //trap(0x1800)

            sVar3 = (short)aVar11[psVar8 + 2];
            sVar2 = param1.health;
            param1.DAT_1C5 = 0;
        }
        else
        {
            if (param1.DAT_3C == 4)
            {
                param1.DAT_1C5 = 0;
                goto LAB_9834;
            }

            if ((uVar7 & 0xff) != 0)
            {
                if (param1.UDAT_1DC < (uint)((iVar4 % 10) * 100 & 0xffff) + 4000)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar7 = aVar11[psVar8 + 3];
                    sVar10 = (short)(iVar4 % (int)uVar7);

                    if (uVar7 == 0)
                        return; //trap(0x1c00)

                    if (uVar7 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar3 = (short)aVar11[psVar8 + 2];
                }
                else
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar7 = aVar11[psVar8 + 1];
                    sVar10 = (short)(iVar4 % (int)uVar7);

                    if (uVar7 == 0)
                        return; //trap(0x1c00)

                    if (uVar7 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar3 = (short)aVar11[psVar8];
                }

                sVar2 = param1.health;
                param1.DAT_1C5 = 0;
                goto LAB_9824;
            }

            iVar4 = (int)GameManager.FUN_64650();
            uVar7 = aVar11[psVar8 + 7];
            sVar10 = (short)(iVar4 % (int)uVar7);

            if (uVar7 == 0)
                return; //trap(0x1c00)

            if (uVar7 == 0xffffffff && iVar4 == -0x80000000)
                return; //trap(0x1800)

            sVar3 = (short)aVar11[psVar8 + 6];
            sVar2 = param1.health;
            param1.DAT_1C5 = 2;
        }

        LAB_9824:
        param1.DAT_11C = (short)(sVar3 + sVar10);
        param1.health = (short)(sVar2 - (sVar3 + sVar10));

        LAB_9834:
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

            if (sVar10 == 0x105 || sVar10 == 0x202 || (sVar10 == 5 && 61 < param1.DAT_60) || 
               (sVar10 == 0x205 && param1.DAT_60 < 23))
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
                FUN_B3CC(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 &= 0xfd;
            }

            FUN_B43C(param1);
        }
    }

    //FUN_994C (ST9)
    private void FUN_994C(CriPlayer param1)
    {
        short sVar2;
        short sVar3;
        int iVar4;
        int iVar5;
        ushort uVar6;
        uint uVar7;
        int psVar8;
        int iVar9;
        short sVar10;
        ushort[] aVar11;

        if ((param1.DAT_11E & 1) != 0)
            return;

        iVar4 = (int)GameManager.FUN_64650();
        param1.BDAT_1C0 &= 0xfb;

        if (param1.health < 1)
            return;

        if (GameManager.instance.DAT_A2D2 == 0)
        {
            aVar11 = DAT_16338;
            psVar8 = 32;
            iVar9 = 5;
        }
        else
        {
            aVar11 = DAT_16398;
            psVar8 = 32;
            iVar9 = 60;
        }

        uVar6 = (ushort)((param1.DAT_1A1 << 8 | param1.DAT_1A0) & 0xf);
        uVar7 = 1;

        if (uVar6 == 1 || uVar6 == 3)
        {
            iVar5 = (int)GameManager.FUN_64650();
            uVar7 = (uint)(iVar5 % iVar9);

            if (iVar9 == 0)
                return; //trap(0x1c00)

            if (iVar9 == -1 && iVar5 == -0x80000000)
                return; //trap(0x1800)
        }

        sVar10 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

        if (sVar10 == 5 || sVar10 == 0x105 || sVar10 == 0x205 || 
           (sVar10 == 0x601 && (param1.DAT_60 - 26 < 12)) || 
           (sVar10 == 0x701 && (param1.DAT_60 < 36)) || 
            sVar10 == 0x304 || param1.DAT_3C == 2 || param1.DAT_3C == 3)
        {
            iVar4 = (int)GameManager.FUN_64650();
            uVar7 = aVar11[psVar8 + 3];
            sVar10 = (short)(iVar4 % (int)uVar7);

            if (uVar7 == 0)
                return; //trap(0x1c00)

            if (uVar7 == 0xffffffff && iVar4 == -0x80000000)
                return; //trap(0x1800)

            sVar3 = (short)aVar11[psVar8 + 2];
            sVar2 = param1.health;
            param1.DAT_1C5 = 0;
        }
        else
        {
            if (param1.DAT_3C == 4)
            {
                param1.DAT_1C5 = 0;
                goto LAB_9C48;
            }

            if ((uVar7 & 0xff) != 0)
            {
                if (param1.UDAT_1DC < ((iVar4 % 10) * 100 & 0xffff) + 5500)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar7 = aVar11[psVar8 + 3];
                    sVar10 = (short)(iVar4 % (int)uVar7);

                    if (uVar7 == 0)
                        return; //trap(0x1c00)

                    if (uVar7 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar3 = (short)aVar11[psVar8 + 2];
                }
                else
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar7 = aVar11[psVar8 + 1];
                    sVar10 = (short)(iVar4 % (int)uVar7);

                    if (uVar7 == 0)
                        return; //trap(0x1c00)

                    if (uVar7 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar3 = (short)aVar11[psVar8];
                }

                sVar2 = param1.health;
                param1.DAT_1C5 = 0;
                goto LAB_9C38;
            }

            iVar4 = (int)GameManager.FUN_64650();
            uVar7 = aVar11[psVar8 + 7];
            sVar10 = (short)(iVar4 % (int)uVar7);

            if (uVar7 == 0)
                return; //trap(0x1c00)

            if (uVar7 == 0xffffffff && iVar4 == -0x80000000)
                return; //trap(0x1800)

            sVar3 = (short)aVar11[psVar8 + 6];
            sVar2 = param1.health;
            param1.DAT_1C5 = 2;
        }

        LAB_9C38:
        param1.DAT_11C = (short)(sVar3 + sVar10);
        param1.health = (short)(sVar2 - (sVar3 + sVar10));

        LAB_9C48:
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

            if (sVar10 == 0x105 || sVar10 == 0x202 || (sVar10 == 5 && 61 < param1.DAT_60) ||
               (sVar10 == 0x205 && param1.DAT_60 < 23))
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
                FUN_B3CC(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 &= 0xfd;
            }

            FUN_B43C(param1);
        }
    }

    //FUN_9D60 (ST9)
    private void FUN_9D60(CriPlayer param1)
    {
        PTR_FUN_169A4[param1.DAT_1A1 & 0xf](param1);
    }

    //FUN_9DA0 (ST9)
    private void FUN_9DA0(CriPlayer param1)
    {
        short sVar2;
        int iVar3;
        int iVar4;
        ushort[] aVar5;
        ushort uVar6;
        short sVar7;
        uint uVar8;
        int iVar9;
        int psVar10;
        ushort uVar11;
        short sVar12;
    
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
                aVar5 = DAT_16338;
            else
                aVar5 = DAT_16398;

            psVar10 = iVar9 * 8;

            if (param1.health < 1)
                return;
            
            uVar11 = (ushort)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (uVar11 == 5 || uVar11 == 0x205 || (uVar11 == 0x601 && param1.DAT_60 - 26 < 12) || 
                uVar11 == 0x304 || param1.DAT_3C == 2 || param1.DAT_3C == 3)
            {
                iVar3 = (int)GameManager.FUN_64650();
                uVar8 = aVar5[psVar10 + 5];
                sVar12 = (short)(iVar3 % (int)uVar8);

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                    return; //trap(0x1800)

                sVar2 = (short)aVar5[psVar10 + 4];
                sVar7 = param1.health;
                param1.DAT_1C5 = 0;
                param1.DAT_11C = (short)(sVar2 + sVar12);
                param1.health = (short)(sVar7 - (sVar2 + sVar12));
            }
            else if (uVar11 == 0x105)
            {
                iVar3 = (int)GameManager.FUN_64650();
                uVar8 = aVar5[psVar10 + 5];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                    return; //trap(0x1800)

                sVar12 = (short)aVar5[psVar10 + 4];
                param1.DAT_3C = 2;
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_1C5 = 4;
                param1.DAT_196 = 0;
                sVar12 += (short)(iVar3 + (int)uVar8);
                param1.DAT_11C = sVar12;
                param1.health -= sVar12;
            }
            else
            {
                if (param1.DAT_3C != 4)
                {
                    if (param1.UDAT_1DC < ((uint)(iVar3 % 10) * 100 & 0xffff) + 4500)
                    {
                        iVar3 = (int)GameManager.FUN_64650();
                        uVar8 = aVar5[psVar10 + 5];
                        sVar12 = (short)(iVar3 % (int)uVar8);

                        if (uVar8 == 0)
                            return; //trap(0x1c00)

                        if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                            return; //trap(0x1800)

                        sVar2 = (short)aVar5[psVar10 + 4];
                        sVar7 = param1.health;
                        param1.DAT_1C5 = 2;
                    }
                    else
                    {
                        if (((uint)(iVar4 % 20) * 100 & 0xffff) + 4500 <= param1.UDAT_1DC)
                        {
                            iVar3 = (int)GameManager.FUN_64650();
                            uVar8 = aVar5[psVar10 + 1];
                            sVar12 = (short)(iVar3 % (int)uVar8);

                            if (uVar8 == 0)
                                return; //trap(0x1c00)

                            if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                                return; //trap(0x1800)

                            sVar2 = (short)aVar5[psVar10];
                            sVar7 = param1.health;
                            param1.DAT_1C5 = 0;
                            param1.DAT_11C = (short)(sVar2 + sVar12);
                            param1.health = (short)(sVar7 - (sVar2 + sVar12));
                            goto LAB_A100;
                        }
                        else
                        {
                            iVar3 = (int)GameManager.FUN_64650();
                            uVar8 = aVar5[psVar10 + 3];
                            sVar12 = (short)(iVar3 % (int)uVar8);

                            if (uVar8 == 0)
                                return; //trap(0x1c00)

                            if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                                return; //trap(0x1800)

                            sVar2 = (short)aVar5[psVar10 + 2];
                            sVar7 = param1.health;
                            param1.DAT_1C5 = 2;
                        }
                    }

                    param1.DAT_11C = (short)(sVar2 + sVar12);
                    param1.health = (short)(sVar7 - (sVar2 + sVar12));
                    goto LAB_A100;
                }

                param1.DAT_1C5 = 0;
            }

            LAB_A100:
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

                uVar11 = (ushort)(param1.DAT_3D << 8 | param1.DAT_3C);

                if (param1.DAT_1C5 == 4 || uVar11 == 0x202 || (uVar11 == 5 && 61 < param1.DAT_60) ||
                   (uVar11 == 0x205 && param1.DAT_60 < 23))
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.DAT_1C5 == 0) goto LAB_A20C;

            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B3CC(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 |= 2;
            }

            FUN_B43C(param1);
        }

        if (param1.DAT_1C5 != 0)
            return;

        LAB_A20C:;
        //FUN_BBFC
    }

    //FUN_A230 (ST9)
    private void FUN_A230(CriPlayer param1)
    {
        short sVar2;
        int iVar3;
        int iVar4;
        ushort[] aVar5;
        ushort uVar6;
        short sVar7;
        uint uVar8;
        int iVar9;
        int psVar10;
        short sVar11;

        if ((param1.DAT_11E & 1) == 0)
        {
            iVar3 = (int)GameManager.FUN_64650();
            iVar4 = (int)GameManager.FUN_64650();
            param1.BDAT_1C0 &= 0xfb;
            uVar6 = (ushort)((param1.DAT_1A1 << 8 | param1.DAT_1A0) & 0xfb);
            iVar9 = 1;

            if (uVar6 == 1 || uVar6 == 3)
                iVar9 = 5;

            if (GameManager.instance.DAT_A2D2 == 0)
                aVar5 = DAT_16338;
            else
                aVar5 = DAT_16398;

            psVar10 = iVar9 * 8;

            if (param1.health < 1)
                return;

            sVar11 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (sVar11 == 5 || sVar11 == 0x205 || (sVar11 == 0x601 && param1.DAT_60 - 26 < 12) || 
                sVar11 == 0x304 || param1.DAT_3C == 2 || param1.DAT_3C == 3)
            {
                iVar3 = (int)GameManager.FUN_64650();
                uVar8 = aVar5[psVar10 + 5];
                sVar11 = (short)(iVar3 % (int)uVar8);

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                    return; //trap(0x1800)

                sVar7 = (short)aVar5[psVar10 + 4];
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
                    uVar8 = aVar5[psVar10 + 5];
                    sVar11 = (short)(iVar3 % (int)uVar8);

                    if (uVar8 == 0)
                        return; //trap(0x1c00)

                    if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                        return; //trap(0x1800)

                    sVar7 = (short)aVar5[psVar10 + 4];
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
                    goto LAB_A584;
                }

                if (param1.DAT_3C != 4)
                {
                    if (param1.UDAT_1DC < ((iVar3 % 10) * 100 & 0xffff) + 5500)
                    {
                        iVar3 = (int)GameManager.FUN_64650();
                        uVar8 = aVar5[psVar10 + 5];
                        sVar11 = (short)(iVar3 % (int)uVar8);

                        if (uVar8 == 0)
                            return; //trap(0x1c00)

                        if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                            return; //trap(0x1800)

                        sVar7 = (short)aVar5[psVar10 + 4];
                        sVar2 = param1.health;
                        param1.DAT_1C5 = 2;
                    }
                    else
                    {
                        if (((iVar4 % 20) * 100 & 0xffff) + 6000 <= param1.UDAT_1DC)
                        {
                            iVar3 = (int)GameManager.FUN_64650();
                            uVar8 = aVar5[psVar10 + 1];
                            sVar11 = (short)(iVar3 % uVar8);

                            if (uVar8 == 0)
                                return; //trap(0x1c00)

                            if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                                return; //trap(0x1800)

                            sVar7 = (short)aVar5[psVar10];
                            sVar2 = param1.health;
                            param1.DAT_1C5 = 0;
                            sVar7 = (short)(sVar7 + sVar11 + 100);
                            param1.DAT_11C = sVar7;
                            param1.health = (short)(sVar2 - sVar7);
                            goto LAB_A584;
                        }

                        iVar3 = (int)GameManager.FUN_64650();
                        uVar8 = aVar5[psVar10 + 3];
                        sVar11 = (short)(iVar3 % uVar8);

                        if (uVar8 == 0)
                            return; //trap(0x1c00)

                        if (uVar8 == 0xffffffff && iVar3 == -0x80000000)
                            return; //trap(0x1800)

                        sVar7 = (short)aVar5[psVar10 + 2];
                        sVar2 = param1.health;
                        param1.DAT_1C5 = 2;
                    }

                    sVar7 = (short)(sVar7 + sVar11 + 100);
                    param1.DAT_11C = sVar7;
                    param1.health = (short)(sVar2 - sVar7);
                    goto LAB_A584;
                }

                param1.DAT_1C5 = 0;
            }

            LAB_A584:
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

                if (param1.DAT_1C5 == 4 || sVar11 == 0x202 || (sVar11 == 5 && 61 < param1.DAT_60) ||
                   (sVar11 == 0x205 && param1.DAT_60 < 23))
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else
                    param1.DAT_1C5 = 2;
            }

            if (param1.DAT_1C5 == 0) goto LAB_A690;

            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B3CC(param1);

            if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 |= 2;
            }

            FUN_B43C(param1);
        }

        if (param1.DAT_1C5 != 0)
            return;

        LAB_A690:;
        //FUN_BBFC
    }

    //FUN_A6B4 (ST9)
    private void FUN_A6B4(CriPlayer param1)
    {
        if (param1.DAT_3C - 2 < 3)
            param1.DAT_1C5 = 0;
        else
        {
            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B3CC(param1);

            param1.DAT_3C = 2;
            param1.DAT_3D = 1;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_1C5 = 2;
            param1.BDAT_1C0 |= 2;
            FUN_B43C(param1);
        }

        param1.BDAT_1C0 |= 4;
        FUN_B4F8(param1);
    }

    //FUN_A744 (ST9)
    private void FUN_A744(CriPlayer param1)
    {
        byte bVar1;

        if (param1.DAT_3C != 5)
        {
            param1.DAT_1C6 = 0;
            bVar1 = (byte)(param1.DAT_1C7 + 1);
            param1.DAT_1C7 = (sbyte)bVar1;

            if (1 < bVar1)
                param1.DAT_194 = 1;

            FUN_A6B4(param1);
        }
    }

    //FUN_A798 (ST9)
    private void FUN_A798(CriPlayer param1)
    {
        if (param1.DAT_3C != 5)
        {
            param1.DAT_1C6 = 1;
            param1.DAT_194 = 1;
            FUN_A6B4(param1);
        }
    }

    //FUN_A7D0 (ST9)
    private void FUN_A7D0(CriPlayer param1)
    {
        if (param1.DAT_3C != 5)
        {
            param1.DAT_1C6 = 2;
            param1.DAT_194 = 1;
            FUN_A6B4(param1);
        }
    }

    //FUN_A808 (ST9)
    private void FUN_A808(CriPlayer param1)
    {
        short sVar2;

        if ((param1.DAT_11E & 1) == 0 && 0 < param1.health)
        {
            if (param1.DAT_3C != 4 || (param1.DAT_3C == 4 && param1.DAT_3D == 3))
                param1.health = -1;

            sVar2 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);
            param1.DAT_1C6 = 3;
            param1.BDAT_1C0 |= 4;

            if (sVar2 == 5 || param1.DAT_3C == 4 || sVar2 == 0x205 || param1.DAT_3C == 2 || param1.DAT_3C == 3)
                param1.DAT_1C5 = 0;
            else if (sVar2 == 0x105)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 2;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.DAT_196 = 0;
                param1.DAT_1C5 = 4;
            }
            else
                param1.DAT_1C5 = 2;

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

                sVar2 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

                if (param1.DAT_1C5 == 4 || sVar2 == 0x202 || (sVar2 == 5 && 61 < param1.DAT_60) ||
                   (sVar2 == 0x205 && param1.DAT_60 < 23))
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
                    FUN_B3CC(param1);

                if (param1.DAT_1C5 == 2)
                {
                    param1.DAT_3C = 2;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                    param1.BDAT_1C0 |= 2;
                }

                FUN_B43C(param1);
            }
        }

        FUN_B4F8(param1);
    }

    //FUN_A9E4 (ST9)
    private void FUN_A9E4(CriPlayer param1)
    {
        DAT_171C8 = (ushort)((param1.DAT_1A1 & 0xf) == 9 ? 1 : 0);
        PTR_FUN_169BC[DAT_171C8](param1);
    }

    //FUN_AA50 (ST9)
    private void FUN_AA50(CriPlayer param1)
    {
        short sVar2;
        short sVar3;
        int iVar4;
        int iVar5;
        uint uVar6;
        int iVar7;
        short sVar8;
        ushort[] aVar9;

        if ((param1.DAT_11E & 1) == 0)
        {
            iVar4 = (int)GameManager.FUN_64650();
            iVar5 = (int)GameManager.FUN_64650();
            param1.BDAT_1C0 &= 0xfb;

            if (param1.health < 1)
                return;

            if (GameManager.instance.DAT_A2D2 == 0)
            {
                aVar9 = DAT_16338;
                iVar7 = 24;
            }
            else
            {
                aVar9 = DAT_16398;
                iVar7 = 24;
            }

            sVar8 = (short)(param1.DAT_3D << 8 | param1.DAT_3C);

            if (sVar8 == 5 || sVar8 == 0x205 || sVar8 == 0x304 || 
                param1.DAT_3C == 2 || param1.DAT_3C == 3)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar6 = aVar9[iVar7 + 7];
                sVar8 = (short)(iVar4 % (int)uVar6);

                if (uVar6 == 0)
                    return; //trap(0x1c00)

                if (uVar6 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                sVar2 = (short)aVar9[iVar7 + 6];
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
                    uVar6 = aVar9[iVar7 + 7];
                    sVar8 = (short)(iVar4 % (int)uVar6);

                    if (uVar6 == 0)
                        return; //trap(0x1c00)

                    if (uVar6 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar2 = (short)aVar9[iVar7 + 6];
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
                        goto LAB_AD78;
                    }

                    if ((uint)((iVar4 % 10) * 100 & 0xffff) + 3000 <= param1.UDAT_1DC)
                    {
                        if (param1.UDAT_1DC < (uint)((iVar5 % 30) * 100 & 0xffff) + 4000)
                        {
                            iVar4 = (int)GameManager.FUN_64650();
                            uVar6 = aVar9[iVar7 + 8];
                            sVar8 = (short)(iVar4 % (int)uVar6);

                            if (uVar6 == 0)
                                return; //trap(0x1c00)

                            if (uVar6 == 0xffffffff && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            sVar2 = (short)aVar9[iVar7 + 4];
                        }
                        else
                        {
                            iVar4 = (int)GameManager.FUN_64650();
                            uVar6 = aVar9[iVar7 + 3];
                            sVar8 = (short)(iVar4 % (int)uVar6);

                            if (uVar6 == 0)
                                return; //trap(0x1c00)

                            if (uVar6 == 0xffffffff && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            sVar2 = (short)aVar9[iVar7 + 2];
                        }

                        sVar3 = param1.health;
                        param1.DAT_1C5 = 2;
                        param1.DAT_11C = (short)(sVar2 + sVar8);
                        param1.health = (short)(sVar3 - (sVar2 + sVar8));
                        goto LAB_AD78;
                    }

                    iVar4 = (int)GameManager.FUN_64650();
                    uVar6 = aVar9[iVar7 + 7];
                    sVar8 = (short)(iVar4 % (int)uVar6);

                    if (uVar6 == 0)
                        return; //trap(0x1c00)

                    if (uVar6 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    sVar2 = (short)aVar9[iVar7 + 6];
                    param1.DAT_1C5 = 1;
                    sVar3 = param1.health;
                }

                param1.DAT_11C = (short)(sVar2 + sVar8);
                param1.health = (short)(sVar3 - (sVar2 + sVar8));
            }

            LAB_AD78:
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

                if (param1.DAT_1C5 == 4 || sVar8 == 0x202 || (sVar8 == 5 && 61 < param1.DAT_60) ||
                   (sVar8 == 0x205 && param1.DAT_60 < 23))
                {
                    param1.DAT_3C = 3;
                    param1.DAT_3D = 1;
                    param1.DAT_3E = 0;
                    param1.DAT_3F = 0;
                }
                else if (param1.DAT_1C5 != 2)
                    param1.DAT_1C5 = 1;
            }

            if (param1.DAT_1C5 == 0) goto LAB_AEA4;

            if (param1.DAT_3C == 1 && param1.DAT_3D == 5)
                FUN_B3CC(param1);

            if (param1.DAT_1C5 == 1)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 0;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
            }
            else if (param1.DAT_1C5 == 2)
            {
                param1.DAT_3C = 2;
                param1.DAT_3D = 1;
                param1.DAT_3E = 0;
                param1.DAT_3F = 0;
                param1.BDAT_1C0 |= 2;
            }

            FUN_B43C(param1);

            if (param1.DAT_1C5 != 0)
                return;
        }

        LAB_AEA4:;
        //FUN_BBFC
    }

    //FUN_AEC8 (ST9)
    private void FUN_AEC8(CriPlayer param1)
    {
        CriInteract oVar1;

        if (param1.UDAT_1D2 == 0)
        {
            oVar1 = SceneManager.instance.FUN_5FF08();

            if (oVar1 != null)
            {
                oVar1.DAT_01 = 11;
                oVar1.BDAT_0A = 17;
                //...
                oVar1.PTR_18 = param1.skeleton;
                param1.UDAT_1D2 = 45;
            }
        }

        FUN_AA50(param1);
    }

    //FUN_AF40 (ST9)
    private void FUN_AF40(CriPlayer param1)
    {
        sbyte sVar1;

        if (GameManager.instance.DAT_9AA0 >> 8 == 6 || GameManager.instance.DAT_9AA0 >> 8 == 9)
        {
            sVar1 = (sbyte)GameManager.instance.DAT_9AA0;

            if (sVar1 - 3 < 6)
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

    //FUN_AFB8 (ST9)
    private void FUN_AFB8(CriPlayer param1)
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

    //FUN_B020 (ST9)
    private void FUN_B020(CriPlayer param1)
    {
        CriPlayer oVar1;
        uint uVar2;
        int iVar3;

        oVar1 = (CriPlayer)SceneManager.instance.FUN_65B30(param1);

        if (oVar1 != null)
        {
            if ((oVar1.DAT_1C0 & 1) != 0)
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
                            goto LAB_B144;
                        }
                    }
                    else if (param1.UDAT_1DC <= oVar1.UDAT_1DC)
                    {
                        oVar1.DAT_1C8 = 0;
                        goto LAB_B144;
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

        LAB_B144:
        param1.DAT_1C8 = 1;
    }

    //FUN_B15C (ST9)
    private void FUN_B15C(CriPlayer param1)
    {
        uint uVar1;
        uint uVar2;
        CriPlayer oVar3;

        if ((GameManager.instance.DAT_922C & 2) == 0 && (param1.DAT_128 & 0x3ff) != 0)
        {
            uVar1 = param1.DAT_128;
            uVar2 = 0;

            do
            {
                if ((uVar1 & 1) != 0) break;

                uVar2++;
                uVar1 = (uint)param1.DAT_128 >> (int)(uVar2 & 0x1f);
            } while ((uVar2 & 0xff) < 10);

            oVar3 = (CriPlayer)SceneManager.instance.skinnedObjects[uVar2 & 0xff];
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

    //FUN_B240 (ST9)
    private void FUN_B240(CriPlayer param1)
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
            else if (param1.UDAT_1DC <= oVar1.UDAT_1DC)
                oVar1.DAT_1C8 = 0;

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

    //FUN_B378 (ST9)
    private void FUN_B378(CriPlayer param1)
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

    //FUN_B3CC (ST9)
    private void FUN_B3CC(CriPlayer param1)
    {
        short sVar1;

        sVar1 = 40;

        if ((param1.BDAT_1C0 & 8) == 0)
            sVar1 = -40;

        param1.vr.y = param1.vr.y + sVar1 * param1.DAT_60 & 0xfff;
    }

    //FUN_B40C (ST9)
    private void FUN_B40C(CriPlayer param1)
    {
        param1.PTR_120 = DAT_16260;
        param1.DAT_120 = 0;
        param1.DAT_12E = 3;
    }

    //FUN_B424 (ST9)
    private void FUN_B424(CriPlayer param1)
    {
        param1.PTR_124 = DAT_16260;
        param1.DAT_124 = 12;
        param1.DAT_12F = 5;
    }

    //FUN_B43C (ST9)
    private void FUN_B43C(CriPlayer param1)
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
            oVar1.DAT_60 = 16;
            oVar1.DAT_18D = true;
            oVar2.DAT_18D = true;
            oVar1.DAT_152 = 0;
            oVar2.DAT_152 = 0;
            oVar1.DAT_11E &= 0xf7;
        }
    }

    //FUN_B4F8 (ST9)
    private void FUN_B4F8(CriPlayer param1)
    {
        sbyte sVar1;
        bool bVar1;
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

            if (0x3ff < (ushort)(sVar3 - 0x200))
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
                SceneManager.instance.FUN_23068((byte)iVar8, (byte)(uVar7 & 0xff));
                uVar5 = uVar7;
            }
        }

        bVar1 = FUN_B668(param1, (uint)iVar8, (uint)(uVar5 & 0xff));

        if (bVar1)
        {
            bVar2 = (byte)(param1.DAT_199 + 1);
            param1.DAT_199 = bVar2;
            param1.DAT_19A |= (ushort)(1 << ((int)uVar5 + iVar8 * 4 & 31));

            if (4 < bVar2)
            {
                param1.DAT_199 = 4;
                SceneManager.instance.FUN_22F9C();
            }
        }
    }

    //FUN_B668 (ST9)
    private bool FUN_B668(CriPlayer param1, uint param2, uint param3)
    {
        return param1.FUN_65D78(ref PTR_DAT_16AF8[(param2 & 0xff) * 4 + (param3 & 0xff) * 4], (byte)param2, (byte)param3);
    }

    //FUN_B6A8 (ST9)
    private void FUN_B6A8(CriPlayer param1)
    {

        if (0 < param1.DAT_194 && param1.DAT_3C != 3 && param1.DAT_3C != 4 && param1.DAT_194-- == 1)
        {
            if (param1.DAT_3C == 2)
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

    //FUN_BCB4 (ST9)
    private void FUN_BCB4(CriPlayer param1)
    {
        CriBone oVar2;
        CriParticle pVar3;
        Vector3Int local_38;
        Matrix3x3 auStack_30;

        oVar2 = Utilities.FUN_601C8(param1.skeleton, 0) as CriBone;
        auStack_30 = new Matrix3x3();
        Utilities.RotMatrix(ref param1.vr, ref auStack_30);
        local_38 = Utilities.ApplyMatrixSV(ref auStack_30, ref oVar2.DAT_44);
        pVar3 = SceneManager.instance.FUN_5FFA0();

        if (pVar3 != null)
        {
            pVar3.tags = 0;
            pVar3.DAT_3C = 3;
            pVar3.DAT_2F = 0;
            pVar3.screen.x = param1.screen.x + local_38.x;
            pVar3.screen.y += param1.screen.y;
            pVar3.screen.z = param1.screen.z + local_38.z;
            pVar3.DAT_68 = 120;
            pVar3.DAT_62 = 0;
            pVar3.DAT_60 = 0;
            pVar3.DAT_69 = 0x4c;
        }
    }

    //FUN_BFCC (ST9)
    private void FUN_BFCC(CriPlayer param1)
    {
        CriPlayer oVar1;

        GameManager.instance.FUN_5DC54();
        GameManager.instance.FUN_46C0C(1, 30, 1);
        InventoryManager.DAT_B7A60[0] |= 4;
        param1.DAT_1C9 = 1;
        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        oVar1.DAT_11E |= 1;
        param1.DAT_12C |= 8;
        oVar1.DAT_12C |= 8;
        SceneManager.instance.DAT_270 = (byte)param1.tags;
        SceneManager.instance.DAT_271 = true;
        SceneManager.instance.DAT_274 = param1.cSkin;
        SceneManager.instance.DAT_278 = param1.DAT_98;
    }

    //FUN_C0A0 (ST9)
    private void FUN_C0A0(CriPlayer param1)
    {
        if ((param1.DAT_1C9 & 1) != 0 && !GameManager.instance.DAT_6D)
        {
            param1.DAT_1C9 &= 0xfe;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_C0E4 (ST9)
    private void FUN_C0E4(CriPlayer param1)
    {
        byte bVar1;
        CriCamera cVar2;
        Vector3Int local_50;
        Vector3Int local_48;
        Vector3Int local_40;
        Matrix3x3 auStack_38;

        bVar1 = param1.BDAT_1CA;
        auStack_38 = new Matrix3x3();
        Utilities.RotMatrix(ref param1.vr, ref auStack_38);
        local_50 = Utilities.ApplyMatrixSV(ref auStack_38, ref DAT_16C8C[bVar1]);
        local_40 = new Vector3Int();
        local_40.x = param1.screen.x + local_50.x;
        local_40.y = param1.screen.y + DAT_16C84[bVar1];
        local_40.z = param1.screen.z + local_50.z;
        Utilities.RotMatrix(ref SceneManager.instance.skinnedObjects[10].vr, ref auStack_38);
        local_50 = Utilities.ApplyMatrixSV(ref auStack_38, ref DAT_16C8C[bVar1 + 2]);
        local_48 = new Vector3Int();
        local_48.x = param1.screen.x + local_50.x;
        local_48.y = param1.screen.y + DAT_16C84[bVar1 + 2];
        local_48.z = param1.screen.z + local_50.z;
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
    }

    //FUN_C280 (ST9)
    private void FUN_C280(CriPlayer param1)
    {
        uint uVar1;
        CriCamera cVar2;
        Vector3Int local_50;
        Vector3Int local_48;
        Vector3Int local_40;
        Matrix3x3 auStack_38;

        uVar1 = param1.BDAT_1CA;
        cVar2 = SceneManager.instance.cCamera;
        local_48 = new Vector3Int();
        auStack_38 = new Matrix3x3();

        if (uVar1 != 0)
        {
            Utilities.RotMatrix(ref SceneManager.instance.skinnedObjects[10].vr, ref auStack_38);
            local_50 = Utilities.ApplyMatrixSV(ref auStack_38, ref DAT_16CB8[uVar1 + 2]);
            local_48 = new Vector3Int();
            local_48.x = param1.screen.x + local_50.x;
            local_48.y = param1.screen.y + DAT_16CAC[uVar1 + 2];
            local_48.z = param1.screen.z + local_50.z;
            cVar2.DAT_8B = 2;
            cVar2.DAT_36 = DAT_16CAC[uVar1 + 4];
            SceneManager.instance.FUN_264C4(1, (short)local_48.x, (short)local_48.y, (short)local_48.z);
        }

        Utilities.RotMatrix(ref param1.vr, ref auStack_38);
        local_50 = Utilities.ApplyMatrixSV(ref auStack_38, ref DAT_16CB8[uVar1]);
        local_40 = new Vector3Int();
        local_40.x = param1.screen.x + local_50.x;
        local_40.y = param1.screen.y + DAT_16CAC[uVar1];
        local_40.z = param1.screen.z + local_50.z;
        cVar2.DAT_8A = 2;
        cVar2.DAT_26 = DAT_16CAC[uVar1 + 4];
        SceneManager.instance.FUN_26504(1, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_269C8(local_48, local_40);
    }

    //FUN_C438 (ST9)
    private void FUN_C438(CriPlayer param1)
    {
        CriCamera cVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack_30;

        local_40 = new Vector3Int(0, 0, 1000);
        auStack_30 = new Matrix3x3();
        Utilities.RotMatrix(ref param1.vr, ref auStack_30);
        local_40 = Utilities.ApplyMatrixSV(ref auStack_30, ref local_40);
        local_38 = new Vector3Int();
        local_38.x = param1.screen.x + local_40.x;
        local_38.y = param1.screen.y - 2000;
        local_38.z = param1.screen.z + local_40.z;
        SceneManager.instance.FUN_264C4(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        cVar1 = SceneManager.instance.cCamera;
        cVar1.DAT_7C = new Vector3Int(0x180, 0xc00, 0x9c4);
    }

    //FUN_C8A0 (ST9)
    private void FUN_C8A0(CriParticle param1)
    {
        ushort uVar1;
        byte bVar2;

        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;

        if (param1.DAT_2F < 6)
        {
            switch (param1.DAT_2F) //0x04 (ST9)
            {
                case 0: //0xC8E8 (ST9)
                case 1:
                    uVar1 = (ushort)param1.vr.y;
                    param1.DAT_56 = 0x28;
                    param1.DAT_54 = 0x7f36;
                    param1.vr.y = 0;
                    param1.DAT_50.r = (byte)(((uint)uVar1 >> 4) & 0xf0);
                    bVar2 = (byte)uVar1;
                    param1.DAT_50.g = (byte)(bVar2 & 0xf0);
                    param1.DAT_50.b = (byte)(bVar2 << 4);
                    break;
                case 2: //FUN_C914 (ST9)
                    uVar1 = (ushort)param1.vr.y;
                    param1.DAT_56 = 0x28;
                    param1.DAT_54 = 0x7f36;
                    param1.vr.y = 0;
                    param1.DAT_50.r = (byte)(((uint)uVar1 >> 4) & 0xf0);
                    param1.DAT_50.a |= 2;
                    bVar2 = (byte)uVar1;
                    param1.DAT_50.g = (byte)(bVar2 & 0xf0);
                    param1.DAT_50.b = (byte)(bVar2 << 4);
                    break;
                case 3: //FUN_C95C (ST9)
                case 4:
                case 5:
                    param1.DAT_56 = 0x68;
                    param1.DAT_54 = 0x7f37;
                    param1.DAT_50.a |= 2;
                    break;
            }
        }

        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16CD8[param1.DAT_2F]));
        param1.flags |= 2;
        param1.DAT_3C++;
    }

    //FUN_C9C0 (ST9)
    private void FUN_C9C0(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.DAT_40.y += param1.DAT_69;
        param1.screen += param1.DAT_40;
        param1.vr.z = param1.vr.z + param1.DAT_6B & 0xfff;
        sVar1 = (sbyte)(param1.DAT_6A - 1);
        param1.DAT_6A = (byte)sVar1;

        if (sVar1 == 0)
            param1.DAT_3C++;

        iVar2 = param1.FUN_606D8();

        if (iVar2 == 1)
            param1.DAT_3C++;
    }

    //FUN_CAEC (ST9)
    private void FUN_CAEC(CriParticle param1)
    {
        ushort uVar1;

        if ((param1.DAT_2F & 0x80) != 0)
            FUN_CC64(param1);

        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(PTR_DAT_16CFC[param1.DAT_2F].DAT_00));
        uVar1 = PTR_DAT_16CFC[param1.DAT_2F].DAT_04;
        param1.flags |= 2;
        param1.DAT_76 = 30;
        param1.DAT_3C++;
        param1.DAT_54 = uVar1;
    }

    //FUN_CB80 (ST9)
    private void FUN_CB80(CriParticle param1)
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

    //FUN_CC64 (ST9)
    private void FUN_CC64(CriParticle param1)
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

    //FUN_CCC0 (ST9)
    private void FUN_CCC0(CriParticle param1)
    {
        uint uVar3;
        bool bVar6;
        int iVar6;
        bool bVar7;
        int iVar7;
        CriStatic oVar9;
        CriStatic oVar10;
        CriStatic[] local_78;
        CriStatic[] local_60;
        uint[] local_48;
        byte[] local_38;

        iVar7 = 0;
        oVar10 = null;
        iVar6 = 0;
        local_78 = new CriStatic[5];
        local_60 = new CriStatic[5];
        local_48 = new uint[] { 4, 5, 6, 7 };
        local_38 = new byte[] { 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1 };
        //...

        do
        {
            oVar9 = SceneManager.instance.staticObjects[iVar6];
            local_78[iVar6] = oVar9;
            iVar6++;
        } while (iVar6 < 5);

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
            iVar6 = 0;

            do
            {
                local_78[iVar6].DAT_78 = local_38[iVar6 + iVar7 * 5];
                local_78[iVar6].DAT_79 = (byte)iVar6;
                iVar6++;
            } while (iVar6 < 5);
        }

        iVar6 = 0;

        do
        {
            iVar7 = 0;

            do
            {
                if (local_78[iVar7].DAT_78 == iVar6)
                {
                    local_60[iVar6] = local_78[iVar7];
                    break;
                }

                iVar7++;
            } while (iVar7 < 5);

            iVar6++;
        } while (iVar6 < 5);

        iVar6 = 0;

        do
        {
            bVar7 = InventoryManager.FUN_4A87C(3, 0x3d);

            if (bVar7)
            {
                iVar6 = 3;
                break;
            }

            bVar7 = InventoryManager.FUN_4A87C(2, local_48[iVar6]);

            if (bVar7) break;

            iVar6++;
        } while (iVar6 < 4);

        if (iVar6 == 1)
        {
            uVar3 = 2;
            local_60[0] = local_60[1];
            local_60[3] = local_60[2];
            local_60[0].DAT_78 = (byte)uVar3;
            local_60[3].DAT_78 = (byte)iVar6;
            local_60[1] = local_60[3];
        }
        else
        {
            if (1 < iVar6)
            {
                if (iVar6 == 2)
                {
                    uVar3 = 3;
                    local_60[0] = local_60[2];
                }
                else
                {
                    uVar3 = 4;
                    local_60[0] = local_60[3];
                    local_60[3] = local_60[4];

                    if (iVar6 != 3)
                    {
                        param1.PTR_68[0] = SceneManager.instance.staticObjects[5];
                        goto LAB_CF98;
                    }
                }

                local_60[0].DAT_78 = (byte)uVar3;
                local_60[3].DAT_78 = (byte)iVar6;
                local_60[1] = local_60[3];
            }

            if (iVar6 != 0)
            {
                param1.PTR_68[0] = SceneManager.instance.staticObjects[5];
                goto LAB_CF98;
            }

            local_60[0].DAT_78 = 1;
            local_60[1].DAT_78 = 0;
        }

        param1.PTR_68[0] = local_60[0];
        oVar9 = local_60[0];
        oVar10 = local_60[1];
        LAB_CF98:
        param1.PTR_68[1] = oVar10;
        param1.DAT_70.x = ((oVar9.screen.x + oVar10.screen.x) / 2);
        param1.DAT_70.y = ((oVar9.screen.z + oVar10.screen.z) / 2);
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

    //FUN_D098 (ST9)
    private void FUN_D098(CriParticle param1)
    {
        byte bVar2;
        bool bVar3;
        CriStatic oVar4;
        CriStatic oVar5;
        Vector3Int local_38;
        Vector3Int local_30;
        Vector3Int local_28;
        Matrix3x3 auStack_58;

        oVar4 = (CriStatic)param1.PTR_68[0];
        oVar5 = (CriStatic)param1.PTR_68[1];
        bVar3 = InventoryManager.FUN_4A87C(3, 0x2c);

        if (bVar3 && 5 < param1.DAT_75++)
        {
            GameManager.instance.FUN_5C94C(oVar4, 145);
            InventoryManager.FUN_4A7E8(3, 0x2c, false);
            param1.DAT_75 = 0;
        }

        local_28 = new Vector3Int(0, param1.DAT_74 << 6, 0);
        auStack_58 = new Matrix3x3();
        Utilities.RotMatrix(ref local_28, ref auStack_58);
        local_38 = new Vector3Int(oVar4.VDAT_74.x, oVar4.screen.y, oVar4.VDAT_74.y);
        local_30 = Utilities.ApplyMatrixSV(ref auStack_58, ref local_38);
        oVar5.screen.x = local_30.x + param1.DAT_70.x;
        oVar5.screen.z = local_30.z + param1.DAT_70.y;
        bVar2 = (byte)(param1.DAT_74 + 1);
        param1.DAT_74 = bVar2;

        if (bVar2 == 24)
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

    //FUN_D2A8 (ST9)
    private void FUN_D2A8(CriParticle param1)
    {
        short sVar1;
        short sVar2;
        CriStatic oVar3;
        CriStatic oVar4;
        int iVar5;
        CriStatic oVar5;
        int iVar7;
        CriStatic[] local_30;

        InventoryManager.FUN_4A7E8(3, 0x2e, false);
        iVar7 = 0;
        local_30 = new CriStatic[5];

        do
        {
            oVar5 = SceneManager.instance.staticObjects[iVar7];
            local_30[iVar7] = oVar5;
            iVar7++;
        } while (iVar7 < 5);

        oVar3 = SceneManager.instance.staticObjects[3];
        oVar4 = SceneManager.instance.staticObjects[4];
        iVar5 = 0;

        do
        {
            InventoryManager.FUN_4A7E8(3, (uint)iVar5 + 0x24, false);
            iVar5++;
        } while (iVar5 < 4);

        if (oVar4.DAT_78 != 3)
            InventoryManager.FUN_4A7E8(3, oVar4.DAT_78 + 0x24U, true);

        if (GameManager.instance.DAT_9AA0 == 0x601 && oVar4.DAT_78 == 4 && InventoryManager.FUN_4A87C(0, 0xb5))
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

        iVar5 = 0;

        while (iVar5 != 4)
        {
            iVar5++;

            if (local_30[iVar5 - 1].DAT_79 != local_30[iVar5 - 1].DAT_78 || 4 < iVar5)
                goto LAB_D440;
        }

        InventoryManager.FUN_4A7E8(3, 0x2e, true);
        LAB_D440:
        InventoryManager.FUN_4A7E8(3, 0x3e, true);
        param1.DAT_3C++;
    }

    //FUN_D4B4 (ST9)
    private void FUN_D4B4(CriParticle param1)
    {
        byte bVar2;
        int iVar4;
        bool bVar4;
        int iVar6;
        CriStatic oVar6;
        byte bVar7;
        int iVar8;
        CriStatic[] local_48;
        byte[] local_30;

        iVar8 = 0;
        iVar6 = 0;
        local_48 = new CriStatic[5];
        local_30 = new byte[] { 0, 1, 2, 3, 4, 0, 3, 2, 1, 4, 4, 2, 1, 0, 3, 3, 2, 1, 0, 4, 1, 0, 3, 4, 2 };
        //...
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
            local_48[iVar6] = SceneManager.instance.staticObjects[iVar6];
            iVar6++;
        } while (iVar6 < 5);

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
            iVar4 = 0;

            do
            {
                oVar6 = local_48[iVar4];
                bVar2 = local_30[iVar4 + iVar8 * 5];
                oVar6.DAT_79 = (byte)iVar4;
                iVar4++;
                oVar6.DAT_78 = bVar2;
            } while (iVar4 < 5);
        }

        iVar4 = 0;

        do
        {
            iVar6 = 0;

            do
            {
                if (local_48[iVar6].DAT_78 == iVar4)
                {
                    param1.PTR_68[iVar4] = local_48[iVar6];
                    break;
                }

                iVar6++;
            } while (iVar6 < 5);

            iVar4++;

            if (3 < iVar4)
            {
                InventoryManager.FUN_4A7E8(3, 0x3e, false);
                InventoryManager.FUN_4A7E8(3, 0x2c, true);
                InventoryManager.FUN_4A7E8(3, 0x2d, true);
                bVar7 = (byte)(iVar8 + 1);

                if (iVar8 == 4)
                    bVar7 = 1;
                else if (2 < iVar8 + 1)
                    bVar7 = 2;

                param1.DAT_3C += bVar7;
                param1.DAT_7A = 0;
                param1.DAT_7B = 0;
                return;
            }
        } while (true);
    }

    //FUN_D78C (ST9)
    private void FUN_D78C(CriParticle param1)
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

            //if (oVar4.DAT_79 != 4) ;
                //FUN_1D988
        }

        oVar3.vr.y = oVar3.vr.y + 0x40 & 0xfff;
        sVar1 = (short)(oVar4.screen.y + 4);
        oVar4.screen.y = sVar1;

        if (-0x433 < sVar1)
        {
            oVar3 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
            oVar3.flags |= 2;
            oVar3.screen.y = -1073;
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

    //FUN_D92C (ST9)
    private void FUN_D92C(CriParticle param1)
    {
        byte bVar2;
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
                    oVar5.screen.x = DAT_16D20[param1.DAT_78 * 3];
                    oVar5.screen.y = DAT_16D20[param1.DAT_78 * 3 + 1];
                    oVar5.screen.z = DAT_16D20[param1.DAT_78 * 3 + 2];
                    oVar5.DAT_4C = null;
                } while (iVar4 < 2);
            }
        }

        bVar2 = (byte)(param1.DAT_7A + 1);
        param1.DAT_7A = bVar2;

        if (bVar2 == 24)
        {
            GameManager.instance.FUN_5C94C(oVar6, 145);

            //if (oVar6.DAT_79 != 4) ;
                //FUN_1D988
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
                FUN_DC04(param1);
        }

        sVar3 = (short)(oVar6.screen.y + 4);
        oVar6.screen.y = sVar3;

        if (-0x433 < sVar3)
        {
            oVar4 = SceneManager.instance.staticObjects[param1.DAT_78 + 9];
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

    //FUN_DC04 (ST9)
    private void FUN_DC04(CriParticle param1)
    {
        byte bVar1;

        bVar1 = param1.DAT_7B;

        if (bVar1 == 1)
            param1.flags &= 0xfffffffd;
        else
        {
            if (1 < bVar1)
            {
                if (bVar1 != 2)
                    return;

                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8010f740));
                param1.flags |= 2;
                param1.screen.x = DAT_16D20[param1.DAT_78 + 16] - 85;
                InventoryManager.FUN_4A7E8(3, 0x2d, false);
                param1.DAT_7B = 0;
                return;
            }

            if (bVar1 != 0)
                return;

            param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8010f738));
            param1.flags |= 2;
            param1.screen.x = DAT_16D20[param1.DAT_78 + 16];
        }

        param1.DAT_7B++;
    }

    //FUN_DD50 (ST9)
    private void FUN_DD50(CriParticle param1)
    {
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3f;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.vr.y = 0x400;
        param1.flags |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x801f748));
        param1.DAT_65 = 3;
        param1.DAT_4C = SceneManager.instance.cCamera;
        param1.DAT_3C++;
    }

    //FUN_DDDC (ST9)
    private void FUN_DDDC(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C++;
    }

    //FUN_DE58 (ST9)
    private void FUN_DE58(CriParticle param1)
    {
        byte bVar1;

        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7f3e;
        param1.DAT_60 = 5;
        param1.DAT_62 = 5;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x80016D68));
        bVar1 = (byte)DAT_16D6C[0];
        param1.DAT_69 = 1;
        param1.DAT_68 = bVar1;
        param1.DAT_3C++;
    }

    //FUN_DEE0 (ST9)
    private void FUN_DEE0(CriParticle param1)
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;

        sVar2 = (sbyte)(param1.DAT_68 - 1);
        param1.DAT_68 = (byte)sVar2;

        if (sVar2 == -1)
        {
            if ((DAT_16D68 + param1.DAT_69 * 8) != 0)
                param1.flags &= 0xfffffffd;
            else
            {
                param1.flags |= 2;
                param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject((uint)(DAT_16D68 + param1.DAT_69 * 8)));
            }

            bVar1 = (byte)DAT_16D6C[param1.DAT_69 * 4];
            bVar3 = (byte)(param1.DAT_69 + 1);
            param1.DAT_69 = bVar3;
            param1.DAT_68 = bVar1;

            if (2 < bVar3)
                param1.DAT_3C++;
        }
    }

    //FUN_E00C (ST9)
    private void FUN_E00C(CriParticle param1)
    {
        param1.flags |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8011c0c0));
        param1.DAT_56 = 0x37;
        param1.DAT_54 = 0x7f36;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.DAT_40.z = 0;
        param1.DAT_40.x = -param1.DAT_69;
        param1.DAT_40.y = -param1.DAT_6A;
        param1.IDAT_6C = 20;
        param1.DAT_3C = 1;
    }

    //FUN_E0A0 (ST9)
    private void FUN_E0A0(CriParticle param1)
    {
        int iVar1;

        param1.screen.y += param1.DAT_40.y;
        param1.screen.x += param1.DAT_40.x;
        param1.screen.z += param1.DAT_40.z;
        param1.vr.x = 0x180 & 0xfff;
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

    //FUN_E14C (ST9)
    private void FUN_E14C(CriParticle param1)
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

    //FUN_E214 (ST9)
    private void FUN_E214(CriParticle param1)
    {
        param1.flags |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(PTR_FUN_16D9C[param1.DAT_2F]));
        param1.DAT_56 = 0x68;
        param1.DAT_54 = 0x7eff;
        param1.DAT_3C = 1;
        param1.DAT_50.a |= 2;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
    }

    //FUN_E290 (ST9)
    private void FUN_E290(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen.x += param1.DAT_40.x;
        param1.screen.y += param1.DAT_40.z;
        param1.screen.z += param1.DAT_40.y;
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

    //FUN_E374 (ST9)
    private void FUN_E374(CriParticle param1)
    {
        param1.DAT_56 = 0x37;
        param1.DAT_54 = 0x7f34;
        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.flags |= 2;
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16DB8[param1.DAT_2F]));
        param1.DAT_3C++;
    }

    //FUN_E3EC (ST9)
    private void FUN_E3EC(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen += param1.DAT_40;

        if (0 < param1.screen.y)
        {
            param1.DAT_6A = 0;
            param1.DAT_40 = Vector3Int.zero;
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

    //FUN_E534 (ST9)
    private void FUN_E534(CriParticle param1)
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
        iVar2 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16DE0[param1.DAT_2F]));

        if (iVar2 == 1)
            param1.DAT_3C = 2;
        else
            param1.DAT_3C = 1;
    }

    //FUN_E5EC (ST9)
    private void FUN_E5EC(CriParticle param1)
    {
        int iVar1;

        param1.screen += param1.DAT_40;
        param1.DAT_40.y += param1.DAT_69;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_E6C4 (ST9)
    private void FUN_E6C4(CriParticle param1)
    {
        int iVar1;
        ushort uVar2;

        param1.DAT_62 = param1.DAT_68;
        param1.DAT_60 = param1.DAT_68;
        param1.vr.z = param1.DAT_6A << 4;
        uVar2 = 0x7f3c;
        param1.IDAT_6C = param1.DAT_6B;
        param1.DAT_56 = (ushort)(DAT_16E34[param1.DAT_2F] << 5 | 8);

        if (3 < param1.DAT_2F)
            uVar2 = 0x7f3d;

        param1.DAT_3C = 1;
        param1.DAT_54 = uVar2;
        param1.flags |= 2;
        param1.DAT_50.a |= 2;
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16E00[param1.DAT_2F]));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_E794 (ST9)
    private void FUN_E794(CriParticle param1)
    {
        int iVar1;

        param1.screen += param1.DAT_40;
        param1.DAT_40.y += param1.DAT_69;
        iVar1 = param1.FUN_606D8();

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_E878 (ST9)
    private void FUN_E878(CriParticle param1)
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
        iVar1 = param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_16E50[param1.DAT_2F]));

        if (iVar1 == 1)
            param1.DAT_3C = 2;
    }

    //FUN_E91C (ST9)
    private void FUN_E91C(CriParticle param1)
    {
        sbyte sVar1;
        int iVar2;

        param1.screen += param1.DAT_40;
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

    //FUN_E9E4 (ST9)
    private void FUN_E9E4(CriParticle param1)
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
        param1.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8012D064));
    }

    //FUN_EA64 (ST9)
    private void FUN_EA64(CriParticle param1)
    {
        param1.FUN_606D8();
    }

    //FUN_EB14 (ST9)
    private void FUN_EB14(CriInteract param1)
    {
        sbyte sVar1;
        CriPlayer oVar3;
        byte bVar4;
        uint uVar5;
        short sVar6;
        uint uVar7;

        oVar3 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        sVar1 = (sbyte)oVar3.DAT_1D7;
        param1.BDAT_08 = (byte)sVar1;

        if ((oVar3.DAT_1C0 & 8) != 0)
        {
            bVar4 = (byte)(sVar1 - 1);
            param1.BDAT_08 = bVar4;

            if (bVar4 << 0x18 < 0)
                param1.BDAT_08 = 0;
        }

        if (oVar3.DAT_3D == 5)
        {
            if (param1.BDAT_08 == 0)
                uVar5 = (uint)(oVar3.frameNum * 0x16);
            else
                uVar5 = (uint)(oVar3.frameNum << 5);
        }
        else
        {
            if (oVar3.DAT_3D != 1)
            {
                param1.BDAT_16 = 0;
                goto LAB_EC04;
            }

            if (param1.BDAT_08 == 0)
                uVar5 = (uint)(oVar3.frameNum * 0x16);
            else
                uVar5 = (uint)(oVar3.frameNum << 5);
        }

        uVar7 = (uint)(oVar3.frameCount + 1 & 0xff);

        if (uVar7 == 0)
            return; //trap(0x1c00)

        param1.BDAT_16 = (byte)(uVar5 / uVar7);
        LAB_EC04:
        oVar3.DAT_3C = 4;
        oVar3.DAT_3D = 0;
        oVar3.DAT_3E = 0;
        oVar3.DAT_3F = 0;
        oVar3.DAT_152 = 2;
        oVar3.DAT_40.z = 0;
        oVar3.DAT_140 |= 0x8000;
        bVar4 = oVar3.DAT_174;
        oVar3.DAT_12C |= 0x10;
        oVar3.DAT_174 = (byte)(bVar4 & 0x7f);
        InventoryManager.FUN_4A7E8(1, 2, true);
        InventoryManager.FUN_4A7E8(2, 0x12, true);
        param1.DAT_0A = param1.DAT_07;
        param1.DAT_07 = 0x80;
        param1.DAT_03 = (sbyte)(param1.DAT_02 + 1);

        if (param1.DAT_02 == 0)
            sVar6 = (short)(oVar3.screen.y + param1.DAT_0A * -0x1a9);
        else
            sVar6 = (short)(oVar3.screen.y + param1.DAT_0A * 0x1a9);

        param1.DAT_0C = sVar6;
    }

    //FUN_ECF8 (ST9)
    private void FUN_ECF8(CriInteract param1)
    {
        byte bVar1;
        short sVar2;
        ushort uVar3;
        CriPlayer oVar4;

        oVar4 = (CriPlayer)SceneManager.instance.skinnedObjects[12];
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

    //FUN_EDB0 (ST9)
    private void FUN_EDB0(CriInteract param1)
    {
        short sVar1;
        CriSkinned oVar2;
        short sVar3;
        Matrix3x3 auStack_38;
        Vector3Int local_18;

        oVar2 = SceneManager.instance.skinnedObjects[10];
        auStack_38 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack_38);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018DA38), 1, param1.BDAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack_38, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -19;
        }
        else
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018E8B8), 1, param1.BDAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack_38, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = -13;
        }

        param1.SDAT_10 = sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_EF40 (ST9)
    private void FUN_EF40(CriInteract param1)
    {
        short sVar1;
        CriSkinned oVar2;
        short sVar3;
        Matrix3x3 auStack_38;
        Vector3Int local_18;

        oVar2 = SceneManager.instance.skinnedObjects[10];
        auStack_38 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref auStack_38);

        if (param1.BDAT_08 == 0)
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018E178), 1, param1.BDAT_16, 4);
            local_18 = new Vector3Int(0, 0, 28);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack_38, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 19;
        }
        else
        {
            oVar2.FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x8018F340), 1, param1.BDAT_16, 6);
            local_18 = new Vector3Int(0, 0, 19);
            param1.VDAT_0E = Utilities.ApplyMatrixSV(ref auStack_38, ref local_18);
            sVar1 = param1.DAT_0A;
            sVar3 = 13;
        }

        param1.SDAT_10 = sVar3;
        param1.DAT_0A = (short)(sVar1 * 0x1a9);
        param1.DAT_03 += 4;
    }

    //FUN_F1B0 (ST9)
    private void FUN_F1B0(CriInteract param1)
    {
        short sVar1;
        bool bVar2;
        int iVar2;
        int iVar3;
        CriStatic oVar3;
        bool bVar4;
        int iVar4;
        CriCamera cVar4;
        int iVar6;
        CriStatic oVar6;

        SceneManager.instance.FUN_26EBC(2, 0);
        SceneManager.instance.FUN_264C4(0, 0, -38, -750);
        SceneManager.instance.FUN_26504(0, 0, -0x3f01, 0x256c);
        oVar6 = SceneManager.instance.staticObjects[0];
        iVar3 = 1;
        oVar6.DAT_48 = 0;
        cVar4 = SceneManager.instance.cCamera;
        cVar4.DAT_36 = 200;
        oVar6.screen.z = 0xba4;
        oVar6.screen.x = 0;
        DAT_171EC[0] = 9;

        do
        {
            SceneManager.instance.staticObjects[iVar3].DAT_48 = 0;
            iVar3++;
        } while (iVar3 < 8);

        iVar4 = 0;
        iVar6 = 0;

        do
        {
            bVar2 = InventoryManager.FUN_4A87C(3, (uint)iVar4 + 0x2c);

            if (!bVar2)
                DAT_171CC[iVar4] = -1;
            else
            {
                oVar3 = SceneManager.instance.staticObjects[iVar6 + 1];
                iVar2 = iVar4;

                if (iVar4 < 0)
                    iVar2 = iVar4 + 3;

                sVar1 = (short)(iVar2 >> 2);
                oVar3.screen.x = sVar1 * -2400 + 4800;
                oVar3.screen.y = -2200;
                oVar3.screen.z = ((short)iVar4 + sVar1 * -4) * -4000 + 3000;
                DAT_171CC[iVar4] = (sbyte)iVar6;
                iVar6++;
            }

            iVar4++;
        } while (iVar4 < 20);

        if (param1.DAT_02 == 0)
        {
            DAT_171CC[3] = -0x10;
            DAT_171CC[7] = -0x10;
            DAT_171CC[11] = -0x10;
            DAT_171CC[15] = -0x10;
            DAT_171CC[19] = -0x10;
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
            SceneManager.instance.staticObjects[iVar6 + 1].screen = new Vector3Int(0, -0x187e, 3000);
            param1.DAT_19 = 1;
            param1.DAT_1A = (byte)(iVar6 + 1);
        }

        param1.DAT_03++;
    }

    //FUN_F3F0 (ST9)
    private void FUN_F3F0(CriInteract param1)
    {
        byte bVar1;
        sbyte sVar2;
        int iVar3;
        sbyte[] aVar3;
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

                goto LAB_F8A4;
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
                        uVar4 = (byte)param1.DAT_0B + 1U;

                        if ((int)uVar4 < (int)uVar5)
                        {
                            do
                            {
                                if (((ushort)param1.SDAT_10 >> (int)(uVar4 & 31) & 1) == 0)
                                {
                                    iVar7 = 147;
                                    param1.DAT_0B = (sbyte)uVar4;
                                    param1.DAT_12 = 0;
                                    param1.DAT_13 = 0;
                                    param1.DAT_03++;
                                    goto LAB_F8A4;
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
                            if (((ushort)param1.SDAT_10 >> (int)(uVar5 & 31) & 1) == 0)
                            {
                                iVar7 = 147;
                                param1.DAT_0B = (sbyte)uVar5;
                                param1.DAT_12 = 0;
                                param1.DAT_13 = 0;
                                param1.DAT_03++;
                                goto LAB_F8A4;
                            }

                            uVar5--;
                        } while (-1 < (int)uVar5);
                    }
                }

                if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0 && param1.BDAT_09 < param1.BDAT_0A)
                {
                    if (param1.DAT_02 == 0)
                        aVar3 = DAT_16EB8;
                    else
                        aVar3 = DAT_16EC0;

                    DAT_171EC[param1.BDAT_09 * 4] = aVar3[(byte)param1.DAT_0B];
                    DAT_171EC[param1.BDAT_09 * 4 + 1] = param1.DAT_0B;
                    param1.DAT_15 = 0;
                    param1.DAT_14 = 0;
                    param1.BDAT_09++;
                    param1.SDAT_10 |= (short)(1 << (param1.DAT_0B & 15));
                    DAT_171EC[param1.BDAT_09 * 4] = 9;

                    if ((uint)(byte)param1.BDAT_0A <= param1.BDAT_09)
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
                            uVar4 = (uint)((ushort)param1.SDAT_10 >> (int)(uVar5 & 31));
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
                        param1.SDAT_10 &= (short)~(1 << (DAT_171EC[bVar1 * 4 + 1] & 15));
                        DAT_171EC[param1.BDAT_09 * 4] = 9;
                        goto LAB_F8A4;
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
            DAT_171EC[0] = 9;
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
        param1.BDAT_08 &= 3;
        LAB_F8A4:
        GameManager.instance.FUN_5C94C(null, iVar7);
    }

    //FUN_F8BC (ST9)
    private void FUN_F8BC(CriInteract param1)
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

    //FUN_F900 (ST9)
    private void FUN_F900(CriInteract param1)
    {
        byte bVar1;
        byte bVar2;
        int iVar2;
        sbyte sVar2;
        sbyte sVar3;
        int iVar3;
        uint uVar3;
        CriCamera cVar3;
        int iVar4;
        sbyte sVar4;
        bool bVar4;
        sbyte sVar5;
        uint uVar5;
        int iVar5;
        int iVar6;
        CriStatic oVar7;
        short sVar8;

        if (DAT_171EC[param1.DAT_17 * 4] < 12)
        {
            switch (DAT_171EC[param1.DAT_17 * 4]) //0x5C (ST9)
            {
                case 0: //FUN_F960 (ST9)
                    iVar6 = (sbyte)param1.DAT_18;
                    iVar4 = iVar6;

                    if (iVar6 < 0)
                        iVar4 = iVar6 + 3;

                    if ((iVar6 + (iVar4 >> 2) * -4) * 0x1000000 >> 0x18 == 1)
                    {
                        DAT_171EC[param1.DAT_17 * 4] = 2;

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

                            if (param1.DAT_19 == 0) goto LAB_10E94;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            SceneManager.instance.staticObjects[bVar1].vr.x += DAT_16EF0[bVar2];
                            LAB_10E94:
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
                                break;
                            }

                            if (param1.DAT_19 == 0) goto LAB_10E94;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            SceneManager.instance.staticObjects[bVar1].vr.x += DAT_16EF0[bVar2];
                            LAB_10E94:
                            param1.DAT_1B++;
                            return;
                        }
                    }
                    
                    param1.DAT_0D = (byte)(bVar1 + 1);
                    SceneManager.instance.staticObjects[0].screen.z += 100;

                    if (param1.DAT_19 != 0)
                        SceneManager.instance.staticObjects[param1.DAT_1A].screen.z += 100;

                    break;
                case 1: //FUN_FA80 (ST9)
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_16EF0[param1.DAT_1B];

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
                        DAT_171EC[param1.DAT_17 * 4] = 11;

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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_16EF0[param1.DAT_1B];

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

                    LAB_10DA0:
                    param1.DAT_0D = (byte)(bVar1 + 1);
                    SceneManager.instance.staticObjects[0].screen.x -= 60;

                    if (param1.DAT_19 != 0)
                        SceneManager.instance.staticObjects[param1.DAT_1A].screen.x -= 60;

                    break;
                case 2: //FUN_FB48 (ST9)
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_16EF0[param1.DAT_1B];

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
                case 3: //FUN_FC88 (ST9)
                    if (param1.BDAT_0C < 5)
                    {
                        switch (param1.BDAT_0C) //0x8C (ST9)
                        {
                            case 0: //FUN_FCB8 (ST9)
                                if (param1.DAT_19 == 0 && DAT_171EC[(sbyte)param1.DAT_18] != -1)
                                {
                                    if (param1.DAT_0D == 0)
                                        GameManager.instance.FUN_5C94C(null, 153);

                                    bVar1 = param1.DAT_0D;
                                    param1.DAT_0D = (byte)(bVar1 + 1);

                                    if (bVar1 < 30)
                                        SceneManager.instance.staticObjects[0].screen.y += 110;
                                    else
                                    {
                                        sVar2 = DAT_171EC[(sbyte)param1.DAT_18];
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
                            case 1: //FUN_FD5C (ST9)
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
                            case 2: //FUN_FD80 (ST9)
                                bVar1 = param1.DAT_0D;
                                param1.DAT_0D = (byte)(bVar1 + 1);

                                if (bVar1 < 7)
                                    SceneManager.instance.staticObjects[0].screen.x += 110;
                                else
                                {
                                    param1.DAT_0D = 0;
                                    param1.BDAT_0C++;
                                }

                                break;
                            case 3: //FUN_FDBC (ST9)
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
                            case 4: //FUN_FE08 (ST9)
                                param1.DAT_1B = 0;

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
                                        SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_16EDC[param1.DAT_1B] >> 1;
                                        param1.DAT_1B++;
                                        return;
                                    }

                                    param1.DAT_1B = 0;
                                    param1.BDAT_0C = 0;
                                    param1.DAT_17++;
                                    InventoryManager.FUN_4A7E8(3, 0x2b, true);
                                    param1.DAT_19 = 1;
                                    DAT_171CC[(sbyte)param1.DAT_18] = -1;
                                    InventoryManager.FUN_4A7E8(3, (uint)(sbyte)param1.DAT_18 + 0x2c, false);
                                }

                                break;

                        }
                    }

                    break;
                case 4: //FUN_FF40 (ST9)
                    if ((sbyte)param1.DAT_18 < 8)
                    {
                        DAT_171EC[(byte)param1.DAT_17 * 4] = 5;

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
                                sVar4 = param1.DAT_17;
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_1B = 0;
                                sVar3 = (sbyte)(param1.DAT_18 - 4);
                                param1.DAT_18 = (byte)sVar3;
                                param1.DAT_17 = (sbyte)(sVar4 + 1);
                                break;
                            }

                            if (param1.DAT_19 == 0) goto LAB_10E94;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            SceneManager.instance.staticObjects[bVar1].vr.z += DAT_16EDC[bVar2];
                            LAB_10E94:
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
                                sVar4 = param1.DAT_17;
                                param1.BDAT_0C = 0;
                                param1.DAT_0D = 0;
                                param1.DAT_1B = 0;
                                sVar3 = (sbyte)(param1.DAT_18 - 8);
                                param1.DAT_18 = (byte)sVar3;
                                param1.DAT_17 = (sbyte)(sVar4 + 1);
                                break;
                            }

                            if (param1.DAT_19 == 0) goto LAB_10E94;

                            bVar1 = param1.DAT_1A;
                            bVar2 = param1.DAT_1B;
                            SceneManager.instance.staticObjects[bVar1].vr.z += DAT_16EDC[bVar2];
                            LAB_10E94:
                            param1.DAT_1B++;
                            return;
                        }
                    }

                    param1.DAT_0D = (byte)(bVar1 + 1);
                    SceneManager.instance.staticObjects[0].screen.x += 60;

                    if (param1.DAT_19 != 0)
                        SceneManager.instance.staticObjects[param1.DAT_1A].screen.x += 60;

                    break;
                case 5: //FUN_10040 (ST9)
                    if ((sbyte)param1.DAT_18 < 4)
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
                            SceneManager.instance.staticObjects[0].screen.x += 60;

                            if (param1.DAT_19 != 0)
                                SceneManager.instance.staticObjects[param1.DAT_1A].screen.x += 60;
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += DAT_16EDC[param1.DAT_1B];

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

                    return;
                case 6: //FUN_10164 (ST9)
                    iVar5 = (sbyte)param1.DAT_18;
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
                            goto LAB_101D8;
                        }

                        DAT_171EC[param1.DAT_17 * 4] = 10;

                        if (param1.DAT_02 == 0)
                        {
                            iVar5 = (sbyte)param1.DAT_18;
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
                            iVar5 = (sbyte)param1.DAT_18;
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_16EDC[param1.DAT_1B];

                                param1.DAT_1B++;
                                return;
                            }

                            sVar4 = param1.DAT_17;
                            param1.BDAT_0C = 0;
                            param1.DAT_0D = 0;
                            param1.DAT_1B = 0;
                            sVar2 = (sbyte)(param1.DAT_18 + 1);
                            param1.DAT_18 = (byte)sVar2;
                            param1.DAT_17 = (sbyte)(sVar4 + 1);
                            break;
                        }

                        goto LAB_10C28;
                    }

                    LAB_101D8:
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
                                SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_16EDC[param1.DAT_1B];

                            param1.DAT_1B++;
                            return;
                        }

                        sVar4 = param1.DAT_17;
                        param1.BDAT_0C = 0;
                        param1.DAT_0D = 0;
                        param1.DAT_1B = 0;
                        sVar2 = (sbyte)(param1.DAT_18 + 2);
                        param1.DAT_18 = (byte)sVar2;
                        param1.DAT_17 = (sbyte)(sVar4 + 1);
                        break;
                    }

                    LAB_10C28:
                    param1.DAT_0D = (byte)(bVar1 + 1);
                    SceneManager.instance.staticObjects[0].screen.z -= 100;
                    
                    if (param1.DAT_19 != 0)
                        SceneManager.instance.staticObjects[param1.DAT_1A].screen.z -= 100;

                    break;
                case 7: //FUN_10270 (ST9)
                    if (param1.BDAT_0C < 5)
                    {
                        switch (param1.BDAT_0C) //0xA4 (ST9)
                        {
                            case 0: //FUN_102A0 (ST9)
                                if (param1.DAT_19 == 0 || DAT_171EC[param1.DAT_18] != -1)
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
                            case 1: //FUN_1039C (ST9)
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
                            case 2: //FUN_103D8 (ST9)
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
                            case 3: //FUN_10408 (ST9)
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
                            case 4: //FUN_10468 (ST9)
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
                                    DAT_171EC[param1.DAT_18] = (sbyte)(param1.DAT_1A - 1);
                                    InventoryManager.FUN_4A7E8(3, (uint)(sbyte)param1.DAT_18 + 0x2c, true);
                                    param1.DAT_1A = 0xff;
                                }

                                break;
                        }
                    }

                    break;
                case 8: //FUN_10548 (ST9)
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_16EDC[param1.DAT_1B];

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
                        DAT_171EC[param1.DAT_17 * 4] = 6;
                        iVar5 = param1.DAT_18;
                        iVar4 = iVar5;

                        if (iVar5 < 0)
                            iVar4 = iVar5 + 3;

                        if ((iVar5 + (iVar4 >> 2) * -4) * 0x1000000 >> 0x18 == 2)
                        {
                            if (param1.DAT_02 != 0)
                            {
                                DAT_171EC[param1.DAT_17 * 4] = 10;

                                if (param1.DAT_02 == 0)
                                {
                                    iVar5 = (sbyte)param1.DAT_18;
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
                                    iVar5 = (sbyte)param1.DAT_18;
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
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_16EDC[param1.DAT_1B];

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

                                goto LAB_10C28;
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += DAT_16EDC[param1.DAT_1B];

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

                    goto LAB_10C28;
                case 9: //FUN_10610 (ST9)
                    if (param1.DAT_18 != 8)
                    {
                        oVar7 = SceneManager.instance.staticObjects[0];
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C = 0x80;
                            GameManager.instance.FUN_5C94C(null, 151);

                            if (oVar7.screen.x < 0)
                                bVar1 = (byte)(param1.BDAT_0C | 2);
                            else
                                bVar1 = (byte)(param1.BDAT_0C | 1);

                            param1.BDAT_0C = bVar1;

                            if (oVar7.screen.x == 0)
                                param1.BDAT_0C = 0x80;

                            if (oVar7.screen.z < 0xba4)
                                bVar1 = (byte)(param1.BDAT_0C | 4);
                            else
                                bVar1 = (byte)(param1.BDAT_0C | 8);

                            param1.BDAT_0C = bVar1;

                            if (oVar7.screen.z == 0xba4)
                                param1.BDAT_0C &= 0x83;
                        }
                        else
                        {
                            if ((param1.BDAT_0C & 1) != 0)
                            {
                                if (oVar7.screen.x < 1)
                                    oVar7.screen.x = 0;
                                else
                                    oVar7.screen.x -= 60;

                                if (param1.DAT_19 != 0)
                                    SceneManager.instance.staticObjects[param1.DAT_1A].screen.x -= 60;
                            }

                            if ((param1.BDAT_0C & 2) != 0)
                            {
                                if (oVar7.screen.x < 0)
                                    oVar7.screen.x += 60;
                                else
                                    oVar7.screen.x = 0;
                            }

                            if (param1.DAT_19 != 0)
                                SceneManager.instance.staticObjects[param1.DAT_1A].screen.x = oVar7.screen.x;

                            if ((param1.BDAT_0C & 4) != 0)
                            {
                                sVar8 = (short)(oVar7.screen.z + 100);

                                if (0xba3 < oVar7.screen.z)
                                    sVar8 = 0xba4;

                                oVar7.screen.z = sVar8;
                            }

                            if (param1.DAT_19 != 0)
                                SceneManager.instance.staticObjects[param1.DAT_1A].screen.z = oVar7.screen.z + 20;

                            if (oVar7.screen.x == 0 && oVar7.screen.z == 0xba4)
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
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += (byte)DAT_16EF0[param1.DAT_1B];

                                        if ((param1.BDAT_0C & 2) != 0)
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += (byte)DAT_16EDC[param1.DAT_1B];

                                        if ((param1.BDAT_0C & 4) != 0)
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += (byte)DAT_16EF0[param1.DAT_1B];

                                        if ((param1.BDAT_0C & 8) != 0)
                                            SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += (byte)DAT_16EDC[param1.DAT_1B];
                                    }

                                    param1.DAT_1B++;
                                    return;
                                }

                                goto LAB_10A30;
                            }
                        }

                        break;
                    }

                    LAB_10A30:
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
                    param1.DAT_16 = 0;
                    param1.DAT_17 = 0;
                    DAT_171EC[0] = 9;
                    param1.DAT_18 = 8;
                    param1.DAT_03 = 1;
                    cVar3 = SceneManager.instance.cCamera;
                    cVar3.DAT_36 = 200;
                    cVar3.DAT_3E = 0;
                    cVar3.DAT_50 = 0;
                    cVar3.DAT_52 = 0;
                    SceneManager.instance.FUN_264C4(400, 0, -38, -750);
                    uVar5 = 0;
                    cVar3.DAT_72 |= 1;
                    cVar3.DAT_73 = 1;

                    do
                    {
                        uVar3 = 0;

                        do
                        {
                            DAT_1721C[uVar3] = 0;
                            uVar3++;
                        } while (uVar3 < 20);

                        bVar4 = FUN_10F1C(uVar5);

                        if (bVar4)
                            FUN_10F48((int)uVar5, 10);

                        if (DAT_1721C[10] != 0 || DAT_1721C[11] != 0 || DAT_1721C[12] != 0 || DAT_1721C[13] != 0)
                        {
                            InventoryManager.FUN_4A7E8(2, 9, true);
                            return;
                        }

                        InventoryManager.FUN_4A7E8(2, 9, false);
                        uVar5++;
                    } while (uVar5 < 4);

                    return;
                case 10: //FUN_10B70 (ST9)
                    if (param1.DAT_02 == 0)
                    {
                        iVar3 = (sbyte)param1.DAT_18;
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
                        iVar3 = (sbyte)param1.DAT_18;
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

                    if (bVar1 < 40) goto LAB_10C28;
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
                                SceneManager.instance.staticObjects[param1.DAT_1A].vr.x += (byte)DAT_16EDC[param1.DAT_1B];

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
                case 11: //FUN_10D3C (ST9)
                    if ((sbyte)param1.DAT_18 < 16)
                    {
                        if (param1.BDAT_0C == 0)
                        {
                            param1.BDAT_0C++;
                            GameManager.instance.FUN_5C94C(null, 151);
                        }

                        bVar1 = param1.DAT_0D;

                        if (bVar1 < 40) goto LAB_10DA0;
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
                                    SceneManager.instance.staticObjects[param1.DAT_1A].vr.z += (byte)DAT_16EF0[param1.DAT_1B];

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

        iVar4 = SceneManager.instance.staticObjects[0].screen.y;

        if (SceneManager.instance.staticObjects[0].screen.z == 0xba4 && -0x16a8 < iVar4)
            iVar4 = -0x16a8;

        SceneManager.instance.FUN_264C4(50, (short)SceneManager.instance.staticObjects[0].screen.x, (short)iVar4, (short)SceneManager.instance.staticObjects[0].screen.z);
    }

    //FUN_10F1C (ST9)
    private bool FUN_10F1C(uint param1)
    {
        if (DAT_171CC[param1] != -1)
            return false;

        return param1 < 20;
    }

    //FUN_10F48 (ST9)
    private void FUN_10F48(int param1, int param2)
    {
        bool bVar1;

        if (DAT_1721C[param1] <= param2)
        {
            DAT_1721C[param1] = (byte)param2;
            param2--;
            bVar1 = FUN_10F1C((uint)param1 - 1);

            if (bVar1)
                FUN_10F48(param1 - 1, param2);

            bVar1 = FUN_10F1C((uint)param1 + 4);

            if (bVar1)
                FUN_10F48(param1 + 4, param2);

            bVar1 = FUN_10F1C((uint)param1 + 1);

            if (bVar1)
                FUN_10F48(param1 + 1, param2);

            bVar1 = FUN_10F1C((uint)param1 - 4);

            if (bVar1)
                FUN_10F48(param1 - 4, param2);
        }
    }

    //FUN_11A9C (ST9)
    private void FUN_11A9C(CriInteract param1)
    {

    }

    //FUN_1AF8 (ST9)
    public static void FUN_1AF8(CriPlayer param1)
    {
        instance.PTR_FUN_160B4[param1.DAT_2F - 2](param1);

        if ((param1.UDAT_1D2 & 0x8000) != 0)
            instance.FUN_20C(param1);
    }

    //FUN_3ABC (ST9)
    public static void FUN_3ABC(CriPlayer param1)
    {
        short sVar1;
        sbyte sVar2;
        byte bVar3;
        uint uVar5;
        bool bVar6;
        CriSkinned oVar6;
        Vector3Int vVar7;
        CriStatic auStack_18;
        byte auStack_14;

        Utilities.RotMatrix(ref param1.vr, ref param1.cTransform.rotation);
        oVar6 = SceneManager.instance.skinnedObjects[10];

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
                goto LAB_3CE4;
            }
        }

        if (param1.DAT_3C == 1 && param1.DAT_3D == 1)
            vVar7 = (Vector3Int)param1.VDAT_1E4;
        else
            vVar7 = oVar6.screen;

        sVar2 = GameManager.instance.FUN_774CC(param1, vVar7);
        param1.DAT_1C2 = (byte)sVar2;

        if (param1.DAT_1C2 == 0xff)
        {
            GameManager.instance.FUN_77238((byte)param1.DAT_48, ref param1.VDAT_1E4);
            sVar2 = GameManager.instance.FUN_774CC(param1, (Vector3Int)param1.VDAT_1E4);
            param1.DAT_1C2 = (byte)sVar2;
        }

        param1.DAT_34 = param1.screen;
        uVar5 = Utilities.FUN_631AC(param1.screen, oVar6.screen);

        if (param1.DAT_177 != 0)
            param1.DAT_177--;

        instance.FUN_C0A0(param1);
        instance.FUN_B6A8(param1);

        if (0 < (short)param1.UDAT_1D2 && --param1.UDAT_1D2 << 0x10 < 0)
            param1.UDAT_1D2 = 0;

        instance.FUN_9444(param1);
        param1.FUN_659D0();

        if ((param1.BDAT_1C0 & 1) == 0 && (param1.DAT_3C != 1 || param1.DAT_3D != 1))
            param1.BDAT_1C0 |= 1;

        instance.PTR_FUN_164B0[param1.DAT_3C](param1);
        param1.FUN_62F3C(ref param1.DAT_40);
        param1.FUN_65A28();
        bVar6 = SceneManager.instance.FUN_80030(param1, param1.DAT_18D, (byte)param1.DAT_12E);

        if (!bVar6 || (param1.DAT_128 & 0x400) == 0)
            bVar3 = (byte)(param1.DAT_162 & 0xfe);
        else
            bVar3 = (byte)(param1.DAT_162 | 1);

        param1.DAT_162 = bVar3;
        auStack_14 = 0;
        auStack_18 = null;
        GameManager.instance.FUN_82EFC(param1, ref auStack_18, ref auStack_14);
        instance.FUN_3F78(param1);
        LAB_3CE4:
        param1.FUN_6449C(param1.DAT_140);
        sVar1 = (short)param1.screen.y;
        param1.DAT_48 = (sbyte)((sVar1 >> 15) - ((sbyte)(sVar1 / 0x1a9) + (sbyte)(sVar1 >> 7)));
        bVar6 = SceneManager.instance.FUN_80A14(param1);

        if (!bVar6)
        {
            param1.DAT_1CC = 0;
            bVar3 = (byte)(param1.DAT_162 & 0xfd);
        }
        else
        {
            param1.DAT_1CD = 0;
            bVar3 = (byte)(param1.DAT_162 | 2);
        }

        param1.DAT_162 = bVar3;

        if ((param1.DAT_3C == 4 && (param1.DAT_3C != 4 || param1.DAT_3D != 3)) || param1.DAT_3C == 6)
            param1.flags &= 0xfffffffb;
        else
            param1.flags |= 4;
    }

    //FUN_CC84 (ST9)
    public static void FUN_CC84(CriParticle param1)
    {
        instance.PTR_FUN_16D10[param1.DAT_3C](param1);
    }

    //FUN_D478 (ST9)
    public static void FUN_D478(CriParticle param1)
    {
        instance.PTR_FUN_16D4C[param1.DAT_3C](param1);
    }

    //FUN_DD14 (ST9)
    public static void FUN_DD14(CriParticle param1)
    {
        instance.PTR_FUN_16D5C[param1.DAT_3C](param1);
    }
    
    //FUN_DE1C (ST9)
    public static void FUN_DE1C(CriParticle param1)
    {
        instance.PTR_FUN_16D80[param1.DAT_3C](param1);
    }

    //FUN_C864 (ST9)
    public static void FUN_C864(CriParticle param1)
    {
        instance.PTR_FUN_16CF0[param1.DAT_3C](param1);
    }

    //FUN_CA8C (ST9)
    public static void FUN_CA8C(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_16D04[param1.DAT_3C](param1);
    }

    //FUN_DFD0 (ST9)
    public static void FUN_DFD0(CriParticle param1)
    {
        instance.PTR_FUN_16D8C[param1.DAT_3C](param1);
    }

    //FUN_E1D8 (ST9)
    public static void FUN_E1D8(CriParticle param1)
    {
        instance.PTR_FUN_16DAC[param1.DAT_3C](param1);
    }

    //FUN_E338 (ST9)
    public static void FUN_E338(CriParticle param1)
    {
        instance.PTR_FUN_16DD4[param1.DAT_3C](param1);
    }

    //FUN_E4C4 (ST9)
    public static void FUN_E4C4(CriParticle param1)
    {
        int iVar1;

        instance.PTR_FUN_16DF4[param1.DAT_3C](param1);
        iVar1 = param1.IDAT_6C - 1;

        if (param1.IDAT_6C != 0xff)
        {
            param1.IDAT_6C = iVar1;

            if (iVar1 == -1)
                param1.FUN_451A4();
        }
    }

    //FUN_E664 (ST9)
    public static void FUN_E664(CriParticle param1)
    {
        int iVar1;

        instance.PTR_FUN_16E44[param1.DAT_3C](param1);
        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();
    }

    //FUN_E80C (ST9)
    public static void FUN_E80C(CriParticle param1)
    {
        int iVar1;

        iVar1 = param1.IDAT_6C - 1;
        param1.IDAT_6C = iVar1;

        if (iVar1 == -1)
            param1.FUN_451A4();

        instance.PTR_FUN_16E84[param1.DAT_3C](param1);
    }

    //FUN_EA84 (ST9)
    public static void FUN_EA84(CriParticle param1)
    {
        instance.PTR_FUN_16E90[param1.DAT_3C](param1);
    }

    //FUN_EAC0 (ST9)
    public static void FUN_EAC0(CriInteract param1)
    {
        ((CriPlayer)SceneManager.instance.skinnedObjects[10]).DAT_1C0 &= 0xfffffffe;
        instance.PTR_FUN_16E9C[param1.DAT_03](param1);
    }

    //FUN_F0D0 (ST9)
    public static void FUN_F0D0(CriInteract param1)
    {
        instance.PTR_FUN_16EC8[param1.DAT_03](param1);
        //...
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
