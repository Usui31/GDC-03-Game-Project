using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kirikananEnemymovement : MonoBehaviour
{
    public float speed;

    public bool MoveRight;


    private void Update()
    {
        if (MoveRight)
        {
            transform.Translate(0, 2 * speed * Time.fixedDeltaTime, 0);
            transform.localScale = new Vector2(0.5f, 0.5f);
        }
        else
        {
            transform.Translate(0, -2 * speed * Time.fixedDeltaTime, 0);
            transform.localScale = new Vector2(0.5f, -0.5f);
        }
    }
    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {
            if (MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
    }
}

