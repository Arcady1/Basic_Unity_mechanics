using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Bullet bullet;    
    [SerializeField]
    [Range(3f, 6f)]
    private float PlayerSpeed = 4f;
    private float Interval = 1f;
    public bool flipX = false;

    private void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while(true)
        {
            yield return new WaitForSeconds(Interval);

            Bullet bull = Instantiate(bullet, transform);
            bull.Direction = transform.right * (flipX ? -1f : 1f);
        }
    }
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 direction = transform.right * PlayerSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, PlayerSpeed * Time.deltaTime);
            flipX = false;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 direction = -transform.right * PlayerSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, PlayerSpeed * Time.deltaTime);
            flipX = true;
        }
    }    
}
