using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bossmove : MonoBehaviour
{
    Rigidbody2D RB;
    public float speed;
    public float speed2;


    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }


    void FixedUpdate()
    {
        move();
    }

    void move()
    {
        RB.velocity = new Vector2(speed, speed2);
    }
}
