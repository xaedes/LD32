using UnityEngine;
using System.Collections;

public class Can : MonoBehaviour {
	public float value = 0.1f; 
	PlayAudioAndSelfDestruct playAudio;
	BurpMeter burpMeter;

	// Use this for initialization
	void Awake () {
		playAudio = GetComponent<PlayAudioAndSelfDestruct>();
		burpMeter = GameObject.FindGameObjectWithTag("BurpMeter").GetComponent<BurpMeter>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			burpMeter.score(value);
			playAudio.PlayAudio();
			SpriteRenderer sprite = GetComponentInChildren<SpriteRenderer>();
			Color c = sprite.color;
			c.a = 0;
			sprite.color = c;
		}
	}


}
