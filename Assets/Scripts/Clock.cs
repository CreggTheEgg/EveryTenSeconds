using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clock : MonoBehaviour
{
    
    public bool clockOn = false;

    public TMP_Text ClockText;
    public float startTime = 0f;

    void Start()
    {
        clockOn = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (clockOn)
        {
            startTime += Time.deltaTime;
            updateClock(startTime);
        }
    }

    void updateClock(float currentTime) 
    {
        currentTime += 1;

        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        ClockText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }
}
