using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public Animator animator;
    public AnimationClip firingAnimation;
    public AudioClip shootingSound;
    private AudioSource audioSource;

    private float timer;

    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = shootingSound;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >2.5)
        {
            timer = 0;
            animator.SetBool("Shoot", true);
            shoot();
        }
    }

    void shoot()
    {
        audioSource.Play();
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }

    public void resetShoot()
    {
        animator.SetBool("Shoot", false);
    }
}
