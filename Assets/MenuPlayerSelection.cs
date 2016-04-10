using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuPlayerSelection : MonoBehaviour {

	public int PlayerController;
	public bool joined = false;

	public Text joinedText;
	public Text notJoinedText;
	public MenuAnimation ma;

	// Update is called once per frame
	void Update () {
		PC ();
		//Controller ();

		/*
		if (Input.GetButton ("PS4_O" + PlayerController)) {
			joined = false;
			joinedText.enabled = false;
			notJoinedText.enabled = true;
			ma.active = false;
		}
		*/
	}

	void PC(){
		if (Input.GetButton ("PC"+ PlayerController+"_UP")) {
			joined = true;
			joinedText.enabled = true;
			notJoinedText.enabled = false;
			ma.active = true;
		}
	}

	void Controller(){
		if (Input.GetButton ("PS4_X" + PlayerController)) {
			joined = true;
			joinedText.enabled = true;
			notJoinedText.enabled = false;
			ma.active = true;
		}
	}
}
