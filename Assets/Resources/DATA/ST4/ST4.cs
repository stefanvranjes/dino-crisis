using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST4 : LevelManager
{
    public static new ST4 instance;

    public FUN_B58BC[] DAT_1279C = new FUN_B58BC[20] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, 
                                                       FUN_45B08, null, FUN_46A1C, FUN_346C, null, null, 
                                                       FUN_45D38, FUN_45E70, null, null, null, FUN_3648, 
                                                       FUN_46814, FUN_3760, FUN_3828 };
    public FUN_B58C0[] DAT_127EC = new FUN_B58C0[] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0 };
    public FUN_C2570[] DAT_1280C = new FUN_C2570[] { FUN_4A26C, FUN_7F6F8, FUN_7F750 };
    public FUN_C1CF8[] DAT_1282C = new FUN_C1CF8[] { };
    public byte[][] DAT_1270C = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 12, 27, 15, 13, 13, 32, 25, 20, 20, 33, 30, 27, 24, 34, 31, 0, 27, 35, 0, 0, 0, 22, 0, 28, 28, 23, 0, 29, 29, 16, 0, 30, 30, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 10, 27, 0, 0, 0, 32, 25, 20, 20, 33, 30, 26, 24, 34, 31, 27, 27, 35, 0, 0, 0, 22, 0, 28, 28, 23, 0, 29, 29, 16, 0, 30, 30, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 10, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 6, 0, 0, 35, 0, 0, 0, 22, 0, 0, 0, 23, 0, 0, 0, 16, 0, 0, 0, 17, 16, 11, 11, 24, 31, 31, 31, 25, 0, 0, 0 }
    };
    public TrgScriptableObject DAT_1261C; //0x1261C (ST4)
    public uint[] DAT_12520 = new uint[63] { 0x0, 0x9, 0x80000016, 0x0, 0xc, 0x80000017, 0x0, 0x80000014, 0x0, 0x7, 0xd, 0x80000015, 0x0, 0xb, 0x80000016, 0x0, 0x9, 0x80000011, 0x0, 0x9, 0x80000013, 0x0, 0x4, 0x80000017, 0x0, 0xc, 0x80000014, 0x0, 0x80000023, 0x0, 0x80000010, 0x0, 0x80000013, 0x0, 0xc, 0x80000018, 0x0, 0x9, 0x80000015, 0x0, 0x80000015, 0x0, 0xe, 0x8000001d, 0x0, 0x5, 0xe, 0x8000001d, 0x0, 0xa, 0x80000013, 0x0, 0x80000013, 0x0, 0x80000010, 0x0, 0x7, 0x80000013, 0x0, 0x7, 0x80000014, 0x0, 0x8000000f };

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
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

        SceneManager.instance.DAT_AC = DAT_1270C[uVar3];
        SceneManager.instance.DAT_B0 = DAT_12520;
        GameManager.instance.DAT_46 = 4;

        for (int i = 0; i < DAT_1261C.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
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

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 4);
    }

    //FUN_346C (ST4)
    public static void FUN_346C(CriParticle param1)
    {
        return;
    }

    //FUN_3648 (ST4)
    public static void FUN_3648(CriParticle param1)
    {
        return;
    }

    //FUN_3760 (ST4)
    public static void FUN_3760(CriParticle param1)
    {
        return;
    }

    //FUN_3828 (ST4)
    public static void FUN_3828(CriParticle param1)
    {
        return;
    }
}
