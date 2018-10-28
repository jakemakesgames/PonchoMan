using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	[SerializeField] private float speed;
	private Vector2 target;

	void Start(){
		// Set the target equal to the mousePosition
		target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}

	void Update(){
		// Move the projectile towards the target
		transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}
}
