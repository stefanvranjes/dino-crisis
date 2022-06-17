using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogManager : MonoBehaviour
{
    public ushort[] DAT_B12C0;
    public TriggerScriptableObject DAT_B1388;
    public byte DAT_B138C;
    public byte DAT_B138D;
    public byte DAT_B138F;
    public byte DAT_B1390;
    public byte DAT_B1391;
    public byte DAT_B1392;
    public byte DAT_B1393;
    public ushort[] PTR_B146C;
    public int DAT_B146C;
    public ushort[] PTR_B1470;
    public int DAT_B1470;
    public ushort[] PTR_B1474;
    public int DAT_B1474;
    public ushort DAT_B1478;
    public ushort DAT_B147A;
    public ushort DAT_B147C;
    public byte DAT_B147E;
    public byte DAT_B147F;
    public byte DAT_B1480;
    public byte DAT_B1481;
    public byte DAT_B1482;
    public byte DAT_B1483;
    public byte DAT_B1484;
    public byte DAT_B1485;
    public byte DAT_B1486;
    public byte DAT_B1487;
    public byte DAT_B1488;
    public byte DAT_B1489;
    public byte DAT_B148A;
    public byte DAT_B148B;
    public byte DAT_B148C;
    public static DialogManager instance;
    public static int[] DAT_98594;
    public static ushort[] DAT_98628;
    public static ushort[] DAT_9F0EC;

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

    public void FUN_1BAB4(byte param1, TriggerScriptableObject param2)
    {
        DAT_B1388 = param2;
        DAT_B138C = param1;
        InventoryManager.FUN_4A7E8(2, 0xe, true);
        DAT_B138D = 0;
        DAT_B138F = 0;
        DAT_B1390 = 0;
        DAT_B1391 = 0;
        DAT_B1392 = 0;
        DAT_B1393 = 0;
        InventoryManager.FUN_4A7E8(1, 0, true);
        InventoryManager.FUN_4A7E8(1, 1, true);
        InventoryManager.FUN_4A7E8(1, 2, true);
        InventoryManager.FUN_4A7E8(1, 3, true);
        InventoryManager.FUN_4A7E8(1, 6, true);
        InventoryManager.FUN_4A7E8(1, 7, true);
        InventoryManager.FUN_4A7E8(1, 0xa, true);
        InventoryManager.FUN_4A7E8(1, 0xb, true);
        InventoryManager.FUN_4A7E8(1, 0xc, true);
        InventoryManager.FUN_4A7E8(1, 0xd, true);
        InventoryManager.FUN_4A7E8(1, 0xe, true);
    }

    public void FUN_1BCA4(ushort[] param1, int param2)
    {
        ushort uVar1;
        byte bVar2;

        uVar1 = param1[param2];
        bVar2 = DAT_B138D;

        while (uVar1 != 0xa000)
        {
            DAT_B138D = (byte)(bVar2 + 1);
            uVar1 = param1[param2];
            param2++;
            DAT_B12C0[bVar2] = uVar1;
            uVar1 = param1[param2];
            bVar2 = DAT_B138D;
        }

        DAT_B138D = bVar2;
        DAT_B12C0[bVar2] = 0xa000;
    }

    public void FUN_1E2D8(ushort[] param1, int param2, byte param3, ushort param4)
    {
        byte bVar1;

        DAT_B147A = (ushort)GameManager.instance.DAT_40;
        DAT_B147E = 30;
        DAT_B1489 = 0;
        DAT_B148C = 0;
        DAT_B148B = 0;
        DAT_B1488 = 0;
        DAT_B1485 = 0;
        DAT_B1483 = 0;
        DAT_B1480 = 0;
        DAT_B147F = 0;
        DAT_B147C = 0;
        DAT_B148A = 40;
        PTR_B1474 = param1;
        DAT_B1474 = param2;
        DAT_B1478 = param4;
        bVar1 = (byte)(InventoryManager.FUN_4A87C(2, 0xc) ? 1 : 0);
        DAT_B1482 = (byte)(param3 | bVar1);
        DAT_B1481 = 1;
        InventoryManager.FUN_4A7E8(2, 4, false);
        InventoryManager.FUN_4A7E8(2, 5, false);
        InventoryManager.FUN_4A7E8(2, 6, false);
        InventoryManager.FUN_4A7E8(2, 7, false);
        InventoryManager.FUN_4A7E8(2, 0x18, false);

        if ((param3 & 2) == 0)
        {
            DAT_B148C = 25;
            DAT_B1486 = 2;
            DAT_B1487 = 12;
        }
        else
        {
            DAT_B148C = 40;
            DAT_B1486 = 1;
            DAT_B1487 = 2;
            DAT_B1474 += 2;
        }

        DAT_B1484 = 1;
        DAT_B1470 = DAT_B1474;
        PTR_B1470 = PTR_B1474;
        DAT_B146C = DAT_B1474;
        PTR_B146C = PTR_B1474;
        GameManager.instance.DAT_40 |= DAT_B1478;
        InventoryManager.FUN_4A7E8(2, 0, true);
    }
}
