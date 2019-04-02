using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSettings : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float PlayerVelocity = 1f;
    [SerializeField]
    float JumpForce = 6.0f;
    [SerializeField]
    float groundRadius = 0.2f;

    public GameManager GM;

    public GameObject player;

    bool isGrounded = false;    
    public Transform GroundCheck;
    public LayerMask WhatIsGround;



    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(isGrounded && Input.GetKeyDown(KeyCode.W))
        {
            Jump();
        }
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(GroundCheck.position, groundRadius, WhatIsGround);
        if (!isGrounded)
            return;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            JumpForce = 0;
            GM.ShowResult();
        }
    }

    void Jump()
    {
        rb.AddForce(new Vector2(0, 20) * JumpForce);
    }    
}
