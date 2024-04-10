using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Flag : MonoBehaviour {
    [SerializeField]
    private Flag nextFlag;
    [SerializeField]
    private bool toDeactivate = false;
    private void Awake() {
        if (nextFlag is not null) {
            nextFlag.toDeactivate = true;
        }
    }
    private void Start() {
        if (toDeactivate) {
            gameObject.SetActive(false);
            toDeactivate = false;
        }
    }
    private void OnTriggerEnter(Collider other) {
        Debug.Log($"{other.gameObject.name} entered {name}");
        if (other.CompareTag("Player")) {
            if (nextFlag is not null) {
                nextFlag.gameObject.SetActive(true);
                gameObject.SetActive(false);
            } else {
                SceneManager.LoadScene("StartingScreen");
            }

        }
    }
}
