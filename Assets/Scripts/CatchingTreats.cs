using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchingTreats : MonoBehaviour
{
    public PlayerStats playerStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Treat")
        {
            collision.gameObject.SetActive(false);
            playerStats.isTreatCaught = true;
        }

        if (collision.gameObject.tag == "Diamond")
        {
            collision.gameObject.SetActive(false);
            playerStats.isDiamondCaught = true;
        }

        if (collision.gameObject.tag == "Trash")
        {
            collision.gameObject.SetActive(false);
            playerStats.isTrashCaught = true;
        }
    }
}
