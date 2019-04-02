using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGenerator : MonoBehaviour
{
    private float StartTime = 0f;
    public float Interval = 2f;
    public GameObject Point;

    public void Update()
    {
        if (Time.time >= StartTime + Interval)
        {
            GameObject pos = Instantiate(Point, transform);

            StartTime += Interval;            
        }
    }
}

