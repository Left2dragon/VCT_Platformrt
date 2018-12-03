using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    //Default level to load(can be changed in unity)
    public string levelToLoad = "SampleScene";

    //Function that triggers if the player collide on the sprite
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Specifically only triggers if the ("tagged sprite") touches this sprite
        if(collision.tag == "Player")
        {
            //prints out a text in the console
            print("Complete");
            //Loads a scene(can be used to change a scene)
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
