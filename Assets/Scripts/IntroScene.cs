using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroScene : MonoBehaviour {

	public float time = 10f;


	void Update () {
		time -= Time.deltaTime;

		if (time <= 0) {
			SceneManager.LoadScene ("Start menu");

		}
	}
}
