using UnityEngine;
using TMPro;  

namespace Wormhole
{
    public class PlayerHealth : MonoBehaviour
    {
        public float health = 10f;        
        public float maxHealth = 10f;     
        public TextMeshProUGUI healthText;
        public GameOverManager gameOverManager;

        void Start()
        {
            
            UpdateHealthUI();
        }

        public void TakeDamage(float damage)
        {
            health -= damage; 
            if (health < 0) health = 0;  

            
            UpdateHealthUI();

            
            if (health <= 0)
            {
                gameOverManager.GameOver();
                Destroy(gameObject);  
            }
        }

        void UpdateHealthUI()
        {
            if (healthText != null)
            {
                healthText.text = "Health: " + health.ToString();  
            }
        }
    }
}
