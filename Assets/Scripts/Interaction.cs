using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {
	Transform hint;
	void OnTriggerEnter2D(Collider2D col) {
		if (col.tag == "Interactable"){
			hint = transform.Find("hint");
			hint.gameObject.SetActive(true);
		}
	}
	void OnTriggerExit2D(Collider2D col) {
		if (col.tag == "Interactable"){
			hint = transform.Find("hint");
			hint.gameObject.SetActive(false);
		}
	}
}
