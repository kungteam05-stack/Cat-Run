using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

    public int speed = 7;
    public int jumpForce = 200;
    public float moveX;
    public bool isGround; 
    private Animator anim;
    private Rigidbody2D rb;
    private bool mirrered;
    private AudioSource au;
    
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        au = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            Dead();
            Application.LoadLevel("GameoverScene");
        }
    }
    private void Dead()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("isDead");
    }
    private void RestartLevel()
    {
       
    }

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        
        if (Input.GetButtonDown("Jump") && isGround == true)
        {
            Jump();
        }

        if (!isGround)
        {
            anim.SetBool("jump", true);
        }
       
        if (moveX != 0 && isGround)
        {
            anim.SetBool("run", true);
        }
        else
        {
            anim.SetBool("run", false);
        }
        
        if (moveX < 0.0f && mirrered == false)
        {
            FlipPlayer();
        }
        else if (moveX > 0.0f && mirrered == true)
        {
            FlipPlayer();
        }
        rb.velocity = new Vector2(moveX * speed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    private void FlipPlayer()
    {
        mirrered = !mirrered;
        Vector2 local = gameObject.transform.localScale;
        local.x *= -1;
        transform.localScale = local;
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce);
        isGround = false;
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ground" || other.gameObject.tag == "Box")
        {
            isGround = true;
            anim.SetBool("jump", false);
        }
        if (other.gameObject.tag == "EndLevel")
        {
           Application.LoadLevel("Scene3");
        }
    }
}
