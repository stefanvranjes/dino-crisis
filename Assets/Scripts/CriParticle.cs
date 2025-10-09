using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Unity.Mathematics;
using Unity.Collections;

public struct UNK_9C7CC
{
    public uint DAT_00;
    public ushort DAT_04;
    public ushort DAT_06;
    public ushort DAT_08;
    public bool DAT_0A;
}

public struct UNK_9CB94
{
    public uint DAT_00;
    public ushort DAT_04;
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
    public int IDAT_68; //0x68
    public CriStatic[] PTR_68; //0x68
    public byte DAT_68; //0x68
    public byte DAT_69; //0x69
    public short SDAT_6A; //0x6A
    public byte DAT_6A; //0x6A
    public byte DAT_6B; //0x6B
    public byte[] PTR_6C; //0x6C
    public int IDAT_6C; //0x6C
    public Vector3Int VDAT_6C; //0x6C
    public byte DAT_6D; //0x6D
    public byte BDAT_6E; //0x6E
    public short DAT_6E; //0x6E
    public byte DAT_6F; //0x6F
    public Vector3Int DAT_70; //0x70
    public byte BDAT_70; //0x70
    public byte DAT_71; //0x71
    public byte DAT_72; //0x72
    public byte DAT_73; //0x73
    public Vector3Int VDAT_74; //0x74
    public byte DAT_74; //0x74
    public byte DAT_75; //0x75
    public short DAT_76; //0x76
    public short SDAT_78; //0x78
    public sbyte DAT_78; //0x78
    public byte DAT_7A; //0x7A
    public byte DAT_7B; //0x7B
    private delegate void FUN_7704(); //0x7704 (ST1)
    private delegate void FUN_7710(); //0x7710 (ST1)
    private delegate void FUN_780C(); //0x780C (ST1)
    private delegate void FUN_13028(); //0x13028 (ST4)
    private delegate void FUN_13048(); //0x13048 (ST4)
    private delegate void FUN_13054(); //0x13054 (ST4)
    private delegate void FUN_13070(); //0x13070 (ST4)
    private delegate void FUN_9C790();
    private delegate void FUN_9C7AC();
    private delegate void FUN_9C7B4();
    private delegate void FUN_9C7C0();
    private delegate void FUN_9C874();
    private delegate void FUN_9C884();
    private delegate void FUN_9C890();
    private delegate void FUN_9C8A4();
    private delegate void FUN_9CAD0();
    private delegate void FUN_9CAF0();
    private delegate void FUN_9CBBC();
    private delegate void FUN_9CBD4();
    private FUN_7704[] PTR_FUN_7704; //0x7704 (ST1)
    private FUN_7710[] PTR_FUN_7710; //0x7710 (ST1)
    private UNK_771C[] PTR_DAT_771C; //0x771C (ST1)
    private static uint[] DAT_77F8 = new uint[4] { 0x8011d314, 0x8011d324, 0x8011d33c, 0x8011d344 }; //0x77F8 (ST1)
    private FUN_780C[] PTR_FUN_780C; //0x780C (ST1)
    private static byte[] DAT_7808 = new byte[4] { 3, 1, 0, 0 }; //0x7808 (ST1)
    private FUN_13028[] PTR_FUN_13028; //0x13028 (ST4)
    private FUN_13048[] PTR_FUN_13048; //0x13048 (ST4)
    private FUN_13054[] PTR_FUN_13054; //0x13054 (ST4)
    private FUN_13070[] PTR_FUN_13070; //0x13070 (ST4)
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
    private static UNK_9C7CC[] PTR_DAT_9C7CC;
    private FUN_9C874[] PTR_FUN_9C874;
    private FUN_9C884[] PTR_FUN_9C884;
    private FUN_9C890[] PTR_FUN_9C890;
    private FUN_9C8A4[] PTR_FUN_9C8A4;
    private FUN_9CAD0[] PTR_FUN_9CAD0;
    private static uint[] DAT_9CAE4 = new uint[3] { 0x8019e700, 0x8019e708, 0x8019e710 };
    private FUN_9CAF0[] PTR_FUN_9CAF0;
    private static uint DAT_9CAE0 = 0;
    private static UNK_9CB94[] PTR_DAT_9CB94;
    private FUN_9CBBC[] PTR_FUN_9CBBC;
    private FUN_9CBD4[] PTR_FUN_9CBD4;

