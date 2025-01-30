using UnityEngine;

namespace Wormhole
{
    public class EnemyHealth : MonoBehaviour
    {
        public float health = 1f;
        public int scoreValue = 10;

        private ScoreManager scoreManager;

        void Start()
        {
          
            scoreManager = FindObjectOfType<ScoreManager>();
        }


        public void TakeDamage(float damage)
        {
            health -= damage; 
            if (health <= 0)
            {
                Die();
            }
        }
        void Die()
        {
            
            if (scoreManager != null)
            {
                scoreManager.AddScore(scoreValue);  
            }

            Destroy(gameObject);  
        }
    }
}

