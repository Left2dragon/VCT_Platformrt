using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    //Variable for its default speed
    public float moveSpeed = 5f;

    //Refrencing the sprites Rigidbody2D
    private Rigidbody2D rbody;
    //Refrencing the source of an another script
    public EnemyJumpTrigger JumpT;

    // Use this for initialization
    void Start()
    {
        //Sets the rbody variable on the sprites Rigidbody2D
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Only triggers if the player is standing ontop of the elevator
        //if the variable has a value greater than 0 the functions below triggers
        if (JumpT.Jump > 0)
        {
            //The sprite moves up if the variable is greater than 0
            rbody.velocity = new Vector2(rbody.velocity.x, moveSpeed);
        }

        //Triggers if the player exits the elevator so it goes down avoiding the elevator doing a weird jump
        //If the variable has the value less than or equals 0 the function below triggers
        if (JumpT.Jump <= 0)
        {
            //The sprite goes down if the value is less than or equals 0
            rbody.velocity = new Vector2(rbody.velocity.x, -moveSpeed);
        }
    }
}
