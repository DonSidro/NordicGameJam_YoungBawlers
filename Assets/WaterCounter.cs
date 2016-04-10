using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class WaterCounter : MonoBehaviour {

	public Image water;


	void Update () {

		water.fillAmount = (float) (GetComponentInParent<CollectorScript> ().water / 10f);
	
	}
}
