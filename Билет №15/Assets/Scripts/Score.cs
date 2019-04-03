using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreTxt;
    private int score = 0;

    public void ScoreValue()
    {
        score += 1;
        scoreTxt.text = "Score: " + score.ToString();
    }
}
