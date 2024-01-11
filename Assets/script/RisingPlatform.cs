using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingPlatform : MonoBehaviour
{
    public Rigidbody2D rb;
    private Transform tf;
    private bool rising = false;
    private float movementSpeed = 3f;
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tf = GetComponent<Transform>();
    }

    void Update()
    {
        if (rising)
        {
            tf.position = tf.position + new Vector3(0, 1 * movementSpeed * Time.deltaTime, 0);

        }
        rb.angularVelocity = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rising = true;
        }
    }
}
