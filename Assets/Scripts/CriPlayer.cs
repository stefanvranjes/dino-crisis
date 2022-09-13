using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriPlayer : CriSkinned
{
    public uint DAT_1C0; //0x1C0
    public sbyte BDAT_1C0; //0x1C0
    public sbyte DAT_1C1; //0x1C1
    public byte DAT_1C2; //0x1C2
    public sbyte DAT_1C3; //0x1C3
    public sbyte DAT_1C4; //0x1C4
    public byte DAT_1C5; //0x1C5
    public byte DAT_1C6; //0x1C6
    public sbyte DAT_1C7; //0x1C7
    public sbyte DAT_1C8; //0x1C8
    public byte DAT_1C9; //0x1C9
    public byte BDAT_1CA; //0x1CA
    public short DAT_1CA; //0x1CA
    public byte DAT_1CB; //0x1CB
    public byte DAT_1CC; //0x1CC
    public byte DAT_1CD; //0x1CD
    public byte DAT_1CE; //0x1CE
    public byte DAT_1CF; //0x1CF
    public uint DAT_1D0; //0x1D0
    public byte BDAT_1D0; //0x1D0
    public byte DAT_1D1; //0x1D1
    public byte DAT_1D2; //0x1D2
    public byte DAT_1D3; //0x1D3
    public byte DAT_1D4; //0x1D4
    public byte DAT_1D5; //0x1D5
    public byte DAT_1D6; //0x1D6
    public byte DAT_1D7; //0x1D7
    public byte BDAT_1D8; //0x1D8
    public CriStatic DAT_1D8; //0x1D8
    public byte DAT_1DA; //0x1DA
    public sbyte DAT_1DB; //0x1DB
    public CriPlayer DAT_1DC; //0x1DC
    public byte BDAT_1DC; //0x1DC
    public byte DAT_1DD; //0x1DD
    public byte DAT_1DE; //0x1DE
    public TodScriptableObject[] DAT_1E0; //0x1E0
    public ushort UDAT_1E0; //0x1E0
    public ushort DAT_1E2; //0x1E2
    public ushort UDAT_1E4; //0x1E4
    public byte DAT_1E4; //0x1E4
    public byte DAT_1E5; //0x1E5
    public ushort DAT_1E6; //0x1E6
    public ushort DAT_1E8; //0x1E8
    public short DAT_1EA; //0x1EA
    public short DAT_1EC; //0x1EC
    public short DAT_1EE; //0x1EE
    public CriPlayer DAT_1F0; //0x1F0
    public Vector2Int V2_1F0; //0x1F0
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
    public Vector4Int V4_21C; //0x21C
    public Object[] REFS;
    public int DAT_21C; //0x21C
    public int DAT_220; //0x220
    public Vector3Int V3_224; //0x224
    public byte DAT_224; //0x224
    public sbyte DAT_226; //0x226
    public byte DAT_227; //0x227
    public byte DAT_240; //0x240
    public ushort[] DAT_244; //0x244
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
    private delegate void FUN_9B980();
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
    private delegate void FUN_9C660();
    private delegate void FUN_9C674();
    private delegate void FUN_9C67C();
    private delegate void FUN_9C694();
    private delegate void FUN_9CDE4();
    private delegate void FUN_9CE2C();
    private delegate void FUN_9CE04();
    private delegate void FUN_9CEA4();
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
    private FUN_9B980[] PTR_FUN_9B980;
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
    private FUN_9C660[] PTR_FUN_9C660;
    private FUN_9C674[] PTR_FUN_9C674;
    private FUN_9C67C[] PTR_FUN_9C67C;
    private FUN_9C694[] PTR_FUN_9C694;
    private FUN_9CDE4[] PTR_FUN_9CDE4;
    private FUN_9CE2C[] PTR_FUN_9CE2C;
    private FUN_9CE04[] PTR_FUN_9CE04;
    private FUN_9CEA4[] PTR_FUN_9CEA4;
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
    private static int[][] DAT_9CFA8 = new int[][]
    {
        new int[1] { 0 },  //DAT_9CF74
        new int[4],  //DAT_9CF78
        new int[4] { 0, 0, 8, 8 }, //DAT_9CF88
        new int[4] //DAT_9CF98
    };
    private static RefScriptableObject[][] PTR_9CFA8 = new RefScriptableObject[][]
    {
        new RefScriptableObject[1], //PTR_9CF74
        new RefScriptableObject[4], //PTR_9CF78, 
        new RefScriptableObject[4]
        {
            (RefScriptableObject)SceneManager.instance.database.common.objects[0x8017B83C],
            (RefScriptableObject)SceneManager.instance.database.common.objects[0x8017B83C],
            (RefScriptableObject)SceneManager.instance.database.common.objects[0x8017B83C],
            (RefScriptableObject)SceneManager.instance.database.common.objects[0x8017B83C]
        }, //PTR_9CF88
        new RefScriptableObject[4] //PTR_9CF98
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
    private static Object[] DAT_9D1D4 = new Object[2] { null, null };

    protected override void Awake()
    {
        base.Awake();
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
        PTR_FUN_9CE2C = new FUN_9CE2C[2]
        {
            FUN_4DCB4, 
            FUN_4DD3C
        };
        PTR_FUN_9CE04 = new FUN_9CE04[10]
        {
            FUN_4D7A4,
            FUN_4DADC,
            FUN_4DDC0,
            FUN_4DF9C,
            FUN_4E130,
            FUN_4E2F0,
            null,
            null,
            FUN_4EF74,
            FUN_4F074
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
        FUN_4CFDC();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_1C0 = 0;
        BDAT_1C0 = 0;
        DAT_1C1 = 0;
        DAT_1C2 = 0;
        DAT_1C3 = 0;
        DAT_1C4 = 0;
        DAT_1C5 = 0;
        DAT_1C6 = 0;
        DAT_1C7 = 0;
        DAT_1C8 = 0;
        DAT_1C9 = 0;
        BDAT_1CA = 0;
        DAT_1CA = 0;
        DAT_1CB = 0;
        DAT_1CC = 0;
        DAT_1CD = 0;
        DAT_1CE = 0;
        DAT_1CF = 0;
        DAT_1D0 = 0;
        BDAT_1D0 = 0;
        DAT_1D1 = 0;
        DAT_1D2 = 0;
        DAT_1D3 = 0;
        DAT_1D4 = 0;
        DAT_1D5 = 0;
        DAT_1D6 = 0;
        DAT_1D7 = 0;
        BDAT_1D8 = 0;
        DAT_1D8 = null;
        DAT_1DA = 0;
        DAT_1DB = 0;
        DAT_1DC = null;
        BDAT_1DC = 0;
        DAT_1DD = 0;
        DAT_1DE = 0;
        DAT_1E0 = null;
        UDAT_1E0 = 0;
        DAT_1E2 = 0;
        UDAT_1E4 = 0;
        DAT_1E4 = 0;
        DAT_1E5 = 0;
        DAT_1E6 = 0;
        DAT_1E8 = 0;
        DAT_1EA = 0;
        DAT_1EC = 0;
        DAT_1EE = 0;
        DAT_1F0 = null;
        V2_1F0 = Vector2Int.zero;
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
        V4_21C = Vector4Int.zero;
        REFS = null;
        DAT_21C = 0;
        DAT_220 = 0;
        V3_224 = Vector3Int.zero;
        DAT_224 = 0;
        DAT_226 = 0;
        DAT_227 = 0;
        DAT_240 = 0;
        DAT_244 = new ushort[4];
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
        CriStatic local_18;
        byte local_14;

        bVar3 = (byte)(((byte)GameManager.instance.DAT_40 ^ 1) & 1);

        if (bVar3 != 0)
        {
            DAT_34 = screen;
            FUN_5211C(DAT_1CF);
        }

        vr.y &= 0xfff;
        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if (bVar3 != 0)
        {
            uVar4 = DAT_3C;

            if (uVar4 != 0)
            {
                FUN_659D0();
                uVar4 = DAT_3C;
            }

            PTR_FUN_9CDE4[uVar4]();
            bVar3 = frames[frameNum].DAT_03;
            //sound...
            FUN_62F3C(ref DAT_40);
            FUN_66208();

            if ((DAT_1C0 & 1) != 0 && (DAT_3C == 1 || DAT_3C == 4))
                FUN_65A28();

            SceneManager.instance.FUN_80030(this, DAT_18D, 1);
            FUN_52618();
            local_18 = null;
            local_14 = 0;
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
        FUN_604A4((Tmd2ScriptableObject)SceneManager.instance.database.playerCore.objects[0x8018066C]);
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
        FUN_609C8((TodScriptableObject)REFS[DAT_220], 1, 0);
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
                    //...
                }

                goto case 0;
            case 0:
            case 4:
                iVar3 = (int)(uVar5 + 4);
                break;
            case 3:
                if ((DAT_240 & 0xf0) != 0)
                {
                    //...
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

        //sound...
        DAT_11E |= 0x80;
        FUN_609C8(oVar6, 0, 0);
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
        FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8019C230], 0, 0);
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
                //...
            }

            //sound...
            FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8019C388], 0, 0);
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
            FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8019CF60], 0, 0);
            DAT_3D++;
        }
    }

    private void FUN_4F7A0()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8019D2B0], 0, 0);
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
            FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801860CC], 2, 0);
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

            //sound...
            FUN_609C8(Utilities.DAT_18770[uVar5], 0, 0);
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
            //...
        }

        //sound...
        DAT_11E |= 0x80;
        FUN_609C8(oVar4, 0, 0);
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
            //load player core file
        }

        uVar4 = 0;
        iVar5 = (int)(uVar8 & 3);
        DAT_21C = DAT_9CFA8[param1][iVar5];
        REFS = PTR_9CFA8[param1][iVar5].ASSET_REFS;
        oVar2 = (CriBone)Utilities.FUN_601C8(skeleton, 3);
        oVar2.cMesh = (Tmd3ScriptableObject)PTR_9CFA8[param1][iVar5].ASSET_REFS[DAT_21C];
        oVar2.materials = new Material[255];
        Tmd3ScriptableObject tmd = oVar2.cMesh;
        Material mat1 = new Material(GameManager.instance.materials[0x34]);
        Material mat2 = new Material(GameManager.instance.materials[0x3C]);
        mat1.mainTexture = tmd.TEX_2D;
        mat1.SetTexture("_Tex8", tmd.TEX8_2D);
        mat1.SetTexture("_CLUT", tmd.CLUT_2D);
        oVar2.materials[0x34] = mat1;
        mat2.mainTexture = tmd.TEX_2D;
        mat2.SetTexture("_Tex8", tmd.TEX8_2D);
        mat2.SetTexture("_CLUT", tmd.CLUT_2D);
        oVar2.materials[0x3C] = mat2;
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

    private void FUN_4FE30()
    {
        if (550 < health)
        {
            DAT_1D7 = 0;
            DAT_220 = DAT_21C + 1;
        }

        else if (250 < health)
        {
            DAT_1D7 = 1;
            DAT_220 = DAT_21C + 8;
        }
        else
        {
            DAT_1D7 = 2;
            DAT_220 = DAT_21C + 15;
        }
    }

    private void FUN_4FC8C()
    {
        TodScriptableObject[] local_18;

        local_18 = new TodScriptableObject[2]
        {
            (TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80189774],
            (TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8018A058]
        };

        if (DAT_3E == 0)
        {
            DAT_11E |= 0x81;
            DAT_40 = new Vector3Int(0, 0, 0);
            DAT_1C0 &= 0xfffffffe;
            FUN_535E4(0x20, 0x20);
            DAT_227 &= 0x7f;
            DAT_112 = 0;
            FUN_609C8(local_18[DAT_3F], 0, 6);
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
        int iVar4;
        int iVar5;

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
                    //...
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

                FUN_609C8((TodScriptableObject)REFS[DAT_220], 1, (byte)iVar6);
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
                        //...
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
                    FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x80190604], 1, 0);
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

        //FUN_4A7E8

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
                //FUN_4A7E8
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
        //FUN_4A7E8

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
            //FUN_4A7E8
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

        FUN_6103C((TodScriptableObject)REFS[DAT_220 + 1], 1, DAT_1F4, DAT_1F5);
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

        //FUN_4E694
        bVar1 = false; //tmp

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
            FUN_6103C((TodScriptableObject)REFS[DAT_220 + 2], 1, DAT_1F4, DAT_1F5);
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

        //FUN_4A7E8

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
            FUN_6103C((TodScriptableObject)REFS[DAT_220 + 3], 1, DAT_1F4, DAT_1F5);
            DAT_40.z = -40;
            DAT_1C0 &= 0xfffffffe;
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }

        //FUN_4A7E8

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
            FUN_609C8((TodScriptableObject)REFS[DAT_220 + 1], 1, 10);
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

        //FUN_4A7E8

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
                ; //FUN_4A7E8
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

                    FUN_6103C((TodScriptableObject)REFS[DAT_220 + 4], 1, DAT_1F4, DAT_1F5);
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

        //FUN_4A7E8

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
            //FUN_4A7E8
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
            //FUN_4E694
            bVar6 = false; //tmp

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
                FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801860CC], (byte)uVar2, 0);
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

        if (DAT_3E == 0)
        {
            DAT_40.z = 0;
            DAT_1C0 &= 0xfffffffe;

            if (DAT_3F == 0)
            {
                oVar2 = (TodScriptableObject)REFS[DAT_220];
                uVar3 = 14;
            }
            else
            {
                oVar2 = (TodScriptableObject)REFS[DAT_220 + 1];
                uVar3 = 5;
            }

            FUN_609C8(oVar2, 1, (byte)uVar3);
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
        if (!GameManager.instance.DAT_A2D2)
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

        if (!GameManager.instance.DAT_A2D2)
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

        if (!GameManager.instance.DAT_A2D2)
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

            if (!GameManager.instance.DAT_A2D2)
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

            if (!GameManager.instance.DAT_A2D2)
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

        if (!GameManager.instance.DAT_A2D2)
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
        CriUnknown oVar1;
        CriBone oVar2;

        if (DAT_202 == 0)
        {
            oVar1 = SceneManager.instance.FUN_5FF08();

            if (oVar1 != null)
            {
                oVar1.DAT_01 = 11;
                oVar1.DAT_0A = 12;
                oVar2 = skeleton;
                //...
                oVar1.PTR_18 = oVar2;
                DAT_202 = 50;
            }
        }

        FUN_44A24();
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

    private void FUN_5211C(byte param1)
    {
        uint uVar2;
        uint uVar5;
        CriSkinned oVar6;
        byte bVar8;
        uint[] local_50;
        byte[] local_40;

        bVar8 = 0;
        uVar5 = 0;
        local_50 = new uint[10];
        local_40 = new byte[10 * 4];

        do
        {
            uVar2 = 0x80000000;
            oVar6 = SceneManager.instance.DAT_27C[uVar5];

            if (oVar6 != null && (oVar6.flags & 1) != 0 && 0 < oVar6.health && (oVar6.DAT_175 & 0x80) == 0)
            {
                //...
            }

            local_50[uVar5] = uVar2 + uVar5;
            uVar5++;
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

            if (DAT_3C != 1 && DAT_3D != 5)
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
            DAT_1FC = oVar2.screen;
        }
    }

    public void FUN_5397C(byte param1)
    {
        DAT_1C5 = param1;
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
        FUN_609C8((TodScriptableObject)REFS[DAT_21C + 2], 1, 5);

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
                //FUN_4A7E8
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
        FUN_609C8((TodScriptableObject)REFS[DAT_21C + 1], 0, 8);
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
        FUN_609C8((TodScriptableObject)REFS[DAT_21C + 2], 1, 5);
        DAT_3E++;
    }

    private void FUN_541F0()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51C8C(screen, PTR_190[DAT_190], vr.y, 90);

        if (sVar1 == 0)
        {
            FUN_609C8((TodScriptableObject)REFS[DAT_21C + 5], 1, 5);
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
                //FUN_4A7E8
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
        FUN_609C8((TodScriptableObject)REFS[DAT_21C + 4], 1, 5);
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
                //FUN_4A7E8
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

        oVar1 = (TodScriptableObject)REFS[DAT_21C + 2];
        DAT_1C0 &= 0xfffffffe;
        FUN_609C8(oVar1, 1, 5);
        PTR_190[DAT_190].y = vr.y + PTR_190[DAT_190].y & 0xfff;
        DAT_3E++;
    }

    private void FUN_540CC()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51D40(PTR_190[DAT_190].y, vr.y, 90);

        if (sVar1 == 0)
        {
            //FUN_4A7E8
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
        FUN_609C8((TodScriptableObject)REFS[DAT_21C + 2], 1, 5);

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
            //FUN_4A7E8
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
        FUN_609C8((TodScriptableObject)REFS[DAT_21C + 6], 1, 10);
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
        FUN_609C8((TodScriptableObject)REFS[DAT_21C + 5], 1, 5);
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
        FUN_609C8((TodScriptableObject)REFS[DAT_21C + 2], 1, 2);
        DAT_3E++;
    }

    private void FUN_54894()
    {
        short sVar1;

        sVar1 = Utilities.FUN_51D40((short)(DAT_1F4 | DAT_1F5 << 8), vr.y, 200);

        if (sVar1 == 0)
        {
            //FUN_4A7E8
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
        FUN_609C8((TodScriptableObject)REFS[DAT_21C + 7], 1, 5);
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
                //FUN_4A7E8
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
        FUN_50FE4((TodScriptableObject)REFS[DAT_21C + 22], 
            (TodScriptableObject)REFS[DAT_21C + 23], 
            (TodScriptableObject)REFS[DAT_21C + 24], 0, 4);
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
            FUN_50FE4((TodScriptableObject)REFS[DAT_21C + 25], 
                (TodScriptableObject)REFS[DAT_21C + 26], 
                (TodScriptableObject)REFS[DAT_21C + 27], 0, 4);
            //FUN_4A7E8
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
        FUN_609C8((TodScriptableObject)REFS[DAT_220 + 1], 1, 5);

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
        FUN_609C8((TodScriptableObject)REFS[DAT_220], 0, 8);
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

        if ((GameManager.instance.DAT_40 & 0x400) == 0)
        {
            DAT_34 = screen;
            FUN_5211C(DAT_1CF);
        }

        vr.y &= 0xfff;
        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if ((GameManager.instance.DAT_40 & 0x400) == 0)
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

                //FUN_5D0C4
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
        DAT_220 = 1;
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
        FUN_609C8((TodScriptableObject)REFS[DAT_220], 0, 0);
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

    private void FUN_2E9CC()
    {
        if ((DAT_208 & 0x20) != 0)
        {
            //FUN_65D1C
            DAT_208 &= 0xffffffdf;
        }
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
        short sVar6;
        uint uVar7;
        uint uVar10;
        Vector3Int plVar11;

        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if (DAT_3C != 0)
        {
            if ((GameManager.instance.DAT_40 & 2) != 0)
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

        

        LAB_2FE28:;
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
        //sound...
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
            ; //sound...
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
        //sound...
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
            ; //sound...
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
        //sound...
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
                ; //sound...
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
        //sound...
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
        //sound...
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
        FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x801860CC], 6, 0);
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
            //FUN_1F988
            uVar2 = DAT_60;
        }

        if (uVar2 == 18)
        {
            //sound...
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
                //sound...

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
                FUN_609C8((TodScriptableObject)SceneManager.instance.database.playerCore.objects[0x8019D2B0], 0, 0);
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
            ; //sound...
    }

    private void FUN_2B4E8()
    {
        sbyte sVar1;
        int iVar2;
        CriPlayer oVar3;

        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        sVar1 = GameManager.instance.FUN_7732C((ushort)screen.x, (ushort)screen.z, (byte)DAT_48);
        BDAT_1C0 = sVar1;
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
        BDAT_1C0 = sVar2;
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

    private void FUN_3031C()
    {
        PTR_FUN_9B980[DAT_3D]();
    }

    private void FUN_30358()
    {
        FUN_3021C();
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
        //sound
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
            ; //sound

        if (uVar1 == 0x10)
            ; //sound

        if (DAT_60 == 0x19)
            ; //sound

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
            ; //sound

        if (uVar1 == 50)
            ; //sound

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

            //sound
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
            ; //sound

        if (uVar2 == 15)
            ; //sound

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
        //sound
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
            ; //sound

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
            ; //sound

        if (uVar1 == 7)
            ; //sound

        if (DAT_60 == 50)
            ; //sound

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
                ; //sound

            if (DAT_60 == 20)
                ; //sound

            if (DAT_60 == 29)
                ; //sound
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
                ; //sound

            if (DAT_60 == 23)
                ; //sound
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
            ; //sound

        if (DAT_60 == 9)
            ; //sound

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
            //sound

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
            ; //sound

        if (DAT_60 == 24)
            ; //sound

        if (DAT_60 == 14)
            ; //sound

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
        //sound
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
            ; //sound

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
            ; //sound
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
                //sound
            }

            if (uVar4 == 10 || uVar4 == 29 || uVar4 == 45 || uVar4 == 53)
            {
                uVar6 = GameManager.FUN_64650();
                //sound
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
        //sound
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
            ; //sound
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
            ; //sound

        if (DAT_60 == 15)
            ; //sound

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
                //sound

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
                ; //sound

            if (DAT_60 == 47)
            {
                //sound
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
            ; //sound

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

            //sound

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
            //sound
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
            ; //sound
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
                ; //sound

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
            ; //sound

        if (DAT_60 == 50)
            ; //sound

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

            //sound
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
            ; //sound
    }

    private void FUN_38C94()
    {
        PTR_FUN_9C1DC[DAT_3E]();
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
                //sound
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
                            //sound
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

                //sound
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
                        //sound

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

    private void FUN_3DBB4()
    {
        FUN_60AB4();
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
}
