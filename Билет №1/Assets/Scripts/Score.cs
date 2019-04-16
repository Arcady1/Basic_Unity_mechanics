using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score;
    public Text scoreText;

    public void ScoreValue()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }
}

