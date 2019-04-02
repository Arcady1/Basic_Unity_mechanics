using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator2 : MonoBehaviour
{
    private float StartTime;
    public Obstacle1 obst2;

    void Update()
    {
        if(Time.timeSinceLevelLoad >= StartTime + Random.Range(1,5))
        {
            StartTime += Random.Range(1, 5);

            Obstacle1 obst = Instantiate(obst2, transform);
        }
    }
}
