using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject playerGo;
    PlayerController playerController;

    GameObject hpGaugeGo;
    Image hpGauge;

    void Start()
    {
        playerGo = GameObject.Find("player");
        playerController = playerGo.GetComponent<PlayerController>();

        hpGaugeGo = GameObject.Find("hpGauge(front)");
        hpGauge = hpGaugeGo.GetComponent<Image>();
    }

    void Update()
    {
        UpdateHpGauge();
    }
    void UpdateHpGauge()
    {
        hpGauge.fillAmount = this.playerController.currentHp / this.playerController.maxHp;
    }
}
