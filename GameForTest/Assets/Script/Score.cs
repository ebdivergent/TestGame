using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public static Score instance;
    public Text bank;
    public Text coinGet;
    public int coins;
    public int coinsNow;
   
    
    void Start()
    {

        coins = PlayerPrefs.GetInt("coins");
        bank.text = coins.ToString();
        if (instance == null)
        {
            instance = this;
        }


    }


    public void ChangeScore(int coinValue)
    {
        coins += coinValue;
        PlayerPrefs.SetInt("coins", coins);

    }
    public void NowCoins(int coinValue)
    {
        coinsNow += coinValue;
        coinGet.text = coinsNow.ToString();
    }
 

    
}
