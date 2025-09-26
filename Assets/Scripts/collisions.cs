using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using TMPro;

public class collisions : MonoBehaviour
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


    //reset the ball to a random point in middle and also reseting to the baselineSpeed.
    void resetBall()
    {
        xPosition = 0f;
        yPosition = Random.Range(-2f,-2f);
        xSpeed = baseLineSpeed;
        ySpeed = baseLineSpeed;
    }

    // Start is called before the first frame update
    //giving baseline speed for reseting the ball speed everytime a point is scored.
    void Start()
    {
        baseLineSpeed = xSpeed;
        transform.position = new Vector3(xPosition, yPosition, 0f);
    }

    // Update is called once per frame
    //checking score for wich player has won and changing the text to reflect that.
    void Update()
    {
        
        xPosition += xSpeed * Time.deltaTime; //optimized
        yPosition += ySpeed * Time.deltaTime; 
        transform.position = new Vector3(xPosition, yPosition, 0f);
        if(leftScore >= 5) 
        {
            scoreBoard.text = "player one has won";
        }
        else if(rightScore >= 5) 
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
