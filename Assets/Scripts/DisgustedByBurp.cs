using UnityEngine;
using System.Collections;

public class DisgustedByBurp : MonoBehaviour {
	float value = 0f;
	float gain = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		value = gain * 0 + (1-gain) * value;
	}

	void OnTriggerEnter2D(Collider2D other){
		Burp burp = other.GetComponentInParent<Burp>();
		if(burp != null){
			value += burp.strength;
//			SendMessage("Disgusted");
		}
	}

	public float Value() {
		return value;
	}
}
