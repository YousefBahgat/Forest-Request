using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontrol : MonoBehaviour {

	public GameObject cam1;
	public GameObject cam2;
	public GameObject cam3;
	public GameObject cam4;
	public GameObject cam5;
	void Update () {
		if (Input.GetKey (KeyCode.X)) {
			cam1.SetActive (true);
			cam2.SetActive (false);
			cam3.SetActive (false);
			cam4.SetActive (false);
			cam5.SetActive (false);
		}	
		if (Input.GetKey (KeyCode.C)) {
			cam1.SetActive (false);
			cam2.SetActive (true);
			cam3.SetActive (false);
			cam4.SetActive (false);
			cam5.SetActive (false);
		}
		if (Input.GetKey (KeyCode.V)) {
			cam1.SetActive (false);
			cam2.SetActive (false);
			cam3.SetActive (true);
			cam4.SetActive (false);
			cam5.SetActive (false);
		}
		if (Input.GetKey (KeyCode.B)) {
			cam1.SetActive (false);
			cam2.SetActive (false);
			cam3.SetActive (false);
			cam4.SetActive (true);
			cam5.SetActive (false);

		}
		if (Input.GetKey (KeyCode.N)) {
			cam1.SetActive (false);
			cam2.SetActive (false);
			cam3.SetActive (false);
			cam4.SetActive (false);
			cam5.SetActive (true);

		}

	}
}
