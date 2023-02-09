using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JellyFishMovement : MonoBehaviour
{
    private int time = 0;
    private int time2 = 0;
    private int time3 = 0;
    private int time4 = 0;
    private Rigidbody2D rb;
    private GameObject oj;
    private float jumpForce = 5;

    void Start()
    {
        oj = GameObject.Find("player");
        rb = oj.GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        StartCoroutine(move());
        StartCoroutine(moveV());
    }

    IEnumerator move()
    {
        if (time2 == 0)
        {
            transform.position = transform.position + new Vector3(0.03f, 0, 0);
            time = time + 1;
            if(time > 200)
            {
                yield return new WaitForSeconds(0);
                time2 = 1;
            }
        }

        if (time2 == 1)
        {
            transform.position = transform.position + new Vector3(-0.03f, 0, 0);
            time = time - 1;
            if (time < 0)
            {
                yield return new WaitForSeconds(0);
                time2 = 0;
            }
        }
    }

    IEnumerator moveV()
    {
        if (time4 == 0)
        {
            transform.position = transform.position + new Vector3(0, -0.01f, 0);
            time3 = time3 + 1;
            if (time3 > 100)
            {
                yield return new WaitForSeconds(0);
                time4 = 1;
            }
        }

        if (time4 == 1)
        {
            transform.position = transform.position + new Vector3(0, 0.01f, 0);
            time3 = time3 - 1;
            if (time3 < 0)
            {
                yield return new WaitForSeconds(0);
                time4 = 0;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
