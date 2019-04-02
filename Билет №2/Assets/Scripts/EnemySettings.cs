using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySettings : MonoBehaviour
{
    [SerializeField]
    float EnemyVelocity = 5.0f;

    public GameObject Enemy;
    
    
    void Update()
    {
        Vector3 direction = -transform.right * EnemyVelocity * Time.time;

        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, EnemyVelocity * Time.time * 0.002f);

        Destroy(Enemy, 6f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {            
            EnemyVelocity = 0f;            
        }
    }
}