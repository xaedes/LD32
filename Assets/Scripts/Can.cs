using UnityEngine;
using System.Collections;

public class Can : MonoBehaviour {
	public float value = 0.1f; 
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			Debug.Log("collision");
			// shake the camera here..
			Destroy(gameObject);
			other.audio.Play();
			BurpMeter burpMeter = GameObject.FindGameObjectWithTag("BurpMeter").GetComponent<BurpMeter>();
			burpMeter.score(value);
		}
	}
}
