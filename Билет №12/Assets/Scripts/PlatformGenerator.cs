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
        Vector3 spawnPos = new Vector3();

        for (int i = 0; i < numberOfPlatform; i++)
        {
            spawnPos.x = Random.Range(-posX, posX);
            spawnPos.y += Random.Range(minY, maxY);

            Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        }
    }
}