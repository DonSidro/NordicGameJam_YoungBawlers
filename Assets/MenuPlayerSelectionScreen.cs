using UnityEngine;
using System.Collections;

public class MenuPlayerSelectionScreen : MonoBehaviour {

	public GameObject[] players;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 1; i < 5; i++) {
			if (Input.GetButton ("PS4_X" + i)) {
				players [i - 1].SetActive (true);
			}
			/*
			if (Input.GetButton ("PS4_O" + i)) {
				players [i - 1].SetActive (false);
			}
			*/
		}
	}

	private void StartGame(){
		 
	}
}
