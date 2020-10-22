using System;

using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rgd_body;

    //Set speed of object movement
	public float verticalSpeed = 10f;
    public float horizontalSpeed = 10f;
    String buttonPressed;


    public void Start()
    {
        rgd_body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {



        if (Input.GetKey("w"))
        {
            buttonPressed = "w";
        }
        else if (Input.GetKey("s"))
        {
            buttonPressed = "s";
        }
        else if (Input.GetKey("d"))
        {
            buttonPressed = "d";
        }
        else if (Input.GetKey("a"))
        {
            buttonPressed = "a";
        }
        
    }

    public void FixedUpdate()
    {
        //All object movement is handled here

        if (buttonPressed == "w")
        {
            //assigns the x and y velocity of the object here
            rgd_body.velocity = new Vector2(0, verticalSpeed);
        }
        else if (buttonPressed == "s")
        {
            rgd_body.velocity = new Vector2(0, -verticalSpeed);
        }
        else if (buttonPressed == "d")
        {
            //an alternative to calculating movespeed horizntally
            //int logHorizontalSpeed = (int)Math.Log(horizontalSpeed);
            rgd_body.velocity = new Vector2(horizontalSpeed, 0);
        }
        else if (buttonPressed == "a")
        {
            rgd_body.velocity = new Vector2(-horizontalSpeed, 0);
        }
        else
        {
            rgd_body.velocity = new Vector2(0, 0);
        }
    }
}
