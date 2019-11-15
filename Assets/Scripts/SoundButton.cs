using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Audio;

public class SoundButton : MonoBehaviour
{
    public TextMeshProUGUI buttonText;
    public GameObject Ball;
    public GameObject offPosition;
    public GameObject onPosition;

    private const string IS_SOUND_ON = "IsSoundOn";
    public AudioMixerGroup musicGroup;

    private bool isStartOver;

    private void Start()
    {
        if (PlayerPrefs.GetInt(IS_SOUND_ON) == 1)
        {
            buttonText.text = "ON";
            Ball.transform.position = onPosition.transform.position;
            buttonText.transform.position = offPosition.transform.position;
        }
        else
        {
            buttonText.text = "OFF";
            Ball.transform.position = offPosition.transform.position;
            buttonText.transform.position = onPosition.transform.position;
        }

        isStartOver = true;
    }

    private void TurnOff()
    {
        buttonText.text = "OFF";
        Ball.transform.position = offPosition.transform.position;
        buttonText.transform.position = onPosition.transform.position;
        musicGroup.audioMixer.SetFloat("soundVolume", -80f);
    }

    private void TurnOn()
    {
        buttonText.text = "ON";
        Ball.transform.position = onPosition.transform.position;
        buttonText.transform.position = offPosition.transform.position;
        musicGroup.audioMixer.SetFloat("soundVolume", 0f);
    }

    public void IsSoundOn()
    {
        if (isStartOver == false)
        {
            return;
        }

        if (PlayerPrefs.GetInt(IS_SOUND_ON) == 1)
        {
            TurnOff();
            PlayerPrefs.SetInt(IS_SOUND_ON, 0);
        }
        else
        {
            TurnOn();
            PlayerPrefs.SetInt(IS_SOUND_ON, 1);
        }
    }
}
