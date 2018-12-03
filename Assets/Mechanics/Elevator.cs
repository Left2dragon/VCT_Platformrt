using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rbody;
    public EnemyJumpTrigger JumpT;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (JumpT.Jump > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, moveSpeed);
        }
    }
}
