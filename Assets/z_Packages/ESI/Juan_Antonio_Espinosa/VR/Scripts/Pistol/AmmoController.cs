using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AmmoController : MonoBehaviour {

    [SerializeField] public bool isCharged { get; private set; }

    [SerializeField] private XRSocketInteractor socket;
    [SerializeField] private XRGrabInteractable interactableAmmo;
    private Ammo ammo;

    [SerializeField] private int ammoCount = 12;
    [SerializeField] public bool ammoLeft { get; private set; }
	
    void Start() {
        
    }

    void Update() {
        if (isCharged && interactableAmmo != null && ammo != null) {
            ammoCount = ammo.ammoCount;

            if (ammoCount > 0) {
                ammoLeft = true;
            }
            else {
                ammoLeft = false;
            }
        }
    }

    public void Cargar() {
        isCharged = true;
        interactableAmmo = (XRGrabInteractable) socket.GetOldestInteractableSelected();
        
        if (interactableAmmo != null)
            ammo = interactableAmmo.GetComponent<Ammo>();

    }

    public void Descargar() {
        isCharged = false;
        interactableAmmo = null;
    }

    public void ReduceAmmo() {
        ammo.ReduceAmmo();
    }
}
