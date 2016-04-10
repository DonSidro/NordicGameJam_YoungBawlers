using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerCounter : MonoBehaviour {

	static public PlayerCounter instance;
	// Use this for initialization
	public List<GameObject> readyPlayers = new List<GameObject>();
	public int count;
	void Awake () {
		
		if (instance == null) {
			instance = this;
		} else {
			Destroy (this);
		}
		DontDestroyOnLoad(transform.gameObject);

	
	}
}
