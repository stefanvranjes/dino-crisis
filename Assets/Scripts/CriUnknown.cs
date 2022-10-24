using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriUnknown : MonoBehaviour
{
    public byte DAT_00;
    public byte DAT_01;
    public byte DAT_02;
    public sbyte DAT_03;
    public byte DAT_04;
    public short DAT_08;
    public byte DAT_0A;
    public ushort DAT_16;
    public CriBone PTR_18;
    public byte DAT_18;
    public byte DAT_19;
    public CriStatic DAT_1C;
    public CriSkinned DAT_20;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetValues()
    {
        DAT_00 = 0;
        DAT_01 = 0;
        DAT_02 = 0;
        DAT_03 = 0;
        DAT_04 = 0;
        DAT_08 = 0;
        DAT_0A = 0;
        DAT_16 = 0;
        PTR_18 = null;
        DAT_18 = 0;
        DAT_19 = 0;
        DAT_1C = null;
        DAT_20 = null;
    }
}
