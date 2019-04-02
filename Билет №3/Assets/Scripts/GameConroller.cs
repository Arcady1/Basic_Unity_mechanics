using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameConroller : MonoBehaviour
{
    public GameObject MainMenu;
    public Score score;
    public ObstacleGenerator generator;

    public void StartGame()
    {
        MainMenu.SetActive(false);
        score.ResetScore();

        for(int i=0; i< generator.transform.childCount; i++)
        {
            Destroy(generator.transform.GetChild(i).gameObject);
        }
    }

    public void GameOver()
    {
        MainMenu.SetActive(true);
    }
}
