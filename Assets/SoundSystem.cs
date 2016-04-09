using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SoundSystem : MonoBehaviour {

	public float pitch;
	public Text pitchText;
	AudioSource audio;

	void Start(){
		pitch = 0.0f;
		audio = GetComponent<AudioSource> ();
	}

	public void IncreasePitch(){
		pitch += 0.1f;
		UpdateText ();
	}

	public void DecreasePitch(){
		pitch -= 0.1f;
		UpdateText ();
	}

	void UpdateText(){
		pitchText.text = "Pitch: " + Mathf.Round(pitch * 100)/100;
	}

	public void PlaySound(string soundName){
		audio.pitch = 1.0f + pitch;
		audio.PlayOneShot((Resources.Load("Sounds/"+soundName) as AudioClip));
	}
}
