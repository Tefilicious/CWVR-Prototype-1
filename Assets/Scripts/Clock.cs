using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Transform hourHand, minuteHand, secondsHand;

    private const float secondsRotation = 6f, minutesRotation = 6f, hourRotation = 3f;

    // Update is called once per frame
    void Update()
    {
        // Timespan is a C# struct that can store date and time
        TimeSpan time = DateTime.Now.TimeOfDay;
        hourHand.rotation = Quaternion.Euler(hourRotation * (float) time.TotalHours, 0f, -90f);
        minuteHand.rotation = Quaternion.Euler(minutesRotation * (float)time.TotalMinutes, 0f, -90f);
        secondsHand.rotation = Quaternion.Euler(secondsRotation * (float)time.TotalSeconds, 0f, -90f);
    }
}
