using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class enemy2 : MonoBehaviour
{ 
    Rigidbody2D rb;
    public Transform groundcheck;
public LayerMask floor;
public float speed;
public float rad;

public GameObject player;
public AudioSource src;
 public Transform killE;
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
    bool isGrounded = Physics2D.OverlapCircle(groundcheck.position, rad, floor);
    if (isGrounded == false)
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        speed *= -1;
    }
      
}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "frog")
        {
            src.Play();
            Destroy(gameObject);
        }
    }
}