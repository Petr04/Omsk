using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bubbles : MonoBehaviour
{
	public GameObject bubble;

	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Sasha") {
			bubble.SetActive(true);
		}
	}

	void OnTriggerExit2D(Collider2D col) {
		if (col.name == "Sasha") {
			bubble.SetActive(false);
		}
	}
}
