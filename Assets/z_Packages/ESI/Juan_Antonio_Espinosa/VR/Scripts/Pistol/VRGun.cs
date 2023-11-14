using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRGun : MonoBehaviour {

    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletSpeed = 20f;

    [SerializeField] private AmmoController ammoCtrl;
	
    void Start() {
        
    }

    void Update() {
        
    }

    public void Disparar() {

        if (!ammoCtrl.isCharged || !ammoCtrl.ammoLeft)
            return;

        ammoCtrl.ReduceAmmo();

        GameObject spawnedBullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        spawnedBullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
        
        Destroy(spawnedBullet, 3f);
    }
}
