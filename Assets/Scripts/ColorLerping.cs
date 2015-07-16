using UnityEngine;
using System.Collections;

public class ColorLerping : MonoBehaviour {

	Color startColor = Color.white;
	Color endColor = Color.cyan;

	float duration = 1.0f;

	float minimum = 0.0f;
	float maximum = 200.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		float lerp = Mathf.PingPong (Time.time, duration) / duration;


	
	}
}
