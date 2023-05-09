using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeLimit = 60.0f; // Set the time limit to 60 seconds
    public GameObject player; // Reference to the player object
    public GameObject[] collectibles; // Array of all collectible objects

    private float timeRemaining;
    private Text timerText;

    void Start()
    {
        timeRemaining = timeLimit;
        timerText = GetComponent<Text>();
    }

    void Update()
    {
        if (timeRemaining > 0.0f)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            Destroy(player);
            DisplayLoseMessage();
        }

        if (AllCollectiblesCollected())
        {
            Destroy(player);
            DisplayWinMessage();
        }
    }

    bool AllCollectiblesCollected()
    {
        foreach (GameObject collectible in collectibles)
        {
            if (collectible.activeInHierarchy)
            {
                return false;
            }
        }
        return true;
    }

    void UpdateTimerText()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60.0f);
        int seconds = Mathf.FloorToInt(timeRemaining % 60.0f);
        string timeString = string.Format("{0:00}:{1:00}", minutes, seconds);
        timerText.text = "Time: " + timeString;
    }

    void DisplayWinMessage()
    {
        Debug.Log("You win! :)");
    }

    void DisplayLoseMessage()
    {
        Debug.Log("You lose. :(");
    }
}

