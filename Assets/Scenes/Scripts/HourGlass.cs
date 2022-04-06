using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HourGlass : MonoBehaviour
{
    public GameObject sand;

    public int sandCount = 4000;
    public int sandPerFrame = 5;

    void Update()
    {
        if (sandCount > 0) {
            for (int i = 0; i < sandPerFrame; i++) {
            var newSand = Instantiate(sand, new Vector3(0, 0, 0), Quaternion.identity, transform);
            newSand.transform.localPosition = new Vector3(
                Random.Range(0.5f, -0.5f),
                Random.Range(0f, 1f),
                Random.Range(0f, -0.5f));
            }
            sandCount -= sandPerFrame;
        }
    }
}
