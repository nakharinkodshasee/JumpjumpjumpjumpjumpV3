using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV8platformmv : MonoBehaviour
{
    private float movementSpeed1 = 3f;
    public float timeRemaining1 = 1;
    private Collider2D coll;
    private int L = 0, R = 0, U = 0, D = 0;

    void Update()
    {
        if (L == 1)
        {
            
            transform.position = transform.position + new Vector3(-1 * movementSpeed1 * Time.deltaTime, 0 , 0);
            
            
        }

        if (R == 1)
        {
            
            transform.position = transform.position + new Vector3(1 * movementSpeed1 * Time.deltaTime, 0 , 0);
            
        }

        if (U == 1)
        {
            
            transform.position = transform.position + new Vector3(0, 1 * movementSpeed1 * Time.deltaTime, 0);
            
  
        }

        if (D == 1)
        {
            transform.position = transform.position + new Vector3(0, -1 * movementSpeed1 * Time.deltaTime, 0);
            
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Left")
        {
            collision.gameObject.SetActive(false);
            L = 1;
            R = 0;
            U = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "Right")
        {
            collision.gameObject.SetActive(false);
            R = 1;
            L = 0;
            U = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "Up")
        {
            collision.gameObject.SetActive(false);
            U = 1;
            L = 0;
            R = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "Down")
        {
            collision.gameObject.SetActive(false);
            D = 1;
            L = 0;
            R = 0;
            U = 0;
        }

        if (collision.gameObject.tag == "RedLeft")
        {
            L = 1;
            R = 0;
            U = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "RedRight")
        {
            R = 1;
            L = 0;
            U = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "RedUp")
        {
            U = 1;
            L = 0;
            R = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "RedDown")
        {
            D = 1;
            L = 0;
            R = 0;
            U = 0;        }

    }

    public void reAwake()
    {
        coll.gameObject.SetActive(true);
    }
}
