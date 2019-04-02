using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    public bool isDead = false;

    public void ScoreValue()
    {     
        
            score += 1;
            scoreText.text = "Score: " + score.ToString();  
    }
}
