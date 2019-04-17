using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenu : MonoBehaviour
{
    [SerializeField]
    private Text scoretxt;

    void Start()
    {
        scoretxt.text = "Score: " + Score.score;
    }
}
