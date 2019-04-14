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
    [SerializeField]
    [Range(1f, 4f)]
    private float interval = 1f;
    [SerializeField]
    private Bullet bullet;

    void Start()
    {
        ch_controller = GetComponent<CharacterController>();
        StartCoroutine(Shoot());
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

    private IEnumerator Shoot()
    {
        while(true)
        {
            yield return new WaitForSeconds(interval);

            Vector3 spawnPos = new Vector3();
            spawnPos.x = gameObject.transform.position.x;
            spawnPos.y = 1f;
            spawnPos.z = 0f;
            Instantiate(bullet, spawnPos, Quaternion.identity);
        }        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Obstacle")
        {
            GameController controller = FindObjectOfType<GameController>();
            controller.StopGame();
        }
    }
}
