using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float ObstacleSpeed = 7f;

    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 direction = -transform.up * ObstacleSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, ObstacleSpeed * Time.deltaTime);

        if (transform.position.y <= -5.5f)
        {
            Destroy(gameObject);

            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }            
    }
}
