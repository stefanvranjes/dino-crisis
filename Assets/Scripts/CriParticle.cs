using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct UNK_9C7CC
{
    public uint DAT_00;
    public ushort DAT_04;
    public ushort DAT_06;
    public ushort DAT_08;
    public bool DAT_0A;
}

public struct UNK_771C
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public short DAT_04;
    public short DAT_06;
    public short DAT_08;
}

public class CriParticle : CriObject
{
    public Vector3Int DAT_34; //0x34
    public byte DAT_3C; //0x3C
    public byte DAT_3D; //0x3D
    public byte DAT_3E; //0x3E
    public byte DAT_3F; //0x3F
    public Vector3Int DAT_40; //0x40
    public CriObject DAT_4C; //0x4C
    public Color32 DAT_50; //0x50
    public ushort DAT_54; //0x54
    public ushort DAT_56; //0x56
    public Tod2ScriptableObject DAT_58; //0x58
    public int DAT_5C; //0x5C
    public ushort DAT_60; //0x60
    public ushort DAT_62; //0x62
    public byte DAT_64; //0x64
    public byte DAT_65; //0x65
    public byte DAT_68; //0x68
    public byte DAT_69; //0x69
    public short SDAT_6A; //0x6A
    public byte DAT_6A; //0x6A
    public byte DAT_6B; //0x6B
    public byte DAT_6C; //0x6C
    public int IDAT_6C; //0x6C
    public short DAT_6E; //0x6E
    public short DAT_70; //0x70
    public short DAT_72; //0x72
    private delegate void FUN_7704(); //0x7704 (ST1)
    private delegate void FUN_7710(); //0x7710 (ST1)
    private delegate void FUN_780C(); //0x780C (ST1)
    private delegate void FUN_9C790();
    private delegate void FUN_9C7AC();
    private delegate void FUN_9C7B4();
    private delegate void FUN_9C7C0();
    private delegate void FUN_9C874();
    private delegate void FUN_9C884();
    private delegate void FUN_9C890();
    private delegate void FUN_9CBD4();
    private FUN_7704[] PTR_FUN_7704; //0x7704 (ST1)
    private FUN_7710[] PTR_FUN_7710; //0x7710 (ST1)
    private UNK_771C[] PTR_DAT_771C; //0x771C (ST1)
    private static uint[] DAT_77F8 = new uint[4] { 0x8011d314, 0x8011d324, 0x8011d33c, 0x8011d344 }; //0x77F8 (ST1)
    private FUN_780C[] PTR_FUN_780C; //0x780C (ST1)
    private static byte[] DAT_7808 = new byte[4] { 3, 1, 0, 0 }; //0x7808 (ST1)
    private static uint[] DAT_9C774 = new uint[7]
    {
        0x8019dfd8, 0x8019e698, 0x8019e6d8, 0x8019dfd8,
        0x8019e0c0, 0x8019e058, 0x8019e610
    };
    private FUN_9C790[] PTR_FUN_9C790;
    private static uint[] DAT_9C7A4 = new uint[2] { 0x8019e0e8, 0x8019e0f0 };
    private FUN_9C7AC[] PTR_FUN_9C7AC;
    private FUN_9C7B4[] PTR_FUN_9C7B4;
    private FUN_9C7C0[] PTR_FUN_9C7C0;
    private UNK_9C7CC[] PTR_DAT_9C7CC;
    private FUN_9C874[] PTR_FUN_9C874;
    private FUN_9C884[] PTR_FUN_9C884;
    private FUN_9C890[] PTR_FUN_9C890;
    private FUN_9CBD4[] PTR_FUN_9CBD4;

    private GridScriptableObject grid;
    private ClutScriptableObject clut;
    private List<byte> commandList;
    private List<Vector3> vertexList;
    private List<Vector2> uvList;
    private List<Vector3> uv2List;
    private List<Color> colorList;
    private List<int> triangleList;
    public Material[] materials;

