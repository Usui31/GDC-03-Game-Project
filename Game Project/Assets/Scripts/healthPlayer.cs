using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthPlayer : MonoBehaviour
{
    public int starthealth;
    private int hp;
    public GameObject diePEffect;

    public HealthBar healthBar;

    public GameObject mati;
    // Start is called before the first frame update
    void Start()
    {
        hp = starthealth;
        healthBar.setMaxHealth(starthealth);
    }

    // Update is called once per frame


    public void TakeDamage(int damage)
    {
        hp -= damage;

        healthBar.setHealth(hp);

        if (hp <= 0)
        {
            Die();


        }
    }
    void Die()
    {
        if (diePEffect != null)
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
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        FindObjectOfType<AudioManager>().Play("MainMenu");

    }
}
