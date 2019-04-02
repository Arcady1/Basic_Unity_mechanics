using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public Obstacle obstacle;
    private float StartTime = 0f;
    public float Interval = 2f;

    public void Update()
    {
        if(Time.timeSinceLevelLoad >= StartTime + Interval)
        {
            Obstacle obst = Instantiate(obstacle, transform);

            Vector3 pos = obstacle.transform.position;
            pos.x = -5f;
            obstacle.transform.position = pos;

            StartTime += Interval;
            if (Interval >= 1f)
            {
                Interval -= 0.1f;
            }  
        }
    }
}
