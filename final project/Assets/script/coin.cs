using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class coin : MonoBehaviour
{
    
    public int score = 1;
    public int inc = 1;
    public Text text;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void scorer()
    {
        score += inc;
        text.text = score.ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            inc++;
            text.text = score.ToString();
        }
    }
}
