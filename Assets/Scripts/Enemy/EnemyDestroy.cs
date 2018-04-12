using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestroy : MonoBehaviour {

	void OnTriggerEnter (Collider collider){

		if(collider.gameObject.CompareTag ("Enemy")){

			Destroy (collider.gameObject);

		}

	}
}
