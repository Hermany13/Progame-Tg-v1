using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerPlayer : MonoBehaviour
{

    public Animator playerAnimator;
    public Rigidbody2D playerRigidbody2D;
    public Transform groundCheck;

    public bool isGrounded;
    public bool facingRight = true;


    public float speed;
    public float direcao;

    // Pulo
    public bool jump = false;
    public float jumpForce;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));

        playerAnimator.SetBool("isGrounded", isGrounded);

        direcao = Input.GetAxisRaw("Horizontal");

        ExecutaMovimentos();

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        MovePlayer(direcao);

        if (jump)
        {
            JumpPlayer();
        }
    }

    void JumpPlayer()
    {
        playerRigidbody2D.AddForce(new Vector2(0f, jumpForce));
        isGrounded = false;
        jump = false;
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

    void ExecutaMovimentos()
    {
        playerAnimator.SetBool("Jump", !isGrounded);
        playerAnimator.SetBool("Run", playerRigidbody2D.velocity.x != 0f && isGrounded);
    }

    void MovePlayer(float movimentoH)
    {
        playerRigidbody2D.velocity = new Vector2(movimentoH * speed, playerRigidbody2D.velocity.y);

        if(movimentoH < 0 && facingRight || (movimentoH > 0 && !facingRight))
        {
            Flip();
        }
    }
}
