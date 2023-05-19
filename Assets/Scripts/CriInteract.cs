using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriInteract : MonoBehaviour
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public byte DAT_04;
    public byte DAT_05;
    public byte DAT_06;
    public short DAT_08;
    public byte BDAT_08;
    public bool DAT_09;
    public byte DAT_0A;
    public sbyte DAT_0B;
    public sbyte DAT_13;
    public sbyte DAT_14;
    public ushort DAT_16;
    public CriBone PTR_18;
    public byte DAT_18;
    public byte DAT_19;
    public CriStatic DAT_1C;
    public CriSkinned DAT_20;
    private delegate void FUN_99208();
    private delegate void FUN_99214();
    private delegate void FUN_99224(CriStatic o);
    private FUN_99208[] PTR_FUN_99208;
    private FUN_99214[] PTR_FUN_99214;
    private byte[] DAT_99220 = new byte[2] { 217, 218 };
    private FUN_99224[] PTR_FUN_99224;

    void Awake()
    {
        PTR_FUN_99208 = new FUN_99208[3]
        {
            FUN_20B48,
            FUN_20B78,
            FUN_5FF98
        };
        PTR_FUN_99214 = new FUN_99214[3]
        {
            FUN_20BB4,
            FUN_20C94,
            FUN_215E0
        };
        PTR_FUN_99224 = new FUN_99224[2]
        {
            FUN_21890,
            FUN_2193C
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetValues()
    {
        DAT_00 = 0;
        DAT_01 = 0;
        DAT_02 = 0;
        DAT_03 = 0;
        DAT_04 = 0;
        DAT_05 = 0;
        DAT_06 = 0;
        DAT_08 = 0;
        BDAT_08 = 0;
        DAT_09 = false;
        DAT_0A = 0;
        DAT_0B = 0;
        DAT_13 = 0;
        DAT_14 = 0;
        DAT_16 = 0;
        PTR_18 = null;
        DAT_18 = 0;
        DAT_19 = 0;
        DAT_1C = null;
        DAT_20 = null;
    }

    public void FUN_20A98()
    {
        return;
    }

    public void FUN_20AA0()
    {
        return;
    }

    public void FUN_20AA8()
    {
        bool bVar1;
        CriStatic oVar2;

        oVar2 = SceneManager.instance.DAT_7CDC[DAT_04];
        bVar1 = InventoryManager.FUN_4A87C(2, 2);

        if (!bVar1)
            oVar2.vr.y = oVar2.vr.y + 0x40 & 0xfff;
    }

    public void FUN_20B0C()
    {
        PTR_FUN_99208[DAT_03]();
    }

    private void FUN_20B48()
    {
        DAT_03++;
        //FUN_601A4
    }

    private void FUN_20B78()
    {
        PTR_FUN_99214[DAT_04]();
    }

    private void FUN_20BB4()
    {
        bool bVar1;
        int iVar2;
        uint uVar3;
        uint uVar4;

        uVar3 = 0;
        uVar4 = DAT_02;

        do
        {
            bVar1 = InventoryManager.FUN_4A87C(11, uVar4);
            uVar3++;

            if (!bVar1)
            {
                GameManager.instance.FUN_5C94C(null, 214);
                DAT_03++;
                InventoryManager.FUN_4A7E8(2, 10, true);
                iVar2 = DialogManager.instance.FUN_1CC54(32);
                DialogManager.instance.FUN_1E2D8(DialogManager.DAT_98628, iVar2, 0, 0xffff);
                return;
            }

            uVar4 += 7;
        } while (uVar3 < 2);

        GameManager.instance.FUN_5C94C(null, 212);
        DAT_04++;
        GameManager.instance.DAT_38 = 0x7f;
        iVar2 = InventoryManager.instance.FUN_67BF8(5);
        DAT_18 = (byte)iVar2; //write int instead byte??
    }

    private void FUN_20C94()
    {
        uint uVar3;

        uVar3 = InventoryManager.instance.FUN_67C30();

        if ((uVar3 & 0x8000) == 0)
        {
            if ((uVar3 & 0x2000) == 0)
            {
                if ((uVar3 & 0x1000) == 0)
                {
                    if ((uVar3 & 0x4000) == 0)
                    {
                        if ((InputManager.controllers[0].DAT_B58B8 & 0x40) == 0)
                        {
                            if ((InputManager.controllers[0].DAT_B58B8 & 0xa0) != 0)
                            {
                                if (DAT_14 == 0 && DAT_13 == 9)
                                {
                                    //...
                                }
                            }
                        }
                    }
                }
            }
        }
    }

    private void FUN_215E0()
    {
        bool bVar1;
        int iVar2;
        uint uVar3;
        uint uVar4;

        bVar1 = InventoryManager.FUN_4A87C(2, 9);

        if (!bVar1)
            GameManager.instance.FUN_5C94C(null, 214);
        else
        {
            GameManager.instance.FUN_5C94C(null, 213);
            iVar2 = DialogManager.instance.FUN_1CC54(31);
            DialogManager.instance.FUN_1E2D8(DialogManager.DAT_98628, iVar2, 0, 0xffff);
            uVar4 = DAT_02;
            uVar3 = 0;

            do
            {
                InventoryManager.FUN_4A7E8(11, uVar4, false);
                uVar3++;
                uVar4 += 7;
            } while (uVar3 < 2);
        }

        DAT_03++;
        GameManager.instance.DAT_38 = 0;
        InventoryManager.instance.FUN_67BF8(DAT_18); //read int instead byte??
        InventoryManager.instance.FUN_674E8(0xe, 0xe);
    }

    public void FUN_21758()
    {
        bool bVar1;
        bool bVar2;
        CriStatic oVar3;

        oVar3 = SceneManager.instance.DAT_7CDC[DAT_04];

        if (DAT_03 == 0)
        {
            DAT_03++;
            bVar1 = InventoryManager.FUN_4A87C(0, DAT_05);
            DAT_09 = bVar1;
            PTR_FUN_99224[bVar1 ? 1 : 0](oVar3);
        }
        else
        {
            if (DAT_03 == 1)
            {
                bVar2 = InventoryManager.FUN_4A87C(0, DAT_05);
                DAT_0A = (byte)(bVar2 ? 1 : 0);

                if (DAT_09 != bVar2)
                {
                    GameManager.instance.FUN_5C94C(oVar3, DAT_99220[DAT_0A]);
                    DAT_0B = (sbyte)DAT_0A;
                }

                DAT_09 = DAT_0A != 0;
                PTR_FUN_99224[DAT_0A](oVar3);
                //FUN_219AC
                DAT_0B = -1;
            }
        }
    }

    private void FUN_21890(CriStatic param1)
    {
        byte bVar1;
        uint uVar2;
        CriStatic oVar3;

        oVar3 = SceneManager.instance.DAT_7CDC[System.Array.IndexOf(SceneManager.instance.DAT_7CDC, param1) + 1];
        SceneManager.instance.FUN_8133C(DAT_06, 0x8000, 0);
        SceneManager.instance.FUN_8133C(DAT_06, 0x2000, 1);
        bVar1 = (byte)(BDAT_08 + 1);
        BDAT_08 = bVar1;

        if ((bVar1 & 1) == 0)
        {
            param1.flags &= 0xfffffffd;
            uVar2 = oVar3.flags | 2;
        }
        else
        {
            param1.flags |= 2;
            uVar2 = oVar3.flags & 0xfffffffd;
        }

        oVar3.flags = uVar2;
    }

    private void FUN_2193C(CriStatic param1)
    {
        CriStatic oVar1;

        oVar1 = SceneManager.instance.DAT_7CDC[System.Array.IndexOf(SceneManager.instance.DAT_7CDC, param1) + 1];
        SceneManager.instance.FUN_8133C(DAT_06, 0x8000, 1);
        SceneManager.instance.FUN_8133C(DAT_06, 0x2000, 0);
        param1.flags &= 0xfffffffd;
        oVar1.flags &= 0xfffffffd;
    }

    private void FUN_219AC()
    {
        uint uVar1;
        sbyte sVar3;
        int iVar4;
        CriSkinned oVar5;
        CriStatic oVar6;
        uint uVar8;

        uVar8 = 0;
        oVar6 = SceneManager.instance.DAT_7CDC[DAT_04];

        do
        {
            //...
            uVar1 = GameManager.instance.FUN_835F4(oVar6);

            if ((uVar1 & 0xff) != 0xff)
            {
                oVar5 = SceneManager.instance.DAT_27C[uVar1 & 0xff];
                iVar4 = (int)uVar1 >> 0x10;

                if (oVar5.tags == 0)
                    oVar5.FUN_21CCC(oVar6, iVar4);

                sVar3 = oVar5.tags;

                if (sVar3 == 2)
                {

                }
            }
        }
    }

    private void FUN_5FF98()
    {
        DAT_00 = 0;
    }
}
