using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float ObsatcleSpeed = 5f;

    void Update()
    {
        Vector3 direction = -transform.right * ObsatcleSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, ObsatcleSpeed * Time.deltaTime);

        if(transform.position.x < -3.4f)
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
