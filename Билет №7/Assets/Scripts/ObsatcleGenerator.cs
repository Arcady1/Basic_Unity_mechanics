using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsatcleGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject obsatcle;
    [SerializeField]
    private float interval = 2f;
    
    void Start()
    {
        StartCoroutine(Interval());
        StartCoroutine(DecreaseInterval());
    }

    private IEnumerator Interval()
    {
        while (true)
        {
            yield return new WaitForSeconds(interval);

            Vector3 SpawnPos = new Vector3();
            SpawnPos.x = Random.Range(-7f, 7f);
            SpawnPos.y = 11f;
            SpawnPos.z = 0f;
            Instantiate(obsatcle, SpawnPos, Quaternion.identity);            
        }        
    }

    private IEnumerator DecreaseInterval()
    {
        while(true)
        {
            yield return new WaitForSeconds(2.5f);

            interval = Mathf.Max(1f, interval - 0.2f);
        }        
    }
}
