using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class eagle : MonoBehaviour
{

    Rigidbody2D rb;
    public Transform groundcheck;
    public LayerMask floor;
    public float speed;
    public float rad;
    
    public GameObject player;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Patrol();
    }
    void Patrol()
    {
        rb.velocity = new Vector2(speed, 0f);
        bool isGrounded = Physics2D.OverlapCircle(groundcheck.position, rad, floor) ;
        if(isGrounded == false)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            speed *= -1;
        }

    }
    
  
    
}