using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	Rigidbody2D body;
	float distToGround;

	float acceleration;
	float friction;

	public float acceleration_Air = 5;
	public float acceleration_Ground = 200;
	public float friction_Air = 0;
	public float friction_Ground = 25;
	public float jumpForce = 3;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
		distToGround = GetComponent<BoxCollider2D> ().bounds.extents.y;
	}

	bool isGrounded() {
		float x = transform.position.x;
		float y = transform.position.y - distToGround - 0.001f;

		Debug.DrawRay(new Vector3(x, y, 1), Vector3.down, Color.green);
		RaycastHit2D hit = Physics2D.Raycast (new Vector2(x, y), Vector2.down);
		if (hit.collider != null && hit.distance < 0.02f) {
			return true;
		}
		else
			return false;
	}
	
	// Update is called once per frame
	void Update () {
		// running
		Vector2 direction = new Vector2(Input.GetAxisRaw ("Horizontal"), 0);

		bool grounded = isGrounded();

		// jump
		if (Input.GetKey (KeyCode.UpArrow) && grounded) {
			body.AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
		}

		// body slam
		//if (Input.GetKey(KeyCode.DownArrow)) 
		//	input. -= 1.0f;

		//make sure the input doesn't exceed 1 if we go diagonally
		//if (input != Vector2.zero)
		//	input.Normalize();

		if (!grounded) {
			friction = friction_Air; 
			acceleration = acceleration_Air; 
		}
		else {
			friction = friction_Ground; 
			acceleration = acceleration_Ground; 
		}
		//Apply friction to velocity
		body.velocity -= body.velocity * friction * Time.deltaTime;

		//Apply acceleration to velocity
		body.velocity += direction * acceleration * Time.deltaTime;

		//We store the velocity in our own variable, just so we can print it on screen
		//velocity = body.velocity;
	}
}
