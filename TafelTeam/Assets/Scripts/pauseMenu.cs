using UnityEngine;
using UnityEngine.UI;

public class pauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public Button PauseButton;
    private bool isPaused = false;

    void Update(){
        // if Q key is pressed, toggle pause state
        if (Input.GetKeyDown(KeyCode.Q))
        {
            TogglePause();
        }
    }

    public void TogglePause(){
        if (isPaused)
        {
            Continue();
        }
        else
        {
            Pause();
        }
    }

    public void Pause(){
        PausePanel.SetActive(true);
        PauseButton.gameObject.SetActive(false); // Turn off the Pause button
        Time.timeScale = 0;
        isPaused = true;
    }

    // set pause panel inactive
    public void Continue(){
        PausePanel.SetActive(false);
        PauseButton.gameObject.SetActive(true); // Turn on the Pause button
        Time.timeScale = 1;
        isPaused = false;
    }
}