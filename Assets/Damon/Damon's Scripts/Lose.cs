using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    public GameObject deathMenu;
    public bool isAlive;

    
    void Update()
    {
        //checks if you're alive
        if (!isAlive)
        {
            Time.timeScale = 0f;
            deathMenu.SetActive(true);
        }
    }
    //goes to main menu
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Title Scene");
    }
    //closes game
    public void QuitGame()
    {
        Application.Quit();
    }
}