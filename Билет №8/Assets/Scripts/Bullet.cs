using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float BulletSpeed = 8f;
    Vector3 direction;
    public Vector3 Direction { set { direction = value; } }    

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, BulletSpeed * Time.deltaTime);
        Destroy(gameObject, 1f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
            Destroy(gameObject);
    }
}
