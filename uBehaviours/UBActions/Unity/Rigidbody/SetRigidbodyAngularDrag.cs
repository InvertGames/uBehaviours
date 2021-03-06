using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"The angular drag of the object.")]
[UBCategory("Rigidbody")]
public class SetRigidbodyAngularDrag : UBAction {

	[UBRequired] public UBObject _Rigidbody = new UBObject(typeof(Rigidbody));
	[UBRequired] public UBFloat _Value = new UBFloat();
	protected override void PerformExecute(IUBContext context){
		if (_Value != null){
			_Rigidbody.GetValueAs<Rigidbody>(context).angularDrag = _Value.GetValue(context);
		}

	}

	public override string ToString(){
	return string.Format("Set {0}'s angularDrag to {1}", _Rigidbody.ToString(RootContainer), _Value.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("#_Rigidbody#.angularDrag = #_Value# ");
	}

}