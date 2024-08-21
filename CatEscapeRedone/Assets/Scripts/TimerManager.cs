using System.Collections;
using System.Collections.Generic;
using UnityEditor.AppleTV;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : MonoBehaviour
{
    GameObject secTimerGo;
    GameObject millisecTimerGo;

    public float tick;
    public int countSec;
    public float countMillisec;

    void Start()
    {
        secTimerGo = GameObject.Find("secTimer");
        millisecTimerGo = GameObject.Find("millisecTimer");

        tick = 30.0f;
    }

    void Update()
    {
        CheckTime();
        DisplayTime();
    }

    void CheckTime()
    {
        this.tick -= Time.deltaTime;
        this.countSec = (int)tick;
        this.countMillisec = 100 * (tick - (int)tick);
    }

    void DisplayTime()
    {
        Text textSec = secTimerGo.GetComponent<Text>();
        textSec.text = $"{this.countSec}";

        Text textMillisec = millisecTimerGo.GetComponent<Text>();
        textMillisec.text = $".{(int)this.countMillisec:D2}";
    }
}
