using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public float score;

    public void ScoreValue()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }
}
