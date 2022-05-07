using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public ushort DAT_1f800028;
    public ushort DAT_1f80002a;
    public Vector3Int DAT_1f80002c;
    public Matrix3x3 DAT_1f800034;
    public byte DAT_38; //gp+38h
    public CriObject DAT_B4; //gp+b4h
    public List<CriObject> DAT_27C; //gp+27ch...gp+1c9ch
    public List<CriObject> DAT_5FCC; //gp+5fcch...gp+7cdch
    public List<CriObject> DAT_7CDC; //gp+7cdch...gp+8ffch
    public byte DAT_1AA0; //gp+9AA0h
    public Material[] materials;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void FUN_7302C()
    {
        //FUN_72F78
        FUN_72C2C();

        if ((DAT_38 & 1) == 0)
            FUN_731E8();
    }

    private void FUN_731E8()
    {
        byte bVar1;
        TmdScriptableObject puVar4;
        CriObject puVar10;

        for (int i = 0; i < DAT_7CDC.Count; i++)
        {
            puVar10 = DAT_7CDC[i];

            if ((puVar10.flags & 3) == 3)
            {
                //if...
                Coprocessor.rotationMatrix.rt11 = puVar10.cTransform.rotation.V00;
                Coprocessor.rotationMatrix.rt12 = puVar10.cTransform.rotation.V01;
                Coprocessor.rotationMatrix.rt13 = puVar10.cTransform.rotation.V02;
                Coprocessor.rotationMatrix.rt21 = puVar10.cTransform.rotation.V10;
                Coprocessor.rotationMatrix.rt22 = puVar10.cTransform.rotation.V11;
                Coprocessor.rotationMatrix.rt23 = puVar10.cTransform.rotation.V12;
                Coprocessor.rotationMatrix.rt31 = puVar10.cTransform.rotation.V20;
                Coprocessor.rotationMatrix.rt32 = puVar10.cTransform.rotation.V21;
                Coprocessor.rotationMatrix.rt33 = puVar10.cTransform.rotation.V22;
                bVar1 = puVar10.DAT_48;
                puVar4 = puVar10.cMesh;

                if (bVar1 == 1)
                {
                    puVar10.FUN_75F10(puVar4, puVar4.QUAD_COUNT_2);
                }
                else
                {
                    //...
                }

                //FUN_75BEC
            }
        }
    }

    private void FUN_72C2C()
    {
        CriObject puVar8;

        Coprocessor.rotationMatrix.rt11 = DAT_B4.cTransform.rotation.V00;
        Coprocessor.rotationMatrix.rt12 = DAT_B4.cTransform.rotation.V01;
        Coprocessor.rotationMatrix.rt13 = DAT_B4.cTransform.rotation.V02;
        Coprocessor.rotationMatrix.rt21 = DAT_B4.cTransform.rotation.V10;
        Coprocessor.rotationMatrix.rt22 = DAT_B4.cTransform.rotation.V11;
        Coprocessor.rotationMatrix.rt23 = DAT_B4.cTransform.rotation.V12;
        Coprocessor.rotationMatrix.rt31 = DAT_B4.cTransform.rotation.V20;
        Coprocessor.rotationMatrix.rt32 = DAT_B4.cTransform.rotation.V21;
        Coprocessor.rotationMatrix.rt33 = DAT_B4.cTransform.rotation.V22;
        DAT_B4.cTransform.position.x = DAT_B4.screen.x;
        DAT_B4.cTransform.position.y = DAT_B4.screen.y;
        DAT_B4.cTransform.position.z = DAT_B4.screen.z;
        Coprocessor.translationVector._trx = DAT_B4.cTransform.position.x;
        Coprocessor.translationVector._try = DAT_B4.cTransform.position.y;
        Coprocessor.translationVector._trz = DAT_B4.cTransform.position.z;
        DAT_1f80002c = DAT_B4.vr;

        for (int i = 0; i < DAT_27C.Count; i++)
        {

        }

        for (int i = 0; i < DAT_7CDC.Count; i++)
        {
            puVar8 = DAT_7CDC[i];

            if ((puVar8.flags & 2) != 0)
            {
                Utilities.RotMatrix(ref puVar8.vr, ref DAT_1f800034);

                //if ()
                FUN_72ADC(ref puVar8.cTransform);
            }
        }

        for (int i = 0; i < DAT_5FCC.Count; i++)
        {

        }
    }

    private void FUN_72ADC(ref CriTransform param1)
    {
        int iVar1;
        int iVar2;
        int iVar3;

        Coprocessor.accumulator.ir1 = DAT_1f800034.V00;
        Coprocessor.accumulator.ir2 = DAT_1f800034.V10;
        Coprocessor.accumulator.ir3 = DAT_1f800034.V20;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
        DAT_1f800034.V20 = (short)(param1.position.x - DAT_1f80002c.x);
        iVar1 = Coprocessor.accumulator.ir1;
        iVar2 = Coprocessor.accumulator.ir2;
        iVar3 = Coprocessor.accumulator.ir3;
        param1.rotation.V00 = (short)iVar1;
        param1.rotation.V10 = (short)iVar2;
        param1.rotation.V20 = (short)iVar3;
        Coprocessor.accumulator.ir1 = DAT_1f800034.V01;
        Coprocessor.accumulator.ir2 = DAT_1f800034.V11;
        Coprocessor.accumulator.ir3 = DAT_1f800034.V21;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
        DAT_1f800034.V21 = (short)(param1.position.y - DAT_1f80002c.y);
        iVar1 = Coprocessor.accumulator.ir1;
        iVar2 = Coprocessor.accumulator.ir2;
        iVar3 = Coprocessor.accumulator.ir3;
        param1.rotation.V01 = (short)iVar1;
        param1.rotation.V11 = (short)iVar2;
        param1.rotation.V21 = (short)iVar3;
        Coprocessor.accumulator.ir1 = DAT_1f800034.V02;
        Coprocessor.accumulator.ir2 = DAT_1f800034.V12;
        Coprocessor.accumulator.ir3 = DAT_1f800034.V22;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.IR, _MVMVA_TRANSLATION_VECTOR.None, 12, false);
        DAT_1f800034.V22 = (short)(param1.position.z - DAT_1f80002c.z);
        iVar1 = Coprocessor.accumulator.ir1;
        iVar2 = Coprocessor.accumulator.ir2;
        iVar3 = Coprocessor.accumulator.ir3;
        param1.rotation.V02 = (short)iVar1;
        param1.rotation.V12 = (short)iVar2;
        param1.rotation.V22 = (short)iVar3;
        Coprocessor.vector0.vx0 = DAT_1f800034.V20;
        Coprocessor.vector0.vy0 = DAT_1f800034.V21;
        Coprocessor.vector0.vz0 = DAT_1f800034.V22;
        Coprocessor.ExecuteMVMVA(_MVMVA_MULTIPLY_MATRIX.Rotation, _MVMVA_MULTIPLY_VECTOR.V0, _MVMVA_TRANSLATION_VECTOR.TR, 12, false);
        iVar1 = Coprocessor.mathsAccumulator.mac1;
        param1.position.x = iVar1;
        iVar1 = Coprocessor.mathsAccumulator.mac2;
        param1.position.y = iVar1;
        iVar1 = Coprocessor.mathsAccumulator.mac3;
        param1.position.z = iVar1;
    }
}
