using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {

	GameObject enemy;

	void OnTriggerEnter (Collider collider){
		//put on the bullet, set to destroy enemy when hit
		if(collider.gameObject.CompareTag ("Enemy")){
<<<<<<< HEAD

			collider.gameObject.GetComponent<EnemyAttributes> ().Death ();
=======
>>>>>>> 067ae56a3da4a6ff426f35e4f02a287af6eb1bef
			Destroy(collider.gameObject);
			Destroy (gameObject);
		}

	}
}
