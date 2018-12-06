using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGet : MonoBehaviour
{
    public int keyGet;

    //This function will unlock/destroy a sprite with the BlockDestroy script
    //Triggers if a sprite enters the collider
    private void OnCollisionEnter2D(Collision2D collision)
    {
        ////Specifically only triggers if the player collides on the key
        if (collision.gameObject.tag == "Player")
        {
            //adds a value
            keyGet++;
            //Destoys the sprite
            Destroy(gameObject);
        }
    }

}
