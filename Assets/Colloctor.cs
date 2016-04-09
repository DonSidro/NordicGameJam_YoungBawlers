using UnityEngine;
using System.Collections;

public class Colloctor : MonoBehaviour {


	void OnTriggerEnter2D(Collider2D col){

		if (col.CompareTag ("DynamicParticle")) {
			Destroy (col.gameObject);
		}
			
	
	}
}
