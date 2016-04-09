using UnityEngine;
using System.Collections;

public class MenuPlayerSelectionScreen : MonoBehaviour {

	public MenuAnimation[] players;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 1; i < 5; i++) {
			if (Input.GetButton ("PS4_Start" + i)) {
				print ("Start");
			}
		}
	}

	private void StartGame(){
		 
	}
}
