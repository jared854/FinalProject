using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public float inputX;
	public float inputY;

	void Update () {
		inputX = Input.GetAxis ("Horizontal1");
		inputY = Input.GetAxis ("Vertical1");

		if (inputX != 0)
			rotate ();
		if (inputY != 0)
			move ();
	}

	void rotate(){
		transform.Rotate (new Vector3 (0f, inputY * Time.deltaTime, 0f));
	}

	void move(){
		transform.position += transform.forward * inputY * Time.deltaTime;
	}
}
