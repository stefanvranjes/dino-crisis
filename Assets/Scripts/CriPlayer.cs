using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriPlayer : CriSkinned
{
    public uint DAT_3C_2; //0x3C
    public uint DAT_1C0; //0x1C0
    public byte DAT_1C6; //0x1C6
    public byte DAT_1C9; //0x1C9
    public short DAT_1CA; //0x1CA
    public byte DAT_1CD; //0x1CD
    public byte DAT_1CF; //0x1CF
    public byte DAT_1D7; //0x1D7
    public short DAT_1E8; //0x1E8
    public byte DAT_1F8; //0x1F8
    public byte DAT_1F9; //0x1F9
    public sbyte DAT_1FA; //0x1FA
    public sbyte DAT_1FB; //0x1FB
    public Vector3Int DAT_1FC; //0x1FC
    public Vector3Int DAT_204; //0x204
    public Vector2Int DAT_20C; //0x20C
    public int DAT_21C; //0x21C
    public int DAT_220; //0x220
    public byte DAT_224; //0x224
    public byte DAT_226; //0x226
    public byte DAT_227; //0x227
    public byte DAT_240; //0x240
    public ushort[] DAT_244; //0x244

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_1C0 = 0;
        DAT_1C6 = 0;
        DAT_1C9 = 0;
        DAT_1CA = 0;
        DAT_1CD = 0;
        DAT_1CF = 0;
        DAT_1D7 = 0;
        DAT_1E8 = 0;
        DAT_1F8 = 0;
        DAT_1F9 = 0;
        DAT_1FA = 0;
        DAT_1FB = 0;
        DAT_1FC = Vector3Int.zero;
        DAT_204 = Vector3Int.zero;
        DAT_20C = Vector2Int.zero;
        DAT_21C = 0;
        DAT_220 = 0;
        DAT_224 = 0;
        DAT_226 = 0;
        DAT_227 = 0;
        DAT_240 = 0;
        DAT_244 = new ushort[3];
    }

    public void FUN_4D23C()
    {
        short sVar2;

        flags = 1;
        tags = 0;
        FUN_604A4(SceneManager.instance.playerSkin);
        sVar2 = 1200;

        if (GameManager.instance.difficulty != _DIFFICULTY.Normal)
            sVar2 = 2400;

        maxHealth = sVar2;
        health = GameManager.instance.playerHealth;
        DAT_240 = GameManager.instance.DAT_A100;
        DAT_1C0 = GameManager.instance.DAT_A0F4;
        DAT_1E8 = GameManager.instance.DAT_A0F2;
        DAT_244 = new ushort[3] { GameManager.instance.DAT_A0F8[0],
                                  GameManager.instance.DAT_A0F8[1],
                                  GameManager.instance.DAT_A0F8[2] };
        FUN_4FE90(DAT_240);
        FUN_65984(11, 14);
        FUN_66404(8, 0x1000, 0x1000);
        DAT_1CF = 0;
        DAT_1C6 = 0;
        DAT_1F9 = 0;
        DAT_1F8 = 0;
        DAT_1CA = 0;
        DAT_1C9 = 0;
        DAT_1CD = 0;
        DAT_227 = 0;
        DAT_177 = 0;
        DAT_152 = 0;
        DAT_140 = 0;
        DAT_12C = 0;
        DAT_11E = 0;
        DAT_226 = 0x80;
        //...
        DAT_18D = true;
        DAT_12E = true;
        DAT_12F = true;
        DAT_46 = 320;
        flags |= 2;
        //FUN_4FE0C
        DAT_34_2 = screen;
        DAT_13C = new Vector2Int(screen.x, screen.z);
        FUN_60444();
        FUN_65984(11, 14);
        DAT_175 = 0x87;
        FUN_5342C();
        FUN_4FE30();
        DAT_3C_2 = 0x1000001;
        //FUN_609C8
    }

    private void FUN_4FE90(uint param1)
    {
        sbyte sVar1;
        CriObject oVar2;
        uint uVar3;
        uint uVar4;
        CriObject oVar6;
        uint uVar8;

        uVar4 = param1 & 3;
        param1 >>= 4;
        uVar3 = (uint)DAT_244[param1 - 1] >> 8;
        DAT_1C0 &= 0xffffffbf;
        uVar8 = uVar4;

        if (param1 == 2)
        {
            if (1 < uVar4 && uVar3 != 7)
            {
                uVar8 = uVar4 - 2;
                uVar4 = uVar8 & 0xff;
            }

            if ((uVar4 == 1 || uVar4 == 3) && GameManager.instance.DAT_A2D0)
                DAT_1C0 |= 0x40;
        }

        if (param1 == 1 && (uVar8 & 0xff) == 1 && uVar3 - 2 < 4)
            uVar8 = 0;

        if (uVar3 == 9)
            uVar8 += 2;

        if (GameManager.instance.DAT_A2D3 == 3)
            uVar8 += 4;

        if (param1 != 0)
        {
            //load player core file
        }

        uVar4 = 0;
        //...
        oVar2 = Utilities.FUN_601C8(skeleton, 3);
        //...
        FUN_4FE30();

        do
        {
            oVar6 = SceneManager.instance.DAT_5FCC[uVar4];
            sVar1 = oVar6.tags;

            if (sVar1 == 4 || sVar1 == 7 || sVar1 == 12)
                oVar6.FUN_60068();

            uVar4++;
        } while (uVar4 < 60);
    }

    private void FUN_4FE30()
    {
        if (550 < health)
        {
            DAT_1D7 = 0;
            DAT_220 = DAT_21C + 4;
        }

        else if (250 < health)
        {
            DAT_1D7 = 1;
            DAT_220 = DAT_21C + 32;
        }
        else
        {
            DAT_1D7 = 2;
            DAT_220 = DAT_21C + 60;
        }
    }

    private void FUN_52320()
    {
        CriBone oVar1;
        long lVar2;
        Vector3Int local_50;
        Vector3Int local_48;
        Matrix3x3 MStack56;
        Vector3Int SStack64;

        DAT_204.z = 0;
        oVar1 = Utilities.FUN_601C8(skeleton, 7) as CriBone;
        local_50 = oVar1.screen;
        local_48 = new Vector3Int();
        local_48.y = Utilities.FUN_615EC(local_50, DAT_1FC);
        DAT_204.y = local_48.y;
        local_48.y = 0x1000 - local_48.y;
        local_48.z = 0;
        local_48.x = 0;
        MStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref local_48, ref MStack56);
        local_48.x = DAT_1FC.x - local_50.x;
        local_48.y = DAT_1FC.y - local_50.y;
        local_48.z = DAT_1FC.z - local_50.z;
        SStack64 = Utilities.ApplyMatrixSV(ref MStack56, ref local_48);
        lVar2 = Utilities.Ratan2(SStack64.y, SStack64.z);
        DAT_204.x = 0x1000 - (int)(lVar2 & 0xfff);
    }

    private void FUN_5342C()
    {
        CriObject oVar2;

        oVar2 = Utilities.FUN_601C8(skeleton, 7);
        DAT_20C = new Vector2Int(oVar2.vr.x, oVar2.vr.y);
        DAT_1F9 = 0;
        DAT_1F8 = 0;
        FUN_5348C(0x70, 0x70);
    }

    private void FUN_5348C(sbyte param1, sbyte param2)
    {
        CriBone oVar1;

        DAT_164 = 8;

        if (param1 == -1)
        {
            FUN_52538();
            FUN_52320();
            DAT_20C.x = DAT_204.x;
            DAT_20C.y = DAT_204.y;
        }
        else
        {
            DAT_1FA = param1;

            if (param2 == -1)
                DAT_1FB = 0;
            else
                DAT_1FB = param2;
        }

        oVar1 = Utilities.FUN_601C8(skeleton, 7) as CriBone;
        oVar1.DAT_43 = true;
    }

    private void FUN_52538()
    {
        CriSkinned oVar1;
        CriBone oVar2;

        oVar1 = SceneManager.instance.DAT_27C[DAT_224];
        oVar2 = Utilities.FUN_601C8(oVar1.skeleton, oVar1.DAT_175 & 0xf) as CriBone;
        DAT_1FC = oVar2.screen;
    }
}
