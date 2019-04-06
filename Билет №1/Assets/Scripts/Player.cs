using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float JumpForce = 9f;   
    
    public float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public Transform groundCheck;
    bool isGrounded = false;

    Rigidbody2D rb;    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       
    }

    void Update()
    {
        if(isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 20) * JumpForce);
        }

    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        if (!isGrounded)
            return;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            GameManager manager = FindObjectOfType<GameManager>();
            manager.ShowResult();

            JumpForce = 0f;
        }
    }   
}
