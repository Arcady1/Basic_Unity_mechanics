using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public float Interval = 0.5f;
    private float StartTime = 0f;
    public Obstacle ObstaclePrefab;

    void Update()
    {
        if (Time.time >= StartTime + Interval)
        {
            Obstacle obstacle = Instantiate(ObstaclePrefab, transform);

            if (Random.Range(0,2) == 1)
            {
                Vector3 pos = obstacle.transform.position;
                pos.x *= -1;
                obstacle.transform.position = pos;
            }

            StartTime += Interval;

            if(Interval > 1f)
            {
                Interval -= 0.1f;
            }

        }
    }
}
