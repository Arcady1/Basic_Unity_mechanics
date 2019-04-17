using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    private float targetY = -1.11f;
    private bool isJumping = false;    

    void Update()
    {
        if (isJumping)
            return;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isJumping = true;
            targetY *= -1f;

            Tweener jumpTween = transform.DOMoveY(targetY, 0.4f);
            jumpTween.OnComplete(() => isJumping = false);
            jumpTween.Play();
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Obstacle")
        {
            GameConroller controller = FindObjectOfType<GameConroller>();
            controller.StopGame();
        }
    }

}
