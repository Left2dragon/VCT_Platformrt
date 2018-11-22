using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGet : MonoBehaviour
{
    public int keyTaken;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        keyTaken++;
        
    }
}
