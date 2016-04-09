using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	Rigidbody2D body;

	float acceleration;
	float friction;

	public float acceleration_Air = 5;
	public float acceleration_Ground = 200;
	public float friction_Air = 0;
	public float friction_Ground = 25;
	public float jumpForce = 3;

	Vector3 velocity = Vector3.zero;
	Vector2 input;

	bool canJump = false;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		//get the input
		input = Vector2.zero;
		if (Input.GetKey (KeyCode.RightArrow)) { 
				input.x += 1.0f;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
				input.x -= 1.0f;
		} 
		if (Input.GetKey (KeyCode.UpArrow) && canJump) {
			//input.y += 1.0f;
			canJump = false;
			body.AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
		}

		if (Input.GetKey(KeyCode.DownArrow)) input.y -= 1.0f;

		//make sure the input doesn't exceed 1 if we go diagonally
		if (input != Vector2.zero)
			input.Normalize();

		UpdateRigidBody ();
	}

	void OnCollisionEnter2D(){
		canJump = true;
	}

	void UpdateRigidBody()
	{
		if (body.velocity.y < 0) {
			print ("In air");
			friction = friction_Air; 
			acceleration = acceleration_Air; 
		}
		else {
			print ("Grounded");
			friction = friction_Ground; 
			acceleration = acceleration_Ground; 
		}
		//Apply friction to velocity
		body.velocity -= body.velocity * friction * Time.deltaTime;

		//Apply acceleration to velocity
		body.velocity += input * acceleration * Time.deltaTime;

		//The rigid body does its own position integration

		//We store the velocity in our own variable, just so we can print it on screen
		velocity = body.velocity;
	}
}
