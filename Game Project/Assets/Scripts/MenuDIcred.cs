using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDIcred : MonoBehaviour
{

    public GameObject menu;

  

    public void LoadScene()
    {


        SceneManager.LoadScene(0);
        FindObjectOfType<AudioManager>().Stop("Credits");

        if (SceneManager.GetActiveScene().buildIndex < 1)
        {

            
            FindObjectOfType<AudioManager>().Stop("Credits");
            FindObjectOfType<AudioManager>().Play("menu");


        }
         
    }
    public void GoToMainMenu2()
    {
       
        SceneManager.LoadScene("Main Menu");
        
        FindObjectOfType<AudioManager>().Stop("Credits");
        FindObjectOfType<AudioManager>().Play("menu");
    }
}
