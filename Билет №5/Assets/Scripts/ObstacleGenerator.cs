using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    [Range(0.5f, 4f)]
    private float Interval = 0.5f;
    [SerializeField]
    private Obsatcle ObstaclePrefab;

    private void Start()
    {
        StartCoroutine(ObstGenerator());
    }

    private IEnumerator ObstGenerator()
    {
        while (true)
        {
            yield return new WaitForSeconds(Interval);

            Obsatcle obastacle =  Instantiate(ObstaclePrefab, transform);

            Vector3 pos = ObstaclePrefab.transform.position;
            pos.x = Random.Range(1.86f, -1.86f);
            ObstaclePrefab.transform.position = pos;
        }
    }
}
