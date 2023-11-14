using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour {

    [SerializeField] public int ammoCount { get; private set; } = 12;

    public void ReduceAmmo() {
        ammoCount--;
        Debug.Log($"Ammo: {ammoCount}");
    }

    public void ReloadAmmo() {
        ammoCount = 12;
    }
}
