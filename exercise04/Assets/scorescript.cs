using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }

    public void ResetScore()
    {
        score = 0;
        scoreText.text = "Score: " + score;
    }

    void Start()
    {
        scoreText.text = "Score: " + score;
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("Score", score);
    }

    void Awake()
    {
        score = PlayerPrefs.GetInt("Score", 0);
    }
}
