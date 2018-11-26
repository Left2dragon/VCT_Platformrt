using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    //Variable for movementspeed and turning
    public float moveSpeed = 2f;
    public bool isLeft = true;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        //Triggers "the void move" into false to make sure the sprite moves left in the start
        Move(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Move(true);
        }
    }

    //A void with a bool variable which triggers when the sprite collides onto a specific kind of barrier
    void Move(bool flip)
    {
        if (flip == true)
        {
            isLeft = !isLeft;
        }
        //moves right if the value is true
        if (isLeft == true)
        {
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(1, 1, 1);
        }
        //moves left if the value is not true
        else
        {
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    //Triggers if the sprite collides onto a specific kind of barrier 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "InvisibleWall")
        {
            //Turns the sprite everytime it collides
            Move(true);
        }
    }
}
