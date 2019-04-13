using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Bullet bullet;
    public Player player;
    private float StartTime = 0f;
    private float Interval = 1f;
    public float PlayerSpeed = 4f;
    public bool flipX = false;

    private void Shoot()
    {
        Bullet bull = Instantiate(bullet, transform);
        bull.Direction = bull.transform.right * (player.flipX ? -1f : 1f);
    }   
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 direction = transform.right * PlayerSpeed * Time.deltaTime;
            player.transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, PlayerSpeed * Time.deltaTime);
            flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 direction = -transform.right * PlayerSpeed * Time.deltaTime;
            player.transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, PlayerSpeed * Time.deltaTime);
            flipX = true;
        }

        if (Time.timeSinceLevelLoad >= StartTime + Interval)
        {
            Shoot();

            StartTime += Interval;
        }
    }    
}
