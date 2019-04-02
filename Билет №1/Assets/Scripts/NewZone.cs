using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewZone : MonoBehaviour
{
    public GameObject Prefabs;
    public Transform Points;
    public GameObject DeletedZone;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Instantiate(Prefabs, Points.position, Quaternion.identity);
            Destroy(DeletedZone);
        }
    }
}
