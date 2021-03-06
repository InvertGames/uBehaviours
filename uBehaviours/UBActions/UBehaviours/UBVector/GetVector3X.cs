using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBCategory("UBVector")]
public class GetVector3X : UBAction {

	[UBRequired] public UBVector2 _Vector = new UBVector2();
	[UBRequireVariable] [UBRequired] public UBFloat _Result = new UBFloat();
	protected override void PerformExecute(IUBContext context){
		if (_Result != null){
			_Result.SetValue( context, UBVector.GetVector3X(_Vector.GetValue(context)));
		}

	}

	public override string ToString(){
	return string.Format("Call {0}'s GetVector3X w/ {1}", "UBVector", _Vector.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("UBVector.GetVector3X(#_Vector#)");
	}

}