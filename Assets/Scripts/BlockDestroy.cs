using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroy : MonoBehaviour
{
    KeyGet st;
    // Update is called once per frame
    void Update()
    {
        if(st.keyTaken == 1)
        {
            Destroy(gameObject);
        }
    }
}
