using UnityEngine;
using System.Collections;

public class VivalKillScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (GameObject.FindGameObjectWithTag ("Player").transform.position == this.transform.position) {
			//Debug.Log("Clear");
			//game over
			ReplayPanelScript.endsForMe = true;
			GameManager.gameEnd = true;
		} else if (GameObject.Find ("Vival").transform.position == this.transform.position) {
			Debug.Log("fall into trap");
			Destroy (this.gameObject);
		}
	}
}
