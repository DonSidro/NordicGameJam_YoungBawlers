using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TestControls : MonoBehaviour {

	public Text debuggui;
	// Use this for initialization
	void Start () {
	
	}
	

	void OnGUI(){
		debuggui.text = 
			"PS4 X C1 : " +  Input.GetButton("PS4_X1") + "\n" +
			"PS4 O C1 : " +  Input.GetButton("PS4_O1") + "\n" +
			"PS4 Tri C1 : " + Input.GetButton("PS4_Square1") + "\n" + 
			"PS4 Sqr C1 : " +  Input.GetButton("PS4_Triangle1") + "\n\n" +

			"Left_Analog_Horizontal C1 : " + Input.GetAxis("PS4_Horizontal1").ToString("F") + "\n" +
			"Left_Analog_Vertical C1 : " + Input.GetAxis("PS4_Vertical1").ToString("F") +"\n\n" +


			"PS4 X C2 : " +  Input.GetButton("PS4_X2") + "\n" +
			"PS4 O C2 : " +  Input.GetButton("PS4_O2") + "\n" +
			"PS4 Tri C2 : " + Input.GetButton("PS4_Square2") + "\n" + 
			"PS4 Sqr C2 : " +  Input.GetButton("PS4_Triangle2") + "\n\n" +


			"Left_Analog_Horizontal C2 : " + Input.GetAxis("PS4_Horizontal2").ToString("F") + "\n" +
			"Left_Analog_Vertical C2 : " + Input.GetAxis("PS4_Vertical2").ToString("F");
	

	}
}
