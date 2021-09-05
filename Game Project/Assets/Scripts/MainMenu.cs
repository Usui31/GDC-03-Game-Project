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
       /* if (Menu == true && Game == false && credits == false)
        {
            FindObjectOfType<AudioMenu>().Play("menu");
            if (Menu == false && Game == true && credits == false)
            {
                FindObjectOfType<AudioManager>().Play("Theme");
                if (Menu == false && Game == false && credits == true)
                {
                    FindObjectOfType<AudioMenu>().Play("credits");
                }
                else
                {
                    FindObjectOfType<AudioMenu>().Stop("credits");
                }
            }
            else
            {
                FindObjectOfType<AudioMenu>().Stop("credits");
            }
        }
        else
        {
            FindObjectOfType<AudioMenu>().Stop("menu");
        }*/
            
        
        
    }
    public void PlayGame(){
        SceneManager.LoadScene("Game Scene");
        FindObjectOfType<AudioMenu>().Stop("menu");
        FindObjectOfType<AudioManager>().Stop("Credits");
        FindObjectOfType<AudioManager>().Play("Theme");
        Menu = false;
        Game = true;
        credits = false;

        
    }

    public void CreditsGame()
    {
        SceneManager.LoadScene("FINISH");
        FindObjectOfType<AudioManager>().Stop("menu");
        FindObjectOfType<AudioMenu>().Stop("menu");
        FindObjectOfType<AudioManager>().Play("Credits");
        Menu = false;
        Game = false;
        credits = true;
    }

    

    public void QuitGame(){
        Debug.Log("quit");
        Application.Quit();
    }
}
