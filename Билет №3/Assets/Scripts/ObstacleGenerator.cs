using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private Obstacle ObstaclePrefab;
    [SerializeField]
    [Range(1f, 4f)]
    private float interval = 1f;

    private void Start()
    {
        StartCoroutine(InstantiateObst());
    }

    private IEnumerator InstantiateObst()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);

            Obstacle obstacle = Instantiate(ObstaclePrefab, transform);
            if (Random.Range(0, 2) == 1)
            {
                Vector3 pos = obstacle.transform.position;
                pos.y *= -1;
                obstacle.transform.position = pos;
            }
            else if(Random.Range(0, 2) == 0)
            {
                Vector3 pos = obstacle.transform.position;
                pos.y *= 1;
                obstacle.transform.position = pos;
            }
        }
    }        
}
