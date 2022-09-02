using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyplatform : MonoBehaviour
{
    public AudioSource src;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
