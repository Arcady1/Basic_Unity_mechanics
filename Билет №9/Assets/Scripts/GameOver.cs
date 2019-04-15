using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    private Text textComponent;

    private void Start()
    {
        textComponent.text = "Score: " + Score.score;
    }
}
