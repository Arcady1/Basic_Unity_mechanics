using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    private bool isJumping = false;
    private float targetZ = 2.67f;
    [SerializeField]
    private int LineNumber = 0;

    private void Update()
    {
        if (isJumping)
            return;

        if(LineNumber == 0 && Input.GetKeyDown(KeyCode.D))
        {
            isJumping = true;
            Tweener jumpTween = transform.DOMoveZ(0f, 0.4f);
            jumpTween.OnComplete(() => isJumping = false);
            jumpTween.Play();

            LineNumber = 1;
        }
        if (LineNumber == 1 && Input.GetKeyDown(KeyCode.A))
        {
            isJumping = true;
            Tweener jumpTween = transform.DOMoveZ(targetZ, 0.4f);
            jumpTween.OnComplete(() => isJumping = false);
            jumpTween.Play();

            LineNumber = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Obstacle")
        {
            GameController controller = FindObjectOfType<GameController>();
            controller.StopGame();
        }
    }

}
