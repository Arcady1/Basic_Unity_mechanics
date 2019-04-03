using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstMovement : MonoBehaviour
{
    private float obstacleSpeed = 5f;

    void Update()
    {
        Move();
    }
    private void Move()
    {
        Vector3 direction = -transform.right * obstacleSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, obstacleSpeed * Time.deltaTime);
    }
}
