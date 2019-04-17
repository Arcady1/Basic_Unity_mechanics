using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    private float targetX;
    private int LineNumber;

    void Start()
    {
        LineNumber = 1;
        targetX = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && LineNumber == 1)
        {
            targetX = 2.2f;
            Tweener jump = transform.DOMoveX(targetX, 0.4f);
            jump.Play();

            LineNumber = 2;
        }        

        if (Input.GetKeyDown(KeyCode.A) && LineNumber == 1)
        {
            targetX = -2.2f;
            Tweener jump = transform.DOMoveX(targetX, 0.4f);
            jump.Play();

            LineNumber = 0;
        }

        if (Input.GetKeyDown(KeyCode.D) && LineNumber == 0)
        {
            targetX *= 0f;
            Tweener jump = transform.DOMoveX(targetX, 0.4f);
            jump.Play();

            LineNumber = 1;
        }

        if (Input.GetKeyDown(KeyCode.A) && LineNumber == 2)
        {
            targetX *= 0f;
            Tweener jump = transform.DOMoveX(targetX, 0.4f);
            jump.Play();

            LineNumber = 1;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            GameController controller = FindObjectOfType<GameController>();
            controller.StopGame();
        }
    }
}
