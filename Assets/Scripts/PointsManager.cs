using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsManager : Singleton<PointsManager>
{
    [SerializeField]
    private TMPro.TMP_Text valueText;

    public int Points { get; set; }

    public void AddPoints(int points)
    {
        Points += points;
        valueText.SetText(Points.ToString());
    }
}
