using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;
    private float StartTime = 0f;
    public float Interval = 2.5f;

    private void Update()
    {
        if(Time.timeSinceLevelLoad > StartTime + Interval)
        {
            StartTime += Interval;

            Vector3 spawnPos = new Vector3();
            if(Random.Range(0,3) == 0)
            {
                spawnPos.x = Random.Range(-100f, -65f);
                spawnPos.y = 0.5f;
                spawnPos.z = -1.4f;
                Instantiate(enemy, spawnPos, Quaternion.identity);
            }
            if (Random.Range(0, 3) == 1)
            {
                spawnPos.x = Random.Range(-100f, -50f);
                spawnPos.y = 0.5f;
                spawnPos.z = 0f;
                Instantiate(enemy, spawnPos, Quaternion.identity);
            }
            if (Random.Range(0, 3) == 2)
            {
                spawnPos.x = Random.Range(-100f, -75f);
                spawnPos.y = 0.5f;
                spawnPos.z = 1.4f;
                Instantiate(enemy, spawnPos, Quaternion.identity);
            }
        }
    }
}
