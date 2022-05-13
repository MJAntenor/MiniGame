using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public static Timer Instance;
    public TextMeshProUGUI timerText;
    private float currentTime;
    private string minutes;
    private string seconds;

    public void Awake()
    {
        Instance = this;
    }

    public void Start()
    {
        currentTime = 0;
    }

    void Update()
    {
        currentTime += Time.deltaTime;
        minutes = Mathf.Floor((currentTime % 3600) / 60).ToString("00");
        seconds = (currentTime % 60).ToString("00");
        timerText.text = "Time: " + minutes + ":" + seconds;
    }
    
    public string Minutes()
    {
        return minutes;
    }

    public string Seconds()
    {
        return seconds;
    }
}
