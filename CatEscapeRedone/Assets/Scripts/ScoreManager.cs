using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    GameObject scoreCounterGo;
    public float score;

    void Start()
    {
        scoreCounterGo = GameObject.Find("scoreCounter");
        this.score = 0;
    }

    void Update()
    {
        CheckScore();
        DisplayScore();
    }

    void CheckScore()
    {
        this.score += Time.deltaTime * 1000;
    }

    void DisplayScore()
    {
        Text text = scoreCounterGo.GetComponent<Text>();
        text.text = $"SCORE {(int)this.score:D5}";
    }
}
