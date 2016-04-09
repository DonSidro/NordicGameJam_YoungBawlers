using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	Rigidbody2D body;
	float distToGround;
	float playerWidth;

	public float acceleration = 30;
	public float friction = 2;
	public float jumpForce = 3;



	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
		playerWidth = GetComponent<BoxCollider2D> ().bounds.extents.x;
		distToGround = GetComponent<BoxCollider2D> ().bounds.extents.y;
	}

	bool isGrounded() {
		float x1 = transform.position.x - playerWidth;
		float x2 = transform.position.x + playerWidth;
		float y = transform.position.y - distToGround - 0.001f;

		return checkGround (new Vector2 (x1, y)) || checkGround(new Vector2 (x2, y));
	}

	bool checkGround(Vector2 pos) {
		RaycastHit2D hit = Physics2D.Raycast (pos, Vector2.down);
		if (hit.collider != null && hit.distance < 0.02f) {
			return true;
		}
		else
			return false;
	}
	
	// Update is called once per frame
	void Update () {
		// jump
		if (Input.GetKey (KeyCode.UpArrow) && isGrounded()) {
			if (body.velocity.y == 0)
				body.AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
		}

		// body slam
		//if (Input.GetKey(KeyCode.DownArrow)) 
		//	input. -= 1.0f;

		//make sure the input doesn't exceed 1 if we go diagonally
		//if (input != Vector2.zero)
		//	input.Normalize();

		float vx = body.velocity.x;

		// apply friction
		vx -= vx * friction * Time.deltaTime;
		// apply acceleration
		vx += Input.GetAxisRaw ("Horizontal") * acceleration * Time.deltaTime;
		// update velocity
		body.velocity = new Vector2 (vx, body.velocity.y);

		//We store the velocity in our own variable, just so we can print it on screen
		//velocity = body.velocity;
	}
		
}
