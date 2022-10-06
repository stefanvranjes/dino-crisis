using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//0x800E8000
public class ST1 : LevelManager
{
    public FUN_B58C0[] DAT_7680 = new FUN_B58C0[3] { FUN_4CFDC, FUN_54EF8, FUN_2FAB0 }; //0x7680 (ST1)
    public byte[][] DAT_7594 = new byte[3][]
    {
        new byte[48] { 29, 7, 10, 11, 27, 15, 13, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 25, 21, 19, 33, 30, 28, 25, 34, 0, 0, 0, 35, 31, 0, 0, 22, 0, 30, 27, 23, 0, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 },
        new byte[48] { 29, 5, 8, 9, 27, 0, 0, 0, 32, 0, 0, 0, 33, 0, 0, 0, 34, 0, 0, 0, 35, 6, 0, 0, 22, 26, 21, 21, 23, 31, 0, 0, 16, 0, 31, 31, 17, 0, 0, 0, 24, 0, 0, 0, 25, 0, 0, 0 }
    }; //0x7594 (ST1)
    public TrgScriptableObject DAT_74A4; //0x74A4 (ST1)
    public uint[] DAT_7230 = new uint[157] { 0x0, 0x20, 0x2d, 0x39, 0x3f, 0x80000042, 0x0, 0x16, 0x1c, 0x21, 0x33, 0x80000050, 0x0, 0x15, 0x22, 0x38, 0x8000004a, 0x0, 0x8, 0x1e, 0x30, 0x8000004b, 0x0, 0x16, 0x28, 0x3c, 0x8000005a, 0x0, 0xc, 0x16, 0x24, 0x34, 0x3c, 0x40, 0x80000052, 0x0, 0x5, 0x14, 0x34, 0x39, 0x8000004a, 0x0, 0x17, 0x1f, 0x39, 0x80000057, 0x0, 0x1b, 0x2e, 0x3c, 0x8000004b, 0x0, 0x10, 0x28, 0x3f, 0x80000064, 0x0, 0x14, 0x21, 0x3c, 0x8000005b, 0x0, 0xd, 0x16, 0x23, 0x28, 0x80000042, 0x0, 0x1a, 0x22, 0x38, 0x80000057, 0x0, 0xf, 0x1c, 0x2b, 0x38, 0x80000045, 0x0, 0x5, 0x1d, 0x31, 0x80000042, 0x0, 0x6, 0x18, 0x22, 0x3d, 0x80000048, 0x0, 0x1d, 0x21, 0x32, 0x80000046, 0x0, 0x3, 0x9, 0x14, 0x22, 0x2a, 0x37, 0x3d, 0x80000053, 0x0, 0x13, 0x1e, 0x2e, 0x32, 0x80000047, 0x0, 0x18, 0x28, 0x3b, 0x8000004a, 0x0, 0x10, 0x1b, 0x27, 0x31, 0x80000043, 0x0, 0xa, 0x15, 0x2b, 0x80000042, 0x0, 0x22, 0x33, 0x41, 0x8000005c, 0x0, 0x12, 0x18, 0x28, 0x34, 0x3f, 0x8000004b, 0x0, 0x6, 0xb, 0x16, 0x1e, 0x3b, 0x8000004d, 0x0, 0x14, 0x26, 0x3b, 0x80000051, 0x0, 0x1e, 0x2b, 0x40, 0x8000004d, 0x0, 0xc, 0x80000018 };

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //FUN_F4 (ST1)
    private void FUN_F4()
    {
        bool bVar2;
        uint uVar3;
        CriTrigger puVar4;
        TriggerData puVar5;

        //...
        PTR_FUN_B58C0 = DAT_7680;
        //...
        uVar3 = 2;

        if (GameManager.instance.DAT_9AA2 < 2)
            uVar3 = GameManager.instance.DAT_9AA2;

        SceneManager.instance.DAT_AC = DAT_7594[uVar3];
        GameManager.instance.DAT_46 = true;
        SceneManager.instance.DAT_B0 = DAT_7230;

        for (int i = 0; i < DAT_74A4.TRIGGERS.Length; i++)
        {
            puVar4 = SceneManager.instance.DAT_9EEC[i];
            puVar5 = DAT_74A4.TRIGGERS[i];
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

        GameManager.instance.FUN_7669C(SceneManager.instance.DAT_9EEC, 1);
        bVar2 = InventoryManager.FUN_4A87C(0, 0x22);

        if (!bVar2)
        {
            bVar2 = InventoryManager.FUN_4A87C(0, 0x23);

            if (!bVar2)
                SceneManager.instance.DAT_9EEC[2].DAT_03 |= 2;
        }

        bVar2 = InventoryManager.FUN_4A87C(0, 0x1e);

        if (!bVar2)
            SceneManager.instance.DAT_9EEC[1].DAT_03 |= 2;
    }
}
