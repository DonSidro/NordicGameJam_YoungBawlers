using UnityEngine;
using System.Collections;

public class Tank : MonoBehaviour {

	public transform spawn;

	void OnTriggerEnter2D(Collider2D col){
	
		if (col.CompareTag ("Team1") && col.gameObject.GetComponent<"done something here">().water > 0) {
			
			col.gameObject.GetComponent<"done something here">().water--;
			GameObject newLiquidParticle=(GameObject)Instantiate(Resources.Load("LiquidPhysics/DynamicParticle")); //Spawn a particle
			newLiquidParticle.GetComponent<Rigidbody2D>().AddForce( particleForce); //Add our custom force
			DynamicParticle particleScript=newLiquidParticle.GetComponent<DynamicParticle>(); // Get the particle script
			particleScript.SetLifeTime(PARTICLE_LIFETIME); //Set each particle lifetime
			particleScript.SetState(particlesState); //Set the particle State
			newLiquidParticle.transform.position= new Vector2(Random.Range(spawn.position.x-0.01f, spawn.position.x+0.01f), spawn.position.y);// Relocate to the spawner position
			newLiquidParticle.transform.parent=particlesParent;
		}
	}
}
