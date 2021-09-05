using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenghitungItem : MonoBehaviour
{
    public Text countKunci;
    public float kunci = 0;
    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("key"))
        {

            kunci += 1;
            countKunci.text = kunci.ToString();
            Destroy(other.gameObject);



        }
    }
}
