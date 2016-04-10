﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ShowTeam : MonoBehaviour {

	public Image[] img;

	public Text tm;
	public GameObject[] players;


	public float TimeToPlay;

	// Use this for initialization
	void Awake () {
		
	}
	
	// Update is called once per frame
	void Update () {
		TimeToPlay -= Time.deltaTime;

		if (TimeToPlay < 0) {
			if (FindObjectOfType<Tank1> ().CountWater > FindObjectOfType<Tank2> ().CountWater) {
				tm.text = "TEAM 1 WINS!";
				Invoke ("loadLoby", 3);
			} else if (FindObjectOfType<Tank1> ().CountWater < FindObjectOfType<Tank2> ().CountWater) {
				tm.text = "TEAM 2 WINS!";
				Invoke ("loadLoby", 3);
			} else {
				tm.text = "DRAW!";
				Invoke ("loadLoby", 3);
			}


		} else {
			tm.text = TimeToPlay.ToString ("F0");
		}

	
	}

	void loadLoby(){
		SceneManager.LoadScene (0);
	}

	void TWOPlayers(){
		players [PlayerCounter.instance.ij [0]].SetActive (true);
		players [PlayerCounter.instance.ij [1]].SetActive (true);
		players [PlayerCounter.instance.ij [0]].tag = "Team1";
		players [PlayerCounter.instance.ij [1]].tag = "Team2";

	}
	void THREEPlayers(){
		players [PlayerCounter.instance.ij [0]].SetActive (true);
		players [PlayerCounter.instance.ij [1]].SetActive (true);
		players [PlayerCounter.instance.ij [2]].SetActive (true);
		players [PlayerCounter.instance.ij [0]].tag = "Team1";
		players [PlayerCounter.instance.ij [1]].tag = "Team2";
		players [PlayerCounter.instance.ij [2]].tag = "Team1";

		
	}
	void FOURPlayers(){
		players [PlayerCounter.instance.ij [0]].SetActive (true);
		players [PlayerCounter.instance.ij [1]].SetActive (true);
		players [PlayerCounter.instance.ij [2]].SetActive (true);
		players [PlayerCounter.instance.ij [3]].SetActive (true);
		players [PlayerCounter.instance.ij [0]].tag = "Team1";
		players [PlayerCounter.instance.ij [1]].tag = "Team2";
		players [PlayerCounter.instance.ij [2]].tag = "Team1";
		players [PlayerCounter.instance.ij [3]].tag = "Team2";

	}

}
