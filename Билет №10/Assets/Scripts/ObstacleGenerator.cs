using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public Obstacle obstacle;

    private void Start()
    {
        StartCoroutine(Inst());
    }

    IEnumerator Inst()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1, 3));

            Obstacle obst = Instantiate(obstacle, transform);

            if (Random.Range(0, 3) == 0)
            {
                Vector3 pos = obstacle.transform.position;
                pos.x = -2.2f;
                obstacle.transform.position = pos;
            }
            if (Random.Range(0, 3) == 1)
            {
                Vector3 pos = obstacle.transform.position;
                pos.x = 0f;
                obstacle.transform.position = pos;
            }
            if (Random.Range(0, 3) == 2)
            {
                Vector3 pos = obstacle.transform.position;
                pos.x = 2.2f;
                obstacle.transform.position = pos;
            }
        }
    }
}
