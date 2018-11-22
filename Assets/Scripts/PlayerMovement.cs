using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Sets a scroll on a variable
    [Range(0,20f)]
    //Variable for how fast the player can move
    public float moveSpeed;
    //Variable for how high the player can jump
    public float jumpHeight;

    public GroundCheck groundCheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the player able to move left and right with A/LeftArrow and D/RightArrow
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed, 
            rbody.velocity.y);

        //Makes the player able to jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Checks if the player is standing on the ground or not
            if(groundCheck.touches > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }

}
