using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Matrix3x3
{
    public short V00, V01, V02;
    public short V10, V11, V12;
    public short V20, V21, V22;
    public bool skewed;
    public short _V00, _V01, _V02;
    public short _V10, _V11, _V12;
    public short _V20, _V21, _V22;

    public Vector3 Scale
    {
        get
        {
            float fV00, fV01, fV02;

            const int SHRT_MAX = 4096;
            fV00 = (float)V00 / SHRT_MAX;
            fV01 = (float)V01 / SHRT_MAX;
            fV02 = (float)V02 / SHRT_MAX;

            //float sx = new Vector3(fV00, fV01, fV02).magnitude;

            float fV10, fV11, fV12;

            fV10 = (float)V10 / SHRT_MAX;
            fV11 = (float)V11 / SHRT_MAX;
            fV12 = (float)V12 / SHRT_MAX;

            //float sy = new Vector3(fV10, fV11, fV12).magnitude;

            float fV20, fV21, fV22;

            fV20 = (float)V20 / SHRT_MAX;
            fV21 = (float)V21 / SHRT_MAX;
            fV22 = (float)V22 / SHRT_MAX;

            float sx = new Vector3(fV00, fV10, fV20).magnitude;
            float sy = new Vector3(fV01, fV11, fV21).magnitude;
            float sz = new Vector3(fV02, fV12, fV22).magnitude;

            return new Vector3(sx, sy, sz);
        }
    }

    public Quaternion Matrix2Quaternion
    {
        get
        {
            const int SHRT_MAX = 4096;
            double fV00, fV01, fV02;
            double fV10, fV11, fV12;
            double fV20, fV21, fV22;

            if (skewed)
            {
                /*Matrix3x3 m33 = Utilities.MatrixNormal(this);
                fV00 = (double)m33.V00 / SHRT_MAX;
                fV01 = (double)m33.V01 / SHRT_MAX;
                fV02 = (double)m33.V02 / SHRT_MAX;
                fV10 = (double)m33.V10 / SHRT_MAX;
                fV11 = (double)m33.V11 / SHRT_MAX;
                fV12 = (double)m33.V12 / SHRT_MAX;
                fV20 = (double)m33.V20 / SHRT_MAX;
                fV21 = (double)m33.V21 / SHRT_MAX;
                fV22 = (double)m33.V22 / SHRT_MAX;*/
                fV00 = (double)_V00 / SHRT_MAX;
                fV01 = (double)_V01 / SHRT_MAX;
                fV02 = (double)_V02 / SHRT_MAX;
                fV10 = (double)_V10 / SHRT_MAX;
                fV11 = (double)_V11 / SHRT_MAX;
                fV12 = (double)_V12 / SHRT_MAX;
                fV20 = (double)_V20 / SHRT_MAX;
                fV21 = (double)_V21 / SHRT_MAX;
                fV22 = (double)_V22 / SHRT_MAX;
            }
            else
            {
                fV00 = (double)V00 / SHRT_MAX;
                fV01 = (double)V01 / SHRT_MAX;
                fV02 = (double)V02 / SHRT_MAX;
                fV10 = (double)V10 / SHRT_MAX;
                fV11 = (double)V11 / SHRT_MAX;
                fV12 = (double)V12 / SHRT_MAX;
                fV20 = (double)V20 / SHRT_MAX;
                fV21 = (double)V21 / SHRT_MAX;
                fV22 = (double)V22 / SHRT_MAX;
            }

            float tr = (float)(fV00 + fV11 + fV22);
            double qw, qx, qy, qz;

            if (tr > 0)
            {
                float S = (float)Math.Sqrt(tr + 1f) * 2;
                qw = 0.25 * S;
                qx = (fV21 - fV12) / S;
                qy = (fV02 - fV20) / S;
                qz = (fV10 - fV01) / S;
            }
            else if ((fV00 > fV11) & (fV00 > fV22))
            {
                float S = (float)Math.Sqrt(1.0 + fV00 - fV11 - fV22) * 2; // S=4*qx 
                qw = (fV21 - fV12) / S;
                qx = 0.25 * S;
                qy = (fV01 + fV10) / S;
                qz = (fV02 + fV20) / S;
            }
            else if (fV11 > fV22)
            {
                float S = (float)Math.Sqrt(1.0 + fV11 - fV00 - fV22) * 2; // S=4*qy
                qw = (fV02 - fV20) / S;
                qx = (fV01 + fV10) / S;
                qy = 0.25 * S;
                qz = (fV12 + fV21) / S;
            }
            else
            {
                float S = (float)Math.Sqrt(1.0 + fV22 - fV00 - fV11) * 2; // S=4*qz
                qw = (fV10 - fV01) / S;
                qx = (fV02 + fV20) / S;
                qy = (fV12 + fV21) / S;
                qz = 0.25 * S;
            }

            return new Quaternion((float)qx, (float)qy, (float)qz, (float)qw);
        }
    }

    public int GetValue32(int index)
    {
        int value = 0;

        if (index >= 5)
            index = 4;
        else if (index < 0)
            index = 0;

        switch (index)
        {
            case 0:
                value = V01 << 16 | (ushort)V00;
                break;
            case 1:
                value = V10 << 16 | (ushort)V02;
                break;
            case 2:
                value = V12 << 16 | (ushort)V11;
                break;
            case 3:
                value = V21 << 16 | (ushort)V20;
                break;
            default:
                value = V22;
                break;
        }

        return value;
    }

    public void SetValue32(int index, int value)
    {
        switch (index)
        {
            case 0:
                V00 = (short)value;
                V01 = (short)(value >> 16);
                break;
            case 1:
                V02 = (short)value;
                V10 = (short)(value >> 16);
                break;
            case 2:
                V11 = (short)value;
                V12 = (short)(value >> 16);
                break;
            case 3:
                V20 = (short)value;
                V21 = (short)(value >> 16);
                break;
            default:
                V22 = (short)value;
                break;
        }
    }

    public void SetValue16(int index, int value)
    {
        switch (index)
        {
            case 0:
                V00 = (short)value;
                break;
            case 1:
                V01 = (short)value;
                break;
            case 2:
                V02 = (short)value;
                break;
            case 3:
                V10 = (short)value;
                break;
            case 4:
                V11 = (short)value;
                break;
            case 5:
                V12 = (short)value;
                break;
            case 6:
                V20 = (short)value;
                break;
            case 7:
                V21 = (short)value;
                break;
            default:
                V22 = (short)value;
                break;
        }
    }
}

