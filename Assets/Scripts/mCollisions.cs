using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class mCollisions : MonoBehaviour
{
    //variables
    public float xPosition = -2f;
    public float yPosition = -3f;
    public float xSpeed = 5f;
    public float ySpeed = 5f;
    public TMP_Text scoreBoard;
    public int leftScore = 0;
    public int rightScore = 0;
    public int topScore = 5;
    private float baseLineSpeed;


    //resetball is reseting the ball everytime it touches the left or right balls. and also giving it a random range of where the ball can spawn
    void resetBall()
    {
        xPosition = 0f;
        yPosition = Random.Range(-2f, -2f);
        xSpeed = baseLineSpeed;
        ySpeed = baseLineSpeed;
    }

    // Start is called before the first frame update
    //setting where the ball should spawn and also reseting to the baselineSpeed.
    void Start()
    {
        baseLineSpeed = xSpeed;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    //checking score for wich player has won and changing the text to reflect that.
    void Update()
    {

        xPosition += xSpeed * Time.deltaTime;
        yPosition += ySpeed * Time.deltaTime;
        transform.position = new Vector3(xPosition, yPosition, 0f);
        if (leftScore >= 5)
        {
            scoreBoard.text = "player one has won";
        }
        else if (rightScore >= 5)
        {
            scoreBoard.text = "player two has won";
        }
    }


    // updating the points and also increasing the speed everytime the ball touches one of the paddles.
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("now you bounce");
        if (collision.gameObject.CompareTag("horizontalWall"))
        {
            Debug.Log("fucking dipshit, thats my feet!");
            ySpeed = ySpeed * -1f;
        }
        else if (collision.gameObject.CompareTag("verticalL"))
        {
            resetBall();
            rightScore++;
            scoreBoard.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("verticalR"))
        {
            resetBall();
            leftScore++;
            scoreBoard.text = leftScore + " - " + rightScore;
        }
        else if (collision.gameObject.CompareTag("Player"))
        {
            xSpeed = xSpeed * -1.2f;
        }
    }


}