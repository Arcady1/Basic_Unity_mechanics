using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;

    public void ScoreValue()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }
}
