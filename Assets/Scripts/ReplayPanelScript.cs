using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ReplayPanelScript : MonoBehaviour {


	public GameObject gamePanel;
	public GameObject startPanel;
	public GameObject replayPanel;

	public Text txtEnd;

	public static bool endsForMe;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (endsForMe) {
			txtEnd.text = "You fell into trap with " + PlayerScript.score.ToString ();
		} else {
			txtEnd.text = "Your Partner fell into trap with " + PlayerScript.score.ToString ();
		}
	
	}

	public void Replay (){
		//Debug.Log("Replay");
		Application.LoadLevel (Application.loadedLevel);

	}

	public void End (){
		Application.LoadLevel (Application.loadedLevel);
		PlayerScript.score = 0;
	}
}
