using UnityEngine;
using System.Collections;

public class StepScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (GameObject.FindGameObjectWithTag ("Player").transform.position == this.transform.position) {
			//Debug.Log("Clear");
			//game over
			this.transform.localScale = new Vector3(1.0f, 1.0f);
		} 

		GameObject[] go = GameObject.FindGameObjectsWithTag ("Kill");

		for (int i = 0; i < go.Length; i++) {
			if (go[i].transform.position == this.transform.position)
			{
				this.transform.localScale = new Vector3(1.0f, 1.0f);
			}
		}

	
	}
}
