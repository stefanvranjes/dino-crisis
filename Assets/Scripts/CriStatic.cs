using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using Unity.Collections;
using Unity.Mathematics;

public struct MyVertex
{
    public float3 vertex;
    public float4 color;
    public float2 uv;
    public float3 uv2;

    public MyVertex(float3 v, float4 c, float2 t, float3 p)
    {
        vertex = v;
        color = c;
        uv = t;
        uv2 = p;
    }
}

[System.Serializable]
public struct MeshDataStruct
{
    public int triStart;
    public int triEnd;
    public int layer;
    public int materialID;
    public int cameraID;
}

[System.Serializable]
public class BoxCollider
{
    public string prefabName;

    public Vector3Int DAT_00; //0x00
    public short DAT_06; //0x06
}

public class CriStatic : CriObject
{
    public Vector3Int DAT_34; //0x34
    public TmdScriptableObject cMesh; //0x3C
    public CriObject DAT_40; //0x40
    public BoxCollider cCollider; //0x44
    public byte DAT_48; //0x48
    public ushort DAT_4A; //0x4A
    public Vector3Int DAT_4C; //0x4C
    public Vector3Int DAT_54; //0x54
    public int DAT_5C;
    public Packet[] PTR_60;
    public byte[] DAT_68;
    public byte DAT_6C;
    public byte DAT_6D;
    public byte DAT_6E;
    public byte DAT_6F;
    public uint DAT_74;
    public Vector2Int VDAT_74;
    public byte DAT_78;
    public byte DAT_79;
    public ushort DAT_7A;
    public byte DAT_7C;
    public byte DAT_7D;
    public sbyte DAT_7E;
    public Vector3Int DAT_80;
    private delegate void FUN_AA430();
    private delegate void FUN_AA438();
    private FUN_AA430[] PTR_FUN_AA430;
    private FUN_AA438[] PTR_FUN_AA438;
    public Material[] materials;
    public int triCount;

    protected Mesh mesh;
    protected int subMeshCount;
    private NativeArray<MyVertex> vertexBuffer;
    private NativeArray<ushort> indexBuffer;
    private NativeArray<int> indicies;

    protected override void Awake()
    {
        base.Awake();
        PTR_FUN_AA430 = new FUN_AA430[2]
        {
            FUN_7F734,
            FUN_7F748
        };
        PTR_FUN_AA438 = new FUN_AA438[5]
        {
            FUN_7F844,
            FUN_7F928,
            FUN_7FAE0,
            FUN_7FB4C,
            FUN_5FF00
        };
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();

        if ((GameManager.instance.DAT_38 & 1) == 0 && cMesh != null && (flags & 3) == 3)
        {
            if (gameObject.layer == 0)
            {
                Graphics.DrawMesh(mesh, transform.localToWorldMatrix, materials[0], 0, Camera.main, 0);
            }
            else
            {
                Graphics.DrawMesh(mesh, transform.localToWorldMatrix, materials[0], 2, RenderQueue.camera4, 0);
            }

            for (int i = 1; i < subMeshCount; i++)
            {
                if (indicies[i] > 0)
                {
                    Graphics.DrawMesh(mesh, transform.localToWorldMatrix, materials[i], 1, RenderQueue.camera2, i);
                }
            }
        }
    }

    private void OnDestroy()
    {
        vertexBuffer.Dispose();
        indexBuffer.Dispose();
        indicies.Dispose();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_34 = Vector3Int.zero;
        cMesh = null;
        DAT_40 = null;
        cCollider = null;
        DAT_48 = 0;
        DAT_4A = 0;
        DAT_4C = Vector3Int.zero;
        DAT_54 = Vector3Int.zero;
        DAT_5C = 0;
        PTR_60 = null;
        DAT_68 = null;
        DAT_6C = 0;
        DAT_6D = 0;
        DAT_6E = 0;
        DAT_6F = 0;
        DAT_74 = 0;
        VDAT_74 = Vector2Int.zero;
        DAT_78 = 0;
        DAT_79 = 0;
        DAT_7A = 0;
        DAT_7C = 0;
        DAT_7D = 0;
        DAT_7E = 0;
        DAT_80 = Vector3Int.zero;
    }

