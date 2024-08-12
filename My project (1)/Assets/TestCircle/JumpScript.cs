using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce = 10.0f;

    [Header("Ground Check")]
    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;
    public float groundCheckRadius;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        if (Input.GetKeyDown(KeyCode.UpArrow) && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    //Suppose To Draw circle where we can see the invisible overlap at

    void OnDrawGizmosSelected()
    {

        Gizmos.color = Color.red; // Give the Gizmos a color
        Gizmos.DrawWireSphere(groundCheck.position, groundCheckRadius); // Draw a circle




    }
}
