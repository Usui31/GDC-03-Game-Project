using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI_ngejar : MonoBehaviour
{
    public GameObject player;
    private Transform playerPos;
    private Vector2 currentPos;
    public float distance;
    public float speedEnemy;
    private Animator mummyAnim;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.GetComponent<Transform>();
        currentPos = GetComponent<Transform>().position;
        mummyAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, playerPos.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speedEnemy * Time.fixedDeltaTime);

            mummyAnim.SetBool("jalan", true);
            mummyAnim.SetFloat("Horizontal", speedEnemy);
            mummyAnim.SetFloat("Vertical", speedEnemy);
            mummyAnim.SetFloat("Speed", speedEnemy);
            
        }
        else
        {
            if(Vector2.Distance(transform.position, currentPos) <= 0)
            {
                mummyAnim.SetBool("jalan", false);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, currentPos, speedEnemy * Time.fixedDeltaTime);
                mummyAnim.SetBool("jalan", true);
                mummyAnim.SetFloat("Horizontal", speedEnemy);
                mummyAnim.SetFloat("Vertical", speedEnemy);
                mummyAnim.SetFloat("Speed", speedEnemy);
            }
           

        }
    }
}
