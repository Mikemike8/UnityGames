using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ssTwoDMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float MoveInput = 0f;
       


        if (Input.GetKey("right"))
        {
            MoveInput = 5.0f;
        }
        else if (Input.GetKey("left"))
        {
            MoveInput = -5.0f;
        }
  

        rb.velocity = new Vector2( speed * MoveInput, rb.velocity.y);
    }
}

