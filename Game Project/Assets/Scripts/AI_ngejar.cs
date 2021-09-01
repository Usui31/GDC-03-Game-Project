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


    [HideInInspector] public bool isFacingRight;
    [HideInInspector] public bool isFacingUp;
    [HideInInspector] public float posX, posY;



    private float timeBtwShots;
    public float startTimeBtwShots;

    public GameObject projectile;
    
    // Start is called before the first frame update
    void Start()
    {
        playerPos = player.GetComponent<Transform>();
        currentPos = GetComponent<Transform>().position;
        mummyAnim = GetComponent<Animator>();

        isFacingRight = false;
        isFacingUp = false;
        posX = 0;
        posY = -1f;



        timeBtwShots = startTimeBtwShots;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, playerPos.position) < distance)
        {
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speedEnemy * Time.deltaTime);

            mummyAnim.SetBool("jalan", true);

           
            
        }
        else
        {
            if(Vector2.Distance(transform.position, currentPos) <= 0)
            {
                mummyAnim.SetBool("jalan", false);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, currentPos, speedEnemy * Time.deltaTime);
                mummyAnim.SetBool("jalan", true);
              
            }
           

        }
        if(timeBtwShots <= 0 && Vector2.Distance(transform.position, playerPos.position) < distance)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            timeBtwShots = startTimeBtwShots;
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
    }
}
