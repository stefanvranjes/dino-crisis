using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ST2 : LevelManager
{
    public static new ST2 instance;

    public FUN_B58BC[] DAT_7470 = new FUN_B58BC[] { };
    public FUN_B58C0[] DAT_74BC = new FUN_B58C0[] { };
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
}
