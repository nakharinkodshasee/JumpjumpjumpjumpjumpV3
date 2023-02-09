using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV18platform : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(0, -0.001f, 0);
    }
}
