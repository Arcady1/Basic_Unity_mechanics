using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text scoreTxt;
    public static int score;

    public void ScoreValue()
    {
        score += 1;
        scoreTxt.text = "Score: " + score.ToString();
    }
}
