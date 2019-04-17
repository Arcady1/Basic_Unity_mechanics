using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    private float Speed = 5f;

    void Update()
    {
        Moving();
        Delete();
    }

    void Moving()
    {
        Vector3 direction = transform.up * Speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, Speed * Time.deltaTime);
    }

    void Delete()
    {
        if (transform.position.y >= 4f)
        {
            Destroy(gameObject);
            GameController controller = FindObjectOfType<GameController>();
            controller.StopGame();
        }            
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            Destroy(gameObject);
    }
}
