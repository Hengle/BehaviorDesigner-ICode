﻿using UnityEngine;
using System.Collections;

namespace ICode.Actions.UnityRectTransform{
	[Category(Category.RectTransform)]    
	[Tooltip("The normalized position in this RectTransform that it rotates around.")]
	[HelpUrl("http://docs.unity3d.com/ScriptReference/RectTransform-pivot.html")]
	[System.Serializable]
	public class SetPivot : RectTransformAction {
		[Tooltip("Value to set.")]
		public FsmVector2 value;
		[Tooltip("Execute the action every frame.")]
		public bool everyFrame;
		
		public override void OnEnter ()
		{
			base.OnEnter ();
			transform.pivot=value.Value;
			if (!everyFrame) {
				Finish ();
			}
		}
		
		public override void OnUpdate ()
		{
			transform.pivot=value.Value;
		}
	}
}