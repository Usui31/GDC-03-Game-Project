using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{



    /*private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 0)
        {
            FindObjectOfType<AudioManager>().Stop("Credits");
            FindObjectOfType<AudioManager>().Play("menu");
            
        }
           
        else
        {
            FindObjectOfType<AudioManager>().Stop("menu");
        }



    }*/
    public void PlayGame(){
        SceneManager.LoadScene("Game Scene");
        FindObjectOfType<AudioManager>().Stop("menu");
        FindObjectOfType<AudioManager>().Stop("Credits");
        FindObjectOfType<AudioManager>().Play("Theme");
        
        
    }

    public void CreditsGame()
    {
        SceneManager.LoadScene("FINISH");
        
        FindObjectOfType<AudioManager>().Stop("menu");
        FindObjectOfType<AudioManager>().Play("Credits");
        
    }

    

    public void QuitGame(){
        Debug.Log("quit");
        Application.Quit();
    }
}
