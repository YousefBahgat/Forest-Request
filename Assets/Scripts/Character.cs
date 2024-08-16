using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Character : MonoBehaviour {
	public float InputX;
	public float InputZ;
	public Vector3 desiredMoveDirection;
	public bool blockRotationPlayer;
	public float desiredRotationSpeed;
	public Animator anim;
	public float Speed;
	public float allowPlayerRotation;
	public Camera cam;
	public CharacterController controller;
	public bool isGrounded;
	private float verticalVel;
	private Vector3 moveVector;
	//public float gravity = 20.0f;
	//public float jumpSpeed = 2.0f;
	void Start () {
		anim = this.GetComponent<Animator>();
		cam = Camera.main;
		controller = this.GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void Update () {
		InputMagnitude ();
		isGrounded = controller.isGrounded;
		if (isGrounded) {
			verticalVel -= 0;
		} else {
			verticalVel -= 2;

		}
		moveVector = new Vector3(0, verticalVel, 0); 
		controller.Move(moveVector);
		if (Input.GetKey (KeyCode.LeftShift)) {
			anim.SetBool ("jumping", true);
		} else {
			anim.SetBool ("jumping", false);
		}
    }

	void PlayerMoveAndRotation()
	{
		InputX = Input.GetAxis("Horizontal"); 
		InputZ = Input.GetAxis("Vertical"); 


		var camera = Camera.main; 
		var forward = cam.transform.forward; 
		var right = cam.transform.right; 


		forward.y = 0f; 
		right.y = 0f; 

		forward.Normalize(); 
		right.Normalize(); 



		desiredMoveDirection = forward * InputZ + right * InputX; 


		if (blockRotationPlayer == false) 
		{
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMoveDirection), desiredRotationSpeed); 
		}
	}

	void InputMagnitude()
	{

		InputX = Input.GetAxis("Horizontal"); 
		InputZ = Input.GetAxis("Vertical"); 




		controller.Move(desiredMoveDirection * Time.deltaTime * 5f); 

		anim.SetFloat("InputZ", InputZ, 0.0f, Time.deltaTime * 2f); 
		anim.SetFloat("InputX", InputX, 0.0f, Time.deltaTime * 2f); 

		//Calculate the Input Magnitude
		Speed = new Vector2(InputX, InputZ).sqrMagnitude; 

		//Physically move player
		if (Speed > allowPlayerRotation)
		{
			anim.SetFloat("InputMagnitude", Speed , 0.0f, Time.deltaTime); 
			PlayerMoveAndRotation(); 
		}
		else if (Speed < allowPlayerRotation)
		{
			anim.SetFloat("InputMagnitude", Speed , 0.0f, Time.deltaTime); 
		}
	}

		




}
