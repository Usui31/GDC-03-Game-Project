using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementATAS : MonoBehaviour
{
    public float speed, timeBTWshoot, shootspeed;

    


    public bool MoveUp;

    public Transform ShootingPoint;

    public GameObject bullet;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if (MoveUp)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);
            transform.localScale = new Vector2(0.5f, 0.5f);
            ShootingPoint.transform.localPosition = new Vector3(0, 0.03f, 0);
            Shoot();
        }
        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
            transform.localScale = new Vector2(0.5f, -0.5f);
            ShootingPoint.transform.localPosition = new Vector3(0, -1.1f, 0);
            Shoot();
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

    IEnumerator Shoot()
    {
        yield return new WaitForSeconds(timeBTWshoot);
        GameObject newBullet = Instantiate(bullet, ShootingPoint.position, Quaternion.identity);

        newBullet.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, speed * shootspeed * Time.fixedDeltaTime);
    }
}
