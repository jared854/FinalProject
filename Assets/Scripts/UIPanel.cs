using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class UIPanel : MonoBehaviour {

	[SerializeField] RectTransform pointSlider;
	[SerializeField] Text pointsText;

	public static UIPanel _instance;


	public static UIPanel instance {
		get {
			if (_instance == null) {
				_instance = GameObject.FindObjectOfType<UIPanel> ();
				if (_instance == null) {
					throw new UnityException ("Instance of UIPanel not found in scene");
				}
			}
			return _instance;
		}
	}


	public static int totalPoints = 0;			//Current points
	public float enemiesHit = 0;			//Current number of target enemies hit
	public float maxHitsLevel = 0;			//The number of target enemies needed to progress to the next level

	void Start(){
		if (_instance != null) {
			Destroy (_instance.gameObject);
		}
		_instance = this;

		ClearSlider ();
		UpdatePoints (0);
		UpdateSlider (1, 0);
	}

	void Update() {
		if (enemiesHit == maxHitsLevel) {
			LevelManager.instance.ChangeLevel ();
		}
	}

	public void UpdateSlider(){
		if (pointSlider == null)
			return;
		float relativeScale = (1.0f + enemiesHit) / (float)maxHitsLevel;
		enemiesHit++;
		Vector3 scale = pointSlider.transform.localScale;
		scale.x = relativeScale;
		pointSlider.transform.localScale = scale;
	}

	public void UpdateSlider(int maxHits, int points){
		if (pointSlider == null)
			return;
		float relativeScale = (float)points / (float)maxHits;
		Vector3 scale = pointSlider.transform.localScale;
		scale.x = relativeScale;
		pointSlider.transform.localScale = scale;
	}

	public void UpdatePoints(int addPoints){
		if (pointsText == null)
			return;
		string format = "D2"; // D2 means decimal format with a minimum of 2 digits, for one digit numbers this will give a preceding 0;
		// int newTotal = Int32.Parse(pointsText.text);
		totalPoints += addPoints;
		pointsText.text = totalPoints.ToString (format);
	}

	public void ClearSlider(){
		UpdateSlider (1, 0);
	}
}
