using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public float pointSpeed = 5f;

    void Update()
    {
        Vector3 direction = -transform.up * pointSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, pointSpeed * Time.deltaTime);

        if(transform.position.y <= -6f)
        {
            Destroy(gameObject);            
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);

            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }
    }
}
