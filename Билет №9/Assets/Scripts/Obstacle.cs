using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float ObstacleSpeed = 5f;

    void Update()
    {
        Vector3 direction = -transform.right * ObstacleSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, ObstacleSpeed * Time.deltaTime);

        if (transform.position.x <= -7f)
        {
            Destroy(gameObject);
            NewScore();
        }            
    }

    private void NewScore()
    {
        Score score = FindObjectOfType<Score>();
        score.ScoreValue();
    }
}
