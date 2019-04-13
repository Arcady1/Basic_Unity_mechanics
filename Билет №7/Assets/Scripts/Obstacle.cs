using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 18f)]
    private float ObsatcleSpeed = 9f;        

    void Update()
    {
        Fall();

        if (transform.position.y < 0.01f)
        {
            Destroy(gameObject);
            Score score = FindObjectOfType<Score>();
            score.ScoreUpdate();
        }            
    }

    private void Fall()
    {
        Vector3 direction = -transform.up * ObsatcleSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, ObsatcleSpeed * Time.deltaTime);
    }
}
