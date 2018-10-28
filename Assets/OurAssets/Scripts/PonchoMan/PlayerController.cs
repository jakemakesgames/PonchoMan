using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] private float speed;
	[SerializeField] private float walkingSpeed;
	[SerializeField] private float runningSpeed;
	private Rigidbody2D rb2D;
	private Vector2 moveVelocity;

	void Start(){
		// Set the rb2D variable equal to the Rigidbody2D component on this GameObject
		rb2D = GetComponent<Rigidbody2D> ();
		// Set the speed equal to the walkSpeed;
		speed = walkingSpeed;
	}

	void Update(){
		// Create a new Vector2 for the moveInput, set it equal to the Horizontal and Vertical axis
		Vector2 moveInput = new Vector2 (Input.GetAxisRaw ("Horizontal"), Input.GetAxisRaw ("Vertical"));
		// Set the moveVelocity vector equal to the moveInput multiplid by movementSpeed
		moveVelocity = moveInput.normalized * speed;

		// If the player HOLDS DOWN the Left Shift key, set the Speed value equal to the runningSpeed
		if (Input.GetKey (KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
			speed = runningSpeed;
		// Else set the Speed value equal to the walkingSpeed
		} else {
			speed = walkingSpeed;
		}
	}

	void FixedUpdate(){
		// Move the rb2D position by the moveVelocity, multiplied by Time.fixedDeltaTime
		rb2D.MovePosition (rb2D.position + moveVelocity * Time.fixedDeltaTime);
	}
}
