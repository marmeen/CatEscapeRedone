using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    GameObject inputManagerGo;
    InputManager inputManager;

    public float radius;

    // player status
    public Vector3 playerPos;
    public int moveDirection;
    public float currentHp;
    public float maxHp;

    void Start()
    {
        inputManagerGo = GameObject.Find("InputManager");
        inputManager = inputManagerGo.GetComponent<InputManager>();

        radius = 1.0f;

        this.maxHp = 100;
        this.currentHp = this.maxHp;
    }

    void Update()
    {
        CheckPlayerPos();
        MovePlayer();
    }

    void CheckPlayerPos()
    {
        playerPos = this.gameObject.transform.position;
    }

    void MovePlayer()
    {
        if (inputManager.leftDown && playerPos.x >= -7.0f)
        {
            moveDirection = -1;
        }
        else if (inputManager.rightDown && playerPos.x <= 7.0f)
        {
            moveDirection = 1;
        }
        else
        {
            moveDirection = 0;
        }
        this.gameObject.transform.Translate(moveDirection, 0, 0);
    }
}
