using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Player;
    Vector3 StartDistance, moveVec;    


    void Start()
    {
        StartDistance = transform.position - Player.transform.position;
    }

    void LateUpdate()
    {
        moveVec = Player.transform.position + StartDistance;
        moveVec.y = 0.63f;        

        transform.position = moveVec;
    }
}
