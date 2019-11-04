using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchingTreats : MonoBehaviour
{
    public PlayerStats playerStats;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.SetActive(false);
        playerStats.isTreatCaught = true;
    }
}
