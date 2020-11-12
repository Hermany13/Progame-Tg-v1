using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    private float horizontal;

    [SerializeField]
    private float movementSpeed;

    private bool facingRight;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        movementSpeed = 3;

        facingRight = true;

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        
    }

    void FixedUpdate()
    {
        HandMovement(horizontal);
        Flip(horizontal);
    }

    void HandMovement(float horizontal)
    {
        // myRigidbody.velocity = Vector2.left;
        myRigidbody.velocity = new Vector2(horizontal * movementSpeed, myRigidbody.velocity.y);
    }

    void Flip(float horizontal)
    {
        if(horizontal > 0 && !facingRight || horizontal < 0 && facingRight)
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;

            theScale.x *= -1;

            transform.localScale = theScale;
        }
    }
}
