using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed = 8f;
    public Vector3 direction;
    public Vector3 Direction { set { direction = value; } }

    public void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, BulletSpeed * Time.deltaTime);
        Destroy(gameObject, 1f);
    }
}
