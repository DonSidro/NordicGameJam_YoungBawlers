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
		if (Input.GetButton ("PS4_X" + PlayerController)) {
			joined = true;
			joinedText.enabled = true;
			notJoinedText.enabled = false;
			ma.active = true;
		}
		if (Input.GetButton ("PS4_O" + PlayerController)) {
			joined = false;
			joinedText.enabled = false;
			notJoinedText.enabled = true;
			ma.active = false;
		}
	}
}
