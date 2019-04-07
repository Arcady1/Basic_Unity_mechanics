using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstacle;
    private float StartTime = 0f;
    public float Interval = 1f;

    void Update()
    {
        if(Time.timeSinceLevelLoad > StartTime + Interval)
        {
            StartTime += Interval;

            Vector3 spawnPosition = new Vector3();
            spawnPosition.x = Random.Range(3.4f, 5.4f);
            spawnPosition.y = Random.Range(3.4f, -3.4f);

            Instantiate(obstacle, spawnPosition, Quaternion.identity);
        }
    }
}
