using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PointsPanel : MonoBehaviour
{
    [SerializeField] RectTransform pointsSlider;

    public void SetLives(int maxPoints, int points)
    {

        UpdateSlider(maxPoints, points);
    }


    /// <summary>
    /// Updates the slider using its x-scale.
    /// </summary>
    /// <param name="points">points.</param>
    void UpdateSlider(int maxPoints, int points)
    {
        if (pointsSlider == null)
            return;
        float relativeScale = (float)points / (float)maxPoints;
        Vector3 scale = pointsSlider.transform.localScale;
        scale.x = relativeScale;
        pointsSlider.transform.localScale = scale;
    }
}

