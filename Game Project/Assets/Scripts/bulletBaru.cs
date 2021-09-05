using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
public class bulletBaru : MonoBehaviour
{
    public float speed;
    public int damage;
    private Transform player;
    private Vector2 target;
    public GameObject duar;

    

    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        target = new Vector2(player.position.x, player.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if(transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.gameObject.CompareTag("Player") || hit.gameObject.CompareTag("Wall"))
        {
            healthPlayer player = hit.GetComponent<healthPlayer>();
            if(player != null)
            {
                player.TakeDamage(damage);
            }
            
            DestroyProjectile();
            

        }

    }

    void DestroyProjectile()
    {
        
        Instantiate(duar, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
