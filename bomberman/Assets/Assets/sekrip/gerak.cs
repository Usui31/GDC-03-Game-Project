using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float MoveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 gerak;


    // Update is called once per frame
    void Update()
    {
        gerak.x = Input.GetAxisRaw("horizontal");
        gerak.y = Input.GetAxisRaw("vertical");


    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + gerak * MoveSpeed * Time.fixedDeltaTime);
    }
}
