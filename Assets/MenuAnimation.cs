using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuAnimation : MonoBehaviour {

	public bool active;

	int frames;
	public int animationDelay = 30;

	Image s_renderer;
	private int walkIndex = 0;
	public Sprite[] walking;
	public Sprite standing;

	// Use this for initialization
	void Start () {
		s_renderer = GetComponent<Image> ();
	}

	// Update is called once per frame
	void Update () {
		if (frames == 0) {
			AnimateWalk ();
			frames = animationDelay;
		}

		if (active) {
			frames--;
		} else {
			s_renderer.sprite = standing;
			walkIndex = 0;
		}

	}

	private void AnimateWalk(){
		walkIndex++;
		if(walkIndex > walking.Length-1){
			walkIndex = 0;
		}

		s_renderer.sprite = walking[walkIndex];
	}
}
