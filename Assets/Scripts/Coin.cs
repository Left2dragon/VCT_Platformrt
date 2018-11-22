using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;

    private void Update()
    {

    }

    //Function that triggers if the player is touching the sprite
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //Skapa en temporär variabel "controller" och sätt den till
            //resultatet av sökning efter objekt med taggen "GameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {

                //Skapa en temporär variabel "tracker" och sätt den till
                //resultatet av sökningen efter komponenten "ScoreTracker".
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += score;
                }
                else
                {
                    Debug.LogError("ScoreTracker saknas på GameController");
                }
            }
            else
            {
                Debug.LogError("GameController finns inte");
            }
            //After touching the sprite the sprite will disappear
            Destroy(gameObject);
        }
    }
}
