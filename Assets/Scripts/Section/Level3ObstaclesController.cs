using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * This script is used to control the movement of the Level3 ball, 
 * mainly by making the ball move back and forth in the vertical direction
 */
public class Level3ObstaclesController : MonoBehaviour
{
    //Define a speed for the ball
    public float speed;
    //Get the y-coordinate of the ball
    private float y;
    //Gets the time the ball changes direction
    private float NowTime;

    // Start is called before the first frame update
    void Start()
    {
        speed = 8f;
        y = transform.position.y;
        NowTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, speed * Time.deltaTime));
        //Make the ball change direction after the y-coordinate transformation of 4
        float NowY = transform.position.y - y;
        //To fix the bug where the ball gets stuck on the boundary,
        //set the time so that speed changes less frequently
        if ((NowY > 4 || NowY < 0) && (Time.time - NowTime)>0.3)
        {
            speed = -speed;
            NowTime = Time.time;
        }
    }
}
