using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class PlayerCounter : MonoBehaviour {

	static public PlayerCounter instance;
	// Use this for initialization
	public int [] ij;
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
