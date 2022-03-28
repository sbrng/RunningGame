using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    public Animator animator;

    public int gemas = 0;

    public bool jump = false;
    public bool crouch = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        //Debug.Log(directionY);
        playerDirection = new Vector2(0, directionY).normalized;

        if(directionY == 1) {
            jump = true;
            animator.SetBool("isJumping", true);
        } else if(directionY == -1) {
            crouch = true;
            animator.SetBool("isCrouching", true);
        } 
    }    
    void FixedUpdate() {

        //rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
        rb.velocity = new Vector2(0, rb.velocity.y);

        if (jump) {
            rb.velocity = Vector2.up * playerSpeed;
            jump = false;
            animator.SetBool("isJumping", false);
        }
        else if (crouch) {
            crouch = false;
            animator.SetBool("isCrouching", false);
        }
    }

    public int getGemas() {
        return this.gemas;
    }

    public void incrementGema() {
        this.gemas++;
    }

}
