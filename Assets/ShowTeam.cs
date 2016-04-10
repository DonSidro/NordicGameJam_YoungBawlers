using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ShowTeam : MonoBehaviour {

	public Image p1;
	public Image p2;
	public Image p3;
	public Image p4;

	public GameObject pc1;
	public GameObject pc2;
	public GameObject pc3;
	public GameObject pc4;

	// Use this for initialization
	void Awake () {
		string[] e = Input.GetJoystickNames ();
		if (e.Length == 2) {
			p1.gameObject.SetActive (true);
			p4.gameObject.SetActive (true);
			p1.color = Color.red;
			p4.color = Color.blue;
			pc1.SetActive (true);
			pc2.SetActive (true);
		} else if (e.Length == 3) {
			p1.gameObject.SetActive (true);
			p3.gameObject.SetActive (true);
			p4.gameObject.SetActive (true);
			p1.color = Color.red;
			p3.color = Color.yellow;
			p4.color = Color.blue;
			pc1.SetActive (true);
			pc2.SetActive (true);
			pc3.SetActive (true);
		} else if (e.Length == 4) {
			p1.gameObject.SetActive (true);
			p2.gameObject.SetActive (true);
			p3.gameObject.SetActive (true);
			p4.gameObject.SetActive (true);
			p1.color = Color.red;
			p2.color = Color.yellow;
			p3.color = Color.blue;
			p4.color = Color.green;
			pc1.SetActive (true);
			pc2.SetActive (true);
			pc3.SetActive (true);
			pc4.SetActive (true);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
