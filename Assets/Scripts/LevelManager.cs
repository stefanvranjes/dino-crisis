using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public RamScriptableObject ram;
    public GianScriptableObject[] gians;
    public IniScriptableObject[] inis;
    public delegate void FUN_B58C0(CriPlayer p);
    public delegate void FUN_C1CF8(CriInteract i);
    public delegate void FUN_C2570(CriStatic s);
    public FUN_B58C0[] PTR_FUN_B58C0;
    public FUN_C1CF8[] PTR_FUN_C1CF8;
    public FUN_C2570[] PTR_FUN_C2570;
    public CriObject DAT_C2590;
    public int DAT_C2594;
    public Vector3Int DAT_C2598;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
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

    public void FUN_4A274()
    {
        CriStatic pcVar1;
        int iVar2;

        iVar2 = 0;

        do
        {
            pcVar1 = SceneManager.instance.DAT_7CDC[iVar2];

            if ((pcVar1.flags & 1) != 0)
                PTR_FUN_C2570[pcVar1.DAT_2E](pcVar1);

            iVar2++;
        } while (iVar2 < 36);
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

    public static void FUN_20A98(CriInteract param1)
    {
        param1.FUN_20A98();
    }

    public static void FUN_20AA0(CriInteract param1)
    {
        param1.FUN_20AA0();
    }

    public static void FUN_20AA8(CriInteract param1)
    {
        param1.FUN_20AA8();
    }

    public static void FUN_20B0C(CriInteract param1)
    {
        param1.FUN_20B0C();
    }

    public static void FUN_21758(CriInteract param1)
    {
        param1.FUN_21758();
    }

    public static void FUN_21ECC(CriInteract param1)
    {
        param1.FUN_21ECC();
    }

    public static void FUN_22178(CriInteract param1)
    {
        param1.FUN_22178();
    }

    public static void FUN_222AC(CriInteract param1)
    {
        param1.FUN_222AC();
    }

    public static void FUN_22464(CriInteract param1)
    {
        param1.FUN_22464();
    }

    public static void FUN_2268C(CriInteract param1)
    {
        param1.FUN_2268C();
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

    public static void FUN_4A26C(CriStatic param1)
    {
        param1.FUN_4A26C();
    }

    public static void FUN_7F6F8(CriStatic param1)
    {
        param1.FUN_7F6F8();
    }

    public static void FUN_7F750(CriStatic param1)
    {
        param1.FUN_7F750();
    }

    public static void FUN_7F7E4(CriStatic param1)
    {
        param1.FUN_7F7E4();
    }
}
