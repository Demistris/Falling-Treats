using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameMenu : MonoBehaviour
{
    public PlayerStats playerStats;
    public GameObject TreatsThrower;
    public GameObject EndGameUI;

    public EndGameMenu EndGameMenu;

    public bool IsMainMenu = true;
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
        IsMainMenu = true;
        EndGameUI.SetActive(false);
        TreatsThrower.SetActive(true);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
