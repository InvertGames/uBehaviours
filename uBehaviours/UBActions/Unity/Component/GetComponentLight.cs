using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"The  attached to this  (null if there is none attached).")]
[UBCategory("Component")]
public class GetComponentLight : UBAction {

	[UBRequired] public UBObject _Component = new UBObject(typeof(Component));
	[UBRequireVariable] [UBRequired] public UBObject _Result = new UBObject(typeof(Light));
	protected override void PerformExecute(IUBContext context){
		if (_Result != null){
			_Result.SetValue( context, _Component.GetValueAs<Component>(context).light);
		}

	}

	public override string ToString(){
	return string.Format("Get light from {0}", _Component.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("#_Result# = #_Component#.light");
	}

}