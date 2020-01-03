using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreatsRemover : MonoBehaviour
{
    public PlayerStats playerStats;

    public AudioSource WrongSoundPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Treat")
        {
            PlayWrongSound();
            playerStats.isLifeLost = true;
        }

        Destroy(collision.gameObject);
    }

    public void PlayWrongSound()
    {
        AudioSource WrongSoundInstance = Instantiate(WrongSoundPrefab);
        WrongSoundInstance.Play();
    }
}