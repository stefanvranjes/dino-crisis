using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public static uint[] DAT_C1500 = new uint[8];
    public static uint[] DAT_B7A60 = new uint[1]; //unsure
    public static uint[] DAT_B7A5C = new uint[1];
    public static uint[] DAT_C15C8 = new uint[2];
    public static uint[] DAT_C1560 = new uint[8];
    public static uint[] DAT_C1580 = new uint[8];
    public static uint[] DAT_B7AA4 = new uint[8]; //unsure
    public static uint[] DAT_C1520 = new uint[8];
    public static uint[] DAT_C1540 = new uint[8];
    public static uint[] DAT_C15A0 = new uint[2];
    public static uint[] DAT_C0C80 = new uint[8]; //unsure
    public static uint[] DAT_C15A8 = new uint[8];
    public static uint[] DAT_C15D0 = new uint[8]; //unsure
    public static uint[][] PTR_DAT_9CD18 = new uint[13][]
    {
        DAT_C1500, DAT_B7A60, DAT_B7A5C,
        DAT_C15C8, DAT_C1560, DAT_C1580,
        DAT_B7AA4, DAT_C1520, DAT_C1540,
        DAT_C15A0, DAT_C0C80, DAT_C15A8,
        DAT_C15D0
    };
    public static uint[] DAT_9CD1C = new uint[13]
    {
        0x100, 0x20, 0x20,
        0x40, 0x100, 0x100,
        0x100, 0x100, 0x100,
        0x40, 0x20, 0x100,
        0x80
    };
    public ushort DAT_C612E;
    public byte[] DAT_C6280;
    public byte DAT_C6290;
    public delegate void FUN_A60D0();
    public FUN_A60D0[] PTR_FUN_A60D0;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DAT_C6280 = new byte[16];
            PTR_FUN_A60D0 = new FUN_A60D0[3]
            {
                FUN_667BC,
                FUN_66994,
                FUN_66B94
            };
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void FUN_1BBCC()
    {
        FUN_4A7E8(2, 0xe, false);
        FUN_4A7E8(1, 0, false);
        FUN_4A7E8(1, 1, false);
        FUN_4A7E8(1, 2, false);
        FUN_4A7E8(1, 3, false);
        FUN_4A7E8(1, 6, false);
        FUN_4A7E8(1, 7, false);
        FUN_4A7E8(1, 10, false);
        FUN_4A7E8(1, 0xb, false);
        FUN_4A7E8(1, 0xc, false);
        FUN_4A7E8(1, 0xd, false);
        FUN_4A7E8(1, 0xe, false);
    }

    public static void FUN_4A7E8(int param1, uint param2, bool param3)
    {
        uint puVar1;

        puVar1 = param2 >> 5;

        if (!param3)
        {
            PTR_DAT_9CD18[param1][puVar1] &= ~(1U << (int)(param2 & 0x1f));
            return;
        }
        
        PTR_DAT_9CD18[param1][puVar1] |= 1U << (int)(param2 & 0x1f);

        if (param1 == 1 && param2 == 2)
        {
            InputManager.controllers[0].DAT_B58B8 = 0;
            GameManager.DAT_1f80000a = 0;
            GameManager.DAT_1f800008 = 0;
            InputManager.controllers[0].DAT_B5898 = 0;
        }
    }

    public static bool FUN_4A87C(int param1, uint param2)
    {
        return (PTR_DAT_9CD18[param1][param2 >> 5] & 1U << (int)(param2 & 0x1f)) != 0;
    }

    private void FUN_667BC()
    {
        return;
    }

    private void FUN_66994()
    {
        return;
    }

    private void FUN_66B94()
    {
        return;
    }

    public uint FUN_67C30()
    {
        ushort uVar1;
        int pbVar2;
        uint uVar3;
        uint uVar4;

        uVar4 = 0;
        uVar3 = 0;
        pbVar2 = 0;

        do
        {
            if ((LevelManager.instance.DAT_B5898 >> (int)(uVar3 & 31) & 1) == 0)
                DAT_C6280[pbVar2] = 0;
            else
                DAT_C6280[pbVar2]++;

            uVar1 = LevelManager.instance.DAT_B58B8;

            if ((uint)DAT_C6290 <= DAT_C6280[pbVar2])
            {
                DAT_C6280[pbVar2] = (byte)(DAT_C6290 >> 1);
                uVar1 = LevelManager.instance.DAT_B5898;
            }

            uVar4 |= uVar1 & 1U << (int)(uVar3 & 31);
            uVar3++;
            pbVar2++;
        } while (uVar3 < 16);

        return uVar4;
    }
}
