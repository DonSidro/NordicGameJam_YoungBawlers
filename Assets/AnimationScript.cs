using UnityEngine;
using System.Collections;

public class AnimationScript : MonoBehaviour {

	public bool carryingWater;

	Rigidbody2D body;
	int frames;
	public int animationDelay = 30;

	SpriteRenderer s_renderer;
	private int walkIndex = 0;
	public Sprite[] walking;
	public Sprite standing;

	public Sprite[] walking_water;
	public Sprite standing_water;

	// Use this for initialization
	void Start () {
		s_renderer = GetComponent<SpriteRenderer> ();
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		animationDelay = 20 - ((int) Mathf.Abs (body.velocity.x*2.5f));
		if(body.velocity.x < 0){
			s_renderer.flipX = true;
		}
		else{
			s_renderer.flipX = false;
		}

		if (frames == 0) {
			AnimateWalk ();
			frames = animationDelay;
		}

		frames--;
	}

	private void AnimateWalk(){
		if (Mathf.Abs(body.velocity.x) < 0.1f) {
			if (carryingWater) {
				s_renderer.sprite = standing_water;
			} else {
				s_renderer.sprite = standing;
			}
		} else {
			walkIndex++;
			if(walkIndex > walking.Length-1){
				walkIndex = 0;
			}
			if (carryingWater) {
				s_renderer.sprite = walking_water[walkIndex];
			} else {
				s_renderer.sprite = walking[walkIndex];
			}
		}
	}
}
