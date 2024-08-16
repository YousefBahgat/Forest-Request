using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public GameObject trail;

	// Use this for initialization
	void Start () {
		trail.SetActive (false);
	}
	
	public void Activatetrail() {
		trail.SetActive (true);
	}
}
