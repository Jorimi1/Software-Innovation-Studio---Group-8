using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpingPower = 22f;
    private bool isFacingRight;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    public Animator ac;

    void Start(){
        this.ac = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        Flip();

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
     {
        if(horizontal > 0){
            ac.SetBool("MoveRight", true);
            ac.SetBool("BacktoFaceRight", false);
            ac.SetBool("MoveLeft", false); 
            ac.SetBool("BacktoFaceLeft", false);
            isFacingRight = true;
        }

        if(horizontal < 0){
            ac.SetBool("MoveRight", false);
            ac.SetBool("BacktoFaceRight", false);
            ac.SetBool("MoveLeft", true); 
            ac.SetBool("BacktoFaceLeft", false);
            isFacingRight = false;
        }

        if(horizontal == 0 && isFacingRight){
            ac.SetBool("MoveRight", false);
            ac.SetBool("BacktoFaceRight", true);
            ac.SetBool("MoveLeft", false); 
            ac.SetBool("BacktoFaceLeft", false);
            isFacingRight = true;
        }

        if(horizontal == 0 && !isFacingRight){
            ac.SetBool("MoveRight", false);
            ac.SetBool("BacktoFaceRight", false);
            ac.SetBool("MoveLeft", false); 
            ac.SetBool("BacktoFaceLeft", true);
            isFacingRight = false;
        }
    }
}

