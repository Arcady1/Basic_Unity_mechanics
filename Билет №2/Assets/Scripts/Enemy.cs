using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 8f)]
    private float enemySpeed = 1f;

    public float Speed
    {
        get => enemySpeed;
        set => enemySpeed = Mathf.Max(value, 4f);
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
