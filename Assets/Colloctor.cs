using UnityEngine;
using System.Collections;

public class Colloctor : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D col){

		if (col.CompareTag ("DynamicParticle") && GetComponent<CollectorScript>().water < GetComponent<CollectorScript>().maxWater) {
			Destroy (col.gameObject);
			GetComponent<CollectorScript> ().water++;
		}
			
	
	}
}
