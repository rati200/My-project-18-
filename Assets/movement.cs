using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{   private Rigidbody2D rb;

    private float speed = 5;

    private float jump = 200;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        rb.velocity = new Vector2(speed, rb.velocity.y);

        else if(Input.GetKey(KeyCode.A))
        rb.velocity = new Vector2(-speed, rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.W))
        rb.AddForce(Vector2.up * jump);

    }
}
