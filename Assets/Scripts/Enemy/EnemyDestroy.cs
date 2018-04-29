using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {

	GameObject enemy;

	void OnTriggerEnter (Collider collider){

		if(collider.gameObject.CompareTag ("Enemy")){

			collider.gameObject.GetComponent<EnemyHealth> ().Death ();
			Destroy(collider.gameObject);
			Destroy (gameObject);
		}

	}
}
