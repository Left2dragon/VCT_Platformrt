using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyVerticalMovement : MonoBehaviour
{
    //Variable for how high the enemy can jump
    public int jumpHeight = 8;

    private Rigidbody2D rbody;

    //Refrencing the scripts
    public EnemyJumpTrigger JumpT;
    public GroundCheck ground;

    // Use this for initialization
    void Start()
    {
        //Sets the rbody variable to the Player's Rigidbody2D
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Triggers if the player jumps above the sprite("JumpT") and limits how many times it can jump("ground")
        if (JumpT.Jump > 0 && ground.touches > 0)
        {
            //makes the enemy jump
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }
    }
}
