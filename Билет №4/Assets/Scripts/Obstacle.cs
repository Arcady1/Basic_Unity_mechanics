using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float ObstacleSpeed = 5f;

    void Update()
    {
        Vector3 direction = -transform.up * ObstacleSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, ObstacleSpeed * Time.deltaTime);

        if(transform.position.y <= -6f)
        {
            Destroy(gameObject);

            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }
    }
}
