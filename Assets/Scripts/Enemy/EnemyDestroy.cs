using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {

	GameObject enemy;

	void OnTriggerEnter (Collider collider){
		//put on the bullet, set to destroy enemy when hit
		if(collider.gameObject.CompareTag ("Enemy")){

			collider.gameObject.GetComponent<EnemyAttributes> ().Death ();
			Destroy(collider.gameObject);
			Destroy (gameObject);
		}

	}
}
