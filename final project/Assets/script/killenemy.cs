using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killenemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        }
    }







}
