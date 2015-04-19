using UnityEngine;
using System.Collections;

public class ControlMovement : MonoBehaviour {
	Movement movement;

	void Awake () {
		movement = GetComponent <Movement>();
	}
	
	
	void FixedUpdate()
	{
		// Store the input axes.
		float h = Input.GetAxisRaw("Horizontal");
		
		// Move the player around the scene.
		movement.Move(movement.speed*h, 0);
		
	}
}
