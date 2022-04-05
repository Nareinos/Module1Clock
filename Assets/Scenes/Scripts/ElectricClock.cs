using System;
using UnityEngine;

public class ElectricClock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutePivot, secondsPivot;

    void Update ()
    {
        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0, 0, -30f * (float)time.TotalHours);
        minutePivot.localRotation = Quaternion.Euler(0, 0, -6f * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, -6f * (float)time.TotalSeconds);
    }
}
