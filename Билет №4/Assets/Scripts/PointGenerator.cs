using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGenerator : MonoBehaviour
{
    [SerializeField]
    private float Interval = 5f;
    [SerializeField]
    private GameObject Point;

    public void Start()
    {
        StartCoroutine(Generator());
    }

    private IEnumerator Generator()
    {
        while(true)
        {
            yield return new WaitForSeconds(Interval);

            GameObject pos = Instantiate(Point, transform);
        }
    }
}

