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
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    public AudioClip dieSound;
    private AudioSource audioSource;
    private bool audioPlayed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        other = GetComponent<BoxCollider2D>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = dieSound;
    }

    void Update()
    {
        Move();
        Jump();
        CheckIfGrounded();
        OnTriggerEnter2D(other);
        if (!audioSource.isPlaying && (audioSource.time == 0f) && audioPlayed == true)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
                }
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        rb.velocity = new Vector2(moveBy, rb.velocity.y);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }
        
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow))
        {
            spriteRenderer.flipX = true;
        }
        else if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
        {
            spriteRenderer.flipX = false;
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
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
            animator.SetBool("isInTheAir", false);
        }
        else
        {
            isGrounded = false;
            animator.SetBool("isInTheAir", true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Finish")
        {
            win = 1;
            isflagged = 1;
        }

        if (isflagged == 1)
            {
                timeRemaining -= Time.deltaTime;
            if(timeRemaining < 0)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
            }
        
        if (other.gameObject.tag == "obstacle" && isflagged == 0 && audioPlayed == false)
        {
            spriteRenderer.enabled = false;
            audioSource.Play();
            audioPlayed = true;
            Time.timeScale = 0;
        }
    }


}
