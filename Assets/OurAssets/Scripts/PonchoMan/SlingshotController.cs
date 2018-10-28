using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlingshotController : MonoBehaviour {

	[SerializeField] private GameObject projectile;
	[SerializeField] private Transform shotPos;

	void Update(){
		// If the Left Mouse Button is being pressed, call the Fire function
		if (Input.GetMouseButtonDown(0)) {
			Fire ();
		}
	}

	void Fire(){
		Instantiate (projectile, shotPos.position, Quaternion.identity);
	}
}
