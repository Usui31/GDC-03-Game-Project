using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class congratsKeFinish : MonoBehaviour
{
   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GoFinish();
        }
    }

    void GoFinish()
    {
        SceneManager.LoadScene("FINISH");
        FindObjectOfType<AudioManager>().Stop("Congrats");
        FindObjectOfType<AudioManager>().Play("Credits");
    }
}
