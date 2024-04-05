using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    [SerializeField]
    private Flag nextFlag;
    private void Start()
    {
        if(nextFlag is not null) { 
        nextFlag.gameObject.SetActive(false);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{other.gameObject.name} entered {name}");
        if(other.CompareTag("Player")) { 
           if(nextFlag is not null)
            {
                nextFlag.gameObject.SetActive(true);
                gameObject.SetActive(false);
            }

        }
    }
}
