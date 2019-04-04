using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    public float enemySpeed = 7f;

    void Update()
    {
        Vector3 direction = transform.right * enemySpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, player.transform.position, enemySpeed * Time.deltaTime);
    }
}
