using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player : MonoBehaviour
{
    private float targetZ = -1.4f;
    [SerializeField]
    private int numberOfLine;

    private void Start()
    {
        numberOfLine = 1;
    }

    private void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow) && numberOfLine == 1)
        {
            Tweener jumpTween = transform.DOMoveZ(targetZ, 0.5f);
            jumpTween.Play();

            numberOfLine = 0;
        }
        if(Input.GetKeyDown(KeyCode.RightArrow) && numberOfLine == 1)
        {
            Tweener jumpTween = transform.DOMoveZ(-targetZ, 0.5f);
            jumpTween.Play();

            numberOfLine = 2;
        }      
        if(Input.GetKeyDown(KeyCode.RightArrow) && numberOfLine == 0)
        {
            Tweener jumpTween = transform.DOMoveZ(0f, 0.5f);
            jumpTween.Play();

            numberOfLine = 1;
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow) && numberOfLine == 2)
        {
            Tweener jumpTween = transform.DOMoveZ(0f, 0.5f);
            jumpTween.Play();

            numberOfLine = 1;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            GameController controller = FindObjectOfType<GameController>();
            controller.StopGame();
        }
    }
}
