using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class ReadyArea : MonoBehaviour {

	private ArrayList readyPlayers = new ArrayList();
	public Text countdown;
	private float TimeToStart = 5;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D col){
		int id = col.GetComponent<Player> ().player;
		readyPlayers.Add (id);
		PlayerCounter.instance.count++;
		PlayerCounter.instance.ij[PlayerCounter.instance.count-1] = id;

	}

	void OnTriggerExit2D(Collider2D col){
		countdown.text = "Starting in ... 5";
		int id = col.GetComponent<Player> ().player;
		readyPlayers.Remove (id);
		PlayerCounter.instance.count--;
		PlayerCounter.instance.ij[PlayerCounter.instance.count-1] = id;


	}

	void Update(){
		if (readyPlayers.Count >= 2) {
			TimeToStart -= Time.deltaTime;
			countdown.enabled = true;
		} else {
			TimeToStart = 5;
			countdown.enabled = false;
		}
		if (TimeToStart <= 0) {
			countdown.text = "Starting ...";
			SceneManager.LoadScene (1);
		}

		if(TimeToStart > 0){
			countdown.text = "Starting in ... " + TimeToStart.ToString ("F0");
		}
	}
}
