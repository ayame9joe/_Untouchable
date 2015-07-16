using UnityEngine;
using System.Collections;

public class Server : MonoBehaviour {


	int port = 10100;
	string Message = "";
	Vector2 sc;


	Vector3 position;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {

		switch (Network.peerType) {
		
		case NetworkPeerType.Disconnected:
			StartServer();
			break;
		case NetworkPeerType.Server:
			OnServer();
			break;
		case NetworkPeerType.Client:
			break;
		case NetworkPeerType.Connecting:
			break;
		}
	
	}

	void StartServer(){
		if (GUILayout.Button ("Start Server")) {
			NetworkConnectionError error = Network.InitializeServer (12, port, false);

			switch (error) {
			case NetworkConnectionError.NoError:
				break;
			default:
				Debug.Log ("Server Error: " + error);
				break;
			}
		}
	}

	void OnServer()
	{
		GUILayout.Label ("Server has begun to waiting for connection");
		int length = Network.connections.Length;

		for (int i = 0; i < length; i++) {
			GUILayout.Label("Client " + i);
		}

		if (GUILayout.Button ("Disconnect Server")) {
			Network.Disconnect();
		}

		sc = GUILayout.BeginScrollView (sc, GUILayout.Width (280), GUILayout.Height (400));
		
		GUILayout.Box (Message);

		GUILayout.EndScrollView ();
	}

	[RPC]
	void RecieveMessage(string msg, NetworkMessageInfo info)
	{
		Message = "Sender: " + info.sender + "Messgage: " + msg;
	}

	[RPC]
	void RecievePosition(Vector3 pos)
	{
		pos = new Vector3(GameObject.FindGameObjectWithTag ("Player").transform.position.x, 
		                  GameObject.FindGameObjectWithTag("Player").transform.position.y,0);
		position = new Vector3(GameObject.FindGameObjectWithTag ("Player").transform.position.x, 
		                       GameObject.FindGameObjectWithTag("Player").transform.position.y,0);
		position = pos;
	}
}
