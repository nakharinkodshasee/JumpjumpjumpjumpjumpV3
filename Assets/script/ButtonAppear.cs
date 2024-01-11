using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAppear : MonoBehaviour
{
    private Image im;
    private Transform transform;

    void Start()
    {
        im = GetComponent<Image>();
        transform = GetComponent<Transform>();
        im.enabled = false;
        transform.position = new Vector2(transform.position.x + 1500, transform.position.y);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            im.enabled = !im.enabled;
            if(im.enabled == true)
            {
                transform.position = new Vector2(transform.position.x - 1500, transform.position.y);
            }
            else 
            {
                transform.position = new Vector2(transform.position.x + 1500, transform.position.y);
            }
            
            
        }
    }
}
