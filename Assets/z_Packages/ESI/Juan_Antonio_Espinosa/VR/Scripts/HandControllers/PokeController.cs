using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PokeController : MonoBehaviour {

    [SerializeField] private GameObject indexPoke, palmPoke;

    [SerializeField] private InputActionProperty grip;

    void Update() {
        indexPoke.SetActive(grip.action.ReadValue<float>() == 0);
        palmPoke.SetActive(grip.action.ReadValue<float>() > 0.1f);
    }
}
