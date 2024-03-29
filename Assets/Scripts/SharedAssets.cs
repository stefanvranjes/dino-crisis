using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class UIntUIntDictionary : SerializableDictionary<uint, uint> { }

public class SharedAssets : MonoBehaviour
{
    public static SharedAssets instance;
    public static Dictionary<uint, SharedAssets> assets;
    public RamScriptableObject ram;
    public GianScriptableObject[] gians;
    public IniScriptableObject[] inis;
    public UIntUIntDictionary SHARED;
    public delegate void FUN_9CE84(CriPlayer p);
    public static FUN_9CE84[][] PTR_FUN_9CE84;

    protected virtual void Awake()
    {
        if (instance == null)
        {
            instance = this;
            assets = new Dictionary<uint, SharedAssets>();
            DontDestroyOnLoad(gameObject);
        }

        PTR_FUN_9CE84 = new FUN_9CE84[4][]
        {
            new FUN_9CE84[1]
            {
                FUN_521BC
            },
            null, 
            null, 
            null
        };
    }

    // Start is called before the first frame update
    protected virtual void Start()
    {
        for (int i = 0; i < gians.Length; i++)
            GameManager.PTR_DAT_9E708[gians[i].INDEX] = gians[i];

        for (int i = 0; i < inis.Length; i++)
        {
            int j = (int)(inis[i].ADDR - 0x801fe900) / 4;

            for (int k = 0; k < inis[i].DATA.Length; k++)
                GameManager.DAT_1FE900[j + k] = inis[i].DATA[k];
        }

        foreach (KeyValuePair<uint, UnityEngine.Object> t in ram.objects)
        {
            if (!GameManager.globalRam.objects.ContainsKey(t.Key))
                GameManager.globalRam.objects.Add(t.Key, t.Value);
            else
                GameManager.globalRam.objects[t.Key] = t.Value;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Init()
    {
        return;
    }

    public static void FUN_521BC(CriPlayer param1)
    {
        param1.FUN_512BC();
    }
}
