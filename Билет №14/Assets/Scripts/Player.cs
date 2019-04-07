using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MovingSpeed = 5f;

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direction = transform.up * MovingSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, MovingSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            Vector3 direction = -transform.up * MovingSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, MovingSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            GameController controller = FindObjectOfType<GameController>();
            controller.StopGame();
        }
    }
}
