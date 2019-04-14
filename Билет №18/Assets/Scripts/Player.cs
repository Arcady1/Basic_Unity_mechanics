using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    public float playerSpeed = 6f;
    public Bullet bullet;

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 direction = -transform.right * playerSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, playerSpeed * Time.deltaTime);           
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 direction = transform.right * playerSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, playerSpeed * Time.deltaTime);           
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 direction = transform.up * playerSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 direction = -transform.up * playerSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, playerSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            GameController controller = FindObjectOfType<GameController>();
            controller.StopGame();
        }
    }
}
