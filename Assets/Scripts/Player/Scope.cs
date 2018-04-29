using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scope : MonoBehaviour {

	//Animator switches between idle and scoped
	public Animator animator;

	public GameObject scopeOverlay;
	public GameObject weaponCamera;
	public Camera mainCamera;

	public float scopedFOV = 20f;
	private float normalFOV;
	//keep track of whether animator is scoped in or not
	private bool isScoped = false;

	void Update (){ 
		//if the q button is pressed then it goes into the scoped view
		if(Input.GetKeyDown(KeyCode.Q)){
			isScoped = !isScoped;
			//switches between idle animation and scoped
			animator.SetBool ("isScoped", isScoped); 

			if (isScoped) {
				StartCoroutine (OnScoped ());
			} else {
				OnUnscoped ();
			}
		}
	}

	void OnUnscoped(){
		//switches back from scoped view to unscoped
		scopeOverlay.SetActive (false);
		weaponCamera.SetActive (true);

		mainCamera.fieldOfView = normalFOV;
	}

	IEnumerator OnScoped(){
		//wait time is to allow for full animation to happen
		yield return new WaitForSeconds (.15f);
		scopeOverlay.SetActive (true);
		weaponCamera.SetActive (false);
		//field of view allows for the scoped function to zoom in 
		normalFOV = mainCamera.fieldOfView;
		mainCamera.fieldOfView = scopedFOV;
	}

}
