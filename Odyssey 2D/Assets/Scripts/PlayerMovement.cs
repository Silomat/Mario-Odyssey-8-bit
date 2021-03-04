using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private float moveInput;
    public float JumpForce;
    private bool facingRight = true;

    Rigidbody2D rb;
    Animator anim;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask groundMask;


    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        anim = this.gameObject.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, groundMask);

        //Moving the Player horizontally
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


    }
    private void Update()
    {
        //Flipping the Player
        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
        
        if(moveInput != 0)
        {
            
            anim.SetBool(("IsRunning"), true);
            //replace this comment with the code to PLAY the running sound

        } else if(moveInput == 0)
        {
            
            anim.SetBool(("IsRunning"), false);
            //replace this comment with the code to STOP the running sound
        }
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded == true)
        {
            rb.velocity = Vector2.up * JumpForce;
            //replace this comment with the code to PLAY the jumping sound
        }
    }
    //Flipping the Player
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}
