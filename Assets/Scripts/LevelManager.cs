using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	public static LevelManager _instance;
	public string nextLevel;

	public static LevelManager instance {
		get {
			if (_instance == null) {
				_instance = GameObject.FindObjectOfType<LevelManager> ();
				if (_instance == null) {
					throw new UnityException ("Instance of LevelManager not found in scene");
				}
			}
			return _instance;
		}
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ChangeLevel() {
		SceneManager.LoadScene (nextLevel);
	}
}
