using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputEvents : MonoBehaviour {
    public float speed = 1f;
    private Vector2 movementV = Vector2.zero;
    public void HandleMovement(InputAction.CallbackContext ctx) {
        if(ctx.performed) {
            movementV = speed * ctx.ReadValue<Vector2>();
        } else if (ctx.canceled){
            movementV = Vector2.zero;
        }
    }
    public void OnShoot(InputAction.CallbackContext ctx) {
        if (ctx.started) {
            Debug.Log("shoot pressed by " + gameObject.name);
        }
    }

    void Update() {
        transform.Translate(movementV.x * Time.deltaTime, 0, movementV.y * Time.deltaTime);
    }
}
