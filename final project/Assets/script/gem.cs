using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class gem : MonoBehaviour
{
    public int score;
    public Text text1;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            
            score += 1;
            text1.text = score.ToString();

        }
    }
    
    
       
    
}