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
		if(Input.GetKeyDown(KeyCode.Q)){
			isScoped = !isScoped;
			animator.SetBool ("isScoped", isScoped); 

			if (isScoped) {
				StartCoroutine (OnScoped ());
			} else {
				OnUnscoped ();
			}
		}
	}

	void OnUnscoped(){
		scopeOverlay.SetActive (false);
		weaponCamera.SetActive (true);

		mainCamera.fieldOfView = normalFOV;
	}

	IEnumerator OnScoped(){
		yield return new WaitForSeconds (.15f);
		scopeOverlay.SetActive (true);
		weaponCamera.SetActive (false);

		normalFOV = mainCamera.fieldOfView;
		mainCamera.fieldOfView = scopedFOV;
	}

}
