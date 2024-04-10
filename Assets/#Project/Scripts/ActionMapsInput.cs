using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActionMapsInput : MonoBehaviour {

    public InputActionAsset inputActions;
    public float speed = 1f;
    private InputAction move, shoot;
    // Start is called before the first frame update
    void Start() {
        move = inputActions.FindActionMap("Player").FindAction("Move");
        shoot = inputActions.FindActionMap("Player").FindAction("Shoot");
        shoot.performed += ctx => { OnShoot(ctx); }; 
    }

    // Update is called once per frame
    void Update() {
        Vector2 movementV = speed * move.ReadValue<Vector2>();
        transform.Translate(movementV.x * Time.deltaTime, 0, movementV.y * Time.deltaTime);
    }
    private void OnShoot(InputAction.CallbackContext ctx) {
        Debug.Log("shoot pressed by " + gameObject.name);
    }

}
