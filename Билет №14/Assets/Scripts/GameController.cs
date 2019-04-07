using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject obstacleGenerator;

    public void StartGame()
    {
        MainMenu.SetActive(false);

        Vector3 spawnPos = new Vector3();
        spawnPos.x = 5f;
        spawnPos.y = 0f;
        Instantiate(obstacleGenerator, spawnPos, Quaternion.identity);

        Score score = FindObjectOfType<Score>();
        score.ResetScore();
    }

    public void StopGame()
    {
        MainMenu.SetActive(true);

        ObstacleGenerator generator = FindObjectOfType<ObstacleGenerator>();
        Destroy(generator);
        
        Player player = FindObjectOfType<Player>();
        player.MovingSpeed = 0f;
    }    
}
