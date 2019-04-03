using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    public int numberOfPlatform;
    public float posX = 3.5f;
    public float minY = 3f;
    public float maxY = 5f;

    private void Start()
    {
        Vector3 spawnPosition = new Vector3();

        for (int i = 0; i < numberOfPlatform; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-posX, posX);
            Instantiate(platformPrefab,spawnPosition, Quaternion.identity);
        }
    }
}