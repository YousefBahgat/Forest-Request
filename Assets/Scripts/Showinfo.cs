using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Showinfo : MonoBehaviour {
	public Text ShowInfo;
	public Text InfoText; 
	public string Info;
	public ScrollRect Scrollview;
	private int flag=0;


	void Start () {
		ShowInfo.gameObject.SetActive (false);
		InfoText.gameObject.SetActive (false);
		Scrollview.gameObject.SetActive (false);
	}
	
	void OnTriggerEnter(Collider player){
		if (player.CompareTag ("Player")) {
			ShowInfo.gameObject.SetActive (true);
			flag = 1;
			Cursor.visible = true;
		}
	}
	void OnTriggerExit(Collider player){
		if (player.CompareTag ("Player")) {
			ShowInfo.gameObject.SetActive (false);
			InfoText.gameObject.SetActive (false);
			Scrollview.gameObject.SetActive (false);
			flag = 0;
			Cursor.visible = false;
		}
	}


	 void Update () {
		if (flag == 1) {
			if (Input.GetButton("Showobj")) {
				InfoText.text = Info;
				InfoText.gameObject.SetActive (true);
				Scrollview.gameObject.SetActive (true);
			

			} 

		}
	//	else {
	//		InfoText.gameObject.SetActive (false);
	//		Scrollview.gameObject.SetActive (false);
	//	}  

		
	} 


}
