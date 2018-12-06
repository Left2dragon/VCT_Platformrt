using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpTrigger : MonoBehaviour
{
    //Variable to check when the sprite will jump
    public int Jump;

    //Triggers if a sprite enters the collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Specifically only triggers if a sprite has a "player" tag
        if (collision.gameObject.tag == "Player")
        {
            //adds a value making the enemy jump
            Jump++;
        }

    }

    //Triggers if the sprite exits the collider
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Specifically only triggers if a sprite has a "player" tag
        if (collision.gameObject.tag == "Player")
        {
            //removes a value which stops the enemy's jump
            Jump--;
        }
    }
}
