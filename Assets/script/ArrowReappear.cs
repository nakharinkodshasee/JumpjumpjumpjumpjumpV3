using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowReappear : MonoBehaviour
{
    private GameObject obj;
    void Start()
    {
        obj = GameObject.Find("platform");
    }

    private void OnDisable()
    {
        obj.GetComponent<LV8platformmv>().reAwake();
    }
}
