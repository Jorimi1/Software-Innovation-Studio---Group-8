using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Transform firePoint;
    private float horizontal;
    private float vertical;
    private float speed = 8f;
    private float jumpingPower = 22f;
    private bool isFacingRight;
    private bool isLadder;
    private bool isClimbing;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    public Animator ac;

    void Start(){
        this.ac = gameObject.GetComponent<Animator>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        

        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpingPower);
        }

        if (Input.GetButtonDown("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }

        if (isLadder && Mathf.Abs(vertical) > 0f)
        {
            isClimbing = true;
        }
        Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (isClimbing)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2(rb.velocity.x, vertical * speed);
        }
        else
        {
            rb.gravityScale = 4f;
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    private void Flip()
     {
        if(horizontal > 0 && !isClimbing){
            ac.SetBool("MoveRight", true);
            ac.SetBool("BacktoFaceRight", false);
            ac.SetBool("MoveLeft", false); 
            ac.SetBool("BacktoFaceLeft", false);
            isFacingRight = true;
            //firePoint.rotation = Quaternion.Euler(0, 180, 0);
        }

        if(horizontal < 0 && !isClimbing){
            ac.SetBool("MoveRight", false);
            ac.SetBool("BacktoFaceRight", false);
            ac.SetBool("MoveLeft", true); 
            ac.SetBool("BacktoFaceLeft", false);
            isFacingRight = false;
            //firePoint.rotation = Quaternion.Euler(0, 0, 0);
        }

        if(horizontal == 0 && isFacingRight && !isClimbing){
            ac.SetBool("MoveRight", false);
            ac.SetBool("BacktoFaceRight", true);
            ac.SetBool("MoveLeft", false); 
            ac.SetBool("BacktoFaceLeft", false);
            isFacingRight = true;
            //firePoint.rotation = Quaternion.Euler(0, 180, 0);
        }

        if(horizontal == 0 && !isFacingRight && !isClimbing){
            ac.SetBool("MoveRight", false);
            ac.SetBool("BacktoFaceRight", false);
            ac.SetBool("MoveLeft", false); 
            ac.SetBool("BacktoFaceLeft", true);
            isFacingRight = false;
            //firePoint.rotation = Quaternion.Euler(0, 0, 0);
        }
     
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Ladder")
        {
            isClimbing=true;
            Debug.Log("check it");
            ac.SetBool("Climb", true);
            ac.SetBool("BacktoFaceRight", false);
            ac.SetBool("MoveRight", false);
            ac.SetBool("BacktoFaceRight", false);
            ac.SetBool("MoveLeft", false); 
            ac.SetBool("BacktoFaceLeft", false);
        }
    }

    void OnTriggerExit2D(Collider2D other){
        if(other.gameObject.tag == "Ladder")
        {
            isClimbing=false;
            ac.SetBool("Climb", false);
            if(isFacingRight){
                ac.SetBool("BacktoFaceRight", true);
                ac.SetBool("BacktoFaceLeft", false);
            }else{
                ac.SetBool("BacktoFaceRight", false);
                ac.SetBool("BacktoFaceLeft", true);
            }
            ac.SetBool("MoveRight", false);
            ac.SetBool("BacktoFaceRight", false);
            ac.SetBool("MoveLeft", false); 
            
        }
    }
}

