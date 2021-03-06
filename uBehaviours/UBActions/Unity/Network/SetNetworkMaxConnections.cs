using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"Set the maximum amount of connections/players allowed.")]
[UBCategory("Network")]
public class SetNetworkMaxConnections : UBAction {

	[UBRequired] public UBInt _Value = new UBInt();
	protected override void PerformExecute(IUBContext context){
		if (_Value != null){
			Network.maxConnections = _Value.GetValue(context);
		}

	}

	public override string ToString(){
	return string.Format("Set {0}'s maxConnections to {1}", "Network", _Value.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("Network.maxConnections = #_Value# ");
	}

}