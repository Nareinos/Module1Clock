using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handle : MonoBehaviour
{
    public WindUpClock windUpClock;

    private float turning_timer = 0;

    void OnMouseDown ()
    {
        windUpClock.windTime += 5;
        turning_timer += 1;
    }

    void Update ()
    {
        if (turning_timer > 0) {
            turning_timer -= Time.deltaTime;

            transform.Rotate(0, 5, 0);
        }
    }
}
