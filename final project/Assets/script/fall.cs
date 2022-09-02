using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fall : MonoBehaviour
{
    float playerinput;
    Rigidbody2D rb;
   public float fale;
    public float fale2;
   
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
    }
     void FixedUpdate()
    {

        falll();
    }
    void falll()
    {
        rb.velocity = new Vector2(0f, -fale2);
        if (gameObject.tag == "ground")
        {
            transform.position = new Vector2(0f, fale2);
        }
    }
}
