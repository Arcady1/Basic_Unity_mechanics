using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    public void scoreValue()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }
}
