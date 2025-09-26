using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    //variables.
    public float speed = 7f;
    public string leftOrRight;
    public float maxValue = 4f;


    //controlling the paddle.
    void paddleControl(KeyCode up,KeyCode down) 
    {
        if (Input.GetKey(up) && transform.position.y < maxValue)
        {
            Debug.Log("fuck you");
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(down) && transform.position.y > -maxValue)
        {
            Debug.Log("fuck of dipshit");
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    // checking wich control scheme should be used.
    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);
        } 
        else if(leftOrRight == "right") 
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
