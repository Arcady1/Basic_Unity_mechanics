using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject StartMenu;
    public GameObject generator;

    public void StartGame()
    {
        for (int i = 0; i < generator.transform.childCount; i++)
        {
            Destroy(generator.transform.GetChild(i).gameObject);
        }

        Score score = FindObjectOfType<Score>();
        score.ResetScore();

        StartMenu.SetActive(false);             

        SceneManager.LoadScene("Game");   
    }

    public void ShowResult()
    {
        StartMenu.SetActive(true);
    }
}
