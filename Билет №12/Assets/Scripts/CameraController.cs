using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    Vector3 distance, moveVec;
    private float smootjSpeed = 3f;

    private void Start()
    {
        distance = transform.position - player.transform.position;        
    }

    private void Update()
    {
        moveVec = distance + player.transform.position;
        moveVec.x = 0;
        moveVec.y = player.transform.position.y;

        Vector3 playerPosition = player.transform.position;
        if (playerPosition.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(moveVec.x, moveVec.y, moveVec.z);
            transform.position = Vector3.Lerp(transform.position, newPos, smootjSpeed);
        }
    }
}