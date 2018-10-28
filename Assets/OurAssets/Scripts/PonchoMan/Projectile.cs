using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	private Vector2 target;
	[SerializeField] private float speed;
	[SerializeField] private GameObject destroyedFX;

	void Start(){
		// Set the target equal to the mousePosition
		target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}

	void Update(){
		// Move the projectile towards the target
		transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
		// If the projectile reaches it's target position, destroy
		if (Vector2.Distance(transform.position, target) < 0.2f){
			// Instantiate a particle effect
			Destroy (gameObject);
		}
	}
}
