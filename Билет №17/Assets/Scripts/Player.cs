using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Range(4f, 15f)]
    private float JumpForce = 7.5f;
    private float ExtraJumps;
    Rigidbody2D rb;

    private bool isGrounded = false;
    [SerializeField]
    private LayerMask WhatIsGround;
    [SerializeField]
    private Transform GroundCheck;
    private float groundCheckRadius = 0.2f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ExtraJumps > 0)
        {
            rb.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
            ExtraJumps--;
        } 
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, groundCheckRadius, WhatIsGround);
        if (isGrounded)
            ExtraJumps = 1;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            GameController controller = FindObjectOfType<GameController>();
            controller.StopGame();
        }
    }
}