using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Range(2f, 8f)]
    private float movingSpeed = 2f;

    private void Update()
    {
        Moving();
    }

    private void Moving()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 direction = transform.right * movingSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, movingSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 direction = -transform.right * movingSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, movingSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Point")
        {
            Score score = FindObjectOfType<Score>();
            score.ScoreValue();
        }
    }
}
