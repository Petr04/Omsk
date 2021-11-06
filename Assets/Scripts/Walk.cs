using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walk : MonoBehaviour {
	Animator anim;
	Rigidbody2D body;
	Transform trans;
	float horizontal;

	public float runSpeed = 10.0f;
	

	void Start() {
		body = GetComponent<Rigidbody2D>();  
		anim = GetComponent<Animator>();  
		trans = GetComponent<Transform>(); 
	}

	void Update() {
		horizontal = Input.GetAxisRaw("Horizontal");
		if (horizontal > 0) {
			anim.SetBool("isWalking", true);
			if (trans.localScale.x < 0) {
				trans.localScale = new Vector3(-trans.localScale.x, trans.localScale.y, trans.localScale.z);
			}

		}
		if (horizontal < 0) {
			anim.SetBool("isWalking", true);
			if (trans.localScale.x > 0) {
				trans.localScale = new Vector3(-trans.localScale.x, trans.localScale.y, trans.localScale.z);
			}
		}
		if (horizontal == 0) {
			anim.SetBool("isWalking", false);
		}
	}

	private void FixedUpdate() {
		body.velocity = new Vector2(horizontal * runSpeed, 0);   
	}
}