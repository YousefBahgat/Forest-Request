using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Showt : MonoBehaviour {
	public Text Greentext;
	private GameObject greenbox;
	public Text GreenScoreText;
	private int  GreenScore=0 ;
	private int greenflag=0;
	public Text lastscene;
	public AudioSource audioSource;
	public AudioClip picksound;

	private float timer= 10f;



	// Use this for initialization
	void Start () {
		Greentext.gameObject.SetActive (false);
	}
	
	void OnTriggerEnter( Collider Box){
		if (Box.CompareTag ("Green")) {
			Greentext.gameObject.SetActive (true);
			greenbox = Box.gameObject;
			greenflag = 1;
		
		}
	}
	void OnTriggerExit(Collider Box){
		if (Box.CompareTag("Green")) {
			Greentext.gameObject.SetActive (false);
			greenflag = 0;
		}
	
	}
	void Update(){
		if (greenflag == 1){
			if(Input.GetKey(KeyCode.E)){
				greenbox.SetActive(false);
				Greentext.gameObject.SetActive (false);
				greenflag = 0;
				GreenScore++;
				GreenScoreText.text = "GreenBoxes: " + GreenScore ;
				audioSource = GetComponent<AudioSource> ();
				audioSource.PlayOneShot (picksound);
			}
	  }
		if (GreenScore == 10) {
			GreenScoreText.text = "GreenBoxes: All Collected";
			lastscene.gameObject.SetActive (true);
			timer -= Time.deltaTime;
			if (timer <= 0) {
				SceneManager.LoadScene ("Basketballgame");
			}

		}


  }

}