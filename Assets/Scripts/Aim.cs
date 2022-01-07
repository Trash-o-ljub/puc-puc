using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public Rigidbody bulletPrefab;
    public Transform bulletSpawnPosition;
    Rigidbody cloneBullet;

    void Update()
    {
        transform.LookAt(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
        void Fire()
        {
            cloneBullet = Instantiate(bulletPrefab, bulletSpawnPosition.position, bulletSpawnPosition.rotation);
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            cloneBullet.velocity = 100 * ray.direction;
        }
    }
}
