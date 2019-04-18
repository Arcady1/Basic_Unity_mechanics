using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetGenerator : MonoBehaviour
{
    [SerializeField]
    private Target target;
    private float minX = -11f;
    private float maxX = 8f;
    private float minZ = -5f;
    private float maxZ = 4f;
    [SerializeField]
    [Range(1f, 2.5f)]
    private float Interval = 1.8f;
    [SerializeField]
    public static int countOfTargets;

    private void Start()
    {
        StartCoroutine(Inst());
    }

    IEnumerator Inst()
    {
        while(true)
        {
            yield return new WaitForSeconds(Interval);

            countOfTargets += 1;

            Target targ = Instantiate(target, transform);
            Vector3 spawnPos = new Vector3();
            spawnPos.x = Random.Range(minX, maxX);
            spawnPos.z = Random.Range(minZ, maxZ);

            targ.transform.position = spawnPos;
        }
    }
}
