using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scenechange : MonoBehaviour  {
	public GameObject timer;
	//public GameObject scoretext;
	//public Timer time;

	void OnTriggerEnter(Collider door){
		if(door.CompareTag("HouseEnter")){
			DontDestroyOnLoad (timer);
			timer.SetActive (false);
		//	DontDestroyOnLoad (scoretext);
		//	scoretext.SetActive (false);
			SceneManager.LoadScene ("Housescene");
		}

	}


}
