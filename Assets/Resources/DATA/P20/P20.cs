using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P20 : SharedAssets
{
    public override void Start()
    {
        base.Start();
        assets.Add(317, this);
    }

    public override void Init()
    {
        base.Init();
        SHARED = new UIntUIntDictionary
        {
            { 0x8017b83c, 0x801679D4 },
            { 0x8017b840, 0x80160000 },
            { 0x8017b844, 0x80192664 },
            { 0x8017b848, 0x801936dc },
            { 0x8017b84c, 0x8019420c },
            { 0x8017b850, 0x80193044 },
            { 0x8017b854, 0x80163b74 },
            { 0x8017b858, 0x801646a4 },
            { 0x8017b85c, 0x80198838 },
            { 0x8017b860, 0x80199220 },
            { 0x8017b864, 0x8019b658 },
            { 0x8017b868, 0x8019420c },
            { 0x8017b86c, 0x8019a7d8 },
            { 0x8017b870, 0x80165324 },
            { 0x8017b874, 0x80165e54 },
            { 0x8017b878, 0x80198d2c },
            { 0x8017b87c, 0x80199ca8 },
            { 0x8017b880, 0x8019b658 },
            { 0x8017b884, 0x8019420c },
            { 0x8017b888, 0x8019af18 },
            { 0x8017b88c, 0x80165324 },
            { 0x8017b890, 0x80165e54 },
            { 0x8017b894, 0x8016147c },
            { 0x8017b898, 0x80160698 },
            { 0x8017b89c, 0x80162260 },
            { 0x8017b8a0, 0x80166ad4 },
            { 0x8017b8a4, 0x80166b34 },
            { 0x8017b8a8, 0x80166b94 },
            { 0x8017b8ac, 0x80161778 },
            { 0x8017b8b0, 0x80160994 },
            { 0x8017b8b4, 0x801627b0 },
            { 0x8017b8b8, 0x8016200c },
            { 0x8017b8bc, 0x80161228 },
            { 0x8017b8c0, 0x8016255c },
            { 0x8017b8c4, 0x80163b74 },
            { 0x8017b8c8, 0x80165324 },
            { 0x8017b8cc, 0x801646a4 },
            { 0x8017b8d0, 0x80165e54 },
            { 0x8017b8d4, 0x80167094 },
            { 0x8017b8d8, 0x80166bf4 },
            { 0x8017b8dc, 0x80167534 }
        };
    }
}