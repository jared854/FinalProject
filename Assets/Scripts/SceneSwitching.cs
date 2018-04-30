using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitching : MonoBehaviour {

	void Update(){

	}

	public void LoadControlsScene(){
		SceneManager.LoadScene ("ControlsScene");
	}

	public void LoadFirstNotesScene(){
		SceneManager.LoadScene ("Note_scene_1");
	}

	public void LoadMainMenuScene(){
		SceneManager.LoadScene ("MainMenu");
	}

	public void QuitGame(){
		Application.Quit ();
		Debug.Log ("Quitting Game...");
	}
}
