using UnityEngine;
using System.Collections;

public class ReadyArea : MonoBehaviour {

	private int[] readyPlayers;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col){
		int id = col.GetComponent<Player> ().player;
		print (id);
	}
}
