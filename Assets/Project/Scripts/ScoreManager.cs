using UnityEngine;
using TMPro;  

namespace Wormhole
{
    public class ScoreManager : MonoBehaviour
    {
        public int score = 0;  
        public TextMeshProUGUI scoreText;  

        void Start()
        {
            UpdateScoreUI();  
        }

        public void AddScore(int points)
        {
            score += points;  
            UpdateScoreUI();  
        }

        void UpdateScoreUI()
        {
            if (scoreText != null)
            {
                scoreText.text = "Score: " + score.ToString();  
            }
        }
    }
}
