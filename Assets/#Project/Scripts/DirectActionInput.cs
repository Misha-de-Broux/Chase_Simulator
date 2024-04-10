using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DirectActionInput : MonoBehaviour {
    public InputAction move, shoot;
    public int speed = 1;
    public void Awake() {
        shoot.performed += ctx => { OnShoot(ctx); };
    }
    private void OnEnable() {
        move.Enable();
        shoot.Enable();
    }
    private void OnDisable() {
        move.Disable();
        shoot.Disable();
    }
    private void Update() {
        Vector2 movementV = move.ReadValue<Vector2>();
        float movementX = Mathf.Clamp(movementV.x, -1, 1);
        float movementZ = Mathf.Clamp(movementV.y, -1, 1);
        transform.Translate(speed * movementX * Time.deltaTime, 0, speed * movementZ * Time.deltaTime);
    }

    private void OnShoot(InputAction.CallbackContext ctx) {
        Debug.Log("shoot pressed by " + gameObject.name);
    }
}
