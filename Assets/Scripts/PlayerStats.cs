using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    public int Points = 0;
    public int Diamonds = 0;
    public int Lifes = 5;
    public int Trash = 2;

    public TextMeshProUGUI PointsText;
    public TextMeshProUGUI DiamondsText;
    public TextMeshProUGUI LifesText;
    public TextMeshProUGUI TrashText;

    public bool isTreatCaught = false;
    public bool isDiamondCaught = false;
    public bool isTrashCaught = false;
    public bool isLifeLost = false;

    public int counter;

    void Update()
    {
        StatChanger();

        PointsText.text = "" + Points;
        DiamondsText.text = "" + Diamonds;
        LifesText.text = "" + Lifes;
        TrashText.text = "" + Trash;

        if (counter == 10)
        {
            FasterFalling();
            counter = 0;
        }

        if(Trash <= 0 || Lifes <= 0)
        {
            EndGame();
        }
    }

    void StatChanger()
    {
        if (isTreatCaught == true)
        {
            Points += 10;
            counter += 1;
            isTreatCaught = false;
        }

        if (isDiamondCaught == true)
        {
            Diamonds += 10;
            isDiamondCaught = false;
        }

        if (isTrashCaught == true)
        {
            Trash -= 1;
            isTrashCaught = false;
        }

        if (isLifeLost == true)
        {
            Lifes -= 1;
            isLifeLost = false;
        }
    }

    void FasterFalling()
    {
        //fallingSpeed += 1;
        //Debug.Log(fallingSpeed);
    }

    void EndGame()
    {
        
    }
}
