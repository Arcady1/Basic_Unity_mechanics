using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{    
    [SerializeField]
    private Text scoretext;
    private int score;

    public void ScoreUpdate()
    {
        score += 1;
        scoretext.text = "Score: " + score.ToString();
    }
}
