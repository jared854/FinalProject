using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FinalEnemyMovement : MonoBehaviour
{
	Transform player;               // Reference to the player's position.
	NavMeshAgent nav;               // Reference to the nav mesh agent.


	void Awake ()
	{
		// finds tag of player and that is what the enemies follow in the navmesh
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		nav = GetComponent <NavMeshAgent> ();
	}


	void Update ()
	{
		//navigation follows player 
		nav.SetDestination (player.position);
	} 
}
