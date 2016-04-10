using UnityEngine;
using System.Collections;

public class PlayerCounter : MonoBehaviour {

	static public PlayerCounter instance;
	// Use this for initialization
	public int[] playerCount = new int[3];
	void Awake () {
		
		if (instance == null) {
			instance = this;
		} else {
			Destroy (this);
		}
		DontDestroyOnLoad(transform.gameObject);
		playerCount [0] = 0;
		playerCount [1] = 0;
		playerCount [2] = 0;
		playerCount [3] = 0;
	}
}
