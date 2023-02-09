using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfCircleMover : MonoBehaviour
{
    public float speed = 1.0f;
    public float radius = 1.0f;
    public Vector3 pivotPoint = Vector3.zero;

    private float totalRotation = 0.0f;
   
    void Start()
    {
        
    }

    
    void Update()
    {
        float angle = speed * Time.deltaTime;
        transform.RotateAround(pivotPoint, Vector3.forward, angle);
        totalRotation += angle;

        if (totalRotation > 180.0f)
        {
            transform.RotateAround(pivotPoint, Vector3.forward, -angle);
            enabled = false;
        }
    }
}
