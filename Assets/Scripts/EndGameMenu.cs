using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameMenu : MonoBehaviour
{
    private Animator FadeIn;

    void Start()
    {
        FadeIn = GetComponent<Animator>();
    }

    public void EndGame()
    {
        FadeIn.Play("FadeIn");
    }
}
