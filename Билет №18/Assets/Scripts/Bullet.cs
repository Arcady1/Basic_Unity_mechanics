using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 6f;
    public Vector3 direction;

    public void Update()
    {        
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, bulletSpeed * Time.deltaTime);
        Destroy(gameObject, 1f);
    }
}
