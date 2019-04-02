using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject MainMenu;
    public Score score;
    public ObstacleGenerator generatorO;
    public PointGenerator generatorP;

    public void StartGame()
    {
        MainMenu.SetActive(false);
        score.ResetScore();

        for(int i = 0; i < generatorO.transform.childCount; i++)
        {
            Destroy(generatorO.transform.GetChild(i).gameObject);
        }

        for (int j = 0; j < generatorP.transform.childCount; j++)
        {
            Destroy(generatorP.transform.GetChild(j).gameObject);
        }
    }

    public void GameOver()
    {
        MainMenu.SetActive(true);
    }
}
