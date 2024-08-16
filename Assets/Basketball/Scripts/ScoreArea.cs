using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreArea : MonoBehaviour {

	public GameObject effect;
	public Text Scoretxt;
	public Player player;
	private int target = 2;
	private  int score=0;
	public Text WON;
	public Text lose;


	private float timer= 4f;
	private float Timerlose = 5f;
	private float Timewin = 5f;



	void Start (){
		effect.SetActive (false);

	}

	void OnTriggerEnter(Collider ball){
		if (ball.GetComponent<Ball> () != null) { 
			effect.SetActive (true);
			score++;
			Scoretxt.text = "Score: " + score;

		}
	}

	void Update( ){
		if (score < target && player.attemptsnum == 0) {
			timer -= Time.deltaTime;
			if (timer <= 0 && score != 5) {
				lose.gameObject.SetActive (true);

				if (Timerlose >= 0) {
					Timerlose -= Time.deltaTime;
				}
				if (Timerlose <= 0) {
					
					SceneManager.LoadScene ("Housescene");
				}
				
			}
				
		} else if (score == target && player.attemptsnum >= 0) { 
			WON.gameObject.SetActive (true);

			timecal ();



		}
					
	}

	void timecal (){
		if (Timewin >= 0) {
			Timewin -= Time.deltaTime;
		}
		if (Timewin <= 0) {

			SceneManager.LoadScene ("Start menu");
		}
	
	}






}
