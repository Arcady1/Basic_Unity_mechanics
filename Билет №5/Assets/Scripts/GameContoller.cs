using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameContoller : MonoBehaviour
{
    public void Start()
    {       
        DontDestroyOnLoad(gameObject);
    }

    public void StartGame()
    {
        
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }

    public void RestartGame()
    {

        SceneManager.LoadScene(0, LoadSceneMode.Single);
    }
}
