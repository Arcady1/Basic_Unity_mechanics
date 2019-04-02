using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpForce = 8f;
    Rigidbody2D rb;
    float movementX = 0f;
    public float movementXSpeed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(rb!= null)
        {
            Vector2 velocity = rb.velocity;
            velocity.y = JumpForce;
            rb.velocity = velocity;
        }
    }

    private void Update()
    {
        movementX = Input.GetAxis("Horizontal") * movementXSpeed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movementX;
        rb.velocity = velocity;
    }
}
