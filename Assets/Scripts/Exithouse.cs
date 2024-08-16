using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exithouse : MonoBehaviour {
	void OnTriggerEnter(Collider door){
	     if(door.CompareTag("HouseExit")){
			//DontDestroyOnLoad (timer);
			SceneManager.LoadScene ("mainscene");
		}
	}
}
