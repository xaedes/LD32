﻿using UnityEngine;
using System.Collections;

public class Can : MonoBehaviour {

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
		}
	}
}
