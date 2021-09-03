using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthPlayer : MonoBehaviour
{
    public float starthealth;
    private float hp;
    public GameObject diePEffect;

    public GameObject mati;
    // Start is called before the first frame update
    void Start()
    {
        hp = starthealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            Die();
            

        }
    }
    void Die()
    {
        if(diePEffect != null)
        {
            Instantiate(diePEffect, transform.position, Quaternion.identity);
        }
        Destroy(gameObject);
        Time.timeScale = 0;
        mati.SetActive(true);

        FindObjectOfType<AudioManager>().Stop("Theme");
        



    }
    public void ResetScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        FindObjectOfType<AudioManager>().Play("Theme");

    }
}
