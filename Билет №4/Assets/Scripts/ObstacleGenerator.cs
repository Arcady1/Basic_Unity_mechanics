using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    [Range(0.5f, 2f)]
    private float Interval = 0.5f;
    [SerializeField]
    private Obstacle ObstaclePrefab;

    private void Start()
    {
        StartCoroutine(ObstGenerator());
    }

    private IEnumerator ObstGenerator()
    {
        while (true)
        {
            yield return new WaitForSeconds(Interval);
            Obstacle obstacle = Instantiate(ObstaclePrefab, transform);

            if (Random.Range(0, 2) == 1)
            {
                Vector3 pos = obstacle.transform.position;
                pos.x *= -1;
                obstacle.transform.position = pos;
            }
        }
    }
}
