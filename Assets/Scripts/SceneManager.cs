using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance;

    public ScnScriptableObject data;
    public List<CriObject> DAT_27C; //gp+27ch...gp+1c9ch
    public List<CriObject> DAT_5FCC; //gp+5fcch...gp+7cdch
    public List<CriObject> DAT_7CDC; //gp+7cdch...gp+8ffch

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        GameManager.sceneManager = this;
        DAT_7CDC = new List<CriObject>();

        for (int i = 0; i < 20; i++)
        {
            GameObject obj = new GameObject();
            DAT_7CDC.Add(obj.AddComponent<CriObject>());
        }

        for (int i = 0; i < data.staticObjs.Count; i++)
        {
            FUN_570A0(data.staticObjs[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FUN_570A0(_STATIC_OBJ_DATA data)
    {
        CriObject oVar1;

        oVar1 = DAT_7CDC[data.DAT_01];
        oVar1.flags = 3;
        oVar1.DAT_2E = data.DAT_02;
        oVar1.DAT_48 = data.DAT_03;
        oVar1.DAT_4A = data.DAT_04;
        oVar1.cMesh = data.DAT_08;
        oVar1.screen = data.DAT_0C;
        oVar1.vr = data.DAT_12;
        oVar1.materials = new Material[255];
        TmdScriptableObject tmd = oVar1.cMesh;

        if (tmd != null)
        {
            for (int i = 0; i < tmd.CMDS.Length; i++)
            {
                if (oVar1.materials[tmd.CMDS[i]] == null)
                {
                    Material mat = new Material(GameManager.instance.materials[tmd.CMDS[i]]);
                    mat.mainTexture = tmd.TEX_2D;
                    mat.SetTexture("_CLUT", tmd.CLUT_2D);
                    oVar1.materials[tmd.CMDS[i]] = mat;
                }
            }
        }
    }
}
