using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 6f;
    Vector3 mousePosition;

    public void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.position = Vector3.MoveTowards(transform.position, mousePosition, bulletSpeed * Time.deltaTime);
        Destroy(gameObject, 1f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            Score score = FindObjectOfType<Score>();
            score.ScoreValue();

            Destroy(gameObject);
        }
    }
}