using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
	Transform player;               // Reference to the player's position.
	//PlayerHealth playerHealth;      // Reference to the player's health.
	//EnemyHealth enemyHealth;        // Reference to this enemy's health.
	NavMeshAgent nav;          // Reference to the nav mesh agent.

	public bool hunting = false;

	public float minX = 1;
	public float maxX = 10;
	public float minZ = 1;
	public float maxZ = 10;

	public float tarX;
	public float tarZ;


	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		//playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent <EnemyHealth> ();
		nav = GetComponent <NavMeshAgent> ();
		randomTarget ();
	}


	void Update ()
	{
		// If the enemy and the player have health left...
		//if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		//{
			// ... set the destination of the nav mesh agent to the player.
			//nav.SetDestination (player.position);
		//}
		// Otherwise...
		//else
		//{
		// ... disable the nav mesh agent.
//			nav.enabled = false;
//		}

		if (hunting) {
			nav.SetDestination (player.position);
		} if (transform.position.x < tarX + 1 && transform.position.x > tarX - 1
			&& transform.position.z < tarZ + 1 && transform.position.z > tarZ - 1) {
			randomTarget ();
		} else {
			nav.SetDestination (new Vector3(tarX, transform.position.y, tarZ));
		}
	} 

	void randomTarget() {
		tarX = Random.Range (minX, maxX);
		tarZ = Random.Range (minZ, maxZ);
	}
}
