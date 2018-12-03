using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    //Function that triggers if the player collide on the sprite
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Specifically only triggers if a sprite with the "Player" tag collides on this sprite
        if(collision.gameObject.tag == "Player")
        {
            //Reloads the current scene
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }
}
