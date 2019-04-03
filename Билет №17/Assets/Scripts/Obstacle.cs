using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject obstacle;
    private float StartTime = 0f;
    public float Interval = 1.5f;
    Vector3 movement;

    private void Update()
    {
        if (Time.timeSinceLevelLoad > StartTime + Interval)
        {
            StartTime += Interval;

            Vector3 spawnPosition = new Vector3();

            if(spawnPosition.y == 0)
            {
                spawnPosition.y = -2.5f;
                spawnPosition.x = 5f;

            }

            if(Random.Range(0, 2) == 0)
            {
                spawnPosition.x = 5f;
                spawnPosition.y = -3.6f;
                //Instantiate(obstacle, spawnPosition, Quaternion.identity);
            }
            if(Random.Range(0, 2) == 1)
            {
                spawnPosition.x = 5f;
                spawnPosition.y = -2.5f;
                //Instantiate(obstacle, spawnPosition, Quaternion.identity);
            }

            Instantiate(obstacle, spawnPosition, Quaternion.identity);
        }
    }
}
