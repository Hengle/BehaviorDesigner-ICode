﻿#if !UNITY_4_6 && !UNITY_4_7 && !UNITY_5_0
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace ICode.Actions.UnityNetworking{
	[Category("UnityNetworking/NetworkManager")]
	[Tooltip("This stops both the client and the server that the manager is using.")]
	[HelpUrl("http://docs.unity3d.com/ScriptReference/Networking.NetworkManager.StopHost.html")]
	[System.Serializable]
	public class StopHost : NetworkManagerAction {

		public override void OnEnter ()
		{
			base.OnEnter ();
			manager.StopHost ();
			Finish ();
		}
	}
}
#endif