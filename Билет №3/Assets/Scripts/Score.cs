using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public int score;

    public void ScoresValue()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score: 0";
    }
}