[Serializable]
public struct CriTransform
{
    public Matrix3x3 rotation;
    public short padding;
    public Vector3Int position;
}

public class CriObject : MonoBehaviour
{
    public CriTransform cTransform; //0x00
    public Vector3Int screen; //0x20
    public sbyte tags; //0x27
    public Vector3Int vr; //0x28
    public byte DAT_2E; //0x2E
    public uint flags; //0x30
    public CriObject DAT_34; //0x34
    public CriObject DAT_38; //0x38
    public TmdScriptableObject cMesh; //0x3C

    // Start is called before the first frame update
    protected virtual void Start()
    {
        
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        transform.position = (Vector3)screen / 16f;
        transform.position = new Vector3(transform.position.x, -transform.position.y, transform.position.z);
        transform.rotation = Quaternion.Euler((Vector3)vr / 4096f * 360f);
    }

    //FUN_601A4
    public virtual void ResetValues()
    {
        cTransform.position = Vector3Int.zero;
        cTransform.rotation = new Matrix3x3();
        cTransform.padding = 0;
        screen = Vector3Int.zero;
        tags = 0;
        vr = Vector3Int.zero;
        DAT_2E = 0;
        flags = 0;
        DAT_34 = null;
        DAT_38 = null;
        cMesh = null;
    }

    public void FUN_60068()
    {
        flags = 0;
    }

    public void FUN_62F3C(ref Vector3Int param1)
    {
        Vector3Int local_10;

        local_10 = Utilities.ApplyMatrixSV(ref cTransform.rotation, ref param1);
        screen.x += local_10.x;
        screen.y += local_10.y;
        screen.z += local_10.z;
    }
}
