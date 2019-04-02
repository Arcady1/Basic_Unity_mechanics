using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int ScoreValue = 0;
    public Text txt;

    public void Update()
    {
        txt.text = "Score: " + ScoreValue;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Point")
        {
            ScoreValue += 1;
        }
    }
}
