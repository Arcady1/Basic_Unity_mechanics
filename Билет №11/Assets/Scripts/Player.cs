using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float JumpForce = 5f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Checkpoint")
        {
            Score score = FindObjectOfType<Score>();
            score.scoreValue();
        }

        if (collision.tag == "Obstacle")
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }

        if(collision.tag == "Ground")
        {
            SceneManager.LoadScene(0, LoadSceneMode.Single);
        }
    }
}