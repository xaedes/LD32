using UnityEngine;
using System.Collections;

public class DisgustedByBurp : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		Debug.Log("other");
		Burp burp = other.GetComponentInParent<Burp>();
		if(burp != null){
			Debug.Log("disgusting");
			SendMessage("Disgusted");
		}
	}
}
