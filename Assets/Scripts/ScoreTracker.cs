using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //<- "namespace"
//using UnityEngine.UI

public class ScoreTracker : MonoBehaviour
{
    //Refrencing the text UI making me able to change a text with codes
    public TMPro.TextMeshProUGUI scoreText;
    //Variable that counts how much score the player has
    public int totalScore;

    private void Update()
    {
        //Applies this text/string format on a certain TextMeshPro Text to show how much score the player has
        scoreText.text = string.Format("Score: {0}", totalScore);
    }
}
