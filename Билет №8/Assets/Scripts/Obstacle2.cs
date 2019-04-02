using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle2 : MonoBehaviour
{
    public float ObstacleSpeed = 3f;

    void Update()
    {
        Vector3 direction = -transform.right * ObstacleSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, ObstacleSpeed * Time.deltaTime);

        Destroy(gameObject, 7f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet")
        {
            Destroy(gameObject);

            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }
    }
}
