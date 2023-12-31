using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Menu : MonoBehaviour
{
    public TextMeshProUGUI enemyHealth;
    public void Playgame()
    {
        SceneManager.LoadScene("CarScene");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit"); // quits the game when quit is click
    }

    public void info()
    {
        SceneManager.LoadScene("Info");
    }

    public void Back()
    {
        SceneManager.LoadScene("Menu");
    }

    public void nextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}


