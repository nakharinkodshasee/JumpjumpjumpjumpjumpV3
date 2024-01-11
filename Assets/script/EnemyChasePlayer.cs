using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasePlayer : MonoBehaviour
{
    public Transform playerTransform; 
    public float speed = 5f; 
    public bool facingRight = false;

    void Update()
    {
        Vector2 direction = playerTransform.position - transform.position;
        transform.position = Vector2.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime); 

        if (playerTransform.position.x < gameObject.transform.position.x && facingRight)
            Flip();
        if (playerTransform.position.x > gameObject.transform.position.x && !facingRight)
            Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 tmpScale = gameObject.transform.localScale;
        tmpScale.x *= -1;
        gameObject.transform.localScale = tmpScale;
    }
}

