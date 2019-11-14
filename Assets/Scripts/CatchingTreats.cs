using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchingTreats : MonoBehaviour
{
    public PlayerStats playerStats;

    public AudioSource CorrectSoundPrefab;
    public AudioSource WrongSoundPrefab;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Treat")
        {
            PlayCorrectSound();
            collision.gameObject.SetActive(false);
            playerStats.isTreatCaught = true;
        }

        if (collision.gameObject.tag == "Diamond")
        {
            PlayCorrectSound();
            collision.gameObject.SetActive(false);
            playerStats.isDiamondCaught = true;
        }

        if (collision.gameObject.tag == "Trash")
        {
            PlayWrongSound();
            collision.gameObject.SetActive(false);
            playerStats.isTrashCaught = true;
        }
    }

    public void PlayCorrectSound()
    {
        AudioSource CorrectSoundInstance = Instantiate(CorrectSoundPrefab);
        CorrectSoundInstance.Play();
    }

    public void PlayWrongSound()
    {
        AudioSource WrongSoundInstance = Instantiate(WrongSoundPrefab);
        WrongSoundInstance.Play();
    }
}
