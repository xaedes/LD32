using UnityEngine;
using System.Collections;

public class Burp : MonoBehaviour {
	BurpMeter burpMeter;

	float drainSpeed = 0.5f;

	// Use this for initialization
	void Awake () {
		burpMeter = GameObject.FindGameObjectWithTag("BurpMeter").GetComponent<BurpMeter>();
	
	}
	
	// Update is called once per frame
	void Update () {
		// If the Fire1 button is being pressed,  it's time to burp
		if (Input.GetButton("Fire1")) {
			float v = burpMeter.drain(Time.deltaTime * drainSpeed);
			if(v > 0 && !audio.isPlaying) {
				audio.Play();
			}
		}
	}


}
