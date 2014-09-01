using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBCategory("UBMath")]
public class SubtractFloat : UBAction {

	[UBRequired] public UBFloat _A = new UBFloat();
	[UBRequired] public UBFloat _B = new UBFloat();
	[UBRequireVariable] [UBRequired] public UBFloat _Result = new UBFloat();
	protected override void PerformExecute(IUBContext context){
		if (_Result != null){
			_Result.SetValue( context, UBMath.SubtractFloat(_A.GetValue(context),_B.GetValue(context)));
		}

	}

	public override string ToString(){
	return string.Format("Call {0}'s SubtractFloat w/ {1} and {2}", "UBMath", _A.ToString(RootContainer), _B.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("UBMath.SubtractFloat(#_A#, #_B#)");
	}

}