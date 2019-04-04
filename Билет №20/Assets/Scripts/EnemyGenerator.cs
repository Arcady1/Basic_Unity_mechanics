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

            spawnPosition.x = Random.Range(-15f, 15f);
            spawnPosition.y = 0.5f;
            spawnPosition.z = Random.Range(-15f, 15f);

            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }        
    }
}
