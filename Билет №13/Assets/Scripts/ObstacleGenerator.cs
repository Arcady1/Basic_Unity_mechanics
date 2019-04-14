using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject Obstacle;
    [SerializeField]
    [Range(2.5f, 4f)]
    private float Interval = 2.5f;

    void Start()
    {
        StartCoroutine(Generate());
        StartCoroutine(DecreaseInterval());
    }

    private IEnumerator Generate()
    {
        while (true)
        {
            yield return new WaitForSeconds(Interval);

            Vector3 spawnPos = new Vector3();
            spawnPos.x = Random.Range(-6f, 6f);
            spawnPos.y = 10f;
            spawnPos.z = 0f;
            Instantiate(Obstacle, spawnPos, Quaternion.identity);
        }         
    }

    private IEnumerator DecreaseInterval()
    {
        while(true)
        {
            yield return new WaitForSeconds(3f);

            Interval = Mathf.Max(1f, Interval - 0.2f);
        }        
    }
}
