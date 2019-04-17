using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private Obstacle obstacle;

    private void Start()
    {
        StartCoroutine(Inst());
    }

    IEnumerator Inst()
    {
        while(true)
        {
            yield return new WaitForSeconds(Random.Range(1.2f, 2f));            

            if(Random.Range(0, 2) == 0)
            {
                Obstacle obst = Instantiate(obstacle, transform);
                obst.Direction = transform.right * 1f;

                Vector3 spawnPos = new Vector3();
                spawnPos.x = -9f;
                spawnPos.y = -2.95f;
                obst.transform.position = spawnPos;
            }

            if (Random.Range(0, 2) == 1)
            {
                Obstacle obst = Instantiate(obstacle, transform);
                obst.Direction = transform.right * -1f;

                Vector3 spawnPos = new Vector3();
                spawnPos.x = 9f;
                spawnPos.y = -2.95f;
                obst.transform.position = spawnPos;
            }
        }
    }
}
