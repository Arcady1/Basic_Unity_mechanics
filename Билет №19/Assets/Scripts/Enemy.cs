using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float EnemySpeed = 10f;

    private void Update()
    {
        Vector3 direction = transform.right * EnemySpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, EnemySpeed * Time.deltaTime);

        if(transform.position.x >= 1f)
        {
            Destroy(gameObject);

            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }        
    }
}
