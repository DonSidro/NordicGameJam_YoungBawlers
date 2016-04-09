using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	public Transform spawn;
	public int CountWater;

	void OnTriggerEnter2D(Collider2D col){
	
		if (col.CompareTag ("Team1") && col.gameObject.GetComponent<CollectorScript>().water > 0) {
			
			col.gameObject.GetComponent<CollectorScript>().water--;
			CountWater++;
			GameObject newLiquidParticle=(GameObject)Instantiate(Resources.Load("LiquidPhysics/DynamicParticle 1")); //Spawn a particle

			DynamicParticle particleScript=newLiquidParticle.GetComponent<DynamicParticle>(); // Get the particle script
			particleScript.SetLifeTime(99999999999f); //Set each particle lifetime
			newLiquidParticle.transform.position= new Vector2(spawn.position.x, spawn.position.y);// Relocate to the spawner position
			newLiquidParticle.transform.parent=transform;
		}
	}
}
