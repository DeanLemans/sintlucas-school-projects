using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bPaddle : MonoBehaviour
{
    //variables.
    public float speed = 7f;
    public string leftOrRight;
    public float maxValue = 7f;
    public float botSpeed = 4f;
    public float botYPosition = 0f;
    public float botXPosition;
    public GameObject square;
    public GameObject paddleRight;


    // Update is called once per frame
    void Update()
    {
        // calling the method botpaddle
            Botpaddle();
    }

    //making the paddle follow the gameobject square, bot.
    void Botpaddle()
    {
        transform.position = new Vector3(botXPosition, botYPosition, 0f);
        
        if (square.transform.position.y > paddleRight.transform.position.y && transform.position.y < maxValue)
        {
            botYPosition += botSpeed * Time.deltaTime;
        }
        
        else if (square.transform.position.y < paddleRight.transform.position.y && transform.position.y > -maxValue)
        {
            botYPosition += -botSpeed * Time.deltaTime;
        }
    }
}
