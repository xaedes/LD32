using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	public Transform can;
	Movement movement;
	DisgustedByBurp disgusted;
	float direction = 0;

	void Awake () {
		movement = GetComponent<Movement>();
		disgusted = GetComponent<DisgustedByBurp>();
		direction = -1;
	}
	
	// Update is called once per frame
	void Update () {
		if(disgusted.Value() > 0.01) {
			float g = disgusted.Value() / 0.1f;
			if(g > 1)
				g = 1;
			direction = g * (1) + (1-g) * direction;
			if(direction>1){
				direction = 1;
			} else if (direction<-1) {
				direction = -1;
			}
		} else {
			float g = 0.0015f;
			direction = g * (-1) + (1-g) * direction;
		}

		movement.Move(direction*movement.speed,0);
	}

	void Disgusted() {
		audio.Play();
	}
}
