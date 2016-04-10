using UnityEngine;
using System.Collections;

public class Colloctor : MonoBehaviour {

	SoundSystem sound;

	void Start(){
		sound = GameObject.Find ("Controller").GetComponent<SoundSystem> ();
	}

	void OnTriggerEnter2D(Collider2D col){

		if (col.CompareTag ("DynamicParticle") && GetComponent<CollectorScript>().water < GetComponent<CollectorScript>().maxWater) {
			sound.PlaySound ("Pickup");
			Destroy (col.gameObject);
			GetComponent<CollectorScript> ().water++;
		}

		if (col.gameObject.tag != transform.tag && col.GetComponent<Player>().dashing && GetComponent<CollectorScript>().water != 0) {

			col.GetComponent<CollectorScript>().water = col.GetComponent<CollectorScript>().water + GetComponent<CollectorScript> ().water;
			GetComponent<CollectorScript> ().water = 0;
			col.GetComponent<Player> ().dashing = false;

		}
			
	
	}
}
