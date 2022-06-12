using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriCamera : MonoBehaviour
{
    public CriTransform cTransform; //0x00
    public Vector3Int screen; //0x20
    public short DAT_26; //0x26
    public Vector3Int vr; //0x28
    public short DAT_2E; //0x2E
    public Vector3Int DAT_30; //0x30
    public short DAT_36; //0x36
    public short DAT_3C; //0x3C
    public short DAT_3E; //0x3E
    public Vector3Int DAT_40; //0x40
    public Vector3Int DAT_48; //0x48
    public short DAT_50; //0x50
    public short DAT_52; //0x52
    public short DAT_54; //0x54
    public short DAT_56; //0x56
    public byte DAT_58; //0x58
    public byte DAT_59; //0x59
    public byte DAT_5A; //0x5A
    public byte DAT_5B; //0x5B
    public CameraMotion motion; //0x5C
    public byte DAT_68; //0x68
    public byte DAT_69; //0x69
    public byte DAT_6A; //0x6A
    public bool DAT_6B; //0x6B
    public byte DAT_72; //0x72
    public byte DAT_73; //0x73
    public Vector3Int DAT_7C; //0x7C
    public byte DAT_82; //0x82
    public byte DAT_83; //0x83
    public Vector3Int DAT_84; //0x84
    public byte DAT_8A; //0x8A
    public byte DAT_8B; //0x8B
    public short DAT_90; //0x90
    public short DAT_92; //0x92

    private delegate void FUN_99404(CameraMotion m);
    private FUN_99404[] PTR_FUN_99404;

    private void Awake()
    {
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
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void FUN_26B18(CameraMotion[] param1)
    {
        byte bVar1;
        byte bVar2;
        CriPlayer oVar3;
        CameraMotion oVar5;
        CameraMotion pbVar6;
        byte bVar7;

        oVar3 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        bVar1 = DAT_83;

        if ((DAT_72 & 4) == 0)
        {
            while (SceneManager.instance.motionLength != 0)
            {
                bVar7 = 0;
                pbVar6 = param1[bVar7];

                while (pbVar6.DAT_03 != oVar3.DAT_48 || pbVar6.DAT_02 == DAT_68 
                       || (pbVar6.DAT_01 & 1 << (bVar1 & 0x1f) & 0xf) == 0 || 
                       !GameManager.instance.FUN_768C8(oVar3.screen, pbVar6.DAT_04))
                {
                    bVar7++;
                    pbVar6 = param1[bVar7];

                    if (SceneManager.instance.motionLength <= bVar7) goto LAB_26D98;
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
                        DAT_2E = 0;
                        DAT_3E = 0;
                    }
                    else
                    {
                        DAT_8A = 2;
                        DAT_8B = 2;
                        DAT_26 = pbVar6.DAT_25;
                        DAT_36 = pbVar6.DAT_24;
                        DAT_2E = pbVar6.DAT_27;
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
                            oVar5 = SceneManager.instance.motions[DAT_6A];
                            DAT_72 &= 0xfe;
                            motion = oVar5;
                        }

                        DAT_82 = DAT_83;
                        return;
                    }

                    //...
                    oVar5 = SceneManager.instance.motions[DAT_6A];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        local_40 = Utilities.FUN_263CC(param1.DAT_2C, SceneManager.instance.DAT_27C[10].screen);
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar9 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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

        oVar1 = (CriPlayer)SceneManager.instance.DAT_27C[10];
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
        byte bVar1;
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

        oVar2 = (CriPlayer)SceneManager.instance.DAT_27C[10];
        local_60 = new Vector3Int();
        local_58 = new Vector3Int();
        bVar1 = DAT_58;

        if (bVar1 == 1)
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
            if (bVar1 < 2)
            {
                if (bVar1 != 0) goto LAB_29044;

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
                if (bVar1 != 2) goto LAB_29044;

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
}
