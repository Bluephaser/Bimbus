/*
 PlayerController.cs
 By: Liam Binford
 Last Edited: 1/10/20
 Description: Script to allow the play to control their character with slidy, physics-based movement
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed = 5;
    Rigidbody2D myRB;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(0, 0);
        //check for forward and backward movement
        if(Input.GetAxis("Vertical") > 0.1)
        {
            movement += new Vector2(0, 1).normalized;
        }
        if(Input.GetAxis("Vertical") < -0.1)
        {
            movement -= new Vector2(0, 1).normalized;
        }
        //check for left and right movement
        if (Input.GetAxis("Horizontal") > 0.1)
        {
            movement += new Vector2(1, 0);
        }
        if (Input.GetAxis("Horizontal") < -0.1)
        {
            movement -= new Vector2(1, 0);
        }

        //add force based on the prior inputs
        myRB.AddForce(movement.normalized * Time.deltaTime * speed);
    }
}
