using System;
using UnityEngine;

public class AnalogClock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutePivot, secondsPivot;

    void Update ()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30f * (float)time.TotalHours);
        minutePivot.localRotation = Quaternion.Euler(0, 0, -6f * (float)time.TotalMinutes);

        float seconds = (float)Math.Floor(time.TotalSeconds);

        secondsPivot.localRotation = Quaternion.Euler(0, 0, -6f * seconds);
    }
}
