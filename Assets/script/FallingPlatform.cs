using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    public Rigidbody2D rb;
    private bool falling = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (falling)
        {
            rb.AddForce(Vector2.down * Time.deltaTime, ForceMode2D.Impulse);
        }
        rb.angularVelocity = 0;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            falling = true;
            rb.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
