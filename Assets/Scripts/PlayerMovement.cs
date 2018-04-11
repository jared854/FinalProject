using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 6f;

	Vector3 movement;
	Rigidbody playerRigidBody;
	int floorMask;
	float camRayLength = 100f;

	void Awake(){
		floorMask = LayerMask.GetMask ("Floor");
		playerRigidBody = GetComponent<Rigidbody> ();
	}

	void FixedUpdate(){
		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Move (h, v);
	}

	void Move (float h, float v){
		movement.Set (h, 0f, v);
		//to make sure there is no advantage to move diagnal
		movement = movement.normalized * speed * Time.deltaTime;
		//applying movement to the player
		playerRigidBody.MovePosition(transform.position + movement);
	}
		
}
