using UnityEngine;
using System.Collections;

public class Burp : MonoBehaviour {
	public float drain = 0.1f;
	public float cooldown = 1f;
	float countdown = 0;

	BurpMeter burpMeter;
	SpriteRenderer burpSprite;
	
	// Use this for initialization
	void Awake () {
		burpMeter = GameObject.FindGameObjectWithTag("BurpMeter").GetComponent<BurpMeter>();
		burpSprite = GameObject.FindGameObjectWithTag("Burp").GetComponent<SpriteRenderer>();
		countdown = 0;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		// If the Fire1 button is being pressed,  it's time to burp
//		Debug.Log(Input.GetButton("Fire1"));
		countdown -= Time.deltaTime;
		if (Input.GetButton("Fire1") && (countdown <= 0)) {
			countdown = cooldown;
			float desired = drain;
			float drained = burpMeter.drain(desired);
			if(drained > 0) {
				audio.Stop();
				audio.Play();
				burpSprite.enabled = true;
				Invoke("disableBurp", audio.clip.length);
			}
		}

		if(burpSprite.enabled) {
			Color c = burpSprite.color;
			c.a = 1 - audio.time / audio.clip.length;
			burpSprite.color = c;
		}

	}

	void disableBurp() {
		burpSprite.enabled = false;
		
	}


}
