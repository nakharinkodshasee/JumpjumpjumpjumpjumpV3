using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonAppear : MonoBehaviour
{
    private Button bt;
    private Image im;
    private Text txt;

    void Start()
    {
        bt = GetComponent<Button>();
        im = GetComponent<Image>();
        txt = GetComponent<Text>();
        im.enabled = false;
        txt.enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            im.enabled = !im.enabled;
        }
    }
}
