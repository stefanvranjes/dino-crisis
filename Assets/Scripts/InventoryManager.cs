using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    private static uint[] DAT_C1500 = new uint[8];
    private static uint[] DAT_B7A60 = new uint[17]; //unsure
    private static uint[] DAT_B7A5C = new uint[1];
    private static uint[] DAT_C15C8 = new uint[2];
    private static uint[] DAT_C1560 = new uint[8];
    private static uint[] DAT_C1580 = new uint[8];
    private static uint[] DAT_B7AA4 = new uint[8]; //unsure
    private static uint[] DAT_C1520 = new uint[8];
    private static uint[] DAT_C1540 = new uint[8];
    private static uint[] DAT_C15A0 = new uint[2];
    private static uint[] DAT_C0C80 = new uint[8]; //unsure
    private static uint[] DAT_C15A8 = new uint[8];
    private static uint[] DAT_C15D0 = new uint[8]; //unsure
    private static uint[][] PTR_DAT_9CD18 = new uint[13][]
    {
        DAT_C1500, DAT_B7A60, DAT_B7A5C,
        DAT_C15C8, DAT_C1560, DAT_C1580,
        DAT_B7AA4, DAT_C1520, DAT_C1540,
        DAT_C15A0, DAT_C0C80, DAT_C15A8,
        DAT_C15D0
    };
    private static uint[] DAT_9CD1C = new uint[13]
    {
        0x100, 0x20, 0x20,
        0x40, 0x100, 0x100,
        0x100, 0x100, 0x100,
        0x40, 0x20, 0x100,
        0x80
    };

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
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
}
