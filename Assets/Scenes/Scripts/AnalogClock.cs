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
        float remainer = Mathf.Lerp(0, 1, Mathf.Atan((float)time.TotalSeconds - seconds) * 20);

        secondsPivot.localRotation = Quaternion.Euler(0, 0, -6f * (seconds + remainer));
    }
}
