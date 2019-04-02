using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int scoreValue = 0;
    public Text txt;

    void Update()
    {
        txt.text = "Score: " + scoreValue;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "CheckPoint")
        {
            scoreValue += 1;            
        }
    }
}

