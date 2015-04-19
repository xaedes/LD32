using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BurpMeter : MonoBehaviour {
	float value = 0f;
	float gain = 0.3f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Scrollbar scrollbar = gameObject.GetComponentInChildren<Scrollbar>();
		scrollbar.value = gain * value + (1-gain) * scrollbar.value;
	}

	public void score(float v) {
		value += v;
	}

	public float drain(float desired) {
		if(desired > value) {
			desired = value;
		}
		value -= desired;
		return desired;
	}
}
