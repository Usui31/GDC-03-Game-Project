using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KunciHolder : MonoBehaviour
{

    private List<Kunci.KeyType> keyList;
    public int count= 0;
    public Text hitung;




    private void Awake()
    {
        keyList = new List<Kunci.KeyType>();
    }

    public void AddKey(Kunci.KeyType keyType)
    {
        Debug.Log("Added Key: " + keyType);
        keyList.Add(keyType);
    }

    public void RemoveKey(Kunci.KeyType keyType)
    {
        keyList.Remove(keyType);
    }

    public bool Containskey(Kunci.KeyType keyType)
    {
        return keyList.Contains(keyType);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Kunci key = collider.GetComponent<Kunci>();
        if (key != null)
        {
            
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
            count += 1;
            Debug.Log("count = "+ count);
            hitung.text = count.ToString();
        }
        KunciPintu keyDoor = collider.GetComponent<KunciPintu>();
        if (keyDoor != null)
        {
            if (Containskey(keyDoor.GetKeyType()) && count == 4)
            {

                RemoveKey(keyDoor.GetKeyType());
                keyDoor.BUKA();
            }
        }
    }



    
}
