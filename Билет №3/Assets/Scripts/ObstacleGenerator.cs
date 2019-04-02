using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    public float Interval = 0.1f;

    private float startTime = 0f;

    public Obstacle ObstaclePrefab;

    void Update()
    {
        if (Time.time >= startTime + Interval)
        {
            Obstacle obstacle = Instantiate(ObstaclePrefab, transform);            

            if(Random.Range(0,2) == 1)
            {
                Vector3 pos = obstacle.transform.position;
                pos.y *= -1;

                obstacle.transform.position = pos;
            }

            startTime += Interval;
                        
            if (Interval > 1f)
            {
                Interval -= 0.1f ;
            }
        }
    }
}
