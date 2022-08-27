using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemymove : MonoBehaviour
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
            if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
        if (collision.gameObject.tag == "wall")
        {
            Destroy(gameObject);
        }
      
    }

}
