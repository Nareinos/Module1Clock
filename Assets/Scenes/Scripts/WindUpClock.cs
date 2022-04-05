using System;
using UnityEngine;

public class WindUpClock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutePivot, secondsPivot;

    public float windTime = 1;

    DateTime time = DateTime.Now;


    void Update()
    {
        if (windTime > 0) {
            time = time.AddSeconds(Time.deltaTime);
            hoursPivot.localRotation = Quaternion.Euler(0, 0, -30f * (float)time.TimeOfDay.TotalHours);
            minutePivot.localRotation = Quaternion.Euler(0, 0, -6f * (float)time.TimeOfDay.TotalMinutes);
            secondsPivot.localRotation = Quaternion.Euler(0, 0, -6f * (float)Math.Floor(time.TimeOfDay.TotalSeconds));
        }

        windTime = Math.Max(0, windTime - Time.deltaTime);
    }
}