    protected override void Awake()
    {
        base.Awake();
        PTR_FUN_7704 = new FUN_7704[3]
        {
            FUN_2BC,
            FUN_31C,
            FUN_60068
        };
        PTR_FUN_7710 = new FUN_7710[3]
        {
            FUN_398,
            FUN_448,
            FUN_60068
        };
        PTR_DAT_771C = new UNK_771C[]
        {

        };
        PTR_FUN_780C = new FUN_780C[4]
        {
            FUN_4B4, 
            FUN_5F8, 
            FUN_71C, 
            FUN_60068
        };
        PTR_FUN_9C790 = new FUN_9C790[5]
        {
            FUN_44F08,
            FUN_44FC0,
            FUN_60068,
            FUN_45038,
            FUN_45104
        };
        PTR_FUN_9C7AC = new FUN_9C7AC[2]
        {
            FUN_45260, 
            FUN_60068
        };
        PTR_FUN_9C7B4 = new FUN_9C7B4[3]
        {
            FUN_452D0,
            FUN_452D0,
            FUN_45304
        };
        PTR_FUN_9C7C0 = new FUN_9C7C0[3]
        {
            FUN_4538C,
            FUN_45444,
            FUN_60068
        };
        PTR_DAT_9C7CC = new UNK_9C7CC[]
        {

        };
        PTR_FUN_9C874 = new FUN_9C874[4]
        {
            FUN_454E0, 
            FUN_45630, 
            FUN_45650, 
            FUN_456B4
        };
        PTR_FUN_9C884 = new FUN_9C884[3]
        {
            FUN_457A4,
            FUN_458C0,
            FUN_60068
        };
        PTR_FUN_9C890 = new FUN_9C890[5]
        {
            FUN_45B44,
            FUN_45C4C,
            FUN_60068,
            FUN_45C6C,
            FUN_45CAC
        };
        PTR_FUN_9CBD4 = new FUN_9CBD4[3]
        {
            FUN_46A7C,
            FUN_46AE4,
            FUN_60068
        };
    }

    protected override void Start()
    {
        base.Start();
        commandList = new List<byte>();
        vertexList = new List<Vector3>();
        uvList = new List<Vector2>();
        uv2List = new List<Vector3>();
        colorList = new List<Color>();
        triangleList = new List<int>();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_34 = Vector3Int.zero;
        DAT_3C = 0;
        DAT_3D = 0;
        DAT_3E = 0;
        DAT_3F = 0;
        DAT_40 = Vector3Int.zero;
        DAT_4C = null;
        DAT_50 = Color.black;
        DAT_54 = 0;
        DAT_56 = 0;
        DAT_58 = null;
        DAT_5C = 0;
        DAT_60 = 0;
        DAT_62 = 0;
        DAT_64 = 0;
        DAT_65 = 0;
        DAT_68 = 0;
        DAT_69 = 0;
        SDAT_6A = 0;
        DAT_6A = 0;
        DAT_6B = 0;
        DAT_6C = 0;
        IDAT_6C = 0;
        DAT_6E = 0;
        DAT_70 = 0;
        DAT_72 = 0;
    }

    private void OnRenderObject()
    {
        if (DAT_58 != null && (flags & 2) != 0)
        {
            GL.PushMatrix();
            GL.MultMatrix(transform.localToWorldMatrix);

            for (int i = 0; i < commandList.Count; i++)
            {
                materials[commandList[i]].SetPass(0);
                GL.Begin(GL.TRIANGLES);
                int j = i * 6;

                for (int k = 0; k < 6; k++)
                {
                    if (!GameManager.instance.disableColors)
                        GL.Color(colorList[triangleList[j + k]]);
                    GL.MultiTexCoord(0, uvList[triangleList[j + k]]);
                    GL.MultiTexCoord(1, uv2List[i]);
                    GL.Vertex(vertexList[triangleList[j + k]]);
                }

                GL.End();
            }

            GL.PopMatrix();
        }
    }

    public void SetMaterials()
    {
        materials = new Material[255];
        grid = SceneManager.instance.grid;
        clut = SceneManager.instance.clut;
        Material mat1 = new Material(GameManager.instance.materials[0x2C]);
        mat1.mainTexture = grid.tex4;
        mat1.SetTexture("_Tex8", grid.tex8);
        mat1.SetTexture("_CLUT", clut.TEX_2D);
        materials[0x2C] = mat1;
    }

