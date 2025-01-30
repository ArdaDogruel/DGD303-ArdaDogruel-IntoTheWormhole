using UnityEngine;

namespace Wormhole
{
    public class EnemyFire : MonoBehaviour
    {
        public GameObject bulletPrefab;
        public Transform firePoint;
        public float bulletSpeed = 20f;
        public float fireRate = 1f;
        private float nextFireTime = 0f;

        void Update()
        {
            if (Time.time >= nextFireTime)
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
                bulletScript.ownerTag = "Enemy"; 
            }
            Rigidbody bulletRb = bullet.GetComponent<Rigidbody>();
            if (bulletRb != null)
            {
                bulletRb.velocity = firePoint.forward * bulletSpeed;
            }
        }
    }
}
