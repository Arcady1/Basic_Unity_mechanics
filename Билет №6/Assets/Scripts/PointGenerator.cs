using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGenerator : MonoBehaviour
{
    [SerializeField]
    [Range(0.5f, 4f)]
    private float interval = 0.5f;
    [SerializeField]
    private GameObject point;

    void Start()
    {
        StartCoroutine(InstPoint());
    }

    IEnumerator InstPoint()
    {
        while(true)
        {
            yield return new WaitForSeconds(interval);

            GameObject _point = Instantiate(point, transform);

            Vector3 pos = point.transform.position;
            pos.x = Random.Range(-2f, 2f);
            point.transform.position = pos;
        }
    }
}
