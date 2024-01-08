using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    
    public bool timeIsRunning = true;
    public float time = 0;
    public TMP_Text timer;
    
    void Update()
    {
        if (timeIsRunning)
        {
            if (time >= 0)
            {
                time += Time.deltaTime;
                DisplayTime(time);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timer.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        timeIsRunning = false;
    }
}
