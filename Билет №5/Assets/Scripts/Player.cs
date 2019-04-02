using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{    
    public float speedMove = 3f;

    void Update()
    {
        Move();
    }

    public void Move()
    {       

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 direction = -transform.right * speedMove * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speedMove * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 direction = transform.right * speedMove * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speedMove * Time.deltaTime);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            GameContoller controller = FindObjectOfType<GameContoller>();
            controller.RestartGame();
        }
    }
}
