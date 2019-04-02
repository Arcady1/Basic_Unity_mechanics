using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject Enemy;
    public Vector3 spawnValues;
    public int EnemyCount;
    public float SpawnWait;
    public float StartWait;
    public float WaveWait;


    void Start()
    {        
        StartCoroutine(SpawnEnemies());      
        
    }

    IEnumerator SpawnEnemies()
    {
        yield return new WaitForSeconds(StartWait);

        while(true)
        {
            for (int i = 0; i < EnemyCount; i++)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(6, 12), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;

                Instantiate(Enemy, spawnPosition, spawnRotation);

                yield return new WaitForSeconds(Random.Range(1.6f, SpawnWait));
            }

            yield return new WaitForSeconds(WaveWait);

        }
    }
}
