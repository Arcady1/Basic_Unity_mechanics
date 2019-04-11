using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public Enemy Enemy;
    public float StartTime = 0f;
    public float Interval = 2.0f;
    public float Timer = 0f;

    private void Update()
    {
        if (Time.timeSinceLevelLoad > Timer)
        {
            Timer += 1;

            if (Timer > StartTime + Interval)
            {
                StartTime += Interval;

                Enemy enemy = Instantiate(Enemy, transform);
            }
        }        
    }
}
