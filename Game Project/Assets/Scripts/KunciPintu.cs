using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KunciPintu : MonoBehaviour
{
    [SerializeField] private Kunci.KeyType keyType;

    public Kunci.KeyType GetKeyType()
    {
        return keyType;

    }

    public void BUKA()
    {
        gameObject.SetActive(false);
    }
}
