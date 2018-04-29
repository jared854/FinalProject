using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttributes : MonoBehaviour
{
	public AudioClip deathClip;                 // The sound to play when the enemy dies.
	public int killPoints;						// The amount added to the player's score when the enemy dies.
	public bool isTarget;						// Whether the enemy is of the target class in the level

	public void Death ()
	{
		UIPanel.instance.UpdatePoints(killPoints);
		if (isTarget) {
			UIPanel.instance.UpdateSlider ();
		}
	}
}
