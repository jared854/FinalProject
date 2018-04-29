using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControl : MonoBehaviour
{
	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	public int bulletSpeed;

	void Update()
	{
		//player controls dictated by axis inputs
		var x = Input.GetAxis("Horizontal") * Time.deltaTime * 150.0f;
		var z = Input.GetAxis("Vertical") * Time.deltaTime * 3.0f;

		transform.Rotate(0, x, 0);
		transform.Translate(0, 0, z);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine (Fire ());
		}

	}


	private IEnumerator Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			bulletSpawn.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * bulletSpeed;

		yield return new WaitForSeconds (5);

		Destroy (bullet.gameObject); 
       
	}

	void OnTriggerEnter (Collider collider){
		//If player touches an enemy (only possible in final level)
		if(collider.gameObject.CompareTag ("Enemy")){
			LevelManager.instance.ChangeLevel ();
		}

	}

}

