using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScore : MonoBehaviour
{
    [SerializeField]
    private Text scoreTXT; 

    void Start()
    {
        scoreTXT.text = "Score: " + Score.score;
    }
}
