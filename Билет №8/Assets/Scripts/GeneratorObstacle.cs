using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorObstacle : MonoBehaviour
{
    public Obstacle2 obstacle;
    private float StartTime = 0f;
    public float Interval = 2f;

    private void Start()
    {
        
    }

    IEnumerator Inst()
    {
        while(true)
        {
            yield return new WaitForSeconds(2f);


        }
    }

    public void Update()
    {
        if (Time.timeSinceLevelLoad >= StartTime + Interval)
        {
            Obstacle2 obst = Instantiate(obstacle, transform);

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
