using UnityEngine;
using System.Collections;

public class Burp : MonoBehaviour {
	public float drain = 0.1f;
	public float strength = 0.1f;
	public float cooldown = 1f;
	float countdown = 0;

	BurpMeter burpMeter;
	SpriteRenderer burpSprite;
	Collider2D burpCollider;
	
	// Use this for initialization
	void Awake () {
		burpMeter = GameObject.FindGameObjectWithTag("BurpMeter").GetComponent<BurpMeter>();
		burpSprite = GameObject.FindGameObjectWithTag("Burp").GetComponent<SpriteRenderer>();
		burpCollider = GameObject.FindGameObjectWithTag("Burp").GetComponent<Collider2D>();
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
			if(drained >= drain) {
				audio.Stop();
				audio.Play();
				enable();
				Invoke("disable", audio.clip.length);
			} else {
				burpMeter.score(drained);
			}
		}

		if(enabled()) {
			Color c = burpSprite.color;
			c.a = 1 - audio.time / audio.clip.length;
			burpSprite.color = c;
		}

	}
	bool enabled() {
		return burpSprite.enabled;
	}
	void enable() {
		burpSprite.enabled = true;
		burpCollider.enabled = true;
	}

	void disable() {
		burpSprite.enabled = false;
		burpCollider.enabled = false;
	}



}
