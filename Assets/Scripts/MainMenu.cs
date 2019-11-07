using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameMenu gameMenu;

    private Animator FadeOut;

    void Start()
    {
        FadeOut = GetComponent<Animator>();
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