using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRGun : MonoBehaviour {

    [SerializeField] private Rigidbody bulletPrefab;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletSpeed = 20f;

    [SerializeField] private AmmoController ammoCtrl;

    [field: SerializeField] private bool unlimitedAmmo { get; set; }

    public void Disparar() {

        if (!unlimitedAmmo) {
            if (!ammoCtrl.isCharged || !ammoCtrl.ammoLeft)
                return;

            ammoCtrl.ReduceAmmo();
        }

        Rigidbody spawnedBullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        spawnedBullet.AddForce(bulletSpawnPoint.forward * bulletSpeed, ForceMode.Impulse);
        
        Destroy(spawnedBullet.gameObject, 3f);
    }
}
