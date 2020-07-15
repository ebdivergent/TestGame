﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiScaler : MonoBehaviour
{
    public float resoX;
    public float resoY;

    private CanvasScaler can;
    
    void Start()
    {
        can=GetComponent<CanvasScaler>();
        SetInfo();
    }

    void SetInfo()
    {
        resoX = (float)Screen.currentResolution.width;
        resoY = (float)Screen.currentResolution.height;
        can.referenceResolution = new Vector2(resoX, resoY);
    }

    void Update()
    {
       
    }
}
