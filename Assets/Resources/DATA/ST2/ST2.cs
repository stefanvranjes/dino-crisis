using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct UNK_7888
{
    public byte DAT_00;
    public sbyte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public Vector3Int DAT_04;
    public ushort DAT_0A;
    public int DAT_0C;
}

public struct UNK_7918
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

public class ST2 : LevelManager
{
    public static new ST2 instance;
    public static CapsuleCollider[] DAT_7558 = new CapsuleCollider[] { }; //0x7558 (ST2)

    public FUN_B58BC[] DAT_7470 = new FUN_B58BC[6] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08 };
    public FUN_B58C0[] DAT_74BC = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0 };
    public FUN_C2570[] DAT_74D4 = new FUN_C2570[] { };
    public FUN_C1CF8[] DAT_7500 = new FUN_C1CF8[] { };
    public byte[][] DAT_73E0 = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 11, 27, 15, 13, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 0, 0, 0, 35, 6, 0, 0, 22, 26, 21, 21, 23, 31, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 }
    };
    public TrgScriptableObject DAT_72F0; //0x72F0 (ST2)
    public uint[] DAT_7250 = new uint[100] { 0x0, 0x8000001d, 0x0, 0x8000000c, 0x0, 0xb, 0x80000016, 0x0, 0x5, 0x8000000e, 0x0, 0x8000001e, 0x0, 0x8000001a, 0x0, 0x8, 0x80000016, 0x0, 0x8, 0x80000020, 0x0, 0xb, 0x80000012, 0x0, 0x8, 0x80000019, 0x0, 0x9, 0x80000023, 0x0, 0x5, 0x8000001b, 0x0, 0x80000016, 0x0, 0x6, 0x8000000e, 0x0, 0x7, 0x8000001d, 0x90300, 0x102f, 0x732, 0x0, 0x0, 0x7ffe0000, 0xa0401, 0xfcde, 0xc6a, 0x0, 0x0, 0x7ffe0000, 0x2, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x3, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x4, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x5, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x6, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x7, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x8, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000, 0x9, 0x0, 0x0, 0x0, 0x0, 0x7ffe0000 };
    private UNK_7888[] PTR_DAT_7888; //0x7888 (ST2)
    private UNK_7918[] PTR_DAT_7918; //0x7918 (ST2)
    private short[] DAT_7AE4 = new short[] { 4, -4, 32, -32, 32, -32, 16, -16, 8, -8, 2, -2, 1, -1 };
    private short[] DAT_7B00 = new short[] { 4, -4, 16, -16, 16, -16, 8, -8, 4, -4, 1, -1, 1, -1 };
    public delegate void FUN_7C14(CriPlayer p); //0x7C14 (ST2)
    public delegate void FUN_7C30(CriPlayer p); //0x7C30 (ST2)
    public FUN_7C14[] PTR_FUN_7C14; //0x7C14 (ST2)
    public FUN_7C30[] PTR_FUN_7C30; //0x7C30 (ST2)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_7C14 = new FUN_7C14[1]
            {
                FUN_10C
            };
            PTR_FUN_7C30 = new FUN_7C30[1]
            {
                FUN_10C
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


    //FUN_04 (ST2)
    public override void Initialize()
    {
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        base.Initialize();
        PTR_FUN_B58BC = DAT_7470;
        PTR_FUN_B58C0 = DAT_74BC;
        PTR_FUN_C2570 = DAT_74D4;
        PTR_FUN_C1CF8 = DAT_7500;
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        SceneManager.instance.DAT_AC = DAT_73E0[uVar3];
        GameManager.instance.DAT_46 = 2;
        SceneManager.instance.DAT_B0 = DAT_7250;

        for (int i = 0; i < DAT_72F0.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
            puVar5 = DAT_72F0.TRIGGERS[i];
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

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 2);
    }

    //FUN_10C (ST2)
    private void FUN_10C(CriPlayer param1)
    {
        return;
    }

    //FUN_3AC (ST2)
    public void FUN_3AC(CriPlayer param1)
    {
        ushort uVar1;
        CriParticle oVar2;
        CriObject oVar3;

        if (param1.DAT_1DA == PTR_DAT_7888[param1.DAT_1D9].DAT_00)
        {
            do
            {
                oVar2 = SceneManager.instance.FUN_5FFA0();

                if (oVar2 != null)
                {
                    oVar2.tags = PTR_DAT_7888[param1.DAT_1D9].DAT_01;
                    oVar2.DAT_2F = PTR_DAT_7888[param1.DAT_1D9].DAT_02;
                    oVar3 = Utilities.FUN_601C8(param1.skeleton, PTR_DAT_7888[param1.DAT_1D9].DAT_03);
                    oVar2.DAT_4C = oVar3;
                    oVar2.screen = PTR_DAT_7888[param1.DAT_1D9].DAT_04;
                    uVar1 = PTR_DAT_7888[param1.DAT_1D9].DAT_0A;
                    oVar2.DAT_60 = uVar1;
                    oVar2.DAT_62 = uVar1;
                    oVar2.IDAT_6C = PTR_DAT_7888[param1.DAT_1D9].DAT_0C;
                    param1.DAT_1D9++;
                }
            } while (PTR_DAT_7888[param1.DAT_1D9].DAT_00 == param1.DAT_1DA);

            if (8 < param1.DAT_1D9)
                param1.DAT_1C0 &= 0xbfffffff;
        }

        param1.DAT_1DA++;
    }

    //FUN_55C (ST2)
    public void FUN_55C(CriPlayer param1)
    {
        ushort uVar1;
        CriParticle oVar2;
        CriObject oVar3;

        if (param1.DAT_60 == PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_00)
        {
            do
            {
                oVar2 = SceneManager.instance.FUN_5FFA0();

                if (oVar2 != null)
                {
                    oVar2.tags = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_01;
                    oVar2.DAT_2F = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_02;
                    oVar3 = Utilities.FUN_601C8(param1.skeleton, PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_03);
                    oVar2.DAT_4C = oVar3;
                    oVar2.screen = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_04;
                    uVar1 = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_0A;
                    oVar2.DAT_62 = uVar1;
                    oVar2.DAT_60 = uVar1;
                    oVar2.DAT_40 = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_0C;
                    oVar2.DAT_72 = PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_12;
                    param1.DAT_1E6++;
                }
            } while (PTR_DAT_7918[(byte)param1.DAT_1E6].DAT_00 == param1.DAT_60);

            if (20 < (byte)param1.DAT_1E6)
                param1.DAT_1C0 &= 0xfffeffff;
        }
    }

    public void FUN_850(CriPlayer param1)
    {
        CriCamera oVar1;
        short sVar2;

        oVar1 = SceneManager.instance.cCamera;
        sVar2 = (short)(param1.DAT_1D3 & 0x7f);
        oVar1.DAT_38 += (short)(DAT_7B00[param1.DAT_1D2] * sVar2);
        oVar1.DAT_3A += (short)(DAT_7AE4[param1.DAT_1D2] * sVar2);
        param1.DAT_1D2++;

        if (13 < param1.DAT_1D2)
        {
            param1.DAT_1D2 = 0;
            param1.DAT_1D3 = 0;
        }
    }

    //FUN_2438 (ST2)
    public static void FUN_2438(CriPlayer param1)
    {
        param1.FUN_2438();
    }
}
