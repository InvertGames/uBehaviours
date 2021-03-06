using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBCategory("Network")]
public class ConnectByGUIDAndPassword : UBAction {

	[UBRequired] public UBString _GUID = new UBString();
	[UBRequired] public UBString _Password = new UBString();
	[UBRequireVariable] [UBRequired] public UBEnum _Result = new UBEnum(typeof(NetworkConnectionError));
	protected override void PerformExecute(IUBContext context){
		if (_Result != null){
			_Result.SetValue( context, Network.Connect(_GUID.GetValue(context),_Password.GetValue(context)));
		}

	}

	public override string ToString(){
	return string.Format("Connect to {0}", _GUID.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("Network.Connect(#_GUID#, #_Password#)");
	}

}