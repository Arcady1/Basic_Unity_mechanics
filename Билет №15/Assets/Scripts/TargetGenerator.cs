using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    public GameObject target;
    private float minX = -4.3f;
    private float maxX = 4.3f;
    private float minZ = -5f;
    private float maxZ = 5f;
    public float Interval = 2f;
    private float StartTime = 0f;

    private void Update()
    {
        if(Time.timeSinceLevelLoad > Interval + StartTime)
        {
            StartTime += Interval;

            Vector3 spawnPosition = new Vector3();

            spawnPosition.x = Random.Range(minX, maxX);
            spawnPosition.z = Random.Range(minZ, maxZ);

            Instantiate(target, spawnPosition, Quaternion.identity);
        }
    }
}
