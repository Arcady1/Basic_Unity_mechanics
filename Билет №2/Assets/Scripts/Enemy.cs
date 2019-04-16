using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    public float enemySpeed = 5f;

    public float Speed
    {
        get => enemySpeed;
        set => Mathf.Max(1f, value);
    }

    void Update()
    {
        Moving();
    }    

    private void Moving()
    {
        Vector3 direction = -transform.right * enemySpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, enemySpeed * Time.deltaTime);

        if (transform.position.x < -4f)
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
