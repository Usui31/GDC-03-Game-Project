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
        if(SceneManager.GetActiveScene().buildIndex == 0)
        {
            
            
            FindObjectOfType<AudioManager>().Stop("Credits");
            FindObjectOfType<AudioMenu>().Stop("Credits");
            FindObjectOfType<AudioMenu>().Play("menu");
            FindObjectOfType<AudioManager>().Play("menu");
        }
        
        
    }
}
