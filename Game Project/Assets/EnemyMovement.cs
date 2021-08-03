using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed;

    public bool MoveUp;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (MoveUp)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);
            transform.localScale = new Vector2(0.2f, 0.3f);
        }
        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
            transform.localScale = new Vector2(0.2f, -0.3f);
        }
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("turn"))
        {
            if (MoveUp)
            {
                MoveUp = false;
            }
            else
            {
                MoveUp = true;
            }
        }

    }
}
