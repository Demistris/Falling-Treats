using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class EndGameMenu : MonoBehaviour
{
    public PlayerStats playerStats;
    public GameObject TreatsThrower;
    public GameObject EndGameUI;

    public bool IsGameEnd = false;

    public void EndOfGame()
    {
        EndGameUI.SetActive(true);
        TreatsThrower.SetActive(false);
        IsGameEnd = true;
    }

    public void NewGameButton()
    {
        IsGameEnd = false;
        EndGameUI.SetActive(false);
        TreatsThrower.SetActive(true);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
