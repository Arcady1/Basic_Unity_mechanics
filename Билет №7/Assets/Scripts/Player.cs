using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float movingSpeed = 8f;

    CharacterController controller;
    Vector3 moveVec;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Moving();
    }

    private void Moving()
    {
        moveVec = Vector3.zero;
        moveVec.x = Input.GetAxis("Horizontal") * movingSpeed;

        controller.Move(moveVec * Time.deltaTime);
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
