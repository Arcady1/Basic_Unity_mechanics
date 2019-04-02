using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public Obsatcle obstacle;
    private float StartTime = 0f;
    public float Interval = 3f;

    void Update()
    {
        if(Time.timeSinceLevelLoad >= StartTime + Interval)
        {
            Obsatcle obastacle =  Instantiate(obstacle, transform); 
            
            Vector3 pos = obstacle.transform.position;
            pos.x = Random.Range(1.86f, -1.86f);
            obstacle.transform.position = pos;

            StartTime += Interval;                   
        }
    }
}
