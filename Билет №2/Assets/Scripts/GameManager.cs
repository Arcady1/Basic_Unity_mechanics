using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject ResultObj;

    public void StartGame()
    {
        ResultObj.SetActive(false);
    }

    public void ShowResult()
    {
        ResultObj.SetActive(true);
    }
}
