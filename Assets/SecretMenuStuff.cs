using UnityEngine;
using System.Collections;

public class SecretMenuStuff : MonoBehaviour {

	public GameObject Waterstuff;

	// Update is called once per frame
	void OnTriggerEnter2D () {
		Waterstuff.SetActive (true);
	}
}
