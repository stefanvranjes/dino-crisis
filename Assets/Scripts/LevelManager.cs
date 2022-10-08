using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public ushort DAT_B58BA;
    public delegate void FUN_B58C0(CriPlayer p);
    public FUN_B58C0[] PTR_FUN_B58C0;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Initialize()
    {

    }

    public void FUN_4A3C4()
    {
        CriPlayer pbVar1;
        int iVar2;
        int iVar3;

        iVar3 = 10;
        iVar2 = 0;

        do
        {
            pbVar1 = (CriPlayer)SceneManager.instance.DAT_27C[iVar2];

            if ((pbVar1.flags & 1) != 0)
                PTR_FUN_B58C0[pbVar1.tags](pbVar1);

            iVar3--;
            iVar2++;
        } while (iVar3 != -1);
    }

    public static void FUN_54EF8(CriPlayer param1)
    {
        param1.FUN_54EF8();
    }

    public static void FUN_4CFDC(CriPlayer param1)
    {
        param1.FUN_4CFDC();
    }

    public static void FUN_2FAB0(CriPlayer param1)
    {
        param1.FUN_2FAB0();
    }
}
