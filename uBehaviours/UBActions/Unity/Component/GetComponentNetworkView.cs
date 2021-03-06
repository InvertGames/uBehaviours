using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"The  attached to this  (Read Only). (null if there is none attached)")]
[UBCategory("Component")]
public class GetComponentNetworkView : UBAction {

	[UBRequired] public UBObject _Component = new UBObject(typeof(Component));
	[UBRequireVariable] [UBRequired] public UBObject _Result = new UBObject(typeof(NetworkView));
	protected override void PerformExecute(IUBContext context){
		if (_Result != null){
			_Result.SetValue( context, _Component.GetValueAs<Component>(context).networkView);
		}

	}

	public override string ToString(){
	return string.Format("Get networkView from {0}", _Component.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("#_Result# = #_Component#.networkView");
	}

}