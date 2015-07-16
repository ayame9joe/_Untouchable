using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	GameObject[] steps;

	int turns;

	public static bool gameEnd;

	public GameObject startPanel;
	public GameObject gamePanel;
	public GameObject replayPanel;

	// Use this for initialization
	void Start () {

		StartCoroutine("WaitForAnimation");
	
	}
	
	// Update is called once per frame
	void Update () {

		if (gameEnd) {
			gamePanel.SetActive(false);
			replayPanel.SetActive(true);
			gameEnd = false;
		}

	
	}

	public void GameStart()
	{


		startPanel.SetActive (false);
		gamePanel.SetActive (true);
		replayPanel.SetActive (false);
	}

	IEnumerator WaitForAnimation()
	{
		turns++;
		yield return new WaitForSeconds (0.6f);
		//Debug.Log (hasNotBeenInit);
		steps = GameObject.FindGameObjectsWithTag ("touchable");



		//int vivalStep = Random.Range (0, steps.Length - 1);
		for (int i = 0; i < steps.Length; i++) {

			if (turns%2 == 0)
			{
				steps[i].transform.localScale = new Vector3(1.2f, 1.2f);
			}
			else {
				steps[i].transform.localScale = new Vector3(1.0f, 1.0f);
			}
		}

		StartCoroutine("WaitForAnimation");

	}
}
