using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {
	public Vector3 positionTo;
	public Vector3 cameraPositionTo;
	public GameObject camera;
	Collider2D playerCol;
	bool canGo = false;

	void OnTriggerStay2D(Collider2D col) {
		if (col.name == "Sasha") {
			canGo = true;
			playerCol = col;
		}
	}
	void Update() {
		if (Input.GetKeyUp(KeyCode.Z) && canGo) {
			playerCol.transform.position = positionTo;
			camera.transform.position = cameraPositionTo;	
		}
	}

}
