using UnityEngine;
using UnityEngine.SceneManagement;

namespace Wormhole
{
    public class GameOverManager : MonoBehaviour
    {
        public GameObject gameOverPanel; 
        private bool isGameOver = false;

        public void GameOver()
        {
            if (isGameOver) return; 

            isGameOver = true;
            gameOverPanel.SetActive(true); 
            Time.timeScale = 0f; 
        }

        public void RestartGame()
        {
            Time.timeScale = 1f; 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); 
        }

        public void GoToMainMenu()
        {
            Time.timeScale = 1f; 
            SceneManager.LoadScene(0); 
        }

        public void QuitGame()
        {
            Application.Quit(); 
        }
    }
}
