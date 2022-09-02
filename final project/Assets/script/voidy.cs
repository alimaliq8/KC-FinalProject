using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class voidy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(4);
        }
        
        {
            if (collision.gameObject.tag == "frog")
            {
                Destroy(gameObject);
            }
        }
    }
}
