using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum _SAVE_STATE 
{
    STATE_00, 
    STATE_01, 
    STATE_02, 
    STATE_03, 
    STATE_04, 
    STATE_05, 
    STATE_06, 
    STATE_07, 
    STATE_08, 
    STATE_09
}

public struct SaveSlot
{
    public string slotName; //0x00
    public uint DAT_18; //0x18
}

//0x800C25C8
public class SaveManager : MonoBehaviour 
{
    public static SaveManager instance;
    private static BufferedBinaryReader writer; //0x8015D000
    public byte currentSlot; //0x08
    public byte DAT_0A; //0x0A
    public sbyte DAT_0C; //0x0C
    public byte DAT_10; //0x10
    public _SAVE_STATE state; //0x11
    public bool DAT_14; //0x14
    public bool DAT_15; //0x15
    public SaveSlot[] saveSlots; //0x20
    public SaveSlot[] saveSlots2; //0x280

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
        saveSlots = new SaveSlot[16];
        saveSlots2 = new SaveSlot[16];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool FUN_23D0C(SaveSlot[] param1, uint param2)
    {
        uint uVar1;

        param2 <<= 13;
        uVar1 = 0;

        do
        {
            param2 += param1[uVar1].DAT_18;
            uVar1++;
        } while (uVar1 < 15);

        return 15 < param2 + 0x1fff >> 13;
    }

    private void FUN_25748()
    {
        sbyte sVar1;
        bool bVar5;
        string acStack64;

        acStack64 = "BASLUS-00922-DINO" + currentSlot;

        switch (state)
        {
            case _SAVE_STATE.STATE_00:
                if (saveSlots[0].slotName == acStack64)
                {
                    bVar5 = FUN_23D0C(saveSlots, 1);

                    if (bVar5)
                    {
                        DAT_10 = 5;
                        state = _SAVE_STATE.STATE_00;
                        DAT_0A = 3;
                        return;
                    }

                    state = _SAVE_STATE.STATE_02;
                    DAT_14 = true;
                }
                else
                {
                    DAT_15 = true;
                    DAT_14 = false;
                    state++;
                }

                break;
            case _SAVE_STATE.STATE_01:
                //...
                state++;
                break;
            case _SAVE_STATE.STATE_02:
                DAT_0C = 5;
                state++;
                goto case _SAVE_STATE.STATE_03;
            case _SAVE_STATE.STATE_03:
                sVar1 = DAT_0C;
                DAT_0C = (sbyte)(sVar1 - 1);

                if ((sbyte)(sVar1 - 1) == -1)
                {
                    DAT_10 = 5;
                    state = _SAVE_STATE.STATE_00;
                    DAT_0A = 1;
                }
                else
                {
                    FUN_23D40(writer);
                    //...
                }

                break;
        }
    }

    private void FUN_23D40(BufferedBinaryReader param1)
    {
        byte[] buffer = new byte[0x840];
        param1 = new BufferedBinaryReader(buffer);
        param1.Write(new byte[8]); //padding
        param1.Write(GameManager.instance.DAT_9AA0);
        param1.Write(GameManager.instance.DAT_9AA2);
        param1.Write((byte)0); //padding
        param1.Write(GameManager.instance.DAT_9AA4);
        param1.Write((byte)0); //padding
        param1.Write(GameManager.instance.DAT_9AA9);
        param1.Write(GameManager.instance.DAT_9AAA);
        param1.Write(GameManager.instance.DAT_9AAB);
        param1.Write(new byte[8]); //padding
        param1.Write(GameManager.instance.DAT_9AB4);
        param1.Write(new byte[0x20]); //padding
        param1.Write(GameManager.instance.DAT_9ADC);
        param1.Write(GameManager.instance.DAT_9ADE);
        param1.Write(GameManager.instance.DAT_9ADF);
        param1.Write(InventoryManager.DAT_C1500);
        param1.Write(InventoryManager.DAT_C1520);
        param1.Write(InventoryManager.DAT_C1540);
        param1.Write(InventoryManager.DAT_C1560);
        param1.Write(InventoryManager.DAT_C1580);
        param1.Write(InventoryManager.DAT_C15A0);
        param1.Write(InventoryManager.DAT_C15A8);
        param1.Write(InventoryManager.DAT_C15C8);
        param1.Write(InventoryManager.DAT_C15D0);
        param1.Write(new byte[0x2dc]); //padding
        param1.Write(GameManager.instance.DAT_9EAC);
        param1.Write(new byte[0x3c - GameManager.instance.DAT_9EAC.Length]); //padding
        param1.Write(GameManager.instance.DAT_9EE8);
        param1.Write(GameManager.instance.DAT_9EE9);
        param1.Write(GameManager.instance.DAT_9EEA);
        param1.Write(GameManager.instance.DAT_9EEB);
        param1.Write(new byte[0xf0]); //padding
        param1.Write(GameManager.instance.DAT_9FDC.x);
        param1.Write(GameManager.instance.DAT_9FDC.y);
        param1.Write(new byte[0xb0]); //padding
        param1.Write(GameManager.instance.DAT_A090);
        param1.Write(GameManager.instance.DAT_A0E0);
        param1.Write(GameManager.instance.DAT_A0E2);
        param1.Write(new byte[4]); //padding
        param1.Write(GameManager.instance.DAT_A0E8);
        param1.Write(GameManager.instance.DAT_A0EA);
        param1.Write(GameManager.instance.DAT_A0EC);
        param1.Write(GameManager.instance.DAT_A0EE);
        param1.Write(new byte[2]); //padding
        param1.Write(GameManager.instance.DAT_A0F2);
        param1.Write(GameManager.instance.DAT_A0F4);
        param1.Write(GameManager.instance.DAT_A0F8);
        param1.Write(GameManager.instance.DAT_A100);
        param1.Write(new byte[0x1cb]); //padding
        param1.Write(GameManager.instance.DAT_A2CC);
        param1.Write(GameManager.instance.DAT_A2CD);
        param1.Write(GameManager.instance.DAT_A2CE);
        param1.Write(GameManager.instance.DAT_A2CF);
        param1.Write(GameManager.instance.DAT_A2D0);
        param1.Write(GameManager.instance.DAT_A2D1);
        param1.Write(GameManager.instance.DAT_A2D2);
        param1.Write(GameManager.instance.DAT_A2D3);
        param1.Write(GameManager.instance.DAT_A2D4);
        param1.Write(new byte[3]); //padding
    }
}
