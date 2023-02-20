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


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            assets = new Dictionary<uint, SharedAssets>();
        }
    }

    // Start is called before the first frame update
    public virtual void Start()
    {
        //Here SHARED should be initialized
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void Init()
    {
        return;
    }
}
