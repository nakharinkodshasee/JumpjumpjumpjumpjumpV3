using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class appear : MonoBehaviour
{
    /*[SerializeField] private Image customImage;*/
    public int isappear = 0;
    private SpriteRenderer spr;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        spr = GetComponent<SpriteRenderer>();
        spr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        isappear = GameObject.Find("player").GetComponent<movement>().win;
        Debug.Log(isappear);
        Debug.Log("heloo");
        if ( isappear == 1)
        {
            spr.enabled = true;
        }

        if (isappear == 0)
        {
            spr.enabled = false;
        }

    }
}
