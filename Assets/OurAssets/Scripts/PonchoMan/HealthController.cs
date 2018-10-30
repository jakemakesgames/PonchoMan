using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour {

	private SpriteRenderer rend;

	[Header("UI Variables")]
	[SerializeField] private int health;
	[SerializeField] private int numOfHearts;

	[SerializeField] private Image[] hearts;
	[SerializeField] private Sprite fullHeart;
	[SerializeField] private Sprite emptyHeart;

	#region Blinking
	[Header("Blinking Variables")]
	[SerializeField] private float blinkingTimer = 0.0f;
	[SerializeField] private float blinkingMinDuration = 0.1f;
	[SerializeField] private float blinkingTotalTimer = 0.0f;
	[SerializeField] private float blinkingTotalDuration = 1.0f;
	[SerializeField] private bool startBlinking = false;
	#endregion

	void Start(){
		rend = GetComponent<SpriteRenderer> ();
	}

	void Update(){

		// If the startBlinking Bool is equal to true, call the BlinkingEffect function
//		if (startBlinking){
//			BlinkingEffect ();
//		}

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

		// Set the startBlinking bool equal to true
		startBlinking = true;
		// Subtract the damagedAmount from the health amount
		health -= damagedAmount;
	}

//	void BlinkingEffect(){
//		blinkingTimer += Time.deltaTime;
//
//		if (blinkingTotalTimer >= blinkingTotalDuration) {
//			startBlinking = false;
//			blinkingTotalTimer = 0.0f;
//
//			rend.enabled = true;
//			return;
//		}
//
//		blinkingTimer += Time.deltaTime;
//		if (blinkingTimer >= blinkingMinDuration) {
//			blinkingTimer = 0.0f;
//
//			if (rend.enabled == true) {
//				rend.enabled = false;
//			} else {
//				rend.enabled = true;
//			}
//		}
//	}

	void PlayerDead (){
		Debug.Log ("Poncho-Man is dead... Game Over...");
	}
}
