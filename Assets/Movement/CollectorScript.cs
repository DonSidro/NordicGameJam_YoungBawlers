using UnityEngine;
using System.Collections;

public class CollectorScript : MonoBehaviour {

	public int maxWater = 10;
	float size;
	public int water = 0;

	void Start() {
		size = GetComponent<BoxCollider2D> ().bounds.extents.y * 2;
	}

//	void OnCollisionEnter2D(Collider2D col) {
//		// if hitting water 
//		if (col.CompareTag("DynamicParticle") && water < maxWater) {
//			water++;
//			Destroy (col.gameObject);
//		}
//
//		// if being hit by a player from above
//		if (col.CompareTag("Player")) {
//			float y = col.gameObject.transform.position.y;
//			float boundY = transform.position.y + size - 0.001f;
//			if (y >= boundY) {
//				// some death animation
//				// insert code here
//				print("death");
//				water = 0;
//			}
//
//		}
//	}
}
