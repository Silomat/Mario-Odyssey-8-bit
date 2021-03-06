using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WAter : MonoBehaviour
{

    Rigidbody2D rb;
    PlayerMovement movement;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        movement = this.GetComponent<PlayerMovement>();

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Water"))
        {
            rb.gravityScale = 3f;
            movement.speed = 3.5f;
            movement.JumpForce = 15f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Water"))
        {
            rb.gravityScale = 5f;
            movement.speed = 7f;
            movement.JumpForce = 20f;
        }
    }
}
