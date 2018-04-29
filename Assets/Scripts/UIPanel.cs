using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class UIPanel : MonoBehaviour {

	[SerializeField] RectTransform pointSlider;
	[SerializeField] Text pointsText;

	public static int totalPoints = 0;

	void Start(){
		UpdatePoints (0);
		UpdateSlider (1, 0);
	}

	void UpdateSlider(int maxPoints, int points){
		if (pointSlider == null)
			return;
		float relativeScale = (float)points / (float)maxPoints;
		Vector3 scale = pointSlider.transform.localScale;
		scale.x = relativeScale;
		pointSlider.transform.localScale = scale;
	}

	void UpdatePoints(int addPoints){
		if (pointsText == null)
			return;
		string format = "D2"; // D2 means decimal format with a minimum of 2 digits, for one digit numbers this will give a preceding 0;
		// int newTotal = Int32.Parse(pointsText.text);
		totalPoints += addPoints;
		pointsText.text = totalPoints.ToString (format);
	}

	void ClearSlider(){
		UpdateSlider (1, 0);
	}
}
