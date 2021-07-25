using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 move;
   

    // Update is called once per frame
    void Update()
    {
        move.x = Input.GetAxisRaw("horizontal");
        move.y = Input.GetAxisRaw("vertical");


    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + move * MoveSpeed * Time.fixedDeltaTime);    
    }
}
