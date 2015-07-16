using UnityEngine;
using System.Collections;

public class Client : MonoBehaviour {

	string IP = "127.0.0.1";
	int port = 10100;
	string Message = "";
	Vector3 sc;

	Vector3 position;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {

		switch (Network.peerType) {
		case NetworkPeerType.Disconnected:
			StartConnect();
			break;
		case NetworkPeerType.Server:
			break;
		case NetworkPeerType.Client:
			OnClient();
			break;
		case NetworkPeerType.Connecting:
			break;
		}
	
	}

	void StartConnect()
	{
		if (GUILayout.Button ("Start Connect")) {
			NetworkConnectionError error= Network.Connect(IP,port);

			switch(error){
			case NetworkConnectionError.NoError:
				break;
			default:
				Debug.Log("Client Error: " + error);
				break;
			}
		}
	}

	void OnClient (){
		sc = GUILayout.BeginScrollView (sc, GUILayout.Width (280), GUILayout.Height (400));

		GUILayout.Box (Message);

		Message = GUILayout.TextArea (Message);

		position = new Vector3(GameObject.FindGameObjectWithTag ("Player").transform.position.x, 
		                       GameObject.FindGameObjectWithTag("Player").transform.position.y,0);

		if (GUILayout.Button ("Send")) {
			GetComponent<NetworkView>().RPC("RecieveMessage", RPCMode.All, Message);
			GetComponent<NetworkView> ().RPC ("RecievePosition", RPCMode.All, position);
		}






		Debug.Log (position.x + ", " + position.y);



		GUILayout.EndScrollView ();

	}

	[RPC]
	void RecieveMessage(string msg, NetworkMessageInfo info)
	{
		Message = "Sender: " + info.sender + " Messgage: " + msg + " Position: " + position.x;
	}

	[RPC]
	void RecievePosition(Vector3 pos, NetworkMessageInfo info)
	{
		position = pos;

		//"Sender: " + info.sender + " Position: " + pos;
	}
}
