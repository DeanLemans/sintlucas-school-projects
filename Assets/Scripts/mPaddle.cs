using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class mPaddle : MonoBehaviour
{
    //variables.
    public float speed = 5;
    public string leftOrRight;
    public float maxValue = 4f;

 
    /// <summary>
    /// using up and down keycodes to change position of paddle
    /// </summary>
    /// <param name="up"></param>
    /// <param name="down"></param>
    void paddleControl(KeyCode up, KeyCode down)
    {
        if (Input.GetKey(down) && transform.position.y < maxValue)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (Input.GetKey(up) && transform.position.y > -maxValue)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }

    /// <summary>
    /// Update is called once per frame
    /// checking wich control scheme should be used.
    /// </summary>
    void Update()
    {
        if (leftOrRight == "left")
        {
            paddleControl(KeyCode.W, KeyCode.S);
        }
        else if (leftOrRight == "right")
        {
            paddleControl(KeyCode.UpArrow, KeyCode.DownArrow);
        }
    }
}
