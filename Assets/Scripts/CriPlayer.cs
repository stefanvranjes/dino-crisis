using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriPlayer : CriSkinned
{
    public uint DAT_1C0; //0x1C0
    public sbyte DAT_1C4; //0x1C4
    public byte DAT_1C5; //0x1C5
    public byte DAT_1C6; //0x1C6
    public sbyte DAT_1C8; //0x1C8
    public byte DAT_1C9; //0x1C9
    public short DAT_1CA; //0x1CA
    public byte DAT_1CD; //0x1CD
    public byte DAT_1CF; //0x1CF
    public uint DAT_1D0; //0x1D0
    public byte DAT_1D4; //0x1D4
    public byte DAT_1D6; //0x1D6
    public byte DAT_1D7; //0x1D7
    public CriStatic DAT_1D8; //0x1D8
    public CriPlayer DAT_1DC; //0x1DC
    public TodScriptableObject[] DAT_1E0; //0x1E0
    public byte DAT_1E4; //0x1E4
    public short DAT_1E6; //0x1E6
    public short DAT_1E8; //0x1E8
    public short DAT_1EA; //0x1EA
    public CriPlayer DAT_1F0; //0x1F0
    public byte DAT_1F4; //0x1F4
    public byte DAT_1F5; //0x1F5
    public byte DAT_1F6; //0x1F6
    public byte DAT_1F7; //0x1F7
    public byte DAT_1F8; //0x1F8
    public byte DAT_1F9; //0x1F9
    public sbyte DAT_1FA; //0x1FA
    public sbyte DAT_1FB; //0x1FB
    public Vector3Int DAT_1FC; //0x1FC
    public Vector3Int DAT_204; //0x204
    public Vector2Int DAT_20C; //0x20C
    public byte DAT_210; //0x210
    public byte DAT_211; //0x211
    public byte DAT_212; //0x212
    public byte DAT_213; //0x213
    public byte DAT_216; //0x216
    public byte DAT_217; //0x217
    public bool DAT_218; //0x218
    public byte DAT_219; //0x219
    public Object[] REFS;
    public int DAT_21C; //0x21C
    public int DAT_220; //0x220
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
            SceneManager.instance.database.DAT_17B83C,
            SceneManager.instance.database.DAT_17B83C,
            SceneManager.instance.database.DAT_17B83C,
            SceneManager.instance.database.DAT_17B83C
        }, //PTR_9CF88
        new RefScriptableObject[4] //PTR_9CF98
    };
    private static byte[] DAT_9D06C = new byte[]
    {
        0x50, 0x30, 0x20, 0
    };

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
        DAT_244 = new ushort[3];
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
        DAT_1C4 = 0;
        DAT_1C5 = 0;
        DAT_1C6 = 0;
        DAT_1C8 = 0;
        DAT_1C9 = 0;
        DAT_1CA = 0;
        DAT_1CD = 0;
        DAT_1CF = 0;
        DAT_1D0 = 0;
        DAT_1D4 = 0;
        DAT_1D6 = 0;
        DAT_1D7 = 0;
        DAT_1D8 = null;
        DAT_1DC = null;
        DAT_1E0 = null;
        DAT_1E4 = 0;
        DAT_1E6 = 0;
        DAT_1E8 = 0;
        DAT_1EA = 0;
        DAT_1F0 = null;
        DAT_1F4 = 0;
        DAT_1F5 = 0;
        DAT_1F6 = 0;
        DAT_1F7 = 0;
        DAT_1F8 = 0;
        DAT_1F9 = 0;
        DAT_1FA = 0;
        DAT_1FB = 0;
        DAT_1FC = Vector3Int.zero;
        DAT_204 = Vector3Int.zero;
        DAT_20C = Vector2Int.zero;
        DAT_210 = 0;
        DAT_211 = 0;
        DAT_212 = 0;
        DAT_213 = 0;
        DAT_216 = 0;
        DAT_217 = 0;
        DAT_218 = false;
        DAT_219 = 0;
        REFS = null;
        DAT_21C = 0;
        DAT_220 = 0;
        DAT_224 = 0;
        DAT_226 = 0;
        DAT_227 = 0;
        DAT_240 = 0;
        DAT_244 = new ushort[3];
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

        bVar3 = (byte)((GameManager.instance.DAT_40 ^ 1) & 1);

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

            //FUN_80030
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
        FUN_604A4(SceneManager.instance.database.playerSkin);
        sVar2 = 1200;

        if (GameManager.instance.difficulty != _DIFFICULTY.Normal)
            sVar2 = 2400;

        maxHealth = sVar2;
        //health = GameManager.instance.playerHealth;
        health = maxHealth; //tmp
        DAT_240 = GameManager.instance.DAT_A100;
        DAT_1C0 = GameManager.instance.DAT_A0F4;
        DAT_1E8 = GameManager.instance.DAT_A0F2;
        DAT_244 = new ushort[3] { GameManager.instance.DAT_A0F8[0],
                                  GameManager.instance.DAT_A0F8[1],
                                  GameManager.instance.DAT_A0F8[2] };
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
        DAT_12E = true;
        DAT_12F = true;
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
        FUN_609C8(SceneManager.instance.database.DAT_19C230, 0, 0);
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
            FUN_609C8(SceneManager.instance.database.DAT_19C388, 0, 0);
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
            FUN_609C8(SceneManager.instance.database.DAT_19CF60, 0, 0);
            DAT_3D++;
        }
    }

    private void FUN_4F7A0()
    {
        bool bVar1;

        bVar1 = FUN_60AB4();

        if (bVar1)
        {
            FUN_609C8(SceneManager.instance.database.DAT_19D2B0, 0, 0);
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
            FUN_609C8(SceneManager.instance.database.DAT_1860CC, 2, 0);
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

    private void FUN_4FE90(uint param1)
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
            SceneManager.instance.database.DAT_189774,
            SceneManager.instance.database.DAT_18A058
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
            DAT_1E8 = sVar1;

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

                sVar1 = DAT_1E8;
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
        if ((GameManager.instance.DAT_1f80000a & 2) != 0)
            DAT_1C6 = 1;

        if (DAT_1C5 != 0)
        {
            DAT_1C5--;
            GameManager.instance.DAT_1f800008 |= 8;
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

        uVar1 = GameManager.instance.DAT_1f800008 | 
            (uint)GameManager.instance.DAT_1f80000a << 0x10;

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
                    FUN_609C8(SceneManager.instance.database.playerIdle, 1, 0);
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

        uVar4 = GameManager.instance.DAT_1f800008 | 
            (uint)GameManager.instance.DAT_1f80000a << 0x10;
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

        uVar2 = GameManager.instance.DAT_1f800008 | 
            (uint)GameManager.instance.DAT_1f80000a << 0x10;

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

        uVar1 = GameManager.instance.DAT_1f800008 | 
            (uint)GameManager.instance.DAT_1f80000a << 0x10;

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

        uVar1 = GameManager.instance.DAT_1f800008 |
            (uint)GameManager.instance.DAT_1f80000a << 0x10;

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

        uVar4 = GameManager.instance.DAT_1f800008 |
            (uint)GameManager.instance.DAT_1f80000a << 0x10;
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
                FUN_609C8(SceneManager.instance.database.DAT_1860CC, (byte)uVar2, 0);
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
                    (GameManager.instance.DAT_1f800008 & 0xa000) != 0)
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
                if ((GameManager.instance.DAT_1f800008 & 0x2000) == 0)
                {
                    if ((GameManager.instance.DAT_1f800008 & 0x8000) == 0)
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

    private void FUN_5348C(sbyte param1, sbyte param2)
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

    private void FUN_535E4(sbyte param1, sbyte param2)
    {
        CriBone oVar1;

        oVar1 = (CriBone)Utilities.FUN_601C8(skeleton, 7);
        DAT_164 = 0;

        if (param1 == -1)
            DAT_20C = new Vector2Int(vr.x, vr.y);
        else
        {
            DAT_1FA = param1;
            DAT_1FB = param2;
        }

        oVar1.DAT_43 = false;
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
        FUN_609C8(SceneManager.instance.database.DAT_1860CC, 6, 0);
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
                FUN_609C8((TodScriptableObject)SceneManager.instance.database.DAT_19D2B0, 0, 0);
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
        DAT_12F = false;
        DAT_12E = false;
        DAT_11E |= 0x81;
        DAT_227 &= 0x7f;
        //FUN_5C94C
        DAT_3E++;
    }

    private void FUN_2B3E4()
    {
        return;
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
