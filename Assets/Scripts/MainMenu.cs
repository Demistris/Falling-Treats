using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour
{
    public GameMenu gameMenu;

    private Animator FadeOut;

    private const string IS_MUSIC_ON = "IsMusicOn";
    public AudioMixerGroup musicGroup;

    private const string IS_SOUND_ON = "IsSoundOn";
    public AudioMixerGroup soundGroup;

    void Start()
    {
        FadeOut = GetComponent<Animator>();

        if (PlayerPrefs.GetInt(IS_MUSIC_ON) == 1)
        {
            musicGroup.audioMixer.SetFloat("musicVolume", 0f);
        }
        else
        {
            musicGroup.audioMixer.SetFloat("musicVolume", -80f);
        }

        if (PlayerPrefs.GetInt(IS_SOUND_ON) == 1)
        {
            soundGroup.audioMixer.SetFloat("soundVolume", 0f);
        }
        else
        {
            soundGroup.audioMixer.SetFloat("soundVolume", -80f);
        }
    }

    public void StartButton()
    {
        FadeOut.Play("FadeOut");
        gameMenu.IsMainMenu = false;
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(.5f);
        gameObject.SetActive(false);
    }
}