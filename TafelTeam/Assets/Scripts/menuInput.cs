using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuInput : MonoBehaviour
{
    void Update()
    {
        // Check if the current scene is 'win'
        if (SceneManager.GetActiveScene().name == "Win")
        {
            // if spacebar = yes go to truthwin
            if (Input.GetKeyDown(KeyCode.Space))
            {
                truthwin();
            }
        }
        else
        {
            // if spacebar = yes go to mainMenu (only if not in 'win' scene)
            if (Input.GetKeyDown(KeyCode.Space))
            {
                ToMainMenu();
            }
        }
    }

    // ToMainScene
    public void ToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    // QuitGame
    public void QuitGame()
    {
        Application.Quit();
    }

    // ToMainMenu
    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // ToAboutUs
    public void ToAboutUs()
    {
        SceneManager.LoadScene("AboutUs");
    }

    public void stupidFix()
    {
        SceneManager.LoadScene("DeanPauseMenu");
    }

    public void truthwin()
    {
        SceneManager.LoadScene("truthwin");
    }
}
