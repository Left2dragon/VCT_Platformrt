using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    //Sets a scroll on a variable between value 0 and 20
    [Range(0, 20f)]
    //Variable for how fast the player can run
    public float moveSpeed;
    //Variable for how high the player can jump
    public float jumpHeight;

    //Refrencing the GroundCheck script into this script
    public GroundCheck groundCheck;

    //Refrencing the players Rigidbody2D making it able to move with this script
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //Sets the rbody variable to the Player's Rigidbody2D
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the player able to move left and right with A/LeftArrow and D/RightArrow
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed,
            rbody.velocity.y);

        //When Spacebar is pushed down the function below activates
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Checks if the player is standing on the ground or not
            if (groundCheck.touches > 0)
            {
                //Makes the player able to jump
                rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
            }
        }
    }

}
