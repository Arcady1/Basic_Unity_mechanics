using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField]
    private Text scoretxt;
    public static int score;

    public void ScoreValue()
    {
        score += 1;
        scoretxt.text = "Score: " + score.ToString();
    }
}
