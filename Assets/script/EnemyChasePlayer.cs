using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasePlayer : MonoBehaviour
{
    public Transform playerTransform; // drag the player game object onto this field in the Inspector
    public float speed = 5f; // set the enemy's speed in the Inspector
    public bool facingRight = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = playerTransform.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
        //transform.LookAt(new Vector3(playerTransform.position.x, playerTransform.position.y, transform.position.z));
        //transform.right = playerTransform.position - transform.position; 

        if (playerTransform.position.x < gameObject.transform.position.x && facingRight)
            Flip();
        if (playerTransform.position.x > gameObject.transform.position.x && !facingRight)
            Flip();
    }

    void Flip()
    {
        //here your flip funktion, as example
        facingRight = !facingRight;
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.x *= -1;
        gameObject.transform.localScale = tmpScale;
    }
}

