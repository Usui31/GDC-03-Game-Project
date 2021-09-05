using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static bool Menu= true;
    public static bool Game = false;
    public static bool credits = false;


    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex <= 0)
        {
            FindObjectOfType<AudioMenu>().Stop("Credits");
            FindObjectOfType<AudioMenu>().Play("menu");
            
        }
           
        else
        {
            FindObjectOfType<AudioMenu>().Stop("menu");
        }
            
        
        
    }
    public void PlayGame(){
        SceneManager.LoadScene("Game Scene");
        FindObjectOfType<AudioMenu>().Stop("menu");
        FindObjectOfType<AudioMenu>().Stop("Credits");
        FindObjectOfType<AudioManager>().Play("Theme");
        Menu = false;
        Game = true;
        credits = false;

        
    }

    public void CreditsGame()
    {
        SceneManager.LoadScene("FINISH");
        
        FindObjectOfType<AudioMenu>().Stop("menu");
        FindObjectOfType<AudioMenu>().Play("Credits");
        Menu = false;
        Game = false;
        credits = true;
    }

    

    public void QuitGame(){
        Debug.Log("quit");
        Application.Quit();
    }
}
