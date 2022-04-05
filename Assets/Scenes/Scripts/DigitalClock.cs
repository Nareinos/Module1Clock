using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitalClock : MonoBehaviour
{

    public float rightDigit = 0;
    public float LeftDigit = 0;

    void Update()
    {
        rightDigit += Time.deltaTime;
        if (rightDigit > 10) {
            rightDigit = 0;
            LeftDigit += 1;
        }

        if (LeftDigit > 9) {
            LeftDigit = 0;
        }

        DrawTicks("RightDigit", (int)rightDigit);
        DrawTicks("LeftDigit", (int)LeftDigit);
    }

    void DrawTicks(string path, int number)
    {
        foreach (Renderer render in GameObject.Find(path).GetComponentsInChildren<Renderer>()) {
            render.material.color = Color.black;
        }

        if (number == 0) {
            var component = GameObject.Find(path + "/RightTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/LeftTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/LeftBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }

        else if (number == 1) {
            var component = GameObject.Find(path + "/RightTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }

        else if (number == 2) {
            var component = GameObject.Find(path + "/MiddleTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleMiddleTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/LeftBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }

        else if (number == 3) {
            var component = GameObject.Find(path + "/RightTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleMiddleTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }

        else if (number == 4) {
            var component = GameObject.Find(path + "/LeftTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleMiddleTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }
        
        else if (number == 5) {
            var component = GameObject.Find(path + "/MiddleTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/LeftTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleMiddleTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }

        else if (number == 6) {
            var component = GameObject.Find(path + "/MiddleMiddleTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/LeftTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/LeftBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }

        else if (number == 7) {
            var component = GameObject.Find(path + "/RightTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }

        else if (number == 8) {
            var component = GameObject.Find(path + "/MiddleMiddleTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/LeftTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/LeftBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }

        else if (number == 9) {
            var component = GameObject.Find(path + "/MiddleMiddleTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/LeftTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleTopTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/RightBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;

            component = GameObject.Find(path + "/MiddleBottomTick").GetComponent<Renderer>();
            component.material.color = Color.red;
        }
    }
}
