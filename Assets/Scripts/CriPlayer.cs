using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriPlayer : CriSkinned
{
    public uint DAT_1C0; //0x1C0
    public byte BDAT_1C0; //0x1C0
    public sbyte DAT_1C1; //0x1C1
    public byte DAT_1C2; //0x1C2
    public sbyte DAT_1C3; //0x1C3
    public int IDAT_1C4; //0x1C4
    public sbyte DAT_1C4; //0x1C4
    public byte DAT_1C5; //0x1C5
    public byte DAT_1C6; //0x1C6
    public sbyte DAT_1C7; //0x1C7
    public sbyte DAT_1C8; //0x1C8
    public int IDAT_1C8; //0x1C8
    public CriInteract PDAT_1C8; //0x1C8
    public byte DAT_1C9; //0x1C9
    public byte BDAT_1CA; //0x1CA
    public short DAT_1CA; //0x1CA
    public byte DAT_1CB; //0x1CB
    public CriObject PTR_1CC; //0x1CC
    public short SDAT_1CC; //0x1CC
    public byte DAT_1CC; //0x1CC
    public byte DAT_1CD; //0x1CD
    public byte DAT_1CE; //0x1CE
    public byte DAT_1CF; //0x1CF
    public uint DAT_1D0; //0x1D0
    public byte BDAT_1D0; //0x1D0
    public byte DAT_1D1; //0x1D1
    public ushort UDAT_1D2; //0x1D2
    public byte DAT_1D2; //0x1D2
    public byte DAT_1D3; //0x1D3
    public short SDAT_1D4; //0x1D4
    public Vector3Int[] PDAT_1D4; //0x1D4
    public byte DAT_1D4; //0x1D4
    public byte DAT_1D5; //0x1D5
    public short SDAT_1D6; //0x1D6
    public byte DAT_1D6; //0x1D6
    public byte DAT_1D7; //0x1D7
    public sbyte BDAT_1D8; //0x1D8
    public short SDAT_1D8; //0x1D8
    public CriStatic DAT_1D8; //0x1D8
    public byte DAT_1D9; //0x1D9
    public ushort UDAT_1DA; //0x1DA
    public byte DAT_1DA; //0x1DA
    public sbyte DAT_1DB; //0x1DB
    public CriPlayer DAT_1DC; //0x1DC
    public uint UDAT_1DC; //0x1DC
    public short SDAT_1DC; //0x1DC
    public byte BDAT_1DC; //0x1DC
    public byte DAT_1DD; //0x1DD
    public short SDAT_1DE; //0x1DE
    public byte DAT_1DE; //0x1DE
    public byte DAT_1DF; //0x1DF
    public TodScriptableObject[] DAT_1E0; //0x1E0
    public ushort UDAT_1E0; //0x1E0
    public byte BDAT_1E2; //0x1E2
    public ushort DAT_1E2; //0x1E2
    public byte DAT_1E3; //0x1E3
    public Vector4Int VDAT_1E4; //0x1E4
    public ushort UDAT_1E4; //0x1E4
    public byte DAT_1E4; //0x1E4
    public byte DAT_1E5; //0x1E5
    public ushort DAT_1E6; //0x1E6
    public sbyte DAT_1E7; //0x1E7
    public byte BDAT_1E8; //0x1E8
    public ushort DAT_1E8; //0x1E8
    public short DAT_1EA; //0x1EA
    public byte DAT_1EB; //0x1EB
    public byte BDAT_1EC; //0x1EC
    public short DAT_1EC; //0x1EC
    public byte DAT_1ED; //0x1ED
    public short DAT_1EE; //0x1EE
    public byte DAT_1EF; //0x1EF
    public CriPlayer DAT_1F0; //0x1F0
    public Vector2Int V2_1F0; //0x1F0
    public byte DAT_1F1; //0x1F1
    public byte DAT_1F2; //0x1F2
    public bool DAT_1F3; //0x1F3
    public CriObject PDAT_1F4; //0x1F4
    public Vector2Int V2_1F4; //0x1F4
    public byte DAT_1F4; //0x1F4
    public byte DAT_1F5; //0x1F5
    public byte DAT_1F6; //0x1F6
    public byte DAT_1F7; //0x1F7
    public short SDAT_1F8; //0x1F8
    public byte DAT_1F8; //0x1F8
    public byte DAT_1F9; //0x1F9
    public short SDAT_1FA; //0x1FA
    public sbyte DAT_1FA; //0x1FA
    public sbyte DAT_1FB; //0x1FB
    public Vector3Int DAT_1FC; //0x1FC
    public short SDAT_1FC; //0x1FC
    public uint UDAT_1FC; //0x1FC
    public short DAT_1FE; //0x1FE
    public short DAT_200; //0x200
    public short DAT_202; //0x202
    public Vector3Int DAT_204; //0x204
    public ushort UDAT_204; //0x204
    public ushort DAT_206; //0x206
    public uint DAT_208; //0x208
    public Vector2Int DAT_20C; //0x20C
    public uint UDAT_20C; //0x20C
    public uint UDAT_210; //0x210
    public byte DAT_210; //0x210
    public byte DAT_211; //0x211
    public byte DAT_212; //0x212
    public byte DAT_213; //0x213
    public uint DAT_214; //0x214
    public byte DAT_216; //0x216
    public byte DAT_217; //0x217
    public bool DAT_218; //0x218
    public CriPlayer PTR_218; //0x218
    public byte DAT_219; //0x219
    public short DAT_21A; //0x21A
    public Vector4Int V4_21C; //0x21C
    //public Object[] REFS;
    //public int[] REFS_2;
    public uint DAT_21C; //0x21C
    public uint DAT_220; //0x220
    public Vector3Int V3_224; //0x224
    public byte DAT_224; //0x224
    public byte DAT_225; //0x225
    public sbyte DAT_226; //0x226
    public byte DAT_227; //0x227
    public Vector3Int DAT_228; //0x228
    public short DAT_22E; //0x22E
    public byte[] DAT_230; //0x230
    public byte DAT_23F; //0x23F
    public byte DAT_240; //0x240
    public byte DAT_241; //0x241
    public ushort[] DAT_244; //0x244
    public byte[] DAT_24C; //0x24C
    private static uint[] DAT_9922C = new uint[]
    {
        0x8019113c, 0x80191884, 0x801914e0, 0x80191c28
    };
    private delegate void FUN_9923C();
    private delegate void FUN_9AD14();
    private delegate void FUN_9AD60();
    private delegate void FUN_9AD6C();
    private delegate void FUN_9AD74();
    private delegate void FUN_9AD7C();
    private delegate void FUN_9AD88();
    private delegate void FUN_9AD90();
    private delegate void FUN_9AD98();
    private delegate void FUN_9ADA0();
    private delegate void FUN_9ADA8();
    private delegate void FUN_9ADB0();
    private delegate void FUN_9ADB8();
    private delegate void FUN_9ADC0();
    private delegate void FUN_9AE50();
    private delegate void FUN_9AEEC();
    private delegate void FUN_9AFD8();
    private delegate void FUN_9AFE4();
    private delegate void FUN_9B000();
    private delegate void FUN_9B008();
    private delegate void FUN_9B010();
    private delegate void FUN_9B050();
    private delegate void FUN_9B06C();
    private delegate void FUN_9B964();
    private delegate void FUN_9B980();
    private delegate void FUN_9BA18();
    private delegate void FUN_9BAB0();
    private delegate void FUN_9BB70();
    private delegate void FUN_9BBC8();
    private delegate void FUN_9BC80();
    private delegate void FUN_9BCE0();
    private delegate void FUN_9BCE8();
    private delegate void FUN_9BCFC();
    private delegate void FUN_9BD14(CriPlayer p);
    private delegate void FUN_9BD38();
    private delegate void FUN_9BD40();
    private delegate void FUN_9BD48();
    private delegate void FUN_9BD50();
    private delegate void FUN_9BD58();
    private delegate void FUN_9BD7C();
    private delegate void FUN_9BD84();
    private delegate void FUN_9BDFC(CriPlayer p);
    private delegate void FUN_9BE20();
    private delegate void FUN_9BE28(CriPlayer p);
    private delegate void FUN_9BE4C();
    private delegate void FUN_9BF5C();
    private delegate void FUN_9BF64();
    private delegate void FUN_9BF9C();
    private delegate void FUN_9BFA4();
    private delegate void FUN_9BFB4();
    private delegate void FUN_9BFC4();
    private delegate void FUN_9BFD0();
    private delegate void FUN_9BFD8();
    private delegate void FUN_9BFF0();
    private delegate void FUN_9C0A8();
    private delegate void FUN_9C160();
    private delegate void FUN_9C1B8(CriPlayer p);
    private delegate void FUN_9C1DC();
    private delegate void FUN_9C294();
    private delegate void FUN_9C364();
    private delegate void FUN_9C370();
    private delegate void FUN_9C378();
    private delegate void FUN_9C388();
    private delegate void FUN_9C390();
    private delegate void FUN_9C408(CriPlayer p);
    private delegate void FUN_9C42C();
    private delegate void FUN_9C434();
    private delegate void FUN_9C44C();
    private delegate void FUN_9C454();
    private delegate void FUN_9C45C();
    private delegate void FUN_9C464();
    private delegate void FUN_9C46C(CriPlayer p);
    private delegate void FUN_9C490();
    private delegate void FUN_9C4A0();
    private delegate void FUN_9C4A8();
    private delegate void FUN_9C528();
    private delegate void FUN_9C530();
    private delegate void FUN_9C538();
    private delegate void FUN_9C540();
    private delegate void FUN_9C548();
    private delegate void FUN_9C558();
    private delegate void FUN_9C560();
    private delegate void FUN_9C590();
    private delegate void FUN_9C59C();
    private delegate void FUN_9C5A8();
    private delegate void FUN_9C5B4();
    private delegate void FUN_9C5BC();
    private delegate void FUN_9C5D0();
    private delegate void FUN_9C5E4();
    private delegate void FUN_9C5EC();
    private delegate void FUN_9C5DC();
    private delegate void FUN_9C5F4();
    private delegate void FUN_9C600();
    private delegate void FUN_9C620();
    private delegate void FUN_9C638();
    private delegate void FUN_9C648();
    private delegate void FUN_9C654();
    private delegate void FUN_9C660();
    private delegate void FUN_9C674();
    private delegate void FUN_9C67C();
    private delegate void FUN_9C694();
    private delegate void FUN_9CDE4();
    private delegate void FUN_9CE04();
    private delegate void FUN_9CE2C();
    private delegate void FUN_9CE3C();
    private delegate void FUN_9CE58();
    private delegate void FUN_9CE94();
    private delegate void FUN_9CEA4();
    private delegate void FUN_9D03C();
    private delegate void FUN_9D064();
    private delegate void FUN_9D070();
    private delegate void FUN_9D09C();
    private delegate void FUN_9D0A8();
    private delegate void FUN_9D0B8();
    private delegate void FUN_9D0C8();
    private delegate void FUN_9D10C();
    private delegate void FUN_9D11C();
    private delegate void FUN_9D12C();
    private delegate void FUN_9D138();
    private delegate void FUN_9D148();
    private delegate void FUN_9D154();
    private delegate void FUN_9D164();
    private delegate void FUN_9D170();
    private delegate void FUN_9D17C();
    private delegate void FUN_9D188();
    private delegate void FUN_9D194();
    private delegate void FUN_9D1A0();
    private delegate void FUN_9D1AC();
    private delegate void FUN_9D1B8();
    private delegate void FUN_9D1F4();
    private delegate void FUN_7C4C(); //0x7C4C (ST2)
    private delegate void FUN_7E08(); //0x7E08 (ST2)
    private delegate void FUN_7E3C(); //0x7E3C (ST2)
    private delegate void FUN_7E60(); //0x7E60 (ST2)
    private delegate void FUN_8114(); //0x8114 (ST2)
    private delegate void FUN_8134(); //0x8134 (ST2)
    private delegate void FUN_8150(); //0x8150 (ST2)
    private delegate void FUN_8158(CriPlayer p); //0x8158 (ST2)
    private delegate void FUN_8164(); //0x8164 (ST2)
    private FUN_9923C[] PTR_FUN_9923C;
    private FUN_9AD14[] PTR_FUN_9AD14;
    private FUN_9AD60[] PTR_FUN_9AD60;
    private FUN_9AD6C[] PTR_FUN_9AD6C;
    private FUN_9AD74[] PTR_FUN_9AD74;
    private FUN_9AD7C[] PTR_FUN_9AD7C;
    private FUN_9AD88[] PTR_FUN_9AD88;
    private FUN_9AD90[] PTR_FUN_9AD90;
    private FUN_9AD98[] PTR_FUN_9AD98;
    private FUN_9ADA0[] PTR_FUN_9ADA0;
    private FUN_9ADA8[] PTR_FUN_9ADA8;
    private FUN_9ADB0[] PTR_FUN_9ADB0;
    private FUN_9ADB8[] PTR_FUN_9ADB8;
    private FUN_9ADC0[] PTR_FUN_9ADC0;
    private FUN_9AE50[] PTR_FUN_9AE50;
    private FUN_9AEEC[] PTR_FUN_9AEEC;
    private FUN_9AFD8[] PTR_FUN_9AFD8;
    private FUN_9AFE4[] PTR_FUN_9AFE4;
    private FUN_9B000[] PTR_FUN_9B000;
    private FUN_9B008[] PTR_FUN_9B008;
    private FUN_9B010[] PTR_FUN_9B010;
    private FUN_9B050[] PTR_FUN_9B050;
    private FUN_9B06C[] PTR_FUN_9B06C;
    private FUN_9B964[] PTR_FUN_9B964;
    private FUN_9B980[] PTR_FUN_9B980;
    private FUN_9BA18[] PTR_FUN_9BA18;
    private FUN_9BAB0[] PTR_FUN_9BAB0;
    private FUN_9BB70[] PTR_FUN_9BB70;
    private FUN_9BBC8[] PTR_FUN_9BBC8;
    private FUN_9BC80[] PTR_FUN_9BC80;
    private FUN_9BCE0[] PTR_FUN_9BCE0;
    private FUN_9BCE8[] PTR_FUN_9BCE8;
    private FUN_9BCFC[] PTR_FUN_9BCFC;
    private FUN_9BD14[] PTR_FUN_9BD14;
    private FUN_9BD38[] PTR_FUN_9BD38;
    private FUN_9BD40[] PTR_FUN_9BD40;
    private FUN_9BD48[] PTR_FUN_9BD48;
    private FUN_9BD50[] PTR_FUN_9BD50;
    private FUN_9BD58[] PTR_FUN_9BD58;
    private FUN_9BD7C[] PTR_FUN_9BD7C;
    private FUN_9BD84[] PTR_FUN_9BD84;
    private FUN_9BDFC[] PTR_FUN_9BDFC;
    private FUN_9BE20[] PTR_FUN_9BE20;
    private FUN_9BE28[] PTR_FUN_9BE28;
    private FUN_9BE4C[] PTR_FUN_9BE4C;
    private FUN_9BF5C[] PTR_FUN_9BF5C;
    private FUN_9BF64[] PTR_FUN_9BF64;
    private FUN_9BF9C[] PTR_FUN_9BF9C;
    private FUN_9BFA4[] PTR_FUN_9BFA4;
    private FUN_9BFB4[] PTR_FUN_9BFB4;
    private FUN_9BFC4[] PTR_FUN_9BFC4;
    private FUN_9BFD0[] PTR_FUN_9BFD0;
    private FUN_9BFD8[] PTR_FUN_9BFD8;
    private FUN_9BFF0[] PTR_FUN_9BFF0;
    private FUN_9C0A8[] PTR_FUN_9C0A8;
    private FUN_9C160[] PTR_FUN_9C160;
    private FUN_9C1B8[] PTR_FUN_9C1B8;
    private FUN_9C1DC[] PTR_FUN_9C1DC;
    private FUN_9C294[] PTR_FUN_9C294;
    private FUN_9C364[] PTR_FUN_9C364;
    private FUN_9C370[] PTR_FUN_9C370;
    private FUN_9C378[] PTR_FUN_9C378;
    private FUN_9C388[] PTR_FUN_9C388;
    private FUN_9C390[] PTR_FUN_9C390;
    private FUN_9C408[] PTR_FUN_9C408;
    private FUN_9C42C[] PTR_FUN_9C42C;
    private FUN_9C434[] PTR_FUN_9C434;
    private FUN_9C44C[] PTR_FUN_9C44C;
    private FUN_9C454[] PTR_FUN_9C454;
    private FUN_9C45C[] PTR_FUN_9C45C;
    private FUN_9C464[] PTR_FUN_9C464;
    private FUN_9C46C[] PTR_FUN_9C46C;
    private FUN_9C490[] PTR_FUN_9C490;
    private FUN_9C4A0[] PTR_FUN_9C4A0;
    private FUN_9C4A8[] PTR_FUN_9C4A8;
    private FUN_9C528[] PTR_FUN_9C528;
    private FUN_9C530[] PTR_FUN_9C530;
    private FUN_9C538[] PTR_FUN_9C538;
    private FUN_9C540[] PTR_FUN_9C540;
    private FUN_9C548[] PTR_FUN_9C548;
    private FUN_9C558[] PTR_FUN_9C558;
    private FUN_9C560[] PTR_FUN_9C560;
    private FUN_9C590[] PTR_FUN_9C590;
    private FUN_9C59C[] PTR_FUN_9C59C;
    private FUN_9C5A8[] PTR_FUN_9C5A8;
    private FUN_9C5B4[] PTR_FUN_9C5B4;
    private FUN_9C5BC[] PTR_FUN_9C5BC;
    private FUN_9C5D0[] PTR_FUN_9C5D0;
    private FUN_9C5E4[] PTR_FUN_9C5E4;
    private FUN_9C5EC[] PTR_FUN_9C5EC;
    private FUN_9C5DC[] PTR_FUN_9C5DC;
    private FUN_9C5F4[] PTR_FUN_9C5F4;
    private FUN_9C600[] PTR_FUN_9C600;
    private FUN_9C620[] PTR_FUN_9C620;
    private FUN_9C638[] PTR_FUN_9C638;
    private FUN_9C648[] PTR_FUN_9C648;
    private FUN_9C654[] PTR_FUN_9C654;
    private FUN_9C660[] PTR_FUN_9C660;
    private FUN_9C674[] PTR_FUN_9C674;
    private FUN_9C67C[] PTR_FUN_9C67C;
    private FUN_9C694[] PTR_FUN_9C694;
    private FUN_9CDE4[] PTR_FUN_9CDE4;
    private FUN_9CE04[] PTR_FUN_9CE04;
    private FUN_9CE2C[] PTR_FUN_9CE2C;
    private FUN_9CE3C[] PTR_FUN_9CE3C;
    private FUN_9CE58[] PTR_FUN_9CE58;
    private FUN_9CE94[] PTR_FUN_9CE94;
    private FUN_9CEA4[] PTR_FUN_9CEA4;
    private FUN_9D03C[] PTR_FUN_9D03C;
    private FUN_9D064[] PTR_FUN_9D064;
    private FUN_9D070[] PTR_FUN_9D070;
    private FUN_9D09C[] PTR_FUN_9D09C;
    private FUN_9D0A8[] PTR_FUN_9D0A8;
    private FUN_9D0B8[] PTR_FUN_9D0B8;
    private FUN_9D0C8[] PTR_FUN_9D0C8;
    private FUN_9D10C[] PTR_FUN_9D10C;
    private FUN_9D11C[] PTR_FUN_9D11C;
    private FUN_9D12C[] PTR_FUN_9D12C;
    private FUN_9D138[] PTR_FUN_9D138;
    private FUN_9D148[] PTR_FUN_9D148;
    private FUN_9D154[] PTR_FUN_9D154;
    private FUN_9D164[] PTR_FUN_9D164;
    private FUN_9D170[] PTR_FUN_9D170;
    private FUN_9D17C[] PTR_FUN_9D17C;
    private FUN_9D188[] PTR_FUN_9D188;
    private FUN_9D194[] PTR_FUN_9D194;
    private FUN_9D1A0[] PTR_FUN_9D1A0;
    private FUN_9D1AC[] PTR_FUN_9D1AC;
    private FUN_9D1B8[] PTR_FUN_9D1B8;
    private FUN_9D1F4[] PTR_FUN_9D1F4;
    private FUN_7C4C[] PTR_FUN_7C4C; //0x7C4C (ST2)
    private FUN_7E08[] PTR_FUN_7E08; //0x7E08 (ST2)
    private FUN_7E3C[] PTR_FUN_7E3C; //0x7E3C (ST2)
    private FUN_7E60[] PTR_FUN_7E60; //0x7E60 (ST2)
    private FUN_8114[] PTR_FUN_8114; //0x8114 (ST2)
    private FUN_8134[] PTR_FUN_8134; //0x8134 (ST2)
    private FUN_8150[] PTR_FUN_8150; //0x8150 (ST2)
    private FUN_8158[] PTR_FUN_8158; //0x8158 (ST2)
    private FUN_8164[] PTR_FUN_8164; //0x8164 (ST2)

    private static CapsuleCollider[] DAT_9B404 = new CapsuleCollider[]
    {
        new CapsuleCollider()
        {
            pos = new Vector3Int(0, 0x4b0, 0x1e),
            radius = 346,
            height = 1652,
            bone = 0,
            flags = 0
        },
        new CapsuleCollider(),
        new CapsuleCollider(),
        new CapsuleCollider(),
        new CapsuleCollider(),
        new CapsuleCollider(),
        new CapsuleCollider()
        {
            pos = new Vector3Int(0, 0, 0),
            radius = 620,
            height = 0,
            bone = -1,
            flags = 0
        },
        new CapsuleCollider()
        {
            pos = new Vector3Int(0, 1000, 0),
            radius = 642,
            height = 1502,
            bone = 0,
            flags = 0
        }, 
        new CapsuleCollider(), 
        new CapsuleCollider(), 
        new CapsuleCollider()
    };
    private static byte DAT_9CDC6;
    private static CapsuleCollider[] DAT_9CDB0 = new CapsuleCollider[]
    {
        new CapsuleCollider()
        {
            pos = new Vector3Int(0, 0x4a1, 0),
            radius = 320,
            height = 1770,
            bone = 8,
            flags = 0x80
        },
        new CapsuleCollider()
        {
            pos = new Vector3Int(0, 0, 0),
            radius = 320,
            height = 0,
            bone = 0,
            flags = 0
        }
    };
    private static short[] DAT_9CE34 = new short[]
    {
        0x800, 0xc00, 0, 0x400
    };
    private static short[] DAT_9CE50 = new short[]
    {
        0x800, 0xc00, 0, 0x400
    };
    private static short[] DAT_9CED0 = new short[]
    {
        -304, -304, 304, 304
    };
    private static short[] DAT_9CED8 = new short[]
    {
        -100, -100, 100, 100
    };
    private static short[] DAT_9CEE0 = new short[]
    {
        -100, -100, 100, 100
    };
    private static short[] DAT_9CEE8 = new short[]
    {
        -70, -70, 70, 70
    };
    private static short[] DAT_9CEF0 = new short[]
    {
        -304, -304, 304, 304
    };
    private static short[] DAT_9CEF8 = new short[]
    {
        -100, -100, 100, 100
    };
    private static short[] DAT_9CF00 = new short[]
    {
        -70, -70, 70, 70
    };
    private static short[] DAT_9D02C = new short[]
    {
        43, 34, 34, 0
    };
    private static short[] DAT_9D034 = new short[]
    {
        -30, -27, -27, 0
    };
    private static byte[] DAT_9D06C = new byte[]
    {
        0x50, 0x30, 0x20, 0
    };
    private static CapsuleCollider[] DAT_9D1C8 = new CapsuleCollider[1]
    {
        new CapsuleCollider()
        {
            pos = new Vector3Int(0, 0x4a1, 0),
            radius = 320,
            height = 1770,
            bone = 8,
            flags = 0x80
        }
    };
    private static int[] DAT_9D1D4 = new int[8] { 0, 0, 1, 3, 0, 2, 0, 0 };

    protected override void Awake()
    {
        base.Awake();
        PTR_FUN_9923C = new FUN_9923C[2]
        {
            FUN_21D9C,
            FUN_21E10
        };
        PTR_FUN_9AD14 = new FUN_9AD14[19]
        {
            FUN_2B828,
            FUN_2B928,
            FUN_2BADC,
            FUN_2BBF4,
            FUN_2BCF4,
            FUN_2BEA8,
            FUN_2BF8C,
            FUN_2C080,
            FUN_2C1A4,
            FUN_2C2C8,
            FUN_2C418,
            FUN_2C5D0,
            FUN_2C890,
            FUN_2CB4C,
            FUN_2CB88,
            FUN_2CED0,
            FUN_2D318,
            FUN_2D4E8,
            FUN_2D5F8
        };
        PTR_FUN_9AD60 = new FUN_9AD60[3]
        {
            FUN_2B730,
            FUN_2B74C,
            FUN_2B7C4
        };
        PTR_FUN_9AD6C = new FUN_9AD6C[2]
        {
            FUN_2B864,
            FUN_2B8B8
        };
        PTR_FUN_9AD74 = new FUN_9AD74[2]
        {
            FUN_2B9C4,
            FUN_2BA18
        };
        PTR_FUN_9AD7C = new FUN_9AD7C[3]
        {
            FUN_2B730,
            FUN_2BB18,
            FUN_2BB90
        };
        PTR_FUN_9AD88 = new FUN_9AD88[2]
        {
            FUN_2BC30,
            FUN_2BC84
        };
        PTR_FUN_9AD90 = new FUN_9AD90[2]
        {
            FUN_2BD90,
            FUN_2BDE4
        };
        PTR_FUN_9AD98 = new FUN_9AD98[2]
        {
            FUN_2BEE4,
            FUN_2BF50
        };
        PTR_FUN_9ADA0 = new FUN_9ADA0[2]
        {
            FUN_2BFC8,
            FUN_2C024
        };
        PTR_FUN_9ADA8 = new FUN_9ADA8[2]
        {
            FUN_2C0BC,
            FUN_2C11C
        };
        PTR_FUN_9ADB0 = new FUN_9ADB0[2]
        {
            FUN_2C1E0,
            FUN_2C258
        };
        PTR_FUN_9ADB8 = new FUN_9ADB8[2]
        {
            FUN_2C304,
            FUN_2C388
        };
        PTR_FUN_9ADC0 = new FUN_9ADC0[4]
        {
            FUN_2C454,
            FUN_2C4B0,
            FUN_2C4F0,
            FUN_2C540
        };
        PTR_FUN_9AE50 = new FUN_9AE50[7]
        {
            FUN_2B730,
            FUN_2C60C,
            FUN_2C66C,
            FUN_2C6B4,
            FUN_2C710,
            FUN_2C784,
            FUN_2C7D0
        };
        PTR_FUN_9AEEC = new FUN_9AEEC[7]
        {
            FUN_2B730,
            FUN_2C8CC,
            FUN_2C92C,
            FUN_2C974,
            FUN_2C9CC,
            FUN_2CA40,
            FUN_2CA8C
        };
        PTR_FUN_9AFD8 = new FUN_9AFD8[3]
        {
            FUN_2B730,
            FUN_2CDD4,
            FUN_2CE34
        };
        PTR_FUN_9AFE4 = new FUN_9AFE4[7]
        {
            FUN_2B730,
            FUN_2CF0C,
            FUN_2CF64,
            FUN_2D010,
            FUN_2D0BC,
            FUN_2D1A4,
            FUN_2D1F4
        };
        PTR_FUN_9B000 = new FUN_9B000[2]
        {
            FUN_2D354,
            FUN_2D3C0
        };
        PTR_FUN_9B008 = new FUN_9B008[2]
        {
            FUN_2D524,
            FUN_2D590
        };
        PTR_FUN_9B010 = new FUN_9B010[2]
        {
            FUN_2D634,
            FUN_2B3E4
        };
        PTR_FUN_9B050 = new FUN_9B050[7]
        {
            FUN_2E364,
            FUN_2E3C8,
            FUN_2E7B4,
            FUN_2E580,
            FUN_2E5F4,
            FUN_2E758,
            FUN_2E7B4
        };
        PTR_FUN_9B06C = new FUN_9B06C[6]
        {
            FUN_2E658,
            FUN_2E674,
            FUN_2E6B4,
            FUN_2E6EC,
            FUN_2E6B4,
            FUN_2E72C
        };
        PTR_FUN_9B964 = new FUN_9B964[7]
        {
            FUN_2FF18,
            FUN_30358,
            FUN_3C570,
            FUN_3D7B8,
            FUN_3DB78,
            FUN_3F694,
            FUN_3FA68
        };
        PTR_FUN_9B980 = new FUN_9B980[38]
        {
            FUN_2B3E4,
            FUN_3042C,
            FUN_31740,
            FUN_31B9C,
            FUN_2B3E4,
            FUN_32284,
            FUN_2B3E4,
            FUN_2B3E4,
            FUN_2B3E4,
            FUN_3405C,
            FUN_2B3E4,
            FUN_344B0,
            FUN_34D64,
            FUN_2B3E4,
            FUN_2B3E4,
            FUN_35DD0,
            FUN_35F78,
            FUN_35F78,
            FUN_367BC,
            FUN_36A44,
            FUN_2B3E4,
            FUN_372CC,
            FUN_37E28,
            FUN_2B3E4,
            FUN_2B3E4,
            FUN_392F4,
            FUN_39934,
            FUN_2B3E4,
            FUN_2B3E4,
            FUN_2B3E4,
            FUN_3A310,
            FUN_3AC54,
            FUN_2B3E4,
            FUN_2B3E4,
            FUN_2B3E4,
            FUN_3B868,
            FUN_3BB1C,
            FUN_2B3E4
        };
        PTR_FUN_9BA18 = new FUN_9BA18[38]
        {
            FUN_303F0,
            FUN_30984,
            FUN_31B60,
            FUN_31F30,
            FUN_320AC,
            FUN_32950,
            FUN_32BAC,
            FUN_32DD0,
            FUN_32FF0,
            FUN_3425C,
            FUN_34474,
            FUN_34D28,
            FUN_35898,
            FUN_35C58,
            FUN_35D94,
            FUN_35F3C,
            FUN_3667C,
            FUN_36780,
            FUN_36A08,
            FUN_36D48,
            FUN_37290,
            FUN_37DEC,
            FUN_381FC,
            FUN_38C94,
            FUN_392B8,
            FUN_398F8,
            FUN_39EBC,
            FUN_3A0C8,
            FUN_3A180,
            FUN_3A2D4,
            FUN_3AC18,
            FUN_3B2F8,
            FUN_3B468,
            FUN_3B5BC,
            FUN_3B7BC,
            FUN_3BAE0,
            FUN_3C390,
            FUN_3C534
        };
        PTR_FUN_9BAB0 = new FUN_9BAB0[2]
        {
            FUN_303A8,
            FUN_3DBB4
        };
        PTR_FUN_9BB70 = new FUN_9BB70[2]
        {
            FUN_30834,
            FUN_308EC
        };
        PTR_FUN_9BBC8 = new FUN_9BBC8[4]
        {
            FUN_309C0,
            FUN_30CE0,
            FUN_30FF0,
            FUN_312EC
        };
        PTR_FUN_9BC80 = new FUN_9BC80[2]
        {
            FUN_31868,
            FUN_318F4
        };
        PTR_FUN_9BCE0 = new FUN_9BCE0[2]
        {
            FUN_31D3C,
            FUN_31DA8
        };
        PTR_FUN_9BCE8 = new FUN_9BCE8[2]
        {
            FUN_31F6C,
            FUN_31FC0
        };
        PTR_FUN_9BCFC = new FUN_9BCFC[9]
        {
            FUN_320E8,
            FUN_320E8,
            FUN_320E8,
            FUN_32214,
            FUN_32214,
            FUN_320E8,
            FUN_32214,
            FUN_32214,
            FUN_320E8
        };
        PTR_FUN_9BD14 = new FUN_9BD14[9]
        {
            FUN_322C0,
            FUN_322C0,
            FUN_322C0,
            FUN_32448,
            FUN_32448,
            FUN_322C0,
            FUN_32448,
            FUN_32448,
            FUN_322C0
        };
        PTR_FUN_9BD38 = new FUN_9BD38[2]
        {
            FUN_326BC,
            FUN_32734
        };
        PTR_FUN_9BD40 = new FUN_9BD40[2]
        {
            FUN_3298C,
            FUN_329EC
        };
        PTR_FUN_9BD48 = new FUN_9BD48[2]
        {
            FUN_32BE8,
            FUN_32CDC
        };
        PTR_FUN_9BD50 = new FUN_9BD50[2]
        {
            FUN_32E0C,
            FUN_32F14
        };
        PTR_FUN_9BD58 = new FUN_9BD58[9]
        {
            FUN_3302C,
            FUN_3302C,
            FUN_3302C,
            FUN_332FC,
            FUN_332FC,
            FUN_337B0,
            FUN_33B78,
            FUN_332FC,
            FUN_337B0
        };
        PTR_FUN_9BD7C = new FUN_9BD7C[2]
        {
            FUN_34098,
            FUN_34104
        };
        PTR_FUN_9BD84 = new FUN_9BD84[2]
        {
            FUN_34298,
            FUN_342F8
        };
        PTR_FUN_9BDFC = new FUN_9BDFC[9]
        {
            FUN_34858,
            FUN_34858,
            FUN_34858,
            FUN_349A8,
            FUN_349A8,
            FUN_34858,
            FUN_349A8,
            FUN_349A8,
            FUN_34858
        };
        PTR_FUN_9BE20 = new FUN_9BE20[2]
        {
            FUN_34B40,
            FUN_34B90
        };
        PTR_FUN_9BE28 = new FUN_9BE28[9]
        {
            FUN_3516C,
            FUN_3516C,
            FUN_3516C,
            FUN_35298,
            FUN_35298,
            FUN_3516C,
            FUN_35298,
            FUN_35298,
            FUN_3516C
        };
        PTR_FUN_9BE4C = new FUN_9BE4C[4]
        {
            FUN_35410,
            FUN_35528,
            FUN_35774,
            FUN_35814
        };
        PTR_FUN_9BF5C = new FUN_9BF5C[2]
        {
            FUN_358D4,
            FUN_35948
        };
        PTR_FUN_9BF64 = new FUN_9BF64[2]
        {
            FUN_35C94,
            FUN_35CEC
        };
        PTR_FUN_9BF9C = new FUN_9BF9C[2]
        {
            FUN_35E58,
            FUN_35EBC
        };
        PTR_FUN_9BFA4 = new FUN_9BFA4[4]
        {
            FUN_361C8,
            FUN_36248,
            FUN_36528,
            FUN_36570
        };
        PTR_FUN_9BFB4 = new FUN_9BFB4[4]
        {
            FUN_366B8,
            FUN_36248,
            FUN_36738,
            FUN_36570
        };
        PTR_FUN_9BFC4 = new FUN_9BFC4[3]
        {
            FUN_368F4,
            FUN_3696C,
            FUN_369D0
        };
        PTR_FUN_9BFD0 = new FUN_9BFD0[2]
        {
            FUN_36C3C,
            FUN_36C94
        };
        PTR_FUN_9BFD8 = new FUN_9BFD8[6]
        {
            FUN_36D84,
            FUN_36E88,
            FUN_36EE8,
            FUN_36FA8,
            FUN_371A8,
            FUN_37240
        };
        PTR_FUN_9BFF0 = new FUN_9BFF0[9]
        {
            FUN_3783C,
            FUN_3783C,
            FUN_3783C,
            FUN_37974,
            FUN_37974,
            FUN_3783C,
            FUN_37974,
            FUN_37974,
            FUN_3783C
        };
        PTR_FUN_9C0A8 = new FUN_9C0A8[4]
        {
            FUN_37AFC,
            FUN_37BB0,
            FUN_37D4C,
            FUN_37D94
        };
        PTR_FUN_9C160 = new FUN_9C160[2]
        {
            FUN_37F60,
            FUN_38018
        };
        PTR_FUN_9C1B8 = new FUN_9C1B8[9]
        {
            FUN_38238,
            FUN_383A0,
            FUN_384E4,
            FUN_38620,
            FUN_384E4,
            FUN_384E4,
            FUN_384E4,
            FUN_384E4,
            FUN_384E4
        };
        PTR_FUN_9C1DC = new FUN_9C1DC[6]
        {
            FUN_38764,
            FUN_387E0,
            FUN_3883C,
            FUN_388A8,
            FUN_38ABC,
            FUN_38B78
        };
        PTR_FUN_9C294 = new FUN_9C294[8]
        {
            FUN_38CD0,
            FUN_38D48,
            FUN_38E58,
            FUN_38EC4,
            FUN_39100,
            FUN_3914C,
            FUN_391AC,
            FUN_391F8
        };
        PTR_FUN_9C364 = new FUN_9C364[2]
        {
            FUN_39614,
            FUN_39724
        };
        PTR_FUN_9C370 = new FUN_9C370[2]
        {
            FUN_39E30,
            FUN_3DBB4
        };
        PTR_FUN_9C378 = new FUN_9C378[4]
        {
            FUN_39EF8,
            FUN_39F40,
            FUN_39F88,
            FUN_39FE0
        };
        PTR_FUN_9C388 = new FUN_9C388[2]
        {
            FUN_3A104,
            FUN_3A14C
        };
        PTR_FUN_9C390 = new FUN_9C390[2]
        {
            FUN_3A1BC,
            FUN_3A214
        };
        PTR_FUN_9C408 = new FUN_9C408[9]
        {
            FUN_3A76C,
            FUN_3A76C,
            FUN_3A76C,
            FUN_3A8A8,
            FUN_3A8A8,
            FUN_3A76C,
            FUN_3A8A8,
            FUN_3A8A8,
            FUN_3A76C
        };
        PTR_FUN_9C42C = new FUN_9C42C[2]
        {
            FUN_3AA18,
            FUN_3AA74
        };
        PTR_FUN_9C434 = new FUN_9C434[6]
        {
            FUN_3AFA4,
            FUN_3AFF0,
            FUN_3B0B8,
            FUN_3B110,
            FUN_3B21C,
            FUN_3B270
        };
        PTR_FUN_9C44C = new FUN_9C44C[2]
        {
            FUN_3B334,
            FUN_3B3C0
        };
        PTR_FUN_9C454 = new FUN_9C454[2]
        {
            FUN_3B4A4,
            FUN_3B540
        };
        PTR_FUN_9C45C = new FUN_9C45C[2]
        {
            FUN_3B5F8,
            FUN_3B674
        };
        PTR_FUN_9C464 = new FUN_9C464[2]
        {
            FUN_3B9A8,
            FUN_3B9E8
        };
        PTR_FUN_9C46C = new FUN_9C46C[9]
        {
            FUN_3516C,
            FUN_3516C,
            FUN_3516C,
            FUN_35298,
            FUN_35298,
            FUN_3516C,
            FUN_35298,
            FUN_35298,
            FUN_3516C
        };
        PTR_FUN_9C490 = new FUN_9C490[4]
        {
            FUN_3BF18,
            FUN_3C008,
            FUN_3C26C,
            FUN_3C30C
        };
        PTR_FUN_9C4A0 = new FUN_9C4A0[2]
        {
            FUN_3C3CC,
            FUN_3C488
        };
        PTR_FUN_9C4A8 = new FUN_9C4A8[6]
        {
            FUN_3C5AC,
            FUN_3CED4,
            FUN_3CF10,
            FUN_3D234,
            FUN_3D6C4,
            FUN_3D77C
        };
        PTR_FUN_9C528 = new FUN_9C528[2]
        {
            FUN_3CBAC,
            FUN_3CCF4
        };
        PTR_FUN_9C530 = new FUN_9C530[2]
        {
            FUN_3D5AC,
            FUN_3D5F8
        };
        PTR_FUN_9C538 = new FUN_9C538[2]
        {
            FUN_3D700,
            FUN_3D748
        };
        PTR_FUN_9C540 = new FUN_9C540[2]
        {
            FUN_3D978,
            FUN_3DB3C
        };
        PTR_FUN_9C548 = new FUN_9C548[4]
        {
            FUN_3D7F4,
            FUN_3D858,
            FUN_3D8B0,
            FUN_2B3E4
        };
        PTR_FUN_9C558 = new FUN_9C558[2]
        {
            FUN_3D9B4,
            FUN_3DA54
        };
        PTR_FUN_9C560 = new FUN_9C560[12]
        {
            FUN_3DBB4,
            FUN_3DBD4,
            FUN_3DE1C,
            FUN_3E028,
            FUN_3E268,
            FUN_3E58C,
            FUN_3EA00,
            FUN_3EC5C,
            FUN_3EDE8,
            FUN_3F1B0,
            FUN_3F3D8,
            FUN_3F414
        };
        PTR_FUN_9C590 = new FUN_9C590[3]
        {
            FUN_3DC10,
            FUN_3DC78,
            FUN_2B3E4
        };
        PTR_FUN_9C59C = new FUN_9C59C[3]
        {
            FUN_3DE58,
            FUN_3DED4,
            FUN_2B3E4
        };
        PTR_FUN_9C5A8 = new FUN_9C5A8[3]
        {
            FUN_3E064,
            FUN_3E0DC,
            FUN_2B3E4
        };
        PTR_FUN_9C5B4 = new FUN_9C5B4[2]
        {
            FUN_3ECF4,
            FUN_3ED98
        };
        PTR_FUN_9C5BC = new FUN_9C5BC[5]
        {
            FUN_3EE24,
            FUN_3EE90,
            FUN_3EF58,
            FUN_3F028,
            FUN_3F108
        };
        PTR_FUN_9C5D0 = new FUN_9C5D0[3]
        {
            FUN_3F1EC,
            FUN_3F268,
            FUN_2B3E4
        };
        PTR_FUN_9C5DC = new FUN_9C5DC[2]
        {
            FUN_3F860,
            FUN_3F9E4
        };
        PTR_FUN_9C5E4 = new FUN_9C5E4[2]
        {
            FUN_3F6D0,
            FUN_3F7F4
        };
        PTR_FUN_9C5EC = new FUN_9C5EC[2]
        {
            FUN_3F89C,
            FUN_3F948
        };
        PTR_FUN_9C5F4 = new FUN_9C5F4[3]
        {
            FUN_40070,
            FUN_40408,
            FUN_407F8
        };
        PTR_FUN_9C600 = new FUN_9C600[2]
        {
            FUN_2F258,
            FUN_2F3A4
        };
        PTR_FUN_9C620 = new FUN_9C620[2]
        {
            FUN_2F4C8,
            FUN_2F590
        };
        PTR_FUN_9C638 = new FUN_9C638[4]
        {
            FUN_3FAA4,
            FUN_3FCCC,
            FUN_3FE64,
            FUN_3DBB4
        };
        PTR_FUN_9C648 = new FUN_9C648[3]
        {
            FUN_400AC,
            FUN_40284,
            FUN_403C0
        };
        PTR_FUN_9C654 = new FUN_9C654[3]
        {
            FUN_40444,
            FUN_40608,
            FUN_407B0
        };
        PTR_FUN_9C660 = new FUN_9C660[5]
        {
            FUN_2B3E4,
            FUN_429F8,
            FUN_40D94,
            FUN_449DC,
            FUN_2B3E4
        };
        PTR_FUN_9C674 = new FUN_9C674[2]
        {
            FUN_40DDC,
            FUN_41C74
        };
        PTR_FUN_9C67C = new FUN_9C67C[6]
        {
            FUN_42A38,
            FUN_43500,
            FUN_4444C,
            FUN_444B8,
            FUN_44508,
            FUN_44558
        };
        PTR_FUN_9C694 = new FUN_9C694[2]
        {
            FUN_44A24,
            FUN_44E30
        };
        PTR_FUN_9CDE4 = new FUN_9CDE4[8]
        {
            FUN_4D23C,
            FUN_4D6D0,
            FUN_4F234,
            FUN_4FC8C,
            FUN_53B30,
            FUN_4FD74,
            FUN_4FDBC,
            FUN_4FE04
        };
        PTR_FUN_9CE04 = new FUN_9CE04[10]
        {
            FUN_4D7A4,
            FUN_4DADC,
            FUN_4DDC0,
            FUN_4DF9C,
            FUN_4E130,
            FUN_4E2F0,
            FUN_4F1AC,
            FUN_4E81C,
            FUN_4EF74,
            FUN_4F074
        };
        PTR_FUN_9CE2C = new FUN_9CE2C[2]
        {
            FUN_4DCB4, 
            FUN_4DD3C
        };
        PTR_FUN_9CE3C = new FUN_9CE3C[5]
        {
            FUN_4E858, 
            FUN_4E8A8, 
            FUN_4EB00, 
            FUN_4EEF0, 
            FUN_4EF40
        };
        PTR_FUN_9CE58 = new FUN_9CE58[1]
        {
            FUN_512BC
        };
        PTR_FUN_9CE94 = new FUN_9CE94[4]
        {
            FUN_508B8,
            FUN_508C0,
            FUN_5094C,
            FUN_509C4
        };
        PTR_FUN_9CEA4 = new FUN_9CEA4[11]
        {
            FUN_4F2E4,
            FUN_4F4C0,
            FUN_4F5C4,
            FUN_4F62C,
            FUN_4F6D8,
            FUN_4F7A0,
            FUN_4F800,
            FUN_4F880,
            FUN_4F8CC,
            FUN_4FA28,
            FUN_4FB94
        };
        PTR_FUN_9D03C = new FUN_9D03C[10]
        {
            FUN_512F8,
            FUN_51468, 
            null, 
            null, 
            FUN_51604, 
            FUN_5174C, 
            FUN_5194C, 
            FUN_51B08, 
            null, 
            null
        };
        PTR_FUN_9D064 = new FUN_9D064[2]
        {
            FUN_51394,
            FUN_51424
        };
        PTR_FUN_9D070 = new FUN_9D070[11]
        {
            FUN_52654,
            FUN_52698,
            FUN_52724,
            FUN_52778,
            FUN_52798,
            FUN_52964,
            FUN_52B9C,
            FUN_52BA4,
            FUN_52C28,
            FUN_52FD0,
            FUN_53064
        };
        PTR_FUN_9D09C = new FUN_9D09C[3]
        {
            FUN_5282C,
            FUN_528A0,
            FUN_528E4
        };
        PTR_FUN_9D0A8 = new FUN_9D0A8[4]
        {
            FUN_529F8,
            FUN_52A6C,
            FUN_52AC0,
            FUN_52B40
        };
        PTR_FUN_9D0B8 = new FUN_9D0B8[4]
        {
            FUN_52C64,
            FUN_52CE0,
            FUN_52D44,
            FUN_52E8C
        };
        PTR_FUN_9D0C8 = new FUN_9D0C8[17]
        {
            FUN_53B6C,
            FUN_53B8C,
            FUN_54148,
            FUN_53DF4,
            FUN_5401C,
            FUN_543A8,
            FUN_543F0,
            FUN_54540,
            FUN_54660,
            FUN_546D0,
            FUN_54780,
            FUN_547F0,
            FUN_5490C,
            FUN_54970,
            FUN_54B2C,
            FUN_54CD4,
            FUN_54E38
        };
        PTR_FUN_9D10C = new FUN_9D10C[4]
        {
            FUN_53BC8,
            FUN_53C60,
            FUN_53CD8,
            FUN_543A8
        };
        PTR_FUN_9D11C = new FUN_9D11C[4]
        {
            FUN_53E30,
            FUN_53E98,
            FUN_53F0C,
            FUN_543A8
        };
        PTR_FUN_9D12C = new FUN_9D12C[3]
        {
            FUN_54058,
            FUN_540CC,
            FUN_543A8
        };
        PTR_FUN_9D138 = new FUN_9D138[4]
        {
            FUN_54184,
            FUN_541F0,
            FUN_5428C,
            FUN_543A8
        };
        PTR_FUN_9D148 = new FUN_9D148[3]
        {
            FUN_5442C,
            FUN_544C4,
            FUN_543A8
        };
        PTR_FUN_9D154 = new FUN_9D154[4]
        {
            FUN_5457C,
            FUN_545E8,
            FUN_53CD8,
            FUN_543A8
        };
        PTR_FUN_9D164 = new FUN_9D164[3]
        {
            FUN_5469C,
            FUN_53CD8,
            FUN_543A8
        };
        PTR_FUN_9D170 = new FUN_9D170[3]
        {
            FUN_5470C,
            FUN_5428C,
            FUN_543A8
        };
        PTR_FUN_9D17C = new FUN_9D17C[3]
        {
            FUN_547BC,
            FUN_53CD8,
            FUN_543A8
        };
        PTR_FUN_9D188 = new FUN_9D188[3]
        {
            FUN_5482C,
            FUN_54894,
            FUN_543A8
        };
        PTR_FUN_9D194 = new FUN_9D194[3]
        {
            FUN_54948,
            FUN_53CD8,
            FUN_53B6C
        };
        PTR_FUN_9D1A0 = new FUN_9D1A0[3]
        {
            FUN_549AC,
            FUN_54A1C,
            FUN_543A8
        };
        PTR_FUN_9D1AC = new FUN_9D1AC[3]
        {
            FUN_54B68,
            FUN_54C00,
            FUN_54CCC
        };
        PTR_FUN_9D1B8 = new FUN_9D1B8[4]
        {
            FUN_54D10,
            FUN_54DA8,
            FUN_53CD8,
            FUN_54E38
        };
        PTR_FUN_9D1F4 = new FUN_9D1F4[6]
        {
            FUN_55078,
            FUN_55150,
            null,
            null,
            FUN_53B30,
            FUN_55170
        };
        PTR_FUN_7C4C = new FUN_7C4C[]
        {
            FUN_2224,
            FUN_2398
        };
        PTR_FUN_7E08 = new FUN_7E08[2]
        {
            FUN_3980, 
            FUN_3AA0
        };
        PTR_FUN_7E3C = new FUN_7E3C[]
        {
            FUN_3EC0, 
            FUN_3E84
        };
        PTR_FUN_7E60 = new FUN_7E60[]
        {
            FUN_4298
        };
        PTR_FUN_8114 = new FUN_8114[]
        {
            FUN_2D98
        };
        PTR_FUN_8134 = new FUN_8134[5]
        {
            FUN_331C, 
            FUN_4258, 
            FUN_43A4, 
            FUN_43E0,
            FUN_4BEC
        };
        PTR_FUN_8150 = new FUN_8150[2]
        {
            FUN_4FD8, 
            FUN_50B8
        };
        PTR_FUN_8158 = new FUN_8158[3]
        {
            FUN_516C, 
            FUN_51D0, 
            FUN_5260
        };
        PTR_FUN_8164 = new FUN_8164[]
        {
            FUN_5130
        };
        DAT_244 = new ushort[4];
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    private void FixedUpdate()
    {

    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_1C0 = 0;
        BDAT_1C0 = 0;
        DAT_1C1 = 0;
        DAT_1C2 = 0;
        DAT_1C3 = 0;
        IDAT_1C4 = 0;
        DAT_1C4 = 0;
        DAT_1C5 = 0;
        DAT_1C6 = 0;
        DAT_1C7 = 0;
        DAT_1C8 = 0;
        IDAT_1C8 = 0;
        PDAT_1C8 = null;
        DAT_1C9 = 0;
        BDAT_1CA = 0;
        DAT_1CA = 0;
        DAT_1CB = 0;
        PTR_1CC = null;
        SDAT_1CC = 0;
        DAT_1CC = 0;
        DAT_1CD = 0;
        DAT_1CE = 0;
        DAT_1CF = 0;
        DAT_1D0 = 0;
        BDAT_1D0 = 0;
        DAT_1D1 = 0;
        UDAT_1D2 = 0;
        DAT_1D2 = 0;
        DAT_1D3 = 0;
        SDAT_1D4 = 0;
        PDAT_1D4 = null;
        DAT_1D4 = 0;
        DAT_1D5 = 0;
        SDAT_1D6 = 0;
        DAT_1D6 = 0;
        DAT_1D7 = 0;
        BDAT_1D8 = 0;
        SDAT_1D8 = 0;
        DAT_1D8 = null;
        DAT_1D9 = 0;
        UDAT_1DA = 0;
        DAT_1DA = 0;
        DAT_1DB = 0;
        DAT_1DC = null;
        UDAT_1DC = 0;
        SDAT_1DC = 0;
        BDAT_1DC = 0;
        DAT_1DD = 0;
        SDAT_1DE = 0;
        DAT_1DE = 0;
        DAT_1DF = 0;
        DAT_1E0 = null;
        UDAT_1E0 = 0;
        BDAT_1E2 = 0;
        DAT_1E2 = 0;
        DAT_1E3 = 0;
        VDAT_1E4 = Vector4Int.zero;
        UDAT_1E4 = 0;
        DAT_1E4 = 0;
        DAT_1E5 = 0;
        DAT_1E6 = 0;
        DAT_1E7 = 0;
        BDAT_1E8 = 0;
        DAT_1E8 = 0;
        BDAT_1EC = 0;
        DAT_1EA = 0;
        DAT_1EB = 0;
        DAT_1EC = 0;
        DAT_1ED = 0;
        DAT_1EE = 0;
        DAT_1EF = 0;
        DAT_1F0 = null;
        V2_1F0 = Vector2Int.zero;
        DAT_1F1 = 0;
        DAT_1F2 = 0;
        DAT_1F3 = false;
        PDAT_1F4 = null;
        V2_1F4 = Vector2Int.zero;
        DAT_1F4 = 0;
        DAT_1F5 = 0;
        DAT_1F6 = 0;
        DAT_1F7 = 0;
        SDAT_1F8 = 0;
        DAT_1F8 = 0;
        DAT_1F9 = 0;
        SDAT_1FA = 0;
        DAT_1FA = 0;
        DAT_1FB = 0;
        DAT_1FC = Vector3Int.zero;
        SDAT_1FC = 0;
        UDAT_1FC = 0;
        DAT_1FE = 0;
        DAT_200 = 0;
        DAT_202 = 0;
        DAT_204 = Vector3Int.zero;
        UDAT_204 = 0;
        DAT_206 = 0;
        DAT_208 = 0;
        DAT_20C = Vector2Int.zero;
        UDAT_20C = 0;
        UDAT_210 = 0;
        DAT_210 = 0;
        DAT_211 = 0;
        DAT_212 = 0;
        DAT_213 = 0;
        DAT_214 = 0;
        DAT_216 = 0;
        DAT_217 = 0;
        DAT_218 = false;
        PTR_218 = null;
        DAT_219 = 0;
        DAT_21A = 0;
        V4_21C = Vector4Int.zero;
        //REFS = null;
        DAT_21C = 0;
        DAT_220 = 0;
        V3_224 = Vector3Int.zero;
        DAT_224 = 0;
        DAT_225 = 0;
        DAT_226 = 0;
        DAT_227 = 0;
        DAT_228 = Vector3Int.zero;
        DAT_22E = 0;
        DAT_230 = new byte[10];
        DAT_23F = 0;
        DAT_240 = 0;
        DAT_241 = 0;
        DAT_244 = new ushort[4];
        DAT_24C = new byte[4];
    }

    public void FUN_6016C()
    {
        flags = 0;
        FUN_60278();
        ResetValues();
    }

    public void FUN_4CFDC()
    {
        byte bVar1;
        short sVar2;
        byte bVar3;
        uint uVar4;
        bool bVar5;
        uint uVar6;
        CriStatic local_18;
        byte local_14;

        bVar3 = (byte)(((byte)InventoryManager.DAT_B7A60[0] ^ 1) & 1);

        if (bVar3 != 0)
        {
            DAT_34 = screen;
            FUN_5211C(DAT_1CF);
        }

        vr.y &= 0xfff;
        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if (bVar3 != 0)
        {
            local_18 = null;
            uVar4 = DAT_3C;

            if (uVar4 != 0)
            {
                FUN_659D0();
                uVar4 = DAT_3C;
            }

            PTR_FUN_9CDE4[uVar4]();
            bVar3 = frames[frameNum].DAT_03;
            local_14 = (byte)(bVar3 & 3);

            if ((bVar3 & 3) != 0)
            {
                uVar6 = 176;

                if ((DAT_1C0 & 2) != 0)
                    uVar6 = 177;

                GameManager.instance.FUN_5D0C4(this, (byte)uVar6, (byte)(bVar3 & 3));
                DAT_1C0 ^= 2;
            }
            
            FUN_62F3C(ref DAT_40);
            FUN_66208();

            if ((DAT_1C0 & 1) != 0 && (DAT_3C == 1 || DAT_3C == 4))
                FUN_65A28();

            SceneManager.instance.FUN_80030(this, DAT_18D, 1);
            FUN_52618();
            GameManager.instance.FUN_82EFC(this, ref local_18, ref local_14);

            if (DAT_3C == 1)
            {
                bVar1 = DAT_3D;

                if (bVar1 == 1 || bVar1 == 5)
                {
                    DAT_1D8 = local_18;
                    DAT_1D4 = local_14;
                }
            }

            if (DAT_152 == 0)
                screen.y += 200;

            FUN_6449C(DAT_140);
            DAT_48 = (sbyte)-((ushort)screen.y / 0x1a9);
            bVar5 = SceneManager.instance.FUN_80A14(this);

            if (!bVar5)
                bVar3 = (byte)(DAT_162 & 0xfd);
            else
                bVar3 = (byte)(DAT_162 | 2);

            DAT_162 = bVar3;
            bVar1 = DAT_177;

            if (bVar1 != 0)
                DAT_177 = (byte)(bVar1 - 1);
        }
    }

    public void FUN_4D23C()
    {
        short sVar2;

        flags = 1;
        tags = 0;
        FUN_604A4((Tmd2ScriptableObject)GameManager.instance.playerCore.objects[0x8018066C]);
        sVar2 = 1200;

        if (GameManager.instance.difficulty != _DIFFICULTY.Normal)
            sVar2 = 2400;

        maxHealth = sVar2;
        //health = GameManager.instance.playerHealth;
        health = maxHealth; //tmp
        DAT_240 = GameManager.instance.DAT_A100;
        DAT_1C0 = GameManager.instance.DAT_A0F4;
        DAT_1E8 = GameManager.instance.DAT_A0F2;
        DAT_244[0] = GameManager.instance.DAT_A0F8[0];
        DAT_244[1] = GameManager.instance.DAT_A0F8[1];
        DAT_244[2] = GameManager.instance.DAT_A0F8[2];
        //FUN_4FE90(DAT_240);
        FUN_4FE90(0x20); //tmp
        FUN_65984(11, 14);
        FUN_66404(8, 0x1000, 0x1000);
        DAT_1CF = 0;
        DAT_1C6 = 0;
        DAT_1F9 = 0;
        DAT_1F8 = 0;
        DAT_1CA = 0;
        DAT_1C9 = 0;
        DAT_1CD = 0;
        DAT_227 = 0;
        DAT_177 = 0;
        DAT_152 = 0;
        DAT_140 = 0;
        DAT_12C = 0;
        DAT_11E = 0;
        DAT_226 = -0x80;
        DAT_120 = 0;
        PTR_120 = DAT_9CDB0;
        DAT_124 = 0;
        PTR_124 = DAT_9CDB0;
        DAT_130 = 1;
        PTR_130 = DAT_9CDB0;
        DAT_18D = true;
        DAT_12E = 1;
        DAT_12F = 1;
        DAT_46 = 320;
        flags |= 2;
        //FUN_4FE0C
        DAT_34 = screen;
        DAT_13C = new Vector2Int(screen.x, screen.z);
        FUN_60444();
        FUN_65984(11, 14);
        DAT_175 = 0x87;
        FUN_5342C();
        FUN_4FE30();
        DAT_3C = 1;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 1;
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_220), 1, 0, DAT_220);
    }

    private void FUN_4FE04()
    {
        return;
    }

    private void FUN_4F234()
    {
        PTR_FUN_9CEA4[DAT_3D]();
        DAT_227 &= 0x7f;
    }

    private void FUN_4F284()
    {
        byte bVar1;
        CriInteract oVar2;

        bVar1 = DAT_240;
        oVar2 = SceneManager.instance.FUN_5FF08();
        oVar2.DAT_01 = 5;
        oVar2.DAT_02 = bVar1;
        oVar2.DAT_04 = (byte)(((uint)bVar1 >> 4) + 0x1f);
        InventoryManager.FUN_4A7E8(11, ((uint)bVar1 >> 4) * 4 + ((bVar1 & 0xfU) - 3), false);
    }

    private void FUN_4F2E4()
    {
        byte bVar1;
        byte bVar2;
        int iVar3;
        uint uVar5;
        TodScriptableObject oVar6;

        oVar6 = null;
        bVar1 = DAT_3E;
        uVar5 = (uint)(bVar1 & 0xf);
        bVar2 = (byte)((uint)bVar1 >> 4);

        switch (bVar2)
        {
            case 2:
                if ((DAT_240 & 0xf0) != 0)
                {
                    FUN_4F284();
                    DAT_240 = 0;
                    FUN_4FE90(0);
                }

                goto case 0;
            case 0:
            case 4:
                iVar3 = (int)(uVar5 + 4);
                break;
            case 3:
                if ((DAT_240 & 0xf0) != 0)
                {
                    FUN_4F284();
                    DAT_240 = 0;
                    FUN_4FE90(0);
                }

                goto case 1;
            case 1:
                iVar3 = (int)uVar5;
                break;
            default:
                goto LAB_4F340;
        }

        oVar6 = Utilities.DAT_18770[iVar3];
        LAB_4F340:
        DAT_1C0 &= 0xfffffffe;

        if ((bVar2 & 1) == 0)
            DAT_40 = new Vector3Int(0, 0, 0);
        else
        {
            DAT_40.x = 0;
            DAT_40.z = 0;

            if ((bVar1 & 1) == 0)
                DAT_40.z = DAT_9CED0[uVar5];
            else
                DAT_40.x = DAT_9CED0[uVar5];
        }

        if ((bVar2 & 4) != 0)
        {
            DAT_40.x = 0;
            DAT_40.z = 0;

            if ((bVar1 & 1) == 0)
                DAT_40.z = DAT_9CED8[uVar5];
            else
                DAT_40.x = DAT_9CED8[uVar5];
        }

        GameManager.instance.FUN_5C94C(this, 3);
        DAT_11E |= 0x80;
        FUN_609C8(oVar6, 0, 0, 0);
        DAT_3D++;
    }

    private void FUN_4F4C0()
    {
        byte bVar1;
        ushort uVar2;
        bool bVar3;
        short[] puVar4;

        bVar1 = DAT_3E;
        bVar3 = FUN_60AB4();

        if (bVar3)
        {
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_12C &= 0xfff7;
            DAT_11E &= 0x7f;
        }

        if ((DAT_3E & 0x10) == 0)
        {
            if ((DAT_3E & 0x40) != 0 && 1U < DAT_60)
            {
                if ((bVar1 & 1) == 0)
                    DAT_40.z = 0;
                else
                    DAT_40.x = 0;
            }
        }
        else
        {
            uVar2 = DAT_60;

            if (uVar2 == 7)
                puVar4 = DAT_9CEE0;
            else
            {
                if (uVar2 != 8)
                {
                    if (uVar2 < 10U)
                        return;

                    if ((bVar1 & 1) == 0)
                        DAT_40.z = 0;
                    else
                        DAT_40.x = 0;

                    return;
                }

                puVar4 = DAT_9CEE8;
            }

            if ((bVar1 & 1) == 0)
                DAT_40.z = puVar4[bVar1 & 0xf];
            else
                DAT_40.x = puVar4[bVar1 & 0xf];
        }
    }

    private void FUN_4F5C4()
    {
        DAT_1C0 &= 0xfffffffe;
        DAT_11E |= 0x80;
        FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x8019C230], 0, 0, 0);
        DAT_40.z = -200;
        DAT_3D++;
    }

    private void FUN_4F62C()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            if (DAT_3E != 0 && (DAT_240 & 0xf0) != 0)
            {
                FUN_4F284();
                DAT_240 = 0;
                FUN_4FE90(0);
            }

            GameManager.instance.FUN_5C94C(this, 3);
            FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x8019C388], 0, 0, 0);
            DAT_3D++;
        }
    }

    private void FUN_4F6D8()
    {
        bool bVar1;

        switch (DAT_60)
        {
            case 5:
                DAT_40.z = -140;
                break;
            case 6:
                DAT_40.z = -80;
                break;
            case 7:
                DAT_40.z = -50;
                break;
            case 8:
                DAT_40.z = -30;
                break;
            case 9:
                DAT_40.z = 0;
                break;
        }

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x8019CF60], 0, 0, 0);
            DAT_3D++;
        }
    }

    private void FUN_4F7A0()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x8019D2B0], 0, 0, 0);
            DAT_3D++;
        }
    }

    private void FUN_4F800()
    {
        bool bVar1;

        if (DAT_60 == 38)
            vr.y = vr.y + 0x800 & 0xfff;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x801860CC], 2, 0, 0);
            DAT_3D++;
        }
    }

    private void FUN_4F880()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_11E &= 0x7f;
            DAT_12C &= 0xfff7;
        }
    }

    private void FUN_4F8CC()
    {
        byte bVar1;
        ushort uVar2;
        bool bVar3;
        short[] puVar4;
        uint uVar5;

        uVar5 = DAT_3D;

        if (uVar5 < 2)
        {
            DAT_40.x = 0;
            DAT_40.z = 0;

            if ((DAT_3D & 1) == 0)
                DAT_40.z = DAT_9CEF0[uVar5];
            else
                DAT_40.x = DAT_9CEF0[uVar5];

            GameManager.instance.FUN_5C94C(this, 3);
            FUN_609C8(Utilities.DAT_18770[uVar5], 0, 0, 0);
        }
        else
        {
            if (uVar5 == 2)
            {
                bVar3 = FUN_60AB4();

                if (bVar3)
                {
                    DAT_3C = 1;
                    DAT_3D = 0;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_12C &= 0xfff7;
                    DAT_11E &= 0x7f;
                }

                uVar2 = DAT_60;

                if (uVar2 == 7)
                {
                    bVar1 = DAT_3D;
                    puVar4 = DAT_9CEF8;
                }
                else
                {
                    if (uVar2 != 8)
                    {
                        if (uVar2 < 10U)
                            return;

                        if ((DAT_3D & 1) == 0)
                            DAT_40.z = 0;
                        else
                            DAT_40.x = 0;
                    }

                    bVar1 = DAT_3D;
                    puVar4 = DAT_9CF00;
                }

                if ((DAT_3D & 1) == 0)
                    DAT_40.z = puVar4[bVar1];
                else
                    DAT_40.x = puVar4[bVar1];
            }
        }
    }

    private void FUN_4FA28()
    {
        short sVar1;
        int iVar2;
        uint uVar3;
        TodScriptableObject oVar4;

        sVar1 = (short)(DAT_1F4 | DAT_1F5 << 8);
        uVar3 = DAT_3F;
        oVar4 = null;

        if (DAT_3E == 0)
        {
            iVar2 = (int)(uVar3 + 4);
            oVar4 = Utilities.DAT_18770[iVar2];
        }
        else
        {
            if (DAT_3E == 1)
            {
                iVar2 = (int)uVar3;
                oVar4 = Utilities.DAT_18770[iVar2];
            }
        }

        if (uVar3 == 1)
            DAT_40.x = -sVar1;
        else
        {
            if (uVar3 < 2)
            {
                if (uVar3 == 0)
                {
                    DAT_40.x = 0;
                    DAT_40.z = -sVar1;
                }

                goto LAB_4FB00;
            }

            if (uVar3 == 2)
            {
                DAT_40.x = 0;
                DAT_40.z = sVar1;
                goto LAB_4FB00;
            }

            if (uVar3 != 3) goto LAB_4FB00;

            DAT_40.x = sVar1;
        }

        DAT_40.z = 0;
        
        LAB_4FB00:
        if ((DAT_3E & 0x70) != 0 && (DAT_240 & 0xf0) != 0)
        {
            FUN_4F284();
            DAT_240 = 0;
            FUN_4FE90(0);
        }

        GameManager.instance.FUN_5C94C(this, 3);
        DAT_11E |= 0x80;
        FUN_609C8(oVar4, 0, 0, 0);
        DAT_3D++;
    }

    private void FUN_4FB94()
    {
        bool bVar1;
        int iVar1;
        uint uVar2;
        int iVar3;
        byte[] local_18;

        local_18 = Utilities.DAT_18824;
        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_12C &= 0xfff7;
            DAT_11E &= 0x7f;
        }

        uVar2 = DAT_3E & 0xfU;

        if ((uint)local_18[uVar2] < DAT_60)
        {
            DAT_40.x = 0;
            DAT_40.z = 0;
            DAT_18C = 0x81;
        }
        else if ((uint)local_18[uVar2 + 2] < DAT_60)
        {
            iVar1 = DAT_40.x << 0x10;
            iVar3 = DAT_40.z << 0x10;
            DAT_40.x = (short)((iVar1 >> 0x10) - (int)((uint)iVar1 >> 0x1f) >> 1);
            DAT_40.z = (short)((iVar3 >> 0x10) - (int)((uint)iVar3 >> 0x1f) >> 1);
        }
    }

    public void FUN_4FE90(uint param1)
    {
        sbyte sVar1;
        CriBone oVar2;
        uint uVar3;
        uint uVar4;
        int iVar5;
        CriObject oVar6;
        uint uVar8;

        uVar4 = param1 & 3;
        param1 >>= 4;
        uVar3 = (uint)DAT_244[param1 - 1] >> 8;
        DAT_1C0 &= 0xffffffbf;
        uVar8 = uVar4;

        if (param1 == 2)
        {
            if (1 < uVar4 && uVar3 != 7)
            {
                uVar8 = uVar4 - 2;
                uVar4 = uVar8 & 0xff;
            }

            if ((uVar4 == 1 || uVar4 == 3) && GameManager.instance.DAT_A2D0)
                DAT_1C0 |= 0x40;
        }

        if (param1 == 1 && (uVar8 & 0xff) == 1 && uVar3 - 2 < 4)
            uVar8 = 0;

        if (uVar3 == 9)
            uVar8 += 2;

        if (GameManager.instance.DAT_A2D3 == 3)
            uVar8 += 4;

        if (param1 != 0)
        {
            uVar3 = Utilities.PTR_DAT_9CF68[param1 - 1][uVar8 & 0xff];

            if (uVar3 != Utilities.DAT_9CFB8)
                SharedAssets.assets[uVar3 & 0xffff].Init();
        }

        uVar4 = 0;
        iVar5 = (int)(uVar8 & 3);
        DAT_21C = Utilities.DAT_9CFA8[param1][iVar5];
        oVar2 = (CriBone)Utilities.FUN_601C8(skeleton, 3);
        oVar2.cMesh = Utilities.GetSharedObject(DAT_21C) as Tmd3ScriptableObject;
        oVar2.materials = new Material[16];
        Tmd3ScriptableObject tmd = oVar2.cMesh;
        Material mat1 = new Material(GameManager.instance.materials[0]);
        mat1.mainTexture = tmd.TEX_2D;
        mat1.SetTexture("_Tex8", tmd.TEX8_2D);
        mat1.SetTexture("_CLUT", tmd.CLUT_2D);
        oVar2.materials[0] = mat1;
        FUN_4FE30();
        return; //tmp

        do
        {
            oVar6 = SceneManager.instance.DAT_5FCC[uVar4];
            sVar1 = oVar6.tags;

            if (sVar1 == 4 || sVar1 == 7 || sVar1 == 12)
                oVar6.FUN_60068();

            uVar4++;
        } while (uVar4 < 60);
    }

    public void FUN_4FE30()
    {
        if (550 < health)
        {
            DAT_1D7 = 0;
            DAT_220 = DAT_21C + 4;
        }

        else if (250 < health)
        {
            DAT_1D7 = 1;
            DAT_220 = DAT_21C + 0x20;
        }
        else
        {
            DAT_1D7 = 2;
            DAT_220 = DAT_21C + 0x3c;
        }
    }

    private void FUN_4FC8C()
    {
        TodScriptableObject[] local_18;

        local_18 = new TodScriptableObject[2]
        {
            (TodScriptableObject)GameManager.instance.playerCore.objects[0x80189774],
            (TodScriptableObject)GameManager.instance.playerCore.objects[0x8018A058]
        };

        if (DAT_3E == 0)
        {
            DAT_11E |= 0x81;
            DAT_40 = new Vector3Int(0, 0, 0);
            DAT_1C0 &= 0xfffffffe;
            FUN_535E4(0x20, 0x20);
            DAT_227 &= 0x7f;
            DAT_112 = 0;
            FUN_609C8(local_18[DAT_3F], 0, 6, 0);
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }
    }

    private void FUN_4D428()
    {
        short sVar1;
        int iVar2;
        CriParticle oVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        CriBone oVar5;
        ushort uVar6;

        if ((DAT_1C0 & 4) != 0)
        {
            sVar1 = (short)(DAT_1E8 - 1);
            DAT_1E8 = (ushort)sVar1;

            if (sVar1 < 1)
            {
                DAT_1E8 = 0;
                DAT_1C0 &= 0xfffffffb;
            }
            else
            {
                if ((sVar1 % 18 & 0xffff) == 0 && 1 < health)
                {
                    health--;
                    FUN_4FE30();
                }

                sVar1 = (short)DAT_1E8;
                iVar2 = Utilities.Rand();
                iVar4 = 30 - sVar1 / 270 & 0xff;

                if (iVar4 == 0)
                    return; //trap(0x1c00)

                if (iVar4 == -1 && iVar2 == -0x80000000)
                    return; //trap(0x1800)

                iVar5 = DAT_1E8;

                if (iVar5 < 5251)
                {
                    iVar4 = iVar2 % iVar4 & 0xff;

                    if (3000 < iVar5 && (iVar5 % 100) * 0x10000 >> 0x10 < 5)
                        iVar4 = 1;
                }
                else
                    iVar4 = DAT_1E8 & 3;

                if (iVar4 == 1)
                {
                    oVar2 = SceneManager.instance.FUN_5FFA0();

                    if (oVar2 != null)
                    {
                        oVar5 = (CriBone)Utilities.FUN_601C8(skeleton, 0);
                        oVar2.tags = 2;
                        sVar1 = (short)(DAT_1E8 / 0x546);
                        iVar3 = Utilities.Rand();
                        uVar6 = (ushort)(sVar1 + 4);

                        if (iVar3 % 3 == 1)
                            uVar6 = (ushort)(sVar1 + 6);

                        oVar2.DAT_62 = (ushort)(uVar6 & 0xff);
                        oVar2.DAT_60 = (ushort)(uVar6 & 0xff);
                        iVar3 = Utilities.Rand();
                        oVar2.screen.x -= (iVar3 & 0xff) - 0x80;
                        iVar3 = Utilities.Rand();
                        oVar2.screen.z -= (iVar3 & 0xff) - 0x80;
                        oVar2.screen.y = oVar5.screen.y;
                    }
                }
            }
        }
    }

    private void FUN_4D6D0()
    {
        if ((GameManager.DAT_1f80000a & 2) != 0)
            DAT_1C6 = 1;

        if (DAT_1C5 != 0)
        {
            DAT_1C5--;
            GameManager.DAT_1f800008 |= 8;
        }

        PTR_FUN_9CE04[DAT_3D]();

        if (health != DAT_1EA)
            FUN_4FE30();

        DAT_1EA = health;
        FUN_4D428();
    }

    private void FUN_4D7A4()
    {
        uint uVar1;
        byte bVar2;
        byte bVar3;
        uint uVar4;
        uint uVar5;
        int iVar6;

        uVar1 = GameManager.DAT_1f800008 | 
            (uint)GameManager.DAT_1f80000a << 0x10;

        switch (DAT_3E)
        {
            case 0:
                DAT_40 = new Vector3Int(0, 0, 0);

                if (DAT_3F == 0)
                    iVar6 = 6;
                else
                    iVar6 = DAT_3F - 1;

                FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_220), 1, (byte)iVar6, DAT_220);
                DAT_1F4 = 90;
                DAT_1C0 |= 1;

                if (DAT_1D7 == 0)
                    DAT_3E++;
                else
                    DAT_3E = 4;

                break;
            case 1:
                if (DAT_5D == 0)
                    DAT_18C = 0;

                FUN_60AB4();
                bVar2 = (byte)(DAT_1F4 - 1);
                DAT_1F4 = bVar2;

                if (bVar2 == 0)
                {
                    if (DAT_1F8 != 0)
                    {
                        FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x8018fdc8], 0, 6, 0);
                        bVar3 = 0x3c;
                        DAT_1F4 = bVar3;
                        DAT_3E++;
                        break;
                    }

                    DAT_1F4 = 90;
                }

                break;
            case 2:
                FUN_60AB4();
                bVar2 = (byte)(DAT_1F4 - 1);
                DAT_1F4 = bVar2;

                if (bVar2 == 0)
                {
                    FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x80190604], 1, 0, 0);
                    DAT_1C0 &= 0xfffffffe;
                    uVar4 = (uint)Utilities.Rand();
                    bVar3 = Utilities.DAT_187BC[(uVar4 & 3) * 2];
                    DAT_1F4 = bVar3;
                    DAT_3E++;
                }

                break;
            case 3:
                FUN_60AB4();

                if (DAT_1F8 == 0)
                {
                    DAT_3F = 0;
                    DAT_3E = 0;
                }

                break;
            case 4:
                if (DAT_5D == 0)
                    DAT_18C = 0;

                FUN_60AB4();
                break;
        }

        InventoryManager.FUN_4A7E8(1, 0xb, false);

        if ((uVar1 & 8) != 0)
        {
            DAT_18C = 0;
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
            return;
        }

        if (DAT_1C6 == 0 || (uVar1 & 2) == 0)
        {
            if ((uVar1 & 0xa00000) != 0)
            {
                DAT_18C = 0;
                InventoryManager.FUN_4A7E8(2, 8, true);
                return;
            }

            if ((uVar1 & 0x1000) == 0)
            {
                uVar5 = 0x401;

                if ((uVar1 & 0xa000) != 0)
                {
                    DAT_18C = 0;
                    goto LAB_4DAC0;
                }

                if ((uVar1 & 0x4000) == 0)
                    return;

                DAT_18C = 0;
                DAT_1F5 = 2;
                uVar5 = 0x201;
            }
            else
            {
                DAT_18C = 0;

                if ((uVar1 & 0x40) == 0)
                {
                    DAT_1F5 = 4;
                    uVar5 = 0x101;
                }
                else
                {
                    DAT_1F5 = 10;
                    uVar5 = 0x501;
                }
            }

            DAT_1F4 = 0;
        }
        else
            uVar5 = 0x1000901;

        LAB_4DAC0:
        DAT_3C = (byte)(uVar5 & 0xff);
        DAT_3D = (byte)((uVar5 & 0xff00) >> 8);
        DAT_3E = (byte)((uVar5 & 0xff0000) >> 0x10);
        DAT_3F = (byte)((uVar5 & 0xff000000) >> 0x18);
    }

    private void FUN_4DADC()
    {
        short sVar1;
        uint uVar2;
        byte bVar3;
        uint uVar4;

        uVar4 = GameManager.DAT_1f800008 | 
            (uint)GameManager.DAT_1f80000a << 0x10;
        PTR_FUN_9CE2C[DAT_3E]();
        InventoryManager.FUN_4A7E8(1, 0xb, false);

        if ((uVar4 & 8) != 0)
        {
            uVar4 = frameNum + 6U;
            bVar3 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
            DAT_1F5 = 8;
            DAT_1F6 = bVar3;
            DAT_1F4 = (byte)(uVar4 + (uVar4 / 33) * -33);
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 5;
            DAT_3F = 0;
            return;
        }

        if ((uVar4 & 0xa00000) != 0)
        {
            InventoryManager.FUN_4A7E8(2, 8, true);
            return;
        }

        if ((uVar4 & 0x1000) == 0)
        {
            uVar2 = 1;

            if (DAT_5D == 0)
            {
                bVar3 = 0x80;

                if (14U < frameNum)
                    bVar3 = 0x81;

                DAT_18C = bVar3;
                uVar2 = 1;
            }

            goto LAB_4DC9C;
        }

        if ((uVar4 & 0x2000) == 0)
        {
            if ((uVar4 & 0x8000) != 0)
            {
                sVar1 = (short)(vr.y - 0x20);
                vr.y = sVar1;
            }
        }
        else
        {
            sVar1 = (short)(vr.y + 0x20);
            vr.y = sVar1;
        }

        if ((uVar4 & 0x40) == 0)
            return;

        DAT_1F5 = 10;
        DAT_1F4 = (byte)((uint)(frameNum * 20) / 30);
        uVar2 = 0x501;
        LAB_4DC9C:
        DAT_3C = (byte)(uVar2 & 0xff);
        DAT_3D = (byte)((uVar2 & 0xff00) >> 8);
        DAT_3E = (byte)((uVar2 & 0xff0000) >> 0x10);
        DAT_3F = (byte)((uVar2 & 0xff000000) >> 0x18);
    }

    private void FUN_4DCB4()
    {
        short sVar1;

        FUN_6103C((TodScriptableObject)Utilities.GetSharedObject(DAT_220 + 4), 1, DAT_1F4, DAT_1F5);
        DAT_18C = 0;
        sVar1 = Utilities.DAT_18790[DAT_1D7];
        DAT_1C0 &= 0xfffffffe;
        DAT_40.z = sVar1;
        DAT_1F4 = 0;
        DAT_3E = 1;
    }

    private void FUN_4DD3C()
    {
        bool bVar1;

        bVar1 = FUN_4E694();

        if (!bVar1)
            DAT_1F4 = 0;
        else
            DAT_1F4++;

        if (15U < DAT_1F4)
        {
            DAT_1F4 = 0;
            DAT_3C = 1;
            DAT_3D = 7;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_40 = new Vector3Int(0, 0, 0);
        }

        FUN_60AB4();
    }

    private void FUN_4DDC0()
    {
        short sVar1;
        uint uVar2;
        uint uVar3;
        byte bVar4;

        uVar2 = GameManager.DAT_1f800008 | 
            (uint)GameManager.DAT_1f80000a << 0x10;

        if (DAT_3E == 0)
        {
            FUN_6103C((TodScriptableObject)Utilities.GetSharedObject(DAT_220 + 8), 1, DAT_1F4, DAT_1F5);
            DAT_1C0 &= 0xfffffffe;
            sVar1 = Utilities.DAT_187A0[DAT_1D7];
            DAT_3E++;
            DAT_40.z = sVar1;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }

        InventoryManager.FUN_4A7E8(1, 0xb, false);

        if ((uVar2 & 8) == 0)
        {
            if ((uVar2 & 0x4000) == 0)
            {
                bVar4 = 0x80;

                if (17U < frameNum)
                    bVar4 = 0x81;

                uVar3 = 1;
                DAT_18C = bVar4;
            }
            else
            {
                if ((uVar2 & 0x2000) == 0)
                {
                    if ((uVar2 & 0x8000) == 0)
                        DAT_40.z = -40;
                    else
                    {
                        DAT_40.z = -30;
                        vr.y -= 0x20;
                    }
                }
                else
                {
                    DAT_40.z = -30;
                    vr.y += 0x20;
                }

                if (DAT_1C4 != 0)
                    return;

                DAT_1F5 = 6;
                uVar3 = 0x301;
                DAT_1F4 = 0;
            }

            DAT_3C = (byte)(uVar3 & 0xff);
            DAT_3D = (byte)((uVar3 & 0xff00) >> 8);
            DAT_3E = (byte)((uVar3 & 0xff0000) >> 0x10);
            DAT_3F = (byte)((uVar3 & 0xff000000) >> 0x18);
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 6;
            DAT_3F = 0;
            DAT_1F5 = 8;

            if (frameCount == 0)
                return; //trap(0x1c00)

            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
            DAT_1F5 = (byte)(((uint)frameNum << 8) / frameCount);
        }
    }

    private void FUN_4DF9C()
    {
        uint uVar1;
        uint uVar2;
        byte bVar3;

        uVar1 = GameManager.DAT_1f800008 | 
            (uint)GameManager.DAT_1f80000a << 0x10;

        if (DAT_3E == 0)
        {
            FUN_6103C((TodScriptableObject)Utilities.GetSharedObject(DAT_220 + 0xc), 1, DAT_1F4, DAT_1F5);
            DAT_40.z = -40;
            DAT_1C0 &= 0xfffffffe;
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }

        InventoryManager.FUN_4A7E8(1, 0xb, false);

        if ((uVar1 & 8) == 0)
        {
            if ((uVar1 & 0x4000) == 0)
                uVar2 = 1;
            else
            {
                if ((uVar1 & 0x2000) == 0)
                {
                    if ((uVar1 & 0x8000) == 0)
                        DAT_40.z = -40;
                    else
                    {
                        DAT_40.z = -20;
                        vr.y -= 0x20;
                    }
                }
                else
                {
                    DAT_40.z = -20;
                    vr.y += 0x20;
                }

                if (DAT_1C4 == 0)
                    return;

                DAT_1F5 = 2;
                uVar2 = 0x201;
                DAT_1F4 = 0;
            }

            DAT_3C = (byte)(uVar2 & 0xff);
            DAT_3D = (byte)((uVar2 & 0xff00) >> 8);
            DAT_3E = (byte)((uVar2 & 0xff0000) >> 0x10);
            DAT_3F = (byte)((uVar2 & 0xff000000) >> 0x18);
        }
        else
        {
            bVar3 = 0x80;

            if (18U < frameNum)
                bVar3 = 0x81;

            DAT_18C = bVar3;
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
        }
    }

    private void FUN_4E130()
    {
        uint uVar1;
        short sVar2;
        uint uVar3;

        uVar1 = GameManager.DAT_1f800008 |
            (uint)GameManager.DAT_1f80000a << 0x10;

        if (DAT_3E == 0)
        {
            FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_220 + 4), 1, 10, DAT_220 + 4);
            DAT_18C = 0;
            DAT_40.z = 0;
            DAT_1C0 &= 0xfffffffe;
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }

        InventoryManager.FUN_4A7E8(1, 0xb, false);

        if ((uVar1 & 0x2000) == 0)
        {
            if ((uVar1 & 0x8000) == 0) goto LAB_4E218;

            sVar2 = (short)(vr.y - 90);
        }
        else
            sVar2 = (short)(vr.y + 90);

        vr.y = sVar2;

        LAB_4E218:
        if ((uVar1 & 8) == 0)
        {
            if ((uVar1 & 0xa00000) == 0)
            {
                if ((uVar1 & 0x1000) == 0)
                {
                    if ((uVar1 & 0x4000) == 0)
                    {
                        if ((uVar1 & 0xa000) != 0)
                            return;

                        DAT_18C = 1;
                        uVar3 = 1;
                    }
                    else
                    {
                        DAT_1F5 = 2;
                        uVar3 = 0x201;
                        DAT_1F4 = 0;
                    }
                }
                else
                {
                    DAT_18C = 0;
                    DAT_1F5 = 4;
                    DAT_1F4 = frameNum;
                    uVar3 = 0x101;
                }

                DAT_3C = (byte)(uVar3 & 0xff);
                DAT_3D = (byte)((uVar3 & 0xff00) >> 8);
                DAT_3E = (byte)((uVar3 & 0xff0000) >> 0x10);
                DAT_3F = (byte)((uVar3 & 0xff000000) >> 0x18);
            }
            else
                InventoryManager.FUN_4A7E8(2, 8, true);
        }
        else
        {
            DAT_18C = 1;
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
        }
    }

    private void FUN_4E2F0()
    {
        byte bVar1;
        short sVar2;
        short sVar3;
        uint uVar4;
        byte bVar5;
        bool bVar6;
        short sVar7;

        uVar4 = GameManager.DAT_1f800008 |
            (uint)GameManager.DAT_1f80000a << 0x10;
        bVar1 = DAT_3E;

        if (bVar1 == 1)
        {
            bVar1 = DAT_3F;
            sVar7 = Utilities.DAT_18798[DAT_1D7];
            sVar2 = Utilities.DAT_18790[DAT_1D7];
            bVar5 = (byte)(DAT_3F + 1);
            DAT_3F = bVar5;
            DAT_40.z = (short)((((sVar7 * bVar1 + sVar2 * (10 - bVar1)) * 0x10000) >> 0x10) / 10);

            if (10U < bVar5)
            {
                DAT_40.z = Utilities.DAT_18798[DAT_1D7];
                DAT_1F4 = 0;
                DAT_3E++;
            }

            FUN_4E490();
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    if (19U < DAT_1F4)
                        DAT_1F4 = 18;

                    FUN_6103C((TodScriptableObject)Utilities.GetSharedObject(DAT_220 + 0x10), 1, DAT_1F4, DAT_1F5);
                    DAT_1C0 &= 0xfffffffe;
                    DAT_3F = 0;
                    sVar3 = Utilities.DAT_18798[DAT_1D7];
                    DAT_3E++;
                    DAT_40.z = sVar3;
                }
            }
            else
            {
                if (bVar1 == 2)
                    FUN_4E490();
            }
        }

        InventoryManager.FUN_4A7E8(1, 0xb, false);

        if ((uVar4 & 8) != 0)
        {
            DAT_1F5 = 6;
            uVar4 = ((uint)frameNum * 34) / 22;
            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
            DAT_1F4 = (byte)((int)uVar4 + (int)(uVar4 / 34) * -34);
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 5;
            DAT_3F = 0;
            //FUN_4FE0C
            return;
        }

        if ((uVar4 & 0xa00000) != 0)
        {
            InventoryManager.FUN_4A7E8(2, 8, true);
            return;
        }

        if ((uVar4 & 0x1000) == 0)
        {
            DAT_18C = 1;
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            //FUN_4FE0C
            return;
        }

        if ((uVar4 & 0x2000) == 0)
        {
            if ((uVar4 & 0x8000) == 0) goto LAB_4E62C;

            sVar7 = (short)(vr.y - 40);
        }
        else
            sVar7 = (short)(vr.y + 40);

        vr.y = sVar7;

        LAB_4E62C:
        if ((uVar4 & 0x40) == 0)
        {
            DAT_18C = 0;
            DAT_1F5 = 4;
            DAT_1F4 = (byte)(((uint)frameNum * 30) / 20);
            DAT_3C = 1;
            DAT_3D = 1;
            DAT_3E = 0;
            DAT_3F = 0;
        }

        void FUN_4E490()
        {
            bVar6 = FUN_4E694();

            if (!bVar6)
                DAT_1F4 = 0;
            else
                DAT_1F4++;

            if (15U < DAT_1F4)
            {
                DAT_1F4 = 0;
                DAT_3C = 1;
                DAT_3D = 7;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_40 = new Vector3Int(0, 0, 0);
            }

            FUN_60AB4();
        }
    }

    private bool FUN_4E694()
    {
        byte bVar1;
        short sVar2;
        int iVar3;
        uint uVar4;
        CriStatic oVar5;

        oVar5 = DAT_1D8;

        if (oVar5 == null)
            return false;

        if (oVar5.DAT_2E != 1)
            return false;

        if ((byte)oVar5.DAT_74 != 0)
            return false;

        if (DAT_1D4 == 0xff)
            return false;

        uVar4 = (uint)(vr.y + 0x200 & 0xfff);

        if (uVar4 <= DAT_9CE34[DAT_1D4 - 1])
            return false;

        if (DAT_9CE34[DAT_1D4 - 1] + 0x400 <= (int)uVar4)
            return false;

        oVar5.DAT_34.x = oVar5.screen.x;
        oVar5.DAT_34.z = oVar5.screen.z;
        bVar1 = DAT_1D4;

        if (bVar1 == 2)
            sVar2 = (short)(oVar5.screen.x - 15);
        else
        {
            if (bVar1 < 3)
            {
                if (bVar1 == 1)
                    oVar5.screen.z -= 15;

                goto LAB_4E7E0;
            }

            if (bVar1 == 3)
            {
                oVar5.screen.z += 15;
                goto LAB_4E7E0;
            }

            if (bVar1 != 4) goto LAB_4E7E0;

            sVar2 = (short)(oVar5.screen.x + 15);
        }

        oVar5.screen.x = sVar2;
        LAB_4E7E0:
        iVar3 = SceneManager.instance.FUN_826EC(oVar5);
        oVar5.screen.x = oVar5.DAT_34.x;
        oVar5.screen.z = oVar5.DAT_34.z;
        return iVar3 == 0;
    }

    private void FUN_4E81C()
    {
        PTR_FUN_9CE3C[DAT_3E]();
    }

    private void FUN_4E858()
    {
        FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x80186aac), 0, 4, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
    }

    private void FUN_4E8A8()
    {
        byte bVar1;
        short sVar2;
        short sVar3;
        bool bVar4;
        int iVar4;
        CriStatic oVar5;

        oVar5 = DAT_1D8;
        bVar4 = FUN_60AB4();
        sVar3 = Utilities.FUN_51D40(DAT_9CE50[DAT_1D4 - 1], vr.y, 0x80);

        if (!bVar4 || sVar3 != 0)
        {
            vr.y += sVar3;
            bVar1 = DAT_1D4;

            if (bVar1 == 2)
            {
                iVar4 = oVar5.cCollider.DAT_00.z;

                if (oVar5.screen.z + iVar4 - 320 < screen.z)
                {
                    screen.z -= 40;
                    return;
                }

                if (oVar5.screen.z - iVar4 + 320 <= screen.z)
                    return;

                screen.z += 40;
                return;
            }

            if (bVar1 < 3)
            {
                if (bVar1 != 1)
                    return;
            }
            else
            {
                if (bVar1 != 3)
                {
                    if (bVar1 != 4)
                        return;

                    iVar4 = oVar5.cCollider.DAT_00.z;

                    if (oVar5.screen.z + iVar4 - 320 < screen.z)
                    {
                        screen.z -= 40;
                        return;
                    }

                    if (oVar5.screen.z - iVar4 + 320 <= screen.z)
                        return;

                    screen.z += 40;
                    return;
                }
            }

            if (oVar5.screen.x + oVar5.cCollider.DAT_00.x - 320 < screen.x)
            {
                screen.x -= 40;
                return;
            }

            if (oVar5.screen.x - oVar5.cCollider.DAT_00.x + 320 <= screen.x)
                return;

            screen.x += 40;
            return;
        }

        DAT_40.z = 0;
        FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x80186ea4), 1, 0, 0);
        bVar1 = DAT_1D4;

        if (bVar1 == 2)
            sVar3 = (short)(oVar5.screen.x + oVar5.cCollider.DAT_00.x * -2);
        else
        {
            if (bVar1 < 3)
            {
                if (bVar1 != 1) goto LAB_4EAD0;

                sVar3 = (short)(oVar5.screen.z + oVar5.cCollider.DAT_00.z * -2);
            }
            else
            {
                if (bVar1 == 3)
                {
                    sVar2 = (short)oVar5.cCollider.DAT_00.z;
                    sVar3 = (short)oVar5.screen.z;
                }
                else
                {
                    if (bVar1 != 4) goto LAB_4EAD0;

                    sVar2 = (short)oVar5.cCollider.DAT_00.x;
                    sVar3 = (short)oVar5.screen.x;
                }

                sVar3 += (short)(sVar2 * 2);
            }
        }

        V2_1F4.x = sVar3;
        LAB_4EAD0:
        DAT_3E++;
    }

    private void FUN_4EB00()
    {
        short sVar1;
        byte bVar2;
        int iVar3;
        short sVar4;
        int iVar5;
        CriStatic oVar6;

        oVar6 = DAT_1D8;
        iVar5 = 3;

        if (20 < frameNum)
            iVar5 = 13;

        FUN_4EDFC(oVar6, (short)iVar5);
        iVar3 = SceneManager.instance.FUN_826EC(oVar6);

        if (iVar3 != 0)
        {
            while (iVar5 != 0)
            {
                FUN_4EDFC(oVar6, (short)iVar5);
                SceneManager.instance.FUN_826EC(oVar6);
                iVar5--;
            }

            DAT_40.z = 0;
            oVar6.DAT_74 |= 1;
            goto LAB_4EDC8;
        }

        sVar1 = (short)V2_1F4.x;
        oVar6 = DAT_1D8;
       
        if ((DAT_1D4 & 1) == 0)
        {
            if ((oVar6.vr.y & 0x400) == 0)
                sVar4 = (short)oVar6.cCollider.DAT_00.z;
            else
                sVar4 = (short)oVar6.cCollider.DAT_00.x;

            iVar5 = screen.z - oVar6.screen.z;
        }
        else
        {
            if ((oVar6.vr.y & 0x400) == 0)
                sVar4 = (short)oVar6.cCollider.DAT_00.x;
            else
                sVar4 = (short)oVar6.cCollider.DAT_00.z;

            iVar5 = screen.x - oVar6.screen.x;
        }

        if (iVar5 < 0)
            iVar5 = -iVar5;

        if (sVar4 < iVar5)
        {
            oVar6.DAT_74 |= 1;
            InventoryManager.FUN_4A7E8(2, 0x1b, true);
            DAT_3E++;
        }

        sVar4 = (short)DAT_60;

        if (sVar4 == 15)
        {
            //FUN_1D988
            sVar4 = (short)DAT_60;
        }

        if (sVar4 == 20)
            GameManager.instance.FUN_5C94C(this, 206);

        FUN_60AB4();
        bVar2 = DAT_1D4;

        if (bVar2 == 2)
        {
            if (sVar1 <= oVar6.screen.x)
                return;

            bVar2 = (byte)oVar6.DAT_74;
            oVar6.screen.x = sVar1;
        }
        else
        {
            if (bVar2 < 3)
            {
                if (bVar2 != 1)
                    return;

                if (sVar1 <= oVar6.screen.z)
                    return;

                bVar2 = (byte)oVar6.DAT_74;
                oVar6.screen.z = sVar1;
            }
            else
            {
                if (bVar2 != 3)
                {
                    if (bVar2 != 4)
                        return;

                    if (oVar6.screen.x <= sVar1)
                        return;

                    bVar2 = (byte)oVar6.DAT_74;
                    oVar6.screen.x = sVar1;
                }
                else
                {
                    if (oVar6.screen.z <= sVar1)
                        return;

                    bVar2 = (byte)oVar6.DAT_74;
                    oVar6.screen.z = sVar1;
                }
            }
        }

        oVar6.DAT_74 &= 0xffffff00;
        oVar6.DAT_74 |= bVar2 | 1U;
        LAB_4EDC8:
        InventoryManager.FUN_4A7E8(2, 0x1b, true);
        DAT_3E++;
    }

    private void FUN_4EDFC(CriStatic param1, short param2)
    {
        byte bVar1;

        param1.DAT_34.x = param1.screen.x;
        param1.DAT_34.z = param1.screen.z;
        bVar1 = DAT_1D4;

        if (bVar1 == 2)
        {
            screen.x = (screen.x - 100) - param2;
            param1.screen.x -= param2;
            return;
        }

        if (bVar1 < 3)
        {
            if (bVar1 != 1)
                return;

            screen.z = (screen.z - 100) - param2;
            param1.screen.z -= param2;
            return;
        }

        if (bVar1 == 3)
        {
            screen.z = param2 + screen.z + 100;
            param1.screen.z += param2;
            return;
        }

        if (bVar1 != 4)
            return;

        screen.x = param2 + screen.x + 100;
        param1.screen.x += param2;
    }

    private void FUN_4EEF0()
    {
        FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x80186aac), 2, 4, 0);
        GameManager.instance.FUN_5C860(206);
        DAT_40.z = 0;
        DAT_3E++;
    }

    private void FUN_4EF40()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
        }
    }

    private void FUN_4EF74()
    {
        bool bVar1;
        uint uVar2;

        switch (DAT_3E)
        {
            case 0:
                uVar2 = 0;
                goto LAB_4F028;
            case 1:
                bVar1 = FUN_60AB4();

                if (bVar1)
                    DAT_3E++;

                if (DAT_60 == 10)
                    ; //FUN_5C94C

                break;
            case 2:
                FUN_60AB4();
                break;
            case 3:
                uVar2 = 2;
                LAB_4F028:
                FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x801860CC], (byte)uVar2, 0, 0);
                DAT_3E++;
                break;
            case 4:
                bVar1 = FUN_60AB4();

                if (bVar1)
                {
                    //FUN_5C94C
                    DAT_3C = 1;
                    DAT_3D = 0;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }

                break;
            default:
                return;
        }
    }

    private void FUN_4F074()
    {
        ushort uVar1;
        TodScriptableObject oVar2;
        uint uVar3;
        uint uVar4;

        if (DAT_3E == 0)
        {
            DAT_40.z = 0;
            DAT_1C0 &= 0xfffffffe;

            if (DAT_3F == 0)
            {
                oVar2 = (TodScriptableObject)Utilities.GetSharedObject(DAT_220);
                uVar4 = DAT_220;
                uVar3 = 14;
            }
            else
            {
                oVar2 = (TodScriptableObject)Utilities.GetSharedObject(DAT_220 + 4);
                uVar4 = DAT_220 + 4;
                uVar3 = 5;
            }

            FUN_609C8(oVar2, 1, (byte)uVar3, uVar4);
            DAT_1F4 = (byte)(vr.y & 0xff);
            DAT_1F5 = (byte)((vr.y & 0xff00) >> 8);
            DAT_1F6 = (byte)(vr.y + 0x800 & 0xff);
            DAT_1F7 = (byte)((vr.y + 0x800 & 0xff00) >> 8);
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }

        uVar1 = (ushort)((short)(DAT_1F4 | DAT_1F5 << 8) +
                        Utilities.DAT_187A8[DAT_1D7]);
        DAT_1F4 = (byte)(uVar1 & 0xff);
        DAT_1F5 = (byte)((uVar1 & 0xff00) >> 8);
        vr.y = (short)(uVar1 & 0xfff);

        if ((short)(DAT_1F6 | DAT_1F7 << 8) <= (short)(DAT_1F4 | DAT_1F5 << 8))
        {
            vr.y = (short)(DAT_1F6 | DAT_1F7 << 8);
            DAT_1C6 = 0;
            DAT_40.z = 0;
            DAT_40.x = 0;
            DAT_18C = 0;
            DAT_3C = 0;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
        }
    }

    private bool FUN_40834(Vector2Int param1, byte param2)
    {
        short sVar1;
        ushort uVar2;
        uint uVar3;
        Vector3Int local_20;

        sVar1 = FUN_64804(SceneManager.instance.DAT_27C[10].screen);

        if (param2 - 2U < 3)
        {
            if (UDAT_20C < 5000)
            {
                if (0xc00U < (ushort)(sVar1 - 0x200))
                {
                    DAT_3C = 1;
                    DAT_3D = 12;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_1E6 = 120;
                    uVar2 = (ushort)((param2 - 1) * 50 + 50);
                    DAT_1E8 = (ushort)uVar2;

                    if (uVar2 < 100U)
                        DAT_1E8 = 100;

                    DAT_208 |= 0x200;
                    GameManager.instance.FUN_65C7C(this);
                    return true;
                }

                return false;
            }
        }
        else
        {
            if (3 < param2 - 2U)
            {
                if (2 < param2 - 1U)
                    return false;

                if (4999 < UDAT_20C)
                    return false;

                if (0xc00U < (ushort)(sVar1 - 0x200))
                {
                    DAT_3C = 1;
                    DAT_3D = 12;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_1E6 = 120;
                    uVar2 = (ushort)((param2 - 1) * 50 + 50);
                    DAT_1E8 = (ushort)uVar2;

                    if (uVar2 < 100U)
                        DAT_1E8 = 100;

                    DAT_208 |= 0x200;
                    GameManager.instance.FUN_65C7C(this);
                    return true;
                }

                return false;
            }
        }

        if ((ushort)(sVar1 - 0x200) < 0xc01U)
            return false;

        local_20 = new Vector3Int(param1.x, 0, param1.y);
        uVar3 = Utilities.FUN_631AC(screen, local_20);

        if (uVar3 << 1 <= UDAT_20C)
        {
            if (2199 < uVar3)
                return false;

            uVar3 = (uVar3 + 800) / 22;
            UDAT_1E4 = (ushort)uVar3;

            if ((uVar3 & 0xffff) < 60)
                UDAT_1E4 = 60;

            DAT_1E8 = (ushort)((param2 - 2) * 50 + 100);
            DAT_3C = 1;
            DAT_3D = 34;
            DAT_3E = 0;
            DAT_3F = 0;
            return true;
        }

        return false;
    }

    private void FUN_40A1C()
    {
        bool bVar1;
        sbyte sVar1;
        byte bVar2;
        short sVar3;
        int iVar4;
        int iVar5;
        uint uVar6;
        uint uVar7;

        sVar3 = FUN_64804(SceneManager.instance.DAT_27C[10].screen);

        if ((ushort)(sVar3 - 0x200) < 0xc00U)
        {
            if ((ushort)(sVar3 - 0x200) < 0x400U)
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar5 = iVar4;

                if (iVar4 < 0)
                    iVar5 = iVar4 + 3;

                uVar7 = (uint)(iVar4 + (iVar5 >> 2) * -4);
                iVar4 = 1;
            }
            else
            {
                if ((ushort)(sVar3 - 0x600) < 0x400U)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    iVar5 = iVar4;

                    if (iVar4 < 0)
                        iVar5 = iVar4 + 3;

                    uVar7 = (uint)(iVar4 + (iVar5 >> 2) * -4);
                    iVar4 = 2;
                }
                else
                {
                    iVar4 = 3;
                    iVar5 = (int)GameManager.FUN_64650();
                    uVar7 = (uint)(iVar5 % 3);
                }
            }
        }
        else
        {
            iVar4 = (int)GameManager.FUN_64650();
            iVar5 = iVar4;

            if (iVar4 < 0)
                iVar5 = iVar4 + 3;

            uVar7 = (uint)(iVar4 + (iVar5 >> 2) * -4);
            iVar4 = 0;
        }

        sVar1 = (sbyte)Utilities.FUN_22EF4(this, uVar7 + (uint)iVar4 * 4 & 0xff);
        uVar6 = uVar7;

        if (sVar1 != 0)
        {
            uVar6 = Utilities.FUN_22F08(this, (uint)iVar4);

            if ((uVar6 & 0xff) == 0xff)
            {
                SceneManager.instance.FUN_23068((byte)iVar4, (byte)(uVar7 & 0xff));
                uVar6 = uVar7;
            }
        }

        bVar1 = Utilities.FUN_2EC6C(this, (byte)iVar4, (byte)uVar6);

        if (bVar1)
        {
            bVar2 = (byte)(DAT_199 + 1);
            DAT_199 = bVar2;
            DAT_19A |= (ushort)(1 << ((int)uVar6 + iVar4 * 4 & 0x1f));

            if (4 < bVar2)
            {
                DAT_199 = 4;
                SceneManager.instance.FUN_22F9C();
            }
        }
    }

    private void FUN_40CD8()
    {
        uint uVar1;

        if ((DAT_11E & 0x80) != 0)
        {
            if ((DAT_18E & 4) != 0)
                DAT_18E &= 0xfb;

            DAT_11E &= 0x7b;

            if ((DAT_208 & 0x400) != 0)
                DAT_208 &= 0xfffffbff;

            DAT_208 |= 1;
            uVar1 = (uint)(DAT_1A0 | DAT_1A1 << 8) >> 4 & 0xf;
            SceneManager.instance.DAT_C3360 = (ushort)uVar1;
            PTR_FUN_9C660[uVar1]();
        }

        FUN_2E9CC();
    }

    private void FUN_40CA4()
    {
        if (GameManager.instance.DAT_A2D2 == 0)
        {
            health = 335;
            return;
        }

        health = 160;
    }

    private void FUN_40D94()
    {
        PTR_FUN_9C674[(DAT_1A1 & 0xf) != 6 ? 1 : 0]();
    }

    private void FUN_40DDC()
    {
        sbyte sVar1;
        byte bVar2;
        short sVar3;
        int iVar4;
        int iVar5;
        ushort uVar6;
        uint uVar7;
        uint uVar8;
        int puVar9;
        ushort[] aVar9;
        int iVar10;
        ushort uVar11;

        if ((DAT_11E & 1) != 0)
        {
            DAT_11E |= 4;
            goto LAB_41B40;
        }

        iVar4 = (int)GameManager.FUN_64650();
        BDAT_1DC = 4;
        DAT_1D5 = 0;

        if (GameManager.instance.DAT_A2D2 == 0)
        {
            aVar9 = Utilities.DAT_9B4A0;
            puVar9 = 0x10;
            iVar10 = 5;
        }
        else
        {
            aVar9 = Utilities.DAT_9B500;
            puVar9 = 0x10;
            iVar10 = 60;
        }

        if (DAT_3C != 2 && (ushort)(DAT_3C | DAT_3D << 8) != 0xe01)
            DAT_1C3 = -1;

        uVar6 = (ushort)(DAT_1A0 & 0xf);

        if (uVar6 == 1)
        {
            iVar5 = (int)GameManager.FUN_64650();

            if (iVar10 == 0)
                return; //trap(0x1c00)

            if (iVar10 == -1 && iVar5 == -0x80000000)
                return; //trap(0x1800)

            uVar8 = (uint)(iVar5 % iVar10);
        }
        else
        {
            uVar8 = 1;

            if (uVar6 == 3)
            {
                iVar5 = (int)GameManager.FUN_64650();

                if (iVar10 == 0)
                    return; //trap(0x1c00)

                if (iVar10 == -1 && iVar5 == -0x80000000)
                    return; //trap(0x1800)

                uVar8 = (uint)(iVar5 % iVar10);
            }
        }

        uVar11 = (ushort)(DAT_3C | DAT_3D << 8);

        if (uVar11 == 0xc01)
        {
            if (8U < DAT_60)
            {
                if (DAT_60 - 9U < 10)
                {
                    if ((uVar8 & 0xff) == 0)
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar8 = aVar9[puVar9 + 7];

                        if (uVar8 == 0)
                            return; //trap(0x1c00)

                        if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar8 = (uint)(aVar9[puVar9 + 6] + iVar4 % (int)uVar8);
                        DAT_11C = (short)uVar8;
                        DAT_1C3 = 3;
                        health -= (short)(((uVar8 & 0xffff) * 130) / 100);
                        goto LAB_41930;
                    }

                    iVar4 = (int)GameManager.FUN_64650();
                    uVar8 = aVar9[puVar9 + 3];

                    if (uVar8 == 0)
                        return; //trap(0x1c00)

                    if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    iVar4 = aVar9[puVar9 + 2] + iVar4 % (int)uVar8;
                    iVar10 = (ushort)health - iVar4;
                    health = (short)iVar10;
                    DAT_11C = (short)iVar4;

                    if (iVar10 * 0x10000 < 1)
                    {
                        DAT_1C3 = 3;
                        goto LAB_41930;
                    }

                    DAT_11E |= 4;
                    uVar8 = DAT_208;
                    uVar7 = 0x400000;
                }
                else
                {
                    if ((uVar8 & 0xff) == 0)
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar8 = aVar9[puVar9 + 7];

                        if (uVar8 == 0)
                            return; //trap(0x1c00)

                        if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar11 = (ushort)(iVar4 % (int)uVar8);
                        uVar6 = aVar9[puVar9 + 6];
                        DAT_1C3 = 3;
                        sVar3 = (short)(health - (uVar6 + uVar11));
                        DAT_11C = (short)(uVar6 + uVar11);
                        health = sVar3;
                        goto LAB_41930;
                    }

                    iVar4 = (int)GameManager.FUN_64650();
                    uVar8 = aVar9[puVar9 + 7];

                    if (uVar8 == 0)
                        return; //trap(0x1c00)

                    if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar8 = (uint)(aVar9[puVar9 + 6] + iVar4 % (int)uVar8);
                    DAT_11C = (short)uVar8;
                    iVar4 = (ushort)health - (int)((uVar8 & 0xffff) >> 1);
                    health = (short)iVar4;

                    if (iVar4 * 0x10000 < 1)
                    {
                        DAT_1C3 = 3;
                        goto LAB_41930;
                    }

                    DAT_11E |= 4;
                    uVar8 = DAT_208;
                    uVar7 = 0x400000;
                }

                DAT_208 = uVar8 | uVar7;
                goto LAB_41930;
            }

            if ((uVar8 & 0xff) == 0)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 3];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9 + 2];
                DAT_1C3 = 2;
                DAT_208 &= 0xfffffffb;
                uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar8));
                sVar3 = (short)(health - uVar11);
                DAT_11C = (short)uVar11;
            }
            else
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 1];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9];
                DAT_11E |= 4;
                DAT_208 |= 0x400000;
                uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar8));
                sVar3 = (short)(health - uVar11);
                DAT_11C = (short)uVar11;
            }

            health = sVar3;
        }
        else
        {
            if (uVar11 == 0x1d01)
            {
                if (1499 < UDAT_20C)
                    return;

                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 7];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar8);
                uVar6 = aVar9[puVar9 + 6];
                DAT_1C3 = 1;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_41930;
            }

            if (uVar11 == 0x1a01 || uVar11 == 0x1c01)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 3];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9 + 2];
                DAT_1C3 = 4;
                DAT_208 |= 0x20000;
                uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar8));
                sVar3 = (short)(health - uVar11);
                DAT_11C = (short)uVar11;
                health = sVar3;
            }

            if (uVar11 == 0x1b01)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 3];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar8);
                uVar6 = aVar9[puVar9 + 2];
                bVar2 = (byte)(DAT_11E | 4);
                DAT_11E = bVar2;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_41930;
            }

            if (uVar11 == 0x1201 || uVar11 == 0x1301 || uVar11 == 0x1401)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 3];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar8);
                uVar6 = aVar9[puVar9 + 2];
                DAT_1C3 = 5;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_41930;
            }

            if ((uVar11 == 0x1001 || uVar11 == 0x1101) && (DAT_208 & 0x10000) != 0)
            {
                if ((uVar8 & 0xff) == 0)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar8 = aVar9[puVar9 + 3];

                    if (uVar8 == 0)
                        return; //trap(0x1c00)

                    if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar6 = aVar9[puVar9 + 2];
                    DAT_1C3 = 2;
                    DAT_208 &= 0xfffffffb;
                    uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar8));
                    sVar3 = (short)(health - uVar11);
                    DAT_11C = (short)uVar11;
                    health = sVar3;
                    goto LAB_41930;
                }

                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 1];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9];
                bVar2 = (byte)(DAT_11E | 4);
                DAT_11E = bVar2;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_41930;
            }

            if (DAT_3C == 2 || (uVar11 = (ushort)(DAT_3C | DAT_3D << 8)) == 0xe01)
            {
                if (DAT_3C == 2 && DAT_3D == 2)
                {
                    if ((uVar8 & 0xff) != 0)
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar8 = aVar9[puVar9 + 1];

                        if (uVar8 == 0)
                            return; //trap(0x1c00)

                        if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        iVar4 = aVar9[puVar9] + iVar4 % (int)uVar8;
                        iVar10 = (ushort)health - iVar4;
                        health = (short)iVar10;
                        DAT_11C = (short)iVar4;

                        if (iVar10 * 0x10000 < 1)
                            DAT_1C3 = 1;
                        else
                            DAT_11E |= 4;

                        goto LAB_41930;
                    }

                    iVar4 = (int)GameManager.FUN_64650();
                    uVar8 = aVar9[puVar9 + 7];
                    uVar11 = (ushort)(iVar4 % (int)uVar8);

                    if (uVar8 == 0)
                        return; //trap(0x1c00)

                    if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                        return;

                    uVar6 = aVar9[puVar9 + 6];
                    DAT_1C3 = 1;
                    sVar3 = (short)(health - (uVar6 + uVar11));
                    DAT_11C = (short)(uVar6 + uVar11);
                    health = sVar3;
                    goto LAB_41930;
                }

                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 1];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9];
                bVar2 = (byte)(DAT_11E | 4);
                DAT_11E = bVar2;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_41930;
            }

            if (uVar11 == 0x2301 || uVar11 == 0x2401 || uVar11 == 0x604)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 3];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar8);
                uVar6 = aVar9[puVar9 + 2];
                bVar2 = (byte)(DAT_11E | 4);
                DAT_11E = bVar2;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_41930;
            }

            if (uVar11 == 0x2201)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 5];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar8);
                uVar6 = aVar9[puVar9 + 4];
                DAT_1C3 = 3;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_41930;
            }

            if (uVar11 == 5)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 1];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9];
                bVar2 = (byte)(DAT_11E | 4);
                DAT_11E = bVar2;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_41930;
            }

            if (uVar11 == 0x105)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 1];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9];
                DAT_1C3 = 4;
                uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar8));
                DAT_11C = (short)uVar11;
                health -= (short)uVar11;
                uVar8 = GameManager.FUN_64650();

                if ((uVar8 & 1) == 0)
                {
                    uVar8 = DAT_208;
                    uVar7 = 0x20000;
                    DAT_196 = 0;
                    DAT_208 = uVar8 | uVar7;
                    goto LAB_41930;
                }

                DAT_208 &= 0xfffdffff;
            }
            else
            {
                uVar7 = (uint)((iVar4 % 10) * 100 & 0xffff);

                if (DAT_3C - 3U < 2)
                {
                    DAT_11E |= 4;
                    goto LAB_41930;
                }

                if (uVar7 + 3500 <= UDAT_20C)
                {
                    if (UDAT_20C < uVar7 + 5000)
                    {
                        if ((uVar8 & 0xff) == 0)
                        {
                            iVar4 = (int)GameManager.FUN_64650();
                            uVar8 = aVar9[puVar9 + 7];

                            if (uVar8 == 0)
                                return; //trap(0x1c00)

                            if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            uVar11 = (ushort)(iVar4 % (int)uVar8);
                            uVar6 = aVar9[puVar9 + 6];
                            DAT_1C3 = 1;
                            sVar3 = (short)(health - (uVar6 + uVar11));
                            DAT_11C = (short)(uVar6 + uVar11);
                            health = sVar3;
                            goto LAB_41930;
                        }

                        iVar4 = (int)GameManager.FUN_64650();
                        uVar8 = aVar9[puVar9 + 3];

                        if (uVar8 == 0)
                            return; //trap(0x1c00)

                        if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar6 = aVar9[puVar9 + 2];
                        DAT_1C3 = 2;
                        DAT_208 &= 0xfffffffb;
                        uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar8));
                        sVar3 = (short)(health - uVar11);
                        DAT_11C = (short)uVar11;
                    }
                    else
                    {
                        if ((uVar8 & 0xff) != 0)
                        {
                            iVar4 = (int)GameManager.FUN_64650();
                            uVar8 = aVar9[puVar9 + 1];

                            if (uVar8 == 0)
                                return; //trap(0x1c00)

                            if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            uVar6 = aVar9[puVar9];
                            bVar2 = (byte)(DAT_11E | 4);
                            DAT_11E = bVar2;
                            sVar3 = (short)(health - (uVar6 + uVar11));
                            DAT_11C = (short)(uVar6 + uVar11);
                            health = sVar3;
                            goto LAB_41930;
                        }

                        iVar4 = (int)GameManager.FUN_64650();
                        uVar8 = aVar9[puVar9 + 3];

                        if (uVar8 == 0)
                            return; //trap(0x1c00)

                        if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar6 = aVar9[puVar9 + 2];
                        DAT_1C3 = 2;
                        DAT_208 &= 0xfffffffb;
                        uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar8));
                        sVar3 = (short)(health - uVar11);
                        DAT_11C = (short)uVar11;
                    }

                    health = sVar3;
                    goto LAB_41930;
                }

                if ((uVar8 & 0xff) == 0)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar8 = aVar9[puVar9 + 7];

                    if (uVar8 == 0)
                        return; //trap(0x1c00)

                    if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar11 = (ushort)(iVar4 % (int)uVar8);
                    uVar6 = aVar9[puVar9 + 6];
                    DAT_1C3 = 1;
                    sVar3 = (short)(health - (uVar6 + uVar11));
                    DAT_11C = (short)(uVar6 + uVar11);
                    health = sVar3;
                    goto LAB_41930;
                }

                iVar4 = (int)GameManager.FUN_64650();
                uVar8 = aVar9[puVar9 + 5];

                if (uVar8 == 0)
                    return; //trap(0x1c00)

                if (uVar8 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9 + 4];
                DAT_1C3 = 0;
                uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar8));
                DAT_11C = (short)uVar11;
                health -= (short)uVar11;
            }
        }

        LAB_41930:
        if (0 < health) goto LAB_41B40;

        uVar8 = DAT_208;
        uVar7 = uVar8 & 0xffffffef;
        DAT_208 = uVar7;

        if ((byte)DAT_1C3 < 2U || DAT_1C3 == 3)
        {
            if ((uVar8 & 0x10000000) != 0) goto LAB_41B40;

            DAT_208 = uVar7 | 0x10000000;
            uVar8 = GameManager.FUN_64650();

            if ((uVar8 & 1) == 0 && !DAT_1A6)
            {
                DAT_1A6 = true;
                DAT_208 |= 0x10;
                FUN_40CA4();
                goto LAB_41B40;
            }

            InventoryManager.FUN_4A7E8(4, DAT_163, true);
        }
        else
        {
            if ((DAT_11E & 4) == 0)
                uVar11 = (ushort)(DAT_3C | DAT_3D << 8);
            else if (DAT_3C - 2U < 2 || (uVar11 = (ushort)(DAT_3C | DAT_3D << 8)) == 0x604)
                InventoryManager.FUN_4A7E8(4, DAT_163, true);
            else if (uVar11 == 0x2301 || uVar11 == 0x2401)
                health = 1;
            else
            {
                if (1U < (byte)DAT_1C3 && DAT_1C3 != 3)
                {
                    FUN_65CF8(0, 0, 30);

                    if ((byte)DAT_1C3 - 4U < 2 || (DAT_3C == 5 && DAT_3D == 0 && 79U < DAT_60) || 
                        DAT_3C == 1 && DAT_3D == 0x1b)
                    {
                        DAT_3C = 3;
                        DAT_3D = 0;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        DAT_11E |= 0x44;
                        FUN_2F848();
                    }
                    else
                    {
                        DAT_3C = 3;
                        DAT_3D = 1;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        uVar8 = GameManager.FUN_64650();

                        if ((uVar8 & 1) == 0 && !DAT_1A6)
                        {
                            DAT_1A6 = true;
                            DAT_208 |= 0x10;
                            FUN_40CA4();
                            return;
                        }

                        DAT_208 &= 0xffffffef;
                        DAT_11E |= 0x44;
                    }

                    InventoryManager.FUN_4A7E8(4, DAT_163, true);
                    return;
                }
            }
        }

        LAB_41B40:
        if ((DAT_11E & 4) == 0)
        {
            if (DAT_3C == 1 && DAT_3D == 7)
            {
                iVar4 = DAT_1EC;

                if (iVar4 < 0)
                    iVar4 += 31;

                vr.y = (short)(vr.y + (iVar4 >> 5) * DAT_60 & 0xfff);
            }

            sVar1 = DAT_1C3;

            if (sVar1 == 2)
            {
                DAT_3C = 2;
                DAT_3D = 3;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                if (sVar1 == 3)
                {
                    DAT_3C = 2;
                    DAT_3D = 1;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
                else
                {
                    if ((byte)sVar1 - 4U < 2)
                    {
                        DAT_3C = 2;
                        DAT_3D = 1;
                        DAT_3E = 0;
                        DAT_3F = 0;
                    }
                    else
                    {
                        DAT_3C = 2;
                        DAT_3D = 0;
                        DAT_3E = 0;
                        DAT_3F = 0;
                    }
                }
            }

            FUN_2F848();
            FUN_65CF8(0, 0, 30);
            DAT_11E |= 4;
        }

        SceneManager.instance.FUN_2E7D0(this);

        if ((DAT_208 & 0x4000) != 0)
            BDAT_1D8++;
    }

    private void FUN_41C74()
    {
        sbyte sVar1;
        byte bVar2;
        short sVar3;
        int iVar4;
        int iVar5;
        ushort uVar6;
        uint uVar7;
        uint uVar8;
        int puVar9;
        ushort[] aVar9;
        uint uVar10;
        ushort uVar11;

        if ((DAT_11E & 1) != 0)
        {
            DAT_11E |= 4;
            goto LAB_428C4;
        }

        iVar4 = (int)GameManager.FUN_64650();
        BDAT_1DC = 4;
        DAT_1D5 = 0;
        uVar10 = (uint)(iVar4 % 10) * 100;

        if (GameManager.instance.DAT_A2D2 == 0)
        {
            aVar9 = Utilities.DAT_9B4A0;
            puVar9 = 0x20;
            iVar4 = 5;
        }
        else
        {
            aVar9 = Utilities.DAT_9B500;
            puVar9 = 0x20;
            iVar4 = 60;
        }

        if (DAT_3C != 2 && (DAT_3C != 1 || DAT_3D != 14))
            DAT_1C3 = -1;

        uVar6 = (ushort)(DAT_1A0 & 0xf);

        if (uVar6 == 1)
        {
            iVar5 = (int)GameManager.FUN_64650();
            uVar8 = (uint)(iVar5 % iVar4);

            if (iVar4 == 0)
                return; //trap(0x1c00)

            if (iVar4 == -1 && iVar5 == -0x80000000)
                return; //trap(0x1800)
        }
        else
        {
            uVar8 = 1;

            if (uVar6 == 3)
            {
                iVar5 = (int)GameManager.FUN_64650();

                if (iVar4 == 0)
                    return; //trap(0x1c00)

                if (iVar4 == -1 && iVar5 == -0x80000000)
                    return; //trap(0x1800)

                uVar8 = (uint)(iVar5 % iVar4);
            }
        }

        uVar11 = (ushort)(DAT_3C | DAT_3D << 8);

        if (uVar11 == 0xc01)
        {
            if (DAT_60 < 9U)
            {
                if ((uVar8 & 0xff) == 0)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar10 = aVar9[puVar9 + 7];

                    if (uVar10 == 0)
                        return; //trap(0x1c00)

                    if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar11 = (ushort)(iVar4 % (int)uVar10);
                    uVar6 = aVar9[puVar9 + 6];
                    DAT_1C3 = 1;
                    sVar3 = (short)(health - (uVar6 + uVar11));
                    DAT_11C = (short)(uVar6 + uVar11);
                    health = sVar3;
                    goto LAB_426B4;
                }

                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 1];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9];
                DAT_11E |= 4;
                DAT_208 |= 0x400000;
                uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar10));
                sVar3 = (short)(health - uVar11);
                DAT_11C = (short)uVar11;
            }
            else
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 7];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar10);
                uVar6 = aVar9[puVar9 + 6];
                DAT_1C3 = 3;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
            }

            health = sVar3;
        }
        else
        {
            if (uVar11 == 0x1d01)
            {
                if (1499U < UDAT_20C)
                    return;

                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 7];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9 + 6];
                DAT_1C3 = 1;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_426B4;
            }

            if (uVar11 == 0x1a01 || uVar11 == 0x1c01)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 3];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = aVar9[puVar9 + 2];
                DAT_1C3 = 4;
                DAT_208 |= 0x20000;
                uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar10));
                sVar3 = (short)(health - uVar11);
                DAT_11C = (short)uVar11;
                health = sVar3;
                goto LAB_426B4;
            }

            if (uVar11 == 0x1b01)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 3];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar10);
                uVar6 = aVar9[puVar9 + 2];
                bVar2 = (byte)(DAT_11E | 4);
                DAT_11E = bVar2;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_426B4;
            }

            if (uVar11 == 0x1201 || uVar11 == 0x1301 || uVar11 == 0x1401)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 3];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar10);
                uVar6 = aVar9[puVar9 + 2];
                DAT_1C3 = 5;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_426B4;
            }

            if (uVar11 == 0x1001 || uVar11 == 0x1101 && (DAT_208 & 0x10000) != 0)
            {
                if ((uVar8 & 0xff) != 0)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar10 = aVar9[puVar9 + 3];

                    if (uVar10 == 0)
                        return; //trap(0x1c00)

                    if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar11 = (ushort)(iVar4 % (int)uVar10);
                    uVar6 = aVar9[puVar9 + 2];
                    bVar2 = (byte)(DAT_11E | 4);
                    DAT_11E = bVar2;
                    sVar3 = (short)(health - (uVar6 + uVar11));
                    DAT_11C = (short)(uVar6 + uVar11);
                    health = sVar3;
                    goto LAB_426B4;
                }

                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 7];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar10);
                uVar6 = aVar9[puVar9 + 6];
                DAT_1C3 = 1;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_426B4;
            }

            if (DAT_3C == 2 || (uVar11 = (ushort)(DAT_3C | DAT_3D << 8)) == 0xe01)
            {
                if (DAT_3C == 2 && DAT_3D == 2)
                {
                    if ((uVar8 & 0xff) != 0 && (uVar10 & 0xffff) * 1500 <= UDAT_20C)
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar10 = aVar9[puVar9 + 1];

                        if (uVar10 == 0)
                            return; //trap(0x1c00)

                        if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        iVar4 = aVar9[puVar9] + iVar4 % (int)uVar10;
                        iVar5 = (ushort)health - iVar4;
                        health = (short)iVar5;
                        DAT_11C = (short)iVar4;

                        if (iVar5 * 0x10000 < 1)
                            DAT_1C3 = 1;
                        else
                            DAT_11E |= 4;

                        goto LAB_426B4;
                    }

                    iVar4 = (int)GameManager.FUN_64650();
                    uVar10 = aVar9[puVar9 + 7];

                    if (uVar10 == 0)
                        return; //trap(0x1c00)

                    if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar11 = (ushort)(iVar4 % (int)uVar10);
                    uVar6 = aVar9[puVar9 + 6];
                    DAT_1C3 = 1;
                    sVar3 = (short)(health - (uVar6 + uVar11));
                    DAT_11C = (short)(uVar6 + uVar11);
                    health = sVar3;
                    goto LAB_426B4;
                }

                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 1];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar10);
                uVar6 = aVar9[puVar9];
                bVar2 = (byte)(DAT_11E | 4);
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_426B4;
            }

            if (uVar11 == 0x2301 || uVar11 == 0x2401 || uVar11 == 0x604)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 3];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar10);
                uVar6 = aVar9[puVar9 + 2];
                bVar2 = (byte)(DAT_11E | 4);
                DAT_11E = bVar2;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_426B4;
            }

            if (uVar11 == 0x2201)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 5];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar10);
                uVar6 = aVar9[puVar9 + 4];
                DAT_1C3 = 3;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_426B4;
            }

            if (uVar11 == 5)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar10 = aVar9[puVar9 + 3];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (ushort)(iVar4 % (int)uVar10);
                uVar6 = aVar9[puVar9 + 2];
                bVar2 = (byte)(DAT_11E | 4);
                DAT_11E = bVar2;
                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_426B4;
            }

            if (uVar11 != 0x105)
            {
                uVar10 &= 0xffff;

                if ((DAT_3C - 3U) < 2)
                {
                    DAT_11E |= 4;
                    goto LAB_426B4;
                }

                uVar7 = UDAT_20C;

                if (uVar7 < uVar10 + 1500)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar10 = aVar9[puVar9 + 7];

                    if (uVar10 == 0)
                        return; //trap(0x1c00)

                    if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar11 = (ushort)(iVar4 % (int)uVar10);

                    uVar6 = aVar9[puVar9 + 6];
                    DAT_1C3 = 1;
                }
                else
                {
                    if (uVar7 < uVar10 + 4500)
                    {
                        if ((uVar8 & 0xff) != 0)
                        {
                            iVar4 = (int)GameManager.FUN_64650();
                            uVar10 = aVar9[puVar9 + 5];

                            if (uVar10 == 0)
                                return; //trap(0x1c00)

                            if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            uVar6 = aVar9[puVar9 + 4];
                            DAT_1C3 = 0;
                            uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar10));
                            DAT_11C = (short)uVar11;
                            health -= (short)uVar11;
                            goto LAB_426B4;
                        }

                        iVar4 = (int)GameManager.FUN_64650();
                        uVar10 = aVar9[puVar9 + 7];

                        if (uVar10 == 0)
                            return; //trap(0x1c00)

                        if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar11 = (ushort)(iVar4 % (int)uVar10);
                        uVar6 = aVar9[puVar9 + 6];
                        DAT_1C3 = 1;
                    }
                    else
                    {
                        if (uVar7 < uVar10 + 5500)
                        {
                            if ((uVar8 & 0xff) != 0)
                            {
                                iVar4 = (int)GameManager.FUN_64650();
                                uVar10 = aVar9[puVar9 + 3];

                                if (uVar10 == 0)
                                    return; //trap(0x1c00)

                                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                                    return; //trap(0x1800)

                                uVar6 = aVar9[puVar9 + 2];
                                DAT_1C3 = 2;
                                DAT_208 &= 0xfffffffb;
                                uVar11 = (ushort)(uVar6 + (iVar4 % (int)uVar10));
                                sVar3 = (short)(health - uVar11);
                                DAT_11C = (short)uVar11;
                                health = sVar3;
                                goto LAB_426B4;
                            }

                            iVar4 = (int)GameManager.FUN_64650();
                            uVar10 = aVar9[puVar9 + 7];

                            if (uVar10 == 0)
                                return; //trap(0x1c00)

                            if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            uVar11 = (ushort)(iVar4 % (int)uVar10);
                            uVar6 = aVar9[puVar9 + 6];
                            DAT_1C3 = 1;
                        }
                        else
                        {
                            if ((uVar8 & 0xff) != 0)
                            {
                                iVar4 = (int)GameManager.FUN_64650();
                                uVar10 = aVar9[puVar9 + 1];

                                if (uVar10 == 0)
                                    return; //trap(0x1c00)

                                if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                                    return; //trap(0x1800)

                                uVar11 = (ushort)(iVar4 % (int)uVar10);
                                uVar6 = aVar9[puVar9];
                                bVar2 = (byte)(DAT_11E | 4);
                                sVar3 = (short)(health - (uVar6 + uVar11));
                                DAT_11C = (short)(uVar6 + uVar11);
                                health = sVar3;
                                goto LAB_426B4;
                            }

                            iVar4 = (int)GameManager.FUN_64650();
                            uVar10 = aVar9[puVar9 + 7];

                            if (uVar10 == 0)
                                return; //trap(0x1c00)

                            if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            uVar11 = (ushort)(iVar4 % (int)uVar10);
                            uVar6 = aVar9[puVar9 + 6];
                            DAT_1C3 = 1;
                        }
                    }
                }

                sVar3 = (short)(health - (uVar6 + uVar11));
                DAT_11C = (short)(uVar6 + uVar11);
                health = sVar3;
                goto LAB_426B4;
            }

            iVar4 = (int)GameManager.FUN_64650();
            uVar10 = aVar9[puVar9 + 3];

            if (uVar10 == 0)
                return; //trap(0x1c00)

            if (uVar10 == 0xffffffff && iVar4 == -0x80000000)
                return; //trap(0x1800)

            uVar6 = aVar9[puVar9 + 2];
            DAT_1C3 = 4;
            uVar11 = (ushort)(uVar6 + (int)(iVar4 % (int)uVar10));
            DAT_11C = (short)uVar11;
            health -= (short)uVar11;
            uVar10 = GameManager.FUN_64650();

            if ((uVar10 & 1) == 0)
            {
                DAT_196 = 0;
                DAT_208 |= 0x20000;
            }
            else
                DAT_208 &= 0xfffdffff;
        }

        LAB_426B4:
        if (0 < health) goto LAB_428C4;

        uVar10 = DAT_208;
        uVar8 = uVar10 & 0xffffffef;
        DAT_208 = uVar8;

        if ((byte)DAT_1C3 < 2U || DAT_1C3 == 3)
        {
            if ((uVar10 & 0x10000000) != 0) goto LAB_428C4;

            DAT_208 = uVar8 | 0x10000000;
            uVar10 = GameManager.FUN_64650();

            if ((uVar10 & 1) == 0 && !DAT_1A6)
            {
                DAT_1A6 = true;
                DAT_208 |= 0x10;
                FUN_40CA4();
                goto LAB_428C4;
            }

            InventoryManager.FUN_4A7E8(4, DAT_163, true);
        }
        else
        {
            if ((DAT_11E & 4) == 0)
                uVar11 = (ushort)(DAT_3C | DAT_3D << 8);
            else if (DAT_3C - 2U < 2 || (uVar11 = (ushort)(DAT_3C | DAT_3D << 8)) == 0x604)
                InventoryManager.FUN_4A7E8(4, DAT_163, true);
            else if (uVar11 == 0x2301 || uVar11 == 0x2401)
                health = 1;
            else
            {
                if (1U < (byte)DAT_1C3 && DAT_1C3 != 3)
                {
                    FUN_65CF8(0, 0, 30);

                    if ((byte)DAT_1C3 - 4U < 2 || (DAT_3C == 5 && DAT_3D == 0 && 79U < DAT_60) || 
                        DAT_3C == 1 && DAT_3D == 0x1b)
                    {
                        DAT_3C = 3;
                        DAT_3D = 0;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        DAT_11E |= 0x44;
                        FUN_2F848();
                    }
                    else
                    {
                        DAT_3C = 3;
                        DAT_3D = 1;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        uVar10 = GameManager.FUN_64650();

                        if ((uVar10 & 1) == 0 && !DAT_1A6)
                        {
                            DAT_1A6 = true;
                            DAT_208 |= 0x10;
                            FUN_40CA4();
                            return;
                        }

                        DAT_208 &= 0xffffffef;
                        DAT_11E |= 0x44;
                    }

                    InventoryManager.FUN_4A7E8(4, DAT_163, true);
                    return;
                }
            }
        }

        LAB_428C4:
        if ((DAT_11E & 4) == 0)
        {
            if (DAT_3C == 1 && DAT_3D == 7)
            {
                iVar4 = DAT_1EC;

                if (iVar4 < 0)
                    iVar4 += 31;

                vr.y = (short)(vr.y + (iVar4 >> 5) * DAT_60 & 0xfff);
            }

            sVar1 = DAT_1C3;

            if (sVar1 == 2)
            {
                DAT_3C = 2;
                DAT_3D = 3;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                if (sVar1 == 3)
                {
                    DAT_3C = 2;
                    DAT_3D = 1;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
                else
                {
                    if ((byte)sVar1 - 4U < 2)
                    {
                        DAT_3C = 2;
                        DAT_3D = 4;
                        DAT_3E = 0;
                        DAT_3F = 0;
                    }
                    else
                    {
                        DAT_3C = 2;
                        DAT_3D = 0;
                        DAT_3E = 0;
                        DAT_3F = 0;
                    }
                }
            }

            FUN_2F848();
            FUN_65CF8(0, 0, 30);
            DAT_11E |= 4;
        }

        SceneManager.instance.FUN_2E7D0(this);

        if ((DAT_208 & 0x4000) != 0)
            BDAT_1D8++;
    }

    private void FUN_429F8()
    {
        PTR_FUN_9C67C[DAT_1A1 & 0xf]();
    }

    private void FUN_42A38()
    {
        sbyte sVar1;
        sbyte sVar2;
        short sVar3;
        int iVar4;
        ushort[] puVar5;
        ushort uVar6;
        ushort uVar7;
        int iVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        int puVar12;

        if ((DAT_11E & 1) == 0)
        {
            iVar4 = (int)GameManager.FUN_64650();
            DAT_1D5 = 1;
            BDAT_1DC = 4;
            uVar11 = (uint)(iVar4 % 10) * 100;
            uVar6 = (ushort)(DAT_1A0 & 0xf);

            if (uVar6 == 1)
                iVar4 = 5;
            else
            {
                iVar4 = 1;

                if (uVar6 == 3)
                    iVar4 = 5;
            }

            if (GameManager.instance.DAT_A2D2 == 0)
                puVar5 = Utilities.DAT_9B4A0;
            else
                puVar5 = Utilities.DAT_9B500;

            puVar12 = iVar4 * 8;

            if (DAT_3C == 2)
                uVar7 = (ushort)(DAT_3C | DAT_3D << 8);
            else
            {
                uVar7 = (ushort)(DAT_3C | DAT_3D << 8);

                if (uVar7 != 0xe01)
                {
                    DAT_1C3 = -1;
                    uVar7 = (ushort)(DAT_3C | DAT_3D << 8);
                }
            }

            if (uVar7 == 0xc01 && 8 < DAT_60)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar11 = puVar5[puVar12 + 7];

                if (uVar11 == 0)
                    return; //trap(0x1c00)

                if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar11 = (uint)(puVar5[puVar12 + 6] + iVar4 % (int)uVar11);
                DAT_11C = (short)uVar11;
                DAT_1C3 = 3;
                health -= (short)((int)(uVar11 & 0xffff) * 0x82 / 100);
                goto LAB_431C0;
            }

            if (uVar7 == 0x1d01)
            {
                if (0x9c3 < UDAT_20C)
                    return;

                iVar4 = (int)GameManager.FUN_64650();
                uVar11 = puVar5[puVar12 + 7];
                uVar7 = (ushort)(iVar4 % (int)uVar11);

                if (uVar11 == 0)
                    return; //trap(0x1c00)

                if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = puVar5[puVar12 + 6];
                sVar2 = 1;
                DAT_1C3 = sVar2;
                DAT_11C = (short)(uVar6 + uVar7);
                health -= (short)(uVar6 + uVar7);
                goto LAB_431C0;
            }

            if ((uVar7 == 0x1001 || uVar7 == 0x1101) && (DAT_208 & 0x10000) != 0)
            {
                iVar4 = (int)GameManager.FUN_64650();
                uVar11 = puVar5[puVar12 + 3];
                uVar7 = (ushort)(iVar4 % (int)uVar11);

                if (uVar11 == 0)
                    return; //trap(0x1c00)

                if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                    return; //trap(0x1800)

                uVar6 = puVar5[puVar12 + 2];
                DAT_11E |= 4;
                DAT_11C = (short)(uVar6 + uVar7);
                health -= (short)(uVar6 + uVar7);
            }
            else
            {
                if (DAT_3C == 2 || (uVar7 = (ushort)(DAT_3C | DAT_3D << 8)) == 0xe01)
                {
                    if ((ushort)(DAT_3C | DAT_3D << 8) == 0x202)
                    {
                        if ((uVar11 & 0xffff) + 2000 <= UDAT_20C)
                        {
                            iVar4 = (int)GameManager.FUN_64650();
                            uVar11 = puVar5[puVar12 + 1];

                            if (uVar11 == 0)
                                return; //trap(0x1c00)

                            if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                                return; //trap(0x1800)

                            iVar4 = puVar5[puVar12] + iVar4 % (int)uVar11;
                            iVar8 = health - iVar4;
                            health = (short)iVar8;
                            DAT_11C = (short)iVar4;

                            if (0 < iVar8 * 0x10000)
                            {
                                DAT_11E |= 4;
                                goto LAB_431C0;
                            }

                            DAT_1C3 = 1;
                            goto LAB_431C0;
                        }

                        iVar4 = (int)GameManager.FUN_64650();
                        uVar11 = puVar5[puVar12 + 7];
                        uVar7 = (ushort)(iVar4 % (int)uVar11);

                        if (uVar11 == 0)
                            return; //trap(0x1c00)

                        if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar6 = puVar5[puVar12 + 6];
                        sVar2 = 1;
                        DAT_1C3 = sVar2;
                        DAT_11C = (short)(uVar6 + uVar7);
                        health -= (short)(uVar6 + uVar7);
                        goto LAB_431C0;
                    }

                    iVar4 = (int)GameManager.FUN_64650();
                    uVar11 = puVar5[puVar12 + 1];
                    uVar7 = (ushort)(iVar4 % (int)uVar11);

                    if (uVar11 == 0)
                        return; //trap(0x1c00)

                    if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar6 = puVar5[puVar12];
                    DAT_11E |= 4;
                    DAT_11C = (short)(uVar6 + uVar7);
                    health -= (short)(uVar6 + uVar7);
                    goto LAB_431C0;
                }

                if (uVar7 == 0x2301 || uVar7 == 0x2401 || uVar7 == 0x604)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar11 = puVar5[puVar12 + 3];
                    uVar7 = (ushort)(iVar4 % (int)uVar11);

                    if (uVar11 == 0)
                        return; //trap(0x1c00)

                    if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar6 = puVar5[puVar12 + 2];
                    DAT_11E |= 4;
                    DAT_11C = (short)(uVar6 + uVar7);
                    health -= (short)(uVar6 + uVar7);
                    goto LAB_431C0;
                }

                if (uVar7 == 0x2201)
                {
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar11 = puVar5[puVar12 + 5];
                    uVar7 = (ushort)(iVar4 % (int)uVar11);

                    if (uVar11 == 0)
                        return; //trap(0x1c00)

                    if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar6 = puVar5[puVar12 + 4];
                    sVar2 = 3;
                    DAT_1C3 = sVar2;
                    DAT_11C = (short)(uVar6 + uVar7);
                    health -= (short)(uVar6 + uVar7);
                    goto LAB_431C0;
                }

                if (uVar7 == 0x1a01 || uVar7 == 0x1c01 || uVar7 == 0x105)
                {
                    if (UDAT_20C < (uVar11 & 0xffff) + 0x708)
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar11 = puVar5[puVar12 + 7];

                        if (uVar11 == 0)
                            return; //trap(0x1c00)

                        if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar6 = puVar5[puVar12 + 6];
                        DAT_1C3 = 1;
                        uVar7 = (ushort)(uVar6 + (ushort)(iVar4 % (int)uVar11));
                        sVar3 = (short)(health - uVar7);
                        DAT_11C = (short)uVar7;
                    }
                    else
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar11 = puVar5[puVar12 + 3];

                        if (uVar11 == 0)
                            return; //trap(0x1c00)

                        if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar6 = puVar5[puVar12 + 2];
                        DAT_1C3 = 4;
                        DAT_208 |= 0x20000;
                        uVar7 = (ushort)(uVar6 + (ushort)(iVar4 % (int)uVar11));
                        sVar3 = (short)(health - uVar7);
                        DAT_11C = (short)uVar7;
                    }

                    health = sVar3;

                    if ((ushort)(DAT_3C | DAT_3D << 8) == 0x105)
                        DAT_196 = 0;

                    goto LAB_431C0;
                }

                if (uVar7 == 0x1201 || uVar7 == 0x1301 || uVar7 == 0x1401)
                {
                    if ((uVar11 & 0xffff) + 0x708 <= UDAT_20C)
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar11 = puVar5[puVar12 + 3];
                        uVar7 = (ushort)(iVar4 % (int)uVar11);

                        if (uVar11 == 0)
                            return; //trap(0x1c00)

                        if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar6 = puVar5[puVar12 + 2];
                        sVar2 = 5;
                        DAT_1C3 = sVar2;
                        DAT_11C = (short)(uVar6 + uVar7);
                        health -= (short)(uVar6 + uVar7);
                        goto LAB_431C0;
                    }

                    iVar4 = (int)GameManager.FUN_64650();
                    uVar11 = puVar5[puVar12 + 7];
                    uVar7 = (ushort)(iVar4 % (int)uVar11);

                    if (uVar11 == 0)
                        return; //trap(0x1c00)

                    if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar6 = puVar5[puVar12 + 6];
                    sVar2 = 1;
                    DAT_1C3 = sVar2;
                    DAT_11C = (short)(uVar6 + uVar7);
                    health -= (short)(uVar6 + uVar7);
                    goto LAB_431C0;
                }

                if (uVar7 == 0x1b01 || uVar7 == 5)
                {
                    if ((uVar11 & 0xffff) + 0x708 <= UDAT_20C)
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar11 = puVar5[puVar12 + 3];
                        uVar7 = (ushort)(iVar4 % (int)uVar11);

                        if (uVar11 == 0)
                            return; //trap(0x1c00)

                        if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar6 = puVar5[puVar12 + 2];
                        DAT_11E |= 4;
                        DAT_11C = (short)(uVar6 + uVar7);
                        health -= (short)(uVar6 + uVar7);
                        goto LAB_431C0;
                    }

                    iVar4 = (int)GameManager.FUN_64650();
                    uVar11 = puVar5[puVar12 + 7];
                    uVar7 = (ushort)(iVar4 % (int)uVar11);

                    if (uVar11 == 0)
                        return; //trap(0x1c00)

                    if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                        return; //trap(0x1800)

                    uVar6 = puVar5[puVar12 + 6];
                    sVar2 = 1;
                    DAT_1C3 = sVar2;
                    DAT_11C = (short)(uVar6 + uVar7);
                    health -= (short)(uVar6 + uVar7);
                    goto LAB_431C0;
                }

                if (DAT_3C - 3U < 2)
                    DAT_11E |= 4;
                else
                {
                    if (UDAT_20C < (uVar11 & 0xffff) + 0x708)
                    {

                        iVar4 = (int)GameManager.FUN_64650();
                        uVar11 = puVar5[puVar12 + 7];
                        uVar7 = (ushort)(iVar4 % (int)uVar11);

                        if (uVar11 == 0)
                            return; //trap(0x1c00)

                        if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar6 = puVar5[puVar12 + 6];
                        sVar2 = 1;
                        DAT_1C3 = sVar2;
                        DAT_11C = (short)(uVar6 + uVar7);
                        health -= (short)(uVar6 + uVar7);
                        goto LAB_431C0;
                    }

                    if (UDAT_20C < (uVar11 & 0xffff) + 0x10cc)
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar11 = puVar5[puVar12 + 5];

                        if (uVar11 == 0)
                            return; //trap(0x1c00)

                        if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar6 = puVar5[puVar12 + 4];
                        DAT_1C3 = 0;
                        uVar7 = (ushort)(uVar6 + (ushort)(iVar4 % (int)uVar11));
                        DAT_11C = (short)uVar7;
                        health -= (short)uVar7;
                    }
                    else
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        uVar11 = puVar5[puVar12 + 3];

                        if (uVar11 == 0)
                            return; //trap(0x1c00)

                        if (uVar11 == 0xffffffff && iVar4 == -0x80000000)
                            return; //trap(0x1800)

                        uVar7 = (ushort)(puVar5[puVar12 + 2] + (ushort)(iVar4 % (int)uVar11));
                        health -= (short)uVar7;
                        DAT_11C = (short)uVar7;

                        if ((ushort)(DAT_3C | DAT_3D << 8) == 0x501 && DAT_60 < 30U)
                        {
                            DAT_11E |= 4;
                            goto LAB_431C0;
                        }

                        DAT_1C3 = 2;
                        DAT_208 &= 0xfffffffb;
                    }
                }
            }

        LAB_431C0:
            if (health < 1)
            {
                uVar11 = DAT_208;
                uVar9 = uVar11 & 0xffffffef;
                DAT_208 = uVar9;

                if ((byte)DAT_1C3 < 2U || DAT_1C3 == 3)
                {
                    if ((uVar11 & 0x10000000) == 0)
                    {
                        DAT_208 = uVar9 | 0x10000000;
                        uVar11 = GameManager.FUN_64650();

                        if ((uVar11 & 1) != 0 || DAT_1A6)
                        {
                            InventoryManager.FUN_4A7E8(4, DAT_163, true);
                            goto LAB_433D0;
                        }

                        DAT_1A6 = true;
                        DAT_208 |= 0x10;
                        FUN_40CA4();
                    }
                }
                else
                {
                    if ((DAT_11E & 4) == 0)
                        uVar7 = (ushort)(DAT_3C | DAT_3D << 8);
                    else
                    {
                        if (DAT_3C - 2U < 2 || (uVar7 = (ushort)(DAT_3C | DAT_3D << 8)) == 0x604)
                        {
                            InventoryManager.FUN_4A7E8(4, DAT_163, true);
                            goto LAB_433D0;
                        }
                    }

                    if (uVar7 == 0x2301 || uVar7 == 0x2401)
                        health = 1;
                    else
                    {
                        if (1U < (byte)DAT_1C3 && DAT_1C3 != 3)
                        {
                            FUN_65CF8(0, 0, 30);

                            if ((byte)DAT_1C3 - 4U < 2 ||
                                ((ushort)(DAT_3C | DAT_3D << 8) == 5 && 79U < DAT_60) ||
                                (ushort)(DAT_3C | DAT_3D << 8) == 0x1b01)
                            {
                                DAT_3C = 3;
                                DAT_3D = 0;
                                DAT_3E = 0;
                                DAT_3F = 0;
                                DAT_11E |= 0x44;
                                FUN_2F848();
                            }
                            else
                            {
                                DAT_3C = 3;
                                DAT_3D = 1;
                                DAT_3E = 0;
                                DAT_3F = 0;
                                uVar11 = GameManager.FUN_64650();

                                if ((uVar11 & 1) == 0 && !DAT_1A6)
                                {
                                    DAT_1A6 = true;
                                    DAT_208 |= 0x10;
                                    FUN_40CA4();
                                    return;
                                }

                                DAT_208 &= 0xffffffef;
                                DAT_11E |= 0x44;
                            }

                            InventoryManager.FUN_4A7E8(4, DAT_163, true);
                            return;
                        }
                    }
                }
            }
        }
        else
            DAT_11E |= 4;

        LAB_433D0:
        if ((DAT_11E & 4) != 0)
        {
            DAT_208 |= 0x20;

            if ((DAT_11E & 4) != 0) goto LAB_434C8;
        }

        if ((ushort)(DAT_3C | DAT_3D << 8) == 0x701)
        {
            iVar4 = DAT_1EC;

            if (iVar4 < 0)
                iVar4 += 31;

            vr.y = (short)(vr.y + (iVar4 >> 5) * DAT_60 & 0xfff);
        }

        sVar1 = DAT_1C3;

        if (sVar1 == 2)
        {
            uVar11 = DAT_208;
            uVar10 = 0x302;
            DAT_3C = (byte)uVar10;
            DAT_3D = (byte)(uVar10 >> 8);
            DAT_3E = (byte)(uVar10 >> 0x10);
            DAT_3F = (byte)(uVar10 >> 0x18);
            DAT_208 = uVar11 | 0x20;
        }
        else
        {
            if (sVar1 == 3)
            {
                DAT_3C = 2;
                DAT_3D = 1;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                uVar10 = 0x402;

                if ((byte)sVar1 - 4U < 2)
                {
                    uVar11 = DAT_208;
                    DAT_3C = (byte)uVar10;
                    DAT_3D = (byte)(uVar10 >> 8);
                    DAT_3E = (byte)(uVar10 >> 0x10);
                    DAT_3F = (byte)(uVar10 >> 0x18);
                    DAT_208 = uVar11 | 0x20;
                }
                else
                {
                    DAT_3C = 2;
                    DAT_3D = 0;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
            }
        }

        FUN_2F848();
        FUN_65CF8(0, 0, 30);
        DAT_11E |= 4;

        LAB_434C8:
        if ((DAT_208 & 0x4000) != 0)
            BDAT_1D8++;
    }

    private void FUN_43500()
    {
        sbyte sVar1;
        ushort uVar2;
        int iVar3;
        ushort[] puVar4;
        ushort uVar5;
        int iVar6;
        uint uVar7;
        uint uVar8;
        short sVar9;
        uint uVar10;
        int puVar11;

        if ((DAT_11E & 1) == 0)
        {
            iVar3 = (int)GameManager.FUN_64650();
            DAT_1D5 = 1;
            BDAT_1DC = 4;
            uVar10 = (uint)((iVar3 % 10) * 100);
            uVar5 = (ushort)(DAT_1A0 & 0xf);

            if (uVar5 == 1)
                iVar3 = 5;
            else
            {
                iVar3 = 1;

                if (uVar5 == 3)
                    iVar3 = 5;
            }

            if (GameManager.instance.DAT_A2D2 == 0)
                puVar4 = Utilities.DAT_9B4A0;
            else
                puVar4 = Utilities.DAT_9B500;

            puVar11 = iVar3 * 8;

            if (DAT_3C == 2)
                uVar2 = (ushort)(DAT_3C | DAT_3D << 8);
            else
            {
                uVar2 = (ushort)(DAT_3C | DAT_3D << 8);

                if (uVar2 != 0xe01)
                {
                    DAT_1C3 = -1;
                    uVar2 = (ushort)(DAT_3C | DAT_3D << 8);
                }
            }

            if (uVar2 == 0xc01 && 8 < DAT_60)
            {
                iVar3 = (int)GameManager.FUN_64650();
                uVar10 = puVar4[puVar11 + 7];

                if (uVar10 == 0)
                    return; //trap(0x1c00)

                if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                    return; //trap(0x1800)

                uVar10 = (uint)(puVar4[puVar11 + 6] + iVar3 % (int)uVar10 + 50);
                DAT_11C = (short)uVar10;
                DAT_1C3 = 3;
                health -= (short)(((uVar10 & 0xffff) * 130) / 100);
            }
            else
            {
                if (uVar2 == 0x1d01)
                {
                    if (2499 < UDAT_20C)
                        return;

                    iVar3 = (int)GameManager.FUN_64650();
                    uVar10 = puVar4[puVar11 + 7];

                    if (uVar10 == 0)
                        return; //trap(0x1c00)

                    if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                        return; //trap(0x1800)

                    uVar5 = puVar4[puVar11 + 6];
                    DAT_1C3 = 1;
                    uVar2 = (ushort)health;
                    sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                }
                else
                {
                    if ((uVar2 == 0x1001 || uVar2 == 0x1101) &&
                        (DAT_208 & 0x10000) != 0)
                    {
                        iVar3 = (int)GameManager.FUN_64650();
                        uVar10 = puVar4[puVar11 + 3];

                        if (uVar10 == 0)
                            return; //trap(0x1c00)

                        if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                            return; //trap(0x1800)

                        uVar5 = puVar4[puVar11 + 2];
                        DAT_11E |= 4;
                        uVar2 = (ushort)health;
                        sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                    }
                    else
                    {
                        if (DAT_3C == 2 || (uVar2 = (ushort)(DAT_3C | DAT_3D << 8)) == 0xe01)
                        {
                            if ((ushort)(DAT_3C | DAT_3D << 8) == 0x202)
                            {
                                if ((uVar10 & 0xffff) + 2000 <= UDAT_20C)
                                {
                                    iVar3 = (int)GameManager.FUN_64650();
                                    uVar10 = puVar4[puVar11 + 1];

                                    if (uVar10 == 0)
                                        return; //trap(0x1c00)

                                    if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                        return; //trap(0x1800)

                                    iVar3 = puVar4[puVar11] + iVar3 % (int)uVar10 + 50;
                                    iVar6 = (ushort)health - iVar3;
                                    health = (short)iVar6;
                                    DAT_11C = (short)iVar3;

                                    if (0 < iVar6 * 0x10000)
                                    {
                                        DAT_11E |= 4;
                                        goto LAB_43E10;
                                    }

                                    DAT_1C3 = 1;
                                    goto LAB_43E10;
                                }

                                iVar3 = (int)GameManager.FUN_64650();
                                uVar10 = puVar4[puVar11 + 7];

                                if (uVar10 == 0)
                                    return; //trap(0x1c00)

                                if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                    return; //trap(0x1800)

                                uVar5 = puVar4[puVar11 + 6];
                                DAT_1C3 = 1;
                                uVar2 = (ushort)health;
                                sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                            }
                            else
                            {
                                iVar3 = (int)GameManager.FUN_64650();
                                uVar10 = puVar4[puVar11 + 1];

                                if (uVar10 == 0)
                                    return; //trap(0x1c00)

                                if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                    return; //trap(0x1800)

                                uVar5 = puVar4[puVar11];
                                DAT_11E |= 4;
                                uVar2 = (ushort)health;
                                sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                            }
                        }
                        else
                        {
                            if (uVar2 == 0x2301 || uVar2 == 0x2401 || uVar2 == 0x604)
                            {
                                iVar3 = (int)GameManager.FUN_64650();
                                uVar10 = puVar4[puVar11 + 3];

                                if (uVar10 == 0)
                                    return; //trap(0x1c00)

                                if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                    return; //trap(0x1800)

                                uVar5 = puVar4[puVar11 + 2];
                                DAT_11E |= 4;
                                uVar2 = (ushort)health;
                                sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                            }
                            else
                            {
                                if (uVar2 == 0x2201)
                                {
                                    iVar3 = (int)GameManager.FUN_64650();
                                    uVar10 = puVar4[puVar11 + 5];

                                    if (uVar10 == 0)
                                        return; //trap(0x1c00)

                                    if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                        return; //trap(0x1800)

                                    uVar5 = puVar4[puVar11 + 4];
                                    DAT_1C3 = 3;
                                    uVar2 = (ushort)health;
                                    sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                                }
                                else
                                {
                                    if (uVar2 == 0x1a01 || uVar2 == 0x1c01 || uVar2 == 0x105)
                                    {
                                        if (UDAT_20C < (uVar10 & 0xffff) + 2500)
                                        {
                                            iVar3 = (int)GameManager.FUN_64650();
                                            uVar10 = puVar4[puVar11 + 7];

                                            if (uVar10 == 0)
                                                return; //trap(0x1c00)

                                            if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                                return; //trap(0x1800)

                                            uVar5 = puVar4[puVar11 + 6];
                                            DAT_1C3 = 1;
                                            uVar2 = (ushort)(uVar5 + (iVar3 % (int)uVar10) + 50);
                                            sVar9 = (short)(health - uVar2);
                                            DAT_11C = (short)uVar2;
                                        }
                                        else
                                        {
                                            iVar3 = (int)GameManager.FUN_64650();
                                            uVar10 = puVar4[puVar11 + 3];

                                            if (uVar10 == 0)
                                                return; //trap(0x1c00)

                                            if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                                return; //trap(0x1800)

                                            uVar5 = puVar4[puVar11 + 2];
                                            DAT_1C3 = 4;
                                            DAT_208 |= 0x20000;
                                            uVar2 = (ushort)(uVar5 + (iVar3 % (int)uVar10) + 50);
                                            sVar9 = (short)(health - uVar2);
                                            DAT_11C = (short)uVar2;
                                        }

                                        health = sVar9;

                                        if ((ushort)(DAT_3C | DAT_3D << 8) == 0x105)
                                            DAT_196 = 0;

                                        goto LAB_43E10;
                                    }

                                    if (uVar2 == 0x1201 || uVar2 == 0x1301 || uVar2 == 0x1401)
                                    {
                                        if (UDAT_20C < (uVar10 & 0xffff) + 2500)
                                        {
                                            iVar3 = (int)GameManager.FUN_64650();
                                            uVar10 = puVar4[puVar11 + 7];

                                            if (uVar10 == 0)
                                                return; //trap(0x1c00)

                                            if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                                return; //trap(0x1800)

                                            uVar5 = puVar4[puVar11 + 6];
                                            DAT_1C3 = 1;
                                            uVar2 = (ushort)health;
                                            sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                                        }
                                        else
                                        {
                                            iVar3 = (int)GameManager.FUN_64650();
                                            uVar10 = puVar4[puVar11 + 3];

                                            if (uVar10 == 0)
                                                return; //trap(0x1c00)

                                            if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                                return; //trap(0x1800)

                                            uVar5 = puVar4[puVar11 + 2];
                                            DAT_1C3 = 5;
                                            uVar2 = (ushort)health;
                                            sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                                        }
                                    }
                                    else
                                    {
                                        if (uVar2 == 0x1b01 || uVar2 == 5)
                                        {
                                            if (UDAT_20C < (uVar10 & 0xffff) + 2500)
                                            {
                                                iVar3 = (int)GameManager.FUN_64650();
                                                uVar10 = puVar4[puVar11 + 7];

                                                if (uVar10 == 0)
                                                    return; //trap(0x1c00)

                                                if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                                    return; //trap(0x1800)

                                                uVar5 = puVar4[puVar11 + 6];
                                                DAT_1C3 = 1;
                                                uVar2 = (ushort)health;
                                                sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                                            }
                                            else
                                            {
                                                iVar3 = (int)GameManager.FUN_64650();
                                                uVar10 = puVar4[puVar11 + 3];

                                                if (uVar10 == 0)
                                                    return; //trap(0x1c00)

                                                if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                                    return; //trap(0x1800)

                                                uVar5 = puVar4[puVar11 + 2];
                                                DAT_11E |= 4;
                                                uVar2 = (ushort)health;
                                                sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                                            }
                                        }
                                        else
                                        {
                                            if (DAT_3C - 3U < 2)
                                            {
                                                DAT_11E |= 4;
                                                goto LAB_43E10;
                                            }

                                            if (UDAT_20C < (uVar10 & 0xffff) + 2500)
                                            {
                                                iVar3 = (int)GameManager.FUN_64650();
                                                uVar10 = puVar4[puVar11 + 7];

                                                if (uVar10 == 0)
                                                    return; //trap(0x1c00)

                                                if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                                    return; //trap(0x1800)

                                                uVar5 = puVar4[puVar11 + 6];
                                                DAT_1C3 = 1;
                                                uVar2 = (ushort)health;
                                                sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                                            }
                                            else
                                            {
                                                if ((uVar10 & 0xffff) + 5000 <= UDAT_20C)
                                                {
                                                    iVar3 = (int)GameManager.FUN_64650();
                                                    uVar10 = puVar4[puVar11 + 3];

                                                    if (uVar10 == 0)
                                                        return; //trap(0x1c00)

                                                    if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                                        return; //trap(0x1800)

                                                    uVar2 = (ushort)(puVar4[puVar11 + 2] + (iVar3 % (int)uVar10) + 50);
                                                    DAT_11C = (short)uVar2;
                                                    health -= (short)uVar2;

                                                    if ((ushort)(DAT_3C | DAT_3D << 8) != 0x501 || 29 < DAT_60)
                                                    {
                                                        DAT_1C3 = 2;
                                                        DAT_208 &= 0xfffffffb;
                                                        goto LAB_43E10;
                                                    }

                                                    DAT_11E |= 4;
                                                    goto LAB_43E10;
                                                }

                                                iVar3 = (int)GameManager.FUN_64650();
                                                uVar10 = puVar4[puVar11 + 5];

                                                if (uVar10 == 0)
                                                    return; //trap(0x1c00)

                                                if (uVar10 == 0xffffffff && iVar3 == -0x80000000)
                                                    return; //trap(0x1800)

                                                uVar5 = puVar4[puVar11 + 4];
                                                uVar2 = (ushort)health;
                                                DAT_1C3 = 0;
                                                sVar9 = (short)((iVar3 % (int)uVar10) + 50);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                DAT_11C = (short)(uVar5 + sVar9);
                health = (short)(uVar2 - (uVar5 + sVar9));
            }

        LAB_43E10:
            if (health < 1)
            {
                uVar10 = DAT_208;
                uVar7 = uVar10 & 0xffffffef;
                DAT_208 = uVar7;

                if ((byte)DAT_1C3 < 2U || DAT_1C3 == 3)
                {
                    if ((uVar10 & 0x10000000) == 0)
                    {
                        DAT_208 = uVar7 | 0x10000000;
                        uVar10 = GameManager.FUN_64650();

                        if ((uVar10 & 1) != 0 || DAT_1A6)
                        {
                            InventoryManager.FUN_4A7E8(4, DAT_163, true);
                            goto LAB_44020;
                        }

                        DAT_1A6 = true;
                        DAT_208 |= 0x10;
                        FUN_40CA4();
                    }
                }
                else
                {
                    if ((DAT_11E & 4) == 0)
                        uVar2 = (ushort)(DAT_3C | DAT_3D << 8);
                    else
                    {
                        if (DAT_3C - 2U < 2 || (uVar2 = (ushort)(DAT_3C | DAT_3D << 8)) == 0x604)
                        {
                            InventoryManager.FUN_4A7E8(4, DAT_163, true);
                            goto LAB_44020;
                        }
                    }

                    if (uVar2 == 0x2301 || uVar2 == 0x2401)
                        health = 1;
                    else
                    {
                        if (1U < (byte)DAT_1C3 && DAT_1C3 != 3)
                        {
                            FUN_65CF8(0, 0, 30);

                            if ((byte)DAT_1C3 - 4U < 2 || (DAT_3C == 5 && DAT_3D == 0 && 79U < DAT_60) ||
                                (DAT_3C == 1 && DAT_3D == 0x1b))
                            {
                                DAT_3C = 3;
                                DAT_3D = 0;
                                DAT_3E = 0;
                                DAT_3F = 0;
                                DAT_11E |= 0x44;
                                FUN_2F848();
                            }
                            else
                            {
                                DAT_3C = 3;
                                DAT_3D = 1;
                                DAT_3E = 0;
                                DAT_3F = 0;
                                uVar10 = GameManager.FUN_64650();

                                if ((uVar10 & 1) == 0 && DAT_1A6)
                                {
                                    DAT_1A6 = true;
                                    DAT_208 |= 0x10;
                                    FUN_40CA4();
                                    return;
                                }

                                DAT_208 &= 0xffffffef;
                                DAT_11E |= 0x44;
                            }

                            InventoryManager.FUN_4A7E8(4, DAT_163, true);
                            return;
                        }
                    }
                }
            }
        }
        else
            DAT_11E |= 4;

        LAB_44020:
        if ((DAT_11E & 4) != 0)
        {
            DAT_208 |= 0x20;

            if ((DAT_11E & 4) != 0) goto LAB_44118;
        }

        if (DAT_3C == 1 && DAT_3D == 7)
        {
            iVar3 = DAT_1EC;

            if (iVar3 < 0)
                iVar3 += 31;

            vr.y = (short)(vr.y + (iVar3 >> 5) * DAT_60 & 0xfff);
        }

        sVar1 = DAT_1C3;

        if (sVar1 == 2)
        {
            uVar10 = DAT_208;
            uVar8 = 0x302;
            DAT_3C = (byte)uVar8;
            DAT_3D = (byte)(uVar8 >> 8);
            DAT_3E = (byte)(uVar8 >> 0x10);
            DAT_3F = (byte)(uVar8 >> 0x18);
            DAT_208 = uVar10 | 0x20;
        }
        else
        {
            if (sVar1 == 3)
            {
                DAT_3C = 2;
                DAT_3D = 1;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                uVar8 = 0x402;

                if ((byte)(sVar1 - 4) < 2U)
                {
                    uVar10 = DAT_208;
                    DAT_3C = (byte)uVar8;
                    DAT_3D = (byte)(uVar8 >> 8);
                    DAT_3E = (byte)(uVar8 >> 0x10);
                    DAT_3F = (byte)(uVar8 >> 0x18);
                    DAT_208 = uVar10 | 0x20;
                }
                else
                {
                    DAT_3C = 2;
                    DAT_3D = 0;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
            }
        }

        FUN_2F848();
        FUN_65CF8(0, 0, 30);
        DAT_11E |= 4;

        LAB_44118:
        if ((DAT_208 & 0x4000) != 0)
            BDAT_1D8++;
    }

    private void FUN_44150()
    {
        ushort uVar1;
        uint uVar2;
        int iVar3;
        uint uVar4;

        GameManager.FUN_64650();
        DAT_1D5 = 0;

        if (DAT_3C != 2 && (ushort)(DAT_3C | DAT_3D << 8) != 0xe01)
            DAT_1C3 = -1;

        if (DAT_3C - 2U < 3 || (uVar1 = (ushort)(DAT_3C | DAT_3D << 8)) == 0xc01 || 
            uVar1 == 0x1b01 || uVar1 == 0x2301 || uVar1 == 0x2401 || uVar1 == 0xe01 || uVar1 == 0x2201)
        {
            DAT_11E |= 4;

            if ((ushort)(DAT_3C | DAT_3D << 8) != 0xc01) goto LAB_44354;

            uVar2 = DAT_208 | 0x400000;
            DAT_208 = uVar2;
        }
        else
        {
            if (uVar1 == 0x1001 || uVar1 == 0x1101)
            {
                if ((DAT_208 & 0x10000) != 0)
                {
                    DAT_11E |= 4;

                    if ((ushort)(DAT_3C | DAT_3D << 8) != 0xc01) goto LAB_44354;

                    uVar2 = DAT_208 | 0x400000;
                    DAT_208 = uVar2;
                    goto LAB_44354;
                }

                uVar1 = (ushort)(DAT_3C | DAT_3D << 8);
            }

            if (uVar1 == 0x1a01 || uVar1 == 0x1c01)
            {
                DAT_1C3 = 4;

                if (DAT_194 != 1)
                {
                    uVar2 = DAT_208 | 0x20000;
                    DAT_208 = uVar2;
                    goto LAB_44354;
                }

                DAT_194 = 0;

                if (BDAT_1DC == 2)
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    uVar1 = (ushort)(iVar3 + (iVar3 / 10) * -10 + 15);
                }
                else
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    uVar1 = (ushort)(iVar3 + (iVar3 / 3) * -3 + 2);
                }

                DAT_196 = (short)(uVar1 * 30);
                uVar2 = DAT_208;
                uVar4 = 0xfffdffff;
            }
            else
            {
                if (uVar1 == 0x1201 || uVar1 == 0x1301 || uVar1 == 0x1401)
                {
                    DAT_1C3 = 5;
                    goto LAB_44354;
                }

                if (BDAT_1DC != 0)
                {
                    DAT_1C3 = 0;
                    goto LAB_44354;
                }

                DAT_1C3 = 2;
                uVar2 = DAT_208;
                uVar4 = 0xfffffffb;
            }

            DAT_208 = uVar2 & uVar4;
        }

        LAB_44354:
        if ((DAT_11E & 4) == 0)
        {
            if (DAT_3C == 1 && DAT_3D == 7)
            {
                iVar3 = DAT_1EC;

                if (iVar3 < 0)
                    iVar3 += 31;

                vr.y = (short)(vr.y + (iVar3 >> 5) * DAT_60 & 0xfff);
            }

            if (DAT_1C3 == 2)
            {
                DAT_3C = 2;
                DAT_3D = 3;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                if ((byte)DAT_1C3 - 4U < 2)
                {
                    DAT_3C = 2;
                    DAT_3D = 4;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
                else
                {
                    DAT_3C = 2;
                    DAT_3D = 0;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
            }

            FUN_2F848();
            FUN_65CF8(0, 0, 30);
            DAT_11E |= 4;
        }

        if ((DAT_208 & 0x4000) != 0)
            BDAT_1D8++;

        FUN_40A1C();
    }

    private void FUN_4444C()
    {
        byte bVar1;

        if (DAT_3C != 5 && (DAT_3C != 4 || DAT_3D == 6))
        {
            BDAT_1DC = 0;
            bVar1 = (byte)(DAT_1DD + 1);
            DAT_1DD = bVar1;

            if (1 < bVar1)
                DAT_194 = 1;

            FUN_44150();
        }
    }

    private void FUN_444B8()
    {
        if (DAT_3C != 5 && (DAT_3C != 4 || DAT_3D == 6))
        {
            BDAT_1DC = 1;
            DAT_194 = 1;
            FUN_44150();
        }
    }

    private void FUN_44508()
    {
        if (DAT_3C != 5 && (DAT_3C != 4 || DAT_3D == 6))
        {
            BDAT_1DC = 2;
            DAT_194 = 1;
            FUN_44150();
        }
    }

    private void FUN_44558()
    {
        sbyte sVar1;
        uint uVar2;
        uint uVar3;
        int iVar4;
        ushort uVar5;
        uint uVar6;

        if ((DAT_11E & 1) != 0)
        {
            DAT_11E |= 4;
            goto LAB_448C8;
        }

        if (DAT_3C == 4 && (ushort)(DAT_3C | DAT_3D << 8) != 0x604)
            return;

        health = -1;

        if ((ushort)(DAT_3C | DAT_3D << 8) != 0x2301 &&
            (ushort)(DAT_3C | DAT_3D << 8) != 0x2401)
            DAT_1A6 = true;

        GameManager.FUN_64650();
        BDAT_1DC = 3;
        DAT_1D5 = 0;

        if (DAT_3C == 2)
            uVar5 = (ushort)(DAT_3C | DAT_3D << 8);
        else
        {
            uVar5 = (ushort)(DAT_3C | DAT_3D << 8);

            if (uVar5 != 0xe01)
            {
                DAT_1C3 = -1;
                uVar5 = (ushort)(DAT_3C | DAT_3D << 8);
            }
        }

        if (uVar5 == 0xc01)
        {
            if (DAT_60 < 9)
                DAT_1C3 = 0;
            else
                DAT_1C3 = 3;
        }
        else
        {
            if (uVar5 == 0x1a01 || uVar5 == 0x1c01)
            {
                DAT_1C3 = 4;
                uVar2 = DAT_208;
                DAT_208 = uVar2 | 0x20000;
            }
            else 
            {
                if (uVar5 == 0x1201 || uVar5 == 0x1301 || uVar5 == 0x1401)
                    DAT_1C3 = 5;
                else
                {
                    if (uVar5 == 0x105)
                    {
                        DAT_1C3 = 4;
                        uVar2 = DAT_208;
                        DAT_196 = 0;
                        DAT_208 = uVar2 | 0x20000;
                    }
                    else if (DAT_3C - 2U < 3 || uVar5 == 0xe01 || uVar5 == 0x2301 ||
                             uVar5 == 0x2401 || uVar5 == 5 || uVar5 == 0x1b01)
                        DAT_11E |= 4;
                    else
                    {
                        if (uVar5 != 0x2201)
                            DAT_1C3 = 0;
                        else
                            DAT_1C3 = 3;
                    }
                }
            }
        }

        if (0 < health) goto LAB_448C8;

        uVar2 = DAT_208;
        uVar6 = uVar2 & 0xffffffef;
        DAT_208 = uVar6;

        if (DAT_1C3 < 2 || DAT_1C3 == 3)
        {
            if ((uVar2 & 0x10000000) != 0) goto LAB_448C8;

            DAT_208 = uVar6 | 0x10000000;
            uVar2 = GameManager.FUN_64650();

            if ((uVar2 & 1) == 0 && !DAT_1A6)
            {
                DAT_1A6 = true;
                DAT_208 |= 0x10;
                FUN_40CA4();
                goto LAB_448C8;
            }

            InventoryManager.FUN_4A7E8(4, DAT_163, true);
        }
        else
        {
            if ((DAT_11E & 4) == 0)
                uVar5 = (ushort)(DAT_3C | DAT_3D << 8);
            else if (DAT_3C - 2U < 2 || (uVar5 = (ushort)(DAT_3C | DAT_3D << 8)) == 0x1b01 || uVar5 == 0x604)
                InventoryManager.FUN_4A7E8(4, DAT_163, true);
            else if (uVar5 == 0x2301 || uVar5 == 0x2401)
                health = 1;
            else
            {
                if (1U < (byte)DAT_1C3 && DAT_1C3 != 3)
                {
                    FUN_65CF8(0, 0, 30);

                    if ((byte)DAT_1C3 - 4U < 2)
                    {
                        DAT_3C = 3;
                        DAT_3D = 0;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        DAT_11E |= 0x44;
                        FUN_2F848();
                    }
                    else
                    {
                        uVar3 = 0x103;

                        if (DAT_3C == 5 && DAT_3D == 0)
                        {
                            uVar3 = 0x502;

                            if (79U < DAT_60)
                            {
                                DAT_3C = 3;
                                DAT_3D = 0;
                                DAT_3E = 0;
                                DAT_3F = 0;
                                DAT_11E |= 0x44;
                                FUN_2F848();
                                goto LAB_448C8;
                            }
                        }

                        DAT_3C = (byte)uVar3;
                        DAT_3D = (byte)(uVar3 >> 8);
                        DAT_3E = (byte)(uVar3 >> 0x10);
                        DAT_3F = (byte)(uVar3 >> 0x18);
                        DAT_208 &= 0xffffffef;
                        DAT_11E |= 0x44;
                    }

                    InventoryManager.FUN_4A7E8(4, DAT_163, true);
                    return;
                }
            }
        }

        LAB_448C8:
        if ((DAT_11E & 4) == 0)
        {
            if (DAT_3C == 1 && DAT_3D == 7)
            {
                iVar4 = DAT_1EC;

                if (iVar4 < 0)
                    iVar4 += 31;

                vr.y = (short)(vr.y + (iVar4 >> 5) * DAT_60 & 0xfff);
            }

            sVar1 = DAT_1C3;

            if (sVar1 == 2)
            {
                DAT_3C = 2;
                DAT_3D = 3;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                if (sVar1 == 3)
                {
                    DAT_3C = 2;
                    DAT_3D = 1;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
                else
                {
                    if ((byte)sVar1 - 4U < 2)
                    {
                        DAT_3C = 2;
                        DAT_3D = 4;
                        DAT_3E = 0;
                        DAT_3F = 0;
                    }
                    else
                    {
                        DAT_3C = 2;
                        DAT_3D = 0;
                        DAT_3E = 0;
                        DAT_3F = 0;
                    }
                }
            }

            FUN_2F848();
            FUN_65CF8(0, 0, 30);
            DAT_11E |= 4;
        }

        if ((DAT_208 & 0x4000) != 0)
            BDAT_1D8++;

        FUN_40A1C();
    }

    private void FUN_449DC()
    {
        PTR_FUN_9C694[(DAT_1A1 & 0xf) == 9 ? 1 : 0]();
    }

    private void FUN_44A24()
    {
        sbyte sVar1;
        int iVar2;
        uint uVar3;
        byte bVar4;
        ushort uVar5;
        uint uVar6;
        uint uVar7;
        int puVar8;
        ushort[] aVar8;

        if ((DAT_11E & 1) != 0)
        {
            DAT_11E |= 4;
            goto LAB_44D5C;
        }

        GameManager.FUN_64650();
        DAT_1D5 = 0;
        BDAT_1DC = 4;

        if (GameManager.instance.DAT_A2D2 == 0)
        {
            aVar8 = Utilities.DAT_9B4A0;
            puVar8 = 24;
        }
        else
        {
            aVar8 = Utilities.DAT_9B500;
            puVar8 = 24;
        }

        bVar4 = DAT_3C;

        if (bVar4 != 2)
        {
            if (DAT_3C != 1 || DAT_3D != 14)
                DAT_1C3 = -1;

            bVar4 = DAT_3C;
        }

        if (bVar4 != 4 || (DAT_3C == 4 && DAT_3D == 6))
        {
            iVar2 = (int)GameManager.FUN_64650();
            uVar6 = aVar8[puVar8 + 7];

            if (uVar6 == 0)
                return; //trap(0x1c00)

            if (uVar6 == 0xffffffff && iVar2 == -0x80000000)
                return; //trap(0x1800)

            uVar5 = (ushort)(aVar8[puVar8 + 6] + (iVar2 % (int)uVar6));
            DAT_11C = (short)uVar5;
            health -= (short)uVar5;
        }

        uVar5 = (ushort)(DAT_3C | DAT_3D << 8);

        if ((uVar5 == 0xc01 && 8U < DAT_60) || uVar5 == 0x2201)
        {
            sVar1 = 3;
            DAT_1C3 = sVar1;
        }
        else
        {
            if ((uVar5 != 2 || DAT_1C3 != 1) && 
                uVar5 != 0x2301 && uVar5 != 0x2401 && DAT_3C != 3)
            {
                sVar1 = 1;

                if (DAT_3C != 4)
                {
                    DAT_1C3 = sVar1;
                    goto LAB_44BBC;
                }
            }

            DAT_11E |= 4;
        }

        LAB_44BBC:
        if (0 < health) goto LAB_44D5C;

        uVar6 = DAT_208;
        uVar7 = uVar6 & 0xffffffef;
        DAT_208 = uVar7;

        if ((byte)DAT_1C3 < 2U || DAT_1C3 == 3)
        {
            if ((uVar6 & 0x10000000) != 0) goto LAB_44D5C;

            DAT_208 = uVar7 | 0x10000000;
            uVar6 = GameManager.FUN_64650();

            if ((uVar6 & 1) == 0 && !DAT_1A6)
            {
                DAT_1A6 = true;
                DAT_208 |= 0x10;
                FUN_40CA4();
                goto LAB_44D5C;
            }

            InventoryManager.FUN_4A7E8(4, DAT_163, true);
        }
        else
        {
            if ((DAT_11E & 4) == 0)
                uVar5 = (ushort)(DAT_3C | DAT_3D << 8);
            else if (DAT_3C - 2U < 2 || (uVar5 = (ushort)(DAT_3C | DAT_3D << 8)) == 0x604)
                InventoryManager.FUN_4A7E8(4, DAT_163, true);
            else if (uVar5 == 0x2301 || uVar5 == 0x2401)
                health = 1;
            else
            {
                if (DAT_1C3 != 1 && DAT_1C3 != 3)
                {
                    FUN_65CF8(0, 0, 30);
                    DAT_3C = 3;
                    DAT_3D = 1;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    uVar6 = GameManager.FUN_64650();

                    if ((uVar6 & 1) == 0 && !DAT_1A6)
                    {
                        DAT_1A6 = true;
                        DAT_208 |= 0x10;
                        FUN_40CA4();
                        return;
                    }

                    DAT_208 &= 0xffffffef;
                    DAT_11E |= 0x44;
                    InventoryManager.FUN_4A7E8(4, DAT_163, true);
                    return;
                }
            }
        }

        LAB_44D5C:
        if ((DAT_11E & 4) == 0)
        {
            if (DAT_3C == 1 && DAT_3D == 7)
            {
                iVar2 = DAT_1EC;

                if (iVar2 < 0)
                    iVar2 += 31;

                vr.y = (short)(vr.y + (iVar2 >> 5) * DAT_60 & 0xfff);
            }

            uVar3 = 2;

            if (DAT_1C3 == 3)
                uVar3 = 0x102;

            DAT_3C = (byte)uVar3;
            DAT_3D = (byte)(uVar3 >> 8);
            DAT_3E = (byte)(uVar3 >> 0x10);
            DAT_3F = (byte)(uVar3 >> 0x18);
            FUN_2F848();
            FUN_65CF8(0, 0, 30);
            DAT_11E |= 4;
        }

        if ((DAT_208 & 0x4000) != 0)
            BDAT_1D8++;
    }

    private void FUN_44E30()
    {
        CriInteract oVar1;
        CriBone oVar2;

        if (DAT_202 == 0)
        {
            oVar1 = SceneManager.instance.FUN_5FF08();

            if (oVar1 != null)
            {
                oVar1.DAT_01 = 11;
                oVar1.BDAT_0A = 12;
                oVar2 = skeleton;
                //...
                oVar1.PTR_18 = oVar2;
                DAT_202 = 50;
            }
        }

        FUN_44A24();
    }

    private void FUN_4F1AC()
    {
        SharedAssets.PTR_FUN_9CE84[DAT_240 >> 4][DAT_240 & 15](this);
        PTR_FUN_9CE94[DAT_241]();
    }

    public uint FUN_50470()
    {
        CriObject oVar1;
        CriSkinned oVar2;
        CriObject oVar3;
        uint uVar3;
        uint uVar4;
        Vector2Int local_18;

        if (DAT_24C[0] == 0)
        {
            if (DAT_225 < 30)
            {
                uVar3 = (byte)DAT_226;
                DAT_225++;
            }
            else
                uVar3 = 0x80;
        }
        else
        {
            oVar2 = SceneManager.instance.DAT_27C[DAT_24C[DAT_24C[0]]];
            oVar3 = Utilities.FUN_601C8(oVar2.skeleton, oVar2.DAT_175 & 15);
            oVar1 = Utilities.FUN_601C8(skeleton, 3);
            local_18 = new Vector2Int();
            Utilities.FUN_52420(oVar1.screen, oVar3.screen, ref local_18);
            uVar4 = (uint)(local_18.x + 0x200 & 0xfff);

            if (uVar4 < 0x400)
                uVar3 = 0x400 - uVar4 >> 2;
            else
            {
                uVar3 = 0xff;

                if (uVar4 < 0xa00)
                    uVar3 = 0;
            }

            DAT_225 = 0;
        }

        return uVar3 & 0xffff;
    }

    public void FUN_50570(Vector3Int[] param1)
    {
        bool bVar1;
        bool bVar2;
        uint uVar3;
        uint uVar4;
        byte bVar6;
        uint uVar7;
        byte bVar8;
        CriSkinned oVar9;
        uint[] local_68;
        byte[] local_58;
        Vector2Int[] auStack64;
        Vector3Int local_30;

        local_68 = new uint[10];
        local_58 = new byte[40];
        auStack64 = new Vector2Int[4];
        FUN_50748(param1, auStack64);
        bVar8 = 0;
        bVar6 = 0;

        do
        {
            oVar9 = SceneManager.instance.DAT_27C[bVar6];

            if ((oVar9.flags & 1) != 0 && (oVar9.DAT_11E & 0x40) == 0 && (oVar9.DAT_175 & 0x80) == 0)
            {
                bVar1 = SceneManager.instance.FUN_80D48(screen, oVar9.screen, 5);

                if (!bVar1)
                {
                    local_30 = new Vector3Int();
                    local_30.x = oVar9.screen.x - screen.x;
                    local_30.y = oVar9.screen.y - screen.y;
                    local_30.z = oVar9.screen.z - screen.z;
                    bVar2 = GameManager.instance.FUN_768C8(local_30, auStack64);

                    if (bVar2)
                    {
                        uVar3 = Utilities.FUN_63160(screen, oVar9.screen);
                        local_68[bVar8] = uVar3 & 0xffffff00 | bVar6;
                        bVar8++;
                    }
                }
            }

            bVar6++;
        } while (bVar6 < 10);

        for (int i = 0; i < 10; i++)
        {
            local_58[i * 4] = (byte)local_68[i];
            local_58[i * 4 + 1] = (byte)(local_68[i] >> 8);
            local_58[i * 4 + 2] = (byte)(local_68[i] >> 0x10);
            local_58[i * 4 + 3] = (byte)(local_68[i] >> 0x18);
        }

        Utilities.QSort(local_58, 0, bVar8, 4, GameManager.instance.FUN_53B08);
        uVar3 = bVar8;

        if (3 < bVar8)
        {
            bVar8 = 3;
            uVar3 = 3;
        }

        uVar7 = 0;

        if (uVar3 != 0)
        {
            uVar4 = 0;

            do
            {
                uVar7++;
                DAT_24C[uVar3 - uVar4] = local_58[uVar4 * 4];
                uVar4 = uVar7 & 0xff;
            } while ((uVar7 & 0xff) < uVar3);
        }

        DAT_24C[0] = bVar8;
    }

    private void FUN_50748(Vector3Int[] param1, Vector2Int[] param2)
    {
        uint uVar1;
        Vector3Int local_58;
        Vector3Int local_48;
        CriTransform MStack64;

        local_58 = new Vector3Int(0, 0, 0);
        MStack64 = new CriTransform();
        Utilities.FUN_8F270(ref MStack64, local_58);
        local_48 = new Vector3Int(0, vr.y, 0);
        uVar1 = 0;
        Utilities.RotMatrix(ref local_48, ref MStack64.rotation);
        Utilities.SetRotMatrix(ref MStack64.rotation);

        do
        {
            Utilities.RotTrans(ref param1[uVar1], ref local_58);
            param2[uVar1] = new Vector2Int(local_58.x, local_58.z);
            uVar1++;
        } while (uVar1 < 4);
    }

    private void FUN_508B8()
    {
        return;
    }

    private void FUN_508C0()
    {
        short sVar1;
        int iVar2;

        if (!GameManager.instance.DAT_A2D0)
            DAT_241 = 0;
        else
        {
            sVar1 = Utilities.FUN_524F0(screen, DAT_228, (short)vr.y);
            iVar2 = sVar1 * 0x78;

            if (iVar2 < 0)
                iVar2 = iVar2 + 0x7ff;

            DAT_21A = (short)((iVar2 >> 11) + 60);
            DAT_241 = 2;
        }
    }

    private void FUN_5094C()
    {
        short sVar1;
        int iVar2;

        sVar1 = Utilities.FUN_51C8C(screen, DAT_228, vr.y, DAT_21A);
        iVar2 = sVar1;

        if (iVar2 < 0)
            iVar2 = -iVar2;

        vr.y = vr.y + sVar1 & 0xfff;

        if (iVar2 < 3)
            DAT_241 = 3;
    }

    private void FUN_509C4()
    {
        DAT_21A = 90;
        DAT_241 = 0;
    }

    public void FUN_512BC()
    {
        PTR_FUN_9D03C[DAT_3E]();
    }

    private void FUN_512F8()
    {
        uint uVar1;

        uVar1 = GameManager.DAT_1f800008;
        PTR_FUN_9D064[DAT_3F]();

        if ((uVar1 & 8) == 0)
        {
            DAT_227 &= 0x7f;
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_18C = 0x81;
        }
    }

    private void FUN_51394()
    {
        bool bVar1;

        DAT_40.z = 0;
        DAT_18C = 0x81;
        DAT_1C0 |= 1;
        DAT_227 |= 0x80;
        bVar1 = FUN_50128();

        if (bVar1)
            DAT_241 = 1;

        FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x80194d3c), 0, 6, 0);
        DAT_3F++;
    }

    private void FUN_51424()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_1F5 = 0;
            DAT_3E = 1;
            DAT_3F = 0;
        }
    }

    private void FUN_51468()
    {
        uint uVar1;
        byte bVar3;

        uVar1 = GameManager.DAT_1f800008;

        if (DAT_3F == 0)
        {
            DAT_40 = Vector3Int.zero;
            DAT_1C0 |= 1;
            FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x801982e8), 1, DAT_1F5, 0);
            DAT_21A = 90;
            DAT_225 = 30;
            DAT_3F++;
        }
        else
        {
            if (DAT_3F == 1)
            {
                if (DAT_18C != 0 && DAT_5D == 0)
                    DAT_18C = 0;

                FUN_60AB4();
            }
        }

        if ((uVar1 & 8) == 0)
        {
            DAT_18C = 0x81;
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
        }
        else
        {
            if ((uVar1 & 0x40000) == 0 || !FUN_502B8())
            {
                if ((uVar1 & 0x1000) == 0)
                {
                    if ((uVar1 & 0x4000) == 0)
                    {
                        if ((uVar1 & 0xa000) == 0)
                            return;

                        DAT_226 = -0x80;
                        DAT_3E = 7;
                        DAT_3F = 0;
                        return;
                    }

                    DAT_3E = 6;
                    DAT_3F = 0;
                    bVar3 = 80;
                }
                else
                {
                    DAT_3E = 5;
                    DAT_3F = 0;
                    bVar3 = 28;
                }

                DAT_1F4 = bVar3;
                DAT_1F5 = 4;
                DAT_1F6 = 0;
            }
            else
                DAT_241 = 1;
        }
    }

    private void FUN_51604()
    {
        uint uVar1;
        bool bVar2;
        uint uVar3;

        uVar1 = GameManager.DAT_1f800008;

        if (DAT_3F == 0)
        {
            FUN_609C8((TodScriptableObject)Utilities.GetRamObject(0x8019508c), 0, 6, 0);
            DAT_40.z = 0;
            DAT_3F = 1;
            DAT_1C0 |= 1;
        }
        else
        {
            if (DAT_3F == 1)
            {
                bVar2 = FUN_60AB4();

                if (bVar2)
                {
                    DAT_3C = 1;
                    DAT_3D = 0;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
            }
        }

        InventoryManager.FUN_4A7E8(1, 0xb, false);

        if ((uVar1 & 8) == 0)
        {
            if ((uVar1 & 0x1000) == 0)
            {
                uVar3 = 0x201;

                if ((uVar1 & 0x4000) == 0)
                {
                    if (DAT_1C6 == 0)
                        return;

                    uVar3 = 0x901;

                    if ((uVar1 & 2) == 0)
                        return;
                }
            }
            else
            {
                if ((uVar1 & 0x40) == 0)
                {
                    DAT_1F4 = 22;
                    DAT_1F5 = 8;
                    uVar3 = 0x101;
                }
                else
                {
                    uVar3 = 0x501;
                    DAT_1F4 = 0;
                }
            }

            DAT_3C = (byte)uVar3;
            DAT_3D = (byte)(uVar3 >> 8);
            DAT_3E = (byte)(uVar3 >> 0x10);
            DAT_3F = (byte)(uVar3 >> 0x18);
        }
        else
        {
            DAT_1F5 = 6;
            DAT_3E = 1;
            DAT_3F = 0;
        }
    }

    private void FUN_5174C()
    {
        short sVar1;
        uint uVar2;
        short sVar4;
        uint uVar5;

        uVar2 = GameManager.DAT_1f800008;

        if (DAT_3F == 0)
        {
            sVar1 = DAT_9D02C[DAT_1D7];
            DAT_1C0 &= 0xfffffffe;
            DAT_40.z = sVar1;
            uVar5 = DAT_1F4 % 0x22U;
            DAT_1F4 = (byte)uVar5;
            DAT_227 |= 0x20;
            FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x80195388), 1, (byte)uVar5, DAT_1F5);
            DAT_3F++;
        }
        else
        {
            if (DAT_3F == 1)
                FUN_60AB4();
        }

        if ((uVar2 & 0x2000) == 0)
        {
            if ((uVar2 & 0x8000) == 0) goto LAB_5187C;

            sVar4 = (short)(vr.y - 0x20);
        }
        else
            sVar4 = (short)(vr.y + 0x20);

        vr.y = sVar4;

        LAB_5187C:
        if ((uVar2 & 8) == 0)
        {
            DAT_227 &= 0xdf;
            DAT_1F5 = 8;
            DAT_1F4 = (byte)((frameNum * 30) / 34);
            DAT_3C = 1;
            DAT_3D = 1;
            DAT_3E = 0;
            DAT_3F = 0;
        }
        else
        {
            if ((uVar2 & 0x1000) == 0)
            {
                DAT_18C = 0x80;
                DAT_1F5 = 8;
                DAT_227 &= 0xdf;
                DAT_3E = 1;
                DAT_3F = 0;
            }
            else
            {
                if ((uVar2 & 0x40000) != 0 && FUN_502B8())
                    DAT_241 = 1;
            }
        }
    }

    private void FUN_5194C()
    {
        short sVar1;
        uint uVar2;
        short sVar4;

        uVar2 = GameManager.DAT_1f800008;

        if (DAT_3F == 0)
        {
            sVar1 = DAT_9D034[DAT_1D7];
            DAT_1C0 &= 0xfffffffe;
            DAT_40.z = sVar1;
            DAT_1F4 = (byte)(DAT_1F4 * 0x13U >> 7);
            DAT_227 |= 0x20;
            FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x80195eb8), 1, DAT_1F4, DAT_1F5);
            DAT_3F++;
        }
        else
        {
            if (DAT_3F == 1)
                FUN_60AB4();
        }

        if ((uVar2 & 0x2000) == 0)
        {
            if ((uVar2 & 0x8000) == 0) goto LAB_51A6C;

            sVar4 = (short)(vr.y - 0x20);
        }
        else
            sVar4 = (short)(vr.y + 0x20);

        vr.y = sVar4;

        LAB_51A6C:
        if ((uVar2 & 8) == 0)
        {
            DAT_1F5 = 10;
            DAT_1F4 = 0;
            DAT_227 &= 0xdf;
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
        }
        else
        {
            if ((uVar2 & 0x4000) == 0)
            {
                DAT_1F5 = 8;
                DAT_227 &= 0xdf;
                DAT_3E = 1;
                DAT_3F = 0;
            }
            else
            {
                if ((uVar2 & 0x40000) != 0 && FUN_502B8())
                    DAT_241 = 1;
            }
        }
    }

    private void FUN_51B08()
    {
        uint uVar1;
        ushort uVar2;
        byte bVar3;

        uVar1 = GameManager.DAT_1f800008;

        if (DAT_3F == 0)
        {
            DAT_18C = 0x81;
            DAT_1C0 |= 1;
            bVar3 = 3;

            if ((uVar1 & 0x8000) != 0)
                bVar3 = 1;

            DAT_1F4 = 0;
            DAT_1F5 = 6;
            FUN_6103C((TodScriptableObject)Utilities.GetRamObject(0x80198398), bVar3, DAT_1F4, 6);
            DAT_3F++;
        }
        else
        {
            if (DAT_3F == 1)
                FUN_60AB4();
        }

        if ((uVar1 & 0x2000) == 0)
        {
            if ((uVar1 & 0x8000) == 0)
            {
                DAT_1F5 = 6;
                DAT_3E = 1;
                DAT_3F = 0;
            }
            else
                vr.y -= 90;
        }
        else
            vr.y += 90;

        if ((uVar1 & 8) == 0)
        {
            DAT_1F5 = 11;
            DAT_227 &= 0xdf;
            DAT_3E = 4;
            DAT_3F = 0;
        }
        else
        {
            uVar2 = 5;

            if ((uVar1 & 0x1000) != 0 || (uVar1 & 0x4000) != 0)
            {
                if ((uVar1 & 0x1000) == 0)
                    uVar2 = 6;

                DAT_3E = (byte)uVar2;
                DAT_3F = (byte)(uVar2 >> 8);
                DAT_1F4 = 0;
                DAT_1F5 = 10;
                DAT_1F6 = 0;
            }
        }
    }

    public void FUN_50FE4(TodScriptableObject param1, TodScriptableObject param2, TodScriptableObject param3, byte param4, byte param5)
    {
        byte bVar1;
        byte bVar2;
        uint uVar3;

        packets = param1.PACKETS;
        bVar1 = (byte)param1.FRAME_COUNT;
        frames = param1.FRAMES;
        DAT_74 = param1.FRAMES;
        frameNum = 0;
        DAT_60 = 0;
        DAT_5C = param4;
        frameCount = bVar1;

        if ((param4 & 2) == 0)
            uVar3 = frameNum;
        else
            uVar3 = (uint)bVar1 - frameNum;

        packet = packets[frames[uVar3].DAT_01];
        bVar2 = frames[uVar3].DAT_00;
        DAT_62 = bVar2;

        if ((DAT_5C & 8) != 0)
            DAT_62 = (byte)(bVar2 << 1);

        DAT_5D = param5;
        GameManager.instance.DAT_C3380 = param2.PACKETS;
        GameManager.instance.DAT_C3384 = param2.FRAMES;
        GameManager.instance.DAT_C3390 = 0;
        GameManager.instance.DAT_C3388 = GameManager.instance.DAT_C3380
            [GameManager.instance.DAT_C3384[frameNum].DAT_01];
        GameManager.instance.DAT_C33A0 = param3.PACKETS;
        GameManager.instance.DAT_C33A4 = param3.FRAMES;
        GameManager.instance.DAT_C33B0 = 0;
        GameManager.instance.DAT_C33A8 = GameManager.instance.DAT_C33A0
            [GameManager.instance.DAT_C33A4[frameNum].DAT_01];
        GameManager.instance.DAT_C338C = GameManager.instance.DAT_C3384;
        GameManager.instance.DAT_C33AC = GameManager.instance.DAT_C33A4;
        frameNum++;
        FUN_50E48();
    }

    public bool FUN_51178()
    {
        uint uVar1;
        int iVar2;
        bool bVar3;

        bVar3 = false;

        if (DAT_62 == 0)
        {
            if ((DAT_5C & 2) == 0)
                uVar1 = frameNum;
            else
                uVar1 = (uint)frameCount - frameNum;

            iVar2 = (int)(uVar1 & 0xff);
            packet = packets[frames[iVar2].DAT_01];
            DAT_62 = frames[iVar2].DAT_00;
            GameManager.instance.DAT_C3388 = GameManager.instance.DAT_C3380
                [GameManager.instance.DAT_C338C[iVar2].DAT_01];
            GameManager.instance.DAT_C33A8 = GameManager.instance.DAT_C33A0
                [GameManager.instance.DAT_C33AC[iVar2].DAT_01];

            if ((uint)frameNum < frameCount)
                frameNum++;
            else
            {
                bVar3 = true;

                if ((DAT_5C & 1) != 0)
                {
                    frameNum = 0;
                    DAT_60 = 0;
                }
            }
        }

        FUN_50E48();
        return bVar3;
    }

    public void FUN_50E48()
    {
        CriBone oVar1;
        uint uVar2;
        Packet psVar3;
        Vector3Int local_18;

        psVar3 = packet;
        oVar1 = skeleton;
        DAT_64 = psVar3.DAT_06;

        if ((DAT_5C & 0x10) == 0)
        {
            local_18 = psVar3.DAT_00;
            uVar2 = (uint)(0x1000 / DAT_62);

            if (DAT_62 == 0)
                return; //trap(0x1c00)

            oVar1.DAT_44 = Utilities.LoadAverageShort12
                (ref oVar1.DAT_44, ref local_18, 0x1000 - (int)uVar2, (int)uVar2);
        }
        else
            oVar1.DAT_44 = psVar3.DAT_00;

        uVar2 = DAT_5D;

        if (uVar2 == 0)
        {
            uVar2 = DAT_62;

            if (uVar2 == 0)
                return; //trap(0x1c00)
        }
        else
        {
            DAT_5D--;

            if (uVar2 == 0)
                return; //trap(0x1c00)
        }

        FUN_50D08(psVar3.COMP, 0x1000 / (int)uVar2);
        DAT_62--;
    }

    public void FUN_50D08(uint[] param1, int param2)
    {
        int iVar2;
        uint[] aVar2;
        uint uVar3;
        uint[] aVar4;
        CriBone oVar4;
        List<Vector3Int> auStack280;
        List<Vector3Int> auStack160;

        auStack280 = new List<Vector3Int>();
        auStack160 = new List<Vector3Int>();
        aVar4 = GameManager.instance.DAT_C3388.COMP;
        aVar2 = GameManager.instance.DAT_C33A8.COMP;

        if (DAT_226 < 0)
        {
            Utilities.FUN_60C94(aVar4, auStack280, boneCount);
            Utilities.FUN_60C94(aVar2, auStack160, boneCount);
            iVar2 = ((byte)DAT_226 - 0x80) * 0x20;
        }
        else
        {
            Utilities.FUN_60C94(param1, auStack280, boneCount);
            Utilities.FUN_60C94(aVar4, auStack160, boneCount);
            iVar2 = (byte)DAT_226 << 5;
        }

        oVar4 = skeleton;
        uVar3 = 0;

        if (boneCount != 0)
        {
            do
            {
                Vector3Int temp1 = auStack280[(int)uVar3];
                Vector3Int temp2 = auStack160[(int)uVar3];
                Utilities.FUN_665D8(ref temp1, ref temp2, ref temp1, iVar2);
                auStack280[(int)uVar3] = temp1;
                auStack160[(int)uVar3] = temp2;
                Utilities.FUN_665D8(ref oVar4.vr, ref temp1, ref oVar4.vr, param2);
                uVar3++;
                oVar4 = (CriBone)oVar4.next;
            } while (uVar3 < boneCount);
        }
    }

    public void FUN_50CC8()
    {
        FUN_50AF4(1);
        FUN_50AF4(2);
        FUN_50AF4(3);
    }

    public void FUN_50AF4(byte param1)
    {
        byte bVar1;
        int iVar2;
        uint uVar3;
        uint uVar4;
        byte bVar5;

        uVar4 = param1;
        bVar5 = 0;
        bVar1 = (byte)InventoryManager.instance.FUN_6AB5C(((uint)DAT_244[uVar4 - 1] >> 8) + 16);

        if (uVar4 != 1)
        {
            if (1 < uVar4)
            {
                if (uVar4 == 2)
                {
                    uVar3 = (uint)DAT_244[1] >> 8;

                    if (uVar3 == 6)
                        bVar5 = 17;
                    else
                    {
                        if (uVar3 == 7)
                            bVar5 = 15;
                    }
                }
                else
                {
                    if (uVar4 == 3)
                    {
                        bVar5 = 3;

                        if ((DAT_240 & 1) == 0)
                            bVar5 = 1;
                    }
                }
            }

            goto LAB_50C48;
        }

        if ((DAT_240 & 3) == 0)
        {
            uVar3 = (uint)DAT_244[0] >> 8;

            if (uVar3 != 1)
            {
                if (1 < uVar3)
                {
                    if (uVar3 < 6)
                        bVar5 = 3;

                    goto LAB_50C48;
                }

                if (uVar3 != 0) goto LAB_50C48;
            }

            bVar5 = 5;
        }
        else
        {
            uVar3 = (uint)DAT_244[0] >> 8;

            if (uVar3 != 1)
            {
                if (1 < uVar3)
                {
                    if (uVar3 < 6)
                        bVar5 = 3;

                    goto LAB_50C48;
                }

                if (uVar3 != 0) goto LAB_50C48;
            }

            bVar5 = 7;
        }

        LAB_50C48:
        if (param1 == 3 && DAT_244[2] >> 8 == 10)
        {
            if (bVar1 == 0)
                bVar5 = 0;
        }
        else
        {
            if (bVar1 < bVar5)
                bVar5 = bVar1;
        }

        iVar2 = param1 - 1;
        DAT_244[iVar2] = (ushort)(DAT_244[iVar2] & 0xff00 | bVar5);
    }

    public bool FUN_50128()
    {
        uint uVar2;
        bool bVar3;
        int piVar4;
        uint uVar5;
        CriSkinned oVar7;
        int iVar8;
        uint[] local_50 = new uint[10];
        byte[] local_40 = new byte[40];

        uVar5 = 0;
        piVar4 = 0;
        iVar8 = 0;

        do
        {
            oVar7 = SceneManager.instance.DAT_27C[uVar5];
            uVar2 = 0x80000000;

            if ((oVar7.flags & 1) != 0 && 0 < oVar7.health && (oVar7.DAT_175 & 0x80) == 0)
            {
                uVar2 = Utilities.FUN_63160(screen, oVar7.screen);

                if (uVar2 < 0x9c4001)
                    local_50[piVar4] = 0;
                else
                    local_50[piVar4] = 0x20000000;

                bVar3 = FUN_520CC(oVar7);

                if (bVar3)
                    local_50[piVar4] += 0x10000000;

                iVar8++;
                uVar2 = local_50[piVar4] + (uVar2 >> 4) & 0xffffff00;
            }

            local_50[piVar4] = uVar2 + uVar5;
            uVar5++;
            piVar4++;
        } while (uVar5 < 10);

        for (int i = 0; i < 10; i++)
        {
            local_40[i * 4] = (byte)local_50[i];
            local_40[i * 4 + 1] = (byte)(local_50[i] >> 8);
            local_40[i * 4 + 2] = (byte)(local_50[i] >> 0x10);
            local_40[i * 4 + 3] = (byte)(local_50[i] >> 0x18);
        }

        if (iVar8 != 0)
        {
            Utilities.QSort(local_40, 0, 10, 4, GameManager.instance.FUN_53B08);
            uVar5 = 0;
            piVar4 = 0;

            do
            {
                DAT_230[uVar5] = local_40[piVar4];
                uVar5++;
                piVar4 += 4;
            } while (uVar5 < 10);
        }

        DAT_23F = 9;
        return FUN_502B8();
    }

    public bool FUN_502B8()
    {
        bool bVar1;
        CriObject oVar2;
        uint uVar3;
        uint uVar4;
        CriSkinned oVar6;
        uint uVar7;

        uVar4 = DAT_23F;
        uVar7 = 0;

        while (true)
        {
            uVar4 = (uVar4 + 1) % 10;
            oVar6 = SceneManager.instance.DAT_27C[DAT_230[uVar4]];
            oVar2 = Utilities.FUN_601C8(oVar6.skeleton, oVar6.DAT_175 & 15);

            if ((oVar6.flags & 1) != 0 && 0 < oVar6.health && (oVar6.DAT_175 & 0x80) == 0)
            {
                bVar1 = SceneManager.instance.FUN_80D48(screen, oVar6.screen, 5);

                if (!bVar1)
                {
                    uVar3 = Utilities.FUN_63160(screen, oVar2.screen);

                    if (249999 < uVar3) break;
                }
            }

            uVar7++;

            if (9 < uVar7)
                return false;
        }

        DAT_23F = (byte)uVar4;
        DAT_228 = oVar2.screen;
        DAT_22E = oVar2.DAT_26;
        return true;
    }

    public void FUN_5080C()
    {
        byte bVar1;
        CriSkinned oVar2;

        bVar1 = DAT_24C[0];

        if (bVar1 != 0)
        {
            DAT_24C[0] = (byte)(bVar1 - 1);
            oVar2 = SceneManager.instance.DAT_27C[DAT_24C[bVar1]];

            if ((oVar2.flags & 1) != 0 && (oVar2.DAT_11E & 0x40) == 0)
            {
                oVar2.DAT_11E |= 0x80;
                oVar2.DAT_1A1 = (byte)DAT_244[(DAT_240 >> 4) - 1];
                oVar2.DAT_1A0 = DAT_240;
            }
        }
    }

    public void FUN_509D8(Tod3ScriptableObject param1)
    {
        CriObject oVar2;
        CriParticle oVar3;
        Frame3 puVar4;
        int puVar5;

        puVar5 = DAT_1F4;
        oVar2 = Utilities.FUN_601C8(skeleton, 3);
        puVar4 = param1.FRAMES[puVar5];

        if (puVar4.FRAME_NUM == frameNum)
        {
            do
            {
                oVar3 = SceneManager.instance.FUN_5FFA0();

                if (oVar3 != null)
                {
                    oVar3.tags = 3;
                    oVar3.DAT_2F = 2;
                    oVar3.DAT_69 = puVar4.DAT_00;
                    oVar3.DAT_62 = puVar4.DAT_0C;
                    oVar3.DAT_60 = puVar4.DAT_0C;
                    oVar3.screen = puVar4.POSITION;
                    oVar3.DAT_40 = puVar4.VELOCITY;
                    oVar3.DAT_4C = oVar2;
                }

                puVar5++;
                DAT_1F4++;
                puVar4 = param1.FRAMES[puVar5];
            } while (puVar4.FRAME_NUM == frameNum);
        }
    }

    private bool FUN_520CC(CriSkinned param1)
    {
        int iVar1;
        CriObject oVar1;

        oVar1 = Utilities.FUN_601C8(param1.skeleton, param1.DAT_175 & 15);
        iVar1 = Utilities.FUN_615EC(screen, oVar1.screen);
        return (iVar1 - vr.y & 0xfff) - 0x300 < 0xa00;
    }

    private void FUN_5211C(byte param1)
    {
        bool bVar1;
        uint uVar2;
        bool bVar3;
        int puVar4;
        uint uVar5;
        CriSkinned oVar6;
        byte bVar8;
        uint[] local_50;
        byte[] local_40;

        bVar8 = 0;
        uVar5 = 0;
        puVar4 = 0;
        local_50 = new uint[10];
        local_40 = new byte[10 * 4];

        do
        {
            uVar2 = 0x80000000;
            oVar6 = SceneManager.instance.DAT_27C[uVar5];

            if (oVar6 != null && (oVar6.flags & 1) != 0 && 0 < oVar6.health && (oVar6.DAT_175 & 0x80) == 0)
            {
                bVar1 = SceneManager.instance.FUN_80D48(screen, oVar6.screen, 5);

                if (!bVar1)
                    local_50[puVar4] = 0;
                else
                    local_50[puVar4] = 0x40000000;

                uVar2 = Utilities.FUN_63160(screen, oVar6.screen);

                if (0x9c4000 < uVar2)
                    local_50[puVar4] += 0x20000000;

                bVar3 = FUN_520CC(oVar6);

                if (bVar3)
                    local_50[puVar4] += 0x10000000;

                bVar8++;
                uVar2 = local_50[puVar4] + (uVar2 >> 4) & 0xfffffff0;
            }

            local_50[uVar5] = uVar2 + uVar5;
            uVar5++;
            puVar4++;
        } while (uVar5 < 10);

        if (param1 == 0)
        {
            uVar5 = 1;

            do
            {
                if (local_50[uVar5] < local_50[0])
                    local_50[0] = local_50[uVar5];

                uVar5++;
            } while (uVar5 < 10);
        }
        else
        {
            for (int i = 0; i < local_50.Length; i++)
            {
                local_40[i * 4] = (byte)local_50[i];
                local_40[i * 4 + 1] = (byte)(local_50[i] >> 8);
                local_40[i * 4 + 2] = (byte)(local_50[i] >> 0x10);
                local_40[i * 4 + 3] = (byte)(local_50[i] >> 0x18);
            }

            Utilities.QSort(local_40, 0, 10, 4, GameManager.instance.FUN_53B08);

            for (int i = 0; i < local_50.Length; i++)
            {
                local_50[i] = (uint)(local_40[i * 4] | local_40[i * 4 + 1] << 8 | 
                    local_40[i * 4 + 2] << 0x10 | local_40[i * 4 + 3] << 0x18);
            }
        }

        DAT_219 = bVar8;
        DAT_224 = (byte)(local_50[param1] & 0xf);
        DAT_1C4 = (sbyte)(local_50[param1] >> 0x1c);
    }

    private void FUN_52320()
    {
        CriBone oVar1;
        long lVar2;
        Vector3Int local_50;
        Vector3Int local_48;
        Matrix3x3 MStack56;
        Vector3Int SStack64;

        DAT_204.z = 0;
        oVar1 = Utilities.FUN_601C8(skeleton, 7) as CriBone;
        local_50 = oVar1.screen;
        local_48 = new Vector3Int();
        local_48.y = Utilities.FUN_615EC(local_50, DAT_1FC);
        DAT_204.y = local_48.y;
        local_48.y = 0x1000 - local_48.y;
        local_48.z = 0;
        local_48.x = 0;
        MStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref local_48, ref MStack56);
        local_48.x = DAT_1FC.x - local_50.x;
        local_48.y = DAT_1FC.y - local_50.y;
        local_48.z = DAT_1FC.z - local_50.z;
        SStack64 = Utilities.ApplyMatrixSV(ref MStack56, ref local_48);
        lVar2 = Utilities.Ratan2(SStack64.y, SStack64.z);
        DAT_204.x = 0x1000 - (int)(lVar2 & 0xfff);
    }

    private void FUN_5342C()
    {
        CriObject oVar2;

        oVar2 = Utilities.FUN_601C8(skeleton, 7);
        DAT_20C = new Vector2Int(oVar2.vr.x, oVar2.vr.y);
        DAT_1F9 = 0;
        DAT_1F8 = 0;
        FUN_5348C(0x70, 0x70);
    }

    private void FUN_52618()
    {
        PTR_FUN_9D070[DAT_164]();
    }

    private void FUN_52654()
    {
        CriBone oVar1;

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        DAT_20C.x = oVar1.vr.x;
        DAT_20C.y = oVar1.vr.y;
    }

    private void FUN_52698()
    {
        CriBone oVar1;
        ushort uVar2;

        FUN_52538();
        FUN_52320();
        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 0);
        DAT_204.x -= oVar1.vr.x & 0xfff;
        uVar2 = (ushort)(DAT_204.y - vr.y & 0xfff);
        DAT_204.y = uVar2;
        DAT_204.y = uVar2 - vr.y & 0xfff;
        FUN_531EC();
    }

    private void FUN_52724()
    {
        CriBone oVar1;

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        DAT_204.x = oVar1.vr.x;
        DAT_204.y = oVar1.vr.y;
        FUN_531EC();
    }

    private void FUN_52778()
    {
        FUN_531EC();
    }

    private void FUN_52798()
    {
        CriBone oVar1;

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        PTR_FUN_9D09C[DAT_1F9]();
        oVar1.vr.x = DAT_20C.x & 0xfff;
        oVar1.vr.y = DAT_20C.y & 0xfff;

        if (DAT_217 != 0)
            oVar1.vr.z = 0;
    }

    private void FUN_5282C()
    {
        CriBone oVar1;

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);

        if (DAT_164 == 0)
        {
            DAT_20C.x = oVar1.vr.x;
            DAT_20C.y = oVar1.vr.y;
        }

        DAT_213 = DAT_211;
        DAT_1F9++;
    }

    private void FUN_528A0()
    {
        byte bVar1;

        bVar1 = (byte)(DAT_213 - 1);
        DAT_213 = bVar1;
        DAT_20C.x -= (byte)DAT_1FA;

        if (bVar1 == 0)
        {
            DAT_213 = DAT_211;
            DAT_1F9++;
        }
    }

    private void FUN_528E4()
    {
        byte bVar1;

        bVar1 = (byte)(DAT_213 - 1);
        DAT_213 = bVar1;
        DAT_20C.x += (byte)DAT_1FA;

        if (bVar1 == 0)
        {
            bVar1 = (byte)(DAT_210 - 1);
            DAT_210 = bVar1;

            if (bVar1 != 0)
            {
                DAT_1F9 = 1;
                DAT_213 = DAT_211;
                return;
            }

            DAT_164 = DAT_217;
            DAT_210 = DAT_212;
            DAT_1FA = (sbyte)(DAT_216 << 4);
        }
    }

    private void FUN_52964()
    {
        CriBone oVar1;

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        PTR_FUN_9D0A8[DAT_1F9]();
        oVar1.vr.x = DAT_20C.x & 0xfff;
        oVar1.vr.y = DAT_20C.y & 0xfff;

        if (DAT_217 != 0)
            oVar1.vr.z = 0;
    }

    private void FUN_529F8()
    {
        CriBone oVar1;

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);

        if (DAT_164 == 0)
        {
            DAT_20C.x = oVar1.vr.x;
            DAT_20C.y = oVar1.vr.y;
        }

        DAT_213 = DAT_211;
        DAT_1F9++;
    }

    private void FUN_52A6C()
    {
        byte bVar1;

        DAT_20C.y = DAT_20C.y - (byte)DAT_1FB & 0xfff;
        bVar1 = (byte)(DAT_213 - 1);
        DAT_213 = bVar1;

        if (bVar1 == 0)
        {
            DAT_213 = (byte)(DAT_211 << 1);
            DAT_1F9++;
        }
    }

    private void FUN_52AC0()
    {
        byte bVar1;

        DAT_20C.y = DAT_20C.y + (byte)DAT_1FB & 0xfff;
        bVar1 = (byte)(DAT_213 - 1);
        DAT_213 = bVar1;

        if (bVar1 == 0)
        {
            bVar1 = (byte)(DAT_210 - 1);
            DAT_210 = bVar1;

            if (bVar1 != 0)
            {
                DAT_1F9 = 1;
                DAT_213 = (byte)(DAT_211 << 1);
                return;
            }

            DAT_213 = DAT_211;
            DAT_1F9++;
        }
    }

    private void FUN_52B40()
    {
        byte bVar1;

        DAT_20C.y = DAT_20C.y - (byte)DAT_1FB & 0xfff;
        bVar1 = (byte)(DAT_213 - 1);
        DAT_213 = bVar1;

        if (bVar1 == 0)
        {
            DAT_164 = DAT_217;
            DAT_210 = DAT_212;
            DAT_1FB = (sbyte)(DAT_216 << 4);
        }
    }

    private void FUN_52B9C()
    {
        return;
    }

    private void FUN_52BA4()
    {
        CriBone oVar1;
        ushort uVar2;

        FUN_52320();
        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 0);
        DAT_204.x = DAT_204.x - oVar1.vr.x & 0xfff;
        uVar2 = (ushort)(DAT_204.y - oVar1.vr.y & 0xfff);
        DAT_204.y = uVar2;
        DAT_204.y = uVar2 - vr.y & 0xfff;
        FUN_531EC();
    }

    private void FUN_52C28()
    {
        PTR_FUN_9D0B8[DAT_1F8]();
    }

    private void FUN_52C64()
    {
        byte bVar1;

        bVar1 = (byte)DAT_1C4;
        FUN_52698();

        if ((bVar1 & 8) != 0 || 2U < bVar1 || (DAT_3C == 1 && DAT_3D == 6))
        {
            DAT_1FB = 0x70;
            DAT_1F8 = 1;
        }
    }

    private void FUN_52CE0()
    {
        CriBone oVar1;

        FUN_52724();

        if (DAT_218)
        {
            DAT_1FB = 0x70;
            DAT_1F8 = 2;
            oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
            oVar1.DAT_43 = false;
        }

        FUN_52D44();
    }

    private void FUN_52D44()
    {
        byte bVar1;
        byte bVar2;
        byte bVar3;
        short sVar4;
        CriBone oVar5;

        bVar1 = (byte)DAT_1C4;

        if (DAT_3C == 1 && DAT_3D != 6)
        {
            oVar5 = (CriBone)Utilities.FUN_601C8(skeleton, 7);

            if ((bVar1 & 8) == 0 && bVar1 < 3U)
            {
                DAT_20C.x = oVar5.vr.x;
                DAT_20C.y = oVar5.vr.y;
                oVar5.DAT_43 = true;
                DAT_1F8 = 0;
            }
            else
            {
                bVar2 = DAT_3D;

                if ((bVar2 == 4 || bVar2 == 1 || bVar2 == 5 || bVar2 == 2) && 
                    (GameManager.DAT_1f800008 & 0xa000) != 0)
                {
                    sVar4 = (short)oVar5.vr.x;
                    DAT_20C.x = sVar4;
                    DAT_204.x = sVar4;
                    DAT_20C.y = oVar5.vr.y;
                    oVar5.DAT_43 = true;
                    bVar3 = DAT_9D06C[DAT_1D7];
                    DAT_1F8 = 3;
                    DAT_1FB = (sbyte)bVar3;
                }
            }
        }
    }

    private void FUN_52E8C()
    {
        byte bVar1;
        short sVar2;
        CriBone oVar3;

        if (DAT_3C == 1 && DAT_3D != 6)
        {
            bVar1 = (byte)DAT_1C4;
            oVar3 = (CriBone)Utilities.FUN_601C8(skeleton, 7);

            if ((bVar1 & 8) == 0 && bVar1 < 3U)
            {
                DAT_20C.x = oVar3.vr.x;
                sVar2 = (short)oVar3.vr.y;
                DAT_1FB = 0x70;
                DAT_20C.y = sVar2;
                oVar3.DAT_43 = true;
                DAT_1F8 = 0;
            }
            else
            {
                if ((GameManager.DAT_1f800008 & 0x2000) == 0)
                {
                    if ((GameManager.DAT_1f800008 & 0x8000) == 0)
                    {
                        bVar1 = DAT_9D06C[DAT_1D7];
                        DAT_204.y = 0;
                        DAT_1F8 = 1;
                        DAT_1FB = (sbyte)((uint)bVar1 >> 1);
                        oVar3.DAT_43 = true;
                    }
                    else
                        DAT_204.y = 0xe80;
                }
                else
                    DAT_204.y = 0x180;

                DAT_204.x = oVar3.vr.x;
            }
        }
        else
        {
            DAT_1FB = 0x70;
            DAT_204.y = 0;
            DAT_1F8 = 1;
        }

        FUN_531EC();
    }

    private void FUN_52FD0()
    {
        CriBone oVar1;
        short sVar2;

        DAT_224 = DAT_210;
        FUN_52538();
        FUN_52320();
        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 0);
        DAT_204.x = DAT_204.x - oVar1.vr.x & 0xfff;
        sVar2 = (short)(DAT_204.y - oVar1.vr.y & 0xfff);
        DAT_204.y = sVar2;
        DAT_204.y = sVar2 - vr.y & 0xfff;
        FUN_531EC();
    }

    private void FUN_53064()
    {
        byte bVar1;
        byte bVar2;
        ushort uVar3;
        int iVar4;
        ushort uVar5;
        uint uVar6;
        int iVar7;

        iVar4 = GameManager.instance.FUN_64CF0();
        uVar6 = DAT_210 - 0x20U;

        if (0xc0 < uVar6)
            uVar6 = 0xc0;

        bVar1 = DAT_1F8;

        if (bVar1 == 1)
        {
            uVar6 = (uint)(DAT_204.y + (int)uVar6 & 0xfff);
            DAT_204.y = (short)uVar6;

            if (0x7ff < (short)uVar6 || (short)uVar6 <= DAT_210) goto LAB_53190;

            DAT_204.y = (short)(DAT_210 | DAT_211 << 8);
            bVar2 = (byte)(DAT_1F8 + 1);
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 != 0) goto LAB_53190;

                DAT_204.x = 0xfb0;
                DAT_204.z = 0;
                DAT_204.y = 0;
                DAT_210 = 0x20;
                bVar2 = (byte)(DAT_1F8 + 1);
            }
            else
            {
                if (bVar1 != 2) goto LAB_53190;

                uVar6 = (uint)(DAT_204.y - (int)uVar6 & 0xfff);
                DAT_204.y = (short)uVar6;

                if ((short)uVar6 < 0x801 || (iVar7 = 0x1000 - DAT_210) <= (short)uVar6)
                    goto LAB_53190;

                DAT_204.y = iVar7;
                bVar2 = (byte)(DAT_1F8 - 1);
            }
        }

        DAT_1F8 = bVar2;

    LAB_53190:
        uVar5 = (ushort)(DAT_210 | DAT_211 << 8);

        if (uVar5 < 0x200)
        {
            uVar5 = (ushort)((short)uVar5 + iVar4 * 0x20);
            DAT_210 = (byte)(uVar5 & 0xff);
            DAT_211 = (byte)((uVar5 & 0xff00) >> 8);
        }

        uVar3 = 0x20;

        if (0x20 < uVar5)
        {
            uVar3 = (ushort)(uVar5 - 3);

            if (iVar4 == 0)
                uVar3 = (ushort)(uVar5 - 20);
        }

        DAT_210 = (byte)(uVar3 & 0xff);
        DAT_211 = (byte)((uVar3 & 0xff00) >> 8);
        FUN_531EC();
    }

    private void FUN_531EC()
    {
        byte bVar1;
        ushort uVar2;
        short sVar3;
        short sVar4;
        uint uVar5;
        int iVar6;
        uint uVar7;
        uint uVar8;
        int iVar9;
        CriBone oVar9;

        if (DAT_1D7 == 0)
        {
            uVar8 = 0x180;

            if (DAT_3C != 1 || DAT_3D != 5)
            {
                iVar9 = 0x100;
                uVar7 = 0x300;
            }
            else
            {
                uVar8 = 0x80;
                iVar9 = 0x55;
                uVar7 = 0x100;
            }
        }
        else
        {
            uVar8 = 0x80;
            iVar9 = 0x55;
            uVar7 = 0x100;
        }

        uVar5 = (uint)(DAT_204.y + 0x400 & 0xfff);

        if (uVar5 < 0xc01)
        {
            if (uVar5 < 0x801)
                sVar3 = Utilities.FUN_51D40(DAT_204.y, DAT_20C.y, (byte)DAT_1FB);
            else
                sVar3 = (short)((byte)DAT_1FB * 3U >> 1);
        }
        else
        {
            iVar6 = (byte)DAT_1FB * -3;
            sVar3 = (short)((uint)(iVar6 - (int)((uint)iVar6 >> 0x1f)) >> 1);
        }

        sVar4 = Utilities.FUN_51D40(DAT_204.x, DAT_20C.x, (byte)DAT_1FA);
        DAT_20C.x = DAT_20C.x + sVar4 & 0xfff;
        DAT_20C.y = DAT_20C.y + sVar3 & 0xfff;
        bVar1 = DAT_164;

        if (bVar1 == 1 || bVar1 == 7 || bVar1 == 8 || bVar1 == 9)
        {
            uVar5 = (ushort)DAT_20C.y;

            if (uVar5 < 0x801)
            {
                if (uVar7 < uVar5)
                    DAT_20C.y = (short)uVar7;
            }
            else
            {
                if ((int)uVar5 < (int)(0x1000 - uVar7))
                    DAT_20C.y = (short)(0x1000 - uVar7);
            }

            uVar7 = (ushort)DAT_20C.x;

            if (uVar7 < 0x801)
            {
                if (uVar8 < uVar7)
                    DAT_20C.x = (short)uVar8;
            }
            else
            {
                if ((int)uVar7 < 0x1000 - iVar9)
                    DAT_20C.x = (short)(0x1000 - iVar9);
            }
        }

        iVar9 = DAT_20C.x - DAT_204.x;

        if (iVar9 < 0)
            iVar9 = -iVar9;

        iVar6 = DAT_20C.y - DAT_204.y;

        if (iVar6 < 0)
            iVar6 = -iVar6;

        DAT_218 = iVar9 + iVar6 < 10;
        oVar9 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        oVar9.vr.x = DAT_20C.x & 0xfff;
        uVar2 = (ushort)DAT_20C.y;
        oVar9.vr.z = 0;
        oVar9.vr.y = uVar2 & 0xfff;
    }

    public void FUN_5348C(sbyte param1, sbyte param2)
    {
        CriBone oVar1;

        DAT_164 = 8;

        if (param1 == -1)
        {
            FUN_52538();
            FUN_52320();
            DAT_20C.x = DAT_204.x;
            DAT_20C.y = DAT_204.y;
        }
        else
        {
            DAT_1FA = param1;

            if (param2 == -1)
                DAT_1FB = 0;
            else
                DAT_1FB = param2;
        }

        oVar1 = Utilities.FUN_601C8(skeleton, 7) as CriBone;
        oVar1.DAT_43 = true;
    }

    public void FUN_53520(byte param1, sbyte param2, sbyte param3)
    {
        CriBone oVar1;

        DAT_210 = param1;
        DAT_164 = 9;

        if (param2 == -1)
        {
            FUN_66208();
            SceneManager.instance.DAT_27C[param1].FUN_66208();
            FUN_52FD0();
            DAT_218 = true;
            DAT_20C.x = DAT_204.x;
            DAT_20C.y = DAT_204.z;
        }
        else
        {
            DAT_1FA = param2;
            DAT_1FB = param3;
        }

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        oVar1.DAT_43 = true;
    }

    public void FUN_535E4(sbyte param1, sbyte param2)
    {
        CriBone oVar1;

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        DAT_164 = 0;

        if (param1 == -1)
        {
            DAT_20C.x = oVar1.vr.x;
            DAT_20C.y = oVar1.vr.y;
        }
        else
        {
            DAT_1FA = param1;
            DAT_1FB = param2;
        }

        oVar1.DAT_43 = false;
    }

    public void FUN_53674(sbyte param1, sbyte param2)
    {
        CriBone oVar1;

        DAT_204.x = 0;
        DAT_204.y = 0;

        if (param1 == -1)
        {
            DAT_20C.x = 0;
            DAT_20C.y = 0;
        }
        else
        {
            DAT_1FA = param1;
            DAT_1FB = param2;
        }

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        oVar1.DAT_43 = true;
        DAT_164 = 3;
    }

    public void FUN_536DC(uint param1, uint param2, byte param3)
    {
        byte bVar1;
        byte bVar2;

        if (DAT_164 != 4)
        {
            if ((param2 & 0xffff) == 0)
                return; //trap(0x1c00)

            bVar1 = DAT_210;
            bVar2 = (byte)DAT_1FA;
            DAT_210 = param3;
            DAT_1FA = (sbyte)param2;
            DAT_212 = bVar1;
            DAT_216 = (byte)((uint)bVar2 >> 4);
            DAT_211 = (byte)((param1 & 0xffff) / (param2 & 0xffff));
            DAT_217 = DAT_164;
            DAT_164 = 4;
            DAT_1F9 = 0;
        }
    }

    public void FUN_53748(uint param1, uint param2, byte param3)
    {
        byte bVar1;
        byte bVar2;

        if (DAT_164 != 5)
        {
            if ((param2 & 0xffff) == 0)
                return; //trap(0x1c00)

            bVar1 = DAT_210;
            bVar2 = (byte)DAT_1FB;
            DAT_210 = param3;
            DAT_1FB = (sbyte)param2;
            DAT_212 = bVar1;
            DAT_216 = (byte)((uint)bVar2 >> 4);
            DAT_211 = (byte)((param1 & 0xffff) / (param2 & 0xffff));
            DAT_217 = DAT_164;
            DAT_164 = 5;
            DAT_1F9 = 0;
        }
    }

    public void FUN_537B4(Vector3Int param1, sbyte param2, sbyte param3)
    {
        CriBone oVar1;
        DAT_1FC = param1;

        if (param2 == -1)
        {
            FUN_66208();
            FUN_52BA4();
            DAT_20C.x = DAT_204.x;
            DAT_20C.y = DAT_204.z;
        }
        else
        {
            DAT_1FA = param2;
            DAT_1FB = param3;
        }

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        oVar1.DAT_43 = true;
        DAT_164 = 7;
    }

    public void FUN_53854(short param1, short param2, sbyte param3, sbyte param4)
    {
        CriBone oVar1;

        DAT_204.x = param1;
        DAT_204.y = param2;

        if (param3 == -1)
        {
            DAT_20C.x = DAT_204.x;
            DAT_20C.y = DAT_204.z;
        }
        else
        {
            DAT_1FA = param3;
            DAT_1FB = param4;
        }

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        oVar1.DAT_43 = true;
        DAT_164 = 3;
    }

    public void FUN_538CC()
    {
        DAT_1F8 = 0;
        DAT_164 = 10;
    }

    public void FUN_538DC(sbyte param1, sbyte param2)
    {
        CriBone oVar1;

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);

        if (param1 == -1)
        {
            DAT_20C.x = oVar1.vr.x;
            DAT_20C.y = oVar1.vr.y;
        }
        else
        {
            DAT_1FA = param1;
            DAT_1FB = param2;
        }

        DAT_1F8 = 0;
        DAT_164 = 2;
    }

    private void FUN_52538()
    {
        CriSkinned oVar1;
        CriBone oVar2;

        oVar1 = SceneManager.instance.DAT_27C[DAT_224];

        if (oVar1 != null)
        {
            oVar2 = Utilities.FUN_601C8(oVar1.skeleton, oVar1.DAT_175 & 0xf) as CriBone;

            if (oVar2 != null)
                DAT_1FC = oVar2.screen;
        }
    }

    public void FUN_5397C(byte param1)
    {
        DAT_1C5 = param1;
    }

    public void FUN_53984(uint param1, byte param2, byte param3)
    {
        FUN_4CFDC();
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_220 + param1 * 4), param2, param3, DAT_220 + param1 * 4);
    }

    public void FUN_539F8(int param1, ushort param2, int param3)
    {
        uint uVar1;

        if (0 < health)
        {
            uVar1 = (uint)(param3 * 0x1000000 + 0x902 + param1 * 0x10000);
            DAT_3C = (byte)uVar1;
            DAT_3D = (byte)(uVar1 >> 8);
            DAT_3E = (byte)(uVar1 >> 0x10);
            DAT_3F = (byte)(uVar1 >> 0x18);
            DAT_1F4 = (byte)param2;
            DAT_1F5 = (byte)(param2 >> 8);
            return;
        }

        DAT_3C = 3;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 0;
    }

    public void FUN_53A2C(uint param1, uint param2)
    {
        uint uVar1;

        DAT_1C0 &= 0xfffffff7;
        uVar1 = param1;

        if ((param1 & 0xf0) != 0)
        {
            if ((param1 & 0xe0) == 0x20)
                uVar1 = 0;

            if ((param1 & 0xe0) == 0x40)
                uVar1 = 1;

            if ((param1 & 0x10) != 0)
                uVar1 += 2;
        }

        if (0 < health)
        {
            if ((param1 & 0xe0) == 0x60)
            {
                uVar1 = ((param1 & 0xf0) >> 4 & 1) * 0x10000 + 0x202;
                DAT_3C = (byte)uVar1;
                DAT_3D = (byte)(uVar1 >> 8);
                DAT_3E = (byte)(uVar1 >> 0x10);
                DAT_3F = (byte)(uVar1 >> 0x18);
                return;
            }

            uVar1 = ((uVar1 & 0xff) << 4 | param2 & 0xff) * 0x10000 + 2;
            DAT_3C = (byte)uVar1;
            DAT_3D = (byte)(uVar1 >> 8);
            DAT_3E = (byte)(uVar1 >> 0x10);
            DAT_3F = (byte)(uVar1 >> 0x18);
            return;
        }

        DAT_3C = 3;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 0;
    }

    private void FUN_53B30()
    {
        PTR_FUN_9D0C8[DAT_3D]();
    }

    private void FUN_53B6C()
    {
        FUN_60AB4();
    }

    private void FUN_53B8C()
    {
        PTR_FUN_9D10C[DAT_3E]();
    }

    private void FUN_53BC8()
    {
        DAT_1D0 = 0xffffffff;
        DAT_18C = 1;
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 8), 1, 5, DAT_21C + 8);

        if (PTR_190[DAT_190].y == 0)
            DAT_1F4 = 90;
        else
            DAT_1F4 = (byte)PTR_190[DAT_190].y;

        DAT_3E++;
    }

    private void FUN_53C60()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51C8C(screen, PTR_190[DAT_190], vr.y, DAT_1F4);

        if (sVar1 == 0)
        {
            DAT_40.z = 54;
            DAT_3E++;
        }
        else
            vr.y += sVar1;

        FUN_60AB4();
    }

    private void FUN_53CD8()
    {
        byte bVar1;
        short sVar2;
        uint uVar3;

        sVar2 = Utilities.FUN_51C8C(screen, PTR_190[DAT_190], vr.y, 0x20);
        vr.y += sVar2;
        uVar3 = Utilities.FUN_63160(screen, PTR_190[DAT_190]);

        if (uVar3 < 250000 && DAT_1D0 < uVar3)
        {
            bVar1 = (byte)(DAT_18F - 1);
            DAT_18F = bVar1;

            if (bVar1 == 0)
            {
                DAT_40 = new Vector3Int(0, 0, 0);
                screen = PTR_190[DAT_190];
                InventoryManager.FUN_4A7E8(3, DAT_176, true);
                DAT_3E++;
            }
            else
            {
                uVar3 = 0xffffffff;
                DAT_190++;
            }
        }

        DAT_1D0 = uVar3;
        FUN_60AB4();
    }

    private void FUN_543A8()
    {
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 4), 0, 8, DAT_21C + 4);

        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3D = 0;
    }

    private void FUN_54148()
    {
        PTR_FUN_9D138[DAT_3E]();
    }

    private void FUN_54184()
    {
        DAT_1D0 = 0xffffffff;
        DAT_1C0 &= 0xfffffffe;
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 8), 1, 5, DAT_21C + 8);

        DAT_3E++;
    }

    private void FUN_541F0()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51C8C(screen, PTR_190[DAT_190], vr.y, 90);

        if (sVar1 == 0)
        {
            FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x14), 1, 5, DAT_21C + 5);

            DAT_40.z = 130;
            DAT_3E++;
        }
        else
            vr.y += sVar1;

        FUN_60AB4();
    }

    private void FUN_5428C()
    {
        byte bVar1;
        short sVar2;
        uint uVar3;

        sVar2 = Utilities.FUN_51C8C(screen, PTR_190[DAT_190], vr.y, 90);
        vr.y += sVar2;
        uVar3 = Utilities.FUN_63160(screen, PTR_190[DAT_190]);

        if (uVar3 < 490000 && DAT_1D0 < uVar3)
        {
            bVar1 = (byte)(DAT_18F - 1);
            DAT_18F = bVar1;

            if (bVar1 == 0)
            {
                DAT_40 = new Vector3Int(0, 0, 0);
                screen = PTR_190[DAT_190];
                InventoryManager.FUN_4A7E8(3, DAT_176, true);
                DAT_3E++;
            }
            else
            {
                uVar3 = 0xffffffff;
                DAT_190++;
            }
        }

        DAT_1D0 = uVar3;
        FUN_60AB4();
    }

    private void FUN_53DF4()
    {
        PTR_FUN_9D11C[DAT_3E]();
    }

    private void FUN_53E30()
    {
        DAT_1D0 = 0xffffffff;
        DAT_1C0 &= 0xfffffffe;
        DAT_40.y = 0;
        DAT_40.x = 0;
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x10), 1, 5, DAT_21C + 0x10);
        DAT_3E++;
    }

    private void FUN_53E98()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51C8C(PTR_190[DAT_190], screen, vr.y, 90);

        if (sVar1 == 0)
        {
            DAT_40.z = -30;
            DAT_3E++;
        }
        else
            vr.y += sVar1;

        FUN_60AB4();
    }

    private void FUN_53F0C()
    {
        byte bVar1;
        short sVar2;
        uint uVar3;

        sVar2 = Utilities.FUN_51C8C(PTR_190[DAT_190], screen, vr.y, 0x20);
        vr.y += sVar2;
        uVar3 = Utilities.FUN_63160(screen, PTR_190[DAT_190]);

        if (uVar3 < 250000 && DAT_1D0 < uVar3)
        {
            bVar1 = (byte)(DAT_18F - 1);
            DAT_18F = bVar1;

            if (bVar1 == 0)
            {
                DAT_40 = new Vector3Int(0, 0, 0);
                screen = PTR_190[DAT_190];
                InventoryManager.FUN_4A7E8(3, DAT_176, true);
                DAT_3E++;
            }
            else
            {
                uVar3 = 0xffffffff;
                DAT_190++;
            }
        }

        DAT_1D0 = uVar3;
        FUN_60AB4();
    }

    private void FUN_5401C()
    {
        PTR_FUN_9D12C[DAT_3E]();
    }

    private void FUN_54058()
    {
        TodScriptableObject oVar1;

        oVar1 = (TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 8);
        DAT_1C0 &= 0xfffffffe;
        FUN_609C8(oVar1, 1, 5, DAT_21C + 8);
        PTR_190[DAT_190].y = vr.y + PTR_190[DAT_190].y & 0xfff;
        DAT_3E++;
    }

    private void FUN_540CC()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51D40(PTR_190[DAT_190].y, vr.y, 90);

        if (sVar1 == 0)
        {
            InventoryManager.FUN_4A7E8(3, DAT_176, true);
            DAT_3E++;
        }
        else
            vr.y += sVar1;

        FUN_60AB4();
    }

    private void FUN_543F0()
    {
        PTR_FUN_9D148[DAT_3E]();
    }

    private void FUN_5442C()
    {
        DAT_1C0 &= 0xfffffffe;
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 8), 1, 5, DAT_21C + 8);

        if (PTR_190[DAT_190].y == 0)
            DAT_1F4 = 90;
        else
            DAT_1F4 = (byte)PTR_190[DAT_190].y;

        DAT_3E++;
    }

    private void FUN_544C4()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51C8C(screen, PTR_190[DAT_190], vr.y, DAT_1F4);

        if (sVar1 == 0)
        {
            InventoryManager.FUN_4A7E8(3, DAT_176, true);
            DAT_3E++;
        }
        else
            vr.y += sVar1;

        FUN_60AB4();
    }

    private void FUN_54540()
    {
        PTR_FUN_9D154[DAT_3E]();
    }

    private void FUN_5457C()
    {
        DAT_1D0 = 0xffffffff;
        DAT_1C0 &= 0xfffffffe;
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x18), 1, 10, DAT_21C + 0x18);
        DAT_3E++;
    }

    private void FUN_545E8()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51C8C(screen, PTR_190[DAT_190], vr.y, 90);

        if (sVar1 == 0)
        {
            DAT_40.z = 43;
            DAT_3E++;
        }
        else
            vr.y += sVar1;

        FUN_60AB4();
    }

    private void FUN_54660()
    {
        PTR_FUN_9D164[DAT_3E]();
    }

    private void FUN_5469C()
    {
        FUN_53BC8();
        DAT_40.z = 54;
    }

    private void FUN_546D0()
    {
        PTR_FUN_9D170[DAT_3E]();
    }

    private void FUN_5470C()
    {
        DAT_1D0 = 0xffffffff;
        DAT_1C0 &= 0xfffffffe;
        DAT_40.y = 0;
        DAT_40.x = 0;
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x14), 1, 5, DAT_21C + 0x14);
        DAT_40.z = 130;
        DAT_3E++;
    }

    private void FUN_54780()
    {
        PTR_FUN_9D17C[DAT_3E]();
    }

    private void FUN_547BC()
    {
        FUN_5457C();
        DAT_40.z = 43;
    }

    private void FUN_547F0()
    {
        PTR_FUN_9D188[DAT_3E]();
    }

    private void FUN_5482C()
    {
        DAT_1C0 &= 0xfffffffe;
        DAT_1F4 = (byte)(vr.y + 0x800 & 0xfff);
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 8), 1, 2, DAT_21C + 8);
        DAT_3E++;
    }

    private void FUN_54894()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51D40((short)(DAT_1F4 | DAT_1F5 << 8), vr.y, 200);

        if (sVar1 == 0)
        {
            InventoryManager.FUN_4A7E8(3, DAT_176, true);
            DAT_3E++;
        }
        else
            vr.y += sVar1;

        FUN_60AB4();
    }

    private void FUN_5490C()
    {
        PTR_FUN_9D194[DAT_3E]();
    }

    private void FUN_54948()
    {
        DAT_1D0 = 0xffffffff;
        DAT_1C0 &= 0xfffffffe;
        DAT_3E++;
    }

    private void FUN_54970()
    {
        PTR_FUN_9D1A0[DAT_3E]();
    }

    private void FUN_549AC()
    {
        DAT_1D0 = 0xffffffff;
        DAT_40.z = -30;
        DAT_1C0 &= 0xfffffffe;
        DAT_40.y = 0;
        DAT_40.x = 0;
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x1c), 1, 5, DAT_21C + 0x1c);
        DAT_3E++;
    }

    private void FUN_54A1C()
    {
        byte bVar1;
        short sVar2;
        uint uVar3;

        sVar2 = Utilities.FUN_51C8C(PTR_190[DAT_190], screen, vr.y, 0x20);
        vr.y += sVar2;
        uVar3 = Utilities.FUN_63160(screen, PTR_190[DAT_190]);

        if (uVar3 < 250000 && DAT_1D0 < uVar3)
        {
            bVar1 = (byte)(DAT_18F - 1);
            DAT_18F = bVar1;

            if (bVar1 == 0)
            {
                DAT_40 = new Vector3Int(0, 0, 0);
                screen = PTR_190[DAT_190];
                InventoryManager.FUN_4A7E8(3, DAT_176, true);
                DAT_3E++;
            }
            else
            {
                uVar3 = 0xffffffff;
                DAT_190++;
            }
        }

        DAT_1D0 = uVar3;
        FUN_60AB4();
    }

    private void FUN_54B2C()
    {
        PTR_FUN_9D1AC[DAT_3E]();
    }

    private void FUN_54B68()
    {
        DAT_40.z = 0;
        DAT_226 = (sbyte)PTR_190[DAT_190].y;
        DAT_1F4 = (byte)((uint)(ushort)PTR_190[DAT_190].y >> 8);
        PTR_190[DAT_190].y = 0;
        DAT_1FB = -96;
        FUN_50FE4((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x58), 
            (TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x5c), 
            (TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x60), 0, 4);
        DAT_3E++;
    }

    private void FUN_54C00()
    {
        bool bVar1;
        short sVar2;

        sVar2 = Utilities.FUN_51C8C(screen, PTR_190[DAT_190], vr.y, DAT_1F4);

        if (sVar2 != 0)
            vr.y += sVar2;

        bVar1 = FUN_51178();

        if (bVar1 && sVar2 == 0)
        {
            FUN_50FE4((TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x64), 
                (TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x68), 
                (TodScriptableObject)Utilities.GetSharedObject(DAT_21C + 0x6c), 0, 4);
            InventoryManager.FUN_4A7E8(3, DAT_176, true);
            DAT_3E++;
        }
    }

    private void FUN_54CCC()
    {
        return;
    }

    private void FUN_54CD4()
    {
        PTR_FUN_9D1B8[DAT_3E]();
    }

    private void FUN_54D10()
    {
        DAT_1D0 = 0xffffffff;
        DAT_18C = 1;
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_220 + 4), 1, 5, DAT_220 + 4);

        if (PTR_190[DAT_190].y == 0)
            DAT_1F4 = 90;
        else
            DAT_1F4 = (byte)PTR_190[DAT_190].y;

        DAT_3E++;
    }

    private void FUN_54DA8()
    {
        short sVar1;
        short sVar2;

        sVar2 = Utilities.FUN_51C8C(screen, PTR_190[DAT_190], vr.y, DAT_1F4);

        if (sVar2 == 0)
        {
            sVar1 = Utilities.DAT_18790[DAT_1D7];
            DAT_3E++;
            DAT_40.z = sVar1;
        }
        else
            vr.y += sVar2;

        FUN_60AB4();
    }

    private void FUN_54E38()
    {
        FUN_609C8((TodScriptableObject)Utilities.GetSharedObject(DAT_220), 0, 8, DAT_220);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3D = 0;
    }

    public void FUN_54EF8()
    {
        byte bVar1;
        byte bVar2;
        CriBone oVar4;
        uint uVar5;
        CriBone oVar6;

        if ((InventoryManager.DAT_B7A60[0] & 0x400) == 0)
        {
            DAT_34 = screen;
            FUN_5211C(DAT_1CF);
        }

        vr.y &= 0xfff;
        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 0x400) == 0)
        {
            oVar4 = (CriBone)Utilities.FUN_601C8(skeleton, 11);
            oVar6 = skeleton;
            DAT_184[0] = oVar4;
            oVar4 = (CriBone)Utilities.FUN_601C8(oVar6, 14);
            DAT_184[1] = oVar4;
            FUN_659D0();
            PTR_FUN_9D1F4[DAT_3C]();
            bVar1 = frames[frameNum].DAT_03;

            if ((bVar1 & 3) != 0)
            {
                bVar2 = DAT_18E;
                uVar5 = 0xbc;

                if (bVar2 != 0)
                {
                    uVar5 = 0xc2;

                    if (bVar2 == 1)
                        uVar5 = 0xb6;
                }

                GameManager.instance.FUN_5D0C4(this, (byte)(uVar5 | DAT_1C0 >> 1 & 1), (byte)(bVar1 & 3));
                DAT_1C0 ^= 2;
            }

            FUN_62F3C(ref DAT_40);
            SceneManager.instance.FUN_80030(this, false, 1);
            FUN_65A28();
            FUN_52618();
        }
    }

    private void FUN_55078()
    {
        REFS = DAT_9D1D4;
        DAT_21C = 0;
        DAT_220 = 4;
        PTR_120 = DAT_9D1C8;
        DAT_120 = 0;
        DAT_12E = 1;
        health = 1000;
        maxHealth = 1000;
        DAT_1D7 = 0;
        DAT_3F = 0;
        DAT_3E = 0;
        DAT_3D = 0;
        DAT_175 = 0x87;
        FUN_5342C();
        FUN_535E4(-0x80, -0x80);
        FUN_65984(11, 14);
        FUN_609C8(REFS[DAT_220 / 4], 0, 0);
        FUN_66404(8, 0x1000, 0x1000);
        DAT_3C++;
    }

    private void FUN_55150()
    {
        FUN_60AB4();
    }

    private void FUN_55170()
    {
        //...
    }

    private void FUN_2E07C()
    {
        CriPlayer oVar1;
        uint uVar2;
        int iVar3;

        if (DAT_1C5 == 0)
            return;

        oVar1 = (CriPlayer)SceneManager.instance.FUN_65B30(this);

        if (oVar1 == null)
            return;

        if ((oVar1.DAT_208 & 0x2000000) == 0)
            return;

        if (UDAT_20C < 5000)
            uVar2 = oVar1.UDAT_20C;
        else
            uVar2 = oVar1.UDAT_20C;

        if (uVar2 < 5000)
        {
            iVar3 = (int)GameManager.FUN_64650();

            if (iVar3 == (iVar3 / 3) * 3)
            {
                if (oVar1.UDAT_20C <= UDAT_20C)
                {
                    oVar1.DAT_1C5 = 0;
                    DAT_1C5 = 1;
                    return;
                }
            }
            else
            {
                if (UDAT_20C <= oVar1.UDAT_20C)
                {
                    oVar1.DAT_1C5 = 0;
                    DAT_1C5 = 1;
                    return;
                }
            }

            oVar1.DAT_1C5 = 1;
        }
        else
        {
            if (oVar1.DAT_1C5 != 0)
                return;

            oVar1.DAT_1C5 = 1;
        }

        DAT_1C5 = 0;
    }

    private void FUN_2E1B4()
    {
        CriPlayer oVar1;

        oVar1 = SceneManager.instance.FUN_65B30(this) as CriPlayer;

        if (oVar1 != null && (oVar1.DAT_208 & 0x2000000) != 0)
        {
            if (oVar1.UDAT_20C < UDAT_20C)
            {
                oVar1.DAT_1C5 = 1;
                DAT_1C5 = 0;
                return;
            }

            oVar1.DAT_1C5 = 0;
        }

        DAT_1C5 = 1;
    }

    private bool FUN_2E284()
    {
        short sVar1;
        CriPlayer oVar2;

        if (DAT_1C5 != 0 && (oVar2 = (CriPlayer)SceneManager.instance.FUN_65B30(this)) != null && 
            (oVar2.DAT_208 & 0x2000000) != 0)
        {
            sVar1 = FUN_64804(oVar2.screen);

            if (oVar2.UDAT_20C < 4500)
            {
                if (0xc00U < (ushort)(sVar1 - 0x200))
                {
                    DAT_1C5 = 0;
                    oVar2.DAT_1C5 = 1;
                    return true;
                }

                return false;
            }
        }

        return false;
    }

    private void FUN_2E328()
    {
        PTR_FUN_9B050[DAT_164]();
    }

    private void FUN_2E364()
    {
        CriBone oVar1;

        Utilities.FUN_64930(vr.y, this, DAT_167, 0xd00, 0x300);

        if (DAT_19E != 0)
        {
            oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 3);
            oVar1.vr.y = (short)DAT_19E;
        }
    }

    private void FUN_2E3C8()
    {
        byte bVar1;
        short sVar2;
        CriBone oVar3;
        uint uVar4;
        ushort uVar5;
        byte bVar6;
        ushort[] local_20;

        bVar6 = 1;
        sVar2 = (short)Utilities.FUN_615EC(screen, SceneManager.instance.DAT_27C[10].screen);
        local_20 = new ushort[4];
        local_20[0] = 0;

        do
        {
            oVar3 = (CriBone)Utilities.FUN_601C8(skeleton, bVar6);
            uVar5 = (ushort)oVar3.vr.y;
            local_20[bVar6] = uVar5;
            bVar6++;
            local_20[0] = (ushort)(local_20[0] + uVar5 & 0xfff);
        } while (bVar6 < 3U);

        uVar5 = (ushort)(sVar2 - (DAT_19E + vr.y) & 0xfff);

        if (0x7ff < uVar5)
            uVar5 = (ushort)(0x1000 - uVar5);

        bVar1 = DAT_166;

        if (bVar1 != 0)
        {
            DAT_166 = (byte)(bVar1 - 1);

            if (bVar1 == 1)
                DAT_166 = 0;
        }

        if ((short)uVar5 < 90 || DAT_166 != 0)
            uVar4 = DAT_167;
        else
            uVar4 = DAT_167 * 5U;

        Utilities.FUN_64930(sVar2, this, uVar4, 0xd00, 0x300);
        bVar6 = 1;
        local_20[0] = DAT_19E;

        do
        {
            uVar4 = bVar6;
            bVar6++;
            local_20[0] = (ushort)(local_20[0] - local_20[uVar4] & 0xfff);
        } while (bVar6 < 3U);

        if (DAT_19E != 0)
        {
            oVar3 = (CriBone)Utilities.FUN_601C8(skeleton, 3);
            oVar3.vr.y = (short)local_20[0];
        }
    }

    private void FUN_2E580()
    {
        short sVar1;
        CriBone oVar2;

        sVar1 = (short)Utilities.FUN_615EC(screen, DAT_168);
        Utilities.FUN_64930(sVar1, this, DAT_167, 0xd00, 0x300);

        if (DAT_19E != 0)
        {
            oVar2 = (CriBone)Utilities.FUN_601C8(skeleton, 3);
            oVar2.vr.y = (short)DAT_19E;
        }
    }

    private void FUN_2E5F4()
    {
        CriBone oVar1;

        Utilities.FUN_64930(DAT_168.y, this, DAT_167, 0xd00, 0x300);

        if (DAT_19E != 0)
        {
            oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 3);
            oVar1.vr.y = (short)DAT_19E;
        }
    }

    private void FUN_2E658()
    {
        DAT_1C9 = 0;
        DAT_1EA = (short)DAT_19E;
        DAT_165++;
    }

    private void FUN_2E674()
    {
        uint uVar1;

        uVar1 = (uint)(DAT_19E + 30 & 0xfff);
        DAT_19E = (ushort)uVar1;

        if (uVar1 - 0x301 < 0x4ff)
        {
            DAT_19E = 0x300;
            DAT_1C9 = 0;
            DAT_165++;
        }
    }

    private void FUN_2E6B4()
    {
        byte bVar1;

        bVar1 = (byte)(DAT_1C9 + 1);
        DAT_1C9 = bVar1;

        if (4 < bVar1)
        {
            DAT_1C9 = 0;
            DAT_165++;
        }
    }

    private void FUN_2E6EC()
    {
        uint uVar1;

        uVar1 = (uint)(DAT_19E - 30 & 0xfff);
        DAT_19E = (ushort)uVar1;

        if (uVar1 - 0x801 < 0x4ff)
        {
            DAT_19E = 0xd00;
            DAT_1C9 = 0;
            DAT_165++;
        }
    }

    private void FUN_2E72C()
    {
        ushort uVar1;

        uVar1 = (ushort)(DAT_19E + 30 & 0xfff);
        DAT_19E = uVar1;

        if (uVar1 < 0x800)
            DAT_165 = 1;
    }

    private void FUN_2E758()
    {
        CriBone oVar1;

        PTR_FUN_9B06C[DAT_165]();
        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 3);
        oVar1.vr.y = (short)DAT_19E;
    }

    private void FUN_2E7B4()
    {
        if (DAT_19E != 0)
            DAT_19E = 0;
    }

    private void FUN_2E9CC()
    {
        if ((DAT_208 & 0x20) != 0)
        {
            //FUN_65D1C
            DAT_208 &= 0xffffffdf;
        }
    }

    private void FUN_2EA6C()
    {
        short sVar1;
        CriParticle oVar2;
        int iVar2;
        CriBone oVar3;
        int iVar3;
        int iVar4;
        ushort uVar5;
        uint uVar6;

        if (DAT_1D6 != 0)
        {
            iVar2 = (int)GameManager.FUN_64650();
            iVar3 = (int)GameManager.FUN_64650();
            uVar6 = (uint)(iVar2 % 20 + 10 & 0xff);

            if (uVar6 == 0)
                return; //trap(0x1c00)

            if (uVar6 == 0xffffffff && iVar3 == -0x80000000)
                return; //trap(0x1800)

            if ((iVar3 % (int)uVar6 & 0xff) == 1)
            {
                oVar2 = SceneManager.instance.FUN_5FFA0();

                if (oVar2 != null)
                {
                    oVar3 = (CriBone)Utilities.FUN_601C8(skeleton, 0);
                    oVar2.tags = 2;
                    iVar4 = (int)GameManager.FUN_64650();
                    sVar1 = (short)(iVar4 + (iVar4 / 5) * -5);
                    iVar4 = (int)GameManager.FUN_64650();
                    uVar5 = (ushort)(sVar1 + 8);

                    if (iVar4 % 3 == 1)
                        uVar5 = (ushort)(sVar1 + 10);

                    oVar2.DAT_62 = (ushort)(uVar5 & 0xff);
                    oVar2.DAT_60 = (ushort)(uVar5 & 0xff);
                    uVar5 = (ushort)GameManager.FUN_64650();
                    oVar2.screen.x = oVar3.screen.x - ((uVar5 & 0xff) - 0x80);
                    uVar5 = (ushort)GameManager.FUN_64650();
                    oVar2.screen.z = oVar3.screen.z - ((uVar5 & 0xff) - 0x80);
                }
            }
        }
    }

    private void FUN_2F258()
    {
        CriCamera oVar1;
        Vector3Int local_50;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        local_50 = new Vector3Int(-2000, 0, -500);
        local_48 = new Vector3Int(0, 0, 0);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_48, ref MStack48);
        local_50 = Utilities.ApplyMatrixSV(ref MStack48, ref local_50);
        local_40 = new Vector3Int(screen.x + local_50.x, screen.y - 4000, screen.z + local_50.z);
        local_50 = new Vector3Int(0, 0, -500);
        local_50 = Utilities.ApplyMatrixSV(ref MStack48, ref local_50);
        local_38 = new Vector3Int(screen.x + local_50.x, screen.y - 1500, screen.z + local_50.z);
        oVar1 = SceneManager.instance.cCamera;
        oVar1.DAT_8B = 0;
        oVar1.DAT_8A = 0;
        oVar1.DAT_92 = 0;
        oVar1.DAT_52 = 0;
        oVar1.DAT_50 = 0;
        oVar1.DAT_3E = 0;
        oVar1.DAT_36 = 0;
        oVar1.DAT_90 = 0;
        oVar1.DAT_56 = 0;
        oVar1.DAT_54 = 0;
        oVar1.SDAT_2E = 0;
        oVar1.DAT_26 = 0;
        SceneManager.instance.FUN_264C4(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        SceneManager.instance.FUN_26504(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
    }

    private void FUN_2F3A4()
    {
        CriCamera oVar1;
        Vector3Int local_50;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        local_50 = new Vector3Int(-1500, 0, 1500);
        local_48 = new Vector3Int(0, 0, 0);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_48, ref MStack48);
        local_50 = Utilities.ApplyMatrixSV(ref MStack48, ref local_50);
        local_40 = new Vector3Int(screen.x + local_50.x, screen.y - 100, screen.z + local_50.z);
        local_38 = new Vector3Int(screen.x, screen.y - 500, screen.z);
        oVar1 = SceneManager.instance.cCamera;
        oVar1.DAT_8B = 0;
        oVar1.DAT_8A = 0;
        oVar1.DAT_92 = 0;
        oVar1.DAT_52 = 0;
        oVar1.DAT_50 = 0;
        oVar1.DAT_3E = 0;
        oVar1.DAT_36 = 0;
        oVar1.DAT_90 = 0;
        oVar1.DAT_56 = 0;
        oVar1.DAT_54 = 0;
        oVar1.SDAT_2E = 0;
        oVar1.DAT_26 = 0;
        SceneManager.instance.FUN_264C4(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        SceneManager.instance.FUN_26504(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
    }

    private void FUN_2F4C8()
    {
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        local_40 = new Vector3Int(-4000, 0, -500);
        local_38 = new Vector3Int(0, 0, 0);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref MStack48);
        local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        local_40 = new Vector3Int(screen.x + local_40.x, screen.y - 6000, screen.z + local_40.z);
        SceneManager.instance.cCamera.DAT_8A = 2;
        SceneManager.instance.cCamera.DAT_26 = 40;
        SceneManager.instance.FUN_26504(1, (short)local_40.x, (short)local_40.y, (short)local_40.z);
    }

    private void FUN_2F590()
    {
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        local_40 = new Vector3Int(-4000, 0, 8000);
        local_38 = new Vector3Int(0, 0, 0);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref MStack48);
        local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        local_40 = new Vector3Int(screen.x + local_40.x, screen.y - 100, screen.z + local_40.z);
        SceneManager.instance.cCamera.DAT_8A = 2;
        SceneManager.instance.cCamera.DAT_26 = 40;
        SceneManager.instance.FUN_26504(1, (short)local_40.x, (short)local_40.y, (short)local_40.z);
    }

    private void FUN_2F658()
    {
        CriCamera oVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        local_40 = new Vector3Int(-1000, 0, 2500);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref vr, ref MStack48);
        local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        local_38 = new Vector3Int(screen.x + local_40.x, screen.y - 1200, screen.z + local_40.z);
        SceneManager.instance.FUN_26504(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        local_40 = new Vector3Int(-2500, 0, 6000);
        local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        local_38 = new Vector3Int(screen.x + local_40.x, screen.y, screen.z + local_40.z);
        SceneManager.instance.FUN_26504(1, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        oVar1 = SceneManager.instance.cCamera;
        oVar1.DAT_8A = 2;
        oVar1.DAT_8B = 0;
        oVar1.DAT_26 = 15;
        oVar1.DAT_92 = 0;
        oVar1.DAT_52 = 0;
        oVar1.DAT_50 = 0;
        oVar1.DAT_3E = 0;
        oVar1.DAT_36 = 0;
        oVar1.DAT_90 = 0;
        oVar1.DAT_56 = 0;
        oVar1.DAT_54 = 0;
        oVar1.SDAT_2E = 0;
    }

    private void FUN_2F800(CriPlayer param1)
    {
        if (param1.DAT_98 == DAT_98)
            param1.DAT_98 = param1.DAT_1E0;

        param1.DAT_18D = true;
        DAT_18D = true;
        param1.DAT_152 = 0;
        DAT_152 = 0;
        param1.DAT_11E &= 0xf7;
    }

    private void FUN_2F848()
    {
        uint uVar2;
        CriPlayer oVar3;

        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (oVar3.DAT_3C != 5)
            return;

        if (oVar3.DAT_1DC != this)
            return;

        switch (oVar3.DAT_3D)
        {
            case 0:
            case 3:
                if (1 < oVar3.DAT_3E) goto case 1;

                FUN_2F800(oVar3);

                if (oVar3.DAT_3D == 0)
                    uVar2 = 0;
                else
                    uVar2 = 2;

                goto LAB_2F984;
            case 1:
            case 4:
            case 14:
                oVar3.DAT_1D6 = 1;
                break;
            case 6:
            case 7:
                oVar3.DAT_3C = 5;
                oVar3.DAT_3D = 8;
                oVar3.DAT_3E = 0;
                oVar3.DAT_3F = 0;
                SceneManager.instance.cCamera.DAT_72 &= 0xfb;
                break;
            case 12:
            case 13:
                if ((DAT_208 & 0x8000000) != 0)
                {
                    DAT_208 &= 0xf7ffffff;
                    SceneManager.instance.FUN_26E6C();
                }

                goto case 16;
            case 16:
                FUN_2F800(oVar3);
                uVar2 = 0;
                oVar3.vr.y = vr.y + 0x800 & 0xfff;
            LAB_2F984:
                FUN_53A2C(1, uVar2);
                break;
        }
    }

    public void FUN_2FAB0()
    {
        byte bVar1;
        short sVar2;
        ushort uVar2;
        sbyte sVar4;
        byte bVar5;
        short sVar6;
        uint uVar7;
        bool bVar8;
        uint uVar10;
        Vector3Int plVar11;

        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if (DAT_3C != 0)
        {
            if ((InventoryManager.DAT_B7A60[0] & 2) != 0)
            {
                FUN_66208();
                return;
            }

            if ((DAT_18E & 0x80) != 0)
            {
                FUN_66208();
                goto LAB_2FE28;
            }
        }

        if (DAT_3C == 1 && DAT_3D == 0x19)
            plVar11 = (Vector3Int)V4_21C;
        else
            plVar11 = SceneManager.instance.DAT_27C[10].screen;

        sVar4 = GameManager.instance.FUN_774CC(this, plVar11);
        DAT_1C7 = sVar4;

        if (DAT_1C7 == -1)
        {
            GameManager.instance.FUN_77238((byte)DAT_48, ref V4_21C);
            sVar4 = GameManager.instance.FUN_774CC(this, (Vector3Int)V4_21C);
            DAT_1C7 = sVar4;
        }

        DAT_34 = screen;
        uVar7 = Utilities.FUN_631AC(screen, SceneManager.instance.DAT_27C[10].screen);
        bVar1 = DAT_177;
        UDAT_20C = uVar7;

        if (bVar1 != 0)
            DAT_177 = (byte)(bVar1 - 1);

        GameManager.instance.FUN_40C60(this);

        if (SDAT_1F8 < 80)
            SDAT_1F8++;

        sVar2 = DAT_194;

        if (0 < DAT_194)
        {
            bVar1 = DAT_3C;

            if (bVar1 != 3 && bVar1 != 4)
            {
                DAT_194 = (short)(sVar2 - 1);

                if (sVar2 == 1)
                {
                    if (bVar1 != 2)
                    {
                        uVar2 = (ushort)(DAT_3D << 8 | DAT_3C);

                        if (uVar2 != 0xe01 && uVar2 != 0x1b01 && uVar2 != 0x2201 && uVar2 != 0x2301 
                            && uVar2 != 0x2401 && (DAT_3E == 0 || (uVar2 != 0xb01 && uVar2 != 0xc01 && 
                            uVar2 != 0xd01 && uVar2 != 0x1501 && uVar2 != 0x1701 && uVar2 != 0x2001 && 
                            uVar2 != 0x1001 && uVar2 != 0x1101 && uVar2 != 0x1e01 && uVar2 != 0x1f01 
                            && uVar2 != 0x1801)))
                        {
                            DAT_194 = 0;
                            DAT_3C = 5;
                            DAT_3D = 0;
                            DAT_3E = 0;
                            DAT_3F = 0;
                            FUN_65CF8(0, 0, 30);
                            FUN_2F848();
                            return;
                        }

                        DAT_194 = 1;
                    }
                }
            }
        }

        sVar6 = DAT_202;

        if (0 < DAT_202)
        {
            DAT_202 = sVar6;

            if (sVar6 << 0x10 < 0)
                DAT_202 = 0;
        }

        FUN_40CD8();
        FUN_659D0();
        uVar10 = DAT_208;

        if ((uVar10 & 0x2000000) == 0 && (uVar2 = (ushort)(DAT_3C | DAT_3D << 8)) != 0x101 &&
            uVar2 != 0x1901 && uVar2 != 0x1a01)
            DAT_208 = uVar10 | 0x2000000;

        PTR_FUN_9B964[DAT_3C]();
        FUN_2E328();
        FUN_62F3C(ref DAT_40);
        screen.y += 100;
        FUN_65A28();
        bVar8 = SceneManager.instance.FUN_80030(this, DAT_18D, (byte)DAT_12E);

        if (!bVar8 || (DAT_128 & 0x400) == 0)
            bVar5 = (byte)(DAT_162 & 0xfe);
        else
            bVar5 = (byte)(DAT_162 | 1);

        DAT_162 = bVar5;
        FUN_3029C();

        if (DAT_3C == 4 && DAT_3D == 5)
            FUN_3E4A0();

        LAB_2FE28:
        FUN_6449C(DAT_140);
        DAT_48 = (sbyte)-(screen.y / 425);
        bVar8 = SceneManager.instance.FUN_80A14(this);

        if (!bVar8)
            bVar5 = (byte)(DAT_162 & 0xfd);
        else
            bVar5 = (byte)(DAT_162 | 2);

        DAT_162 = bVar5;

        if (DAT_3C == 1 && DAT_3D == 31)
            DAT_214 = Utilities.FUN_631AC(screen, DAT_34);

        if (DAT_3C == 4 && (DAT_3C != 4 || DAT_3D != 6) || DAT_3C == 6)
            flags &= 0xfffffffb;
        else
            flags |= 4;
    }

    private void FUN_2FF18()
    {
        byte bVar1;
        bool bVar2;
        int iVar3;
        CriPlayer oVar3;
        uint uVar4;
        int iVar5;

        skinSize = new Vector3Int(0x1000, 0x1000, 0x1000);
        screen.y = 0;
        DAT_3C++;
        FUN_6449C(DAT_140);
        FUN_77784(3, 620);

        if (DAT_2F / 3 == 0)
            DAT_18E |= 0x20;

        if ((DAT_18E & 3) == 0)
            bVar1 = 1;
        else
        {
            bVar1 = 26;

            if ((DAT_18E & 3) == 1)
                bVar1 = 25;
        }

        DAT_3D = bVar1;

        if (maxHealth == 0)
            FUN_2D704();

        health = maxHealth;

        if (DAT_196 < 1)
            DAT_196 = 0;
        else
        {
            DAT_3C = 5;
            DAT_3D = 1;
            DAT_3E = 0;
            DAT_3F = 0;
        }

        DAT_12C = 0;
        DAT_1A3 = 0;
        DAT_199 = 0;
        DAT_194 = 0;
        DAT_19E = 0;
        DAT_175 = 2;
        FUN_65CF8(0, 0, 30);
        oVar3 = (CriPlayer)SceneManager.instance.FUN_65B30(this);

        if (oVar3 == null)
            DAT_1C5 = 1;
        else
        {
            if (oVar3.DAT_1C5 != 1)
                DAT_1C5 = 1;
        }

        DAT_1C8 = 0;
        DAT_1C2 = 0;
        DAT_1D2 = 0;
        BDAT_1D0 = 0;
        SDAT_1F8 = 0;
        DAT_208 = 0;
        DAT_1DD = 0;
        BDAT_1DC = 0;
        DAT_1E6 = 100;
        iVar3 = (int)GameManager.FUN_64650();
        DAT_1D3 = (byte)(iVar3 + (iVar3 / 2) * -2 + 2);
        FUN_2DA0C(false);
        uVar4 = GameManager.FUN_64650();

        if ((uVar4 & 1) == 0)
            uVar4 = DAT_208 & 0xfffffeff;
        else
            uVar4 = DAT_208 | 0x100;

        DAT_208 = uVar4;
        PTR_120 = DAT_9B404;
        DAT_120 = 0;
        PTR_130 = DAT_9B404;
        DAT_130 = 6;
        DAT_18D = true;
        PTR_124 = DAT_9B404;
        DAT_124 = 7;
        DAT_12E = 3;
        DAT_12F = 2;
        iVar3 = (int)GameManager.FUN_64650();
        uVar4 = 0;
        DAT_1FE = (short)(iVar3 + (iVar3 / 30) * -30 + 120);
        FUN_66404(0, 0x1000, 0x2000);
        FUN_65984(19, 11);

        do
        {
            if ((DAT_19A >> (int)(uVar4 & 0x1f) & 1U) != 0)
            {
                bVar2 = Utilities.FUN_2EC6C(this, (byte)(uVar4 >> 2), (byte)(uVar4 & 3));

                if (bVar2)
                    DAT_199++;
            }

            uVar4++;
        } while ((uVar4 & 0xff) < 15);

        if ((DAT_3C == 5 && DAT_3D == 1) || (DAT_3C == 1 && DAT_3D == 0x1a))
            iVar5 = 2;
        else
            iVar5 = 5;

        FUN_609C8(iVar5, 1, 0);
    }

    private void FUN_2B828()
    {
        PTR_FUN_9AD60[DAT_3E]();
    }

    private void FUN_2B730()
    {
        DAT_11E |= 0x88;
        DAT_3E++;
    }

    private void FUN_2B74C()
    {
        FUN_609C8(39, 1, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_9CDC6 = 0;
        FUN_65714();
        DAT_1C0 &= 0xfffffffe;
        GameManager.instance.FUN_5C94C(this, 3);
        DAT_3E++;
    }

    private void FUN_2B7C4()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3D = 1;
            DAT_3E = 0;
            DAT_140 &= 0xfffe;
        }

        FUN_65714();

        if (DAT_60 == 10)
            GameManager.instance.FUN_5C94C(this, 5);
    }

    private void FUN_2B928()
    {
        if (DAT_1D6 == 0)
            PTR_FUN_9AD6C[DAT_3E]();
        else
        {
            FUN_6103C(43, 0, 12, 5);
            DAT_60 = 24;
            DAT_3C = 5;
            DAT_3D = 2;
            DAT_40.x = 0;
            DAT_40.z = 0;
            DAT_3E = 1;
            DAT_154.DAT_152 = 0;
            DAT_152 = 0;
        }
    }

    private void FUN_2B864()
    {
        FUN_609C8(40, 1, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        FUN_65714();
        DAT_3E++;
    }

    private void FUN_2B8B8()
    {
        ushort uVar1;

        FUN_60AB4();
        FUN_65714();
        uVar1 = DAT_60;

        if (uVar1 == 20)
        {
            DAT_5C |= 8;
            uVar1 = DAT_60;
        }

        if (uVar1 == 50)
            DAT_5C &= 0xf7;
    }

    private void FUN_2BADC()
    {
        PTR_FUN_9AD74[DAT_3E]();
    }

    private void FUN_2B9C4()
    {
        FUN_609C8(43, 1, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_154.DAT_152 = 0;
        DAT_152 = 0;
        DAT_3E++;
    }

    private void FUN_2BA18()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_9CDC6 = 0;
            DAT_11E &= 0x7f;
            DAT_12C &= 0xfff7;
            DAT_1DC.FUN_2F800(this);

            if (DAT_1D6 == 0 && DAT_1A3 == 0)
            {
                DAT_1E8 = 5400;
                DAT_1C0 |= 4;
            }
            else
            {
                DAT_1D6 = 0;
                DAT_1A3 = 0;
            }
        }

        if (DAT_60 == 10)
        {
            //...
        }
    }

    private void FUN_2BBF4()
    {
        PTR_FUN_9AD7C[DAT_3E]();
    }

    private void FUN_2BB18()
    {
        FUN_609C8(41, 1, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_9CDC6 = 0;
        FUN_65714();
        DAT_1C0 &= 0xfffffffe;
        GameManager.instance.FUN_5C94C(this, 3);
        DAT_3E++;
    }

    private void FUN_2BB90()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3D = 4;
            DAT_3E = 0;
            DAT_140 &= 0xfffe;
        }

        FUN_65714();

        if (DAT_60 == 10)
            GameManager.instance.FUN_5C94C(this, 5);
    }

    private void FUN_2BCF4()
    {
        if (DAT_1D6 == 0)
            PTR_FUN_9AD88[DAT_3E]();
        else
        {
            FUN_6103C(44, 0, 12, 5);
            DAT_60 = 24;
            DAT_3C = 5;
            DAT_3D = 5;
            DAT_40.x = 0;
            DAT_40.z = 0;
            DAT_3E = 1;
            DAT_154.DAT_152 = 0;
            DAT_152 = 0;
        }
    }

    private void FUN_2BC30()
    {
        FUN_609C8(42, 1, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        FUN_65714();
        DAT_3E++;
    }

    private void FUN_2BC84()
    {
        ushort uVar1;

        FUN_60AB4();
        FUN_65714();
        uVar1 = DAT_60;

        if (uVar1 == 20)
        {
            DAT_5C |= 8;
            uVar1 = DAT_60;
        }

        if (uVar1 == 50)
            DAT_5C &= 0xf7;
    }

    private void FUN_2BEA8()
    {
        PTR_FUN_9AD90[DAT_3E]();
    }

    private void FUN_2BD90()
    {
        FUN_609C8(44, 1, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_154.DAT_152 = 0;
        DAT_152 = 0;
        DAT_3E++;
    }

    private void FUN_2BDE4()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_9CDC6 = 0;
            DAT_11E &= 0x7f;
            DAT_12C &= 0xfff7;
            DAT_1DC.FUN_2F800(this);

            if (DAT_1D6 == 0 && DAT_1A3 == 0)
            {
                DAT_1E8 = 5400;
                DAT_1C0 |= 4;
            }
            else
            {
                DAT_1D6 = 0;
                DAT_1A3 = 0;
            }
        }

        if (DAT_60 == 10)
        {
            //...
        }
    }

    private void FUN_2BF8C()
    {
        PTR_FUN_9AD98[DAT_3E]();
    }

    private void FUN_2BEE4()
    {
        FUN_609C8(45, 0, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_11E |= 0x80;
        FUN_65714();
        DAT_1C0 &= 0xfffffffe;
        DAT_3E++;
    }

    private void FUN_2BF50()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 5;
            DAT_3D = 7;
            DAT_3E = 0;
            DAT_3F = 0;
        }

        FUN_65714();
    }

    private void FUN_2C080()
    {
        PTR_FUN_9ADA0[DAT_3E]();
    }

    private void FUN_2BFC8()
    {
        FUN_6103C(46, 1, DAT_1E4, 5);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
        FUN_65714();
    }

    private void FUN_2C024()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
            FUN_6103C(46, 1, DAT_1E4, 5);

        FUN_65714();
    }

    private void FUN_2C1A4()
    {
        PTR_FUN_9ADA8[DAT_3E]();
    }

    private void FUN_2C0BC()
    {
        FUN_609C8(47, 0, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        FUN_65714();
        //FUN_1D988
        DAT_3E++;
    }

    private void FUN_2C11C()
    {
        ushort uVar1;
        bool bVar2;

        bVar2 = FUN_60AB4();

        if (!bVar2)
            FUN_65714();
        else
        {
            FUN_65714();
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1DC.FUN_2F800(this);
            uVar1 = DAT_12C;
            vr.y = vr.y + 0x400 & 0xfff;
            DAT_12C = (ushort)(uVar1 & 0xffbf);
            DAT_12C = (ushort)(uVar1 & 0xffb7);
            DAT_11E &= 0x7f;
        }
    }

    private void FUN_2C2C8()
    {
        PTR_FUN_9ADB0[DAT_3E]();
    }

    private void FUN_2C1E0()
    {
        FUN_609C8(41, 0, 5);
        DAT_11E |= 0x80;
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_1C8 = 0;
        DAT_1C0 &= 0xfffffffe;
        GameManager.instance.FUN_5C94C(this, 3);
        DAT_3E++;
    }

    private void FUN_2C258()
    {
        short sVar1;
        bool bVar2;

        sVar1 = (short)DAT_64.z;
        bVar2 = FUN_60AB4();

        if (!bVar2)
        {
            DAT_40.z = -((DAT_64.z - sVar1) - 76);

            if (DAT_60 == 10)
                GameManager.instance.FUN_5C94C(this, 5);
        }
        else
        {
            DAT_3C = 5;
            DAT_3D = 10;
            DAT_3E = 0;
            DAT_3F = 0;
        }
    }

    private void FUN_2C418()
    {
        PTR_FUN_9ADB8[DAT_3E]();
    }

    private void FUN_2C304()
    {
        FUN_609C8(48, 1, 0);
        DAT_1CA = 25;
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_1E6 = 100;
        DAT_5C |= 8;
        FUN_538CC();
        DAT_3E++;
    }

    private void FUN_2C388()
    {
        int iVar2;

        FUN_60AB4();

        if ((DAT_11E & 0x20) == 0)
        {
            iVar2 = GameManager.instance.FUN_64C80();

            if (iVar2 != 0)
                DAT_1CA -= (short)iVar2;

            if (DAT_1CA < 1 || --DAT_1E6 << 0x10 < 1)
            {
                DAT_3C = 5;
                DAT_3D = 11;
                DAT_3E = 0;
                DAT_3F = 0;
            }
        }
    }

    private void FUN_2C5D0()
    {
        PTR_FUN_9ADC0[DAT_3E]();
    }

    private void FUN_2C454()
    {
        FUN_609C8(54, 4, 5);
        DAT_40.x = 0;
        DAT_40.z = 0;
        FUN_5348C(0x70, 0x70);
        DAT_3E++;
    }

    private void FUN_2C4B0()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;
    }

    private void FUN_2C4F0()
    {
        DAT_98 = DAT_1E0;
        FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x801860CC], 6, 0, 0);
        DAT_3E++;
    }

    private void FUN_2C540()
    {
        bool bVar1;
        int iVar1;
        CriPlayer oVar2;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            oVar2 = DAT_1DC;
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            iVar1 = (int)GameManager.FUN_64650();
            oVar2.DAT_1C8 = (sbyte)(iVar1 + (iVar1 / 10) * -10 + 20);
            DAT_11E &= 0x7f;
            DAT_12C &= 0xfff7;
        }
    }

    private void FUN_2C890()
    {
        PTR_FUN_9AE50[DAT_3E]();
    }

    private void FUN_2C60C()
    {
        FUN_609C8(49, 0, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        FUN_65714();
        DAT_1C0 &= 0xfffffffe;
        DAT_3E++;
    }

    private void FUN_2C66C()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;

        FUN_65714();
    }

    private void FUN_2C6B4()
    {
        CriPlayer oVar1;

        oVar1 = DAT_1DC;
        FUN_609C8(50, 1, 0);
        FUN_65714();
        oVar1.DAT_1D4 = 0;
        DAT_3E++;
    }

    private void FUN_2C710()
    {
        bool bVar1;
        CriPlayer oVar2;

        oVar2 = DAT_1DC;
        bVar1 = FUN_60AB4();

        if (bVar1)
            oVar2.DAT_1D4++;

        FUN_65714();

        if (oVar2.DAT_1D4 == 0)
            ; //FUN_2F9A0
    }

    private void FUN_2C784()
    {
        FUN_609C8(53, 0, 0);
        FUN_65714();
        DAT_3E++;
    }

    private void FUN_2C7D0()
    {
        byte bVar1;
        bool bVar2;

        bVar2 = FUN_60AB4();

        if (!bVar2)
        {
            FUN_65714();

            if (DAT_60 == 25)
                ; //FUN_1D988
        }
        else
        {
            FUN_65714();
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1E8 = 5400;
            DAT_1C0 |= 4;
            bVar1 = DAT_11E;
            vr.y = vr.y + 0x800 & 0xfff;
            DAT_152 = 0;
            DAT_98 = DAT_1E0;
            DAT_12C &= 0xfff7;
            DAT_11E = (byte)(bVar1 & 0x7f);
            DAT_11E = (byte)(bVar1 & 0x77);
            DAT_154.DAT_152 = 0;
        }
    }

    private void FUN_2CB4C()
    {
        PTR_FUN_9AEEC[DAT_3E]();
    }

    private void FUN_2C8CC()
    {
        FUN_609C8(51, 0, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        FUN_65714();
        DAT_1C0 &= 0xfffffffe;
        DAT_3E++;
    }

    private void FUN_2C92C()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;

        FUN_65714();
    }

    private void FUN_2C974()
    {
        FUN_609C8(52, 1, 0);
        FUN_65714();
        DAT_1DC.DAT_1D4 = 0;
        DAT_3E++;
    }

    private void FUN_2C9CC()
    {
        bool bVar1;
        CriPlayer oVar2;

        oVar2 = DAT_1DC;
        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_1D4++;

        FUN_65714();

        if (DAT_1D4 == 0)
            ; //FUN_2F9A0
    }

    private void FUN_2CA40()
    {
        FUN_609C8(53, 0, 0);
        FUN_65714();
        DAT_3E++;
    }

    private void FUN_2CA8C()
    {
        byte bVar1;
        bool bVar2;

        bVar2 = FUN_60AB4();

        if (!bVar2)
        {
            FUN_65714();

            if (DAT_60 == 25)
                ; //FUN_1D988
        }
        else
        {
            FUN_65714();
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1E8 = 5400;
            DAT_1C0 |= 4;
            bVar1 = DAT_11E;
            vr.y = vr.y + 0x800 & 0xfff;
            DAT_152 = 0;
            DAT_98 = DAT_1E0;
            DAT_12C &= 0xfff7;
            DAT_11E = (byte)(bVar1 & 0x7f);
            DAT_11E = (byte)(bVar1 & 0x77);
            DAT_154.DAT_152 = 0;
        }
    }

    private void FUN_2CB88()
    {
        byte bVar1;
        int iVar2;
        bool bVar2;
        CriPlayer oVar3;

        if (DAT_1D6 != 0)
        {
            DAT_3E = 6;
            DAT_1D6 = 0;
        }

        switch (DAT_3E)
        {
            case 0:
                FUN_609C8(68, 0, 0);
                DAT_40 = new Vector3Int(0, 0, 0);
                DAT_11E |= 0x80;
                FUN_65714();
                DAT_1C0 &= 0xfffffffe;
                DAT_3E++;
                break;
            case 1:
            case 5:
                bVar2 = FUN_60AB4();

                if (bVar2)
                    DAT_3E++;

                FUN_65714();
                break;
            case 2:
                FUN_609C8(69, 1, 0);
                FUN_65714();
                //FUN_2F9A0
                bVar1 = (byte)(DAT_3E + 1);
                goto LAB_2CD40;
            case 3:
                bVar2 = FUN_60AB4();

                if (bVar2)
                    FUN_609C8(69, 1, 0);

                FUN_65714();
                //FUN_2F9A0
                break;
            case 4:
                FUN_609C8(70, 0, 0);
                FUN_65714();
                bVar1 = (byte)(DAT_3E + 1);
                goto LAB_2CD40;
            case 6:
                FUN_6103C(44, 0, 12, 5);
                DAT_60 = 24;
                bVar1 = (byte)(DAT_3E + 1);
                LAB_2CD40:
                DAT_3E = bVar1;
                break;
            case 7:
                bVar2 = FUN_60AB4();

                if (bVar2)
                {
                    oVar3 = DAT_1DC;
                    DAT_3C = 1;
                    DAT_3D = 0;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_11E &= 0x7f;
                    DAT_12C &= 0xfff7;
                    oVar3.FUN_2F800(this);
                    iVar2 = (int)GameManager.FUN_64650();
                    oVar3.DAT_1C8 = (sbyte)(iVar2 + (iVar2 / 10) * -10 + 20);
                }

                break;
            default:
                return;
        }
    }

    private void FUN_2CED0()
    {
        PTR_FUN_9AFD8[DAT_3E]();
    }

    private void FUN_2CDD4()
    {
        FUN_609C8(74, 0, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        FUN_65714();
        DAT_1C0 &= 0xfffffffe;
        DAT_3E++;
    }

    private void FUN_2CE34()
    {
        bool bVar1;
        ushort uVar2;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
            DAT_3C = 5;
            DAT_3D = 10;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_11E &= 0xf7;
        }

        FUN_65714();
        uVar2 = DAT_60;

        if (uVar2 == 15)
        {
            //FUN_1D988
            uVar2 = DAT_60;
        }

        if (uVar2 == 18)
        {
            GameManager.instance.FUN_5C94C(this, 3);
            GameManager.instance.FUN_5C94C(this, 5);
        }
    }

    private void FUN_2D318()
    {
        PTR_FUN_9AFE4[DAT_3E]();
    }

    private void FUN_2CF0C()
    {
        FUN_609C8(71, 0, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_1C0 &= 0xfffffffe;
        DAT_3E++;
    }

    private void FUN_2CF64()
    {
        bool bVar1;
        CriPlayer oVar2;
        Matrix3x3 MStack56;
        Vector3Int local_18;

        oVar2 = DAT_1DC;
        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;

        local_18 = new Vector3Int(0, 0, 1550);
        MStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref MStack56);
        local_18 = Utilities.ApplyMatrixSV(ref MStack56, ref local_18);
        screen.x = oVar2.screen.x + local_18.x;
        screen.z = oVar2.screen.z + local_18.z;
        vr.y = oVar2.vr.y + 0x800 & 0xfff;
    }

    private void FUN_2D010()
    {
        short sVar1;
        CriPlayer oVar2;
        Matrix3x3 MStack56;
        Vector3Int local_18;

        oVar2 = DAT_1DC;
        FUN_609C8(72, 1, 0);
        local_18 = new Vector3Int(0, 0, 1550);
        MStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar2.vr, ref MStack56);
        local_18 = Utilities.ApplyMatrixSV(ref MStack56, ref local_18);
        screen.x = oVar2.screen.x + local_18.x;
        screen.z = oVar2.screen.z + local_18.z;
        sVar1 = (short)oVar2.vr.y;
        DAT_3E++;
        vr.y = sVar1 + 0x800 & 0xfff;
    }

    private void FUN_2D0BC()
    {
        CriPlayer oVar1;
        Matrix3x3 MStack56;
        Vector3Int local_18;

        oVar1 = DAT_1DC;
        FUN_60AB4();
        local_18 = new Vector3Int(0, 0, 1550);
        MStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar1.vr, ref MStack56);
        local_18 = Utilities.ApplyMatrixSV(ref MStack56, ref local_18);
        screen.x = oVar1.screen.x + local_18.x;
        screen.z = oVar1.screen.z + local_18.z;
        vr.y = oVar1.screen.y + 0x800 & 0xfff;

        if ((DAT_162 & 2) != 0 && 
            (oVar1.DAT_210 | oVar1.DAT_211 << 8 | oVar1.DAT_212 << 0x10 | oVar1.DAT_213 << 0x18) < 100)
        {
            DAT_3E++;
            oVar1.DAT_3E = 4;
        }

        if (oVar1.DAT_60 == 1)
            ; //FUN_1D988
    }

    private void FUN_2D1A4()
    {
        FUN_609C8(73, 0, 0);
        //FUN_1D988
        DAT_3E++;
    }

    private void FUN_2D1F4()
    {
        byte bVar1;
        bool bVar2;
        CriPlayer oVar2;
        int iVar3;

        bVar2 = FUN_60AB4();

        if (bVar2)
        {
            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
            FUN_6103C(41, 0, 3, 0);
            oVar2 = DAT_1DC;
            DAT_60 = 3;
            DAT_3C = 5;
            DAT_3D = 9;
            DAT_3E = 1;
            DAT_1C8 = 0;
            DAT_1CA = 0;
            oVar2.DAT_18D = true;
            bVar1 = DAT_11E;
            DAT_1F0 = oVar2;
            DAT_18D = true;
            DAT_11E = (byte)(bVar1 & 0xf7);

            if ((bVar1 & 1) == 0 && 0 < health)
            {
                iVar3 = (int)GameManager.FUN_64650();
                health = (short)((health - 175) - (iVar3 + (iVar3 / 50) * -50));
                FUN_4FE30();

                if (health < 1)
                    ; //FUN_2ECAC
            }
        }
    }

    private void FUN_2D4E8()
    {
        PTR_FUN_9B000[DAT_3E]();
    }

    private void FUN_2D354()
    {
        FUN_609C8(66, 0, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_11E |= 0x80;
        FUN_65714();
        DAT_1C0 &= 0xfffffffe;
        DAT_3E++;
    }

    private void FUN_2D3C0()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (!bVar1)
        {
            FUN_65714();

            if (DAT_60 == 22)
            {
                GameManager.instance.FUN_5C94C(this, 5);

                if ((DAT_11E & 1) == 0 && 0 < health)
                {
                    health -= 75;
                    FUN_4FE30();

                    if (health < 1)
                        ; //FUN_2ECAC
                }
            }
        }
        else
        {
            DAT_11E &= 0xf7;

            if (health < 1)
            {
                GameManager.instance.PTR_FUN_14C = GameManager.FUN_2D6C8;
                DAT_3C = 6;
                DAT_3D = 0;
                DAT_3E = 1;
            }
            else
            {
                DAT_98 = DAT_1E0;
                FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[0x8019D2B0], 0, 0, 0);
                DAT_3C = 2;
                DAT_3D = 6;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_11E &= 0x7f;
                DAT_12C &= 0xfff7;
            }
        }
    }

    private void FUN_2D5F8()
    {
        PTR_FUN_9B008[DAT_3E]();
    }

    private void FUN_2D524()
    {
        FUN_609C8(67, 0, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_11E |= 0x80;
        FUN_65714();
        DAT_1C0 &= 0xfffffffe;
        DAT_3E++;
    }

    private void FUN_2D590()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
            DAT_3C = 5;
            DAT_3D = 1;
            DAT_3E = 0;
            DAT_3F = 0;
        }

        FUN_65714();

        if (DAT_60 == 13)
            GameManager.instance.FUN_5C94C(this, 5);
    }

    private void FUN_2B4E8()
    {
        sbyte sVar1;
        int iVar2;
        CriPlayer oVar3;

        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        sVar1 = GameManager.instance.FUN_7732C((ushort)screen.x, (ushort)screen.z, (byte)DAT_48);
        BDAT_1C0 = (byte)sVar1;
        sVar1 = GameManager.instance.FUN_7732C((ushort)oVar3.screen.x, (ushort)oVar3.screen.z, (byte)oVar3.DAT_48);
        DAT_1C1 = sVar1;
        iVar2 = (int)GameManager.FUN_64650();
        DAT_1C6 = (byte)(iVar2 % 2);
        DAT_1E2 = 100;

        if ((iVar2 % 2 & 0xff) != 0)
        {
            DAT_1E2 = 0;
            FUN_2B3EC();
        }
    }

    public void FUN_2B6F4()
    {
        PTR_FUN_9AD14[DAT_3D]();
    }

    public void FUN_2D6C8()
    {
        PTR_FUN_9B010[DAT_3E]();
    }

    private void FUN_2D634()
    {
        int iVar1;

        if (DAT_3D == 0)
            iVar1 = 55;
        else
            iVar1 = 56;

        FUN_609C8(iVar1, 1, 0);
        DAT_40.x = 0;
        DAT_40.z = 0;
        DAT_124 = 0;
        DAT_120 = 0;
        DAT_12F = 0;
        DAT_12E = 0;
        DAT_11E |= 0x81;
        DAT_227 &= 0x7f;
        //FUN_5C94C
        DAT_3E++;
    }

    private void FUN_2D76C()
    {
        byte bVar1;
        ushort uVar2;
        int iVar3;
        uint uVar4;
        uint uVar5;
        byte[] local_18;

        iVar3 = (int)GameManager.FUN_64650();
        SDAT_1FC = (short)(iVar3 + (iVar3 / 120) * -120 + 180);
        iVar3 = (int)GameManager.FUN_64650();
        uVar2 = Utilities.DAT_9B03C[DAT_2F];
        DAT_208 &= 0xfbffffff;
        UDAT_1E0 = (ushort)(uVar2 + (iVar3 + (iVar3 / 150) * -150) * 10);

        if (8U < DAT_1CB)
        {
            DAT_1CF = 0;
            DAT_1CE = 0;
            DAT_1CD = 0;
            DAT_1CC = 0;
            DAT_1CB = 0;
        }

        uVar5 = 0;
        uVar4 = 0;
        local_18 = new byte[8];

        do
        {
            switch (uVar4)
            {
                case 0:
                    bVar1 = DAT_1CC;
                    break;
                case 1:
                    bVar1 = DAT_1CD;
                    break;
                case 2:
                    bVar1 = DAT_1CE;
                    break;
                default:
                    bVar1 = DAT_1CF;
                    break;
            }

            if (bVar1 < Utilities.DAT_9B018[uVar4 + DAT_2F * 4])
            {
                local_18[uVar5 & 0xff] = (byte)uVar4;
                uVar5++;
            }

            uVar4++;
        } while (uVar4 < 4);

        uVar5 &= 0xff;

        if (uVar5 != 0)
        {
            iVar3 = (int)GameManager.FUN_64650();

            if (uVar5 == 0)
                return; //trap(0x1c00)

            if (uVar5 == 0xffffffff && iVar3 == -0x80000000)
                return; //trap(0x1800)

            bVar1 = local_18[iVar3 % (int)uVar5 & 0xff];
            DAT_1C2 = bVar1;

            switch (bVar1)
            {
                case 0:
                    DAT_1CC++;
                    break;
                case 1:
                    DAT_1CD++;
                    break;
                case 2:
                    DAT_1CE++;
                    break;
                default:
                    DAT_1CF++;
                    break;
            }

            DAT_1CB++;
        }

        if (DAT_1C2 == 1 && UDAT_20C < 4500)
        {
            iVar3 = (int)GameManager.FUN_64650();

            if (iVar3 == 0)
            {
                DAT_1C2 = 2;
                return;
            }

            iVar3 = (int)GameManager.FUN_64650();

            if (iVar3 == 0 && DAT_2F / 3 != 0)
            {
                DAT_1C2 = 3;
                return;
            }
        }
        else
        {
            if (DAT_1C2 != 3)
                return;

            if (3499 < UDAT_20C)
                return;

            iVar3 = (int)GameManager.FUN_64650();

            if (iVar3 == (iVar3 / 3) * 3)
            {
                DAT_1C2 = 2;
                return;
            }
        }

        DAT_1C2 = 0;
    }

    private void FUN_2DA0C(bool param1)
    {
        bool bVar1;
        int iVar2;
        uint uVar3;
        int iVar4;

        if (!param1)
        {
            if (maxHealth * 7 / 10 <= health)
            {
                iVar4 = 4;
                goto LAB_2DAC8;
            }

            bVar1 = health < (maxHealth << 2) / 10;
        }
        else
            bVar1 = health < (maxHealth * 7) / 10;

        iVar4 = 2;

        if (!bVar1)
            iVar4 = 3;

        LAB_2DAC8:
        iVar2 = (int)GameManager.FUN_64650();

        if (iVar4 == 0)
            return; //trap(0x1c00)

        if (iVar4 == -1 && iVar2 == -0x80000000)
            return; //trap(0x1800)

        uVar3 = (uint)(iVar2 % iVar4 + 1);
        DAT_1D1 = (byte)uVar3;

        if ((uVar3 & 0xff) == 1)
        {
            uVar3 = GameManager.FUN_64650();

            if ((uVar3 & 7) != 0)
            {
                iVar2 = (int)GameManager.FUN_64650();
                iVar4--;

                if (iVar4 == 0)
                    return; //trap(0x1c00)

                if (iVar4 == -1 && iVar2 == -0x80000000)
                    return; //trap(0x1800)

                DAT_1D1 = (byte)((iVar2 % iVar4) + 2);
            }
        }
    }

    private void FUN_2DB80()
    {
        short sVar1;
        short sVar2;
        byte bVar3;
        sbyte sVar4;
        short sVar5;
        byte bVar6;
        byte bVar7;
        Vector3Int local_70;
        Vector3Int local_68;
        Vector3Int local_60;
        Vector3Int local_58;
        Vector2Int local_50;
        Vector2Int local_4c;
        Matrix3x3 MStack64;
        Vector2Int auStack72;

        local_70 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
        local_60 = new Vector3Int(0, 0, 1500);
        local_58 = new Vector3Int(0, 0, 0);
        local_50 = new Vector2Int();
        local_4c = new Vector2Int();
        sVar1 = (short)screen.x;
        sVar2 = (short)screen.z;
        bVar3 = 0;

        do
        {
            bVar6 = bVar3;
            sVar5 = (short)Utilities.FUN_615EC(local_70, screen);
            local_58.y = sVar5 - 0x100 & 0xfff;
            MStack64 = new Matrix3x3();
            Utilities.RotMatrix(ref local_58, ref MStack64);
            local_68 = Utilities.ApplyMatrixSV(ref MStack64, ref local_60);
            local_68.x += local_70.x;
            local_68.z += local_70.z;

            if (bVar6 == 0)
                local_50 = new Vector2Int(local_68.x, local_68.z);

            auStack72 = new Vector2Int();
            sVar4 = SceneManager.instance.FUN_64D20(this, local_68, ref auStack72);

            if (sVar4 != 0) break;

            screen.x = local_68.x;
            screen.z = local_68.z;
            bVar3 = (byte)(bVar6 + 1);
        } while (bVar6 + 1U < 4);

        screen.x = sVar1;
        screen.z = sVar2;
        bVar3 = 0;

        do
        {
            bVar7 = bVar3;
            sVar5 = (short)Utilities.FUN_615EC(local_70, screen);
            local_58.y = sVar5 + 0x100 & 0xfff;
            Utilities.RotMatrix(ref local_58, ref MStack64);
            local_68.x += local_70.x;
            local_68.z += local_70.z;

            if (bVar7 == 0)
                local_4c = new Vector2Int(local_68.x, local_68.z);

            sVar4 = SceneManager.instance.FUN_64D20(this, local_68, ref auStack72);

            if (sVar4 != 0) break;

            screen.x = local_68.x;
            screen.z = local_68.z;
            bVar3 = (byte)(bVar7 + 1);
        } while (bVar7 + 1U < 4);

        screen.x = sVar1;
        screen.z = sVar2;

        if (bVar6 == bVar7)
        {
            local_70 = new Vector3Int(local_50.x, 0, local_50.y);
            SceneManager.instance.DAT_C3358 = FUN_64804(local_70);

            if (0x7ff < SceneManager.instance.DAT_C3358)
            {
                V3_224.x = local_4c.x;
                DAT_208 &= 0xfffffffd;
                V3_224.z = local_4c.y;
                goto LAB_2DE04;
            }
        }
        else
        {
            if ((uint)bVar6 < bVar7)
            {
                V3_224.x = local_4c.x;
                DAT_208 &= 0xfffffffd;
                V3_224.z = local_4c.y;
                goto LAB_2DE04;
            }
        }

        V3_224.x = local_50.x;
        DAT_208 |= 2;
        V3_224.z = local_50.y;
        LAB_2DE04:
        local_70 = new Vector3Int(V3_224.x, 0, V3_224.z);
        SceneManager.instance.DAT_C3358 = FUN_64804(local_70);

        if ((ushort)(SceneManager.instance.DAT_C3358 - 0x401) < 0x7ffU)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
        }
    }

    private void FUN_2DE6C()
    {
        short sVar1;
        short sVar2;
        Vector3Int local_50;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        local_50 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
        local_40 = new Vector3Int(0, 0, 1500);
        sVar2 = (short)Utilities.FUN_615EC(local_50, V3_224);
        sVar1 = -0x100;

        if ((DAT_208 & 2) == 0)
            sVar1 = 0x100;

        local_38 = new Vector3Int(0, sVar2 + sVar1 & 0xfff, 0);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref MStack48);
        local_48 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        V3_224.x = local_48.x + local_50.x;
        V3_224.z = local_48.z + local_50.z;
    }

    private void FUN_2DF3C()
    {
        CriPlayer oVar1;
        uint uVar2;
        int iVar3;

        oVar1 = SceneManager.instance.FUN_65B30(this) as CriPlayer;

        if (oVar1 != null)
        {
            if ((oVar1.DAT_208 & 0x2000000) != 0)
            {
                if (UDAT_20C < 5000)
                    uVar2 = oVar1.UDAT_20C;
                else
                    uVar2 = oVar1.UDAT_20C;

                if (uVar2 < 5000)
                {
                    iVar3 = (int)GameManager.FUN_64650();

                    if (iVar3 == (iVar3 / 3) * 3)
                    {
                        if (oVar1.UDAT_20C <= UDAT_20C)
                        {
                            oVar1.DAT_1C5 = 0;
                            goto LAB_2E064;
                        }
                    }
                    else
                    {
                        if (UDAT_20C <= oVar1.UDAT_20C)
                        {
                            oVar1.DAT_1C5 = 0;
                            goto LAB_2E064;
                        }
                    }

                    oVar1.DAT_1C5 = 1;
                }
                else
                {
                    if (oVar1.DAT_1C5 != 0)
                        return;

                    oVar1.DAT_1C5 = 1;
                }

                DAT_1C5 = 0;
                return;
            }

            if (oVar1.DAT_1C5 != 0)
                oVar1.DAT_1C5 = 0;
        }

        LAB_2E064:
        DAT_1C5 = 1;
    }

    private void FUN_2B3E4()
    {
        return;
    }

    private void FUN_2B3EC()
    {
        uint uVar1;
        int iVar2;
        int iVar3;

        iVar3 = DAT_10C.x - screen.x;

        if (iVar3 < 0)
            iVar3 = -iVar3;

        iVar2 = DAT_10C.z - screen.z;

        if (iVar2 < 0)
            iVar2 = -iVar2;

        if (iVar3 < iVar2)
        {
            uVar1 = GameManager.FUN_64650();

            if ((uVar1 & 1) == 0)
                UDAT_204 = 0x400;
            else
                UDAT_204 = 0xc00;
        }
        else
        {
            uVar1 = GameManager.FUN_64650();

            if ((uVar1 & 1) == 0)
                UDAT_204 = 0;
            else
                UDAT_204 = 0x800;
        }

        iVar3 = (int)GameManager.FUN_64650();
        DAT_206 = (ushort)((iVar3 + (iVar3 / 50) * -50) * 10 + 1500);
    }

    private void FUN_2B57C()
    {
        CriPlayer oVar1;
        sbyte sVar2;
        sbyte sVar3;
        ushort uVar4;
        uint uVar5;
        Vector3Int local_50;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        uVar4 = (ushort)(DAT_1E2 - 1);

        if (DAT_1E2 != 0)
        {
            DAT_1E2 = uVar4;

            if (uVar4 << 0x10 < 1)
            {
                DAT_1C6 = 1;
                FUN_2B3EC();
            }
        }

        if ((DAT_162 & 2) != 0)
        {
            DAT_1C6 = 0;
            DAT_1E2 = 100;
        }

        if (DAT_1C6 != 0)
        {
            local_48 = new Vector3Int(0, 0, (short)DAT_206);
            local_40 = new Vector3Int(0, (short)UDAT_204, 0);
            MStack48 = new Matrix3x3();
            Utilities.RotMatrix(ref local_40, ref MStack48);
            local_38 = Utilities.ApplyMatrixSV(ref MStack48, ref local_48);
            local_50 = new Vector3Int(DAT_10C.x + local_38.x, 0, DAT_10C.z + local_38.z);
            uVar5 = Utilities.FUN_631AC(screen, local_50);

            if (uVar5 < 2000)
            {
                DAT_1C6 = 0;
                DAT_1E2 = 100;
            }
        }

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        sVar2 = GameManager.instance.FUN_7732C((ushort)screen.x, (ushort)screen.z, (byte)DAT_48);
        sVar3 = GameManager.instance.FUN_7732C((ushort)oVar1.screen.x, (ushort)oVar1.screen.z, (byte)oVar1.DAT_48);

        if (sVar2 == BDAT_1C0)
        {
            if (DAT_1C1 == sVar2 || sVar3 == DAT_1C1)
                goto LAB_2B6D8;
        }

        DAT_1E2 = 0;
        DAT_1C6 = 1;
        FUN_2B3EC();
        BDAT_1C0 = (byte)sVar2;
        LAB_2B6D8:
        DAT_1C1 = sVar3;
    }

    private void FUN_3021C()
    {
        ushort uVar1;

        uVar1 = (ushort)(DAT_3C | DAT_3D << 8);

        if (uVar1 != 0xb01 && uVar1 != 0xc01 && uVar1 != 0xf01 &&
            uVar1 != 0x1001 && uVar1 != 0x1101 && uVar1 != 0x1301 &&
            uVar1 != 0x1501 && uVar1 != 0x1601 && uVar1 != 0x1e01 &&
            uVar1 != 0x1f01 && uVar1 != 0x2401) 
            FUN_3031C();
    }

    private void FUN_3029C()
    {
        ushort uVar1;

        uVar1 = (ushort)(DAT_3C | DAT_3D << 8);

        if (uVar1 == 0xb01 || uVar1 == 0xc01 || uVar1 == 0xf01 ||
            uVar1 == 0x1001 || uVar1 == 0x1101 || uVar1 == 0x1301 ||
            uVar1 == 0x1501 || uVar1 == 0x1601 || uVar1 == 0x1e01 ||
            uVar1 == 0x1f01 || uVar1 == 0x2401)
            FUN_3031C();
    }

    private void FUN_3031C()
    {
        PTR_FUN_9B980[DAT_3D]();
    }

    private void FUN_30358()
    {
        FUN_3021C();
        PTR_FUN_9BA18[DAT_3D]();
        FUN_2EA6C();
    }

    private void FUN_303A8()
    {
        FUN_609C8(5, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
    }

    private void FUN_303F0()
    {
        PTR_FUN_9BAB0[DAT_3E]();
    }

    private void FUN_3042C()
    {
        byte bVar2;
        CriPlayer oVar5;

        if ((DAT_18E & 4) != 0)
            return;

        bVar2 = DAT_1DA;

        if (bVar2 != 0)
        {
            DAT_1DA = (byte)(bVar2 - 1);

            if (bVar2 != 1)
                return;

            DAT_3C = 1;
            DAT_3D = 10;
            DAT_3E = 0;
            DAT_3F = 0;
            return;
        }

        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        //...
    }

    private void FUN_30834()
    {
        uint uVar1;

        uVar1 = SceneManager.instance.FUN_65FD8(this);
        uVar1 &= 0xff;
        uVar1 = uVar1 - (((uint)((ulong)uVar1 * 0xcccccccd >> 0x20) & 0xfffffffc) + uVar1 / 5) & 0xff;
        FUN_6103C(0, 1, (byte)(uVar1 * 5), 5);
        DAT_60 = Utilities.DAT_9BAB8[uVar1];
        GameManager.instance.FUN_5C94C(this, 53);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_208 &= 0xfffffffe;
        DAT_3E++;
    }

    private void FUN_308EC()
    {
        ushort uVar1;

        FUN_60AB4();
        uVar1 = DAT_60;

        if (uVar1 == 4)
            GameManager.instance.FUN_5C94C(this, 53);

        if (uVar1 == 0x10)
            GameManager.instance.FUN_5C94C(this, 54);

        if (DAT_60 == 0x19)
            GameManager.instance.FUN_5C94C(this, 55);

        if ((DAT_18E & 0x10) != 0)
            ; //FUN_2F9A0
    }

    private void FUN_30984()
    {
        PTR_FUN_9BB70[DAT_3E]();
    }

    private void FUN_309C0()
    {
        sbyte sVar2;
        ushort uVar3;
        ushort uVar4;
        short sVar5;
        uint uVar6;
        uint uVar7;
        int iVar8;
        CriPlayer oVar8;
        Vector3Int local_20;
        Vector2Int auStack24;

        oVar8 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        auStack24 = new Vector2Int();
        uVar3 = (ushort)FUN_64804(oVar8.screen);
        uVar4 = (ushort)(SDAT_1FC - 1);
        uVar7 = 0;

        if (0 < SDAT_1FC)
        {
            SDAT_1FC = (short)uVar4;

            if (uVar4 << 0x10 < 1 && Utilities.DAT_9B560[DAT_2F] < UDAT_20C)
            {
                uVar6 = GameManager.FUN_64650();

                if ((uVar6 & 1) != 0 && DAT_2F / 3 != 0)
                {
                    DAT_1C2 = 3;
                    return;
                }

                DAT_1C2 = 1;
                DAT_3C = 1;
                DAT_3D = 9;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_208 |= 0x4000000;
                V2_1F0 = new Vector2Int(oVar8.screen.x, oVar8.screen.z);
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                goto LAB_30CC4;
            }
        }

        if (UDAT_1E0 < UDAT_20C)
        {
            uVar6 = GameManager.FUN_64650();

            if ((uVar6 & 1) != 0 && DAT_2F / 3 != 0)
            {
                DAT_1C2 = 3;
                return;
            }

            DAT_1C2 = 1;
            DAT_3C = 1;
            DAT_3D = 9;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_208 |= 0x4000000;
            V2_1F0 = new Vector2Int(oVar8.screen.x, oVar8.screen.z);
            V2_1F4 = new Vector2Int(screen.x, screen.z);
            goto LAB_30CC4;
        }

        if ((GameManager.instance.DAT_922C & 2) == 0 && (oVar8.DAT_11E & 0x80) == 0)
        {
            if (2499 < UDAT_20C || (uVar3 - 0x200) < 0xc01U)
            {
                if (!(2499 < UDAT_20C)) uVar7 = 0x1501;

                if (1999U < UDAT_20C)
                    if (FUN_30BDC()) goto LAB_30CCC;

                uVar7 = 0x1001;

                if ((uVar3 & 0x800) == 0)
                    uVar7 = 0x1101;
            }
        }
        else if (FUN_30BDC()) goto LAB_30CCC;

        DAT_3C = (byte)uVar7;
        DAT_3D = (byte)(uVar7 >> 8);
        DAT_3E = (byte)(uVar7 >> 0x10);
        DAT_3F = (byte)(uVar7 >> 0x18);
        LAB_30CC4:
        FUN_65CF8(0, 0, 30);
        LAB_30CCC:
        return;

        bool FUN_30BDC()
        {
            sVar2 = SceneManager.instance.FUN_64D20(this, oVar8.screen, ref auStack24);

            if (sVar2 == 0 || sVar2 == -1 || 
               (iVar8 = (int)GameManager.FUN_64650()) != (iVar8 / 5) * 5)
            {
                local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
                sVar5 = FUN_64804(local_20);
                uVar7 = 0x701;

                if (0x400U < (ushort)(sVar5 - 0x600))
                {
                    uVar7 = 0x801;

                    if (0x1ffU < (ushort)(sVar5 - 0x400) && 0x1ffU < (ushort)(sVar5 - 0xa01))
                    {
                        return true;
                    }
                }
            }
            else
            {
                uVar7 = 0x501;

                if ((DAT_18E & 0x20) != 0)
                {
                    local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
                    sVar5 = FUN_64804(local_20);
                    uVar7 = 0x701;

                    if (0x400U < (ushort)(sVar5 - 0x600))
                    {
                        uVar7 = 0x801;

                        if (0x1ffU < (ushort)(sVar5 - 0x400) && 0x1ffU < (ushort)(sVar5 - 0xa01))
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }

    private void FUN_30CE0()
    {
        sbyte sVar2;
        ushort uVar3;
        ushort uVar4;
        short sVar5;
        uint uVar6;
        uint uVar7;
        int iVar8;
        CriPlayer oVar8;
        int iVar9;
        Vector3Int local_20;
        Vector2Int auStack24;

        oVar8 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        uVar3 = (ushort)FUN_64804(oVar8.screen);
        uVar4 = (ushort)(SDAT_1FC - 1);
        uVar7 = 0; //not in the original code

        if (SDAT_1FC < 1 || 0 < (SDAT_1FC = (short)uVar4) << 0x10 || 
            UDAT_20C <= Utilities.DAT_9B560[DAT_2F])
        {
            iVar9 = DAT_2F;

            if (Utilities.DAT_9BB78[iVar9] < UDAT_20C)
            {
                DAT_1C2 = 1;
                DAT_3C = 1;
                DAT_3D = 9;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_208 |= 0x4000000;
                V2_1F0 = new Vector2Int(oVar8.screen.x, oVar8.screen.z);
                V2_1F4 = new Vector2Int(screen.x, screen.z);
            }
            else
            {
                if (Utilities.DAT_9BB8C[iVar9] <= UDAT_20C || uVar3 - 0x200U < 0xc01)
                {
                    if (Utilities.DAT_9BB8C[iVar9] > UDAT_20C)
                        uVar7 = 0x501;

                    if ((GameManager.instance.DAT_922C & 2) == 0 && 
                        (oVar8.DAT_11E & 0x80) == 0 && UDAT_20C < 2000)
                    {
                        uVar7 = 0x1001;

                        if ((uVar3 & 0x800) == 0)
                            uVar7 = 0x1101;
                    }
                    else
                    {
                        auStack24 = new Vector2Int();
                        sVar2 = SceneManager.instance.FUN_64D20(this, oVar8.screen, ref auStack24);

                        if (sVar2 == 0 || sVar2 == -1 || (iVar8 = (int)GameManager.FUN_64650()) != (iVar8 / 5) * 5)
                        {
                            local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
                            sVar5 = FUN_64804(local_20);
                            uVar7 = 0x701;

                            if (0x400U < (ushort)(sVar5 - 0x600))
                            {
                                uVar7 = 0x801;

                                if (0x1ffU < (ushort)(sVar5 - 0x400) && 0x1ffU < (ushort)(sVar5 - 0xa01))
                                    return;
                            }
                        }
                        else
                        {
                            uVar7 = 0x501;

                            if ((DAT_18E & 0x20) != 0)
                            {
                                local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
                                sVar5 = FUN_64804(local_20);
                                uVar7 = 0x701;

                                if (0x400U < (ushort)(sVar5 - 0x600))
                                {
                                    uVar7 = 0x801;

                                    if (0x1ffU < (ushort)(sVar5 - 0x400) && 0x1ffU < (ushort)(sVar5 - 0xa01))
                                        return;
                                }
                            }
                        }
                    }
                }

                DAT_3C = (byte)uVar7;
                DAT_3D = (byte)(uVar7 >> 8);
                DAT_3E = (byte)(uVar7 >> 0x10);
                DAT_3F = (byte)(uVar7 >> 0x18);
            }
        }
        else
        {
            uVar6 = GameManager.FUN_64650();

            if ((uVar6 & 1) != 0 && DAT_2F / 3 != 0)
            {
                DAT_1C2 = 3;
                return;
            }

            DAT_1C2 = 1;
            DAT_3C = 1;
            DAT_3D = 9;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_208 |= 0x4000000;
            V2_1F0 = new Vector2Int(oVar8.screen.x, oVar8.screen.z);
            V2_1F4 = new Vector2Int(screen.x, screen.z);
        }

        FUN_65CF8(0, 0, 30);
    }

    private void FUN_30FF0()
    {
        sbyte sVar2;
        ushort uVar3;
        short sVar4;
        int iVar7;
        CriPlayer oVar7;
        uint uVar5;
        uint uVar6;
        Vector3Int local_20;
        Vector2Int auStack24;

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        uVar5 = (ushort)FUN_64804(oVar7.screen);
        uVar3 = (ushort)(SDAT_1FC - 1);

        if (SDAT_1FC < 1 || 0 < (SDAT_1FC = (short)uVar3) << 0x10 || 
            UDAT_20C <= Utilities.DAT_9B560[DAT_2F])
        {
            if (UDAT_1E0 < UDAT_20C)
            {
                uVar5 = GameManager.FUN_64650();

                if ((uVar5 & 1) != 0 && DAT_2F / 3 != 0)
                {
                    DAT_1C2 = 3;
                    return;
                }

                DAT_1C2 = 1;
                DAT_3C = 1;
                DAT_3D = 9;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_208 |= 0x4000000;
                V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                V2_1F4 = new Vector2Int(screen.x, screen.z);
            }
            else
            {
                if ((GameManager.instance.DAT_922C & 2) == 0 && 
                    (oVar7.DAT_11E & 0x80) == 0 && UDAT_20C < 2000)
                {
                    uVar6 = 0x1001;

                    if ((uVar5 & 0x800) == 0)
                        uVar6 = 0x1101;
                }
                else
                {
                    auStack24 = new Vector2Int();
                    sVar2 = SceneManager.instance.FUN_64D20(this, oVar7.screen, ref auStack24);

                    if (sVar2 == 0 || sVar2 == -1 || (iVar7 = (int)GameManager.FUN_64650()) != (iVar7 / 5) * 5)
                    {
                        local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
                        sVar4 = FUN_64804(local_20);
                        uVar6 = 0x701;

                        if (0x400U < (ushort)(sVar4 - 0x600))
                        {
                            uVar6 = 0x801;

                            if (0x1ffU < (ushort)(sVar4 - 0x400) && 0x1ffU < (ushort)(sVar4 - 0xa01))
                                return;
                        }
                    }
                    else
                    {
                        uVar6 = 0x501;

                        if ((DAT_18E & 0x20) != 0)
                        {
                            local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
                            sVar4 = FUN_64804(local_20);
                            uVar6 = 0x701;

                            if (0x400U < (ushort)(sVar4 - 0x600))
                            {
                                uVar6 = 0x801;

                                if (0x1ffU < (ushort)(sVar4 - 0x400) && 0x1ffU < (ushort)(sVar4 - 0xa01))
                                    return;
                            }
                        }
                    }
                }

                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
            }
        }
        else
        {
            uVar5 = GameManager.FUN_64650();

            if ((uVar5 & 1) != 0 && DAT_2F / 3 != 0)
            {
                DAT_1C2 = 3;
                return;
            }

            DAT_1C2 = 1;
            DAT_3C = 1;
            DAT_3D = 9;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_208 |= 0x4000000;
            V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
            V2_1F4 = new Vector2Int(screen.x, screen.z);
        }

        FUN_65CF8(0, 0, 30);
    }

    private void FUN_312EC()
    {
        sbyte sVar2;
        ushort uVar3;
        ushort uVar4;
        short sVar5;
        int iVar7;
        CriPlayer oVar7;
        uint uVar6;
        int iVar8;
        uint uVar9;
        Vector2Int auStack24;
        Vector3Int local_20;

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        uVar3 = (ushort)FUN_64804(oVar7.screen);
        uVar4 = (ushort)(SDAT_1FC - 1);

        if (SDAT_1FC < 1 || 0 < (SDAT_1FC = (short)uVar4) << 0x10 || 
            UDAT_20C < Utilities.DAT_9BBB4[DAT_2F])
        {
            uVar9 = UDAT_20C;
            iVar8 = DAT_2F;
            uVar6 = 0x301;

            if (uVar9 < Utilities.DAT_9BBA0[iVar8])
            {
                if (uVar9 < Utilities.DAT_9BBB4[iVar8] && 3500 < uVar9)
                {
                    if (0xe00 < uVar3 - 0x100U)
                    {
                        DAT_3C = 1;
                        DAT_3D = 9;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                        V2_1F4 = new Vector2Int(screen.x, screen.z);
                        goto LAB_315C4;
                    }

                    uVar9 = UDAT_20C;
                }

                if (uVar9 < 3500)
                {
                    iVar7 = (int)GameManager.FUN_64650();

                    if (iVar7 == (iVar7 / 3) * 3)
                    {
                        DAT_1C2 = 2;
                        return;
                    }

                    DAT_1C2 = 0;
                    return;
                }

                if ((GameManager.instance.DAT_922C & 2) == 0 &&
                    (oVar7.DAT_11E & 0x80) == 0 && uVar9 < 2000)
                {
                    uVar6 = 0x1001;

                    if ((uVar3 & 0x800) == 0)
                        uVar6 = 0x1101;
                }
                else
                {
                    auStack24 = new Vector2Int();
                    sVar2 = SceneManager.instance.FUN_64D20(this, oVar7.screen, ref auStack24);

                    if (sVar2 == 0 || sVar2 == -1 || (iVar7 = (int)GameManager.FUN_64650()) != (iVar7 / 5) * 5)
                    {
                        local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
                        sVar5 = FUN_64804(local_20);
                        uVar6 = 0x701;

                        if (0x400U < (ushort)(sVar5 - 0x600))
                        {
                            uVar6 = 0x801;

                            if (0x1ffU < (ushort)(sVar5 - 0x400) && 0x1ffU < (ushort)(sVar5 - 0xa01))
                                return;
                        }
                    }
                    else
                    {
                        uVar6 = 0x501;

                        if ((DAT_18E & 0x20) != 0)
                        {
                            local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
                            sVar5 = FUN_64804(local_20);
                            uVar6 = 0x701;

                            if (0x400U < (ushort)(sVar5 - 0x600))
                            {
                                uVar6 = 0x801;

                                if (0x1ffU < (ushort)(sVar5 - 0x400) && 0x1ffU < (ushort)(sVar5 - 0xa01))
                                    return;
                            }
                        }
                    }
                }
            }

            DAT_3C = (byte)uVar6;
            DAT_3D = (byte)(uVar6 >> 8);
            DAT_3E = (byte)(uVar6 >> 0x10);
            DAT_3F = (byte)(uVar6 >> 0x18);
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 9;
            DAT_3E = 0;
            DAT_3F = 0;
            V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
            V2_1F4 = new Vector2Int(screen.x, screen.z);
        }

        LAB_315C4:
        FUN_65CF8(0, 0, 30);
    }

    private void FUN_315E0()
    {
        CriPlayer oVar1;
        ushort uVar2;
        short sVar3;
        uint uVar4;
        Vector3Int local_18;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        uVar2 = (ushort)FUN_64804(oVar1.screen);

        if ((GameManager.instance.DAT_922C & 2) == 0 && (oVar1.DAT_11E & 0x80) == 0)
        {
            if (UDAT_20C < 2500)
            {
                uVar4 = 0x1501;

                if (0xc00U < uVar2 - 0x200) goto LAB_31710;

                if (UDAT_20C < 2000)
                {
                    uVar4 = 0x1001;

                    if ((uVar2 & 0x800) == 0)
                        uVar4 = 0x1101;

                    goto LAB_31710;
                }
            }
        }

        if (UDAT_20C <= 5000)
        {
            local_18 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
            sVar3 = FUN_64804(local_18);
            uVar4 = 0x701;

            if (0x400U < (ushort)(sVar3 - 0x600))
            {
                uVar4 = 0x801;

                if (0x1ffU < (ushort)(sVar3 - 0x400) &&
                    0x1ffU < (ushort)(sVar3 - 0xa01))
                    return;
            }
        }
        else
            uVar4 = 0x301;

        LAB_31710:
        DAT_3C = (byte)uVar4;
        DAT_3D = (byte)(uVar4 >> 8);
        DAT_3E = (byte)(uVar4 >> 0x10);
        DAT_3F = (byte)(uVar4 >> 0x18);
        FUN_65CF8(0, 0, 30);
    }

    private void FUN_31740()
    {
        byte bVar1;
        ushort uVar2;
        int iVar3;

        if ((SceneManager.instance.DAT_27C[10].DAT_11E & 0x80) == 0 && 
            (DAT_208 & 0x80000) == 0)
        {
            bVar1 = (byte)(DAT_1C8 - 1);

            if (0 < DAT_1C8)
            {
                DAT_1C8 = (sbyte)bVar1;

                if (0 < bVar1 << 0x18)
                    return;

                DAT_1C8 = 0;
            }

            uVar2 = (ushort)(DAT_1FE - 1);

            if (0 < DAT_1FE)
            {
                DAT_1FE = (short)uVar2;

                if (uVar2 << 0x10 < 1)
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    DAT_1FE = (short)(iVar3 + (iVar3 / 30) * -30 + 120);

                    if (3500 < UDAT_20C)
                    {
                        DAT_3C = 1;
                        DAT_3D = 6;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        return;
                    }
                }

                if (DAT_1C5 == 0)
                    FUN_315E0();
                else
                    PTR_FUN_9BBC8[DAT_1C2]();
            }
        }
    }

    private void FUN_31868()
    {
        FUN_609C8(5, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);

        if ((DAT_208 & 0x800000) == 0)
            FUN_65CF8(1, 0, 30);
        else
            DAT_208 &= 0xff7fffff;

        FUN_2B4E8();
        DAT_3E++;
    }

    private void FUN_318F4()
    {
        ushort uVar1;
        short sVar1;
        int iVar2;
        CriPlayer oVar2;
        int iVar3;
        int iVar4;
        uint uVar5;
        int iVar6;
        Vector3Int psVar7;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        FUN_60AB4();
        uVar1 = DAT_60;

        if (uVar1 == 7)
            GameManager.instance.FUN_5C94C(this, 48);

        if (uVar1 == 50)
            GameManager.instance.FUN_5C94C(this, 49);

        if (DAT_60 == 2)
        {
            iVar3 = (int)GameManager.FUN_64650();
            uVar5 = (uint)(iVar3 % 3 & 0xff);

            if (uVar5 == 1)
                iVar6 = 70;
            else
            {
                iVar6 = 71;

                if (uVar5 != 2) goto LAB_319AC;
            }

            GameManager.instance.FUN_5C94C(this, iVar6);
        }

        LAB_319AC:
        FUN_2B57C();
        uVar5 = DAT_60;
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (uVar5 < 6 || uVar5 - 26 < 24 || uVar5 - 66 < 18)
        {
            local_48 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);

            if (DAT_1C6 != 0)
            {
                local_40 = new Vector3Int(0, 0, (short)DAT_206);
                local_38 = new Vector3Int(0, (short)UDAT_204, 0);
                MStack48 = new Matrix3x3();
                Utilities.RotMatrix(ref local_38, ref MStack48);
                local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
                local_48.x += local_40.x;
                local_48.z += local_40.z;
            }

            sVar1 = FUN_64804(local_48);
            iVar3 = 20;

            if ((ushort)(sVar1 - 0x401) < 0x7ffU)
                iVar3 = 80;

            if (oVar2.DAT_3C == 5 && oVar2.DAT_3D == 10)
                psVar7 = oVar2.screen;
            else
                psVar7 = local_48;

            iVar2 = Utilities.FUN_615EC(screen, psVar7);
            iVar4 = (int)GameManager.FUN_64650();
            sVar1 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar3 + iVar4 % 0xf) * 0x10000 >> 0x10), iVar2);
            vr.y = vr.y + sVar1 & 0xfff;
            DAT_40.z = Utilities.DAT_9BBD8[DAT_60];
        }
        else
            DAT_40.z = 0;
    }

    private void FUN_31B60()
    {
        PTR_FUN_9BC80[DAT_3E]();
    }

    private void FUN_31B9C()
    {
        sbyte sVar2;
        short sVar3;
        int iVar4;
        CriPlayer oVar4;
        uint uVar5;
        Vector2Int auStack24;
        Vector3Int local_20;

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_1C5 == 0)
        {
            if (UDAT_20C < Utilities.DAT_9BC88[DAT_2F])
            {
                DAT_3C = 1;
                DAT_3D = 0x16;
                DAT_3E = 0;
                DAT_3F = 0;
                return;
            }
        }
        else
        {
            sVar3 = FUN_64804(oVar4.screen);

            if (UDAT_20C < Utilities.DAT_9BC9C[DAT_2F] && 0xe00U < (ushort)(sVar3 - 0x100))
            {
                DAT_3C = 1;
                DAT_3D = 9;
                DAT_3E = 0;
                DAT_3F = 0;
                V2_1F0 = new Vector2Int(oVar4.screen.x, oVar4.screen.z);
                V2_1F4 = new Vector2Int(screen.x, screen.z);
            }
        }

        auStack24 = new Vector2Int();
        sVar2 = SceneManager.instance.FUN_64D20(this, oVar4.screen, ref auStack24);

        if (sVar2 == 0 || sVar2 == -1 || (iVar4 = (int)GameManager.FUN_64650()) != (iVar4 / 5) * 5)
        {
            local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
            sVar3 = FUN_64804(local_20);
            uVar5 = 0x401;

            if (0x800U < (ushort)(sVar3 - 0x400))
                return;
        }
        else
        {
            uVar5 = 0x501;

            if (DAT_1C5 == 0)
            {
                local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
                sVar3 = FUN_64804(local_20);
                uVar5 = 0x401;

                if (0x800U < (ushort)(sVar3 - 0x400))
                    return;
            }
        }

        DAT_3C = (byte)uVar5;
        DAT_3D = (byte)(uVar5 >> 8);
        DAT_3E = (byte)(uVar5 >> 0x10);
        DAT_3F = (byte)(uVar5 >> 0x18);
        FUN_65CF8(0, 0, 30);
    }

    private void FUN_31D3C()
    {
        FUN_609C8(23, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 50);
        FUN_65CF8(1, 0, 30);
        FUN_2B4E8();
        DAT_3E++;
    }

    private void FUN_31DA8()
    {
        short sVar1;
        ushort uVar2;
        int iVar3;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        FUN_60AB4();
        uVar2 = DAT_60;

        if (uVar2 == 2)
            GameManager.instance.FUN_5C94C(this, 48);

        if (uVar2 == 15)
            GameManager.instance.FUN_5C94C(this, 49);

        DAT_40.z = Utilities.DAT_9BCB0[DAT_60];
        FUN_2B57C();
        local_48 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);

        if (DAT_1C6 != 0)
        {
            local_40 = new Vector3Int(0, 0, (short)DAT_206);
            local_38 = new Vector3Int(0, (short)UDAT_204, 0);
            MStack48 = new Matrix3x3();
            Utilities.RotMatrix(ref local_38, ref MStack48);
            local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
            local_48.x += local_40.x;
            local_48.z += local_40.z;
        }

        sVar1 = (short)Utilities.FUN_615EC(screen, local_48);
        iVar3 = (int)GameManager.FUN_64650();
        uVar2 = (ushort)Utilities.FUN_64838(vr.y, (uint)((iVar3 % 15 + 50) * 0x10000 >> 0x10), sVar1);
        vr.y = (short)(vr.y + uVar2 & 0xfff);
    }

    private void FUN_31F30()
    {
        PTR_FUN_9BCE0[DAT_3E]();
    }

    private void FUN_31F6C()
    {
        FUN_609C8(7, 1, 10);
        GameManager.instance.FUN_5C94C(this, 48);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
    }

    private void FUN_31FC0()
    {
        sbyte sVar1;
        short sVar2;
        bool bVar3;
        uint uVar4;
        CriPlayer oVar4;
        Vector3Int local_20;
        Vector2Int auStack24;

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar3 = FUN_60AB4();

        if (bVar3)
        {
            auStack24 = new Vector2Int();
            sVar1 = SceneManager.instance.FUN_64D20(this, oVar4.screen, ref auStack24);

            if (sVar1 == 0)
                local_20 = oVar4.screen;
            else
                local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);

            sVar2 = FUN_64804(local_20);

            if ((ushort)(sVar2 - 0x300) < 0xa01U)
            {
                uVar4 = 0x701;

                if (0x400U < (ushort)(sVar2 - 0x600))
                    uVar4 = 0x801;
            }
            else
                uVar4 = 0x201;

            DAT_3C = (byte)uVar4;
            DAT_3D = (byte)(uVar4 >> 8);
            DAT_3E = (byte)(uVar4 >> 0x10);
            DAT_3F = (byte)(uVar4 >> 0x18);
        }

        if (DAT_60 < 11U)
            DAT_40.z = 0x30;
        else
            DAT_40.z = 0;
    }

    private void FUN_320AC()
    {
        PTR_FUN_9BCE8[DAT_3E]();
    }

    private void FUN_320E8()
    {
        CriPlayer oVar1;
        short sVar2;
        uint uVar3;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (UDAT_20C < 3500)
        {
            sVar2 = FUN_64804(oVar1.screen);

            if ((ushort)(sVar2 - 0x201) < 0xbffU || (GameManager.instance.DAT_922C & 2) != 0 || 
                (oVar1.DAT_11E & 0x80) != 0)
            {
                uVar3 = 0x701;

                if (0x400U < (ushort)(sVar2 - 0x600))
                {
                    uVar3 = 0x801;

                    if (0x1ffU < (ushort)(sVar2 - 0x400) && 0x1ffU < (ushort)(sVar2 - 0xa01))
                        return;
                }

                DAT_3C = (byte)uVar3;
                DAT_3D = (byte)(uVar3 >> 8);
                DAT_3E = (byte)(uVar3 >> 0x10);
                DAT_3F = (byte)(uVar3 >> 0x18);
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 12;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_1E6 = 100;
                DAT_1E8 = 100;
                DAT_208 &= 0xfffffdff;
            }

            FUN_65CF8(0, 0, 30);
        }
    }

    private void FUN_32214()
    {
        ushort uVar1;
        CriPlayer oVar2;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        uVar1 = (ushort)(oVar2.DAT_3C | oVar2.DAT_3D << 8);

        if (uVar1 == 0x905 || uVar1 == 0xa05 || uVar1 == 0xb05)
        {
            if (uVar1 == 0xb05 && oVar2.DAT_1C8 == 0)
                oVar2.DAT_1C8 = 1;
        }
        else
            FUN_320E8();
    }

    private void FUN_32284()
    {
        PTR_FUN_9BCFC[DAT_2F]();
    }

    private void FUN_322C0(CriPlayer param1)
    {
        sbyte sVar2;
        bool bVar2;
        Vector2Int auStack24;

        auStack24 = new Vector2Int();
        sVar2 = SceneManager.instance.FUN_64D20(this, param1.screen, ref auStack24);

        if ((GameManager.instance.DAT_922C & 2) == 0 || GameManager.instance.DAT_9230 == this)
        {
            if (UDAT_20C <= 4500 && sVar2 == 0)
            {
                bVar2 = FUN_2E284();

                if (!bVar2 && (param1.DAT_11E & 0x80) == 0)
                {
                    DAT_3C = 1;
                    DAT_3D = 12;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_1E6 = 100;
                    DAT_1E8 = 100;
                    DAT_208 &= 0xfffffdff;
                    GameManager.instance.FUN_65C7C(this);
                }
                else
                {
                    DAT_3C = 1;
                    DAT_3D = 2;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    GameManager.instance.FUN_65CB0(this);
                }
            }
            else
            {
                if (sVar2 == -1 || (DAT_18E & 0x20) != 0 || !FUN_40834(auStack24, (byte)sVar2))
                {
                    DAT_3C = 1;
                    DAT_3D = 9;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    V2_1F0 = new Vector2Int(param1.screen.x, param1.screen.z);
                    V2_1F4 = new Vector2Int(screen.x, screen.z);
                    DAT_208 &= 0xfbffffff;
                }
            }
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 0x16;
            DAT_3E = 0;
            DAT_3F = 0;
        }

        FUN_65CF8(0, 0, 30);
    }

    private void FUN_32448(CriPlayer param1)
    {
        CriPlayer oVar2;
        sbyte sVar3;
        bool bVar3;
        Vector2Int auStack24;

        auStack24 = new Vector2Int();
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        sVar3 = SceneManager.instance.FUN_64D20(this, param1.screen, ref auStack24);

        if ((GameManager.instance.DAT_922C & 2) != 0 && GameManager.instance.DAT_9230 != this)
        {
            DAT_3C = 1;
            DAT_3D = 0x16;
            DAT_3E = 0;
            DAT_3F = 0;
            goto LAB_32698;
        }

        if (((param1.DAT_3C == 5 && param1.DAT_3D == 9) || (param1.DAT_3C == 5 && param1.DAT_3D == 10)) && 
            param1.DAT_1F0 == this)
        {
            if (2200 < UDAT_20C)
            {
                DAT_3C = 1;
                DAT_3D = 9;
                DAT_3E = 0;
                DAT_3F = 0;
                V2_1F0 = new Vector2Int(param1.screen.x, param1.screen.z);
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                goto LAB_32698;
            }

            DAT_3C = 1;
            DAT_3D = 0x16;
            DAT_3E = 0;
            DAT_3F = 0;
            BDAT_1CA = 0;
            V2_1F0 = new Vector2Int(oVar2.screen.x, oVar2.screen.z);
            FUN_2E07C();
        }
        else
        {
            if (param1.DAT_1C8 == 0)
            {
                if (4500 < UDAT_20C || sVar3 != 0)
                {
                    if (sVar3 != -1 || (DAT_18E & 0x20) != 0 || !FUN_40834(auStack24, (byte)sVar3))
                    {
                        DAT_3C = 1;
                        DAT_3D = 9;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        V2_1F0 = new Vector2Int(param1.screen.x, param1.screen.z);
                        V2_1F4 = new Vector2Int(screen.x, screen.z);
                        DAT_208 &= 0xfbffffff;
                    }

                    goto LAB_32698;
                }

                bVar3 = FUN_2E284();

                if (!bVar3 && (param1.DAT_11E & 0x80) == 0)
                {
                    DAT_3C = 1;
                    DAT_3D = 12;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_1E6 = 100;
                    DAT_1E8 = 100;
                    DAT_208 &= 0xfffffdff;
                    GameManager.instance.FUN_65C7C(this);
                    goto LAB_32698;
                }

                DAT_3C = 1;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 0x16;
                DAT_3E = 0;
                DAT_3F = 0;
                BDAT_1CA = 0;
                V2_1F0 = new Vector2Int(oVar2.screen.x, oVar2.screen.z);
                param1.DAT_1C8 = 0;
                FUN_2E07C();
            }
        }

        GameManager.instance.FUN_65CB0(this);
        LAB_32698:
        FUN_65CF8(0, 0, 30);
    }

    private void FUN_326BC()
    {
        int iVar1;

        if ((DAT_208 & 0x100) == 0)
            iVar1 = 8;
        else
            iVar1 = 9;

        FUN_609C8(iVar1, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_65CF8(6, 0, 30);
        DAT_3E++;
    }

    private void FUN_32734()
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        int iVar4;
        uint uVar6;
        CriPlayer oVar11;

        oVar11 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar3 = FUN_60AB4();

        if (bVar3)
            PTR_FUN_9BD14[DAT_2F](oVar11);

        if (DAT_60 == 20)
            GameManager.instance.FUN_5C94C(this, 50);

        uVar6 = DAT_2F;

        if (uVar6 / 3 != 0 && (uVar6 - (((uint)((ulong)uVar6 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar6 / 3) & 0xff) != 2)
        {
            if (DAT_60 - 2U < 0x19)
                DAT_40.z = Utilities.DAT_184F0[DAT_60 - 2] << 1;
            else
                DAT_40.z = 0;
        }

        sVar1 = (short)Utilities.FUN_615EC(screen, oVar11.screen);
        iVar4 = (int)GameManager.FUN_64650();
        sVar2 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar4 % 15 + 20) * 0x10000 >> 0x10), sVar1);
        vr.y = (short)(vr.y + sVar2 & 0xfff);
    }

    private void FUN_32950()
    {
        PTR_FUN_9BD38[DAT_3E]();
    }

    private void FUN_3298C()
    {
        FUN_609C8(10, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_65CF8(1, 0, 30);
        DAT_3E++;
    }

    private void FUN_329EC()
    {
        ushort uVar1;
        short sVar1;
        short sVar2;
        bool bVar3;
        int iVar3;
        int iVar4;
        CriPlayer oVar4;
        Vector3Int puVar5;
        Vector3Int local_18;

        bVar3 = FUN_60AB4();
        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (bVar3)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_65CF8(0, 0, 30);
        }

        uVar1 = DAT_60;

        if (uVar1 == 37)
            GameManager.instance.FUN_5C94C(this, 50);

        if (uVar1 == 7)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 50)
            GameManager.instance.FUN_5C94C(this, 49);

        if (DAT_60 - 32U < 19 || DAT_60 - 80U < 19)
        {
            local_18 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
            iVar3 = 20;
            sVar1 = FUN_64804(local_18);

            if ((ushort)(sVar1 - 0x401) < 0x7ffU)
                iVar3 = 80;

            local_18 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);

            if (oVar4.DAT_3C == 5 && oVar4.DAT_3D == 10)
                puVar5 = oVar4.screen;
            else
                puVar5 = local_18;

            sVar2 = (short)Utilities.FUN_615EC(screen, puVar5);
            iVar4 = (int)GameManager.FUN_64650();
            sVar1 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar3 + iVar4 & 15) * 0x10000 >> 0x10), sVar2);
            DAT_40.z = 45;
            vr.y = (short)(vr.y + sVar1 & 0xfff);
        }
        else
            DAT_40.z = 0;
    }

    private void FUN_32BAC()
    {
        PTR_FUN_9BD40[DAT_3E]();
    }

    private void FUN_32BE8()
    {
        short sVar1;
        short sVar2;
        int iVar3;
        Vector3Int local_10;

        FUN_609C8(12, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        local_10 = new Vector3Int(-500, 0, 500);
        local_10 = Utilities.ApplyMatrixSV(ref cTransform.rotation, ref local_10);
        screen.x -= local_10.x;
        local_10.x = DAT_10C.x;
        screen.z -= local_10.z;
        local_10.y = 0;
        local_10.z = DAT_10C.z;
        sVar1 = FUN_64804(local_10);
        iVar3 = sVar1 - 0x800;
        DAT_1EC = sVar1;

        if (iVar3 < 0)
            iVar3 = sVar1 - 2017;

        sVar1 = (short)vr.y;
        sVar2 = (short)(iVar3 >> 5);
        DAT_1EE = sVar2;
        vr.y = sVar1 + sVar2 & 0xfff;
        FUN_65CF8(0, 0, 30);
        DAT_3E++;
    }

    private void FUN_32CDC()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (!bVar1)
        {
            vr.y = (short)(vr.y + DAT_1EE & 0xfff);

            if (DAT_60 == 14)
                GameManager.instance.FUN_5C94C(this, 48);

            if (DAT_60 == 20)
                GameManager.instance.FUN_5C94C(this, 49);

            if (DAT_60 == 29)
                GameManager.instance.FUN_5C94C(this, 48);
        }
        else
        {
            if ((DAT_208 & 0x1000) == 0 || (DAT_18E & 8) != 0)
            {
                DAT_3C = 1;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 29;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_208 &= 0xffffefff;
            }

            vr.y = (short)(vr.y + 0x800 & 0xfff);
        }
    }

    private void FUN_32DD0()
    {
        PTR_FUN_9BD48[DAT_3E]();
    }

    private void FUN_32E0C()
    {
        short sVar1;
        short sVar2;
        Vector3Int local_10;

        FUN_609C8(13, 1, 10);
        local_10 = new Vector3Int(DAT_10C.x, 0, DAT_10C.z);
        DAT_40 = new Vector3Int(0, 0, 0);
        sVar1 = FUN_64804(local_10);

        if ((sVar1 & 0x800) == 0)
            sVar2 = (short)(sVar1 / 30);
        else
            sVar2 = (short)-(((-sVar1 & 0xfff) / 30) * 0x10000 >> 0x10);

        DAT_1EE = sVar2;
        vr.y = (short)(vr.y + DAT_1EE & 0xfff);
        FUN_65CF8(1, 0, 30);
        DAT_3E++;
    }

    private void FUN_32F14()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (!bVar1)
        {
            vr.y = (short)(vr.y + DAT_1EE & 0xfff);

            if (DAT_60 == 12)
                GameManager.instance.FUN_5C94C(this, 48);

            if (DAT_60 == 23)
                GameManager.instance.FUN_5C94C(this, 49);
        }
        else
        {
            if ((DAT_208 & 0x1000) == 0 || (DAT_18E & 8) != 0)
            {
                DAT_3C = 1;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 29;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_208 &= 0xffffefff;
            }

            FUN_65CF8(0, 0, 30);
        }
    }

    private void FUN_32FF0()
    {
        PTR_FUN_9BD50[DAT_3E]();
    }

    private void FUN_3302C()
    {
        CriPlayer oVar2;
        sbyte sVar3;
        bool bVar3;
        uint uVar4;
        bool bVar5;
        uint uVar6;
        uint uVar7;
        Vector2Int auStack32;
        Vector3Int local_30;
        Vector3Int local_28;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_1C2 != 1)
            DAT_1C2 = 1;

        if ((GameManager.instance.DAT_922C & 2) != 0 && GameManager.instance.DAT_9230 != this)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            goto LAB_332C8;
        }

        if ((DAT_128 & 0x3ff) != 0)
        {
            uVar7 = 0;

            if ((DAT_12A & 6) != 0)
            {
                DAT_1C5 = 0;
                uVar4 = DAT_128;

                do
                {
                    if ((uVar4 & 1) != 0) break;

                    uVar7++;
                    uVar4 = (uint)(DAT_128 >> (int)(uVar7 & 0x1f));
                } while (uVar7 < 10);

                ((CriPlayer)SceneManager.instance.DAT_27C[uVar7]).DAT_1C5 = 1;
                DAT_3C = 1;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
                FUN_65CF8(0, 0, 30);
                GameManager.instance.FUN_65CB0(this);
                return;
            }
        }

        auStack32 = new Vector2Int();
        sVar3 = SceneManager.instance.FUN_64D20(this, oVar2.screen, ref auStack32);

        if (DAT_1C2 == 1 && UDAT_20C < 4000)
        {
            bVar5 = Utilities.FUN_64C0C(screen, oVar2.screen, (short)vr.y, 0x80);

            if (!bVar5)
            {
                local_30 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
                local_28 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
                uVar7 = Utilities.FUN_631AC(local_30, local_28);
                uVar4 = Utilities.FUN_631AC(local_30, screen);

                if (uVar7 < uVar4)
                {
                    bVar5 = Utilities.FUN_64C0C(screen, oVar2.screen, (short)vr.y, 0x200);
                    uVar6 = 0x401;

                    if (bVar5)
                    {
                        V2_1F0 = new Vector2Int(oVar2.screen.x, oVar2.screen.z);
                        V2_1F4 = new Vector2Int(screen.x, screen.z);
                        return;
                    }
                }
                else
                {
                    uVar7 = Utilities.FUN_631AC(local_30, oVar2.screen);
                    uVar6 = 0x401;

                    if (uVar4 <= uVar7) goto LAB_332C8;
                }

                goto LAB_332BC;
            }

            if (sVar3 != 0)
                return;

            if ((DAT_208 & 0x4000000) != 0)
            {
                DAT_3C = 1;
                DAT_3D = 5;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_332C8;
            }

            bVar3 = FUN_2E284();
            uVar6 = 0x201;

            if (!bVar3)
            {
                uVar6 = 0x201;

                if ((oVar2.DAT_11E & 0x80) == 0)
                {
                    DAT_3C = 1;
                    DAT_3D = 12;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_1E6 = 100;
                    DAT_1E8 = 100;
                    DAT_208 &= 0xfffffdff;
                    goto LAB_332C8;
                }
            }
        }
        else
        {
            local_30 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
            local_28 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
            uVar7 = Utilities.FUN_631AC(local_30, local_28);
            uVar4 = Utilities.FUN_631AC(local_30, screen);

            if (uVar7 < uVar4)
            {
                bVar5 = Utilities.FUN_64C0C(screen, oVar2.screen, (short)vr.y, 0x200);
                uVar6 = 0x401;

                if (bVar5)
                {
                    V2_1F0 = new Vector2Int(oVar2.screen.x, oVar2.screen.z);
                    V2_1F4 = new Vector2Int(screen.x, screen.z);
                    return;
                }
            }
            else
            {
                uVar7 = Utilities.FUN_631AC(local_30, oVar2.screen);
                uVar6 = 0x401;

                if (uVar4 <= uVar7) goto LAB_332C8;
            }
        }

        LAB_332BC:
        DAT_3C = (byte)uVar6;
        DAT_3D = (byte)(uVar6 >> 8);
        DAT_3E = (byte)(uVar6 >> 0x10);
        DAT_3F = (byte)(uVar6 >> 0x18);
        GameManager.instance.FUN_65CB0(this);
        LAB_332C8:
        FUN_65CF8(0, 0, 30);
    }

    private void FUN_332FC()
    {
        sbyte sVar2;
        byte bVar3;
        uint uVar4;
        bool bVar5;
        uint uVar6;
        bool bVar7;
        CriPlayer oVar7;
        ushort uVar8;
        uint uVar9;
        bool bVar10;
        Vector2Int auStack32;
        Vector3Int local_30;
        Vector3Int local_28;

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_1C2 != 1 && DAT_1C2 != 3)
        {
            if (DAT_2F / 3 == 0)
                DAT_1C2 = 1;
            else
                DAT_1C2 = 3;
        }

        uVar8 = (ushort)(oVar7.DAT_3C | oVar7.DAT_3D << 8);

        if (uVar8 == 0x905 || uVar8 == 0xa05)
        {
            if (oVar7.DAT_1F0 == this)
            {
                if (UDAT_20C - 2201 < 199)
                {
                    DAT_3C = 1;
                    DAT_3D = 0x18;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    oVar7.DAT_11E |= 0x20;
                    return;
                }

                if (2199 < UDAT_20C)
                    return;

                DAT_3C = 1;
                DAT_3D = 0x16;
                DAT_3E = 0;
                DAT_3F = 0;
                V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                GameManager.instance.FUN_65CB0(this);
                return;
            }
        }

        if (uVar8 == 0xb05 && DAT_1C2 != 3)
        {
            if (DAT_2F / 3 == 0)
                DAT_1C2 = 1;
            else
                DAT_1C2 = 3;
        }

        if ((GameManager.instance.DAT_922C & 2) != 0 && GameManager.instance.DAT_9230 != this)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            goto LAB_3377C;
        }

        uVar9 = 0;

        if ((DAT_128 & 0x3ff) != 0 && (DAT_12A & 6) != 0)
        {
            DAT_1C5 = 0;
            uVar4 = DAT_128;

            do
            {
                if ((uVar4 & 1) != 0) break;

                uVar9++;
                uVar4 = (uint)(DAT_128 >> (int)(uVar9 & 0x1f));
            } while (uVar9 < 10);

            ((CriPlayer)SceneManager.instance.DAT_27C[uVar9]).DAT_1C5 = 1;
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_65CF8(0, 0, 30);
            GameManager.instance.FUN_65CB0(this);
            return;
        }

        auStack32 = new Vector2Int();
        sVar2 = SceneManager.instance.FUN_64D20(this, oVar7.screen, ref auStack32);
        bVar3 = DAT_1C2;

        if (bVar3 == 1 && UDAT_20C < 4000)
        {
            bVar5 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x80);

            if (!bVar5)
            {
                if (bVar3 == 3 && UDAT_20C < 3500)
                {
                    uVar6 = 0x401;

                    if ((oVar7.DAT_11E & 0x80) == 0)
                    {
                        bVar7 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x100);

                        if (bVar7)
                        {
                            DAT_3C = 1;
                            DAT_3D = 11;
                            DAT_3E = 0;
                            DAT_3F = 0;
                            goto LAB_3377C;
                        }
                    }

                    DAT_3C = (byte)uVar6;
                    DAT_3D = (byte)(uVar6 >> 8);
                    DAT_3E = (byte)(uVar6 >> 0x10);
                    DAT_3F = (byte)(uVar6 >> 0x18);
                    goto LAB_33774;
                }

                local_30 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
                local_28 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
                uVar9 = Utilities.FUN_631AC(local_30, local_28);
                uVar4 = Utilities.FUN_631AC(local_30, screen);

                if (uVar4 <= uVar9)
                {
                    uVar9 = Utilities.FUN_631AC(local_30, oVar7.screen);

                    if (uVar4 <= uVar9)
                        return;

                    uVar6 = 0x401;

                    if (UDAT_20C < 1200 && (oVar7.DAT_11E & 0x80) == 0)
                    {
                        DAT_3C = 1;
                        DAT_3D = 11;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        goto LAB_3377C;
                    }

                    DAT_3C = (byte)uVar6;
                    DAT_3D = (byte)(uVar6 >> 8);
                    DAT_3E = (byte)(uVar6 >> 0x10);
                    DAT_3F = (byte)(uVar6 >> 0x18);
                    goto LAB_33774;
                }

                bVar5 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x200);

                if (bVar5)
                {
                    V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                    V2_1F4 = new Vector2Int(screen.x, screen.z);
                    return;
                }

                uVar6 = 0x401;

                if (1199 < UDAT_20C)
                {
                    DAT_3C = (byte)uVar6;
                    DAT_3D = (byte)(uVar6 >> 8);
                    DAT_3E = (byte)(uVar6 >> 0x10);
                    DAT_3F = (byte)(uVar6 >> 0x18);
                    goto LAB_33774;
                }

                if ((oVar7.DAT_11E & 0x80) == 0)
                {
                    DAT_3C = 1;
                    DAT_3D = 11;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    goto LAB_3377C;
                }

                DAT_3C = 1;
                DAT_3D = 4;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_33774;
            }

            if (sVar2 != 0)
                return;

            if ((DAT_208 & 0x4000000) != 0)
            {
                DAT_3C = 1;
                DAT_3D = 5;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_3377C;
            }

            bVar10 = FUN_2E284();
            uVar6 = 0x201;

            if (!bVar10 && (oVar7.DAT_11E & 0x80) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 12;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_1E6 = 100;
                DAT_1E8 = 100;
                DAT_208 &= 0xfffffdff;
                goto LAB_3377C;
            }

            DAT_3C = (byte)uVar6;
            DAT_3D = (byte)(uVar6 >> 8);
            DAT_3E = (byte)(uVar6 >> 0x10);
            DAT_3F = (byte)(uVar6 >> 0x18);
        }
        else
        {
            if (bVar3 == 3 && UDAT_20C < 3500)
            {
                uVar6 = 0x401;

                if ((oVar7.DAT_11E & 0x80) == 0)
                {
                    bVar7 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x100);

                    if (bVar7)
                    {
                        DAT_3C = 1;
                        DAT_3D = 11;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        goto LAB_3377C;
                    }
                }

                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
                goto LAB_33774;
            }

            local_30 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
            local_28 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
            uVar9 = Utilities.FUN_631AC(local_30, local_28);
            uVar4 = Utilities.FUN_631AC(local_30, screen);

            if (uVar4 <= uVar9)
            {
                uVar9 = Utilities.FUN_631AC(local_30, oVar7.screen);

                if (uVar4 <= uVar9)
                    return;

                uVar6 = 0x401;

                if (UDAT_20C < 1200 && (oVar7.DAT_11E & 0x80) == 0)
                {
                    DAT_3C = 1;
                    DAT_3D = 11;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    goto LAB_3377C;
                }

                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
                goto LAB_33774;
            }

            bVar5 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x200);

            if (bVar5)
            {
                V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                return;
            }

            uVar6 = 0x401;

            if (1199 < UDAT_20C)
            {
                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
                goto LAB_33774;
            }

            if ((oVar7.DAT_11E & 0x80) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 11;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_3377C;
            }

            DAT_3C = 1;
            DAT_3D = 4;
            DAT_3E = 0;
            DAT_3F = 0;
            goto LAB_33774;
        }

        LAB_33774:
        GameManager.instance.FUN_65CB0(this);
        LAB_3377C:
        FUN_65CF8(0, 0, 30);
    }

    private void FUN_337B0()
    {
        sbyte sVar2;
        byte bVar3;
        uint uVar4;
        bool bVar5;
        uint uVar6;
        bool bVar7;
        CriPlayer oVar7;
        uint uVar8;
        bool bVar9;
        Vector2Int auStack32;
        Vector3Int local_30;
        Vector3Int local_28;

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_1C2 != 1 && DAT_1C2 != 3)
        {
            if (DAT_2F / 3 == 0)
                DAT_1C2 = 1;
            else
                DAT_1C2 = 3;
        }

        if ((GameManager.instance.DAT_922C & 2) != 0 && GameManager.instance.DAT_9230 != this)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            goto LAB_33B44;
        }

        uVar8 = 0;

        if ((DAT_128 & 0x3ff) != 0 && (DAT_12A & 6) != 0)
        {
            DAT_1C5 = 0;
            uVar4 = DAT_128;

            do
            {
                if ((uVar4 & 1) != 0) break;

                uVar8++;
                uVar4 = (uint)(DAT_128 >> (int)(uVar8 & 0x1f));
            } while (uVar8 < 10);

            ((CriPlayer)SceneManager.instance.DAT_27C[uVar8]).DAT_1C5 = 1;
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_65CF8(0, 0, 30);
            GameManager.instance.FUN_65CB0(this);
            return;
        }

        auStack32 = new Vector2Int();
        sVar2 = SceneManager.instance.FUN_64D20(this, oVar7.screen, ref auStack32);
        bVar3 = DAT_1C2;

        if (bVar3 == 1 && UDAT_20C < 4000)
        {
            bVar5 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x80);

            if (!bVar5)
            {
                if (bVar3 == 3 && UDAT_20C < 3500)
                {
                    uVar6 = 0x401;

                    if ((oVar7.DAT_11E & 0x80) == 0)
                    {
                        bVar7 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x100);

                        if (!bVar7)
                        {
                            DAT_3C = 1;
                            DAT_3D = 11;
                            DAT_3E = 0;
                            DAT_3F = 0;
                            goto LAB_33B44;
                        }
                    }

                    DAT_3C = (byte)uVar6;
                    DAT_3D = (byte)(uVar6 >> 8);
                    DAT_3E = (byte)(uVar6 >> 0x10);
                    DAT_3F = (byte)(uVar6 >> 0x18);
                    goto LAB_33B3C;
                }

                local_30 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
                local_28 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
                uVar8 = Utilities.FUN_631AC(local_30, local_28);
                uVar4 = Utilities.FUN_631AC(local_30, screen);

                if (uVar4 <= uVar8)
                {
                    uVar8 = Utilities.FUN_631AC(local_30, oVar7.screen);

                    if (uVar4 <= uVar8)
                        return;

                    uVar6 = 0x401;

                    if (UDAT_20C < 1200 && (oVar7.DAT_11E & 0x80) == 0)
                    {
                        DAT_3C = 1;
                        DAT_3D = 11;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        goto LAB_33B44;
                    }

                    DAT_3C = (byte)uVar6;
                    DAT_3D = (byte)(uVar6 >> 8);
                    DAT_3E = (byte)(uVar6 >> 0x10);
                    DAT_3F = (byte)(uVar6 >> 0x18);
                    goto LAB_33B3C;
                }

                bVar5 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x200);

                if (bVar5)
                {
                    V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                    V2_1F4 = new Vector2Int(screen.x, screen.z);
                    return;
                }

                uVar6 = 0x401;

                if (1199 < UDAT_20C)
                {
                    DAT_3C = (byte)uVar6;
                    DAT_3D = (byte)(uVar6 >> 8);
                    DAT_3E = (byte)(uVar6 >> 0x10);
                    DAT_3F = (byte)(uVar6 >> 0x18);
                    goto LAB_33B3C;
                }

                if ((oVar7.DAT_11E & 0x80) == 0)
                {
                    DAT_3C = 1;
                    DAT_3D = 11;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    goto LAB_33B44;
                }

                DAT_3C = 1;
                DAT_3D = 4;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_33B3C;
            }

            if (sVar2 != 0)
                return;

            if ((DAT_208 & 0x4000000) != 0)
            {
                DAT_3C = 1;
                DAT_3D = 5;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_33B44;
            }

            bVar9 = FUN_2E284();
            uVar6 = 0x201;

            if (!bVar9 && (oVar7.DAT_11E & 0x80) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 12;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_1E6 = 100;
                DAT_1E8 = 100;
                DAT_208 &= 0xfffffdff;
                goto LAB_33B44;
            }

            DAT_3C = (byte)uVar6;
            DAT_3D = (byte)(uVar6 >> 8);
            DAT_3E = (byte)(uVar6 >> 0x10);
            DAT_3F = (byte)(uVar6 >> 0x18);
        }
        else
        {
            if (bVar3 == 3 && UDAT_20C < 3500)
            {
                uVar6 = 0x401;

                if ((oVar7.DAT_11E & 0x80) == 0)
                {
                    bVar7 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x100);

                    if (!bVar7)
                    {
                        DAT_3C = 1;
                        DAT_3D = 11;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        goto LAB_33B44;
                    }
                }

                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
                goto LAB_33B3C;
            }

            local_30 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
            local_28 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
            uVar8 = Utilities.FUN_631AC(local_30, local_28);
            uVar4 = Utilities.FUN_631AC(local_30, screen);

            if (uVar4 <= uVar8)
            {
                uVar8 = Utilities.FUN_631AC(local_30, oVar7.screen);

                if (uVar4 <= uVar8)
                    return;

                uVar6 = 0x401;

                if (UDAT_20C < 1200 && (oVar7.DAT_11E & 0x80) == 0)
                {
                    DAT_3C = 1;
                    DAT_3D = 11;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    goto LAB_33B44;
                }

                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
                goto LAB_33B3C;
            }

            bVar5 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x200);

            if (bVar5)
            {
                V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                return;
            }

            uVar6 = 0x401;

            if (1199 < UDAT_20C)
            {
                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
                goto LAB_33B3C;
            }

            if ((oVar7.DAT_11E & 0x80) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 11;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_33B44;
            }

            DAT_3C = 1;
            DAT_3D = 4;
            DAT_3E = 0;
            DAT_3F = 0;
            goto LAB_33B3C;
        }

        LAB_33B3C:
        GameManager.instance.FUN_65CB0(this);
        LAB_33B44:
        FUN_65CF8(0, 0, 30);
    }

    private void FUN_33B78()
    {
        sbyte sVar2;
        byte bVar3;
        uint uVar4;
        bool bVar5;
        uint uVar6;
        bool bVar7;
        CriPlayer oVar7;
        ushort uVar8;
        uint uVar9;
        bool bVar10;
        Vector2Int auStack32;
        Vector3Int local_30;
        Vector3Int local_28;

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_1C2 != 1 && DAT_1C2 != 3)
        {
            if (DAT_2F / 3 == 0)
                DAT_1C2 = 1;
            else
                DAT_1C2 = 3;
        }

        uVar8 = (ushort)(DAT_3C | DAT_3D << 8);

        if (uVar8 == 0x905 || uVar8 == 0xa05)
        {
            if (oVar7.DAT_1F0 == this)
            {
                if (UDAT_20C - 2201 < 199)
                {
                    DAT_3C = 1;
                    DAT_3D = 0x18;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    oVar7.DAT_11E |= 0x20;
                    return;
                }

                if (2199 < UDAT_20C)
                    return;

                DAT_3C = 1;
                DAT_3D = 0x16;
                DAT_3E = 0;
                DAT_3F = 0;
                BDAT_1CA = 0;
                V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                GameManager.instance.FUN_65CB0(this);
                return;
            }
        }

        if (uVar8 == 0xb05 && DAT_1C2 != 3)
        {
            if (DAT_2F / 3 == 0)
                DAT_1C2 = 1;
            else
                DAT_1C2 = 3;
        }

        if ((GameManager.instance.DAT_922C & 2) != 0 && GameManager.instance.DAT_9230 != this)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            goto LAB_34028;
        }

        uVar9 = 0;

        if ((DAT_128 & 0x3ff) != 0 && (DAT_12A & 6) != 0)
        {
            uVar4 = DAT_128;

            do
            {
                if ((uVar4 & 1) != 0) break;

                uVar9++;
                uVar4 = (uint)(DAT_128 >> (int)(uVar9 & 0x1f));
            } while (uVar9 < 10);

            ((CriPlayer)SceneManager.instance.DAT_27C[uVar9]).DAT_1C5 = 1;
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_65CF8(0, 0, 30);
            GameManager.instance.FUN_65CB0(this);
            return;
        }

        auStack32 = new Vector2Int();
        sVar2 = SceneManager.instance.FUN_64D20(this, oVar7.screen, ref auStack32);
        bVar3 = DAT_1C2;

        if (bVar3 == 1 && UDAT_20C < 4000)
        {
            bVar5 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x80);

            if (!bVar5)
            {
                if (bVar3 == 3 && UDAT_20C < 3500)
                {
                    uVar6 = 0x401;

                    if ((oVar7.DAT_11E & 0x80) == 0)
                    {
                        bVar7 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x100);

                        if (bVar7)
                        {
                            uVar9 = GameManager.FUN_64650();

                            if ((uVar9 & 1) == 0)
                            {
                                DAT_3C = 1;
                                DAT_3D = 0x1e;
                                DAT_3E = 0;
                                DAT_3F = 0;
                            }
                            else
                            {
                                DAT_3C = 1;
                                DAT_3D = 0x1f;
                                DAT_3E = 0;
                                DAT_3F = 0;
                                V2_1F4 = new Vector2Int(screen.x, screen.z);
                            }

                            goto LAB_34028;
                        }
                    }

                    DAT_3C = (byte)uVar6;
                    DAT_3D = (byte)(uVar6 >> 8);
                    DAT_3E = (byte)(uVar6 >> 0x10);
                    DAT_3F = (byte)(uVar6 >> 0x18);
                    goto LAB_34020;
                }

                local_30 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
                local_28 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
                uVar9 = Utilities.FUN_631AC(local_30, local_28);
                uVar4 = Utilities.FUN_631AC(local_30, screen);

                if (uVar4 <= uVar9)
                {
                    uVar9 = Utilities.FUN_631AC(local_30, oVar7.screen);

                    if (uVar4 <= uVar9)
                        return;

                    uVar6 = 0x401;

                    if (UDAT_20C < 1200 && (oVar7.DAT_11E & 0x80) == 0)
                    {
                        DAT_3C = 1;
                        DAT_3D = 11;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        goto LAB_34028;
                    }

                    DAT_3C = (byte)uVar6;
                    DAT_3D = (byte)(uVar6 >> 8);
                    DAT_3E = (byte)(uVar6 >> 0x10);
                    DAT_3F = (byte)(uVar6 >> 0x18);
                    goto LAB_34020;
                }

                bVar5 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x200);
                
                if (bVar5)
                {
                    V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                    V2_1F4 = new Vector2Int(screen.x, screen.z);
                    return;
                }

                uVar6 = 0x401;

                if (1199 < UDAT_20C)
                {
                    DAT_3C = (byte)uVar6;
                    DAT_3D = (byte)(uVar6 >> 8);
                    DAT_3E = (byte)(uVar6 >> 0x10);
                    DAT_3F = (byte)(uVar6 >> 0x18);
                    goto LAB_34020;
                }

                if ((oVar7.DAT_11E & 0x80) == 0)
                {
                    DAT_3C = 1;
                    DAT_3D = 11;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    goto LAB_34028;
                }

                DAT_3C = 1;
                DAT_3D = 4;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_34020;
            }

            if (sVar2 != 0)
                return;

            if ((DAT_208 & 0x4000000) != 0)
            {
                DAT_3C = 1;
                DAT_3D = 5;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_34028;
            }

            bVar10 = FUN_2E284();
            uVar6 = 0x201;

            if (!bVar10 && (oVar7.DAT_11E & 0x80) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 12;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_1E6 = 100;
                DAT_1E8 = 100;
                DAT_208 &= 0xfffffdff;
                goto LAB_34028;
            }

            DAT_3C = (byte)uVar6;
            DAT_3D = (byte)(uVar6 >> 8);
            DAT_3E = (byte)(uVar6 >> 0x10);
            DAT_3F = (byte)(uVar6 >> 0x18);
        }
        else
        {
            if (bVar3 == 3 && UDAT_20C < 3500)
            {
                uVar6 = 0x401;

                if ((oVar7.DAT_11E & 0x80) == 0)
                {
                    bVar7 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x100);

                    if (bVar7)
                    {
                        uVar9 = GameManager.FUN_64650();

                        if ((uVar9 & 1) == 0)
                        {
                            DAT_3C = 1;
                            DAT_3D = 0x1e;
                            DAT_3E = 0;
                            DAT_3F = 0;
                        }
                        else
                        {
                            DAT_3C = 1;
                            DAT_3D = 0x1f;
                            DAT_3E = 0;
                            DAT_3F = 0;
                            V2_1F4 = new Vector2Int(screen.x, screen.z);
                        }

                        goto LAB_34028;
                    }
                }

                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
                goto LAB_34020;
            }

            local_30 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
            local_28 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
            uVar9 = Utilities.FUN_631AC(local_30, local_28);
            uVar4 = Utilities.FUN_631AC(local_30, screen);

            if (uVar4 <= uVar9)
            {
                uVar9 = Utilities.FUN_631AC(local_30, oVar7.screen);

                if (uVar4 <= uVar9)
                    return;

                uVar6 = 0x401;

                if (UDAT_20C < 1200 && (oVar7.DAT_11E & 0x80) == 0)
                {
                    DAT_3C = 1;
                    DAT_3D = 11;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    goto LAB_34028;
                }

                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
                goto LAB_34020;
            }

            bVar5 = Utilities.FUN_64C0C(screen, oVar7.screen, (short)vr.y, 0x200);

            if (bVar5)
            {
                V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                return;
            }

            uVar6 = 0x401;

            if (1199 < UDAT_20C)
            {
                DAT_3C = (byte)uVar6;
                DAT_3D = (byte)(uVar6 >> 8);
                DAT_3E = (byte)(uVar6 >> 0x10);
                DAT_3F = (byte)(uVar6 >> 0x18);
                goto LAB_34020;
            }

            if ((oVar7.DAT_11E & 0x80) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 11;
                DAT_3E = 0;
                DAT_3F = 0;
                goto LAB_34028;
            }

            DAT_3C = 1;
            DAT_3D = 4;
            DAT_3E = 0;
            DAT_3F = 0;
            goto LAB_34020;
        }

        LAB_34020:
        GameManager.instance.FUN_65CB0(this);
        LAB_34028:
        FUN_65CF8(0, 0, 30);
    }

    private void FUN_3405C()
    {
        PTR_FUN_9BD58[DAT_2F]();
    }

    private void FUN_34098()
    {
        FUN_609C8(6, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 100);
        GameManager.instance.FUN_65C7C(this);
        FUN_65CF8(1, 0, 30);
        DAT_3E++;
    }

    private void FUN_34104()
    {
        short sVar2;
        short sVar3;
        int iVar4;
        CriPlayer oVar4;
        Vector3Int local_20;
        Vector2Int auStack24;

        FUN_60AB4();

        if (DAT_60 == 1)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 9)
            GameManager.instance.FUN_5C94C(this, 49);

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        DAT_40.z = Utilities.DAT_9B5A8[DAT_60];
        auStack24 = new Vector2Int();

        if ((oVar4.DAT_3C == 5 && oVar4.DAT_3D == 9) || (oVar4.DAT_3C == 5 && oVar4.DAT_3D == 10) ||
            SceneManager.instance.FUN_64D20(this, oVar4.screen, ref auStack24) == 0)
            local_20 = oVar4.screen;
        else
            local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);

        sVar2 = (short)Utilities.FUN_615EC(screen, local_20);
        iVar4 = (int)GameManager.FUN_64650();
        sVar3 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar4 % 15 + 60) * 0x10000 >> 0x10), sVar2);
        vr.y = vr.y + sVar3 & 0xfff;
    }

    private void FUN_3425C()
    {
        PTR_FUN_9BD7C[DAT_3E]();
    }

    private void FUN_34298()
    {
        FUN_609C8(1, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_65CF8(1, 0, 30);
        DAT_3E++;
    }

    private void FUN_342F8()
    {
        short sVar1;
        bool bVar2;
        CriPlayer oVar2;
        int iVar3;
        CriPlayer oVar4;
        uint uVar4;

        bVar2 = FUN_60AB4();

        if (!bVar2)
            return;

        FUN_65CF8(0, 0, 30);

        if ((DAT_208 & 8) != 0)
        {
            DAT_3C = 1;
            DAT_3D = 0x19;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_208 = DAT_208 & 0xfffffff7 | 0x100000;
            return;
        }

        oVar2 = SceneManager.instance.FUN_65B30(this) as CriPlayer;

        if (oVar2 != null && (oVar2.DAT_208 & 0x2000000) == 0)
        {
            iVar3 = (int)GameManager.FUN_64650();
            
            if (iVar3 == (iVar3 / 3) * 3)
            {
                PTR_218 = oVar2;
                DAT_208 |= 0x1000;
            }
        }

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        sVar1 = FUN_64804(oVar4.screen);

        if ((ushort)(sVar1 - 0x301) < 0xa00U)
        {
            uVar4 = 0x701;

            if (0x400U < (ushort)(sVar1 - 0x600))
                uVar4 = 0x801;
        }
        else
        {
            uVar4 = 0x201;

            if ((DAT_208 & 0x1000) != 0 && (DAT_18E & 8) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 29;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_208 &= 0xffffefff;
                goto LAB_34458;
            }
        }

        DAT_3C = (byte)uVar4;
        DAT_3D = (byte)(uVar4 >> 8);
        DAT_3E = (byte)(uVar4 >> 0x10);
        DAT_3F = (byte)(uVar4 >> 0x18);
        FUN_2D76C();
        LAB_34458:
        FUN_2DF3C();
    }

    private void FUN_34474()
    {
        PTR_FUN_9BD84[DAT_3E]();
    }

    private void FUN_344B0()
    {
        short sVar2;
        bool bVar3;
        int iVar3;
        short sVar5;
        uint uVar6;
        CriPlayer oVar7;
        int iVar8;

        if ((GameManager.instance.DAT_922C & 2) != 0 && GameManager.instance.DAT_9230 != this)
        {
            DAT_3C = 1;
            DAT_3D = 0x16;
            DAT_3E = 0;
            DAT_3F = 0;
            return;
        }

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar7.DAT_11E & 0x80) != 0)
            return;

        bVar3 = SceneManager.instance.FUN_81014(screen, oVar7.screen, (byte)(DAT_48 << 4 | 0xf), false);

        if (bVar3)
            return;

        if (14U < DAT_60 && (DAT_162 & 1) != 0)
        {
            sVar2 = oVar7.FUN_64804(screen);

            if (DAT_1C4 != 0) goto LAB_3482C;

            if ((DAT_12B & 4) == 0 || 0x15U < DAT_60)
            {
                if (DAT_1C4 != 0) goto LAB_3482C;

                DAT_1C4 = 1;

                if (oVar7.DAT_98 == DAT_98)
                    oVar7.DAT_98 = oVar7.DAT_1E0;

                if ((ushort)(sVar2 - 0x201) < 0x400U)
                    uVar6 = 1;
                else
                {
                    if ((ushort)(sVar2 - 0xa01) < 0x400U)
                        uVar6 = 3;
                    else
                    {
                        if ((ushort)(sVar2 - 0xa01) < 0x400U)
                            uVar6 = 2;
                        else
                            uVar6 = 0;
                    }
                }

                oVar7.FUN_53A2C(1, uVar6);
                //...
            }
            else
            {
                DAT_1C4 = 1;

                if (oVar7.DAT_98 == DAT_98)
                    oVar7.DAT_98 = oVar7.DAT_1E0;

                if ((ushort)(sVar2 - 0x201) < 0x400U)
                {
                    uVar6 = 1;
                    oVar7.FUN_53A2C(1, uVar6);
                    //...
                    goto LAB_34704;
                }

                if ((ushort)(sVar2 - 0xa01) < 0x400U)
                {
                    uVar6 = 3;
                    oVar7.FUN_53A2C(1, uVar6);
                    //...
                    goto LAB_34704;
                }

                if (0xbffU < (ushort)(sVar2 - 0x201))
                {
                    uVar6 = 0;
                    oVar7.FUN_53A2C(1, uVar6);
                    //...
                    goto LAB_34704;
                }

                GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                oVar7.DAT_3C = 5;
                oVar7.DAT_3D = 9;
                oVar7.DAT_3E = 0;
                oVar7.DAT_3F = 0;
                oVar7.DAT_1F0 = this;
                FUN_65C4C(oVar7);
                //...
            }

            LAB_34704:
            //FUN_1D988
            GameManager.instance.FUN_5C94C(this, 64);

            if ((oVar7.DAT_11E & 1) == 0 && 0 < oVar7.health)
            {
                if (oVar7.DAT_3C == 5 && oVar7.DAT_3D == 9)
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    iVar8 = (int)((ulong)((long)iVar3 * 0x51eb851f) >> 0x20);
                    sVar5 = (short)(oVar7.health - 150);
                }
                else
                {
                    iVar3 = (int)GameManager.FUN_64650();
                    iVar8 = (int)((ulong)((long)iVar3 * 0x51eb851f) >> 0x20);
                    sVar5 = (short)(oVar7.health - 125);
                }

                oVar7.health = (short)(sVar5 - (iVar3 + ((iVar8 >> 4) - (iVar3 >> 31)) * -50));
                oVar7.FUN_4FE30();

                if (oVar7.health < 1)
                {
                    if (oVar7.DAT_3C != 5 || oVar7.DAT_3D != 9)
                    {
                        oVar7.DAT_3C = 3;
                        oVar7.DAT_3D = 0;
                        oVar7.DAT_3E = 0;
                        oVar7.DAT_3F = 0;

                        if ((ushort)(sVar2 - 0x400) < 0x800U)
                            oVar7.DAT_3F = 0;
                        else
                            oVar7.DAT_3F = 1;
                    }

                    //FUN_2ECAC
                }
            }
        }

        if (DAT_1C4 == 0)
            return;

        LAB_3482C:;
        //FUN_2F9A0
    }

    private void FUN_34858(CriPlayer param1)
    {
        short sVar1;
        uint uVar2;

        GameManager.instance.FUN_65CB0(this);
        sVar1 = FUN_64804(param1.screen);

        if (DAT_1C4 == 0)
        {
            if ((ushort)(sVar1 - 0x101) < 0xdffU)
            {
                DAT_3C = 1;
                DAT_3D = 15;
                DAT_3E = 0;
                DAT_3F = 0;
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                goto LAB_3498C;
            }

            if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 && 
                (param1.DAT_11E & 0x80) == 0)
            {
                DAT_1C2 = 2;
                DAT_1C4 = 0;

                if ((sVar1 & 0x800) == 0)
                    uVar2 = 0x1101;
                else
                    uVar2 = 0x1001;

                DAT_3C = (byte)uVar2;
                DAT_3D = (byte)(uVar2 >> 8);
                DAT_3E = (byte)(uVar2 >> 0x10);
                DAT_3F = (byte)(uVar2 >> 0x18);
                GameManager.instance.FUN_65C7C(this);
                FUN_65CF8(0, 0, 30);
                return;
            }
        }

        FUN_2E07C();

        if ((ushort)(sVar1 - 0x401) < 0x7ffU)
        {
            uVar2 = 0x701;

            if (0x400U < (ushort)(sVar1 - 0x600))
                uVar2 = 0x801;
        }
        else
            uVar2 = 0x201;

        DAT_3C = (byte)uVar2;
        DAT_3D = (byte)(uVar2 >> 8);
        DAT_3E = (byte)(uVar2 >> 0x10);
        DAT_3F = (byte)(uVar2 >> 0x18);
        LAB_3498C:
        DAT_1C4 = 0;
    }

    private void FUN_349A8(CriPlayer param1)
    {
        short sVar1;
        uint uVar2;

        GameManager.instance.FUN_65CB0(this);
        sVar1 = FUN_64804(param1.screen);

        if (DAT_1C4 == 0)
        {
            if ((ushort)(sVar1 - 0x101) < 0xdffU)
            {
                DAT_3C = 1;
                DAT_3D = 15;
                DAT_3E = 0;
                DAT_3F = 0;
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                goto LAB_34B24;
            }

            if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 &&
                (param1.DAT_11E & 0x80) == 0)
            {
                DAT_1C2 = 2;
                DAT_1C4 = 0;

                if ((sVar1 & 0x800) == 0)
                    uVar2 = 0x1101;
                else
                    uVar2 = 0x1001;

                DAT_3C = (byte)uVar2;
                DAT_3D = (byte)(uVar2 >> 8);
                DAT_3E = (byte)(uVar2 >> 0x10);
                DAT_3F = (byte)(uVar2 >> 0x18);
                GameManager.instance.FUN_65C7C(this);
                FUN_65CF8(0, 0, 30);
                return;
            }

            FUN_2E07C();

            if ((ushort)(sVar1 - 0x401) < 0x7ffU)
            {
                uVar2 = 0x701;

                if (0x400U < (ushort)(sVar1 - 0x600))
                    uVar2 = 0x801;
            }
            else
                uVar2 = 0x201;
        }
        else
        {
            if ((param1.DAT_3C != 5 || param1.DAT_3D != 9) && (param1.DAT_3C != 5 || param1.DAT_3D != 10))
            {
                if ((ushort)(sVar1 - 0x401) < 0x7ffU)
                {
                    uVar2 = 0x701;

                    if (0x400U < (ushort)(sVar1 - 0x600))
                        uVar2 = 0x801;
                }
                else
                    uVar2 = 0x201;
            }
            else
            {
                if (UDAT_20C < 2200)
                {
                    DAT_3C = 1;
                    DAT_3D = 0x16;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    FUN_2E07C();
                    DAT_1C4 = 0;
                    return;
                }

                uVar2 = 0x501;
            }
        }

        DAT_3C = (byte)uVar2;
        DAT_3D = (byte)(uVar2 >> 8);
        DAT_3E = (byte)(uVar2 >> 0x10);
        DAT_3F = (byte)(uVar2 >> 0x18);
        LAB_34B24:
        DAT_1C4 = 0;
    }

    private void FUN_34B40()
    {
        FUN_609C8(59, 1, 5);
        DAT_40 = new Vector3Int(0, 0, 150);
        DAT_1C4 = 0;
        DAT_3E++;
    }

    private void FUN_34B90()
    {
        sbyte sVar1;
        short sVar2;
        short sVar3;
        bool bVar4;
        int iVar5;
        CriPlayer oVar6;
        Vector3Int local_20;
        Vector2Int auStack24;

        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar4 = FUN_60AB4();

        if (bVar4)
        {
            FUN_2D76C();
            PTR_FUN_9BDFC[DAT_2F](oVar6);
        }

        if (DAT_60 == 11)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 24)
            GameManager.instance.FUN_5C94C(this, 49);

        if (DAT_60 == 14)
            GameManager.instance.FUN_5C94C(this, 66);

        if (DAT_1C4 != 0 && 23U < DAT_60)
            DAT_40.z = 0;

        local_20 = oVar6.screen;
        auStack24 = new Vector2Int();
        sVar1 = SceneManager.instance.FUN_64D20(this, local_20, ref auStack24);

        if (sVar1 != 0)
            local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);

        sVar2 = (short)Utilities.FUN_615EC(screen, local_20);
        iVar5 = (int)GameManager.FUN_64650();
        sVar3 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar5 % 15 + 30) * 0x10000 >> 0x10), sVar2);
        vr.y = vr.y + sVar3 & 0xfff;
    }

    private void FUN_34D28()
    {
        PTR_FUN_9BE20[DAT_3E]();
    }

    private void FUN_34D64()
    {
        ushort uVar1;
        short sVar3;
        int iVar4;
        bool bVar4;
        uint uVar5;
        uint uVar6;
        short sVar8;
        CriPlayer oVar9;
        int iVar10;

        oVar9 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar9.DAT_11E & 0x80) != 0)
            return;

        bVar4 = SceneManager.instance.FUN_81014(screen, oVar9.screen, (byte)(DAT_48 << 4 | 0xf), false);

        if (bVar4)
            return;

        if (DAT_60 < 0x13U && (DAT_208 & 0x400000) == 0)
        {
            if ((DAT_162 & 1) == 0)
                return;

            if (DAT_1C4 != 0)
                return;

            DAT_1C4 = 1;
            DAT_18D = false;
            oVar9.DAT_18D = false;
            DAT_3E++;
            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
            uVar1 = (ushort)vr.y;
            uVar5 = (uint)(oVar9.vr.y - uVar1 & 0xfff);

            if (uVar5 - 0x400 < 0x800)
            {
                oVar9.vr.y = (short)(uVar1 + 0x800 & 0xfff);
                uVar6 = 5;
            }
            else
            {
                uVar6 = 0x305;
                oVar9.vr.y = (short)uVar1;
            }

            oVar9.DAT_3C = (byte)uVar6;
            oVar9.DAT_3D = (byte)(uVar6 >> 8);
            oVar9.DAT_3E = (byte)(uVar6 >> 0x10);
            oVar9.DAT_3F = (byte)(uVar6 >> 0x18);
            FUN_65C4C(oVar9);
            //FUN_1D988

            if ((oVar9.DAT_11E & 1) != 0)
                return;

            if (oVar9.health < 1)
                return;

            iVar4 = (int)GameManager.FUN_64650();
            oVar9.health = (short)((oVar9.health - 300) - (iVar4 + (iVar4 / 50) * -50));
            oVar9.FUN_4FE30();

            if (0 < oVar9.health)
                return;

            uVar5 = uVar5 + 0x800 & 0xfff;
        }
        else
        {
            if (0x16U < DAT_60)
                return;

            if ((DAT_162 & 1) == 0)
                return;

            if (DAT_1C4 != 0)
                return;

            DAT_1C4 = 1;
            sVar3 = oVar9.FUN_64804(screen);

            if (oVar9.DAT_98 == DAT_98)
                oVar9.DAT_98 = oVar9.DAT_1E0;

            if ((ushort)(sVar3 - 0x200) < 0x400U)
            {
                oVar9.FUN_53A2C(1, 1);
                //...
            }
            else
            {
                if ((ushort)(sVar3 - 0xa00) < 0x400U)
                {
                    oVar9.FUN_53A2C(1, 3);
                    //...
                }
                else
                {
                    if ((ushort)(sVar3 - 0x200) < 0xc00U)
                    {
                        GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                        oVar9.DAT_3C = 5;
                        oVar9.DAT_3D = 9;
                        oVar9.DAT_3E = 0;
                        oVar9.DAT_3F = 0;
                        oVar9.DAT_1F0 = this;
                        //...
                    }
                    else
                    {
                        oVar9.FUN_53A2C(1, 0);
                        //...
                    }
                }
            }

            //FUN_1D988

            if ((oVar9.DAT_11E & 1) != 0)
                return;

            if (oVar9.health < 1)
                return;

            if (oVar9.DAT_3C == 5 && oVar9.DAT_3D == 9)
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar10 = (int)((ulong)((long)iVar4 * 0x51eb851f) >> 0x20);
                sVar8 = (short)(oVar9.health - 150);
            }
            else
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar10 = (int)((ulong)((long)iVar4 * 0x51eb851f) >> 0x20);
                sVar8 = (short)(oVar9.health - 125);
            }

            oVar9.health = (short)(sVar8 - (iVar4 + ((iVar10 >> 4) - (iVar4 >> 31)) * -50));
            oVar9.FUN_4FE30();

            if (0 < oVar9.health)
                return;

            if (oVar9.DAT_3C != 5 || oVar9.DAT_3D != 9)
            {
                oVar9.DAT_3C = 3;
                oVar9.DAT_3D = 0;
                oVar9.DAT_3E = 0;
                oVar9.DAT_3F = 0;

                if ((ushort)(sVar3 - 0x400) < 0x800U)
                    oVar9.DAT_3F = 0;
                else
                    oVar9.DAT_3F = 1;
            }

            uVar5 = (uint)(int)sVar3;
        }

        //FUN_2ECAC
        return;
    }

    private void FUN_3516C(CriPlayer param1)
    {
        short sVar1;
        uint uVar2;
        int iVar3;

        DAT_3C = 1;
        DAT_3D = 2;
        DAT_3E = 0;
        DAT_3F = 0;
        FUN_2E07C();

        if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 && 
            (param1.DAT_11E & 0x80) == 0)
        {
            DAT_1C2 = 2;
            sVar1 = FUN_64804(param1.screen);
            uVar2 = 0x1001;

            if ((sVar1 & 0x800) == 0)
                uVar2 = 0x1101;

            DAT_3C = (byte)uVar2;
            DAT_3D = (byte)(uVar2 >> 8);
            DAT_3E = (byte)(uVar2 >> 0x10);
            DAT_3F = (byte)(uVar2 >> 0x18);
            GameManager.instance.FUN_65C7C(this);
            FUN_65CF8(0, 0, 30);
        }
        else
        {
            if (DAT_1C2 == 3 && UDAT_20C < 3500)
            {
                iVar3 = (int)GameManager.FUN_64650();

                if (iVar3 == (iVar3 / 3) * 3)
                    DAT_1C2 = 2;
                else
                    DAT_1C2 = 0;
            }
        }
    }

    private void FUN_35298(CriPlayer param1)
    {
        short sVar1;
        uint uVar2;
        int iVar3;

        if ((param1.DAT_3C == 5 && param1.DAT_3D == 9) || (param1.DAT_3C == 5 && param1.DAT_3D == 10))
        {
            if (UDAT_20C < 2200)
            {
                DAT_3C = 1;
                DAT_3D = 0x16;
                DAT_3E = 0;
                DAT_3F = 0;
                FUN_2E07C();
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 5;
                DAT_3E = 0;
                DAT_3F = 0;
            }
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_2E07C();

            if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 && 
                (param1.DAT_11E & 0x80) == 0)
            {
                DAT_1C2 = 2;
                sVar1 = FUN_64804(param1.screen);
                uVar2 = 0x1001;

                if ((sVar1 & 0x800) == 0)
                    uVar2 = 0x1101;

                DAT_3C = (byte)uVar2;
                DAT_3D = (byte)(uVar2 >> 8);
                DAT_3E = (byte)(uVar2 >> 0x10);
                DAT_3F = (byte)(uVar2 >> 0x18);
                GameManager.instance.FUN_65C7C(this);
                FUN_65CF8(0, 0, 30);
            }
            else
            {
                if (DAT_1C2 == 3 && UDAT_20C < 3500)
                {
                    iVar3 = (int)GameManager.FUN_64650();

                    if (iVar3 == (iVar3 / 3) * 3)
                        DAT_1C2 = 2;
                    else
                        DAT_1C2 = 0;
                }
            }
        }
    }

    private void FUN_35410()
    {
        uint uVar1;

        FUN_609C8(14, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_2D76C();
        FUN_66460(true);

        if (DAT_1E6 == 0)
            DAT_1E6 = 100;

        if (DAT_1E8 == 0)
            DAT_1E8 = 100;

        uVar1 = (UDAT_20C + 0x800) / 40;
        UDAT_1E4 = (ushort)uVar1;

        if ((uVar1 & 0xffff) < 50)
            UDAT_1E4 = 50;

        if ((uint)DAT_1E6 < UDAT_1E4)
            UDAT_1E4 = DAT_1E6;

        ((CriPlayer)SceneManager.instance.DAT_27C[10]).DAT_1CC = (byte)UDAT_1E4;
        GameManager.instance.FUN_65C7C(this);
        DAT_12E = 2;
        GameManager.instance.FUN_5C94C(this, 51);
        DAT_1C4 = 0;
        DAT_208 &= 0xffbfffff;
        DAT_3E++;
    }

    private void FUN_35528()
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        int iVar3;
        int iVar4;
        uint uVar5;
        CriPlayer oVar6;

        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar3 = FUN_60AB4();

        if (bVar3)
        {
            PTR_120 = DAT_9B404;
            DAT_120 = 0;
            DAT_12E = 3;
            DAT_1C4 = 0;
            DAT_208 &= 0xffbfffff;
            GameManager.instance.FUN_65CB0(this);
            DAT_140 &= 0xfffc;
            FUN_66460(false);

            if (DAT_48 != oVar6.DAT_48)
            {
                DAT_3C = 1;
                DAT_3D = 0x23;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_1DB = DAT_48;
                return;
            }

            PTR_FUN_9BE28[DAT_2F](oVar6);
            return;
        }

        if (DAT_60 == 26)
            GameManager.instance.FUN_5C94C(this, 62);

        if (DAT_60 - 9U < 15)
            DAT_40.y = (short)(((ushort)Utilities.DAT_9B5CC[DAT_60 - 9] * DAT_1E8) / 100);

        if (DAT_60 - 9U < 10)
        {
            uVar5 = UDAT_1E4;
            iVar3 = (int)(uVar5 * 0xb0);
        }
        else
        {
            if (6 < (DAT_60 - 0x13U & 0xffff))
            {
                DAT_40.z = 0;
                goto LAB_356F4;
            }

            uVar5 = UDAT_1E4;
            iVar3 = (int)(uVar5 * 0x48);
        }

        DAT_40.z = (short)((int)((iVar3 - uVar5) * 2) / 100);
        LAB_356F4:
        sVar1 = (short)Utilities.FUN_615EC(screen, oVar6.screen);
        iVar4 = (int)GameManager.FUN_64650();
        sVar2 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar4 % 15 + 10) * 0x10000 >> 0x10), sVar1);
        vr.y = vr.y + sVar2 & 0xfff;
    }

    private void FUN_35774()
    {
        CriPlayer oVar3;

        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        FUN_609C8(24, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        screen.y = oVar3.screen.y;
        FUN_656EC();
        //FUN_65D1C
        oVar3.DAT_152 = 1;
        DAT_152 = 1;
        oVar3.DAT_154 = this;
        DAT_154 = oVar3;
        DAT_140 |= 3;
        DAT_3E++;
    }

    private void FUN_35814()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 13;
            DAT_3E = 0;
            DAT_3F = 0;
            PTR_120 = DAT_9B404;
            DAT_120 = 0;
            DAT_1C4 = 0;
            DAT_12E = 3;
            DAT_140 &= 0xfffc;
            FUN_66460(false);
        }

        FUN_65714();

        if (DAT_60 == 9)
            GameManager.instance.FUN_5C94C(this, 62);
    }

    private void FUN_35898()
    {
        PTR_FUN_9BE4C[DAT_3E]();
    }

    private void FUN_358D4()
    {
        CriPlayer oVar1;

        FUN_609C8(25, 1, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_65714();
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar1.DAT_1CA = 88;
        oVar1.DAT_1C9 = 2;
        oVar1.DAT_1E5 = 0;
        DAT_3E++;
    }

    private void FUN_35948()
    {
        byte bVar2;
        short sVar3;
        short sVar4;
        ushort uVar4;
        int iVar5;
        bool bVar5;
        uint uVar6;
        uint uVar7;
        CriPlayer oVar8;

        oVar8 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar5 = FUN_60AB4();

        if (!bVar5 || oVar8.DAT_1E5 != 1)
        {
            FUN_65714();
            uVar4 = DAT_60;

            if (uVar4 == 8 || uVar4 == 27 || uVar4 == 43 || uVar4 == 51)
            {
                uVar6 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(this, (int)(uVar6 & 1 | 64));
            }

            if (uVar4 == 10 || uVar4 == 29 || uVar4 == 45 || uVar4 == 53)
            {
                uVar6 = GameManager.FUN_64650();
                GameManager.instance.FUN_5C94C(this, (int)((uVar6 & 3) + 53));
            }

            sVar3 = (short)(SDAT_1FA - 1);

            if (SDAT_1FA < 1)
            {
                if (uVar4 == 20)
                    DAT_5C |= 8;

                if (uVar4 == 50)
                    DAT_5C &= 0xf7;

                if (uVar4 == 10 || uVar4 == 24)
                    ; //FUN_1D988

                if (uVar4 == 45)
                    ; //FUN_1D988

                //FUN_2F9A0

                if ((oVar8.DAT_11E & 0x20) == 0 && 0 < oVar8.health && oVar8.DAT_1E5 == 0)
                {
                    bVar5 = GameManager.FUN_64C68();

                    if (!bVar5)
                        sVar4 = (short)(oVar8.DAT_1CA - 1);
                    else
                        sVar4 = (short)(oVar8.DAT_1CA - oVar8.DAT_1C9);

                    oVar8.DAT_1CA = sVar4;

                    if (oVar8.DAT_1CA < 0)
                        oVar8.DAT_1E5 = 1;

                    if ((oVar8.DAT_11E & 1) == 0 && DAT_60 == 12)
                    {
                        iVar5 = (int)GameManager.FUN_64650();
                        oVar8.health = (short)((oVar8.health - 100) - (iVar5 + (iVar5 / 20) * -20));
                        oVar8.FUN_4FE30();

                        if (oVar8.health < 1)
                        {
                            if (oVar8.DAT_3C == 5 && oVar8.DAT_3D == 0)
                                uVar7 = 0;
                            else
                                uVar7 = 0x800;

                            //FUN_2ECAC
                        }
                    }
                }
            }
            else
            {
                SDAT_1FA = sVar3;

                if ((int)(sVar3 << 0x10) < 1)
                {
                    DAT_3C = 1;
                    DAT_3D = 14;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    FUN_2E07C();
                }
            }
        }
        else
        {
            SDAT_1FA = 10;
            bVar2 = 5;

            if (oVar8.DAT_3C == 5 && oVar8.DAT_3D == 1)
                bVar2 = 2;

            oVar8.DAT_3D = bVar2;
            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
            oVar8.DAT_3C = 5;
            oVar8.DAT_3E = 0;
            oVar8.DAT_1E5 = 2;
            FUN_65714();
        }
    }

    private void FUN_35C58()
    {
        PTR_FUN_9BF5C[DAT_3E]();
    }

    private void FUN_35C94()
    {
        FUN_609C8(16, 1, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_5C94C(this, 60);
        DAT_3E++;
    }

    private void FUN_35CEC()
    {
        CriPlayer oVar1;
        bool bVar2;

        bVar2 = FUN_60AB4();

        if (bVar2)
        {
            DAT_18D = true;
            oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
            oVar1.DAT_18D = true;
            oVar1.DAT_11E &= 0xf7;
            DAT_3C = 2;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1C3 = 0;
            GameManager.instance.FUN_65CB0(this);
            FUN_2D76C();
        }

        if (DAT_60 < 15U)
            DAT_40.z = -120;
        else
            DAT_40.z = 0;

        if (DAT_60 == 15)
            GameManager.instance.FUN_5C94C(this, 63);
    }

    private void FUN_35D94()
    {
        PTR_FUN_9BF64[DAT_3E]();
    }

    private void FUN_35DD0()
    {
        uint uVar1;
        Vector3Int local_10;

        if ((DAT_162 & 2) == 0)
        {
            local_10 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
            uVar1 = Utilities.FUN_631AC(screen, local_10);

            if (uVar1 <= 3000)
                return;

            DAT_3C = 1;
            DAT_3D = 4;
            DAT_3E = 0;
            DAT_3F = 0;
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 4;
            DAT_3E = 0;
            DAT_3F = 0;
        }

        FUN_65CF8(0, 0, 30);
        GameManager.instance.FUN_65CB0(this);
    }

    private void FUN_35E58()
    {
        FUN_609C8(23, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 50);
        FUN_65CF8(1, 0, 30);
        DAT_3E++;
    }

    private void FUN_35EBC()
    {
        FUN_60AB4();

        if (DAT_60 == 2)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 15)
            GameManager.instance.FUN_5C94C(this, 49);

        DAT_40.z = Utilities.DAT_9BF6C[DAT_60];
    }

    private void FUN_35F3C()
    {
        PTR_FUN_9BF9C[DAT_3E]();
    }

    private void FUN_35F78()
    {
        int iVar2;
        uint uVar3;
        uint uVar5;
        CriPlayer oVar6;

        if ((GameManager.instance.DAT_922C & 2) == 0 || GameManager.instance.DAT_9230 == this)
        {
            oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];

            if ((oVar6.DAT_11E & 0x80) == 0 && !SceneManager.instance.FUN_81014(screen, oVar6.screen, (byte)(DAT_48 << 4 | 0xf), false) && 
                (DAT_162 & 1) != 0 && DAT_1C4 == 0 && (DAT_12B & 0x38) != 0)
            {
                DAT_1C4 = 1;

                if ((ushort)(oVar6.vr.y - vr.y & 0xfff) - 0x400U < 0x801)
                {
                    uVar3 = GameManager.FUN_64650();
                    uVar5 = 0x60;

                    if ((uVar3 & 2) != 0 && DAT_1A7 == 0)
                    {
                        uVar5 = 0x70;
                        DAT_208 |= 0x8000;
                    }

                    oVar6.vr.y = (short)(vr.y + 0x800 & 0xfff);
                    oVar6.FUN_53A2C(uVar5, 0);
                    //...
                }
                else
                {
                    GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                    oVar6.DAT_3C = 5;
                    oVar6.DAT_3D = 9;
                    oVar6.DAT_3E = 0;
                    oVar6.DAT_3F = 0;
                    oVar6.DAT_1F0 = this;
                    FUN_65C4C(oVar6);
                    //...
                    oVar6.vr.y = vr.y;
                }

                //FUN_1D988
                GameManager.instance.FUN_5C94C(this, 68);

                if ((oVar6.DAT_11E & 1) == 0 && 0 < oVar6.health)
                {
                    iVar2 = (int)GameManager.FUN_64650();
                    oVar6.health = (short)(oVar6.health - ((iVar2 % 100 + 150) / 2));
                    oVar6.FUN_4FE30();

                    if (oVar6.health < 1)
                        ; //FUN_2ECAC
                }
            }
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 0x16;
            DAT_3E = 0;
            DAT_3F = 0;
        }
    }

    private void FUN_361C8()
    {
        FUN_609C8(26, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_65CF8(1, 0, 30);
        DAT_1C4 = 0;
        DAT_208 &= 0xffff7fff;
        GameManager.instance.FUN_65C7C(this);
        DAT_3E++;
    }

    private void FUN_36248()
    {
        short sVar2;
        short sVar3;
        bool bVar4;
        int iVar4;
        CriPlayer oVar4;
        byte bVar5;

        bVar4 = FUN_60AB4();
        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (!bVar4) goto LAB_36344;

        if (DAT_1C4 == 0)
        {
            iVar4 = (int)GameManager.FUN_64650();
            DAT_1C8 = (sbyte)(iVar4 + (iVar4 / 10) * -10 + 20);

            if (DAT_1C4 != 0)
            {
                DAT_3C = 1;
                DAT_3D = 22;
                DAT_3E = 0;
                DAT_3F = 0;
                BDAT_1CA = 0;
                V2_1F0 = new Vector2Int(oVar4.screen.x, oVar4.screen.z);
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
            }
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 22;
            DAT_3E = 0;
            DAT_3F = 0;
            BDAT_1CA = 0;
            V2_1F0 = new Vector2Int(oVar4.screen.x, oVar4.screen.z);
        }

        DAT_1C4 = 0;
        FUN_65CF8(1, 30, 30);
        DAT_208 = DAT_208 & 0xfffeffff | 0x800000;
        GameManager.instance.FUN_65CB0(this);
        FUN_2D76C();
        FUN_2E07C();

        LAB_36344:
        if (DAT_60 == 44 && 2000 < UDAT_20C)
            DAT_3E++;
        else
        {
            if (DAT_60 == 47)
            {
                DAT_12E = 6;
                PTR_124 = DAT_9B404;
                DAT_124 = 7;
                DAT_12F = 5;
            }

            if (DAT_60 == 57)
            {
                DAT_12E = 3;
                PTR_124 = DAT_9B404;
                DAT_124 = 7;
                DAT_12F = 2;
            }

            if (DAT_60 == 45)
                FUN_65CF8(6, 0, 30);

            if (DAT_60 == 15)
                GameManager.instance.FUN_5C94C(this, 51);

            if (DAT_60 == 47)
            {
                GameManager.instance.FUN_5C94C(this, 67);
                GameManager.instance.FUN_5C94C(this, 52);
            }

            if (DAT_60 < 40U)
            {
                sVar2 = (short)Utilities.FUN_615EC(screen, oVar4.screen);
                iVar4 = (int)GameManager.FUN_64650();
                sVar3 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar4 % 15 + 20) * 0x10000 >> 0x10), sVar2);
                vr.y = vr.y + sVar3 & 0xfff;
            }

            if (DAT_60 - 46U < 11)
            {
                bVar5 = DAT_3D;

                if (bVar5 == 16)
                    vr.y = vr.y + 0x40 & 0xfff;

                if (bVar5 == 17)
                    vr.y = vr.y - 0x40 & 0xfff;
            }
        }
    }

    private void FUN_36528()
    {
        FUN_609C8(37, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
    }

    private void FUN_36570()
    {
        short sVar2;
        bool bVar3;
        CriPlayer oVar3;

        bVar3 = FUN_60AB4();

        if (bVar3)
        {
            FUN_65CF8(0, 0, 30);
            GameManager.instance.FUN_65CB0(this);
            FUN_2D76C();
            oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
            FUN_2E1B4();

            if (DAT_1C5 != 0 && DAT_2F / 3 != 0)
            {
                sVar2 = FUN_64804(oVar3.screen);

                if (3500 < UDAT_20C && 0x800U < (ushort)(sVar2 - 0x400))
                {
                    DAT_1C2 = 3;
                    DAT_3C = 1;
                    DAT_3D = 9;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    V2_1F0 = new Vector2Int(oVar3.screen.x, oVar3.screen.z);
                    V2_1F4 = new Vector2Int(screen.x, screen.z);
                    return;
                }
            }

            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
        }
    }

    private void FUN_3667C()
    {
        PTR_FUN_9BFA4[DAT_3E]();
    }

    private void FUN_366B8()
    {
        FUN_609C8(36, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_65CF8(1, 0, 30);
        DAT_1C4 = 0;
        DAT_208 &= 0xffff7fff;
        GameManager.instance.FUN_65C7C(this);
        DAT_3E++;
    }

    private void FUN_36738()
    {
        FUN_609C8(38, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
    }

    private void FUN_36780()
    {
        PTR_FUN_9BFB4[DAT_3E]();
    }

    private void FUN_367BC()
    {
        ushort uVar1;
        short sVar3;
        bool bVar4;
        uint uVar5;
        CriPlayer oVar6;

        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar6.DAT_11E & 0x80) == 0)
        {
            bVar4 = SceneManager.instance.FUN_81014(screen, oVar6.screen, (byte)(DAT_48 << 4 | 0xf), false);

            if (!bVar4 && DAT_3E == 2 && (GameManager.instance.DAT_922C & 2) == 0 && (oVar6.DAT_11E & 0x80) == 0)
            {
                sVar3 = FUN_64804(oVar6.screen);

                if (UDAT_20C < 2000)
                {
                    if ((ushort)(sVar3 - 0x101) < 0x2ffU)
                    {
                        uVar1 = DAT_12C;
                        uVar5 = 0x1301;
                    }
                    else
                    {
                        if (0x1feU < (ushort)(sVar3 - 0xc01))
                            return;

                        uVar5 = 0x1401;

                        if (0x6feU < (ushort)(oVar6.vr.y - vr.y & 0xfff) - 0x201U)
                            return;

                        uVar1 = DAT_12C;
                    }

                    DAT_3C = (byte)uVar5;
                    DAT_3D = (byte)(uVar5 >> 8);
                    DAT_3E = (byte)(uVar5 >> 0x10);
                    DAT_3F = (byte)(uVar5 >> 0x18);
                    DAT_12C = (ushort)(uVar1 & 0xfeff);
                }
            }
        }
    }

    private void FUN_368F4()
    {
        FUN_609C8(19, 0, 10);
        PTR_124 = DAT_9B404;
        DAT_124 = 12;
        DAT_12F = 1;
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_12C |= 0x100;
        DAT_3E++;
        DAT_208 &= 0xffffffef;
    }

    private void FUN_3696C()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;

        if (DAT_60 == 14)
            GameManager.instance.FUN_5C94C(this, 63);

        DAT_200 = 300;
    }

    private void FUN_369D0()
    {
        short sVar1;

        sVar1 = (short)(DAT_200 - 1);

        if (0 < DAT_200)
        {
            DAT_200 = sVar1;

            if (sVar1 << 0x10 < 1)
            {
                DAT_3C = 2;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_12C &= 0xfeff;
            }
        }
    }

    private void FUN_36A08()
    {
        PTR_FUN_9BFC4[DAT_3E]();
    }

    private void FUN_36A44()
    {
        ushort uVar1;
        int iVar3;
        CriPlayer oVar4;

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar4.DAT_11E & 0x80) == 0 && !SceneManager.instance.FUN_81014(screen, oVar4.screen, (byte)(DAT_48 << 4 | 0xf), false) && 
            (DAT_162 & 1) != 0 && DAT_1C4 == 0 && (DAT_12B & 0x38) != 0)
        {
            DAT_1C4 = 1;
            uVar1 = (ushort)vr.y;

            if (oVar4.DAT_98 == DAT_98)
                oVar4.DAT_98 = oVar4.DAT_1E0;

            if ((ushort)(oVar4.vr.y - uVar1 & 0xfff) - 0x400U < 0x801)
            {
                oVar4.FUN_53A2C(1, 0);
                oVar4.vr.y = (short)(vr.y + 0x800 & 0xfff);
                //FUN_1D988
            }
            else
            {
                GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                oVar4.DAT_3C = 5;
                oVar4.DAT_3D = 9;
                oVar4.DAT_3E = 0;
                oVar4.DAT_3F = 0;
                oVar4.DAT_1F0 = this;
                FUN_65C4C(oVar4);
                oVar4.vr.y = vr.y;
            }

            GameManager.instance.FUN_5C94C(this, 68);

            if ((oVar4.DAT_11E & 1) == 0 && 0 < oVar4.health)
            {
                iVar3 = (int)GameManager.FUN_64650();
                oVar4.health = (short)((oVar4.health - 50) - (iVar3 + (iVar3 / 50) * -50));
                oVar4.FUN_4FE30();

                if (oVar4.health < 1)
                    oVar4.health = 1;
            }
        }
    }

    private void FUN_36C3C()
    {
        FUN_609C8(27, 0, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_1C4 = 0;
        GameManager.instance.FUN_65C7C(this);
        DAT_3E++;
    }

    private void FUN_36C94()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 2;
            DAT_3D = 2;
            DAT_1C4 = 0;
            GameManager.instance.FUN_65CB0(this);
        }

        if (DAT_60 == 8)
        {
            DAT_12E = 6;
            PTR_124 = DAT_9B404;
            DAT_124 = 7;
            DAT_12F = 5;
        }

        if (DAT_60 == 16)
        {
            DAT_12E = 3;
            PTR_124 = DAT_9B404;
            DAT_124 = 7;
            DAT_12F = 2;
        }

        if (DAT_60 == 8)
        {
            GameManager.instance.FUN_5C94C(this, 67);
            GameManager.instance.FUN_5C94C(this, 52);
        }
    }

    private void FUN_36D48()
    {
        PTR_FUN_9BFD0[DAT_3E]();
    }

    private void FUN_36D84()
    {
        CriPlayer oVar2;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        FUN_609C8(28, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_65CF8(0, 0, 30);
        FUN_656EC();
        DAT_18D = false;
        oVar2.DAT_18D = false;
        GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
        oVar2.DAT_3C = 5;
        oVar2.DAT_3D = 6;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        FUN_65C4C(oVar2);
        oVar2.DAT_152 = 1;
        DAT_152 = 1;
        DAT_154 = oVar2;
        oVar2.DAT_11E |= 8;
        oVar2.vr.y = vr.y;
        SceneManager.instance.cCamera.DAT_72 |= 4;
        //FUN_1D988
        GameManager.instance.FUN_65C7C(this);
        DAT_3E++;
    }

    private void FUN_36E88()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;

        FUN_65714();

        if (DAT_60 == 10)
            GameManager.instance.FUN_5C94C(this, 64);
    }

    private void FUN_36EE8()
    {
        CriPlayer oVar1;
        int iVar2;
        uint uVar3;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        iVar2 = (int)GameManager.FUN_64650();
        uVar3 = (uint)(iVar2 % 5 & 0xff);
        FUN_6103C(29, 1, (byte)uVar3, 5);
        oVar1.DAT_1E4 = (byte)(iVar2 % 5);
        DAT_60 = (ushort)uVar3;
        oVar1.DAT_1CA = 84;
        oVar1.DAT_1C9 = 7;
        oVar1.DAT_1E5 = 0;
        DAT_3E++;
    }

    private void FUN_36FA8()
    {
        short sVar2;
        bool bVar3;
        int iVar3;
        uint uVar4;
        CriPlayer oVar5;

        oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar3 = FUN_60AB4();

        if (bVar3)
        {
            if (oVar5.DAT_1E5 == 0)
            {
                iVar3 = (int)GameManager.FUN_64650();
                uVar4 = (uint)(iVar3 % 5 & 0xff);
                FUN_6103C(29, 1, (byte)uVar4, 5);
                oVar5.DAT_1E4 = (byte)(iVar3 % 5);
                DAT_60 = (ushort)uVar4;
            }
            else
                DAT_3E++;
        }

        if (DAT_60 == 1)
        {
            //...
        }

        if (DAT_60 == 13)
        {
            //...
        }

        if (oVar5.DAT_1E5 == 0)
        {
            bVar3 = GameManager.FUN_64C68();

            if (!bVar3)
                sVar2 = (short)(oVar5.DAT_1CA - 1);
            else
                sVar2 = (short)(oVar5.DAT_1CA - oVar5.DAT_1C9);

            oVar5.DAT_1CA = sVar2;

            if (oVar5.DAT_1CA < 0)
                oVar5.DAT_1E5 = 1;

            if ((oVar5.DAT_11E & 1) == 0 && DAT_60 == 2)
            {
                iVar3 = (int)GameManager.FUN_64650();
                oVar5.health = (short)((oVar5.health - 20) - (iVar3 + (iVar3 / 20) * -20));
                oVar5.FUN_4FE30();

                if (oVar5.health < 1)
                    oVar5.health = 1;
            }
        }
    }

    private void FUN_371A8()
    {
        CriPlayer oVar1;

        FUN_609C8(30, 0, 0);
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar1.DAT_3C = 5;
        oVar1.DAT_3D = 8;
        oVar1.DAT_3E = 0;
        oVar1.DAT_3F = 0;
        oVar1.DAT_152 = 0;
        oVar1.DAT_11E &= 0xf7;
        SceneManager.instance.cCamera.DAT_72 &= 0xfb;
        DAT_3E++;
    }

    private void FUN_37240()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 2;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_18D = true;
            SceneManager.instance.DAT_27C[10].DAT_18D = true;
            GameManager.instance.FUN_65CB0(this);
        }
    }

    private void FUN_37290()
    {
        PTR_FUN_9BFD8[DAT_3E]();
    }

    private void FUN_372CC()
    {
        short sVar2;
        ushort uVar3;
        bool bVar4;
        int iVar4;
        short sVar6;
        ushort uVar6;
        uint uVar7;
        CriPlayer oVar8;
        int iVar9;

        if ((GameManager.instance.DAT_922C & 2) != 0 && GameManager.instance.DAT_9230 != this)
        {
            DAT_3C = 1;
            DAT_3D = 0x16;
            DAT_3E = 0;
            DAT_3F = 0;
            return;
        }

        oVar8 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar8.DAT_11E & 0x80) != 0)
            return;

        bVar4 = SceneManager.instance.FUN_81014(screen, oVar8.screen, (byte)(DAT_48 << 4 | 0xf), false);

        if (bVar4)
            return;

        if ((DAT_162 & 1) == 0)
            return;

        if (DAT_60 < 0x12U)
            return;

        if (1U < DAT_3E)
            return;

        sVar2 = oVar8.FUN_64804(screen);

        if (DAT_60 < 0x20U && (DAT_12B & 4) != 0)
        {
            if (DAT_1C4 != 0)
                return;

            DAT_1C4 = 1;

            if (oVar8.DAT_98 == DAT_98)
                oVar8.DAT_98 = oVar8.DAT_1E0;

            uVar3 = (ushort)(sVar2 - 0x200);

            if (uVar3 < 0x400U || (ushort)(sVar2 - 0xa00) < 0x400U)
            {
                if ((oVar8.DAT_227 & 0x80) == 0 || (GameManager.FUN_64650() & 1) != 0 || DAT_1A7 != 0)
                {
                    if ((ushort)(sVar2 - 0x200) < 0x400U)
                        uVar7 = 1;
                    else
                        uVar7 = 3;

                    oVar8.FUN_53A2C(1, uVar7);
                }
                else
                {
                    if (uVar3 < 0x400U)
                        uVar7 = 1;
                    else
                        uVar7 = 3;

                    oVar8.FUN_53A2C(2, uVar7);
                    DAT_208 |= 0x8000;
                }

                //FUN_1D988
            }
            else
            {
                if (uVar3 < 0xc00U)
                {
                    if (DAT_60 < 0x1cU)
                    {
                        DAT_3C = 1;
                        DAT_3D = 0x17;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        DAT_18D = false;
                        oVar8.DAT_18D = false;
                        GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                        oVar8.DAT_3C = 5;
                        oVar8.DAT_3D = 13;
                        oVar8.DAT_3E = 0;
                        oVar8.DAT_3F = 0;
                    }
                    else
                    {
                        GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                        oVar8.DAT_3C = 5;
                        oVar8.DAT_3D = 9;
                        oVar8.DAT_3E = 0;
                        oVar8.DAT_3F = 0;
                        oVar8.DAT_1F0 = this;
                    }

                    FUN_65C4C(oVar8);
                    //FUN_1D988
                    goto LAB_375BC;
                }

                if (0x1bU < DAT_60)
                {
                    oVar8.FUN_53A2C(1, 0);
                    //FUN_1D988
                    goto LAB_375BC;
                }

                DAT_3C = 1;
                DAT_3D = 0x17;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_18D = false;
                oVar8.DAT_18D = false;
                GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                oVar8.DAT_3C = 5;
                oVar8.DAT_3D = 12;
                oVar8.DAT_3E = 0;
                oVar8.DAT_3F = 0;
                FUN_65C4C(oVar8);
            }

            LAB_375BC:
            if ((oVar8.DAT_11E & 1) != 0)
                return;

            if (oVar8.health < 1)
                return;

            if (oVar8.DAT_3C == 5 && oVar8.DAT_3D == 9)
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar9 = (int)((ulong)((long)iVar4 * 0x51eb851f) >> 0x20);
                sVar6 = (short)(oVar8.health - 150);
            }
            else
            {
                iVar4 = (int)GameManager.FUN_64650();
                iVar9 = (int)((ulong)((long)iVar4 * 0x51eb851f) >> 0x20);
                sVar6 = (short)(oVar8.health - 125);
            }

            oVar8.health = (short)(sVar6 - (iVar4 + ((iVar9 >> 4) - (iVar4 >> 31)) * -50));
            oVar8.FUN_4FE30();

            if (0 < oVar8.health)
                return;

            uVar6 = (ushort)(oVar8.DAT_3C | oVar8.DAT_3D << 8);

            if (uVar6 == 0x905 || uVar6 == 0xc05 || uVar6 == 0xd05) goto LAB_3780C;

            oVar8.DAT_3C = 3;
            oVar8.DAT_3D = 0;
            oVar8.DAT_3E = 0;
            oVar8.DAT_3F = 0;

            if ((ushort)(sVar2 - 0x400) < 0x800U)
            {
                oVar8.DAT_3F = 0;
                goto LAB_3780C;
            }
        }
        else
        {
            if (DAT_1C4 != 0)
                return;

            DAT_1C4 = 1;

            if (oVar8.DAT_98 == DAT_98)
                oVar8.DAT_98 = oVar8.DAT_1E0;

            if ((ushort)(sVar2 - 0x200) < 0xc00U)
            {
                if ((ushort)(sVar2 - 0x200) < 0x400U)
                    uVar7 = 1;
                else
                {
                    if ((ushort)(sVar2 - 0x600) < 0x400U)
                        uVar7 = 2;
                    else
                        uVar7 = 3;
                }
            }
            else
                uVar7 = 0;

            oVar8.FUN_53A2C(1, uVar7);
            //FUN_1D988

            if ((oVar8.DAT_11E & 1) != 0)
                return;

            if (oVar8.health < 1)
                return;

            iVar4 = (int)GameManager.FUN_64650();
            oVar8.health = (short)((oVar8.health - 125) - (iVar4 + (iVar4 / 50) * -50));
            oVar8.FUN_4FE30();

            if (0 < oVar8.health)
                return;

            oVar8.DAT_3C = 3;
            oVar8.DAT_3D = 0;
            oVar8.DAT_3E = 0;
            oVar8.DAT_3F = 0;

            if ((ushort)(sVar2 - 0x400) < 0x800U)
            {
                oVar8.DAT_3F = 0;
                goto LAB_3780C;
            }
        }

        oVar8.DAT_3F = 1;
        LAB_3780C:;
        //FUN_2ECAC
    }

    private void FUN_3783C()
    {
        CriPlayer oVar1;
        short sVar2;
        uint uVar3;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        DAT_1C4 = 0;
        GameManager.instance.FUN_65CB0(this);
        FUN_2E07C();

        if (UDAT_20C <= 2000 || (GameManager.FUN_64650() & 1) == 0)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_2D76C();

            if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 && 
                (oVar1.DAT_11E & 0x80) == 0)
            {
                DAT_1C2 = 2;
                sVar2 = FUN_64804(oVar1.screen);
                uVar3 = 0x1001;

                if ((sVar2 & 0x800) == 0)
                    uVar3 = 0x1101;

                DAT_3C = (byte)uVar3;
                DAT_3D = (byte)(uVar3 >> 8);
                DAT_3E = (byte)(uVar3 >> 0x10);
                DAT_3F = (byte)(uVar3 >> 0x18);
                GameManager.instance.FUN_65C7C(this);
                FUN_65CF8(0, 0, 30);
            }
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 22;
            DAT_3E = 0;
            DAT_3F = 0;
            BDAT_1CA = 0;
            V2_1F0 = new Vector2Int(oVar1.screen.x, oVar1.screen.z);
        }
    }

    private void FUN_37974()
    {
        CriPlayer oVar1;
        short sVar2;
        uint uVar3;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        GameManager.instance.FUN_65CB0(this);

        if ((oVar1.DAT_3C == 5 && oVar1.DAT_3D == 9) || (oVar1.DAT_3C == 5 && oVar1.DAT_3D == 10))
        {
            if (UDAT_20C < 2200)
            {
                DAT_3C = 1;
                DAT_3D = 22;
                DAT_3E = 0;
                DAT_3F = 0;
                FUN_2E07C();
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 5;
                DAT_3E = 0;
                DAT_3F = 0;
            }
        }
        else
        {
            FUN_2E07C();

            if (UDAT_20C <= 2000 || (GameManager.FUN_64650() & 1) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
                FUN_2D76C();

                if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 && 
                    (oVar1.DAT_11E & 0x80) == 0)
                {
                    DAT_1C2 = 2;
                    sVar2 = FUN_64804(oVar1.screen);
                    uVar3 = 0x1001;

                    if ((sVar2 & 0x800) == 0)
                        uVar3 = 0x1101;

                    DAT_3C = (byte)uVar3;
                    DAT_3D = (byte)(uVar3 >> 8);
                    DAT_3E = (byte)(uVar3 >> 0x10);
                    DAT_3F = (byte)(uVar3 >> 0x18);
                    GameManager.instance.FUN_65C7C(this);
                    FUN_65CF8(0, 0, 30);
                }
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 22;
                DAT_3E = 0;
                DAT_3F = 0;
                BDAT_1CA = 0;
                V2_1F0 = new Vector2Int(oVar1.screen.x, oVar1.screen.z);
            }
        }
    }

    private void FUN_37AFC()
    {
        uint uVar1;

        FUN_609C8(31, 0, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_65C7C(this);
        DAT_1C4 = 0;
        uVar1 = UDAT_20C / 15;
        UDAT_1E4 = (ushort)uVar1;

        if ((uVar1 & 0xffff) < 50)
            UDAT_1E4 = 50;

        if (150U < UDAT_1E4)
            UDAT_1E4 = 150;

        DAT_208 &= 0xffff7fff;
        DAT_3E++;
    }

    private void FUN_37BB0()
    {
        short sVar1;
        short sVar2;
        int iVar3;
        bool bVar3;

        bVar3 = FUN_60AB4();

        if (bVar3)
        {
            DAT_1C4 = 0;
            PTR_FUN_9BFF0[DAT_2F]();
        }

        if (DAT_60 == 18 && 3000 < UDAT_20C)
            DAT_3E++;
        else
        {
            if (DAT_60 == 22)
                GameManager.instance.FUN_5C94C(this, 64);

            if (DAT_60 - 20U < 10)
                DAT_40.z = (Utilities.DAT_9C094[DAT_60 - 20] * UDAT_1E4) / 100;
            else
                DAT_40.z = 0;

            sVar1 = (short)Utilities.FUN_615EC(screen, SceneManager.instance.DAT_27C[10].screen);
            iVar3 = (int)GameManager.FUN_64650();
            sVar2 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar3 % 15 + 20) * 0x10000 >> 0x10), sVar1);
            vr.y = vr.y + sVar2 & 0xfff;

            if (DAT_1C4 != 0)
                ; //FUN_2F9A0
        }
    }

    private void FUN_37D4C()
    {
        FUN_609C8(35, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
    }

    private void FUN_37D94()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_2D76C();
            FUN_65CF8(0, 0, 30);
            GameManager.instance.FUN_65CB0(this);
        }
    }

    private void FUN_37DEC()
    {
        PTR_FUN_9C0A8[DAT_3E]();
    }

    private void FUN_37E28()
    {
        sbyte sVar1;
        byte bVar2;
        uint uVar3;
        Vector3Int local_20;
        Vector2Int auStack24;

        local_20 = new Vector3Int(V2_1F0.x, 0, V2_1F0.y);
        uVar3 = Utilities.FUN_631AC(SceneManager.instance.DAT_27C[10].screen, local_20);

        if (uVar3 <= 300 && 1199 < UDAT_20C && (DAT_128 & 0x3ff) == 0)
        {
            if ((DAT_162 & 2) != 0)
            {
                bVar2 = 0;

                if ((DAT_208 & 0x80) == 0)
                {
                    do
                    {
                        FUN_2DE6C();
                        local_20 = new Vector3Int(V3_224.x, 0, V3_224.z);
                        auStack24 = new Vector2Int();
                        sVar1 = SceneManager.instance.FUN_64D20(this, local_20, ref auStack24);

                        if (sVar1 == 0)
                        {
                            bVar2 = (byte)(BDAT_1CA + bVar2);
                            BDAT_1CA = bVar2;

                            if (bVar2 < 5U)
                            {
                                DAT_208 |= 0x80;
                                return;
                            }
                            else
                            {
                                DAT_3C = 1;
                                DAT_3D = 2;
                                DAT_3E = 0;
                                DAT_3F = 0;
                                return;
                            }
                        }

                        bVar2++;
                    } while (bVar2 < 5U);

                    DAT_3C = 1;
                    DAT_3D = 2;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
            }
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
        }
    }

    private void FUN_37F60()
    {
        CriPlayer oVar2;

        FUN_609C8(5, 1, 5);
        DAT_40 = new Vector3Int(0, 0, 0);

        if ((DAT_208 & 0x800000) == 0)
            FUN_65CF8(1, 0, 30);
        else
            DAT_208 &= 0xff7fffff;

        BDAT_1CA = 0;
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        DAT_208 &= 0xffffff7f;
        V2_1F0 = new Vector2Int(oVar2.screen.x, oVar2.screen.z);
        FUN_2DB80();
        DAT_3E++;
    }

    private void FUN_38018()
    {
        byte bVar1;
        short sVar2;
        short sVar3;
        int iVar4;
        uint uVar5;
        uint uVar6;

        FUN_60AB4();

        if (DAT_60 == 7)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 50)
            GameManager.instance.FUN_5C94C(this, 49);

        if (DAT_60 == 2)
        {
            iVar4 = (int)GameManager.FUN_64650();
            uVar5 = (uint)(iVar4 % 3 & 0xff);

            if (uVar5 == 1)
                uVar6 = 70;
            else
            {
                uVar6 = 71;

                if (uVar5 != 2) goto LAB_380CC;
            }

            GameManager.instance.FUN_5C94C(this, (int)uVar6);
        }

        LAB_380CC:
        if (DAT_60 < 6U || DAT_60 - 26U < 24 || DAT_60 - 66U < 18)
        {
            uVar5 = Utilities.FUN_631AC(screen, V3_224);

            if (uVar5 < 1000)
            {
                if ((DAT_208 & 0x80) != 0)
                    DAT_208 &= 0xffffff7f;

                FUN_2DE6C();
                bVar1 = (byte)(BDAT_1CA + 1);
                BDAT_1CA = bVar1;

                if (4 < bVar1)
                {
                    DAT_3C = 1;
                    DAT_3D = 2;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
            }

            sVar2 = (short)Utilities.FUN_615EC(screen, V3_224);
            iVar4 = (int)GameManager.FUN_64650();
            sVar3 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar4 % 15 + 10) * 0x10000 >> 0x10), sVar2);
            vr.y = vr.y + sVar3 & 0xfff;
            DAT_40.z = Utilities.DAT_9C0B8[DAT_60];
        }
        else
            DAT_40.z = 0;
    }

    private void FUN_381FC()
    {
        PTR_FUN_9C160[DAT_3E]();
    }

    private void FUN_38238(CriPlayer param1)
    {
        byte bVar1;
        ushort uVar2;
        int iVar3;

        if (param1.health < 1)
            return;

        iVar3 = GameManager.instance.FUN_64C80();

        if (iVar3 != 0)
            param1.DAT_1CA -= (short)iVar3;

        uVar2 = (ushort)(param1.DAT_1E6 - 1);
        param1.DAT_1E6 = uVar2;

        if (uVar2 < 106)
        {
            iVar3 = (int)GameManager.FUN_64650();
            bVar1 = (byte)((iVar3 % 2) + 2);
        }
        else
        {
            bVar1 = 1;

            if (0 < param1.DAT_1CA) goto LAB_382DC;
        }

        param1.DAT_1E5 = bVar1;

        LAB_382DC:
        if ((param1.DAT_11E & 1) == 0 && DAT_60 == 2)
        {
            iVar3 = (int)GameManager.FUN_64650();
            param1.health = (short)((param1.health - 100) - (iVar3 + (iVar3 / 20) * -20));
            param1.FUN_4FE30();

            if (param1.health < 1)
            {
                if ((DAT_208 & 0x8000000) != 0)
                {
                    DAT_208 &= 0xf7ffffff;
                    SceneManager.instance.FUN_26E6C();
                }

                //FUN_2ECAC
            }
        }
    }

    private void FUN_383A0(CriPlayer param1)
    {
        byte bVar1;
        ushort uVar2;
        int iVar3;

        if (0 < param1.health)
        {
            iVar3 = GameManager.instance.FUN_64C80();

            if (iVar3 != 0)
                param1.DAT_1CA -= (short)iVar3;

            uVar2 = (ushort)(param1.DAT_1E6 - 1);
            param1.DAT_1E6 = uVar2;
            bVar1 = 2;

            if (uVar2 < 106)
                param1.DAT_1E5 = bVar1;
            else
            {
                bVar1 = 1;

                if (param1.DAT_1CA < 1)
                    param1.DAT_1E5 = bVar1;
            }

            if ((param1.DAT_11E & 1) == 0 && DAT_60 == 2)
            {
                iVar3 = (int)GameManager.FUN_64650();
                param1.health = (short)((param1.health - 100) - (iVar3 + (iVar3 / 20) * -20));
                param1.FUN_4FE30();

                if (param1.health < 1)
                {
                    if ((DAT_208 & 0x8000000) != 0)
                    {
                        DAT_208 &= 0xf7ffffff;
                        SceneManager.instance.FUN_26E6C();
                    }

                    //FUN_2ECAC
                }
            }
        }
    }

    private void FUN_384E4(CriPlayer param1)
    {
        ushort uVar1;
        int iVar2;

        if (0 < param1.health)
        {
            iVar2 = GameManager.instance.FUN_64C80();

            if (iVar2 != 0)
                param1.DAT_1CA -= (short)iVar2;

            if (param1.DAT_1CA < 1 || (param1.DAT_1E6 = (uVar1 = (ushort)(param1.DAT_1E6 - 1))) << 0x10 < 1)
                param1.DAT_1E5 = 1;

            if ((param1.DAT_11E & 1) == 0 && DAT_60 == 2)
            {
                iVar2 = (int)GameManager.FUN_64650();
                param1.health = (short)((param1.health - 100) - (iVar2 + (iVar2 / 20) * -20));
                param1.FUN_4FE30();

                if (param1.health < 1)
                {
                    if ((DAT_208 & 0x8000000) != 0)
                    {
                        DAT_208 &= 0xf7ffffff;
                        SceneManager.instance.FUN_26E6C();
                    }

                    //FUN_2ECAC
                }
            }
        }
    }

    private void FUN_38620(CriPlayer param1)
    {
        byte bVar1;
        ushort uVar2;
        int iVar3;

        if (0 < param1.health)
        {
            iVar3 = GameManager.instance.FUN_64C80();

            if (iVar3 != 0)
                param1.DAT_1CA -= (short)iVar3;

            uVar2 = (ushort)(param1.DAT_1E6 - 1);
            param1.DAT_1E6 = uVar2;
            bVar1 = 3;

            if (uVar2 < 106)
                param1.DAT_1E5 = bVar1;
            else
            {
                bVar1 = 1;

                if (param1.DAT_1CA < 1)
                    param1.DAT_1E5 = bVar1;
            }

            if ((param1.DAT_11E & 1) == 0 && DAT_60 == 2)
            {
                iVar3 = (int)GameManager.FUN_64650();
                param1.health = (short)((param1.health - 100) - (iVar3 + (iVar3 / 20) * -20));
                param1.FUN_4FE30();

                if (param1.health < 1)
                {
                    if ((DAT_208 & 0x8000000) != 0)
                    {
                        DAT_208 &= 0xf7ffffff;
                        SceneManager.instance.FUN_26E6C();
                    }

                    //FUN_2ECAC
                }
            }
        }
    }

    private void FUN_38764()
    {
        CriPlayer oVar2;

        FUN_609C8(34, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_656EC();
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar2.DAT_152 = 1;
        DAT_152 = 1;
        oVar2.DAT_154 = this;
        DAT_154 = oVar2;
        oVar2.vr.y = vr.y;
        DAT_3E++;
    }

    private void FUN_387E0()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;

        FUN_65714();
        //FUN_2F9E0
    }

    private void FUN_3883C()
    {
        CriPlayer oVar1;

        FUN_609C8(32, 1, 0);
        FUN_65714();
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar1.DAT_1CA = 30;
        oVar1.DAT_1E6 = 174;
        oVar1.DAT_1E5 = 0;
        DAT_3E++;
    }

    private void FUN_388A8()
    {
        byte bVar1;
        bool bVar3;
        CriCamera oVar3;
        uint uVar4;
        CriPlayer oVar6;

        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar3 = FUN_60AB4();
        bVar1 = oVar6.DAT_1E5;

        if (!bVar3 || bVar1 == 0) goto LAB_38994;

        if (bVar1 == 2)
            uVar4 = 0x2101;
        else
        {
            if (bVar1 < 3)
            {
                if (bVar1 == 1)
                    DAT_3E++;

                goto LAB_38994;
            }

            uVar4 = 0x2001;

            if (bVar1 != 3) goto LAB_38994;
        }

        DAT_3C = (byte)uVar4;
        DAT_3D = (byte)(uVar4 >> 8);
        DAT_3E = (byte)(uVar4 >> 0x10);
        DAT_3F = (byte)(uVar4 >> 0x18);
        GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
        bVar3 = InventoryManager.FUN_4A87C(0, 0xc9);

        if (!bVar3)
        {
            DAT_208 &= 0xf7ffffff;
            SceneManager.instance.FUN_26E6C();
        }
        else
            InventoryManager.FUN_4A7E8(0, 0xc9, false);

        LAB_38994:
        FUN_65714();

        if (DAT_60 == 2 && (DAT_208 & 0x8000000) == 0)
        {
            bVar3 = InventoryManager.FUN_4A87C(0, 0xc9);

            if (!bVar3)
            {
                DAT_208 |= 0x8000000;
                SceneManager.instance.FUN_26E1C();
                oVar3 = SceneManager.instance.cCamera;
                oVar3.DAT_72 |= 4;
                oVar3.DAT_70 = 1;
                oVar3.PTR_FUN_8C = SceneManager.instance.cCamera.FUN_2EDE4;
                oVar3.DAT_64 = this;
            }
        }

        if (DAT_60 == 8)
        {
            //...
        }

        if (DAT_60 == 25)
        {
            //...
        }

        if (oVar6.DAT_1E5 == 0)
            PTR_FUN_9C1B8[DAT_2F](oVar6);
    }

    private void FUN_38ABC()
    {
        bool bVar1;

        FUN_609C8(33, 0, 0);
        FUN_65714();
        SceneManager.instance.cCamera.DAT_72 &= 0xfb;
        bVar1 = InventoryManager.FUN_4A87C(0, 0xc9);

        if (!bVar1)
        {
            DAT_208 &= 0xf7ffffff;
            SceneManager.instance.FUN_26E6C();
        }
        else
            InventoryManager.FUN_4A7E8(0, 0xc9, false);

        SceneManager.instance.DAT_27C[10].DAT_3E++;
        DAT_3E++;
    }

    private void FUN_38B78()
    {
        CriPlayer oVar1;
        bool bVar2;
        short sVar3;
        uint uVar4;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar2 = FUN_60AB4();

        if (bVar2)
        {
            DAT_18D = true;
            oVar1.DAT_18D = true;
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_2D76C();
            GameManager.instance.FUN_65CB0(this);

            if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 && 
                (oVar1.DAT_11E & 0x80) == 0)
            {
                DAT_1C2 = 2;
                sVar3 = FUN_64804(oVar1.screen);
                uVar4 = 0x1001;

                if ((sVar3 & 0x800) == 0)
                    uVar4 = 0x1101;

                DAT_3C = (byte)uVar4;
                DAT_3D = (byte)(uVar4 >> 8);
                DAT_3E = (byte)(uVar4 >> 0x10);
                DAT_3F = (byte)(uVar4 >> 0x18);
                GameManager.instance.FUN_65C7C(this);
                FUN_65CF8(0, 0, 30);
            }
        }

        FUN_65714();

        if (DAT_60 == 23)
            GameManager.instance.FUN_5C94C(this, 60);
    }

    private void FUN_38C94()
    {
        PTR_FUN_9C1DC[DAT_3E]();
    }

    private void FUN_38CD0()
    {
        FUN_609C8(60, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_656EC();
        DAT_18D = true;
        SceneManager.instance.DAT_27C[10].DAT_18D = true;
        FUN_65CF8(0, 0, 30);
        DAT_3E++;
    }

    private void FUN_38D48()
    {
        bool bVar1;
        CriPlayer oVar3;

        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;

        FUN_65714();

        if (DAT_60 == 11)
        {
            GameManager.instance.FUN_5C94C(this, 64);
            oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
            oVar3.DAT_3C = 5;
            oVar3.DAT_3D = 14;
            oVar3.DAT_3E = 0;
            oVar3.DAT_3F = 0;
            FUN_65C4C(oVar3);
            oVar3.DAT_152 = 1;
            oVar3.DAT_11E &= 0xdf;
            DAT_152 = 1;
            oVar3.DAT_154 = this;
            DAT_154 = oVar3;
            oVar3.DAT_11E |= 8;
            oVar3.DAT_14C.x = DAT_14C.x;
            oVar3.DAT_14C.z = DAT_14C.z;
            oVar3.vr.y = vr.y;
            //FUN_1D988
        }

        if (DAT_60 == 12)
            ; //FUN_65D1C
    }

    private void FUN_38E58()
    {
        CriPlayer oVar1;

        FUN_609C8(61, 1, 0);
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar1.DAT_1CA = 82;
        oVar1.DAT_1C9 = 6;
        oVar1.DAT_1E5 = 0;
        FUN_65714();
        DAT_3E++;
    }

    private void FUN_38EC4()
    {
        short sVar2;
        bool bVar3;
        int iVar3;
        CriPlayer oVar4;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar3 = FUN_60AB4();

        if (bVar3)
        {
            if (oVar4.DAT_1E5 == 0)
            {
                FUN_609C8(61, 1, 0);
                local_38 = new Vector3Int(0, 0, -989);
                MStack48 = new Matrix3x3();
                Utilities.RotMatrix(ref vr, ref MStack48);
                local_38 = Utilities.ApplyMatrixSV(ref MStack48, ref local_38);
                DAT_14C.x += local_38.x;
                DAT_14C.z += local_38.z;
                oVar4.DAT_14C.x = DAT_14C.x;
                oVar4.DAT_14C.z = DAT_14C.z;
            }
            else
            {
                oVar4.DAT_3E++;
                DAT_3E++;
            }
        }

        FUN_65714();

        if (DAT_60 == 9)
        {
            //...
        }

        if (DAT_60 == 27)
        {
            //...
        }

        if (0 < oVar4.health && oVar4.DAT_1E5 == 0)
        {
            bVar3 = GameManager.FUN_64C68();

            if (!bVar3)
                sVar2 = (short)(oVar4.DAT_1CA - 1);
            else
                sVar2 = (short)(oVar4.DAT_1CA - oVar4.DAT_1C9);

            oVar4.DAT_1CA = sVar2;

            if (oVar4.DAT_1CA < 0)
                oVar4.DAT_1E5 = 1;

            if ((oVar4.DAT_11E & 1) == 0 && DAT_60 == 2)
            {
                iVar3 = (int)GameManager.FUN_64650();
                oVar4.health = (short)((oVar4.health - 40) - (iVar3 + (iVar3 / 20) * -20));
                oVar4.FUN_4FE30();

                if (oVar4.health < 1)
                    ; //FUN_2ECAC
            }
        }
    }

    private void FUN_39100()
    {
        FUN_609C8(62, 1, 0);
        FUN_65714();
        DAT_3E++;
    }

    private void FUN_3914C()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;

        FUN_65714();

        if (DAT_60 == 25)
            GameManager.instance.FUN_5C94C(this, 60);
    }

    private void FUN_391AC()
    {
        FUN_6103C(15, 0, 5, 5);
        DAT_3E++;
    }

    private void FUN_391F8()
    {
        CriPlayer oVar1;
        bool bVar2;
        int iVar2;

        bVar2 = FUN_60AB4();
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (bVar2)
        {
            DAT_18D = true;
            iVar2 = (int)GameManager.FUN_64650();
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1C8 = (sbyte)(iVar2 + (iVar2 / 10) * -10 + 20);
            FUN_2D76C();
            FUN_2E07C();
            GameManager.instance.FUN_65CB0(this);
            oVar1.DAT_152 = 0;
            DAT_152 = 0;
            oVar1.DAT_11E &= 0xf7;
        }
    }

    private void FUN_392B8()
    {
        PTR_FUN_9C294[DAT_3E]();
    }

    private void FUN_392F4()
    {
        short sVar1;
        short sVar2;
        byte bVar4;
        CriBone oVar5;

        if ((DAT_18E & 4) != 0)
            return;

        bVar4 = DAT_1DA;

        if (bVar4 != 0)
        {
            DAT_1DA = (byte)(bVar4 - 1);

            if (bVar4 != 1)
                return;

            if ((DAT_208 & 0x200000) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 6;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_208 &= 0xffdfffff;
            }

            FUN_65CF8(0, 0, 30);
            FUN_2D76C();
            FUN_2DF3C();
            return;
        }

        oVar5 = (CriBone)Utilities.FUN_601C8(skeleton, 3);
        sVar1 = (short)vr.y;
        sVar2 = (short)oVar5.vr.y;
        //...
    }

    private void FUN_39614()
    {
        uint uVar1;

        if ((DAT_208 & 0x100000) == 0)
        {
            uVar1 = SceneManager.instance.FUN_65FD8(this);
            uVar1 &= 0xff;
            uVar1 = uVar1 - (((uint)((ulong)uVar1 * 0xcccccccd >> 0x20) & 0xfffffffc) + uVar1 / 5) & 0xff;
            FUN_6103C(5, 1, (byte)(uVar1 * 9), 5);
            DAT_60 = Utilities.DAT_9C2B4[uVar1];
        }
        else
            FUN_609C8(5, 1, 10);

        DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_77238((byte)DAT_48, ref V4_21C);
        DAT_208 &= 0xffeffffe;
        FUN_65CF8(5, 0, 30);
        DAT_3E++;
    }

    private void FUN_39724()
    {
        short sVar1;
        short sVar2;
        int iVar3;
        uint uVar4;
        uint uVar5;
        Vector3Int local_18;

        FUN_60AB4();

        if (DAT_60 == 7)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 50)
            GameManager.instance.FUN_5C94C(this, 49);

        if (DAT_60 == 2)
        {
            iVar3 = (int)GameManager.FUN_64650();
            uVar4 = (uint)(iVar3 % 3 & 0xff);

            if (uVar4 == 1)
                uVar5 = 70;
            else
            {
                uVar5 = 71;

                if (uVar4 != 2) goto LAB_397D8;
            }

            GameManager.instance.FUN_5C94C(this, (int)uVar5);
        }

        LAB_397D8:
        if (DAT_60 < 6U || DAT_60 - 26U < 24 || DAT_60 - 66U < 18)
        {
            local_18 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);
            sVar1 = (short)Utilities.FUN_615EC(screen, local_18);
            iVar3 = (int)GameManager.FUN_64650();
            sVar2 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar3 % 15 + 20) * 0x10000 >> 0x10), sVar1);
            vr.y = vr.y + sVar2 & 0xfff;
            DAT_40.z = Utilities.DAT_9C2BC[DAT_60];
        }
        else
            DAT_40.z = 0;

        if (DAT_1C7 == 0)
        {
            uVar4 = Utilities.FUN_631AC(screen, (Vector3Int)V4_21C);

            if (uVar4 < 650)
                GameManager.instance.FUN_77238((byte)DAT_48, ref V4_21C);
        }
    }

    private void FUN_398F8()
    {
        PTR_FUN_9C364[DAT_3E]();
    }

    private void FUN_39934()
    {
        byte bVar2;
        short sVar3;
        CriPlayer oVar7;

        if ((DAT_18E & 4) != 0)
            return;

        bVar2 = DAT_1DA;

        if (bVar2 != 0)
        {
            DAT_1DA = (byte)(bVar2 - 1);

            if (bVar2 != 1)
                return;

            DAT_3C = 1;
            DAT_3D = 0x1b;
            DAT_3E = 0;
            DAT_3F = 0;
            return;
        }

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        sVar3 = FUN_64804(oVar7.screen);
        //...
    }

    private void FUN_39E30()
    {
        byte bVar1;
        uint uVar2;

        uVar2 = SceneManager.instance.FUN_65FD8(this);
        FUN_6103C(2, 9, (byte)((uVar2 & 3) * 3), 5);
        bVar1 = Utilities.DAT_9C36C[uVar2 & 3];
        PTR_124 = DAT_9B404;
        DAT_124 = 12;
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_12F = 1;
        DAT_60 = bVar1;
        DAT_3E++;
    }

    private void FUN_39EBC()
    {
        PTR_FUN_9C370[DAT_3E]();
    }

    private void FUN_39EF8()
    {
        FUN_609C8(3, 1, 5);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
    }

    private void FUN_39F40()
    {
        FUN_60AB4();

        if (DAT_60 == 40)
            DAT_3E++;
    }

    private void FUN_39F88()
    {
        FUN_6103C(18, 0, 9, 0);
        PTR_124 = DAT_9B404;
        DAT_124 = 7;
        DAT_12F = 2;
        DAT_3E++;
    }

    private void FUN_39FE0()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            if (health < 1 && BDAT_1DC == 3)
            {
                DAT_3C = 2;
                DAT_3D = 5;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                if (DAT_48 == SceneManager.instance.DAT_27C[10].DAT_48)
                {
                    if ((DAT_208 & 8) == 0)
                    {
                        DAT_3C = 1;
                        DAT_3D = 2;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        FUN_2D76C();
                        FUN_2DF3C();
                    }
                    else
                    {
                        DAT_3C = 1;
                        DAT_3D = 25;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        DAT_208 = DAT_208 & 0xfffffff7 | 0x100000;
                    }
                }
                else
                {
                    DAT_3C = 1;
                    DAT_3D = 35;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_1DB = DAT_48;
                }
            }
        }

        if (DAT_60 == 7)
            GameManager.instance.FUN_5C94C(this, 63);
    }

    private void FUN_3A0C8()
    {
        PTR_FUN_9C378[DAT_3E]();
    }

    private void FUN_3A104()
    {
        FUN_609C8(4, 0, 5);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
    }

    private void FUN_3A14C()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 26;
            DAT_3E = 0;
            DAT_3F = 0;
        }
    }

    private void FUN_3A180()
    {
        PTR_FUN_9C388[DAT_3E]();
    }

    private void FUN_3A1BC()
    {
        FUN_609C8(11, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_208 &= 0xfffff7ff;
        DAT_3E++;
    }

    private void FUN_3A214()
    {
        bool bVar1;
        uint uVar2;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            uVar2 = DAT_208;

            if ((uVar2 & 0x800) != 0)
            {
                DAT_208 = uVar2 | 0x2000;
                PTR_218.DAT_3C = 1;
                PTR_218.DAT_3D = 29;
                PTR_218.DAT_3E = 0;
                PTR_218.DAT_3F = 0;
                uVar2 = DAT_208;
            }

            if ((uVar2 & 0x2000) != 0)
                DAT_208 = uVar2 & 0x2000;

            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_2D76C();
        }

        if (DAT_60 == 6)
            GameManager.instance.FUN_5C94C(this, 72);

        if (39U < DAT_60 && (DAT_208 & 0x2800) == 0)
            DAT_208 |= 0x800;
    }

    private void FUN_3A2D4()
    {
        PTR_FUN_9C390[DAT_3E]();
    }

    private void FUN_3A310()
    {
        short sVar1;
        int iVar2;
        bool bVar2;
        ushort uVar3;
        short sVar3;
        short sVar4;
        int iVar6;
        uint uVar5;
        CriPlayer oVar7;
        int iVar8;

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar7.DAT_11E & 0x80) != 0)
            return;

        bVar2 = SceneManager.instance.FUN_81014(screen, oVar7.screen, (byte)(DAT_48 << 4 | 0xf), false);

        if (bVar2)
            return;

        if (12U < DAT_60 && (DAT_162 & 1) != 0)
        {
            sVar1 = oVar7.FUN_64804(screen);

            if (DAT_1C4 != 0) goto LAB_3A740;

            if ((DAT_12B & 4) == 0 || 0x10U < DAT_60)
            {
                if (DAT_1C4 != 0) goto LAB_3A740;

                DAT_1C4 = 1;

                if (oVar7.DAT_98 == DAT_98)
                    oVar7.DAT_98 = oVar7.DAT_1E0;

                if ((ushort)(sVar1 - 0x201) < 0x400U)
                    uVar5 = 1;
                else
                {
                    if ((ushort)(sVar1 - 0xa01) < 0x400U)
                        uVar5 = 3;
                    else
                    {
                        uVar5 = 2;

                        if (0xbffU < (ushort)(sVar1 - 0x201))
                            uVar5 = 0;
                    }
                }

                oVar7.FUN_53A2C(1, uVar5);
                //FUN_1D988
                GameManager.instance.FUN_5C94C(this, 64);
            }
            else
            {
                DAT_1C4 = 1;

                if (oVar7.DAT_98 == DAT_98)
                    oVar7.DAT_98 = oVar7.DAT_1E0;

                if ((ushort)(sVar1 - 0x201) < 0x400U)
                {
                    oVar7.FUN_53A2C(1, 1);
                    uVar5 = 0x40;
                }
                else
                {
                    if ((ushort)(sVar1 - 0xa01) < 0x400U)
                    {
                        oVar7.FUN_53A2C(1, 3);
                        uVar5 = 0x40;
                    }
                    else
                    {
                        if ((ushort)(sVar1 - 0x201) < 0xc00U)
                        {
                            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                            oVar7.DAT_3C = 5;
                            oVar7.DAT_3D = 9;
                            oVar7.DAT_3E = 0;
                            oVar7.DAT_3F = 0;
                            oVar7.DAT_1F0 = this;
                            FUN_65C4C(oVar7);
                            GameManager.instance.FUN_5C94C(this, 64);
                            //FUN_1D988
                            goto LAB_3A5D4;
                        }

                        GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                        oVar7.DAT_3C = 5;
                        oVar7.DAT_3D = 15;
                        oVar7.DAT_3E = 0;
                        oVar7.DAT_3F = 0;
                        FUN_65C4C(oVar7);
                        oVar7.vr.y = (short)(vr.y + 0x800 & 0xfff);
                        oVar7.DAT_14C.x = screen.x;
                        uVar5 = 0x3e;
                        oVar7.DAT_14C.z = screen.z;
                        DAT_18D = false;
                        oVar7.DAT_18D = false;
                    }
                }

                GameManager.instance.FUN_5C94C(this, (int)uVar5);
                //FUN_1D988
            }

            LAB_3A5D4:
            if ((oVar7.DAT_11E & 1) == 0 && 0 < oVar7.health)
            {
                if (oVar7.DAT_3C == 5 && oVar7.DAT_3D == 15 && oVar7.DAT_3E == 0 && oVar7.DAT_3F == 0)
                {
                    iVar2 = (int)GameManager.FUN_64650();
                    iVar8 = (int)((ulong)((long)iVar2 * 0x51eb851f) >> 0x20);
                    sVar3 = (short)(iVar2 >> 31);
                    sVar4 = (short)(oVar7.health - 175);
                }
                else
                {
                    if (oVar7.DAT_3C == 5 && oVar7.DAT_3D == 9)
                    {
                        iVar2 = (int)GameManager.FUN_64650();
                        iVar8 = (int)((ulong)((long)iVar2 * 0x51eb851f) >> 0x20);
                        sVar3 = (short)(iVar2 >> 31);
                        sVar4 = (short)(oVar7.health - 150);
                    }
                    else
                    {
                        iVar2 = (int)GameManager.FUN_64650();
                        iVar8 = (int)((ulong)((long)iVar2 * 0x51eb851f) >> 0x20);
                        sVar3 = (short)(iVar2 >> 31);
                        sVar4 = (short)(oVar7.health - 125);
                    }
                }

                oVar7.health = (short)(sVar4 - (iVar2 + ((iVar8 >> 4) - sVar3) * -50));
                oVar7.FUN_4FE30();

                if (oVar7.health < 1)
                {
                    uVar3 = (ushort)(oVar7.DAT_3C | oVar7.DAT_3D << 8);

                    if (uVar3 == 0x905)
                    {
                        if (uVar3 == 0xf05)
                            iVar6 = 0x800;
                        else
                            iVar6 = sVar1;
                    }
                    else
                    {
                        if (uVar3 != 0xf05)
                        {
                            oVar7.DAT_3C = 3;
                            oVar7.DAT_3D = 0;
                            oVar7.DAT_3E = 0;
                            oVar7.DAT_3F = 0;

                            if ((ushort)(sVar1 - 0x400) < 0x800U)
                                oVar7.DAT_3F = 0;
                            else
                                oVar7.DAT_3F = 1;

                            if (uVar3 == 0xf05)
                                iVar6 = 0x800;
                            else
                                iVar6 = sVar1;
                        }

                        iVar6 = 0x800;
                    }

                    //FUN_2ECAC
                }
            }
        }

        if (DAT_1C4 == 0)
            return;

        LAB_3A740:;
        //FUN_2F9A0
    }

    private void FUN_3A76C(CriPlayer param1)
    {
        short sVar1;
        uint uVar2;

        GameManager.instance.FUN_65CB0(this);
        sVar1 = FUN_64804(param1.screen);

        if (DAT_1C4 == 0)
        {
            if ((ushort)(sVar1 - 257) < 0xdffU)
            {
                DAT_3C = 1;
                DAT_3D = 15;
                DAT_3E = 0;
                DAT_3F = 0;
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                goto LAB_3A890;
            }

            if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 && 
                (param1.DAT_11E & 0x80) == 0)
            {
                DAT_1C2 = 2;
                uVar2 = 0x1001;

                if ((sVar1 & 0x800) == 0)
                    uVar2 = 0x1101;

                DAT_3C = (byte)uVar2;
                DAT_3D = (byte)(uVar2 >> 8);
                DAT_3E = (byte)(uVar2 >> 0x10);
                DAT_3F = (byte)(uVar2 >> 0x18);
                GameManager.instance.FUN_65C7C(this);
                FUN_65CF8(0, 0, 30);
                return;
            }
        }

        if ((ushort)(sVar1 - 0x401) < 0x7ffU)
        {
            uVar2 = 0x701;

            if (0x400U < (ushort)(sVar1 - 0x600))
                uVar2 = 0x801;
        }
        else
            uVar2 = 0x201;

        DAT_3C = (byte)uVar2;
        DAT_3D = (byte)(uVar2 >> 8);
        DAT_3E = (byte)(uVar2 >> 0x10);
        DAT_3F = (byte)(uVar2 >> 0x18);
        LAB_3A890:
        DAT_1C4 = 0;
    }

    private void FUN_3A8A8(CriPlayer param1)
    {
        short sVar1;
        uint uVar2;

        GameManager.instance.FUN_65CB0(this);
        sVar1 = FUN_64804(param1.screen);

        if (DAT_1C4 == 0)
        {
            if ((ushort)(sVar1 - 257) < 0xdffU)
            {
                DAT_3C = 1;
                DAT_3D = 15;
                DAT_3E = 0;
                DAT_3F = 0;
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                goto LAB_3AA00;
            }

            if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 &&
                (param1.DAT_11E & 0x80) == 0)
            {
                DAT_1C2 = 2;
                uVar2 = 0x1001;

                if ((sVar1 & 0x800) == 0)
                    uVar2 = 0x1101;

                DAT_3C = (byte)uVar2;
                DAT_3D = (byte)(uVar2 >> 8);
                DAT_3E = (byte)(uVar2 >> 0x10);
                DAT_3F = (byte)(uVar2 >> 0x18);
                GameManager.instance.FUN_65C7C(this);
                FUN_65CF8(0, 0, 30);
                return;
            }

            if ((ushort)(sVar1 - 0x401) < 0x7ffU)
            {
                uVar2 = 0x701;

                if (0x400U < (ushort)(sVar1 - 0x600))
                    uVar2 = 0x801;
            }
            else
                uVar2 = 0x201;
        }
        else
        {
            if ((param1.DAT_3C != 5 || param1.DAT_3D != 9) && (param1.DAT_3C != 5 || param1.DAT_3D != 10))
            {
                if ((ushort)(sVar1 - 0x401) < 0x7ffU)
                {
                    uVar2 = 0x701;

                    if (0x400U < (ushort)(sVar1 - 0x600))
                        uVar2 = 0x801;
                }
                else
                    uVar2 = 0x201;
            }
            else
            {
                uVar2 = 0x1601;

                if (2199 < UDAT_20C)
                    uVar2 = 0x501;
            }
        }

        DAT_3C = (byte)uVar2;
        DAT_3D = (byte)(uVar2 >> 8);
        DAT_3E = (byte)(uVar2 >> 0x10);
        DAT_3F = (byte)(uVar2 >> 0x18);
        LAB_3AA00:
        DAT_1C4 = 0;
    }

    private void FUN_3AA18()
    {
        FUN_609C8(59, 1, 5);
        GameManager.instance.FUN_5C94C(this, 66);
        DAT_1C4 = 0;
        DAT_40 = new Vector3Int(0, 0, 150);
        DAT_3E++;
    }

    private void FUN_3AA74()
    {
        sbyte sVar1;
        short sVar2;
        short sVar3;
        bool bVar4;
        int iVar5;
        CriPlayer oVar7;
        Vector3Int local_20;
        Vector2Int auStack24;

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar4 = FUN_60AB4();

        if (bVar4)
        {
            FUN_2D76C();
            FUN_64804(oVar7.screen);
            DAT_18D = true;
            oVar7.DAT_18D = true;
            PTR_FUN_9C408[DAT_2F](oVar7);
        }

        if (DAT_60 == 11)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 24)
            GameManager.instance.FUN_5C94C(this, 49);

        if (DAT_1C4 != 0 && 23U < DAT_60)
            DAT_40.z = 0;

        auStack24 = new Vector2Int();
        local_20 = oVar7.screen;
        sVar1 = SceneManager.instance.FUN_64D20(this, local_20, ref auStack24);

        if (sVar1 != 0)
            local_20 = new Vector3Int(DAT_10C.x, screen.y, DAT_10C.z);

        sVar2 = (short)Utilities.FUN_615EC(screen, local_20);
        iVar5 = (int)GameManager.FUN_64650();
        sVar3 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar5 & 15 + 30) * 0x10000 >> 0x10), sVar2);
        vr.y = vr.y + sVar3 & 0xfff;
    }

    private void FUN_3AC18()
    {
        PTR_FUN_9C42C[DAT_3E]();
    }

    private void FUN_3AC54()
    {
        short sVar2;
        int iVar3;
        uint uVar4;
        uint uVar5;
        CriPlayer oVar6;
        Vector3Int local_20;

        if (1U < DAT_3E)
        {
            oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];

            if (((oVar6.DAT_11E & 0x80) == 0 || DAT_1C4 != 0) && 
                !SceneManager.instance.FUN_81014(screen, oVar6.screen, (byte)(DAT_48 << 4 | 0xf), false))
            {
                if (DAT_1C4 == 0)
                {
                    if ((DAT_162 & 1) == 0 || (DAT_12B & 4) == 0)
                    {
                        local_20 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
                        uVar4 = Utilities.FUN_631AC(local_20, screen);

                        if (uVar4 <= 4000)
                        {
                            if ((DAT_162 & 2) != 0 && DAT_214 < 100)
                            {
                                DAT_1C4 = 1;
                                DAT_3E = 4;
                            }
                        }
                        else
                        {
                            DAT_3C = 1;
                            DAT_3D = 4;
                            DAT_3E = 0;
                            DAT_3F = 0;
                            GameManager.instance.FUN_65CB0(this);
                        }
                    }
                    else
                    {
                        sVar2 = oVar6.FUN_64804(screen);

                        if ((ushort)(sVar2 - 0x401) < 0x800U)
                        {
                            DAT_1C4 = 2;
                            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                            oVar6.DAT_3C = 5;
                            oVar6.DAT_3D = 9;
                            oVar6.DAT_3E = 0;
                            oVar6.DAT_3F = 0;
                            oVar6.DAT_1F0 = this;
                            FUN_65C4C(oVar6);
                            V2_1F4.x = screen.x;
                            V2_1F4.y = screen.z;
                        }
                        else
                        {
                            DAT_1C4 = 1;
                            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                            oVar6.DAT_3C = 5;
                            oVar6.DAT_3D = 0x10;
                            oVar6.DAT_3E = 0;
                            oVar6.DAT_3F = 0;
                            FUN_65C4C(oVar6);
                            oVar6.vr.y = (short)(vr.y + 0x800 & 0xfff);
                            DAT_18D = false;
                            oVar6.DAT_18D = false;
                        }

                        //FUN_1D988
                        GameManager.instance.FUN_5C94C(this, 63);

                        if ((oVar6.DAT_11E & 1) == 0 && 0 < oVar6.health)
                        {
                            if (oVar6.DAT_3C == 5 && oVar6.DAT_3D == 9)
                            {
                                iVar3 = (int)GameManager.FUN_64650();
                                oVar6.health = (short)((oVar6.health - 150) - (iVar3 + (iVar3 / 50) * -50));
                            }

                            oVar6.FUN_4FE30();

                            if (oVar6.health < 1)
                                ; //FUN_2ECAC
                        }
                    }
                }

                if (DAT_1C4 == 2)
                {
                    local_20 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
                    uVar4 = Utilities.FUN_631AC(local_20, screen);

                    if (uVar4 <= 2500)
                    {
                        if ((DAT_162 & 2) != 0 && DAT_214 < 100)
                        {
                            DAT_1C4 = 1;
                            DAT_3E = 4;
                        }
                    }
                    else
                    {
                        DAT_3C = 1;
                        DAT_3D = 4;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        GameManager.instance.FUN_65CB0(this);
                    }
                }

                uVar5 = Utilities.FUN_631AC(oVar6.screen, oVar6.DAT_34);
                UDAT_210 = uVar5;
            }
        }
    }

    private void FUN_3AFA4()
    {
        FUN_609C8(63, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_1C4 = 0;
        DAT_3E++;
    }

    private void FUN_3AFF0()
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        int iVar3;

        sVar2 = (short)DAT_64.z;
        bVar3 = FUN_60AB4();

        if (bVar3)
            DAT_3E++;

        DAT_40.z = sVar2 - DAT_64.z;
        sVar1 = (short)Utilities.FUN_615EC(screen, SceneManager.instance.DAT_27C[10].screen);
        iVar3 = (int)GameManager.FUN_64650();
        sVar2 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar3 % 15 + 30) * 0x10000 >> 0x10), sVar1);
        vr.y = vr.y + sVar2 & 0xfff;
    }

    private void FUN_3B0B8()
    {
        short sVar1;

        sVar1 = (short)DAT_64.z;
        FUN_609C8(64, 1, 0);
        DAT_40.z = sVar1 - DAT_64.z;
        DAT_3E++;
    }

    private void FUN_3B110()
    {
        short sVar1;
        short sVar2;
        bool bVar3;
        int iVar3;

        sVar2 = (short)DAT_64.z;
        bVar3 = FUN_60AB4();

        if (bVar3 && DAT_60 == 0)
            sVar2 = -1171;

        DAT_40.z = sVar2 - DAT_64.z;

        if (DAT_60 == 1)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 7)
            GameManager.instance.FUN_5C94C(this, 49);

        if (DAT_1C4 == 0)
        {
            sVar1 = (short)Utilities.FUN_615EC(screen, SceneManager.instance.DAT_27C[10].screen);
            iVar3 = (int)GameManager.FUN_64650();
            sVar2 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar3 % 15 + 30) * 0x10000 >> 0x10), sVar1);
            vr.y = vr.y + sVar2 & 0xfff;
        }
    }

    private void FUN_3B21C()
    {
        FUN_609C8(65, 1, 0);
        DAT_40.z = 0;
        GameManager.instance.FUN_5C94C(this, 75);
        DAT_3E++;
    }

    private void FUN_3B270()
    {
        short sVar1;
        bool bVar2;

        bVar2 = FUN_60AB4();

        if (bVar2)
        {
            FUN_6103C(16, 0, 4, 0);
            DAT_3C = 2;
            DAT_3D = 0;
            DAT_3E = 1;
            DAT_1C3 = 1;
            DAT_60 = 6;
            sVar1 = (short)Utilities.FUN_615EC(SceneManager.instance.DAT_27C[10].screen, screen);
            DAT_1EC = sVar1;
            DAT_1C4 = 0;
        }
    }

    private void FUN_3B2F8()
    {
        PTR_FUN_9C434[DAT_3E]();
    }

    private void FUN_3B334()
    {
        CriPlayer oVar1;

        FUN_609C8(57, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        SceneManager.instance.cCamera.DAT_72 &= 0xfb;
        oVar1.DAT_152 = 0;
        DAT_152 = 0;
        //FUN_1D988
        oVar1.DAT_3C = 5;
        oVar1.DAT_3D = 17;
        oVar1.DAT_3E = 0;
        oVar1.DAT_3F = 0;
        DAT_3E++;
    }

    private void FUN_3B3C0()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            FUN_6103C(5, 1, 22, 0);
            DAT_60 = 42;
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 1;
            FUN_65CF8(1, 0, 30);
            FUN_2B4E8();
            DAT_18D = true;
            GameManager.instance.FUN_65CB0(this);
            FUN_2D76C();
            SceneManager.instance.DAT_27C[10].DAT_18D = true;
        }
    }

    private void FUN_3B468()
    {
        PTR_FUN_9C44C[DAT_3E]();
    }

    private void FUN_3B4A4()
    {
        CriPlayer oVar2;

        FUN_609C8(58, 0, 0);
        FUN_656EC();
        DAT_40 = new Vector3Int(0, 0, 0);
        SceneManager.instance.cCamera.DAT_72 &= 0xfb;
        //FUN_1D988
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar2.DAT_3C = 5;
        oVar2.DAT_3D = 18;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        oVar2.vr.y = oVar2.vr.y + 0x800 & 0xfff;
        DAT_3E++;
    }

    private void FUN_3B540()
    {
        bool bVar1;
        CriPlayer oVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 13;
            DAT_3E = 0;
            DAT_3F = 0;
            oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
            oVar1.DAT_152 = 0;
            DAT_152 = 0;
            oVar1.DAT_11E &= 0xf7;
        }

        FUN_65714();

        if (DAT_60 == 18)
            GameManager.instance.FUN_5C94C(this, 62);
    }

    private void FUN_3B5BC()
    {
        PTR_FUN_9C454[DAT_3E]();
    }

    private void FUN_3B5F8()
    {
        CriPlayer oVar2;

        FUN_609C8(14, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        V2_1F0 = new Vector2Int(oVar2.screen.x, oVar2.screen.z);
        DAT_1DB = DAT_48;
        FUN_66460(true);
        DAT_3E++;
    }

    private void FUN_3B674()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            if ((byte)DAT_48 < DAT_1DB + 2)
            {
                DAT_3C = 1;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
                FUN_66460(false);
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 35;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_1DB = DAT_48;
            }

            DAT_140 &= 0xfffe;
        }

        DAT_40.y = (short)((Utilities.DAT_9B5EC[DAT_60] * DAT_1E8) / 100);
        DAT_40.z = (short)((Utilities.DAT_9B648[DAT_60] * UDAT_1E4) / 100);

        if (DAT_60 == 26)
            GameManager.instance.FUN_5C94C(this, 62);
    }

    private void FUN_3B7BC()
    {
        PTR_FUN_9C45C[DAT_3E]();
    }

    private void FUN_3B868()
    {
        CriPlayer oVar1;
        Vector3Int local_40;
        Matrix3x3 MStack48;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_48 < DAT_1DA)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_18D = false;
            oVar1.DAT_18D = false;
            GameManager.instance.FUN_65CB0(this);
            FUN_66460(false);
        }
        else
        {
            MStack48 = new Matrix3x3();
            local_40 = new Vector3Int(0, 0, (short)UDAT_20C);
            Utilities.RotMatrix(ref vr, ref MStack48);
            local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
            //...
        }
    }

    private void FUN_3B9A8()
    {
        FUN_34098();
        SceneManager.instance.DAT_27C[10].DAT_18D = false;
        DAT_18D = false;
        DAT_1DB = DAT_48;
    }

    private void FUN_3B9E8()
    {
        short sVar1;
        short sVar2;
        int iVar3;

        FUN_60AB4();

        if (DAT_60 == 1)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 9)
            GameManager.instance.FUN_5C94C(this, 49);

        DAT_40.z = Utilities.DAT_9B5A8[DAT_60];
        sVar1 = (short)Utilities.FUN_615EC(screen, SceneManager.instance.DAT_27C[10].screen);
        iVar3 = (int)GameManager.FUN_64650();
        sVar2 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar3 % 15 + 60) * 0x10000 >> 0x10), sVar1);
        vr.y = vr.y + sVar2 & 0xfff;
    }

    private void FUN_3BAE0()
    {
        PTR_FUN_9C464[DAT_3E]();
    }

    private void FUN_3BB1C()
    {
        ushort uVar1;
        short sVar3;
        bool bVar4;
        int iVar4;
        uint uVar5;
        uint uVar6;
        short sVar8;
        CriPlayer oVar9;
        int iVar10;

        oVar9 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar9.DAT_11E & 0x80) == 0)
        {
            bVar4 = SceneManager.instance.FUN_81014(screen, oVar9.screen, (byte)(DAT_48 << 4 | 0xf), false);

            if (!bVar4)
            {
                if (DAT_60 < 0x13U)
                {
                    if ((DAT_162 & 1) == 0)
                        return;

                    if (DAT_1C4 != 0)
                        return;

                    DAT_1C4 = 1;
                    DAT_18D = false;
                    oVar9.DAT_18D = false;
                    oVar9.DAT_140 |= 1;
                    DAT_3E++;
                    GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                    uVar1 = (ushort)vr.y;
                    uVar5 = (uint)(oVar9.vr.y - uVar1 & 0xfff);

                    if (uVar5 - 0x400 < 0x800)
                    {
                        oVar9.vr.y = (short)(uVar1 + 0x800 & 0xfff);
                        uVar6 = 5;
                    }
                    else
                    {
                        uVar6 = 0x305;
                        oVar9.vr.y = (short)uVar1;
                    }

                    oVar9.DAT_3C = (byte)uVar6;
                    oVar9.DAT_3D = (byte)(uVar6 >> 8);
                    oVar9.DAT_3E = (byte)(uVar6 >> 0x10);
                    oVar9.DAT_3F = (byte)(uVar6 >> 0x18);
                    FUN_65C4C(oVar9);
                    //FUN_1D988

                    if ((oVar9.DAT_11E & 1) != 0)
                        return;

                    if (oVar9.health < 1)
                        return;

                    iVar4 = (int)GameManager.FUN_64650();
                    oVar9.health = (short)((oVar9.health - 300) - (iVar4 + (iVar4 / 50) * -50));
                    oVar9.FUN_4FE30();

                    if (0 < oVar9.health)
                        return;

                    uVar5 = (uint)(uVar5 + 0x800 & 0xfff);
                }
                else
                {
                    if (0x16U < DAT_60)
                        return;

                    if ((DAT_162 & 1) == 0)
                        return;

                    if (DAT_1C4 != 0)
                        return;

                    DAT_1C4 = 1;

                    if (oVar9.DAT_98 == DAT_98)
                        oVar9.DAT_98 = oVar9.DAT_1E0;

                    sVar3 = oVar9.FUN_64804(screen);

                    if ((ushort)(sVar3 - 0x200) < 0x400U)
                    {
                        oVar9.FUN_53A2C(1, 1);
                        //...
                    }
                    else
                    {
                        if ((ushort)(sVar3 - 0xa00) < 0x400U)
                        {
                            oVar9.FUN_53A2C(1, 3);
                            //...
                        }
                        else
                        {
                            if ((ushort)(sVar3 - 0x200) < 0xc00U)
                            {
                                GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;
                                oVar9.DAT_3C = 5;
                                oVar9.DAT_3D = 9;
                                oVar9.DAT_3E = 0;
                                oVar9.DAT_3F = 0;
                                oVar9.DAT_1F0 = this;
                                FUN_65C4C(oVar9);
                                //...
                            }
                            else
                            {
                                oVar9.FUN_53A2C(1, 0);
                                //...
                            }
                        }
                    }


                    //FUN_1D988

                    if ((oVar9.DAT_11E & 1) != 0)
                        return;

                    if (oVar9.health < 1)
                        return;

                    if (oVar9.DAT_3C == 5 && oVar9.DAT_3D == 9)
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        iVar10 = (int)((ulong)((long)iVar4 * 0x51eb851f) >> 0x20);
                        sVar8 = (short)(oVar9.health - 150);
                    }
                    else
                    {
                        iVar4 = (int)GameManager.FUN_64650();
                        iVar10 = (int)((ulong)((long)iVar4 * 0x51eb851f) >> 0x20);
                        sVar8 = (short)(oVar9.health - 125);
                    }

                    oVar9.health = (short)(sVar8 - (iVar4 + ((iVar10 >> 4) - (iVar4 >> 31)) * -50));
                    oVar9.FUN_4FE30();

                    if (0 < oVar9.health)
                        return;

                    if (oVar9.DAT_3C != 5 || oVar9.DAT_3D != 9)
                    {
                        oVar9.DAT_3C = 3;
                        oVar9.DAT_3D = 0;
                        oVar9.DAT_3E = 0;
                        oVar9.DAT_3F = 0;

                        if ((ushort)(sVar3 - 0x400) < 0x800U)
                            oVar9.DAT_3F = 0;
                        else
                            oVar9.DAT_3F = 1;
                    }

                    uVar5 = (uint)(int)sVar3;
                }

                //FUN_2ECAC
            }
        }
    }

    private void FUN_3BF18()
    {
        CriPlayer oVar1;
        uint uVar2;

        FUN_609C8(14, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_2D76C();
        uVar2 = (UDAT_20C + 0x800) / 40;
        UDAT_1E4 = (ushort)uVar2;

        if ((uVar2 & 0xffff) < 50)
            UDAT_1E4 = 50;

        if (60U < UDAT_1E4)
            UDAT_1E4 = 60;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        DAT_1E8 = (ushort)((((byte)DAT_48 - (byte)oVar1.DAT_48) - 2) * 50 + 100);
        GameManager.instance.FUN_65C7C(this);
        DAT_12E = 2;
        DAT_1C4 = 0;
        DAT_3E++;
    }

    private void FUN_3C008()
    {
        short sVar1;
        short sVar2;
        int iVar3;
        bool bVar3;
        int iVar4;
        uint uVar5;
        CriPlayer oVar6;

        oVar6 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar3 = FUN_60AB4();

        if (bVar3)
        {
            PTR_120 = DAT_9B404;
            DAT_120 = 0;
            DAT_12E = 3;
            DAT_1C4 = 0;
            GameManager.instance.FUN_65CB0(this);
            DAT_140 &= 0xfffc;
            FUN_66460(false);

            if (DAT_48 != oVar6.DAT_48)
            {
                DAT_3C = 1;
                DAT_3D = 35;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_1DB = DAT_48;
                return;
            }

            PTR_FUN_9C46C[DAT_2F](oVar6);
            return;
        }

        if (DAT_60 == 26)
            GameManager.instance.FUN_5C94C(this, 62);

        uVar5 = DAT_60;

        if (uVar5 - 9 < 15)
        {
            if (uVar5 < 15)
                DAT_40.y = Utilities.DAT_9B5CC[uVar5 - 9];
            else
                DAT_40.y = (short)((Utilities.DAT_9B5CC[DAT_60 - 9] * DAT_1E8) / 100);
        }

        if (uVar5 - 9 < 10)
        {
            uVar5 = UDAT_1E4;
            iVar3 = (int)(uVar5 * 0xb0);
        }
        else
        {
            if (6 < (uVar5 - 19 & 0xffff))
            {
                DAT_40.z = 0;
                goto LAB_3C1EC;
            }

            uVar5 = UDAT_1E4;
            iVar3 = (int)(uVar5 * 0x48);
        }

        DAT_40.z = (short)((int)((iVar3 - uVar5) * 2) / 100);
        LAB_3C1EC:
        sVar1 = (short)Utilities.FUN_615EC(screen, oVar6.screen);
        iVar4 = (int)GameManager.FUN_64650();
        sVar2 = (short)Utilities.FUN_64838(vr.y, (uint)((iVar4 % 15 + 10) * 0x10000 >> 0x10), sVar1);
        vr.y = vr.y + sVar2 & 0xfff;
    }

    private void FUN_3C26C()
    {
        CriPlayer oVar2;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        FUN_609C8(24, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        screen.y = oVar2.screen.y;
        FUN_656EC();
        //FUN_65D1C
        oVar2.DAT_152 = 1;
        DAT_152 = 1;
        oVar2.DAT_154 = this;
        DAT_154 = oVar2;
        DAT_140 |= 3;
        DAT_3E++;
    }

    private void FUN_3C30C()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 13;
            DAT_3E = 0;
            DAT_3F = 0;
            PTR_120 = DAT_9B404;
            DAT_120 = 0;
            DAT_1C4 = 0;
            DAT_12E = 3;
            DAT_140 &= 0xfffc;
            FUN_66460(false);
        }

        FUN_65714();

        if (DAT_60 == 9)
            GameManager.instance.FUN_5C94C(this, 62);
    }

    private void FUN_3C390()
    {
        PTR_FUN_9C490[DAT_3E]();
    }

    private void FUN_3C3CC()
    {
        int iVar1;
        int[] local_18;

        local_18 = new int[4] { 8, 9, 11, 0 };
        iVar1 = (int)GameManager.FUN_64650();
        DAT_1D9 = (byte)(iVar1 % 3);
        FUN_609C8(local_18[iVar1 % 3 & 0xff], 1, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        FUN_65CF8(6, 0, 30);
        DAT_3E++;
    }

    private void FUN_3C488()
    {
        bool bVar1;
        uint uVar2;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            FUN_65CF8(0, 0, 30);
            GameManager.instance.FUN_65CB0(this);
            FUN_2D76C();
            FUN_2DF3C();
            DAT_1A4 = 1;
        }

        if (DAT_1D9 == 2)
        {
            if (DAT_60 != 6)
                return;

            uVar2 = 72;
        }
        else
        {
            if (DAT_60 != 20)
                return;

            uVar2 = 50;
        }

        GameManager.instance.FUN_5C94C(this, (int)uVar2);
    }

    private void FUN_3C534()
    {
        PTR_FUN_9C4A0[DAT_3E]();
    }

    private void FUN_3C570()
    {
        PTR_FUN_9C4A8[DAT_3D]();
    }

    private void FUN_3C5AC()
    {
        byte bVar2;
        byte bVar3;
        ushort uVar4;
        bool bVar5;
        int iVar5;
        short sVar6;
        int iVar7;
        CriPlayer oVar7;
        uint uVar8;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        oVar7 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_3E == 0)
        {
            DAT_40 = new Vector3Int(0, 0, 0);
            uVar4 = (ushort)Utilities.FUN_615EC(oVar7.screen, screen);
            DAT_1EC = (short)uVar4;
            local_38 = new Vector3Int(0, 0, (short)uVar4);
            local_40 = new Vector3Int(0, 0, 0);

            if (DAT_1C3 == 0)
            {
                local_40.x = 30;
                local_40.z = 30;
                FUN_609C8(15, 1, 0);
                GameManager.instance.FUN_5C94C(this, 58);
            }
            else
            {
                local_40.z = 88;
                FUN_609C8(16, 1, 0);
                GameManager.instance.FUN_5C94C(this, 60);
                BDAT_1D8 = 0;
                DAT_208 |= 0x4000;
            }

            MStack48 = new Matrix3x3();
            Utilities.RotMatrix(ref local_38, ref MStack48);
            local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
            screen.x += local_40.x;
            PTR_120 = DAT_9B404;
            DAT_120 = 0;
            PTR_124 = DAT_9B404;
            DAT_124 = 7;
            DAT_12E = 3;
            DAT_12F = 2;
            DAT_12C = 0;
            screen.z += local_40.z;
            FUN_2D76C();
            DAT_3E++;
            return;
        }

        if (DAT_3E != 1)
            return;

        bVar5 = FUN_60AB4();

        if (!bVar5) goto LAB_3C9E8;

        GameManager.instance.FUN_65CB0(this);
        DAT_12C &= 0xfff7;
        DAT_140 &= 0xfffc;
        bVar5 = InventoryManager.FUN_4A87C(5, DAT_163);

        if (bVar5)
            InventoryManager.FUN_4A7E8(5, DAT_163, false);

        if ((DAT_208 & 0x10) == 0 || DAT_48 != oVar7.DAT_48)
        {
            if (0 < health)
            {
                if (DAT_1C3 != 0)
                {
                    DAT_3D = 2;
                    DAT_3E = 0;
                    goto LAB_3C9E8;
                }

                if (DAT_48 == oVar7.DAT_48)
                {
                    DAT_3C = 1;
                    DAT_3D = 2;
                    DAT_3E = 0;
                    DAT_3F = 0;

                    if (79 < SDAT_1F8)
                    {
                        BDAT_1D0 = 1;
                        FUN_2DA0C(true);
                        SDAT_1F8 = 0;
                        goto LAB_3C9C4;
                    }

                    bVar2 = (byte)(BDAT_1D0 + 1);
                    BDAT_1D0 = bVar2;

                    if ((uint)bVar2 < DAT_1D1)
                    {
                        SDAT_1F8 = 0;
                        goto LAB_3C9C4;
                    }

                    BDAT_1D0 = 0;
                    FUN_2DA0C(true);

                    if (1999 < UDAT_20C || (GameManager.instance.DAT_922C & 2) != 0 || 
                        (oVar7.DAT_11E & 0x80) != 0)
                    {
                        iVar5 = (int)GameManager.FUN_64650();
                        bVar3 = 1;

                        if (iVar5 == (iVar5 / 3) * 3)
                        {
                            bVar3 = 3;

                            if (DAT_2F / 3 == 0)
                                bVar3 = 1;
                        }

                        DAT_1C2 = bVar3;
                        DAT_3C = 1;
                        DAT_3D = 9;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        V2_1F0 = new Vector2Int(oVar7.screen.x, oVar7.screen.z);
                        V2_1F4 = new Vector2Int(screen.x, screen.z);
                        SDAT_1F8 = 0;
                        goto LAB_3C9C4;
                    }

                    DAT_1C2 = 2;
                    DAT_208 |= 0x10000;
                    sVar6 = FUN_64804(oVar7.screen);
                    uVar8 = 0x1001;

                    if ((sVar6 & 0x800) == 0)
                        uVar8 = 0x1101;

                    DAT_3C = (byte)uVar8;
                    DAT_3D = (byte)(uVar8 >> 8);
                    DAT_3E = (byte)(uVar8 >> 0x10);
                    DAT_3F = (byte)(uVar8 >> 0x18);
                    GameManager.instance.FUN_65C7C(this);
                    SDAT_1F8 = 0;
                }
                else
                {
                    DAT_3C = 1;
                    DAT_3D = 35;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_1DB = DAT_48;
                    SDAT_1F8 = 0;
                }

                LAB_3C9C4:
                DAT_1D2 = 0;
                iVar7 = (int)GameManager.FUN_64650();
                DAT_1D3 = (byte)(iVar7 + (iVar7 / 2) * -2 + 2);
                goto LAB_3C9E8;
            }

            DAT_208 &= 0xffffffef;
            InventoryManager.FUN_4A7E8(4, DAT_163, true);

            if (DAT_1C3 == 0)
            {
                bVar2 = DAT_11E;
                DAT_3C = 3;
                DAT_3D = 1;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                bVar2 = DAT_11E;
                DAT_3C = 3;
                DAT_3D = 0;
                DAT_3E = 0;
                DAT_3F = 0;
            }

            DAT_11E = (byte)(bVar2 | 0x44);
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 18;
            DAT_3E = 0;
            DAT_3F = 0;
        }

        FUN_65CF8(0, 0, 30);
        
        LAB_3C9E8:
        if (DAT_60 == 6 && DAT_1C3 == 0 && 
            health < 1 || (DAT_208 & 0x10) != 0)
        {
            uVar8 = 0x103;

            if (BDAT_1DC == 3)
                uVar8 = 0x502;

            DAT_3C = (byte)uVar8;
            DAT_3D = (byte)(uVar8 >> 8);
            DAT_3E = (byte)(uVar8 >> 0x10);
            DAT_3F = (byte)(uVar8 >> 0x18);

            if ((DAT_208 & 0x10) == 0)
                DAT_11E |= 0x44;

            FUN_65CF8(0, 0, 30);
        }

        local_40 = new Vector3Int(0, 0, 0);
        local_38 = new Vector3Int(0, 0, 0);
        local_38.y = DAT_1EC;

        if (DAT_1C3 == 0)
        {
            local_40.x = Utilities.DAT_9C4F4[DAT_60];
            local_40.z = Utilities.DAT_9C4C0[DAT_60];
        }
        else
        {
            local_40.z = Utilities.DAT_9B6A4[DAT_60];

            if (DAT_60 == 13)
                GameManager.instance.FUN_5C94C(this, 62);
        }

        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref MStack48);
        local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        screen.x += local_40.x;
        screen.z += local_40.z;

        if (DAT_1C3 == 0)
        {
            if (DAT_1D5 == 1)
                ; //FUN_2EA44
        }
        else
        {
            if (DAT_1D5 == 1)
                ; //FUN_2EA1C
        }
    }

    private void FUN_3CBAC()
    {
        CriPlayer oVar1;
        ushort uVar2;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        DAT_40 = new Vector3Int(0, 0, 0);
        uVar2 = (ushort)Utilities.FUN_615EC(oVar1.screen, screen);
        DAT_1EC = (short)uVar2;
        local_38 = new Vector3Int(0, (short)uVar2, 0);
        local_40 = new Vector3Int(0, 0, 75);
        FUN_609C8(16, 1, 0);
        GameManager.instance.FUN_5C94C(this, 60);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref MStack48);
        local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        screen.x += local_40.x;
        PTR_120 = DAT_9B404;
        DAT_120 = 0;
        PTR_124 = DAT_9B404;
        DAT_124 = 7;
        DAT_12E = 3;
        DAT_12F = 2;
        DAT_12C = 0;
        BDAT_1D8 = 0;
        DAT_208 |= 0x4000;
        screen.z += local_40.z;
        FUN_2D76C();
        DAT_3E++;
    }

    private void FUN_3CCF4()
    {
        bool bVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            GameManager.instance.FUN_65CB0(this);
            DAT_12C &= 0xfff7;
            DAT_140 &= 0xfffc;

            if ((DAT_208 & 0x10) == 0 || DAT_48 != SceneManager.instance.DAT_27C[10].DAT_48)
            {
                if (health < 1)
                {
                    DAT_208 &= 0xffffffef;
                    InventoryManager.FUN_4A7E8(4, DAT_163, true);
                    DAT_3C = 3;
                    DAT_3D = 0;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_11E |= 0x44;
                    FUN_65CF8(0, 0, 30);
                }
                else
                {
                    DAT_3D = 2;
                    DAT_3E = 0;
                }
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 18;
                DAT_3E = 0;
                DAT_3F = 0;
                FUN_65CF8(0, 0, 30);
            }
        }

        local_40 = new Vector3Int(0, 0, (short)(Utilities.DAT_9B6D8[DAT_60] * 150 / 100));
        local_38 = new Vector3Int(0, DAT_1EC, 0);

        if (DAT_60 == 13)
            GameManager.instance.FUN_5C94C(this, 62);

        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref MStack48);
        local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        screen.x += local_40.x;
        screen.z += local_40.z;

        if (DAT_1D5 == 1)
            ; //FUN_2EA1C
    }

    private void FUN_3CED4()
    {
        PTR_FUN_9C528[DAT_3E]();
    }

    private void FUN_3CF10()
    {
        byte bVar1;
        bool bVar2;
        int iVar2;
        CriPlayer oVar2;
        bool bVar3;
        uint uVar4;
        short sVar5;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar1 = DAT_3E;

        if (bVar1 == 1)
        {
            bVar2 = FUN_60AB4();

            if (!bVar2)
                return;
        }
        else
        {
            if (1 < bVar1)
            {
                if (bVar1 == 2)
                {
                    FUN_609C8(18, 1, 10);
                    PTR_124 = DAT_9B404;
                    DAT_124 = 7;
                    DAT_12F = 2;
                    DAT_3E++;
                    return;
                }

                if (bVar1 != 3)
                    return;

                bVar3 = FUN_60AB4();

                if (bVar3)
                {
                    if (health < 1)
                    {
                        uVar4 = 0x103;

                        if (BDAT_1DC == 3)
                            uVar4 = 0x502;

                        DAT_3C = (byte)uVar4;
                        DAT_3D = (byte)(uVar4 >> 8);
                        DAT_3E = (byte)(uVar4 >> 0x10);
                        DAT_3F = (byte)(uVar4 >> 0x18);
                        DAT_11E |= 0x44;
                    }
                    else
                    {
                        if (DAT_48 == oVar2.DAT_48)
                        {
                            DAT_3C = 1;
                            DAT_3D = 2;
                            DAT_3E = 0;
                            DAT_3F = 0;

                            if (DAT_1C3 != 0 && (uint)DAT_1D3 <= (DAT_1D2 = (bVar1 = (byte)(DAT_1D2 + 1))))
                            {
                                if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 && 
                                    (oVar2.DAT_11E & 0x80) == 0)
                                {
                                    DAT_1C2 = 2;
                                    DAT_208 |= 0x10000;
                                    sVar5 = FUN_64804(oVar2.screen);
                                    uVar4 = 0x1001;

                                    if ((sVar5 & 0x800) == 0)
                                        uVar4 = 0x1101;

                                    DAT_3C = (byte)uVar4;
                                    DAT_3D = (byte)(uVar4 >> 8);
                                    DAT_3E = (byte)(uVar4 >> 0x10);
                                    DAT_3F = (byte)(uVar4 >> 0x18);
                                    GameManager.instance.FUN_65C7C(this);
                                }
                                else
                                {
                                    DAT_3C = 1;
                                    DAT_3D = 5;
                                    DAT_3E = 0;
                                    DAT_3F = 0;
                                    DAT_1C2 = 1;
                                }

                                DAT_1D2 = 0;
                                iVar2 = (int)GameManager.FUN_64650();
                                DAT_1D3 = (byte)(iVar2 + (iVar2 / 2) * -2 + 2);
                            }
                        }
                        else
                        {
                            DAT_3C = 1;
                            DAT_3D = 35;
                            DAT_3E = 0;
                            DAT_3F = 0;
                            DAT_1DB = DAT_48;
                        }

                        DAT_208 &= 0xffffbfff;
                    }
                }

                if (DAT_60 != 32)
                    return;

                GameManager.instance.FUN_5C94C(this, 63);
                return;
            }

            if (bVar1 != 0)
                return;

            DAT_40 = new Vector3Int(0, 0, 0);
            oVar2 = SceneManager.instance.FUN_65B30(this) as CriPlayer;

            if (oVar2 == null)
            {
                iVar2 = (int)GameManager.FUN_64650();

                if ((iVar2 % 2 & 0xff) == 0)
                {
                    FUN_609C8(18, 1, 5);
                    DAT_3E = 3;
                    return;
                }

                FUN_609C8(17, 9, 5);
            }
            else
            {
                if (oVar2.DAT_3C == 2 && oVar2.DAT_3D == 2 && oVar2.DAT_3E < 2U)
                {
                    FUN_609C8(18, 1, 5);
                    DAT_3E = 3;
                    return;
                }

                FUN_609C8(17, 9, 5);
            }
        }

        DAT_3E++;
    }

    private void FUN_3D234()
    {
        byte bVar2;
        byte bVar3;
        byte bVar4;
        bool bVar5;
        CriPlayer oVar5;
        int iVar5;
        short sVar6;
        uint uVar7;
        int iVar8;

        bVar3 = DAT_3E;

        if (bVar3 == 1)
        {
            FUN_60AB4();

            if (DAT_60 != 4)
                return;
        }
        else
        {
            if (bVar3 < 2)
            {
                if (bVar3 != 0)
                    return;

                DAT_40 = new Vector3Int(0, 0, 0);
                FUN_609C8(15, 1, 0);
                DAT_12C = 0;
                FUN_2D76C();
                GameManager.instance.FUN_5C94C(this, 58);
                PTR_120 = DAT_9B404;
                DAT_120 = 0;
                DAT_12E = 3;
                PTR_124 = DAT_9B404;
                DAT_124 = 7;
                bVar2 = DAT_3E;
                DAT_12F = 2;
                goto LAB_3D32C;
            }

            if (bVar3 != 2)
            {
                if (bVar3 != 3)
                    return;

                bVar5 = FUN_60AB4();

                if (!bVar5)
                    return;

                GameManager.instance.FUN_65CB0(this);
                DAT_12C &= 0xfff7;
                oVar5 = (CriPlayer)SceneManager.instance.DAT_27C[10];

                if (health < 1)
                {
                    DAT_3C = 3;
                    DAT_3D = 1;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_11E |= 0x44;
                    FUN_65CF8(0, 0, 30);
                    return;
                }

                if (DAT_48 == oVar5.DAT_48)
                {
                    if ((DAT_208 & 4) == 0)
                    {
                        DAT_3C = 1;
                        DAT_3D = 2;
                        DAT_3E = 0;
                        DAT_3F = 0;
                    }
                    else
                    {
                        DAT_3C = 1;
                        DAT_3D = 9;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        V2_1F0 = new Vector2Int(oVar5.screen.x, oVar5.screen.z);
                        V2_1F4 = new Vector2Int(screen.x, screen.z);
                    }

                    if (SDAT_1F8 < 80)
                    {
                        bVar3 = (byte)(BDAT_1D0 + 1);
                        BDAT_1D0 = bVar3;

                        if ((uint)DAT_1D1 <= bVar3)
                        {
                            DAT_1D0 = 0;
                            FUN_2DA0C(false);

                            if (UDAT_20C < 2000 && (GameManager.instance.DAT_922C & 2) == 0 && 
                                (oVar5.DAT_11E & 0x80) == 0)
                            {
                                DAT_1C2 = 2;
                                DAT_208 |= 0x10000;
                                sVar6 = FUN_64804(oVar5.screen);
                                uVar7 = 0x1001;

                                if ((sVar6 & 0x800) == 0)
                                    uVar7 = 0x1101;

                                DAT_3C = (byte)uVar7;
                                DAT_3D = (byte)(uVar7 >> 8);
                                DAT_3E = (byte)(uVar7 >> 0x10);
                                DAT_3F = (byte)(uVar7 >> 0x18);
                                GameManager.instance.FUN_65C7C(this);
                                SDAT_1F8 = 0;
                                goto LAB_3D574;
                            }

                            iVar8 = (int)GameManager.FUN_64650();
                            bVar4 = 1;

                            if (iVar8 == (iVar8 / 3) * 3)
                            {
                                bVar4 = 3;

                                if (DAT_2F / 3 == 0)
                                    bVar4 = 1;
                            }

                            DAT_1C2 = bVar4;
                            DAT_3C = 1;
                            DAT_3D = 9;
                            DAT_3E = 0;
                            DAT_3F = 0;
                            V2_1F0 = new Vector2Int(oVar5.screen.x, oVar5.screen.z);
                            V2_1F4 = new Vector2Int(screen.x, screen.z);
                        }
                    }
                    else
                    {
                        BDAT_1D0 = 1;
                        FUN_2DA0C(false);
                    }
                }
                else
                {
                    DAT_3C = 1;
                    DAT_3D = 35;
                    DAT_3E = 0;
                    DAT_3F = 0;
                    DAT_1DB = DAT_48;
                }

                SDAT_1F8 = 0;
                LAB_3D574:
                DAT_1D2 = 0;
                iVar5 = (int)GameManager.FUN_64650();
                DAT_1D3 = (byte)(iVar5 + (iVar5 / 2) * -2 + 2);
                return;
            }

            FUN_6103C(15, 2, 2, 0);
        }

        bVar2 = DAT_3E;
        LAB_3D32C:
        DAT_3E = (byte)(bVar2 + 1);
    }

    private void FUN_3D5AC()
    {
        FUN_609C8(22, 4, 5);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_12C = 0;
        DAT_3E++;
    }

    private void FUN_3D5F8()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            GameManager.instance.FUN_65CB0(this);

            if (health < 1)
            {
                DAT_3C = 3;
                DAT_3D = 0;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                if (DAT_1C3 == 5)
                {
                    DAT_3C = 2;
                    DAT_3D = 2;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }
                else
                {
                    if ((DAT_208 & 0x20000) == 0)
                    {
                        DAT_3C = 1;
                        DAT_3D = 5;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        DAT_194 = 0;
                    }
                    else
                    {
                        DAT_3C = 1;
                        DAT_3D = 27;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        bVar1 = InventoryManager.FUN_4A87C(5, DAT_163);

                        if (bVar1)
                            InventoryManager.FUN_4A7E8(5, DAT_163, false);

                        if (DAT_12C != 0)
                            DAT_12C = 0;
                    }
                }
            }
        }
    }

    private void FUN_3D6C4()
    {
        PTR_FUN_9C530[DAT_3E]();
    }

    private void FUN_3D700()
    {
        FUN_609C8(75, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
    }

    private void FUN_3D748()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 3;
            DAT_3D = 1;
            DAT_3E = 0;
            DAT_3F = 0;
        }
    }

    private void FUN_3D77C()
    {
        PTR_FUN_9C538[DAT_3E]();
    }

    private void FUN_3D7B8()
    {
        PTR_FUN_9C540[DAT_3D]();
    }

    private void FUN_3D7F4()
    {
        FUN_609C8(19, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_65CB0(this);
        InventoryManager.FUN_4A7E8(4, DAT_163, true);
        DAT_3E++;
    }

    private void FUN_3D858()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
            DAT_3E++;

        if (DAT_60 == 14)
            GameManager.instance.FUN_5C94C(this, 63);
    }

    private void FUN_3D8B0()
    {
        CriPlayer oVar1;

        if (DAT_1A3 == 0)
            SceneManager.instance.FUN_2EBF8(this);

        DAT_12C = 0xffff;
        PTR_124 = null;
        PTR_120 = null;
        DAT_12F = 0;
        DAT_12E = 0;
        DAT_11E |= 0x40;
        DAT_140 |= 0x8000;
        oVar1 = SceneManager.instance.FUN_65B30(this) as CriPlayer;

        if (oVar1 != null && (oVar1.DAT_208 & 0x2000000) != 0)
        {
            oVar1.DAT_1C5 = 1;
            DAT_1C5 = 0;
        }

        DAT_144 &= 0x7fff;
        FUN_65CF8(0, 0, 30);
        DAT_3E++;
    }

    private void FUN_3D978()
    {
        PTR_FUN_9C548[DAT_3E]();
    }

    private void FUN_3D9B4()
    {
        int iVar1;
        uint uVar2;

        iVar1 = (int)GameManager.FUN_64650();
        uVar2 = (uint)(iVar1 % 5 & 0xff);
        FUN_6103C(20, 8, (byte)uVar2, 5);
        DAT_60 = (ushort)(uVar2 << 1);
        DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_65CB0(this);
        DAT_3E++;
    }

    private void FUN_3DA54()
    {
        bool bVar1;
        CriPlayer oVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            if ((DAT_208 & 0x10) == 0 || DAT_48 != SceneManager.instance.DAT_27C[10].DAT_48)
            {
                DAT_208 &= 0xffffffef;
                InventoryManager.FUN_4A7E8(4, DAT_163, true);
                DAT_3C = 3;
                DAT_3D = 0;
                DAT_3E = 0;
                DAT_3F = 0;
            }
            else
            {
                DAT_3C = 1;
                DAT_3D = 18;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_11E &= 0xbf;
            }

            oVar1 = SceneManager.instance.FUN_65B30(this) as CriPlayer;

            if (oVar1 != null && (oVar1.DAT_208 & 0x2000000) != 0)
            {
                oVar1.DAT_1C5 = 1;
                DAT_1C5 = 0;
            }
        }

        if (DAT_60 == 32)
            GameManager.instance.FUN_5C94C(this, 62);
    }

    private void FUN_3DB3C()
    {
        PTR_FUN_9C558[DAT_3E]();
    }

    private void FUN_3DB78()
    {
        PTR_FUN_9C560[DAT_3D]();
    }

    private void FUN_3DBB4()
    {
        FUN_60AB4();
    }

    private void FUN_3DBD4()
    {
        PTR_FUN_9C590[DAT_3E]();
    }

    private void FUN_3DC10()
    {
        FUN_609C8(5, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        V2_1F4 = new Vector2Int(screen.x, screen.z);
        UDAT_210 = Utilities.FUN_631AC(screen, PTR_190[DAT_190]);
        DAT_3E++;
    }

    private void FUN_3DC78()
    {
        byte bVar1;
        short sVar2;
        ushort uVar3;
        uint uVar4;
        bool bVar5;
        uint uVar6;
        Vector3Int local_18;

        local_18 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
        uVar4 = Utilities.FUN_631AC(local_18, screen);

        if (UDAT_210 < uVar4)
        {
            bVar1 = (byte)(DAT_18F - 1);
            DAT_18F = bVar1;

            if (bVar1 == 0)
            {
                DAT_40 = new Vector3Int(0, 0, 0);
                InventoryManager.FUN_4A7E8(3, DAT_176, true);
                DAT_3E++;
                return;
            }

            DAT_190++;
            V2_1F4 = new Vector2Int(screen.x, screen.z);
            UDAT_210 = Utilities.FUN_631AC(screen, PTR_190[DAT_190]);
        }

        FUN_60AB4();
        bVar5 = InventoryManager.FUN_4A87C(0, 0x59);

        if (!bVar5)
        {
            if (DAT_60 == 7)
                GameManager.instance.FUN_5C94C(this, 48);

            if (DAT_60 == 50)
                GameManager.instance.FUN_5C94C(this, 49);
        }

        sVar2 = FUN_64804(PTR_190[DAT_190]);

        if (DAT_60 - 32U < 19 || DAT_60 - 80U < 19)
        {
            uVar6 = 20;

            if ((ushort)(sVar2 - 0x401) < 0x7ffU)
                uVar6 = 80;

            uVar3 = (ushort)Utilities.FUN_615EC(screen, PTR_190[DAT_190]);
            sVar2 = (short)Utilities.FUN_64838(vr.y, uVar6, uVar3);
            DAT_40.z = 45;
            vr.y = vr.y + sVar2 & 0xfff;
        }
        else
            DAT_40.z = 0;
    }

    private void FUN_3DE1C()
    {
        PTR_FUN_9C59C[DAT_3E]();
    }

    private void FUN_3DE58()
    {
        FUN_609C8(23, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 170);
        V2_1F4 = new Vector2Int(screen.x, screen.z);
        UDAT_210 = Utilities.FUN_631AC(screen, PTR_190[DAT_190]);
        DAT_3E++;
    }

    private void FUN_3DED4()
    {
        byte bVar1;
        ushort uVar2;
        short sVar3;
        uint uVar4;
        bool bVar5;
        Vector3Int local_18;

        local_18 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
        uVar4 = Utilities.FUN_631AC(local_18, screen);

        if (UDAT_210 < uVar4)
        {
            bVar1 = (byte)(UDAT_210 - 1);
            UDAT_210 = bVar1;

            if (bVar1 == 0)
            {
                DAT_40 = new Vector3Int(0, 0, 0);
                InventoryManager.FUN_4A7E8(3, DAT_176, true);
                DAT_3E++;
                return;
            }

            DAT_190++;
            V2_1F4 = new Vector2Int(screen.x, screen.z);
            UDAT_210 = Utilities.FUN_631AC(screen, PTR_190[DAT_190]);
        }

        FUN_60AB4();
        bVar5 = InventoryManager.FUN_4A87C(0, 0x59);

        if (!bVar5)
        {
            if (DAT_60 == 2)
                GameManager.instance.FUN_5C94C(this, 48);

            if (DAT_60 == 15)
                GameManager.instance.FUN_5C94C(this, 49);
        }

        uVar2 = (ushort)Utilities.FUN_615EC(screen, PTR_190[DAT_190]);
        sVar3 = (short)Utilities.FUN_64838(vr.y, 60, uVar2);
        vr.y = vr.y + sVar3 & 0xfff;
    }

    private void FUN_3E028()
    {
        PTR_FUN_9C5A8[DAT_3E]();
    }

    private void FUN_3E064()
    {
        FUN_609C8(10, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        V2_1F4 = new Vector2Int(screen.x, screen.z);
        UDAT_210 = Utilities.FUN_631AC(screen, PTR_190[DAT_190]);
        DAT_3E++;
    }

    private void FUN_3E0DC()
    {
        byte bVar1;
        short sVar2;
        ushort uVar3;
        uint uVar4;
        uint uVar5;
        Vector3Int local_18;

        local_18 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
        uVar4 = Utilities.FUN_631AC(local_18, screen);

        if (UDAT_210 < uVar4)
        {
            bVar1 = (byte)(DAT_18F - 1);
            DAT_18F = bVar1;

            if (bVar1 == 0)
            {
                DAT_40 = new Vector3Int(0, 0, 0);
                InventoryManager.FUN_4A7E8(3, DAT_176, true);
                DAT_3E++;
                return;
            }

            DAT_190++;
            local_18 = new Vector3Int(screen.x, 0, screen.z);
            V2_1F4 = new Vector2Int(local_18.x, local_18.z);
            UDAT_210 = Utilities.FUN_631AC(screen, PTR_190[DAT_190]);
        }

        FUN_60AB4();

        if (DAT_60 == 37)
            GameManager.instance.FUN_5C94C(this, 50);

        sVar2 = FUN_64804(SceneManager.instance.DAT_27C[10].screen);

        if (DAT_60 - 32U < 19 || DAT_60 - 80U < 19)
        {
            uVar5 = 20;

            if ((ushort)(sVar2 - 0x401) < 0x7ffU)
                uVar5 = 80;

            uVar3 = (ushort)Utilities.FUN_615EC(screen, PTR_190[DAT_190]);
            sVar2 = (short)Utilities.FUN_64838(vr.y, uVar5, uVar3);
            DAT_40.z = 45;
            vr.y = vr.y + sVar2 & 0xfff;
        }
        else
            DAT_40.z = 0;
    }

    private void FUN_3E268()
    {
        byte bVar1;
        short sVar2;
        ushort uVar3;
        uint uVar4;
        bool bVar5;
        int iVar5;

        bVar1 = DAT_3E;

        if (bVar1 == 1)
        {
            bVar5 = FUN_60AB4();

            if (bVar5)
            {
                InventoryManager.FUN_4A7E8(3, DAT_176, true);
                DAT_3E++;
                FUN_66460(false);
                DAT_140 &= 0xfffe;
            }

            DAT_40.y = (short)((Utilities.DAT_9B5EC[DAT_60] * DAT_1E8) / 100);
            DAT_40.z = (short)((Utilities.DAT_9B648[DAT_60] * UDAT_1E4) / 100);

            if (DAT_60 == 26)
                GameManager.instance.FUN_5C94C(this, 62);

            uVar3 = (ushort)Utilities.FUN_615EC(screen, PTR_190[DAT_190]);
            sVar2 = (short)Utilities.FUN_64838(vr.y, 40, uVar3);
        }
        else
        {
            if (bVar1 < 2 && bVar1 == 0)
            {
                FUN_609C8(14, 0, 0);
                DAT_40 = new Vector3Int(0, 0, 0);
                uVar4 = Utilities.FUN_631AC(screen, PTR_190[DAT_190]);
                UDAT_1E4 = (ushort)(uVar4 / 22);

                if ((uVar4 / 22 & 0xffff) < 50)
                    UDAT_1E4 = 50;

                iVar5 = ((PTR_190[DAT_190].y - screen.y) / 425) * -0x10000;
                sVar2 = 100;

                if (1 < iVar5 >> 0x10)
                    sVar2 = (short)(((iVar5 >> 0x10) - 2) * 50 + 100);

                DAT_1E8 = (ushort)sVar2;
                DAT_140 |= 1;
                FUN_66460(true);
                DAT_3E++;
            }
        }
    }

    private void FUN_3E4A0()
    {
        short sVar3;
        CriPlayer oVar4;

        oVar4 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_60 < 19U && (DAT_162 & 1) != 0 && DAT_1C4 == 0)
        {
            DAT_1C4 = 1;
            DAT_18D = false;
            oVar4.DAT_18D = false;
            DAT_3E++;
            sVar3 = oVar4.FUN_64804(screen);
            GameManager.instance.PTR_FUN_148 = GameManager.FUN_2B6F4;

            if ((ushort)(sVar3 - 0x400) < 0x800U)
            {
                oVar4.DAT_3C = 5;
                oVar4.DAT_3D = 3;
                oVar4.DAT_3E = 0;
                oVar4.DAT_3F = 0;
                oVar4.vr.y = vr.y;
            }
            else
            {
                oVar4.DAT_3C = 5;
                oVar4.DAT_3D = 0;
                oVar4.DAT_3E = 0;
                oVar4.DAT_3F = 0;
                oVar4.vr.y = vr.y + 0x800 & 0xfff;
            }

            FUN_65C4C(oVar4);
        }
    }

    private void FUN_3E58C()
    {
        byte bVar1;
        byte bVar2;
        short sVar3;
        ushort uVar4;
        int iVar5;
        bool bVar6;
        int iVar6;
        uint uVar7;
        uint uVar8;
        bool bVar9;
        int iVar9;
        CriPlayer oVar9;

        bVar1 = DAT_3E;
        oVar9 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (bVar1 != 1)
        {
            if (bVar1 < 2)
            {
                if (bVar1 != 0)
                    return;

                FUN_609C8(14, 0, 0);
                GameManager.instance.FUN_5C94C(this, 51);
                UDAT_1E4 = (ushort)((UDAT_20C + 0x800) / 40);
                DAT_40 = new Vector3Int(0, 0, 0);
                oVar9.DAT_1CC = (byte)UDAT_1E4;
                iVar5 = ((screen.y - PTR_190[DAT_190].y) / 425) * -0x10000;
                sVar3 = 100;

                if (1 < iVar5 >> 0x10)
                    sVar3 = (short)(((iVar5 >> 0x10) - 2) * 50 + 100);

                DAT_1E8 = (ushort)sVar3;
                GameManager.instance.FUN_65C7C(this);
                DAT_12E = 1;
                DAT_1C4 = 0;
                DAT_140 |= 3;
                FUN_66460(true);
                bVar2 = DAT_3E;
            }
            else
            {
                if (bVar1 != 2)
                {
                    if (bVar1 != 3)
                        return;

                    bVar6 = FUN_60AB4();

                    if (bVar6)
                    {
                        if ((oVar9.DAT_11E & 1) == 0 && 0 < oVar9.health)
                        {
                            iVar6 = (int)GameManager.FUN_64650();
                            oVar9.health = (short)((oVar9.health - 200) - (iVar6 + (iVar6 / 150) * -150));
                            oVar9.FUN_4FE30();

                            if (oVar9.health < 1)
                            {
                                uVar8 = 0x800;

                                if (oVar9.DAT_3C == 5 && oVar9.DAT_3D == 0)
                                    uVar8 = 0;

                                //FUN_2ECAC
                            }
                        }

                        DAT_3C = 1;
                        DAT_3D = 13;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        DAT_12E = 3;
                        DAT_1C4 = 0;
                        DAT_140 &= 0xfffc;
                        FUN_66460(false);
                    }

                    FUN_65714();

                    if (DAT_60 != 9)
                        return;

                    GameManager.instance.FUN_5C94C(this, 62);
                    return;
                }

                FUN_609C8(24, 0, 0);
                DAT_40 = new Vector3Int(0, 0, 0);
                screen.y = oVar9.screen.y;
                FUN_656EC();
                //FUN_65D1C
                oVar9.DAT_152 = 1;
                DAT_152 = 1;
                oVar9.DAT_154 = this;
                bVar2 = DAT_3E;
                DAT_154 = oVar9;
            }

            DAT_3E = (byte)(bVar2 + 1);
            return;
        }

        bVar9 = FUN_60AB4();

        if (bVar9)
        {
            DAT_12E = 3;
            DAT_1C4 = 0;
            GameManager.instance.FUN_65CB0(this);
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_140 &= 0xfffc;
            FUN_66460(false);
            return;
        }

        if (DAT_60 == 26)
            GameManager.instance.FUN_5C94C(this, 62);

        if (DAT_60 - 9U < 15)
        {
            if (DAT_60 < 15U)
                DAT_40.y = Utilities.DAT_9B5CC[DAT_60 - 9];
            else
                DAT_40.y = (short)((Utilities.DAT_9B5CC[DAT_60 - 9] * DAT_1E8) / 100);
        }

        if (DAT_60 - 9U < 10)
        {
            uVar7 = UDAT_1E4;
            iVar9 = (int)(uVar7 * 0xb0);
        }
        else
        {
            if (6 < (DAT_60 - 19U & 0xffff))
            {
                DAT_40.z = 0;
                goto LAB_3E850;
            }

            uVar7 = UDAT_1E4;
            iVar9 = (int)(uVar7 * 0x48);
        }

        DAT_40.z = (short)(((iVar9 - (int)uVar7) * 2) / 100);
        LAB_3E850:
        uVar4 = (ushort)Utilities.FUN_615EC(screen, oVar9.screen);
        sVar3 = (short)Utilities.FUN_64838(vr.y, 20, uVar4);
        vr.y = vr.y + sVar3 & 0xfff;
    }

    private void FUN_3EA00()
    {
        bool bVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        if (DAT_3E == 0)
        {
            DAT_40 = new Vector3Int(0, 0, 0);
            local_40 = new Vector3Int(0, 0, 88);
            local_38 = new Vector3Int(0, DAT_1EC, 0);
            FUN_609C8(16, 1, 0);
            GameManager.instance.FUN_5C94C(this, 60);
            BDAT_1D8 = 0;
            DAT_208 |= 0x4000;
            MStack48 = new Matrix3x3();
            Utilities.RotMatrix(ref local_38, ref MStack48);
            local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
            screen.x += local_40.x;
            DAT_12C |= 8;
            DAT_18D = true;
            PTR_120 = DAT_9B404;
            DAT_120 = 0;
            DAT_196 = 0;
            DAT_12E = 3;
            screen.z += local_40.z;
            FUN_2D76C();
            DAT_1C4 = 0;
            FUN_2F848();
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
            {
                bVar1 = FUN_60AB4();

                if (bVar1)
                {
                    if (health < 1)
                    {
                        DAT_3C = 3;
                        DAT_3D = 0;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        DAT_11E |= 0x44;
                        FUN_65CF8(0, 0, 30);
                    }
                    else
                    {
                        DAT_3C = 2;
                        DAT_3D = 2;
                        DAT_3E = 0;
                        DAT_3F = 0;
                    }

                    GameManager.instance.FUN_65CB0(this);
                    DAT_12C = 0;
                    DAT_11E &= 0xfe;
                    DAT_140 &= 0xfffc;
                    bVar1 = InventoryManager.FUN_4A87C(5, DAT_163);

                    if (bVar1)
                        InventoryManager.FUN_4A7E8(5, DAT_163, false);

                    SceneManager.instance.FUN_2E22C(this);
                }

                local_38 = new Vector3Int(0, DAT_1EC, 0);
                local_40 = new Vector3Int(0, 0, Utilities.DAT_9B6A4[DAT_60]);
                MStack48 = new Matrix3x3();
                Utilities.RotMatrix(ref local_38, ref MStack48);
                local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
                screen.x += local_40.x;
                screen.z += local_40.z;

                if (DAT_60 == 13)
                    GameManager.instance.FUN_5C94C(this, 62);
            }
        }
    }

    private void FUN_3EC5C()
    {
        short sVar1;
        short sVar2;
        short sVar3;
        bool bVar4;

        sVar1 = (short)DAT_64.x;
        sVar2 = (short)DAT_64.y;
        sVar3 = (short)DAT_64.z;
        bVar4 = FUN_60AB4();

        if (bVar4)
            InventoryManager.FUN_4A7E8(3, DAT_176, true);

        DAT_40.x = DAT_64.x - sVar1;
        DAT_40.y = sVar2 - DAT_64.y;
        DAT_40.z = sVar3 - DAT_64.z;
    }

    private void FUN_3ECF4()
    {
        int iVar1;
        uint uVar2;

        iVar1 = (int)GameManager.FUN_64650();
        uVar2 = (uint)(iVar1 % 10 & 0xff);
        FUN_6103C(11, 1, (byte)uVar2, 5);
        DAT_60 = (ushort)uVar2;
        DAT_40 = new Vector3Int(0, 0, 0);
        GameManager.instance.FUN_5C94C(this, 72);
        DAT_3E++;
    }

    private void FUN_3ED98()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            if ((DAT_208 & 0x40000) == 0)
            {
                DAT_3C = 1;
                DAT_3D = 2;
                DAT_3E = 0;
                DAT_3F = 0;
            }

            GameManager.instance.FUN_65CB0(this);
        }
    }

    private void FUN_3EDE8()
    {
        PTR_FUN_9C5B4[DAT_3E]();
    }

    private void FUN_3EE24()
    {
        short sVar1;

        sVar1 = FUN_64804(PTR_190[DAT_190]);

        if ((ushort)(sVar1 - 0x600) < 0x401)
        {
            DAT_3E++;
            FUN_3EE90();
        }
        else
        {
            DAT_3E = 3;
            FUN_3F028();
        }
    }

    private void FUN_3EE90()
    {
        short sVar2;
        short sVar3;
        int iVar4;
        Vector3Int local_10;

        FUN_609C8(12, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        local_10 = new Vector3Int(-500, 0, 500);
        local_10 = Utilities.ApplyMatrixSV(ref cTransform.rotation, ref local_10);
        screen.x -= local_10.x;
        screen.z -= local_10.z;
        sVar2 = FUN_64804(PTR_190[DAT_190]);
        iVar4 = sVar2 - 0x800;
        DAT_1EC = sVar2;

        if (iVar4 < 0)
            iVar4 = sVar2 - 2017;

        sVar2 = (short)vr.y;
        sVar3 = (short)(iVar4 >> 5);
        DAT_1EE = sVar3;
        vr.y = sVar2 + sVar3 & 0xfff;
        DAT_3E++;
    }

    private void FUN_3EF58()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (!bVar1)
        {
            vr.y = vr.y + DAT_1EE & 0xfff;
            bVar1 = InventoryManager.FUN_4A87C(0, 0x59);

            if (!bVar1)
            {
                if (DAT_60 == 14)
                    GameManager.instance.FUN_5C94C(this, 48);

                if (DAT_60 == 20)
                    GameManager.instance.FUN_5C94C(this, 49);

                if (DAT_60 == 29)
                    GameManager.instance.FUN_5C94C(this, 48);
            }
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            vr.y = vr.y + 0x800 & 0xfff;
            InventoryManager.FUN_4A7E8(3, DAT_176, true);
        }
    }

    private void FUN_3F028()
    {
        short sVar1;
        short sVar2;

        FUN_609C8(13, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 0);
        sVar1 = FUN_64804(PTR_190[DAT_190]);

        if ((sVar1 & 0x800) == 0)
            sVar2 = (short)(sVar1 / 30);
        else
            sVar2 = (short)-(((-sVar1 & 0xfff) / 30) * 0x10000 >> 0x10);

        DAT_1EE = sVar2;
        vr.y = vr.y + DAT_1EE & 0xfff;
        DAT_3E++;
    }

    private void FUN_3F108()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (!bVar1)
        {
            vr.y = vr.y + DAT_1EE & 0xfff;
            bVar1 = InventoryManager.FUN_4A87C(0, 0x59);

            if (!bVar1)
            {
                if (DAT_60 == 12)
                    GameManager.instance.FUN_5C94C(this, 48);

                if (DAT_60 == 23)
                    GameManager.instance.FUN_5C94C(this, 49);
            }
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 2;
            DAT_3E = 0;
            DAT_3F = 0;
            InventoryManager.FUN_4A7E8(3, DAT_176, true);
        }
    }

    private void FUN_3F1B0()
    {
        PTR_FUN_9C5BC[DAT_3E]();
    }

    private void FUN_3F1EC()
    {
        FUN_609C8(6, 1, 10);
        DAT_40 = new Vector3Int(0, 0, 100);
        V2_1F4 = new Vector2Int(screen.x, screen.z);
        UDAT_210 = Utilities.FUN_631AC(screen, PTR_190[DAT_190]);
        DAT_3E++;
    }

    private void FUN_3F268()
    {
        byte bVar1;
        ushort uVar2;
        short sVar3;
        uint uVar4;
        Vector3Int local_18;

        local_18 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
        uVar4 = Utilities.FUN_631AC(local_18, screen);

        if (UDAT_210 < uVar4)
        {
            bVar1 = (byte)(DAT_18F - 1);
            DAT_18F = bVar1;

            if (bVar1 == 0)
            {
                DAT_40 = new Vector3Int(0, 0, 0);
                InventoryManager.FUN_4A7E8(3, DAT_176, true);
                DAT_3E++;
                return;
            }

            local_18 = new Vector3Int(screen.x, 0, screen.z);
            DAT_190++;
            V2_1F4 = new Vector2Int(local_18.x, local_18.z);
            UDAT_210 = Utilities.FUN_631AC(screen, PTR_190[DAT_190]);
        }

        FUN_60AB4();

        if (DAT_60 == 1)
            GameManager.instance.FUN_5C94C(this, 48);

        if (DAT_60 == 9)
            GameManager.instance.FUN_5C94C(this, 49);

        DAT_40.z = Utilities.DAT_9B5A8[DAT_60];
        uVar2 = (ushort)Utilities.FUN_615EC(screen, PTR_190[DAT_190]);
        sVar3 = (short)Utilities.FUN_64838(vr.y, 60, uVar2);
        vr.y = vr.y + sVar3 & 0xfff;
    }

    private void FUN_3F3D8()
    {
        PTR_FUN_9C5D0[DAT_3E]();
    }

    private void FUN_3F414()
    {
        bool bVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        if (DAT_3E == 0)
        {
            DAT_40 = new Vector3Int(0, 0, 0);
            local_40 = new Vector3Int(0, 0, 75);
            local_38 = new Vector3Int(0, DAT_1EC, 0);
            FUN_609C8(16, 1, 0);
            GameManager.instance.FUN_5C94C(this, 60);
            MStack48 = new Matrix3x3();
            Utilities.RotMatrix(ref local_38, ref MStack48);
            local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
            screen.x += local_40.x;
            BDAT_1D8 = 0;
            DAT_208 |= 0x4000;
            DAT_12C |= 8;
            DAT_18D = true;
            screen.z += local_40.z;
            FUN_2D76C();
            DAT_1C4 = 0;
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
            {
                bVar1 = FUN_60AB4();

                if (bVar1)
                {
                    if (health < 1)
                    {
                        DAT_3C = 3;
                        DAT_3D = 0;
                        DAT_3E = 0;
                        DAT_3F = 0;
                        DAT_11E |= 0x44;
                        FUN_65CF8(0, 0, 30);
                    }
                    else
                    {
                        DAT_3C = 2;
                        DAT_3D = 2;
                        DAT_3E = 0;
                        DAT_3F = 0;
                    }

                    GameManager.instance.FUN_65CB0(this);
                    DAT_12C = 0;
                    DAT_11E &= 0xfe;
                    DAT_140 &= 0xfffc;
                    SceneManager.instance.FUN_2E22C(this);
                }

                local_38 = new Vector3Int(0, DAT_1EC, 0);
                local_40 = new Vector3Int(0, 0, (Utilities.DAT_9B6D8[DAT_60] * 150) / 100);

                if (DAT_60 == 13)
                    GameManager.instance.FUN_5C94C(this, 62);

                MStack48 = new Matrix3x3();
                Utilities.RotMatrix(ref local_38, ref MStack48);
                local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
                screen.x += local_40.x;
                screen.z += local_40.z;
            }
        }
    }

    private void FUN_3F694()
    {
        PTR_FUN_9C5DC[DAT_3D]();
    }

    private void FUN_3F6D0()
    {
        short sVar1;
        int iVar2;
        CriPlayer oVar2;

        FUN_609C8(21, 1, 10);
        GameManager.instance.FUN_65CB0(this);
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3E++;
        oVar2 = SceneManager.instance.FUN_65B30(this) as CriPlayer;

        if (oVar2 != null && (oVar2.DAT_208 & 0x2000000) != 0)
        {
            oVar2.DAT_1C5 = 1;
            DAT_1C5 = 0;
        }

        if (BDAT_1DC == 2)
        {
            iVar2 = (int)GameManager.FUN_64650();
            sVar1 = (short)(iVar2 + (iVar2 / 10) * -10 + 20);
        }
        else
        {
            iVar2 = (int)GameManager.FUN_64650();
            sVar1 = (short)(iVar2 + (iVar2 / 5) * -5 + 10);
        }

        DAT_196 = (short)(sVar1 * 30);
        DAT_1DD = 0;
        InventoryManager.FUN_4A7E8(5, DAT_163, true);
    }

    private void FUN_3F7F4()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 5;
            DAT_3D = 1;
            DAT_3E = 0;
            DAT_3F = 0;
        }

        if (DAT_60 == 78)
            DAT_5C |= 8;

        if (DAT_60 == 84)
            GameManager.instance.FUN_5C94C(this, 62);
    }

    private void FUN_3F860()
    {
        PTR_FUN_9C5E4[DAT_3E]();
    }

    private void FUN_3F89C()
    {
        int iVar1;
        uint uVar2;

        iVar1 = (int)GameManager.FUN_64650();
        uVar2 = (uint)(iVar1 % 5 & 0xff);
        FUN_6103C(2, 9, (byte)uVar2, 5);
        DAT_12C = 0xffff;
        PTR_124 = DAT_9B404;
        DAT_124 = 12;
        DAT_60 = (ushort)uVar2;
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_12F = 1;
        DAT_3E++;
    }

    private void FUN_3F948()
    {
        bool bVar1;
        int iVar1;
        uint uVar2;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            iVar1 = (int)GameManager.FUN_64650();
            uVar2 = (uint)(iVar1 % 5 & 0xff);
            FUN_6103C(2, 9, (byte)uVar2, 5);
            DAT_60 = (ushort)uVar2;
        }
    }

    private void FUN_3F9E4()
    {
        ushort uVar1;

        uVar1 = (ushort)(DAT_196 - 1);

        if (DAT_196 < 0 || 0 < (DAT_196 = (short)uVar1) << 0x10)
            PTR_FUN_9C5EC[DAT_3E]();
        else
        {
            DAT_3C = 1;
            DAT_3D = 27;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_12C = 0;
            InventoryManager.FUN_4A7E8(5, DAT_163, false);
        }
    }

    private void FUN_3FA68()
    {
        PTR_FUN_9C5F4[DAT_3D]();
    }

    private void FUN_3FAA4()
    {
        int iVar2;
        CriPlayer oVar3;

        if ((DAT_1DE & 4) == 0)
        {
            screen = new Vector3Int(-0x2063, 0, -0xee8);
            vr.y = 0x2e0;
            FUN_609C8(5, 1, 0);
        }
        else
        {
            GameManager.instance.FUN_46C0C(0, 20, 1);
            oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
            oVar3.screen = new Vector3Int(0, 0, 0);
            oVar3.vr.y = 0;
            oVar3.PTR_124 = null;
            oVar3.PTR_120 = null;
            oVar3.DAT_12F = 0;
            oVar3.DAT_12E = 0;
            oVar3.DAT_140 |= 0x8000;
            oVar3.FUN_535E4(0x70, 0x70);
            GameManager.instance.PTR_FUN_14C = GameManager.FUN_2D6C8;
            FUN_65C4C(oVar3);

            if ((DAT_1DE & 2) == 0)
            {
                oVar3.DAT_3C = 6;
                oVar3.DAT_3D = 0;
                oVar3.DAT_3E = 0;
                oVar3.DAT_3F = 0;
                oVar3.vr.y = 0x800;
            }
            else
            {
                oVar3.DAT_3C = 6;
                oVar3.DAT_3D = 1;
                oVar3.DAT_3E = 0;
                oVar3.DAT_3F = 0;
            }

            oVar3.DAT_1C0 &= 0xfffffffe;
            screen = new Vector3Int(0x4b0, 0, -0x650);
            vr.y = 0x80;
            FUN_609C8(11, 0, 10);
            GameManager.instance.FUN_5C94C(this, 72);
            iVar2 = (int)GameManager.FUN_64650();
            DAT_1D7 = (byte)(iVar2 + (iVar2 / 2) * -2);
            SceneManager.instance.cCamera.DAT_70 = 1;
            SceneManager.instance.cCamera.PTR_FUN_8C = SceneManager.instance.cCamera.FUN_2EF18;
            oVar3.PTR_FUN_9C600[DAT_1D7]();
        }

        PTR_124 = null;
        PTR_120 = null;
        DAT_12F = 0;
        DAT_12E = 0;
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_140 |= 0x8000;
        flags |= 2;
        FUN_65CF8(0, 0, 30);
        DAT_3E++;
    }

    private void FUN_3FCCC()
    {
        bool bVar2;
        CriPlayer oVar2;
        CriCamera oVar3;

        if ((DAT_1DE & 4) != 0)
        {
            bVar2 = FUN_60AB4();

            if (bVar2)
            {
                oVar2 = SceneManager.instance.FUN_65B30(this) as CriPlayer;

                if (oVar2 != null)
                {
                    oVar2.FUN_609C8(23, 1, 10);
                    oVar2.DAT_40 = new Vector3Int(0, 0, 170);
                    oVar2.V2_1F4.x = oVar2.screen.x;
                    V2_1F4.y = oVar2.screen.z; //???
                    oVar2.UDAT_210 = Utilities.FUN_631AC(oVar2.screen, Utilities.DAT_9C610);
                    oVar2.DAT_3E++;
                }

                FUN_609C8(5, 1, 10);
                FUN_65CF8(3, 0, 30);
                DAT_168 = oVar2.screen;
                DAT_40 = new Vector3Int(0, 0, 0);
                V2_1F4 = new Vector2Int(screen.x, screen.z);
                UDAT_210 = Utilities.FUN_631AC(screen, Utilities.DAT_9C608);
                DAT_3E++;
                oVar3 = SceneManager.instance.cCamera;
                oVar3.DAT_70 = 1;
                oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
                oVar3.DAT_64 = oVar2;
                oVar3.PTR_FUN_8C = oVar3.PTR_FUN_9C618[DAT_1D7];
                oVar2.PTR_FUN_9C620[DAT_1D7]();
            }
        }
    }

    private void FUN_3FE64()
    {
        short sVar1;
        ushort uVar2;
        short sVar3;
        uint uVar4;
        uint uVar5;
        Vector3Int local_20;

        local_20 = new Vector3Int(V2_1F4.x, 0, V2_1F4.y);
        uVar4 = Utilities.FUN_631AC(local_20, screen);

        if (UDAT_210 < uVar4)
        {
            DAT_40 = new Vector3Int(0, 0, 0);
            DAT_3E++;
            FUN_609C8(1, 2, 10);
            FUN_65CF8(0, 0, 30);

            if ((DAT_1DE & 4) != 0)
                SceneManager.instance.DAT_272 = true;
        }
        else
        {
            if ((DAT_1DE & 4) == 0)
            {
                FUN_60AB4();
                uVar2 = (ushort)Utilities.FUN_615EC(screen, Utilities.DAT_9C630);
                sVar1 = (short)Utilities.FUN_64838(vr.y, 60, uVar2);
                vr.y = vr.y + sVar1 & 0xfff;
                sVar3 = 15;

                if (DAT_60 == 2)
                {
                    GameManager.instance.FUN_5C94C(this, 48);
                    sVar3 = 15;
                }
            }
            else
            {
                FUN_60AB4();
                sVar1 = FUN_64804(Utilities.DAT_9C628);

                if (DAT_60 - 32U < 19 || DAT_60 - 80U < 19)
                {
                    uVar5 = 20;

                    if ((ushort)(sVar1 - 0x401) < 0x7ffU)
                        uVar5 = 80;

                    uVar2 = (ushort)Utilities.FUN_615EC(screen, Utilities.DAT_9C628);
                    sVar1 = (short)Utilities.FUN_64838(vr.y, uVar5, uVar2);
                    DAT_40.z = 45;
                    vr.y = vr.y + sVar1 & 0xfff;
                }
                else
                    DAT_40.z = 0;

                sVar3 = 50;

                if (DAT_60 == 7)
                {
                    GameManager.instance.FUN_5C94C(this, 48);
                    sVar3 = 50;
                }
            }

            if (DAT_60 == sVar3)
                GameManager.instance.FUN_5C94C(this, 49);
        }
    }

    private void FUN_40070()
    {
        PTR_FUN_9C638[DAT_3E]();
    }

    private void FUN_400AC()
    {
        CriCamera oVar2;
        CriPlayer oVar3;

        if ((DAT_1DE & 4) == 0)
        {
            screen = new Vector3Int(-2500, 0, 0);
            vr.y = 0x400;
            FUN_609C8(10, 1, 0);
            oVar2 = SceneManager.instance.cCamera;
            oVar2.PTR_FUN_8C = oVar2.FUN_2F038;
            oVar2.DAT_64 = this;
            FUN_2F658();
        }
        else
        {
            GameManager.instance.FUN_46C0C(0, 20, 1);
            oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
            oVar3.screen = new Vector3Int(0, 0, 0);
            oVar3.vr.y = 0;
            oVar3.PTR_124 = null;
            oVar3.PTR_120 = null;
            oVar3.DAT_12F = 0;
            oVar3.DAT_12E = 0;
            oVar3.DAT_140 |= 0x8000;
            FUN_535E4(0x70, 0x70);
            GameManager.instance.PTR_FUN_14C = GameManager.FUN_2D6C8;
            FUN_65C4C(oVar3);

            if ((DAT_1DE & 2) == 0)
            {
                oVar3.DAT_3C = 6;
                oVar3.DAT_3D = 0;
                oVar3.DAT_3E = 0;
                oVar3.DAT_3F = 0;
                oVar3.vr.y = 0x800;
            }
            else
            {
                oVar3.DAT_3C = 6;
                oVar3.DAT_3D = 1;
                oVar3.DAT_3E = 0;
                oVar3.DAT_3F = 0;
            }

            oVar3.DAT_1C0 &= 0xfffffffe;
            screen = new Vector3Int(0, 0, -1400);
            vr.y = 0;
            FUN_609C8(0, 1, 0);
        }

        PTR_124 = null;
        PTR_120 = null;
        DAT_12F = 0;
        DAT_12E = 0;
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_140 |= 0x8000;
        flags |= 2;
        FUN_65CF8(0, 0, 30);
        DAT_3E++;
    }

    private void FUN_40284()
    {
        bool bVar1;

        if ((DAT_1DE & 4) == 0)
        {
            bVar1 = FUN_60AB4();

            if (bVar1)
            {
                FUN_6103C(1, 10, 7, 0);
                DAT_3E++;
            }

            if (DAT_60 == 37)
                GameManager.instance.FUN_5C94C(this, 50);

            if (DAT_60 - 32U < 19 || DAT_60 - 80U < 19)
                DAT_40.z = 45;
            else
                DAT_40.z = 0;
        }
        else
        {
            FUN_60AB4();

            if (DAT_60 == 4)
                GameManager.instance.FUN_5C94C(this, 53);

            if (DAT_60 == 16)
                GameManager.instance.FUN_5C94C(this, 54);

            if (DAT_60 == 25)
                GameManager.instance.FUN_5C94C(this, 55);

            if (DAT_60 == 1)
                ; //FUN_65D1C
        }
    }

    private void FUN_403C0()
    {
        FUN_60AB4();

        if (DAT_60 == 40)
            SceneManager.instance.DAT_272 = true;
    }

    private void FUN_40408()
    {
        PTR_FUN_9C648[DAT_3E]();
    }

    private void FUN_40444()
    {
        CriCamera oVar2;
        CriPlayer oVar3;

        GameManager.instance.FUN_46C0C(0, 20, 1);
        DialogManager.instance.DAT_B1440 = 2;
        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        oVar3.screen = new Vector3Int(0, 0, 0);
        oVar3.vr.y = 0;
        oVar3.PTR_124 = null;
        oVar3.PTR_120 = null;
        oVar3.DAT_12F = 0;
        oVar3.DAT_12E = 0;
        oVar3.DAT_140 |= 0x8000;
        oVar3.FUN_535E4(0x70, 0x70);
        GameManager.instance.PTR_FUN_14C = GameManager.FUN_2D6C8;
        FUN_65C4C(oVar3);

        if ((DAT_1DE & 2) == 0)
        {
            oVar3.DAT_3C = 6;
            oVar3.DAT_3D = 0;
            oVar3.DAT_3E = 0;
            oVar3.DAT_3F = 0;
            oVar3.vr.y = 0x800;
        }
        else
        {
            oVar3.DAT_3C = 6;
            oVar3.DAT_3D = 1;
            oVar3.DAT_3E = 0;
            oVar3.DAT_3F = 0;
        }

        oVar3.DAT_1C0 &= 0xfffffffe;
        screen = new Vector3Int(0xe80, 0, 0);
        vr.y = 0xc00;
        FUN_609C8(5, 1, 0);
        SceneManager.instance.FUN_264C4(0, (short)oVar3.screen.x, (short)(oVar3.screen.y - 500), (short)oVar3.screen.z);
        oVar2 = SceneManager.instance.cCamera;
        oVar2.DAT_7C = new Vector3Int(0xe80, 0xa00, 2000);
        oVar2.DAT_70 = 1;
        oVar2.PTR_FUN_8C = oVar2.FUN_2F0D4;
        oVar2.DAT_64 = this;
        SceneManager.instance.FUN_2F7B8();
        PTR_124 = null;
        PTR_120 = null;
        DAT_12F = 0;
        DAT_12E = 0;
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_140 |= 0x8000;
        flags |= 2;
        FUN_65CF8(0, 0, 30);
        DAT_1DF = 0;
        DAT_3E++;
    }

    private void FUN_40608()
    {
        CriCamera oVar1;
        short sVar2;
        ushort uVar3;
        uint uVar4;
        uint uVar5;

        if (SceneManager.instance.cCamera.DAT_7C.y < 0x201)
        {
            FUN_609C8(11, 0, 0);
            GameManager.instance.FUN_5C94C(this, 72);
            DAT_40 = new Vector3Int(0, 0, 0);
            oVar1 = SceneManager.instance.cCamera;
            oVar1.PTR_FUN_8C = oVar1.FUN_2F14C;
            oVar1.DAT_64 = this;
            DAT_3E++;
        }
        else
        {
            FUN_60AB4();
            sVar2 = FUN_64804(SceneManager.instance.DAT_27C[10].screen);

            if (DAT_60 - 32U < 19 || DAT_60 - 80U < 19)
            {
                uVar5 = 20;

                if ((ushort)(sVar2 - 0x401) < 0x7ffU)
                    uVar5 = 80;

                uVar3 = (ushort)Utilities.FUN_615EC(screen, SceneManager.instance.DAT_27C[10].screen);
                sVar2 = (short)Utilities.FUN_64838(vr.y, uVar5, uVar3);
                DAT_40.z = 45;
                vr.y = vr.y + sVar2 & 0xfff;
            }
            else
                DAT_40.z = 0;

            if (DAT_60 == 7)
                GameManager.instance.FUN_5C94C(this, 48);

            if (DAT_60 == 50)
                GameManager.instance.FUN_5C94C(this, 49);

            if (DAT_60 == 2)
            {
                uVar4 = GameManager.FUN_64650();

                if ((uVar4 & 2) == 0)
                    uVar5 = 71;
                else
                    uVar5 = 70;

                GameManager.instance.FUN_5C94C(this, (int)uVar5);
            }
        }
    }

    private void FUN_407B0()
    {
        FUN_60AB4();

        if (DAT_60 == 40)
            SceneManager.instance.DAT_272 = true;
    }

    private void FUN_407F8()
    {
        PTR_FUN_9C654[DAT_3E]();
    }

    private void FUN_4FD74()
    {
        DAT_227 &= 0x7f;
        GameManager.instance.PTR_FUN_148(this);
    }

    private void FUN_4FDBC()
    {
        DAT_227 &= 0x7f;
        GameManager.instance.PTR_FUN_14C(this);
    }

    public void FUN_21B0C(CriObject param1, short param2, CriInteract param3)
    {
        byte bVar1;
        ushort uVar2;
        CriPlayer oVar3;

        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((oVar3.DAT_11E & 8) == 0 || oVar3.DAT_1DC != this && 0 < health)
        {
            uVar2 = (ushort)(param2 + 0x800 & 0xfff);
            DAT_3C = 4;
            DAT_3D = 3;
            DAT_3E = 0;
            DAT_3F = 0;
            UDAT_1DA = uVar2;
            DAT_177 = 30;
            BDAT_1C0 |= 4;
            GameManager.instance.FUN_5C94C(param1, 219);

            if (param3.DAT_0B == 0)
                DAT_140 |= 1;

            flags |= 4;
            bVar1 = (byte)(BDAT_1C0 & 0xef);
            BDAT_1C0 = bVar1;

            if (0x7ff < ((uVar2 - (ushort)vr.y & 0xfff) + 0x400 & 0xfff))
            {
                BDAT_1C0 = (byte)(bVar1 | 0x10);
                UDAT_1DA = (ushort)(UDAT_1DA + 0x800 & 0xfff);
            }
        }
    }

    public void FUN_21C18(CriObject param1, short param2, CriInteract param3)
    {
        CriPlayer oVar1;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if ((DAT_11E & 8) == 0 || oVar1.DAT_1DC != this && 0 < health)
        {
            DAT_3C = 4;
            DAT_3D = 6;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1EC = param2;
            DAT_177 = 30;
            GameManager.instance.FUN_5C94C(param1, 219);

            if (param3.DAT_0B == 0)
                DAT_140 |= 1;

            flags |= 4;
        }
    }

    public void FUN_21CCC(CriObject param1, int param2)
    {
        if ((DAT_11E & 8) == 0)
        {
            GameManager.instance.PTR_FUN_148 = GameManager.FUN_21E7C;
            DAT_3C = 5;
            DAT_3D = 100;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_177 = 30;
            DAT_158 = new Vector3Int(0, param2, 0);
            DAT_3F = (byte)((((param2 + 0x800 & 0xfff) - vr.y & 0xfff) + 0x200 & 0xfff) >> 0x10);
            DAT_11E |= 0x80;
            DAT_12C |= 8;
            GameManager.instance.FUN_5C94C(param1, 219);
            DAT_12C |= 0x200;
            //...
        }
    }

    private void FUN_21D9C()
    {
        DAT_3E++;
        FUN_609C8((TodScriptableObject)GameManager.instance.playerCore.objects[DAT_9922C[DAT_3F]], 0, 0, 0);
        DAT_40 = new Vector3Int(0, 0, 180);
        DAT_18D = true;
        GameManager.instance.FUN_5C94C(this, 3);
    }

    private void FUN_21E10()
    {
        bool bVar1;

        if (DAT_40.z < 1)
            DAT_40.z = 0;
        else
            DAT_40.z -= 20;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_11E &= 0x7f;
            DAT_12C &= 0xfff7;
        }
    }

    public void FUN_21E7C()
    {
        PTR_FUN_9923C[DAT_3E]();
        Utilities.RotMatrix_gte(ref DAT_158, ref cTransform.rotation);
    }

    //FUN_2224 (ST2)
    private void FUN_2224()
    {
        health = 1000;
        maxHealth = 1000;
        DAT_112 = 10;
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_120 = 0;
        PTR_120 = null;
        DAT_175 = 2;
        DAT_11C = 0;
        DAT_3C++;
        FUN_609C8(11, 1, 10);
        DAT_3C = 4;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 0;
        DAT_12F = 4;
        DAT_1DF = 0;
        DAT_1C0 = 0;
        DAT_124 = 0;
        PTR_124 = ST2.instance.DAT_7558;
        DAT_154 = SceneManager.instance.DAT_27C[10];
    }

    //FUN_22D0 (ST2)
    private void FUN_22D0()
    {
        byte bVar1;
        short sVar2;

        if ((DAT_11E & 0x80) == 0)
            return;

        DAT_11E &= 0x7f;

        if (DAT_3C == 2)
            return;

        bVar1 = (byte)(DAT_1A0 >> 4);

        if (DAT_3D == 3)
        {
            if (0 < DAT_40.z)
                DAT_40.z = 0;

            if (bVar1 == 1)
            {
                if (DAT_60 < 15) goto LAB_2370;

                DAT_3C = 2;
                DAT_3D = 0;
                DAT_3E = 0;
                DAT_3F = 0;
                sVar2 = (short)(DAT_11C + 3);
            }
            else
            {
                if (bVar1 != 3) goto LAB_2370;

                DAT_3C = 2;
                DAT_3D = 0;
                DAT_3E = 0;
                DAT_3F = 0;
                sVar2 = (short)(DAT_11C + 6);
            }

            DAT_11C = sVar2;
        }

        LAB_2370:
        if ((DAT_1C0 & 0x40000000) == 0)
        {
            DAT_1C0 |= 0x40000000;
            DAT_1D9 = 0;
            DAT_1DA = 0;
        }
    }

    //FUN_2398 (ST2)
    private void FUN_2398()
    {
        if ((DAT_1C0 & 0x40000000) != 0)
            ST2.instance.FUN_3AC(this);

        if ((DAT_1C0 & 0x10000) != 0)
            ST2.instance.FUN_55C(this);

        ST2.instance.PTR_FUN_7C14[DAT_3D](this);
        ST2.instance.PTR_FUN_7C30[DAT_3D](this);
    }

    //FUN_2438 (ST2)
    public void FUN_2438()
    {
        uint uVar1;
        sbyte sVar2;

        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) != 0)
            return;

        if (DAT_3C != 0)
        {
            if ((DAT_18E & 0x80) != 0) goto LAB_2574;

            sVar2 = (sbyte)(DAT_1E2 >> 8);

            if (sVar2 == 6)
            {
                if (SceneManager.instance.cCamera.DAT_68 == 7)
                {
                    DAT_1C0 = DAT_1C0 & 0xfffdffff | 0x40000;
                    goto LAB_2514;
                }
            }

            if (sVar2 == 7 && SceneManager.instance.cCamera.DAT_68 == 6)
                DAT_1C0 &= 0xfff9ffff;
        }

        LAB_2514:
        DAT_34 = screen;
        FUN_22D0();
        PTR_FUN_7C4C[DAT_3C]();
        SceneManager.instance.FUN_802B8(this, false, 1);
        FUN_62F3C(ref DAT_40);

        LAB_2574:
        if ((UDAT_1D2 & 0x8000) != 0)
            ST2.instance.FUN_850(this);

        if (DAT_3C == 4)
            uVar1 = flags & 0xfffffffb;
        else
            uVar1 = flags | 4;

        flags = uVar1;
        DAT_1E2 = (ushort)(SceneManager.instance.cCamera.DAT_68 << 8 | (byte)DAT_1E2);
    }

    //FUN_2D98 (ST2)
    private void FUN_2D98()
    {
        return;
    }

    //FUN_2DA0 (ST2)
    private void FUN_2DA0(short param1, short param2)
    {
        DAT_10C.x = param1;
        DAT_10C.z = param2;
        SDAT_1D4 = (short)Utilities.FUN_615EC(screen, DAT_10C);
        DAT_40.z = 75;
        DAT_1C0 |= 3;
    }

    //FUN_2EFC (ST2)
    private void FUN_2EFC()
    {
        byte bVar1;
        int iVar2;
        bool bVar2;
        sbyte sVar3;
        uint uVar4;
        uint uVar5;

        if ((DAT_11E & 0x80) == 0)
            return;

        DAT_11E &= 0x7f;
        bVar2 = InventoryManager.FUN_4A87C(3, 0x3e);

        if (bVar2)
            return;

        if (DAT_3C == 2)
            return;

        if ((DAT_1C0 & 0x10000000) != 0)
            return;

        bVar1 = (byte)(DAT_1A0 >> 4);
        uVar4 = (uint)(DAT_1A0 & 0xf);

        if (bVar1 == 2)
            uVar5 = ST2.instance.DAT_7D54[uVar4];
        else
        {
            if (bVar1 < 3)
            {
                uVar5 = 0;

                if (bVar1 == 1)
                    uVar5 = ST2.instance.DAT_7D54[uVar4 + 4];
            }
            else
            {
                uVar5 = 0;

                if (bVar1 == 3)
                    uVar5 = ST2.instance.DAT_7D54[uVar4 + 8];
            }
        }

        iVar2 = (int)(uVar5 + IDAT_1C4);
        DAT_1C4 = (sbyte)iVar2;
        DAT_11C = (short)(uVar5 + DAT_11C);

        if (10 < iVar2)
            DAT_1C0 |= 0x40;

        sVar3 = (sbyte)DAT_3D;
        uVar4 = 0x102;

        if (sVar3 != 7)
        {
            if (2 < (ushort)DAT_11C)
            {
                iVar2 = ST2.instance.DAT_7D54[uVar4 + 12];

                if (-1 < iVar2)
                {
                    uVar4 = (uint)(iVar2 << 8 | 2);
                    goto LAB_3088;
                }

                sVar3 = (sbyte)(DAT_3D);
            }

            if (sVar3 != 2)
                return;

            uVar4 = 0x102;

            if (bVar1 == 2 && DAT_3A != 1)
                return;
        }

        LAB_3088:
        DAT_3C = (byte)uVar4;
        DAT_3D = (byte)(uVar4 >> 8);
        DAT_3E = (byte)(uVar4 >> 0x10);
        DAT_3F = (byte)(uVar4 >> 0x18);
        DAT_11C = 0;
    }

    //FUN_331C (ST2)
    private void FUN_331C()
    {
        CriObject oVar2;

        DAT_3C = 4;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 0;
        health = 1000;
        maxHealth = 1000;
        DAT_130 = 0;
        PTR_130 = ST2.instance.DAT_7CF4;
        DAT_40 = new Vector3Int(0, 0, 0);
        DAT_120 = 0;
        PTR_120 = null;
        DAT_140 = 1;
        BDAT_1E2 = 0;
        DAT_1D4 = 0;
        DAT_1D5 = 0;
        oVar2 = Utilities.FUN_601C8(skeleton, 2);
        PTR_1CC = oVar2;
        DAT_175 = 2;
        DAT_11C = 0;
        DAT_1DF = 0;
        DAT_1EA = 0; //ushort instead of byte??
        DAT_1C0 |= 0x21;
        DAT_1C4 = 0;
        DAT_1C5 = 0;
        DAT_1C6 = 0;
        DAT_1C7 = 0;
        DAT_154 = SceneManager.instance.DAT_27C[10];
        GameManager.instance.PTR_FUN_148 = ST2.FUN_530C;
        GameManager.instance.PTR_FUN_14C = ST2.FUN_5348;
        PTR_124 = ST2.instance.DAT_7CD0;
        DAT_124 = 0;
        DAT_12F = 3;
    }

    //FUN_3980 (ST2)
    private void FUN_3980()
    {
        DAT_1DF++;

        if (DAT_3A == 3)
            DAT_1DB = 1;
        else
        {
            DAT_3A = (byte)(DAT_3D - 1);
            DAT_1DB = (sbyte)(-0x301 < DAT_154.screen.x ? 1 : 0);

            if (DAT_3A == 0 || GameManager.instance.FUN_768C8(DAT_154.screen, ST2.instance.DAT_7DC0[DAT_1DB]))
                goto LAB_3A1C;
        }

        DAT_3A = 0;
        LAB_3A1C:
        DAT_112 = 0;
        DAT_40.z = 0;
        FUN_609C8(ST2.instance.DAT_7D00[DAT_1DB], 0, 0);
        PTR_120 = ST2.instance.DAT_7CD0;
        DAT_120 = 0;
        DAT_12E = 3;
        DAT_3E++;
        DAT_1C0 = DAT_1C0 & 0x7ffffff6 | 0x400;
        BDAT_1E2 = DAT_3D;
    }

    //FUN_3AA0 (ST2)
    private void FUN_3AA0()
    {
        bool bVar1;
        bool bVar2;
        uint uVar3;
        CriSkinned oVar4;

        oVar4 = DAT_154;

        if (frame.DAT_01 == 16)
        {
            DAT_40.z = ST2.instance.DAT_7DF0[DAT_3A * 2];
            DAT_112 = ST2.instance.DAT_7DF0[(DAT_3A << 2 | 2) / 2];
            GameManager.instance.FUN_5C94C(this, 48);
        }

        if (DAT_112 == 0)
            DAT_40.z = 0;
        else
            DAT_112--;

        bVar2 = FUN_60AB4();

        if (!bVar2)
        {
            bVar2 = SceneManager.instance.FUN_802B8(this, true, 2);

            if (!bVar2)
                return;

            uVar3 = DAT_1C0;
            bVar1 = true;

            if ((uVar3 & 0x1000) != 0)
                bVar1 = oVar4.health < 201;

            if (DAT_3D == 2)
                bVar1 = true;

            if (bVar1)
            {
                DAT_3C = 1;
                DAT_3D = 8;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_40.z = 0;
                oVar4.PTR_120 = null;
                oVar4.DAT_120 = 0;
                PTR_120 = null;
                DAT_120 = 0;
                FUN_609C8(ST2.instance.DAT_7D00[DAT_1DB + 2], 0, 10);
                oVar4.DAT_152 = 1;
                oVar4.DAT_154 = this;
                oVar4.DAT_3C = 5;
                oVar4.DAT_3D = 0;
                oVar4.DAT_3E = 0;
                oVar4.DAT_3F = 0;
                oVar4.DAT_11E |= 0x80;
                oVar4.vr.y = vr.y;
                oVar4.DAT_98 = DAT_98;
                FUN_656EC();
                GameManager.instance.FUN_5C94C(this, 49);
                FUN_2DA0(0xaf, 0x1300);
                DAT_1C0 |= 0x10000000;
                //FUN_1D988
                return;
            }
        }
        else
        {
            DAT_40.z = 0;
            DAT_3E++;
            FUN_609C8(ST2.instance.DAT_7D00[DAT_1DB + 4], 0, 0);
            uVar3 = DAT_1C0;
        }

        DAT_1C0 = uVar3 & 0xfffffbff;
    }

    //FUN_3E84 (ST2)
    private void FUN_3E84()
    {
        PTR_FUN_7E08[DAT_3E]();
    }

    //FUN_3EC0 (ST2)
    private void FUN_3EC0()
    {
        byte bVar1;
        sbyte sVar2;
        bool bVar3;
        int iVar3;
        uint uVar4;

        uVar4 = DAT_1C0;

        if ((uVar4 & 0x80) == 0)
        {
            if (DAT_154.screen.x < -0x2ff)
            {
                bVar1 = DAT_1EF;
                DAT_1EF = (byte)(bVar1 + 1);
                bVar1 = ST2.instance.DAT_7E24[bVar1];
                DAT_3D = (byte)(bVar1 & 0x7f);

                if ((bVar1 & 0x80) != 0)
                    DAT_1C0 |= 0x80;

                DAT_1C0 &= 0xfffff7ff;
                return;
            }

            DAT_1C0 = uVar4 | 0x80;

            if ((uVar4 & 0x800) == 0)
            {
                DAT_3D = 6;
                DAT_11C = 0;
                DAT_1C0 |= 9;
                return;
            }
        }

        if (1 < BDAT_1E2 - 1)
            DAT_1DF = 0;

        DAT_3E = 0;
        bVar3 = InventoryManager.FUN_4A87C(3, 0x22);

        if (!bVar3)
        {
            if (1 < DAT_1DF)
            {
                DAT_3D = 4;
                return;
            }

            if (BDAT_1E2 == 4)
            {
                DAT_3D = 2;
                return;
            }

            do
            {
                iVar3 = (int)GameManager.FUN_64650();
                sVar2 = ST2.instance.DAT_7E14[iVar3 >> 3 & 0xf];
                DAT_3D = (byte)sVar2;
            } while (sVar2 == BDAT_1E2);
        }
        else
        {
            InventoryManager.FUN_4A7E8(3, 0x22, false);
            DAT_3D = 1;
            DAT_3A = 3;
        }

        DAT_1C0 &= 0xfffff7ff;
    }

    //FUN_4258 (ST2)
    private void FUN_4258()
    {
        PTR_FUN_7E3C[DAT_3D & 0x7f]();
    }

    //FUN_4298 (ST2)
    private void FUN_4298()
    {
        bool bVar1;

        if (DAT_3E == 0)
        {
            DAT_3E++;
            FUN_609C8(17, 0, 0);
        }
        else
        {
            bVar1 = FUN_60AB4();

            if (bVar1)
            {
                DAT_3C = 1;
                DAT_3D = 0;
                DAT_3E = 0;
                DAT_3F = 0;
                BDAT_1E2 = 0;
            }
        }
    }

    //FUN_4300 (ST2)
    private void FUN_4300()
    {
        DAT_3C = 1;
        DAT_3D = 6;
        DAT_3E = 0;
        DAT_3F = 0;
        DAT_3E = 1;
        FUN_609C8(ST2.instance.DAT_7D00[DAT_1DB + 12], 0, 0);
        FUN_2DA0(0xaf, 0x1300);
        DAT_40.z = 100;
        GameManager.instance.FUN_5C94C(this, 54);
        DAT_1C0 = DAT_1C0 & 0xffffffdf | 0x80;
        BDAT_1E2 = 0;
    }

    //FUN_43A4 (ST2)
    private void FUN_43A4()
    {
        PTR_FUN_7E60[DAT_3D]();
    }

    //FUN_43E0 (ST2)
    private void FUN_43E0()
    {
        return;
    }

    //FUN_4BEC (ST2)
    private void FUN_4BEC()
    {
        PTR_FUN_8114[DAT_3D]();
    }

    //FUN_4C28 (ST2)
    public void FUN_4C28()
    {
        byte bVar1;
        bool bVar2;
        short sVar3;
        short sVar4;
        int iVar5;
        bool bVar5;
        uint uVar6;
        CriSkinned oVar7;

        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) != 0)
            return;

        if (DAT_3C != 0 && (DAT_18E & 0x80) != 0)
            return;

        oVar7 = DAT_154;
        DAT_34 = screen;
        FUN_2EFC();
        bVar5 = GameManager.instance.FUN_768C8(oVar7.screen, ST2.instance.DAT_7DC0[0]);

        if (!bVar5)
            uVar6 = DAT_1C0 & 0xffffefff;
        else
            uVar6 = DAT_1C0 | 0x1000;

        DAT_1C0 = uVar6;
        PTR_FUN_8134[DAT_3C]();
        FUN_62F3C(ref DAT_40);

        if (DAT_3C == 4 || (ushort)DAT_1D0 == 0)
            DAT_1C0 |= 0x40;
        else
            DAT_1D0--;

        if ((DAT_1C0 & 0x40) != 0 && DAT_3C == 1 && DAT_3D == 0)
        {
            InventoryManager.FUN_4A7E8(3, 0x3e, true);
            oVar7.DAT_11E = 0;
        }

        bVar5 = SceneManager.instance.FUN_802B8(this, false, 3);

        if (!bVar5)
        {
            FUN_66208();
            goto LAB_4EBC;
        }

        bVar2 = false;

        if (oVar7.DAT_152 == 0 && (oVar7.DAT_11E & 1) == 0)
        {
            bVar1 = DAT_3D;

            if (bVar1 == 4)
            {
                if ((DAT_1C0 & 0x400) != 0 && (DAT_12B & 6) == 0)
                    goto LAB_4E30;
            }
            else
            {
                if (bVar1 < 5)
                {
                    if (bVar1 < 3 && bVar1 != 0)
                    {
                        if ((DAT_1C0 & 0x400) != 0 && (DAT_12B & 6) == 0)
                            goto LAB_4E30;
                    }
                }
                else
                {
                    if (bVar1 == 7)
                    {
                        if ((DAT_1C0 & 0x400) != 0 && (DAT_12B & 6) == 0)
                            goto LAB_4E30;
                    }
                }
            }

            bVar2 = true;
        }

        LAB_4E30:
        if (bVar2)
        {
            oVar7.DAT_11E |= 0x80;
            sVar3 = oVar7.FUN_64804(screen);
            oVar7.DAT_3E = (byte)(((sVar3 + 0x200 & 0xfff) >> 10) | 0x10);
            oVar7.DAT_3C = 2;
            oVar7.DAT_3D = 0;
            oVar7.DAT_177 = 20;
            sVar3 = (short)(oVar7.health - 200);
            oVar7.health = sVar3;

            if (sVar3 < 100)
                oVar7.health = 100;

            //FUN_1D988
        }

        LAB_4EBC:
        if ((DAT_1C0 & 1) != 0 && DAT_3C != 4 && oVar7.DAT_152 == 0)
        {
            sVar4 = (short)Utilities.FUN_615EC(screen, oVar7.screen);
            iVar5 = (int)Utilities.FUN_64838(vr.y, 10, sVar4);
            vr.y += iVar5;

            if (0x900 < vr.y * 0x10000 >> 0x10)
                vr.y = 0x900;

            if (vr.y < 0x6d0)
                vr.y = 0x6d0;
        }

        if ((DAT_1C0 & 2) != 0)
        {
            uVar6 = Utilities.FUN_63160(DAT_10C, screen);

            if (uVar6 < 10000)
            {
                DAT_40.z = 0;
                screen.x = DAT_10C.x;
                screen.z = DAT_10C.z;
                DAT_1C0 &= 0xfffffffd;
            }
        }

        if (DAT_3C == 4)
            uVar6 = flags & 0xfffffffb;
        else
            uVar6 = flags | 4;

        flags = uVar6;
    }

    //FUN_4FD8 (ST2)
    private void FUN_4FD8()
    {
        CriPlayer oVar2;

        oVar2 = (CriPlayer)DAT_154;
        FUN_66418();
        DAT_3E++;
        FUN_609C8(ST2.instance.DAT_8148[oVar2.DAT_1DB], 0, 0);
        DAT_140 = 0xffff;
        DAT_12C = 0xffff;
        FUN_65714();
        DAT_1C0 &= 0xfffffffe;
        SceneManager.instance.cCamera.DAT_70 = 1;
        SceneManager.instance.cCamera.PTR_FUN_8C = SceneManager.instance.cCamera.FUN_2D20;
        //...
    }

    //FUN_50B8 (ST2)
    private void FUN_50B8()
    {
        CriSkinned oVar1;

        oVar1 = DAT_154;
        FUN_60AB4();
        FUN_65714();

        if (oVar1.frame.DAT_01 == 42)
        {
            SceneManager.instance.DAT_272 = false;
            SceneManager.instance.DAT_270 = 3;
            GameManager.instance.DAT_28 = 4;
        }
    }

    //FUN_5130 (ST2)
    private void FUN_5130()
    {
        PTR_FUN_8150[DAT_3E]();
    }

    //FUN_516C (ST2)
    private void FUN_516C(CriPlayer param1)
    {
        DAT_40.z = -0xf;
        DAT_3E++;
        FUN_609C8(22, 0, 10);
        param1.SDAT_1D4 = (short)Utilities.FUN_615EC(screen, param1.screen);
    }

    //FUN_51D0 (ST2)
    private void FUN_51D0(CriPlayer param1)
    {
        Vector3Int local_18;

        FUN_60AB4();

        if (DAT_3F != 0)
        {
            DAT_3F = 0;
            DAT_40.z = 0;
            DAT_3E++;
            FUN_609C8(23, 4, 0);
        }

        local_18 = new Vector3Int(0, param1.SDAT_1D4, 0);
        Utilities.RotMatrix(ref local_18, ref cTransform.rotation);
    }

    //FUN_5260 (ST2)
    private void FUN_5260(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_98 = DAT_1E0;
        }
    }

    //FUN_529C (ST2)
    private void FUN_529C()
    {
        short sVar1;
        CriPlayer oVar2;

        oVar2 = (CriPlayer)DAT_154;
        PTR_FUN_8158[DAT_3E](oVar2);
        sVar1 = (short)Utilities.FUN_64838(vr.y, 150, (ushort)oVar2.SDAT_1D4);
        vr.y += sVar1;
    }

    //FUN_530C (ST2)
    public void FUN_530C()
    {
        PTR_FUN_8164[DAT_3D]();
    }

    //FUN_252C (ST4)
    public void FUN_252C()
    {
        CriPlayer oVar1;
        sbyte sVar2;
        bool bVar3;
        bool bVar4;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if ((InventoryManager.DAT_B7A60[0] & 2) == 0)
        {
            if (DAT_3C == 0 || (DAT_18E & 0x80) == 0)
            {
                DAT_34 = screen;
                sVar2 = GameManager.instance.FUN_774CC(this, oVar1.screen);
                BDAT_1D8 = sVar2;
                ST4.instance.PTR_FUN_12F38[DAT_3C](this);
                vr.y &= 0xfff;
                FUN_62F3C(ref DAT_40);
                PTR_120 = ST4.instance.DAT_12890;
                DAT_120 = 0;
                bVar4 = SceneManager.instance.FUN_802B8(this, false, 3);

                if (bVar4)
                    ST4.instance.FUN_27AC(oVar1, this, DAT_12B & 7U);

                bVar3 = SceneManager.instance.FUN_80A14(this);

                if (bVar3)
                {
                    if (!DAT_1F3)
                        DAT_1F2 = 0;
                    else
                        DAT_1F2++;
                }

                DAT_1F3 = bVar3;
                ST4.instance.FUN_7E8(this);
            }

            if (IDAT_1C4 != 0)
                IDAT_1C4--;

            if (DAT_177 != 0)
                DAT_177--;

            if ((UDAT_1D2 & 0x8000) != 0)
                ST4.instance.FUN_824(this);

            if ((ushort)DAT_1D0 == 0)
                DAT_1C0 |= 1;
            else
                DAT_1D0--;

            if ((DAT_1C0 & 1) != 0 && (oVar1.DAT_11E & 0x80) == 0)
                InventoryManager.FUN_4A7E8(0, 0x7d, true);

            if ((DAT_1C0 & 0x40000000) != 0)
                ST4.instance.FUN_460(this);

            flags |= 4;
        }
    }

    //FUN_3AB8 (ST4)
    public void FUN_3AB8()
    {
        byte bVar1;
        short sVar2;
        bool bVar3;

        Utilities.RotMatrixYXZ(ref vr, ref cTransform.rotation);

        if (DAT_3C != 0)
        {
            if ((InventoryManager.DAT_B7A60[0] & 2) != 0)
            {
                FUN_66208();
                return;
            }

            if ((DAT_18E & 0x80) != 0)
            {
                FUN_66208();
                goto LAB_3C64;
            }
        }

        DAT_34 = screen;

        if (DAT_177 != 0)
            DAT_177--;

        if ((BDAT_1D0 & 1) != 0 && !GameManager.instance.DAT_6D)
        {
            BDAT_1D0 &= 0xfe;
            GameManager.instance.DAT_28 = 4;
        }

        ST4.instance.FUN_E528(this);
        sVar2 = (short)(SDAT_1F8 - 1);

        if (0 < SDAT_1F8)
        {
            SDAT_1F8 = sVar2;

            if (sVar2 << 0x10 < 0)
                SDAT_1F8 = 0;
        }

        ST4.instance.FUN_AEF4(this);
        //...
        ST4.instance.FUN_E23C(this);
        FUN_62F3C(ref DAT_40);
        bVar3 = SceneManager.instance.FUN_80030(this, DAT_18D, (byte)DAT_12E);

        if (!bVar3 || (DAT_128 & 0x400) == 0)
            bVar1 = (byte)(DAT_162 & 0xfe);
        else
            bVar1 = (byte)(DAT_162 | 1);

        DAT_162 = bVar1;
        ST4.instance.FUN_3F64(this);

        if (DAT_3C == 4)
            ST4.instance.FUN_7BD0(this);

        LAB_3C64:
        if (DAT_1C7 == 0)
            FUN_6449C(DAT_140);

        DAT_48 = (sbyte)-(screen.y / 0x1a9);
        bVar3 = SceneManager.instance.FUN_80500(this, (byte)BDAT_1C0);

        if (!bVar3)
            bVar1 = (byte)(DAT_162 & 0xfd);
        else
            bVar1 = (byte)(DAT_162 | 2);

        DAT_162 = bVar1;
        ST4.instance.FUN_DC10(this);

        if (DAT_3C == 4 || (DAT_3C == 2 && DAT_3D == 2) || DAT_3C == 6)
            flags &= 0xfffffffb;
        else
            flags |= 4;
    }

    //FUN_10E38 (ST4)
    public void FUN_10E38()
    {
        CriSkinned oVar1;
        sbyte sVar2;
        uint uVar3;

        Utilities.RotMatrix(ref vr, ref cTransform.rotation);
        oVar1 = SceneManager.instance.DAT_27C[10];

        if ((InventoryManager.DAT_B7A60[0] & 2) == 0)
        {
            if (DAT_3C == 0 || (DAT_18E & 0x80) == 0)
            {
                DAT_34 = screen;

                if ((DAT_1C0 & 2) == 0)
                {
                    DAT_158.x = oVar1.screen.x;
                    DAT_158.z = oVar1.screen.z;
                }

                sVar2 = GameManager.instance.FUN_774CC(this, DAT_158);
                DAT_1DB = sVar2;

                if ((DAT_11E & 0x80) != 0)
                    ST4.instance.FUN_10D80(this);

                ST4.instance.PTR_FUN_14194[DAT_3C](this);

                if ((flags & 1) == 0)
                    return;

                FUN_62F3C(ref DAT_40);

                if ((DAT_1C0 & 0x60) != 0)
                    ST4.instance.FUN_11020(this);

                FUN_6449C(0);
                SceneManager.instance.FUN_80030(this, true, 1);
                SceneManager.instance.FUN_80A14(this);
                //...
            }

            if (DAT_3C == 4)
                uVar3 = flags & 0xfffffffb;
            else
                uVar3 = flags | 4;

            flags = uVar3;
        }
    }
}
