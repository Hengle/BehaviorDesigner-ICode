﻿using UnityEngine;
using System.Collections;

namespace ICode.Actions.UnityTransform{
	[Category(Category.Transform)]  
	[Tooltip("Move the transform to the end of the local transform list.")]
	[HelpUrl("http://docs.unity3d.com/ScriptReference/Transform.SetAsLastSibling.html")]
	[System.Serializable]
	public class SetAsLastSibling : TransformAction {
		public override void OnEnter ()
		{
			base.OnEnter ();
			 transform.SetAsLastSibling ();
		}
	}
}