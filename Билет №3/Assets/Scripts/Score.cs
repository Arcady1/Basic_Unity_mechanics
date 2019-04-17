using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;
    public static int score;

    public void ScoresValue()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }
}
