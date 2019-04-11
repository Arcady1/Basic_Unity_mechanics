using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float enemySpeed = 5f;

    void Update()
    {
        Vector3 direction = -transform.right * enemySpeed * Time.timeSinceLevelLoad * 0.002f;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, enemySpeed * Time.timeSinceLevelLoad * 0.002f);

        if(transform.position.x < -4f)
        {
            Destroy(gameObject);

            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
