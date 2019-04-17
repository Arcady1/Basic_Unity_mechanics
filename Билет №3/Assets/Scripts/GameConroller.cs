﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameConroller : MonoBehaviour
{
    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        Score.score = 0;
    }

    public void StopGame()
    {
        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
