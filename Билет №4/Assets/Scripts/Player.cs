using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    private bool isJumping = false;
    private float targetX = -1.6f;

    public void Update()
    {
        if (isJumping)
            return;

        if(Input.GetKey(KeyCode.Space))
        {
            isJumping = true;
            targetX *= -1;

            Tweener jumpTween = transform.DOMoveX(targetX, 0.4f);
            jumpTween.OnComplete(() => isJumping = false);
            jumpTween.Play();
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
