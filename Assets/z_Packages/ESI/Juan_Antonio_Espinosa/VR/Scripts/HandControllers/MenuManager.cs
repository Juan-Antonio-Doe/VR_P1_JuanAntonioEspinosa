using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour {

    [SerializeField] private GameObject handCanvas;
    [SerializeField] private InputActionProperty menuButton;

    void Update() {
        if (menuButton.action.WasPressedThisFrame()) {
            handCanvas.SetActive(!handCanvas.activeSelf);
        }
    }
}
