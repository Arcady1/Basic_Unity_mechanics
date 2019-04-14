using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    [Range(6f,12f)]
    private float fallSpeed = 6f;

    void Update()
    {
        Vector3 direction = -transform.up * fallSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, fallSpeed * Time.deltaTime);

        if (transform.position.y <= 0.01f)
            Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(gameObject);
            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }            
    }
}
