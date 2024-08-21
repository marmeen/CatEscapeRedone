using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public bool leftDown;
    public bool rightDown;

    void Start()
    {

    }

    void Update()
    {
        UpdateKeyDown();
    }

    void UpdateKeyDown()
    {
        this.leftDown = Input.GetKeyDown(KeyCode.LeftArrow);
        this.rightDown = Input.GetKeyDown(KeyCode.RightArrow);
    }
}
