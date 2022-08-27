using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipplayer : MonoBehaviour
{
    bool faceRight = false;
    SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        flip();
    }
    void flip()
    {
        if (Input.GetKey(KeyCode.D) && faceRight == false)
        {
            sprite.flipX = false;
            faceRight = true;
        }
        else if (Input.GetKey(KeyCode.A) && faceRight == true)
        {
            sprite.flipX = true;
            faceRight = false;
        }
    }
}