    public void AddBuffer()
    {
        commandList.Add(GameManager.DAT_1f800068.a);
        float translateFactor = 16f;
        int tri = vertexList.Count;
        vertexList.Add(GameManager.DAT_1f80006c.InvertY() / translateFactor);
        vertexList.Add(GameManager.DAT_1f800074.InvertY() / translateFactor);
        vertexList.Add(GameManager.DAT_1f80007c.InvertY() / translateFactor);
        vertexList.Add(GameManager.DAT_1f800084.InvertY() / translateFactor);
        colorList.Add(GameManager.DAT_1f800068.Opaque());
        colorList.Add(GameManager.DAT_1f800068.Opaque());
        colorList.Add(GameManager.DAT_1f800068.Opaque());
        colorList.Add(GameManager.DAT_1f800068.Opaque());
        ushort texpage = GameManager.DAT_1f80007a;
        ushort palette = GameManager.DAT_1f800072;
        bool lowColors = (texpage >> 7 & 3) == 0 ? true : false;
        int clutX = (palette & 0x3f) * 16;
        int clutY = palette >> 6;
        uv2List.Add(new Vector3((float)(clutX - clut.VRAM_X) / clut.WIDTH, (float)(clutY - clut.VRAM_Y) / clut.HEIGHT, lowColors ? 0f : 1f));
        int f = lowColors ? 4 : 2;
        int d = lowColors ? 1 : 1;
        int pageX = (texpage & 0xf) * 64 * f;
        int pageY = (texpage >> 4 & 1) * 256;
        float width = lowColors ? grid.tex4.width : grid.tex8.width;
        float height = grid.tex4.height;
        int vramX = grid.VRAM_X * f;
        int vramY = grid.VRAM_Y;
        Vector2Int uv1 = new Vector2Int(GameManager.DAT_1f800070, GameManager.DAT_1f800071);
        Vector2Int uv2 = new Vector2Int(GameManager.DAT_1f800078, GameManager.DAT_1f800079);
        Vector2Int uv3 = new Vector2Int(GameManager.DAT_1f800080, GameManager.DAT_1f800081);
        Vector2Int uv4 = new Vector2Int(GameManager.DAT_1f800088, GameManager.DAT_1f800089);
        uv1.x = pageX + (uv1.x / d) - vramX;
        uv1.y = pageY + uv1.y - vramY;
        uvList.Add(new Vector2(uv1.x / width, 1f - uv1.y / height));
        uv2.x = pageX + (uv2.x / d) - vramX;
        uv2.y = pageY + uv2.y - vramY;
        uvList.Add(new Vector2(uv2.x / width, 1f - uv2.y / height));
        uv3.x = pageX + (uv3.x / d) - vramX;
        uv3.y = pageY + uv3.y - vramY;
        uvList.Add(new Vector2(uv3.x / width, 1f - uv3.y / height));
        uv4.x = pageX + (uv4.x / d) - vramX;
        uv4.y = pageY + uv4.y - vramY;
        uvList.Add(new Vector2(uv4.x / width, 1f - uv4.y / height));
        triangleList.Add(tri);
        triangleList.Add(tri + 1);
        triangleList.Add(tri + 2);
        triangleList.Add(tri + 3);
        triangleList.Add(tri + 2);
        triangleList.Add(tri + 1);
    }

    public void ClearBuffer()
    {
        commandList.Clear();
        vertexList.Clear();
        uvList.Clear();
        uv2List.Clear();
        colorList.Clear();
        triangleList.Clear();
    }

    public void FUN_44EA8()
    {
        int iVar1;

        iVar1 = IDAT_6C - 1;
        IDAT_6C = iVar1;

        if (iVar1 == -1)
            FUN_451A4();

        PTR_FUN_9C790[DAT_3C]();
    }

