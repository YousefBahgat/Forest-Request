using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainButtons : MonoBehaviour {

	public void PlayGame(){
		SceneManager.LoadScene ("mainscene");
	}
	public void QuitGame(){
		Application.Quit ();
	}
}
