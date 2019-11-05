using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatsRemover : MonoBehaviour
{
    public PlayerStats playerStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Treat" || collision.gameObject.tag == "Diamond")
        {
            playerStats.isLifeLost = true;
        }

        Destroy(collision.gameObject);
    }
}
