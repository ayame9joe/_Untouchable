using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	
	bool hasNotBeenInit;
	GameObject[] steps;
	
	public static bool isMyTurn;
	int turns;
	int vivalTurns;

	Vector2 tempPos;
	
	bool gotoNextSession;

	int vivalStepSeq;
	int killStepSeq;
	int vivalKillStepSeq;



	public static int score;
	public GameObject vival;
	public GameObject kill;
	public GameObject vivalKill;

	bool hasChecknScore;

	public Text txtScore;

	Color startColor = Color.white;
	Color endColor = Color.cyan;
	
	float duration = 100.0f;
	
	float minimum = 0.0f;
	float maximum = 100.0f;

	float lerp;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		txtScore.text = score.ToString ();

		if (Input.GetMouseButtonUp (0)) {
			this.transform.position = Input.mousePosition;

			vivalStepSeq = Random.Range(0, 7);
			killStepSeq = Random.Range(0, 7);
			vivalKillStepSeq = Random.Range(0,7);

			Debug.Log(vivalKillStepSeq);

			hasChecknScore = false;

			vival.transform.position = steps [vivalStepSeq].transform.position;

			if (turns > 5)
			{

				GameObject go = GameObject.Instantiate(kill, steps[killStepSeq].transform.position, this.transform.rotation) as GameObject;
				go.transform.parent = GameObject.Find("kills").transform;

				
				turns = 0;
			}
			if (vivalTurns > 5)
			{
				GameObject go1 = GameObject.Instantiate(vivalKill, steps[vivalKillStepSeq].transform.position, this.transform.rotation) as GameObject;
				go1.transform.parent = GameObject.Find("vivalKills").transform;

				
				vivalTurns = 0;
			}
			//this.GetComponent<Image>().material.color = Color.Lerp(Color.white, Color.cyan, lerp);
			//this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
			//Debug.Log(vivalStepSeq + "," + vival.transform.position);
		}



		//Debug.Log (hasNotBeenInit);
		steps = GameObject.FindGameObjectsWithTag ("touchable");

		//int vivalStep = Random.Range (0, steps.Length - 1);
		for (int i = 0; i < steps.Length - 1; i++) {

			if (this.transform.position == steps [i].transform.position) {
				hasNotBeenInit = true;
			}


			
		}


		lerp = Mathf.PingPong (Time.time, duration) / duration;

		if (vival.transform.position == this.transform.position && !hasChecknScore) {

			hasChecknScore = true;
			score += 10;
			this.transform.localScale = new Vector3(2.0f, 2.0f, 2.0f);
			StartCoroutine("BackToNormal");


			//this.transform.position.x = Mathf.Lerp(minimum, maximum, lerp);
		}

		if (vival.transform.position == this.transform.position) {
			//this.GetComponent<Image>().material.color = Color.Lerp(Color.white, Color.cyan, lerp);


		}


		//if (isMyTurn) {
		if (!hasNotBeenInit) {
			//this.transform.position = Input.mousePosition;
			GameObject.Find ("step0").tag = "touchable";
			GameObject.Find ("step1").tag = "touchable";
			GameObject.Find ("step2").tag = "touchable";
			GameObject.Find ("step3").tag = "touchable";
			GameObject.Find ("step4").tag = "touchable";
			GameObject.Find ("step5").tag = "touchable";
			GameObject.Find ("step6").tag = "touchable";
			GameObject.Find ("step7").tag = "touchable";
			GameObject.Find ("step8").tag = "touchable";
		} else if (this.transform.position == GameObject.Find ("step0").transform.position) {

			//Debug.Log("step0");
			tempPos = GameObject.Find ("step0").transform.position;
			GameObject.Find ("step0").tag = "untouchable";
			GameObject.Find ("step1").tag = "touchable";
			GameObject.Find ("step2").tag = "untouchable";
			GameObject.Find ("step3").tag = "touchable";
			GameObject.Find ("step4").tag = "untouchable";
			GameObject.Find ("step5").tag = "untouchable";
			GameObject.Find ("step6").tag = "untouchable";
			GameObject.Find ("step7").tag = "untouchable";
			GameObject.Find ("step8").tag = "untouchable";
		} else if (this.transform.position == GameObject.Find ("step1").transform.position) {
			tempPos = GameObject.Find ("step1").transform.position;
			GameObject.Find ("step0").tag = "touchable";
			GameObject.Find ("step1").tag = "touchable";
			GameObject.Find ("step2").tag = "touchable";
			GameObject.Find ("step3").tag = "untouchable";
			GameObject.Find ("step4").tag = "touchable";
			GameObject.Find ("step5").tag = "untouchable";
			GameObject.Find ("step6").tag = "untouchable";
			GameObject.Find ("step7").tag = "untouchable";
			GameObject.Find ("step8").tag = "untouchable";
		} else if (this.transform.position == GameObject.Find ("step2").transform.position) {
			tempPos = GameObject.Find ("step2").transform.position;
			GameObject.Find ("step0").tag = "untouchable";
			GameObject.Find ("step1").tag = "touchable";
			GameObject.Find ("step2").tag = "untouchable";
			GameObject.Find ("step3").tag = "untouchable";
			GameObject.Find ("step4").tag = "untouchable";
			GameObject.Find ("step5").tag = "touchable";
			GameObject.Find ("step6").tag = "untouchable";
			GameObject.Find ("step7").tag = "untouchable";
			GameObject.Find ("step8").tag = "untouchable";
		} else if (this.transform.position == GameObject.Find ("step3").transform.position) {
			tempPos = GameObject.Find ("step3").transform.position;
			GameObject.Find ("step0").tag = "touchable";
			GameObject.Find ("step1").tag = "untouchable";
			GameObject.Find ("step2").tag = "untouchable";
			GameObject.Find ("step3").tag = "untouchable";
			GameObject.Find ("step4").tag = "touchable";
			GameObject.Find ("step5").tag = "untouchable";
			GameObject.Find ("step6").tag = "touchable";
			GameObject.Find ("step7").tag = "untouchable";
			GameObject.Find ("step8").tag = "untouchable";
		} else if (this.transform.position == GameObject.Find ("step4").transform.position) {
			tempPos = GameObject.Find ("step4").transform.position;
			GameObject.Find ("step0").tag = "untouchable";
			GameObject.Find ("step1").tag = "touchable";
			GameObject.Find ("step2").tag = "untouchable";
			GameObject.Find ("step3").tag = "touchable";
			GameObject.Find ("step4").tag = "untouchable";
			GameObject.Find ("step5").tag = "touchable";
			GameObject.Find ("step6").tag = "untouchable";
			GameObject.Find ("step7").tag = "touchable";
			GameObject.Find ("step8").tag = "untouchable";
		} else if (this.transform.position == GameObject.Find ("step5").transform.position) {
			tempPos = GameObject.Find ("step5").transform.position;
			GameObject.Find ("step0").tag = "untouchable";
			GameObject.Find ("step1").tag = "untouchable";
			GameObject.Find ("step2").tag = "touchable";
			GameObject.Find ("step3").tag = "untouchable";
			GameObject.Find ("step4").tag = "touchable";
			GameObject.Find ("step5").tag = "untouchable";
			GameObject.Find ("step6").tag = "untouchable";
			GameObject.Find ("step7").tag = "untouchable";
			GameObject.Find ("step8").tag = "touchable";
		} else if (this.transform.position == GameObject.Find ("step6").transform.position) {
			tempPos = GameObject.Find ("step6").transform.position;
			GameObject.Find ("step0").tag = "untouchable";
			GameObject.Find ("step1").tag = "untouchable";
			GameObject.Find ("step2").tag = "untouchable";
			GameObject.Find ("step3").tag = "touchable";
			GameObject.Find ("step4").tag = "untouchable";
			GameObject.Find ("step5").tag = "untouchable";
			GameObject.Find ("step6").tag = "untouchable";
			GameObject.Find ("step7").tag = "touchable";
			GameObject.Find ("step8").tag = "untouchable";
		} else if (this.transform.position == GameObject.Find ("step7").transform.position) {
			tempPos = GameObject.Find ("step7").transform.position;
			GameObject.Find ("step0").tag = "untouchable";
			GameObject.Find ("step1").tag = "untouchable";
			GameObject.Find ("step2").tag = "untouchable";
			GameObject.Find ("step3").tag = "untouchable";
			GameObject.Find ("step4").tag = "touchable";
			GameObject.Find ("step5").tag = "untouchable";
			GameObject.Find ("step6").tag = "touchable";
			GameObject.Find ("step7").tag = "untouchable";
			GameObject.Find ("step8").tag = "touchable";
		} else if (this.transform.position == GameObject.Find ("step8").transform.position) {
			tempPos = GameObject.Find ("step8").transform.position;
			GameObject.Find ("step0").tag = "untouchable";
			GameObject.Find ("step1").tag = "untouchable";
			GameObject.Find ("step2").tag = "untouchable";
			GameObject.Find ("step3").tag = "untouchable";
			GameObject.Find ("step4").tag = "untouchable";
			GameObject.Find ("step5").tag = "touchable";
			GameObject.Find ("step6").tag = "untouchable";
			GameObject.Find ("step7").tag = "touchable";
			GameObject.Find ("step8").tag = "untouchable";
		}

			


	
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		this.transform.position = Input.mousePosition;
		if (other.tag == "touchable") {
			//Debug.Log("touchable");
			this.transform.position = other.transform.position; 
		//	if (vival.transform.position == other.transform.position)
			{
				//score+=10;

			}
			turns++;
			vivalTurns++;


		} else if (other.tag == "untouchable") {
			//Debug.Log("untouchable");
			this.transform.position = tempPos;
			//turns++;
		}
	}

	IEnumerator BackToNormal()
	{
		yield return new WaitForSeconds (0.6f);
		//this.GetComponent<Image>().material.color = Color.Lerp(Color.cyan, Color.white, lerp);
		this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
	}
}