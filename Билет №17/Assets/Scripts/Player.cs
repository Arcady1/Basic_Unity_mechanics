using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float JumpForce = 10f;
    private float ExtraJumps;
    Rigidbody2D rb;

    private bool isGrounded = false;
    public LayerMask WhatIsGround;
    public Transform GroundCheck;
    private float groundCheckRadius = 0.2f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && ExtraJumps > 0)
        {
            rb.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
            ExtraJumps--;
        } 
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, groundCheckRadius, WhatIsGround);
        if (isGrounded)
        {
            ExtraJumps = 1f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}