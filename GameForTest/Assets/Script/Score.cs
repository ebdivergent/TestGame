using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    
    public static Score instance;
    public TextMeshProUGUI text;
    public int coins;
    
    //public int coinValue;
    // Start is called before the first frame update
    void Start()
    {
        //if(SceneManager.GetActiveScene().buildIndex == 2)
        
        //    coinValue = PlayerPrefs.GetInt("Score");
        
        
        if(instance == null)
        {
            instance = this;
        }
        
    }

    public void ChangeScore(int coinValue)
    {
        coins += coinValue;
        text.text = ":" + coins.ToString();
    }
}
