﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    //The source that checks if the player is standing on the ground or not
    public int touches;

    //When the player is on the ground the script will add a value
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touches++;
    }

    //When the player is no longer touching the ground anymore the script will subtract the variable
    private void OnTriggerExit2D(Collider2D collision)
    {
        touches--;
    }

}
