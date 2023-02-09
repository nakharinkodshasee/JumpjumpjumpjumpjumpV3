using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float jumpForce;
    bool isGrounded = false;
    public Transform isGroundedChecker;
    public float checkGroundRadius;
    public LayerMask groundLayer;
    public Collider2D other;
    public int win = 0;
    public int isflagged = 0;
    public float timeRemaining = 5;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
        CheckIfGrounded();
        OnTriggerEnter2D(other);
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
        
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            //.AddForce(Vector2.up * jumpForce * 1.5f, ForceMode2D.Impulse);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            rb.AddForce(Vector2.down * jumpForce * 1.5f, ForceMode2D.Impulse);
        }
    }

    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        if (collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;

        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.tag == "Finish")
        {
            Debug.Log("hi");
            win = 1;
            isflagged = 1;
        
           
            //gameObject.SetActive(false);
            
            //GameObject.Find("winningword").GetComponent<appear>().gameObject.SetActive(true);
        }

        if (isflagged == 1)
            {
                timeRemaining -= Time.deltaTime;
            if(timeRemaining < 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        
        if (other.gameObject.tag == "obstacle" && isflagged == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);

            // do the kill player stuff here
        }
    }


}
