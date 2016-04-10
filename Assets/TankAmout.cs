using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TankAmout : MonoBehaviour {

	public Image water;


	void Update () {
		if (GetComponentInParent<Tank1> () == null) {
			water.fillAmount = (float)(GetComponentInParent<Tank2> ().CountWater / 30f);

		} else {
			water.fillAmount = (float)(GetComponentInParent<Tank1> ().CountWater / 30f);
		}


	}
}
