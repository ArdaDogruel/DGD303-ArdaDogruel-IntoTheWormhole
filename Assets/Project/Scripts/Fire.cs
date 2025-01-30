using UnityEngine;

namespace Wormhole
{
    public class Fire : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public Transform firePoint;
        public float bulletSpeed = 20f;
        public float fireRate = 0.2f;
        private float nextFireTime = 0f;

        void Update()
        {
            if (Time.time >= nextFireTime && Input.GetKey(KeyCode.Space))
            {
                Shoot();
                nextFireTime = Time.time + fireRate;
            }
        }

        void Shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Bullet bulletScript = bullet.GetComponent<Bullet>();
            if (bulletScript != null)
            {
                bulletScript.ownerTag = "Player"; 
            }
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            if (bulletRb != null)
            {
                bulletRb.velocity = firePoint.forward * bulletSpeed;
            }
        }
    }
}
