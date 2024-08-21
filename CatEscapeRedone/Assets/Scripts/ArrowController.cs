using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : ArrowGenerator
{
    GameObject playerGo;
    PlayerController playerController;

    void Start()
    {
        playerGo = GameObject.Find("player");
        playerController = playerGo.GetComponent<PlayerController>();
    }

    void Update()
    {
        CheckArrowPos();
        MoveArrow();
        DestroyArrow();
    }

    void CheckArrowPos()
    {
        arrowPos = this.gameObject.transform.position;
    }

    void MoveArrow()
    {
        this.gameObject.transform.Translate(0, this.arrowSpeed * this.arrowDirection, 0);
    }

    void DestroyArrow()
    {
        float calRadius = this.radius + playerController.radius;
        float distance = Vector3.Distance(this.arrowPos, playerController.playerPos);
        float groundPos = -4.4f;

        if (arrowPos.y < groundPos)
        {
            Destroy(this.gameObject);
        }

        if (distance < calRadius)
        {
            Destroy(this.gameObject);
            AttackPlayer();
        }

    }
    void AttackPlayer()
    {
        this.playerController.currentHp -= (int)this.arrowDamage;
        Debug.Log($"데미지: {this.arrowDamage}, 체력: {(int)this.playerController.currentHp}/{(int)this.playerController.maxHp}");
    }
}
