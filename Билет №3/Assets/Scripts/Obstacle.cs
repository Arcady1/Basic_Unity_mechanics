using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    public float ObstacleSpeed = 7.0f;
    public GameObject obstacle;

    void Update()
    {
        Vector3 direction = -transform.right * ObstacleSpeed * Time.deltaTime;

        transform.position= Vector3.MoveTowards(transform.position, transform.position + direction, ObstacleSpeed * Time.deltaTime);

        if(transform.localPosition.x <= -8)
        {
            Destroy(gameObject);

            Score score = FindObjectOfType<Score>();
            score.ScoresValue();
        }
    }
}