    private void FUN_44F08()
    {
        byte bVar1;

        if ((DAT_2F & 0x80) != 0)
        {
            bVar1 = (byte)(DAT_2F & 0x7f);
            DAT_2F = bVar1;

            if (6 < bVar1)
            {
                DAT_2F = (byte)(bVar1 - 7);
                DAT_3C = 3;
                FUN_45038();
                return;
            }

            DAT_62 = DAT_69;
            DAT_60 = DAT_69;
        }

        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_9C774[DAT_2F]));
        DAT_56 = 62;
        DAT_54 = 0x7df0;
        DAT_3C = 1;
        flags |= 2;
    }

    private void FUN_44FC0()
    {
        int iVar1;

        screen.y += DAT_40.y;
        screen.x += DAT_40.x;
        screen.z += DAT_40.z;
        DAT_40.y += DAT_68;
        iVar1 = FUN_606D8();

        if (iVar1 == 1)
            DAT_3C = 2;
    }

    private void FUN_45038()
    {
        short sVar1;

        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_9C7A4[DAT_2F]));
        DAT_56 = 30;
        DAT_54 = 0x7df0;
        DAT_50.r = 0xd0;
        DAT_65 = 3;
        vr.x = 0x400;
        DAT_50.a |= 2;
        DAT_4C = SceneManager.instance.cCamera;

        if (DAT_68 == 0)
        {
            sVar1 = (short)(DAT_69 << 4);
            DAT_62 = (ushort)sVar1;
            DAT_60 = (ushort)sVar1;
            DAT_69 = 0;
            DAT_6A = 0;
        }

        DAT_6B = 0;
        flags |= 2;
        DAT_3C++;
    }

    private void FUN_45104()
    {
        byte bVar1;
        byte bVar2;

        if (DAT_69 != 0)
        {
            DAT_69--;
            bVar1 = DAT_6B;
            bVar2 = (byte)(bVar1 + DAT_68);
            DAT_6B = bVar2;

            if (bVar2 < bVar1)
            {
                DAT_60++;
                DAT_62++;
            }
        }

        if (DAT_6A < DAT_68)
            DAT_68 -= DAT_6A;
        else
            DAT_68 = 0;

        FUN_606D8();
    }

    private void FUN_451A4()
    {
        Vector3Int local_10;

        if (DAT_4C != null)
        {
            local_10 = Utilities.ApplyMatrixSV(ref DAT_4C.cTransform.rotation, ref screen);
            screen.x = DAT_4C.screen.x + local_10.x;
            screen.y = DAT_4C.screen.y + local_10.y;
            screen.z = DAT_4C.screen.z + local_10.z;
            DAT_40 = Utilities.ApplyMatrixSV(ref DAT_4C.cTransform.rotation, ref DAT_40);
            DAT_4C = null;
        } 
    }

    public void FUN_45224()
    {
        PTR_FUN_9C7AC[DAT_3C]();
    }

    private void FUN_45260()
    {
        int iVar1;

        iVar1 = FUN_606D8();

        if (DAT_2F == 0)
        {
            if (iVar1 != 0)
                DAT_3C++;
        }
        else
            PTR_FUN_9C7B4[DAT_2F]();
    }

    private void FUN_452D0()
    {
        if (GameManager.instance.DAT_7C == 0)
            DAT_3C++;
    }

    private void FUN_45304()
    {
        if ((SceneManager.instance.DAT_7CDC[DAT_68].flags & 1) == 0)
            DAT_3C++;
    }

    public void FUN_45350()
    {
        PTR_FUN_9C7C0[DAT_3C]();
    }

    private void FUN_4538C()
    {
        DAT_54 = 0x7df0;
        DAT_56 = 30;
        flags |= 2;
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8019e0c0));
        DAT_50.a |= 2;
        FUN_451A4();
        DAT_34 = screen;
        screen.y += 2000;
        SceneManager.instance.FUN_834F0(this);
        DAT_65 = 3;
        vr.x = 0x400;
        DAT_40.x = 0;
        DAT_4C = SceneManager.instance.cCamera;
        DAT_3C++;
    }

    private void FUN_45444()
    {
        int iVar1;

        iVar1 = FUN_606D8();

        if (iVar1 != 0)
            DAT_3C++;
    }

    public void FUN_45480()
    {
        int iVar1;

        PTR_FUN_9C874[DAT_3C]();
        iVar1 = IDAT_6C - 1;
        IDAT_6C = iVar1;

        if (iVar1 == -1)
            FUN_451A4();
    }

    private void FUN_454E0()
    {
        byte bVar1;
        int iVar2;
        int iVar3;

        iVar3 = 0;

        if (DAT_2F == 1)
            FUN_456F4(0);
        else
        {
            if (DAT_2F == 2)
            {
                iVar2 = DAT_69;
                iVar3 = FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(PTR_DAT_9C7CC[iVar2].DAT_00));
                DAT_56 = (ushort)(PTR_DAT_9C7CC[iVar2].DAT_04 & 0xff9f | PTR_DAT_9C7CC[iVar2].DAT_06 << 5);
                DAT_54 = PTR_DAT_9C7CC[iVar2].DAT_08;

                if (PTR_DAT_9C7CC[iVar2].DAT_06 != 0xff)
                    DAT_50.a |= 2;

                if (!PTR_DAT_9C7CC[iVar2].DAT_0A)
                    DAT_2F = 0;
                else
                {
                    FUN_456F4(0);
                    DAT_2F = 1;
                }
            }
        }

        flags |= 2;

        if (DAT_68 != 0)
        {
            DAT_62 = DAT_68;
            DAT_60 = DAT_68;
        }

        if (DAT_6B != 0)
            DAT_6C = DAT_6B;

        bVar1 = 2;

        if (iVar3 == 1)
            bVar1 = 3;

        DAT_3C = bVar1;
    }

    private void FUN_45630()
    {
        FUN_606D8();
    }

    private void FUN_45650()
    {
        int iVar1;

        screen.x += DAT_40.x;
        screen.y += DAT_40.y;
        screen.z += DAT_40.z;
        iVar1 = FUN_606D8();

        if (iVar1 != 0)
            DAT_3C = 3;
    }

    private void FUN_456B4()
    {
        if (DAT_2F == 1)
            GameManager.instance.DAT_0C.DAT_03 = 0;

        FUN_60068();
    }

    private void FUN_456F4(uint param2)
    {
        LightSource oVar2;

        oVar2 = GameManager.instance.DAT_0C;
        oVar2.DAT_03 = 1;
        oVar2.DAT_04 = screen;
        oVar2.DAT_0E = Utilities.DAT_18530[param2 & 0xff];
        oVar2.DAT_0A = 0x600;
        oVar2.DAT_00 = 0x20;
        oVar2.DAT_01 = 0x20;
        oVar2.DAT_02 = 0x20;
    }

    public void FUN_45758()
    {
        PTR_FUN_9C884[DAT_3C]();
        FUN_630EC();
    }

    private void FUN_457A4()
    {
        int iVar1;
        CriSkinned oVar1;
        Vector3Int local_20;
        Vector3Int local_18;

        local_20 = new Vector3Int(60, -40, -30);
        DAT_56 = 62;
        oVar1 = SceneManager.instance.DAT_27C[10];
        DAT_54 += 0x7df0;
        local_18 = new Vector3Int(0, oVar1.vr.y & 0xfff, 0);
        Utilities.RotMatrix(ref local_18, ref oVar1.cTransform.rotation);
        local_18 = Utilities.ApplyMatrixSV(ref oVar1.cTransform.rotation, ref local_20);
        iVar1 = Utilities.Rand();
        DAT_40.x = local_18.x + (iVar1 & 31) - 15;
        iVar1 = Utilities.Rand();
        DAT_40.y = local_18.y + (iVar1 & 31) - 15;
        iVar1 = Utilities.Rand();
        DAT_40.z = local_18.z + (iVar1 & 31) - 15;
        DAT_70 = 0x222;
        DAT_6A = 10;
        DAT_6E = 40;
        DAT_3C++;
    }

    private void FUN_458C0()
    {
        short sVar1;
        uint uVar2;
        uint uVar3;
        int iVar4;

        sVar1 = DAT_6E;
        DAT_6E = (short)(sVar1 - 1);

        if (sVar1 == 1)
            DAT_3C++;

        DAT_34 = screen;
        DAT_40.y += SDAT_6A;
        screen.y += DAT_40.y;
        DAT_40.x = (DAT_40.x * 0x180000 >> 0x10) / 0x19;
        vr.z = vr.z - DAT_70 & 0xfff;
        DAT_40.z = (DAT_40.z * 0x180000 >> 0x10) / 0x19;
        screen.x += DAT_40.x;
        screen.z += DAT_40.z;
        uVar2 = (ushort)SceneManager.instance.FUN_834F0(this);
        uVar3 = uVar2 >> 12;

        if (uVar3 == 1)
        {
            if ((uVar2 & 0xff) == 0)
            {
                if ((uVar2 & 0x400) == 0)
                    DAT_40.x = -DAT_40.x;
                else
                    DAT_40.z = -DAT_40.z;
            }
            else
            {
                DAT_40.x = -DAT_40.x;
                DAT_40.z = -DAT_40.z;
            }

            DAT_70 = (short)-DAT_70;
        }
        else
        {
            if (uVar3 < 2) goto LAB_45AAC;

            if (uVar3 != 2)
            {
                if (uVar3 != 3) goto LAB_45AAC;

                if ((uVar2 & 0xff) == 0)
                {
                    if ((uVar2 & 0x400) == 0)
                        DAT_40.x = -DAT_40.x;
                    else
                        DAT_40.z = -DAT_40.z;
                }
                else
                {
                    DAT_40.x = -DAT_40.x;
                    DAT_40.z = -DAT_40.z;
                }

                DAT_70 = (short)-DAT_70;
            }
            else
            {
                iVar4 = DAT_40.y << 0x10;
                sVar1 = (short)-((iVar4 >> 0x10) - (int)((uint)iVar4 >> 0x1f) >> 1);
                DAT_40.y = sVar1;

                if (-10 < sVar1) goto LAB_45AAC;
            }
        }

        GameManager.instance.FUN_5C94C(this, 18);

        LAB_45AAC:
        if (DAT_6E < 30)
            DAT_70 = (short)((DAT_70 * 0x130000 >> 0x10) / 0x14);
    }

    public void FUN_45B08()
    {
        PTR_FUN_9C890[DAT_3C]();
    }

    private void FUN_45B44()
    {
        byte bVar1;

        bVar1 = DAT_2F;
        DAT_56 = 126;
        DAT_54 = 0x7df2;

        if (bVar1 == 1)
        {
            DAT_50.r = 0;
            DAT_50.g = 0xff;
            DAT_50.b = 0;
        }
        else
        {
            if (bVar1 < 2)
            {
                if (bVar1 == 0)
                {
                    DAT_50.r = 0xff;
                    DAT_50.g = 0;
                    DAT_50.b = 0;
                }
            }
            else
            {
                if (bVar1 == 2)
                {
                    DAT_50.r = DAT_68;
                    DAT_50.g = DAT_69;
                    DAT_50.b = DAT_6A;
                }
            }
        }

        if (vr.y == 0)
        {
            DAT_60 = 11;
            DAT_62 = 11;
        }
        else
        {
            DAT_60 = (ushort)((uint)(vr.y & 0xf0) >> 4);
            DAT_62 = (ushort)(vr.y & 0xf);
        }

        DAT_50.a |= 2;
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8019e250));
        flags |= 2;
        DAT_3C++;
    }

    private void FUN_45C4C()
    {
        FUN_606D8();
    }

    private void FUN_45C6C()
    {
        FUN_45B44();
        DAT_62 = 6;
        DAT_60 = 6;
        flags &= 0xfffffffd;
    }

    private void FUN_45CAC()
    {
        bool bVar1;
        uint uVar2;

        bVar1 = InventoryManager.FUN_4A87C(2, 0x16);

        if (!bVar1)
        {
            bVar1 = InventoryManager.FUN_4A87C(2, 0x17);

            if (!bVar1)
                uVar2 = flags & 0xfffffffd;
            else
            {
                DAT_50.r = 0;
                DAT_50.g = 0xff;
                uVar2 = flags | 2;
            }

            flags = uVar2;
        }
        else
        {
            DAT_50.r = 0xff;
            DAT_50.g = 0;
            flags |= 2;
        }

        FUN_606D8();
    }

    public void FUN_46A1C()
    {
        int iVar1;

        iVar1 = IDAT_6C - 1;
        IDAT_6C = iVar1;

        if (iVar1 == -1)
            FUN_451A4();

        PTR_FUN_9CBD4[DAT_3C]();
    }

    private void FUN_46A7C()
    {
        DAT_56 = 62;
        DAT_54 = 0x7df1;
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8019e3b8));
        DAT_6B = 20;
        flags |= 2;
        DAT_3C++;
    }

    private void FUN_46AE4()
    {
        sbyte sVar1;
        int iVar2;

        DAT_34 = screen;
        screen.x += DAT_40.x;
        DAT_40.y += 10;
        screen.z += DAT_40.z;
        screen.y += DAT_40.y;
        vr.z = vr.z + DAT_6B * 2;
        iVar2 = SceneManager.instance.FUN_834F0(this);

        if (iVar2 >> 12 == 2)
        {
            GameManager.instance.FUN_5C94C(this, 22);
            DAT_6B = DAT_69;
            DAT_40.y = (DAT_40.y * -DAT_6A) / 0xff;
        }

        FUN_606D8();
        sVar1 = (sbyte)(DAT_68 - 1);
        DAT_68 = (byte)sVar1;

        if (sVar1 == -1)
            DAT_3C++;
    }

    //FUN_270 (ST1)
    public void FUN_270()
    {
        PTR_FUN_7704[DAT_3C]();
        FUN_630EC();
    }

    //FUN_2BC (ST1)
    private void FUN_2BC()
    {
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8010ee50));
        DAT_56 = 103;
        DAT_54 = 0x7ef0;
        DAT_50.a |= 2;
        DAT_3C++;
        flags |= 2;
    }

    //FUN_31C (ST1)
    private void FUN_31C()
    {
        int iVar1;

        iVar1 = FUN_606D8();

        if (iVar1 == 1)
            DAT_3C++;
    }

    //FUN_35C (ST1)
    public void FUN_35C()
    {
        PTR_FUN_7710[DAT_3C]();
    }

    //FUN_398 (ST1)
    private void FUN_398()
    {
        byte bVar1;
        ushort uVar2;
        uint[] local_20;

        local_20 = new uint[4];
        local_20[0] = ST1.instance.DAT_04[0];
        local_20[1] = ST1.instance.DAT_04[1];
        local_20[2] = ST1.instance.DAT_04[2];
        local_20[3] = ST1.instance.DAT_04[3];
        bVar1 = DAT_2F;
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(local_20[bVar1]));
        DAT_56 = 37;
        DAT_54 = 0x7f3c;

        if (bVar1 == 0)
            uVar2 = 12;
        else
            uVar2 = 8;

        DAT_60 = uVar2;
        DAT_62 = uVar2;
        flags |= 2;
        DAT_3C++;
    }

    //FUN_448 (ST1)
    private void FUN_448()
    {
        FUN_606D8();
    }

    //FUN_468 (ST1)
    public void FUN_468()
    {
        PTR_FUN_780C[DAT_3C]();
        FUN_630EC();
    }

    //FUN_4B4 (ST1)
    private void FUN_4B4()
    {
        byte bVar1;
        sbyte sVar2;
        byte bVar3;
        int iVar4;
        Vector3Int local_38;
        Vector3Int local_40;
        Matrix3x3 auStack48;

        iVar4 = DAT_2F;
        bVar1 = DAT_7808[PTR_DAT_771C[iVar4].DAT_03];
        DAT_54 = 0x7efa;
        DAT_56 = (ushort)(bVar1 << 5 | 5);
        sVar2 = (sbyte)PTR_DAT_771C[iVar4].DAT_02;
        DAT_50.a |= 2;
        DAT_62 = (ushort)(short)sVar2;
        DAT_60 = (ushort)(short)sVar2;
        bVar3 = PTR_DAT_771C[iVar4].DAT_01;
        DAT_50.r = bVar3;
        DAT_50.g = bVar3;
        DAT_50.b = bVar3;
        local_38 = new Vector3Int(0, vr.y, 0);
        auStack48 = new Matrix3x3();
        Utilities.RotMatrix(ref local_38, ref auStack48);
        local_40 = new Vector3Int(0, 0, PTR_DAT_771C[iVar4].DAT_04);
        local_40 = Utilities.ApplyMatrixSV(ref auStack48, ref local_40);
        DAT_40.x = local_40.x;
        DAT_40.y = PTR_DAT_771C[iVar4].DAT_06;
        DAT_72 = 0x10;
        DAT_40.z = local_40.z;
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_77F8[PTR_DAT_771C[iVar4].DAT_00]));
        vr = new Vector3Int(0, 0, 0);
        DAT_3C++;
    }

    //FUN_5F8 (ST1)
    private void FUN_5F8()
    {
        short sVar1;
        short sVar2;
        int iVar3;

        if (0 < screen.y)
        {
            DAT_3C++;
            DAT_60 >>= 1;
            iVar3 = DAT_40.x << 0x10;
            DAT_62 >>= 1;
            DAT_40.x = (iVar3 >> 0x10) - (iVar3 >> 0x1f) >> 1;
            screen.y = 0;
            iVar3 = DAT_40.z << 0x10;
            sVar1 = PTR_DAT_771C[DAT_2F].DAT_06;
            DAT_40.z = (iVar3 >> 0x10) - (iVar3 >> 0x1f) >> 1;
            DAT_40.y = sVar1;
        }

        sVar2 = PTR_DAT_771C[DAT_2F].DAT_08;
        DAT_40.y += DAT_72;
        screen.x += DAT_40.x;
        screen.z += DAT_40.z;
        vr.z = vr.z - sVar2 & 0xfff;
        screen.y += DAT_40.y;
        FUN_606D8();
    }

    //FUN_71C (ST1)
    private void FUN_71C()
    {
        short sVar1;

        if (0 < screen.y)
            DAT_3C++;

        sVar1 = PTR_DAT_771C[DAT_2F].DAT_08;
        DAT_40.y += DAT_72;
        screen.x += DAT_40.x;
        screen.z += DAT_40.z;
        vr.z = vr.z - sVar1 & 0xfff;
        screen.y += DAT_40.y;
        FUN_606D8();
    }

    public int FUN_606A8(Tod2ScriptableObject param1)
    {
        DAT_5C = 0;
        DAT_58 = param1;
        DAT_64 = param1.FRAMES[0].DAT_05;
        SetMaterials();
        return FUN_606D8();
    }

    public int FUN_606D8()
    {
        byte bVar1;
        uint uVar2;
        int iVar3;
        Frame2 fVar4;

        iVar3 = 0;

        if (DAT_64 != 1)
        {
            if (DAT_64 != 0) goto LAB_6078C;

            fVar4 = DAT_58.FRAMES[DAT_5C];
            uVar2 = fVar4.DAT_04 & 0xe0U;

            if (uVar2 == 0x20) goto LAB_6078C;

            if ((int)uVar2 < 0x21)
            {
                if (uVar2 != 0) goto LAB_6078C;

                fVar4 = DAT_58.FRAMES[DAT_5C + (fVar4.DAT_04 & 0x1f)];
            }
            else
            {
                if (uVar2 != 0x40) goto LAB_6078C;

                fVar4 = DAT_58.FRAMES[0];
            }

            DAT_5C = System.Array.IndexOf(DAT_58.FRAMES, fVar4);
            bVar1 = fVar4.DAT_05;
            DAT_64 = bVar1;

            if (bVar1 != 1) goto LAB_6078C;
        }

        iVar3 = (DAT_58.FRAMES[DAT_5C].DAT_04 << 0x18) >> 0x1d;
        LAB_6078C:
        DAT_64--;
        return iVar3;
    }
}
