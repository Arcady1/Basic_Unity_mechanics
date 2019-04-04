using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    private float StartTime = 0f;
    public float Interval = 1f;

    private void Update()
    {
        if(Time.timeSinceLevelLoad > StartTime + Interval)
        {
            StartTime += Interval;

            Vector3 spawnPosition = new Vector3();
            spawnPosition.x = Random.Range(-3.5f, 3.5f);
            spawnPosition.y = Random.Range(-4.5f, 4.5f);

            Instantiate(enemy, spawnPosition, Quaternion.identity);
        }
    }
}
