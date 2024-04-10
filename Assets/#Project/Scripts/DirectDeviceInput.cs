using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DirectDeviceInput : MonoBehaviour {
    public Vector3 speedV = new Vector3(0f, 0f, 0f);

    public Vector3 accelerationV = new Vector3(0f, 0f, 0f);

    public float speed = 1;
    public float acceleration = 1;



    // Update is called once per frame
    void Update() {
        Keyboard keyboard = Keyboard.current;
        speedV *= 1 - Time.deltaTime;
        CorrectSmall();
        if (keyboard != null) {
            if (keyboard.wKey.isPressed) {
                speedV.z += acceleration * Time.deltaTime;
            }
            if (keyboard.sKey.isPressed) {
                speedV.z -= acceleration * Time.deltaTime;
            }
            if (keyboard.aKey.isPressed) {
                speedV.x -= acceleration * Time.deltaTime;
            }
            if (keyboard.dKey.isPressed) {
                speedV.x += acceleration * Time.deltaTime;
            }
        }
        transform.Translate(speed * speedV * Time.deltaTime);
    }

    void CorrectSmall() {
        if (speedV.x < 0.01f && speedV.x > -0.01f) {
            speedV.x = 0f;
        }
        if (speedV.z < 0.01f && speedV.z > -0.01f) {
            speedV.z = 0f;
        }
        if (speedV.z < 0.01f && speedV.z > -0.01f) {
            speedV.z = 0f;
        }
    }

}
