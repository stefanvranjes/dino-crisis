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
    public byte currentSlot; //0x08
    public byte DAT_0A; //0x0A
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
        }
    }
}
