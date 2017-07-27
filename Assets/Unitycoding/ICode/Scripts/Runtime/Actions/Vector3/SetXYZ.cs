﻿using UnityEngine;
using System.Collections;

namespace ICode.Actions.UnityVector3{
	[Category(Category.Vector3)] 
	[Tooltip("Set the x,y,z component of the Vector3.")]
	[System.Serializable]
	public class SetXYZ : StateAction {
		[Shared]
		[Tooltip("Vector3 to use")]
		public FsmVector3 vector;
		[NotRequired]
		[Tooltip("The x value to set.")]
		public FsmFloat x;
		[NotRequired]
		[Tooltip("The y value to set.")]
		public FsmFloat y;
		[NotRequired]
		[Tooltip("The z value to set.")]
		public FsmFloat z;
		[Tooltip("Execute the action every frame.")]
		public bool everyFrame;

		public override void OnEnter ()
		{
			vector.Value = new Vector3 (x.IsNone?vector.Value.x: x.Value,y.IsNone?vector.Value.y: y.Value,z.IsNone?vector.Value.z: z.Value);
			if (!everyFrame) {
				Finish ();
			}
		}
		
		public override void OnUpdate ()
		{
			vector.Value = new Vector3 (x.IsNone?vector.Value.x: x.Value,y.IsNone?vector.Value.y: y.Value,z.IsNone?vector.Value.z: z.Value);
		}
	}
}