﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowTeam : MonoBehaviour {

	public Image p1;
	public Image p2;
	public Image p3;
	public Image p4;

	// Use this for initialization
	void Awake () {
		string[] e = Input.GetJoystickNames ();
		if (e.Length == 2) {
			p1.gameObject.SetActive (true);
			p4.gameObject.SetActive (true);
			p1.color = Color.red;
			p4.color = Color.blue;
		} else if (e.Length == 3) {
			p1.gameObject.SetActive (true);
			p3.gameObject.SetActive (true);
			p4.gameObject.SetActive (true);
			p1.color = Color.red;
			p3.color = Color.yellow;
			p4.color = Color.blue;
		} else if (e.Length == 4) {
			p1.gameObject.SetActive (true);
			p2.gameObject.SetActive (true);
			p3.gameObject.SetActive (true);
			p4.gameObject.SetActive (true);
			p1.color = Color.red;
			p2.color = Color.yellow;
			p3.color = Color.blue;
			p4.color = Color.green;
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
