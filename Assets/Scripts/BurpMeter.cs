using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BurpMeter : MonoBehaviour {
	float value = 0f;
	float gain = 0.3f;

	Scrollbar scrollbar;

	void Awake () {
		scrollbar = gameObject.GetComponentInChildren<Scrollbar>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		scrollbar.value = gain * value + (1-gain) * scrollbar.value;
	}

	public void score(float v) {
		value += v;
		if(value > 1) {
			value = 1;
		}
	}

	public float drain(float desired) {
		if(desired > value) {
			desired = value;
		}
		value -= desired;
		return desired;
	}
}
