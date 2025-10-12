using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Floor : CriStatic
{
    public MeshDataStruct[] meshData;

    // Start is called before the first frame update
    protected override void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    protected override void Update()
    {
        base.Update();

        if ((GameManager.instance.DAT_38 & 1) == 0 && cMesh != null && (flags & 3) == 3)
        {
            for (int i = 0; i < meshData.Length; i++)
            {
                Graphics.DrawMesh(mesh, transform.localToWorldMatrix, materials[meshData[i].materialID], meshData[i].layer,
                    RenderQueue.GetCamera(meshData[i].cameraID), subMeshCount + i);
            }
        }
    }

    public override void MeshData()
    {
        base.MeshData();
        mesh.subMeshCount += meshData.Length;
        mesh.SetSubMesh(0, new SubMeshDescriptor(0, 0));

        for (int i = 0; i < meshData.Length; i++)
        {
            mesh.SetSubMesh(subMeshCount + i, new SubMeshDescriptor(meshData[i].triStart, meshData[i].triEnd * 3));
        }
    }

    public override void UpdateMesh()
    {
        if (triCount != 0)
        {
            mesh.subMeshCount = subMeshCount + meshData.Length;

            for (int i = 0; i < meshData.Length; i++)
            {
                mesh.SetSubMesh(subMeshCount + i, new SubMeshDescriptor(0, 0));
            }

            for (int i = 0; i < meshData.Length; i++)
            {
                mesh.SetSubMesh(subMeshCount + i, new SubMeshDescriptor(meshData[i].triStart, meshData[i].triEnd * 3));
            }
        }
    }
}
