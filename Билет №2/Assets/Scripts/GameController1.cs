using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController1 : MonoBehaviour
{
    public GameObject DeathScreen;
    public GameObject generator;

    public void StartGame()
    {
        DeathScreen.SetActive(false);

        for (int i = 0; i < generator.transform.childCount; i++)
        {
            Destroy(generator.transform.GetChild(i).gameObject);
        }

        PlayerSettings player = FindObjectOfType<PlayerSettings>();
        player.JumpForce = 27.2f;

        Score score = FindObjectOfType<Score>();
        score.ResetScore();
    }

    public void StopGame()
    {
        DeathScreen.SetActive(true);
    }
}
