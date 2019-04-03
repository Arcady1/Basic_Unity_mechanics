using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    Vector3 distance, moveVec;

    private void Start()
    {
        distance = transform.position - player.transform.position;
    }

    private void Update()
    {
        moveVec = distance + player.transform.position;
        moveVec.x = 0;
        transform.position = moveVec;
    }
}
