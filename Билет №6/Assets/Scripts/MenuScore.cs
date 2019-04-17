using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScore : MonoBehaviour
{
    [SerializeField]
    private Text Scoretxt;

    private void Start()
    {
        Scoretxt.text = "Score: " + Score.score;
    }
}
