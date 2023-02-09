using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowReappear : MonoBehaviour
{
    private GameObject obj;
 
    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.Find("platform");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        Debug.Log("Disable");
        obj.GetComponent<LV8platformmv>().reAwake();
    }
}
