using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class upsidemove : MonoBehaviour
{
    private float movementSpeed = 1f;
    public float timeRemaining1 = 2;
    public float timeRemaining2 = 0;

    void Update()
    {
        if (timeRemaining1 > 0)
        {
            transform.position = transform.position + new Vector3(0,4 * movementSpeed * Time.deltaTime,  0);
            timeRemaining1 -= Time.deltaTime;
            if (timeRemaining1 < 0)
            {
                timeRemaining2 = 2;

            }
        }

        if (timeRemaining2 > 0)
        {
            transform.position = transform.position + new Vector3(0,-4 * movementSpeed * Time.deltaTime,  0);
            timeRemaining2 -= Time.deltaTime;

            if (timeRemaining2 < 0)
            {
                timeRemaining1 = 2;
            }
        }



    }
}
