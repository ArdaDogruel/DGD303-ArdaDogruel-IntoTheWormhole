using UnityEngine;

namespace Wormhole
{
    public class Bullet : MonoBehaviour
    {
        public float speed = 20f;
        public float lifetime = 5f;
        private Rigidbody rb;

        public float damage = 1f; 
        public string ownerTag; 

        void Start()
        {
            rb = GetComponent<Rigidbody>();
            Destroy(gameObject, lifetime);  
        }

        void Update()
        {
            if (rb != null)
            {
                rb.velocity = -transform.up * speed;  
            }
        }

        
        private void OnCollisionEnter(Collision collision)
        {
            
            Debug.Log("Çarpýþma ile karþýlaþýldý: " + collision.gameObject.name);

            
            if (ownerTag == "Player" && collision.gameObject.CompareTag("Enemy"))
            {
                
                collision.gameObject.GetComponent<EnemyHealth>().TakeDamage(damage);
                Destroy(gameObject); 
            }
            
            else if (ownerTag == "Enemy" && collision.gameObject.CompareTag("Player"))
            {
                
                collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
                Destroy(gameObject); 
            }
            
            else if (collision.gameObject.CompareTag("Bullet"))
            {
                Destroy(gameObject); 
            }
        }
    }
}
