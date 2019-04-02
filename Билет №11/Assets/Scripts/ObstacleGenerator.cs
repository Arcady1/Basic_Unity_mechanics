using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public Obstacle1 obstacle1;
    private float StartTime = 0f;

    void Update()
    {
        if(Time.timeSinceLevelLoad >= StartTime + Random.Range(1, 5))
        {
            StartTime += Random.Range(1, 5);

            Obstacle1 obst1 = Instantiate(obstacle1, transform);
        }
    }
}
