using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriPlayer : CriSkinned
{
    public uint DAT_1C0; //0x1C0
    public sbyte DAT_1C4; //0x1C4
    public byte DAT_1C6; //0x1C6
    public byte DAT_1C9; //0x1C9
    public short DAT_1CA; //0x1CA
    public byte DAT_1CD; //0x1CD
    public byte DAT_1CF; //0x1CF
    public byte DAT_1D7; //0x1D7
    public short DAT_1E8; //0x1E8
    public byte DAT_1F4; //0x1F4
    public byte DAT_1F5; //0x1F5
    public byte DAT_1F6; //0x1F6
    public byte DAT_1F7; //0x1F7
    public byte DAT_1F8; //0x1F8
    public byte DAT_1F9; //0x1F9
    public sbyte DAT_1FA; //0x1FA
    public sbyte DAT_1FB; //0x1FB
    public Vector3Int DAT_1FC; //0x1FC
    public Vector3Int DAT_204; //0x204
    public Vector2Int DAT_20C; //0x20C
    public Object[] REFS;
    public int DAT_21C; //0x21C
    public int DAT_220; //0x220
    public byte DAT_224; //0x224
    public byte DAT_226; //0x226
    public byte DAT_227; //0x227
    public byte DAT_240; //0x240
    public ushort[] DAT_244; //0x244
    public delegate void FUN_9CDE4();
    public delegate void FUN_9CE2C();
    public delegate void FUN_9CE04();
    public FUN_9CDE4[] PTR_FUN_9CDE4;
    public FUN_9CE2C[] PTR_FUN_9CE2C;
    public FUN_9CE04[] PTR_FUN_9CE04;

    protected override void Awake()
    {
        base.Awake();
        PTR_FUN_9CDE4 = new FUN_9CDE4[8]
        {
            FUN_4D23C,
            null,
            null,
            null,
            null,
            null,
            null,
            FUN_4FE04
        };
        PTR_FUN_9CE2C = new FUN_9CE2C[2]
        {
            FUN_4DCB4, 
            FUN_4DD3C
        };
        PTR_FUN_9CE04 = new FUN_9CE04[10]
        {
            FUN_4D7A4,
            FUN_4DADC,
            FUN_4DDC0,
            FUN_4DF9C,
            FUN_4E130,
            FUN_4E2F0,
            null,
            null,
            FUN_4EF74,
            FUN_4F074
        };
        DAT_244 = new ushort[3];
    }

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
        DAT_1F4 = 0;
        DAT_1F5 = 0;
        DAT_1F6 = 0;
        DAT_1F7 = 0;
        DAT_1F8 = 0;
        DAT_1F9 = 0;
        DAT_1FA = 0;
        DAT_1FB = 0;
        DAT_1FC = Vector3Int.zero;
        DAT_204 = Vector3Int.zero;
        DAT_20C = Vector2Int.zero;
        REFS = null;
        DAT_21C = 0;
        DAT_220 = 0;
        DAT_224 = 0;
        DAT_226 = 0;
        DAT_227 = 0;
        DAT_240 = 0;
        DAT_244 = new ushort[3];
    }

    public void FUN_4CFDC()
    {
        short sVar2;
        byte bVar3;
        uint uVar4;

        bVar3 = (byte)((GameManager.instance.DAT_40 ^ 1) & 1);

        if (bVar3 != 0)
        {
            DAT_34 = screen;
            //FUN_5211C
        }

        vr.y &= 0xfff;
        Utilities.RotMatrix(ref vr, ref cTransform.rotation);

        if (bVar3 != 0)
        {
            uVar4 = DAT_3C;

            if (uVar4 != 0)
            {
                FUN_659D0();
                uVar4 = DAT_3C;
            }

            PTR_FUN_9CDE4[uVar4]();
            //...
            FUN_62F3C(ref DAT_40);
            FUN_66208();

            if ((DAT_1C0 & 1) != 0 && (DAT_3C == 1 || DAT_3C == 4))
                ; //FUN_65A28


        }
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
        //FUN_4FE90(DAT_240);
        FUN_4FE90(0x20); //tmp
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
        DAT_34 = screen;
        DAT_13C = new Vector2Int(screen.x, screen.z);
        FUN_60444();
        FUN_65984(11, 14);
        DAT_175 = 0x87;
        FUN_5342C();
        FUN_4FE30();
        DAT_3C = 1;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 1;
        FUN_609C8((TodScriptableObject)REFS[DAT_220], 1, 0);
    }

    private void FUN_4FE04()
    {
        return;
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
        return; //tmp

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

    private void FUN_4D7A4()
    {
        uint uVar1;
        byte bVar2;
        byte bVar3;
        uint uVar4;
        uint uVar5;
        int iVar6;

        uVar1 = GameManager.instance.DAT_1f800008 | 
            (uint)GameManager.instance.DAT_1f80000a << 0x10;

        switch (DAT_3E)
        {
            case 0:
                DAT_40 = new Vector3Int(0, 0, 0);

                if (DAT_3F == 0)
                    iVar6 = 6;
                else
                    iVar6 = DAT_3F - 1;

                FUN_609C8((TodScriptableObject)REFS[DAT_220], 1, (byte)iVar6);
                DAT_1F4 = 90;
                DAT_1C0 |= 1;

                if (DAT_1D7 == 0)
                    DAT_3E++;
                else
                    DAT_3E = 4;

                break;
            case 1:
                if (DAT_5D == 0)
                    DAT_18C = 0;

                FUN_60AB4();
                bVar2 = (byte)(DAT_1F4 - 1);
                DAT_1F4 = bVar2;

                if (bVar2 == 0)
                {
                    if (DAT_1F8 != 0)
                    {
                        //...
                    }

                    DAT_1F4 = 90;
                }

                break;
            case 2:
                FUN_60AB4();
                bVar2 = (byte)(DAT_1F4 - 1);
                DAT_1F4 = bVar2;

                if (bVar2 == 0)
                {
                    FUN_609C8(SceneManager.instance.playerIdle, 1, 0);
                    DAT_1C0 &= 0xfffffffe;
                    uVar4 = (uint)Utilities.Rand();
                    bVar3 = Utilities.DAT_187BC[(uVar4 & 3) * 2];
                    DAT_1F4 = bVar3;
                    DAT_3E++;
                }

                break;
            case 3:
                FUN_60AB4();

                if (DAT_1F8 == 0)
                {
                    DAT_3F = 0;
                    DAT_3E = 0;
                }

                break;
            case 4:
                if (DAT_5D == 0)
                    DAT_18C = 0;

                FUN_60AB4();
                break;
        }

        //FUN_4A7E8

        if ((uVar1 & 8) != 0)
        {
            DAT_18C = 0;
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
            return;
        }

        if (DAT_1C6 == 0 || (uVar1 & 2) == 0)
        {
            if ((uVar1 & 0xa00000) != 0)
            {
                DAT_18C = 0;
                //FUN_4A7E8
                return;
            }

            if ((uVar1 & 0x1000) == 0)
            {
                uVar5 = 0x401;

                if ((uVar1 & 0xa000) != 0)
                {
                    DAT_18C = 0;
                    goto LAB_4DAC0;
                }

                if ((uVar1 & 0x4000) == 0)
                    return;

                DAT_18C = 0;
                DAT_1F5 = 2;
                uVar5 = 0x201;
            }
            else
            {
                DAT_18C = 0;

                if ((uVar1 & 0x40) == 0)
                {
                    DAT_1F5 = 4;
                    uVar5 = 0x101;
                }
                else
                {
                    DAT_1F5 = 10;
                    uVar5 = 0x501;
                }
            }

            DAT_1F4 = 0;
        }
        else
            uVar5 = 0x1000901;

        LAB_4DAC0:
        DAT_3C = (byte)(uVar5 & 0xff);
        DAT_3D = (byte)((uVar5 & 0xff00) >> 8);
        DAT_3E = (byte)((uVar5 & 0xff0000) >> 0x10);
        DAT_3F = (byte)((uVar5 & 0xff000000) >> 0x18);
    }

    private void FUN_4DADC()
    {
        short sVar1;
        uint uVar2;
        byte bVar3;
        uint uVar4;

        uVar4 = GameManager.instance.DAT_1f800008 | 
            (uint)GameManager.instance.DAT_1f80000a << 0x10;
        PTR_FUN_9CE2C[DAT_3E]();
        //FUN_4A7E8

        if ((uVar4 & 8) != 0)
        {
            uVar4 = frameNum + 6U;
            bVar3 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
            DAT_1F5 = 8;
            DAT_1F6 = bVar3;
            DAT_1F4 = (byte)(uVar4 + (uVar4 / 33) * -33);
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 5;
            DAT_3F = 0;
            return;
        }

        if ((uVar4 & 0xa00000) != 0)
        {
            //FUN_4A7E8
            return;
        }

        if ((uVar4 & 0x1000) == 0)
        {
            uVar2 = 1;

            if (DAT_5D == 0)
            {
                bVar3 = 0x80;

                if (14U < frameNum)
                    bVar3 = 0x81;

                DAT_18C = bVar3;
                uVar2 = 1;
            }

            goto LAB_4DC9C;
        }

        if ((uVar4 & 0x2000) == 0)
        {
            if ((uVar4 & 0x8000) != 0)
            {
                sVar1 = (short)(vr.y - 0x20);
                vr.y = sVar1;
            }
        }
        else
        {
            sVar1 = (short)(vr.y + 0x20);
            vr.y = sVar1;
        }

        if ((uVar4 & 0x40) == 0)
            return;

        DAT_1F5 = 10;
        DAT_1F4 = (byte)((uint)(frameNum * 20) / 30);
        uVar2 = 0x501;
        LAB_4DC9C:
        DAT_3C = (byte)(uVar2 & 0xff);
        DAT_3D = (byte)((uVar2 & 0xff00) >> 8);
        DAT_3E = (byte)((uVar2 & 0xff0000) >> 0x10);
        DAT_3F = (byte)((uVar2 & 0xff000000) >> 0x18);
    }

    private void FUN_4DCB4()
    {
        short sVar1;

        FUN_6103C((TodScriptableObject)REFS[DAT_220 + 1], 1, DAT_1F4, DAT_1F5);
        DAT_18C = 0;
        sVar1 = Utilities.DAT_18790[DAT_1D7];
        DAT_1C0 &= 0xfffffffe;
        DAT_40.z = sVar1;
        DAT_1F4 = 0;
        DAT_3E = 1;
    }

    private void FUN_4DD3C()
    {
        bool bVar1;

        //FUN_4E694
        bVar1 = false; //tmp

        if (!bVar1)
            DAT_1F4 = 0;
        else
            DAT_1F4++;

        if (15U < DAT_1F4)
        {
            DAT_1F4 = 0;
            DAT_3C = 1;
            DAT_3D = 7;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_40 = new Vector3Int(0, 0, 0);
        }

        FUN_60AB4();
    }

    private void FUN_4DDC0()
    {
        short sVar1;
        uint uVar2;
        uint uVar3;
        byte bVar4;

        uVar2 = GameManager.instance.DAT_1f800008 | 
            (uint)GameManager.instance.DAT_1f80000a << 0x10;

        if (DAT_3E == 0)
        {
            FUN_6103C((TodScriptableObject)REFS[DAT_220 + 2], 1, DAT_1F4, DAT_1F5);
            DAT_1C0 &= 0xfffffffe;
            sVar1 = Utilities.DAT_187A0[DAT_1D7];
            DAT_3E++;
            DAT_40.z = sVar1;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }

        //FUN_4A7E8

        if ((uVar2 & 8) == 0)
        {
            if ((uVar2 & 0x4000) == 0)
            {
                bVar4 = 0x80;

                if (17U < frameNum)
                    bVar4 = 0x81;

                uVar3 = 1;
                DAT_18C = bVar4;
            }
            else
            {
                if ((uVar2 & 0x2000) == 0)
                {
                    if ((uVar2 & 0x8000) == 0)
                        DAT_40.z = -40;
                    else
                    {
                        DAT_40.z = -30;
                        vr.y -= 0x20;
                    }
                }
                else
                {
                    DAT_40.z = -30;
                    vr.y += 0x20;
                }

                DAT_1F5 = 6;
                uVar3 = 0x301;
                DAT_1F4 = 0;
            }

            DAT_3C = (byte)(uVar3 & 0xff);
            DAT_3D = (byte)((uVar3 & 0xff00) >> 8);
            DAT_3E = (byte)((uVar3 & 0xff0000) >> 0x10);
            DAT_3F = (byte)((uVar3 & 0xff000000) >> 0x18);
        }
        else
        {
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 6;
            DAT_3F = 0;
            DAT_1F5 = 8;

            if (frameCount == 0)
                return; //trap(0x1c00)

            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
            DAT_1F5 = (byte)(((uint)frameNum << 8) / frameCount);
        }
    }

    private void FUN_4DF9C()
    {
        uint uVar1;
        uint uVar2;
        byte bVar3;

        uVar1 = GameManager.instance.DAT_1f800008 | 
            (uint)GameManager.instance.DAT_1f80000a << 0x10;

        if (DAT_3E == 0)
        {
            FUN_6103C((TodScriptableObject)REFS[DAT_220 + 3], 1, DAT_1F4, DAT_1F5);
            DAT_40.z = -40;
            DAT_1C0 &= 0xfffffffe;
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }

        //FUN_4A7E8

        if ((uVar1 & 8) == 0)
        {
            if ((uVar1 & 0x4000) == 0)
                uVar2 = 1;
            else
            {
                if ((uVar1 & 0x2000) == 0)
                {
                    if ((uVar1 & 0x8000) == 0)
                        DAT_40.z = -40;
                    else
                    {
                        DAT_40.z = -20;
                        vr.y -= 0x20;
                    }
                }
                else
                {
                    DAT_40.z = -20;
                    vr.y += 0x20;
                }

                if (DAT_1C4 == 0)
                    return;

                DAT_1F5 = 2;
                uVar2 = 0x201;
                DAT_1F4 = 0;
            }

            DAT_3C = (byte)(uVar2 & 0xff);
            DAT_3D = (byte)((uVar2 & 0xff00) >> 8);
            DAT_3E = (byte)((uVar2 & 0xff0000) >> 0x10);
            DAT_3F = (byte)((uVar2 & 0xff000000) >> 0x18);
        }
        else
        {
            bVar3 = 0x80;

            if (18U < frameNum)
                bVar3 = 0x81;

            DAT_18C = bVar3;
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
        }
    }

    private void FUN_4E130()
    {
        uint uVar1;
        short sVar2;
        uint uVar3;

        uVar1 = GameManager.instance.DAT_1f800008 |
            (uint)GameManager.instance.DAT_1f80000a << 0x10;

        if (DAT_3E == 0)
        {
            FUN_609C8((TodScriptableObject)REFS[DAT_220 + 1], 1, 10);
            DAT_18C = 0;
            DAT_40.z = 0;
            DAT_1C0 &= 0xfffffffe;
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }

        //FUN_4A7E8

        if ((uVar1 & 0x2000) == 0)
        {
            if ((uVar1 & 0x8000) == 0) goto LAB_4E218;

            sVar2 = (short)(vr.y - 90);
        }
        else
            sVar2 = (short)(vr.y + 90);

        vr.y = sVar2;

        LAB_4E218:
        if ((uVar1 & 8) == 0)
        {
            if ((uVar1 & 0xa00000) == 0)
            {
                if ((uVar1 & 0x1000) == 0)
                {
                    if ((uVar1 & 0x4000) == 0)
                    {
                        if ((uVar1 & 0xa000) != 0)
                            return;

                        DAT_18C = 1;
                        uVar3 = 1;
                    }
                    else
                    {
                        DAT_1F5 = 2;
                        uVar3 = 0x201;
                        DAT_1F4 = 0;
                    }
                }
                else
                {
                    DAT_18C = 0;
                    DAT_1F5 = 4;
                    DAT_1F4 = frameNum;
                    uVar3 = 0x101;
                }

                DAT_3C = (byte)(uVar3 & 0xff);
                DAT_3D = (byte)((uVar3 & 0xff00) >> 8);
                DAT_3E = (byte)((uVar3 & 0xff0000) >> 0x10);
                DAT_3F = (byte)((uVar3 & 0xff000000) >> 0x18);
            }
            else
                ; //FUN_4A7E8
        }
        else
        {
            DAT_18C = 1;
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 0;
            DAT_3F = 0;
            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
        }
    }

    private void FUN_4E2F0()
    {
        byte bVar1;
        short sVar2;
        short sVar3;
        uint uVar4;
        byte bVar5;
        bool bVar6;
        short sVar7;

        uVar4 = GameManager.instance.DAT_1f800008 |
            (uint)GameManager.instance.DAT_1f80000a << 0x10;
        bVar1 = DAT_3E;

        if (bVar1 == 1)
        {
            bVar1 = DAT_3F;
            sVar7 = Utilities.DAT_18798[DAT_1D7];
            sVar2 = Utilities.DAT_18790[DAT_1D7];
            bVar5 = (byte)(DAT_3F + 1);
            DAT_3F = bVar5;
            DAT_40.z = (short)((((sVar7 * bVar1 + sVar2 * (10 - bVar1)) * 0x10000) >> 0x10) / 10);

            if (10U < bVar5)
            {
                DAT_40.z = Utilities.DAT_18798[DAT_1D7];
                DAT_1F4 = 0;
                DAT_3E++;
            }

            FUN_4E490();
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    if (19U < DAT_1F4)
                        DAT_1F4 = 18;

                    FUN_6103C((TodScriptableObject)REFS[DAT_220 + 4], 1, DAT_1F4, DAT_1F5);
                    DAT_1C0 &= 0xfffffffe;
                    DAT_3F = 0;
                    sVar3 = Utilities.DAT_18798[DAT_1D7];
                    DAT_3E++;
                    DAT_40.z = sVar3;
                }
            }
            else
            {
                if (bVar1 == 2)
                    FUN_4E490();
            }
        }

        //FUN_4A7E8

        if ((uVar4 & 8) != 0)
        {
            DAT_1F5 = 6;
            uVar4 = ((uint)frameNum * 34) / 22;
            DAT_1F6 = Utilities.DAT_187B8[(uint)DAT_240 >> 4];
            DAT_1F4 = (byte)((int)uVar4 + (int)(uVar4 / 34) * -34);
            DAT_3C = 1;
            DAT_3D = 6;
            DAT_3E = 5;
            DAT_3F = 0;
            //FUN_4FE0C
            return;
        }

        if ((uVar4 & 0xa00000) != 0)
        {
            //FUN_4A7E8
            return;
        }

        if ((uVar4 & 0x1000) == 0)
        {
            DAT_18C = 1;
            DAT_3C = 1;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
            //FUN_4FE0C
            return;
        }

        if ((uVar4 & 0x2000) == 0)
        {
            if ((uVar4 & 0x8000) == 0) goto LAB_4E62C;

            sVar7 = (short)(vr.y - 40);
        }
        else
            sVar7 = (short)(vr.y + 40);

        vr.y = sVar7;

        LAB_4E62C:
        if ((uVar4 & 0x40) == 0)
        {
            DAT_18C = 0;
            DAT_1F5 = 4;
            DAT_1F4 = (byte)(((uint)frameNum * 30) / 20);
            DAT_3C = 1;
            DAT_3D = 1;
            DAT_3E = 0;
            DAT_3F = 0;
        }

        void FUN_4E490()
        {
            //FUN_4E694
            bVar6 = false; //tmp

            if (!bVar6)
                DAT_1F4 = 0;
            else
                DAT_1F4++;

            if (15U < DAT_1F4)
            {
                DAT_1F4 = 0;
                DAT_3C = 1;
                DAT_3D = 7;
                DAT_3E = 0;
                DAT_3F = 0;
                DAT_40 = new Vector3Int(0, 0, 0);
            }

            FUN_60AB4();
        }
    }

    private void FUN_4EF74()
    {
        bool bVar1;
        uint uVar2;

        switch (DAT_3E)
        {
            case 0:
                uVar2 = 0;
                goto LAB_4F028;
            case 1:
                bVar1 = FUN_60AB4();

                if (bVar1)
                    DAT_3E++;

                if (DAT_60 == 10)
                    ; //FUN_5C94C

                break;
            case 2:
                FUN_60AB4();
                break;
            case 3:
                uVar2 = 2;
                LAB_4F028:
                FUN_609C8(SceneManager.instance.DAT_1860CC, (byte)uVar2, 0);
                DAT_3E++;
                break;
            case 4:
                bVar1 = FUN_60AB4();

                if (bVar1)
                {
                    //FUN_5C94C
                    DAT_3C = 1;
                    DAT_3D = 0;
                    DAT_3E = 0;
                    DAT_3F = 0;
                }

                break;
            default:
                return;
        }
    }

    private void FUN_4F074()
    {
        ushort uVar1;
        TodScriptableObject oVar2;
        uint uVar3;

        if (DAT_3E == 0)
        {
            DAT_40.z = 0;
            DAT_1C0 &= 0xfffffffe;

            if (DAT_3F == 0)
            {
                oVar2 = (TodScriptableObject)REFS[DAT_220];
                uVar3 = 14;
            }
            else
            {
                oVar2 = (TodScriptableObject)REFS[DAT_220 + 1];
                uVar3 = 5;
            }

            FUN_609C8(oVar2, 1, (byte)uVar3);
            DAT_1F4 = (byte)(vr.y & 0xff);
            DAT_1F5 = (byte)((vr.y & 0xff00) >> 8);
            DAT_1F6 = (byte)(vr.y + 0x800 & 0xff);
            DAT_1F7 = (byte)((vr.y + 0x800 & 0xff00) >> 8);
            DAT_3E++;
        }
        else
        {
            if (DAT_3E == 1)
                FUN_60AB4();
        }

        uVar1 = (ushort)((short)(DAT_1F4 | DAT_1F5 << 8) +
                        Utilities.DAT_187A8[DAT_1D7]);
        DAT_1F4 = (byte)(uVar1 & 0xff);
        DAT_1F5 = (byte)((uVar1 & 0xff00) >> 8);
        vr.y = (short)(uVar1 & 0xfff);

        if ((short)(DAT_1F6 | DAT_1F7 << 8) <= (short)(DAT_1F4 | DAT_1F5 << 8))
        {
            vr.y = (short)(DAT_1F6 | DAT_1F7 << 8);
            DAT_1C6 = 0;
            DAT_40.z = 0;
            DAT_40.x = 0;
            DAT_18C = 0;
            DAT_3C = 0;
            DAT_3D = 0;
            DAT_3E = 0;
            DAT_3F = 0;
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
