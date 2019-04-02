using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Player player;
    Vector3 moveVec, StartPosition;

    private void Start()
    {
        StartPosition = transform.position - player.transform.position;
    }

    private void Update()
    {
        moveVec = player.transform.position + StartPosition;
        moveVec.x = 0;
        transform.position = moveVec;

    }
}
