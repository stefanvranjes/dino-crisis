using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P20 : SharedAssets
{
    public static new P20 instance;
    private delegate void FUN_1910(CriPlayer p); //0x1910 (P20)
    private delegate void FUN_1938(CriPlayer p); //0x1938 (P20)
    private delegate void FUN_1940(CriPlayer p); //0x1940 (P20)
    private static Vector3Int[] DAT_18E0 = new Vector3Int[4]
    {
        new Vector3Int(-700, 0, 200), new Vector3Int(-8000, 0, 20200),
        new Vector3Int(8000, 0, 20200), new Vector3Int(700, 0, 200)
    };
    private static FUN_1910[] PTR_FUN_1910; //0x1910 (P20)
    private static FUN_1938[] PTR_FUN_1938; //0x1938 (P20)
    private static FUN_1940[] PTR_FUN_1940; //0x1940 (P20)

    protected override void Awake()
    {
        base.Awake();

        if (instance == null)
        {
            instance = this;
            PTR_FUN_9CE84[1] = new FUN_9CE84[4]
            {
                FUN_04,
                FUN_04,
                FUN_04,
                FUN_04
            };
            PTR_FUN_9CE84[2] = new FUN_9CE84[4]
            {
                FUN_04,
                FUN_04,
                FUN_04,
                FUN_04
            };
            PTR_FUN_1910 = new FUN_1910[3]
            {
                FUN_40, 
                FUN_250, 
                FUN_5EC
            };
            PTR_FUN_1938 = new FUN_1938[2]
            {
                FUN_10C, 
                FUN_1B4
            };
            PTR_FUN_1940 = new FUN_1940[4]
            {
                FUN_654, 
                FUN_80C, 
                FUN_8C0, 
                FUN_95C
            };
        }
    }

    protected override void Start()
    {
        base.Start();
        assets.Add(317, this);
    }

    public override void Init()
    {
        base.Init();
        SHARED = new UIntUIntDictionary
        {
            { 0x8017b83c, 0x801679D4 },
            { 0x8017b840, 0x80160000 },
            { 0x8017b844, 0x80192664 },
            { 0x8017b848, 0x801936dc },
            { 0x8017b84c, 0x8019420c },
            { 0x8017b850, 0x80193044 },
            { 0x8017b854, 0x80163b74 },
            { 0x8017b858, 0x801646a4 },
            { 0x8017b85c, 0x80198838 },
            { 0x8017b860, 0x80199220 },
            { 0x8017b864, 0x8019b658 },
            { 0x8017b868, 0x8019420c },
            { 0x8017b86c, 0x8019a7d8 },
            { 0x8017b870, 0x80165324 },
            { 0x8017b874, 0x80165e54 },
            { 0x8017b878, 0x80198d2c },
            { 0x8017b87c, 0x80199ca8 },
            { 0x8017b880, 0x8019b658 },
            { 0x8017b884, 0x8019420c },
            { 0x8017b888, 0x8019af18 },
            { 0x8017b88c, 0x80165324 },
            { 0x8017b890, 0x80165e54 },
            { 0x8017b894, 0x8016147c },
            { 0x8017b898, 0x80160698 },
            { 0x8017b89c, 0x80162260 },
            { 0x8017b8a0, 0x80166ad4 },
            { 0x8017b8a4, 0x80166b34 },
            { 0x8017b8a8, 0x80166b94 },
            { 0x8017b8ac, 0x80161778 },
            { 0x8017b8b0, 0x80160994 },
            { 0x8017b8b4, 0x801627b0 },
            { 0x8017b8b8, 0x8016200c },
            { 0x8017b8bc, 0x80161228 },
            { 0x8017b8c0, 0x8016255c },
            { 0x8017b8c4, 0x80163b74 },
            { 0x8017b8c8, 0x80165324 },
            { 0x8017b8cc, 0x801646a4 },
            { 0x8017b8d0, 0x80165e54 },
            { 0x8017b8d4, 0x80167094 },
            { 0x8017b8d8, 0x80166bf4 },
            { 0x8017b8dc, 0x80167534 }
        };
    }

    //FUN_04 (P20)
    public static void FUN_04(CriPlayer param1)
    {
        PTR_FUN_1910[param1.DAT_3E](param1);
    }

    //FUN_40 (P20)
    private void FUN_40(CriPlayer param1)
    {
        uint uVar1;
        sbyte sVar2;

        uVar1 = GameManager.DAT_1f800008;
        param1.FUN_50570(DAT_18E0);
        sVar2 = (sbyte)param1.FUN_50470();
        param1.DAT_226 = sVar2;
        PTR_FUN_1938[param1.DAT_3F](param1);

        if ((uVar1 & 8) == 0)
        {
            param1.DAT_227 &= 0x7f;
            param1.DAT_3C = 1;
            param1.DAT_3D = 0;
            param1.DAT_3E = 0;
            param1.DAT_3F = 0;
            param1.DAT_18C = 0x80;
        }

        if (param1.DAT_1F6 != 0)
            param1.DAT_1F6--;
    }

    //FUN_10C (P20)
    private void FUN_10C(CriPlayer param1)
    {
        bool bVar1;

        param1.DAT_40.z = 0;
        param1.DAT_1C0 |= 1;
        param1.DAT_227 |= 0x80;
        bVar1 = param1.FUN_50128();

        if (bVar1)
            param1.DAT_241 = 1;

        param1.DAT_225 = 30;
        param1.DAT_1FB = -0x60;
        param1.FUN_50FE4((TodScriptableObject)Utilities.GetRamObject(0x8016147c),
                        (TodScriptableObject)Utilities.GetRamObject(0x80160698),
                        (TodScriptableObject)Utilities.GetRamObject(0x80162260), 0, 4);
        param1.DAT_3F++;
    }

    //FUN_1B4 (P20)
    private void FUN_1B4(CriPlayer param1)
    {
        uint uVar1;
        bool bVar2;

        uVar1 = GameManager.DAT_1f800008;
        bVar2 = param1.FUN_51178();

        if (bVar2)
        {
            if ((uVar1 & 0xa0) != 0 && (byte)param1.DAT_244[1] == 0)
                GameManager.instance.FUN_5C94C(param1, 20);

            param1.DAT_1FB = 0x70;
            param1.DAT_1F5 = 0;
            param1.DAT_3E = 1;
            param1.DAT_3F = 0;
        }
    }

    //FUN_250 (P20)
    private void FUN_250(CriPlayer param1)
    {
        byte bVar1;
        ushort uVar2;
        uint uVar3;
        bool bVar4;
        sbyte sVar5;
        byte bVar6;
        int iVar8;
        uint uVar9;

        uVar3 = GameManager.DAT_1f800008;
        bVar4 = false;

        if (param1.DAT_3F == 0)
        {
            uVar9 = param1.DAT_1C0;
            param1.DAT_40 = new Vector3Int(0, 0, 0);

            if ((uVar9 & 0x40) == 0)
                uVar9 |= 1;
            else
                uVar9 &= 0xfffffffe;

            param1.DAT_1C0 = uVar9;
            param1.FUN_50FE4((TodScriptableObject)Utilities.GetRamObject(0x80166ad4),
                            (TodScriptableObject)Utilities.GetRamObject(0x80166b34),
                            (TodScriptableObject)Utilities.GetRamObject(0x80166b94), 0, param1.DAT_1F5);
            param1.DAT_225 = 30;
            param1.DAT_3F++;
        }
        else
        {
            if (param1.DAT_3F == 1)
            {
                if (param1.DAT_18C != 0 && param1.DAT_5D == 0)
                    param1.DAT_18C = 0;

                param1.FUN_51178();
            }
        }

        if ((param1.DAT_1C0 & 0x40) != 0)
        {
            bVar4 = param1.FUN_50128();

            if (bVar4 && param1.DAT_241 == 0)
                param1.DAT_241 = 1;
        }

        param1.FUN_50570(DAT_18E0);
        iVar8 = (int)param1.FUN_50470();
        bVar1 = (byte)param1.DAT_226;
        iVar8 = ((iVar8 - bVar1) * 0x10000) >> 0x10;

        if (iVar8 < 0x11)
        {
            if (iVar8 < -0x10)
            {
                sVar5 = (sbyte)(bVar1 + (iVar8 + 0x10));

                if (iVar8 + 0x10 < -0x10)
                {
                    sVar5 = -0x10;
                    sVar5 = (sbyte)(bVar1 + sVar5);
                }

                param1.DAT_226 = sVar5;
            }
        }
        else
        {
            sVar5 = (sbyte)(bVar1 + (iVar8 - 0x10));

            if (0x10 < iVar8 - 0x10)
            {
                sVar5 = 0x10;
                sVar5 = (sbyte)(bVar1 + sVar5);
            }

            param1.DAT_226 = sVar5;
        }

        if ((param1.DAT_1C0 & 0x40) == 0)
            bVar1 = (byte)(param1.DAT_241 == 0 ? 1 : 0);
        else
            bVar1 = (byte)(param1.DAT_24C[0] | (!bVar4 ? 1 : 0));

        if ((uVar3 & 0xa00000) != 0)
        {
            uVar2 = (ushort)(param1.DAT_244[1] >> 8);

            if (uVar2 == 0xff)
                GameManager.instance.FUN_5C94C(param1, 20);
            else
            {
                if ((param1.DAT_244[1] & 0xff) == 0)
                {
                    iVar8 = InventoryManager.instance.FUN_6AB5C(uVar2 + 0x10U);

                    if (iVar8 == 0)
                        GameManager.instance.FUN_5C94C(param1, 20);
                    else
                    {
                        param1.DAT_3E = 9;
                        param1.DAT_3F = 0;
                    }
                }
            }
        }

        if ((uVar3 & 8) == 0)
        {
            param1.DAT_1F5 = param1.DAT_1F6;
            param1.DAT_3C = 1;
            param1.DAT_3D = 6;
            param1.DAT_3E = 4;
            param1.DAT_3F = 0;
            goto LAB_5C0;
        }

        if ((uVar3 & 0xa0) == 0 || param1.DAT_244[1] >> 8 == 0xff || 
            (param1.DAT_244[1] & 0xff) == 0 || param1.DAT_1F6 != 0 || bVar1 == 0)
        {
            if ((uVar3 & 0x40000) != 0)
            {
                bVar4 = param1.FUN_502B8();

                if (bVar4)
                {
                    param1.DAT_241 = 1;
                    goto LAB_5C0;
                }
            }

            if ((uVar3 & 0x1000) == 0)
            {
                if ((uVar3 & 0x4000) == 0)
                {
                    if ((uVar3 & 0xa000) == 0 || param1.DAT_241 != 0) goto LAB_5C0;

                    param1.DAT_3E = 7;
                    param1.DAT_3F = 0;
                    goto LAB_5C0;
                }

                param1.DAT_3E = 6;
                param1.DAT_3F = 0;
                bVar6 = 0x60;

                if (param1.DAT_244[1] >> 8 == 6)
                    bVar6 = 0xd0;
            }
            else
            {
                param1.DAT_3E = 5;
                param1.DAT_3F = 0;
                bVar6 = 0x1c;

                if (param1.DAT_244[1] >> 8 == 6)
                    bVar6 = 10;
            }

            param1.DAT_1F4 = bVar6;
            param1.DAT_1F5 = 4;
        }
        else
        {
            if (param1.DAT_241 != 0)
                param1.DAT_241 = 3;

            param1.DAT_3E = 2;
            param1.DAT_3F = 0;
        }

        LAB_5C0:
        if (param1.DAT_1F6 != 0)
            param1.DAT_1F6--;
    }

    //FUN_5EC (P20)
    private void FUN_5EC(CriPlayer param1)
    {
        PTR_FUN_1940[param1.DAT_3F](param1);

        if (param1.DAT_3F != 4 && param1.DAT_3F < 2)
            param1.FUN_509D8((Tod3ScriptableObject)Utilities.GetRamObject(0x8017b7bc));
    }

    //FUN_654 (P20)
    private void FUN_654(CriPlayer param1)
    {
        byte bVar1;
        CriParticle oVar3;
        CriObject oVar4;
        uint uVar5;

        if ((byte)param1.DAT_244[1] == 0)
        {
            GameManager.instance.FUN_5C94C(param1, 17);
            param1.FUN_50FE4((TodScriptableObject)Utilities.GetRamObject(0x80166ad4),
                            (TodScriptableObject)Utilities.GetRamObject(0x80166b34),
                            (TodScriptableObject)Utilities.GetRamObject(0x80166b94), 0, 2);
            bVar1 = 4;
            param1.DAT_1F4 = 0;
        }
        else
        {
            param1.DAT_227 |= 0x50;
            param1.DAT_1C0 |= 1;
            param1.DAT_244[1]--;
            InventoryManager.instance.FUN_6AB8C((uint)(param1.DAT_244[1] >> 8) + 0x10, -1);
            //...
            param1.FUN_50FE4((TodScriptableObject)Utilities.GetRamObject(0x80161778),
                            (TodScriptableObject)Utilities.GetRamObject(0x80160994),
                            (TodScriptableObject)Utilities.GetRamObject(0x801627b0), 0, 0);
            param1.DAT_1F4 = 0;
            oVar3 = SceneManager.instance.FUN_5FFA0();

            if (oVar3 != null)
            {
                oVar4 = Utilities.FUN_601C8(param1.skeleton, 3);
                oVar3.tags = 4;
                uVar5 = 0x8019e3b0;

                if (param1.DAT_244[1] >> 8 == 6)
                    uVar5 = 0x8019e3a8;

                oVar3.FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(uVar5));
                oVar3.DAT_54 = 5;
                oVar3.DAT_62 = 3;
                oVar3.DAT_60 = 3;
                oVar3.screen = oVar4.screen;
            }

            param1.FUN_50570(DAT_18E0);
            param1.FUN_5080C();
            GameManager.instance.FUN_5C94C(param1, 16);
            bVar1 = (byte)(param1.DAT_3F + 1);
        }

        param1.DAT_3F = bVar1;
    }

    //FUN_80C (P20)
    private void FUN_80C(CriPlayer param1)
    {
        uint uVar1;
        bool bVar2;

        uVar1 = GameManager.DAT_1f800008;
        param1.DAT_227 &= 0xbf;
        bVar2 = param1.FUN_51178();

        if (bVar2)
        {
            param1.DAT_227 &= 0xef;

            if ((uVar1 & 0xa0) != 0 && (byte)param1.DAT_244[1] == 0)
                GameManager.instance.FUN_5C94C(param1, 20);

            param1.DAT_1F5 = 0;
            param1.DAT_3E = 1;
            param1.DAT_3F = 0;
        }
    }

    //FUN_8C0 (P20)
    private void FUN_8C0(CriPlayer param1)
    {
        param1.DAT_40 = new Vector3Int(0, 0, 0);
        param1.FUN_50570(DAT_18E0);
        param1.DAT_226 = (sbyte)param1.FUN_50470();
        param1.DAT_18C = 0;
        param1.DAT_1C0 &= 0xfffffffe;
        param1.FUN_50FE4((TodScriptableObject)Utilities.GetRamObject(0x80166ad4),
                        (TodScriptableObject)Utilities.GetRamObject(0x80166b34),
                        (TodScriptableObject)Utilities.GetRamObject(0x80166b94), 0, 3);
        param1.DAT_3F++;
    }

    //FUN_95C (P20)
    private void FUN_95C(CriPlayer param1)
    {
        bool bVar1;

        bVar1 = param1.FUN_51178();

        if (bVar1)
            param1.DAT_3F = 0;
    }
}
