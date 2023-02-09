using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingPlatform : MonoBehaviour
{
    public Rigidbody2D rb;
    //private GameObject ob;
    private Transform tf;
    private bool rising = false;
    private float movementSpeed = 3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //ob = GetComponent<GameObject>();
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rising)
        {
            //rb.AddForce(Vector2.up * Time.deltaTime, ForceMode2D.Impulse);
            tf.position = tf.position + new Vector3(0, 1 * movementSpeed * Time.deltaTime, 0);

        }
        rb.angularVelocity = 0;
        //rb.velocity = -rb.velocity;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rising = true;
            //rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
