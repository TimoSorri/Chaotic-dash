using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour
{
    float currentTime = 0;
    float startingTime = 0;
    [SerializeField] Text countdownText;
    void Start()
    {
        currentTime += startingTime;  
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("00:00");

        if (currentTime <= 0)
        {
            currentTime = 0;
        }
    }
}
