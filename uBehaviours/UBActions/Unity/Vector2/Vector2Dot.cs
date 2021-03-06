using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"Dot Product of two vectors.")]
[UBCategory("Vector2")]
public class Vector2Dot : UBAction
{

	
	[UBRequired] public UBVector2 _Lhs = new UBVector2();
	
	[UBRequired] public UBVector2 _Rhs = new UBVector2();
	[UBRequireVariable] [UBRequired] public UBFloat _Result = new UBFloat();
	protected override void PerformExecute(IUBContext context){
		if (_Result != null){
			_Result.SetValue( context, Vector2.Dot(_Lhs.GetValue(context),_Rhs.GetValue(context)));
		}

	}

	public override string ToString(){
	return string.Format(" Dot product of {0} and {1}",  _Lhs.ToString(RootContainer), _Rhs.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("Vector2.Dot(#_Lhs#, #_Rhs#)");
	}

}