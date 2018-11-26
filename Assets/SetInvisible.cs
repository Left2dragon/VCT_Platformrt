using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //disables the sprite renderer to make the sprite invisible
        GetComponent<SpriteRenderer>().enabled = false;
    }

}
