using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour
{
    //Default level to load(can be changed in unity)
    public string levelToLoad = "SampleScene";

    //If the sprite gets touched by the player the Scene will load to its set scene
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Specifically only triggers if the ("tagged sprite") touches this sprite
        if(collision.tag == "Player")
        {
            print("Complete");
            SceneManager.LoadScene(levelToLoad);
        }
    }
}
