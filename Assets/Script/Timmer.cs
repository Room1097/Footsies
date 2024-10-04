using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;  // Include this to manage scenes

public class GameTimer : MonoBehaviour
{
    public float startTime = 60f;  // Starting time in seconds
    private float timeRemaining;
    public Text timerText;  // UI Text to display the time

    void Start()
    {
        timeRemaining = startTime;  // Initialize time remaining
    }

    void Update()
    {
        // Decrease time remaining
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;  // Decrease by 1 second per second
            UpdateTimerUI();
        }
        else
        {
            timeRemaining = 0;
            TimerEnded();
        }
    }

    void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);  // Format time as MM:SS
    }

    void TimerEnded()
    {
        Debug.Log("Time's up! Returning to Home Screen");
        SceneManager.LoadScene("TitleScene");  // Load the home screen (replace with your scene name)
    }
}
