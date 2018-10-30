using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour {

	[SerializeField] private int health;
	[SerializeField] private int numOfHearts;

	[SerializeField] private Image[] hearts;
	[SerializeField] private Sprite fullHeart;
	[SerializeField] private Sprite emptyHeart;

	void Update(){

		// If the player's health is greater than the numOfHearts
		if (health > numOfHearts) {
			// Set the health value equal to the numOfHearts
			health = numOfHearts;
		}

		// If the player's health is less thanor equal to zero, set the health to zero and call the death function
		if (health <= 0){
			PlayerDead ();
		}

		// For every i element in the hearts array
		for (int i = 0; i < hearts.Length; i++) {

			// If i is less than the health value, the heart sprite will be the fullHeart
			if (i < health) {
				hearts [i].sprite = fullHeart;
			// Else the heart sprite will be the emptyHeart
			} else {
				hearts [i].sprite = emptyHeart;
			}

			// If i is less than the numOfHearts value, the hearts will be enabled
			if (i < numOfHearts) {
				hearts [i].enabled = true;
			// Else the hearts will not be enabled
			} else {
				hearts [i].enabled = false;
			}
		}
	}

	public void TakeDamage(int damagedAmount){

		// Subtract the damagedAmount from the health amount
		health -= damagedAmount;
	}

	void PlayerDead (){
		Debug.Log ("Poncho-Man is dead... Game Over...");
	}
}
