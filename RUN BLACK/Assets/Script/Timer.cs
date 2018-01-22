using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Timer : MonoBehaviour {
    public Text timerLabel; //#2
    private string timerText;
    private float temp;
    public int second;
    public int minute;
    public static int s;
    public static int m;

    void Start()
    {

    }

    void Update()
    {
        temp += Time.deltaTime; //#3
        TimeSpan timeSpan = TimeSpan.FromSeconds(temp); //#4
        second = timeSpan.Seconds;
        minute = timeSpan.Minutes;
        s = second;
        m = minute;
        timerText = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds); //#5
        timerLabel.text = timerText; //#6
        if(Time.timeScale == 1){
            GameObject.Find("score").SendMessage("scorecount", 4);
        }
    }
}
