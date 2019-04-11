using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private float score = 0f;

    public void ScoreValue()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }

    public void ResetScore()
    {
        score = 0f;
        scoreText.text = "Score: ";
    }
}
