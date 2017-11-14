using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPSScript : MonoBehaviour {

    public Text fpsNumText;
    float fps = 0.0f;

    int frameCount = 0;
    float timeCount = 0.0f;
    float lastFramerate = 0.0f;
    public float refreshRate = 0.5f;

    void Update()
    {
        if(timeCount < refreshRate)
        {
            timeCount += Time.unscaledDeltaTime;
            frameCount++;
        }
        else
        {
            lastFramerate = (float)frameCount / timeCount;
            frameCount = 0;
            timeCount = 0.0f;
            fpsNumText.text = lastFramerate.ToString("0.00");
        }
    }
}
