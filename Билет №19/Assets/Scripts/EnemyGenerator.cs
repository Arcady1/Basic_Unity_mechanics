using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    private Enemy enemy;
    [SerializeField]
    [Range(2.5f, 4f)]
    private float Interval = 2.5f;

    private void Start()
    {
        StartCoroutine(Inst());
    }

    IEnumerator Inst()
    {
        while (true)
        {
            yield return new WaitForSeconds(Interval);

            Enemy enem = Instantiate(enemy, transform);

            Vector3 spawnPos = new Vector3();
            if (Random.Range(0, 3) == 0)
            {
                spawnPos.x = Random.Range(-100f, -65f);
                spawnPos.y = 0.5f;
                spawnPos.z = -1.4f;

                enem.transform.position = spawnPos;
            }
            if (Random.Range(0, 3) == 1)
            {
                spawnPos.x = Random.Range(-100f, -50f);
                spawnPos.y = 0.5f;
                spawnPos.z = 0f;

                enem.transform.position = spawnPos;
            }
            if (Random.Range(0, 3) == 2)
            {
                spawnPos.x = Random.Range(-100f, -75f);
                spawnPos.y = 0.5f;
                spawnPos.z = 1.4f;

                enem.transform.position = spawnPos;
            }
        }
    }
}
