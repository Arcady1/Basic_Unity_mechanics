using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedMove = 9f;
    private float gravityForce;
    Vector3 moveVec;
    CharacterController ch_controller;

    public void Start()
    {
        ch_controller = GetComponent<CharacterController>();
    }
    public void Update()
    {
        CharacterMove();
        Graviy();
    }

    public void CharacterMove()
    {
        moveVec = Vector3.zero;
        moveVec.x = Input.GetAxis("Horizontal") * speedMove;
        moveVec.z = Input.GetAxis("Vertical") * speedMove;
        moveVec.y = gravityForce;

        ch_controller.Move(moveVec * Time.deltaTime);
    }

    private void Graviy()
    {
        if(!ch_controller.isGrounded)
        {
            gravityForce -= 20f * Time.deltaTime;
        }
        else
        {
            gravityForce = -1f;
        }
    }
}
