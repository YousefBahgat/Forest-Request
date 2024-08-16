using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Controller : MonoBehaviour {

	public Player player;
	public Ball ball; 
	public float resetTimer = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(player.holdingBall == false){
			resetTimer -= Time.deltaTime;
			if (resetTimer <= 0) {
				ball.GetComponent<Rigidbody> ().velocity = Vector3.zero;
				ball.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
				ball.trail.SetActive (false);
				ball.GetComponent<Rigidbody>().useGravity = false;
				player.holdingBall = true;
				resetTimer = 5f;

			}
	}
}
}
