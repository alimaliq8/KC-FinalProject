using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class coin : MonoBehaviour
{
    public int score;
    public Text text;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "coin")
        {
            score += 1;
            text.text = score.ToString();
            Destroy(collision.gameObject);
        }
        if (score == 10)
        {
            SceneManager.LoadScene(1);
        }
    }
}
