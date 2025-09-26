using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuGo : MonoBehaviour
{
    
    //using the scenemanager to load differnt scenes via the keypad123 or the alpha123.
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1) || Input.GetKey(KeyCode.Keypad1))  
        {
            SceneManager.LoadScene("Normal");
        }
        else if (Input.GetKey(KeyCode.Alpha2) || Input.GetKey(KeyCode.Keypad2)) 
        {
            SceneManager.LoadScene("Bot");
        }
        else if (Input.GetKey(KeyCode.Alpha3) || Input.GetKey(KeyCode.Keypad3))
        {
            SceneManager.LoadScene("Mystery");
        }
    }
}
