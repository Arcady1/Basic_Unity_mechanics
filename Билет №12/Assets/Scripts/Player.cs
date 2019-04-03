using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpForce = 8f;    
    public float movementXSpeed = 4f;
    private float movementX = 0f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y >= 0f)
        {
            if (rb != null)
            {
                rb.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
            }
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
