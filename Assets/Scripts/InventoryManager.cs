using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class InventoryRect
{
    public bool DAT_00;
    public sbyte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
    public short DAT_04;
    public short DAT_06;
    public short DAT_08;
    public short DAT_0A;
    public short DAT_0C;
    public short DAT_0E;
    public short DAT_10;
    public short DAT_12;
    public short DAT_14;
    public short DAT_16;
    public short DAT_18;
    public short DAT_1A;
}

[System.Serializable]
public class InventoryText
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
}

[System.Serializable]
public class InventoryWindow
{
    public byte[] ARRY_00;
    public sbyte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public byte DAT_03;
    public byte DAT_04;
    public byte DAT_05;
    public sbyte BDAT_06;
    public byte[] DAT_06;
    public sbyte DAT_07;
    public byte DAT_14;
    public sbyte DAT_15;
    public byte DAT_16;
    public byte DAT_17;
    public byte[] DAT_18;
    public byte DAT_1C;
    public byte DAT_1D;
    public sbyte DAT_1E;
    public sbyte DAT_1F;
    public InventoryText DAT_20;
    public byte DAT_24;
    public byte DAT_25;
    public byte DAT_26;
    public byte DAT_27;
    public byte[] DAT_28;
    public sbyte DAT_2C;
    public sbyte DAT_2D;
    public byte DAT_34;
    public byte DAT_35;
    public byte DAT_36;
    public byte DAT_37;
    public byte BDAT_38;
    public byte DAT_39;
    public InventoryRect[] rect; //0x00
    public InventoryRect[] rect2; //0x30
    public InventoryText[] DAT_38;
    public byte DAT_4C;
    public sbyte DAT_4D;
    public byte DAT_4E;
    public byte DAT_4F;
    public byte DAT_50;
    public byte[] DAT_51;
    public byte[] DAT_54;
    public byte DAT_56;
    public sbyte DAT_57;
    public byte DAT_58;
    public byte DAT_59;
    public byte DAT_5A;
    public byte DAT_5B;
    public byte DAT_5C;
    public byte DAT_5D;
    public byte[] DAT_5E;
    public byte DAT_63;
    public byte DAT_64;
    public sbyte DAT_65;
    public sbyte DAT_66;
    public byte DAT_67;
    public byte DAT_68;
    public byte DAT_69;

    public InventoryWindow()
    {
        rect = new InventoryRect[3];
        rect2 = new InventoryRect[2];

        for (int i = 0; i < rect.Length; i++)
            rect[i] = new InventoryRect();

        for (int i = 0; i < rect2.Length; i++)
            rect2[i] = new InventoryRect();
    }
}

