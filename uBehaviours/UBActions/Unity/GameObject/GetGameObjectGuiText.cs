using System;
using System.Collections.Generic;
using UnityEngine;
using UBehaviours.Actions;

[UBHelp(@"The  attached to this GameObject (Read Only). (null if there is none attached)")]
[UBCategory("GameObject")]
public class GetGameObjectGuiText : UBAction {

	[UBRequired] public UBGameObject _GameObject = new UBGameObject();
	[UBRequireVariable] [UBRequired] public UBObject _Result = new UBObject(typeof(GUIText));
	protected override void PerformExecute(IUBContext context){
		if (_Result != null){
			_Result.SetValue( context, _GameObject.GetValue(context).guiText);
		}

	}

	public override string ToString(){
	return string.Format("Get guiText from {0}", _GameObject.ToString(RootContainer));
	}

	public override void WriteCode(IUBCSharpGenerator sb){
		sb.AppendExpression("#_Result# = #_GameObject#.guiText");
	}

}