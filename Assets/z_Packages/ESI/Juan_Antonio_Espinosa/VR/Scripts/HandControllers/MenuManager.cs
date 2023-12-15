using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MenuManager : MonoBehaviour {

    [SerializeField] private GameObject handCanvas;
    [SerializeField] private InputActionProperty menuButton;
    [SerializeField] private InputActionProperty simulatorMenuButton;

    void Update() {
        if (menuButton.action.WasPressedThisFrame() || simulatorMenuButton.action.WasPressedThisFrame()) {
            handCanvas.SetActive(!handCanvas.activeSelf);
        }
    }

    public void StartGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void Restart() {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void Exit() {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
