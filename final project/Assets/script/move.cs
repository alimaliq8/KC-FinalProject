using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class move : MonoBehaviour
{
    public Rigidbody2D RB;

    float playerinput;
    public float jumpforce;
    public int speed;

    public int health = 100;

    public string hero;

    private bool isgrounded;
    public Transform feetpos;
    public float checkradius;
    public LayerMask whatisground;

    public AudioSource src;

    public int score;
    public Text text;
 
    public Text text2;

    // Start is called before the first frame update
    void Start()
    {


        RB = GetComponent<Rigidbody2D>();
        
    }



    void FixedUpdate()
    {
        playerinput = Input.GetAxisRaw("Horizontal");
        RB.velocity = new Vector2(playerinput * speed, RB.velocity.y);



    }

    

   
   
    void Update()
    {
        isgrounded = Physics2D.OverlapCircle(feetpos.position, checkradius, whatisground);

        if (isgrounded == true && Input.GetKeyDown(KeyCode.W))
        {

            RB.velocity = Vector2.up * jumpforce;
        }


    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            src.Play();
            health -= 20;
            text2.text = health.ToString();

            if (health == 0)
            {
                src.Play();
                SceneManager.LoadScene(0);
            }
        }
        if (collision.gameObject.tag == "Enemya")
        {
            src.Play();
            health -= 20;
            text2.text = health.ToString();

            if (health == 0)
            {
                src.Play();
                SceneManager.LoadScene(2);
            }
        }
        if (collision.gameObject.tag == "frog")
        {
            src.Play();
            health -= 100;
            text2.text = health.ToString();
            if (health <= 0)
            {
                src.Play();
                SceneManager.LoadScene(4);
            }

        }
        if (collision.gameObject.tag == "walle")
        {
            SceneManager.LoadScene(2);
        }
        if (collision.gameObject.tag == "Enemyy")
        {
            src.Play();
            health -= 20;
            text2.text = health.ToString();

            if (health == 0)
            {
                src.Play();
                SceneManager.LoadScene(4);
            }
        }


    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin")
        {
            Destroy(collision.gameObject);
            score ++;
           
            text.text = score.ToString();
            if (collision.tag == "coine")
            {
                Destroy(collision.gameObject);
                score ++;
                
                text.text = score.ToString();
            }

            
        }
       if (collision.tag == "door")
        {
            SceneManager.LoadScene(4);
                

            
        }
       
    }



}
