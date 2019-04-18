using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private Obstacle obstacle;
    [SerializeField]
    [Range(1f, 4f)]
    private float Interval = 1f;

    private void Start()
    {
        StartCoroutine(Inst());
    }

    IEnumerator Inst()
    {
        while(true)
        {
            yield return new WaitForSeconds(Interval);

            Obstacle obst = Instantiate(obstacle, transform);

            Vector3 spawnPos = new Vector3();
            spawnPos.x = Random.Range(3.4f, 5.4f);
            spawnPos.y = Random.Range(3.4f, -3.4f);

            obstacle.transform.position = spawnPos;
        }
    }
}
