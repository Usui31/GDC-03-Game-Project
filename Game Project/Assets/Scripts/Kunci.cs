using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kunci : MonoBehaviour
{
    [SerializeField] private KeyType keyType;
    public enum KeyType {
        key1,
        key2,
        key3
    }

    public KeyType GetKeyType()
    {
        return keyType;
    }
}
