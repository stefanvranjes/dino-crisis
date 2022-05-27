using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance;

    public ScnScriptableObject data;
    public Tmd2ScriptableObject playerSkin;
    public CriSkinned[] DAT_27C; //gp+27ch...gp+1c9ch
    public CriBone[] DAT_1C9C; //gp+1c9ch...gp+5fcch
    public CriObject[] DAT_5FCC; //gp+5fcch...gp+7cdch
    public CriObject[] DAT_7CDC; //gp+7cdch...gp+8ffch

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
        DAT_27C = new CriSkinned[11];
        DAT_1C9C = new CriBone[100];
        DAT_5FCC = new CriObject[60];
        DAT_7CDC = new CriObject[40];

        for (int i = 0; i < data.staticObjs.Count; i++)
        {
            FUN_570A0(data.staticObjs[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FUN_47BE0()
    {
        CriPlayer oVar3;

        GameManager.instance.DAT_55 = 0;
        GameManager.instance.DAT_21 = 6;
        GameManager.instance.DAT_28++;
        //FUN_6E6C8

        if (GameManager.instance.DAT_9AA1 != GameManager.instance.DAT_9ADD)
        {
            //FUN_1802C
        }

        //FUN_1802C
        //FUN_601A4
        //FUN_5DDD0
        GameObject obj = new GameObject();
        oVar3 = obj.AddComponent<CriPlayer>();
        DAT_27C[10] = oVar3;
        oVar3.screen = GameManager.instance.playerSpawnPos;
        oVar3.DAT_34_2 = GameManager.instance.playerSpawnPos;
        oVar3.vr.y = GameManager.instance.playerSpawnRotY;
        oVar3.DAT_48 = (sbyte)-(oVar3.screen.y / 0x1a9);

    }

    private void FUN_570A0(_STATIC_OBJ_DATA data)
    {
        CriStatic oVar1;

        GameObject obj = new GameObject();
        oVar1 = obj.AddComponent<CriStatic>();
        DAT_7CDC[data.DAT_01] = oVar1;
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
                    mat.SetTexture("_Tex8", tmd.TEX8_2D);
                    mat.SetTexture("_CLUT", tmd.CLUT_2D);
                    oVar1.materials[tmd.CMDS[i]] = mat;
                }
            }
        }
    }

    public CriBone FUN_601F0()
    {
        int iVar1;
        CriBone puVar2;
        int iVar3;

        iVar1 = 99;
        iVar3 = 0;

        do
        {
            iVar1--;
            puVar2 = DAT_1C9C[iVar3];

            if (puVar2 != null && (puVar2.flags & 1) == 0)
            {
                puVar2.ResetValues();
                puVar2.flags = 3;
                puVar2.DAT_43 = false;
                return puVar2;
            }

            iVar3++;
        } while (iVar1 != -1);

        return null;
    }
}
