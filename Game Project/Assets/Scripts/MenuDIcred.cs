using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuDIcred : MonoBehaviour
{

    public GameObject menu;


    public void LoadScene(string scenename)
    {
        

        SceneManager.LoadScene(scenename);
        if(scenename == "Main Menu")
        {
            
            
            FindObjectOfType<AudioManager>().Stop("Credits");
            FindObjectOfType<AudioMenu>().Play("menu");
        }
        
        
    }
}
