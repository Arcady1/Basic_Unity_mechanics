using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    [Range(5f, 10f)]
    private float bulletSpeed = 5f;

    void Update()
    {
        Vector3 direction = transform.up * bulletSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, bulletSpeed * Time.deltaTime);

        Destroy(gameObject, 2.5f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Obstacle")
            Destroy(gameObject);
    }
}
