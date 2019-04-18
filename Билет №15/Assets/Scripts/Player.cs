using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    [Range(8f, 11f)]
    private float speedMove = 9f;
    private float gravityForce;
    CharacterController _controller;
    [SerializeField]
    private int count = 1;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Move();
        Graviy();

        if(count < TargetGenerator.countOfTargets)
        {
            GameController controller = FindObjectOfType<GameController>();
            controller.StopGame();
        }
    }

    void Move()
    {
        Vector3 moveVec = Vector3.zero;
        moveVec.x = Input.GetAxis("Horizontal") * speedMove;
        moveVec.z = Input.GetAxis("Vertical") * speedMove;
        moveVec.y = gravityForce;

        _controller.Move(moveVec * Time.deltaTime);
    }

    void Graviy()
    {
        if (_controller.isGrounded)
            gravityForce -= 30f * Time.deltaTime;
        else
            gravityForce = -1f;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Point")
        {
            Score score = FindObjectOfType<Score>();
            score.ScoreValue();

            count += 1;
        }
    }
}