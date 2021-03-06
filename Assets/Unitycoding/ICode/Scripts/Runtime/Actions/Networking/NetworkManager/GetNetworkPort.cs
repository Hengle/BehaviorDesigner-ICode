﻿#if !UNITY_4_6 && !UNITY_4_7 && !UNITY_5_0
using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

namespace ICode.Actions.UnityNetworking{
	[Category("UnityNetworking/NetworkManager")]
	[Tooltip("The network port currently in use.For clients, this is the port of the server connected to. For servers, this is the listen port.")]
	[HelpUrl("http://docs.unity3d.com/ScriptReference/Networking.NetworkManager-networkPort.html")]
	[System.Serializable]
	public class GetNetworkPort : NetworkManagerAction {
		[Shared]
		[Tooltip("Store the value.")]
		public FsmInt store;

		public override void OnEnter ()
		{
			base.OnEnter ();
			store.Value=manager.networkPort;
			Finish ();
		}
	}
}
#endif