    public void SetMaterials()
    {
        materials = new Material[16];
        TmdScriptableObject tmd = cMesh;

        if (tmd != null)
        {
            Material mat1 = new Material(GameManager.instance.materials[0]);
            Material mat2 = new Material(GameManager.instance.materials[1]);
            Material mat3 = new Material(GameManager.instance.materials[2]);
            Material mat4 = new Material(GameManager.instance.materials[3]);
            Material mat5 = new Material(GameManager.instance.materials[4]);
            mat1.mainTexture = tmd.TEX_2D;
            mat1.SetTexture("_Tex8", tmd.TEX8_2D);
            mat1.SetTexture("_CLUT", tmd.CLUT_2D);
            materials[0] = mat1;
            mat2.mainTexture = tmd.TEX_2D;
            mat2.SetTexture("_Tex8", tmd.TEX8_2D);
            mat2.SetTexture("_CLUT", tmd.CLUT_2D);
            materials[1] = mat2;
            mat3.mainTexture = tmd.TEX_2D;
            mat3.SetTexture("_Tex8", tmd.TEX8_2D);
            mat3.SetTexture("_CLUT", tmd.CLUT_2D);
            materials[2] = mat3;
            mat4.mainTexture = tmd.TEX_2D;
            mat4.SetTexture("_Tex8", tmd.TEX8_2D);
            mat4.SetTexture("_CLUT", tmd.CLUT_2D);
            materials[3] = mat4;
            mat5.mainTexture = tmd.TEX_2D;
            mat5.SetTexture("_Tex8", tmd.TEX8_2D);
            mat5.SetTexture("_CLUT", tmd.CLUT_2D);
            materials[4] = mat5;
        }
    }

