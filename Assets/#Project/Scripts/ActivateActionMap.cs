using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateActionMap : MonoBehaviour {
    public InputActionAsset actions;
    public string[] actionMapsToEnnable;
    public void OnEnable() {
        foreach (string actionMap in actionMapsToEnnable) {
            actions.FindActionMap(actionMap).Enable();
        }
    }
    public void OnDisable() {
        foreach (string actionMap in actionMapsToEnnable) {
            actions.FindActionMap(actionMap).Disable();
        }
    }
}
