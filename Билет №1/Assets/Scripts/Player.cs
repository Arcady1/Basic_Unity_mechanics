using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Range(1f,9f)]
    private float JumpForce = 9f;

    [SerializeField]
    private LayerMask WhatIsGround;
    [SerializeField]
    private Transform GroundCheck;
    private float GroundRadius = 0.2f;
    private bool isGrounded = false;

    Rigidbody2D rb;    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       
    }

    void Update()
    {
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * JumpForce,ForceMode2D.Impulse);
        }

    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.transform.position, GroundRadius, WhatIsGround);
        if (!isGrounded)
            return;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obstacle")
        {
            //
        }
    }   
}
