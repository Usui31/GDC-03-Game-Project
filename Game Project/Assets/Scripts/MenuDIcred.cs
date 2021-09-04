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
        FindObjectOfType<AudioManager>().Stop("Credits");
        FindObjectOfType<AudioManager>().Play("menu");
    }
}
