using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TUTOR : MonoBehaviour
{
    public GameObject efek;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Tutorial();
        }
    }

    void Tutorial()
    {
        Time.timeScale = 0;
        Destroy(gameObject);
    }
}
