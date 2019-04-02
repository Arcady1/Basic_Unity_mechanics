using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle1 : MonoBehaviour
{
    private float ObstacleSpeed = 4f;

    public void Update()
    {
        Vector3 direction = -transform.right * ObstacleSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, ObstacleSpeed * Time.deltaTime);

        Destroy(gameObject, 3f);
    }
}
