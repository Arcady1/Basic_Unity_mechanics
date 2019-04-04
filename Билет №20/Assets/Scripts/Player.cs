using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 8f;
    Vector3 moveVec;
    private float gravitation;

    CharacterController ch_controller;private void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        }

    private void Update()
    {
        GameGravity();
    }

    private void FixedUpdate()
    {
        
    }

    private void GameGravity()
    {
        if (!ch_controller.isGrounded)
        {
            gravitation -= 10f * Time.deltaTime;
        }
        else
        {
            gravitation = -1f;
        }
        moveVec.y = gravitation;
        ch_controller.Move(moveVec * Time.deltaTime);
    }
}
