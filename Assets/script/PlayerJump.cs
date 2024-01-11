using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5;
    public float fallForce = 1;
    private Rigidbody2D rb;
    private int jumpCount = 1000;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fallForce = 1;
            if (jumpCount > 0)
            {
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                jumpCount--;
            }
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            while (fallForce < 10)
            {
                rb.AddForce(Vector2.down * fallForce, ForceMode2D.Impulse);
                fallForce = ((fallForce + 1) * Time.deltaTime) ;
            }
        }
    }

}
