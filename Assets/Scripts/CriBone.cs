using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriBone : CriObject
{
    public byte DAT_42; //0x42
    public byte DAT_43; //0x43
    public Vector3Int DAT_44; //0x44
    public Vector3Int DAT_4C; //0x4C

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    public override void ResetValues()
    {
        base.ResetValues();
        DAT_42 = 0;
        DAT_43 = 0;
        DAT_44 = Vector3Int.zero;
        DAT_4C = Vector3Int.zero;
    }
}
