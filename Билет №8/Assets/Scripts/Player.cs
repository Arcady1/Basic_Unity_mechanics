using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        Vector3 position = transform.position;
        Bullet bull = Instantiate(bullet, position, bullet.transform.rotation);
        bull.Direction = bull.transform.right * (player.flipX ? -1.0f : 1.0f);
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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}
