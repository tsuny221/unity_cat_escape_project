﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }
    // void Update()
    // {
    //     //左矢印が押された時
    //     if(Input.GetKeyDown(KeyCode.LeftArrow))
    //     {
    //         transform.Translate(-3, 0, 0); //左「３」動かす
    //     }
    //     //右矢印が押された時
    //     if(Input.GetKeyDown(KeyCode.RightArrow))
    //     {
    //         transform.Translate(3, 0, 0); //右「３」動かす
    //     }
    // }
}
