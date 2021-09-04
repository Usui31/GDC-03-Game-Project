using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDeath : MonoBehaviour
{
    public GameObject mati;

    public GameObject menu;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            mati.SetActive(true);
            FindObjectOfType<AudioManager>().Stop("Theme");
        }
    }

    public void ResetScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void GoToMainMenu2()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
        FindObjectOfType<AudioManager>().Stop("Theme");
        FindObjectOfType<AudioManager>().Play("menu");
    }

}
