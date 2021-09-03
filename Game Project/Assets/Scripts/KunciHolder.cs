using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunciHolder : MonoBehaviour
{

    private List<Kunci.KeyType> keyList;

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
        if(key != null)
        {
            AddKey(key.GetKeyType());
            Destroy(key.gameObject);
        }
        KunciPintu keyDoor = collider.GetComponent<KunciPintu>();
        if(keyDoor != null)
        {
            if (Containskey(keyDoor.GetKeyType()))
            {
                
                RemoveKey(keyDoor.GetKeyType());
                keyDoor.BUKA();
            }
        }
    }



}
