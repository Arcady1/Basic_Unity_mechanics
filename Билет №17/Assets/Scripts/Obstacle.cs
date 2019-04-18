using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField]
    private ObstMovement obstacle;
    [SerializeField]
    [Range(1.5f, 2f)]
    private float Interval = 1.5f;
    Vector3 spawnPosition;

    private void Start()
    {
        StartCoroutine(Inst());
    }

    IEnumerator Inst()
    {
        while (true)
        {
            yield return new WaitForSeconds(Interval);

            ObstMovement obst = Instantiate(obstacle, transform);

            if (Random.Range(0, 2) == 0)
            {
                spawnPosition.x = 5f;
                spawnPosition.y = -3.6f;

                obst.transform.position = spawnPosition;
            }
            if (Random.Range(0, 2) == 1)
            {
                spawnPosition.x = 5f;
                spawnPosition.y = -2.56f;

                obst.transform.position = spawnPosition;
            }
        }
    }
}
