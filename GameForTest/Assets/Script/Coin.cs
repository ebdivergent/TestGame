﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    public int coinValueNow = 1;
    public int coinNow;
    
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(20 * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag ("bullet"))
        {
            Score.instance.ChangeScore(coinValue);
            Score.instance.NowCoins(coinValue);
            FindObjectOfType<SoundManager>().Play("coin");
        }
    }
}
