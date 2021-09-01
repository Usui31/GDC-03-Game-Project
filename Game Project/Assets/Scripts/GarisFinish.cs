using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarisFinish : MonoBehaviour
{

    public GameObject EndGame;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("finish"))
        {
            
        }
    }
}
