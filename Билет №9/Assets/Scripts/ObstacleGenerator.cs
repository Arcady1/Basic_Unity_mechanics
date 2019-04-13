using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject Obstacle;
    [SerializeField]
    private int Interval = 3;
    private float pos;

    void Start()
    {
        StartCoroutine(Generator());
    }

    private IEnumerator Generator()
    {
        while(true)
        {
            Interval = Random.Range(3, 5);
            yield return new WaitForSeconds(Interval);

            pos = Random.Range(0, 2);
            if (pos == 0)
            {
                Vector3 spawnPos = new Vector3();
                spawnPos.z = 2.665f;
                spawnPos.x = 7.5f;
                Instantiate(Obstacle, spawnPos, Quaternion.identity);
            }
            if (pos == 1)
            {
                Vector3 spawnPos = new Vector3();
                spawnPos.z = 0f;
                spawnPos.x = 7.5f;
                Instantiate(Obstacle, spawnPos, Quaternion.identity);
            }
        }        
    }
}
