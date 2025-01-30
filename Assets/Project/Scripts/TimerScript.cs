using UnityEngine;
using TMPro;

namespace Wormhole
{
    public class TimerScript : MonoBehaviour
    {
        public TextMeshProUGUI timerText;  
        private float timeElapsed = 0f;   

        void Update()
        {
            timeElapsed += Time.deltaTime;

            UpdateTimerUI();
        }

        void UpdateTimerUI()
        {
   
            int minutes = Mathf.FloorToInt(timeElapsed / 60);
            int seconds = Mathf.FloorToInt(timeElapsed % 60);
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}
