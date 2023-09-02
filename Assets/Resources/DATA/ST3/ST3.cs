using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST3 : LevelManager
{
    public static new ST3 instance;

    public FUN_B58BC[] DAT_11B40 = new FUN_B58BC[6] { FUN_44EA8, FUN_45224, FUN_45350, FUN_45480, FUN_45758, FUN_45B08 };
    public FUN_B58C0[] DAT_11B98 = new FUN_B58C0[3] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0 };
    public FUN_C2570[] DAT_11BC0 = new FUN_C2570[3] { FUN_4A26C, FUN_7F6F8, FUN_7F750 };
    public FUN_C1CF8[] DAT_11BE0 = new FUN_C1CF8[1] { FUN_20A98 };
    public byte[][] DAT_11AB0 = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 10, 27, 15, 13, 0, 32, 25, 20, 18, 33, 30, 27, 24, 34, 31, 0, 25, 35, 0, 0, 0, 22, 0, 28, 26, 23, 0, 29, 27, 16, 0, 30, 29, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 8, 27, 0, 0, 0, 32, 25, 20, 20, 33, 30, 27, 24, 34, 31, 0, 25, 35, 0, 0, 0, 22, 0, 28, 26, 23, 0, 29, 27, 16, 0, 30, 29, 17, 0, 31, 31, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 8, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 6, 0, 0, 35, 0, 0, 0, 22, 0, 0, 0, 23, 0, 0, 0, 16, 26, 20, 19, 17, 31, 30, 29, 24, 0, 31, 31, 25, 0, 0, 0 }
    };
    public TrgScriptableObject DAT_118D0; //0x118D0 (ST3)
    public TrgScriptableObject DAT_119C0; //0x119C0 (ST3)
    public uint[] DAT_11674 = new uint[151] { 0x0, 0xa, 0x11, 0x22, 0x31, 0x36, 0x80000046, 0x0, 0x16, 0x3a, 0x80000060, 0x0, 0x8, 0x17, 0x36, 0x8000005b, 0x0, 0xa, 0x18, 0x26, 0x2e, 0x36, 0x80000044, 0x0, 0x16, 0x80000046, 0x0, 0xc, 0x10, 0x1d, 0x21, 0x32, 0x3b, 0x80000044, 0x0, 0x6, 0x9, 0x22, 0x2e, 0x33, 0x80000047, 0x0, 0x1f, 0x24, 0x39, 0x8000004e, 0x0, 0x15, 0x1b, 0x20, 0x29, 0x36, 0x80000060, 0x0, 0x8, 0x16, 0x36, 0x80000047, 0x0, 0xe, 0x2f, 0x33, 0x80000040, 0x0, 0xd, 0x24, 0x32, 0x38, 0x80000045, 0x0, 0x7, 0xc, 0x12, 0x21, 0x27, 0x30, 0x39, 0x80000041, 0x0, 0x7, 0xf, 0x30, 0x80000042, 0x0, 0x12, 0x1a, 0x25, 0x39, 0x80000052, 0x0, 0x8, 0xb, 0x12, 0x18, 0x24, 0x30, 0x80000048, 0x0, 0x6, 0x17, 0x2b, 0x80000040, 0x0, 0x6, 0x2a, 0x31, 0x80000040, 0x0, 0xf, 0x24, 0x36, 0x8000003e, 0x0, 0x13, 0x2b, 0x8000004c, 0x0, 0x26, 0x37, 0x80000046, 0x0, 0x12, 0x26, 0x35, 0x8000004e, 0x0, 0x20, 0x27, 0x3b, 0x8000004a, 0x0, 0x10, 0x30, 0x3c, 0x80000050, 0x0, 0x8, 0x18, 0x29, 0x35, 0x3b, 0x80000047, 0x0, 0x12, 0x34, 0x80000044, 0x0, 0x1b, 0x25, 0x34, 0x80000043 };

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

        SceneManager.instance.DAT_AC = DAT_11AB0[uVar3];
        SceneManager.instance.DAT_B0 = DAT_11674;
        GameManager.instance.DAT_46 = 3;
        bVar1 = InventoryManager.FUN_4A87C(0, 0x5d);

        if (!bVar1)
        {
            for (int i = 0; i < DAT_118D0.TRIGGERS.Length; i++)
            {
                puVar4 = SceneManager.instance.DAT_9EEC[i];
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
                puVar4 = SceneManager.instance.DAT_9EEC[i];
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

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 3);
        //...
    }
}
