using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static Score instance;
    public TextMeshProUGUI text;
    int coins;
    // Start is called before the first frame update
    void Start()
    {
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
