using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuScore : MonoBehaviour
{
    [SerializeField]
    private Text scoreMtext;

    private void Start()
    {
        scoreMtext.text = "Score: " + Score.score;
    }
}
