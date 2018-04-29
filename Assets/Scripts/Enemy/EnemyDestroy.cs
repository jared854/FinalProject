using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {

	void OnTriggerEnter (Collider collider){
		//put on the bullet, set to destroy enemy when hit
		if(collider.gameObject.CompareTag ("Enemy")){

			Destroy (collider.gameObject);
			Destroy (gameObject);
		}

	}
}
