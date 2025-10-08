using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriCamera : CriObject
{
    public short SDAT_2E; //0x2E
    public Vector3Int DAT_30; //0x30
    public short DAT_36; //0x36
    public short DAT_38; //0x38
    public short DAT_3A; //0x3A
    public ushort DAT_3C; //0x3C
    public short DAT_3E; //0x3E
    public Vector3Int DAT_40; //0x40
    public short DAT_46; //0x46
    public Vector3Int DAT_48; //0x48
    public short DAT_4E; //0x4E
    public short DAT_50; //0x50
    public short DAT_52; //0x52
    public short DAT_54; //0x54
    public short DAT_56; //0x56
    public sbyte DAT_58; //0x58
    public sbyte DAT_59; //0x59
    public sbyte DAT_5A; //0x5A
    public sbyte DAT_5B; //0x5B
    public CameraMotion motion; //0x5C
    public CriObject DAT_64; //0x64
    public byte DAT_68; //0x68
    public byte DAT_69; //0x69
    public byte DAT_6A; //0x6A
    public bool DAT_6B; //0x6B
    public byte DAT_70; //0x70
    public byte DAT_71; //0x71
    public byte DAT_72; //0x72
    public byte DAT_73; //0x73
    public short DAT_74; //0x74
    public short DAT_76; //0x76
    public ushort DAT_78; //0x78
    public Vector3Int DAT_7C; //0x7C
    public byte DAT_82; //0x82
    public byte DAT_83; //0x83
    public Vector3Int DAT_84; //0x84
    public byte DAT_8A; //0x8A
    public byte DAT_8B; //0x8B
    public delegate void FUN_8C();
    public FUN_8C PTR_FUN_8C;
    public short DAT_90; //0x90
    public short DAT_92; //0x92

    private delegate void FUN_18448();
    private delegate void FUN_99404(CameraMotion m);
    private FUN_18448[] PTR_FUN_18448;
    private FUN_99404[] PTR_FUN_99404;
    public FUN_8C[] PTR_FUN_9C618;
    public FUN_8C[] PTR_FUN_168A4; //0x168A4 (ST9)
    public FUN_8C[] PTR_FUN_16ACC; //0x16ACC (ST6)
    public FUN_8C[] PTR_FUN_16AD4; //0x16AD4 (ST6)
    public static CameraMotion DAT_99498;

    protected override void Awake()
    {
        base.Awake();
        PTR_FUN_18448 = new FUN_18448[10]
        {
            FUN_27320,
            null,
            FUN_27444,
            FUN_27478,
            FUN_2753C,
            FUN_2765C,
            FUN_27720,
            FUN_277B8,
            FUN_278B4,
            FUN_27944
        };
        PTR_FUN_99404 = new FUN_99404[37]
        {
            FUN_27BC4,
            FUN_27C04,
            FUN_27BC4,
            FUN_27C28,
            FUN_27C7C,
            FUN_27BC4,
            FUN_27BC4,
            FUN_27D58,
            FUN_27E64,
            FUN_27F50,
            FUN_2803C,
            FUN_280F0,
            FUN_27BC4,
            FUN_27BC4,
            FUN_27BC4,
            FUN_27BC4,
            FUN_27BC4,
            FUN_281A4,
            FUN_28298,
            FUN_28388,
            FUN_28454,
            FUN_2851C,
            FUN_27BC4,
            FUN_27BC4,
            FUN_27BC4,
            FUN_27BC4,
            FUN_28544,
            FUN_27BC4,
            FUN_27BC4,
            FUN_27BC4,
            FUN_27BC4,
            FUN_287B0,
            FUN_288B4,
            FUN_2892C,
            FUN_289A4,
            FUN_289D8,
            FUN_28A0C
        };
        PTR_FUN_9C618 = new FUN_8C[2]
        {
            FUN_2EF40,
            FUN_2EFE8
        };
        PTR_FUN_168A4 = new FUN_8C[4]
        {
            FUN_C4FC,
            FUN_C5AC,
            FUN_C5D4,
            FUN_C6FC
        };
        PTR_FUN_16ACC = new FUN_8C[2]
        {
            FUN_C59C,
            FUN_C64C
        };
        PTR_FUN_16AD4 = new FUN_8C[2]
        {
            FUN_C674,
            FUN_C79C
        };
    }

    protected override void Start()
    {
        base.Start();
        GetComponent<Camera>().fieldOfView = 42f;
    }

    protected override void Update()
    {
        base.Update();
        transform.localEulerAngles = new Vector3
            (-transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z);
    }

    public void FUN_27210()
    {
        FUN_18448[] local_30;
        int ppcVar3;
        int ppcVar4;
        int ppcVar5;
        int ppcVar6;
        FUN_18448 pcVar7;
        FUN_18448 pcVar8;
        FUN_18448 pcVar9;
        Vector3Int local_38;

        ppcVar3 = 0;
        ppcVar4 = 0;
        local_30 = new FUN_18448[10];

        do
        {
            ppcVar6 = ppcVar4;
            ppcVar5 = ppcVar3;
            pcVar7 = PTR_FUN_18448[ppcVar5 + 1];
            pcVar8 = PTR_FUN_18448[ppcVar5 + 2];
            pcVar9 = PTR_FUN_18448[ppcVar5 + 3];
            local_30[ppcVar6] = PTR_FUN_18448[ppcVar5];
            local_30[ppcVar6 + 1] = pcVar7;
            local_30[ppcVar6 + 2] = pcVar8;
            local_30[ppcVar6 + 3] = pcVar9;
            ppcVar3 = ppcVar5 + 4;
            ppcVar4 = ppcVar6 + 4;
        } while (ppcVar5 + 4 != 8);

        pcVar7 = PTR_FUN_18448[ppcVar5 + 5];
        local_30[ppcVar6 + 4] = FUN_278B4;
        local_30[ppcVar6 + 5] = pcVar7;

        if ((InventoryManager.DAT_B7A60[0] & 8) == 0)
        {
            if ((DAT_72 & 2) != 0)
                return;

            local_30[DAT_70]();
        }

        vr.x &= 0xfff;
        vr.y &= 0xfff;
        vr.z &= 0xfff;
        local_38 = new Vector3Int();
        local_38.x = -vr.x;
        local_38.y = -vr.y;
        local_38.z = -vr.z;
        Utilities.RotMatrix(ref local_38, ref cTransform.rotation);
    }

    private void FUN_27320()
    {
        byte bVar1;
        CameraMotion mVar2;

        if ((DAT_72 & 1) != 0)
        {
            bVar1 = (byte)(DAT_73 - 1);
            DAT_73 = bVar1;

            if (bVar1 != 0)
                return;

            SceneManager.instance.FUN_55580(9, DAT_68);
            SceneManager.instance.FUN_55700();
            mVar2 = SceneManager.instance.motions.MOTIONS[DAT_6A];
            DAT_72 &= 0xfe;
            motion = mVar2;
            InventoryManager.FUN_4A7E8(2, 0x14, false);
        }

        FUN_26B18(SceneManager.instance.motions.MOTIONS);
    }

    private void FUN_27444()
    {
        DAT_8A = 2;
        DAT_8B = 2;
        SceneManager.instance.FUN_269C8(DAT_40, DAT_48);
    }

    private void FUN_27478()
    {
        CameraMotion mVar1;

        if (DAT_5A == 0)
        {
            mVar1 = SceneManager.instance.motions.MOTIONS[DAT_6A];
            motion = mVar1;
            DAT_68 = mVar1.DAT_02;
            DAT_69 = motion.DAT_00;
            //...
            DAT_5A++;
        }
        else
        {
            if (DAT_5A != 1)
                return;
        }

        PTR_FUN_99404[DAT_69](motion);
    }

    private void FUN_2753C()
    {
        short sVar1;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        if (DAT_5A == 0)
        {
            sVar1 = (short)(DAT_46 - 1);
            DAT_46 = sVar1;

            if (sVar1 == -1)
                DAT_5A++;
            else
            {
                vr.x += DAT_74;
                vr.y += DAT_76;
                DAT_3C += DAT_78;
            }
        }

        local_38 = new Vector3Int();
        local_38.x = vr.x;
        local_38.y = vr.y;
        local_38.z = 0;
        MStack48 = new Matrix3x3();
        Utilities.RotMatrixYXZ(ref local_38, ref MStack48);
        local_38.x = 0;
        local_38.y = 0;
        local_38.z = (short)-DAT_3C;
        local_38 = Utilities.ApplyMatrixSV(ref MStack48, ref local_38);
        screen.x = DAT_30.x + local_38.x;
        screen.y = DAT_30.y + local_38.y;
        screen.z = DAT_30.z + local_38.z;
    }

    private void FUN_2765C()
    {
        CriBone puVar1;
        CriBone m;
        Vector3Int local_18;
        Vector3Int local_10;

        puVar1 = SceneManager.instance.skinnedObjects[0].skeleton;
        SceneManager.instance.skinnedObjects[0].flags &= 0xfffffffd;
        m = (CriBone)Utilities.FUN_601C8(puVar1, 3);
        local_10 = m.screen;
        local_18 = new Vector3Int(0, 0, 1000);
        local_18 = Utilities.ApplyMatrixSV(ref m.cTransform.rotation, ref local_18);
        local_18.x += local_10.x;
        local_18.y += local_10.y;
        local_18.z += local_10.z;
        DAT_8A = 0;
        DAT_8B = 0;
        SceneManager.instance.FUN_269C8(local_18, local_10);
    }

    private void FUN_27720()
    {
        CriPlayer oVar1;
        CriBone puVar1;
        CriBone oVar2;
        Vector3Int local_18;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_18 = new Vector3Int();
        local_18.x = oVar1.screen.x;
        local_18.y = oVar1.screen.y - 0x400;
        local_18.z = oVar1.screen.z;
        puVar1 = SceneManager.instance.skinnedObjects[0].skeleton;
        SceneManager.instance.skinnedObjects[0].flags &= 0xfffffffd;
        oVar2 = (CriBone)Utilities.FUN_601C8(puVar1, 3);
        local_10 = oVar2.screen;
        DAT_8A = 0;
        DAT_8B = 0;
        SceneManager.instance.FUN_269C8(local_18, local_10);
    }

    private void FUN_277B8()
    {
        CriStatic oVar1;
        Matrix3x3 MStack64;
        Vector3Int local_20;
        Vector3Int local_18;

        oVar1 = SceneManager.instance.staticObjects[DAT_71];
        local_18 = oVar1.screen;
        local_20 = oVar1.vr;
        MStack64 = new Matrix3x3();
        Utilities.RotMatrixYXZ(ref local_20, ref MStack64);
        local_20 = new Vector3Int(0, 0, 1000);
        local_20 = Utilities.ApplyMatrixSV(ref MStack64, ref local_20);
        local_20.x += local_18.x;
        local_20.y += local_18.y;
        local_20.z += local_18.z;
        DAT_8A = 0;
        DAT_8B = 0;
        SceneManager.instance.FUN_269C8(local_20, local_18);
    }

    private void FUN_278B4()
    {
        CriStatic oVar1;
        CriBone oVar2;
        Vector3Int local_18;
        Vector3Int local_10;

        oVar1 = SceneManager.instance.staticObjects[0];
        local_10 = new Vector3Int();
        local_10.x = oVar1.screen.x;
        local_10.y = oVar1.screen.y - 0x400;
        local_10.z = oVar1.screen.z;
        oVar2 = (CriBone)Utilities.FUN_601C8
            (SceneManager.instance.skinnedObjects[0].skeleton, 3);
        local_18 = oVar2.screen;
        DAT_8A = 0;
        DAT_8B = 0;
        SceneManager.instance.FUN_269C8(local_18, local_10);
    }

    private void FUN_27944()
    {
        CameraMotion mVar1;

        if (DAT_5A == 0)
        {
            mVar1 = SceneManager.instance.motions.MOTIONS[DAT_71];
            motion = mVar1;
            DAT_68 = mVar1.DAT_02;
            DAT_69 = motion.DAT_00;
            //...
            DAT_8A = 0;
            DAT_8B = 0;
            DAT_5A++;
        }
        else
        {
            if (DAT_5A != 1)
                return;
        }

        DAT_6B = false;
        PTR_FUN_99404[DAT_69](motion);
        SceneManager.instance.FUN_269C8(DAT_40, DAT_48);
    }

    public void FUN_26B18(CameraMotion[] param1)
    {
        byte bVar1;
        byte bVar2;
        CriPlayer oVar3;
        CameraMotion oVar5;
        CameraMotion pbVar6;
        byte bVar7;

        oVar3 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        bVar1 = DAT_83;

        if ((DAT_72 & 4) == 0)
        {
            while (SceneManager.instance.motions.MOTIONS.Length != 0)
            {
                bVar7 = 0;
                pbVar6 = param1[bVar7];

                while (pbVar6.DAT_03 != oVar3.DAT_48 || pbVar6.DAT_02 == DAT_68 
                       || (pbVar6.DAT_01 & 1 << (bVar1 & 0x1f) & 0xf) == 0 || 
                       !GameManager.instance.FUN_768C8(oVar3.screen, pbVar6.DAT_04))
                {
                    bVar7++;

                    if (SceneManager.instance.motions.MOTIONS.Length <= bVar7) goto LAB_26D98;

                    pbVar6 = param1[bVar7];
                }

                if (pbVar6.DAT_00 != 0)
                {
                    //FUN_4A7E8
                    DAT_56 = 0;
                    DAT_52 = 0;
                    DAT_90 = 0;
                    DAT_92 = 0;
                    DAT_58 = 0;
                    DAT_59 = 0;
                    DAT_5A = 0;
                    DAT_5B = 0;
                    DAT_68 = pbVar6.DAT_02;
                    bVar2 = pbVar6.DAT_00;
                    DAT_6A = bVar7;
                    DAT_69 = bVar2;

                    if ((pbVar6.DAT_01 & 0x40) == 0)
                    {
                        DAT_8A = 0;
                        DAT_8B = 0;
                        DAT_26 = 0x1000;
                        DAT_36 = 0x1000;
                        SDAT_2E = 0;
                        DAT_3E = 0;
                    }
                    else
                    {
                        DAT_8A = 2;
                        DAT_8B = 2;
                        DAT_26 = pbVar6.DAT_25;
                        DAT_36 = pbVar6.DAT_24;
                        SDAT_2E = pbVar6.DAT_27;
                        DAT_3E = pbVar6.DAT_26;
                    }

                    if ((pbVar6.DAT_01 & 0x80) == 0)
                    {
                        if (DAT_82 == DAT_83)
                        {
                            //FUN_4A7E8
                            DAT_73 = 6;
                            DAT_72 |= 1;
                        }
                        else
                        {
                            //...
                            oVar5 = SceneManager.instance.motions.MOTIONS[DAT_6A];
                            DAT_72 &= 0xfe;
                            motion = oVar5;
                        }

                        DAT_82 = DAT_83;
                        return;
                    }

                    //...
                    oVar5 = SceneManager.instance.motions.MOTIONS[DAT_6A];
                    DAT_72 &= 0xfe;
                    DAT_82 = DAT_83;
                    motion = oVar5;
                    break;
                }

                FUN_27BC4(pbVar6);
            }
        }

        LAB_26D98:
        PTR_FUN_99404[DAT_69](motion);
        SceneManager.instance.FUN_269C8(DAT_7C, DAT_84);
    }

    private void FUN_27BC4(CameraMotion param1)
    {
        uint uVar1;

        uVar1 = 0;

        do
        {
            if (((byte)param1.DAT_2C.x >> (int)(uVar1 & 0x1f) & 1) != 0)
            {
                DAT_83 = (byte)uVar1;
                return;
            }

            uVar1++;
        } while ((uVar1 & 0xff) < 7);
    }

    private void FUN_27C04(CameraMotion param1)
    {
        SceneManager.instance.FUN_27A1C(param1.DAT_2C, param1.DAT_34);
    }

    private void FUN_27C28(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_10 = new Vector3Int();
        local_10.x = oVar1.screen.x;
        local_10.y = oVar1.screen.y - param1.DAT_34.x;
        local_10.z = oVar1.screen.z;
        SceneManager.instance.FUN_27A1C(local_10, param1.DAT_2C);
    }

    private void FUN_27C7C(CameraMotion param1)
    {
        long lVar1;
        Vector3Int local_40;
        Matrix3x3 MStack56;
        Vector3Int local_18;

        local_40 = Utilities.FUN_263CC(param1.DAT_2C, SceneManager.instance.skinnedObjects[10].screen);
        lVar1 = Utilities.Ratan2(-param1.DAT_34.y, param1.DAT_34.x);
        local_40.x = (short)lVar1;
        local_40.z = 0;
        MStack56 = new Matrix3x3();
        Utilities.RotMatrixYXZ(ref local_40, ref MStack56);
        local_18 = new Vector3Int(0, 0, -param1.DAT_34.x);
        local_18 = Utilities.ApplyMatrixSV(ref MStack56, ref local_18);
        local_18.x += param1.DAT_2C.x;
        local_18.y += param1.DAT_2C.y;
        local_18.z += param1.DAT_2C.z;
        SceneManager.instance.FUN_27A1C(param1.DAT_2C, local_18);
    }

    private void FUN_27D58(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_48;
        Vector3Int local_40;
        Matrix3x3 MStack56;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_48 = new Vector3Int(0, oVar1.vr.y, 0);
        MStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref local_48, ref MStack56);
        local_40 = new Vector3Int(0, 0, -param1.DAT_2C.z);
        local_40 = Utilities.ApplyMatrixSV(ref MStack56, ref local_40);
        local_48.x = oVar1.screen.x;
        local_48.y = oVar1.screen.y - param1.DAT_2C.x;
        local_48.z = oVar1.screen.z;
        local_40.x += oVar1.screen.x;
        local_40.y += oVar1.screen.y - param1.DAT_2C.y;
        local_40.z += oVar1.screen.z;
        DAT_8A = 1;
        DAT_8B = 1;
        SceneManager.instance.FUN_27A1C(local_48, local_40);
    }

    private void FUN_27E64(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_40 = new Vector3Int();
        local_40.x = param1.DAT_2C.x;
        local_40.y = oVar1.screen.y - param1.DAT_32;
        local_40.z = oVar1.screen.z;
        local_38 = new Vector3Int(0, -param1.DAT_2C.z, 0);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref MStack48);
        local_38 = new Vector3Int(0, 0, -param1.DAT_2C.y);
        local_38 = Utilities.ApplyMatrixSV(ref MStack48, ref local_38);
        local_38.x += local_40.x;
        local_38.z += local_40.z;
        local_38.y += local_40.y - param1.DAT_34.x;
        SceneManager.instance.FUN_27A1C(local_40, local_38);
    }

    private void FUN_27F50(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_40 = new Vector3Int();
        local_40.x = oVar1.screen.x;
        local_40.y = oVar1.screen.y - param1.DAT_32;
        local_40.z = param1.DAT_2C.x;
        local_38 = new Vector3Int(0, -param1.DAT_2C.z, 0);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref MStack48);
        local_38 = new Vector3Int(0, 0, -param1.DAT_2C.y);
        local_38 = Utilities.ApplyMatrixSV(ref MStack48, ref local_38);
        local_38.x += local_40.x;
        local_38.z += local_40.z;
        local_38.y += local_40.y - param1.DAT_34.x;
        SceneManager.instance.FUN_27A1C(local_40, local_38);
    }

    private void FUN_2803C(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_18;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_18 = new Vector3Int();
        local_10 = new Vector3Int();
        local_18.x = DAT_40.x;
        local_10.x = DAT_48.x;
        local_10.y = oVar1.screen.y - oVar1.DAT_34.y;
        local_18.y = DAT_40.y + local_10.y;
        local_10.y = DAT_48.y + local_10.y;
        local_10.z = oVar1.screen.z - oVar1.DAT_34.z;
        local_18.z = DAT_40.z + local_10.z;
        local_10.z = DAT_48.z + local_10.z;
        SceneManager.instance.FUN_27A1C(local_18, local_10);
    }

    private void FUN_280F0(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_18;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_18 = new Vector3Int();
        local_10 = new Vector3Int();
        local_18.z = DAT_40.z;
        local_10.z = DAT_48.z;
        local_10.x = oVar1.screen.x - oVar1.DAT_34.x;
        local_18.x = DAT_40.x + local_10.x;
        local_10.x = DAT_48.x + local_10.x;
        local_10.y = oVar1.screen.y - oVar1.DAT_34.y;
        local_18.y = DAT_40.y + local_10.y;
        local_10.y = DAT_48.y + local_10.y;
        SceneManager.instance.FUN_27A1C(local_18, local_10);
    }

    private void FUN_281A4(CameraMotion param1)
    {
        CriPlayer oVar1;
        ushort uVar1;
        Vector3Int local_18;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_18 = new Vector3Int();
        local_10 = new Vector3Int();
        local_18.x = oVar1.screen.x;
        local_18.y = oVar1.screen.y - param1.DAT_32;
        local_18.z = oVar1.screen.z;
        local_10.x = param1.DAT_2C.x;
        local_10.y = local_18.y - param1.DAT_34.x;
        uVar1 = (ushort)(param1.DAT_2C.z & 0xfff);
        //changing camera motion data ???

        if (uVar1 - 0x401U < 0x7ffU)
            local_10.z = param1.DAT_2C.y;
        else
            local_10.z = -param1.DAT_2C.y;

        local_10.z = local_18.z + local_10.z;

        if (DAT_58 == 0)
        {
            SceneManager.instance.FUN_26504(0, (short)local_10.x, (short)local_10.y, (short)local_10.z);
            DAT_58++;
        }

        SceneManager.instance.FUN_27A1C(local_18, local_10);
    }

    private void FUN_28298(CameraMotion param1)
    {
        int iVar1;
        CriPlayer oVar1;
        Vector3Int local_18;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_18 = new Vector3Int();
        local_10 = new Vector3Int();
        local_18.x = oVar1.screen.x;
        local_18.y = oVar1.screen.y - param1.DAT_32;
        local_18.z = oVar1.screen.z;

        if ((param1.DAT_2C.z & 0x800) == 0)
            local_10.x = -param1.DAT_2C.y;
        else
            local_10.x = param1.DAT_2C.y;

        local_10.x = local_18.x + local_10.x;
        iVar1 = local_18.y - param1.DAT_34.x;
        local_10.y = iVar1;
        local_10.z = param1.DAT_2C.x;

        if (DAT_58 == 0)
        {
            SceneManager.instance.FUN_26504(0, (short)local_10.x, (short)(iVar1 * 0x10000 >> 0x10), (short)local_10.z);
            DAT_58++;
        }

        SceneManager.instance.FUN_27A1C(local_18, local_10);
    }

    private void FUN_28388(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_18;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_18 = new Vector3Int();
        local_10 = new Vector3Int();
        local_10.x = DAT_48.x;
        local_18.x = DAT_40.x + (oVar1.screen.x - oVar1.DAT_34.x);
        local_10.y = oVar1.screen.y - oVar1.DAT_34.y;
        local_18.y = DAT_40.y + local_10.y;
        local_10.y = DAT_48.y + local_10.y;
        local_10.z = oVar1.screen.z - oVar1.DAT_34.z;
        local_18.z = DAT_40.z + local_10.z;
        local_10.z = DAT_48.z + local_10.z;
        SceneManager.instance.FUN_27A1C(local_18, local_10);
    }

    private void FUN_28454(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_18;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_18 = new Vector3Int();
        local_10 = new Vector3Int();
        local_10.z = DAT_48.z;
        local_10.x = oVar1.screen.x - oVar1.DAT_34.x;
        local_18.x = DAT_40.x + local_10.x;
        local_10.x = DAT_48.x + local_10.x;
        local_10.y = oVar1.screen.y - oVar1.DAT_34.y;
        local_18.y = DAT_40.y + local_10.y;
        local_10.y = DAT_48.y + local_10.y;
        local_18.z = DAT_40.z + (oVar1.screen.z - oVar1.DAT_34.z);
        SceneManager.instance.FUN_27A1C(local_18, local_10);
    }

    private void FUN_2851C(CameraMotion param1) 
    {
        SceneManager.instance.FUN_27A1C(DAT_40, DAT_48);
    }

    private void FUN_28544(CameraMotion param1)
    {
        int iVar1;
        int iVar2;
        int iVar3;
        int iVar4;
        int iVar5;
        int iVar6;
        int iVar7;
        int iVar8;
        CriPlayer oVar9;
        Vector3Int local_10;

        oVar9 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        iVar8 = param1.DAT_34.x;
        iVar4 = param1.DAT_3C.x - iVar8;
        iVar6 = param1.DAT_2C.z - oVar9.screen.z;
        iVar7 = param1.DAT_34.z;
        iVar3 = param1.DAT_3C.z - iVar7;
        iVar1 = param1.DAT_2C.x - oVar9.screen.x;
        iVar2 = iVar4 * iVar6 - iVar3 * iVar1;

        if (iVar2 != 0)
        {
            iVar1 = (iVar7 - oVar9.screen.z) * iVar1 -
                    (iVar8 - oVar9.screen.x) * iVar6;
            iVar2 /= 1000;
            iVar6 = iVar1 / iVar2;

            if (iVar2 == 0)
                return; //trap(0x1c00)

            if (iVar2 == -1 && iVar1 == -0x80000000)
                return; //trap(0x1800)

            iVar5 = param1.DAT_34.x + (iVar4 * iVar6) / 1000;
            local_10 = new Vector3Int();
            local_10.x = iVar5;
            iVar1 = param1.DAT_34.z + (iVar3 * iVar6) / 1000;
            iVar2 = iVar4;

            if (iVar4 < 0)
                iVar2 = -iVar4;

            local_10.z = iVar1;

            if (iVar2 < 1001)
            {
                iVar2 = iVar3;

                if (iVar3 < 0)
                    iVar2 = -iVar3;

                if (iVar2 < 1001)
                    return;

                iVar2 = param1.DAT_3C.y - param1.DAT_34.y;
                iVar3 /= 1000;

                if (iVar3 == 0)
                    return; //trap(0x1c00)

                if (iVar3 == -1 && iVar2 == -0x80000000)
                    return; //trap(0x1800)

                iVar2 = (iVar2 / iVar3) * ((iVar1 * 0x10000 >> 0x10) - iVar7);
                iVar4 = (int)((ulong)((long)iVar2 * 0x10624dd3) >> 0x20);
            }
            else
            {
                iVar2 = param1.DAT_3C.y - param1.DAT_34.y;
                iVar4 /= 1000;

                if (iVar4 == 0)
                    return; //trap(0x1c00)

                if (iVar4 == -1 && iVar2 == -0x80000000)
                    return; //trap(0x1800)

                iVar2 = (iVar2 / iVar4) * ((iVar5 * 0x10000 >> 0x10) - iVar5);
                iVar4 = (int)((ulong)((long)iVar2 * 0x10624dd3) >> 0x20);
            }

            local_10.y = param1.DAT_34.y + ((iVar4 >> 6) - (iVar2 >> 0x1f));
            SceneManager.instance.FUN_27A1C(param1.DAT_2C, local_10);
        }
    }

    private void FUN_287B0(CameraMotion param1)
    {
        long lVar1;
        CriPlayer oVar1;
        Matrix3x3 MStack72;
        Vector3Int local_28;
        Vector3Int local_20;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_20 = oVar1.screen;
        local_28 = Utilities.FUN_263CC(param1.DAT_2C, local_20);
        lVar1 = (int)Utilities.FUN_2630C(local_20, param1.DAT_2C);
        lVar1 = Utilities.Ratan2(param1.DAT_34.y, lVar1);
        local_28.x = (short)lVar1;
        local_28.z = 0;
        MStack72 = new Matrix3x3();
        Utilities.RotMatrixYXZ(ref local_28, ref MStack72);
        local_20.x = 0;
        local_20.y = 0;
        local_20.z = param1.DAT_34.x;
        local_20 = Utilities.ApplyMatrixSV(ref MStack72, ref local_20);
        local_20.x += param1.DAT_2C.x;
        local_20.y += param1.DAT_2C.y;
        local_20.z += param1.DAT_2C.z;
        SceneManager.instance.FUN_27A1C(param1.DAT_2C, local_20);
    }

    private void FUN_288B4(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_10 = new Vector3Int();
        local_10.x = DAT_40.x;
        local_10.z = DAT_40.z + (oVar1.screen.z - oVar1.DAT_34.z);
        local_10.y = DAT_40.y + (oVar1.screen.y - oVar1.DAT_34.y);
        SceneManager.instance.FUN_27A1C(local_10, DAT_48);
    }

    private void FUN_2892C(CameraMotion param1)
    {
        CriPlayer oVar1;
        Vector3Int local_10;

        oVar1 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_10 = new Vector3Int();
        local_10.z = DAT_40.z;
        local_10.x = DAT_40.x + (oVar1.screen.x - oVar1.DAT_34.x);
        local_10.y = DAT_40.y + (oVar1.screen.y - oVar1.DAT_34.y);
        SceneManager.instance.FUN_27A1C(local_10, DAT_48);
    }

    private void FUN_289A4(CameraMotion param1)
    {
        SceneManager.instance.FUN_27A1C(param1.DAT_2C, param1.DAT_34);
        DAT_69 = 0x20;
    }

    private void FUN_289D8(CameraMotion param1)
    {
        SceneManager.instance.FUN_27A1C(param1.DAT_2C, param1.DAT_34);
        DAT_69 = 0x21;
    }

    private void FUN_28A0C(CameraMotion param1)
    {
        sbyte sVar1;
        CriPlayer oVar2;
        int iVar2;
        int iVar3;
        int iVar4;
        Vector3Int local_60;
        Vector3Int local_58;
        Vector3Int local_50;
        int local_48;
        int local_40;
        Matrix3x3 MStack56;

        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        local_60 = new Vector3Int();
        local_58 = new Vector3Int();
        sVar1 = DAT_58;

        if (sVar1 == 1)
        {
            local_48 = param1.DAT_34.x - param1.DAT_2C.x;
            local_40 = param1.DAT_34.z - param1.DAT_2C.z;
            iVar3 = local_48 * (oVar2.screen.x - param1.DAT_2C.x) +
                    local_40 * (oVar2.screen.z - param1.DAT_2C.z);
            iVar2 = (local_48 * local_48 + local_40 * local_40) / 1000;
            iVar4 = iVar3 / iVar2;

            if (iVar2 == 0)
                return; //trap(0x1c00)

            if (iVar2 == -1 && iVar3 == -0x80000000)
                return; //trap(0x1800)

            local_60.x = param1.DAT_2C.x + ((iVar4 * local_48) / 1000);
            local_60.y = -param1.DAT_3C.x;
            local_60.z = param1.DAT_2C.z + ((iVar4 * local_40) / 1000);
            local_58.x = param1.DAT_34.x;
            local_58.z = param1.DAT_34.z;
        }
        else
        {
            if (sVar1 < 2)
            {
                if (sVar1 != 0) goto LAB_29044;

                local_60.x = oVar2.screen.x;
                local_60.y = oVar2.screen.y - 0x400;
                local_60.z = oVar2.screen.z;
                iVar3 = (int)Utilities.FUN_2630C(local_60, param1.DAT_2C);
                iVar4 = (int)Utilities.FUN_2630C(local_60, param1.DAT_34);

                if (iVar3 < iVar4)
                {
                    local_48 = param1.DAT_34.x - param1.DAT_2C.x;
                    local_40 = param1.DAT_34.z - param1.DAT_2C.z;
                    iVar3 = local_48 * (oVar2.screen.x - param1.DAT_2C.x) +
                            local_40 * (oVar2.screen.z - param1.DAT_2C.z);
                    iVar2 = (local_48 * local_48 + local_40 * local_40) / 1000;
                    iVar4 = iVar3 / iVar2;

                    if (iVar2 == 0)
                        return; //trap(0x1c00)

                    if (iVar2 == -1 && iVar3 == -0x80000000)
                        return; //trap(0x1800)

                    local_60.x = param1.DAT_2C.x + ((iVar4 * local_48) / 1000);
                    local_60.y = -param1.DAT_3C.x;
                    local_60.z = param1.DAT_2C.z + ((iVar4 * local_40) / 1000);
                    local_58.x = param1.DAT_34.x;
                    local_58.z = param1.DAT_34.z;
                    DAT_58 = 1;
                }
                else
                {
                    local_48 = param1.DAT_2C.x - param1.DAT_34.x;
                    local_40 = param1.DAT_2C.z - param1.DAT_34.z;
                    iVar3 = local_48 * (oVar2.screen.x - param1.DAT_34.x) +
                            local_40 * (oVar2.screen.z - param1.DAT_34.z);
                    iVar2 = (local_48 * local_48 + local_40 * local_40) / 1000;
                    iVar4 = iVar3 / iVar2;

                    if (iVar2 == 0)
                        return; //trap(0x1c00)

                    if (iVar2 == -1 && iVar3 == -0x80000000)
                        return; //trap(0x1800)

                    local_60.x = param1.DAT_34.x + ((iVar4 * local_48) / 1000);
                    local_60.y = -param1.DAT_3C.x;
                    local_60.z = param1.DAT_34.z + ((iVar4 * local_40) / 1000);
                    local_58.x = param1.DAT_2C.x;
                    local_58.z = param1.DAT_2C.z;
                    DAT_58 = 2;
                }
            }
            else
            {
                if (sVar1 != 2) goto LAB_29044;

                local_48 = param1.DAT_2C.x - param1.DAT_34.x;
                local_40 = param1.DAT_2C.z - param1.DAT_34.z;
                iVar3 = local_48 * (oVar2.screen.x - param1.DAT_34.x) +
                        local_40 * (oVar2.screen.z - param1.DAT_34.z);
                iVar2 = (local_48 * local_48 + local_40 * local_40) / 1000;
                iVar4 = iVar3 / iVar2;

                if (iVar2 == 0)
                    return; //trap(0x1c00)

                if (iVar2 == -1 && iVar3 == -0x80000000)
                    return; //trap(0x1800)

                local_60.x = param1.DAT_34.x + ((iVar4 * local_48) / 1000);
                local_60.y = -param1.DAT_3C.x;
                local_60.z = param1.DAT_34.z + ((iVar4 * local_40) / 1000);
                local_58.x = param1.DAT_2C.x;
                local_58.z = param1.DAT_2C.z;
            }
        }

        local_58.y = 0;
        LAB_29044:
        local_50 = new Vector3Int();
        MStack56 = new Matrix3x3();
        local_50.x = 0;
        local_50.y = Utilities.FUN_615EC(local_60, local_58);
        local_50.z = 0;
        Utilities.RotMatrix(ref local_50, ref MStack56);
        local_50.x = 0;
        local_50.y = 0;
        local_50.z = param1.DAT_3C.z;
        local_50 = Utilities.ApplyMatrixSV(ref MStack56, ref local_50);
        local_50.x += local_60.x;
        local_50.z += local_60.z;
        local_50.y = -param1.DAT_3C.y;
        SceneManager.instance.FUN_27A1C(local_60, local_50);
    }

    private void FUN_294B8(Vector2Int param1, short param2)
    {
        Vector3Int local_18;
        Matrix3x3 MStack56;

        local_18 = new Vector3Int(param1.x, param1.y, 0);
        MStack56 = new Matrix3x3();
        Utilities.RotMatrixYXZ(ref local_18, ref MStack56);
        local_18 = new Vector3Int(0, 0, param2);
        local_18 = Utilities.ApplyMatrixSV(ref MStack56, ref local_18);
        screen.x = DAT_30.x + local_18.x;
        screen.y = DAT_30.y + local_18.y;
        screen.z = DAT_30.z + local_18.z;
    }

    public void FUN_2EDE4()
    {
        CriObject oVar1;
        CriPlayer oVar2;
        Vector3Int local_50;
        Vector3Int local_48;
        Vector3Int local_40;
        Matrix3x3 MStack56;

        oVar1 = DAT_64;
        local_50 = new Vector3Int(1000, 0, -1000);
        MStack56 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar1.vr, ref MStack56);
        local_50 = Utilities.ApplyMatrixSV(ref MStack56, ref local_50);
        local_40 = new Vector3Int(oVar1.screen.x + local_50.x, oVar1.screen.y - 2000, oVar1.screen.z + local_50.z);
        local_50 = new Vector3Int(-1000, 0, 0);
        oVar2 = (CriPlayer)SceneManager.instance.skinnedObjects[10];
        Utilities.RotMatrix(ref oVar2.vr, ref MStack56);
        local_48 = new Vector3Int(oVar2.screen.x + local_50.x, oVar2.screen.y, oVar2.screen.z + local_50.z);
        SceneManager.instance.FUN_264C4(0, (short)local_48.x, (short)local_48.y, (short)local_48.z);
        SceneManager.instance.FUN_26504(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_269C8(local_48, local_40);
    }

    public void FUN_2EF18()
    {
        SceneManager.instance.FUN_269C8(DAT_40, DAT_48);
    }

    public void FUN_2EF40()
    {
        CriObject oVar1;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        oVar1 = DAT_64;
        local_40 = new Vector3Int(0, 0, -500);
        local_38 = new Vector3Int(0, 0, 0);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref MStack48);
        local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        local_48 = new Vector3Int(oVar1.screen.x + local_40.x, oVar1.screen.y - 1500, screen.z + local_40.z);
        SceneManager.instance.FUN_269C8(local_48, DAT_48);
    }

    public void FUN_2EFE8()
    {
        CriObject oVar1;
        Vector3Int local_10;

        oVar1 = DAT_64;
        local_10 = new Vector3Int(oVar1.screen.x, oVar1.screen.y - 500, oVar1.screen.z);
        SceneManager.instance.FUN_269C8(local_10, DAT_48);
    }

    public void FUN_2F038()
    {
        CriObject oVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        oVar1 = DAT_64;
        local_40 = new Vector3Int(1000, 0, 0);
        MStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar1.vr, ref MStack48);
        local_40 = Utilities.ApplyMatrixSV(ref MStack48, ref local_40);
        local_38 = new Vector3Int(oVar1.screen.x + local_40.x, oVar1.screen.y - 1800, oVar1.screen.z + local_40.z);
        SceneManager.instance.FUN_269C8(local_38, DAT_48);
    }

    public void FUN_2F0D4()
    {
        if (0x200 < DAT_7C.y)
        {
            DAT_7C.y -= 10;
            DAT_7C.z += 10;
        }

        SceneManager.instance.FUN_269C8(DAT_40, DAT_48);
        FUN_294B8((Vector2Int)DAT_7C, (short)DAT_7C.z);
        vr.x = DAT_7C.x;
        vr.y = DAT_7C.y;
        DAT_3C = (ushort)DAT_7C.z;
    }

    public void FUN_2F14C()
    {
        CriObject oVar1;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 MStack48;

        oVar1 = DAT_64;
        local_48 = new Vector3Int(2000, 0, 2500);
        MStack48 = new Matrix3x3();
        MStack48 = Utilities.RotMatrix(ref oVar1.vr, ref MStack48);
        local_48 = Utilities.ApplyMatrixSV(ref MStack48, ref local_48);
        local_40 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 1000, oVar1.screen.z + local_48.z);
        local_48 = new Vector3Int(0, 0, 1000);
        local_48 = Utilities.ApplyMatrixSV(ref MStack48, ref local_48);
        local_38 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 1000, oVar1.screen.z + local_48.z);
        SceneManager.instance.cCamera.DAT_8B = 0;
        SceneManager.instance.cCamera.DAT_36 = 0;
        SceneManager.instance.FUN_26504(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_269C8(local_38, local_40);
    }

    //FUN_1CFC (ST9)
    public void FUN_1CFC()
    {
        CriSkinned oVar1;
        CriBone oVar2;
        CriSkinned oVar3;
        Vector3Int local_48;
        Vector3Int local_40;
        Matrix3x3 auStack_38;

        oVar1 = SceneManager.instance.skinnedObjects[0];
        oVar3 = SceneManager.instance.skinnedObjects[10];
        oVar2 = Utilities.FUN_601C8(oVar1.skeleton, 3) as CriBone;
        local_40 = new Vector3Int(0, Utilities.FUN_615EC(oVar3.screen, oVar1.screen), 0);
        auStack_38 = new Matrix3x3();
        Utilities.RotMatrix_gte(ref local_40, ref auStack_38);
        local_48 = new Vector3Int(0, 0, ST9.instance.DAT_160CC[(oVar1.DAT_2F - 2) * 2 + 1]);
        local_48 = Utilities.ApplyMatrixSV(ref auStack_38, ref local_48);
        local_48.x += oVar3.screen.x;
        local_48.y = ST9.instance.DAT_160CC[(oVar1.DAT_2F - 2) * 2];
        local_48.z += oVar3.screen.z;
        SceneManager.instance.FUN_269C8(oVar2.screen, local_48);
    }

    //FUN_1E08 (ST9)
    public void FUN_1E08()
    {
        CriBone oVar2;
        CriSkinned oVar3;
        Vector3Int local_18;

        oVar3 = SceneManager.instance.skinnedObjects[0];
        oVar2 = Utilities.FUN_601C8(oVar3.skeleton, 3) as CriBone;
        local_18 = ST9.instance.DAT_160D8[oVar3.DAT_2F - 2];
        local_18 = Utilities.ApplyMatrixSV(ref oVar3.cTransform.rotation, ref local_18);
        local_18.x += oVar2.screen.x;
        local_18.y += oVar2.screen.y;
        local_18.z += oVar2.screen.z;
        DAT_56 = 0;
        DAT_54 = 0;
        DAT_52 = 0;
        DAT_50 = 0;
        DAT_3E = 0;
        SDAT_2E = 0;
        DAT_92 = 0;
        DAT_90 = 0;
        DAT_36 = 0;
        DAT_26 = 0;
        DAT_8B = 0;
        DAT_8A = 0;
        SceneManager.instance.FUN_269C8(oVar2.screen, local_18);
    }

    //FUN_2D20 (ST2)
    public void FUN_2D20()
    {
        int iVar1;
        short[] aVar2;
        CriObject oVar3;
        CriPlayer oVar4;

        oVar4 = (CriPlayer)SceneManager.instance.skinnedObjects[0];
        iVar1 = oVar4.DAT_1DB * 3;
        oVar3 = oVar4.PTR_1CC;
        DAT_8B = 2;
        DAT_8A = 2;
        aVar2 = ST2.instance.DAT_7D44;
        SceneManager.instance.FUN_26504(0, aVar2[iVar1], aVar2[iVar1 + 1], aVar2[iVar1 + 2]);
        SceneManager.instance.FUN_269C8(oVar3.screen, DAT_48);
    }

    //FUN_3440 (ST9)
    public void FUN_3440()
    {
        CriSkinned puVar1;
        CriSkinned oVar2;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack_30;

        oVar2 = SceneManager.instance.skinnedObjects[10];
        local_40 = new Vector3Int(oVar2.screen.x, oVar2.screen.y - 0x400, oVar2.screen.z);
        puVar1 = SceneManager.instance.skinnedObjects[0];
        puVar1.flags &= 0xfffffffd;
        local_38 = new Vector3Int(); //tmp
        auStack_30 = new Matrix3x3();
        Utilities.RotMatrix_gte(ref puVar1.vr, ref auStack_30);
        local_38 = Utilities.ApplyMatrixSV(ref auStack_30, ref local_38);
        local_38.x += oVar2.screen.x;
        local_38.y += oVar2.screen.y;
        local_38.z += oVar2.screen.z;
        DAT_8B = 0;
        SceneManager.instance.FUN_269C8(local_40, local_38);
    }

    //FUN_BD7C (ST9)
    public void FUN_BD7C()
    {
        CriObject oVar1;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack_30;

        oVar1 = DAT_64;
        local_48 = new Vector3Int(1500, 0, 1500);
        auStack_30 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar1.vr, ref auStack_30);
        local_48 = Utilities.ApplyMatrixSV(ref auStack_30, ref local_48);
        local_38 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 1500, oVar1.screen.z + local_48.z);
        local_48 = new Vector3Int(0, 0, 500);
        Utilities.RotMatrix(ref SceneManager.instance.skinnedObjects[10].vr, ref auStack_30);
        local_48 = Utilities.ApplyMatrixSV(ref auStack_30, ref local_48);
        local_40 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 1500, oVar1.screen.z + local_48.z);
        SceneManager.instance.FUN_264C4(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_26504(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        SceneManager.instance.FUN_269C8(local_40, local_38);
    }

    //FUN_BE1C (ST6)
    public void FUN_BE1C()
    {
        CriObject oVar1;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        oVar1 = DAT_64;
        local_48 = new Vector3Int(1500, 0, 1500);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar1.vr, ref auStack48);
        local_48 = Utilities.ApplyMatrixSV(ref auStack48, ref local_48);
        local_38 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 3500, oVar1.screen.z + local_48.z);
        local_48 = new Vector3Int(0, 0, 500);
        Utilities.RotMatrix(ref SceneManager.instance.skinnedObjects[10].vr, ref auStack48);
        local_48 = Utilities.ApplyMatrixSV(ref auStack48, ref local_48);
        local_40 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 1500, oVar1.screen.z + local_48.z);
        SceneManager.instance.FUN_264C4(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_26504(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        SceneManager.instance.FUN_269C8(local_40, local_38);
    }

    //FUN_BEA0 (ST9)
    public void FUN_BEA0()
    {
        CriObject oVar1;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack_30;

        oVar1 = DAT_64;
        local_48 = new Vector3Int(0, 0, 1500);
        auStack_30 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar1.vr, ref auStack_30);
        local_48 = Utilities.ApplyMatrixSV(ref auStack_30, ref local_48);
        local_38 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 3000, oVar1.screen.z + local_48.z);
        local_48 = new Vector3Int(0, 0, 1000);
        Utilities.RotMatrix(ref SceneManager.instance.skinnedObjects[10].vr, ref auStack_30);
        local_48 = Utilities.ApplyMatrixSV(ref auStack_30, ref local_48);
        local_40 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 1500, oVar1.screen.z + local_48.z);
        SceneManager.instance.FUN_264C4(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_26504(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        SceneManager.instance.FUN_269C8(local_40, local_38);
    }

    //FUN_BF40 (ST6)
    public void FUN_BF40()
    {
        CriObject oVar1;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        oVar1 = DAT_64;
        local_48 = new Vector3Int(0, 0, 1500);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar1.vr, ref auStack48);
        local_38 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 3000, oVar1.screen.z + local_48.z);
        local_48 = new Vector3Int(0, 0, 1000);
        Utilities.RotMatrix(ref SceneManager.instance.skinnedObjects[10].vr, ref auStack48);
        local_48 = Utilities.ApplyMatrixSV(ref auStack48, ref local_48);
        local_40 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 1500, oVar1.screen.z + local_48.z);
        SceneManager.instance.FUN_264C4(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_26504(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        SceneManager.instance.FUN_269C8(local_40, local_38);
    }

    //FUN_BFC4 (ST9)
    public void FUN_BFC4()
    {
        return;
    }

    //FUN_C064 (ST6)
    public void FUN_C064()
    {
        return;
    }

    //FUN_C4FC (ST6)
    public void FUN_C4FC()
    {
        CriObject oVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack_30;

        oVar1 = DAT_64;
        local_40 = new Vector3Int(0, 0, SceneManager.instance.skinnedObjects[10].screen.z - oVar1.screen.z >> 1);
        auStack_30 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar1.vr, ref auStack_30);
        local_40 = Utilities.ApplyMatrixSV(ref auStack_30, ref local_40);
        local_38 = new Vector3Int();
        local_38.x = oVar1.screen.x + local_40.x;
        local_38.y = oVar1.screen.y - 1500;
        local_38.z = oVar1.screen.z + local_40.z;
        SceneManager.instance.FUN_269C8(local_38, DAT_48);
    }

    //FUN_C59C (ST6)
    private void FUN_C59C()
    {
        CriObject oVar1;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        oVar1 = DAT_64;
        auStack48 = new Matrix3x3();
        local_40 = new Vector3Int(0, 0, SceneManager.instance.skinnedObjects[10].screen.z - oVar1.screen.z >> 1);
        Utilities.RotMatrix(ref oVar1.vr, ref auStack48);
        local_40 = Utilities.ApplyMatrixSV(ref auStack48, ref local_40);
        local_38 = new Vector3Int(oVar1.screen.x + local_40.x, oVar1.screen.y - 1500, oVar1.screen.z + local_40.z);
        SceneManager.instance.FUN_269C8(local_38, DAT_48);
    }

    //FUN_C5AC (ST9)
    private void FUN_C5AC()
    {
        SceneManager.instance.FUN_269C8(DAT_40, DAT_48);
    }

    //FUN_C5D4 (ST9)
    private void FUN_C5D4()
    {
        CriObject oVar1;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack_30;

        oVar1 = DAT_64;
        local_48 = new Vector3Int(1500, 0, 3000);
        auStack_30 = new Matrix3x3();
        Utilities.RotMatrix(ref oVar1.vr, ref auStack_30);
        local_48 = Utilities.ApplyMatrixSV(ref auStack_30, ref local_48);
        local_38 = new Vector3Int();
        local_38.x = oVar1.screen.x + local_48.x;
        local_38.y = oVar1.screen.y;
        local_38.z = oVar1.screen.z + local_48.z;
        local_48 = new Vector3Int(0, 0, 1000);
        Utilities.RotMatrix(ref oVar1.vr, ref auStack_30);
        local_48 = Utilities.ApplyMatrixSV(ref auStack_30, ref local_48);
        local_40 = new Vector3Int();
        local_40.x = oVar1.screen.x + local_48.x;
        local_40.y = oVar1.screen.y - 2000;
        local_40.z = oVar1.screen.z + local_48.z;
        SceneManager.instance.FUN_264C4(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_26504(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        SceneManager.instance.FUN_269C8(local_40, local_38);
    }

    //FUN_C64C (ST6)
    private void FUN_C64C()
    {
        SceneManager.instance.FUN_269C8(DAT_40, DAT_48);
    }

    //FUN_C6FC (ST9)
    private void FUN_C6FC()
    {
        DAT_7C.y -= 20;
        SceneManager.instance.FUN_269C8(DAT_40, DAT_48);
        FUN_294B8((Vector2Int)DAT_7C, (short)DAT_7C.z);
        vr.x = DAT_7C.x;
        vr.y = DAT_7C.y;
        DAT_3C = (ushort)DAT_7C.z;
    }

    //FUN_C674 (ST6)
    private void FUN_C674()
    {
        CriObject oVar1;
        Vector3Int local_48;
        Vector3Int local_40;
        Vector3Int local_38;
        Matrix3x3 auStack48;

        oVar1 = DAT_64;
        auStack48 = new Matrix3x3();
        local_48 = new Vector3Int(1500, 0, 3000);
        Utilities.RotMatrix(ref oVar1.vr, ref auStack48);
        local_48 = Utilities.ApplyMatrixSV(ref auStack48, ref local_48);
        local_38 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y, local_48.z);
        local_48 = new Vector3Int(0, 0, 1000);
        local_38.z = oVar1.screen.z + local_38.z;
        Utilities.RotMatrix(ref oVar1.vr, ref auStack48);
        local_48 = Utilities.ApplyMatrixSV(ref auStack48, ref local_48);
        local_40 = new Vector3Int(oVar1.screen.x + local_48.x, oVar1.screen.y - 2000, oVar1.screen.z + local_48.z);
        SceneManager.instance.FUN_264C4(0, (short)local_40.x, (short)local_40.y, (short)local_40.z);
        SceneManager.instance.FUN_26504(0, (short)local_38.x, (short)local_38.y, (short)local_38.z);
        SceneManager.instance.FUN_269C8(local_40, local_38);
    }

    //FUN_C79C (ST6)
    private void FUN_C79C()
    {
        DAT_7C.y -= 20;
        SceneManager.instance.FUN_269C8(DAT_40, DAT_48);
        FUN_294B8((Vector2Int)DAT_7C, (short)DAT_7C.z);
        vr.x = DAT_7C.x;
        vr.y = DAT_7C.y;
        DAT_3C = (ushort)DAT_7C.z;
    }
    
    //FUN_14C90 (ST6)
    public void FUN_14C90()
    {
        int iVar1;
        bool bVar2;
        Vector3Int local_18;
        Vector3Int local_10;

        bVar2 = InventoryManager.FUN_4A87C(3, 0x3d);

        if (bVar2)
        {
            InventoryManager.FUN_4A7E8(3, 0x3d, false);
            InventoryManager.FUN_4A7E8(3, 0x3b, false);
            DAT_3E = 0;
            SDAT_2E = 0;
            DAT_92 = 0;
            DAT_90 = 0;
            DAT_36 = 0;
            DAT_26 = 0;
            DAT_8B = 0;
            DAT_8A = 0;
        }

        bVar2 = InventoryManager.FUN_4A87C(3, 0x3b);
        iVar1 = GameManager.instance.DAT_922C;

        if (bVar2)
        {
            InventoryManager.FUN_4A7E8(3, 0x3b, false);
            DAT_26 = ST6.instance.DAT_17230[iVar1 * 4];
            DAT_36 = ST6.instance.DAT_17230[iVar1 * 4 + 1];
            SDAT_2E = ST6.instance.DAT_17230[iVar1 * 4 + 2];
            DAT_3E = ST6.instance.DAT_17230[iVar1 * 4 + 3];
            DAT_8B = 2;
            DAT_8A = 2;
        }

        local_18 = new Vector3Int(ST6.instance.DAT_17208[iVar1 * 3] + ST6.instance.DAT_174E4,
                                  ST6.instance.DAT_17208[iVar1 * 3 + 1], ST6.instance.DAT_17208[iVar1 * 3 + 2]);
        local_10 = new Vector3Int(ST6.instance.DAT_1721C[iVar1 * 3], ST6.instance.DAT_1721C[iVar1 * 3 + 1],
                                  ST6.instance.DAT_1721C[iVar1 * 3 + 2]);
        SceneManager.instance.FUN_269C8(local_18, local_10);
    }
}
