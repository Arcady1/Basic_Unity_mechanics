using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstMovement : MonoBehaviour
{
    private float obstacleSpeed = 5f;
    
    private void Update()
    {
        Vector3 direction = -transform.right * obstacleSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, obstacleSpeed * Time.deltaTime);

        if(transform.position.x < -3.6f)
        {
            Destroy(gameObject);

            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }
    }
}
