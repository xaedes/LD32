using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	Vector3 movement;
	public float speed = 1f; 
	const float movingThreshold = 1e-2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void FixedUpdate()
	{
		// Move the entity around the scene according to this.movement
		Move();
		
		// Movement for this circle done.
		movement.Set(0, 0, 0);
		
	}

	public void Move(float h, float v) {
		Move(new Vector3(h,v,0f));
	}
	public void Move(Vector3 v) {
		movement += v;
	}

	void Move()
	{
		// Move the player to it's current position plus the movement.
		
		if (movement.magnitude > movingThreshold) {
			float length = Time.deltaTime * speed;
			
			if( movement.magnitude < length ) {
				length = movement.magnitude;
			}
			movement = movement.normalized * length;
		} else {
			movement = Vector3.zero;
		}
		
		Vector3 update = transform.position + movement;
		transform.position = update;
	}

}
