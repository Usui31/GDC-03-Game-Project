using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;

    [HideInInspector] public bool isFacingRight;
    [HideInInspector] public bool isFacingUp;
    [HideInInspector] public float posX, posY;
    [HideInInspector] public bool shoot;
    Vector2 movement;

    void Start(){
        isFacingRight = false;
        isFacingUp = false;
        posX = 0;
        posY = -1f;
        shoot = false;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        if ((movement.x != 0 || movement.y != 0)) 
        {

            
            animator.SetFloat("Horizontal",movement.x);
            animator.SetFloat("Vertical", movement.y);
            animator.SetFloat("Speed", movement.sqrMagnitude);
            animator.SetBool("Walk",true);
            
        }else animator.SetBool("Walk",false);
            

        if (movement.x >0f){
            isFacingRight = true;
            posX = 1f;
            posY = 0;
        }else if (movement.x <0f){
            isFacingRight = false;
            posX =  -1f;
            posY = 0;
        }

        if (movement.y > 0f){
            isFacingUp = true;
            posX = 0;
            posY = 1f;
        }else if (movement.y < 0f){
            isFacingUp = false;
            posX = 0;
            posY = -1f;
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
