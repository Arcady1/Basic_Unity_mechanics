using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public Obstacle obsatcle;
    public float Interval = 1.5f;
    private float StartTime = 0f;

    void Update()
    {
        if(Time.timeSinceLevelLoad > StartTime + Interval)
        {
            StartTime += Interval;

            Obstacle obst = Instantiate(obsatcle, transform);
        }
    }
}
