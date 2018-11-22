using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HurtObject : MonoBehaviour
{
    //Function that triggers if the player is touching the sprite
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Restarts the level
        if(collision.gameObject.tag == "Player")
        {
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }
}
