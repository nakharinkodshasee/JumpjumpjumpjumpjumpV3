using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV20platform : MonoBehaviour
{
    
    void Start()
    {
       
    }

   
    void FixedUpdate()
    {
        gameObject.transform.position = gameObject.transform.position + new Vector3(0.04f, 0.04f, 0);
    }
}
