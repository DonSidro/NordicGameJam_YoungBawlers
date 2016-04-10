using UnityEngine;
using System.Collections;

public class WaterWaveSpawner : MonoBehaviour {

	public GameObject[] Spawns;
	public GameObject water;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public int hazardCount;
	int c;
	void Start(){
		StartCoroutine (WaveSpawing());
	}

	IEnumerator WaveSpawing(){
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				c = Random.Range (0, Spawns.Length);
				//Vector3 spawnPosition = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (water, new Vector2 (Random.Range(Spawns[c].transform.position.x -0.01f,Spawns[c].transform.position.x + 0.01f),Spawns[c].transform.position.y), spawnRotation);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	
	}
}
