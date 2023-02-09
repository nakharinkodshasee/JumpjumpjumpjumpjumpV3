using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV8platformmv : MonoBehaviour
{
    private float movementSpeed1 = 3f;
    public float timeRemaining1 = 1;
    public Collider2D coll;
    private int L = 0, R = 0, U = 0, D = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moveup a bit
        /*if (timeRemaining1 > 0)
        {
            transform.position = transform.position + new Vector3(0,1 * movementSpeed1 * Time.deltaTime,  0);
            timeRemaining1 -= Time.deltaTime;
            //Debug.Log(timeRemaining1);
            if (timeRemaining1 < 0)
            {
                //timeRemaining2 = 1;

            }
        }*/
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

        OnTriggerEnter2D(coll);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Left")
        {
            Debug.Log("LEFT");
            collision.gameObject.SetActive(false);
            L = 1;
            R = 0;
            U = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "Right")
        {
            Debug.Log("RIGHT");
            collision.gameObject.SetActive(false);
            R = 1;
            L = 0;
            U = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "Up")
        {
            Debug.Log("UP");
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
            Debug.Log("DOWN");
        }
        //Debug.Log("Enter");
        //Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "RedLeft")
        {
            Debug.Log("LEFT");
            //collision.gameObject.SetActive(false);
            L = 1;
            R = 0;
            U = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "RedRight")
        {
            Debug.Log("RIGHT");
            //collision.gameObject.SetActive(false);
            R = 1;
            L = 0;
            U = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "RedUp")
        {
            Debug.Log("UP");
            //collision.gameObject.SetActive(false);
            U = 1;
            L = 0;
            R = 0;
            D = 0;
        }

        if (collision.gameObject.tag == "RedDown")
        {
            //collision.gameObject.SetActive(false);
            D = 1;
            L = 0;
            R = 0;
            U = 0;
            Debug.Log("DOWN");
        }

    }

    public void reAwake()
    {
        coll.gameObject.SetActive(true);
    }
}
