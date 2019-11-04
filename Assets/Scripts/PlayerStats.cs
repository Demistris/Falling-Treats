using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public int Points = 0;
    public TextMeshProUGUI PointsText;

    public bool isTreatCaught = false;

    void Update()
    {
        AddingPoints();
        PointsText.text = "" + Points;
    }

    void AddingPoints()
    {
        if (isTreatCaught == true)
        {
            Points += 10;
            isTreatCaught = false;
        }
    }
}
