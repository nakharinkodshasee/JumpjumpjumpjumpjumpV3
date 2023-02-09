using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallleftsidemove : MonoBehaviour
{
    private float movementSpeed = 3f;
    public float timeRemaining1 = 1;
    public float timeRemaining2 = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining1 > 0)
        {
            transform.position = transform.position + new Vector3(-1 * movementSpeed * Time.deltaTime, 0, 0);
            timeRemaining1 -= Time.deltaTime;
            //Debug.Log(timeRemaining1);
            if (timeRemaining1 < 0)
            {
                timeRemaining2 = 1;

            }
        }

        if (timeRemaining2 > 0)
        {
            transform.position = transform.position + new Vector3(1 * movementSpeed * Time.deltaTime, 0, 0);
            timeRemaining2 -= Time.deltaTime;

            if (timeRemaining2 < 0)
            {
                timeRemaining1 = 1;
                //Debug.Log(timeRemaining1);
            }
        }



    }
}
