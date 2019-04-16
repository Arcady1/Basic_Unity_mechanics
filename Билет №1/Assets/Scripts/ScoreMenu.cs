using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenu : MonoBehaviour
{
    [SerializeField]
    private Text menuScore;

    private void Start()
    {
        menuScore.text = "Score: " + Score.score;
    }
}