    public virtual void MeshData()
    {
        subMeshCount = 6;
        indexBuffer = new NativeArray<ushort>(
            (cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 6) * subMeshCount, Allocator.Persistent
        );

        vertexBuffer = new NativeArray<MyVertex>(
            cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 4, Allocator.Persistent
        );

        indicies = new NativeArray<int>(
            subMeshCount, Allocator.Persistent
        );

        mesh = new Mesh();
        mesh.subMeshCount = subMeshCount;
        mesh.SetVertexBufferParams(cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 4,
                                                 new VertexAttributeDescriptor(VertexAttribute.Position, VertexAttributeFormat.Float32, 3),
                                                 new VertexAttributeDescriptor(VertexAttribute.Color, VertexAttributeFormat.Float32, 4),
                                                 new VertexAttributeDescriptor(VertexAttribute.TexCoord0, VertexAttributeFormat.Float32, 2), 
                                                 new VertexAttributeDescriptor(VertexAttribute.TexCoord1, VertexAttributeFormat.Float32, 3));
        mesh.SetIndexBufferParams(subMeshCount * (cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 6), IndexFormat.UInt16);
        int f = cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 6;
        
        for (int i = cMesh.TRI_COUNT - 1; i >= 0; i--)
        {
            int tri = i * 3;

            if ((cMesh.CMDS[i] & 0x10) != 0)
            {
                vertexBuffer[tri] = new MyVertex(cMesh.VERTS[tri], cMesh.CLRS[tri].ToFloat(), cMesh.UVS[tri], cMesh.UVS2[i]);
                vertexBuffer[tri + 1] = new MyVertex(cMesh.VERTS[tri + 1], cMesh.CLRS[tri + 1].ToFloat(), cMesh.UVS[tri + 1], cMesh.UVS2[i]);
                vertexBuffer[tri + 2] = new MyVertex(cMesh.VERTS[tri + 2], cMesh.CLRS[tri + 2].ToFloat(), cMesh.UVS[tri + 2], cMesh.UVS2[i]);
            }
            else
            {
                vertexBuffer[tri] = new MyVertex(cMesh.VERTS[tri], new float4(1, 1, 1, 1), cMesh.UVS[tri], cMesh.UVS2[i]);
                vertexBuffer[tri + 1] = new MyVertex(cMesh.VERTS[tri + 1], new float4(1, 1, 1, 1), cMesh.UVS[tri + 1], cMesh.UVS2[i]);
                vertexBuffer[tri + 2] = new MyVertex(cMesh.VERTS[tri + 2], new float4(1, 1, 1, 1), cMesh.UVS[tri + 2], cMesh.UVS2[i]);
            }

            int cmd = cMesh.CMDS[i] & 0xef;
            int sm = indicies[cmd] + cmd * f;
            indexBuffer[sm] = (ushort)cMesh.TRIS[tri];
            indexBuffer[sm + 1] = (ushort)cMesh.TRIS[tri + 1];
            indexBuffer[sm + 2] = (ushort)cMesh.TRIS[tri + 2];
            indicies[cmd] += 3;
        }

        for (int i = cMesh.QUAD_COUNT - 1, j = cMesh.TRI_COUNT; i >= 0; i--)
        {
            int quad = j * 3 + i * 4;
            int tri = i * 6;

            if ((cMesh.CMDS[i + j] & 0x10) != 0)
            {
                vertexBuffer[quad] = new MyVertex(cMesh.VERTS[quad], cMesh.CLRS[quad].ToFloat(), cMesh.UVS[quad], cMesh.UVS2[i + j]);
                vertexBuffer[quad + 1] = new MyVertex(cMesh.VERTS[quad + 1], cMesh.CLRS[quad + 1].ToFloat(), cMesh.UVS[quad + 1], cMesh.UVS2[i + j]);
                vertexBuffer[quad + 2] = new MyVertex(cMesh.VERTS[quad + 2], cMesh.CLRS[quad + 2].ToFloat(), cMesh.UVS[quad + 2], cMesh.UVS2[i + j]);
                vertexBuffer[quad + 3] = new MyVertex(cMesh.VERTS[quad + 3], cMesh.CLRS[quad + 3].ToFloat(), cMesh.UVS[quad + 3], cMesh.UVS2[i + j]);
            }
            else
            {
                vertexBuffer[quad] = new MyVertex(cMesh.VERTS[quad], new float4(1, 1, 1, 1), cMesh.UVS[quad], cMesh.UVS2[i + j]);
                vertexBuffer[quad + 1] = new MyVertex(cMesh.VERTS[quad + 1], new float4(1, 1, 1, 1), cMesh.UVS[quad + 1], cMesh.UVS2[i + j]);
                vertexBuffer[quad + 2] = new MyVertex(cMesh.VERTS[quad + 2], new float4(1, 1, 1, 1), cMesh.UVS[quad + 2], cMesh.UVS2[i + j]);
                vertexBuffer[quad + 3] = new MyVertex(cMesh.VERTS[quad + 3], new float4(1, 1, 1, 1), cMesh.UVS[quad + 3], cMesh.UVS2[i + j]);
            }

            int cmd = cMesh.CMDS[i + j] & 0xef;
            int sm = indicies[cmd] + cmd * f;
            indexBuffer[sm] = (ushort)cMesh.QUADS[tri];
            indexBuffer[sm + 1] = (ushort)(cMesh.QUADS[tri + 1]);
            indexBuffer[sm + 2] = (ushort)(cMesh.QUADS[tri + 2]);
            indexBuffer[sm + 3] = (ushort)(cMesh.QUADS[tri + 3]);
            indexBuffer[sm + 4] = (ushort)(cMesh.QUADS[tri + 4]);
            indexBuffer[sm + 5] = (ushort)(cMesh.QUADS[tri + 5]);
            indicies[cmd] += 6;
        }

        mesh.SetVertexBufferData(vertexBuffer, 0, 0, cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 4);
        mesh.SetIndexBufferData(indexBuffer, 0, 0, subMeshCount * (cMesh.TRI_COUNT * 3 + cMesh.QUAD_COUNT * 6));

        for (int i = 0; i < subMeshCount; i++)
            mesh.SetSubMesh(i, new SubMeshDescriptor(i * f, indicies[i]));

        mesh.RecalculateBounds();
    }

    public virtual void UpdateMesh()
    {
        if (triCount != 0)
        {
            mesh.SetSubMesh(0, new SubMeshDescriptor(0, indicies[0] - triCount));
        }
    }

    public void FUN_7F6F8()
    {
        PTR_FUN_AA430[tags]();
    }

    private void FUN_7F734()
    {
        DAT_74 &= 0xffffff00;
        tags++;
    }

    private void FUN_7F748()
    {
        return;
    }