    private GridScriptableObject grid;
    private ClutScriptableObject clut;
    private Mesh mesh;
    private NativeArray<MyVertex> vertexBuffer;
    private NativeArray<ushort> indexBuffer;
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
        PTR_FUN_13028 = new FUN_13028[3]
        {
            FUN_34A8,
            FUN_3578,
            FUN_60068
        };
        PTR_FUN_13048 = new FUN_13048[3]
        {
            FUN_3684,
            FUN_372C,
            FUN_60068
        };
        PTR_FUN_13054 = new FUN_13054[3]
        {
            FUN_379C,
            FUN_3808,
            FUN_60068
        };
        PTR_FUN_13070 = new FUN_13070[3]
        {
            FUN_3864,
            FUN_3908,
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
        PTR_FUN_9C8A4 = new FUN_9C8A4[3]
        {
            FUN_45D74,
            FUN_45DFC,
            FUN_60068
        };
        PTR_FUN_9CAD0 = new FUN_9CAD0[4]
        {
            FUN_45ED0,
            FUN_45FE4,
            FUN_461E0,
            FUN_60068
        };
        PTR_FUN_9CAF0 = new FUN_9CAF0[3]
        {
            FUN_46534,
            FUN_46598,
            FUN_60068
        };
        PTR_FUN_9CBBC = new FUN_9CBBC[3]
        {
            FUN_46850,
            FUN_4695C,
            FUN_60068
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
    }

    protected override void Update()
    {
        base.Update();

        if ((flags & 2) != 0 && (DAT_65 & 0x80) == 0)
        {
            Graphics.DrawMesh(mesh, transform.localToWorldMatrix, materials[5], gameObject.layer, Camera.main, 0);
        }
    }

    private void OnDestroy()
    {
        vertexBuffer.Dispose();
        indexBuffer.Dispose();
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
        PTR_68 = new CriStatic[2];
        IDAT_68 = 0;
        DAT_69 = 0;
        SDAT_6A = 0;
        DAT_6A = 0;
        DAT_6B = 0;
        PTR_6C = new byte[8];
        IDAT_6C = 0;
        VDAT_6C = Vector3Int.zero;
        DAT_6E = 0;
        DAT_70 = Vector3Int.zero;
        VDAT_74 = Vector3Int.zero;
        DAT_74 = 0;
        DAT_75 = 0;
        DAT_76 = 0;
        SDAT_78 = 0;
        DAT_78 = 0;
        DAT_7A = 0;
        DAT_7B = 0;
    }

    public void SetMaterials()
    {
        materials = new Material[16];
        grid = SceneManager.instance.grid;
        clut = SceneManager.instance.clut;
        Material mat1 = new Material(GameManager.instance.materials[5]);
        mat1.mainTexture = grid.tex4;
        mat1.SetTexture("_Tex8", grid.tex8);
        mat1.SetTexture("_CLUT", clut.TEX_2D);
        materials[5] = mat1;
    }

    public void MeshData()
    {
        int indexCount = 6 * 20;
        int vertexCount = 4 * 20;
        indexBuffer = new NativeArray<ushort>(
            indexCount, Allocator.Persistent
        );

        vertexBuffer = new NativeArray<MyVertex>(
            vertexCount, Allocator.Persistent
        );

        mesh = new Mesh();
        mesh.SetVertexBufferParams(vertexCount, new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3),
                                                new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.Float32, 4),
                                                new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float32, 2),
                                                new VertexAttributeDescriptor(VertexAttribute.TexCoord1, VertexAttributeFormat.Float32, 3));
        mesh.SetIndexBufferParams(indexCount, IndexFormat.UInt16);

        for (int i = 0; i < vertexCount; i++)
        {
            vertexBuffer[i] = new MyVertex(float3.zero, float4.zero, float2.zero, float3.zero);
        }

        for (int i = 0, j = 0; i < indexCount; i += 6, j += 4)
        {
            indexBuffer[i] = (ushort)j;
            indexBuffer[i + 1] = (ushort)(j + 1);
            indexBuffer[i + 2] = (ushort)(j + 2);
            indexBuffer[i + 3] = (ushort)(j + 3);
            indexBuffer[i + 4] = (ushort)(j + 2);
            indexBuffer[i + 5] = (ushort)(j + 1);
        }

        mesh.SetVertexBufferData(vertexBuffer, 0, 0, vertexCount);
        mesh.SetIndexBufferData(indexBuffer, 0, 0, indexCount);
    }

    public void UpdateMesh(int vertexCount, int indexCount)
    {
        mesh.SetVertexBufferData(vertexBuffer, 0, 0, vertexCount);
        mesh.SetSubMesh(0, new SubMeshDescriptor(0, indexCount));
        mesh.RecalculateBounds();
    }

    public void AddBuffer(int tri)
    {
        float translateFactor = 16f;
        float3 v1 = new float3(GameManager.DAT_1f80006c.x, -GameManager.DAT_1f80006c.y, GameManager.DAT_1f80006c.z) / translateFactor;
        float3 v2 = new float3(GameManager.DAT_1f800074.x, -GameManager.DAT_1f800074.y, GameManager.DAT_1f800074.z) / translateFactor;
        float3 v3 = new float3(GameManager.DAT_1f80007c.x, -GameManager.DAT_1f80007c.y, GameManager.DAT_1f80007c.z) / translateFactor;
        float3 v4 = new float3(GameManager.DAT_1f800084.x, -GameManager.DAT_1f800084.y, GameManager.DAT_1f800084.z) / translateFactor;
        float4 c = new float4(GameManager.DAT_1f800068.r, GameManager.DAT_1f800068.g, GameManager.DAT_1f800068.b, 255) / 255;
        ushort texpage = GameManager.DAT_1f80007a;
        ushort palette = GameManager.DAT_1f800072;
        bool lowColors = (texpage >> 7 & 3) == 0 ? true : false;
        int clutX = (palette & 0x3f) * 16;
        int clutY = palette >> 6;
        float3 p = new float3((float)(clutX - clut.VRAM_X) / clut.WIDTH, (float)(clutY - clut.VRAM_Y) / clut.HEIGHT, lowColors ? 0f : 1f);
        int f = lowColors ? 4 : 2;
        int d = lowColors ? 1 : 1;
        int pageX = (texpage & 0xf) * 64 * f;
        int pageY = (texpage >> 4 & 1) * 256 + 1;
        float width = lowColors ? grid.tex4.width : grid.tex8.width;
        float height = grid.tex4.height;
        int vramX = grid.VRAM_X * f;
        int vramY = grid.VRAM_Y;
        float2 uv1 = new float2(GameManager.DAT_1f800070, GameManager.DAT_1f800071);
        float2 uv2 = new float2(GameManager.DAT_1f800078, GameManager.DAT_1f800079);
        float2 uv3 = new float2(GameManager.DAT_1f800080, GameManager.DAT_1f800081);
        float2 uv4 = new float2(GameManager.DAT_1f800088, GameManager.DAT_1f800089);
        uv1.x = pageX + (uv1.x / d) - vramX;
        uv1.y = pageY + uv1.y - vramY;
        uv1 = new float2(uv1.x / width, 1f - uv1.y / height);
        uv2.x = pageX + (uv2.x / d) - vramX;
        uv2.y = pageY + uv2.y - vramY;
        uv2 = new float2(uv2.x / width, 1f - uv2.y / height);
        uv3.x = pageX + (uv3.x / d) - vramX;
        uv3.y = pageY + uv3.y - vramY;
        uv3 = new float2(uv3.x / width, 1f - uv3.y / height);
        uv4.x = pageX + (uv4.x / d) - vramX;
        uv4.y = pageY + uv4.y - vramY;
        uv4 = new float2(uv4.x / width, 1f - uv4.y / height);
        vertexBuffer[tri] = new MyVertex(v1, c, uv1, p);
        vertexBuffer[tri + 1] = new MyVertex(v2, c, uv2, p);
        vertexBuffer[tri + 2] = new MyVertex(v3, c, uv3, p);
        vertexBuffer[tri + 3] = new MyVertex(v4, c, uv4, p);
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

    public void FUN_451A4()
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
        if ((SceneManager.instance.staticObjects[DAT_68].flags & 1) == 0)
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
            PTR_6C[0] = DAT_6B;

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
        oVar1 = SceneManager.instance.skinnedObjects[10];
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
        DAT_70.x = 0x222;
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
        vr.z = vr.z - DAT_70.x & 0xfff;
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

            DAT_70.x = -DAT_70.x;
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

                DAT_70.x = -DAT_70.x;
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
            DAT_70.x = (DAT_70.x * 0x130000 >> 0x10) / 0x14;
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

    public void FUN_45D38()
    {
        PTR_FUN_9C8A4[DAT_3C]();
    }

    private void FUN_45D74()
    {
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8019dfd8));
        DAT_62 = 10;
        DAT_60 = 10;
        DAT_54 = 0x7df0;
        flags |= 2;

        if (DAT_2F == 4)
        {
            DAT_56 = 0x7e;
            DAT_50.a |= 2;
        }
        else
            DAT_56 = 0x3e;

        DAT_3C++;
    }

    private void FUN_45DFC()
    {
        screen.x += DAT_40.x;
        screen.z += DAT_40.z;
        FUN_606D8();

        if ((DAT_58.FRAMES[DAT_5C].DAT_04 & 0xe0) != 0)
            DAT_3C++;
    }

    public void FUN_45E70()
    {
        int iVar1;

        iVar1 = IDAT_6C - 1;
        IDAT_6C = iVar1;

        if (iVar1 == -1)
            FUN_451A4();

        PTR_FUN_9CAD0[DAT_3C]();
    }

    private void FUN_45ED0()
    {
        CriSkinned oVar1;
        ushort uVar2;

        oVar1 = SceneManager.instance.skinnedObjects[10];
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8019e5c8));
        DAT_56 = 0x7e;
        DAT_54 = 0x7df8;
        DAT_50.a |= 2;
        DAT_69 = 2;
        DAT_6A = 0;
        flags |= 2;

        if (DAT_2F == 0)
        {
            DAT_62 = 10;
            DAT_60 = 10;
            DAT_6B = 60;
            DAT_3C = 1;
            uVar2 = (ushort)SceneManager.instance.FUN_83534(ref screen, oVar1.screen);

            if ((uVar2 & 0xff) == 0)
                return;

            FUN_46334((sbyte)uVar2, uVar2);
        }
        else
        {
            DAT_62 = 7;
            DAT_60 = 7;
            DAT_6B = 90;
            DAT_3C = 2;
            uVar2 = (ushort)SceneManager.instance.FUN_83534(ref screen, oVar1.screen);

            if ((uVar2 & 0xff) == 0)
                return;

            FUN_4640C((sbyte)uVar2, uVar2);
            FUN_462CC();
        }

        DAT_3C = 3;
    }

    private void FUN_45FE4()
    {
        byte bVar2;
        byte bVar3;
        short sVar4;
        ushort uVar5;
        CriSkinned oVar6;
        CriObject oVar7;
        CriParticle oVar8;
        Vector3Int local_50;
        Vector3Int local_48;
        Matrix3x3 MStack64;

        local_50 = screen;
        bVar2 = (byte)(DAT_6A + 1);
        DAT_6A = bVar2;
        screen.y += bVar2 >> 4;

        if (DAT_78 != -1)
        {
            oVar6 = SceneManager.instance.skinnedObjects[DAT_78];
            oVar7 = Utilities.FUN_601C8(oVar6.skeleton, oVar6.DAT_175 & 15);
            sVar4 = Utilities.FUN_51C8C(screen, oVar7.screen, DAT_70.y, 0x10);
            DAT_70.y += sVar4;
        }

        MStack64 = new Matrix3x3();
        Utilities.RotMatrixYXZ(ref DAT_70, ref MStack64);
        local_48 = new Vector3Int(0, 0, 500);
        local_48 = Utilities.ApplyMatrixSV(ref MStack64, ref local_48);
        screen.x += local_48.x;
        screen.y += local_48.y;
        screen.z += local_48.z;
        FUN_606D8();
        bVar3 = (byte)(DAT_69 - 1);
        DAT_69 = bVar3;

        if (bVar3 == 0)
        {
            oVar8 = SceneManager.instance.FUN_5FFA0();

            if (oVar8 != null)
            {
                oVar8.tags = 3;
                oVar8.DAT_2F = 2;
                oVar8.screen = screen;
                oVar8.DAT_62 = 20;
                oVar8.DAT_60 = 20;
                oVar8.DAT_69 = 0;
            }

            DAT_69 = 2;
        }

        uVar5 = (ushort)SceneManager.instance.FUN_83534(ref screen, local_50);

        if ((uVar5 & 0xff) != 0)
        {
            FUN_46334((sbyte)uVar5, uVar5);
            DAT_3C = 3;
        }

        bVar3 = (byte)(DAT_6B - 1);
        DAT_6B = bVar3;

        if (bVar3 == 0)
            DAT_3C = 3;
    }

    private void FUN_461E0()
    {
        byte bVar1;
        byte bVar2;
        ushort uVar3;
        Vector3Int local_10;

        local_10 = screen;
        screen.y += DAT_40.y;
        screen.x += DAT_40.x;
        screen.z += DAT_40.z;
        bVar1 = (byte)(DAT_6A + 1);
        DAT_6A = bVar1;
        screen.y += bVar1 * 8;
        FUN_606D8();
        uVar3 = (ushort)SceneManager.instance.FUN_83534(ref screen, local_10);

        if ((uVar3 & 0xff) != 0)
        {
            FUN_4640C((sbyte)uVar3, uVar3);
            FUN_462CC();
            DAT_3C = 3;
        }

        bVar2 = (byte)(DAT_6B - 1);
        DAT_6B = bVar2;

        if (bVar2 == 0)
            DAT_3C = 3;
    }

    private void FUN_462CC()
    {
        if (5 < GameManager.instance.DAT_04 - DAT_9CAE0)
        {
            GameManager.instance.FUN_5C94C(this, 24);
            DAT_9CAE0 = GameManager.instance.DAT_04;
        }
    }

    private void FUN_46334(sbyte param1, uint param2)
    {
        CriSkinned oVar1;
        CriInteract oVar2;

        if (param1 == 8)
        {
            oVar1 = SceneManager.instance.skinnedObjects[(param2 & 0xffff) >> 8];

            if ((oVar1.DAT_11E & 0x40) == 0)
            {
                oVar1.DAT_11E |= 0x80;
                oVar1.DAT_1A0 = 0x30;
                oVar1.DAT_1A1 = 8;
            }
        }

        oVar2 = SceneManager.instance.FUN_5FF08();

        if (oVar2 != null)
        {
            oVar2.DAT_01 = 11;
            oVar2.BDAT_0A = 12;
            //...
            oVar2.VDAT_10 = screen;
        }

        GameManager.instance.FUN_5C94C(this, 23);
    }

    private void FUN_4640C(sbyte param1, uint param2)
    {
        CriSkinned oVar2;
        CriInteract oVar3;

        if (param1 == 8)
        {
            oVar2 = SceneManager.instance.skinnedObjects[(param2 & 0xffff) >> 8];

            if ((oVar2.DAT_11E & 0x40) == 0)
            {
                oVar2.DAT_11E |= 0x80;
                oVar2.DAT_1A0 = 0x30;
                oVar2.DAT_1A1 = 9;
            }
        }
        else
        {
            oVar3 = SceneManager.instance.FUN_5FF08();

            if (oVar3 != null)
            {
                oVar3.DAT_01 = 11;
                oVar3.VDAT_10 = screen;
                oVar3.BDAT_0A = 9;
                //...
            }
        }
    }

    public void FUN_464F8()
    {
        PTR_FUN_9CAF0[DAT_3C]();
    }

    private void FUN_46534()
    {
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(DAT_9CAE4[DAT_2F]));
        DAT_54 = 0x7df4;
        DAT_56 = 0x3e;
        DAT_3C = 1;
        flags |= 2;
    }

    private void FUN_46598()
    {
        int iVar1;

        FUN_606D8();
        vr.x = vr.x + VDAT_6C.x & 0xfff;
        vr.y = vr.y + VDAT_6C.y & 0xfff;
        vr.z = vr.z + VDAT_6C.z & 0xfff;
        DAT_40.x += VDAT_74.x;
        DAT_40.y += VDAT_74.y;
        DAT_40.z += VDAT_74.z;
        screen.x += DAT_40.x;
        iVar1 = IDAT_68 - 1;
        IDAT_68 = iVar1;
        screen.y += DAT_40.y;
        screen.z += DAT_40.z;

        if (iVar1 == 0)
            DAT_3C = 2;
    }

    public void FUN_46814()
    {
        PTR_FUN_9CBBC[DAT_3C]();
    }

    private byte FUN_4699C()
    {
        byte bVar1;
        ushort uVar2;

        uVar2 = (ushort)vr.y;
        bVar1 = DAT_2F;
        vr.y = 0;
        DAT_62 = uVar2;
        DAT_60 = uVar2;
        DAT_2F = (byte)(bVar1 >> 4 & 7);
        return (byte)(bVar1 & 0xf);
    }

    private void FUN_46850()
    {
        ushort uVar1;
        ushort uVar2;
        uint uVar3;
        uint uVar4;

        uVar4 = 0;

        if ((DAT_2F & 0x80) != 0)
            uVar4 = FUN_4699C();

        uVar3 = DAT_2F;
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(PTR_DAT_9CB94[uVar3].DAT_00));
        uVar2 = 8;

        if (uVar3 == 2)
            uVar2 = 0x18;

        uVar1 = (ushort)(uVar2 | 0x20);

        if (uVar3 == 4)
            uVar1 = (ushort)(uVar2 | 0x40);

        DAT_56 = uVar1;
        DAT_54 = PTR_DAT_9CB94[uVar3].DAT_04;
        flags |= 2;
        DAT_50.a |= 2;
        uVar3 = 0;

        if ((uVar4 & 0xff) != 0)
        {
            do
            {
                FUN_606D8();
                uVar3++;
            } while (uVar3 < (uVar4 & 0xff));
        }

        DAT_3C++;
    }

    private void FUN_4695C()
    {
        int iVar1;

        iVar1 = FUN_606D8();

        if (iVar1 == 1)
            DAT_3C++;
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
        DAT_70.y = 0x10;
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
        DAT_40.y += DAT_70.y;
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
        DAT_40.y += DAT_70.y;
        screen.x += DAT_40.x;
        screen.z += DAT_40.z;
        vr.z = vr.z - sVar1 & 0xfff;
        screen.y += DAT_40.y;
        FUN_606D8();
    }

    //FUN_346C (ST4)
    public void FUN_346C()
    {
        PTR_FUN_13028[DAT_3C]();
    }

    //FUN_34A8 (ST4)
    private void FUN_34A8()
    {
        uint uVar2;
        uint uVar3;

        uVar3 = 0;

        if ((DAT_2F & 0x80) != 0)
            uVar3 = ST4.instance.FUN_3608(this);

        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(ST4.instance.PTR_DAT_12FF0[DAT_2F].DAT_00));
        DAT_56 = 0x25;
        DAT_54 = ST4.instance.PTR_DAT_12FF0[DAT_2F].DAT_04;
        flags |= 2;
        DAT_50.a |= 2;
        uVar2 = 0;

        if ((uVar3 & 0xff) != 0)
        {
            do
            {
                FUN_606D8();
                uVar2++;
            } while (uVar2 < (uVar3 & 0xff));
        }

        DAT_3C++;
    }

    //FUN_3578 (ST4)
    private void FUN_3578()
    {
        short sVar1;
        int iVar2;
        short sVar3;

        iVar2 = FUN_606D8();

        if (iVar2 == 1)
            DAT_3C++;

        if (DAT_2F < 5)
        {
            sVar3 = (short)(DAT_40.y + DAT_68);
            sVar1 = (short)(screen.y + sVar3);
            screen.y = sVar1;
            DAT_40.y = sVar3;

            if (10000 < sVar1)
                DAT_3C++;
        }
    }

    //FUN_3648 (ST4)
    public void FUN_3648()
    {
        PTR_FUN_13048[DAT_3C]();
    }

    //FUN_3684 (ST4)
    private void FUN_3684()
    {
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(ST4.instance.DAT_13034[DAT_2F]));
        DAT_56 = 8;
        DAT_54 = 0x7efc;
        DAT_65 = 3;
        DAT_50.a |= 2;
        flags |= 2;
        vr.y = DAT_68 << 4;
        DAT_4C = SceneManager.instance.cCamera;
        DAT_3C = 1;
        vr.x = DAT_69 << 4;
    }

    //FUN_372C (ST4)
    private void FUN_372C()
    {
        int iVar1;

        iVar1 = FUN_606D8();

        if (iVar1 == 1)
            DAT_3C = 2;
    }

    //FUN_3760 (ST4)
    public void FUN_3760()
    {
        PTR_FUN_13054[DAT_3C]();
    }

    //FUN_379C (ST4)
    private void FUN_379C()
    {
        DAT_62 = DAT_68;
        DAT_60 = DAT_68;
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(0x8010c830));
        DAT_56 = 0x68;
        DAT_54 = 0x7f3b;
        DAT_3C = 1;
        DAT_50.a |= 2;
        flags |= 2;
    }

    //FUN_3808 (ST4)
    private void FUN_3808()
    {
        FUN_606D8();
    }

    //FUN_3828 (ST4)
    public void FUN_3828()
    {
        PTR_FUN_13070[DAT_3C]();
    }

    //FUN_3864 (ST4)
    private void FUN_3864()
    {
        FUN_606A8((Tod2ScriptableObject)Utilities.GetRamObject(ST4.instance.DAT_13060[DAT_2F]));
        DAT_56 = 0x27;
        DAT_54 = 0x7ef1;
        flags |= 2;
        DAT_62 = DAT_68;
        DAT_60 = DAT_68;
        DAT_40.x = DAT_69;
        DAT_40.y = -DAT_6A;
        DAT_68 = 0;
        DAT_3C = 1;
        DAT_40.z = -DAT_6B;
    }

    //FUN_3908 (ST4)
    private void FUN_3908()
    {
        ushort uVar1;
        ushort uVar3;
        short sVar4;
        int iVar5;
        uint uVar6;
        uint uVar7;

        iVar5 = FUN_606D8();

        if (iVar5 == 1)
            DAT_3C = 2;

        if (DAT_40.z == 0)
            return;

        screen.x += DAT_40.x;
        DAT_40.y += 40;
        screen.z += DAT_40.z;
        screen.y += DAT_40.y;
        uVar7 = 0;

        if (12999 < screen.z)
        {
            iVar5 = 13000 - screen.z;
            uVar7 = (uint)(iVar5 - (int)((uint)iVar5 >> 31)) >> 1;
        }

        uVar3 = (ushort)(uVar7 & 0xff00);

        if ((short)uVar3 <= screen.y)
        {
            uVar1 = DAT_60;
            iVar5 = (int)(uVar1 * 0x190000) >> 0x10;

            if (iVar5 < DAT_40.y)
                DAT_40.y = (short)(uVar1 * 0x19);
            else
            {
                if (DAT_40.y < -iVar5)
                    DAT_40.y = (short)(uVar1 * -0x19);
            }

            screen.y = (short)uVar3;
            DAT_40.y = -DAT_40.y;
            uVar6 = (uint)Utilities.Rand();
            DAT_40.x = (short)(ST4.instance.DAT_1306C[uVar6 & 3] * DAT_60);

            if (screen.x < -10200)
                sVar4 = 40;
            else
            {
                if (screen.x < -5699) goto LAB_3A78;

                sVar4 = -40;
            }

            DAT_40.x = sVar4;
        }

        LAB_3A78:
        if ((uVar7 & 0xff00) == 0 && DAT_40.z < 0)
            DAT_40.z++;

        vr.z += 0xa0;
    }

    public int FUN_606A8(Tod2ScriptableObject param1)
    {
        DAT_5C = 0;
        DAT_58 = param1;
        DAT_64 = param1.FRAMES[0].DAT_05;
        SetMaterials();
        MeshData();
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