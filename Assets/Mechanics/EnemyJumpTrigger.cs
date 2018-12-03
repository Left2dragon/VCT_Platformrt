using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyJumpTrigger : MonoBehaviour
{
    //Variable to check when the sprite will jump
    public int Jump;

    //Triggers if a sprite enter the collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Specifically only triggers if a sprite has a "player" tag
        if(collision.gameObject.tag == "Player")
        {
            Jump++;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Jump--;
        }
    }
}