    public void FUN_7F750()
    {
        bool bVar1;

        if (DAT_2F != 0)
        {
            bVar1 = InventoryManager.FUN_4A87C(2, 0x1b);

            if (bVar1)
            {
                InventoryManager.FUN_4A7E8(2, 0x1b, false);
                flags |= 2;
            }
        }

        bVar1 = InventoryManager.FUN_4A87C(2, 2);

        if (!bVar1)
        {
            bVar1 = InventoryManager.FUN_4A87C(2, 3);

            if (!bVar1)
                vr.y = vr.y + 0x40 & 0xfff;
        }
    }

    public void FUN_7F7E4()
    {
        if (tags == 0)
        {
            tags++;
            //DAT_74 = DAT_44; ???
        }
    }

    public void FUN_7F808()
    {
        PTR_FUN_AA438[tags]();
    }

    private void FUN_7F844()
    {
        sbyte sVar1;
        uint uVar2;
        CriSkinned oVar3;

        cMesh = (TmdScriptableObject)Utilities.GetRamObject(0x80180178);
        cCollider = null;
        flags |= 2;
        DAT_7A = 0x14;
        tags = 1;
        oVar3 = SceneManager.instance.skinnedObjects[10];
        uVar2 = SceneManager.instance.FUN_83534(ref screen, oVar3.screen);

        if ((uVar2 & 0xff) == 8)
        {
            oVar3 = SceneManager.instance.skinnedObjects[(uVar2 & 0xffff) >> 8];
            oVar3.DAT_11E |= 0x80;
            oVar3.DAT_1A0 = DAT_7C;
            oVar3.DAT_1A1 = DAT_7D;
            sVar1 = 4;
        }
        else
        {
            if ((uVar2 & 0xff) == 0)
                return;

            DAT_7A = 4;
            sVar1 = 2;
        }

        tags = sVar1;
    }

    private void FUN_7F928()
    {
        sbyte sVar1;
        short sVar2;
        uint uVar3;
        CriSkinned oVar4;
        CriObject oVar5;
        Vector3Int local_50;
        Vector3Int local_48;
        Matrix3x3 MStack64;

        local_50 = screen;

        if (DAT_7E != -1)
        {
            oVar4 = SceneManager.instance.skinnedObjects[DAT_7E];
            oVar5 = Utilities.FUN_601C8(oVar4.skeleton, oVar4.DAT_175 & 15);
            sVar2 = Utilities.FUN_51C8C(screen, oVar5.screen, DAT_80.y, 0x10);
            DAT_80.y += sVar2;
        }

        MStack64 = new Matrix3x3();
        Utilities.RotMatrixYXZ(ref DAT_80, ref MStack64);
        local_48 = new Vector3Int(0, 0, 800);
        local_48 = Utilities.ApplyMatrixSV(ref MStack64, ref local_48);
        screen.x += local_48.x;
        screen.y += local_48.y;
        screen.z += local_48.z;
        uVar3 = SceneManager.instance.FUN_83534(ref screen, local_50);

        if ((uVar3 & 0xff) == 8)
        {
            oVar4 = SceneManager.instance.skinnedObjects[(uVar3 & 0xffff) >> 8];
            oVar4.DAT_11E |= 0x80;
            oVar4.DAT_1A0 = DAT_7C;
            oVar4.DAT_1A1 = DAT_7D;
        }
        else
        {
            if ((uVar3 & 0xff) != 0)
            {
                DAT_7A = 4;
                sVar1 = 2;
                goto LAB_7FAC4;
            }

            sVar2 = (short)(DAT_7A - 1);
            DAT_7A = (ushort)sVar2;

            if (sVar2 != 0)
                return;
        }

        sVar1 = 4;
        LAB_7FAC4:
        tags = sVar1;
    }

    private void FUN_7FAE0()
    {
        short sVar1;

        if ((DAT_7A & 1) == 0)
            sVar1 = (short)(vr.x - 0x100);
        else
            sVar1 = (short)(vr.x + 0x100);

        vr.x = sVar1;
        sVar1 = (short)(DAT_7A - 1);
        DAT_7A = (ushort)sVar1;

        if (sVar1 == 0)
        {
            DAT_7A = 0x1a;
            tags++;
        }
    }

    private void FUN_7FB4C()
    {
        short sVar1;

        sVar1 = (short)(DAT_7A - 1);
        DAT_7A = (ushort)sVar1;

        if (sVar1 == 0)
            tags = 4;
    }

    public void FUN_4A26C()
    {
        return;
    }
}