[System.Serializable]
public struct UNK_CLASS
{
    public byte DAT_08;
}

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
    public ushort DAT_C60F0;
    public ushort DAT_C60F2;
    public byte DAT_C6100;
    public byte DAT_C6101;
    public byte DAT_C6102;
    public byte DAT_C6103;
    public byte DAT_C6104;
    public byte DAT_C6105;
    public byte DAT_C6106;
    public bool DAT_C6107;
    public byte DAT_C6108;
    public byte DAT_C6109;
    public ushort DAT_C610A;
    public ushort DAT_C610C;
    public ushort DAT_C610E;
    public ushort DAT_C6110;
    public ushort DAT_C612E;
    public InventoryWindow[] DAT_C6130;
    public uint DAT_C61F8;
    public byte DAT_C61FC;
    public byte DAT_C61FD;
    public byte DAT_C61FE;
    public byte DAT_C61FF;
    public byte DAT_C6200;
    public byte DAT_C6201;
    public byte DAT_C6202;
    public ushort[] DAT_C6210;
    public byte[] DAT_C6280;
    public byte DAT_C6290;
    public int DAT_C6294;
    public ushort[] DAT_C6298;
    public byte[][] DAT_C62B0;
    public delegate void FUN_A60D0();
    public delegate void FUN_A60DC();
    public byte[] DAT_A6104 = new byte[4] { 1, 4, 4, 2 };
    public delegate void FUN_A6108(InventoryWindow[] w, int i);
    public delegate void FUN_A6114(InventoryWindow[] w, int i);
    public delegate void FUN_A611C(InventoryWindow[] w, int i);
    public delegate int FUN_A6130(InventoryWindow[] w, int i);
    public delegate void FUN_A6138(InventoryWindow[] w, int i);
    public delegate void FUN_A614C(InventoryWindow[] w, int i);
    public delegate void FUN_A6158(InventoryWindow[] w, int i);
    public delegate void FUN_A6160(InventoryWindow[] w, int i);
    public delegate bool FUN_A6174(ushort[] a, int i);
    public delegate void FUN_A617C(InventoryWindow[] w, int i);
    public delegate void FUN_A842C(InventoryWindow[] w, int i);
    public delegate void FUN_A88D0(InventoryWindow[] w, int i);
    public delegate void FUN_A88D8(InventoryWindow[] w, int i);
    public delegate void FUN_A88E0(InventoryWindow[] w, int i);
    public delegate void FUN_A88F0(InventoryWindow[] w, int i);
    public delegate void FUN_A8900(InventoryWindow[] w, int i);
    public FUN_A60D0[] PTR_FUN_A60D0;
    public FUN_A60DC[] PTR_FUN_A60DC;
    public FUN_A6108[] PTR_FUN_A6108;
    public FUN_A6114[] PTR_FUN_A6114;
    public FUN_A611C[] PTR_FUN_A611C;
    public FUN_A6130[] PTR_FUN_A6130;
    public FUN_A6138[] PTR_FUN_A6138;
    public FUN_A614C[] PTR_FUN_A614C;
    public FUN_A6158[] PTR_FUN_A6158;
    public FUN_A6160[] PTR_FUN_A6160;
    public FUN_A6174[] PTR_FUN_A6174;
    public FUN_A617C[] PTR_FUN_A617C;
    public byte[] DAT_A8408 = new byte[8] { 22, 7, 15, 8, 4, 17, 23, 0 };
    public UNK_CLASS[][] PTR_DAT_A83EC = new UNK_CLASS[7][];
    public FUN_A842C[] PTR_FUN_A842C;
    public byte[] DAT_A886C = new byte[8] { 47, 8, 55, 5, 60, 4, 0, 0 };
    public byte[][] PTR_DAT_A88B8 = new byte[3][]
    {
        new byte[32] { 1, 19, 0, 0, 2, 5, 1, 0, 3, 6, 2, 0, 5, 2, 3, 0, 5, 12, 4, 0, 6, 2, 5, 0, 6, 8, 6, 0, 6, 16, 7, 0 },
        new byte[20] { 1, 5, 8, 0, 3, 1, 9, 0, 5, 2, 10, 0, 5, 12, 11, 0, 6, 8, 12, 0 },
        new byte[16] { 1, 4, 13, 0, 6, 2, 14, 0, 6, 13, 15, 0, 6, 18, 16, 0 }
    };
    public FUN_A88D0[] PTR_FUN_A88D0;
    public FUN_A88D8[] PTR_FUN_A88D8;
    public FUN_A88E0[] PTR_FUN_A88E0;
    public FUN_A88F0[] PTR_FUN_A88F0;
    public FUN_A8900[] PTR_FUN_A8900;
    public RectTransform inventoryRect;
    public Button itemButton;
    public Button equipButton;
    public Button mapButton;
    public Button mixButton;
    public Button exitButton;
    public Text descText;
    public ScrollRect itemsRect;
    public ScrollRect suppliesRect;
    public ScrollRect weaponListRect;
    public ScrollRect ammoListRect;
    public ScrollRect equippedWeaponRect;
    public ScrollRect equippedAmmoRect;
    public RectTransform actionsRect;
    public RectTransform previewRect;
    public List<Sprite> sprites;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            PTR_FUN_A60D0 = new FUN_A60D0[3]
            {
                FUN_667BC,
                FUN_66994,
                FUN_66B94
            };
            PTR_FUN_A60DC = new FUN_A60DC[6]
            {
                FUN_6B08C,
                FUN_68598,
                FUN_6CF38,
                FUN_7007C,
                FUN_7007C,
                FUN_6E898
            };
            PTR_FUN_A6108 = new FUN_A6108[3]
            {
                FUN_68638,
                FUN_6873C,
                FUN_68778
            };
            PTR_FUN_A6114 = new FUN_A6114[2]
            {
                FUN_69034,
                FUN_6A1D4
            };
            PTR_FUN_A611C = new FUN_A611C[5]
            {
                FUN_69070,
                FUN_691C8,
                FUN_693A0,
                FUN_69618,
                FUN_696F8
            };
            PTR_FUN_A6130 = new FUN_A6130[2]
            {
                FUN_68D50,
                FUN_68D84
            };
            PTR_FUN_A6138 = new FUN_A6138[5]
            {
                FUN_6A210,
                FUN_6A3BC,
                FUN_6A594,
                FUN_6A784,
                FUN_6A864
            };
            PTR_FUN_A614C = new FUN_A614C[3]
            {
                FUN_6B14C,
                FUN_6B2F0,
                FUN_6B32C
            };
            PTR_FUN_A6158 = new FUN_A6158[2]
            {
                FUN_6B46C,
                FUN_6C1A8
            };
            PTR_FUN_A6160 = new FUN_A6160[5]
            {
                FUN_6B4A8,
                FUN_6B4A8,
                FUN_6B6CC,
                FUN_6B9E0,
                FUN_6BA84
            };
            PTR_FUN_A6174 = new FUN_A6174[2]
            {
                FUN_6BC74,
                FUN_6BC7C
            };
            PTR_FUN_A617C = new FUN_A617C[5]
            {
                FUN_6C1E4,
                FUN_6C1E4,
                FUN_6C3EC,
                FUN_6C75C,
                FUN_6C800
            };
            PTR_FUN_A842C = new FUN_A842C[2]
            {
                FUN_6D0C4,
                FUN_6D224
            };
            PTR_FUN_A88D0 = new FUN_A88D0[2]
            {
                FUN_6E8F4,
                FUN_6EA48
            };
            PTR_FUN_A88D8 = new FUN_A88D8[2]
            {
                FUN_6EA84,
                FUN_6F12C
            };
            PTR_FUN_A88E0 = new FUN_A88E0[4]
            {
                FUN_6EB8C,
                FUN_6ECB8,
                FUN_6ED34,
                FUN_6F0E8
            };
            PTR_FUN_A88F0 = new FUN_A88F0[4]
            {
                FUN_70124,
                FUN_701CC,
                FUN_70BD0,
                FUN_70C04
            };
            PTR_FUN_A8900 = new FUN_A8900[5]
            {
                FUN_70208,
                FUN_70410,
                FUN_706A0,
                FUN_709B4,
                FUN_70A5C
            };
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        DAT_C6130 = new InventoryWindow[1];
        DAT_C6210 = new ushort[0x70];
        DAT_C6280 = new byte[0x10];

        for (int i = 0; i < DAT_C6130.Length; i++)
            DAT_C6130[i] = new InventoryWindow();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetValues()
    {
        DAT_C6100 = 0;
        DAT_C6101 = 0;
        DAT_C6102 = 0;
        DAT_C6103 = 0;
        DAT_C6104 = 0;
        DAT_C6105 = 0;
        DAT_C6106 = 0;
        DAT_C6107 = false;
        DAT_C6108 = 0;
        DAT_C6109 = 0;
        DAT_C610A = 0;
        DAT_C610C = 0;
        DAT_C610E = 0;
        DAT_C6110 = 0;
        DAT_C612E = 0;
        DAT_C6130[0] = new InventoryWindow();
        DAT_C61F8 = 0;
        DAT_C61FC = 0;
        DAT_C61FD = 0;
        DAT_C61FE = 0;
        DAT_C61FF = 0;
        DAT_C6200 = 0;
        DAT_C6201 = 0;
        DAT_C6202 = 0;
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
        byte bVar1;
        CriPlayer oVar2;
        byte bVar3;
        byte[] local_18 = new byte[3];

        ResetValues();
        inventoryRect.gameObject.SetActive(true);
        SaveManager.instance.saveButton.gameObject.SetActive(false);
        GameManager.instance.DAT_2A++;
        FUN_674E8(0xe, 0xe);
        FUN_67BF8(10);
        DAT_C61F8 = DAT_B7A60[0];
        FUN_4A7E8(1, 2, false);
        //FUN_1CC7C
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar1 = oVar2.DAT_240;
        DAT_C6108 = bVar1;
        DAT_C6109 = bVar1;
        DAT_C610C = (ushort)((uint)oVar2.DAT_244[0] >> 8);
        DAT_C610E = (ushort)((uint)oVar2.DAT_244[1] >> 8);
        DAT_C6110 = (ushort)((uint)oVar2.DAT_244[2] >> 8);

        if (GameManager.instance.DAT_39 == 4) goto LAB_66978;

        DAT_C6100 = GameManager.instance.DAT_39;
        bVar1 = (byte)GameManager.instance.DAT_2E;
        DAT_C61FE = 60;
        DAT_C6101 = 1;
        DAT_C61FC = bVar1;
        bVar3 = GameManager.instance.DAT_39;

        if (bVar3 == 1)
        {
            DAT_C6103 = 0;
            DAT_C6104 = 3;
            bVar3 = (byte)(DAT_C61FF | 1);
        }
        else
        {
            if (bVar3 < 2)
            {
                if (bVar3 == 0)
                {
                    DAT_C61FF |= 1;

                    if ((byte)GameManager.instance.DAT_2E - 16U < 20)
                    {
                        local_18[1] = (byte)(GameManager.instance.DAT_2E >> 8);
                        local_18[0] = (byte)GameManager.instance.DAT_2E;
                        local_18[2] = FUN_6FCA8(local_18[0]);
                        DialogManager.instance.FUN_68188(local_18);
                    }

                    DAT_C6104 = 3;
                }

                goto LAB_66978;
            }

            if (bVar3 != 2) goto LAB_66978;

            bVar3 = (byte)(DAT_C61FF | 2);
        }

        DAT_C61FF = bVar3;
        LAB_66978:
        FUN_6AC20();
    }

    private void FUN_66994()
    {
        ushort uVar1;

        DAT_C6294 = 3;

        if (DAT_C6101 == 0)
        {
            itemsRect.gameObject.SetActive(false);
            suppliesRect.gameObject.SetActive(false);
            weaponListRect.gameObject.SetActive(false);
            equippedWeaponRect.gameObject.SetActive(false);
            equippedAmmoRect.gameObject.SetActive(false);
            uVar1 = DAT_C612E;

            if ((uVar1 & 0x1000) == 0)
            {
                if ((uVar1 & 0x4000) == 0)
                {
                    if ((uVar1 & 0xa0) == 0)
                    {
                        if ((uVar1 & 0x40) != 0)
                        {
                            GameManager.instance.FUN_5C94C(null, 1);
                            GameManager.instance.DAT_2A = 2;
                        }
                    }
                    else
                    {
                        if (DAT_C6100 != 2) //tmp
                        {
                            GameManager.instance.FUN_5C94C(null, 2);
                            DAT_C6130[0] = new InventoryWindow();
                            DAT_C6107 = false;
                            DAT_C6101++;

                            if (DAT_C6100 == 4)
                                GameManager.instance.DAT_2A = 2;
                        }
                        else
                            GameManager.instance.FUN_5C94C(null, 1);
                    }
                }
                else
                {
                    if (DAT_C6100 < 4U)
                    {
                        DAT_C6100++;
                        GameManager.instance.FUN_5C94C(null, 0);
                    }
                }
            }
            else
            {
                if (DAT_C6100 != 0)
                {
                    DAT_C6100--;
                    GameManager.instance.FUN_5C94C(null, 0);
                }
            }

            DAT_C610A = (ushort)(DAT_C6100 + 0x10a);

            if (DAT_C6100 == 2)
                DAT_C610A = 0x10f;

            switch (DAT_C6100)
            {
                case 0:
                    itemButton.Select();
                    break;
                case 1:
                    equipButton.Select();
                    break;
                case 2:
                    mapButton.Select();
                    break;
                case 3:
                    mixButton.Select();
                    break;
                case 4:
                    exitButton.Select();
                    break;
            }

            FUN_67AD8();
        }
        else
        {
            if (DAT_C6101 != 1) goto LAB_66B58;
            else
            {
                PTR_FUN_A60DC[DAT_C6100]();

                if (1U < DAT_C6100) goto LAB_66B58;
            }
        }

        FUN_67F08();
        
        LAB_66B58:
        if ((DAT_C612E & 0x10) != 0)
        {
            GameManager.instance.DAT_2A = 2;
            GameManager.instance.FUN_5C94C(null, 1);
        }
    }

    private void FUN_66B94()
    {
        CriPlayer oVar2;

        //FUN_1CC7C
        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];

        if (DAT_C6109 != DAT_C6108)
            oVar2.DAT_240 = DAT_C6108;

        oVar2.FUN_4FE90(DAT_C6108);
        oVar2.DAT_3C = 1;
        oVar2.DAT_3D = 0;
        oVar2.DAT_3E = 0;
        oVar2.DAT_3F = 0;
        oVar2.FUN_53984(0, 1, 0);
        FUN_6AC20();
        FUN_4A7E8(2, 0xf, false);
        DAT_B7A60[0] = DAT_C61F8;
        GameManager.instance.DAT_28 = 3;
        GameManager.instance.DAT_2E = 0;
        GameManager.instance.DAT_2C = 0;
        GameManager.instance.DAT_2A = 0;
        FUN_4A7E8(2, 8, false);
        inventoryRect.gameObject.SetActive(false);
        SaveManager.instance.saveButton.gameObject.SetActive(true);
        ResetValues();
    }

    private void FUN_66C68(int param1, short param2)
    {
        Vector2 local_10;

        DAT_C6294 = 1;

        if (param1 == 1)
        {
            actionsRect.GetChild(0).gameObject.SetActive(true);
            actionsRect.GetChild(1).gameObject.SetActive(true);
            actionsRect.GetChild(2).gameObject.SetActive(false);
            FUN_67554(actionsRect.GetChild(0).GetComponentInChildren<Text>(), 383, new Color32(0x80, 0x80, 0x80, 0xff));
            FUN_67554(actionsRect.GetChild(1).GetComponentInChildren<Text>(), 384, new Color32(0x80, 0x80, 0x80, 0xff));
            actionsRect.GetComponentsInChildren<Button>()[param2].Select();
            local_10 = new Vector2(0xc6, 0xb6);
        }
        else
        {
            if (param1 == 0)
            {
                actionsRect.GetChild(0).gameObject.SetActive(true);
                actionsRect.GetChild(1).gameObject.SetActive(true);
                actionsRect.GetChild(2).gameObject.SetActive(true);
                FUN_67554(actionsRect.GetChild(0).GetComponentInChildren<Text>(), 383, new Color32(0x80, 0x80, 0x80, 0xff));
                FUN_67554(actionsRect.GetChild(1).GetComponentInChildren<Text>(), 384, new Color32(0x80, 0x80, 0x80, 0xff));
                FUN_67554(actionsRect.GetChild(2).GetComponentInChildren<Text>(), 385, new Color32(0x80, 0x80, 0x80, 0xff));
                actionsRect.GetComponentsInChildren<Button>()[param2].Select();
                local_10 = new Vector2(0xc6, 0xb6);
            }
            else
            {
                if (param1 == 2)
                {
                    actionsRect.GetChild(0).gameObject.SetActive(true);
                    actionsRect.GetChild(1).gameObject.SetActive(true);
                    actionsRect.GetChild(2).gameObject.SetActive(false);
                    FUN_67554(actionsRect.GetChild(0).GetComponentInChildren<Text>(), 386, new Color32(0x80, 0x80, 0x80, 0xff));
                    FUN_67554(actionsRect.GetChild(1).GetComponentInChildren<Text>(), 384, new Color32(0x80, 0x80, 0x80, 0xff));
                    actionsRect.GetComponentsInChildren<Button>()[param2].Select();
                    local_10 = new Vector2(0xc6, 0xb6);
                }
                else
                {
                    if (param1 != 3)
                    {
                        DAT_C6294 = 1;
                        return;
                    }

                    actionsRect.GetChild(0).gameObject.SetActive(true);
                    actionsRect.GetChild(1).gameObject.SetActive(true);
                    actionsRect.GetChild(2).gameObject.SetActive(true);
                    FUN_67554(actionsRect.GetChild(0).GetComponentInChildren<Text>(), 387, new Color32(0x80, 0x80, 0x80, 0xff));
                    FUN_67554(actionsRect.GetChild(1).GetComponentInChildren<Text>(), 384, new Color32(0x80, 0x80, 0x80, 0xff));
                    FUN_67554(actionsRect.GetChild(2).GetComponentInChildren<Text>(), 385, new Color32(0x80, 0x80, 0x80, 0xff));
                    actionsRect.GetComponentsInChildren<Button>()[param2].Select();
                    local_10 = new Vector2(0xeb, 0x9d);
                }
            }
        }

        FUN_6ACDC(actionsRect, local_10);
    }

    private int FUN_67404(byte[] param1, int param2)
    {
        byte bVar1;
        ushort uVar2;
        int iVar3;
        int puVar4;

        bVar1 = param1[param2];
        puVar4 = 0;

        do
        {
            if (bVar1 == 0)
            {
                DAT_C6210[puVar4] = 0xa000;
                return 0;
            }

            if (bVar1 == 0x20)
                DAT_C6210[puVar4] = 0;
            else
            {
                if (bVar1 == 0x3f)
                    uVar2 = 0x82;
                else
                {
                    if (bVar1 == 0x3a)
                        uVar2 = 0x88;
                    else
                    {
                        if (bVar1 == 0x2e)
                            uVar2 = 0x9a;
                        else
                        {
                            if (bVar1 == 0x2f)
                                uVar2 = 0x96;
                            else
                            {
                                if (bVar1 != 0xa)
                                {
                                    if (bVar1 < 0x3aU)
                                        iVar3 = param1[param2] + 5;
                                    else
                                        iVar3 = param1[param2] - 0x40;

                                    DAT_C6210[puVar4] = (ushort)(iVar3 << 1);
                                    goto LAB_674B8;
                                }

                                uVar2 = 0x4000;
                            }
                        }
                    }
                }

                DAT_C6210[puVar4] = uVar2;
            }

            LAB_674B8:
            puVar4++;
            param2++;
            bVar1 = param1[param2];
        } while (true);
    }

    public uint FUN_674E8(ushort param1, ushort param2)
    {
        uint uVar1;

        uVar1 = (uint)DAT_C60F0 << 0x10 | DAT_C60F2;
        DAT_C60F0 = param1;
        DAT_C60F2 = param2;
        return uVar1;
    }

    private void FUN_6750C(ushort[] param1, int param2, Text param3, Color32 param4)
    {
        FUN_67CD4(param1, param2, param3, param4);
    }

    private void FUN_67554(Text param1, int param2, Color32 param3)
    {
        int iVar1;

        iVar1 = DialogManager.instance.FUN_6752C(param2);
        FUN_6750C(DialogManager.DAT_9F0EC, iVar1, param1, param3);
    }

    private void FUN_67AD8()
    {
        if (DAT_C610A != 0)
            FUN_67554(descText, DAT_C610A, new Color32(0, 0, 0, 0xff));
    }

    public byte FUN_67BF8(byte param1)
    {
        byte bVar1;
        int puVar2;
        uint uVar3;
        uint uVar4;

        bVar1 = DAT_C6290;
        puVar2 = 0;
        uVar3 = 0;
        DAT_C6290 = param1;

        do
        {
            DAT_C6280[puVar2] = 0;
            uVar4 = uVar3 + 1;
            puVar2 = (int)uVar3 + 1;
            uVar3 = uVar4;
        } while (uVar4 < 16);

        return bVar1;
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
            if ((InputManager.controllers[0].DAT_B5898 >> (int)(uVar3 & 31) & 1) == 0)
                DAT_C6280[pbVar2] = 0;
            else
                DAT_C6280[pbVar2]++;

            uVar1 = InputManager.controllers[0].DAT_B58B8;

            if ((uint)DAT_C6290 <= DAT_C6280[pbVar2])
            {
                DAT_C6280[pbVar2] = (byte)(DAT_C6290 >> 1);
                uVar1 = InputManager.controllers[0].DAT_B5898;
            }

            uVar4 |= uVar1 & 1U << (int)(uVar3 & 31);
            uVar3++;
            pbVar2++;
        } while (uVar3 < 16);

        return uVar4;
    }

    private void FUN_67CD4(ushort[] param1, int param2, Text param3, Color32 param4)
    {
        ushort uVar1;
        uint uVar6;
        List<char> chars = new List<char>();

        while (param1[param2] != 0xa000)
        {
            uVar1 = param1[param2++];
            uVar6 = uVar1 & 0x3ffU;
            chars.Add(Utilities.characters[(ushort)uVar6]);
        }

        param3.text = new string(chars.ToArray());
        param3.color = param4;
    }

    private void FUN_67F08()
    {
        DAT_C6294 = 3;
        itemButton.gameObject.SetActive(true);
        equipButton.gameObject.SetActive(true);
        mapButton.gameObject.SetActive(true);
        mixButton.gameObject.SetActive(true);
        exitButton.gameObject.SetActive(true);
    }

    private void FUN_68598()
    {
        equippedWeaponRect.gameObject.SetActive(true);
        equippedAmmoRect.gameObject.SetActive(true);

        if (DAT_C6130[0].DAT_69 == 0)
            PTR_FUN_A6108[DAT_C6102](DAT_C6130, 0);

        FUN_6A954(DAT_C6130, 0);
        DAT_C6294 = 3; //write byte instead int??
        FUN_68CA4(DAT_C6130, 0);
        FUN_69CEC(DAT_C6130, 0);
        FUN_687B4(DAT_C6130, 0);
        FUN_67AD8();
    }

    private void FUN_68638(InventoryWindow[] param1, int param2)
    {
        DAT_C6102++;

        if ((DAT_C61FF & 1) == 0)
        {
            param1[param2].rect[0].DAT_0C = 0;
            param1[param2].rect[0].DAT_0E = -77;
            param1[param2].rect[0].DAT_10 = 0;
            param1[param2].rect[0].DAT_12 = 140;
            FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, 0x8c0000);
            param1[param2].rect[2].DAT_0C = 0;
            param1[param2].rect[2].DAT_0E = 323;
            param1[param2].rect[1].DAT_0C = 0;
            param1[param2].rect[1].DAT_0E = 147;
            param1[param2].rect[1].DAT_10 = 0;
            param1[param2].rect[1].DAT_12 = 266;
            param1[param2].rect[2].DAT_10 = 0;
            param1[param2].rect[2].DAT_12 = 258;
            FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, 0x1020000);
            param1[param2].rect[1].DAT_0C = 0;
            param1[param2].rect[1].DAT_0E = 147;
            param1[param2].rect[1].DAT_10 = 0;
            param1[param2].rect[1].DAT_12 = 266;
        }
        else
        {
            param1[param2].rect[0].DAT_10 = 0;
            param1[param2].rect[0].DAT_12 = -146;
            param1[param2].rect[0].DAT_0C = 0;
            param1[param2].rect[0].DAT_0E = 123;
            param1[param2].rect[1].DAT_0C = 0;
            param1[param2].rect[1].DAT_0E = 147;
            param1[param2].rect[1].DAT_10 = 0;
            param1[param2].rect[1].DAT_12 = 516;
            param1[param2].rect[2].DAT_0C = 0;
            param1[param2].rect[2].DAT_0E = 123;
            param1[param2].rect[2].DAT_10 = 0;
            param1[param2].rect[2].DAT_12 = -60;
        }

        FUN_69014(param1, param2);
        FUN_6A1CC(param1, param2);
    }

    private void FUN_6873C(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A6114[DAT_C6103](param1, param2);
    }

    private void FUN_68778(InventoryWindow[] param1, int param2)
    {
        DAT_C6104 = 0;
        DAT_C6103 = 0;
        DAT_C6102 = 0;
        DAT_C6101--;
        GameManager.instance.FUN_5C94C(null, 1);
    }

    private void FUN_687B4(InventoryWindow[] param1, int param2)
    {
        short sVar1;
        short sVar2;
        Vector3Int vVar3;
        bool bVar4;
        Vector2 local_30;

        vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);
        sVar1 = param1[param2].rect[0].DAT_0E;
        sVar2 = param1[param2].rect[0].DAT_12;
        bVar4 = FUN_68C58();

        if (bVar4)
        {
            //FUN_6ACDC
        }

        FUN_6ACDC((RectTransform)equippedWeaponRect.transform, new Vector2(sVar1 - 600, sVar2 - 100));
        local_30 = new Vector2(param1[param2].rect[2].DAT_0E - 600, param1[param2].rect[2].DAT_12 - 70);
        bVar4 = FUN_69F30();

        if (bVar4)
        {
            //FUN_6ACDC
        }

        FUN_6ACDC((RectTransform)equippedAmmoRect.transform, local_30);

        if (DAT_C6103 == 0)
            local_30.x = sVar1;

        local_30.x -= 0x60;

        if (DAT_C6103 == 0)
            local_30.y = sVar2;

        local_30.y++;

        if (DAT_C6103 == 0)
            equippedWeaponRect.content.GetChild(0).GetComponent<Button>().Select();
        else if (DAT_C6103 == 1)
            equippedAmmoRect.content.GetChild(0).GetComponent<Button>().Select();

        FUN_6895C(param1, param2);
        FUN_699B8(param1, param2);
    }

    private void FUN_6895C(InventoryWindow[] param1, int param2)
    {
        short sVar1;
        int iVar2;
        uint uVar3;
        Vector3Int vVar3;
        Color32 cVar4;
        int iVar6;
        int iVar7;
        int iVar8;
        int iVar9;
        uint uVar10;
        uint local_30;
        int local_2c;

        if ((param1[param2].DAT_68 & 1) == 0)
        {
            weaponListRect.gameObject.SetActive(false);
        }
        else
        {
            weaponListRect.gameObject.SetActive(true);
            DAT_C6294 = 2; //write byte instead int??
            sVar1 = param1[param2].rect[1].DAT_0E;
            iVar9 = sVar1;
            local_2c = param1[param2].rect[1].DAT_12;

            if (5 < param1[param2].DAT_5B)
            {
                vVar3 = new Vector3Int(0x80, 0x80, 0x80);

                if (param1[param2].DAT_59 != 0)
                    vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

                //FUN_6ACDC
                vVar3 = new Vector3Int(0x80, 0x80, 0x80);

                if (param1[param2].DAT_59 + 1 < (param1[param2].DAT_5B + 4) / 5)
                    vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

                //FUN_6ACDC
            }

            FUN_6ACDC((RectTransform)weaponListRect.transform, new Vector2(iVar9, local_2c - 165));
            uVar10 = 0;
            uVar3 = 0;
            local_30 = (uint)DAT_C6108 >> 4;

            if (param1[param2].DAT_5A != 0)
            {
                iVar7 = -0x3b;
                iVar6 = 0;

                do
                {
                    if (param1[param2].DAT_54[iVar6] != 0)
                    {
                        iVar2 = param1[param2].DAT_54[iVar6] * 6;
                        cVar4 = new Color32(0x80, 0x80, 0x80, 0xff);

                        if (local_30 != 0 && local_30 == (byte)(DialogManager.DAT_A593C[iVar2 + 1] >> 8) >> 4)
                            cVar4 = new Color32(0xba, 0x25, 0x36, 0xff);

                        weaponListRect.content.GetChild((int)uVar10).gameObject.SetActive(true);
                        FUN_67554(weaponListRect.content.GetChild((int)uVar10).GetComponentInChildren<Text>(), DialogManager.DAT_A593C[iVar2 + 2], cVar4);
                        weaponListRect.content.GetChild((int)uVar10).GetChild(0).GetComponent<Image>().sprite = sprites[(byte)DialogManager.DAT_A593C[iVar2] >> 4];

                        if (param1[param2].DAT_5C == uVar3)
                        {
                            param1[param2].DAT_5D = param1[param2].DAT_54[iVar6];
                            weaponListRect.content.GetChild((int)uVar3).GetComponent<Button>().Select();
                        }

                        //iVar8 += 0x1a;
                        iVar7 += 0x1a;
                        uVar3++;
                    }
                    else
                    {
                        weaponListRect.content.GetChild((int)uVar10).gameObject.SetActive(false);
                    }

                    uVar10++;
                    iVar6++;
                } while (uVar10 < param1[param2].DAT_5A);

                while (uVar10 < 5)
                {
                    weaponListRect.content.GetChild((int)uVar10).gameObject.SetActive(false);
                    uVar10++;
                }
            }
            else
            {
                weaponListRect.content.GetChild(0).gameObject.SetActive(false);
                weaponListRect.content.GetChild(1).gameObject.SetActive(false);
                weaponListRect.content.GetChild(2).gameObject.SetActive(false);
                weaponListRect.content.GetChild(3).gameObject.SetActive(false);
                weaponListRect.content.GetChild(4).gameObject.SetActive(false);
            }
        }
    }

    private int FUN_68C18(uint param1)
    {
        byte bVar1;
        uint uVar2;
        int iVar3;

        uVar2 = 0;
        iVar3 = 0;

        if (param1 >> 4 != 0)
        {
            do
            {
                bVar1 = DAT_A6104[uVar2];
                uVar2++;
                iVar3 += bVar1;
            } while (uVar2 < param1 >> 4);
        }

        return iVar3 + (int)(param1 & 0xf);
    }

    private bool FUN_68C58()
    {
        bool bVar1;
        uint uVar2;

        uVar2 = 1;

        do
        {
            bVar1 = FUN_4A87C(11, uVar2);
            uVar2++;

            if (bVar1)
                return true;
        } while (uVar2 < 0xb);

        return false;
    }

    private void FUN_68CA4(InventoryWindow[] param1, int param2)
    {
        short sVar1;
        int iVar2;
        int iVar3;
        int iVar4;

        iVar4 = param1[param2].rect[0].DAT_0E;
        sVar1 = param1[param2].rect[0].DAT_12;
        iVar2 = FUN_68C18(DAT_C6108);

        if (iVar2 == 0)
            FUN_67554(equippedWeaponRect.content.GetChild(0).GetComponentInChildren<Text>(), 371, new Color32(0x80, 0x80, 0x80, 0xff));
        else
        {
            iVar3 = sVar1 + 6;
            FUN_67554(equippedWeaponRect.content.GetChild(0).GetComponentInChildren<Text>(), DialogManager.DAT_A593C[iVar2 * 6 + 2], new Color32(0x80, 0x80, 0x80, 0xff));
            equippedWeaponRect.content.GetChild(0).GetChild(0).GetComponent<Image>().sprite = sprites[(byte)DialogManager.DAT_A593C[iVar2 * 6] >> 4];
        }
    }

    private int FUN_68D50(InventoryWindow[] param1, int param2)
    {
        DAT_C6108 = (byte)(DialogManager.DAT_A593C[param1[param2].DAT_5D * 6 + 1] >> 8);
        return 0;
    }

    private int FUN_68D84(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        byte bVar2;
        int iVar3;
        int iVar4;
        uint uVar5;

        iVar3 = param1[param2].DAT_5D * 6;
        bVar1 = (byte)DialogManager.DAT_A593C[iVar3 + 1];

        if (bVar1 == (uint)DAT_C6108 >> 4)
        {
            FUN_4A7E8(11, param1[param2].DAT_5D, false);
            bVar2 = DAT_C6108;
            iVar4 = FUN_68C18(bVar2);
            FUN_4A7E8(11, (uint)iVar4, false);
            uVar5 = (uint)bVar1 << 4 | (bVar2 & 0xfU) + (byte)(DialogManager.DAT_A593C[iVar3 + 1] >> 8);
            DAT_C6108 = (byte)uVar5;
            iVar4 = FUN_68C18(uVar5 & 0xff);
            FUN_4A7E8(11, (uint)iVar4, true);
            iVar4 = 0;
        }
        else
            iVar4 = 0x17c;

        return iVar4;
    }

    private void FUN_68E54(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        bool bVar2;
        uint uVar3;
        uint uVar4;
        int puVar5;

        uVar4 = 0;
        uVar3 = 0;
        puVar5 = 0;
        bVar1 = (byte)((uint)DAT_C6108 >> 4);

        do
        {
            bVar2 = FUN_4A87C(11, uVar3);

            if (bVar2)
            {
                if (bVar1 != 0 && bVar1 == (uint)(byte)(DialogManager.DAT_A593C[puVar5 + 1] >> 8) >> 4)
                {
                    param1[param2].DAT_59 = (byte)(4 < uVar4 ? 1 : 0);
                    param1[param2].DAT_5C = (byte)(uVar4 - (((byte)((ulong)uVar4 * 0xcccccccd >> 0x20) & 0xfc) + (uVar4 / 5)));
                    return;
                }

                uVar4++;
            }

            uVar3++;
            puVar5 += 6;

            if (0xf < uVar3)
            {
                param1[param2].DAT_5C = 0;
                param1[param2].DAT_59 = 0;
                return;
            }
        } while (true);
    }

    private void FUN_68F2C(InventoryWindow[] param1, int param2)
    {
        bool bVar1;
        uint uVar2;
        byte bVar3;
        int iVar4;
        bool bVar4;
        uint uVar5;

        param1[param2].DAT_54 = new byte[5];
        iVar4 = param1[param2].DAT_59 * 5;
        uVar2 = 0;

        while (iVar4 != 0)
        {
            bVar1 = FUN_4A87C(11, uVar2);

            if (bVar1)
                iVar4--;

            uVar2++;
        }

        uVar5 = 0;

        do
        {
            if (15 < uVar2) break;

            bVar4 = FUN_4A87C(11, uVar2);

            if (bVar4)
            {
                param1[param2].DAT_54[uVar5] = (byte)uVar2;
                uVar5++;
            }

            uVar2++;
        } while (uVar5 < 5);

        param1[param2].DAT_5A = (byte)uVar5;
        bVar3 = 0;
        uVar2 = 0;

        do
        {
            bVar4 = FUN_4A87C(11, uVar2);

            if (bVar4)
                bVar3++;

            uVar2++;
        } while (uVar2 < 0x10);

        param1[param2].DAT_5B = bVar3;
    }

    private void FUN_69014(InventoryWindow[] param1, int param2)
    {
        param1[param2].DAT_59 = 0;
        FUN_68F2C(param1, param2);
    }

    private void FUN_69034(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A611C[DAT_C6104](param1, param2);
    }

    private void FUN_69070(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        int iVar2;
        bool bVar2;

        iVar2 = FUN_68C18(DAT_C6108);

        if (iVar2 == 0)
            DAT_C610A = 0x173;
        else
            DAT_C610A = DialogManager.DAT_A593C[iVar2 * 6 + 3];

        uVar1 = DAT_C612E;

        if ((uVar1 & 0x4000) == 0)
        {
            if ((uVar1 & 0x20a0) == 0)
            {
                if ((uVar1 & 0x40) != 0)
                    DAT_C6102++;
            }
            else
            {
                bVar2 = FUN_68C58();

                if (!bVar2)
                {
                    DAT_C6104 = 4;
                    DAT_C610A = 0x174;
                    GameManager.instance.FUN_5C94C(null, 1);
                }
                else
                {
                    GameManager.instance.FUN_5C94C(null, 2);
                    DAT_C6104 = 1;
                    FUN_68E54(param1, param2);
                    FUN_68F2C(param1, param2);
                    FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, 0x360000);
                    FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, 0x8c0000);
                }
            }
        }
        else
        {
            DAT_C6103++;
            GameManager.instance.FUN_5C94C(null, 0);
        }
    }

    private void FUN_691C8(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        sbyte sVar2;

        param1[param2].DAT_68 |= 1;
        uVar1 = DAT_C612E;

        if ((uVar1 & 0xa0) == 0)
        {
            if ((uVar1 & 0x40) == 0)
            {
                if ((uVar1 & 0x1000) == 0)
                {
                    if ((uVar1 & 0x4000) == 0)
                    {
                        if ((uVar1 & 0x8000) == 0)
                        {
                            if ((uVar1 & 0x2000) == 0 ||
                                (param1[param2].DAT_5B + 4) / 5 - 1 <= param1[param2].DAT_59)
                                goto LAB_69368;

                            GameManager.instance.FUN_5C94C(null, 0);
                            sVar2 = (sbyte)(param1[param2].DAT_59 + 1);
                        }
                        else
                        {
                            if (param1[param2].DAT_59 == 0) goto LAB_69368;

                            GameManager.instance.FUN_5C94C(null, 0);
                            sVar2 = (sbyte)(param1[param2].DAT_59 - 1);
                        }

                        param1[param2].DAT_59 = (byte)sVar2;
                        FUN_68F2C(param1, param2);
                        param1[param2].DAT_5C = 0;
                        goto LAB_69368;
                    }

                    if (param1[param2].DAT_5A - 1 <= param1[param2].DAT_5C) goto LAB_69368;

                    param1[param2].DAT_5C++;
                }
                else
                {
                    if (param1[param2].DAT_5C == 0) goto LAB_69368;

                    param1[param2].DAT_5C--;
                }

                GameManager.instance.FUN_5C94C(null, 0);
            }
            else
            {
                GameManager.instance.FUN_5C94C(null, 1);
                DAT_C6104 = 0;
                param1[param2].DAT_68 &= 0xfe;
                FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, 0x8c0000);
                FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, 0x1020000);
            }
        }
        else
        {
            DAT_C6104 = 2;
            DAT_C6106 = 0;
            GameManager.instance.FUN_5C94C(null, 2);
        }

        LAB_69368:
        DAT_C610A = DialogManager.DAT_A593C[param1[param2].DAT_5D * 6 + 3];
    }

    private void FUN_693A0(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        byte bVar2;
        ushort uVar3;
        int iVar4;

        actionsRect.gameObject.SetActive(true);
        uVar3 = DAT_C612E;

        if ((uVar3 & 0x1000) == 0)
        {
            if ((uVar3 & 0x4000) == 0)
            {
                if ((uVar3 & 0x40) == 0)
                {
                    if ((uVar3 & 0xa0) != 0)
                    {
                        if (DAT_C6106 == 0)
                        {
                            bVar1 = param1[param2].DAT_5D;
                            iVar4 = PTR_FUN_A6130[(byte)DialogManager.DAT_A593C[bVar1 * 6] & 0xf](param1, param2);

                            if (iVar4 == 0)
                            {
                                if (((byte)DialogManager.DAT_A593C[bVar1 * 6] & 0xf) == 1 && param1[param2].DAT_5B < 7U)
                                    param1[param2].DAT_59 = 0;

                                actionsRect.gameObject.SetActive(false);
                                GameManager.instance.FUN_5C94C(null, 2);
                                DAT_C6104 = 0;
                                param1[param2].DAT_68 &= 0xfe;
                                FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, 0x8c0000);
                                FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, 0x1020000);
                                FUN_68F2C(param1, param2);
                            }
                            else
                            {
                                GameManager.instance.FUN_5C94C(null, 1);
                                DAT_C610A = (ushort)iVar4;
                            }
                        }
                        else
                        {
                            actionsRect.gameObject.SetActive(false);
                            GameManager.instance.FUN_5C94C(null, 2);
                            FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, -0x920000);
                            FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, -0x3c0000);
                            FUN_6A8A4(param1[param2], 1, 10, 0x930000, 0x2040000);
                            DAT_C6104 = 3;
                            bVar2 = param1[param2].DAT_5D;
                            DAT_C61FD = 0;
                            DAT_C61FE = 30;
                            DAT_C61FC = bVar2;
                            DAT_C610A = DialogManager.DAT_A593C[param1[param2].DAT_5D * 6 + 3];
                        }
                    }
                }
                else
                {
                    DAT_C6104 = 1;
                    actionsRect.gameObject.SetActive(false);
                    GameManager.instance.FUN_5C94C(null, 1);
                }
            }
            else
            {
                if (DAT_C6106 == 0)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    DAT_C6106 = 1;
                }
            }
        }
        else
        {
            if (DAT_C6106 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 0);
                DAT_C6106 = 0;
            }
        }

        FUN_66C68(2, DAT_C6106);
    }

    private void FUN_69618(InventoryWindow[] param1, int param2)
    {
        param1[param2].DAT_68 &= 0xfe;
        FUN_6A9F4();
        previewRect.gameObject.SetActive(true);

        if (DAT_C61FE == 0 && (DAT_C612E & 0xe0) != 0)
        {
            previewRect.gameObject.SetActive(false);
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 1;
            DAT_C61FF &= 0xfe;
            param1[param2].DAT_68 |= 1;
            FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, 0x360000);
            FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, 0x8c0000);
            FUN_6A8A4(param1[param2], 1, 10, 0x930000, 0x10a0000);
        }
    }

    private void FUN_696F8(InventoryWindow[] param1, int param2)
    {
        if ((DAT_C612E & 0xe0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
        }
    }

    private void FUN_69738(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        bool bVar2;
        byte bVar3;
        uint uVar4;
        uint uVar5;
        int pbVar6;
        sbyte sVar7;
        int iVar8;
        uint uVar9;

        param1[param2].DAT_5E = new byte[5];
        uVar9 = 0;
        pbVar6 = 0;
        iVar8 = param1[param2].DAT_63 * 5;
        bVar3 = (byte)((uint)DAT_C6108 >> 4);

        while (iVar8 != 0)
        {
            if (GameManager.instance.DAT_9EAC[pbVar6] - 16U < 11 && 
                GameManager.instance.DAT_9EAC[pbVar6 + 1] != 0 && 
                bVar3 == ((byte)DialogManager.DAT_A593C[GameManager.instance.DAT_9EAC[pbVar6] * 6 + 1] & 0xf))
            {
                uVar4 = 1U << (GameManager.instance.DAT_9EAC[pbVar6] - 16 & 31);

                if ((uVar9 & uVar4) == 0)
                {
                    uVar9 |= uVar4;
                    iVar8--;
                }
            }

            pbVar6 += 4;
        }

        uVar4 = 0;
        uVar9 = uVar4;

        do
        {
            if (GameManager.instance.DAT_9ADE * 4 <= pbVar6) break;

            bVar2 = uVar4 < 5;

            if (GameManager.instance.DAT_9EAC[pbVar6] - 16U < 11 &&
                GameManager.instance.DAT_9EAC[pbVar6 + 1] != 0)
            {
                bVar1 = GameManager.instance.DAT_9EAC[pbVar6];

                if (bVar3 == ((byte)DialogManager.DAT_A593C[bVar1 * 6 + 1] & 0xf))
                {
                    uVar5 = 1U << (bVar1 - 16 & 31);

                    if ((uVar9 & uVar5) == 0)
                    {
                        uVar9 |= uVar5;
                        param1[param2].DAT_5E[uVar4] = bVar1;
                        uVar4++;
                    }
                }
            }

            pbVar6 += 4;
        } while (bVar2);

        uVar9 = 0;
        param1[param2].DAT_64 = (byte)uVar4;
        pbVar6 = 0;
        sVar7 = 0;

        while (pbVar6 < GameManager.instance.DAT_9ADE * 4)
        {
            if (GameManager.instance.DAT_9EAC[pbVar6] - 16U < 11 && 
                GameManager.instance.DAT_9EAC[pbVar6 + 1] != 0 && 
                bVar3 == ((byte)DialogManager.DAT_A593C[GameManager.instance.DAT_9EAC[pbVar6] * 6 + 1] & 0xf))
            {
                uVar4 = 1U << (GameManager.instance.DAT_9EAC[pbVar6] - 16 & 31);

                if ((uVar9 & uVar4) == 0)
                {
                    uVar9 |= uVar4;
                    sVar7++;
                }
            }

            pbVar6 += 4;
        }

        param1[param2].DAT_65 = sVar7;
    }

    private void FUN_699B8(InventoryWindow[] param1, int param2)
    {
        short sVar1;
        uint uVar2;
        uint uVar4;
        Vector3Int vVar4;
        Color32 cVar5;
        int iVar6;
        int iVar7;
        uint local_38;
        int local_3c;

        if ((param1[param2].DAT_68 & 2) == 0)
        {
            ammoListRect.gameObject.SetActive(false);
        }
        else
        {
            ammoListRect.gameObject.SetActive(true);
            DAT_C6294 = 2; //write byte instead int??
            sVar1 = param1[param2].rect[1].DAT_0E;
            iVar7 = sVar1;
            local_3c = param1[param2].rect[1].DAT_12;

            if (5 < param1[param2].DAT_65)
            {
                vVar4 = new Vector3Int(0x80, 0x80, 0x80);

                if (param1[param2].DAT_63 != 0)
                    vVar4 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

                //FUN_6ACDC
                vVar4 = new Vector3Int(0x80, 0x80, 0x80);

                if (param1[param2].DAT_63 + 1 < (param1[param2].DAT_65 + 4) / 5)
                    vVar4 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

                //FUN_6ACDC
            }

            FUN_6ACDC((RectTransform)ammoListRect.transform, new Vector2(iVar7, local_3c - 165));
            local_38 = ((uint)((CriPlayer)SceneManager.instance.DAT_27C[10]).DAT_244[(DAT_C6108 >> 4) - 1] >> 8) + 0x10;
            uVar4 = 0;

            if (param1[param2].DAT_64 != 0)
            {
                do
                {
                    iVar6 = (int)uVar4;
                    uVar2 = param1[param2].DAT_5E[iVar6];

                    if (uVar2 != 0)
                    {
                        cVar5 = new Color32(0x80, 0x80, 0x80, 0xff);

                        if (local_38 == uVar2)
                            cVar5 = new Color32(0xba, 0x25, 0x36, 0xff);

                        ammoListRect.content.GetChild((int)uVar4).gameObject.SetActive(true);
                        ammoListRect.content.GetChild((int)uVar4).GetChild(0).GetComponent<Image>().sprite = sprites[(byte)DialogManager.DAT_A593C[uVar2 * 6] >> 4];
                        FUN_67554(ammoListRect.content.GetChild((int)uVar4).GetComponentInChildren<Text>(), DialogManager.DAT_A593C[uVar2 * 6 + 2], cVar5);
                        ammoListRect.content.GetChild((int)uVar4).GetComponentsInChildren<Text>()[1].text = DAT_C6298[param1[param2].DAT_5E[iVar6] - 0x10].ToString();

                        if (param1[param2].DAT_66 == uVar4)
                        {
                            param1[param2].DAT_67 = param1[param2].DAT_5E[iVar6];
                            ammoListRect.content.GetChild((int)uVar4).GetComponent<Button>().Select();
                        }
                    }
                    else
                    {
                        ammoListRect.content.GetChild((int)uVar4).gameObject.SetActive(false);
                    }

                    uVar4++;
                } while (uVar4 < param1[param2].DAT_64);

                while (uVar4 < 5)
                {
                    ammoListRect.content.GetChild((int)uVar4).gameObject.SetActive(false);
                    uVar4++;
                }
            }
            else
            {
                ammoListRect.content.GetChild(0).gameObject.SetActive(false);
                ammoListRect.content.GetChild(1).gameObject.SetActive(false);
                ammoListRect.content.GetChild(2).gameObject.SetActive(false);
                ammoListRect.content.GetChild(3).gameObject.SetActive(false);
                ammoListRect.content.GetChild(4).gameObject.SetActive(false);
            }
        }
    }

    private void FUN_69CEC(InventoryWindow[] param1, int param2)
    {
        uint uVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        uint uVar5;
        int iVar6;
        int iVar7;

        iVar6 = param1[param2].rect[2].DAT_0E;
        iVar7 = param1[param2].rect[2].DAT_12;
        uVar1 = (uint)DAT_C6108 >> 4;

        if (uVar1 != 0)
        {
            uVar4 = 0;
            uVar5 = (uint)((CriPlayer)SceneManager.instance.DAT_27C[10]).DAT_244[uVar1 - 1] >> 8;
            uVar1 = uVar5 + 0x10;
            iVar3 = (int)uVar1 * 6;

            if (GameManager.instance.DAT_9ADE != 0)
            {
                do
                {
                    iVar2 = (int)uVar4 * 4;

                    if (GameManager.instance.DAT_9EAC[iVar2] == uVar1 && GameManager.instance.DAT_9EAC[iVar2 + 1] != 0)
                    {
                        equippedAmmoRect.content.GetChild(0).GetChild(0).GetComponent<Image>().sprite = sprites[(byte)DialogManager.DAT_A593C[iVar3] >> 4];
                        FUN_67554(equippedAmmoRect.content.GetChild(0).GetComponentInChildren<Text>(), DialogManager.DAT_A593C[iVar3 + 2], new Color32(0x80, 0x80, 0x80, 0xff));
                        equippedAmmoRect.content.GetChild(0).GetComponentsInChildren<Text>()[1].text = DAT_C6298[uVar5].ToString();
                        return;
                    }

                    uVar4++;
                } while (uVar4 < GameManager.instance.DAT_9ADE);
            }
        }

        //FUN_67554
    }

    private bool FUN_69E70(InventoryWindow[] param1, int param2)
    {
        CriPlayer oVar1;
        int iVar2;
        uint uVar3;

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        iVar2 = param1[param2].DAT_67 * 6;
        uVar3 = (byte)DialogManager.DAT_A593C[iVar2 + 1] & 0xfU;

        if (uVar3 == (uint)DAT_C6108 >> 4)
        {
            if (((byte)DialogManager.DAT_A593C[iVar2 + 1] & 0xf0) == 0)
                oVar1.DAT_244[uVar3 - 1] = (ushort)((byte)(DialogManager.DAT_A593C[iVar2 + 1] >> 8) << 8);
            else
            {
                if (uVar3 != 2)
                    return true;

                if ((DAT_C6108 & 0xfU) < 2)
                    return false;

                uVar3 = 2;
                oVar1.DAT_244[1] = (ushort)((byte)(DialogManager.DAT_A593C[iVar2 + 1] >> 8) << 8);
            }

            oVar1.FUN_50AF4((byte)uVar3);
        }

        return true;
    }

    private bool FUN_69F30()
    {
        byte bVar1;
        int pbVar2;
        uint uVar3;

        uVar3 = 0;
        pbVar2 = 0;
        bVar1 = (byte)((uint)DAT_C6108 >> 4);

        if (GameManager.instance.DAT_9ADE != 0)
        {
            do
            {
                if (GameManager.instance.DAT_9EAC[pbVar2] - 16U < 11 &&
                    GameManager.instance.DAT_9EAC[pbVar2 + 1] != 0 &&
                    ((byte)DialogManager.DAT_A593C[GameManager.instance.DAT_9EAC[pbVar2] * 6 + 1] & 0xf) == bVar1 &&
                    (bVar1 != 2 || ((byte)DialogManager.DAT_A593C[GameManager.instance.DAT_9EAC[pbVar2] * 6 + 1] & 0xf0) == 0 ||
                    1 < (DAT_C6108 & 0xfU)))
                    return true;

                uVar3++;
                pbVar2 += 4;
            } while (uVar3 < GameManager.instance.DAT_9ADE);
        }

        return false;
    }

    private bool FUN_6A00C(uint param2)
    {
        int pbVar1;
        uint uVar2;

        uVar2 = 0;
        pbVar1 = 0;

        if (GameManager.instance.DAT_9ADE != 0)
        {
            do
            {
                if (GameManager.instance.DAT_9EAC[pbVar1] == param2 &&
                    GameManager.instance.DAT_9EAC[pbVar1 + 1] != 0)
                    return true;

                uVar2++;
                pbVar1 += 4;
            } while (uVar2 < GameManager.instance.DAT_9ADE);
        }

        return false;
    }

    private void FUN_6A078(InventoryWindow[] param1, int param2)
    {
        uint uVar1;
        uint uVar2;
        int pbVar3;
        int iVar4;
        uint uVar5;
        uint uVar6;

        iVar4 = -1;
        uVar5 = 0;
        uVar6 = (uint)DAT_C6108 >> 4;
        pbVar3 = 0;

        if (pbVar3 < GameManager.instance.DAT_9ADE * 4)
        {
            do
            {
                if (GameManager.instance.DAT_9EAC[pbVar3] - 16U < 11 &&
                    GameManager.instance.DAT_9EAC[pbVar3 + 1] != 0)
                {
                    uVar2 = GameManager.instance.DAT_9EAC[pbVar3];

                    if (uVar6 == ((byte)DialogManager.DAT_A593C[uVar2 * 6 + 1] & 0xf))
                    {
                        uVar1 = 1U << (int)(uVar2 - 16 & 31);

                        if ((uVar5 & uVar1) == 0)
                        {
                            uVar5 |= uVar1;
                            iVar4++;

                            if (((uint)((CriPlayer)SceneManager.instance.DAT_27C[10]).DAT_244[uVar6 - 1] >> 8) + 0x10 == uVar2)
                            {
                                param1[param2].DAT_63 = (byte)(4 < iVar4 ? 1 : 0);
                                param1[param2].DAT_66 = (sbyte)(iVar4 + (iVar4 / 5) * -5);
                                return;
                            }
                        }
                    }
                }

                pbVar3 += 4;
            } while (pbVar3 < GameManager.instance.DAT_9ADE * 4);
        }

        param1[param2].DAT_66 = 0;
        param1[param2].DAT_63 = 0;
    }

    private void FUN_6A1CC(InventoryWindow[] param1, int param2)
    {
        return;
    }

    private void FUN_6A1D4(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A6138[DAT_C6104](param1, param2);
    }

    private void FUN_6A210(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        bool bVar2;
        int iVar3;
        uint uVar4;
        uint uVar5;

        uVar5 = (uint)DAT_C6108 >> 4;

        if (uVar5 != 0)
        {
            uVar4 = ((uint)((CriPlayer)SceneManager.instance.DAT_27C[10]).DAT_244[uVar5 - 1] >> 8) + 0x10;
            bVar2 = FUN_6A00C(uVar4);

            if (bVar2)
            {
                DAT_C610A = DialogManager.DAT_A593C[uVar4 * 6 + 3];
                goto LAB_6A29C;
            }
        }

        DAT_C610A = 0x175;
    LAB_6A29C:
        uVar1 = DAT_C612E;

        if ((uVar1 & 0x20a0) == 0)
        {
            if ((uVar1 & 0x40) != 0)
            {
                DAT_C6102++;
                return;
            }

            if ((uVar1 & 0x1000) == 0)
                return;

            iVar3 = 0;
            DAT_C6103--;
        }
        else
        {
            if (uVar5 == 0)
            {
                iVar3 = 1;
                DAT_C6104 = 4;
                DAT_C610A = 0x177;
            }
            else
            {
                bVar2 = FUN_69F30();

                if (bVar2)
                {
                    GameManager.instance.FUN_5C94C(null, 2);
                    DAT_C6104 = 1;
                    FUN_6A078(param1, param2);
                    FUN_69738(param1, param2);
                    FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, 0x360000);
                    FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, 0x8c0000);
                    return;
                }

                iVar3 = 1;
                DAT_C6104 = 4;
                DAT_C610A = 0x176;
            }
        }

        GameManager.instance.FUN_5C94C(null, iVar3);
    }

    private void FUN_6A3BC(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        sbyte sVar2;

        param1[param2].DAT_68 |= 2;
        uVar1 = DAT_C612E;

        if ((uVar1 & 0xa0) == 0)
        {
            if ((uVar1 & 0x40) == 0)
            {
                if ((uVar1 & 0x1000) == 0)
                {
                    if ((uVar1 & 0x4000) == 0)
                    {
                        if ((uVar1 & 0x8000) == 0)
                        {
                            if ((uVar1 & 0x2000) == 0 ||
                                ((byte)param1[param2].DAT_65 + 4) / 5 - 1 <= param1[param2].DAT_63) goto LAB_6A55C;

                            GameManager.instance.FUN_5C94C(null, 0);
                            sVar2 = (sbyte)(param1[param2].DAT_63 + 1);
                        }
                        else
                        {
                            if (param1[param2].DAT_63 == 0) goto LAB_6A55C;

                            GameManager.instance.FUN_5C94C(null, 0);
                            sVar2 = (sbyte)(param1[param2].DAT_63 - 1);
                        }

                        param1[param2].DAT_63 = (byte)sVar2;
                        FUN_69738(param1, param2);
                        param1[param2].DAT_66 = 0;
                        goto LAB_6A55C;
                    }

                    if (param1[param2].DAT_64 - 1 <= (byte)param1[param2].DAT_66) goto LAB_6A55C;

                    param1[param2].DAT_66++;
                }
                else
                {
                    if (param1[param2].DAT_66 == 0) goto LAB_6A55C;

                    param1[param2].DAT_66--;
                }

                GameManager.instance.FUN_5C94C(null, 0);
            }
            else
            {
                GameManager.instance.FUN_5C94C(null, 1);
                DAT_C6104 = 0;
                param1[param2].DAT_68 &= 0xfd;
                FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, 0x8c0000);
                FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, 0x1020000);
            }
        }
        else
        {
            DAT_C6104 = 2;
            DAT_C6106 = 0;
            GameManager.instance.FUN_5C94C(null, 2);
        }

        LAB_6A55C:
        DAT_C610A = DialogManager.DAT_A593C[param1[param2].DAT_67 * 6 + 3];
    }

    private void FUN_6A594(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        ushort uVar2;
        ushort uVar3;
        bool bVar4;

        actionsRect.gameObject.SetActive(true);
        uVar2 = DAT_C612E;

        if ((uVar2 & 0x1000) == 0)
        {
            if ((uVar2 & 0x4000) == 0)
            {
                if ((uVar2 & 0x40) == 0)
                {
                    if ((uVar2 & 0xa0) != 0)
                    {
                        if (DAT_C6106 == 0)
                        {
                            bVar4 = FUN_69E70(param1, param2);

                            if (bVar4)
                            {
                                actionsRect.gameObject.SetActive(false);
                                GameManager.instance.FUN_5C94C(null, 2);
                                DAT_C6104 = 0;
                                param1[param2].DAT_68 &= 0xfd;
                                FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, 0x8c0000);
                                FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, 0x1020000);
                                goto LAB_6A764;
                            }

                            GameManager.instance.FUN_5C94C(null, 1);
                            uVar3 = 0x17c;
                        }
                        else
                        {
                            actionsRect.gameObject.SetActive(false);
                            GameManager.instance.FUN_5C94C(null, 2);
                            FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, -0x920000);
                            FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, -0x3c0000);
                            FUN_6A8A4(param1[param2], 1, 10, 0x930000, 0x2040000);
                            DAT_C6104 = 3;
                            bVar1 = param1[param2].DAT_67;
                            DAT_C61FD = 0;
                            DAT_C61FE = 30;
                            DAT_C61FC = bVar1;
                            uVar3 = DialogManager.DAT_A593C[param1[param2].DAT_67 * 6 + 3];
                        }

                        DAT_C610A = uVar3;
                    }
                }
                else
                {
                    DAT_C6104 = 1;
                    GameManager.instance.FUN_5C94C(null, 1);
                    actionsRect.gameObject.SetActive(false);
                }
            }
            else
            {
                if (DAT_C6106 == 0)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    DAT_C6106 = 1;
                }
            }
        }
        else
        {
            if (DAT_C6106 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 0);
                DAT_C6106 = 0;
            }
        }

        LAB_6A764:
        FUN_66C68(2, DAT_C6106);
    }

    private void FUN_6A784(InventoryWindow[] param1, int param2)
    {
        param1[param2].DAT_68 &= 0xfd;
        FUN_6A9F4();
        previewRect.gameObject.SetActive(true);

        if (DAT_C61FE == 0 && (DAT_C612E & 0xe0) != 0)
        {
            previewRect.gameObject.SetActive(false);
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 1;
            DAT_C61FF &= 0xfe;
            param1[param2].DAT_68 |= 2;
            FUN_6A8A4(param1[param2], 0, 10, 0x7b0000, 0x360000);
            FUN_6A8A4(param1[param2], 2, 10, 0x7b0000, 0x8c0000);
            FUN_6A8A4(param1[param2], 1, 10, 0x930000, 0x10a0000);
        }
    }

    private void FUN_6A864(InventoryWindow[] param1, int param2)
    {
        if ((DAT_C612E & 0xe0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
        }
    }

    private void FUN_6A8A4(InventoryWindow param1, uint param2, int param3, int param4, int param5)
    {
        InventoryRect puVar1;

        param1.DAT_69++;
        puVar1 = param1.rect[param2];

        if (param3 == 0)
            return; //trap(0x1c00)

        if (param3 == -1 && param4 - (puVar1.DAT_0E << 0x10 | (ushort)puVar1.DAT_0C) == -0x80000000)
            return; //trap(0x1800)

        if (param3 == 0)
            return; //trap(0x1c00)

        if (param3 == -1 && param5 - (puVar1.DAT_12 << 0x10 | (ushort)puVar1.DAT_10) == -0x80000000)
            return; //trap(0x1800)

        puVar1.DAT_01 = (sbyte)param3;
        puVar1.DAT_14 = (short)param4;
        puVar1.DAT_16 = (short)(param4 >> 0x10);
        puVar1.DAT_18 = (short)param5;
        puVar1.DAT_1A = (short)(param5 >> 0x10);
        puVar1.DAT_00 = true;
        puVar1.DAT_04 = (short)(((short)param4 - puVar1.DAT_0C) / param3);
        puVar1.DAT_06 = (short)(((short)(param4 >> 0x10) - puVar1.DAT_0E) / param3);
        puVar1.DAT_08 = (short)(((short)param5 - puVar1.DAT_10) / param3);
        puVar1.DAT_0A = (short)(((short)(param5 >> 0x10) - puVar1.DAT_12) / param3);
    }

    private void FUN_6A954(InventoryWindow[] param1, int param2)
    {
        sbyte sVar1;
        int piVar2;
        InventoryRect pcVar3;

        piVar2 = 0;

        do
        {
            pcVar3 = param1[param2].rect[piVar2];

            if (pcVar3.DAT_00)
            {
                pcVar3.DAT_0C += pcVar3.DAT_04;
                pcVar3.DAT_0E += pcVar3.DAT_06;
                sVar1 = (sbyte)(pcVar3.DAT_01 - 1);
                pcVar3.DAT_01 = sVar1;
                pcVar3.DAT_10 += pcVar3.DAT_08;
                pcVar3.DAT_12 += pcVar3.DAT_0A;

                if (sVar1 == -1)
                {
                    param1[param2].DAT_69--;
                    pcVar3.DAT_00 = false;
                    pcVar3.DAT_0C = pcVar3.DAT_14;
                    pcVar3.DAT_0E = pcVar3.DAT_16;
                    pcVar3.DAT_10 = pcVar3.DAT_18;
                    pcVar3.DAT_12 = pcVar3.DAT_1A;
                }
            }

            piVar2++;
        } while (piVar2 < 3);
    }

    private void FUN_6A9F4()
    {
        byte bVar1;
        int iVar2;
        ushort[] aVar2;
        int iVar3;
        int iVar4;

        iVar3 = DAT_C61FC * 6;

        if ((DAT_C61FF & 1) != 0)
        {
            DAT_C610A = 0;
            iVar3 = DAT_C61FC * 6;
            aVar2 = DialogManager.instance.FUN_67350(377, DialogManager.DAT_A593C[iVar3 + 2]);
            FUN_6750C(aVar2, 0, descText, new Color32(0, 0, 0, 0xff));
        }

        if (DAT_C61FE != 0)
            DAT_C61FE--;

        bVar1 = DAT_C61FD;

        if (bVar1 == 1)
        {
            DAT_C61FD = 2;
            //FUN_2A17C
            return;
        }

        if (bVar1 < 2)
        {
            if (bVar1 == 0)
            {
                //...
                DAT_C61FD++;
                return;
            }
        }
        else
        {
            if (bVar1 == 2)
            {
                //...
                DAT_C61FD++;
                return;
            }
        }

        iVar4 = 0;
        iVar2 = 80;

        if (DAT_C6100 == 3)
        {
            iVar4 = 30;
            iVar2 = 110;
        }

        //FUN_679CC
        FUN_67554(previewRect.GetChild(1).GetComponent<Text>(), DialogManager.DAT_A593C[iVar3 + 4], new Color32(0x80, 0x80, 0x80, 0xff));
    }

    public ushort FUN_6AB5C(uint param1)
    {
        if (param1 != 0xff)
            return DAT_C6298[param1 - 16];

        return 0;
    }

    public void FUN_6AB8C(uint param1, short param2)
    {
        int pbVar1;
        int iVar3;

        DAT_C6298[param1 - 0x10] += (ushort)param2;
        pbVar1 = 0;
        iVar3 = GameManager.instance.DAT_9ADE - 1;

        if (iVar3 != 1)
        {
            do
            {
                if (GameManager.instance.DAT_9EAC[pbVar1] != 0 &&
                    GameManager.instance.DAT_9EAC[pbVar1 + 1] == param1)
                {
                    GameManager.instance.DAT_9EAC[pbVar1 + 1] += (byte)param2;
                    return;
                }

                iVar3--;
                pbVar1 += 4;
            } while (iVar3 != -1);
        }
    }

    public void FUN_6AC20()
    {
        int pbVar1;
        int iVar2;

        DAT_C6298 = new ushort[512];
        iVar2 = GameManager.instance.DAT_9ADE;
        pbVar1 = 0;

        while (--iVar2 != -1)
        {
            if (GameManager.instance.DAT_9EAC[pbVar1] - 16U < 11)
                DAT_C6298[GameManager.instance.DAT_9EAC[pbVar1] - 16] += 
                    GameManager.instance.DAT_9EAC[pbVar1 + 1];

            pbVar1 += 4;
        }

        ((CriPlayer)SceneManager.instance.DAT_27C[10]).FUN_50CC8();
    }

    private void FUN_6ACDC(RectTransform param1, Vector2 param2)
    {
        param1.anchoredPosition = new Vector2(param2.x, -param2.y) / 2f;
    }

    private void FUN_6AF38(RectTransform param1, Vector2 param2)
    {
        param1.anchoredPosition = new Vector2(param2.x, -param2.y) * 2f;
    }

    private void FUN_6B08C()
    {
        //FUN_6AF38
        itemsRect.gameObject.SetActive(true);
        suppliesRect.gameObject.SetActive(true);

        if (DAT_C6130[0].DAT_5B == 0)
            PTR_FUN_A614C[DAT_C6102](DAT_C6130, 0);

        FUN_6CDD8(DAT_C6130, 0);
        FUN_6BFDC(DAT_C6130, 0);
        FUN_6BDD4(DAT_C6130, 0);
        FUN_6CA4C(DAT_C6130, 0);
        FUN_6C840(DAT_C6130, 0);
    }

    private void FUN_6B14C(InventoryWindow[] param1, int param2)
    {
        uint uVar1;
        InventoryRect rVar2;
        InventoryRect rVar3;
        InventoryRect rVar4;
        uint uVar5;

        DAT_C6102++;
        FUN_6B3C8(param1, param2);
        FUN_6C110(param1, param2);
        param1[param2].DAT_50 = 2;
        param1[param2].DAT_5A = 3;
        rVar2 = param1[param2].rect[1];
        rVar3 = rVar2;
        rVar4 = param1[param2].rect[0];

        if ((DAT_C61FF & 1) == 0)
        {
            uVar1 = 0;
            uVar5 = 1;

            if (param1[param2].DAT_56 != 0 && param1[param2].DAT_4C == 0)
            {
                uVar1 = 1;
                DAT_C6103 = 1;
                uVar5 = 0;
                param1[param2].DAT_50 = 3;
                param1[param2].DAT_5A = 2;
                rVar3 = param1[param2].rect[0];
                rVar4 = rVar2;
            }

            rVar4.DAT_0C = 0;
            rVar4.DAT_0E = 147;
            rVar4.DAT_10 = 0;
            rVar4.DAT_12 = -6;
            FUN_6CD1C(param1[param2], uVar1, 10, 0x930000, 0xc20000);
            rVar3.DAT_0C = 0;
            rVar3.DAT_0E = 124;
            rVar3.DAT_10 = 0;
            rVar3.DAT_12 = 349;
            FUN_6CD1C(param1[param2], uVar5, 10, 0x7c0000, 0x950000);
        }
        else
        {
            if (42U < DAT_C61FC)
            {
                DAT_C6103 = 1;
                param1[param2].DAT_50 = 3;
                param1[param2].DAT_5A = 2;
                rVar3 = param1[param2].rect[0];
                rVar4 = rVar2;
            }

            rVar4.DAT_0C = 0;
            rVar4.DAT_0E = 147;
            rVar4.DAT_10 = 0;
            rVar4.DAT_12 = 694;
            rVar3.DAT_0C = 0;
            rVar3.DAT_0E = 124;
            rVar3.DAT_10 = 0;
            rVar3.DAT_12 = -151;
        }

        rVar4.DAT_03 = 4;
        rVar3.DAT_03 = 20;

        if (param1[param2].DAT_59 == 0 && param1[param2].DAT_4F == 0)
            DAT_C6102 = 2;
    }

    private void FUN_6B2F0(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A6158[DAT_C6103](param1, param2);
    }

    private void FUN_6B32C(InventoryWindow[] param1, int param2)
    {
        if ((DAT_C612E & 0xe0) != 0)
        {
            DAT_C6104 = 0;
            DAT_C6103 = 0;
            DAT_C6102 = 0;
            DAT_C6101--;
            GameManager.instance.FUN_5C94C(null, 1);
        }

        //...
    }

    private void FUN_6B3C8(InventoryWindow[] param1, int param2)
    {
        uint uVar1;
        int iVar2;

        uVar1 = 0;
        iVar2 = 0;

        while (uVar1 < GameManager.instance.DAT_9ADE * 4U)
        {
            if (GameManager.instance.DAT_9EAC[uVar1] != 0)
                iVar2++;

            uVar1 += 4;
        }

        param1[param2].DAT_4F = (byte)iVar2;

        if (iVar2 == 0)
            param1[param2].DAT_4D = -1;
        else
            param1[param2].DAT_4D = 0;

        param1[param2].DAT_4E = 0;

        if (iVar2 == 0)
            DAT_C6103 = 1;

        FUN_6BB40(param1, param2);
    }

    private void FUN_6B46C(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A6160[DAT_C6104](param1, param2);
    }

    private void FUN_6B4A8(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        ushort uVar2;
        sbyte sVar3;
        bool bVar4;

        uVar2 = DAT_C612E;

        if ((uVar2 & 0x1000) == 0)
        {
            if ((uVar2 & 0x4000) == 0)
            {
                if ((uVar2 & 0xa0) == 0)
                {
                    if ((uVar2 & 0x40) == 0)
                    {
                        if ((uVar2 & 0x2000) == 0)
                        {
                            if ((uVar2 & 0x8000) == 0 || param1[param2].DAT_4D < 1) goto LAB_6B67C;

                            GameManager.instance.FUN_5C94C(null, 0);
                            sVar3 = (sbyte)(param1[param2].DAT_4D - 1);
                        }
                        else
                        {
                            if ((param1[param2].DAT_4F + 4) / 5 - 1 <= param1[param2].DAT_4D) goto LAB_6B67C;

                            GameManager.instance.FUN_5C94C(null, 0);
                            sVar3 = (sbyte)(param1[param2].DAT_4D + 1);
                        }

                        param1[param2].DAT_4D = sVar3;
                        FUN_6BB40(param1, param2);
                        param1[param2].DAT_4E = 0;
                    }
                    else
                    {
                        DAT_C6104 = 0;
                        DAT_C6103 = 0;
                        DAT_C6102 = 0;
                        DAT_C6101--;
                        GameManager.instance.FUN_5C94C(null, 1);
                    }
                }
                else
                {
                    DAT_C6104 = 2;
                    DAT_C6106 = 0;
                    GameManager.instance.FUN_5C94C(null, 2);
                }

                goto LAB_6B67C;
            }

            sVar3 = (sbyte)(param1[param2].DAT_4E + 1);

            if (param1[param2].DAT_4C - 1 <= param1[param2].DAT_4E) goto LAB_6B67C;
        }
        else
        {
            sVar3 = (sbyte)(param1[param2].DAT_4E - 1);

            if (param1[param2].DAT_4E == 0)
            {
                bVar4 = FUN_6BC28();

                if (bVar4)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    DAT_C6103 = 1;
                    bVar1 = param1[param2].DAT_50;
                    param1[param2].DAT_58 = 0;
                    param1[param2].DAT_50 = param1[param2].DAT_5A;
                    param1[param2].DAT_5A = bVar1;
                    FUN_6CD1C(param1[param2], 0x10000, 0x10, 0x930000, 0xc20000);
                    FUN_6CD1C(param1[param2], 0x10001, 0x10, 0x7c0000, 0x950000);
                    suppliesRect.transform.SetSiblingIndex(7);
                    itemsRect.transform.SetSiblingIndex(8);
                }

                goto LAB_6B67C;
            }
        }

        param1[param2].DAT_4E = (byte)sVar3;
        GameManager.instance.FUN_5C94C(null, 0);
        LAB_6B67C:
        DAT_C610A = DialogManager.DAT_A593C[param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00 * 6 + 3];
    }

    private void FUN_6B6CC(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        int iVar2;
        bool bVar2;
        sbyte sVar3;
        byte bVar4;
        byte bVar5;
        sbyte sVar5;

        actionsRect.gameObject.SetActive(true);
        uVar1 = DAT_C612E;

        if ((uVar1 & 0x1000) == 0)
        {
            if ((uVar1 & 0x4000) == 0)
            {
                if ((uVar1 & 0x40) == 0)
                {
                    if ((uVar1 & 0xa0) == 0) goto LAB_6B9C0;

                    bVar4 = DAT_C6106;

                    if (bVar4 == 1)
                    {
                        actionsRect.gameObject.SetActive(false);
                        GameManager.instance.FUN_5C94C(null, 2);
                        DAT_C6104 = 3;
                        bVar5 = param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00;
                        DAT_C61FE = 30;
                        DAT_C61FD = 0;
                        DAT_C61FC = bVar5;
                        FUN_6CD1C(param1[param2], 0, 10, 0x930000, 0x2b60000);
                        FUN_6CD1C(param1[param2], 1, 10, 0x7c0000, -0x6a0000);
                        DAT_C610A = DialogManager.DAT_A593C[param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00 * 6 + 3];
                        goto LAB_6B9C0;
                    }

                    if (bVar4 < 2)
                    {
                        if (bVar4 == 0)
                        {
                            bVar2 = PTR_FUN_A6174[DialogManager.DAT_A593C[param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00 * 6] & 0xf]
                                    (DialogManager.DAT_A593C, param1[param2].DAT_38[param1[param2].DAT_4E].DAT_00);

                            if (!bVar2)
                            {
                                GameManager.instance.FUN_5C94C(null, 1);
                                DAT_C610A = 0x17a;
                            }
                            else
                            {
                                DAT_C6104 = 0;
                                actionsRect.gameObject.SetActive(false);
                                GameManager.instance.FUN_5C94C(null, 2);
                                iVar2 = FUN_6BAC4(param1, param2);
                                sVar3 = (sbyte)(GameManager.instance.DAT_9EAC[iVar2 + 1] - 1);
                                GameManager.instance.DAT_9EAC[iVar2 + 1] = (byte)sVar3;

                                if (sVar3 == 0)
                                {
                                    sVar3 = (sbyte)param1[param2].DAT_4C;
                                    param1[param2].DAT_4F--;
                                    bVar4 = (byte)(sVar3 - 1);
                                    param1[param2].DAT_4C = bVar4;

                                    if (bVar4 <= param1[param2].DAT_4E)
                                        param1[param2].DAT_4E = (byte)(sVar3 - 2);
                                }

                                if (param1[param2].DAT_4C == 0)
                                {
                                    param1[param2].DAT_4E = 0;
                                    param1[param2].DAT_4D--;
                                }

                                if (param1[param2].DAT_4F == 0)
                                {
                                    DAT_C6102 = 2;
                                    param1[param2].DAT_4D = 0;
                                }

                                FUN_6BB40(param1, param2);
                            }
                        }

                        goto LAB_6B9C0;
                    }

                    if (bVar4 != 2) goto LAB_6B9C0;
                    DAT_C6104 = 0;
                    bVar2 = FUN_6FEAC(true, null);
                    actionsRect.gameObject.SetActive(false);

                    if (bVar2)
                    {
                        GameManager.instance.FUN_5C94C(null, 2);
                        param1[param2].DAT_4D = 0;
                        FUN_6B3C8(param1, param2);
                        sVar5 = 0;

                        if (param1[param2].DAT_4C == 0)
                            sVar5 = -1;

                        param1[param2].DAT_4D = sVar5;
                        goto LAB_6B9C0;
                    }
                }
                else
                {
                    DAT_C6104 = 0;
                    actionsRect.gameObject.SetActive(false);
                }

                GameManager.instance.FUN_5C94C(null, 1);
            }
            else
            {
                if (DAT_C6106 < 2)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    DAT_C6106++;
                }
            }
        }
        else
        {
            if (DAT_C6106 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 0);
                DAT_C6106--;
            }
        }

        LAB_6B9C0:
        FUN_66C68(0, DAT_C6106);
    }

    private void FUN_6B9E0(InventoryWindow[] param1, int param2)
    {
        FUN_6A9F4();
        previewRect.gameObject.SetActive(true);

        if (DAT_C61FE == 0 && (DAT_C612E & 0xe0) != 0)
        {
            previewRect.gameObject.SetActive(false);
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
            DAT_C61FF &= 0xfe;
            FUN_6CD1C(param1[param2], 0, 10, 0x930000, 0xc20000);
            FUN_6CD1C(param1[param2], 1, 10, 0x7c0000, 0x950000);
            suppliesRect.transform.SetSiblingIndex(8);
            itemsRect.transform.SetSiblingIndex(7);
        }
    }

    private void FUN_6BA84(InventoryWindow[] param1, int param2)
    {
        if ((DAT_C612E & 0xe0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
        }
    }

    private int FUN_6BAC4(InventoryWindow[] param1, int param2)
    {
        int iVar1;
        int iVar2;
        uint uVar3;
        int iVar4;

        iVar4 = 0;
        iVar2 = param1[param2].DAT_4D * 5;

        while (iVar2 != 0)
        {
            if (GameManager.instance.DAT_9EAC[iVar4 + 1] != 0)
                iVar2--;

            iVar4 += 4;
        }

        uVar3 = param1[param2].DAT_4E;

        while (uVar3 != 0)
        {
            iVar2 = iVar4 + 4;
            iVar1 = GameManager.instance.DAT_9EAC[iVar4 + 5];
            iVar4 = iVar2;

            if (iVar1 != 0)
                uVar3--;
        }

        return iVar4;
    }

    private void FUN_6BB40(InventoryWindow[] param1, int param2)
    {
        uint uVar1;
        int iVar2;
        int puVar3;
        InventoryText[] aVar4;

        param1[param2].DAT_38 = new InventoryText[5];

        for (int i = 0; i < 5; i++) 
            param1[param2].DAT_38[i] = new InventoryText();

        FUN_6FAF0();
        puVar3 = 0;
        iVar2 = param1[param2].DAT_4D * 5;
        uVar1 = GameManager.instance.DAT_9ADE;

        while (0 < iVar2)
        {
            if (GameManager.instance.DAT_9EAC[puVar3 + 1] != 0)
                iVar2--;

            puVar3 += 4;
            uVar1--;
        }

        iVar2 = 0;
        aVar4 = param1[param2].DAT_38;

        while (uVar1-- != 0 && iVar2 < 5)
        {
            if (GameManager.instance.DAT_9EAC[puVar3 + 1] != 0)
            {
                aVar4[iVar2].DAT_00 = GameManager.instance.DAT_9EAC[puVar3];
                aVar4[iVar2].DAT_01 = GameManager.instance.DAT_9EAC[puVar3 + 1];
                aVar4[iVar2].DAT_02 = GameManager.instance.DAT_9EAC[puVar3 + 2];
                aVar4[iVar2].DAT_03 = GameManager.instance.DAT_9EAC[puVar3 + 3];
                iVar2++;
            }

            puVar3 += 4;
        }

        param1[param2].DAT_4C = (byte)iVar2;
    }

    private bool FUN_6BC28()
    {
        bool bVar1;
        uint uVar2;

        uVar2 = 0x2b;

        do
        {
            bVar1 = FUN_4A87C(11, uVar2);
            uVar2++;

            if (bVar1)
                return true;
        } while (uVar2 < 0x70);

        return false;
    }

    private bool FUN_6BC74(ushort[] param1, int param2)
    {
        return false;
    }

    private bool FUN_6BC7C(ushort[] param1, int param2)
    {
        byte bVar1;
        CriPlayer oVar2;
        int iVar2;
        uint uVar3;
        uint uVar4;

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar1 = (byte)param1[param2 + 1];

        if (bVar1 == 1)
        {
            uVar4 = (uint)(int)oVar2.maxHealth;

            if (oVar2.health < (short)uVar4)
            {
                iVar2 = 300;

                if (GameManager.instance.difficulty != _DIFFICULTY.Normal)
                    iVar2 = 600;

                uVar3 = (uint)(oVar2.health + iVar2);

                if (uVar4 < uVar3)
                    uVar3 = uVar4;

                oVar2.health = (short)uVar3;
                oVar2.FUN_4FE30();
                return true;
            }
        }
        else
        {
            if (1 < bVar1)
            {
                if (bVar1 == 2)
                {
                    if (oVar2.maxHealth <= oVar2.health)
                        return false;

                    oVar2.health = oVar2.maxHealth;
                }
                else
                {
                    if (bVar1 != 3)
                        return false;

                    if (oVar2.maxHealth <= oVar2.health && (oVar2.DAT_1C0 & 4) == 0)
                        return false;

                    oVar2.DAT_1C0 &= 0xfffffffb;
                    oVar2.health = oVar2.maxHealth;
                }

                oVar2.FUN_4FE30();
                return true;
            }

            if (bVar1 != 0)
                return false;

            if ((oVar2.DAT_1C0 & 4) != 0)
            {
                oVar2.DAT_1C0 &= 0xfffffffb;
                return true;
            }
        }

        return false;
    }

    private void FUN_6BDD4(InventoryWindow[] param1, int param2)
    {
        short sVar1;
        short sVar2;
        uint uVar3;
        Vector3Int vVar3;
        int iVar4;
        int iVar5;
        Vector2 local_28;

        DAT_C6294 = param1[param2].DAT_50;
        sVar1 = param1[param2].rect[0].DAT_0E;
        iVar4 = sVar1;
        sVar2 = param1[param2].rect[0].DAT_12;
        iVar5 = sVar2;

        if (5U < param1[param2].DAT_4F)
        {
            vVar3 = new Vector3Int(0x80, 0x80, 0x80);

            if (0 < param1[param2].DAT_4D)
                vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
            vVar3 = new Vector3Int(0x80, 0x80, 0x80);

            if (param1[param2].DAT_4D + 1 < (param1[param2].DAT_4F + 4) / 5)
                vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
        }

        //FUN_6ACDC
        uVar3 = 0;
        iVar5 -= 64;

        do
        {
            if (DAT_C6103 == 0 && param1[param2].DAT_4E == uVar3)
            {
                //...
                suppliesRect.content.GetChild((int)uVar3).GetComponent<Button>().Select();
            }

            uVar3++;
            iVar5 += 26;
        } while (uVar3 < 5);

        local_28 = new Vector2(sVar1 - 0x6b - 0x28, sVar2 - 0x60 - 0x62);
        FUN_6AF38((RectTransform)suppliesRect.transform, local_28);
    }

    private void FUN_6BFDC(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        short sVar2;
        ushort[] uVar3;
        int iVar4;
        InventoryText pbVar5;
        int iVar7;
        int iVar8;
        int iVar9;
        uint uVar10;
        Color32 local_30;

        uVar10 = 0;
        iVar9 = -53;
        iVar8 = -59;
        local_30 = new Color32(0x80, 0x80, 0x80, 0xff);
        iVar7 = param1[param2].rect[0].DAT_0E;
        sVar2 = param1[param2].rect[0].DAT_12;
        DAT_C6294 = param1[param2].DAT_50;

        do
        {
            pbVar5 = param1[param2].DAT_38[uVar10];

            if (pbVar5.DAT_01 != 0)
            {
                suppliesRect.content.GetChild((int)uVar10).gameObject.SetActive(true);
                iVar4 = sVar2 + iVar8;
                bVar1 = pbVar5.DAT_00;
                iVar8 += 26;
                suppliesRect.content.GetChild((int)uVar10).GetChild(0).GetComponent<Image>().sprite = sprites[(byte)DialogManager.DAT_A593C[bVar1 * 6] >> 4];
                uVar3 = FUN_71350(pbVar5);
                FUN_6750C(uVar3, 0, suppliesRect.content.GetChild((int)uVar10).GetComponentInChildren<Text>(), local_30);
                suppliesRect.content.GetChild((int)uVar10).GetComponentsInChildren<Text>()[1].text = pbVar5.DAT_01 + "/" + (DialogManager.DAT_A593C[bVar1 * 6] >> 8);
                iVar9 += 26;
            }
            else
                suppliesRect.content.GetChild((int)uVar10).gameObject.SetActive(false);

            uVar10++;
        } while (uVar10 < 5);
    }

    private void FUN_6C110(InventoryWindow[] param1, int param2)
    {
        bool bVar1;
        uint uVar2;
        int iVar3;

        FUN_6CC68(param1, param2);
        iVar3 = 0;
        uVar2 = 0x2b;

        do
        {
            bVar1 = FUN_4A87C(11, uVar2);

            if (bVar1)
                iVar3++;

            uVar2++;
        } while (uVar2 < 0x70);

        param1[param2].DAT_59 = (byte)iVar3;

        if (iVar3 == 0)
            param1[param2].DAT_57 = -1;
        else
            param1[param2].DAT_57 = 0;

        param1[param2].DAT_58 = 0;

        if (iVar3 == 0)
            DAT_C6103 = 0;

        DAT_C610A = 0;
    }

    private void FUN_6C1A8(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A617C[DAT_C6104](param1, param2);
    }

    private void FUN_6C1E4(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        ushort uVar2;
        sbyte sVar3;
        int iVar4;

        uVar2 = DAT_C612E;

        if ((uVar2 & 0x1000) == 0)
        {
            if ((uVar2 & 0x4000) == 0)
            {
                if ((uVar2 & 0xa0) == 0)
                {
                    iVar4 = 1;

                    if ((uVar2 & 0x40) == 0)
                    {
                        if ((uVar2 & 0x2000) == 0)
                        {
                            if ((uVar2 & 0x8000) == 0 || param1[param2].DAT_57 < 1) goto LAB_6C3A0;

                            sVar3 = (sbyte)(param1[param2].DAT_57 - 1);
                        }
                        else
                        {
                            if ((param1[param2].DAT_59 + 4) / 5 - 1 <= param1[param2].DAT_57) goto LAB_6C3A0;

                            sVar3 = (sbyte)(param1[param2].DAT_57 + 1);
                        }

                        param1[param2].DAT_57 = sVar3;
                        FUN_6CC68(param1, param2);
                        iVar4 = 0;
                        param1[param2].DAT_58 = 0;
                    }
                    else
                    {
                        DAT_C6104 = 0;
                        DAT_C6103 = 0;
                        DAT_C6102 = 0;
                        DAT_C6101--;
                        suppliesRect.transform.SetSiblingIndex(8);
                        itemsRect.transform.SetSiblingIndex(7);
                    }
                }
                else
                {
                    iVar4 = 2;
                    DAT_C6104 = 2;
                    DAT_C6106 = 0;
                }
            }
            else
            {
                if (param1[param2].DAT_56 - 1 <= param1[param2].DAT_58) goto LAB_6C3A0;

                param1[param2].DAT_58++;
                iVar4 = 0;
            }
        }
        else
        {
            if (param1[param2].DAT_58 == 0)
            {
                if (param1[param2].DAT_4F != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    DAT_C6103 = 0;
                    bVar1 = param1[param2].DAT_5A;
                    param1[param2].DAT_4E = 0;
                    param1[param2].DAT_5A = param1[param2].DAT_50;
                    param1[param2].DAT_50 = bVar1;
                    FUN_6CD1C(param1[param2], 0x10000, 0x10, 0x930000, 0xc20000);
                    FUN_6CD1C(param1[param2], 0x10001, 0x10, 0x7c0000, 0x950000);
                    suppliesRect.transform.SetSiblingIndex(8);
                    itemsRect.transform.SetSiblingIndex(7);
                }

                goto LAB_6C3A0;
            }

            param1[param2].DAT_58--;
            iVar4 = 0;
        }

        GameManager.instance.FUN_5C94C(null, iVar4);
        LAB_6C3A0:
        DAT_C610A = DialogManager.DAT_A593C[param1[param2].DAT_51[param1[param2].DAT_58] * 6 + 3];
    }

    private void FUN_6C3EC(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        byte bVar2;
        ushort uVar3;
        ushort uVar4;
        uint uVar5;
        uint uVar6;
        bool bVar7;
        int iVar8;
        bool bVar8;

        actionsRect.gameObject.SetActive(true);
        uVar3 = DAT_C612E;

        if ((uVar3 & 0x1000) == 0)
        {
            if ((uVar3 & 0x4000) == 0)
            {
                if ((uVar3 & 0x40) == 0)
                {
                    if ((uVar3 & 0xa0) != 0)
                    {
                        if (DAT_C6106 == 0)
                        {
                            bVar1 = param1[param2].DAT_51[param1[param2].DAT_58];
                            iVar8 = bVar1 * 6;

                            if ((byte)DialogManager.DAT_A593C[iVar8] == 0)
                            {
                                GameManager.instance.FUN_5C94C(null, 1);
                                uVar4 = 0x17b;
                            }
                            else
                            {
                                if ((byte)DialogManager.DAT_A593C[iVar8] != 1) goto LAB_6C738;

                                if (bVar1 == 88)
                                {
                                    actionsRect.gameObject.SetActive(false);
                                    GameManager.instance.FUN_5C94C(null, 2);
                                    DAT_C6100 = 2;
                                    DAT_C6104 = 0;
                                    DAT_C6103 = 0;
                                    DAT_C6102 = 0;
                                    DAT_C61FF |= 6;
                                    bVar8 = FUN_4A87C(0, 6);

                                    if (!bVar8)
                                    {
                                        uVar5 = FUN_4A87C(0, 0xa3) ? 1U : 0;
                                        uVar6 = FUN_4A87C(0, 0xcd) ? 1U : 0;

                                        if ((uVar5 | uVar6) != 0)
                                        {
                                            bVar8 = FUN_4A87C(0, 0xa3);

                                            if (bVar8)
                                            {
                                                DAT_C6200 = 6;
                                                DAT_C6201 = 16;
                                                DAT_C6202 = 91;
                                                return;
                                            }

                                            DAT_C6200 = 6;
                                            DAT_C6201 = 13;
                                            DAT_C6202 = bVar1;
                                            return;
                                        }

                                        bVar8 = FUN_4A87C(0, 4);
                                    }
                                    else
                                    {
                                        bVar8 = FUN_4A87C(0, 0xdc);

                                        if (bVar8)
                                        {
                                            DAT_C6200 = 6;
                                            DAT_C6201 = 13;
                                            DAT_C6202 = bVar1;
                                            return;
                                        }

                                        bVar8 = FUN_4A87C(0, 4);
                                    }

                                    if (!bVar8)
                                    {
                                        DAT_C6200 = 5;
                                        DAT_C6201 = 3;
                                        DAT_C6202 = 60;
                                        return;
                                    }

                                    DAT_C6200 = 6;
                                    DAT_C6201 = 7;
                                    DAT_C6202 = 82;
                                    return;
                                }

                                bVar7 = FUN_4A87C(6, (byte)DialogManager.DAT_A593C[iVar8 + 1]);

                                if (bVar7)
                                {
                                    GameManager.instance.FUN_5C94C(null, 2);
                                    FUN_4A7E8(2, 0x10, true);
                                    GameManager.instance.DAT_2A = 2;
                                    GameManager.instance.DAT_20 = (byte)DialogManager.DAT_A593C[iVar8 + 1];
                                    FUN_4A7E8(11, (byte)DialogManager.DAT_A593C[iVar8 + 1], false);

                                    if ((byte)DialogManager.DAT_A593C[iVar8 + 1] - 65U < 2)
                                        DAT_C61F8 |= 0x5003;

                                    goto LAB_6C738;
                                }

                                GameManager.instance.FUN_5C94C(null, 1);
                                uVar4 = 0x17b;
                            }
                        }
                        else
                        {
                            actionsRect.gameObject.SetActive(false);
                            GameManager.instance.FUN_5C94C(null, 2);
                            FUN_6CD1C(param1[param2], 0, 10, 0x7c0000, 0x2890000);
                            FUN_6CD1C(param1[param2], 1, 10, 0x930000, -0x6a0000);
                            DAT_C6104 = 3;
                            bVar2 = param1[param2].DAT_51[param1[param2].DAT_58];
                            DAT_C61FD = 0;
                            DAT_C61FE = 30;
                            DAT_C61FF = bVar2;
                            uVar4 = DialogManager.DAT_A593C[param1[param2].DAT_51[param1[param2].DAT_58] * 6 + 3];
                        }

                        DAT_C610A = uVar4;
                    }
                }
                else
                {
                    DAT_C6104 = 0;
                    GameManager.instance.FUN_5C94C(null, 1);
                    actionsRect.gameObject.SetActive(false);
                }

                goto LAB_6C738;
            }

            if (DAT_C6106 != 0) goto LAB_6C738;

            DAT_C6106 = 1;
        }
        else
        {
            if (DAT_C6106 == 0) goto LAB_6C738;

            DAT_C6106 = 0;
        }

        GameManager.instance.FUN_5C94C(null, 0);
        LAB_6C738:
        FUN_66C68(1, DAT_C6106);
    }

    private void FUN_6C75C(InventoryWindow[] param1, int param2)
    {
        FUN_6A9F4();
        previewRect.gameObject.SetActive(true);

        if (DAT_C61FE == 0 && (DAT_C612E & 0xe0) != 0)
        {
            previewRect.gameObject.SetActive(false);
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
            DAT_C61FF &= 0xfe;
            FUN_6CD1C(param1[param2], 0, 10, 0x7c0000, 0x950000);
            FUN_6CD1C(param1[param2], 1, 10, 0x930000, 0xc20000);
            itemsRect.transform.SetSiblingIndex(8);
            suppliesRect.transform.SetSiblingIndex(7);
        }
    }

    private void FUN_6C800(InventoryWindow[] param1, int param2)
    {
        if ((DAT_C612E & 0xe0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6104 = 0;
        }
    }

    private void FUN_6C840(InventoryWindow[] param1, int param2)
    {
        short sVar1;
        short sVar2;
        uint uVar3;
        Vector3Int vVar3;
        int iVar4;
        int iVar5;
        Vector2 local_28;

        DAT_C6294 = param1[param2].DAT_5A;
        sVar1 = param1[param2].rect[1].DAT_0E;
        iVar4 = sVar1;
        sVar2 = param1[param2].rect[1].DAT_12;
        iVar5 = sVar2;

        if (5 < param1[param2].DAT_59)
        {
            vVar3 = new Vector3Int(0x80, 0x80, 0x80);

            if (0 < param1[param2].DAT_57)
                vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
            vVar3 = new Vector3Int(0x80, 0x80, 0x80);

            if (param1[param2].DAT_57 + 1 < (param1[param2].DAT_59 + 4) / 5)
                vVar3 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
        }

        //FUN_6ACDC
        uVar3 = 0;
        iVar5 -= 64;

        do
        {
            if (DAT_C6103 == 1 && param1[param2].DAT_58 == uVar3)
            {
                //...
                itemsRect.content.GetChild((int)uVar3).GetComponent<Button>().Select();
            }

            uVar3++;
            iVar5 += 26;
        } while (uVar3 < 5);

        local_28 = new Vector2(sVar1 - 0x6b - 0x28, sVar2 - 0x60 - 0x62);
        FUN_6AF38((RectTransform)itemsRect.transform, local_28);
    }

    private void FUN_6CA4C(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        int iVar5;
        uint uVar6;
        int iVar7;
        int iVar8;
        int iVar9;

        DAT_C6294 = param1[param2].DAT_5A;
        iVar8 = param1[param2].rect[1].DAT_0E;
        bVar1 = param1[param2].DAT_56;
        iVar7 = param1[param2].rect[1].DAT_12;
        uVar6 = 0;

        if (bVar1 != 0)
        {
            iVar9 = -53;
            iVar5 = -59;

            do
            {
                iVar2 = param1[param2].DAT_51[uVar6] * 6;

                if ((byte)DialogManager.DAT_A593C[iVar2] == 0)
                    iVar3 = 9;
                else
                {
                    if ((byte)DialogManager.DAT_A593C[iVar2 + 1] == 0x2d)
                        iVar3 = 9;
                    else
                        iVar3 = 10;
                }

                itemsRect.content.GetChild((int)uVar6).gameObject.SetActive(true);
                itemsRect.content.GetChild((int)uVar6).GetChild(0).GetComponent<Image>().sprite = sprites[iVar3];
                FUN_67554(itemsRect.content.GetChild((int)uVar6).GetComponentInChildren<Text>(), DialogManager.DAT_A593C[iVar2 + 2], new Color32(0x80, 0x80, 0x80, 0xff));

                switch (param1[param2].DAT_51[uVar6])
                {
                    case 32:
                        uVar4 = GameManager.instance.DAT_9EE8;
                        break;
                    case 33:
                        uVar4 = GameManager.instance.DAT_9EE9;
                        break;
                    case 34:
                        uVar4 = GameManager.instance.DAT_9EEA;
                        break;
                    case 35:
                        uVar4 = GameManager.instance.DAT_9EEB;
                        break;
                    default:
                        goto LAB_6CB64;
                    case 43:
                        uVar4 = GameManager.instance.DAT_A0E0;
                        break;
                }

                //...
                LAB_6CB64:
                iVar9 += 26;
                uVar6++;
                iVar5 += 26;
            } while (uVar6 < bVar1);

            while (uVar6 < 5)
            {
                itemsRect.content.GetChild((int)uVar6).gameObject.SetActive(false);
                uVar6++;
            }
        }
        else
        {
            itemsRect.content.GetChild(0).gameObject.SetActive(false);
            itemsRect.content.GetChild(1).gameObject.SetActive(false);
            itemsRect.content.GetChild(2).gameObject.SetActive(false);
            itemsRect.content.GetChild(3).gameObject.SetActive(false);
            itemsRect.content.GetChild(4).gameObject.SetActive(false);
        }

        FUN_67AD8();
    }

    private void FUN_6CC68(InventoryWindow[] param1, int param2)
    {
        bool bVar1;
        int iVar2;
        uint uVar3;

        param1[param2].DAT_51 = new byte[5];
        iVar2 = param1[param2].DAT_57 * 5;
        uVar3 = 0x2b;

        while (0 < iVar2)
        {
            bVar1 = FUN_4A87C(11, uVar3);

            if (bVar1)
                iVar2--;

            uVar3++;
        }

        iVar2 = 0;

        do
        {
            if (0x6f < uVar3) break;

            bVar1 = FUN_4A87C(11, uVar3);

            if (bVar1)
            {
                param1[param2].DAT_51[iVar2] = (byte)uVar3;
                iVar2++;
            }

            uVar3++;
        } while (iVar2 < 5);

        param1[param2].DAT_56 = (byte)iVar2;
    }

    private void FUN_6CD1C(InventoryWindow param1, uint param2, int param3, int param4, int param5)
    {
        InventoryRect puVar1;

        param1.DAT_5B++;
        puVar1 = param1.rect[param2 & 0xffff];

        if (param3 == 0)
            return; //trap(0x1c00)

        if (param3 == -1 && param4 - (puVar1.DAT_0E << 0x10 | (ushort)puVar1.DAT_0C) == -0x80000000)
            return; //trap(0x1800)

        if (param3 == 0)
            return; //trap(0x1c00)

        if (param3 == -1 && param5 - (puVar1.DAT_12 << 0x10 | (ushort)puVar1.DAT_10) == -0x80000000)
            return; //trap(0x1800)

        puVar1.DAT_01 = (sbyte)param3;
        puVar1.DAT_02 = (byte)(param2 >> 0x10);
        puVar1.DAT_14 = (short)param4;
        puVar1.DAT_16 = (short)(param4 >> 0x10);
        puVar1.DAT_18 = (short)param5;
        puVar1.DAT_1A = (short)(param5 >> 0x10);
        puVar1.DAT_00 = true;
        puVar1.DAT_04 = (short)(((short)param4 - puVar1.DAT_0C) / param3);
        puVar1.DAT_06 = (short)(((short)(param4 >> 0x10) - puVar1.DAT_0E) / param3);
        puVar1.DAT_08 = (short)(((short)param5 - puVar1.DAT_10) / param3);
        puVar1.DAT_0A = (short)(((short)(param5 >> 0x10) - puVar1.DAT_12) / param3);
    }

    private void FUN_6CDD8(InventoryWindow[] param1, int param2)
    {
        sbyte sVar1;
        byte bVar2;
        int iVar3;
        int iVar4;
        InventoryRect pcVar5;
        int iVar6;

        iVar6 = 0;

        if (iVar6 < 2)
        {
            do
            {
                pcVar5 = param1[param2].rect[iVar6];

                if (pcVar5.DAT_00)
                {
                    if (pcVar5.DAT_02 == 0)
                    {
                        pcVar5.DAT_0C += pcVar5.DAT_04;
                        pcVar5.DAT_0E += pcVar5.DAT_06;
                        sVar1 = pcVar5.DAT_01;
                        pcVar5.DAT_01 = (sbyte)(sVar1 - 1);
                        pcVar5.DAT_10 += pcVar5.DAT_08;
                        pcVar5.DAT_12 += pcVar5.DAT_0A;

                        if ((sbyte)(sVar1 - 1) == 0)
                        {
                            param1[param2].DAT_5B--;
                            pcVar5.DAT_00 = false;
                            pcVar5.DAT_0C = pcVar5.DAT_14;
                            pcVar5.DAT_0E = pcVar5.DAT_16;
                            pcVar5.DAT_10 = pcVar5.DAT_18;
                            pcVar5.DAT_12 = pcVar5.DAT_1A;
                        }
                    }
                    else
                    {
                        if (pcVar5.DAT_02 == 1)
                        {
                            bVar2 = (byte)(pcVar5.DAT_03 + 1 & 31);
                            pcVar5.DAT_03 = bVar2;
                            iVar3 = Utilities.ccos(bVar2 << 7);
                            iVar4 = Utilities.csin(pcVar5.DAT_03 << 7);
                            sVar1 = pcVar5.DAT_01;
                            pcVar5.DAT_0E = (short)((iVar3 >> 8) + 0x88);
                            pcVar5.DAT_12 = (short)((iVar4 >> 7) + 0xac);
                            pcVar5.DAT_01 = (sbyte)(sVar1 - 1);

                            if ((sbyte)(sVar1 - 1) == 0)
                            {
                                param1[param2].DAT_5B--;
                                pcVar5.DAT_00 = false;
                            }
                        }
                    }
                }

                iVar6++;
            } while (iVar6 < 2);
        }
    }

    private void FUN_6CF38()
    {
        //...
        PTR_FUN_A842C[DAT_C6102](DAT_C6130, 0);
    }

    private void FUN_6D0C4(InventoryWindow[] param1, int param2)
    {
        uint uVar1;

        DAT_C6102++;
        param1[param2].DAT_04 = (byte)(GameManager.instance.DAT_A0E2 >> 8);
        param1[param2].DAT_05 = (byte)GameManager.instance.DAT_A0E2;

        if ((DAT_C61FF & 4) != 0)
        {
            param1[param2].DAT_04 = DAT_C6200;
            param1[param2].DAT_05 = DAT_C6201;
            DAT_C6103 = (byte)(FUN_6E4F8(DAT_C6200, DAT_C6201) >> 0x10);
        }

        if (param1[param2].DAT_04 != 0)
            param1[param2].DAT_03 |= 1;

        uVar1 = FUN_6E4F8(GameManager.instance.DAT_9AA0 >> 8, GameManager.instance.DAT_9AA0 & 0xffU);
        param1[param2].DAT_00 = (sbyte)(uVar1 >> 0x10);
        param1[param2].DAT_01 = (byte)(uVar1 >> 8);
        param1[param2].DAT_02 = (byte)uVar1;

        if ((DAT_C61FF & 2) != 0)
        {
            uVar1 = FUN_6E4F8(param1[param2].DAT_04, param1[param2].DAT_05);
            param1[param2].DAT_00 = (sbyte)(uVar1 >> 0x10);
            param1[param2].DAT_04 = (byte)(uVar1 >> 8);
            param1[param2].DAT_05 = (byte)uVar1;
        }

        FUN_6E424(param1, param2);
    }

    private void FUN_6D224(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        int iVar2;
        int iVar3;

        uVar1 = DAT_C612E;

        if ((uVar1 & 0x4000) == 0)
        {
            if ((uVar1 & 0x1000) == 0)
            {
                if ((uVar1 & 0x40) == 0)
                    return;

                GameManager.instance.FUN_5C94C(null, 1);
                DAT_C6102 = 0;
                DAT_C6101--;
                DAT_C61FF &= 0xf9;
                return;
            }

            iVar3 = -1;
        }
        else
            iVar3 = 1;

        iVar2 = FUN_6E3B4(param1[param2], iVar3);

        if (-1 < iVar2)
        {
            GameManager.instance.FUN_5C94C(null, 0);
            param1[param2].DAT_00 = (sbyte)iVar2;
        }
    }

    private int FUN_6E3B4(InventoryWindow param1, int param2)
    {
        int iVar1;
        int iVar2;

        iVar2 = 0;
        iVar1 = param1.DAT_00 + param2;

        do
        {
            if (iVar1 < 0)
            {
                iVar1 = 0;
                iVar2 = 1;
            }
            else
            {
                if (iVar1 < 7)
                {
                    if (param1.DAT_06[iVar1] != 0)
                        iVar2 = 2;
                }
                else
                {
                    iVar1 = 6;
                    iVar2 = 1;
                }
            }

            iVar1 += param2;
        } while (iVar2 == 0);

        iVar1 -= param2;

        if (iVar2 != 2)
            iVar1 = -1;

        return iVar1;
    }

    private void FUN_6E424(InventoryWindow[] param1, int param2)
    {
        UNK_CLASS puVar1;
        uint uVar2;
        uint uVar3;
        uint uVar4;
        UNK_CLASS[] puVar5;
        uint uVar6;

        uVar6 = 0;

        do
        {
            uVar2 = FUN_4A87C(11, uVar6 + 0x24) ? 1U : 0;
            puVar5 = PTR_DAT_A83EC[uVar6];
            uVar4 = 0;

            if (uVar2 == 0)
            {
                do
                {
                    if (DAT_A8408[uVar6] <= uVar4) break;

                    puVar1 = puVar5[uVar4];
                    uVar4++;
                    uVar3 = FUN_4A87C(12, puVar1.DAT_08) ? 1U : 0;
                    uVar2 |= uVar3;
                } while (uVar2 == 0);
            }

            param1[param2].DAT_06[uVar6] = (byte)uVar2;
            uVar6++;

            if (6 < uVar6)
                return;
        } while (true);
    }

    private uint FUN_6E4F8(int param1, uint param2)
    {
        bool bVar1;
        uint uVar2;
        uint uVar3;
        int iVar4;
        bool bVar4;

        iVar4 = param1 - 1;

        switch (iVar4)
        {
            case 0:
                uVar2 = (uint)iVar4 * 0x10000;

                if (param2 == 0x14)
                {
                    bVar1 = FUN_4A87C(12, 14);
                    uVar2 = (uint)iVar4 * 0x10000;

                    if (bVar1)
                        param2 = 0xe;
                }

                goto LAB_6E6A8;
            case 2:
                if (param2 != 0xd)
                {
                    uVar2 = (uint)iVar4 * 0x10000;

                    if (param2 == 0xe)
                    {
                        bVar1 = FUN_4A87C(12, 0x25);
                        uVar2 = (uint)iVar4 * 0x10000;

                        if (bVar1)
                            param2 = 9;
                    }

                    goto LAB_6E6A8;
                }

                uVar3 = 0x26;
                LAB_6E670:
                bVar1 = FUN_4A87C(12, uVar3);
                uVar2 = (uint)iVar4 << 0x10;

                if (bVar1)
                    param2 = 0xa;

                goto LAB_6E6A8;
            case 3:
                if (8 < param2)
                    iVar4 = param1;

                uVar2 = (uint)iVar4 << 0x10;

                if (param2 != 0) goto LAB_6E6A8;

                iVar4 = 0;
                break;
            case 4:
                if (param2 == 0x10)
                {
                    bVar4 = FUN_4A87C(12, 0x44);
                    uVar2 = 0x50000;

                    if (bVar4)
                        param2 = 0xb;

                    goto LAB_6E6A8;
                }

                if (0x10 < param2)
                {
                    uVar2 = 0x50000;

                    if (param2 == 0x11)
                    {
                        bVar4 = FUN_4A87C(12, 0x3c);
                        uVar2 = 0x50000;

                        if (bVar4)
                            param2 = 3;
                    }

                    goto LAB_6E6A8;
                }

                uVar2 = 0x50000;

                if (param2 != 0xa) goto LAB_6E6A8;

                iVar4 = 6;
                break;
            case 5:
                iVar4 = 6;

                if (param2 == 0x13)
                {
                    uVar3 = 0x55;
                    goto LAB_6E670;
                }

                uVar2 = 0x60000;

                if (param2 != 0x15) goto LAB_6E6A8;

                bVar1 = FUN_4A87C(12, 0x50);
                uVar2 = 0x60000;

                if (!bVar1) goto LAB_6E6A8;

                param2 = 5;
                break;
        }

        uVar2 = (uint)iVar4 << 0x10;
        LAB_6E6A8:
        return uVar2 | (uint)param1 << 8 | param2;
    }

    private void FUN_6E898()
    {
        PTR_FUN_A88D0[DAT_C6102](DAT_C6130, 0);
        //FUN_6F494
    }

    private void FUN_6E8F4(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        byte bVar3;
        byte[] aVar4;
        //FUN_601A4

        if ((uint)(int)GameManager.instance.DAT_2E < 8)
            param1[param2].DAT_34 = 0;
        else
        {
            bVar3 = 1;

            if (12 < (uint)(int)GameManager.instance.DAT_2E)
                bVar3 = 2;

            param1[param2].DAT_34 = bVar3;
        }

        DAT_C6103 = 0;
        DAT_C6102++;
        aVar4 = DAT_C62B0[GameManager.instance.DAT_2E];
        param1[param2].ARRY_00 = aVar4;
        param1[param2].BDAT_38 = (byte)(GameManager.instance.DAT_9AA0 >> 8);
        param1[param2].DAT_39 = (byte)GameManager.instance.DAT_9AA0;
        FUN_6FA30(param1[param2]);
        FUN_6FAF0();
        bVar1 = aVar4[1];
        param1[param2].DAT_07 = -1;
        param1[param2].DAT_04 = (byte)((bVar1 + 4) / 5);
        bVar1 = GameManager.instance.DAT_9ADE;
        param1[param2].DAT_1F = -1;
        param1[param2].DAT_1C = (byte)((bVar1 + 4) / 5);
        FUN_6FBE8(param1[param2], 0);
        FUN_6FBE8(param1[param2], 1);
    }

    private void FUN_6EA48(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A88D8[DAT_C6103](param1, param2);
    }

    private void FUN_6EA84(InventoryWindow[] param1, int param2)
    {
        Vector3Int vVar1;
        Vector3Int vVar2;
        Vector3Int vVar3;

        //...
        DAT_C610A = 0;
        PTR_FUN_A88E0[DAT_C6104](param1, param2);
        DAT_C6294 = 1;
        vVar1 = FUN_6FE88(param1[param2].DAT_34, 0x40);
        vVar2 = FUN_6FE88(param1[param2].DAT_34, 0x80);
        vVar3 = GameManager.instance.FUN_71BF8(vVar1, vVar2, 4);
        //FUN_6AF38
    }

    private void FUN_6EB8C(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        sbyte sVar2;

        uVar1 = DAT_C612E;

        if ((uVar1 & 0x4000) == 0)
        {
            if ((uVar1 & 0x8000) == 0)
            {
                if ((uVar1 & 0x2000) == 0)
                {
                    if ((uVar1 & 0xa0) == 0)
                    {
                        if ((uVar1 & 0x40) == 0)
                            return;

                        GameManager.instance.FUN_5C94C(null, 1);
                        sVar2 = 3;

                        if (param1[param2].DAT_36 != 2)
                        {
                            param1[param2].DAT_36 = 2;
                            return;
                        }
                    }
                    else
                    {
                        GameManager.instance.FUN_5C94C(null, 2);
                        sVar2 = (sbyte)(param1[param2].DAT_36 + 1);
                    }

                    DAT_C6104 = (byte)sVar2;
                }
                else
                {
                    if (param1[param2].DAT_36 < 2U)
                    {
                        GameManager.instance.FUN_5C94C(null, 0);
                        param1[param2].DAT_36++;
                    }
                }
            }
            else
            {
                if (param1[param2].DAT_36 != 0)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    param1[param2].DAT_36--;
                }
            }
        }
        else
        {
            GameManager.instance.FUN_5C94C(null, 0);
            DAT_C6104 = 0;
            DAT_C6103++;
            param1[param2].DAT_35 = 0;
            param1[param2].BDAT_06 = 0;
            param1[param2].DAT_1F = -1;
            param1[param2].DAT_07 = -1;
        }
    }

    private void FUN_6ECB8(InventoryWindow[] param1, int param2)
    {
        DAT_C6104 = 0;
        param1[param2].DAT_1E = 0;
        param1[param2].BDAT_06 = 0;
        param1[param2].DAT_1D = 0;
        param1[param2].DAT_05 = 0;
        param1[param2].DAT_1F = -1;
        param1[param2].DAT_07 = -1;
        FUN_6FEAC(false, param1[param2]);
        FUN_6FEAC(true, param1[param2]);
        FUN_6FA30(param1[param2]);
        FUN_6FAF0();
        FUN_6FBE8(param1[param2], 0);
        FUN_6FBE8(param1[param2], 1);
    }

    private void FUN_6ED34(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        bool bVar2;
        int iVar3;
        Vector3Int vVar3;
        Vector3Int vVar4;
        Vector3Int vVar5;
        uint uVar5;
        byte[] aVar6;
        int puVar6;
        uint uVar7;
        int iVar8;
        byte[] aVar8;
        uint uVar9;
        uint uVar10;
        uint uVar11;
        byte[] local_48 = new byte[8];

        uVar11 = param1[param2].DAT_34;
        DAT_C6294 = 1;
        //memset
        uVar10 = 0;
        aVar6 = PTR_DAT_A88B8[uVar11];
        puVar6 = 0;
        uVar7 = DAT_A886C[uVar11 * 2 + 1];
        uVar9 = DAT_A886C[uVar11 * 2];
        uVar5 = 0;

        if (uVar7 != 0)
        {
            iVar8 = 0x5e;

            do
            {
                if (7 < uVar5) break;

                bVar2 = FUN_4A87C(9, uVar9);

                if (bVar2)
                {
                    uVar10++;
                    iVar3 = GameManager.instance.FUN_6E848(aVar6[puVar6], aVar6[puVar6 + 1]);
                    //FUN_6750C
                    iVar8 += 0x1a;
                }

                uVar9++;
                puVar6 += 4;
                uVar7--;
                uVar5++;
            } while (uVar7 != 0);
        }

        if (DAT_C6105 == 0)
        {
            DAT_C6105 = 1;
            uVar5 = 0;

            if (uVar10 != 0)
            {
                puVar6 = 0;

                do
                {
                    if (local_48[puVar6] == param1[param2].BDAT_38 &&
                        local_48[puVar6 + 1] == param1[param2].DAT_39) break;

                    uVar5++;
                    puVar6 += 4;
                } while (uVar5 < uVar10);
            }

            param1[param2].DAT_37 = (byte)uVar5;
        }

        //...
        vVar3 = FUN_6FE88(param1[param2].DAT_34, 0x40);
        vVar4 = FUN_6FE88(param1[param2].DAT_34, 0x80);
        vVar5 = GameManager.instance.FUN_71BF8(vVar3, vVar4, 4);
        //...
        uVar1 = DAT_C612E;

        if ((uVar1 & 0x1000) == 0)
        {
            if ((uVar1 & 0x4000) == 0)
            {
                if ((uVar1 & 0xa0) == 0)
                {
                    if ((uVar1 & 0x40) != 0)
                    {
                        GameManager.instance.FUN_5C94C(null, 1);
                        DAT_C6104 = 0;
                        DAT_C6105 = 0;
                    }
                }
                else
                {
                    GameManager.instance.FUN_5C94C(null, 2);
                    DAT_C6104 = 0;
                    DAT_C6105 = 0;
                    iVar8 = param1[param2].DAT_37 * 4;
                    param1[param2].BDAT_38 = local_48[param1[param2].DAT_37];
                    param1[param2].DAT_39 = local_48[iVar8 + 1];
                    aVar8 = DAT_C62B0[local_48[iVar8 + 2]];
                    param1[param2].ARRY_00 = aVar8;
                    param1[param2].DAT_04 = (byte)((aVar8[1] + 7) >> 3);
                    param1[param2].DAT_07 = -1;
                    param1[param2].DAT_1F = -1;
                    FUN_6FBE8(param1[param2], 0);
                }
            }
            else
            {
                if (param1[param2].DAT_37 < uVar10 - 1)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    param1[param2].DAT_37++;
                }
            }
        }
        else
        {
            if (param1[param2].DAT_37 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 0);
                param1[param2].DAT_37--;
            }
        }
    }

    private void FUN_6F0E8(InventoryWindow[] param1, int param2)
    {
        GameManager.instance.DAT_2A = 2;
        param1[param2].DAT_35 = 0;
        DAT_C6102 = 0;
        FUN_6AC20();
        ((CriPlayer)SceneManager.instance.DAT_27C[10]).FUN_50CC8();
    }

    private void FUN_6F12C(InventoryWindow[] param1, int param2)
    {
        sbyte sVar1;
        ushort uVar2;
        byte bVar3;
        int puVar4;
        uint uVar5;
        int puVar6;
        byte bVar7;

        uVar5 = param1[param2].DAT_35;
        uVar2 = DAT_C612E;

        if (uVar5 == 0) FUN_6F168(ref param1[param2].DAT_04, ref param1[param2].DAT_05, ref param1[param2].BDAT_06, ref param1[param2].DAT_07);
        else FUN_6F168(ref param1[param2].DAT_1C, ref param1[param2].DAT_1D, ref param1[param2].DAT_1E, ref param1[param2].DAT_1F);

        void FUN_6F168(ref byte REF_00, ref byte REF_01, ref sbyte REF_02, ref sbyte REF_03)
        {
            if ((uVar2 & 0x1000) == 0)
            {
                if ((uVar2 & 0x4000) == 0)
                {
                    if ((uVar2 & 0xa0) == 0)
                    {
                        if ((uVar2 & 0x40) == 0)
                        {
                            if ((uVar2 & 0x2000) == 0)
                            {
                                if ((uVar2 & 0x8000) == 0 || -1 < REF_03 || REF_01 == 0) goto LAB_6F42C;

                                GameManager.instance.FUN_5C94C(null, 0);
                                bVar3 = (byte)(REF_01 - 1);
                            }
                            else
                            {
                                if (-1 < REF_03 || REF_00 - 1 <= REF_01) goto LAB_6F42C;

                                GameManager.instance.FUN_5C94C(null, 0);
                                bVar3 = (byte)(REF_01 + 1);
                            }

                            REF_01 = bVar3;
                            FUN_6FBE8(param1[param2], param1[param2].DAT_35);
                            REF_02 = 0;
                        }
                        else
                        {
                            if (param1[param2].DAT_07 < 0)
                            {
                                if (param1[param2].DAT_1F < 0)
                                {
                                    DAT_C6103 = 0;
                                    param1[param2].DAT_36 = 0;
                                }
                                else
                                {
                                    sVar1 = param1[param2].DAT_1F;
                                    param1[param2].DAT_35 = 1;
                                    param1[param2].DAT_1F = -1;
                                    param1[param2].DAT_1E = sVar1;
                                }
                            }
                            else
                            {
                                sVar1 = param1[param2].DAT_07;
                                param1[param2].DAT_35 = 0;
                                param1[param2].DAT_07 = -1;
                                param1[param2].BDAT_06 = sVar1;
                            }

                            GameManager.instance.FUN_5C94C(null, 1);
                        }
                    }
                    else
                    {
                        REF_03 = REF_02;

                        if (param1[param2].DAT_07 < 0 || param1[param2].DAT_1F < 0)
                        {
                            bVar3 = (byte)(param1[param2].DAT_35 ^ 1);
                            param1[param2].DAT_35 = bVar3;

                            if (bVar3 == 0) param1[param2].BDAT_06 = 0;
                            else param1[param2].DAT_1E = 0;
                        }
                        else
                        {
                            puVar6 = 4 + (param1[param2].DAT_05 * 5 + param1[param2].DAT_07) * 4;
                            puVar4 = (param1[param2].DAT_1D * 5 + param1[param2].DAT_1F) * 4;
                            bVar7 = param1[param2].ARRY_00[puVar6];
                            param1[param2].ARRY_00[puVar6] = GameManager.instance.DAT_9EAC[puVar4];
                            GameManager.instance.DAT_9EAC[puVar4] = bVar7;
                            bVar7 = param1[param2].ARRY_00[puVar6 + 1];
                            param1[param2].ARRY_00[puVar6 + 1] = GameManager.instance.DAT_9EAC[puVar4 + 1];
                            GameManager.instance.DAT_9EAC[puVar4 + 1] = bVar7;
                            bVar7 = param1[param2].ARRY_00[puVar6 + 2];
                            param1[param2].ARRY_00[puVar6 + 2] = GameManager.instance.DAT_9EAC[puVar4 + 2];
                            GameManager.instance.DAT_9EAC[puVar4 + 2] = bVar7;
                            bVar7 = param1[param2].ARRY_00[puVar6 + 3];
                            param1[param2].ARRY_00[puVar6 + 3] = GameManager.instance.DAT_9EAC[puVar4 + 3];
                            GameManager.instance.DAT_9EAC[puVar4 + 3] = bVar7;
                            param1[param2].DAT_1F = -1;
                            param1[param2].DAT_07 = -1;
                            FUN_6FBE8(param1[param2], 0);
                            FUN_6FBE8(param1[param2], 1);
                        }

                        GameManager.instance.FUN_5C94C(null, 2);
                    }

                    goto LAB_6F42C;
                }

                bVar3 = (byte)(REF_02 + 1);

                if (3U < (byte)REF_02)
                {
                    if (uVar5 == 0)
                    {
                        param1[param2].DAT_35 = 1;
                        param1[param2].DAT_1E = 0;
                        GameManager.instance.FUN_5C94C(null, 0);
                    }

                    goto LAB_6F42C;
                }

                REF_02 = (sbyte)bVar3;
            }
            else
            {
                bVar3 = (byte)(REF_02 - 1);

                if (REF_02 != 0)
                    REF_02 = (sbyte)bVar3;
                else
                {
                    if (uVar5 == 0)
                    {
                        DAT_C6103--;
                        param1[param2].DAT_36 = 0;
                    }
                    else
                        param1[param2].BDAT_06 = 4;

                    param1[param2].DAT_35 = 0;
                }
            }

            GameManager.instance.FUN_5C94C(null, 0);

            LAB_6F42C:;
            //...
        }
    }

    private void FUN_6FA30(InventoryWindow param1)
    {
        uint uVar1;
        int iVar2;
        int iVar3;
        uint uVar4;
        uint uVar5;

        uVar5 = param1.ARRY_00[1];
        uVar4 = 0;

        if (uVar5 != 1)
        {
            iVar3 = 0;

            do
            {
                uVar1 = uVar4;

                if (param1.ARRY_00[iVar3 + 5] == 0)
                {
                    do
                    {
                        uVar1++;

                        if (uVar5 <= uVar1) goto LAB_6FAD8;

                        iVar2 = (int)(uVar1 * 4);
                    } while (param1.ARRY_00[iVar2 + 5] == 0);

                    param1.ARRY_00[iVar3 + 4] = param1.ARRY_00[iVar2 + 4];
                    param1.ARRY_00[uVar1 * 4 + 5] = 0;
                }

                LAB_6FAD8:
                uVar4++;
                iVar3 += 4;
            } while (uVar4 < uVar5 - 1);
        }
    }

    public void FUN_6FAF0()
    {
        int iVar2;
        uint uVar3;
        int iVar4;
        uint uVar5;

        uVar5 = 0;

        if (GameManager.instance.DAT_9ADE != 1)
        {
            iVar4 = 0;

            do
            {
                if (GameManager.instance.DAT_9EAC[iVar4 + 1] == 0)
                {
                    uVar3 = uVar5 + 1;

                    if (uVar3 < GameManager.instance.DAT_9ADE)
                    {
                        do
                        {
                            iVar2 = (int)uVar3 * 4;

                            if (GameManager.instance.DAT_9EAC[iVar2 + 1] != 0)
                            {
                                GameManager.instance.DAT_9EAC[iVar4] = GameManager.instance.DAT_9EAC[iVar2];
                                GameManager.instance.DAT_9EAC[uVar3 * 4 + 1] = 0;
                                break;
                            }

                            uVar3++;
                        } while (uVar3 < GameManager.instance.DAT_9ADE);
                    }
                }

                uVar5++;
                iVar4 += 4;
            } while (uVar5 < GameManager.instance.DAT_9ADE - 1U);
        }
    }

    private void FUN_6FBE8(InventoryWindow param1, int param2)
    {
        int iVar2;
        byte[] aVar2;
        uint uVar4;

        //memset

        if (param2 == 0)
        {
            aVar2 = param1.ARRY_00;
            iVar2 = 4;
        }
        else
        {
            aVar2 = GameManager.instance.DAT_9EAC;
            iVar2 = 0;
        }

        uVar4 = 0;
        //...
    }

    private byte FUN_6FCA8(int param1)
    {
        switch (param1)
        {
            case 18:
            case 27:
                return 1;
            case 19:
            case 28:
                return 4;
            case 20:
            case 29:
                return 7;
            case 21:
            case 31:
                return 29;
            default:
                return 1;
            case 30:
                return 10;
        }
    }

    private Vector3Int FUN_6FE88(uint param1, uint param2)
    {
        uint uVar1;

        if (param1 != 2)
            uVar1 = param2 << (int)((param1 & 3) << 3);
        else
            uVar1 = param2 << 8 | param2;

        return new Vector3Int((byte)uVar1, (byte)(uVar1 >> 8), (byte)(uVar1 >> 0x10));
    }

    private bool FUN_6FEAC(bool param1, InventoryWindow param2)
    {
        byte bVar1;
        bool bVar2;
        sbyte sVar3;
        uint uVar4;
        byte bVar5;
        int pbVar6;
        uint uVar7;
        uint uVar8;
        int pbVar9;
        uint uVar10;
        uint uVar11;
        int pbVar12;
        bool bVar13;
        byte[] aVar13;

        bVar13 = false;

        if (!param1)
        {
            bVar1 = param2.ARRY_00[1];
            aVar13 = param2.ARRY_00;
            pbVar12 = 4;
        }
        else
        {
            aVar13 = GameManager.instance.DAT_9EAC;
            pbVar12 = 0;
            bVar1 = GameManager.instance.DAT_9ADE;
        }

        uVar11 = bVar1;
        uVar10 = 0;
        pbVar9 = pbVar12;

        if (uVar11 != 1)
        {
            do
            {
                uVar8 = aVar13[pbVar9];
                bVar1 = aVar13[pbVar9 + 2];

                if (aVar13[pbVar9 + 1] < (uint)DialogManager.DAT_A593C[uVar8 * 6] >> 8)
                {
                    uVar4 = (uint)(DialogManager.DAT_A593C[uVar8 * 6] >> 8) - aVar13[pbVar9 + 1];
                    uVar7 = uVar10 + 1;

                    if (uVar4 != 0)
                    {
                        pbVar6 = pbVar12 + (int)uVar7 * 4;

                        do
                        {
                            if (uVar11 <= uVar7) break;

                            if (aVar13[pbVar6 + 1] != 0 && aVar13[pbVar6] == uVar8)
                            {
                                if (uVar8 == 0x14)
                                {
                                    bVar2 = bVar1 < 9U;

                                    if (8U < aVar13[pbVar6 + 2])
                                    {
                                        if (bVar2)
                                        {
                                            bVar5 = 0;

                                            if (aVar13[pbVar6 + 2] == bVar1)
                                                bVar5 = bVar1;
                                        }
                                        else
                                        {
                                            bVar5 = bVar1;

                                            if ((uint)bVar1 < aVar13[pbVar6 + 2])
                                                bVar5 = aVar13[pbVar6 + 2];
                                        }
                                    }
                                    else
                                    {
                                        bVar5 = 0;

                                        if (aVar13[pbVar6 + 2] == bVar1)
                                            bVar5 = bVar1;
                                    }
                                }
                                else
                                {
                                    if (uVar8 != 30)
                                    {
                                        bVar5 = 0;

                                        if (aVar13[pbVar6 + 2] == bVar1)
                                            bVar5 = bVar1;
                                    }

                                    bVar2 = bVar1 < 12U;

                                    if (aVar13[pbVar6 + 2] < 12U)
                                    {
                                        bVar5 = 0;

                                        if (aVar13[pbVar6 + 2] == bVar1)
                                            bVar5 = bVar1;
                                    }
                                    else if (bVar2)
                                    {
                                        bVar5 = 0;

                                        if (aVar13[pbVar6 + 2] == bVar1)
                                            bVar5 = bVar1;
                                    }
                                    else
                                    {
                                        bVar5 = bVar1;

                                        if ((uint)bVar1 < aVar13[pbVar6 + 2])
                                            bVar5 = aVar13[pbVar6 + 2];
                                    }
                                }

                                if (bVar5 != 0)
                                {
                                    aVar13[pbVar9 + 2] = bVar5;
                                    bVar5 = aVar13[pbVar6 + 1];
                                    bVar13 = true;

                                    if (uVar4 < bVar5)
                                    {
                                        sVar3 = (sbyte)uVar4;
                                        aVar13[pbVar6 + 1] = (byte)(bVar5 - sVar3);
                                        uVar4 = 0;
                                        aVar13[pbVar9 + 1] += (byte)sVar3;
                                    }
                                    else
                                    {
                                        uVar4 -= bVar5;
                                        aVar13[pbVar9 + 1] += bVar5;
                                        aVar13[pbVar6 + 1] = 0;
                                    }
                                }
                            }

                            pbVar6 += 4;
                            uVar7++;
                        } while (uVar4 != 0);
                    }
                }

                uVar10++;
                pbVar9 += 4;
            } while (uVar10 < uVar11 - 1);
        }

        return bVar13;
    }

    private void FUN_7007C()
    {
        if (DAT_C6130[0].DAT_26 == 0)
            PTR_FUN_A88F0[DAT_C6102](DAT_C6130, 0);

        FUN_72420(DAT_C6130, 0);
        FUN_7148C(DAT_C6130, 0);
        FUN_71F24(DAT_C6130, 0);
        //FUN_71760

        if ((DAT_C612E & 0x10) != 0)
            FUN_70BD0(DAT_C6130, 0);
    }

    private void FUN_70124(InventoryWindow[] param1, int param2)
    {
        DAT_C610A = 0;
        DAT_C6102++;
        FUN_71C6C(param1, param2);
        param1[param2].rect2[0].DAT_0C = 0;
        param1[param2].rect2[0].DAT_0E = -110;
        param1[param2].rect2[0].DAT_10 = 0;
        param1[param2].rect2[0].DAT_12 = 170;
        FUN_7236C(param1[param2], 0, 10, 0xa00000, 0xaa0000);
        param1[param2].rect2[1].DAT_0C = 0;
        param1[param2].rect2[1].DAT_0E = 20;
        param1[param2].rect2[1].DAT_10 = 0;
        param1[param2].rect2[1].DAT_12 = 492;
        FUN_7236C(param1[param2], 1, 10, 0x140000, 0x1060000);

        if (param1[param2].DAT_14 == 0)
            DAT_C6102 = 3;
    }

    private void FUN_701CC(InventoryWindow[] param1, int param2)
    {
        PTR_FUN_A8900[DAT_C6103](param1, param2);
    }

    private void FUN_70208(InventoryWindow[] param1, int param2)
    {
        ushort uVar1;
        sbyte sVar2;
        byte bVar3;
        int iVar4;

        uVar1 = DAT_C612E;

        if ((uVar1 & 0x1000) == 0)
        {
            if ((uVar1 & 0x4000) == 0)
            {
                if ((uVar1 & 0x2000) == 0)
                {
                    if ((uVar1 & 0x8000) == 0)
                    {
                        if ((uVar1 & 0x40) != 0)
                        {
                            GameManager.instance.FUN_5C94C(null, 1);
                            bVar3 = (byte)(param1[param2].DAT_24 - 1);

                            if (param1[param2].DAT_24 != 0)
                            {
                                param1[param2].DAT_24 = bVar3;
                                iVar4 = bVar3 * 4;
                                param1[param2].DAT_15 = (sbyte)((uint)param1[param2].DAT_18[iVar4 + 3] >> 4);
                                param1[param2].DAT_16 = (byte)(param1[param2].DAT_18[iVar4 + 3] & 0xf);
                                param1[param2].DAT_18[iVar4 + 1] = 0;
                                FUN_71C6C(param1, param2);
                                return;
                            }

                            DAT_C6102++;
                            return;
                        }

                        if ((uVar1 & 0xa0) == 0)
                            return;

                        if ((param1[param2].ARRY_00[param1[param2].DAT_16 * 4 + 3] & 1) != 0)
                        {
                            GameManager.instance.FUN_5C94C(null, 1);
                            return;
                        }

                        GameManager.instance.FUN_5C94C(null, 2);
                        param1[param2].DAT_25 = 0;
                        DAT_C6103 = 1;
                        return;
                    }

                    if (param1[param2].DAT_15 < 1)
                        return;

                    GameManager.instance.FUN_5C94C(null, 0);
                    sVar2 = (sbyte)(param1[param2].DAT_15 - 1);
                }
                else
                {
                    if ((param1[param2].DAT_17 + 4) / 5 - 1 <= param1[param2].DAT_15)
                        return;

                    GameManager.instance.FUN_5C94C(null, 0);
                    sVar2 = (sbyte)(param1[param2].DAT_15 + 1);
                }

                param1[param2].DAT_15 = sVar2;
                FUN_71C6C(param1, param2);
                param1[param2].DAT_16 = 0;
            }
            else
            {
                if (param1[param2].DAT_16 < param1[param2].DAT_14 - 1)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    param1[param2].DAT_16++;
                }
            }
        }
        else
        {
            if (param1[param2].DAT_16 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 0);
                param1[param2].DAT_16--;
            }
        }
    }

    private void FUN_70410(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        byte bVar2;
        ushort uVar3;
        bool bVar4;
        int puVar5;

        uVar3 = DAT_C612E;

        if ((uVar3 & 0x1000) == 0)
        {
            if ((uVar3 & 0x4000) == 0)
            {
                if ((uVar3 & 0xa0) == 0)
                {
                    if ((uVar3 & 0x40) != 0)
                    {
                        GameManager.instance.FUN_5C94C(null, 1);
                        DAT_C6103--;
                    }
                }
                else
                {
                    bVar1 = param1[param2].DAT_25;

                    if (bVar1 == 1)
                    {
                        GameManager.instance.FUN_5C94C(null, 2);
                        DAT_C6103 = 4;
                        bVar2 = param1[param2].ARRY_00[param1[param2].DAT_16 * 4];
                        DAT_C61FE = 30;
                        DAT_C61FD = 0;
                        DAT_C61FC = bVar2;
                        FUN_7236C(param1[param2], 0, 10, -0x6e0000, 0xaa0000);
                        FUN_7236C(param1[param2], 1, 10, 0x140000, 0x1ec0000);
                    }
                    else
                    {
                        if (bVar1 < 2)
                        {
                            if (bVar1 == 0)
                            {
                                GameManager.instance.FUN_5C94C(null, 2);

                                if (param1[param2].DAT_24 == 0)
                                {
                                    param1[param2].DAT_2D = 0;
                                    param1[param2].DAT_2C = 0;
                                }

                                DAT_C6103 = 0;
                                puVar5 = param1[param2].DAT_24 * 4;
                                param1[param2].DAT_18[puVar5] = param1[param2].ARRY_00[param1[param2].DAT_16 * 4];
                                param1[param2].DAT_18[puVar5 + 1] = param1[param2].ARRY_00[param1[param2].DAT_16 * 4 + 1];
                                param1[param2].DAT_18[puVar5 + 2] = param1[param2].ARRY_00[param1[param2].DAT_16 * 4 + 2];
                                param1[param2].DAT_18[puVar5 + 3] = param1[param2].ARRY_00[param1[param2].DAT_16 * 4 + 3];
                                param1[param2].DAT_18[puVar5 + 3] = (byte)(param1[param2].DAT_16 | (byte)param1[param2].DAT_15 << 4);
                                param1[param2].DAT_24++;
                                FUN_71C6C(param1, param2);

                                if (1U < param1[param2].DAT_24)
                                {
                                    DAT_C6103 = 2;
                                    bVar4 = FUN_70E1C(param1, param2);

                                    if (!bVar4)
                                    {
                                        param1[param2].DAT_20.DAT_03 = 0;
                                        param1[param2].DAT_20.DAT_02 = 0;
                                        param1[param2].DAT_20.DAT_01 = 0;
                                        param1[param2].DAT_20.DAT_00 = 0;
                                    }

                                    param1[param2].DAT_25 = 0;
                                }
                            }
                        }
                        else
                        {
                            if (bVar1 == 2)
                            {
                                DAT_C6103 = 0;
                                bVar4 = FUN_6FEAC(true, null);

                                if (!bVar4)
                                    GameManager.instance.FUN_5C94C(null, 1);
                                else
                                {
                                    GameManager.instance.FUN_5C94C(null, 2);
                                    param1[param2].DAT_15 = 0;
                                    param1[param2].DAT_16 = 0;
                                    FUN_71C6C(param1, param2);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (param1[param2].DAT_25 < 2U)
                {
                    GameManager.instance.FUN_5C94C(null, 0);
                    param1[param2].DAT_25++;
                }
            }
        }
        else
        {
            if (param1[param2].DAT_25 != 0)
            {
                GameManager.instance.FUN_5C94C(null, 0);
                param1[param2].DAT_25--;
            }
        }

        //FUN_66C68
    }

    private void FUN_706A0(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        ushort uVar2;
        byte bVar3;
        sbyte sVar4;
        bool bVar5;
        int iVar5;

        uVar2 = DAT_C612E;

        if ((uVar2 & 0x40) == 0)
        {
            if ((uVar2 & 0xa0) == 0)
            {
                if ((uVar2 & 0x8000) == 0)
                {
                    if ((uVar2 & 0x2000) == 0 || param1[param2].DAT_25 != 0) goto LAB_708AC;

                    GameManager.instance.FUN_5C94C(null, 0);
                    sVar4 = (sbyte)(param1[param2].DAT_25 + 1);
                }
                else
                {
                    if (param1[param2].DAT_25 == 0) goto LAB_708AC;

                    GameManager.instance.FUN_5C94C(null, 0);
                    sVar4 = (sbyte)(param1[param2].DAT_25 - 1);
                }

                param1[param2].DAT_25 = (byte)sVar4;
                goto LAB_708AC;
            }

            if (param1[param2].DAT_25 == 0)
            {
                bVar5 = FUN_724BC(param1[param2].DAT_18, 0, 4);

                if (!bVar5)
                {
                    GameManager.instance.FUN_5C94C(null, 10);
                    DAT_C6103 = 3;
                    param1[param2].DAT_27 = 0;
                }
                else
                {
                    GameManager.instance.FUN_5C94C(null, 2);
                    bVar5 = FUN_725D0(param1, param2);

                    if (!bVar5)
                    {
                        DAT_C6103 = 3;
                        param1[param2].DAT_27 = 1;
                    }
                    else
                    {
                        FUN_71C6C(param1, param2);
                        param1[param2].DAT_15 = (sbyte)((param1[param2].DAT_17 - 1) / 5);
                        FUN_71C6C(param1, param2);
                        param1[param2].DAT_16 = (byte)(param1[param2].DAT_14 - 1);
                        DAT_C6103 = 4;
                        bVar1 = param1[param2].ARRY_00[param1[param2].DAT_16 * 4];
                        DAT_C61FE = 30;
                        DAT_C61FD = 0;
                        DAT_C61FC = bVar1;
                        FUN_7236C(param1[param2], 0, 10, -0x6e0000, 0xaa0000);
                        FUN_7236C(param1[param2], 1, 10, 0x140000, 0x1ec0000);
                    }
                }

                goto LAB_708AC;
            }
        }

        GameManager.instance.FUN_5C94C(null, 1);
        DAT_C6103 = 0;
        bVar3 = (byte)(param1[param2].DAT_24 - 1);
        param1[param2].DAT_24 = bVar3;
        iVar5 = bVar3 * 4;
        param1[param2].DAT_15 = (sbyte)((uint)param1[param2].DAT_18[iVar5 + 3] >> 4);
        param1[param2].DAT_16 = (byte)(param1[param2].DAT_18[iVar5 + 3] & 0xf);
        param1[param2].DAT_18[iVar5 + 1] = 0;
        FUN_71C6C(param1, param2);
        LAB_708AC:;
        //...
    }

    private void FUN_709B4(InventoryWindow[] param1, int param2)
    {
        //...

        if ((DAT_C612E & 0xe0) != 0)
        {
            DAT_C6103 = 0;
            param1[param2].DAT_24 = 0;
            param1[param2].DAT_20.DAT_01 = 0;
            param1[param2].DAT_18[5] = 0;
            param1[param2].DAT_18[1] = 0;
            FUN_71C6C(param1, param2);
        }
    }

    private void FUN_70A5C(InventoryWindow[] param1, int param2)
    {
        int iVar1;
        uint uVar1;
        byte[] auStack24 = new byte[8];

        //FUN_674DC

        if (1U < param1[param2].DAT_24)
        {
            //sprintf
            iVar1 = FUN_67404(auStack24, 0);
            //FUN_6750C
            FUN_71350(param1[param2].DAT_20);
            //FUN_6750C
            uVar1 = 0x185;

            if (param1[param2].DAT_20.DAT_01 == 1)
                uVar1 = 0x184;

            //FUN_67554
        }

        //FUN_67AD8
        FUN_6A9F4();

        if (DAT_C61FE == 0 && (DAT_C612E & 0xe0) != 0)
        {
            GameManager.instance.FUN_5C94C(null, 1);
            DAT_C6103 = 0;
            FUN_7236C(param1[param2], 0, 10, 0xa00000, 0xaa0000);
            FUN_7236C(param1[param2], 1, 10, 0x140000, 0x1060000);

            if (1U < param1[param2].DAT_24)
            {
                param1[param2].DAT_24 = 0;
                param1[param2].DAT_20.DAT_01 = 0;
                param1[param2].DAT_18[5] = 0;
                param1[param2].DAT_18[1] = 0;
                FUN_71C6C(param1, param2);
            }
        }
    }

    private void FUN_70BD0(InventoryWindow[] param1, int param2)
    {
        FUN_6AC20();
        DAT_C6104 = 0;
        DAT_C6103 = 0;
        DAT_C6102 = 0;
        DAT_C6101 = 0;
    }

    private void FUN_70C04(InventoryWindow[] param1, int param2)
    {
        if ((DAT_C612E & 0xe0) != 0)
        {
            DAT_C6102 = 2;
            GameManager.instance.FUN_5C94C(null, 1);
        }

        //...
    }

    private int FUN_70C8C(byte[] param1, int param2, int param3, InventoryWindow param4)
    {
        byte bVar1;
        byte bVar2;

        bVar1 = param1[param2];

        if (bVar1 == 31 || param1[param3] == 31)
        {
            if (bVar1 == 31)
                param2 = param3;

            if (param1[param2] != 20)
                return 0;

            if (param1[param2 + 2] != 9)
                return 0;
        }
        else
        {
            if ((bVar1 != 20 || param1[param2 + 2] != 9) && 
                (param1[param3] != 20 || param1[param3 + 2] != 9))
            {
                if ((param1[param2] != 30 || param1[param2 + 2] != 12) && 
                    (param1[param3] != 30 || param1[param3 + 2] != 12))
                {
                    if (param1[param2] != 21 && param1[param3] != 21)
                        return 2;

                    return 0;
                }

                if (param1[param2] == 30 && param1[param2 + 2] == 12)
                    param2 = param3;

                if (param1[param2] != 30)
                    return 0;

                if (param1[param2 + 2] != 12)
                    return 0;

                bVar2 = 31;
                goto LAB_70CDC;
            }

            if (param1[param2] == 20 && param1[param2 + 2] == 9)
                param2 = param3;

            if (param1[param2] != 31)
                return 0;
        }

        bVar2 = 21;
        LAB_70CDC:
        param4.DAT_20.DAT_00 = bVar2;
        param4.DAT_20.DAT_01 = 1;
        param4.DAT_20.DAT_02 = 29;
        return 1;
    }

    private bool FUN_70E1C(InventoryWindow[] param1, int param2)
    {
        byte bVar2;
        byte bVar3;
        byte bVar4;
        byte bVar5;
        int puVar6;
        int puVar7;
        int iVar8;
        uint uVar9;
        byte[] local_20 = new byte[12];
        uint[] local_10 = new uint[2];

        uVar9 = 0;
        puVar7 = 0;
        puVar6 = 0;
        iVar8 = 0;

        do
        {
            local_20[puVar6] = param1[param2].DAT_18[iVar8];
            local_20[puVar6 + 1] = param1[param2].DAT_18[iVar8 + 1];
            local_20[puVar6 + 2] = param1[param2].DAT_18[iVar8 + 2];
            local_20[puVar6 + 3] = param1[param2].DAT_18[iVar8 + 3];
            bVar4 = local_20[puVar6];
            puVar6 += 4;
            iVar8 += 4;
            uVar9++;
            local_10[puVar7] = (bVar4 < 0x20U ? 1U : 0) ^ 1;
            puVar7 += 1;
        } while (uVar9 < 2);

        if (local_10[0] == 1 && local_10[1] == 1)
        {
            if ((uint)local_20[4] < local_20[0])
            {
                local_20[8] = local_20[0];
                local_20[9] = local_20[1];
                local_20[10] = local_20[2];
                local_20[11] = local_20[3];
                local_20[0] = local_20[4];
                local_20[1] = local_20[5];
                local_20[2] = local_20[6];
                local_20[3] = local_20[7];
                local_20[4] = local_20[8];
                local_20[5] = local_20[9];
                local_20[6] = local_20[10];
                local_20[7] = local_20[11];
            }

            if (local_20[0] == 0x20)
            {
                uVar9 = local_20[4];

                if (uVar9 == 0x22)
                {
                    bVar4 = 0x12;
                    param1[param2].DAT_20.DAT_00 = bVar4;
                    param1[param2].DAT_20.DAT_02 = 2;
                    param1[param2].DAT_20.DAT_01 = 1;
                }
                else
                {
                    if (uVar9 < 0x23)
                    {
                        if (uVar9 != 0x20)
                            return false;

                        param1[param2].DAT_20.DAT_00 = 0x12;
                        bVar2 = 3;
                    }
                    else
                    {
                        if (uVar9 != 0x23)
                            return false;

                        bVar4 = 0x12;
                        param1[param2].DAT_20.DAT_00 = bVar4;
                        bVar2 = 2;
                    }

                    param1[param2].DAT_20.DAT_02 = 1;
                    param1[param2].DAT_20.DAT_01 = bVar2;
                }
            }
            else
            {
                if (local_20[0] != 0x21)
                    return false;

                uVar9 = local_20[4];

                if (uVar9 == 0x22)
                {
                    bVar4 = 0x1b;
                    param1[param2].DAT_20.DAT_00 = bVar4;
                    param1[param2].DAT_20.DAT_02 = 2;
                    param1[param2].DAT_20.DAT_01 = 1;
                }
                else
                {
                    if (0x22 < uVar9)
                    {
                        if (uVar9 != 0x23)
                            return false;

                        bVar4 = 0x1b;
                        param1[param2].DAT_20.DAT_00 = bVar4;
                        param1[param2].DAT_20.DAT_02 = 1;
                        param1[param2].DAT_20.DAT_01 = 2;
                    }
                    else
                    {
                        if (uVar9 != 0x21)
                            return false;

                        param1[param2].DAT_20.DAT_00 = 0x1b;
                        param1[param2].DAT_20.DAT_02 = 1;
                        param1[param2].DAT_20.DAT_01 = 1;
                    }
                }
            }
        }
        else
        {
            if ((uint)local_20[0] < local_20[4])
            {
                local_20[8] = local_20[0];
                local_20[9] = local_20[1];
                local_20[10] = local_20[2];
                local_20[11] = local_20[3];
                local_20[0] = local_20[4];
                local_20[1] = local_20[5];
                local_20[2] = local_20[6];
                local_20[3] = local_20[7];
                local_20[4] = local_20[8];
                local_20[5] = local_20[9];
                local_20[6] = local_20[10];
                local_20[7] = local_20[11];
            }

            iVar8 = FUN_70C8C(local_20, 0, 4, param1[param2]);

            if (iVar8 == 0)
                return false;

            if (iVar8 == 2)
            {
                if (local_20[0] < 0x20U)
                {
                    if ((uint)local_20[2] < local_20[6])
                    {
                        param1[param2].DAT_20.DAT_00 = local_20[4];
                        param1[param2].DAT_20.DAT_01 = local_20[5];
                        param1[param2].DAT_20.DAT_02 = local_20[6];
                        param1[param2].DAT_20.DAT_03 = local_20[7];
                    }
                    else
                    {
                        param1[param2].DAT_20.DAT_00 = local_20[0];
                        param1[param2].DAT_20.DAT_01 = local_20[1];
                        param1[param2].DAT_20.DAT_02 = local_20[2];
                        param1[param2].DAT_20.DAT_03 = local_20[3];
                    }

                    if (local_20[2] == local_20[6])
                    {
                        if ((uint)local_20[1] < local_20[5])
                            local_20[1] = local_20[5];

                        param1[param2].DAT_20.DAT_01 = local_20[1];
                    }

                    bVar3 = (byte)(local_20[2] + local_20[6]);
                    param1[param2].DAT_20.DAT_02 = bVar3;
                }
                else
                {
                    uVar9 = local_20[0];

                    if (uVar9 == 0x21)
                    {
                        if (local_20[4] < 0x1bU)
                        {
                            param1[param2].DAT_20.DAT_00 = local_20[4];
                            param1[param2].DAT_20.DAT_01 = local_20[5];
                            param1[param2].DAT_20.DAT_02 = local_20[6];
                            param1[param2].DAT_20.DAT_03 = local_20[7];
                            bVar3 = (byte)(param1[param2].DAT_20.DAT_02 + 1);
                            param1[param2].DAT_20.DAT_02 = bVar3;
                        }
                        else
                        {
                            param1[param2].DAT_20.DAT_00 = local_20[4];
                            param1[param2].DAT_20.DAT_01 = local_20[5];
                            param1[param2].DAT_20.DAT_02 = local_20[6];
                            param1[param2].DAT_20.DAT_03 = local_20[7];
                            param1[param2].DAT_20.DAT_02 += 5;
                            param1[param2].DAT_20.DAT_01++;
                        }
                    }
                    else
                    {
                        if (uVar9 < 0x22)
                        {
                            if (uVar9 == 0x20)
                            {
                                if (local_20[4] < 0x1bU)
                                {
                                    param1[param2].DAT_20.DAT_00 = local_20[4];
                                    param1[param2].DAT_20.DAT_01 = local_20[5];
                                    param1[param2].DAT_20.DAT_02 = local_20[6];
                                    param1[param2].DAT_20.DAT_03 = local_20[7];
                                    param1[param2].DAT_20.DAT_02 += 5;
                                    param1[param2].DAT_20.DAT_01++;
                                }
                                else
                                {
                                    param1[param2].DAT_20.DAT_00 = local_20[4];
                                    param1[param2].DAT_20.DAT_01 = local_20[5];
                                    param1[param2].DAT_20.DAT_02 = local_20[6];
                                    param1[param2].DAT_20.DAT_03 = local_20[7];
                                    bVar3 = (byte)(param1[param2].DAT_20.DAT_02 + 1);
                                    param1[param2].DAT_20.DAT_02 = bVar3;
                                }
                            }
                        }
                        else
                        {
                            if (uVar9 == 0x22)
                            {
                                param1[param2].DAT_20.DAT_00 = local_20[4];
                                param1[param2].DAT_20.DAT_01 = local_20[5];
                                param1[param2].DAT_20.DAT_02 = local_20[6];
                                param1[param2].DAT_20.DAT_03 = local_20[7];
                                param1[param2].DAT_20.DAT_02 = (byte)(((local_20[6] + 3) / 3) * 3 + 1);
                            }
                            else
                            {
                                if (uVar9 == 0x23)
                                {
                                    param1[param2].DAT_20.DAT_00 = local_20[4];
                                    param1[param2].DAT_20.DAT_01 = local_20[5];
                                    param1[param2].DAT_20.DAT_02 = local_20[6];
                                    param1[param2].DAT_20.DAT_03 = local_20[7];
                                    param1[param2].DAT_20.DAT_01 <<= 1;
                                }
                            }
                        }
                    }
                }
            }
        }

        if (param1[param2].DAT_20.DAT_00 < 0x1bU)
        {
            if (param1[param2].DAT_20.DAT_02 < 0x1dU)
            {
                if (param1[param2].DAT_20.DAT_02 < 9U)
                    bVar4 = (byte)(((param1[param2].DAT_20.DAT_02 - 1) / 3) + 18);
                else
                    bVar4 = 20;

                bVar5 = param1[param2].DAT_20.DAT_02;
                param1[param2].DAT_20.DAT_00 = bVar4;

                if (9U < bVar5)
                    bVar5 = 9;

                param1[param2].DAT_20.DAT_02 = bVar5;
                goto LAB_71338;
            }

            bVar4 = 21;
        }
        else
        {
            if (param1[param2].DAT_20.DAT_02 < 0x1dU)
            {
                if (param1[param2].DAT_20.DAT_02 < 12U)
                    bVar4 = (byte)(((param1[param2].DAT_20.DAT_02 - 1) / 3) + 27);
                else
                    bVar4 = 30;

                bVar5 = param1[param2].DAT_20.DAT_02;
                param1[param2].DAT_20.DAT_00 = bVar4;

                if (12U < bVar5)
                    bVar5 = 12;

                param1[param2].DAT_20.DAT_02 = bVar5;
                goto LAB_71338;
            }

            bVar4 = 31;
        }

        param1[param2].DAT_20.DAT_00 = bVar4;
        param1[param2].DAT_20.DAT_02 = 0x1d;
        param1[param2].DAT_20.DAT_01 = 1;
        LAB_71338:
        param1[param2].DAT_20.DAT_03 = 0;
        return true;
    }

    private ushort[] FUN_71350(InventoryText param1)
    {
        int iVar1;
        uint uVar2;
        ushort uVar3;
        int iVar4;
        uint uVar5;
        int iVar6;

        uVar5 = param1.DAT_02;
        iVar1 = param1.DAT_00 * 6;

        switch (param1.DAT_00)
        {
            case 18:
            case 19:
            case 27:
            case 28:
            case 29:
                uVar5--;
                iVar6 = (int)(uVar5 - (((uint)((ulong)uVar5 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar5 / 3));
                iVar4 = iVar6 + 448;

                if (iVar6 != 0)
                {
                    uVar3 = DialogManager.DAT_A593C[2 + iVar1];
                    goto LAB_71474;
                }

                break;
            case 20:
                uVar2 = uVar5 - 1;

                if (9 < uVar5)
                    uVar2 = 8;

                iVar6 = (int)(uVar2 - (((uint)((ulong)uVar2 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar2 / 3));
                iVar4 = iVar6 + 448;

                if (iVar6 != 0)
                {
                    uVar3 = DialogManager.DAT_A593C[2 + iVar1];
                    goto LAB_71474;
                }

                break;
            case 30:
                uVar2 = uVar5 - 1;

                if (12 < uVar5)
                    uVar2 = 11;

                iVar6 = (int)(uVar2 - (((uint)((ulong)uVar2 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar2 / 3));
                iVar4 = iVar6 + 448;

                if (iVar6 != 0)
                {
                    uVar3 = DialogManager.DAT_A593C[2 + iVar1];
                    goto LAB_71474;
                }

                break;
        }

        uVar3 = DialogManager.DAT_A593C[2 + iVar1];
        iVar4 = 0;
        LAB_71474:
        return DialogManager.instance.FUN_67350(uVar3, iVar4);
    }

    private ushort[] FUN_71350(byte[] param1, int param2)
    {
        int iVar1;
        uint uVar2;
        ushort uVar3;
        int iVar4;
        uint uVar5;
        int iVar6;

        uVar5 = param1[param2 + 2];
        iVar1 = param1[param2] * 6;

        switch (param1[param2])
        {
            case 18:
            case 19:
            case 27:
            case 28:
            case 29:
                uVar5--;
                iVar6 = (int)(uVar5 - (((uint)((ulong)uVar5 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar5 / 3));
                iVar4 = iVar6 + 448;

                if (iVar6 != 0)
                {
                    uVar3 = DialogManager.DAT_A593C[2 + iVar1];
                    goto LAB_71474;
                }

                break;
            case 20:
                uVar2 = uVar5 - 1;

                if (9 < uVar5)
                    uVar2 = 8;

                iVar6 = (int)(uVar2 - (((uint)((ulong)uVar2 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar2 / 3));
                iVar4 = iVar6 + 448;

                if (iVar6 != 0)
                {
                    uVar3 = DialogManager.DAT_A593C[2 + iVar1];
                    goto LAB_71474;
                }

                break;
            case 30:
                uVar2 = uVar5 - 1;

                if (12 < uVar5)
                    uVar2 = 11;

                iVar6 = (int)(uVar2 - (((uint)((ulong)uVar2 * 0xaaaaaaab >> 0x20) & 0xfffffffe) + uVar2 / 3));
                iVar4 = iVar6 + 448;

                if (iVar6 != 0)
                {
                    uVar3 = DialogManager.DAT_A593C[2 + iVar1];
                    goto LAB_71474;
                }

                break;
        }

        uVar3 = DialogManager.DAT_A593C[2 + iVar1];
        iVar4 = 0;
        LAB_71474:
        return DialogManager.instance.FUN_67350(uVar3, iVar4);
    }

    private void FUN_7148C(InventoryWindow[] param1, int param2)
    {
        byte bVar1;
        short sVar2;
        ushort[] uVar3;
        int iVar4;
        uint uVar5;
        Vector3Int vVar5;
        Vector3Int vVar6;
        int pbVar7;
        int pbVar8;
        int iVar9;
        int iVar10;
        int iVar11;
        int local_38;
        int local_30;

        //FUN_674DC
        sVar2 = param1[param2].rect2[0].DAT_0E;
        iVar9 = sVar2;
        local_38 = param1[param2].rect2[0].DAT_12;

        if (5U < param1[param2].DAT_17)
        {
            vVar5 = new Vector3Int(0x80, 0x80, 0x80);

            if (0 < param1[param2].DAT_15)
                vVar5 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
            vVar5 = new Vector3Int(0x80, 0x80, 0x80);

            if (param1[param2].DAT_15 + 1 < (param1[param2].DAT_17 + 4) / 5)
                vVar5 = GameManager.instance.FUN_71BF8(new Vector3Int(0x60, 0x60, 0x60), new Vector3Int(0xd0, 0xd0, 0xd0), 4);

            //FUN_6ACDC
        }

        //FUN_6ACDC
        uVar5 = 0;
        iVar11 = -0x35;
        iVar10 = -0x3b;
        local_30 = local_38 - 0x3f;
        pbVar7 = 1;
        pbVar8 = 0;

        do
        {
            vVar6 = new Vector3Int(0x80, 0x80, 0x80);

            if ((param1[param2].ARRY_00[pbVar7 + 2] & 1) != 0)
                vVar6 = new Vector3Int(0x40, 0x40, 0x40);

            if (param1[param2].ARRY_00[pbVar7] != 0)
            {
                bVar1 = param1[param2].ARRY_00[pbVar8];
                iVar4 = local_38 + iVar10;
                iVar10 += 0x1a;
                //FUN_67904
                uVar3 = FUN_71350(param1[param2].ARRY_00, pbVar8);
                //...
                iVar11 += 0x1a;
            }

            pbVar7 += 4;
            pbVar8 += 4;

            if (param1[param2].DAT_16 == uVar5)
            {
                //...
            }

            uVar5++;
            local_30 += 0x1a;
        } while (uVar5 < 5);
    }

    private void FUN_71C6C(InventoryWindow[] param1, int param2)
    {
        byte[] aVar1 = new byte[4];
        byte[] aVar2 = new byte[4];
        uint uVar3;
        int puVar4;
        int puVar5;
        sbyte sVar6;
        int iVar7;
        bool bVar7;
        uint uVar8;

        param1[param2].ARRY_00 = new byte[20];
        sVar6 = 0;
        FUN_6FAF0();
        uVar3 = 0;

        while (uVar3 < GameManager.instance.DAT_9ADE * 4U)
        {
            if (GameManager.instance.DAT_9EAC[uVar3 + 1] != 0)
                sVar6++;

            uVar3 += 4;
        }

        param1[param2].DAT_17 = (byte)sVar6;
        puVar4 = 0;
        iVar7 = param1[param2].DAT_15 * 5;
        uVar3 = GameManager.instance.DAT_9ADE;

        while (0 < iVar7)
        {
            if (GameManager.instance.DAT_9EAC[puVar4 + 1] != 0)
                iVar7--;

            puVar4 += 4;
            uVar3--;
        }

        uVar8 = 0;
        puVar5 = 0;

        while (uVar3-- != 0 && (int)uVar8 < 5)
        {
            if (GameManager.instance.DAT_9EAC[puVar4 + 1] != 0)
            {
                param1[param2].ARRY_00[puVar5] = GameManager.instance.DAT_9EAC[puVar4];
                param1[param2].ARRY_00[puVar5 + 1] = GameManager.instance.DAT_9EAC[puVar4 + 1];
                param1[param2].ARRY_00[puVar5 + 2] = GameManager.instance.DAT_9EAC[puVar4 + 2];
                param1[param2].ARRY_00[puVar5 + 3] = GameManager.instance.DAT_9EAC[puVar4 + 3];

                if (GameManager.instance.DAT_9EAC[puVar4] < 27U &&
                    3 < GameManager.instance.DAT_9EAC[puVar4] - 18U)
                    param1[param2].ARRY_00[puVar5 + 3] = 1;

                if (param1[param2].DAT_24 != 0)
                {
                    aVar1[0] = param1[param2].DAT_18[4];
                    aVar1[1] = param1[param2].DAT_18[5];
                    aVar1[2] = param1[param2].DAT_18[6];
                    aVar1[3] = param1[param2].DAT_18[7];
                    aVar2[0] = param1[param2].DAT_20.DAT_00;
                    aVar2[1] = param1[param2].DAT_20.DAT_01;
                    aVar2[2] = param1[param2].DAT_20.DAT_02;
                    aVar2[3] = param1[param2].DAT_20.DAT_03;
                    param1[param2].DAT_18[4] = GameManager.instance.DAT_9EAC[puVar4];
                    param1[param2].DAT_18[5] = GameManager.instance.DAT_9EAC[puVar4 + 1];
                    param1[param2].DAT_18[6] = GameManager.instance.DAT_9EAC[puVar4 + 2];
                    param1[param2].DAT_18[7] = GameManager.instance.DAT_9EAC[puVar4 + 3];
                    bVar7 = FUN_70E1C(param1, param2);

                    if (!bVar7)
                        param1[param2].ARRY_00[puVar5 + 3] = 1;

                    param1[param2].DAT_18[4] = aVar1[0];
                    param1[param2].DAT_18[5] = aVar1[1];
                    param1[param2].DAT_18[6] = aVar1[2];
                    param1[param2].DAT_18[7] = aVar1[3];
                    param1[param2].DAT_20.DAT_00 = aVar2[0];
                    param1[param2].DAT_20.DAT_01 = aVar2[1];
                    param1[param2].DAT_20.DAT_02 = aVar2[2];
                    param1[param2].DAT_20.DAT_03 = aVar2[3];
                }

                if (param1[param2].DAT_24 == 1)
                {
                    if ((uint)param1[param2].DAT_18[3] >> 4 == param1[param2].DAT_15 &&
                        uVar8 == (param1[param2].DAT_18[3] & 0xf))
                        param1[param2].ARRY_00[puVar5 + 3] = 1;
                }
                else
                {
                    if (param1[param2].DAT_24 == 2)
                    {
                        if ((uint)param1[param2].DAT_18[3] >> 4 == param1[param2].DAT_15 &&
                            uVar8 == (param1[param2].DAT_18[3] & 0xf))
                            param1[param2].ARRY_00[puVar5 + 3] = 1;

                        if ((uint)param1[param2].DAT_18[7] >> 4 == param1[param2].DAT_15 &&
                            uVar8 == (param1[param2].DAT_18[7] & 0xf))
                            param1[param2].ARRY_00[puVar5 + 3] = 1;
                    }
                }

                puVar5 += 4;
                uVar8++;
            }

            puVar4 += 4;
        }

        param1[param2].DAT_05 = (byte)uVar8;
    }

    private void FUN_71F24(InventoryWindow[] param1, int param2)
    {
        short sVar1;
        short sVar2;
        sbyte sVar3;
        sbyte sVar4;
        uint uVar5;
        int pbVar6;
        int iVar7;
        byte bVar8;
        uint uVar9;
        int pcVar10;
        uint uVar11;
        int iVar12;
        bool bVar12;
        int iVar13;

        if (param1[param2].DAT_24 == 0)
            return;

        //FUN_674DC
        uVar11 = 0;
        iVar13 = 0;
        iVar12 = 0;
        sVar1 = param1[param2].rect2[1].DAT_0E;
        sVar2 = param1[param2].rect2[1].DAT_12;

        do
        {
            pbVar6 = iVar12;

            if (uVar11 == 1)
                pbVar6 += 4;

            pcVar10 = iVar13;

            if (param1[param2].DAT_18[pbVar6] < 0x1bU)
            {
                uVar5 = param1[param2].DAT_18[pbVar6 + 2];
                bVar8 = param1[param2].DAT_18[pbVar6 + 1];
                uVar9 = bVar8;
                iVar7 = (int)(uVar5 - 1);

                if (iVar7 < 0)
                    iVar7 = 0;

                sVar4 = (sbyte)iVar7;
                sVar3 = (sbyte)(bVar8 << 4);

                if (9 < uVar5)
                {
                    sVar4 = 8;

                    if (0x1c < uVar5)
                        sVar4 = 15;

                    bVar8 = (byte)uVar9;
                    sVar3 = (sbyte)(uVar9 << 4);
                }

                param1[param2].DAT_28[pcVar10] = (byte)(sVar3 - bVar8);
                param1[param2].DAT_28[pcVar10 + 1] = (byte)(sVar4 * 6);
            }
            else
            {
                if (param1[param2].DAT_18[pbVar6] < 0x20U)
                {
                    uVar5 = param1[param2].DAT_18[pbVar6 + 2];
                    bVar8 = param1[param2].DAT_18[pbVar6 + 1];
                    uVar9 = bVar8;
                    iVar7 = (int)(uVar5 - 1);

                    if (iVar7 < 0)
                        iVar7 = 0;

                    sVar4 = (sbyte)iVar7;
                    sVar3 = (sbyte)(bVar8 << 4);

                    if (0xc < uVar5)
                    {
                        sVar4 = 11;

                        if (0x13 < uVar5)
                            sVar4 = 14;

                        bVar8 = (byte)uVar9;
                        sVar3 = (sbyte)(uVar9 << 4);
                    }

                    param1[param2].DAT_28[pcVar10] = (byte)(sVar3 - bVar8);
                    param1[param2].DAT_28[pcVar10 + 1] = (byte)(sVar4 * 6);
                }

                param1[param2].DAT_28[pcVar10] = 15;
                param1[param2].DAT_28[pcVar10 + 1] = 0;
            }

            iVar13 += 2;
            uVar11++;
            iVar12 += 4;
        } while (uVar11 < 2);

        if (param1[param2].DAT_24 == 1)
        {
            bVar8 = (byte)param1[param2].DAT_2C;

            if (param1[param2].DAT_28[0] != bVar8)
            {
                sVar3 = -1;

                if (bVar8 <= (uint)param1[param2].DAT_28[0])
                    sVar3 = 1;

                param1[param2].DAT_2C = (sbyte)(bVar8 + sVar3);
            }

            sVar3 = param1[param2].DAT_2D;

            if ((sbyte)param1[param2].DAT_28[1] == sVar3) goto LAB_720F0;

            sVar4 = (sbyte)(sVar3 - 1);

            if (sVar3 <= (sbyte)param1[param2].DAT_28[1])
                sVar4 = (sbyte)(sVar3 + 1);
        }
        else
        {
            bVar8 = (byte)param1[param2].DAT_2C;

            if (param1[param2].DAT_28[2] != bVar8)
            {
                sVar3 = -1;

                if (bVar8 <= (uint)param1[param2].DAT_28[2])
                    sVar3 = 1;

                param1[param2].DAT_2C = (sbyte)(bVar8 + sVar3);
            }

            sVar3 = param1[param2].DAT_2D;

            if ((sbyte)param1[param2].DAT_28[3] == sVar3) goto LAB_720F0;

            sVar4 = (sbyte)(sVar3 - 1);

            if (sVar3 <= (sbyte)param1[param2].DAT_28[3])
                sVar4 = (sbyte)(sVar3 + 1);
        }

        param1[param2].DAT_2D = sVar4;
        LAB_720F0:
        //...

        if (1 < param1[param2].DAT_24)
        {
            bVar12 = FUN_724BC(param1[param2].DAT_18, 0, 4);
            //...
        }
    }

    private void FUN_7236C(InventoryWindow param1, uint param2, int param3, int param4, int param5)
    {
        InventoryRect puVar1;

        param1.DAT_26++;
        puVar1 = param1.rect2[param2];

        if (param3 == 0)
            return; //trap(0x1c00)

        if (param3 == -1 && param4 - (puVar1.DAT_0E << 0x10 | (ushort)puVar1.DAT_0C) == -0x80000000)
            return; //trap(0x1800)

        if (param3 == 0)
            return; //trap(0x1c00)

        if (param3 == -1 && param5 - (puVar1.DAT_12 << 0x10 | (ushort)puVar1.DAT_10) == -0x80000000)
            return; //trap(0x1800)

        puVar1.DAT_01 = (sbyte)param3;
        puVar1.DAT_14 = (short)param4;
        puVar1.DAT_16 = (short)(param4 >> 0x10);
        puVar1.DAT_18 = (short)param5;
        puVar1.DAT_1A = (short)(param5 >> 0x10);
        puVar1.DAT_00 = true;
        puVar1.DAT_04 = (short)(((short)param4 - puVar1.DAT_0C) / param3);
        puVar1.DAT_06 = (short)(((short)(param4 >> 0x10) - puVar1.DAT_0E) / param3);
        puVar1.DAT_08 = (short)(((short)param5 - puVar1.DAT_10) / param3);
        puVar1.DAT_0A = (short)(((short)(param5 >> 0x10) - puVar1.DAT_12) / param3);
    }

    private void FUN_72420(InventoryWindow[] param1, int param2)
    {
        sbyte sVar1;
        int piVar2;
        InventoryRect pcVar3;

        piVar2 = 0;

        do
        {
            pcVar3 = param1[param2].rect2[piVar2];

            if (pcVar3.DAT_00)
            {
                pcVar3.DAT_0C += pcVar3.DAT_04;
                pcVar3.DAT_0E += pcVar3.DAT_06;
                sVar1 = (sbyte)(pcVar3.DAT_01 - 1);
                pcVar3.DAT_01 = sVar1;
                pcVar3.DAT_10 += pcVar3.DAT_08;
                pcVar3.DAT_12 += pcVar3.DAT_0A;

                if (sVar1 == -1)
                {
                    param1[param2].DAT_26--;
                    pcVar3.DAT_00 = false;
                    pcVar3.DAT_0C = pcVar3.DAT_14;
                    pcVar3.DAT_0E = pcVar3.DAT_16;
                    pcVar3.DAT_10 = pcVar3.DAT_18;
                    pcVar3.DAT_12 = pcVar3.DAT_1A;
                }
            }

            piVar2++;
        } while (piVar2 < 2);
    }

    private bool FUN_724BC(byte[] param1, int param2, int param3)
    {
        byte bVar1;
        int pbVar2;

        bVar1 = param1[param2];
        pbVar2 = param2;

        if ((uint)param1[param3] < bVar1)
        {
            bVar1 = param1[param3];
            pbVar2 = param3;
            param3 = param2;
        }

        if (bVar1 < 0x20U || param1[param3] < 0x20U)
        {
            bVar1 = param1[pbVar2];

            if (bVar1 == 0x1f)
                return param1[param3] == 0x14;

            if (param1[param3] == 0x1f)
                return bVar1 == 0x14;

            if (bVar1 != 0x15)
                return param1[param3] != 0x15;
        }
        else
        {
            if (bVar1 == 0x20)
            {
                bVar1 = param1[param3];

                if (bVar1 != 0x20)
                {
                    if (bVar1 < 0x20)
                        return false;

                    if (0x23 < bVar1)
                        return false;

                    if (bVar1 < 0x22)
                        return false;
                }

                return true;
            }

            if (bVar1 != 0x21)
                return false;

            if (param1[param3] < 0x24)
            {
                if (param1[param3] < 0x21)
                    return false;

                return true;
            }
        }

        return false;
    }

    private bool FUN_725D0(InventoryWindow[] param1, int param2)
    {
        bool bVar1;
        int iVar2;
        bool bVar3;
        int puVar4;
        byte bVar5;
        int iVar6;
        uint uVar7;
        int iVar8;
        uint uVar9;
        int iVar10;
        int piVar11;
        int[] local_18 = new int[2];

        iVar6 = param1[param2].DAT_20.DAT_00 * 6;
        uVar7 = (byte)(DialogManager.DAT_A593C[iVar6] >> 8);
        iVar2 = param1[param2].DAT_20.DAT_01 + (int)uVar7 - 1;

        if (uVar7 == 0)
            return false; //trap(0x1c00)

        if (uVar7 == 0xffffffff && iVar2 == -0x80000000)
            return false; //trap(0x1800)

        bVar3 = false;

        if (param1[param2].DAT_17 + iVar2 / (int)uVar7 - 2 <= GameManager.instance.DAT_9ADE)
        {
            piVar11 = 0;
            iVar2 = 0;

            do
            {
                iVar10 = 0;
                uVar7 = GameManager.instance.DAT_9ADE;
                iVar8 = (int)((uint)param1[param2].DAT_18[iVar2 + 3] >> 4) * 5;

                if (iVar8 != 0)
                {
                    do
                    {
                        if (GameManager.instance.DAT_9EAC[iVar10 + 1] != 0)
                            iVar8--;

                        iVar10 += 4;
                        uVar7--;
                    } while (0 < iVar8);
                }

                uVar9 = 0;

                while (true)
                {
                    if (uVar7-- == 0 || 4 < (int)uVar9) goto LAB_7271C;

                    if (GameManager.instance.DAT_9EAC[iVar10 + 1] != 0)
                    {
                        bVar1 = uVar9 == (param1[param2].DAT_18[iVar2 + 3] & 0xfU);
                        uVar9++;

                        if (bVar1) break;
                    }

                    iVar10 += 4;
                }

                local_18[piVar11] = iVar10;
                LAB_7271C:
                iVar2 += 4;
                piVar11++;
            } while (iVar2 < 8);

            //...
            FUN_6FAF0();
            uVar7 = param1[param2].DAT_20.DAT_01;
            bVar3 = true;

            if (uVar7 != 0)
            {
                do
                {
                    puVar4 = (int)GameManager.instance.FUN_5FE14();
                    GameManager.instance.DAT_9EAC[puVar4] = param1[param2].DAT_20.DAT_00;
                    GameManager.instance.DAT_9EAC[puVar4 + 1] = param1[param2].DAT_20.DAT_01;
                    GameManager.instance.DAT_9EAC[puVar4 + 2] = param1[param2].DAT_20.DAT_02;
                    GameManager.instance.DAT_9EAC[puVar4 + 3] = param1[param2].DAT_20.DAT_03;
                    bVar5 = (byte)uVar7;

                    if ((byte)(DialogManager.DAT_A593C[iVar6] >> 8) <= (int)uVar7)
                        bVar5 = (byte)(DialogManager.DAT_A593C[iVar6] >> 8);

                    GameManager.instance.DAT_9EAC[puVar4 + 1] = bVar5;
                    GameManager.instance.DAT_9EAC[puVar4 + 3] = 0;
                    uVar7 -= (byte)(DialogManager.DAT_A593C[iVar6] >> 8);
                    bVar3 = true;
                } while (0 < (int)uVar7);
            }
        }

        return bVar3;
    }
}
