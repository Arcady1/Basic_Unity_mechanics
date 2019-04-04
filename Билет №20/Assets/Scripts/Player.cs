using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 8f;
    Vector3 moveVec;

    CharacterController ch_controller;

    private void Start()
    {
        ch_controller = GetComponent<CharacterController>();
    }

    private void FixedUpdate()
    {
        moveVec.x = Input.GetAxis("Vertical") * playerSpeed;
        moveVec.z = Input.GetAxis("Horizontal") * playerSpeed;

        ch_controller.Move(moveVec * Time.deltaTime);
    }
}
