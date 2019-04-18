using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
    [SerializeField]
    private Text scoretext;
    public static int score;

    public void ScoreValue()
    {
        score += 1;
        scoretext.text = "Score: " + score.ToString();
    }
}
