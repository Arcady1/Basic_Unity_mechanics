using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController ch_controller;
    Vector3 moveVec;
    [SerializeField]
    [Range(3f,9f)]
    private float MovingSpeed = 7f;

    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
        Move();   
    }

    private void Move()
    {
        moveVec = Vector3.zero;
        moveVec.x = Input.GetAxis("Horizontal") * MovingSpeed;
        Vector3 move = new Vector3(moveVec.x, moveVec.y, moveVec.z);

        ch_controller.Move(move * Time.deltaTime);
    }
}
