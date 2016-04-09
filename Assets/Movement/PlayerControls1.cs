using UnityEngine;
using System.Collections;

public class PlayerControls1 : MonoBehaviour {

	public string PlayerController;

	Rigidbody2D body;
	float distToGround;
	float playerWidth;

	public float acceleration = 30;
	public float friction = 2;
	public float jumpForce = 3;



	// Use this for initialization
	void Start () {
		
		body = GetComponent<Rigidbody2D> ();
		playerWidth = GetComponent<BoxCollider2D> ().bounds.extents.x - 0.02f;
		distToGround = GetComponent<BoxCollider2D> ().bounds.extents.y;
	}

	bool isGrounded() {
		return Physics2D.Raycast (new Vector2(transform.position.x - playerWidth, transform.position.y - distToGround),-Vector2.up,0.1f) || Physics2D.Raycast (new Vector2(transform.position.x + playerWidth, transform.position.y) ,-Vector2.up,distToGround+0.1f) ;
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
		Debug.DrawRay(new Vector2 (transform.position.x - playerWidth, transform.position.y - distToGround), -Vector2.up, Color.blue);
		Debug.DrawRay(new Vector2 (transform.position.x + playerWidth, transform.position.y - distToGround), -Vector2.up, Color.blue);

		// jump
		if (Input.GetButton ("PS4_X" + PlayerController) && isGrounded ()) {
			if (Mathf.Abs(body.velocity.y) <= 0.001)
				body.AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
		}
			// running
		Vector2 direction = new Vector2 (Input.GetAxisRaw ("PS4_Horizontal"+ PlayerController), 0);
			

			

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
		vx += Input.GetAxisRaw ("PS4_Horizontal"+ PlayerController) * acceleration * Time.deltaTime;
			// update velocity
			body.velocity = new Vector2 (vx, body.velocity.y);

			//We store the velocity in our own variable, just so we can print it on screen
			//velocity = body.velocity;
		}
		
}

