using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private Collider2D col;
    private SpriteRenderer spriter;
    private SpriteRenderer doorSpriter;
    private BoxCollider2D doorBoxCollider;
    public Sprite newsprite;
    public Sprite doorNewsprite;
    private GameObject obj;
    private string name;
    private char lastletter;

    void Start()
    {
        spriter = gameObject.GetComponent<SpriteRenderer>();
        name = gameObject.transform.name;
        lastletter = name[15];
        obj = GameObject.Find("Door_Lock_"+lastletter);
        doorSpriter = obj.gameObject.GetComponent<SpriteRenderer>();
        doorBoxCollider = obj.gameObject.GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player") {
            spriter.sprite = newsprite;
            Debug.Log(name + " " + lastletter);
            doorSpriter.sprite = doorNewsprite;
            doorBoxCollider.enabled = false;
        }
    }

    
}
