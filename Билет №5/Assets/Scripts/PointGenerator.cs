using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGenerator : MonoBehaviour
{
    public GameObject point;
    private float StartTime = 0f;
    public float Interval = 3f;

    void Update()
    {
        if(Time.timeSinceLevelLoad >= StartTime + Interval)
        {
            GameObject pos = Instantiate(point, transform);

            StartTime += Interval;
        }
    }
}
