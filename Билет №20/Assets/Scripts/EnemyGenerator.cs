using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;
    private float StartTime = 0;
    public float Interval = 2f;

    private void Update()
    {
        if (Time.timeSinceLevelLoad > StartTime + Interval)
        {
            StartTime += Interval;

            Vector3 spawnPosition = new Vector3();

            if(Random.Range(0, 2) == 0)
            {
                spawnPosition.x = 0f;
                spawnPosition.y = 0.5f;
                spawnPosition.z = -10f;
                Instantiate(enemy, spawnPosition, Quaternion.identity);
            }
            if (Random.Range(0, 2) == 1)
            {
                spawnPosition.x = 0f;
                spawnPosition.y = 0.5f;
                spawnPosition.z = 10f;
                Instantiate(enemy, spawnPosition, Quaternion.identity);
            }


            
        }        
    }
}
