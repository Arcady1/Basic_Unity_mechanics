using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField]
    private Enemy Enemy;
    [SerializeField]
    [Range(1f, 8f)]
    private float Interval = 4f;
    [SerializeField]
    private float nextSpeed;

    private void Start()
    {
        StartCoroutine(Generator());
        StartCoroutine(IntervalCor());
        StartCoroutine(NextEnemySpeed());
    }

    private IEnumerator Generator()
    {
        while (true)
        {
            yield return new WaitForSeconds(Interval);

            Enemy enemy = Instantiate(Enemy, transform);
            enemy.Speed += nextSpeed;
        }        
    }

    private IEnumerator IntervalCor()
    {
        while(true)
        {
            yield return new WaitForSeconds(3.5f);

            Interval = Mathf.Max(1f, Interval - 0.2f);
        }
    }

    private IEnumerator NextEnemySpeed()
    {
        while(true)
        {
            yield return new WaitForSeconds(4f);

            nextSpeed += 0.3f;
        }        
    }
}
