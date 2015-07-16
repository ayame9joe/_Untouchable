using UnityEngine;
using System.Collections;

public class KillScript : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (GameObject.FindGameObjectWithTag ("Player").transform.position == this.transform.position) {
			//Debug.Log("Clear");
			Destroy (this.gameObject);
		} else if (GameObject.Find ("Vival").transform.position == this.transform.position) {
			ReplayPanelScript.endsForMe = false;
			GameManager.gameEnd = true;

		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") {

		}
	}
}
