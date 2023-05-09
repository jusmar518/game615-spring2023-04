using System;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public Text countdownText;
    private float currentTime = 60f;
    

    private void Update()
    {
        currentTime -= Time.deltaTime;
        int seconds = Mathf.FloorToInt(currentTime % 60);
        countdownText.text = seconds.ToString();

        if (currentTime <= 0)
        {
            currentTime = 0;
            Debug.Log("Time's up!");
        }
    }
}


