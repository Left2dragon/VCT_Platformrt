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
//The OnCollisionEnter2D Can be used to other objects such as when entering a door you will switch scene and same when you reach your goal.
//(collision.gameobject.tag == "tag") makes sure that the function above only triggers if a sprite with a specific tag enters it