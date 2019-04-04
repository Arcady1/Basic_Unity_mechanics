using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    public float playerSpeed = 6f;
    public Bullet bullet;
    public bool flipX = false;

    private void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            Vector3 direction = transform.position;
            Bullet bull = Instantiate(bullet, direction, bullet.transform.rotation);
            bull.direction = transform.right * (flipX ? -1f : 1f);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 direction = -transform.right * playerSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, playerSpeed * Time.deltaTime);

            flipX = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 direction = transform.right * playerSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, playerSpeed * Time.deltaTime);

            flipX = false;
        }
        //if (Input.GetKey(KeyCode.W))
        //{
        //    Vector3 direction = transform.up * playerSpeed * Time.deltaTime;
        //    transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, playerSpeed * Time.deltaTime);
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    Vector3 direction = -transform.up * playerSpeed * Time.deltaTime;
        //    transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, playerSpeed * Time.deltaTime);
        //}
    } 
}
