using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //Variable for movementspeed and turning
    public float moveSpeed = 2f;
    //Variable that makes sure that the enemy is moving left when the game starts
    public bool isLeft = true;

    //Refrencing the sprites rigidbody2D
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //Sets the rbody variable to the sprite's Rigidbody2D
        rbody = GetComponent<Rigidbody2D>();
        //Triggers "the void move" into false to make sure the sprite moves left in the start
        Move(false);
    }

    //A void with a bool variable which triggers when the sprite collides onto a specific kind of barrier
    void Move(bool flip)
    {
        if (flip == true)
        {
            //Flips the enenmy
            isLeft = !isLeft;
        }
        //Triggers the codes below if the value is true
        if (isLeft == true)
        {
            //Makes the sprite move left
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            //flips the sprite to face left
            transform.localScale = new Vector3(1, 1, 1);
        }
        //Triggers the codes below if the value is not true
        else
        {
            //Makes the sprite move right
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            //flips the sprite to face right
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    //Triggers if the sprite collides onto a specific kind of barrier 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Specifically only triggers if the enemy collides on a collider
        if(collision.tag == "InvisibleWall")
        {
            //Turns the sprite everytime it collides
            Move(true);
        }
    }
}
