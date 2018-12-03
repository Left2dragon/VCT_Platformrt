using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    public KeyGet keyGot;

    // Update is called once per frame
    void Update()
    {
        //Triggers the codes below if the variable has the value 1
        if (keyGot.keyGet == 1)
        {
            //Temporarely deletes the sprite
            Destroy(gameObject);
        }
    }
}
