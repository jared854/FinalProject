using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
	//This is all for the pause menu
	public static bool GameIsPaused = false;

	public GameObject pauseMenuUI;


	void Update () {
		//this determines whether the game is paused or not
		if (Input.GetKeyDown (KeyCode.P)) {
			if (GameIsPaused) {
				Resume ();
			} else {
				Pause (); 
			}
		}
	}

	public void Resume(){
		//resumes the game
		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameIsPaused = false;
	}

	void Pause(){
		//pauses the game and sets time equal to 0 so the game timer stops
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameIsPaused = true;
	}


}
