using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    float PlayerVelocity = 5.0f;

    [SerializeField]
    public Transform EndPoint;

    [SerializeField]
    float JumpForce = 9f;    

    [SerializeField]
    float groundRadius = 0.2f;

    public LayerMask whatIsGround;
    public Transform groundCheck;
    bool isGrounded = false;

    public GameManager GM;

    Rigidbody2D rb;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();       
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,EndPoint.position * 1000f, Time.deltaTime * PlayerVelocity);         

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
        if (collision.tag == "Enemy")
        {
            rb.AddForce(transform.right * -2.5f, ForceMode2D.Impulse);
            PlayerVelocity = 0;
            JumpForce = 0;

            GM.ShowResult();
        }
    }   
}
