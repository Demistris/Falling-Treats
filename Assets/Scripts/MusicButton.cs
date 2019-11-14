using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class MusicButton : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    public GameObject Ball;
    public GameObject offPosition;
    public GameObject onPosition;

    private const string IS_MUSIC_ON = "IsMusicOn";
    public AudioMixerGroup musicGroup;

    private void Start()
    {
        if (PlayerPrefs.GetInt(IS_MUSIC_ON) == 1)
        {
            TurnOff();
        }
        else
        {
            TurnOn();
        }
    }

    private void TurnOff()
    {
        buttonText.text = "OFF";
        Ball.transform.position = offPosition.transform.position;
        buttonText.transform.position = onPosition.transform.position;
        musicGroup.audioMixer.SetFloat("musicVolume", -80f);
        PlayerPrefs.SetInt(IS_MUSIC_ON, 0);
    }

    private void TurnOn()
    {
        buttonText.text = "ON";
        Ball.transform.position = onPosition.transform.position;
        buttonText.transform.position = offPosition.transform.position;
        musicGroup.audioMixer.SetFloat("musicVolume", 0f);
        PlayerPrefs.SetInt(IS_MUSIC_ON, 1);
    }

    public void IsMusicOn()
    {
        if (PlayerPrefs.GetInt(IS_MUSIC_ON) == 1)
        {
            TurnOff();
            PlayerPrefs.SetInt(IS_MUSIC_ON, 0);
        }
        else
        {
            TurnOn();
            PlayerPrefs.SetInt(IS_MUSIC_ON, 1);
        }
    }
}
