using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"Applies a rotation of eulerAngles.z degrees around the z axis, eulerAngles.x degrees around the x axis, and eulerAngles.y degrees around the y axis (in that order).")]
[UBCategory("Transform")]
public class RotateByEulerAngles : UBAction {

	[UBRequired] public UBTransform _Transform = new UBTransform();
	
	[UBRequired] public UBVector3 _EulerAngles = new UBVector3();
	protected override void PerformExecute(IUBContext context){
		_Transform.GetValue(context).Rotate(_EulerAngles.GetValue(context));
	}

    public override string ToString()
    {
        return string.Format("Rotate {0}", _Transform.ToString(RootContainer));
    }


	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("#_Transform#.Rotate(#_EulerAngles#)");
	}

}