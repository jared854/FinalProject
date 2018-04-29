using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float inputX;
	public float inputY;

	void Update () {
		//gets inout controls from the stated axis
		inputX = Input.GetAxis ("Horizontal1");
		inputY = Input.GetAxis ("Vertical1");

		if (inputX != 0)
			rotate ();
		if (inputY != 0)
			move ();
	}

	void rotate(){
		//used to rotate the camera
		transform.Rotate (new Vector3 (inputX, 0f, 0f));
	}

	void move(){
		//used to move the camera with the player
		transform.position += transform.forward * inputX * Time.deltaTime;
	}
}
