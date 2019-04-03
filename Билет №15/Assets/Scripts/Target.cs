using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{    
    void Update()
    {
        Destroy();
    }

    private void Destroy()
    {
        Destroy(gameObject, 1f);
    }
}
