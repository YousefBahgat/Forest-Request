using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {
	public Ball ball; 
	public GameObject playerCamera;

	public float ballDistance = 2f;
	public float ballThrowingForce = 5f;

	public bool holdingBall = true;
	public Text attempts; 
	public  int attemptsnum = 5 ; 
	// Use this for initialization
	void Start () {
		ball.GetComponent<Rigidbody>().useGravity = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (holdingBall) {
			ball.transform.position = playerCamera.transform.position + playerCamera.transform.forward * ballDistance;
			if (Input.GetMouseButtonDown (0)) {
				ball.Activatetrail ();
				holdingBall = false;
				ball.GetComponent<Rigidbody>().useGravity = true;
				ball.GetComponent<Rigidbody> ().AddForce (playerCamera.transform.forward * ballThrowingForce);
				attemptsnum--;
				attempts.text = "Attempts: " + attemptsnum;
			}
		}
	}
}
